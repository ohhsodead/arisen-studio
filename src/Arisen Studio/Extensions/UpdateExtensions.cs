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
using ArisenStudio.Models.Database;

namespace ArisenStudio.Extensions
{
    public abstract class UpdateExtensions
    {
        /// <summary>
        /// Check if there is a new update available found on startup.
        /// </summary>
        public static bool IsUpdateAvailable { get; set; } = false;

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
        /// Get download stats from GitHub.
        /// </summary>
        public static StatsData StatsData { get; set; } = GetDownloadStats();

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
        /// Get download stats from GitHub.
        /// </summary>
        /// <returns> </returns>
        public static StatsData GetDownloadStats()
        {
            using StreamReader streamReader = new(HttpExtensions.GetStream(Urls.StatsData));
            return JsonConvert.DeserializeObject<StatsData>(streamReader.ReadToEnd());
        }

        /// <summary>
        /// Check the current application version against the latest version in GitHub Releases. 
        /// If there's an update then download and update the new files.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            MainWindow.Window.SetStatus("Checking for new updates...");
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            AutoUpdater.SetOwner(MainWindow.Window);
            AutoUpdater.HttpUserAgent = "Arisen Studio Auto Updater";
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.Icon = Properties.Resources.arisenstudio;
            AutoUpdater.ReportErrors = true;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.Start(Urls.UpdateData);
        }

        public static UpdateInfoEventArgs updateInfo;

        /// <summary>
        /// Check for a new available update and downloads whether on the update conditions.
        /// </summary>
        /// <param name="args"></param>
        private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            updateInfo = args;

            if (args.Error == null)
            {
                if (args.IsUpdateAvailable)
                {
                    IsUpdateAvailable = args.IsUpdateAvailable;
                    updateInfo = args;
                    MainWindow.Window.UpdateAvailable(args.IsUpdateAvailable);
                    MainWindow.Window.SetStatus($"A new update is available: ({AllReleases[0].Name})");
                    DialogResult dialogResult;
                    if (args.Mandatory.Value)
                    {
                        dialogResult =
                            XtraMessageBox.Show(MainWindow.Window,
                            $"A new version of Arisen Studio is available: {AllReleases[0].Name}. " +
                            $"This update is required and includes important fixes and improvements. You need to install it to keep using the app.\n\n" +
                            $"Update will begin downloading when you click OK.",
                            @"Update Available",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        UpdateApplication();
                    }
                    else
                    {
                        dialogResult =
                            XtraMessageBox.Show(MainWindow.Window,
                            $"A new version of Arisen Studio is available: {AllReleases[0].Name}\n\n" +
                            $"Would you like to download and install it now?",
                            @"Update Available",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                    }

                    // Uncomment the following line if you want to show standard update dialog instead.
                    // AutoUpdater.ShowUpdateForm(args);

                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            if (AutoUpdater.DownloadUpdate(args))
                            {
                                Application.Exit();
                            }
                        }
                        catch (Exception ex)
                        {
                            MainWindow.Window.SetStatus($"Unable to download new version at the moment. Error: {ex.Message}", ex);
                            _ = XtraMessageBox.Show(MainWindow.Window, $@"There is a problem reaching update server. " +
                                "Please check your internet connection and try again later.\n\nError: {ex.Message}",
                                @"Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MainWindow.Window.SetStatus($"You're currently using the latest version of Arisen Studio ({CurrentVersionName})");
                }
            }
            else
            {
                if (args.Error is WebException)
                {
                    MainWindow.Window.SetStatus($"Unable to check application version at this current time. Error: {args.Error.Message}", args.Error);
                    _ = XtraMessageBox.Show(MainWindow.Window, @"There is a problem reaching update server. " +
                        "Please check your internet connection and try again later.",
                        @"Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainWindow.Window.SetStatus($"Unable to check application for a new version. Arisen Studio will try agian later." +
                        $"Error Message: {args.Error.Message}", args.Error);
                    _ = XtraMessageBox.Show(MainWindow.Window, args.Error.Message,
                        args.Error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Close the app, then download and install the new update.
        /// </summary>
        public static void UpdateApplication()
        {
            var args = updateInfo;

            switch (args.Error)
            {
                case null when args.IsUpdateAvailable:
                    try
                    {
                        MainWindow.Settings.FirstTimeOpenAfterUpdate = true;
                        IsUpdateAvailable = args.IsUpdateAvailable;
                        updateInfo = args;
                        MainWindow.Window.SetStatus($"A new update is available: ({AllReleases[0].Name})");

                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = XtraMessageBox.Show(MainWindow.Window, ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case WebException:
                    MainWindow.Window.SetStatus($"Unable to download new version at the moment. Error: {args.Error.Message}", args.Error);
                    _ = XtraMessageBox.Show(MainWindow.Window, @"There is a problem reaching update server. " +
                        "Please check your internet connection and try again later.",
                        @"Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MainWindow.Window.SetStatus($"Unable to check for a new application version at the moment." +
                        $" Error: {args.Error.Message}", args.Error);
                    _ = XtraMessageBox.Show(MainWindow.Window,
                        args.Error.Message,
                        args.Error.GetType().ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}