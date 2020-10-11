using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms;
using ModioX.Models.Release_Data;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class UpdateExtensions
    {
        /// <summary>
        ///     Retrieves the current application version.
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        ///     Retrieves the latest release data.
        /// </summary>
        public static GitHubData GitHubData { get; } = GetGitHubReleaseData();

        /// <summary>
        ///     Direct web API for this projects data on GitHub with the latest release information.
        /// </summary>
        internal const string GitHubRelease = "https://api.github.com/repos/ohhsodead/ModioX/releases/latest";

        /// <summary>
        ///     Retrieves the latest release information from the GitHub API.
        /// </summary>
        /// <returns></returns>
        public static GitHubData GetGitHubReleaseData()
        {
            GitHubData GitHubReleaseData;

            using (StreamReader streamReader = new StreamReader(HttpExtensions.GetStream(GitHubRelease)))
            {
                GitHubReleaseData = JsonConvert.DeserializeObject<GitHubData>(streamReader.ReadToEnd());
            }

            return GitHubReleaseData;
        }

        /// <summary>
        ///     Checks the current application version against the latest version hosted on GitHub.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                MainWindow.mainForm.SetStatus($"Checking for new updates...");

                Version latestVersion = new Version(GitHubData.TagName);

                if (CurrentVersion.CompareTo(latestVersion) < 0)
                {
                    RunInstaller(latestVersion);
                }
                else
                {
                    MainWindow.mainForm.SetStatus($"ModioX is running the latest update (Beta v{CurrentVersion.ToString().Remove(0, 2)})");
                }
            }
            catch (Exception ex)
            {
                MainWindow.mainForm.SetStatus($"Unable to update - {ex.Message}", ex);
                Application.Exit();
            }
        }

        /// <summary>
        ///     Downloads the new version installer from GitHub releases to the users downloads folder, closes the application and runs the installer
        /// </summary>
        /// <param name="newVersion">Newest update version</param>
        private static void RunInstaller(Version newVersion)
        {
            try
            {
                MainWindow.SettingsData.FirstTimeOpenAfterUpdate = true;
                MainWindow.mainForm.SetStatus("A new update is available - Starting to download the installer...");
                _ = DarkMessageBox.Show(MainWindow.mainForm, $@"This version of ModioX is now outdated. An update (v{newVersion}) has been released on GitHub. Click OK to download and run the installer.", @"New Update Available", MessageBoxIcon.Information);
                Program.WebClient.DownloadFile(GitHubData.Assets[0].BrowserDownloadUrl, $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}");
                _ = Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MainWindow.mainForm.SetStatus($"There was an issue running the installer: {ex.Message})", ex);
                _ = DarkMessageBox.Show(MainWindow.mainForm, @"Unable to update. You must manually install the latest available update from the GitHub releases page.", "Error", MessageBoxIcon.Error);
                _ = Process.Start($"{Utilities.GitHubRepo}releases/latest");
                Application.Exit();
            }
        }
    }
}