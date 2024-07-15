using AutoUpdaterDotNET;
using DevExpress.XtraEditors;
using ArisenStudio.Constants;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Release_Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using ArisenStudio.Models.Dashboard;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArisenStudio.Extensions
{
    public abstract class UpdateExtensions
    {
        /// <summary>
        /// Get the application current version.
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// Get the current version name.
        /// </summary>
        public static string CurrentVersionName { get; } = $"Beta v{CurrentVersion.ToString().TrimStart('0', '.')}";

        /// <summary>
        /// Get all release data from GitHub.
        /// </summary>
        public static List<GitHubReleaseData> AllReleases { get; set; } = GetAllReleasesData();

        /// <summary>
        /// Get all release information from the GitHub API.
        /// </summary>
        /// <returns> </returns>
        public static List<GitHubReleaseData> GetAllReleasesData()
        {
            using StreamReader streamReader = new(HttpExtensions.GetStream(Urls.GitHubReleases));
            return JsonConvert.DeserializeObject<List<GitHubReleaseData>>(streamReader.ReadToEnd());
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            switch (args.Error)
            {
                case null when args.IsUpdateAvailable:
                    MainWindow.Settings.FirstTimeOpenAfterUpdate = true;
                    MainWindow.Window.SetStatus("A new update is available. Downloading installer...");
                    XtraMessageBox.Show(MainWindow.Window, $"There is a new version available ({AllReleases[0].Name})", @"Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    break;
                case null:
                    MainWindow.Window.SetStatus($"You're currently using the latest version of Arisen Studio ({CurrentVersionName})");
                    break;
                case WebException:
                    MainWindow.Window.SetStatus($"Unable to check application version at this current time. Error: {args.Error.Message}", args.Error);
                    XtraMessageBox.Show(MainWindow.Window, @"There is a problem reaching update server. Please check your internet connection and try again later.", @"Update Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MainWindow.Window.SetStatus($"Unable to check application for a new version. Error Message: {args.Error.Message}", args.Error);
                    XtraMessageBox.Show(MainWindow.Window, args.Error.Message, args.Error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}