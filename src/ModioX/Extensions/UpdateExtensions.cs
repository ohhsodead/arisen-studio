using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using DevExpress.XtraEditors;
using ModioX.Constants;
using ModioX.Forms.Windows;
using ModioX.Models.Release_Data;
using Newtonsoft.Json;

namespace ModioX.Extensions
{
    public abstract class UpdateExtensions
    {
        /// <summary>
        /// Get the latest release data from GitHub.
        /// </summary>
        public static GitHubData GitHubData { get; set; } = GetLatestReleaseData();

        /// <summary>
        /// Get the application current version.
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// Get the current version name.
        /// </summary>
        public static string CurrentVersionName { get; } = $"Beta v{CurrentVersion.ToString().TrimStart('0', '.')}";

        /// <summary>
        /// Get the latest release information from the GitHub API.
        /// </summary>
        /// <returns> </returns>
        public static GitHubData GetLatestReleaseData()
        {
            GitHubData gitHubLatestReleaseData;

            using (StreamReader streamReader = new(HttpExtensions.GetStream(Urls.GitHubLatestRelease)))
            {
                gitHubLatestReleaseData = JsonConvert.DeserializeObject<GitHubData>(streamReader.ReadToEnd());
            }

            return gitHubLatestReleaseData;
        }

        /// <summary>
        /// Check the current application version against the latest version hosted on GitHub. If
        /// this version is outdated, then download and run the latest version installer.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            MainWindow.Window.SetStatus("Checking application for new updates...");
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Mandatory = true;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.UpdateMode = Mode.ForcedDownload;
            AutoUpdater.Start(Urls.UpdateData);
        }

        private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.Error == null)
            {
                if (args.IsUpdateAvailable)
                {
                    MainWindow.Settings.FirstTimeOpenAfterUpdate = true;
                    MainWindow.Window.SetStatus("A new update is available. Downloading the installer...");
                    XtraMessageBox.Show(MainWindow.Window, $"There is a new version of ModioX ({GitHubData.Name}) available.", @"Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(MainWindow.Window, ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MainWindow.Window.SetStatus($"You're currently using the latest version of ModioX ({CurrentVersionName})");
                }
            }
            else
            {
                if (args.Error is WebException)
                {
                    MainWindow.Window.SetStatus($"Unable to check application version at this current time. Error: {args.Error.Message}", args.Error);

                    XtraMessageBox.Show(MainWindow.Window,
                        @"There is a problem reaching update server. Please check your internet connection and try again later.",
                        @"Update Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainWindow.Window.SetStatus($"Unable to check application for a new version. Error Message: {args.Error.Message}", args.Error);

                    XtraMessageBox.Show(MainWindow.Window, args.Error.Message, args.Error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}