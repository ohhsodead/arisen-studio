using DevExpress.XtraEditors;
using ModioX.Constants;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Release_Data;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    public abstract class UpdateExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly WebClient WebClient = new();

        /// <summary>
        /// Get the latest release data from GitHub.
        /// </summary>
        public static GitHubData GitHubData { get; } = GetGitHubLatestReleaseData();

        /// <summary>
        /// Get the current application version.
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// Get the current application version name.
        /// </summary>
        public static string CurrentVersionName { get; } = $"Beta v{CurrentVersion.ToString().TrimEnd('0', '.')}";

        /// <summary>
        /// Get the latest release information from the GitHub API.
        /// </summary>
        /// <returns></returns>
        public static GitHubData GetGitHubLatestReleaseData()
        {
            GitHubData gitHubLatestReleaseData;

            using (StreamReader streamReader = new StreamReader(HttpExtensions.GetStream(Urls.GitHubLatestRelease)))
            {
                gitHubLatestReleaseData = JsonConvert.DeserializeObject<GitHubData>(streamReader.ReadToEnd());
            }

            return gitHubLatestReleaseData;
        }

        /// <summary>
        /// Check the current application version against the latest version hosted on GitHub. If this version is outdated,
        /// then download and run the latest version installer.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                MainWindow.Window.SetStatus("Checking application for new updates...");

                Version latestVersion = new Version(GitHubData.TagName);

                if (CurrentVersion < latestVersion)
                {
                    DownloadAndRunInstaller();
                }
                else
                {
                    MainWindow.Window.SetStatus($"You're currently using the latest version of ModioX ({GitHubData.Name})");
                }
            }
            catch (Exception ex)
            {
                MainWindow.Window.SetStatus($"Unable to check application version at this current time. Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Download the latest installer from GitHub to the user's downloads folder, run the program and close this instance
        /// of the application.
        /// </summary>
        private static void DownloadAndRunInstaller()
        {
            try
            {
                string installerFile = $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}";

                MainWindow.Settings.FirstTimeOpenAfterUpdate = true;
                MainWindow.Window.SetStatus("A new update is available. Downloading the installer...");
                XtraMessageBox.Show($"A new version of ModioX ({GitHubData.Name}) is now available. Click OK to download and run the installer.", @"Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WebClient.DownloadFile(GitHubData.Assets[0].BrowserDownloadUrl, installerFile);
                Process.Start(installerFile);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MainWindow.Window.SetStatus($"Unable to download or run the installer. Error: {ex.Message})", ex);
                XtraMessageBox.Show("Unable to complete the update. You must manually install the latest available update from the GitHub releases page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start($"{Urls.GitHubRepo}releases/latest");
                Application.Exit();
            }
        }
    }
}