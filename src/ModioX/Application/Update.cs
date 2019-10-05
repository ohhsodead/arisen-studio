using ModioX.Extensions;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModioX.Application
{
    internal static class Update
    {
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// Check application for update. Installs the latest installer and runs the file before closing this instance
        /// </summary>
        public static void CheckVersion()
        {
            try
            {
                Program.Log.Info("Checking application for update...");

                using (StreamReader sr = new StreamReader(HttpExtensions.GetStream(Utilities.ProjectVersionUrl)))
                {
                    Version newVersion = new Version(sr.ReadToEnd());
                    if (CurrentVersion.CompareTo(newVersion) < 0)
                    {
                        RunInstaller(newVersion);
                    }
                    else
                    {
                        Program.Log.InfoFormat("Application is running latest available update (Version: {0})", newVersion);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.Log.Info("Failed to update : " + ex.Message, ex);
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// Downloads the newest update installer from GitHub and runs it for the user
        /// </summary>
        /// <param name="newVersion">Newest version installer to run</param>
        private static void RunInstaller(Version newVersion)
        {
            try
            {
                Program.Log.Info(@"New update available - Starting to download the installer...");
                DarkUI.Forms.DarkMessageBox.Show(MainForm.mainForm, $@"This version of ModioX is now outdated. An update (v{newVersion}) has been released on GitHub. Click OK to download and run the installer.", @"Update Available");
                Program.WebClient.DownloadFile($"{Utilities.ProjectRepoUrl}releases/download/{newVersion}/ModioX.Installer.Windows.exe", $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\ModioX.Installer.Windows.exe.exe");
                Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\ModioX.Installer.Windows.exe.exe");
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was a problem starting the update installer : " + ex.Message, ex);
                DarkUI.Forms.DarkMessageBox.Show(MainForm.mainForm, @"There was an issue. You will need to manually install the latest available update from the GitHub releases page.", "Error");
                Process.Start($"{Utilities.ProjectRepoUrl}releases/latest");
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}