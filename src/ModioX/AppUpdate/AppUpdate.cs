using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms;
using ModioX.Windows;
using System;
using System.Diagnostics;
using System.IO;
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
        ///     Checks the current application version against the version hosted via dropbox text file.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                MainForm.mainForm.SetStatus($"Checking for a new update...");
                Program.Log.Info("Checking for a new update...");

                using (StreamReader streamReader = new StreamReader(HttpExtensions.GetStream(Utilities.ProjectVersionUrl)))
                {
                    Version newVersion = new Version(streamReader.ReadToEnd());

                    if (CurrentVersion.CompareTo(newVersion) < 0)
                    {
                        RunInstaller(newVersion);
                    }
                    else
                    {
                        MainForm.mainForm.SetStatus($"ModioX is running latest available update (Beta v{newVersion.ToString().Remove(0, 2)})");
                        Program.Log.InfoFormat($"ModioX is running latest available update (Beta v{newVersion.ToString().Remove(0, 2)})");
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.mainForm.SetStatus($"Failed to update. Message : {ex.Message}");
                Program.Log.Info("Failed to update. Message : {ex.Message}", ex);
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
                MainForm.mainForm.SetStatus("New update available - Starting to download the installed...");
                Program.Log.Info("New update available - Starting to download the installer...");
                DarkMessageBox.Show(MainForm.mainForm, $@"This version of ModioX is now outdated. An update (v{newVersion}) has been released on GitHub. Click OK to download and run the installer.", @"Update Available", MessageBoxIcon.Information);
                Program.WebClient.DownloadFile($"{Utilities.ProjectRepoUrl}releases/download/{newVersion}/ModioX.Installer.Windows.exe", $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\ModioX.Installer.Windows.exe");
                Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\ModioX.Installer.Windows.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MainForm.mainForm.SetStatus($"There was a problem starting the update installer : {ex.Message})");
                Program.Log.Error($"There was a problem starting the update installer : {ex.Message}", ex);
                DarkMessageBox.Show(MainForm.mainForm, @"There was an issue. You will need to manually install the latest available update from the GitHub releases page.", "Error", MessageBoxIcon.Error);
                Process.Start($"{Utilities.ProjectRepoUrl}releases/latest");
                Application.Exit();
            }
        }
    }
}