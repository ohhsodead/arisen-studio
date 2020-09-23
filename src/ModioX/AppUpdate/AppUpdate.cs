using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms;
using ModioX.Models.Release_Data;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ModioX.AppUpdate
{
    internal static class AppUpdate
    {
        /// <summary>
        ///     
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        ///     
        /// </summary>
        public static GitHubData GitHubData { get; } = Utilities.GetGitHubReleaseData();

        /// <summary>
        ///     Checks the current application version against the version hosted via dropbox text file.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                MainForm.mainForm.SetStatus($"Checking for a new update...");

                Version newVersion = new Version(GitHubData.TagName);

                if (CurrentVersion.CompareTo(newVersion) < 0)
                {
                    RunInstaller(newVersion);
                }
                else
                {
                    MainForm.mainForm.SetStatus($"ModioX is running the latest update (Beta v{CurrentVersion.ToString().Remove(0, 2)})");
                }
            }
            catch (Exception ex)
            {
                MainForm.mainForm.SetStatus($"Unable to update - {ex.Message}", ex);
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
                MainForm.SettingsData.FirstTimeOpenAfterUpdate = true;
                MainForm.mainForm.SetStatus("A new update is available - Starting to download the installer...");
                _ = DarkMessageBox.Show(MainForm.mainForm, $@"This version of ModioX is now outdated. An update (v{newVersion}) has been released on GitHub. Click OK to download and run the installer.", @"New Update Available", MessageBoxIcon.Information);
                Program.WebClient.DownloadFile(GitHubData.Assets[0].BrowserDownloadUrl, $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}");
                _ = Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MainForm.mainForm.SetStatus($"There was an issue running the installer: {ex.Message})", ex);
                _ = DarkMessageBox.Show(MainForm.mainForm, @"Unable to update. You must manually install the latest available update from the GitHub releases page.", "Error", MessageBoxIcon.Error);
                _ = Process.Start($"{Utilities.GitHubRepo}releases/latest");
                Application.Exit();
            }
        }
    }
}