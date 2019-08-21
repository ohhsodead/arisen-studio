using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class Update
    {
        /// <summary>
        /// Check application for update. Installs the latest installer and runs the file before closing this instance
        /// </summary>
        public static void CheckVersion()
        {
            try
            {
                Program.LogMessage("Checking application for update...");
                using (StreamReader sr = new StreamReader(HttpExtensions.GetStream(Utilities.ProjectVersionUrl)))
                {
                    Version newVersion = new Version(sr.ReadToEnd());
                    Version curVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    if (curVersion.CompareTo(newVersion) < 0)
                        RunInstaller(newVersion);
                    else
                        Program.LogMessage(string.Format("Application running latest update. Version: {0}", newVersion));
                }
            }
            catch (Exception ex)
            {
                Program.LogMessage("Update failed: " + ex.Message);
                Application.Exit();
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
                Program.LogMessage(@"New update available - Beginning to download the installer");
                MessageBox.Show($@"ModioX v{newVersion} is now available. Click OK to run the installer.", @"ModioX - Update Available");
                Program.WebClient.DownloadFile($"{Utilities.ProjectRepoUrl}releases/download/{newVersion}/ModioX.Installer.Windows.exe", $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\ModioX.Installer.Windows.exe.exe");
                Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\ModioX.Installer.Windows.exe.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Program.LogMessage("Update failed: " + ex);
                MessageBox.Show(@"There was an issue. You will need to manually install the latest available update from GitHub.");
                Process.Start($"{Utilities.ProjectRepoUrl}releases/latest");
                Application.Exit();
            }
        }
    }
}
