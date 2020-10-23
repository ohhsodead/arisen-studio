using DarkUI.Forms;
using ModioX.Constants;
using ModioX.Forms;
using ModioX.Io;
using ModioX.Models.Release_Data;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    public abstract class UpdateExtensions
    {
        /// <summary>
        ///     Get the current application version.
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        ///     Get the current application version name.
        /// </summary>
        public static string CurrentVersionName { get; } = $"Beta v{CurrentVersion.ToString().Remove(0, 2)}";

        /// <summary>
        ///     Get the latest release data from GitHub.
        /// </summary>
        public static GitHubData GitHubData { get; } = GetGitHubLatestReleaseData();

        /// <summary>
        ///     Get the latest release information from the GitHub API.
        /// </summary>
        /// <returns></returns>
        public static GitHubData GetGitHubLatestReleaseData()
        {
            GitHubData GitHubLatestReleaseData;

            using (StreamReader streamReader = new StreamReader(HttpExtensions.GetStream(Urls.GitHubLatestRelease)))
            {
                GitHubLatestReleaseData = JsonConvert.DeserializeObject<GitHubData>(streamReader.ReadToEnd());
            }

            return GitHubLatestReleaseData;
        }

        /// <summary>
        ///     Check the current application version against the latest version hosted on GitHub. If this version is outdated,
        ///     then download and run the latest version installer.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                MainWindow.mainWindow.SetStatus($"Checking application for new update...");

                Version latestVersion = new Version(GitHubData.TagName);

                if (CurrentVersion.CompareTo(latestVersion) < 0)
                {
                    DownloadAndRunInstaller();
                }
                else
                {
                    MainWindow.mainWindow.SetStatus($"You're currently using the latest version of ModioX ({GitHubData.Name})");
                }
            }
            catch (Exception ex)
            {
                MainWindow.mainWindow.SetStatus($"Unable to check application version at this current time. Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        ///     Download the latest installer from GitHub to the user's downloads folder, run the program and close this instance of the application.
        /// </summary>
        private static void DownloadAndRunInstaller()
        {
            try
            {
                string installerFile = $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}";

                MainWindow.SettingsData.FirstTimeOpenAfterUpdate = true;
                MainWindow.mainWindow.SetStatus("A new update is available. Downloading the installer...");
                _ = DarkMessageBox.Show(MainWindow.mainWindow, $@"A new version of ModioX ({GitHubData.Name}) is now available. Click OK to download and run the installer.", @"Update Available", MessageBoxIcon.Information);
                Program.WebClient.DownloadFile(GitHubData.Assets[0].BrowserDownloadUrl, installerFile);
                _ = Process.Start(installerFile);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MainWindow.mainWindow.SetStatus($"Unable to download or run the installer. Error: {ex.Message})", ex);
                _ = DarkMessageBox.Show(MainWindow.mainWindow, @"Unable to complete the update. You must manually install the latest available update from the GitHub releases page.", "Error", MessageBoxIcon.Error);
                _ = Process.Start($"{Urls.GitHubRepo}releases/latest");
                Application.Exit();
            }
        }
    }
}