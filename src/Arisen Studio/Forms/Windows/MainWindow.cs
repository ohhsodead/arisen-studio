using CodeHollow.FeedReader;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using DiscordRPC;
using FluentFTP;
using Humanizer;
using Microsoft.VisualBasic.FileIO;
using ArisenStudio.Constants;
using ArisenStudio.Controls;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Io;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Release_Data;
using ArisenStudio.Models.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkit;
using FtpExtensions = ArisenStudio.Extensions.FtpExtensions;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using JRPC_Client;
using FluentFTP.Exceptions;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using DevExpress.XtraCharts;

namespace ArisenStudio.Forms.Windows
{
    public partial class MainWindow : RibbonForm
    {
        /// <summary>
        /// Initialize application.
        /// </summary>
        public MainWindow()
        {
            Window = this;
            InitializeComponent();
            SkinColors = CommonSkins.GetSkin(LookAndFeel).Colors;
        }

        /// <summary>
        /// Get/get the current language resources.
        /// </summary>
        public static ResourceManager ResourceLanguage { get; set; } = new ResourceManager("ArisenStudio.Languages.en_US", Assembly.GetExecutingAssembly());

        /// <summary>
        /// Get the instance of this form.
        /// </summary>
        public static MainWindow Window { get; private set; }

        /// <summary>
        /// Get the user's settings.
        /// </summary>
        public static SettingsData Settings { get; private set; } = new();

        /// <summary>
        /// Get the users backup files details.
        /// </summary>
        public static BackupFilesData BackupFiles { get; private set; } = new();

        /// <summary>
        /// Get the data from the database files.
        /// </summary>
        public static GitHubData Database { get; private set; }

        /// <summary>
        /// Get the current console profile data.
        /// </summary>
        public static ConsoleProfile ConsoleProfile { get; private set; }

        /// <summary>
        /// Get whether a console is currently connected.
        /// </summary>
        public static bool IsConsoleConnected { get; private set; } = false;

        /// <summary>
        /// Get the current console type.
        /// </summary>
        public static Platform Platform { get; private set; }

        /// <summary>
        /// Set the current console type.
        /// </summary>
        public void SetPlatform(Platform value)
        {
            Platform = value;

#if !DEBUG
            EnableConsoleActions();
#endif
        }

        /// <summary>
        /// Return the Xbox console functions.
        /// </summary>
        public static IXboxManager XboxManager { get; private set; }

        /// <summary>
        /// Return the Xbox console functions.
        /// </summary>
        public static IXboxConsole XboxConsole { get; private set; }

        /// <summary>
        /// Return the FTP client for faster and more reliable functions.
        /// </summary>
        public static FtpClient FtpClient { get; private set; }

        /// <summary>
        /// Return whether webMAN is installed on the console.
        /// </summary>
        public static bool IsWebManInstalled { get; private set; }

        /// <summary>
        /// Get the colors for the current skin.
        /// </summary>
        public static SkinColors SkinColors { get; private set; }

        public OverlayWindowOptions splashScreenOptions = new(
            opacity: 1,
            fadeIn: false,
            fadeOut: true,
            disableInput: true,
            animationType: WaitAnimationType.Line,
            trackOwnerBounds: true);

        public PanelControl overlayBackground;

        private IOverlaySplashScreenHandle ShowSplashScreenProgress()
        {
            overlayBackground = new() { BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, Size = Window.WindowState == FormWindowState.Maximized ? new Size(Window.Size.Width - 0, Window.Size.Height - 10) : new Size(Window.Size.Width + 40, Window.Size.Height - 28), Location = new Point(-0, 36), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom };
            Controls.Add(overlayBackground);
            return SplashScreenManager.ShowOverlayForm(overlayBackground, splashScreenOptions);
            //return SplashScreenManager.ShowOverlayForm(this, splashScreenOptions);
        }

        private void CloseSplashScreenProgress(IOverlaySplashScreenHandle handleProgressPanel)
        {
            if (handleProgressPanel != null)
            {
                SplashScreenManager.CloseOverlayForm(handleProgressPanel);
                Controls.Remove(overlayBackground);
            }
        }

        private IOverlaySplashScreenHandle handleSplashScreenProgress = null;

        /// <summary>
        /// Form loading event.
        /// </summary>
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.StyleChanged += MainWindow_StyleChanged;
            WindowsFormsSettings.AllowHoverAnimation = DefaultBoolean.True;

            Text = $@"Arisen Studio [{UpdateExtensions.CurrentVersionName}]";

            LoadApplicationSettings();

            WindowState = Settings.WindowState;

            handleSplashScreenProgress = ShowSplashScreenProgress();

            if (HttpExtensions.CheckForInternetConnection())
            {
                Program.Log.Info("Internet connection detected.");

                UpdateExtensions.CheckApplicationVersion();

                if (Settings.FirstTimeOpenAfterUpdate)
                {
                    Settings.FirstTimeOpenAfterUpdate = false;
                    DialogExtensions.ShowWhatsNewDialog(this, UpdateExtensions.AllReleases[0]);
                }

                SetStatus(ResourceLanguage.GetString("INITIALIZING_APP_DB") + "...");
                await Task.Run(LoadDataAsync);
                InitializeFinished();
            }
            else
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("NO_INTERNET_CONNECTION"), ResourceLanguage.GetString("NO_INTERNET_CONNECTION_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetStatus(ResourceLanguage.GetString("NO_INTERNET_CONNECTION_TITLE"));
                Application.Exit();
            }
        }

        /// <summary>
        /// Save application settings, and if console is connected then closes connections.
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Environment.Exit(0);
            }

            if (WindowState == FormWindowState.Normal | WindowState == FormWindowState.Minimized)
            {
                Settings.WindowState = FormWindowState.Normal;
            }
            else
            {
                Settings.WindowState = FormWindowState.Maximized;
            }

            SaveApplicationSettings();

            if (DiscordClient != null)
            {
                if (!DiscordClient.IsInitialized)
                {
                    if (!DiscordClient.IsDisposed)
                    {
                        DiscordClient.ClearPresence();
                        DiscordClient.Deinitialize();
                        DiscordClient.Dispose();
                    }
                }
            }

            if (IsConsoleConnected)
            {
                try
                {
                    if (!TextBoxFileManagerLocalPath.Text.IsNullOrWhiteSpace())
                    {
                        switch (ConsoleProfile.Platform)
                        {
                            case Platform.PS3:
                                Settings.LocalPathPS3 = TextBoxFileManagerLocalPath.Text;
                                break;
                            case Platform.PS4:
                                Settings.LocalPathPS3 = TextBoxFileManagerLocalPath.Text;
                                break;
                            case Platform.XBOX360:
                                Settings.LocalPathXbox = TextBoxFileManagerLocalPath.Text;
                                break;
                        }
                    }

                    if (!TextBoxFileManagerConsolePath.Text.IsNullOrWhiteSpace())
                    {
                        switch (ConsoleProfile.Platform)
                        {
                            case Platform.PS3:
                                Settings.ConsolePathPS3 = TextBoxFileManagerConsolePath.Text;
                                break;
                            case Platform.PS4:
                                Settings.ConsolePathPS3 = TextBoxFileManagerConsolePath.Text;
                                break;
                            case Platform.XBOX360:
                                Settings.ConsolePathXbox = TextBoxFileManagerConsolePath.Text;
                                break;
                        }
                    }

                    switch (ConsoleProfile.Platform)
                    {
                        case Platform.PS3:
                            FtpClient.Dispose();
                            break;
                        case Platform.PS4:
                            //FtpClient.Dispose();
                            break;
                        case Platform.XBOX360:
                            XboxConsole.CloseConnection(0);
                            break;
                    }
                }
                catch
                {
                    // false positive; the console is probably be powered off
                }
            }

            SaveApplicationSettings();
        }

        private void MainWindow_StyleChanged(object sender, EventArgs e)
        {
            SkinColors = CommonSkins.GetSkin(LookAndFeel).Colors;
            UpdateControlColors();
        }

        /// <summary>
        /// Retrieve the categories and mods database.
        /// </summary>
        private static async Task LoadDataAsync()
        {
            try
            {
                Database = await GitHubData.InitializeAsync();//.ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"{ResourceLanguage.GetString("UNABLE_LOAD_DATABASE")} {ResourceLanguage.GetString("ERROR")}: {ex.Message}");
                Application.Exit();
            }
        }

        /// <summary>
        /// Finalize application after being initialized.
        /// </summary>
        private void InitializeFinished()
        {
            if (Settings.Language != "English")
            {
                ChangeLanguage(Settings.Language);
            }

            SetStatus(ResourceLanguage.GetString("SUCCESS_LOADED_DB"));

            foreach (string firmwareType in Database.GameModsPS3.AllFirmwareTypes.Where(firmwareType => !ComboBoxGameModsPS3FilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxGameModsPS3FilterSystemType.Properties.Items.Add(firmwareType);
            }

            foreach (string firmwareType in Database.HomebrewPS3.AllFirmwareTypes.Where(firmwareType => !ComboBoxHomebrewFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxHomebrewFilterSystemType.Properties.Items.Add(firmwareType);
            }

            foreach (string firmwareType in Database.ResourcesPS3.AllFirmwareTypes.Where(firmwareType => !ComboBoxResourcesFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxResourcesFilterSystemType.Properties.Items.Add(firmwareType);
            }

            SetStatus($"{ResourceLanguage.GetString("INITIALIZED")} Arisen Studio ({UpdateExtensions.CurrentVersionName}) - {ResourceLanguage.GetString("READY_TO_CONNECT")}");

            if (Settings.FirstTimeUse)
            {
                DialogExtensions.ShowSetupWizardDialog(this);
                Settings.FirstTimeUse = false;

                if (Settings.ConsoleProfiles.Count == 0)
                {
                    Platform platform = DialogExtensions.ShowPlatformList(this, true);
                    Settings.ConsoleProfiles.Add(Settings.CreateDefaultProfile(platform));
                }
            }
            else if (Settings.ConsoleProfiles.Count == 0)
            {
                DialogExtensions.ShowSetupWizardDialog(this);
            }

            SetConsoleProfile();

            // Dashboard tab
            LoadAnnouncements();
            LoadCurrentPoll();
            LoadStatistics();
            LoadChangeLog();
            LoadNewsFeed();

            // Downloads tab
            LoadDownloads();

            // Installed Mods tab
            LoadInstalledMods();

            // Settings tab
            LoadLanguages();
            LoadSettings();

            SetAboutInfo();

            PageDashboard.AutoScroll = true;

            UpdateControlColors();
            Focus();

            NavigationMenu.SelectElement(NavigationItemDashboard);

            EnableConsoleActions();

            BannerAdDashboard.ShowAd(802, 134, "33krwjd74qn6");

            CloseSplashScreenProgress(handleSplashScreenProgress);

#if !DEBUG
            if (ConsoleProfile.Platform == Platform.PS3)
            {
                NavigationItemGameMods.Visible = true;
                NavigationItemHomebrew.Visible = true;
                NavigationItemPackages.Visible = true;
                NavigationItemResources.Visible = true;
                NavigationItemApplications.Visible = false;
                NavigationItemGames.Visible = false;
            }
            else if (ConsoleProfile.Platform == Platform.PS4)
            {
                NavigationItemGameMods.Visible = false;
                NavigationItemHomebrew.Visible = false;
                NavigationItemPackages.Visible = false;
                NavigationItemResources.Visible = false;
                NavigationItemApplications.Visible = true;
                NavigationItemGames.Visible = true;
            }
            else if (ConsoleProfile.Platform == Platform.XBOX360)
            {
                NavigationItemGameMods.Visible = true;
                NavigationItemHomebrew.Visible = true;
                NavigationItemPackages.Visible = false;
                NavigationItemResources.Visible = false;
                NavigationItemApplications.Visible = false;
                NavigationItemGames.Visible = false;
            }
#endif
        }

        private void SetConsoleProfile()
        {
            if (Settings.ConsoleProfiles.Count() == 0)
            {
                ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false, true);

                if (consoleProfile != null)
                {
                    consoleProfile.IsDefault = true;
                    Settings.ConsoleProfiles.Add(consoleProfile);
                    SetStatusConsole(consoleProfile);
                    return;
                }
                else
                {
                    SetConsoleProfile();
                }
            }

            ConsoleProfile defaultProfile = Settings.GetDefaultProfile();

            if (defaultProfile == null)
            {
                XtraMessageBox.Show(this, "You must create and have one console profile set as default.", ResourceLanguage.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogExtensions.ShowEditConnectionsDialog(this, true);

                SetConsoleProfile();
            }

            SetStatusConsole(defaultProfile);
        }

        private void UpdateControlColors()
        {
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.AccordionControl, LookAndFeel, "Item");
            element.ContentMargins.Top = 10;
            element.ContentMargins.Bottom = 10;
            element.ContentMargins.Left = 16;
        }

        private IOverlaySplashScreenHandle handleOverlayFeatureNotAvailable = null;

        private IOverlaySplashScreenHandle ShowOverlayFeatureNotAvailable(NavigationPage page, string message)
        {
            page.Enabled = false;
            return SplashScreenManager.ShowOverlayForm(page, customPainter: new FeatureNotAvailableOverlay(message));
        }

        private void CloseOverlayFeatureNotAvailable(NavigationPage page, IOverlaySplashScreenHandle handle)
        {
            if (handle != null)
            {
                page.Enabled = true;
                SplashScreenManager.CloseOverlayForm(handle);
            }
        }

        #region Ribbon Page

        // Connection

        private void ButtonConnectConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (IsConsoleConnected)
            {
                case true:
                    ConnectConsole();
                    break;
                default:
                    {
                        ConnectConsole();

                        break;
                    }
            }
        }

        private void ButtonDisconnectConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (IsConsoleConnected)
            {
                case true:
                    DisconnectConsole();
                    break;
                default:
                    {
                        DisconnectConsole();

                        break;
                    }
            }
        }

        private void ButtonChangeProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConsoleProfile consoleProfile = DialogExtensions.ShowConnectionsDialog(this);

            if (consoleProfile != null)
            {
                if (ConsoleProfile != consoleProfile && IsConsoleConnected)
                {
                    DisconnectConsole();
                }

                SetStatusConsole(consoleProfile);
            }
        }

        private void ButtonAddNewProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
            }
        }

        private void ButtonScanXboxConsoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus(ResourceLanguage.GetString("SCANNING_XBOX_CONSOLES"));

            try
            {
                int count = 0;

                foreach (var consoleProfile in XboxExtensions.ScanForConsoles(this))
                {
                    Settings.ConsoleProfiles.Add(consoleProfile);
                    count++;
                }

                XtraMessageBox.Show(this, $"A total of {count} consoles were added to your profiles.", ResourceLanguage.GetString("XBOX_CONSOLES"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Unable to scan for Xbox consoles.", ex);
                XtraMessageBox.Show(this, $"Unable to scan for Xbox consoles.\n\nError: {ex.Message}", ResourceLanguage.GetString("XBOX_CONSOLES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetStatus(ResourceLanguage.GetString("SCANNING_XBOX_FINISHED"));
        }

        private void ButtonEditConsoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowEditConnectionsDialog(this, true);
        }

        private void ButtonHowToGuides_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(this, "Our How-To-Guides have been moved to our website at https://arisen.studio/guide\n\nWould you like to open the link in your browser?.", "How-To Guides", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(Urls.ProjectWebsite);
            }
        }

        private void ButtonSetupWizard_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowSetupWizardDialog(this);
        }

        private void ButtonDownloadsFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetDownloadsLocation();
        }

        private void ButtonDiscordPresence_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            NavigationMenu.SelectElement(NavigationItemSettings);
            NavigationFrame.SelectedPage = PageSettings;
            TabControlSettings.SelectedPage = TabPageDiscord;
        }

        private void ButtonInstallModsToUSB_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            NavigationMenu.SelectElement(NavigationItemSettings);
            NavigationFrame.SelectedPage = PageSettings;
            TabControlSettings.SelectedPage = TabPageTransfer;
        }

        private void ButtonAdvancedSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            NavigationMenu.SelectElement(NavigationItemSettings);
            NavigationFrame.SelectedPage = PageSettings;
        }

        // Help

        private void ButtonAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            NavigationMenu.SelectedElement = null;
            NavigationFrame.SelectedPage = PageAbout;
        }

        private void ButtonOpenLogFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Opening Log file...");

            string logFile = $"{UserFolders.Logs}latest.log";

            if (File.Exists(logFile))
            {
                try
                {
                    Process.Start(logFile);
                }
                catch (Exception ex)
                {
                    SetStatus("Failed to open Log file...", ex);
                    XtraMessageBox.Show(this, "Failed to open the log file.\nIt may have been deleted, that's ok.", $"{ResourceLanguage.GetString("ERROR")}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SetStatus("Failed to find Log file...");
                XtraMessageBox.Show(this, "Failed to find the log file.\nIt may have been deleted, that's ok.", "No Log File.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonOpenLogFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Opening Log folder...");

            if (!Directory.Exists(UserFolders.Logs))
            {
                Directory.CreateDirectory(UserFolders.Logs);
            }

            Process.Start(UserFolders.Logs);
        }

        private void ButtonRequestMods_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Process.Start(Urls.RequestModsForm);
            DialogExtensions.ShowRequestModsDialog(this);
        }

        private void ButtonSendFeedback_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start($"{Urls.GitHubRepo}issues/new/choose");
        }

        // Modding Tools

        private void ButtonToolsPsGameUpdates_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameUpdatesFinder(this);
        }

        private void ButtonToolsPsBackupFilesManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameBackupFileManager(this);
        }

        private void ButtonToolsPsPackageManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowPackageManager(this);
        }

        private void ButtonToolsPsConsoleManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowPs3ConsoleManager(this);
        }

        private void ButtonToolsPsGameRegions_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameRegionsDialog(this);
        }

        private void ButtonToolsPsBootPluginsEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowBootPluginsEditor(this);
        }

        private void ButtonToolsXboxGameSaveResigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxGameSaveResigner(this);
        }

        private void ButtonToolsXboxHDKey_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxHDKey(this);
        }

        private void ButtonToolsXboxGamesLauncher_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxGameLauncher(this);
        }

        private void ButtonToolsXboxModuleLoader_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxModuleLoader(this);
        }

        private void ButtonToolsXboxXuidSpoofer_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxXuidGameSpoofer(this);
        }

        private void ButtonToolsXboxDashlaunchEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxDashlaunchEditor(this);
        }

        private void ButtonToolsPsPowerShutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Shutting Down Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Shutdown);
            SetStatus("webMAN Commands - Successfully Shutdown Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Restarting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Restart);
            SetStatus("webMAN Commands - Successfully Restarted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerSoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Soft Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.SoftReboot);
            SetStatus("webMAN Commands - Successfully Soft Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerHardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Hard Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.HardReboot);
            SetStatus("webMAN Commands - Successfully Hard Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerQuickReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Quick Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.QuickReboot);
            SetStatus("webMAN Commands - Successfully Quick Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsGamesOpenGUI_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Opening Game Launcher...");
            //WebManExtensions.OpenGamesGUI(ConsoleProfile.Address);
            var gameLauncher = new Tools.PS3.GameLauncher();
            gameLauncher.ShowDialog(this);
            SetStatus("webMAN Commands - Successfully Opened Game Launcher.");
        }

        private void ButtonToolsPsGamesMountBD_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (BD) list...");

            List<ListItem> games = FtpExtensions.GetGamesBd();

            switch (games.Count)
            {
                case <= 0:
                    SetStatus("webMAN Commands - No Games (BD) Found.");
                    XtraMessageBox.Show(this, "No games (BD) can be found on your console. If you have them on external devices then enable this option in your settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            ListItem selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (BD)", games);

            switch (selectedGame)
            {
                case null:
                    SetStatus("webMAN Commands - Mount Game (BD) Cancelled.");
                    break;
                default:
                    SetStatus($"webMAN Commands - Mounting Game (BD): {selectedGame.Name}");
                    WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame.Value);
                    SetStatus($"webMAN Commands - Successfully Mounted Game (BD): {selectedGame.Name}");
                    break;
            }
        }

        private void ButtonToolsPsGamesMountISO_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (ISO) list...");

            List<ListItem> games = FtpExtensions.GetGamesIso();

            switch (games.Count)
            {
                case <= 0:
                    SetStatus("webMAN Commands - No Games (ISO) Found.");
                    XtraMessageBox.Show(this, "No games (ISO) can be found on your console. If you have them on external devices then enable this option in your settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            ListItem selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (ISO)", games);

            switch (selectedGame)
            {
                case null:
                    SetStatus("webMAN Commands - Mount Game (ISO) Cancelled.");
                    break;
                default:
                    SetStatus($"webMAN Commands - Mounting Game (ISO): {selectedGame.Name}");
                    WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame.Value);
                    SetStatus($"webMAN Commands - Successfully Mounted Game (ISO): {selectedGame.Name}");
                    break;
            }
        }

        private void ButtonToolsPsGamesMountPSN_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (PSN) list...");

            List<ListItem> games = FtpExtensions.GetGamesPsn();

            switch (games.Count)
            {
                case <= 0:
                    SetStatus("webMAN Commands - No Games (PSN) Found.");
                    XtraMessageBox.Show(this, "No games (PSN) can be found on your console. If you have them on external devices then enable this option in your settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            ListItem selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (PSN)", games);

            switch (selectedGame)
            {
                case null:
                    SetStatus("webMAN Commands - Mount Game (PSN) Cancelled.");
                    break;
                default:
                    SetStatus($"webMAN Commands - Mounting Game (PSN): {selectedGame.Name}");
                    WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame.Value);
                    SetStatus($"webMAN Commands - Successfully Mounted Game (PSN): {selectedGame.Name}");
                    break;
            }
        }

        private void ButtonToolsPsGamesUnmount_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Unmounting Game...");
            WebManExtensions.Unmount(ConsoleProfile.Address);
            SetStatus("webMAN Commands - Successfully Unmounted Game");
        }

        private void ButtonToolsPsGamesStartGame_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Launching Game...");
            WebManExtensions.LaunchGame(ConsoleProfile.Address);
            SetStatus("webMAN Commands - Successfully Launched Game.");
        }

        private void ButtonToolsPsNotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:");

            if (notifyMessage.IsNullOrWhiteSpace())
            {
                SetStatus("No message was entered. Cancelled.");
            }

            {
                SetStatus("webMAN Commands - Notifying Message...");
                WebManExtensions.NotifyPopup(ConsoleProfile.Address, notifyMessage);
                SetStatus($"webMAN Commands - Message Notified: {notifyMessage}");
            }
        }

        private void ButtonToolsPsVirtualController_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("webMAN Commands - Virtual Controller: Opening in Web Browser");
            Process.Start("http://pad.aldostools.org/pad.html");
            SetStatus("webMAN Commands - Virtual Controller: Opened in Web Browser");
        }

        private void ButtonToolsXboxPowerShutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Shutdown();
            DisconnectConsole();
        }

        private void ButtonToolsXboxPowerSoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Cold);
            DisconnectConsole();
        }

        private void ButtonToolsXboxPowerHardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Warm);
            DisconnectConsole();
        }

        private void ButtonToolsXboxTakeScreenshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowTakeScreenshot(this);
        }

        private void ButtonToolsXboxConsoleManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxConsoleManager(this);
        }

        private void ButtonToolsXboxNotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("NOTIFY_MESSAGE"), ResourceLanguage.GetString("MESSAGE"));

            List<string> notifyIcons = [];

            foreach (XNotifyLogo xNotifyIcon in Enum.GetValues(typeof(XNotifyLogo)) as XNotifyLogo[])
            {
                notifyIcons.Add(xNotifyIcon.Humanize());
            }

            string notifyIcon = DialogExtensions.ShowListItemDialog(this, ResourceLanguage.GetString("NOTIFY_ICON"), ResourceLanguage.GetString("ICON"), notifyIcons.ToArray());

            XboxConsole.XNotify(notifyMessage, notifyIcon.DehumanizeTo<XNotifyLogo>());
        }

        #endregion

        #region Connect & Disconnect Functions

        /// <summary>
        /// Attempt to connect to the console profile by opening the FTP/XboxConsole connection.
        /// </summary>
        public void ConnectConsole()
        {
            try
            {
                string platform = ConsoleProfile.Platform.ToString().ToLowerInvariant();

                SetStatus(string.Format(ResourceLanguage.GetString("CONNECTING_TO_CONSOLE"), $"{ConsoleProfile.Name} ({ConsoleProfile.Address})"));

                switch (ConsoleProfile.Platform)
                {
                    case Platform.PS3:
                        FtpClient = new FtpClient
                        {
                            Host = ConsoleProfile.Address,
                            Port = 21,
                            Credentials = ConsoleProfile.UseDefaultCredentials
                            ? new NetworkCredential("anonymous", "anonymous")
                            : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password),
                            Config = new() { SocketKeepAlive = true, DataConnectionType = FtpDataConnectionType.PASV, ReadTimeout = 90000, ConnectTimeout = 90000, DataConnectionConnectTimeout = 90000, DataConnectionReadTimeout = 90000 },
                            //Config = new() { SocketKeepAlive = true, DataConnectionType = FtpDataConnectionType.AutoActive, ReadTimeout = 90000, ConnectTimeout = 90000, DataConnectionConnectTimeout = 90000, DataConnectionReadTimeout = 90000 },
                        };

                        FtpClient.Connect();

                        IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address);

                        NotifyIfWebManInstalled(platform, IsWebManInstalled);

                        SetPlatform(ConsoleProfile.Platform);

                        break;

                    case Platform.XBOX360:
                        XboxManager = new XboxManager();

                        XboxConsole = ConsoleProfile.UseDefaultConsole
                            ? XboxManager.OpenConsole(XboxManager.DefaultConsole)
                            : XboxManager.OpenConsole(ConsoleProfile.Address);

                        JRPC.Connect(XboxConsole, out _);

                        if (!JRPC.Connect(XboxConsole, out _))
                        {
                            DialogExtensions.ShowErrorMessage(this, "You must have JRPC2 module set as a plugin on your console to use some features.");
                        }

                        SetPlatform(ConsoleProfile.Platform);

                        break;

                    case Platform.PS4:

                        //XtraMessageBox.Show(this,
                        //            $"Unfortunately, connection to PS4 is not complete yet, but you can still browse and download homebrew applications.",
                        //            ResourceLanguage.GetString("CONNECTION_FAILED"),
                        //            MessageBoxButtons.OK,
                        //            MessageBoxIcon.Information);
                        //break;

                        FtpClient = new FtpClient
                        {
                            Host = ConsoleProfile.Address,
                            Port = 9090,
                            Credentials = new NetworkCredential(string.Empty, string.Empty),
                            Config = new() { SocketKeepAlive = true, DataConnectionType = FtpDataConnectionType.PASV, ReadTimeout = 90000, ConnectTimeout = 90000, DataConnectionConnectTimeout = 90000, DataConnectionReadTimeout = 90000 },
                            //Config = new() { SocketKeepAlive = true, DataConnectionType = FtpDataConnectionType.AutoActive, ReadTimeout = 90000, ConnectTimeout = 90000, DataConnectionConnectTimeout = 90000, DataConnectionReadTimeout = 90000 },
                        };

                        FtpClient.Connect();

                        //IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address);

                        //NotifyIfWebManInstalled(platformString, IsWebManInstalled);

                        SetPlatform(ConsoleProfile.Platform);

                        break;

                    default:
                        throw new NotImplementedException();
                }

#if !DEBUG //Only here so can release without full PS4 support
                if (ConsoleProfile.Platform != Platform.PS4)
                {
                    ButtonConnectConsole.Caption = ResourceLanguage.GetString("RECONNECT_CONSOLE");
                    ButtonDisconnectConsole.Enabled = true;

                    SetStatusConsole(ConsoleProfile);
                    SetStatusIsConnected(true);

                    EnableConsoleActions();

                    SetStatus($"{ResourceLanguage.GetString("SUCCESS_CONNECTED")}.");
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("SUCCESS_CONNECTED"), ResourceLanguage.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Settings.AutoLoadDirectoryListings || NavigationFrame.SelectedPage == PageFileManager)
                    {
                        if (NavigationFrame.SelectedPage == PageFileManager)
                        {
                            CloseOverlayFeatureNotAvailable(PageFileManager, handleOverlayFeatureNotAvailable);
                        }

                        StartFileManager();
                        TimerLoadConsole.Enabled = true;
                        hadLoadedFileManager = true;
                    }
                }
#endif
            }
            catch (Exception ex)
            {
                SetStatus(ResourceLanguage.GetString("UNABLE_TO_CONNECT"), ex);
                XtraMessageBox.Show(this,
                                    $"{ResourceLanguage.GetString("UNABLE_TO_CONNECT")} {(ConsoleProfile.Platform == Platform.XBOX360 ? $"\n{ResourceLanguage.GetString("NEIGHBORHOOD_NOT_FOUND")}" : string.Empty)}\n\n{ResourceLanguage.GetString("ERROR")}: {ex.Message}",
                                    ResourceLanguage.GetString("CONNECTION_FAILED"),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void NotifyIfWebManInstalled(string platform, bool isWebManInstalled)
        {
            if (isWebManInstalled)
            {
                switch (platform)
                {
                    case "PS3":
                        WebManExtensions.NotifyPopup(ConsoleProfile.Address, ResourceLanguage.GetString("CONNECTED_NOTIFICATION"));
                        break;
                }
            }
        }

        /// <summary>
        /// Disconnects from the console and flushes all resources from the FTP connections.
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus(ResourceLanguage.GetString("DISCONNECTING_FROM_CONSOLE"));

            switch (Platform)
            {
                case Platform.PS3:
                    try
                    {
                        FtpClient.Dispose();
                    }
                    catch
                    {
                        // False positive, if console is powered off then an error will be thrown.
                    }

                    break;
                case Platform.XBOX360:
                    try
                    {
                        XboxConsole.CloseConnection(0);
                    }
                    catch
                    {
                        // False positive, if console is powered off then an error will be thrown.
                    }

                    break;
                case Platform.PS4:
                    try
                    {
                        FtpClient.Dispose();
                    }
                    catch
                    {
                        // False positive, if console is powered off then an error will be thrown.
                    }

                    break;
            }

            SetStatusIsConnected(false);
            EnableFileManager(false);

            EnableConsoleActions();

            ButtonConnectConsole.Caption = ResourceLanguage.GetString("CONNECT_CONSOLE");
            ButtonDisconnectConsole.Enabled = false;

            SetStatus(ResourceLanguage.GetString("SUCCESS_DISCONNECTED"));
            XtraMessageBox.Show(this, ResourceLanguage.GetString("SUCCESS_DISCONNECTED"), ResourceLanguage.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Navigation Menu

        private void NavigationItemDashboard_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageDashboard;
        }

        private void NavigationItemDownloads_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageDownloads;
            LoadDownloads();
        }

        private void NavigationItemInstalledMods_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageInstalledFiles;
            LoadInstalledMods();
        }

        private bool hadLoadedFileManager = false;

        private void NavigationItemFileManager_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageFileManager;

            if (!hadLoadedFileManager && IsConsoleConnected)
            {
                StartFileManager();
                TimerLoadConsole.Enabled = true;
                hadLoadedFileManager = true;
            }

            if (!IsConsoleConnected)
            {
                if (handleOverlayFeatureNotAvailable == null)
                {
                    handleOverlayFeatureNotAvailable = ShowOverlayFeatureNotAvailable(PageFileManager, ResourceLanguage.GetString("YOU_MUST_BE_CONNECTED_TO_USE_FEATURE"));
                }
            }
            else
            {
                if (handleOverlayFeatureNotAvailable != null)
                {
                    CloseOverlayFeatureNotAvailable(PageFileManager, handleOverlayFeatureNotAvailable);
                }
            }
        }

        private void NavigationItemSettings_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageSettings;
            LoadSettings();
        }

        /* Library */

        private bool hasLoadedCustomMods = false;

        private void NavigationItemCustomMods_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageCustomMods;

            if (!hasLoadedCustomMods)
            {
                LoadCustomModsCategories();
                SearchCustomMods();
                hasLoadedCustomMods = true;
            }
        }

        private bool hasLoadedGameMods = false;
        private bool hasLoadedGameModsXbox = false;

        private void NavigationItemGameMods_Click(object sender, EventArgs e)
        {
            if (Platform == Platform.PS3)
            {
                NavigationFrame.SelectedPage = PageGameModsPS3;

                if (!hasLoadedGameMods)
                {
                    LoadGameModsCategoriesPS3();
                    SearchGameModsPS3();
                    hasLoadedGameMods = true;
                }
            }
            else if (Platform == Platform.XBOX360)
            {
                NavigationFrame.SelectedPage = PageGameModsXbox;

                if (!hasLoadedGameModsXbox)
                {
                    LoadGameModsCategoriesXbox();
                    SearchGameModsXbox();
                    hasLoadedGameModsXbox = true;
                }
            }
        }

        private bool hasLoadedHomebrewPS3 = false;
        private bool hasLoadedHomebrewXbox = false;
        private bool hasLoadedHomebrewPS4 = false;

        private void NavigationItemHomebrew_Click(object sender, EventArgs e)
        {
            if (Platform == Platform.PS3)
            {
                NavigationFrame.SelectedPage = PageHomebrewPS3;

                if (!hasLoadedHomebrewPS3)
                {
                    //LoadHomebrewCategoriesPS3();
                    SearchHomebrewPS3();
                    hasLoadedHomebrewPS3 = true;
                }
            }
            else if (Platform == Platform.XBOX360)
            {
                NavigationFrame.SelectedPage = PageHomebrewXbox;

                if (!hasLoadedHomebrewXbox)
                {
                    //LoadHomebrewCategoriesXbox();
                    SearchHomebrewXbox();
                    hasLoadedHomebrewXbox = true;
                }
            }
            else if (Platform == Platform.PS4)
            {
                NavigationFrame.SelectedPage = PageHomebrewPS4;

                if (!hasLoadedHomebrewPS4)
                {
                    //LoadHomebrewCategoriesPS4();
                    SearchHomebrewPS4();
                    hasLoadedHomebrewPS4 = true;
                }
            }
        }

        private bool hasLoadedResources = false;

        private void NavigationItemResources_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageResourcesPS3;

            if (!hasLoadedResources)
            {
                LoadResourcesCategories();
                SearchResources();
                hasLoadedResources = true;
            }
        }

        private bool hasLoadedPackages = false;

        private void NavigationItemPackages_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PagePackagesPS3;

            if (!hasLoadedPackages)
            {
                LoadPackages();
                hasLoadedPackages = true;
            }
        }

        private bool hasLoadedGames = false;

        private void NavigationItemGames_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageGamesPS4;

            if (!hasLoadedGames)
            {
                LoadGamesCategories();
                SearchGames();
                hasLoadedGames = true;
            }
        }

        private bool hasLoadedGameSaves = false;

        private void NavigationItemGameSaves_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageGameSaves;

            if (!hasLoadedGameSaves)
            {
                SearchGameSaves();
                hasLoadedGameSaves = true;
            }
        }

        #endregion

        #region Dashboard Page

        private void LoadOurFavoriteGames()
        {
            foreach (var tileItem in TileGroupFavoriteGames.Items.OfType<TileItem>().Except([TileItemFavoriteGames]).ToList())
            {
                TileGroupFavoriteGames.Items.Remove(tileItem);
            }

            TileItemFavoriteGames.Visible = false;

            foreach (Models.Dashboard.FavoriteGamesData.Favorite game in Database.FavoriteGames.Favorites)
            {
                if (game.GetPlatform() == ConsoleProfile.Platform)
                {
                    TileGroupFavoriteGames.Items.Add(FavoriteModItem(game.GetPlatform(), game.CategoryId, game.ImageUrl));
                }
            }

            if (ConsoleProfile.Platform == Platform.PS3)
            {
                LabelHeaderFavoriteGames.Text = ResourceLanguage.GetString("OUR_FAVORITE_GAMES");
            }
            else if (ConsoleProfile.Platform == Platform.PS4)
            {
                LabelHeaderFavoriteGames.Text = ResourceLanguage.GetString("OUR_FAVORITE_CATEGORIES");
            }
            else if (ConsoleProfile.Platform == Platform.XBOX360)
            {
                LabelHeaderFavoriteGames.Text = ResourceLanguage.GetString("OUR_FAVORITE_GAMES");
            }
        }

        private TileItem FavoriteModItem(Platform platform, string categoryId, string imageUrl)
        {
            TileItem tileItem = new()
            {
                TextAlignment = TileItemContentAlignment.BottomLeft,
                ItemSize = TileItemSize.Wide
            };

            tileItem.Elements.Assign(TileItemFavoriteGames.Elements);

            tileItem.Elements[0].Text = Database.CategoriesData.GetCategoryById(categoryId).Title;

            if (ConsoleProfile.Platform == Platform.PS3)
            {
                tileItem.Elements[1].Text = Database.GameModsPS3.Library.Where(x => x.CategoryId == categoryId).Count().ToString() + " Total Game Mods";
            }
            else if (ConsoleProfile.Platform == Platform.PS4)
            {
                tileItem.Elements[1].Text = Database.HomebrewPS4.Library.Where(x => x.CategoryId == categoryId).Count().ToString() + " Total Homebrew";
            }
            else if (ConsoleProfile.Platform == Platform.XBOX360)
            {
                tileItem.Elements[1].Text = Database.GameModsXbox.Library.Where(x => x.CategoryId == categoryId).Count().ToString() + " Total Game Mods";
            }

            tileItem.Tag = platform.Humanize() + "|" + categoryId;

            if (!string.IsNullOrWhiteSpace(imageUrl))
            {
                var tileImage = HttpExtensions.GetImageFromUrl(imageUrl);

                tileItem.BackgroundImage = ImageExtensions.AdjustBrightness(tileImage, 0.30F);
                tileItem.BackgroundImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                tileItem.BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter;
            }

            tileItem.ItemClick += FavoriteModItem_Click;

            return tileItem;
        }

        private void FavoriteModItem_Click(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = sender as TileItem;
            string categoryTitle = tileItem.Elements[0].Text;
            Platform platform = tileItem.Tag.ToString().Split('|')[0].DehumanizeTo<Platform>();
            string categoryId = tileItem.Tag.ToString().Split('|')[1];

            if (platform == Platform.PS3)
            {
                if (!hasLoadedGameMods)
                {
                    LoadGameModsCategoriesPS3();
                    SearchGameModsPS3();
                    hasLoadedGameMods = true;
                }

                NavigationFrame.SelectedPage = PageGameModsPS3;
                NavigationMenu.SelectElement(NavigationItemGameMods);
                ComboBoxGameModsPS3FilterGame.SelectedItem = categoryTitle;
            }
            else if (platform == Platform.PS4)
            {
                if (!hasLoadedGameMods)
                {
                    //LoadGameModsCategories();
                    SearchHomebrewPS4();
                    hasLoadedHomebrewPS4 = true;
                }

                NavigationFrame.SelectedPage = PageHomebrewPS4;
                NavigationMenu.SelectElement(NavigationItemHomebrew);
                ComboBoxHomebrewPS4FilterStatus.SelectedItem = categoryTitle; // Database.CategoriesData.GetCategoryById(categoryId).Title;
                //LoadHomebrewCategoriesPS4();
                SearchHomebrewPS4();
            }
            else if (platform == Platform.XBOX360)
            {
                NavigationFrame.SelectedPage = PageGameModsXbox;
                NavigationMenu.SelectElement(NavigationItemGameMods);
                ComboBoxGameModsXboxFilterGame.SelectedItem = categoryTitle; // Database.CategoriesData.GetCategoryById(categoryId).Title;
                //LoadGameModsCategories();
                SearchGameModsXbox();
            }
        }

        private void LoadOurFavoriteMods()
        {
            foreach (var tileItem in TileGroupOurFavoriteMods.Items.OfType<TileItem>().Except(new[] { TileItemFavoriteMods }).ToList())
            {
                TileGroupOurFavoriteMods.Items.Remove(tileItem);
            }

            TileItemFavoriteMods.Visible = false;

            foreach (Models.Dashboard.FavoriteModsData.Favorite favorite in Database.FavoriteMods.Favorites)
            {
                if (favorite.GetPlatform() == ConsoleProfile.Platform)
                {
                    TileGroupOurFavoriteMods.Items.Add(FavoriteModItem(favorite.GetPlatform(), favorite.CategoryId, favorite.ModId, favorite.Name));
                }
            }
        }

        private TileItem FavoriteModItem(Platform platform, string categoryId, int modId, string modName)
        {
            TileItem tileItem = new()
            {
                TextAlignment = TileItemContentAlignment.TopLeft,
                ItemSize = TileItemSize.Medium
            };

            tileItem.Elements.Assign(TileItemFavoriteMods.Elements);

            tileItem.Elements[0].Text = Database.CategoriesData.GetCategoryById(categoryId).Title;
            tileItem.Elements[1].Text = modName;

            tileItem.Tag = platform.Humanize() + "|" + modId.ToString();

            if (platform == Platform.PS3)
            {
                tileItem.AppearanceItem.Normal.BackColor = Color.FromArgb(0, 120, 215);
                tileItem.AppearanceItem.Normal.BorderColor = Color.FromArgb(0, 120, 215);
            }
            else if (platform == Platform.PS4)
            {
                tileItem.AppearanceItem.Normal.BackColor = Color.FromArgb(0, 120, 215);
                tileItem.AppearanceItem.Normal.BorderColor = Color.FromArgb(0, 120, 215);
            }
            else
            {
                tileItem.AppearanceItem.Normal.BackColor = Color.FromArgb(26, 163, 86);
                tileItem.AppearanceItem.Normal.BorderColor = Color.FromArgb(26, 163, 86);
            }

            tileItem.ItemClick += FavoriteModsItem_Click;

            return tileItem;
        }

        private void FavoriteModsItem_Click(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = sender as TileItem;
            string categoryTitle = tileItem.Elements[0].Text;
            Platform platform = tileItem.Tag.ToString().Split('|')[0].DehumanizeTo<Platform>();
            int modId = int.Parse(tileItem.Tag.ToString().Split('|')[1]);

            if (platform == Platform.PS3)
            {
                ShowDetails(platform, categoryTitle, modId);
            }
            else if (platform == Platform.PS4)
            {
                ShowDetails(platform, categoryTitle, modId);
            }
            else if (platform == Platform.XBOX360)
            {
                ShowDetails(platform, categoryTitle, modId);
            }
        }

        private async void LoadCurrentPoll()
        {
            await InitializeWebPollAsync();
        }

        private async Task InitializeWebPollAsync()
        {
            if (WebViewPoll.CoreWebView2 == null)
            {
                WebViewPoll.CoreWebView2InitializationCompleted += WebViewPoll_CoreWebView2InitializationCompleted;
                WebViewPoll.NavigationCompleted += WebViewPoll_NavigationCompleted;
                WebViewPoll.NavigationStarting += WebViewPoll_NavigationStarting;
                await WebViewPoll.EnsureCoreWebView2Async(null);
            }
        }

        private void WebViewPoll_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                if (!string.IsNullOrEmpty(Properties.Resources.PollLink))
                {
                    WebViewPoll.CoreWebView2.NavigateToString(Properties.Resources.PollLink);
                }

                //Credits：https://blog.jussipalo.com/2021/02/webview2-how-to-hide-scrollbars.html
                WebViewPoll.ExecuteScriptAsync("document.querySelector('body').style.overflow='scroll';var style=document.createElement('style');style.type='text/css';style.innerHTML='::-webkit-scrollbar{display:none}';document.getElementsByTagName('body')[0].appendChild(style)");
            }
            else
            {
                SetStatus($"CoreWebView2 Initialization Failed - " + e.InitializationException.Message, e.InitializationException);
            }
        }

        private void WebViewPoll_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                ((WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
            }
        }

        private void WebViewPoll_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.NavigationKind is CoreWebView2NavigationKind.BackOrForward or CoreWebView2NavigationKind.Reload)
            {
                e.Cancel = true;
            }
        }

        private void LoadAnnouncements()
        {
            PanelAnnouncementsItems.Controls.Clear();
            Database.Announcements.Announcements.Reverse();

            foreach (Models.Dashboard.AnnouncementsData.Announcement announcement in Database.Announcements.Announcements)
            {
                if (!Settings.DismissedAnnouncements.Contains(announcement.Id))
                {
                    if (DateTime.Now >= announcement.DateStart && DateTime.Now <= announcement.DateEnd)
                    {
                        AccouncementItem announcementItem = new(announcement.Id, announcement.Title, announcement.Message, announcement.DateStart) { Dock = DockStyle.Top };
                        PanelAnnouncementsItems.Controls.Add(announcementItem);
                        announcementItem.BringToFront();
                        //PanelAnnouncementsItems.ScrollControlIntoView(announcementItem);
                    }
                }
            }

            NoAnnouncements.Visible = PanelAnnouncementsItems.Controls.Count < 1;
        }

        private async void LoadNewsFeed()
        {
            PanelNewsItems.Controls.Clear();

            Feed feed = await FeedReader.ReadAsync(Urls.RssFeedData);

            foreach (FeedItem item in feed.Items.Reverse())
            {
                NewsItem newsItem = new(item.Title, item.Description, (DateTime)item.PublishingDate) { Dock = DockStyle.Top };
                PanelNewsItems.Controls.Add(newsItem);
            }
        }

        private void LoadStatistics()
        {
            chartControl1.Titles.Add(new ChartTitle() { Text = "Statistics" });

            Series series1 = new("Statistics", ViewType.Pie)
            {
                // Bind the series to data.
                DataSource = DataPoint.GetDataPoints(
                Database.GameModsPS3.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Game).Count,
                Database.HomebrewPS3.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew).Count,
                Database.ResourcesPS3.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Resource).Count,
                Database.PackagesCount(),
                Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == Platform.PS3).ToList().Count),

                ArgumentDataMember = "Argument"
            };

            series1.ValueDataMembers.AddRange(["Value"]);

            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Access diagram settings.
            SimpleDiagram diagram = (SimpleDiagram)chartControl1.Diagram; diagram.Margins.All = 10;

            // Format the the series labels.
            series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            // Format the series legend items.
            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels. 
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Specify the pie rotation.
            myView.Rotation = -60;

            // Specify a data filter to explode points.
            //myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9));
            //myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"));
            //myView.ExplodeMode = PieExplodeMode.UseFilters;
            //myView.ExplodedDistancePercentage = 30;
            //myView.RuntimeExploding = true;

            // Customize the legend.
            chartControl1.Legend.Visibility = DefaultBoolean.True;

            LabelHeaderStatistics.Text = ResourceLanguage.GetString("STATISTICS");

            LabelStatsDownloads.Text = string.Format(ResourceLanguage.GetString("STATS_DOWNLOADS"), $"{UpdateExtensions.StatsData.TotalDownloads:N0}");

            LabelStatsPlayStation3.Text =
                $"{Database.GameModsPS3.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Game).Count:N0} {ResourceLanguage.GetString("LABEL_GAME_MODS")}\n" +
                $"{Database.HomebrewPS3.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew).Count:N0} {ResourceLanguage.GetString("LABEL_HOMEBREW")}\n" +
                $"{Database.ResourcesPS3.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Resource).Count:N0} {ResourceLanguage.GetString("LABEL_RESOURCES")}\n" +
                $"{Database.PackagesCount():N0} {ResourceLanguage.GetString("LABEL_PACKAGES")}\n" +
                $"{Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == Platform.PS3).ToList().Count:N0} {ResourceLanguage.GetString("LABEL_GAME_SAVES")}\n" +
                $"{Database.GameCheatsPS3.GetTotalCheats():N0} {ResourceLanguage.GetString("LABEL_GAME_CHEATS")}";

            LabelStatisticsPlayStation4.Text =
                $"{Database.HomebrewPS4.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew).Count:N0} {ResourceLanguage.GetString("LABEL_HOMEBREW")}\n" +
                $"{Database.HomebrewPS4.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Game).Count:N0} {ResourceLanguage.GetString("GAMES")}";
            //$"{Database.GamePatchesXbox.GetTotalCheats():N0} {ResourceLanguage.GetString("LABEL_GAME_CHEATS")}";

            LabelStatsXbox360.Text =
                $"{Database.GameModsXbox.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Game).Count:N0} {ResourceLanguage.GetString("LABEL_GAME_MODS")}\n" +
                $"{Database.HomebrewXbox.Library.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew).Count:N0} {ResourceLanguage.GetString("LABEL_HOMEBREW")}\n" +
                $"{Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == Platform.XBOX360).ToList().Count:N0} {ResourceLanguage.GetString("LABEL_GAME_SAVES")}";
            //$"{Database.GamePatchesXbox.GetTotalCheats():N0} {ResourceLanguage.GetString("LABEL_GAME_CHEATS")}";

            LabelStatsLastUpdated.Text = $"{ResourceLanguage.GetString("LAST_UPDATED")}: {Database.CategoriesData.LastUpdated.ToLocalTime().ToShortDateString()}";
        }

        public class DataPoint
        {
            public string Argument { get; set; }

            public double Value { get; set; }

            public static List<DataPoint> GetDataPoints(int gameMods, int homebrew, int resources, int packages, int gameSaves)
            {
                return [
                    new DataPoint { Argument = "Game Mods",     Value = gameMods},
                    new DataPoint { Argument = "Homebrew",      Value = homebrew},
                    new DataPoint { Argument = "Resources",     Value = resources},
                    new DataPoint { Argument = "Packages",      Value = packages},
                    new DataPoint { Argument = "Game Saves",    Value = gameSaves}
                ];
            }
        }

        private int ChangeLogsCurrent;
        private int ChangeLogsMaximum;

        private void LoadChangeLog()
        {
            ChangeLogsCurrent = 0;
            ChangeLogsMaximum = UpdateExtensions.AllReleases.Count();

            GitHubReleaseData gitHubData = UpdateExtensions.AllReleases[0];

            LabelChangeLogVersion.Text = $"{gitHubData.Name}"; //({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = gitHubData.Body.Replace("- ", "• ");
        }

        private void PanelAnnouncementsItems_ControlAdded(object sender, ControlEventArgs e)
        {
            NoAnnouncements.Visible = PanelAnnouncementsItems.Controls.Count < 1;
        }

        private void PanelAnnouncementsItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            NoAnnouncements.Visible = PanelAnnouncementsItems.Controls.Count < 1;
        }

        private void ImageReloadNewsItems_Click(object sender, EventArgs e)
        {
            LoadNewsFeed();
        }

        // Change Log

        private static List<GitHubReleaseData> GitHubAllReleases { get; set; } = UpdateExtensions.AllReleases;

        private void ButtonChangeLogPrevious_Click(object sender, EventArgs e)
        {
            ChangeLogsCurrent++;

            GitHubReleaseData gitHubData = GitHubAllReleases[ChangeLogsCurrent];

            string releaseBody = gitHubData.Body.Substring(0, gitHubData.Body.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

            LabelChangeLogVersion.Text = $"{gitHubData.Name}"; // ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = releaseBody.Replace("- ", "• ");

            ButtonChangeLogPrevious.Enabled = ChangeLogsCurrent != ChangeLogsMaximum - 1;
            ButtonChangeLogNext.Enabled = ChangeLogsCurrent != 0;
        }

        private void ButtonChangeLogNext_Click(object sender, EventArgs e)
        {
            ChangeLogsCurrent--;

            GitHubReleaseData gitHubData = GitHubAllReleases[ChangeLogsCurrent];

            string releaseBody = gitHubData.Body.Substring(0, gitHubData.Body.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

            LabelChangeLogVersion.Text = $"{gitHubData.Name}"; // ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = releaseBody.Replace("- ", "• ");

            ButtonChangeLogPrevious.Enabled = ChangeLogsCurrent != ChangeLogsMaximum;
            ButtonChangeLogNext.Enabled = ChangeLogsCurrent != 0;
        }

        #endregion

        #region Downloads Page

        private int SelectedDownloadId = -1;

        private void TileItemDownloadsOpenFolder_ItemClick(object sender, TileItemEventArgs e)
        {
            Process.Start(IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathDownloads));
        }

        private void TileItemDownloadsOpenFile_ItemClick(object sender, TileItemEventArgs e)
        {
            int? downloadItemModId = GridViewDownloads.GetFocusedRowCellValue("ModId") as int?;
            string downloadItemPlatform = GridViewDownloads.GetFocusedRowCellValue(ResourceLanguage.GetString("LABEL_PLATFORM")) as string;
            DownloadedItem downloadedItem = Settings.DownloadedMods.FirstOrDefault(x => x.ModId.Equals(downloadItemModId.Value) && x.Platform.Humanize().EqualsIgnoreCase(downloadItemPlatform));

            if (Directory.Exists(downloadedItem.FilePath))
            {
                Process.Start("explorer.exe", $"/select,\"{downloadedItem.FilePath}\"");
            }
            else
            {
                XtraMessageBox.Show(this, $"{ResourceLanguage.GetString("DIRECTORY_NOT_EXIST")}.\n\nPath: {downloadedItem.FilePath}", ResourceLanguage.GetString("DIRECTORY_NOT_FOUND"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TileItemDownloadsDeleteItem_ItemClick(object sender, TileItemEventArgs e)
        {
            if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE_ITEM"), ResourceLanguage.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? downloadItemModId = GridViewDownloads.GetFocusedRowCellValue("ModId") as int?;
                Platform downloadItemPlatform = GridViewDownloads.GetFocusedRowCellValue(ResourceLanguage.GetString("LABEL_PLATFORM")).ToString().DehumanizeTo<Platform>();
                DownloadedItem downloadedItem = Settings.DownloadedMods.FirstOrDefault(x => x.ModId.Equals(downloadItemModId.Value) && x.Platform == downloadItemPlatform);

                if (downloadedItem != null)
                {
                    File.Delete(downloadedItem.FilePath);
                    Settings.DownloadedMods.RemoveAll(x => x == downloadedItem);
                    SearchDownloads();
                }
            }
        }

        private void TileItemDownloadsDeleteAllItems_ItemClick(object sender, TileItemEventArgs e)
        {
            if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE_ALL_ITEMS"), ResourceLanguage.GetString("CONFIRM_DELETE_ALL"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (string file in Directory.GetFiles(IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathDownloads), "*.zip", System.IO.SearchOption.AllDirectories))
                {
                    File.Delete(file);
                }

                Settings.DownloadedMods.Clear();
                SearchDownloads();
            }
        }

        private void TileItemDownloadsViewDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            int? downloadItemModId = GridViewDownloads.GetFocusedRowCellValue("ModId") as int?;
            Platform downloadItemPlatform = GridViewDownloads.GetFocusedRowCellValue(ResourceLanguage.GetString("LABEL_PLATFORM")).ToString().DehumanizeTo<Platform>();
            string downloadItemCategory = GridViewDownloads.GetFocusedRowCellValue(ResourceLanguage.GetString("LABEL_CATEGORY")) as string;

            ModItemData modItemData = Database.GetModItem(downloadItemPlatform, Database.CategoriesData.GetCategoryByTitle(downloadItemCategory).CategoryType, downloadItemModId.Value);

            if (modItemData != null)
            {
                ShowDetails(modItemData.GetPlatform(), downloadItemCategory, modItemData.Id);
            }
        }

        /// <summary>
        /// Get/set the playform for filtering downloads.
        /// </summary>
        private string FilterDownloadsPlatform { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the file name for filtering downloads.
        /// </summary>
        private string FilterDownloadsFileName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the category Id for filtering downloads.
        /// </summary>
        private string FilterDownloadsCategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the mod type for filtering downloads.
        /// </summary>
        private string FilterDownloadsModType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the region for filtering downloads.
        /// </summary>
        private string FilterDownloadsRegion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering downloads.
        /// </summary>
        private string FilterDownloadsVersion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the date time for filtering downloads.
        /// </summary>
        private DateTime? FilterDownloadsDownloadOn { get; set; } = null;

        /// <summary>
        /// Get/set the date time type for filtering downloads.
        /// </summary>
        private FilterType FilterDownloadsDownloadOnType { get; set; } = FilterType.Equal;

        private void ComboBoxDownloadsFilterPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDownloadsPlatform = ComboBoxDownloadsFilterPlatform.SelectedIndex is (-1) or 0
                ? string.Empty
                : ComboBoxDownloadsFilterPlatform.SelectedItem as string;

            SearchDownloads();
        }

        private void ComboBoxDownloadsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDownloadsFilterCategory.SelectedIndex is (-1) or 0)
            {
                FilterDownloadsCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxDownloadsFilterCategory.SelectedItem as string;
                FilterDownloadsCategoryId = Database.CategoriesData.GetCategoryByTitle(selectedCategory).Id;
            }

            SearchDownloads();
        }

        private void TextBoxDownloadsFilterFileName_EditValueChanged(object sender, EventArgs e)
        {
            FilterDownloadsFileName = TextBoxDownloadsFilterFileName.Text;

            SearchDownloads();
        }

        private void ComboBoxDownloadsFilterModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDownloadsModType = ComboBoxDownloadsFilterModType.SelectedIndex is (-1) or 0
                ? string.Empty
                : ComboBoxDownloadsFilterModType.SelectedItem as string;

            SearchDownloads();
        }

        private void ComboBoxDownloadsFilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDownloadsRegion = ComboBoxDownloadsFilterRegion.SelectedIndex is (-1) or 0
                ? string.Empty
                : ComboBoxDownloadsFilterRegion.SelectedItem as string;

            SearchDownloads();
        }

        private void ComboBoxDownloadsFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDownloadsVersion = ComboBoxDownloadsFilterVersion.SelectedIndex is (-1) or 0
                ? string.Empty
                : ComboBoxDownloadsFilterVersion.SelectedItem as string;

            SearchDownloads();
        }

        private void ImageDownloadsFilterOnType_Click(object sender, EventArgs e)
        {
            if (FilterDownloadsDownloadOnType == FilterType.Equal)
            {
                FilterDownloadsDownloadOnType = FilterType.MoreThanOrEqual;
                ImageDownloadsFilterOnType.Image = Properties.Resources.more_or_equal;
            }
            else if (FilterDownloadsDownloadOnType == FilterType.MoreThanOrEqual)
            {
                FilterDownloadsDownloadOnType = FilterType.LessThanOrEqual;
                ImageDownloadsFilterOnType.Image = Properties.Resources.less_or_equal;
            }
            else if (FilterDownloadsDownloadOnType == FilterType.LessThanOrEqual)
            {
                FilterDownloadsDownloadOnType = FilterType.Equal;
                ImageDownloadsFilterOnType.Image = Properties.Resources.equal_sign;
            }

            SearchDownloads();
        }

        private void DateTimeDownloadsFilterDate_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTimeDownloadsFilterDate.Text.IsValidDate("MM/dd/yyyy"))
            {
                FilterDownloadsDownloadOn = DateTime.Parse(DateTimeDownloadsFilterDate.EditValue.ToString());
            }
            else
            {
                DateTimeDownloadsFilterDate.EditValue = null;
                FilterDownloadsDownloadOn = null;
            }

            SearchDownloads();
        }

        private static DataTable DataTableDownloads { get; } = DataExtensions.CreateDataTable(
            [
                new("ModId", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_PLATFORM"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_DOWNLOADED_ON"), typeof(string))
            ]);

        private void LoadDownloadsCategories()
        {
            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                ComboBoxDownloadsFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void LoadDownloads()
        {
            LoadDownloadsCategories();

            GridViewDownloads.ShowLoadingPanel();

            DataTableDownloads.Rows.Clear();

            foreach (DownloadedItem downloadedItem in Settings.DownloadedMods)
            {
                Category category = Database.CategoriesData.GetCategoryById(downloadedItem.CategoryId);

                PackageItemData packageItemData = Database.GetPackage(downloadedItem.CategoryId, downloadedItem.Url);

                ModItemData modItemData = Database.GetModItem(downloadedItem.Platform, category.CategoryType, downloadedItem.ModId);

                if (modItemData != null)
                {
                    DataTableDownloads.Rows.Add(modItemData.Id,
                                                downloadedItem.Platform.Humanize(),
                                                category.Title,
                                                File.Exists(downloadedItem.FilePath) ? downloadedItem.DownloadFile.Name : $"{downloadedItem.DownloadFile.Name} ({ResourceLanguage.GetString("FILE_MISSING")})",
                                                modItemData.ModType,
                                                downloadedItem.DownloadFile.Region,
                                                downloadedItem.DownloadFile.Version,
                                                Settings.UseRelativeTimes ? downloadedItem.DateTime.Humanize() : $"{downloadedItem.DateTime:g}");
                }
                else if (packageItemData != null)
                {
                    DataTableDownloads.Rows.Add(modItemData.Id,
                                                        downloadedItem.Platform.Humanize(),
                                                        category.Title,
                                                        File.Exists(downloadedItem.FilePath) ? downloadedItem.DownloadFile.Name : $"{downloadedItem.DownloadFile.Name} ({ResourceLanguage.GetString("FILE_MISSING")})",
                                                        modItemData.ModType,
                                                        string.IsNullOrEmpty(downloadedItem.DownloadFile.Region) ? "n/a" : downloadedItem.DownloadFile.Region,
                                                        downloadedItem.DownloadFile.Version,
                                                        Settings.UseRelativeTimes ? downloadedItem.DateTime.Humanize() : $"{downloadedItem.DateTime:g}");
                }
            }

            GridControlDownloads.DataSource = DataTableDownloads;

            GridViewDownloads.FocusedRowHandle = -1;

            GridViewDownloads.Columns[0].Visible = false;

            GridViewDownloads.Columns[1].MinWidth = 122;
            GridViewDownloads.Columns[1].MaxWidth = 122;

            GridViewDownloads.Columns[2].MinWidth = 250;
            GridViewDownloads.Columns[2].MaxWidth = 250;

            //GridViewDownloads.Columns[3].MinWidth = 100; // Ignore column

            GridViewDownloads.Columns[4].MinWidth = 132;
            GridViewDownloads.Columns[4].MaxWidth = 132;

            GridViewDownloads.Columns[5].MinWidth = 110;
            GridViewDownloads.Columns[5].MaxWidth = 110;

            GridViewDownloads.Columns[6].MinWidth = 92;
            GridViewDownloads.Columns[6].MaxWidth = 92;

            GridViewDownloads.Columns[7].MinWidth = 100;
            GridViewDownloads.Columns[7].MaxWidth = 100;

            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;

            GridViewDownloads.HideLoadingPanel();
        }

        /// <summary>
        /// Search downloaded mods.
        /// </summary>
        private void SearchDownloads()
        {
            GridViewDownloads.ShowLoadingPanel();

            DataTableDownloads.Rows.Clear();

            foreach (DownloadedItem downloadedItem in Settings.DownloadedMods.FindAll(x =>
            x.Platform.Humanize().ContainsIgnoreCase(FilterDownloadsPlatform) &&
            x.DownloadFile.Name.ContainsIgnoreCase(FilterDownloadsFileName) &&
            x.CategoryId.ContainsIgnoreCase(FilterDownloadsCategoryId)))
            {
                Category category = Database.CategoriesData.GetCategoryById(downloadedItem.CategoryId);

                PackageItemData packageItemData = Database.GetPackage(downloadedItem.CategoryId, downloadedItem.Url);
                ModItemData modItemData = Database.GetModItem(downloadedItem.Platform, Database.CategoriesData.GetCategoryById(downloadedItem.CategoryId).CategoryType, downloadedItem.ModId);


                if (modItemData != null)
                {
                    if (modItemData.ModTypes.ToArray().AnyContainsIgnoreCase(FilterDownloadsModType) && modItemData.Regions.ToArray().AnyContainsIgnoreCase(FilterDownloadsRegion) && modItemData.Versions.ToArray().AnyContainsIgnoreCase(FilterDownloadsVersion))
                    {
                        bool shouldLoadDates = true;

                        if (FilterDownloadsDownloadOn != null)
                        {
                            if (FilterDownloadsDownloadOnType == FilterType.Equal && downloadedItem.DateTime == FilterDownloadsDownloadOn)
                            {
                                shouldLoadDates = true;
                            }
                            else if (FilterDownloadsDownloadOnType == FilterType.MoreThanOrEqual && downloadedItem.DateTime >= FilterDownloadsDownloadOn)
                            {
                                shouldLoadDates = true;
                            }
                            else if (FilterDownloadsDownloadOnType == FilterType.LessThanOrEqual && downloadedItem.DateTime <= FilterDownloadsDownloadOn)
                            {
                                shouldLoadDates = true;
                            }
                        }

                        if (shouldLoadDates)
                        {
                            DataTableDownloads.Rows.Add(modItemData.Id,
                                                        downloadedItem.Platform.Humanize(),
                                                        category.Title,
                                                        File.Exists(downloadedItem.FilePath) ? downloadedItem.DownloadFile.Name : $"{downloadedItem.DownloadFile.Name} ({ResourceLanguage.GetString("FILE_MISSING")})",
                                                        modItemData.ModType,
                                                        string.IsNullOrEmpty(downloadedItem.DownloadFile.Region) ? "n/a" : downloadedItem.DownloadFile.Region,
                                                        downloadedItem.DownloadFile.Version,
                                                        Settings.UseRelativeTimes ? downloadedItem.DateTime.Humanize() : $"{downloadedItem.DateTime:g}");
                        }
                    }
                }
                else if (packageItemData != null)
                {
                    if (FilterDownloadsModType == string.Empty && FilterDownloadsRegion == string.Empty && FilterDownloadsVersion == string.Empty)
                    {
                        bool shouldLoadDates = true;

                        if (FilterDownloadsDownloadOn != null)
                        {
                            if (FilterDownloadsDownloadOnType == FilterType.Equal && downloadedItem.DateTime == FilterDownloadsDownloadOn)
                            {
                                shouldLoadDates = true;
                            }
                            else if (FilterDownloadsDownloadOnType == FilterType.MoreThanOrEqual && downloadedItem.DateTime >= FilterDownloadsDownloadOn)
                            {
                                shouldLoadDates = true;
                            }
                            else if (FilterDownloadsDownloadOnType == FilterType.LessThanOrEqual && downloadedItem.DateTime <= FilterDownloadsDownloadOn)
                            {
                                shouldLoadDates = true;
                            }
                        }

                        if (shouldLoadDates)
                        {
                            DataTableDownloads.Rows.Add(modItemData.Id,
                                                        downloadedItem.Platform.Humanize(),
                                                        category.Title,
                                                        File.Exists(downloadedItem.FilePath) ? downloadedItem.DownloadFile.Name : $"{downloadedItem.DownloadFile.Name} ({ResourceLanguage.GetString("FILE_MISSING")})",
                                                        modItemData.ModType,
                                                        string.IsNullOrEmpty(downloadedItem.DownloadFile.Region) ? "n/a" : downloadedItem.DownloadFile.Region,
                                                        downloadedItem.DownloadFile.Version,
                                                        Settings.UseRelativeTimes ? downloadedItem.DateTime.Humanize() : $"{downloadedItem.DateTime:g}");
                        }

                        //continue;
                    }
                }
            }

            GridControlDownloads.DataSource = DataTableDownloads;

            GridViewDownloads.FocusedRowHandle = -1;
            GridViewDownloads.MoveFirst();

            TileItemDownloadsOpenFile.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;

            GridViewDownloads.HideLoadingPanel();
        }

        private void GridViewDownloads_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (SelectedDownloadId != -1)
            {
                if (GridViewDownloads.RowCount > 0)
                {
                    SelectedDownloadId = (int)GridViewDownloads.GetRowCellValue(e.FocusedRowHandle, GridViewDownloads.Columns[0]);
                }
            }

            TileItemDownloadsOpenFile.Enabled = e.FocusedRowHandle != -1;
            TileItemDownloadsDeleteItem.Enabled = e.FocusedRowHandle != -1;
            TileItemDownloadsViewDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewDownloads_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedDownloadId = (int)GridViewDownloads.GetRowCellValue(info.RowHandle, GridViewDownloads.Columns[0]);
            }

            TileItemDownloadsOpenFile.Enabled = SelectedDownloadId != -1;
            TileItemDownloadsDeleteItem.Enabled = SelectedDownloadId != -1;
            TileItemDownloadsViewDetails.Enabled = SelectedDownloadId != -1;
        }

        private void GridViewDownloads_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedDownloadId != -1)
            {
                int modId = int.Parse(GridViewDownloads.GetFocusedRowCellDisplayText(GridViewDownloads.Columns[0]));
                Platform platform = GridViewDownloads.GetFocusedRowCellDisplayText(GridViewDownloads.Columns[1]).DehumanizeTo<Platform>();
                string category = GridViewDownloads.GetFocusedRowCellDisplayText(GridViewDownloads.Columns[2]);

                ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryByTitle(category).CategoryType, modId);

                ShowDetails(platform, category, modId);
            }
        }

        #endregion

        #region Installed Files Page

        private int SelectedInstalledFilesModId = -1;

        private void TileItemInstalledFilesDeleteItem_ItemClick(object sender, TileItemEventArgs e)
        {
            if (GridViewInstalledFiles.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE_ITEM"), ResourceLanguage.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int consoleId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[0]));
                    int modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]));
                    Platform platform = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[2]).DehumanizeTo<Platform>();

                    InstalledModInfo installedModInfo = Settings.ConsoleProfiles.Find(x => x.Platform == platform && x.Id == consoleId).InstalledMods.Find(x => x.ModId == modId);
                    Settings.ConsoleProfiles.Find(x => x.Platform == platform && x.Id == consoleId).InstalledMods.Remove(installedModInfo);
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("DELETE_ITEM_SUCCESS"), ResourceLanguage.GetString("DELETED"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void TileItemInstalledFilesViewDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            // Check if ModId has custom mods format and then get the ModId from it otherwise get it as normal
            int modId;
            bool isCustom = false;

            if (GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Contains("|"))
            {
                modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Split('|')[1]);
                isCustom = true;
            }
            else
            {
                modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]));
            }

            if (isCustom)
            {
                CustomItemData customItemData = Settings.GetCustomMod(modId);

                if (customItemData != null)
                {
                    ShowCustomModDetails(modId);
                }
            }
            else
            {
                Platform platform = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[2]).DehumanizeTo<Platform>();
                string category = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[3]);

                ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryByTitle(category).CategoryType, modId);

                if (modItemData != null)
                {
                    ShowDetails(modItemData.GetPlatform(), category, modItemData.Id);
                }
            }
        }

        private void TileItemInstalledFilesUninstallItem_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedInstalledFilesModId != -1)
            {
                if (GridViewInstalledFiles.RowCount > 0)
                {
                    // Check if ModId has custom mods format and then get the ModId from it otherwise get it as normal
                    int modId;
                    bool isCustom = false;

                    if (GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Contains("|"))
                    {
                        modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Split('|')[1]);
                        isCustom = true;
                    }
                    else
                    {
                        modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]));
                    }

                    int consoleId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[0]));

                    foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles.FindAll(x => x.Id == consoleId))
                    {
                        foreach (InstalledModInfo installedModInfo in consoleProfile.InstalledMods)
                        {
                            if (!IsConsoleConnected && ConsoleProfile == null)
                            {
                                XtraMessageBox.Show(this, string.Format(ResourceLanguage.GetString("UNINSTALL_CONNECTION_REQUIREMENT"), consoleProfile.Name, consoleProfile.Platform.Humanize()), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else if (IsConsoleConnected && ConsoleProfile.Id != consoleProfile.Id)
                            {
                                XtraMessageBox.Show(this, string.Format(ResourceLanguage.GetString("UNINSTALL_CONNECT_TO_REQUIRED_CONSOLE"), consoleProfile.Name, consoleProfile.Platform.Humanize()), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            if (isCustom)
                            {
                                if (installedModInfo.IsCustom)
                                {
                                    CustomItemData customItemData = Settings.GetCustomMod(installedModInfo.ModId);

                                    if (modId == installedModInfo.ModId)
                                    {
                                        ShowTransferCustomModsDialog(this, TransferType.UninstallCustom, customItemData);
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Platform platform = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[2]).DehumanizeTo<Platform>();
                                string category = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[3]);

                                if (installedModInfo.Platform == platform && installedModInfo.ModId == modId) //&& installedModInfo.CategoryId == Database.CategoriesData.GetCategoryByTitle(category).Id)
                                {
                                    if (platform is Platform.PS3 or Platform.XBOX360)
                                    {
                                        ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                                        ShowTransferModsDialog(this, TransferType.UninstallMods, modItemData, null, installedModInfo == null ? string.Empty : ((DownloadFiles)installedModInfo.DownloadFiles).Region);
                                        break;
                                    }
                                    else if (platform == Platform.PS4)
                                    {
                                        AppItemData appItemData = Database.HomebrewPS4.GetModById(installedModInfo.ModId);

                                        ShowTransferHomebrewPS4FileDialog(this, TransferType.UninstallApplication, appItemData);
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    LoadInstalledMods();
                }
            }
        }

        /// <summary>
        /// Get/set the playform for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsPlatform { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the playform for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsCategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the file name for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the mod type for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsRegion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsVersion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the date time for filtering installed mods.
        /// </summary>
        private int? FilterInstalledModsTotalFiles { get; set; } = null;

        /// <summary>
        /// Get/set the date time type for filtering installed mods.
        /// </summary>
        private FilterType FilterInstalledModsTotalFilesType { get; set; } = FilterType.Equal;

        /// <summary>
        /// Get/set the date time for filtering installed mods.
        /// </summary>
        private DateTime? FilterInstalledModsInstalledOn { get; set; } = null;

        /// <summary>
        /// Get/set the date time type for filtering installed mods.
        /// </summary>
        private FilterType FilterInstalledModsInstalledOnType { get; set; } = FilterType.Equal;

        private void ComboBoxInstalledModsFilterPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsPlatform = ComboBoxInstalledFilesFilterPlatform.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledFilesFilterPlatform.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxInstalledFilesFilterCategory.SelectedIndex is (-1) or 0)
            {
                FilterInstalledModsCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxInstalledFilesFilterCategory.SelectedItem as string;
                FilterInstalledModsCategoryId = Database.CategoriesData.GetCategoryByTitle(selectedCategory).Id;
            }

            SearchInstalledMods();
        }

        private void TextBoxInstalledModsFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterInstalledModsName = TextBoxInstalledFilesFilterName.Text;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsType = ComboBoxInstalledFilesFilterType.SelectedIndex == 0 | ComboBoxInstalledFilesFilterType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledFilesFilterType.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsRegion = ComboBoxInstalledFilesFilterRegion.SelectedIndex == 0 | ComboBoxInstalledFilesFilterRegion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledFilesFilterRegion.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsVersion = ComboBoxInstalledFilesFilterVersion.SelectedIndex == 0 | ComboBoxInstalledFilesFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledFilesFilterVersion.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ImageInstalledModsFilterTotalFilesType_Click(object sender, EventArgs e)
        {
            if (FilterInstalledModsTotalFilesType == FilterType.Equal)
            {
                FilterInstalledModsTotalFilesType = FilterType.MoreThanOrEqual;
                ImageInstalledModsFilterTotalFilesType.Image = Properties.Resources.more_or_equal;
            }
            else if (FilterInstalledModsTotalFilesType == FilterType.MoreThanOrEqual)
            {
                FilterInstalledModsTotalFilesType = FilterType.LessThanOrEqual;
                ImageInstalledModsFilterTotalFilesType.Image = Properties.Resources.less_or_equal;
            }
            else if (FilterInstalledModsTotalFilesType == FilterType.LessThanOrEqual)
            {
                FilterInstalledModsTotalFilesType = FilterType.Equal;
                ImageInstalledModsFilterTotalFilesType.Image = Properties.Resources.equal_sign;
            }

            SearchInstalledMods();
        }

        private void NumericBoxInstalledModsFilterTotalFiles_Properties_EditValueChanged(object sender, EventArgs e)
        {
            FilterInstalledModsTotalFiles = NumericBoxInstalledFilesFilterTotalFiles.Value <= -1
                ? null
                : ((int)NumericBoxInstalledFilesFilterTotalFiles.Value);

            SearchInstalledMods();
        }

        private void ImageInstalledModsFilterInstalledOnType_Click(object sender, EventArgs e)
        {
            if (FilterInstalledModsTotalFilesType == FilterType.Equal)
            {
                FilterInstalledModsInstalledOnType = FilterType.MoreThanOrEqual;
                ImageInstalledModsFilterInstalledOnType.Image = Properties.Resources.more_or_equal;
            }
            else if (FilterInstalledModsTotalFilesType == FilterType.MoreThanOrEqual)
            {
                FilterInstalledModsInstalledOnType = FilterType.LessThanOrEqual;
                ImageInstalledModsFilterInstalledOnType.Image = Properties.Resources.less_or_equal;
            }
            else if (FilterInstalledModsTotalFilesType == FilterType.LessThanOrEqual)
            {
                FilterInstalledModsInstalledOnType = FilterType.Equal;
                ImageInstalledModsFilterInstalledOnType.Image = Properties.Resources.equal_sign;
            }

            SearchInstalledMods();
        }

        private void DateTimeInstalledModsFilterInstalledOn_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTimeInstalledFilesFilterInstalledOn.Text.ToString().IsValidDate("MM/dd/yyyy"))
            {
                FilterInstalledModsInstalledOn = DateTime.Parse(DateTimeInstalledFilesFilterInstalledOn.EditValue.ToString());
                SearchInstalledMods();
            }
            else
            {
                DateTimeInstalledFilesFilterInstalledOn.EditValue = null;
                FilterInstalledModsInstalledOn = null;
                SearchInstalledMods();
            }
        }

        private void LoadInstalledModsCategories()
        {
            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                ComboBoxInstalledFilesFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableInstalledMods { get; } = DataExtensions.CreateDataTable(
            [
                new("ProfileId", typeof(int)),
                new("ModId", typeof(string)),
                new(ResourceLanguage.GetString("LABEL_PLATFORM"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_TOTAL_FILES"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_INSTALLED_ON"), typeof(string))
            ]);

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void LoadInstalledMods()
        {
            LoadInstalledModsCategories();

            GridViewInstalledFiles.ShowLoadingPanel();

            DataTableInstalledMods.Rows.Clear();

            int totalFiles = 0;

            foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
            {
                foreach (InstalledModInfo installedModInfo in consoleProfile.InstalledMods)
                {
                    //ModItemData modItemData = installedModInfo.Platform == Platform.PS3
                    //    ? Database.ModsPS3(Database).GetModById(installedModInfo.Platform, installedModInfo.ModId)
                    //    : Database.GameModsXboxXBOX.GetModById(installedModInfo.Platform, installedModInfo.ModId);

                    if (installedModInfo.IsCustom)
                    {
                        CustomItemData customMod = Settings.GetCustomMod(installedModInfo.ModId);

                        Category modCategory = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                        DataTableInstalledMods.Rows.Add(consoleProfile.Id,
                                                        "custom|" + customMod.Id.ToString(),
                                                        installedModInfo.Platform.Humanize(),
                                                        modCategory.Title,
                                                        ((DownloadFiles)installedModInfo.DownloadFiles).Name,
                                                        customMod.ModType,
                                                        string.IsNullOrEmpty(((DownloadFiles)installedModInfo.DownloadFiles).Region) ? "n/a" : ((DownloadFiles)installedModInfo.DownloadFiles).Region,
                                                        ((DownloadFiles)installedModInfo.DownloadFiles).Version,
                                                        $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? $" {ResourceLanguage.GetString("FILES")}" : $" {ResourceLanguage.GetString("FILE")}")}",
                                                        Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");
                    }
                    else
                    {
                        ModItemData modItemData = Database.GetModItem(installedModInfo.Platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                        Category modCategory = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                        DataTableInstalledMods.Rows.Add(consoleProfile.Id,
                                                        modItemData.Id.ToString(),
                                                        installedModInfo.Platform.Humanize(),
                                                        modCategory.Title,
                                                        ((DownloadFiles)installedModInfo.DownloadFiles).Name,
                                                        modItemData.ModType,
                                                        string.IsNullOrEmpty(((DownloadFiles)installedModInfo.DownloadFiles).Region) ? "n/a" : ((DownloadFiles)installedModInfo.DownloadFiles).Region,
                                                        ((DownloadFiles)installedModInfo.DownloadFiles).Version,
                                                        $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? $" {ResourceLanguage.GetString("FILES")}" : $" {ResourceLanguage.GetString("FILE")}")}",
                                                        Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");
                    }

                    totalFiles += installedModInfo.TotalFiles;
                }
            }

            GridControlInstalledFiles.DataSource = DataTableInstalledMods;

            GridViewInstalledFiles.FocusedRowHandle = -1;

            GridViewInstalledFiles.Columns[0].Visible = false;
            GridViewInstalledFiles.Columns[1].Visible = false;

            GridViewInstalledFiles.Columns[2].MinWidth = 122;
            GridViewInstalledFiles.Columns[2].MaxWidth = 122;

            GridViewInstalledFiles.Columns[3].MinWidth = 250;
            GridViewInstalledFiles.Columns[3].MaxWidth = 250;

            //GridViewInstalledMods.Columns[4].MinWidth = 80;
            //GridViewInstalledMods.Columns[4].MaxWidth = 80;

            GridViewInstalledFiles.Columns[5].MinWidth = 132;
            GridViewInstalledFiles.Columns[5].MaxWidth = 132;

            GridViewInstalledFiles.Columns[6].MinWidth = 110;
            GridViewInstalledFiles.Columns[6].MaxWidth = 110;

            GridViewInstalledFiles.Columns[7].MinWidth = 92;
            GridViewInstalledFiles.Columns[7].MaxWidth = 92;

            GridViewInstalledFiles.Columns[8].MinWidth = 94;
            GridViewInstalledFiles.Columns[8].MaxWidth = 94;

            GridViewInstalledFiles.Columns[9].MinWidth = 100;
            GridViewInstalledFiles.Columns[9].MaxWidth = 100;

            //TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            //TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;

            GridViewInstalledFiles.HideLoadingPanel();
        }

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void SearchInstalledMods()
        {
            GridViewInstalledFiles.ShowLoadingPanel();

            DataTableInstalledMods.Rows.Clear();

            foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles.Where(x => x.Platform.Humanize() == FilterInstalledModsPlatform))
            {
                foreach (InstalledModInfo installedModInfo in consoleProfile.InstalledMods.Where(x => x.CategoryId == FilterInstalledModsCategoryId)) //&& x.Name.ContainsIgnoreCaseSymbols(FilterInstalledModsName))
                {
                    Category category = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                    ModItemData modItemData = Database.GetModItem(installedModInfo.Platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                    if (!modItemData.Name.ContainsIgnoreCaseSymbols(FilterInstalledModsName))
                    {
                        continue;
                    }

                    bool shouldLoadFiles = true;

                    if (FilterInstalledModsTotalFiles != null)
                    {
                        if (FilterInstalledModsTotalFilesType == FilterType.Equal && installedModInfo.TotalFiles == FilterInstalledModsTotalFiles)
                        {
                            shouldLoadFiles = true;
                        }
                        else if (FilterInstalledModsTotalFilesType == FilterType.MoreThanOrEqual && installedModInfo.TotalFiles >= FilterInstalledModsTotalFiles)
                        {
                            shouldLoadFiles = true;
                        }
                        else
                        {
                            shouldLoadFiles = FilterInstalledModsTotalFilesType == FilterType.LessThanOrEqual && installedModInfo.TotalFiles <= FilterInstalledModsTotalFiles;
                        }
                    }

                    bool shouldLoadDates = true;

                    if (FilterInstalledModsInstalledOn != null)
                    {
                        if (FilterPackagesModifiedDateType == FilterType.Equal && installedModInfo.DateInstalled == FilterPackagesModifiedDate)
                        {
                            shouldLoadDates = true;
                        }
                        else if (FilterPackagesModifiedDateType == FilterType.MoreThanOrEqual && installedModInfo.DateInstalled >= FilterPackagesModifiedDate)
                        {
                            shouldLoadDates = true;
                        }
                        else
                        {
                            shouldLoadDates = FilterPackagesModifiedDateType == FilterType.LessThanOrEqual && installedModInfo.DateInstalled <= FilterPackagesModifiedDate;
                        }
                    }

                    if (shouldLoadFiles && shouldLoadDates)
                    {
                        DataTableInstalledMods.Rows.Add(consoleProfile.Id,
                                                        modItemData.Id.ToString(),
                                                        installedModInfo.Platform.Humanize(),
                                                        category.Title,
                                                        ((DownloadFiles)installedModInfo.DownloadFiles).Name,
                                                        modItemData.ModType,
                                                        string.IsNullOrEmpty(((DownloadFiles)installedModInfo.DownloadFiles).Region) ? "n/a" : ((DownloadFiles)installedModInfo.DownloadFiles).Region,
                                                        ((DownloadFiles)installedModInfo.DownloadFiles).Version,
                                                        $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? $" {ResourceLanguage.GetString("FILES")}" : $" {ResourceLanguage.GetString("FILE")}")}",
                                                        Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");
                    }
                }
            }

            GridControlInstalledFiles.DataSource = DataTableInstalledMods;

            GridViewInstalledFiles.FocusedRowHandle = -1;

            TileItemInstalledModsDeleteItem.Enabled = GridViewInstalledFiles.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledFiles.SelectedRowsCount > 0;
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledFiles.SelectedRowsCount > 0;

            GridViewInstalledFiles.HideLoadingPanel();
        }

        private void GridViewInstalledMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (SelectedInstalledFilesModId != -1)
            {
                if (GridViewInstalledFiles.RowCount > 0)
                {
                    SelectedInstalledFilesModId =
                        GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Contains("|") ?
                        (int)GridViewInstalledFiles.GetRowCellValue(e.FocusedRowHandle, GridViewInstalledFiles.Columns[1]) :
                        int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]));
                }
            }

            TileItemInstalledModsDeleteItem.Enabled = GridViewInstalledFiles.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledFiles.SelectedRowsCount > 0;
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledFiles.SelectedRowsCount > 0;
        }

        private void GridViewInstalledMods_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedInstalledFilesModId =
                    GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Contains("|") ?
                    (int)GridViewInstalledFiles.GetRowCellValue(e.RowHandle, GridViewInstalledFiles.Columns[1]) :
                    int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]));
            }

            TileItemInstalledModsDeleteItem.Enabled = GridViewInstalledFiles.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledFiles.SelectedRowsCount > 0;
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledFiles.SelectedRowsCount > 0;
        }

        private void GridViewInstalledMods_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedInstalledFilesModId != -1)
            {
                if (GridViewInstalledFiles.RowCount > 0)
                {
                    // Check if ModId has custom mods format and then get the ModId from it otherwise get it as normal
                    int modId;
                    bool isCustom = false;

                    if (GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Contains("|"))
                    {
                        modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]).Split('|')[1]);
                        isCustom = true;
                    }
                    else
                    {
                        modId = int.Parse(GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[1]));
                    }

                    if (isCustom)
                    {
                        CustomItemData customItemData = Settings.GetCustomMod(modId);

                        if (customItemData != null)
                        {
                            ShowCustomModDetails(modId);
                        }
                    }
                    else
                    {
                        Platform platform = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[2]).DehumanizeTo<Platform>();
                        string category = GridViewInstalledFiles.GetFocusedRowCellDisplayText(GridViewInstalledFiles.Columns[3]);

                        ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryByTitle(category).CategoryType, modId);

                        if (modItemData != null)
                        {
                            ShowDetails(modItemData.GetPlatform(), category, modItemData.Id);
                        }
                    }
                }
            }
        }

        #endregion

        #region File Manager Page

        /// <summary>
        /// Get the user's local computer drives.
        /// </summary>
        private readonly DriveInfo[] LocalDrives = DriveInfo.GetDrives();

        /// <summary>
        /// Get/set the current local directory path.
        /// </summary>
        private string DirectoryPathLocal { get; set; } = @"C:\";

        /// <summary>
        /// Gets/set the current console directory path.
        /// </summary>
        private string DirectoryPathConsole { get; set; } = Platform == Platform.PS3 ? "/dev_hdd0/" : @"Hdd:\";

        /// <summary>
        /// </summary>
        private Image ImageFile => ImageCollection.Images["file"];

        /// <summary>
        /// </summary>
        private Image ImageFolder => ImageCollection.Images["folder"];

        /// <summary>
        /// </summary>
        private Image ImageFolderUp => ImageCollection.Images["folder up"];

        private void StartFileManager()
        {
            GridControlFileManagerLocalFiles.Focus();

            ButtonFileManagerConsoleAddToModules.Visible = Platform == Platform.XBOX360;

            SetConsoleStatus(ResourceLanguage.GetString("FETCHING_DRIVES"));

            foreach (DriveInfo driveInfo in LocalDrives)
            {
                ComboBoxFileManagerLocalDrives.Properties.Items.Add(driveInfo.Name.Replace(@"\", string.Empty));
            }

            switch (Settings.RememberLocalPath)
            {
                case true when Platform == Platform.PS3:
                    {
                        if (Settings.LocalPathPS3.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathPS3))
                        {
                            LoadLocalDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\");
                        }
                        else
                        {
                            LoadLocalDirectory(Settings.LocalPathPS3);
                        }

                        break;
                    }
                case true:
                    {
                        switch (Platform)
                        {
                            case Platform.XBOX360 when Settings.LocalPathXbox.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathXbox):
                                LoadLocalDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\");
                                break;
                            case Platform.XBOX360:
                                LoadLocalDirectory(Settings.LocalPathXbox);
                                break;
                        }

                        break;
                    }
                default:
                    LoadLocalDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\");
                    break;
            }

            //EnableFileManager(true);
            hadLoadedFileManager = true;
        }

        private void TimerLoadConsole_Tick(object sender, EventArgs e)
        {
            TimerLoadConsole.Enabled = false;

            SetConsoleStatus(ResourceLanguage.GetString("FETCHING_ROOT_DIRECTORIES"));

            switch (Platform)
            {
                case Platform.PS3:
                    {
                        foreach (ListItem driveName in FtpExtensions.GetFolderNames("/"))
                        {
                            ComboBoxFileManagerConsoleDrives.Properties.Items.Add(driveName.Name.Replace(@"/", string.Empty));
                        }

                        break;
                    }

                case Platform.XBOX360:
                    {
                        foreach (string drive in XboxConsole.Drives.Split(','))
                        {
                            bool isStartUppercase = char.IsUpper(drive.First());

                            if (isStartUppercase)
                            {
                                ComboBoxFileManagerConsoleDrives.Properties.Items.Add(drive.Transform(To.TitleCase));
                            }
                            else
                            {
                                ComboBoxFileManagerConsoleDrives.Properties.Items.Add(drive);
                            }
                        }

                        break;
                    }
            }

            SetConsoleStatus(ResourceLanguage.GetString("SUCCESS_ROOT_DIRECTORIES"));

            switch (Settings.RememberLocalPath)
            {
                case true:
                    switch (Platform)
                    {
                        case Platform.PS3:

                            if (Settings.ConsolePathPS3.Equals("/") || Settings.ConsolePathPS3.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory("/" + ComboBoxFileManagerConsoleDrives.Properties.Items[0] + "/");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathPS3);
                            }

                            break;

                        case Platform.XBOX360:

                            if (Settings.ConsolePathXbox.Equals(@"\") || Settings.ConsolePathXbox.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory(ComboBoxFileManagerConsoleDrives.Properties.Items[0] + @":\");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathXbox);
                            }

                            break;
                    }

                    break;
                case false:
                    switch (Platform)
                    {
                        case Platform.PS3:

                            LoadConsoleDirectory("/dev_hdd0/");
                            break;

                        case Platform.XBOX360:

                            LoadConsoleDirectory(ComboBoxFileManagerConsoleDrives.Properties.Items[0] + @":\");
                            break;
                    }
                    break;
            }

            TimerLoadConsole.Enabled = false;
        }

        private void EnableFileManager(bool enable)
        {
            PanelFileManager.Enabled = enable;
            ComboBoxFileManagerLocalDrives.Enabled = enable;
            TextBoxFileManagerLocalPath.Enabled = enable;
            ButtonFileManagerBrowseLocalDirectory.Enabled = enable;
            GridControlFileManagerLocalFiles.Enabled = enable;
            PanelFileManagerLocalButtons.Enabled = enable;

            ComboBoxFileManagerConsoleDrives.Enabled = enable;
            TextBoxFileManagerConsolePath.Enabled = enable;
            ButtonFileManagerConsoleNavigate.Enabled = enable;
            GridControlFileManagerConsoleFiles.Enabled = enable;
            PanelFileManagerConsoleButtons.Enabled = enable;

            if (!enable)
            {
                GridControlFileManagerLocalFiles.DataSource = null;
                GridControlFileManagerConsoleFiles.DataSource = null;
            }
        }

        GridHitInfo downHitInfo = null;

        #region Local File Explorer

        private void ComboBoxLocalDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocalDirectory(ComboBoxFileManagerLocalDrives.SelectedItem + @"\");
        }

        private void ButtonBrowseLocalDirectory_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowser = new() { ShowNewFolderButton = true };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                DirectoryPathLocal = folderBrowser.SelectedPath;

                if (Directory.Exists(folderBrowser.SelectedPath))
                {
                    LoadLocalDirectory(DirectoryPathLocal);
                }
            }
        }

        private DataTable DataTableLocalFiles { get; } = DataExtensions.CreateDataTable(
            [
                new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                new() { Caption = "", ColumnName = "Image", DataType = typeof(Image) },
                new() { Caption = ResourceLanguage.GetString("LABEL_NAME"), ColumnName = "Name", DataType = typeof(string) },
                new() { Caption = ResourceLanguage.GetString("LABEL_SIZE"), ColumnName = "Size", DataType = typeof(string) },
                new() { Caption = ResourceLanguage.GetString("LABEL_LAST_MODIFIED"), ColumnName = "Last Modified", DataType = typeof(string) }
            ]);

        /// <summary>
        /// Loads files and folders into the local gridview
        /// </summary>
        /// <param name="directoryPath"> </param>
        public void LoadLocalDirectory(string directoryPath)
        {
            try
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING"), $" '{directoryPath}'"));

                DataTableLocalFiles.Rows.Clear();

                DirectoryPathLocal = directoryPath.Replace(@"\\", @"\");
                TextBoxFileManagerLocalPath.Text = DirectoryPathLocal;

                ComboBoxFileManagerLocalDrives.SelectedIndexChanged -= ComboBoxLocalDrives_SelectedIndexChanged;
                ComboBoxFileManagerLocalDrives.SelectedItem = DirectoryPathLocal.Substring(0, 2);
                ComboBoxFileManagerLocalDrives.SelectedIndexChanged += ComboBoxLocalDrives_SelectedIndexChanged;

                bool isParentRoot = LocalDrives.Any(x => x.Name.Equals(DirectoryPathLocal.Replace(@"//", @"/")));

                switch (isParentRoot)
                {
                    case false:
                        DataTableLocalFiles.Rows.Add("folder",
                                                     ImageFolderUp,
                                                     "..",
                                                     string.Empty,
                                                     string.Empty);
                        break;
                }

                int folders = 0;
                int files = 0;
                long totalBytes = 0;

                //foreach (string directoryItem in Directory.GetDirectories(DirectoryPathLocal))
                foreach (string directoryItem in Directory.GetDirectories(DirectoryPathLocal))
                {
                    DataTableLocalFiles.Rows.Add("folder",
                                                 ImageFolder,
                                                 Path.GetFileName(directoryItem),
                                                 "<DIRECTORY>",
                                                 Directory.GetLastWriteTime(directoryItem));

                    folders++;
                }

                foreach (string fileItem in Directory.GetFiles(DirectoryPathLocal))
                {
                    long fileBytes = new FileInfo(fileItem).Length;

                    DataTableLocalFiles.Rows.Add("file",
                                        ImageFile,
                                        Path.GetFileName(fileItem),
                                        Settings.UseFormattedFileSizes ? fileBytes.Bytes().Humanize("#.##") : fileBytes + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                        File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                SetLocalStatus(ResourceLanguage.GetString("FETCHED_LISTING"));

                string statusFiles = files > 0
                    ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : string.Empty)}"
                    : string.Empty + $"{(folders < 1 ? "." : string.Empty)}";
                string statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : string.Empty;
                string statusTotalBytes = files > 0
                    ? $"Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " " + ResourceLanguage.GetString("LABEL_BYTES"))}"
                    : string.Empty;

                switch (files)
                {
                    case < 1 when folders < 1:
                        SetLocalStatus(ResourceLanguage.GetString("DIRECTORY_EMPTY"));
                        break;
                    default:
                        SetLocalStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                        break;
                }

                GridControlFileManagerLocalFiles.DataSource = DataTableLocalFiles;

                GridViewFileManagerConsoleFiles.FocusedRowHandle = -1;

                GridViewFileManagerLocalFiles.Columns[0].Visible = false;
                GridViewFileManagerLocalFiles.Columns[1].Caption = " ";
                GridViewFileManagerLocalFiles.Columns[1].MinWidth = 28;
                GridViewFileManagerLocalFiles.Columns[1].MaxWidth = 28;
                GridViewFileManagerLocalFiles.Columns[1].ImageOptions.Alignment = StringAlignment.Center;

                //GridViewLocalFiles.Columns[2].Width = 300;

                GridViewFileManagerLocalFiles.Columns[3].MinWidth = 150;
                GridViewFileManagerLocalFiles.Columns[3].MaxWidth = 150;

                GridViewFileManagerLocalFiles.Columns[4].MinWidth = 125;
                GridViewFileManagerLocalFiles.Columns[4].MaxWidth = 125;
            }
            catch (UnauthorizedAccessException ex)
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING_ERROR"), DirectoryPathLocal, ex.Message), ex);
            }
            catch (Exception ex)
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING_ERROR"), DirectoryPathLocal, ex.Message), ex);

                try
                {
                    // Attempt to load the parent directory listing instead
                    LoadLocalDirectory(Path.GetDirectoryName(DirectoryPathLocal) + @"\");
                }
                catch
                {
                    SetLocalStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING_ERROR"), Path.GetDirectoryName(DirectoryPathLocal) + @"\", ex.Message), ex);
                }
            }
        }

        private void GridViewLocalFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[0]);
                        string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[2]);

                        ButtonFileManagerLocalUpload.Enabled = type == "file" && name != "..";
                        ButtonFileManagerLocalDelete.Enabled = (type == "file") | (type == "folder") && name != "..";
                        ButtonFileManagerLocalRename.Enabled = (type == "file") | (type == "folder") && name != "..";
                        break;
                    }
            }
        }

        private void GridViewLocalFiles_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerLocalFiles.GetRowCellDisplayText(e.RowHandle, GridViewFileManagerLocalFiles.Columns[0]);
                        string name = GridViewFileManagerLocalFiles.GetRowCellDisplayText(e.RowHandle, GridViewFileManagerLocalFiles.Columns[2]);

                        ButtonFileManagerLocalUpload.Enabled = type == "file" && name != "..";
                        ButtonFileManagerLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
                        break;
                    }
            }
        }

        private void GridViewLocalFiles_DoubleClick(object sender, EventArgs e)
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[0]);
                        string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[2]);

                        switch (name)
                        {
                            case "..":
                                {
                                    string trimLastIndex = Path.GetDirectoryName(DirectoryPathLocal).TrimEnd('\\');
                                    string parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";

                                    if (Directory.Exists(parentDirectory))
                                    {
                                        LoadLocalDirectory(parentDirectory);
                                    }

                                    break;
                                }
                            default:
                                {
                                    switch (type)
                                    {
                                        case "folder":
                                            LoadLocalDirectory(DirectoryPathLocal + @"\" + name + @"\");
                                            break;
                                    }

                                    break;
                                }
                        }

                        ButtonFileManagerLocalOpenExplorer.Enabled = Directory.Exists(TextBoxFileManagerLocalPath.Text);
                        break;
                    }
            }
        }

        private void GridViewFileManagerLocalFiles_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

            if (ModifierKeys != Keys.None)
            {
                return;
            }

            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle)
            {
                downHitInfo = hitInfo;
            }
        }

        private void GridViewFileManagerLocalFiles_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.Copy);
                    downHitInfo = null;
                }
            }
        }

        private void GridControlFileManagerLocalFiles_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(GridHitInfo)))
            {
                if (e.Data.GetData(typeof(GridHitInfo)) is not GridHitInfo downHitInfo)
                {
                    return;
                }

                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));

                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle && hitInfo.RowHandle != GridControl.NewItemRowHandle)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void GridControlFileManagerLocalFiles_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = srcHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;

            UploadLocalFile();
        }

        private void ButtonLocalUpload_Click(object sender, EventArgs e)
        {
            UploadLocalFile();
        }

        private void ButtonLocalDelete_Click(object sender, EventArgs e)
        {
            DeleteLocalItem();
        }

        private void ButtonLocalRename_Click(object sender, EventArgs e)
        {
            string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[0]);

            switch (type)
            {
                case "folder":
                    RenameLocalFolder();
                    break;

                case "file":
                    RenameLocalFile();
                    break;
            }
        }

        private void ButtonLocalNewFolder_Click(object sender, EventArgs e)
        {
            CreateLocalFolder();
        }

        private void ButtonLocalRefresh_Click(object sender, EventArgs e)
        {
            LoadLocalDirectory(DirectoryPathLocal);
        }

        private void ButtonLocalOpenExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", TextBoxFileManagerLocalPath.Text);
            }
            catch (Exception ex)
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("UNABLE_TO_OPEN_EXPLORER"), TextBoxFileManagerLocalPath.Text, ex.Message), ex);
            }
        }

        public void CreateLocalFolder()
        {
            try
            {
                string newName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("ADD_NEW_FOLDER"), ResourceLanguage.GetString("FOLDER_NAME"));

                if (newName != null)
                {
                    string folderPath = TextBoxFileManagerLocalPath.Text + @"\" + newName;

                    if (Directory.Exists(folderPath))
                    {
                        XtraMessageBox.Show(ResourceLanguage.GetString("FOLDER_NAME_EXISTS"), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATING"), folderPath));
                        Directory.CreateDirectory(folderPath);
                        SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATED"), folderPath));
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATE_ERROR"), ex.Message), ex);
                XtraMessageBox.Show(string.Format(ResourceLanguage.GetString("FOLDER_CREATE_ERROR"), ex.Message), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UploadLocalFile()
        {
            try
            {
                string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[0]);
                string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[2]);

                switch (type)
                {
                    case "file":
                        {
                            string localPath = TextBoxFileManagerLocalPath.Text + name;
                            string consolePath = TextBoxFileManagerConsolePath.Text + name;

                            if (File.Exists(localPath))
                            {
                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FILE_UPLOADING"), consolePath));

                                switch (Platform)
                                {
                                    case Platform.PS3:
                                        FtpExtensions.UploadFile(localPath, consolePath);
                                        break;
                                    default:
                                        XboxConsole.SendFile(localPath, consolePath);
                                        break;
                                }

                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FILE_UPLOADED"), Path.GetFileName(localPath)));
                                LoadConsoleDirectory(DirectoryPathConsole);
                            }
                            else
                            {
                                SetLocalStatus(ResourceLanguage.GetString("FILE_UPLOAD_NOT_FOUND"));
                            }

                            break;
                        }
                    case "folder":
                        {
                            string localPath = TextBoxFileManagerLocalPath.Text + name + @"\";
                            string consolePath = TextBoxFileManagerConsolePath.Text + name;

                            SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_UPLOADING"), consolePath));

                            FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
                            SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_UPLOADED"), localPath));
                            LoadConsoleDirectory(DirectoryPathConsole);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("UPLOAD_ERROR"), ex.Message), ex);
            }
        }

        public void DeleteLocalItem()
        {
            try
            {
                if (XtraMessageBox.Show(ResourceLanguage.GetString("CONFIRM_DELETE_ITEM"), ResourceLanguage.GetString("DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[0]);
                    string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[2]);

                    switch (name.Equals(".."))
                    {
                        case false:
                            {
                                string selectedItem = TextBoxFileManagerLocalPath.Text + @"\" + name;

                                switch (type)
                                {
                                    case "folder":
                                        SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_DELETING"), selectedItem));
                                        UserFolders.DeleteDirectory(selectedItem);
                                        SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_DELETED"), name));
                                        break;
                                    case "file":
                                        {
                                            if (File.Exists(selectedItem))
                                            {
                                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FILE_DELETING"), selectedItem));
                                                File.Delete(selectedItem);
                                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FILE_DELETED"), name));
                                            }

                                            break;
                                        }
                                }

                                break;
                            }
                    }

                    GridViewFileManagerLocalFiles.DeleteRow(GridViewFileManagerLocalFiles.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus(string.Format(ResourceLanguage.GetString("DELETE_ITEM_ERROR"), ex.Message), ex);
            }
        }

        private void RenameLocalFile()
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string oldFileName = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[2]);
                        string oldFilePath = TextBoxFileManagerLocalPath.Text + @"\" + oldFileName;

                        string newFileName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("FILE_RENAME"), ResourceLanguage.GetString("FILE_NAME"), oldFileName).RemoveInvalidChars();

                        string newFilePath = TextBoxFileManagerLocalPath.Text + @"\" + newFileName;

                        if (newFileName != null && !newFileName.Equals(oldFileName))
                        {
                            if (File.Exists(newFilePath))
                            {
                                SetLocalStatus(ResourceLanguage.GetString("FILE_NAME_EXISTS"));
                            }
                            else
                            {
                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FILE_RENAMING"), newFileName));
                                FileSystem.RenameFile(oldFilePath, newFileName);
                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FILE_RENAMED"), newFileName));
                                LoadLocalDirectory(DirectoryPathLocal);
                            }
                        }

                        break;
                    }
            }
        }

        private void RenameLocalFolder()
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string oldFolderName = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText(GridViewFileManagerLocalFiles.Columns[2]);
                        string oldFolderPath = TextBoxFileManagerLocalPath.Text + @"\" + oldFolderName;

                        string newFolderName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("FOLDER_RENAME"), ResourceLanguage.GetString("FOLDER_NAME"), oldFolderName).RemoveInvalidChars();

                        string newFolderPath = TextBoxFileManagerLocalPath.Text + @"\" + newFolderName;

                        if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                        {
                            if (Directory.Exists(newFolderPath))
                            {
                                SetLocalStatus(ResourceLanguage.GetString("FOLDER_NAME_EXISTS"));
                            }
                            else
                            {
                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_RENAMING"), newFolderName));
                                FileSystem.RenameDirectory(oldFolderPath, newFolderName);
                                SetLocalStatus(string.Format(ResourceLanguage.GetString("FOLDER_RENAMED"), newFolderName));
                                LoadLocalDirectory(DirectoryPathLocal);
                            }
                        }

                        break;
                    }
            }
        }

        #endregion

        #region Console File Explorer

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Platform == Platform.PS3)
            {
                LoadConsoleDirectory("/" + ComboBoxFileManagerConsoleDrives.SelectedItem + "/");
            }
            else
            {
                LoadConsoleDirectory(ComboBoxFileManagerConsoleDrives.SelectedItem + @":\");
            }
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxFileManagerConsolePath.Text);
        }

        private DataTable DataTableConsoleFiles { get; } = DataExtensions.CreateDataTable(
            [
                new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                new() { Caption = "", ColumnName = "Image", DataType = typeof(Image) },
                new() { Caption = ResourceLanguage.GetString("LABEL_NAME"), ColumnName = "Name", DataType = typeof(string) },
                new() { Caption = ResourceLanguage.GetString("LABEL_SIZE"), ColumnName = "Size", DataType = typeof(string) },
                new() { Caption = ResourceLanguage.GetString("LABEL_LAST_MODIFIED"), ColumnName = "Last Modified", DataType = typeof(string) }
            ]);

        /// <summary>
        /// Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath"> Console path to retrieve </param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING"), $" '{directoryPath}'"));

                DataTableConsoleFiles.Rows.Clear();

                DirectoryPathConsole = Platform == Platform.PS3 ? directoryPath.Replace("//", "/") : directoryPath.Replace(@"\\", @"\");
                TextBoxFileManagerConsolePath.Text = DirectoryPathConsole;

                int secondIndexOfSlash = DirectoryPathConsole.TrimStart('/').IndexOfNth("/");
                int indexOfFirstColon = DirectoryPathConsole.IndexOfNth(":");
                string rootPath = Platform == Platform.PS3 ? DirectoryPathConsole.Substring(1, secondIndexOfSlash) : DirectoryPathConsole.Substring(0, indexOfFirstColon);

                ComboBoxFileManagerConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxFileManagerConsoleDrives.SelectedItem = Platform == Platform.PS3 ? rootPath.Replace("/", string.Empty) : rootPath.ToUpper().Replace(@"\", string.Empty);
                ComboBoxFileManagerConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                bool isRoot = Platform == Platform.PS3 ? ComboBoxFileManagerConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace("/", string.Empty)) : ComboBoxFileManagerConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace(":", string.Empty).Replace(@"\", string.Empty).ToUpper());

                if (!isRoot)
                {
                    DataTableConsoleFiles.Rows.Add("folder",
                                                   ImageCollection.Images[2],
                                                   "..",
                                                   string.Empty,
                                                   string.Empty);
                }

                if (Platform == Platform.PS3)
                {
                    FtpClient.SetWorkingDirectory(DirectoryPathConsole);

                    List<FtpListItem> folders = [];
                    List<FtpListItem> files = [];

                    int totalBytes = 0;

                    foreach (FtpListItem listItem in FtpClient.GetListing(DirectoryPathConsole))
                    {
                        switch (listItem.Type)
                        {
                            case FtpObjectType.Directory:
                                folders.Add(listItem);
                                break;

                            case FtpObjectType.File:
                                files.Add(listItem);
                                break;

                            case FtpObjectType.Link:
                                break;
                        }
                    }

                    foreach (FtpListItem listItem in folders.OrderBy(x => x.Name))
                    {
                        switch (DirectoryPathConsole)
                        {
                            case "/dev_hdd0/home/":
                                {
                                    string profileName = FtpExtensions.GetUserNameFromUserId(listItem.Name);
                                    DataTableConsoleFiles.Rows.Add("folder",
                                                                   ImageCollection.Images[1],
                                                                   $"{listItem.Name} ({profileName})",
                                                                   "<PROFILE>",
                                                                   listItem.Modified);
                                    break;
                                }
                            case "/dev_hdd0/game/":
                                {
                                    string gameTitle = Settings.AutoDetectGameTitles
                                        ? $" ({FtpExtensions.GetParamTitle($"/dev_hdd0/game/{listItem.Name}/PARAM.SFO")})"
                                        : string.Empty;
                                    DataTableConsoleFiles.Rows.Add("folder",
                                                                   ImageCollection.Images[0],
                                                                   $"{listItem.Name}{gameTitle}",
                                                                   "<UPDATE>",
                                                                   listItem.Modified);
                                    break;
                                }
                            default:
                                DataTableConsoleFiles.Rows.Add("folder",
                                                               ImageCollection.Images[1],
                                                               listItem.Name,
                                                               "<DIRECTORY>",
                                                               listItem.Modified);
                                break;
                        }
                    }

                    foreach (FtpListItem listItem in files.OrderBy(x => x.Name))
                    {
                        DataTableConsoleFiles.Rows.Add("file",
                                                       ImageFile,
                                                       listItem.Name,
                                                       Settings.UseFormattedFileSizes ? listItem.Size.Bytes().Humanize("#.##") : listItem.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       Settings.UseRelativeTimes ? listItem.Modified.Humanize() : listItem.Modified);

                        totalBytes += Convert.ToInt32(listItem.Size);
                    }

                    string statusFiles = files.Count > 0
                        ? $"{files.Count} {(files.Count == 1 ? ResourceLanguage.GetString("LABEL_FILE") : ResourceLanguage.GetString("LABEL_FILES"))} {(files.Count > 0 && folders.Count > 0 ? "&&" : string.Empty)} "
                        : $"{$"{(folders.Count == 0 ? "." : string.Empty)}"}";
                    string statusFolders = folders.Count > 0
                        ? $" {folders.Count} {(folders.Count == 1 ? ResourceLanguage.GetString("LABEL_DIRECTORY") : ResourceLanguage.GetString("LABEL_DIRECTORIES"))}."
                        : string.Empty;
                    string statusTotalBytes = totalBytes > 0
                        ? $" Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " " + ResourceLanguage.GetString("LABEL_BYTES"))}"
                        : string.Empty;

                    switch (files.Count)
                    {
                        case < 1 when folders.Count < 1:
                            SetConsoleStatus(ResourceLanguage.GetString("DIRECTORY_EMPTY"));
                            break;
                        default:
                            SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                            break;
                    }
                }
                else if (Platform == Platform.XBOX360)
                {
                    List<IXboxFile> files = [];
                    List<IXboxFile> folders = [];

                    long totalBytes = 0;

                    IXboxFiles xboxDirectories = XboxConsole.DirectoryFiles(DirectoryPathConsole);

                    foreach (IXboxFile directory in xboxDirectories)
                    {
                        if (directory.IsDirectory)
                        {
                            folders.Add(directory);
                        }
                    }

                    IXboxFiles xboxFiles = XboxConsole.DirectoryFiles(DirectoryPathConsole);

                    foreach (IXboxFile file in xboxFiles)
                    {
                        if (!file.IsDirectory)
                        {
                            files.Add(file);
                        }
                    }

                    foreach (IXboxFile folder in folders)
                    {
                        if (DirectoryPathConsole.ToLower().StartsWith(@"hdd:\content\"))
                        {
                            //int profileIndex = DirectoryPathConsole.Length - DirectoryPathConsole.TrimEnd('\\').IndexOf(@"\", 13) - 1;
                            //string profileName = DirectoryPathConsole.Substring(profileIndex, 16);
                            //bool isProfilePath = false;

                            //if (profileIndex == 16 && profileName != null)
                            //{
                            //    isProfilePath = true;
                            //}

                            //string gameTitle = isProfilePath && Settings.AutoDetectGameTitles
                            //           ? $" ({MainWindow.Database.GamesXBOXTitleIds.GetTitleFromTitleId(folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""))})"
                            //           : "";
                            string gameTitle = Settings.AutoDetectGameTitles
                                       ? $" ({Database.GamesTitleIdsXbox.GetTitleFromTitleId(folder.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty))})"
                                       : string.Empty;
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageCollection.Images[1],
                                                           $"{folder.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty)}{gameTitle}",
                                                           "<GAME>",
                                                           folder.ChangeTime);
                        }
                        else
                        {
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageCollection.Images[1],
                                                           folder.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty),
                                                           "<DIRECTORY>",
                                                           folder.ChangeTime);
                        }
                    }

                    foreach (IXboxFile file in files)
                    {
                        DataTableConsoleFiles.Rows.Add("file",
                                                       ImageCollection.Images[0],
                                                       file.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty),
                                                       Settings.UseFormattedFileSizes ? Convert.ToInt64(file.Size).Bytes().Humanize("#.##") : file.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       file.ChangeTime);

                        totalBytes += Convert.ToInt64(file.Size);
                    }

                    SetConsoleStatus(ResourceLanguage.GetString("FETCHED_LISTING"));

                    string statusFiles = files.Count > 0
                        ? $"{files.Count} {(files.Count == 1 ? ResourceLanguage.GetString("LABEL_FILE") : ResourceLanguage.GetString("LABEL_FILES"))} {(files.Count > 0 && folders.Count > 0 ? "&&" : string.Empty)} "
                        : $"{$"{(folders.Count == 0 ? "." : string.Empty)}"}";
                    string statusFolders = folders.Count > 0
                        ? $"{folders.Count} {(folders.Count == 1 ? ResourceLanguage.GetString("LABEL_DIRECTORY") : ResourceLanguage.GetString("LABEL_DIRECTORIES"))}."
                        : string.Empty;
                    string statusTotalBytes = totalBytes > 0
                        ? $"Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " " + ResourceLanguage.GetString("LABEL_BYTES"))}"
                        : string.Empty;

                    switch (files.Count)
                    {
                        case < 1 when folders.Count < 1:
                            SetConsoleStatus(ResourceLanguage.GetString("DIRECTORY_EMPTY"));
                            break;
                        default:
                            SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                            break;
                    }
                }

                GridControlFileManagerConsoleFiles.DataSource = DataTableConsoleFiles;

                GridViewFileManagerConsoleFiles.FocusedRowHandle = -1;

                GridViewFileManagerConsoleFiles.Columns[0].Visible = false;

                GridViewFileManagerConsoleFiles.Columns[1].Caption = " ";
                GridViewFileManagerConsoleFiles.Columns[1].MinWidth = 28;
                GridViewFileManagerConsoleFiles.Columns[1].MaxWidth = 28;
                GridViewFileManagerConsoleFiles.Columns[1].ImageOptions.Alignment = StringAlignment.Center;

                //GridViewConsoleFiles.Columns[2].Width = 300;

                GridViewFileManagerConsoleFiles.Columns[3].MinWidth = 150;
                GridViewFileManagerConsoleFiles.Columns[3].MaxWidth = 150;

                GridViewFileManagerConsoleFiles.Columns[4].MinWidth = 125;
                GridViewFileManagerConsoleFiles.Columns[4].MaxWidth = 125;
            }
            catch (FtpException ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING_ERROR"), DirectoryPathConsole, ex.Message), ex);
            }
            catch (Exception ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FETCHING_LISTING_ERROR"), DirectoryPathConsole, ex.Message), ex);
            }
        }

        private void GridViewConsoleFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewFileManagerConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[0]);
                        string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);

                        ButtonFileManagerConsoleDownload.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleRename.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleAddToModules.Enabled = type == "file" && name.EndsWith(".xex");

                        break;
                    }

                default:
                    ButtonFileManagerConsoleDownload.Enabled = false;
                    ButtonFileManagerConsoleDelete.Enabled = false;
                    ButtonFileManagerConsoleRename.Enabled = false;
                    ButtonFileManagerConsoleAddToModules.Enabled = false;
                    break;
            }
        }

        private void GridViewConsoleFiles_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewFileManagerConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[0]);
                        string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);

                        ButtonFileManagerConsoleDownload.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleRename.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleAddToModules.Enabled = type == "file" && name.EndsWith(".xex");

                        break;
                    }

                default:
                    ButtonFileManagerConsoleDownload.Enabled = false;
                    ButtonFileManagerConsoleDelete.Enabled = false;
                    ButtonFileManagerConsoleRename.Enabled = false;
                    ButtonFileManagerConsoleAddToModules.Enabled = false;
                    break;
            }
        }

        private void GridViewConsoleFiles_DoubleClick(object sender, EventArgs e)
        {
            switch (GridViewFileManagerConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[0]);
                        string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);

                        switch (name)
                        {
                            // Go to parent directory
                            case "..":
                                {

                                    string trimLastIndex;
                                    string parentDirectory;

                                    if (Platform == Platform.PS3)
                                    {
                                        trimLastIndex = Path.GetDirectoryName(DirectoryPathConsole).Replace(@"\", "/").TrimEnd('/');
                                        parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf("/")) + "/";
                                    }
                                    else
                                    {
                                        trimLastIndex = Path.GetDirectoryName(DirectoryPathConsole).Replace("/", @"\").TrimEnd('\\');
                                        parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";
                                    }

                                    LoadConsoleDirectory(parentDirectory);

                                    break;
                                }
                            // Go to selected directory
                            default:
                                {
                                    if (Platform == Platform.PS3)
                                    {
                                        switch (type)
                                        {
                                            // Go to selected folder directory
                                            case "folder" when DirectoryPathConsole == "/dev_hdd0/home/":
                                            case "folder" when DirectoryPathConsole == "/dev_hdd0/game/":
                                                LoadConsoleDirectory(DirectoryPathConsole + name.Split()[0] + "/");
                                                break;
                                            case "folder":
                                                LoadConsoleDirectory(DirectoryPathConsole + name + "/");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        switch (type)
                                        {
                                            // Go to selected folder directory
                                            //case "folder" when DirectoryPathConsole.ToLower().StartsWith(@"Hdd:\Content\".ToLower()):
                                            //    LoadConsoleDirectory(DirectoryPathConsole + name.Split()[0] + @"\");
                                            //    break;
                                            case "folder":
                                                LoadConsoleDirectory(DirectoryPathConsole + name + @"\");
                                                break;
                                        }
                                    }

                                    break;
                                }
                        }

                        break;
                    }
            }
        }

        private void GridViewFileManagerConsoleFiles_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

            if (ModifierKeys != Keys.None)
            {
                return;
            }

            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle)
            {
                downHitInfo = hitInfo;
            }
        }

        private void GridViewFileManagerConsoleFiles_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.Copy);
                    downHitInfo = null;
                }
            }
        }

        private void GridControlFileManagerConsoleFiles_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(GridHitInfo)))
            {
                if (e.Data.GetData(typeof(GridHitInfo)) is not GridHitInfo downHitInfo)
                {
                    return;
                }

                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle && hitInfo.RowHandle != GridControl.NewItemRowHandle)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void GridControlFileManagerConsoleFiles_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = srcHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;

            DownloadFromConsole();
        }

        private void ButtonConsoleDownload_Click(object sender, EventArgs e)
        {
            DownloadFromConsole();
        }

        private void ButtonConsoleDelete_Click(object sender, EventArgs e)
        {
            DeleteConsoleItem();
        }

        private void ButtonConsoleRename_Click(object sender, EventArgs e)
        {
            string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[0]);

            switch (type)
            {
                case "folder":
                    RenameConsoleFolder();
                    break;

                case "file":
                    RenameConsoleFile();
                    break;
            }
        }

        private void ButtonConsoleNewFolder_Click(object sender, EventArgs e)
        {
            CreateConsoleFolder();
        }

        private void ButtonConsoleRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(DirectoryPathConsole);
        }

        private void ButtonConsoleAddToModules_Click(object sender, EventArgs e)
        {
            string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);
            string fileName = name;

            if (XtraMessageBox.Show(ResourceLanguage.GetString("FILE_RENAME_MODULE"), ResourceLanguage.GetString("FILE_RENAME"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fileName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("FILE_RENAME"), ResourceLanguage.GetString("FILE_NAME"), name);

                if (fileName.IsNullOrEmpty() | fileName.IsNullOrWhiteSpace())
                {
                    XtraMessageBox.Show(ResourceLanguage.GetString("FILE_NAME_EMPTY"), ResourceLanguage.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (Settings.GameFilesXbox.Any(x => x.Name.EqualsIgnoreCase(fileName)))
            {
                XtraMessageBox.Show(ResourceLanguage.GetString("FILE_NAME_EXISTS_IN_MODULES"), ResourceLanguage.GetString("FILE_NAME_DUPLICATE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Settings.GameFilesXbox.Add(new()
            {
                Name = fileName,
                Value = DirectoryPathConsole + name
            });
        }

        public void DownloadFromConsole()
        {
            try
            {
                string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[0]);
                string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);

                string consoleFile = DirectoryPathConsole + name;
                string localFile = DirectoryPathLocal + name;

                switch (type)
                {
                    case "file":
                        {
                            SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_DOWNLOADING"), Path.GetFileName(localFile)));

                            switch (Platform)
                            {
                                case Platform.PS3:
                                    if (File.Exists(localFile))
                                    {
                                        File.Delete(localFile);
                                    }

                                    FtpClient.DownloadFile(localFile, consoleFile, FtpLocalExists.Overwrite);
                                    break;
                                case Platform.XBOX360:
                                    if (File.Exists(localFile))
                                    {
                                        File.Delete(localFile);
                                    }

                                    XboxConsole.ReceiveFile(localFile, consoleFile);
                                    break;
                            }

                            SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_DOWNLOADED"), Path.GetFileName(localFile)));
                            LoadLocalDirectory(DirectoryPathLocal);

                            break;
                        }
                    case "folder":
                        {
                            switch (Platform)
                            {
                                case Platform.PS3:
                                    {
                                        string consolePath = DirectoryPathConsole + name + "/";
                                        string localPath = DirectoryPathLocal + name;

                                        if (Directory.Exists(localPath))
                                        {
                                            UserFolders.DeleteDirectory(localPath);
                                        }

                                        SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_DOWNLOADING"), Path.GetFileName(consolePath)));
                                        FtpExtensions.DownloadDirectory(consolePath, localPath);
                                        LoadLocalDirectory(DirectoryPathLocal);
                                        SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_DOWNLOADED"), Path.GetFileName(localPath)));
                                        break;
                                    }

                                case Platform.XBOX360:
                                    break;
                            }

                            break;
                        }
                }

                LoadConsoleDirectory(DirectoryPathConsole);
            }
            catch (Exception ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_DOWNLOAD_ERROR"), ex.Message), ex);
            }
        }

        public void DeleteConsoleItem()
        {
            try
            {
                if (XtraMessageBox.Show(ResourceLanguage.GetString("CONFIRM_DELETE_ITEM"), ResourceLanguage.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[0]);
                    string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);

                    string itemPath = DirectoryPathConsole + name;

                    switch (type)
                    {
                        case "folder":
                            {
                                itemPath = DirectoryPathConsole switch
                                {
                                    "/dev_hdd0/home/" => DirectoryPathConsole + name.Split()[0],
                                    _ => itemPath
                                };

                                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_DELETING"), itemPath));

                                switch (Platform)
                                {
                                    case Platform.PS3:
                                        FtpExtensions.DeleteDirectory(itemPath);
                                        break;
                                    case Platform.XBOX360:
                                        XboxConsole.RemoveDirectory(itemPath);
                                        break;
                                }

                                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_DELETED"), itemPath));
                                break;
                            }
                        case "file":
                            SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_DELETING"), itemPath));

                            switch (Platform)
                            {
                                case Platform.PS3:
                                    FtpExtensions.DeleteFile(itemPath);
                                    break;
                                case Platform.XBOX360:
                                    XboxConsole.DeleteFile(itemPath);
                                    break;
                            }

                            SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_DELETED"), itemPath));
                            break;
                    }

                    GridViewFileManagerConsoleFiles.DeleteRow(GridViewFileManagerConsoleFiles.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("DELETE_ITEM_ERROR"), ex.Message), ex);
            }
        }

        private void RenameConsoleFile()
        {
            try
            {
                string oldFileName = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);
                string oldFilePath = TextBoxFileManagerConsolePath.Text + oldFileName;

                string newFileName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("FILE_RENAME"), ResourceLanguage.GetString("FILE_NAME"), oldFileName).RemoveInvalidChars();

                string newConsoleFilePath = TextBoxFileManagerConsolePath.Text + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_RENAMING"), newFileName));

                    switch (Platform)
                    {
                        case Platform.PS3:
                            if (FtpClient.FileExists(newConsoleFilePath))
                            {
                                SetConsoleStatus(ResourceLanguage.GetString("FILE_NAME_EXISTS"));
                                return;
                            }

                            FtpExtensions.RenameFileOrFolder(oldFilePath, newConsoleFilePath);
                            break;
                        case Platform.XBOX360:
                            bool fileNameExists = false;

                            foreach (IXboxFile file in XboxConsole.DirectoryFiles(DirectoryPathConsole))
                            {
                                if (!file.IsDirectory)
                                {
                                    if (file.Name.EqualsIgnoreCase(newFileName))
                                    {
                                        fileNameExists = true;
                                    }
                                }
                            }

                            if (fileNameExists)
                            {
                                SetConsoleStatus(ResourceLanguage.GetString("FILE_NAME_EXISTS"));
                                return;
                            }

                            XboxConsole.RenameFile(oldFilePath, newConsoleFilePath);
                            break;
                    }

                    SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_RENAMED"), newFileName));
                    LoadConsoleDirectory(DirectoryPathConsole);
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FILE_RENAME_ERROR"), ex.Message), ex);
            }
        }

        private void RenameConsoleFolder()
        {
            try
            {
                string oldFolderName = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText(GridViewFileManagerConsoleFiles.Columns[2]);
                string oldFileName = TextBoxFileManagerConsolePath.Text + oldFolderName;

                string newFolderName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("FOLDER_RENAME"), ResourceLanguage.GetString("FOLDER_NAME"), oldFolderName).RemoveInvalidChars();

                string newFolderPath = TextBoxFileManagerConsolePath.Text + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpClient.DirectoryExists(newFolderPath))
                    {
                        SetConsoleStatus(ResourceLanguage.GetString("FOLDER_NAME_EXISTS"));
                    }
                    else
                    {
                        SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_RENAMING"), newFolderName));

                        switch (Platform)
                        {
                            case Platform.PS3:
                                FtpExtensions.RenameFileOrFolder(oldFileName, newFolderPath);
                                break;
                            case Platform.XBOX360:
                                XboxConsole.RenameFile(oldFileName, newFolderName);
                                break;
                        }

                        SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_RENAMED"), newFolderName));
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_RENAME_ERROR"), ex.Message), ex);
            }
        }

        public void CreateConsoleFolder()
        {
            try
            {
                string folderName = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("FOLDER_CREATE"), ResourceLanguage.GetString("FOLDER_NAME"));

                if (folderName != null)
                {
                    string folderPath = DirectoryPathConsole + "/" + folderName;

                    if (FtpClient.DirectoryExists(folderPath))
                    {
                        XtraMessageBox.Show(ResourceLanguage.GetString("FOLDER_NAME_EXISTS"), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATING"), folderName));

                        switch (Platform)
                        {
                            case Platform.PS3:
                                FtpClient.CreateDirectory(folderPath, true);
                                break;
                            case Platform.XBOX360:
                                XboxConsole.MakeDirectory(folderPath.TrimStart('/').Replace("/", @"\"));
                                break;
                        }

                        SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATED"), folderName));
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (FtpException ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATE_ERROR"), ex.Message), ex);
                XtraMessageBox.Show(string.Format(ResourceLanguage.GetString("FOLDER_CREATE_ERROR"), ex.Message), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                SetConsoleStatus(string.Format(ResourceLanguage.GetString("FOLDER_CREATE_ERROR"), ex.Message), ex);
                XtraMessageBox.Show(string.Format(ResourceLanguage.GetString("FOLDER_CREATE_ERROR"), ex.Message), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        /// <summary>
        /// Set the current status in the local panel.
        /// </summary>
        /// <param name="status"> </param>
        /// <param name="ex"> </param>
        public void SetLocalStatus(string status, Exception ex = null)
        {
            LabelFileManagerLocalStatus.Text = status;

            switch (ex)
            {
                case null:
                    Program.Log.Info(status);
                    break;

                default:
                    Program.Log.Error(ex, status);
                    break;
            }

            Refresh();
        }

        /// <summary>
        /// Set the current status in the console panel.
        /// </summary>
        /// <param name="status"> </param>
        /// <param name="ex"> </param>
        public void SetConsoleStatus(string status, Exception ex = null)
        {
            LabelFileManagerConsoleStatus.Text = status;

            switch (ex)
            {
                case null:
                    Program.Log.Info(status);
                    break;

                default:
                    Program.Log.Error(ex, status);
                    break;
            }

            Refresh();
        }

        #endregion

        #region Settings Page

        private string CurrentLanguage { get; set; } = "English";

        private Dictionary<string, string> LanguageResources { get; } = new()
        {
            { "English", "ArisenStudio.Languages.en_US" },
            { "Español", "ArisenStudio.Languages.es_ES" },
            { "Português (Brasil)", "ArisenStudio.Languages.pt_BR" },
            { "Svenska", "ArisenStudio.Languages.sv_SE" },
            { "Türkçe", "ArisenStudio.Languages.tr_TR" },
            //{ "Português", "ArisenStudio.Languages.pt_PT" },
        };

        private void LoadLanguages()
        {
            ComboBoxSettingsLanguages.Properties.Items.Clear();

            foreach (KeyValuePair<string, string> language in LanguageResources)
            {
                ComboBoxSettingsLanguages.Properties.Items.Add(language.Key);
            }

            ComboBoxSettingsLanguages.SelectedItem = CurrentLanguage;
        }

        private string GetLanguageResource(string languageName)
        {
            foreach (KeyValuePair<string, string> item in LanguageResources)
            {
                if (item.Key == languageName)
                {
                    return item.Value;
                }
            }

            return null;
        }

        private void ChangeLanguage(string languageName)
        {
            try
            {
                ComboBoxSettingsLanguages.SelectedIndexChanged -= ComboBoxSettingsLanguages_SelectedIndexChanged;
                ComboBoxSettingsLanguages.SelectedItem = languageName;
                ComboBoxSettingsLanguages.SelectedIndexChanged += ComboBoxSettingsLanguages_SelectedIndexChanged;

                string languageResource = GetLanguageResource(languageName);

                if (languageResource.IsNullOrEmpty())
                {
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("LANGUAGE_HELP"), ResourceLanguage.GetString("LANGUAGE_NOT_SUPPORTED"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ComboBoxSettingsLanguages.SelectedItem = CurrentLanguage;
                    return;
                }
                else
                {
                    ResourceLanguage = new ResourceManager(languageResource, Assembly.GetExecutingAssembly());
                    CurrentLanguage = languageName;
                    Settings.Language = languageName;
                }
            }
            catch
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("LANGUAGE_HELP"), ResourceLanguage.GetString("LANGUAGE_NOT_SUPPORTED"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ComboBoxSettingsLanguages.SelectedItem = CurrentLanguage;
                return;
            }

            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(ResourceLanguage.BaseName.Replace("_", "-").Replace("ArisenStudio.Languages.", ""));

                // Ribbon Bar
                RibbonPageHome.Text = ResourceLanguage.GetString("HOME");
                RibbonPageTools.Text = ResourceLanguage.GetString("TOOLS");
                RibbonGroupConnection.Text = ResourceLanguage.GetString("CONNECTION");
                RibbonGroupConnsoleProfiles.Text = ResourceLanguage.GetString("CONSOLE_PROFILES");
                RibbonGroupQuickSettings.Text = ResourceLanguage.GetString("QUICK_SETTINGS");
                RibbonGroupModdingTools.Text = ResourceLanguage.GetString("MODDING_TOOLS");
                RibbonGroupWebManCommands.Text = ResourceLanguage.GetString("WEBMAN_COMMANDS");
                RibbonGroupXbdmCommands.Text = ResourceLanguage.GetString("XBDM_COMMANDS");

                // Connection
                ButtonConnectConsole.Caption = ResourceLanguage.GetString("CONNECT_CONSOLE");
                ButtonDisconnectConsole.Caption = ResourceLanguage.GetString("DISCONNECT_CONSOLE");

                // Console Profiles
                ButtonChangeProfile.Caption = ResourceLanguage.GetString("CHANGE_PROFILE");
                ButtonAddNewProfile.Caption = ResourceLanguage.GetString("ADD_NEW_PROFILE");
                ButtonScanXboxConsoles.Caption = ResourceLanguage.GetString("SCAN_XBOX_CONSOLES");
                ButtonEditProfiles.Caption = ResourceLanguage.GetString("EDIT_PROFILES");

                // Quick Settings
                ButtonHowToGuides.Caption = ResourceLanguage.GetString("HOW_TO_GUIDES");
                ButtonSetupWizard.Caption = ResourceLanguage.GetString("SETUP_WIZARD");
                ButtonDownloadsFolder.Caption = ResourceLanguage.GetString("DOWNLOADS_FOLDER");
                ButtonDiscordPresence.Caption = ResourceLanguage.GetString("DISCORD_RICH_PRESENCE");
                ButtonInstallModsToUSB.Caption = ResourceLanguage.GetString("INSTALL_MODS_TO_USB");
                ButtonAdvancedSettings.Caption = ResourceLanguage.GetString("ADVANCED_SETTINGS");

                // Help
                ButtonAbout.Caption = ResourceLanguage.GetString("ABOUT");
                ButtonOpenLogFile.Caption = ResourceLanguage.GetString("OPEN_LOG_FILE");
                ButtonOpenLogFolder.Caption = ResourceLanguage.GetString("OPEN_LOG_FOLDER");
                ButtonRequestMods.Caption = ResourceLanguage.GetString("REQUEST_MODS");
                ButtonSendFeedback.Caption = ResourceLanguage.GetString("SEND_FEEDBACK");

                // PS3 Tools
                ButtonToolsPsGameUpdates.Caption = ResourceLanguage.GetString("GAME_UPDATES");
                ButtonToolsPsBackupFilesManager.Caption = ResourceLanguage.GetString("BACKUP_FILES_MANAGER");
                ButtonToolsPsPackageManager.Caption = ResourceLanguage.GetString("PACKAGE_MANAGER");
                ButtonToolsPsConsoleManager.Caption = ResourceLanguage.GetString("CONSOLE_MANAGER");
                ButtonToolsPsGameRegions.Caption = ResourceLanguage.GetString("GAME_REGIONS");
                ButtonToolsPsBootPluginsEditor.Caption = ResourceLanguage.GetString("BOOT_PLUGINS_EDITOR");

                // Xbox Tools
                ButtonToolsXboxGameSaveResigner.Caption = ResourceLanguage.GetString("GAME_SAVE_RESIGNER");
                ButtonToolsXboxGamesLauncher.Caption = ResourceLanguage.GetString("GAMES_LAUNCHER");
                ButtonToolsXboxModuleLoader.Caption = ResourceLanguage.GetString("MODULE_LOADER");
                ButtonToolsXboxXuidSpoofer.Caption = ResourceLanguage.GetString("XUID_SPOOFER");
                ButtonToolsXboxDashlaunchEditor.Caption = ResourceLanguage.GetString("DASHLAUNCH_EDITOR");

                // PS3 webMAN Commands
                ButtonToolsPsPower.Caption = ResourceLanguage.GetString("POWER");
                ButtonToolsPsPowerShutdown.Caption = ResourceLanguage.GetString("SHUTDOWN");
                ButtonToolsPsPowerRestart.Caption = ResourceLanguage.GetString("RESTART");
                ButtonToolsPsPowerSoftReboot.Caption = ResourceLanguage.GetString("SOFT_REBOOT");
                ButtonToolsPsPowerHardReboot.Caption = ResourceLanguage.GetString("HARD_REBOOT");
                ButtonToolsPsPowerQuickReboot.Caption = ResourceLanguage.GetString("QUICK_REBOOT");
                ButtonToolsPsGames.Caption = ResourceLanguage.GetString("GAMES");
                ButtonToolsPsGamesMountBD.Caption = ResourceLanguage.GetString("MOUNT_BD");
                ButtonToolsPsGamesMountISO.Caption = ResourceLanguage.GetString("MOUNT_ISO");
                ButtonToolsPsGamesMountPSN.Caption = ResourceLanguage.GetString("MOUNT_PSN");
                ButtonToolsPsGamesUnmount.Caption = ResourceLanguage.GetString("UNMOUNT");
                ButtonToolsPsNotifyMessage.Caption = ResourceLanguage.GetString("NOTIFY_MESSAGE");
                ButtonToolsPsVirtualController.Caption = ResourceLanguage.GetString("VIRTUAL_CONTROLLER");

                // Xbox 360 Commands
                ButtonToolsXboxPower.Caption = ResourceLanguage.GetString("POWER");
                ButtonToolsXboxPowerShutdown.Caption = ResourceLanguage.GetString("SHUTDOWN");
                ButtonToolsXboxPowerSoftReboot.Caption = ResourceLanguage.GetString("SOFT_REBOOT");
                ButtonToolsXboxPowerHardReboot.Caption = ResourceLanguage.GetString("HARD_REBOOT");
                ButtonToolsXboxTakeScreenshot.Caption = ResourceLanguage.GetString("TAKE_SCREENSHOT");
                ButtonToolsXboxConsoleManager.Caption = ResourceLanguage.GetString("CONSOLE_MANAGER");
                ButtonToolsXboxNotifyMessage.Caption = ResourceLanguage.GetString("NOTIFY_MESSAGE");

                // Status Bar
                StatusLabelHeaderStatus.Caption = ResourceLanguage.GetString("STATUS");
                StatusLabelHeaderIsConnected.Caption = ResourceLanguage.GetString("NOT_CONNECTED");
                StatusLabelHeaderCurrentGame.Caption = ResourceLanguage.GetString("CURRENT_GAME");

                // Navigation Menu
                NavigationItemDashboard.Text = ResourceLanguage.GetString("NAVIGATION_DASHBOARD");
                NavigationItemInstalledFiles.Text = ResourceLanguage.GetString("NAVIGATION_INSTALLED_FILES");
                NavigationItemDownloads.Text = ResourceLanguage.GetString("NAVIGATION_DOWNLOADS");
                NavigationItemFileManager.Text = ResourceLanguage.GetString("NAVIGATION_FILE_MANAGER");
                NavigationItemSettings.Text = ResourceLanguage.GetString("NAVIGATION_SETTINGS");

                NavigationItemGameMods.Text = ResourceLanguage.GetString("NAVIGATION_GAME_MODS");
                NavigationItemHomebrew.Text = ResourceLanguage.GetString("NAVIGATION_HOMEBREW");
                NavigationItemResources.Text = ResourceLanguage.GetString("NAVIGATION_RESOURCES");
                NavigationItemPackages.Text = ResourceLanguage.GetString("NAVIGATION_PACKAGES");
                NavigationItemGameSaves.Text = ResourceLanguage.GetString("NAVIGATION_GAME_SAVES");
                NavigationItemGameCheats.Text = ResourceLanguage.GetString("NAVIGATION_GAME_CHEATS");

                // Dashboard
                LabelHeaderFavoriteGames.Text = ResourceLanguage.GetString("OUR_FAVORITE_GAMES");
                LabelHeaderFavoriteMods.Text = ResourceLanguage.GetString("OUR_FAVORITE_MODS");
                LabelHeaderRecentlyUpdated.Text = ResourceLanguage.GetString("RECENTLY_UPDATED");
                LabelHeaderAnnouncements.Text = ResourceLanguage.GetString("ANNOUNCEMENTS");
                LabelHeaderLatestNews.Text = ResourceLanguage.GetString("LATEST_NEWS");
                LabelHeaderChangeLog.Text = ResourceLanguage.GetString("CHANGE_LOG");
                ButtonChangeLogNext.Text = ResourceLanguage.GetString("LABEL_NEXT");
                ButtonChangeLogPrevious.Text = ResourceLanguage.GetString("LABEL_PREVIOUS");
                LoadStatistics();
                LoadNewsFeed();
                LoadAnnouncements();
                NoAnnouncements.LoadText();

                // Downloads
                TileItemDownloadsOpenFolder.Text = ResourceLanguage.GetString("OPEN_FOLDER");
                TileItemDownloadsOpenFile.Text = ResourceLanguage.GetString("OPEN_FILE");
                TileItemDownloadsDeleteItem.Text = ResourceLanguage.GetString("DELETE_ITEM");
                TileItemDownloadsViewDetails.Text = ResourceLanguage.GetString("VIEW_DETAILS");

                LabelDownloadsFilterPlatform.Text = ResourceLanguage.GetString("LABEL_PLATFORM");
                LabelDownloadsFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelDownloadsFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelDownloadsFilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelDownloadsFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelDownloadsFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelDownloadsFilterDownloadedOn.Text = ResourceLanguage.GetString("LABEL_DOWNLOADED_ON");

                // Installed Mods
                TileItemInstalledModsDeleteItem.Text = ResourceLanguage.GetString("DELETE_ITEM");
                TileItemInstalledModsUninstallItem.Text = ResourceLanguage.GetString("UNINSTALL_ITEM");
                TileItemInstalledModsViewDetails.Text = ResourceLanguage.GetString("VIEW_DETAILS");

                LabelInstalledModsFilterPlatform.Text = ResourceLanguage.GetString("LABEL_PLATFORM");
                LabelInstalledModsFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelInstalledModsFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelInstalledModsFilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelInstalledModsFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelInstalledModsFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelInstalledModsFilterTotalFiles.Text = ResourceLanguage.GetString("LABEL_TOTAL_FILES");
                LabelInstalledModsFilterInstalledOn.Text = ResourceLanguage.GetString("LABEL_INSTALLED_ON");

                // File Manager
                ButtonFileManagerLocalUpload.Text = ResourceLanguage.GetString("LABEL_UPLOAD");
                ButtonFileManagerLocalDelete.Text = ResourceLanguage.GetString("LABEL_DELETE");
                ButtonFileManagerLocalRename.Text = ResourceLanguage.GetString("LABEL_RENAME");
                ButtonFileManagerLocalNewFolder.Text = ResourceLanguage.GetString("LABEL_NEW_FOLDER");
                ButtonFileManagerLocalRefresh.Text = ResourceLanguage.GetString("LABEL_REFRESH");
                ButtonFileManagerLocalOpenExplorer.Text = ResourceLanguage.GetString("LABEL_OPEN_EXPLORER");

                ButtonFileManagerConsoleDownload.Text = ResourceLanguage.GetString("LABEL_DOWNLOAD");
                ButtonFileManagerConsoleDelete.Text = ResourceLanguage.GetString("LABEL_DELETE");
                ButtonFileManagerConsoleRename.Text = ResourceLanguage.GetString("LABEL_RENAME");
                ButtonFileManagerConsoleNewFolder.Text = ResourceLanguage.GetString("LABEL_NEW_FOLDER");
                ButtonFileManagerConsoleRefresh.Text = ResourceLanguage.GetString("LABEL_REFRESH");
                ButtonFileManagerConsoleAddToModules.Text = ResourceLanguage.GetString("LABEL_ADD_TO_MODULES");

                // Settings: Interface
                LabelSettingsLanguage.Text = ResourceLanguage.GetString("LANGUAGE");
                LabelSettingsHelpTranslate.Text = ResourceLanguage.GetString("HELP_TRANSLATE");

                LabelSettingsCustomization.Text = ResourceLanguage.GetString("CUSTOMIZATION");
                LabelSettingsUseFormattedFileSizes.Text = ResourceLanguage.GetString("USE_FORMATTED_FILE_SIZES");
                LabelSettingsUseRelativeTimes.Text = ResourceLanguage.GetString("USE_RELATIVE_TIMES");

                LabelSettingsAutomation.Text = ResourceLanguage.GetString("AUTOMATION");
                LabelSettingsInstallModsToUsbDevice.Text = ResourceLanguage.GetString("INSTALL_MODS_TO_LOCAL_USB");
                LabelSettingsInstallHomebrewToUsbDevice.Text = ResourceLanguage.GetString("INSTALL_HOMEBREW_TO_LOCAL_USB");
                LabelSettingsInstallResourcesToUsbDevice.Text = ResourceLanguage.GetString("INSTALL_RESOURCES_TO_LOCAL_USB");
                LabelSettingsInstallPackagesToUsbDevice.Text = ResourceLanguage.GetString("INSTALL_PACKAGES_TO_LOCAL_USB");
                LabelSettingsInstallGameSavesToUsbDevice.Text = ResourceLanguage.GetString("INSTALL_GAME_SAVES_TO_LOCAL_USB");
                LabelSettingsCleanUpFilesAfterInstalling.Text = ResourceLanguage.GetString("AUTO_DELETE_FILES_AFTER_INSTALLING");
                LabelSettingsShowGamesFromExternalDevices.Text = ResourceLanguage.GetString("SHOW_GAMES_IN_EXTERNAL_DEVICES");
                LabelSettingsAutoDetectGameRegions.Text = ResourceLanguage.GetString("AUTO_DETECT_GAME_REGIONS");
                LabelSettingsAutoDetectGameTitles.Text = ResourceLanguage.GetString("AUTO_DETECT_GAME_TITLES");
                LabelSettingsRememberGameRegions.Text = ResourceLanguage.GetString("REMEMBER_GAME_REGIONS_WHEN_INSTALLING");
                LabelSettingsAutoLoadDirectoryListings.Text = ResourceLanguage.GetString("AUTO_LOAD_DIRECTORY_LISTINGS");
                LabelSettingsRememberLocalPath.Text = ResourceLanguage.GetString("REMEMBER_LOCAL_DIRECTORY_PATH");
                LabelSettingsRememberConsolePath.Text = ResourceLanguage.GetString("REMEMBER_CONSOLE_DIRECTORY_PATH");

                // Settings: Files
                LabelSettingsPackagesFilePathPS3.Text = ResourceLanguage.GetString("PACKAGES_INSTALL_FILE_PATH");
                LabelSettingsPackagesFilePathPS4.Text = ResourceLanguage.GetString("PACKAGES_INSTALL_FILE_PATH");
                LabelSettingsLaunchIniFilePath.Text = ResourceLanguage.GetString("LAUNCH_FILE_PATH");

                // Settings: Paths
                LabelSettingsPathBaseDirectory.Text = ResourceLanguage.GetString("LABEL_BASE_DIRECTORY");
                LabelSettingsPathDownloads.Text = ResourceLanguage.GetString("LABEL_DOWNLOADS");
                LabelSettingsPathGameMods.Text = ResourceLanguage.GetString("LABEL_GAME_MODS");
                LabelSettingsPathPackages.Text = ResourceLanguage.GetString("LABEL_PACKAGES");
                LabelSettingsPathGameSaves.Text = ResourceLanguage.GetString("LABEL_GAME_SAVES");

                LabelSettingsReferToBaseDirectory.Text = ResourceLanguage.GetString("REFER_TO_BASE_DIRECTORY");
                LabelSettingsDirectoriesMustBeWritable.Text = ResourceLanguage.GetString("DIRECTORIES_MUST_BE_WRITABLE");

                // Settings: Discord
                LabelSettingsRichPresence.Text = ResourceLanguage.GetString("RICH_PRESENCE");
                LabelSettingsShowCurrentGamePlaying.Text = ResourceLanguage.GetString("SHOW_CURRENT_GAME_PLAYING");

                // Game Mods
                TileItemGameModsPS3ShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemGameModsPS3Sort.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelGameModsPS3FilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelGameModsPS3FilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelGameModsPS3FilterSystemType.Text = ResourceLanguage.GetString("LABEL_SYSTEM_TYPE");
                LabelGameModsPS3FilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelGameModsPS3FilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelGameModsPS3FilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelGameModsPS3FilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxGameModsPS3FilterStatus.Properties.Items.Clear();
                ComboBoxGameModsPS3FilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxGameModsPS3FilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxGameModsPS3FilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxGameModsPS3FilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Homebrew
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemHomebrewSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelHomebrewFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelHomebrewFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelHomebrewFilterSystemType.Text = ResourceLanguage.GetString("LABEL_SYSTEM_TYPE");
                LabelHomebrewFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelHomebrewFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxHomebrewFilterStatus.Properties.Items.Clear();
                ComboBoxHomebrewFilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxHomebrewFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxHomebrewFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxHomebrewFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Resources
                TileItemResourcesShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemResourcesSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelResourcesFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelResourcesFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelResourcesFilterSystemType.Text = ResourceLanguage.GetString("LABEL_SYSTEM_TYPE");
                LabelResourcesFilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelResourcesFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelResourcesFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxResourcesFilterStatus.Properties.Items.Clear();
                ComboBoxResourcesFilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxResourcesFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxResourcesFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxResourcesFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Packages
                TileItemPackagesSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelPackagesFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelPackagesFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelPackagesFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelPackagesFilterModifiedDate.Text = ResourceLanguage.GetString("LABEL_MODIFIED_DATE");
                LabelPackagesFilterFileSize.Text = ResourceLanguage.GetString("LABEL_FILE_SIZE");
                LabelPackagesFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxPackagesFilterStatus.Properties.Items.Clear();
                ComboBoxPackagesFilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxPackagesFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxPackagesFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxPackagesFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Homebrew (Xbox 360)
                TileItemGameModsXboxShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemGameModsXboxSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelGameModsXboxFilterGame.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelGameModsXboxFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelGameModsXboxFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelGameModsXboxFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxGameModsXboxFilterStatus.Properties.Items.Clear();
                ComboBoxGameModsXboxFilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxGameModsXboxFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxGameModsXboxFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxGameModsXboxFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Homebrew (PS4)
                TileItemHomebrewPS4ShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemHomebrewPS4SortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelHomebrewPS4FilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelHomebrewPS4FilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelHomebrewPS4FilterFwVersion.Text = ResourceLanguage.GetString("LABEL_FW_VERSION");
                LabelHomebrewPS4FilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelHomebrewPS4FilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxHomebrewPS4FilterStatus.Properties.Items.Clear();
                ComboBoxHomebrewPS4FilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxHomebrewPS4FilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxHomebrewPS4FilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxHomebrewPS4FilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Game Saves
                TileItemGameSavesSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelGameSavesFilterGame.Text = ResourceLanguage.GetString("LABEL_GAME");
                LabelGameSavesFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelGameSavesFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelGameSavesFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");

                // About
                LabelHeaderLibraries.Text = ResourceLanguage.GetString("LABEL_LIBRARIES");
                LabelAboutHeaderContributors.Text = ResourceLanguage.GetString("LABEL_CONTRIBUTORS");
                LabelHeaderTranslators.Text = ResourceLanguage.GetString("LABEL_TRANSLATORS");
            }
            catch (Exception ex)
            {
                SetStatus("Unable to change the language. Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "There was an issue changing the language. Error: " + ex.Message);
            }
        }

        private void ComboBoxSettingsLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSettingsLanguages.SelectedIndex != -1)
            {
                ChangeLanguage(ComboBoxSettingsLanguages.SelectedItem as string);
            }
        }

        private void LabelSettingsHelpTranslate_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start("https://crowdin.com/project/arisenstudio");
        }

        private void LoadSettings()
        {
            /* Appearance */

            // Customization
            ToggleSettingsUseFormattedFileSizes.IsOn = Settings.UseFormattedFileSizes;
            ToggleSettingsUseRelativeTimes.IsOn = Settings.UseRelativeTimes;

            // Automation
            ToggleSettingsAlwaysShowGamePlaying.IsOn = Settings.AlwaysShowCurrentGamePlaying;
            ToggleSettingsShowGamesFromExternalDevices.IsOn = Settings.ShowGamesFromExternalDevices;
            ToggleSettingsAutoDetectGameRegions.IsOn = Settings.AutoDetectGameRegions;
            ToggleSettingsAutoDetectGameTitles.IsOn = Settings.AutoDetectGameTitles;
            ToggleSettingsAutoLoadDirectoryListings.IsOn = Settings.AutoLoadDirectoryListings;
            ToggleSettingsRememberLocalPath.IsOn = Settings.RememberLocalPath;
            ToggleSettingsRememberConsolePath.IsOn = Settings.RememberConsolePath;

            /* Transfer */
            ToggleSettingsInstallModsToUsbDevice.IsOn = Settings.InstallGameModsToUsbDevice;
            ToggleSettingsInstallHomebrewToUsbDevice.IsOn = Settings.InstallHomebrewToUsbDevice;
            ToggleSettingsInstallResourcesToUsbDevice.IsOn = Settings.InstallResourcesToUsbDevice;
            ToggleSettingsInstallGameSavesToUsbDevice.IsOn = Settings.InstallGameSavesToUsbDevice;
            ToggleSettingsCleanUpLocalFilesAfterInstalling.IsOn = Settings.CleanUpLocalFilesAfterInstalling;
            ToggleSettingsRememberGameRegions.IsOn = Settings.RememberGameRegions;
            ToggleSettingsAlwaysBackupGameFiles.IsOn = Settings.AlwaysBackupGameFiles;


            /* Files */

            // Packages File Path PS3
            TextBoxSettingsPackagesInstallPathPS3.Text = Settings.PackageInstallPathPS3;

            // Packages File Path PS4
            TextBoxSettingsPackagesInstallPathPS4.Text = Settings.PackageInstallPathPS4;

            // Launch.ini File Path
            TextBoxSettingsLaunchIniFilePath.Text = Settings.LaunchIniFilePath;

            /* Paths */
            TextBoxSettingsPathBaseDirectory.Text = Settings.PathBaseDirectory;
            TextBoxSettingsPathDownloads.Text = Settings.PathDownloads;
            TextBoxSettingsPathGameMods.Text = Settings.PathGameMods;
            TextBoxSettingsPathHomebrew.Text = Settings.PathHomebrew;
            TextBoxSettingsPathResources.Text = Settings.PathResources;
            TextBoxSettingsPathPackages.Text = Settings.PathPackages;
            TextBoxSettingsPathGameSaves.Text = Settings.PathGameSaves;

            /* Discord */

            // RPC
            ToggleSettingsAlwaysShowPresence.Toggled -= ToggleSettingsAlwaysShowPresence_Toggled;
            ToggleSettingsAlwaysShowPresence.IsOn = Settings.AlwaysShowPresence;
            ToggleSettingsAlwaysShowPresence.Toggled += ToggleSettingsAlwaysShowPresence_Toggled;

            ToggleSettingsShowCurrentGamePlaying.Toggled -= ToggleSettingsShowCurrentGamePlaying_Toggled;
            ToggleSettingsShowCurrentGamePlaying.IsOn = Settings.ShowCurrentGamePlaying;
            ToggleSettingsShowCurrentGamePlaying.Toggled += ToggleSettingsShowCurrentGamePlaying_Toggled;

            if (Settings.AlwaysShowPresence || Settings.ShowCurrentGamePlaying)
            {
                EnableDiscordRpc();
            }
        }

        private DiscordRpcClient DiscordClient { get; set; } = null;

        private System.Timers.Timer DiscordTimer { get; } = new(10000);

        public void EnableDiscordRpc()
        {
            DiscordClient = new("1082874591770320966");
            DiscordClient.Initialize();

            SetPresence();

            DiscordTimer.Elapsed += (sender, args) => { if (!DiscordClient.IsDisposed) { SetPresence(); /*DiscordClient.Invoke();*/ } };

            DiscordTimer.Start();
        }

        public void DisableDiscordRpc()
        {
            try
            {
                DiscordClient.ClearPresence();

                DiscordTimer.Enabled = false;
                DiscordTimer.Stop();

                DiscordClient.ClearPresence();
                DiscordClient.Dispose();

                if (!DiscordClient.IsDisposed)
                {
                    DiscordClient.Dispose();
                }

                //if (DiscordClient != null)
                //{
                //    DiscordClient.ClearPresence();
                //    DiscordClient.Deinitialize();
                //    DiscordClient.Dispose();
                //}

                //ButtonDiscordPresence.CheckedChanged -= ButtonDiscordPresence_CheckedChanged;
                //ButtonDiscordPresence.Checked = false;
                //ButtonDiscordPresence.CheckedChanged += ButtonDiscordPresence_CheckedChanged;
            }
            catch { }
        }

        public void SetPresence()
        {
            if (Settings.AlwaysShowPresence)
            {
                DiscordClient.SetPresence(new RichPresence()
                {
                    Details = "Browsing Library",
                    Buttons =
                    [
                        new()
                        {
                            Label = "Download Arisen Studio",
                            Url = "https://github.com/ohhsodead/arisen-studio"
                        },
                        new()
                        {
                            Label = "Join Our Discord",
                            Url = Urls.DiscordServer
                        }
                    ],
                    Assets = new Assets()
                    {
                        LargeImageKey = "arisenstudio",
                        LargeImageText = "Arisen Studio"
                    }
                });

                if (Settings.ShowCurrentGamePlaying)
                {
                    if (IsConsoleConnected)
                    {
                        string image = Platform == Platform.PS3 ? "playstation" : "xbox";
                        string game = string.Empty;

                        if (Platform == Platform.PS3)
                        {
                            if (IsWebManInstalled)
                            {
                                game = WebManExtensions.GetGame(ConsoleProfile.Address);
                            }
                        }
                        else
                        {
                            if (XboxConsole.GetTitleId() != 0)
                            {
                                game = XboxConsole.GetTitleId().ToString("X");

                                if (string.IsNullOrWhiteSpace(game))
                                {
                                    game = "Dashboard";
                                }
                                else
                                {
                                    game = Database.GamesTitleIdsXbox.GetTitleFromTitleId(game);
                                }
                            }
                        }

                        DiscordClient.SetPresence(new RichPresence()
                        {
                            Details = game,
                            //State = "Playing Game",
                            Buttons =
                            [
                                new()
                                {
                                    Label = "Download Arisen Studio",
                                    Url = "https://github.com/ohhsodead/arisen-studio"
                                },
                                new()
                                {
                                    Label = "Join Our Server",
                                    Url = Urls.DiscordServer
                                }
                            ],
                            Assets = new Assets()
                            {
                                LargeImageKey = "arisenstudio",
                                LargeImageText = "Arisen Studio",
                                SmallImageKey = image,
                                SmallImageText = Platform.Humanize(),
                            }
                        });
                    }
                }
            }
            else
            {
                DisableDiscordRpc();
            }
        }

        /* Interface */

        // Customisation

        private void ToggleSettingsUseFormattedFileSizes_Toggled(object sender, EventArgs e)
        {
            Settings.UseFormattedFileSizes = ToggleSettingsUseFormattedFileSizes.IsOn;
        }

        private void ToggleSettingsUseRelativeTimes_Toggled(object sender, EventArgs e)
        {
            Settings.UseRelativeTimes = ToggleSettingsUseRelativeTimes.IsOn;
        }

        // Automation

        private void ToggleSettingsAlwaysShowGamePlaying_Toggled(object sender, EventArgs e)
        {
            Settings.AlwaysShowCurrentGamePlaying = ToggleSettingsAlwaysShowGamePlaying.IsOn;

            if (IsConsoleConnected)
            {
                if (Settings.AlwaysShowCurrentGamePlaying)
                {
                    StatusLabelHeaderCurrentGame.Visibility = BarItemVisibility.Always;
                    StatusLabelCurrentGame.Visibility = BarItemVisibility.Always;
                    TimerCurrentGame.Enabled = true;
                }
                else
                {
                    StatusLabelHeaderCurrentGame.Visibility = BarItemVisibility.Never;
                    StatusLabelCurrentGame.Visibility = BarItemVisibility.Never;
                    TimerCurrentGame.Enabled = false;
                }
            }
        }

        private void ToggleSettingsShowGamesFromExternalDevices_Toggled(object sender, EventArgs e)
        {
            Settings.ShowGamesFromExternalDevices = ToggleSettingsShowGamesFromExternalDevices.IsOn;
        }

        private void ToggleSettingsAutoDetectGameTitles_Toggled(object sender, EventArgs e)
        {
            Settings.AutoDetectGameTitles = ToggleSettingsAutoDetectGameTitles.IsOn;
        }

        private void ToggleSettingsAutoLoadFileManagerListings_Toggled(object sender, EventArgs e)
        {
            Settings.AutoLoadDirectoryListings = ToggleSettingsAutoLoadDirectoryListings.IsOn;
        }

        private void ToggleSettingsRememberConsolePath_Toggled(object sender, EventArgs e)
        {
            Settings.RememberConsolePath = ToggleSettingsRememberConsolePath.IsOn;
        }

        private void ToggleSettingsRememberLocalPath_Toggled(object sender, EventArgs e)
        {
            Settings.RememberLocalPath = ToggleSettingsRememberLocalPath.IsOn;
        }

        private void ToggleSettingsAutoDetectGameRegions_Toggled(object sender, EventArgs e)
        {
            Settings.AutoDetectGameRegions = ToggleSettingsAutoDetectGameRegions.IsOn;
        }

        /* Transfer */

        private void ToggleSettingsInstallModsToUsbDevice_Toggled(object sender, EventArgs e)
        {
            ButtonInstallModsToUSB.Checked = ToggleSettingsInstallModsToUsbDevice.IsOn;
            Settings.InstallGameModsToUsbDevice = ToggleSettingsInstallModsToUsbDevice.IsOn;
        }

        private void ToggleSettingsInstallHomebrewToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallHomebrewToUsbDevice = ToggleSettingsInstallHomebrewToUsbDevice.IsOn;
        }

        private void ToggleSettingsInstallResourcesToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallResourcesToUsbDevice = ToggleSettingsInstallResourcesToUsbDevice.IsOn;
        }

        private void ToggleSettingsInstallPackagesToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallPackagesToUsbDevice = ToggleSettingsInstallPackagesToUsbDevice.IsOn;
        }

        private void ToggleSettingsInstallGameSavesToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallGameSavesToUsbDevice = ToggleSettingsInstallGameSavesToUsbDevice.IsOn;
        }

        private void ToggleSettingsCleanUpLocalFilesAfterInstalling_Toggled(object sender, EventArgs e)
        {
            Settings.CleanUpLocalFilesAfterInstalling = ToggleSettingsCleanUpLocalFilesAfterInstalling.IsOn;
        }

        private void ToggleSettingsRememberGameRegions_Toggled(object sender, EventArgs e)
        {
            Settings.RememberGameRegions = ToggleSettingsRememberGameRegions.IsOn;
        }

        private void ToggleSettingsAlwaysBackupGameFiles_Toggled(object sender, EventArgs e)
        {
            Settings.AlwaysBackupGameFiles = ToggleSettingsAlwaysBackupGameFiles.IsOn;
        }

        /* Paths */

        private void TextBoxSettingsPathBaseDirectory_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathBaseDirectory.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathBaseDirectory.Text = TextBoxSettingsPathBaseDirectory.Text.Replace(@"\\", @"\");
            }

            Settings.PathBaseDirectory = TextBoxSettingsPathBaseDirectory.Text;

            //if (TextBoxSettingsPathBaseDirectory.Text.Contains(@"\\"))
            //{
            //    TextBoxSettingsPathBaseDirectory.Text.Replace(@"\\", @"\");
            //    Settings.PathBaseDirectory = TextBoxSettingsPathBaseDirectory.Text += @"\";
            //}
        }

        private void TextBoxSettingsPathBaseDirectory_Leave(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathBaseDirectory.Text.Contains(@"\\"))
            {
                //Settings.PathBaseDirectory = TextBoxSettingsPathBaseDirectory.Text;
                TextBoxSettingsPathBaseDirectory.Text = TextBoxSettingsPathBaseDirectory.Text.Replace(@"\\", @"\");
                Settings.PathBaseDirectory = TextBoxSettingsPathBaseDirectory.Text += @"\";
            }

            if (!TextBoxSettingsPathBaseDirectory.Text.EndsWith(@"\"))
            {
                //Settings.PathBaseDirectory = TextBoxSettingsPathBaseDirectory.Text;
                TextBoxSettingsPathBaseDirectory.Text += @"\";
            }
        }

        private void ButtonSettingsPathBaseDirectory_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_BASE_DIRECTORY"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathBaseDirectory.Text = path + @"\";
            }
        }

        private void TextBoxSettingsPathDownloads_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathDownloads.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathDownloads.Text = TextBoxSettingsPathDownloads.Text.Replace(@"\\", @"\");
            }

            Settings.PathDownloads = TextBoxSettingsPathDownloads.Text + @"\";
        }

        private void TextBoxSettingsPathDownloads_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSettingsPathDownloads.Text.EndsWith(@"\"))
            {
                TextBoxSettingsPathDownloads.Text += @"\";
            }
        }

        private void ButtonSettingsPathDownloads_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_DOWNLOADS"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathDownloads.Text = path + @"\";
            }
        }

        private void TextBoxSettingsPathGameMods_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathGameMods.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathGameMods.Text = TextBoxSettingsPathGameMods.Text.Replace(@"\\", @"\");
            }

            Settings.PathGameMods = TextBoxSettingsPathGameMods.Text;
        }

        private void TextBoxSettingsPathGameMods_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSettingsPathGameMods.Text.EndsWith(@"\"))
            {
                TextBoxSettingsPathGameMods.Text += @"\";
            }
        }

        private void ButtonSettingsPathGameMods_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_GAME_MODS"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathGameMods.Text = path + @"\";
            }
        }

        private void TextBoxSettingsPathHomebrew_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathHomebrew.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathHomebrew.Text = TextBoxSettingsPathHomebrew.Text.Replace(@"\\", @"\");
            }

            Settings.PathHomebrew = TextBoxSettingsPathHomebrew.Text;
        }

        private void TextBoxSettingsPathHomebrew_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSettingsPathHomebrew.Text.EndsWith(@"\"))
            {
                TextBoxSettingsPathHomebrew.Text += @"\";
            }
        }

        private void ButtonSettingsPathHomebrew_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_HOMEBREW"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathHomebrew.Text = path + @"\";
            }
        }

        private void TextBoxSettingsPathResources_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathResources.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathResources.Text = TextBoxSettingsPathResources.Text.Replace(@"\\", @"\");
            }

            Settings.PathResources = TextBoxSettingsPathResources.Text;
        }

        private void TextBoxSettingsPathResources_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSettingsPathResources.Text.EndsWith(@"\"))
            {
                TextBoxSettingsPathResources.Text += @"\";
            }
        }

        private void ButtonSettingsPathResources_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_RESOURCES"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathResources.Text = path + @"\";
            }
        }

        private void TextBoxSettingsPathPackages_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathPackages.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathPackages.Text = TextBoxSettingsPathPackages.Text.Replace(@"\\", @"\");
            }

            Settings.PathPackages = TextBoxSettingsPathPackages.Text;
        }

        private void TextBoxSettingsPathPackages_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSettingsPathPackages.Text.EndsWith(@"\"))
            {
                TextBoxSettingsPathPackages.Text += @"\";
            }
        }

        private void ButtonSettingsPathPackages_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_PACKAGES"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathPackages.Text = path + @"\";
            }
        }

        private void TextBoxSettingsPathGameSaves_EditValueChanged(object sender, EventArgs e)
        {
            if (TextBoxSettingsPathGameSaves.Text.Contains(@"\\"))
            {
                TextBoxSettingsPathGameSaves.Text = TextBoxSettingsPathGameSaves.Text.Replace(@"\\", @"\");
            }

            Settings.PathGameSaves = TextBoxSettingsPathGameSaves.Text;
        }

        private void TextBoxSettingsPathGameSaves_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSettingsPathGameSaves.Text.EndsWith(@"\"))
            {
                TextBoxSettingsPathGameSaves.Text += @"\";
            }
        }

        private void ButtonSettingsPathGameSaves_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_GAME_SAVES"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathGameSaves.Text = path + @"\";
            }
        }

        // Tools

        /* PlayStation 3 */

        private void TextBoxSettingsPackagesFilePathPS3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSettingsPackagesInstallPathPS3.Text.IsNullOrEmpty() | TextBoxSettingsPackagesInstallPathPS3.Text.IsNullOrWhiteSpace())
                {
                    TextBoxSettingsPackagesInstallPathPS3.Text = Settings.PackageInstallPathPS3;
                    return;
                }

                Settings.PackageInstallPathPS3 = TextBoxSettingsPackagesInstallPathPS3.Text;
            }
        }

        /* PlayStation 4 */

        private void TextBoxSettingsPackagesInstallPathPS4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSettingsPackagesInstallPathPS4.Text.IsNullOrEmpty() | TextBoxSettingsPackagesInstallPathPS4.Text.IsNullOrWhiteSpace())
                {
                    TextBoxSettingsPackagesInstallPathPS4.Text = Settings.PackageInstallPathPS4;
                    return;
                }

                Settings.PackageInstallPathPS4 = TextBoxSettingsPackagesInstallPathPS4.Text;
            }
        }

        /* Xbox 360 */

        private void TextBoxSettingsLaunchIniFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSettingsLaunchIniFilePath.Text.IsNullOrEmpty() | TextBoxSettingsLaunchIniFilePath.Text.IsNullOrWhiteSpace())
                {
                    TextBoxSettingsLaunchIniFilePath.Text = Settings.LaunchIniFilePath;
                    return;
                }

                Settings.LaunchIniFilePath = TextBoxSettingsLaunchIniFilePath.Text;
            }
        }

        // Download

        private void ImageSettingsDownloadsFolder_Click(object sender, EventArgs e)
        {
            SetDownloadsLocation();
        }

        private void SetDownloadsLocation()
        {
            string downloadsPath = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_DOWNLOADS"));

            if (!downloadsPath.IsNullOrEmpty())
            {
                if (!Directory.Exists(downloadsPath))
                {
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("DIRECTORY_NOT_EXIST"), ResourceLanguage.GetString("DIRECTORY_NOT_FOUND"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TextBoxSettingsPathDownloads.Text = downloadsPath + @"\";
            }
        }

        // Discord

        private void ToggleSettingsAlwaysShowPresence_Toggled(object sender, EventArgs e)
        {
            Settings.AlwaysShowPresence = ToggleSettingsAlwaysShowPresence.IsOn;

            if (Settings.AlwaysShowPresence)
            {
                EnableDiscordRpc();
            }
            else
            {
                ToggleSettingsShowCurrentGamePlaying.Toggled -= ToggleSettingsShowCurrentGamePlaying_Toggled;
                ToggleSettingsShowCurrentGamePlaying.IsOn = false;
                ToggleSettingsShowCurrentGamePlaying.Toggled += ToggleSettingsShowCurrentGamePlaying_Toggled;

                Settings.AlwaysShowPresence = false;
                Settings.ShowCurrentGamePlaying = false;

                DisableDiscordRpc();
            }
        }

        private void ToggleSettingsShowCurrentGamePlaying_Toggled(object sender, EventArgs e)
        {
            Settings.ShowCurrentGamePlaying = ToggleSettingsShowCurrentGamePlaying.IsOn;

            if (Settings.ShowCurrentGamePlaying)
            {
                ToggleSettingsAlwaysShowPresence.Toggled -= ToggleSettingsAlwaysShowPresence_Toggled;
                ToggleSettingsAlwaysShowPresence.IsOn = true;
                ToggleSettingsAlwaysShowPresence.Toggled += ToggleSettingsAlwaysShowPresence_Toggled;

                EnableDiscordRpc();
            }

            if (!Settings.AlwaysShowPresence)
            {
                DisableDiscordRpc();
            }
        }

        #endregion

        #region Custom Mods Page

        private int SelectedCustomModId = -1;

        private void TileItemCustomModsSortOptions_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterCustomModsSortOption, [ResourceLanguage.GetString("LABEL_GAME"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_MOD_TYPE"), ResourceLanguage.GetString("LABEL_REGION"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR")], FilterCustomModsSortOrder);

            if (sortOptions != null)
            {
                FilterCustomModsSortOption = sortOptions.SortOption;
                FilterCustomModsSortOrder = sortOptions.SortOrder;
                SearchCustomMods();
            }
        }

        private void TileItemCustomAdd_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogExtensions.ShowNewCustomModsDialog(this);
        }

        private void TileItemCustomEdit_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedCustomModId != -1)
            {
                var customItem = Settings.GetCustomMod(SelectedCustomModId);
                DialogExtensions.ShowNewCustomModsDialog(this, customItem, true);

                for (int i = 0; i < GridViewCustomMods.RowCount; i++)
                {
                    if ((int)GridViewCustomMods.GetRowCellValue(i, GridViewCustomMods.Columns[0]) == SelectedCustomModId)
                    {
                        GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_PLATFORM"), customItem.Platform.Humanize());
                        GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_CATEGORY"), customItem.Category);
                        GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_NAME"), customItem.Name);
                        GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_MOD_TYPE"), customItem.ModType);
                        GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_VERSION"), customItem.Version);
                        break;
                    }
                }

                //Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemCustomDelete_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedCustomModId != -1)
            {
                var customItem = Settings.GetCustomMod(SelectedCustomModId);

                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE_ITEM"), ResourceLanguage.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Settings.CustomMods.Remove(customItem);
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("DELETE_ITEM_SUCCESS"), ResourceLanguage.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TileItemCustomShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedCustomModId != -1)
            {
                ShowCustomModDetails(SelectedCustomModId);
            }
        }

        private void TileItemCustomInstall_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedCustomModId != -1)
            {
                var customItem = Settings.GetCustomMod(SelectedCustomModId);

                ShowTransferCustomModsDialog(this, TransferType.InstallCustom, customItem);
                //var modItem = Database.CustomModsPS3.GetModById(Platform.PS3, SelectedCustomModId);
                //Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemCustomUninstall_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedCustomModId != -1)
            {
                var customItem = Settings.GetCustomMod(SelectedCustomModId);

                ShowTransferCustomModsDialog(this, TransferType.UninstallCustom, customItem);

                //var modItem = Database.CustomModsPS3.GetModById(Platform.PS3, SelectedCustomModId);
                //Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterCustomModsSortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterCustomModsSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set the Platform for filtering mods.
        /// </summary>
        private string FilterCustomModsPlatform { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the category ID for filtering mods.
        /// </summary>
        private string FilterCustomModsCategory { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterCustomModsName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the mod type for filtering mods.
        /// </summary>
        private string FilterCustomModsType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering mods.
        /// </summary>
        private string FilterCustomModsVersion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the status for filtering mods.
        /// </summary>
        private string FilterCustomModsStatus { get; set; } = string.Empty;

        private void ComboBoxCustomModsFilterPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCustomModsPlatform = ComboBoxCustomModsFilterPlatform.SelectedIndex == -1
                ? string.Empty
                : ComboBoxCustomModsFilterPlatform.SelectedItem as string;

            SearchCustomMods();
        }

        private void ComboBoxCustomModsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCustomModsFilterCategory.SelectedIndex is (-1) or 0)
            {
                FilterCustomModsCategory = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxCustomModsFilterCategory.SelectedItem as string;
                FilterCustomModsCategory = selectedCategory;
                //FilterCustomModsCategory = Database.CategoriesData.GetCategoryByTitle(selectedCategory).Id;
            }

            SearchCustomMods();
        }

        private void TextBoxCustomModsFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterCustomModsName = TextBoxCustomModsFilterName.Text;

            SearchCustomMods();
        }

        private void ComboBoxCustomModsFilterModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCustomModsType = ComboBoxCustomModsFilterModType.SelectedIndex == 0 | ComboBoxCustomModsFilterModType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxCustomModsFilterModType.SelectedItem as string;

            SearchCustomMods();
        }

        private void ComboBoxCustomModsFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCustomModsVersion = ComboBoxCustomModsFilterVersion.SelectedIndex == 0 | ComboBoxCustomModsFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxCustomModsFilterVersion.SelectedItem as string;

            SearchCustomMods();
        }

        private void ComboBoxCustomModsFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCustomModsStatus = ComboBoxCustomModsFilterStatus.SelectedIndex == 0 | ComboBoxCustomModsFilterStatus.SelectedIndex == -1
                ? string.Empty
                : ComboBoxCustomModsFilterStatus.SelectedItem as string;

            SearchCustomMods();
        }

        private void LoadCustomModsCategories()
        {
            ComboBoxCustomModsFilterCategory.Properties.Items.Clear();

            ComboBoxCustomModsFilterCategory.SelectedIndexChanged -= ComboBoxCustomModsFilterCategory_SelectedIndexChanged;
            ComboBoxCustomModsFilterCategory.SelectedIndex = -1;
            ComboBoxCustomModsFilterCategory.SelectedIndexChanged += ComboBoxCustomModsFilterCategory_SelectedIndexChanged;

            ComboBoxCustomModsFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            ComboBoxCustomModsFilterModType.Properties.Items.Clear();
            ComboBoxCustomModsFilterModType.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxCustomModsFilterVersion.Properties.Items.Clear();
            ComboBoxCustomModsFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                if (Settings.CustomMods.Any(x => x.Category.EqualsIgnoreCaseSymbols(category.Title)))
                {
                    ComboBoxCustomModsFilterCategory.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            foreach (CustomItemData customMod in Settings.CustomMods)
            {
                foreach (string modType in from string modType in customMod.ModType
                                           where !ComboBoxCustomModsFilterModType.Properties.Items.Contains(modType)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCaseSymbols(modType))
                                           select modType)
                {
                    ComboBoxCustomModsFilterModType.Properties.Items.Add(modType);
                }

                foreach (string version in from string version in customMod.Version
                                           where !ComboBoxCustomModsFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxCustomModsFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        private DataTable DataTableCustomMods { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_PLATFORM"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Search for mods and display the results.
        /// </summary>
        private void SearchCustomMods()
        {
            GridViewCustomMods.ShowLoadingPanel();

            Category category;

            if (FilterCustomModsCategory.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = [],
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterCustomModsCategory);
            }

            DataTableCustomMods.Rows.Clear();

            int countResults = 0;

            BeginInvoke(new Action(() =>
            {
                foreach (CustomItemData customMod in Settings.CustomMods.FindAll(x =>
                x.Platform.Humanize().ContainsIgnoreCase(FilterCustomModsPlatform) &&
                //x.DownloadFile.Name.ContainsIgnoreCase(FilterDownloadsFileName) &&
                x.Category.ContainsIgnoreCaseSymbols(FilterCustomModsCategory) &&
                x.Name.EqualsIgnoreCaseSymbols(FilterCustomModsName) &&
                x.ModType.ContainsIgnoreCaseSymbols(FilterCustomModsType) &&
                x.Version.EqualsIgnoreCase(FilterCustomModsVersion)))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, category.Id, customMod.Id, true) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == customMod.Platform && x.ModId == customMod.Id);

                    if (FilterCustomModsStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterCustomModsStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                    {
                        continue;
                    }

                    DataTableCustomMods.Rows.Add(
                        customMod.Id,
                        customMod.Platform.Humanize(),
                        customMod.Category,
                        customMod.Name,
                        customMod.ModType,
                        customMod.Version,
                        isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));

                    countResults++;
                }
            }));

            GridControlCustomMods.DataSource = DataTableCustomMods;

            GridViewCustomMods.Columns[0].Visible = false;

            GridViewCustomMods.Columns[1].MinWidth = 122;
            GridViewCustomMods.Columns[1].MaxWidth = 122;

            GridViewCustomMods.Columns[2].MinWidth = 250;
            GridViewCustomMods.Columns[2].MaxWidth = 250;

            //GridViewCustomMods.Columns[3].MinWidth = 30;

            GridViewCustomMods.Columns[4].MinWidth = 128;
            GridViewCustomMods.Columns[4].MaxWidth = 128;

            GridViewCustomMods.Columns[5].MinWidth = 96;
            GridViewCustomMods.Columns[5].MaxWidth = 96;

            GridViewCustomMods.Columns[6].MinWidth = 100;
            GridViewCustomMods.Columns[6].MaxWidth = 100;

            GridViewCustomMods.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewCustomMods.Columns[FilterCustomModsSortOption], FilterCustomModsSortOrder),
            ]);

            ComboBoxCustomModsFilterModType.SelectedIndexChanged -= ComboBoxCustomModsFilterModType_SelectedIndexChanged;
            ComboBoxCustomModsFilterModType.SelectedIndex = string.IsNullOrEmpty(FilterCustomModsType) ? -1 : ComboBoxCustomModsFilterModType.Properties.Items.IndexOf(FilterCustomModsType);
            ComboBoxCustomModsFilterModType.SelectedIndexChanged += ComboBoxCustomModsFilterModType_SelectedIndexChanged;

            ComboBoxCustomModsFilterVersion.SelectedIndexChanged -= ComboBoxCustomModsFilterVersion_SelectedIndexChanged;
            ComboBoxCustomModsFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterCustomModsVersion) ? -1 : ComboBoxCustomModsFilterVersion.Properties.Items.IndexOf(FilterCustomModsVersion);
            ComboBoxCustomModsFilterVersion.SelectedIndexChanged += ComboBoxCustomModsFilterVersion_SelectedIndexChanged;

            ComboBoxCustomModsFilterStatus.SelectedIndexChanged -= ComboBoxCustomModsFilterStatus_SelectedIndexChanged;
            ComboBoxCustomModsFilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterCustomModsStatus) ? -1 : ComboBoxCustomModsFilterStatus.Properties.Items.IndexOf(FilterCustomModsStatus);
            ComboBoxCustomModsFilterStatus.SelectedIndexChanged += ComboBoxCustomModsFilterStatus_SelectedIndexChanged;

            //GridControlCustomMods.Refresh();
            //GridViewCustomMods.FocusedRowHandle = 1;
            //GridControlCustomMods.Refresh();

            GridViewCustomMods.MoveFirst();
            //GridViewCustomMods.OptionsScrollAnnotations.ShowFocusedRow = DefaultBoolean.True;
            //GridControlCustomMods.Refresh();

            GridViewCustomMods.HideLoadingPanel();
        }

        private void GridViewCustomMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedCustomModId = (int)GridViewCustomMods.GetRowCellValue(e.FocusedRowHandle, GridViewCustomMods.Columns[0]);
            }

            TileItemCustomEdit.Enabled = e.FocusedRowHandle != -1;
            TileItemCustomDelete.Enabled = e.FocusedRowHandle != -1;
            TileItemCustomInstall.Enabled = e.FocusedRowHandle != -1;
            TileItemCustomUninstall.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewCustomMods_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedCustomModId = (int)GridViewCustomMods.GetRowCellValue(info.RowHandle, GridViewCustomMods.Columns[0]);
            }

            TileItemCustomEdit.Enabled = info.RowHandle != -1;
            TileItemCustomDelete.Enabled = info.RowHandle != -1;
            TileItemCustomInstall.Enabled = info.RowHandle != -1;
            TileItemCustomUninstall.Enabled = info.RowHandle != -1;
        }

        private void GridViewCustomMods_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                string platform = (string)GridViewCustomMods.GetRowCellValue(info.RowHandle, GridViewCustomMods.Columns[1]);
                string category = (string)GridViewCustomMods.GetRowCellValue(info.RowHandle, GridViewCustomMods.Columns[2]);
                int modId = (int)GridViewCustomMods.GetRowCellValue(info.RowHandle, GridViewCustomMods.Columns[0]);

                SelectedCustomModId = modId;

                ShowDetails(Platform.PS3, category, modId);
            }
        }

        #endregion

        #region Game Mods Page (PS3)

        private int SelectedGameModPS3Id = -1;

        private void TileItemGameModsPS3ShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterGameModsPS3ShowFavorites)
            {
                FilterGameModsPS3ShowFavorites = false;
                TileItemGameModsPS3ShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchGameModsPS3();
            }
            else
            {
                FilterGameModsPS3ShowFavorites = true;
                TileItemGameModsPS3ShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchGameModsPS3();
            }
        }

        private void TileItemGameModsPS3SortOptions_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameModsPS3SortOption, [ResourceLanguage.GetString("LABEL_GAME"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_MOD_TYPE"), ResourceLanguage.GetString("LABEL_REGION"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR")], FilterGameModsPS3SortOrder);

            if (sortOptions != null)
            {
                FilterGameModsPS3SortOption = sortOptions.SortOption;
                FilterGameModsPS3SortOrder = sortOptions.SortOrder;
                SearchGameModsPS3();
            }
        }

        private void TileItemGameModsPS3AddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameModPS3Id != -1)
            {
                var modItem = Database.GameModsPS3.GetModById(Platform.PS3, SelectedGameModPS3Id);
                Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemGameModsPS3Download_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameModPS3Id != -1)
            {
                var modItem = Database.GameModsPS3.GetModById(Platform.PS3, SelectedGameModPS3Id);
                ShowTransferModsDialog(this, TransferType.DownloadMods, modItem, modItem.DownloadFiles.Last());
            }
        }

        private void TileItemGameModsPS3ShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameModPS3Id != -1)
            {
                ShowGameModDetails(Platform.PS3, SelectedGameModPS3Id);
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private bool FilterGameModsPS3ShowFavorites { get; set; } = false;

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterGameModsPS3SortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterGameModsPS3SortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterGameModsPS3CategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterGameModsPS3Name { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the system type for filtering mods.
        /// </summary>
        private string FilterGameModsPS3SystemType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the type for filtering mods.
        /// </summary>
        private string FilterGameModsPS3Type { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the region for filtering mods.
        /// </summary>
        private string FilterGameModsPS3Region { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering mods.
        /// </summary>
        private string FilterGameModsPS3Version { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the status for filtering mods.
        /// </summary>
        private string FilterGameModsPS3Status { get; set; } = string.Empty;

        private void ComboBoxGameModsPS3FilterGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameModsPS3FilterGame.SelectedIndex == 0 | ComboBoxGameModsPS3FilterGame.SelectedIndex == -1)
            {
                FilterGameModsPS3CategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxGameModsPS3FilterGame.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterGameModsPS3CategoryId = category.Id;
            }

            SearchGameModsPS3();
        }

        private void TextBoxGameModsPS3FilterName_TextChanged(object sender, EventArgs e)
        {
            FilterGameModsPS3Name = TextBoxGameModsPS3FilterName.Text;

            SearchGameModsPS3();
        }

        private void ComboBoxGameModsPS3FilterSystemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsPS3SystemType = ComboBoxGameModsPS3FilterSystemType.SelectedIndex == 0 | ComboBoxGameModsPS3FilterSystemType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsPS3FilterSystemType.SelectedItem.ToString();

            SearchGameModsPS3();
        }

        private void ComboBoxGameModsPS3FilterModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsPS3Type = ComboBoxGameModsPS3FilterModType.SelectedIndex == 0 | ComboBoxGameModsPS3FilterModType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsPS3FilterModType.SelectedItem as string;

            SearchGameModsPS3();
        }

        private void ComboBoxGameModsPS3FilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsPS3Region = ComboBoxGameModsPS3FilterRegion.SelectedIndex == 0 | ComboBoxGameModsPS3FilterRegion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsPS3FilterRegion.SelectedItem as string;

            SearchGameModsPS3();
        }

        private void ComboBoxGameModsPS3FilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsPS3Version = ComboBoxGameModsPS3FilterVersion.SelectedIndex == 0 | ComboBoxGameModsPS3FilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsPS3FilterVersion.SelectedItem as string;

            SearchGameModsPS3();
        }

        private void ComboBoxGameModsPS3FilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsPS3Status = ComboBoxGameModsPS3FilterStatus.SelectedIndex == 0 | ComboBoxGameModsPS3FilterStatus.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsPS3FilterStatus.SelectedItem as string;

            SearchGameModsPS3();
        }

        private void LoadGameModsCategoriesPS3()
        {
            ComboBoxGameModsPS3FilterGame.Properties.Items.Clear();

            ComboBoxGameModsPS3FilterGame.SelectedIndexChanged -= ComboBoxGameModsPS3FilterGame_SelectedIndexChanged;
            ComboBoxGameModsPS3FilterGame.SelectedIndex = -1;
            ComboBoxGameModsPS3FilterGame.SelectedIndexChanged += ComboBoxGameModsPS3FilterGame_SelectedIndexChanged;

            ComboBoxGameModsPS3FilterGame.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            ComboBoxGameModsPS3FilterModType.Properties.Items.Clear();
            ComboBoxGameModsPS3FilterModType.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxGameModsPS3FilterRegion.Properties.Items.Clear();
            ComboBoxGameModsPS3FilterRegion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxGameModsPS3FilterVersion.Properties.Items.Clear();
            ComboBoxGameModsPS3FilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
            {
                if (Database.GameModsPS3.Library.Any(x => x.GetPlatform() == ConsoleProfile.Platform && x.CategoryId.Equals(category.Id)))
                {
                    ComboBoxGameModsPS3FilterGame.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            foreach (ModItemData modItemData in Database.GameModsPS3.Library)
            {
                foreach (string modType in from string modType in modItemData.ModTypes
                                           where !ComboBoxGameModsPS3FilterModType.Properties.Items.Contains(modType)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(modType))
                                           select modType)
                {
                    ComboBoxGameModsPS3FilterModType.Properties.Items.Add(modType);
                }

                foreach (string region in from string region in modItemData.Regions
                                          where !ComboBoxGameModsPS3FilterRegion.Properties.Items.Contains(region)
                                          where !ignoreValues.Exists(x => x.EqualsIgnoreCase(region))
                                          select region)
                {
                    ComboBoxGameModsPS3FilterRegion.Properties.Items.Add(region);
                }

                foreach (string version in from string version in modItemData.Versions
                                           where !ComboBoxGameModsPS3FilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxGameModsPS3FilterVersion.Properties.Items.Add(version);
                }
            }
        }

        private DataTable DataTableGameModsPS3 { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_GAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Search for mods and display the results.
        /// </summary>
        private void SearchGameModsPS3()
        {
            GridViewGameModsPS3.ShowLoadingPanel();

            Category category;

            if (FilterGameModsPS3CategoryId.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = [],
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterGameModsPS3CategoryId);
            }

            DataTableGameModsPS3.Rows.Clear();

            int countResults = 0;

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.GameModsPS3.GetGameMods(Database.CategoriesData, FilterGameModsPS3CategoryId, FilterGameModsPS3Name, FilterGameModsPS3SystemType, FilterGameModsPS3Type, FilterGameModsPS3Region, FilterGameModsPS3Version, FilterGameModsPS3ShowFavorites))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id, false) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterGameModsPS3Status == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterGameModsPS3Status == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterGameModsPS3Status == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                    {
                        continue;
                    }

                    DataTableGameModsPS3.Rows.Add(modItemData.Id,
                                               modItemData.GetCategoryName(Database.CategoriesData),
                                               modItemData.Name,
                                               modItemData.FirmwareType,
                                               modItemData.ModType,
                                               modItemData.Region,
                                               string.Join(" & ", modItemData.Versions),
                                               isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));

                    countResults++;
                }
            }));

            GridControlGameModsPS3.DataSource = DataTableGameModsPS3;

            GridViewGameModsPS3.Columns[0].Visible = false;

            GridViewGameModsPS3.Columns[1].MinWidth = 250;
            GridViewGameModsPS3.Columns[1].MaxWidth = 250;

            //GridViewGameModsPS3.Columns[2].MinWidth = 30;

            GridViewGameModsPS3.Columns[3].MinWidth = 110;
            GridViewGameModsPS3.Columns[3].MaxWidth = 110;

            GridViewGameModsPS3.Columns[4].MinWidth = 128;
            GridViewGameModsPS3.Columns[4].MaxWidth = 128;

            GridViewGameModsPS3.Columns[5].MinWidth = 112;
            GridViewGameModsPS3.Columns[5].MaxWidth = 112;

            GridViewGameModsPS3.Columns[6].MinWidth = 96;
            GridViewGameModsPS3.Columns[6].MaxWidth = 96;

            GridViewGameModsPS3.Columns[7].MinWidth = 100;
            GridViewGameModsPS3.Columns[7].MaxWidth = 100;

            GridViewGameModsPS3.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewGameModsPS3.Columns[FilterGameModsPS3SortOption], FilterGameModsPS3SortOrder),
            ]);

            ComboBoxGameModsPS3FilterSystemType.SelectedIndexChanged -= ComboBoxGameModsPS3FilterSystemType_SelectedIndexChanged;
            ComboBoxGameModsPS3FilterSystemType.SelectedIndex = string.IsNullOrEmpty(FilterGameModsPS3SystemType) ? -1 : ComboBoxGameModsPS3FilterSystemType.Properties.Items.IndexOf(FilterGameModsPS3SystemType);
            ComboBoxGameModsPS3FilterSystemType.SelectedIndexChanged += ComboBoxGameModsPS3FilterSystemType_SelectedIndexChanged;

            ComboBoxGameModsPS3FilterModType.SelectedIndexChanged -= ComboBoxGameModsPS3FilterModType_SelectedIndexChanged;
            ComboBoxGameModsPS3FilterModType.SelectedIndex = string.IsNullOrEmpty(FilterGameModsPS3Type) ? -1 : ComboBoxGameModsPS3FilterModType.Properties.Items.IndexOf(FilterGameModsPS3Type);
            ComboBoxGameModsPS3FilterModType.SelectedIndexChanged += ComboBoxGameModsPS3FilterModType_SelectedIndexChanged;

            ComboBoxGameModsPS3FilterRegion.SelectedIndexChanged -= ComboBoxGameModsPS3FilterRegion_SelectedIndexChanged;
            ComboBoxGameModsPS3FilterRegion.SelectedIndex = string.IsNullOrEmpty(FilterGameModsPS3Region) ? -1 : ComboBoxGameModsPS3FilterRegion.Properties.Items.IndexOf(FilterGameModsPS3Region);
            ComboBoxGameModsPS3FilterRegion.SelectedIndexChanged += ComboBoxGameModsPS3FilterRegion_SelectedIndexChanged;

            ComboBoxGameModsPS3FilterVersion.SelectedIndexChanged -= ComboBoxGameModsPS3FilterVersion_SelectedIndexChanged;
            ComboBoxGameModsPS3FilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterGameModsPS3Version) ? -1 : ComboBoxGameModsPS3FilterVersion.Properties.Items.IndexOf(FilterGameModsPS3Version);
            ComboBoxGameModsPS3FilterVersion.SelectedIndexChanged += ComboBoxGameModsPS3FilterVersion_SelectedIndexChanged;

            ComboBoxGameModsPS3FilterStatus.SelectedIndexChanged -= ComboBoxGameModsPS3FilterStatus_SelectedIndexChanged;
            ComboBoxGameModsPS3FilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterGameModsPS3Status) ? -1 : ComboBoxGameModsPS3FilterStatus.Properties.Items.IndexOf(FilterGameModsPS3Status);
            ComboBoxGameModsPS3FilterStatus.SelectedIndexChanged += ComboBoxGameModsPS3FilterStatus_SelectedIndexChanged;

            //GridControlGameModsPS3.Refresh();
            //GridViewGameModsPS3.FocusedRowHandle = 1;
            //GridControlGameModsPS3.Refresh();

            GridViewGameModsPS3.MoveFirst();
            //GridViewGameModsPS3.OptionsScrollAnnotations.ShowFocusedRow = DefaultBoolean.True;
            //GridControlGameModsPS3.Refresh();

            GridViewGameModsPS3.HideLoadingPanel();
            GridViewGameModsPS3.MoveFirst();
        }

        private void GridViewGameModsPS3_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                if (GridViewGameModsPS3.RowCount > 0)
                {
                    SelectedGameModPS3Id = (int)GridViewGameModsPS3.GetRowCellValue(e.FocusedRowHandle, GridViewGameModsPS3.Columns[0]);
                }
            }

            TileItemGameModsPS3AddFavorite.Enabled = e.FocusedRowHandle != -1;
            TileItemGameModsPS3Download.Enabled = e.FocusedRowHandle != -1;
            TileItemGameModsPS3ShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewGameModsPS3_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedGameModXboxId = (int)GridViewGameModsPS3.GetRowCellValue(info.RowHandle, GridViewGameModsPS3.Columns[0]);
            }

            TileItemGameModsPS3AddFavorite.Enabled = SelectedGameModXboxId != -1;
            TileItemGameModsPS3Download.Enabled = SelectedGameModXboxId != -1;
            TileItemGameModsPS3ShowDetails.Enabled = SelectedGameModXboxId != -1;
        }

        private void GridViewGameModsPS3_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

                int modId = (int)GridViewGameModsPS3.GetRowCellValue(info.RowHandle, GridViewGameModsPS3.Columns[0]);
                SelectedGameModXboxId = modId;
                ShowGameModDetails(Platform.PS3, modId);
            }
        }

        #endregion

        #region Homebrew Page (PS3)

        private int SelectedHomebrewId = 0;

        private void TileItemHomebrewShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterHomebrewShowFavorites)
            {
                FilterHomebrewShowFavorites = false;
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchHomebrewPS3();
            }
            else
            {
                FilterHomebrewShowFavorites = true;
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchHomebrewPS3();
            }
        }

        private void TileItemHomebrewSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterHomebrewSortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR")], FilterHomebrewSortOrder);

            if (sortOptions != null)
            {
                FilterHomebrewSortOption = sortOptions.SortOption;
                FilterHomebrewSortOrder = sortOptions.SortOrder;
                SearchHomebrewPS3();
            }
        }

        private void TileItemHomebrewAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedHomebrewId != -1)
            {
                var modItem = Database.HomebrewPS3.GetModById(Platform.PS3, SelectedHomebrewId);
                Settings.FavoriteMods.Add(new() { Platform = Platform.PS3, CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemHomebrewDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedHomebrewId != -1)
            {
                var modItem = Database.HomebrewPS3.GetModById(Platform.PS3, SelectedHomebrewId);
                ShowTransferModsDialog(this, TransferType.DownloadMods, modItem, modItem.DownloadFiles.Last());
            }
        }

        private void TileItemHomebrewShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedHomebrewId != -1)
            {
                ShowHomebrewDetails(Platform.PS3, SelectedHomebrewId);
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterHomebrewSortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterHomebrewSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private bool FilterHomebrewShowFavorites { get; set; } = false;

        /// <summary>
        /// Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterHomebrewCategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterHomebrewName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the system type for filtering mods.
        /// </summary>
        private string FilterHomebrewSystemType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering mods.
        /// </summary>
        private string FilterHomebrewVersion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the status for filtering mods.
        /// </summary>
        private string FilterHomebrewStatus { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the selected mods info selected by the user.
        /// </summary>
        private static ModItemData SelectedHomebrewItem { get; set; }

        private void ComboBoxHomebrewFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewFilterCategory.SelectedIndex == 0 | ComboBoxHomebrewFilterCategory.SelectedIndex == -1)
            {
                FilterHomebrewCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxHomebrewFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterHomebrewCategoryId = category.Id;
            }

            SearchHomebrewPS3();
        }

        private void TextBoxFilterHomebrewName_TextChanged(object sender, EventArgs e)
        {
            FilterHomebrewName = TextBoxHomebrewFilterName.Text;

            SearchHomebrewPS3();
        }

        private void ComboBoxHomebrewFilterSystemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewSystemType = ComboBoxHomebrewFilterSystemType.SelectedIndex == 0 | ComboBoxHomebrewFilterSystemType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterSystemType.SelectedItem.ToString();

            SearchHomebrewPS3();
        }

        private void ComboBoxHomebrewFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewVersion = ComboBoxHomebrewFilterVersion.SelectedIndex == 0 | ComboBoxHomebrewFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterVersion.SelectedItem as string;

            SearchHomebrewPS3();
        }

        private void ComboBoxHomebrewFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewStatus = ComboBoxHomebrewFilterStatus.SelectedIndex == 0 | ComboBoxHomebrewFilterStatus.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterStatus.SelectedItem as string;

            SearchHomebrewPS3();
        }

        private void LoadHomebrewCategories()
        {
            ComboBoxHomebrewFilterCategory.Properties.Items.Clear();

            ComboBoxHomebrewFilterCategory.SelectedIndexChanged -= ComboBoxHomebrewFilterCategory_SelectedIndexChanged;
            ComboBoxHomebrewFilterCategory.SelectedIndex = -1;
            ComboBoxHomebrewFilterCategory.SelectedIndexChanged += ComboBoxHomebrewFilterCategory_SelectedIndexChanged;

            ComboBoxHomebrewFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Homebrew == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxHomebrewFilterCategory.Properties.Items.Add(category.Title);
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            ComboBoxHomebrewFilterVersion.Properties.Items.Clear();
            ComboBoxHomebrewFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (ModItemData modItemData in Database.HomebrewPS3.Library)
            {
                foreach (string version in from string version in modItemData.Versions
                                           where !ComboBoxHomebrewFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxHomebrewFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        private static DataTable DataTableHomebrew { get; } = DataExtensions.CreateDataTable(
            [
                new("ID", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Search for mods and display the results.
        /// </summary>
        private void SearchHomebrewPS3()
        {
            GridViewHomebrewPS3.ShowLoadingPanel();

            Category category;

            if (FilterHomebrewCategoryId.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = [],
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterHomebrewCategoryId);
            }

            DataTableHomebrew.Rows.Clear();

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a"];

            List<string> versions = [];
            List<string> authors = [];

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.HomebrewPS3.GetHomebrew(Database.CategoriesData, FilterHomebrewCategoryId, FilterHomebrewName, FilterHomebrewSystemType, FilterHomebrewVersion, FilterHomebrewShowFavorites))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id, false) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterHomebrewStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterHomebrewStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterHomebrewStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                    {
                        continue;
                    }

                    DataTableHomebrew.Rows.Add(modItemData.Id,
                                               modItemData.GetCategoryName(Database.CategoriesData),
                                               modItemData.Name,
                                               modItemData.FirmwareType,
                                               string.Join(" & ", modItemData.Versions),
                                               isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                }
            }));

            GridControlHomebrewPS3.DataSource = DataTableHomebrew;

            GridViewHomebrewPS3.Columns[0].Visible = false;

            GridViewHomebrewPS3.Columns[1].MinWidth = 250;
            GridViewHomebrewPS3.Columns[1].MaxWidth = 250;

            //GridViewHomebrew.Columns[2].MinWidth = 30;

            GridViewHomebrewPS3.Columns[3].MinWidth = 110;
            GridViewHomebrewPS3.Columns[3].MaxWidth = 110;

            GridViewHomebrewPS3.Columns[4].MinWidth = 92;
            GridViewHomebrewPS3.Columns[4].MaxWidth = 92;

            GridViewHomebrewPS3.Columns[5].MinWidth = 100;
            GridViewHomebrewPS3.Columns[5].MaxWidth = 100;

            GridViewHomebrewPS3.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewHomebrewPS3.Columns[FilterHomebrewSortOption], FilterHomebrewSortOrder),
            ]);

            ComboBoxHomebrewFilterSystemType.SelectedIndexChanged -= ComboBoxHomebrewFilterSystemType_SelectedIndexChanged;
            ComboBoxHomebrewFilterSystemType.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewSystemType) ? -1 : ComboBoxHomebrewFilterSystemType.Properties.Items.IndexOf(FilterHomebrewSystemType);
            ComboBoxHomebrewFilterSystemType.SelectedIndexChanged += ComboBoxHomebrewFilterSystemType_SelectedIndexChanged;

            ComboBoxHomebrewFilterVersion.SelectedIndexChanged -= ComboBoxHomebrewFilterVersion_SelectedIndexChanged;
            ComboBoxHomebrewFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewVersion) ? -1 : ComboBoxHomebrewFilterVersion.Properties.Items.IndexOf(FilterHomebrewVersion);
            ComboBoxHomebrewFilterVersion.SelectedIndexChanged += ComboBoxHomebrewFilterVersion_SelectedIndexChanged;

            ComboBoxHomebrewFilterStatus.SelectedIndexChanged -= ComboBoxHomebrewFilterStatus_SelectedIndexChanged;
            ComboBoxHomebrewFilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewStatus) ? -1 : ComboBoxHomebrewFilterStatus.Properties.Items.IndexOf(FilterHomebrewStatus);
            ComboBoxHomebrewFilterStatus.SelectedIndexChanged += ComboBoxHomebrewFilterStatus_SelectedIndexChanged;

            GridViewHomebrewPS3.HideLoadingPanel();

            if (GridViewHomebrewPS3.RowCount > 0)
            {
                GridViewHomebrewPS3.FocusedRowHandle = 0;
            }
        }

        private void GridViewHomebrew_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedHomebrewId = (int)GridViewHomebrewPS3.GetRowCellValue(e.FocusedRowHandle, GridViewHomebrewPS3.Columns[0]);
            }

            TileItemHomebrewDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemHomebrewShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewHomebrew_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedHomebrewId = (int)GridViewHomebrewPS3.GetRowCellValue(info.RowHandle, GridViewHomebrewPS3.Columns[0]);
            }
        }

        private void GridViewHomebrew_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                int modId = (int)GridViewHomebrewPS3.GetRowCellValue(info.RowHandle, GridViewHomebrewPS3.Columns[0]);
                SelectedHomebrewId = modId;
                ShowHomebrewDetails(Platform.PS3, modId);
            }
        }

        #endregion

        #region Resources Page

        private int SelectedResourceId = -1;

        private void TileItemResourcesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterResourcesSortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_MOD_TYPE"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR")], FilterResourcesSortOrder);

            if (sortOptions != null)
            {
                FilterResourcesSortOption = sortOptions.SortOption;
                FilterResourcesSortOrder = sortOptions.SortOrder;
                SearchResources();
            }
        }

        private void TileItemResourcesShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterResourcesShowFavorites)
            {
                FilterResourcesShowFavorites = false;
                TileItemResourcesShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchResources();
            }
            else
            {
                FilterResourcesShowFavorites = true;
                TileItemResourcesShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchResources();
            }
        }

        private void TileItemResourcesAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedResourceId != -1)
            {
                var modItem = Database.ResourcesPS3.GetModById(Platform.PS3, SelectedResourceId);
                Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemResourcesDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedResourceId != -1)
            {
                var modItem = Database.ResourcesPS3.GetModById(Platform.PS3, SelectedResourceId);
                ShowTransferModsDialog(this, TransferType.DownloadMods, modItem, modItem.DownloadFiles.Last());
            }
        }

        private void TileItemResourcesShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedResourceId != -1)
            {
                ShowResourceDetails(SelectedResourceId);
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterResourcesSortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterResourcesSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private bool FilterResourcesShowFavorites { get; set; } = false;

        /// <summary>
        /// Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterResourcesCategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterResourcesName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the system type for filtering mods.
        /// </summary>
        private string FilterResourcesSystemType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the type for filtering mods.
        /// </summary>
        private string FilterResourcesModType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering mods.
        /// </summary>
        private string FilterResourcesVersion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the status for filtering mods.
        /// </summary>
        private string FilterResourcesStatus { get; set; } = string.Empty;

        private void ComboBoxResourcesFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxResourcesFilterCategory.SelectedIndex == 0 | ComboBoxResourcesFilterCategory.SelectedIndex == -1)
            {
                FilterResourcesCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxResourcesFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterResourcesCategoryId = category.Id;
            }

            SearchResources();
        }

        private void TextBoxResourcesFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterResourcesName = TextBoxResourcesFilterName.Text;

            SearchResources();
        }

        private void ComboBoxResourcesFilterSystemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResourcesSystemType = ComboBoxResourcesFilterSystemType.SelectedIndex == 0 | ComboBoxResourcesFilterSystemType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxResourcesFilterSystemType.SelectedItem.ToString();

            SearchResources();
        }

        private void ComboBoxResourcesFilterModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResourcesModType = ComboBoxResourcesFilterModType.SelectedIndex == 0 | ComboBoxResourcesFilterModType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxResourcesFilterModType.SelectedItem as string;

            SearchResources();
        }

        private void ComboBoxResourcesFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResourcesVersion = ComboBoxResourcesFilterVersion.SelectedIndex == 0 | ComboBoxResourcesFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxResourcesFilterVersion.SelectedItem as string;

            SearchResources();
        }

        private void ComboBoxResourcesFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResourcesStatus = ComboBoxResourcesFilterStatus.SelectedIndex == 0 | ComboBoxResourcesFilterStatus.SelectedIndex == -1
                ? string.Empty
                : ComboBoxResourcesFilterStatus.SelectedItem as string;

            SearchResources();
        }

        private void LoadResourcesCategories()
        {
            ComboBoxResourcesFilterCategory.Properties.Items.Clear();

            ComboBoxResourcesFilterCategory.SelectedIndexChanged -= ComboBoxResourcesFilterCategory_SelectedIndexChanged;
            ComboBoxResourcesFilterCategory.SelectedIndex = -1;
            ComboBoxResourcesFilterCategory.SelectedIndexChanged += ComboBoxResourcesFilterCategory_SelectedIndexChanged;

            ComboBoxResourcesFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Resource == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxResourcesFilterCategory.Properties.Items.Add(category.Title);
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            ComboBoxResourcesFilterModType.Properties.Items.Clear();
            ComboBoxResourcesFilterModType.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxResourcesFilterVersion.Properties.Items.Clear();
            ComboBoxResourcesFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (ModItemData modItemData in Database.ResourcesPS3.Library)
            {
                foreach (string modType in from string modType in modItemData.ModTypes
                                           where !ComboBoxResourcesFilterModType.Properties.Items.Contains(modType)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(modType))
                                           select modType)
                {
                    ComboBoxResourcesFilterModType.Properties.Items.Add(modType);
                }

                foreach (string version in from string version in modItemData.Versions
                                           where !ComboBoxResourcesFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxResourcesFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        private static DataTable DataTableResources { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Search for mods and display the results.
        /// </summary>
        private void SearchResources()
        {
            GridViewResources.ShowLoadingPanel();

            Category category;

            if (FilterResourcesCategoryId.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = [],
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterResourcesCategoryId);
            }

            DataTableResources.Rows.Clear();

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a"];

            List<string> modTypes = [];
            List<string> versions = [];
            List<string> authors = [];

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.ResourcesPS3.GetResources(Database.CategoriesData, FilterResourcesCategoryId, FilterResourcesName, FilterResourcesSystemType, FilterResourcesModType, FilterResourcesVersion, FilterResourcesShowFavorites).OrderBy(x => x.Name))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id, false) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterResourcesStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterResourcesStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterResourcesStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                    {
                        continue;
                    }

                    DataTableResources.Rows.Add(modItemData.Id,
                                                modItemData.GetCategoryName(Database.CategoriesData),
                                                modItemData.Name,
                                                modItemData.FirmwareType,
                                                modItemData.ModType,
                                                string.Join(" & ", modItemData.Versions),
                                                isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                }
            }));

            GridControlResources.DataSource = DataTableResources;

            GridViewResources.Columns[0].Visible = false;

            GridViewResources.Columns[1].MinWidth = 250;
            GridViewResources.Columns[1].MaxWidth = 250;

            //GridViewResources.Columns[2].MinWidth = 30;

            GridViewResources.Columns[3].MinWidth = 110;
            GridViewResources.Columns[3].MaxWidth = 110;

            GridViewResources.Columns[4].MinWidth = 128;
            GridViewResources.Columns[4].MaxWidth = 128;

            GridViewResources.Columns[5].MinWidth = 94;
            GridViewResources.Columns[5].MaxWidth = 94;

            GridViewResources.Columns[6].MinWidth = 100;
            GridViewResources.Columns[6].MaxWidth = 100;

            GridViewResources.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewResources.Columns[FilterResourcesSortOption], FilterResourcesSortOrder),
            ]);

            ComboBoxResourcesFilterSystemType.SelectedIndexChanged -= ComboBoxResourcesFilterSystemType_SelectedIndexChanged;
            ComboBoxResourcesFilterSystemType.SelectedIndex = string.IsNullOrEmpty(FilterResourcesSystemType) ? -1 : ComboBoxResourcesFilterSystemType.Properties.Items.IndexOf(FilterResourcesSystemType);
            ComboBoxResourcesFilterSystemType.SelectedIndexChanged += ComboBoxResourcesFilterSystemType_SelectedIndexChanged;

            ComboBoxResourcesFilterModType.SelectedIndexChanged -= ComboBoxResourcesFilterModType_SelectedIndexChanged;
            ComboBoxResourcesFilterModType.SelectedIndex = string.IsNullOrEmpty(FilterResourcesModType) ? -1 : ComboBoxResourcesFilterModType.Properties.Items.IndexOf(FilterResourcesModType);
            ComboBoxResourcesFilterModType.SelectedIndexChanged += ComboBoxResourcesFilterModType_SelectedIndexChanged;

            ComboBoxResourcesFilterVersion.SelectedIndexChanged -= ComboBoxResourcesFilterVersion_SelectedIndexChanged;
            ComboBoxResourcesFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterResourcesVersion) ? -1 : ComboBoxResourcesFilterVersion.Properties.Items.IndexOf(FilterResourcesVersion);
            ComboBoxResourcesFilterVersion.SelectedIndexChanged += ComboBoxResourcesFilterVersion_SelectedIndexChanged;

            ComboBoxResourcesFilterStatus.SelectedIndexChanged -= ComboBoxResourcesFilterStatus_SelectedIndexChanged;
            ComboBoxResourcesFilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterResourcesStatus) ? -1 : ComboBoxResourcesFilterStatus.Properties.Items.IndexOf(FilterResourcesStatus);
            ComboBoxResourcesFilterStatus.SelectedIndexChanged += ComboBoxResourcesFilterStatus_SelectedIndexChanged;

            GridViewResources.HideLoadingPanel();

            if (GridViewResources.RowCount > 0)
            {
                GridViewResources.FocusedRowHandle = 0;
            }
        }

        private void GridViewResources_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedResourceId = (int)GridViewResources.GetRowCellValue(e.FocusedRowHandle, GridViewResources.Columns[0]);
            }

            TileItemResourcesDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemResourcesShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewResources_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedResourceId = (int)GridViewResources.GetRowCellValue(e.RowHandle, GridViewResources.Columns[0]);
                ShowResourceDetails(SelectedResourceId);
            }

            TileItemResourcesDownload.Enabled = SelectedResourceId != -1;
            TileItemResourcesShowDetails.Enabled = SelectedResourceId != -1;
        }

        private void GridViewResources_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedResourceId = (int)GridViewResources.GetRowCellValue(info.RowHandle, GridViewResources.Columns[0]);
                ShowResourceDetails(SelectedResourceId);
            }
        }

        #endregion

        #region Packages Page

        private string SelectedPackageCategory = string.Empty;
        private string SelectedPackageUrl = string.Empty;

        private void TileItemPackagesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterPackagesSortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_REGION"), ResourceLanguage.GetString("LABEL_MODIFIED_DATE"), ResourceLanguage.GetString("LABEL_FILE_SIZE")], FilterPackagesSortOrder);

            if (sortOptions != null)
            {
                FilterPackagesSortOption = sortOptions.SortOption;
                FilterPackagesSortOrder = sortOptions.SortOrder;
                SearchPackages();
            }
        }

        private void TileItemPackagesAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!SelectedPackageCategory.IsNullOrEmpty())
            {
                var package = Database.GetPackage(SelectedPackageCategory, SelectedPackageUrl);

                Settings.FavoriteMods.Add(new() { Platform = Platform.PS3, CategoryId = SelectedPackageCategory, CategoryType = CategoryType.Package, ModId = package.Id });
            }
        }

        private void TileItemPackagesDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!SelectedPackageCategory.IsNullOrEmpty())
            {
                var modItem = Database.GetPackage(SelectedPackageCategory, SelectedPackageUrl);
                ShowTransferPackageFileDialog(this, TransferType.InstallPackage, modItem);
            }
        }

        private void TileItemPackagesInstall_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!SelectedPackageCategory.IsNullOrEmpty())
            {
                var modItem = Database.GetPackage(SelectedPackageCategory, SelectedPackageUrl);
                ShowTransferPackageFileDialog(this, TransferType.InstallPackage, modItem);
            }
        }

        private void TileItemPackagesShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!SelectedPackageCategory.IsNullOrEmpty())
            {
                ShowPackageDetails(SelectedPackageCategory, SelectedPackageUrl);
            }
        }

        private PackagesData PackagesData { get; set; }

        private string FilterPackagesSortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        private ColumnSortOrder FilterPackagesSortOrder { get; set; } = ColumnSortOrder.Ascending;

        private string FilterPackagesCategory { get; set; } = string.Empty;

        private string FilterPackagesTitle { get; set; } = string.Empty;

        private string FilterPackagesRegion { get; set; } = string.Empty;

        private FilterType FilterPackagesModifiedDateType { get; set; } = FilterType.Equal;

        private DateTime? FilterPackagesModifiedDate { get; set; } = null;

        private FilterType FilterPackagesFileSizeType { get; set; } = FilterType.Equal;

        private int FilterPackagesFileSize { get; set; } = -1;

        private string FilterPackagesStatus { get; set; } = string.Empty;

        private void ComboBoxPackagesFilterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFilterPackagesCategories.SelectedIndex is (-1) or 0)
            {
                FilterPackagesCategory = string.Empty;
                SearchPackages();
                return;
            }

            if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Games"))
            {
                PackagesData = Database.GamesPS3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Demos"))
            {
                PackagesData = Database.DemosPS3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("DLCs"))
            {
                PackagesData = Database.DLCsPS3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Avatars"))
            {
                PackagesData = Database.AvatarsPS3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Themes"))
            {
                PackagesData = Database.ThemesPS3;
            }

            FilterPackagesCategory = ComboBoxFilterPackagesCategories.SelectedItem as string;
            SearchPackages();
        }

        private void TextBoxPackagesFilterTitle_EditValueChanged(object sender, EventArgs e)
        {
            FilterPackagesTitle = TextBoxPackagesFilterName.Text;
            SearchPackages();
        }

        private void ImagePackagesFilterDateType_Click(object sender, EventArgs e)
        {
            if (FilterPackagesModifiedDateType == FilterType.Equal)
            {
                FilterPackagesModifiedDateType = FilterType.MoreThanOrEqual;
                ImagePackagesFilterDateType.Image = Properties.Resources.more_or_equal;
            }
            else if (FilterPackagesModifiedDateType == FilterType.MoreThanOrEqual)
            {
                FilterPackagesModifiedDateType = FilterType.LessThanOrEqual;
                ImagePackagesFilterDateType.Image = Properties.Resources.less_or_equal;
            }
            else if (FilterPackagesModifiedDateType == FilterType.LessThanOrEqual)
            {
                FilterPackagesModifiedDateType = FilterType.Equal;
                ImagePackagesFilterDateType.Image = Properties.Resources.equal_sign;
            }
        }

        private void ComboBoxPackagesFilterModifiedDate_EditValueChanged(object sender, EventArgs e)
        {
            //if (ComboBoxPackagesFilterModifiedDate.EditValue.ToString().IsValidDate("MM/dd/yyyy"))
            if (!ComboBoxPackagesFilterModifiedDate.Text.IsNullOrWhiteSpace())
            {
                FilterPackagesModifiedDate = ComboBoxPackagesFilterModifiedDate.DateTime;
                SearchPackages();
            }
            else
            {
                //ComboBoxPackagesFilterModifiedDate.DateTime = null;
                ComboBoxPackagesFilterModifiedDate.EditValue = null;
                FilterPackagesModifiedDate = null;
                SearchPackages();
            }
        }

        private void ImagePackagesFilterFileSizeType_Click(object sender, EventArgs e)
        {
            if (FilterPackagesFileSizeType == FilterType.Equal)
            {
                FilterPackagesFileSizeType = FilterType.MoreThanOrEqual;
                ImagePackagesFilterFileSizeType.Image = Properties.Resources.more_or_equal;
            }
            else if (FilterPackagesFileSizeType == FilterType.MoreThanOrEqual)
            {
                FilterPackagesFileSizeType = FilterType.LessThanOrEqual;
                ImagePackagesFilterFileSizeType.Image = Properties.Resources.less_or_equal;
            }
            else if (FilterPackagesFileSizeType == FilterType.LessThanOrEqual)
            {
                FilterPackagesFileSizeType = FilterType.Equal;
                ImagePackagesFilterFileSizeType.Image = Properties.Resources.equal_sign;
            }
        }

        private void ComboBoxPackagesFilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPackagesFilterRegion.SelectedIndex is (-1) or 0)
            {
                FilterPackagesRegion = string.Empty;
                SearchPackages();
                return;
            }

            FilterPackagesRegion = ComboBoxPackagesFilterRegion.SelectedItem as string;
            SearchPackages();
        }

        private void ComboBoxPackagesFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPackagesFilterStatus.SelectedIndex is (-1) or 0)
            {
                FilterPackagesStatus = string.Empty;
                SearchPackages();
                return;
            }

            FilterPackagesStatus = ComboBoxPackagesFilterStatus.SelectedItem as string;
            SearchPackages();
        }

        private static DataTable DataTablePackages { get; } = DataExtensions.CreateDataTable(
            [
                new("Url", typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MODIFIED_DATE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_FILE_SIZE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Load packages into view.
        /// </summary>
        private void LoadPackages()
        {
            GridViewPackages.ShowLoadingPanel();

            DataTablePackages.Rows.Clear();

            BeginInvoke(new Action(() =>
            {
                if (FilterPackagesSortOption == ResourceLanguage.GetString("LABEL_FILE_SIZE"))
                {
                    foreach (PackageItemData package in GetAllPackages().Where(x => !x.IsUrlMissing).OrderBy(x => x.Size))
                    {
                        bool isInstalled = Settings.InstalledPackages.Any(x => x.Url.Equals(x.Url));

                        bool isDownloaded = Settings.DownloadedMods.Any(x => x.CategoryId.Equals("PACKAGE"));

                        bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                        if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                        {
                            continue;
                        }
                        else if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                        {
                            continue;
                        }
                        else if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                        {
                            continue;
                        }

                        bool shouldLoad = true;

                        if (!package.IsDateMissing)
                        {
                            if (FilterPackagesModifiedDate != null)
                            {
                                if (FilterPackagesModifiedDateType == FilterType.Equal && DateTime.Parse(package.ModifiedDate) == FilterPackagesModifiedDate)
                                {
                                    shouldLoad = true;
                                }
                                else if (FilterPackagesModifiedDateType == FilterType.MoreThanOrEqual && DateTime.Parse(package.ModifiedDate) >= FilterPackagesModifiedDate)
                                {
                                    shouldLoad = true;
                                }
                                else
                                {
                                    shouldLoad = FilterPackagesModifiedDateType == FilterType.LessThanOrEqual && DateTime.Parse(package.ModifiedDate) <= FilterPackagesModifiedDate;
                                }
                            }
                        }
                        else
                        {
                            if (FilterPackagesModifiedDate != null)
                            {
                                shouldLoad = false;
                                continue;
                            }
                        }

                        if (!package.IsSizeMissing)
                        {
                            if (FilterPackagesFileSize != -1)
                            {
                                if (FilterPackagesFileSizeType == FilterType.Equal && int.Parse(package.Size) == FilterPackagesFileSize)
                                {
                                    shouldLoad = true;
                                }
                                else if (FilterPackagesFileSizeType == FilterType.MoreThanOrEqual && int.Parse(package.Size) >= FilterPackagesFileSize)
                                {
                                    shouldLoad = true;
                                }
                                else
                                {
                                    shouldLoad = FilterPackagesFileSizeType == FilterType.LessThanOrEqual && int.Parse(package.Size) <= FilterPackagesFileSize;
                                }
                            }
                        }
                        else
                        {
                            if (FilterPackagesFileSize != -1)
                            {
                                shouldLoad = false;
                                continue;
                            }
                        }

                        if (shouldLoad)
                        {
                            DataTablePackages.Rows.Add(package.Url,
                                                       package.Category,
                                                       package.Name,
                                                       package.TitleId,
                                                       package.IsDateMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                       package.IsSizeMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                        }
                    }
                }
                else
                {
                    foreach (PackageItemData package in GetAllPackages().OrderBy(x => x.Name))
                    {
                        bool isInstalled = ConsoleProfile != null && Settings.InstalledPackages.Any(x => x.Url.Equals(x.Url));

                        bool isDownloaded = Settings.DownloadedMods.Any(x => x.CategoryId.Equals("PACKAGE"));

                        bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                        if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                        {
                            continue;
                        }
                        else if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                        {
                            continue;
                        }
                        else if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                        {
                            continue;
                        }

                        bool shouldLoad = true;

                        if (!package.IsDateMissing)
                        {
                            if (FilterPackagesModifiedDate != null)
                            {
                                if (FilterPackagesModifiedDateType == FilterType.Equal && DateTime.Parse(package.ModifiedDate) == FilterPackagesModifiedDate)
                                {
                                    shouldLoad = true;
                                }
                                else if (FilterPackagesModifiedDateType == FilterType.MoreThanOrEqual && DateTime.Parse(package.ModifiedDate) >= FilterPackagesModifiedDate)
                                {
                                    shouldLoad = true;
                                }
                                else
                                {
                                    shouldLoad = FilterPackagesModifiedDateType == FilterType.LessThanOrEqual && DateTime.Parse(package.ModifiedDate) <= FilterPackagesModifiedDate;
                                }
                            }
                        }
                        else
                        {
                            if (FilterPackagesModifiedDate != null)
                            {
                                shouldLoad = false;
                                continue;
                            }
                        }

                        if (!package.IsSizeMissing)
                        {
                            if (FilterPackagesFileSize != -1)
                            {
                                if (FilterPackagesFileSizeType == FilterType.Equal && long.Parse(package.Size) == FilterPackagesFileSize)
                                {
                                    shouldLoad = true;
                                }
                                else if (FilterPackagesFileSizeType == FilterType.MoreThanOrEqual && long.Parse(package.Size) >= FilterPackagesFileSize)
                                {
                                    shouldLoad = true;
                                }
                                else
                                {
                                    shouldLoad = FilterPackagesFileSizeType == FilterType.LessThanOrEqual && long.Parse(package.Size) <= FilterPackagesFileSize;
                                }
                            }
                        }
                        else
                        {
                            if (FilterPackagesFileSize != -1)
                            {
                                shouldLoad = false;
                                continue;
                            }
                        }

                        if (shouldLoad)
                        {
                            DataTablePackages.Rows.Add(package.Url,
                                                       package.Category,
                                                       package.Name,
                                                       package.TitleId,
                                                       package.IsDateMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                       package.IsSizeMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                        }
                    }
                }
            }));

            GridControlPackages.DataSource = DataTablePackages;

            GridViewPackages.Columns[0].Visible = false;

            GridViewPackages.Columns[1].MinWidth = 98;
            GridViewPackages.Columns[1].MaxWidth = 98;

            //GridViewGames.Columns[2].MinWidth = 232;
            //GridViewGames.Columns[2].MaxWidth = 232;

            GridViewPackages.Columns[3].MaxWidth = 86;
            GridViewPackages.Columns[3].MinWidth = 86;

            GridViewPackages.Columns[4].MaxWidth = 108;
            GridViewPackages.Columns[4].MinWidth = 108;

            GridViewPackages.Columns[5].MaxWidth = 120;
            GridViewPackages.Columns[5].MinWidth = 120;

            GridViewPackages.Columns[6].MaxWidth = 100;
            GridViewPackages.Columns[6].MinWidth = 100;

            GridViewPackages.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewPackages.Columns[FilterPackagesSortOption], FilterPackagesSortOrder),
            ]);

            GridViewPackages.HideLoadingPanel();

            if (GridViewPackages.RowCount > 0)
            {
                GridViewPackages.FocusedRowHandle = 0;
            }

            GridViewPackages.MoveFirst();
        }

        private void SearchPackages()
        {
            GridViewPackages.ShowLoadingPanel();

            DataTablePackages.Rows.Clear();

            List<PackageItemData> packages;

            if (FilterPackagesCategory.IsNullOrEmpty())
            {
                ComboBoxFilterPackagesCategories.SelectedIndexChanged -= ComboBoxPackagesFilterCategories_SelectedIndexChanged;
                ComboBoxFilterPackagesCategories.SelectedIndex = -1;
                ComboBoxFilterPackagesCategories.SelectedIndexChanged += ComboBoxPackagesFilterCategories_SelectedIndexChanged;
                packages = GetAllPackages();
            }
            else
            {
                packages = PackagesData.Packages;
            }

            BeginInvoke(new Action(() =>
            {
                foreach ((PackageItemData package, bool isInstalled) in from PackageItemData package in packages.FindAll(x =>
                !x.IsUrlMissing &&
                !x.IsNameMissing &&
                x.Category.ContainsIgnoreCase(FilterPackagesCategory) &&
                x.Name.ContainsIgnoreCase(FilterPackagesTitle) &&
                x.Region.ContainsIgnoreCase(FilterPackagesRegion)).OrderBy(x => x.Name)
                                                                        let isInstalled = Settings.InstalledPackages.Any(x => x.Url.Equals(x.Url))
                                                                        select (package, isInstalled))
                {
                    bool shouldLoad = true;

                    if (!package.IsDateMissing)
                    {
                        if (FilterPackagesModifiedDate != null)
                        {
                            if (FilterPackagesModifiedDateType == FilterType.Equal && DateTime.Parse(package.ModifiedDate) == FilterPackagesModifiedDate)
                            {
                                shouldLoad = true;
                            }
                            else if (FilterPackagesModifiedDateType == FilterType.MoreThanOrEqual && DateTime.Parse(package.ModifiedDate) >= FilterPackagesModifiedDate)
                            {
                                shouldLoad = true;
                            }
                            else
                            {
                                shouldLoad = FilterPackagesModifiedDateType == FilterType.LessThanOrEqual && DateTime.Parse(package.ModifiedDate) <= FilterPackagesModifiedDate;
                            }
                        }
                    }
                    else
                    {
                        if (FilterPackagesModifiedDate != null)
                        {
                            shouldLoad = false;
                            continue;
                        }
                    }

                    if (!package.IsSizeMissing)
                    {
                        if (FilterPackagesFileSize != -1)
                        {
                            if (FilterPackagesFileSizeType == FilterType.Equal && int.Parse(package.Size) == FilterPackagesFileSize)
                            {
                                shouldLoad = true;
                            }
                            else if (FilterPackagesFileSizeType == FilterType.MoreThanOrEqual && int.Parse(package.Size) >= FilterPackagesFileSize)
                            {
                                shouldLoad = true;
                            }
                            else
                            {
                                shouldLoad = FilterPackagesFileSizeType == FilterType.LessThanOrEqual && int.Parse(package.Size) <= FilterPackagesFileSize;
                            }
                        }
                    }
                    else
                    {
                        if (FilterPackagesModifiedDate != null)
                        {
                            shouldLoad = false;
                            continue;
                        }
                    }

                    if (shouldLoad)
                    {
                        if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && isInstalled)
                        {
                            DataTablePackages.Rows.Add(package.Url,
                                                       package.Category,
                                                       package.Name,
                                                       package.TitleId,
                                                       package.IsDateMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                       package.IsSizeMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                        }
                        else if (FilterPackagesStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && !isInstalled)
                        {
                            DataTablePackages.Rows.Add(package.Url,
                                                       package.Category,
                                                       package.Name,
                                                       package.TitleId,
                                                       package.IsDateMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                       package.IsSizeMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                        }
                        else
                        {
                            DataTablePackages.Rows.Add(package.Url,
                                                       package.Category,
                                                       package.Name,
                                                       package.TitleId,
                                                       package.IsDateMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                       package.IsSizeMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                                       isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                        }
                    }
                }
            }));

            GridControlPackages.DataSource = DataTablePackages;

            GridViewPackages.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewPackages.Columns[FilterPackagesSortOption], FilterPackagesSortOrder),
            ]);

            GridViewPackages.HideLoadingPanel();

            if (GridViewPackages.RowCount > 0)
            {
                GridViewPackages.FocusedRowHandle = 0;
            }

            GridViewPackages.MoveFirst();
        }

        private static List<PackageItemData> GetAllPackages()
        {
            List<PackageItemData> packages =
            [
                .. Database.GamesPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing),
                .. Database.DemosPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing),
                .. Database.DLCsPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing),
                .. Database.AvatarsPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing),
                .. Database.ThemesPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing),
            ];

            return packages;
        }

        private void GridViewPackages_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedPackageCategory = GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[1]);
                SelectedPackageUrl = GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[0]);
            }

            TileItemPackagesDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemPackagesShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewPackages_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedPackageCategory = GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[1]);
                SelectedPackageUrl = GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[0]);
            }

            TileItemPackagesDownload.Enabled = e.RowHandle != -1;
            TileItemPackagesShowDetails.Enabled = e.RowHandle != -1;
        }

        private void GridViewPackages_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedPackageCategory = GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[1]);
                SelectedPackageUrl = GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[0]);

                ShowPackageDetails(SelectedPackageCategory, SelectedPackageUrl);
            }
        }

        #endregion

        #region Game Mods Page (Xbox 360)

        private int SelectedGameModXboxId = -1;

        private void TileItemGameModsXboxShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterGameModsXboxShowFavorites)
            {
                FilterGameModsXboxShowFavorites = false;
                SearchGameModsXbox();
            }
            else
            {
                FilterGameModsXboxShowFavorites = true;
                SearchGameModsXbox();
            }
        }

        private void TileItemGameModsXboxSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameModsXboxSortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR"), ResourceLanguage.GetString("LABEL_STATUS")], FilterGameModsXboxSortOrder);

            if (sortOptions != null)
            {
                FilterGameModsXboxSortOption = sortOptions.SortOption;
                FilterGameModsXboxSortOrder = sortOptions.SortOrder;
                SearchGameModsXbox();
            }
        }

        private void TileItemGameModsXboxAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameModXboxId != -1)
            {
                var modItem = Database.GameModsXbox.GetModById(Platform.XBOX360, SelectedGameModXboxId);
                Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemGameModsXboxDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameModXboxId != -1)
            {
                var modItem = Database.GameModsXbox.GetModById(Platform.XBOX360, SelectedGameModXboxId);
                ShowTransferModsDialog(this, TransferType.DownloadMods, modItem, modItem.DownloadFiles.Last());
            }
        }

        private void TileItemGameModsXboxShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameModXboxId != -1)
            {
                ShowHomebrewDetails(Platform.XBOX360, SelectedGameModXboxId);
            }
        }

        private string FilterGameModsXboxSortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        private ColumnSortOrder FilterGameModsXboxSortOrder { get; set; } = ColumnSortOrder.Ascending;

        private bool FilterGameModsXboxShowFavorites { get; set; } = false;

        private string FilterGameModsXboxCategoryId { get; set; } = string.Empty;

        private string FilterGameModsXboxName { get; set; } = string.Empty;

        private string FilterGameModsXboxVersion { get; set; } = string.Empty;

        private string FilterGameModsXboxStatus { get; set; } = string.Empty;

        private void ComboBoxGameModsXboxFilterGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameModsXboxFilterGame.SelectedIndex == 0 | ComboBoxGameModsXboxFilterGame.SelectedIndex == -1)
            {
                FilterGameModsXboxCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxGameModsXboxFilterGame.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterGameModsXboxCategoryId = category.Id;
            }

            SearchGameModsXbox();
        }

        private void TextBoxGameModsXboxFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterGameModsXboxName = TextBoxGameModsXboxFilterName.Text;
            SearchPackages();
        }

        private void ComboBoxGameModsXboxFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameModsXboxFilterVersion.SelectedIndex is (-1) or 0)
            {
                FilterGameModsXboxVersion = string.Empty;
                SearchGameModsXbox();
                return;
            }

            FilterGameModsXboxVersion = ComboBoxGameModsXboxFilterVersion.SelectedItem as string;
            SearchGameModsXbox();
        }

        private void ComboBoxGameModsXboxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameModsXboxFilterStatus.SelectedIndex is (-1) or 0)
            {
                FilterGameModsXboxStatus = string.Empty;
                SearchGameModsXbox();
                return;
            }

            FilterGameModsXboxStatus = ComboBoxGameModsXboxFilterStatus.SelectedItem as string;
            SearchGameModsXbox();
        }

        private static DataTable DataTableGameModsXbox { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        private void LoadGameModsCategoriesXbox()
        {
            ComboBoxGameModsXboxFilterGame.Properties.Items.Clear();

            ComboBoxGameModsXboxFilterGame.SelectedIndexChanged -= ComboBoxGameModsXboxFilterGame_SelectedIndexChanged;
            ComboBoxGameModsXboxFilterGame.SelectedIndex = -1;
            ComboBoxGameModsXboxFilterGame.SelectedIndexChanged += ComboBoxGameModsXboxFilterGame_SelectedIndexChanged;

            ComboBoxGameModsXboxFilterGame.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            ComboBoxGameModsXboxFilterVersion.Properties.Items.Clear();
            ComboBoxGameModsXboxFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
            {
                if (Database.GameModsXbox.Library.Any(x => x.GetPlatform() == ConsoleProfile.Platform && x.CategoryId.Equals(category.Id)))
                {
                    ComboBoxGameModsXboxFilterGame.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            foreach (ModItemData modItemData in Database.GameModsXbox.Library)
            {
                foreach (string version in from string version in modItemData.Versions
                                           where !ComboBoxGameModsXboxFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxGameModsXboxFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        /// <summary>
        /// Search Game Mods for Xbox 360.
        /// </summary>
        public void SearchGameModsXbox()
        {
            GridViewGameModsXbox.ShowLoadingPanel();

            DataTableGameModsXbox.Rows.Clear();

            foreach (ModItemData modItemData in Database.GameModsXbox.GetGameModsXbox(Database.CategoriesData, FilterGameModsXboxCategoryId, FilterGameModsXboxName, FilterGameModsXboxVersion, FilterGameModsXboxShowFavorites))
            {
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id, false) != null;

                bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                if (FilterGameModsXboxStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                {
                    continue;
                }
                else if (FilterGameModsXboxStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                {
                    continue;
                }
                else if (FilterGameModsXboxStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                {
                    continue;
                }

                Category category = Database.CategoriesData.GetCategoryById(modItemData.CategoryId);

                DataTableGameModsXbox.Rows.Add(modItemData.Id,
                                          category.Title,
                                          modItemData.Name,
                                          modItemData.Version,
                                          isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            }

            GridControlGameModsXbox.DataSource = DataTableGameModsXbox;

            GridViewGameModsXbox.Columns[0].Visible = false;

            GridViewGameModsXbox.Columns[1].MinWidth = 250;
            GridViewGameModsXbox.Columns[1].MaxWidth = 250;

            //GridViewGameModsXbox.Columns[2].MinWidth = 180; //125

            GridViewGameModsXbox.Columns[3].MinWidth = 94;
            GridViewGameModsXbox.Columns[3].MaxWidth = 94;

            GridViewGameModsXbox.Columns[4].MinWidth = 100;
            GridViewGameModsXbox.Columns[4].MaxWidth = 100;

            GridViewGameModsXbox.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewGameModsXbox.Columns[FilterGameModsXboxSortOption], FilterGameModsXboxSortOrder),
            ]);

            GridViewGameModsXbox.HideLoadingPanel();

            if (GridViewGameModsXbox.RowCount > 0)
            {
                GridViewGameModsXbox.FocusedRowHandle = 0;
            }
        }

        private void GridViewGameModsXbox_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedGameModXboxId = (int)GridViewGameModsXbox.GetRowCellValue(e.FocusedRowHandle, GridViewGameModsXbox.Columns[0]);
            }

            TileItemGameModsXboxDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemGameModsXboxShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewGameModsXbox_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedGameModXboxId = (int)GridViewGameModsXbox.GetRowCellValue(info.RowHandle, GridViewGameModsXbox.Columns[0]);
            }

            TileItemGameModsXboxDownload.Enabled = SelectedGameModXboxId != -1;
            TileItemGameModsXboxShowDetails.Enabled = SelectedGameModXboxId != -1;
        }

        private void GridViewGameModsXbox_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

                SelectedGameModXboxId = (int)GridViewGameModsXbox.GetRowCellValue(info.RowHandle, GridViewGameModsXbox.Columns[0]); ;

                ModItemData selectedPlugin = Database.GameModsXbox.GetModById(Platform.XBOX360, SelectedGameModXboxId);
                ShowHomebrewDetails(Platform.XBOX360, selectedPlugin.Id);
            }
        }

        #endregion

        #region Homebrew Page (Xbox 360)

        private int SelectedHomebrewXboxId = -1;

        private void TileItemHomebrewXboxShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterHomebrewXboxShowFavorites)
            {
                FilterHomebrewXboxShowFavorites = false;
                SearchHomebrewXbox();
            }
            else
            {
                FilterHomebrewXboxShowFavorites = true;
                SearchHomebrewXbox();
            }
        }

        private void TileItemHomebrewXboxSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterHomebrewXboxSortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR"), ResourceLanguage.GetString("LABEL_STATUS")], FilterHomebrewXboxSortOrder);

            if (sortOptions != null)
            {
                FilterHomebrewXboxSortOption = sortOptions.SortOption;
                FilterHomebrewXboxSortOrder = sortOptions.SortOrder;
                SearchHomebrewXbox();
            }
        }

        private void TileItemHomebrewXboxAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedHomebrewXboxId != -1)
            {
                var modItem = Database.HomebrewXbox.GetModById(Platform.XBOX360, SelectedHomebrewXboxId);
                Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemHomebrewXboxDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedHomebrewXboxId != -1)
            {
                var modItem = Database.HomebrewXbox.GetModById(Platform.XBOX360, SelectedHomebrewXboxId);
                ShowTransferModsDialog(this, TransferType.DownloadMods, modItem, modItem.DownloadFiles.Last());
            }
        }

        private void TileItemHomebrewXboxShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedHomebrewXboxId != -1)
            {
                ShowHomebrewDetails(Platform.XBOX360, SelectedHomebrewXboxId);
            }
        }

        private string FilterHomebrewXboxSortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        private ColumnSortOrder FilterHomebrewXboxSortOrder { get; set; } = ColumnSortOrder.Ascending;

        private bool FilterHomebrewXboxShowFavorites { get; set; } = false;

        private string FilterHomebrewXboxCategoryId { get; set; } = string.Empty;

        private string FilterHomebrewXboxName { get; set; } = string.Empty;

        private string FilterHomebrewXboxVersion { get; set; } = string.Empty;

        private string FilterHomebrewXboxStatus { get; set; } = string.Empty;

        private void ComboBoxHomebrewXboxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewXboxFilterCategory.SelectedIndex == 0 | ComboBoxHomebrewXboxFilterCategory.SelectedIndex == -1)
            {
                FilterHomebrewXboxCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxHomebrewXboxFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterHomebrewXboxCategoryId = category.Id;
            }

            SearchHomebrewXbox();
        }

        private void TextBoxHomebrewXboxFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterHomebrewXboxName = TextBoxHomebrewXboxFilterName.Text;
            SearchPackages();
        }

        private void ComboBoxHomebrewXboxFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewXboxFilterVersion.SelectedIndex is (-1) or 0)
            {
                FilterHomebrewXboxVersion = string.Empty;
                SearchHomebrewXbox();
                return;
            }

            FilterHomebrewXboxVersion = ComboBoxHomebrewXboxFilterVersion.SelectedItem as string;
            SearchHomebrewXbox();
        }

        private void ComboBoxHomebrewXboxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewXboxFilterStatus.SelectedIndex is (-1) or 0)
            {
                FilterHomebrewXboxStatus = string.Empty;
                SearchHomebrewXbox();
                return;
            }

            FilterHomebrewXboxStatus = ComboBoxHomebrewXboxFilterStatus.SelectedItem as string;
            SearchHomebrewXbox();
        }

        private static DataTable DataTableHomebrewXbox { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        private void LoadHomebrewXboxCategoriesXbox()
        {
            ComboBoxHomebrewXboxFilterCategory.Properties.Items.Clear();

            ComboBoxHomebrewXboxFilterCategory.SelectedIndexChanged -= ComboBoxHomebrewXboxFilterCategory_SelectedIndexChanged;
            ComboBoxHomebrewXboxFilterCategory.SelectedIndex = -1;
            ComboBoxHomebrewXboxFilterCategory.SelectedIndexChanged += ComboBoxHomebrewXboxFilterCategory_SelectedIndexChanged;

            ComboBoxHomebrewXboxFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            ComboBoxHomebrewXboxFilterVersion.Properties.Items.Clear();
            ComboBoxHomebrewXboxFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
            {
                if (Database.HomebrewXbox.Library.Any(x => x.GetPlatform() == ConsoleProfile.Platform && x.CategoryId.Equals(category.Id)))
                {
                    ComboBoxHomebrewXboxFilterCategory.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            foreach (ModItemData modItemData in Database.HomebrewXbox.Library)
            {
                foreach (string version in from string version in modItemData.Versions
                                           where !ComboBoxHomebrewXboxFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxHomebrewXboxFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        /// <summary>
        /// Search Homebrew for Xbox 360.
        /// </summary>
        public void SearchHomebrewXbox()
        {
            GridViewHomebrewXbox.ShowLoadingPanel();

            DataTableHomebrewXbox.Rows.Clear();

            foreach (ModItemData modItemData in Database.HomebrewXbox.GetHomebrewXbox(Database.CategoriesData, FilterHomebrewXboxCategoryId, FilterHomebrewXboxName, FilterHomebrewXboxVersion, FilterHomebrewXboxShowFavorites))
            {
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id, false) != null;

                bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                if (FilterHomebrewXboxStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                {
                    continue;
                }
                else if (FilterHomebrewXboxStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                {
                    continue;
                }
                else if (FilterHomebrewXboxStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                {
                    continue;
                }

                Category category = Database.CategoriesData.GetCategoryById(modItemData.CategoryId);

                DataTableHomebrewXbox.Rows.Add(modItemData.Id,
                                          category.Title,
                                          modItemData.Name,
                                          modItemData.Version,
                                          isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            }

            GridControlHomebrewXbox.DataSource = DataTableHomebrewXbox;

            GridViewHomebrewXbox.Columns[0].Visible = false;

            GridViewHomebrewXbox.Columns[1].MinWidth = 250;
            GridViewHomebrewXbox.Columns[1].MaxWidth = 250;

            //GridViewHomebrewXbox.Columns[2].MinWidth = 180; //125

            GridViewHomebrewXbox.Columns[3].MinWidth = 94;
            GridViewHomebrewXbox.Columns[3].MaxWidth = 94;

            GridViewHomebrewXbox.Columns[4].MinWidth = 100;
            GridViewHomebrewXbox.Columns[4].MaxWidth = 100;

            GridViewHomebrewXbox.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewHomebrewXbox.Columns[FilterHomebrewXboxSortOption], FilterHomebrewXboxSortOrder),
            ]);

            GridViewHomebrewXbox.HideLoadingPanel();

            if (GridViewHomebrewXbox.RowCount > 0)
            {
                GridViewHomebrewXbox.FocusedRowHandle = 0;
            }
        }

        private void GridViewHomebrewXbox_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedGameModXboxId = (int)GridViewHomebrewXbox.GetRowCellValue(e.FocusedRowHandle, GridViewHomebrewXbox.Columns[0]);
            }

            TileItemHomebrewXboxDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemHomebrewXboxShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewHomebrewXbox_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedGameModXboxId = (int)GridViewHomebrewXbox.GetRowCellValue(info.RowHandle, GridViewHomebrewXbox.Columns[0]);
            }

            TileItemHomebrewXboxDownload.Enabled = SelectedGameModXboxId != -1;
            TileItemHomebrewXboxShowDetails.Enabled = SelectedGameModXboxId != -1;
        }

        private void GridViewHomebrewXbox_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

                SelectedGameModXboxId = (int)GridViewHomebrewXbox.GetRowCellValue(info.RowHandle, GridViewHomebrewXbox.Columns[0]); ;

                ModItemData selectedPlugin = Database.HomebrewXbox.GetModById(Platform.XBOX360, SelectedGameModXboxId);
                ShowHomebrewDetails(Platform.XBOX360, selectedPlugin.Id);
            }
        }

        #endregion

        #region Homebrew Page (PS4)

        private int SelectedAppId = -1;

        private void TileItemHomebrewPS4ShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterHomebrewPS4ShowFavorites)
            {
                FilterHomebrewPS4ShowFavorites = false;
                SearchHomebrewPS4();
            }
            else
            {
                FilterHomebrewPS4ShowFavorites = true;
                SearchHomebrewPS4();
            }
        }

        private void TileItemHomebrewPS4SortOptions_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterHomebrewPS4SortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR"), ResourceLanguage.GetString("LABEL_STATUS")], FilterHomebrewPS4SortOrder);

            if (sortOptions != null)
            {
                FilterHomebrewPS4SortOption = sortOptions.SortOption;
                FilterHomebrewPS4SortOrder = sortOptions.SortOrder;
                SearchHomebrewPS4();
            }
        }

        private void TileItemHomebrewPS4AddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedAppId != -1)
            {
                var modItem = Database.HomebrewPS4.GetModById(SelectedAppId);
                Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemHomebrewPS4Download_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedAppId != -1)
            {
                var appItem = Database.HomebrewPS4.GetModById(SelectedAppId);
                ShowTransferHomebrewPS4FileDialog(this, TransferType.DownloadMods, appItem);
            }
        }

        private void TileItemHomebrewPS4ShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedAppId != -1)
            {
                ShowAppDetails(SelectedAppId);
            }
        }

        private void LoadHomebrewPS4Categories()
        {
            ComboBoxHomebrewPS4FilterCategory.Properties.Items.Clear();

            ComboBoxHomebrewPS4FilterCategory.SelectedIndexChanged -= ComboBoxHomebrewPS4FilterCategory_SelectedIndexChanged;
            ComboBoxHomebrewPS4FilterCategory.SelectedIndex = -1;
            ComboBoxHomebrewPS4FilterCategory.SelectedIndexChanged += ComboBoxHomebrewPS4FilterCategory_SelectedIndexChanged;

            ComboBoxHomebrewPS4FilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            ComboBoxHomebrewPS4FilterFwVersion.Properties.Items.Clear();
            ComboBoxHomebrewPS4FilterFwVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxHomebrewPS4FilterVersion.Properties.Items.Clear();
            ComboBoxHomebrewPS4FilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Homebrew == x.CategoryType).OrderBy(x => x.Title))
            {
                if (Database.HomebrewPS4.Library.Any(x => x.CategoryId.Equals(category.Id)))
                {
                    ComboBoxHomebrewPS4FilterCategory.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            foreach (AppItemData appItemData in Database.HomebrewPS4.Library)
            {
                foreach (string fwVersion in from string fwVersion in appItemData.FirmwareVersions
                                             where !ComboBoxHomebrewPS4FilterFwVersion.Properties.Items.Contains(fwVersion)
                                             where !ignoreValues.Exists(x => x.EqualsIgnoreCase(fwVersion))
                                             select fwVersion)
                {
                    ComboBoxHomebrewPS4FilterFwVersion.Properties.Items.Add(fwVersion);
                }

                foreach (string version in from string version in appItemData.Versions
                                           where !ComboBoxHomebrewPS4FilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxHomebrewPS4FilterVersion.Properties.Items.Add(version);
                }
            }
        }

        private string FilterHomebrewPS4SortOption { get; set; } = ResourceLanguage.GetString("LABEL_NAME");

        private ColumnSortOrder FilterHomebrewPS4SortOrder { get; set; } = ColumnSortOrder.Ascending;

        private bool FilterHomebrewPS4ShowFavorites { get; set; } = false;

        private string FilterHomebrewPS4CategoryId { get; set; } = string.Empty;

        private string FilterHomebrewPS4Name { get; set; } = string.Empty;

        private string FilterHomebrewPS4FWVersion { get; set; } = string.Empty;

        private string FilterHomebrewPS4Version { get; set; } = string.Empty;

        private string FilterHomebrewPS4Status { get; set; } = string.Empty;

        private void ComboBoxHomebrewPS4FilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewPS4FilterCategory.SelectedIndex == 0 | ComboBoxHomebrewPS4FilterCategory.SelectedIndex == -1)
            {
                FilterHomebrewPS4CategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxHomebrewPS4FilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterHomebrewPS4CategoryId = category.Id;
            }

            SearchHomebrewPS4();
        }

        private void TextBoxHomebrewPS4FilterName_TextChanged(object sender, EventArgs e)
        {
            FilterHomebrewPS4Name = TextBoxHomebrewPS4FilterName.Text;
            SearchHomebrewPS4();
        }

        private void ComboBoxHomebrewPS4FilterFwVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewPS4FilterFwVersion.SelectedIndex is (-1) or 0)
            {
                FilterHomebrewPS4FWVersion = string.Empty;
                SearchHomebrewPS4();
                return;
            }

            FilterHomebrewPS4FWVersion = ComboBoxHomebrewPS4FilterFwVersion.SelectedItem as string;
            SearchHomebrewPS4();
        }

        private void ComboBoxHomebrewPS4FilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewPS4FilterVersion.SelectedIndex is (-1) or 0)
            {
                FilterHomebrewPS4Version = string.Empty;
                SearchHomebrewPS4();
                return;
            }

            FilterHomebrewPS4Version = ComboBoxHomebrewPS4FilterVersion.SelectedItem as string;
            SearchHomebrewPS4();
        }

        private void ComboBoxHomebrewPS4FilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHomebrewPS4FilterStatus.SelectedIndex is (-1) or 0)
            {
                FilterHomebrewPS4Status = string.Empty;
                SearchHomebrewPS4();
                return;
            }

            FilterHomebrewPS4Status = ComboBoxHomebrewPS4FilterStatus.SelectedItem as string;
            SearchHomebrewPS4();
        }

        private static DataTable DataTableHomebrewPS4 { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_FW_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Load all HomebrewPS4 for Xbox.
        /// </summary>
        public void SearchHomebrewPS4()
        {
            GridViewHomebrewPS4.ShowLoadingPanel();

            Category category;

            if (FilterHomebrewPS4CategoryId.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = [],
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterHomebrewPS4CategoryId);
            }

            DataTableHomebrewPS4.Rows.Clear();

            foreach (AppItemData appItemData in Database.HomebrewPS4.GetHomebrew(Database.CategoriesData, FilterHomebrewPS4CategoryId, FilterHomebrewPS4Name, FilterHomebrewPS4Version, FilterHomebrewPS4FWVersion, FilterHomebrewPS4ShowFavorites))
            {
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, appItemData.CategoryId, appItemData.Id, false) != null;

                bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == appItemData.GetPlatform() && x.ModId == appItemData.Id);

                bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                if (FilterHomebrewPS4Status == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                {
                    continue;
                }
                else if (FilterHomebrewPS4Status == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                {
                    continue;
                }
                else if (FilterHomebrewPS4Status == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                {
                    continue;
                }

                DataTableHomebrewPS4.Rows.Add(appItemData.Id,
                                       appItemData.GetCategoryName(Database.CategoriesData),
                                       appItemData.Name,
                                       appItemData.Version,
                                       appItemData.PlayableVersion,
                                       isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            }

            GridControlHomebrewPS4.DataSource = DataTableHomebrewPS4;

            GridViewHomebrewPS4.Columns[0].Visible = false;

            GridViewHomebrewPS4.Columns[1].MinWidth = 250;
            GridViewHomebrewPS4.Columns[1].MaxWidth = 250;

            //GridViewHomebrewPS4.Columns[2].MinWidth = 30;

            GridViewHomebrewPS4.Columns[3].MinWidth = 94;
            GridViewHomebrewPS4.Columns[3].MaxWidth = 94;

            GridViewHomebrewPS4.Columns[4].MinWidth = 110;
            GridViewHomebrewPS4.Columns[4].MaxWidth = 110;

            GridViewHomebrewPS4.Columns[5].MinWidth = 100;
            GridViewHomebrewPS4.Columns[5].MaxWidth = 100;

            GridViewHomebrewPS4.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewHomebrewPS4.Columns[FilterHomebrewPS4SortOption], FilterHomebrewPS4SortOrder),
            ]);

            GridViewHomebrewPS4.HideLoadingPanel();

            if (GridViewHomebrewPS4.RowCount > 0)
            {
                GridViewHomebrewPS4.FocusedRowHandle = 0;
            }

            GridViewHomebrewPS4.MoveFirst();
        }

        private void GridViewHomebrewPS4_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedAppId = (int)GridViewHomebrewPS4.GetRowCellValue(e.FocusedRowHandle, GridViewHomebrewPS4.Columns[0]);
            }

            TileItemHomebrewPS4Download.Enabled = e.FocusedRowHandle != -1;
            TileItemHomebrewPS4ShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewHomebrewPS4_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedAppId = (int)GridViewHomebrewPS4.GetRowCellValue(info.RowHandle, GridViewHomebrewPS4.Columns[0]);
            }

            TileItemHomebrewPS4Download.Enabled = SelectedAppId != -1;
            TileItemHomebrewPS4ShowDetails.Enabled = SelectedAppId != -1;
        }

        private void GridViewHomebrewPS4_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                AppItemData appItem = Database.HomebrewPS4.GetModById((int)GridViewHomebrewPS4.GetRowCellValue(info.RowHandle, GridViewHomebrewPS4.Columns[0]));
                SelectedAppId = appItem.Id;
                ShowAppDetails(SelectedAppId);
            }
        }

        #endregion

        #region Games Page

        private int SelectedGameId = -1;

        private void TileItemGamesFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterGamesShowFavorites)
            {
                FilterGamesShowFavorites = false;
                //TileItemHomebrewPS4ShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchGames();
            }
            else
            {
                FilterGamesShowFavorites = true;
                //TileItemHomebrewPS4ShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchGames();
            }
        }

        private void TileItemGamesSort_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGamesSortOption, [ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR"), ResourceLanguage.GetString("LABEL_STATUS")], FilterGamesSortOrder);

            if (sortOptions != null)
            {
                FilterGamesSortOption = sortOptions.SortOption;
                FilterGamesSortOrder = sortOptions.SortOrder;
                SearchGames();
            }
        }

        private void TileItemGamesAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameId != -1)
            {
                var modItem = Database.HomebrewPS4.GetModById(SelectedGameId);
                Settings.FavoriteMods.Add(new() { Platform = modItem.GetPlatform(), CategoryId = modItem.CategoryId, CategoryType = Database.CategoriesData.GetCategoryById(modItem.CategoryId).CategoryType, ModId = modItem.Id });
            }
        }

        private void TileItemGamesDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameId != -1)
            {
                var modItem = Database.HomebrewPS4.GetModById(SelectedGameId);
                ShowTransferHomebrewPS4FileDialog(this, TransferType.DownloadApplication, modItem);
            }
        }

        private void TileItemGamesShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameId != -1)
            {
                ShowAppDetails(SelectedGameId);
            }
        }

        private void LoadGamesCategories()
        {
            ComboBoxGamesFilterCategory.Properties.Items.Clear();

            ComboBoxGamesFilterCategory.SelectedIndexChanged -= ComboBoxGamesFilterCategory_SelectedIndexChanged;
            ComboBoxGamesFilterCategory.SelectedIndex = -1;
            ComboBoxGamesFilterCategory.SelectedIndexChanged += ComboBoxGamesFilterCategory_SelectedIndexChanged;

            ComboBoxGamesFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            ComboBoxGamesFilterFwVersion.Properties.Items.Clear();
            ComboBoxGamesFilterFwVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxGamesFilterVersion.Properties.Items.Clear();
            ComboBoxGamesFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
            {
                if (Database.HomebrewPS4.Library.Any(x => x.CategoryId.Equals(category.Id)))
                {
                    ComboBoxGamesFilterCategory.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a", ""];

            foreach (AppItemData appItemData in Database.HomebrewPS4.Library)
            {
                foreach (string fwVersion in from string fwVersion in appItemData.FirmwareVersions
                                             where !ComboBoxGamesFilterFwVersion.Properties.Items.Contains(fwVersion)
                                             where !ignoreValues.Exists(x => x.EqualsIgnoreCase(fwVersion))
                                             select fwVersion)
                {
                    ComboBoxGamesFilterFwVersion.Properties.Items.Add(fwVersion);
                }

                foreach (string version in from string version in appItemData.Versions
                                           where !ComboBoxGamesFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxGamesFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterGamesSortOption { get; set; } = ResourceLanguage.GetString("LABEL_CATEGORY");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterGamesSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set option to filter by favorites.
        /// </summary>
        private bool FilterGamesShowFavorites { get; set; } = false;

        private string FilterGamesCategoryId { get; set; } = string.Empty;

        private string FilterGamesName { get; set; } = string.Empty;

        private string FilterGamesFWVersion { get; set; } = string.Empty;

        private string FilterGamesVersion { get; set; } = string.Empty;

        private string FilterGamesStatus { get; set; } = string.Empty;

        private void ComboBoxGamesFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGamesFilterCategory.SelectedIndex == 0 | ComboBoxGamesFilterCategory.SelectedIndex == -1)
            {
                FilterGamesCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxGamesFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterGamesCategoryId = category.Id;
            }

            SearchGames();
        }

        private void TextBoxGamesFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterGamesName = TextBoxGamesFilterName.Text;
            SearchPackages();
        }

        private void ComboBoxGamesFilterFwVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGamesFilterFwVersion.SelectedIndex is (-1) or 0)
            {
                FilterGamesFWVersion = string.Empty;
                SearchGames();
                return;
            }

            FilterGamesFWVersion = ComboBoxGamesFilterFwVersion.SelectedItem as string;
            SearchGames();
        }

        private void ComboBoxGamesFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGamesFilterVersion.SelectedIndex is (-1) or 0)
            {
                FilterGamesVersion = string.Empty;
                SearchGames();
                return;
            }

            FilterGamesVersion = ComboBoxGamesFilterVersion.SelectedItem as string;
            SearchGames();
        }

        private void ComboBoxGamesFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGamesFilterStatus.SelectedIndex is (-1) or 0)
            {
                FilterGamesStatus = string.Empty;
                SearchGames();
                return;
            }

            FilterGamesStatus = ComboBoxGamesFilterStatus.SelectedItem as string;
            SearchGames();
        }

        private static DataTable DataTableGames { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_FW_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            ]);

        /// <summary>
        /// Load all Games for PS4.
        /// </summary>
        public void SearchGames()
        {
            //LoadGamesCategories();

            GridViewGames.ShowLoadingPanel();

            DataTableGames.Rows.Clear();

            foreach (AppItemData appItemData in Database.HomebrewPS4.GetGames(Database.CategoriesData, FilterGamesCategoryId, FilterGamesName, FilterGamesVersion, FilterGamesFWVersion, FilterGamesShowFavorites))
            {
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, appItemData.CategoryId, appItemData.Id, false) != null;

                bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == appItemData.GetPlatform() && x.ModId == appItemData.Id);

                bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                if (FilterGamesStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                {
                    continue;
                }
                else if (FilterGamesStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                {
                    continue;
                }
                else if (FilterGamesStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                {
                    continue;
                }

                Category category = Database.CategoriesData.GetCategoryById(appItemData.CategoryId);

                DataTableGames.Rows.Add(appItemData.Id,
                                       category.Title,
                                       appItemData.Name,
                                       appItemData.Version,
                                       isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            }

            GridControlGames.DataSource = DataTableGames;

            GridViewGames.Columns[0].Visible = false;

            GridViewGames.Columns[1].MinWidth = 250;
            GridViewGames.Columns[1].MaxWidth = 250;

            //GridViewGames.Columns[2].MinWidth = 30;

            GridViewGames.Columns[3].MinWidth = 94;
            GridViewGames.Columns[3].MaxWidth = 94;

            GridViewGames.Columns[4].MinWidth = 110;
            GridViewGames.Columns[4].MaxWidth = 110;

            GridViewGames.Columns[5].MinWidth = 100;
            GridViewGames.Columns[5].MaxWidth = 100;

            GridViewGames.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewGames.Columns[FilterGamesSortOption], FilterGamesSortOrder),
            ]);

            GridViewGames.HideLoadingPanel();

            if (GridViewGames.RowCount > 0)
            {
                GridViewGames.FocusedRowHandle = 0;
            }

            GridViewGames.MoveFirst();
        }

        private void GridViewGames_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedGameId = (int)GridViewGames.GetRowCellValue(e.FocusedRowHandle, GridViewGames.Columns[0]);
            }

            TileItemGamesDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemGamesShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewGames_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                //SelectedGameId = (int)GridViewGames.GetRowCellValue(info.RowHandle, GridViewGames.Columns[0]);
                //AppItemData selectedPlugin = Database.AppsPS4.GetModById(Platform.XBOX360, int.Parse(GridViewGames.GetRowCellDisplayText(e.RowHandle, "Id")));
                SelectedGameId = (int)GridViewGames.GetRowCellValue(e.RowHandle, GridViewGames.Columns[0]);
            }

            TileItemGamesDownload.Enabled = SelectedGameId != -1;
            TileItemGamesShowDetails.Enabled = SelectedGameId != -1;
        }

        private void GridViewGames_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                AppItemData selectedPlugin = Database.HomebrewPS4.GetModById((int)GridViewGames.GetRowCellValue(info.RowHandle, GridViewGames.Columns[0]));
                SelectedGameId = selectedPlugin.Id;
                ShowAppDetails(selectedPlugin.Id);

                //int modId = (int)GridViewGames.GetRowCellValue(info.RowHandle, GridViewGames.Columns[0]);
                //SelectedGameId = modId;
                //ShowGameModDetails(modId);
            }
        }

        #endregion

        #region Game Saves Page

        private GameSaveItemData SelectedGameSaveItem { get; set; }

        private void TileItemGameSavesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameSavesSortOption, [ResourceLanguage.GetString("LABEL_GAME"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_REGION"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR")], FilterGameSavesSortOrder);

            if (sortOptions != null)
            {
                FilterGameSavesSortOption = sortOptions.SortOption;
                FilterGameSavesSortOrder = sortOptions.SortOrder;
                SearchGameSaves();
            }
        }

        private void TileItemGameSavesAddFavorite_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameSaveItem != null)
            {
                var gameSaveItem = Database.GameSaves.GameSaves.First(x => x.GetPlatform() == ConsoleProfile.Platform && x.Id == SelectedGameSaveItem.Id);
                Settings.FavoriteMods.Add(new() { Platform = gameSaveItem.GetPlatform(), CategoryId = gameSaveItem.CategoryId, CategoryType = CategoryType.GameSave, ModId = gameSaveItem.Id });
            }
        }

        private void TileItemGameSavesDownload_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameSaveItem != null)
            {
                ShowTransferGameSavesFileDialog(this, TransferType.DownloadGameSave, SelectedGameSaveItem);
            }
        }

        private void TileItemGameSavesShowDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            if (SelectedGameSaveItem != null)
            {
                ShowGameSaveDetails(ConsoleProfile.Platform, SelectedGameSaveItem.Id);
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterGameSavesSortOption { get; set; } = ResourceLanguage.GetString("LABEL_GAME");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterGameSavesSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set the category Id for filtering game saves.
        /// </summary>
        private string FilterGameSavesCategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the file name for filtering game saves.
        /// </summary>
        private string FilterGameSavesName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the mod type for filtering game saves.
        /// </summary>
        private string FilterGameSavesRegion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering game saves.
        /// </summary>
        private string FilterGameSavesVersion { get; set; } = string.Empty;

        private void ComboBoxGameSavesFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameSavesFilterCategory.SelectedIndex == 0 | ComboBoxGameSavesFilterCategory.SelectedIndex == -1)
            {
                FilterGameSavesCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxGameSavesFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterGameSavesCategoryId = category.Id;
            }

            SearchGameSaves();
        }

        private void TextBoxGameSavesFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterGameSavesName = TextBoxGameSavesFilterName.Text;

            SearchGameSaves();
        }

        private void ComboBoxGameSavesFilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameSavesRegion = ComboBoxGameSavesFilterRegion.SelectedIndex == 0 | ComboBoxGameSavesFilterRegion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameSavesFilterRegion.SelectedItem as string;

            SearchGameSaves();
        }

        private void ComboBoxGameSavesFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameSavesVersion = ComboBoxGameSavesFilterVersion.SelectedIndex == 0 | ComboBoxGameSavesFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameSavesFilterVersion.SelectedItem as string;

            SearchGameSaves();
        }

        private static DataTable DataTableGameSaves { get; } = DataExtensions.CreateDataTable(
            [
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_GAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
            ]);

        private void LoadGameSavesCategories()
        {
            ComboBoxGameSavesFilterCategory.Properties.Items.Clear();

            ComboBoxGameSavesFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_GAMES")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => x.CategoryType == CategoryType.Game).OrderBy(x => x.Title))
            {
                if (Database.GameSaves.GameSaves.Any(x => x.GetPlatform() == ConsoleProfile.Platform && x.CategoryId.Equals(category.Id)))
                {
                    ComboBoxGameSavesFilterCategory.Properties.Items.Add(category.Title);
                }
            }

            List<string> ignoreValues = ["n/a", "-", "all regions", "all", "n", "a"];

            foreach (GameSaveItemData gameSaveItem in Database.GameSaves.GameSaves)
            {
                foreach (string region in from string region in gameSaveItem.Region.Split(' ')
                                          where !ComboBoxGameSavesFilterRegion.Properties.Items.Contains(region)
                                          where !ignoreValues.Exists(x => x.EqualsIgnoreCase(region))
                                          select region)
                {
                    ComboBoxGameSavesFilterRegion.Properties.Items.Add(region);
                }

                foreach (string version in from string version in gameSaveItem.Version.Split('/')
                                           where !ComboBoxGameSavesFilterVersion.Properties.Items.Contains(version)
                                           where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                           select version)
                {
                    ComboBoxGameSavesFilterVersion.Properties.Items.Add(version);
                }
            }
        }

        /// <summary>
        /// Load all game saves.
        /// </summary>
        public void SearchGameSaves()
        {
            LoadGameSavesCategories();

            GridViewGameSaves.ShowLoadingPanel();

            DataTableGameSaves.Rows.Clear();

            foreach (GameSaveItemData gameSaveItem in Database.GameSaves.GetGameSaveItems(Platform, FilterGameSavesCategoryId, FilterGameSavesName, FilterGameSavesRegion, FilterGameSavesVersion))
            {
                Category category = Database.CategoriesData.GetCategoryById(gameSaveItem.CategoryId);

                DataTableGameSaves.Rows.Add(gameSaveItem.Id,
                                            category.Title,
                                            gameSaveItem.Name,
                                            gameSaveItem.Region,
                                            gameSaveItem.Version);
            }

            GridControlGameSaves.DataSource = DataTableGameSaves;

            GridViewGameSaves.Columns[0].Visible = false;

            GridViewGameSaves.Columns[1].MinWidth = 250;
            GridViewGameSaves.Columns[1].MaxWidth = 250;

            //GridViewGameSaves.Columns[2].MinWidth = 180; // Ignore column

            GridViewGameSaves.Columns[3].MinWidth = 112;
            GridViewGameSaves.Columns[3].MaxWidth = 112;

            GridViewGameSaves.Columns[4].MinWidth = 92;
            GridViewGameSaves.Columns[4].MaxWidth = 92;

            ComboBoxGameSavesFilterRegion.SelectedIndexChanged -= ComboBoxGameSavesFilterRegion_SelectedIndexChanged;
            ComboBoxGameSavesFilterRegion.SelectedIndex = string.IsNullOrEmpty(FilterGameSavesRegion) ? -1 : ComboBoxGameSavesFilterRegion.Properties.Items.IndexOf(FilterGameSavesRegion);
            ComboBoxGameSavesFilterRegion.SelectedIndexChanged += ComboBoxGameSavesFilterRegion_SelectedIndexChanged;

            ComboBoxGameSavesFilterVersion.SelectedIndexChanged -= ComboBoxGameSavesFilterVersion_SelectedIndexChanged;
            ComboBoxGameSavesFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterGameSavesVersion) ? -1 : ComboBoxGameSavesFilterVersion.Properties.Items.IndexOf(FilterGameSavesVersion);
            ComboBoxGameSavesFilterVersion.SelectedIndexChanged += ComboBoxGameSavesFilterVersion_SelectedIndexChanged;

            GridViewGameSaves.SortInfo.ClearAndAddRange([
                new GridColumnSortInfo(GridViewGameSaves.Columns[FilterGameSavesSortOption], FilterGameSavesSortOrder),
            ]);

            GridViewGameSaves.HideLoadingPanel();

            if (GridViewGameSaves.RowCount > 0)
            {
                GridViewGameSaves.FocusedRowHandle = 0;
            }
        }

        private void GridViewGameSaves_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -1)
            {
                SelectedGameSaveItem = Database.GameSaves.GetModById(Platform, (int)GridViewGameSaves.GetRowCellValue(e.FocusedRowHandle, GridViewGames.Columns[0]));
            }

            TileItemGameSavesDownload.Enabled = e.FocusedRowHandle != -1;
            TileItemGameSavesShowDetails.Enabled = e.FocusedRowHandle != -1;
        }

        private void GridViewGameSaves_RowClick(object sender, RowClickEventArgs e)
        {
            DXMouseEventArgs ea = e;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                SelectedGameSaveItem = Database.GameSaves.GetModById(Platform, (int)GridViewGameSaves.GetRowCellValue(e.RowHandle, GridViewGames.Columns[0]));
            }

            TileItemGameSavesDownload.Enabled = SelectedGameSaveItem != null;
            TileItemGameSavesShowDetails.Enabled = SelectedGameSaveItem != null;
        }

        private void GridViewGameSaves_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

                //int modId = (int)GridViewGames.GetRowCellValue(info.RowHandle, GridViewGames.Columns[0]);
                //SelectedGameModXboxId = modId;

                SelectedGameSaveItem = Database.GameSaves.GetModById(Platform, (int)GridViewGameSaves.GetRowCellValue(info.RowHandle, GridViewGames.Columns[0]));

                ShowGameSaveDetails(ConsoleProfile.Platform, SelectedGameSaveItem.Id);
            }
        }

        #endregion

        #region Show Item Details

        /// <summary>
        /// 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="category"></param>
        /// <param name="modId"></param>
        private void ShowDetails(Platform platform, string category, int modId)
        {
            ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryByTitle(category).CategoryType, modId);

            if (platform == Platform.PS3)
            {
                if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
                {
                    ShowGameModDetails(platform, modId);
                }
                else if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
                {
                    ShowHomebrewDetails(platform, modId);
                }
                else if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Resource)
                {
                    ShowResourceDetails(modId);
                }
                else
                {
                    if (Database.GameSaves.GameSaves.Exists(x => x.GetPlatform() == platform && x.Id.Equals(modId)))
                    {
                        ShowGameSaveDetails(platform, modId);
                    }
                }
            }
            if (platform == Platform.PS4)
            {
                if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
                {
                    ShowAppDetails(modId);
                }
                else if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
                {
                    ShowAppDetails(modId);
                }
                else
                {
                    if (Database.GameSaves.GameSaves.Exists(x => x.GetPlatform() == platform && x.Id.Equals(modId)))
                    {
                        ShowGameSaveDetails(platform, modId);
                    }
                }
            }
            else if (platform == Platform.XBOX360)
            {
                if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
                {
                    ShowHomebrewDetails(platform, modId);
                }
                else if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
                {
                    ShowHomebrewDetails(platform, modId);
                }
                else
                {
                    if (Database.GameSaves.GameSaves.Exists(x => x.GetPlatform() == platform && x.Id.Equals(modId)))
                    {
                        ShowGameSaveDetails(platform, modId);
                    }
                }
            }
        }

        /// <summary>
        /// Show the custom mods details dialog.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="CustomItemData.Id" /> </param>
        private void ShowCustomModDetails(int modId)
        {
            CustomItemData customItem = Settings.GetCustomMod(modId);

            switch (customItem)
            {
                case null:
                    return;
            }

            ShowCustomModDetails(SelectedCustomModId);
        }

        /// <summary>
        /// Show the game mods details dialog.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModItemData.Id" /> </param>
        private void ShowGameModDetails(Platform platform, int modId)
        {
            ModItemData modItemData;

            if (platform == Platform.PS3)
            {
                modItemData = Database.GameModsPS3.GetModById(platform, modId);
            }
            else
            {
                modItemData = Database.GameModsXbox.GetModById(platform, modId);
            }

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Database.CategoriesData, modItemData);
        }

        /// <summary>
        /// Show the homebrew details dialog.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.modItemData.Id" /> </param>
        private void ShowHomebrewDetails(Platform platform, int modId)
        {
            ModItemData modItemData = null;

            if (platform == Platform.PS3)
            {
                modItemData = Database.HomebrewPS3.GetModById(platform, modId);
            }
            if (platform == Platform.XBOX360)
            {
                modItemData = Database.HomebrewXbox.GetModById(platform, modId);
            }
            else
            {
                var appItemData = Database.HomebrewPS4.GetModById(modId);

                DialogExtensions.ShowItemDetailsDialog(this, Database.CategoriesData, modItemData, appItemData);
                return;
            }

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Database.CategoriesData, modItemData);
        }

        /// <summary>
        /// Show the resource file details dialog.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.modItemData.Id" /> </param>
        private void ShowResourceDetails(int modId)
        {
            ModItemData modItemData = Database.ResourcesPS3.GetModById(Platform.PS3, modId);

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Database.CategoriesData, modItemData);
        }

        /// <summary>
        /// Show the package file details dialog.
        /// </summary>
        /// <param name="category"> Specifies the package category </param>
        /// <param name="url"> Specifies the Url <see cref="PackageItemData" /> </param>
        private void ShowPackageDetails(string category, string url)
        {
            PackageItemData packageItem = Database.GetPackage(category, url);

            switch (packageItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemPackageDetailsDialog(this, packageItem);
        }

        /// <summary>
        /// Show the application details dialog matching the specified <see cref="AppItemData.Id" />
        /// </summary>
        /// <param name="modId"> Specifies the Id of <see cref="AppItemData" /> </param>
        private void ShowAppDetails(int modId)
        {
            AppItemData appItemData = Database.HomebrewPS4.GetModById(modId);

            switch (appItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Database.CategoriesData, null, appItemData);
        }

        /// <summary>
        /// Show the details dialog.
        /// </summary>
        /// <param name=platform"> Specifies the <see cref="PlatformPrefix" /> </param>
        /// <param name="id"> Specifies the <see cref="GameSaveItemData.Id" /> </param>
        private void ShowGameSaveDetails(Platform platform, int id)
        {
            GameSaveItemData gameSaveItem = Database.GameSaves.GetModById(platform, id);

            switch (gameSaveItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemGameSaveDetailsDialog(this, gameSaveItem);
        }

        /// <summary>
        /// Show the details dialog.
        /// </summary>
        /// <param name="gameCheatItem"> Specifies the <see cref="GameCheatItemData" /> </param>
        private void ShowGameCheats(GameCheatItemData gameCheatItem)
        {
            DialogExtensions.ShowItemGameCheatsDialog(this, gameCheatItem);
        }

        /// <summary>
        /// Show the details dialog.
        /// </summary>
        /// <param name="gameCheatItem"> Specifies the <see cref="GameCheatItemData" /> </param>
        private void ShowGamePatches(GamePatchItemData gamePatchItem)
        {
            DialogExtensions.ShowItemGamePatchesDialog(this, gamePatchItem);
        }

        #endregion

        #region Update Status / Show Transfer Dialogs

        private void UpdateCustomModsRowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewCustomMods.RowCount; i++)
            {
                if ((int)GridViewCustomMods.GetRowCellValue(i, GridViewCustomMods.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewCustomMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdateModsRowStatusPS3(int modId, string text)
        {
            for (int i = 0; i < GridViewGameModsPS3.RowCount; i++)
            {
                if ((int)GridViewGameModsPS3.GetRowCellValue(i, GridViewGameModsPS3.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewGameModsPS3.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewGameModsPS3.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdateModsRowStatusXbox(int modId, string text)
        {
            for (int i = 0; i < GridViewGameModsXbox.RowCount; i++)
            {
                if ((int)GridViewGameModsXbox.GetRowCellValue(i, GridViewGameModsXbox.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewGameModsXbox.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewGameModsXbox.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdatePackagesRowStatus(string pkgUrl, string text)
        {
            for (int i = 0; i < GridViewPackages.RowCount; i++)
            {
                if ((string)GridViewPackages.GetRowCellValue(i, GridViewPackages.Columns[0]) == pkgUrl)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewPackages.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewPackages.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdateHomebrewPS3RowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewHomebrewPS3.RowCount; i++)
            {
                if ((int)GridViewHomebrewPS3.GetRowCellValue(i, GridViewHomebrewPS3.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewHomebrewPS3.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewHomebrewPS3.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdateHomebrewXboxRowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewHomebrewXbox.RowCount; i++)
            {
                if ((int)GridViewHomebrewXbox.GetRowCellValue(i, GridViewHomebrewXbox.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewHomebrewXbox.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewHomebrewXbox.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdateHomebrewPS4RowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewHomebrewPS4.RowCount; i++)
            {
                if ((int)GridViewHomebrewPS4.GetRowCellValue(i, GridViewHomebrewPS4.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewHomebrewPS4.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewHomebrewPS4.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        private void UpdateGameSavesRowStatus(int gameSaveId, string text)
        {
            for (int i = 0; i < GridViewGameSaves.RowCount; i++)
            {
                if ((int)GridViewGameSaves.GetRowCellValue(i, GridViewGameSaves.Columns[0]) == gameSaveId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewGameSaves.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewGameSaves.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                    }
                    break;
                }
            }
        }

        public void ShowTransferCustomModsDialog(Form owner, TransferType transferType, CustomItemData customItem)
        {
            UpdateCustomModsRowStatus(customItem.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("DOWNLOADING") : transferType == TransferType.InstallMods ? ResourceLanguage.GetString("INSTALLING") : ResourceLanguage.GetString("UNINSTALLING"));

            DialogExtensions.ShowTransferFilesDialog(owner, transferType, customItem);
            UpdateCustomModsRowStatus(customItem.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : transferType == TransferType.InstallMods ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            LoadInstalledMods();
        }

        public void ShowTransferModsDialog(Form owner, TransferType transferType, ModItemData modItem, DownloadFiles downloadFiles = null, string region = "")
        {
            UpdateModsRowStatusPS3(modItem.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("DOWNLOADING") : transferType == TransferType.InstallMods ? ResourceLanguage.GetString("INSTALLING") : ResourceLanguage.GetString("UNINSTALLING"));

            DialogExtensions.ShowTransferFilesDialog(owner, transferType, Database.CategoriesData.GetCategoryById(modItem.CategoryId), modItem, downloadFiles, region);
            UpdateModsRowStatusPS3(modItem.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : transferType == TransferType.InstallMods ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            LoadInstalledMods();
            LoadDownloads();
        }

        public void ShowTransferPackageFileDialog(Form owner, TransferType transferType, PackageItemData packageItem)
        {
            UpdatePackagesRowStatus(packageItem.Url, transferType == TransferType.DownloadPackage ? ResourceLanguage.GetString("DOWNLOADING") : transferType == TransferType.InstallPackage ? ResourceLanguage.GetString("INSTALLING") : ResourceLanguage.GetString("UNINSTALLING"));

            DialogExtensions.ShowTransferPackagesDialog(owner, transferType, packageItem);
            UpdatePackagesRowStatus(packageItem.Url, transferType == TransferType.DownloadPackage ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : transferType == TransferType.InstallPackage ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            LoadDownloads();
        }

        public void ShowTransferHomebrewPS4FileDialog(Form owner, TransferType transferType, AppItemData appItemData)
        {
            UpdateHomebrewPS4RowStatus(appItemData.Id, transferType == TransferType.DownloadGameSave ? ResourceLanguage.GetString("DOWNLOADING") : ResourceLanguage.GetString("INSTALLING"));

            DialogExtensions.ShowTransferFilesDialog(owner, transferType, Database.CategoriesData.GetCategoryById(appItemData.CategoryId), appItemData, appItemData.DownloadFiles.Last());
            UpdateHomebrewPS4RowStatus(appItemData.Id, transferType == TransferType.DownloadGameSave ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : ResourceLanguage.GetString("LABEL_INSTALLED"));
        }

        public void ShowTransferGameSavesFileDialog(Form owner, TransferType transferType, GameSaveItemData gameSaveItem)
        {
            UpdateGameSavesRowStatus(gameSaveItem.Id, transferType == TransferType.DownloadGameSave ? ResourceLanguage.GetString("DOWNLOADING") : ResourceLanguage.GetString("INSTALLING"));

            DialogExtensions.ShowTransferGameSavesDialog(owner, transferType, Database.CategoriesData.GetCategoryById(gameSaveItem.CategoryId), gameSaveItem);
            UpdateGameSavesRowStatus(gameSaveItem.Id, transferType == TransferType.DownloadGameSave ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : ResourceLanguage.GetString("LABEL_INSTALLED"));
        }

        #endregion

        #region About Page

        private void SetAboutInfo()
        {
            //LabelAboutTitle.Text = $@"Arisen Studio ({UpdateExtensions.CurrentVersionName})";
            LabelAboutVersion.Text = $"{UpdateExtensions.CurrentVersionName} ({GitHubAllReleases[0].PublishedAt.DateTime.ToShortDateString()})";
            //LabelAboutSubTitle.Text = string.Format(LabelAboutSubTitle.Text, GitHubAllReleases[0].PublishedAt.DateTime.ToShortDateString());
        }

        private void LabelAboutSubTitle_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private void ImageSocialWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(Urls.ProjectWebsite);
        }

        private void ImageSocialTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ohhsodead");
        }

        private void ImageSocialDiscord_Click(object sender, EventArgs e)
        {
            Process.Start(Urls.DiscordServer);
        }

        private void ImageSocialGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(Urls.GitHubRepo);
        }

        private void LabelAboutLibraries_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private void LabelAboutContributors_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private void LabelAboutTranslators_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        #endregion

        /// <summary>
        /// Enable or disable console-only actions.
        /// </summary>
        private void EnableConsoleActions()
        {
#if !DEBUG
            NavigationItemGameMods.Visible = Platform == Platform.PS3 | Platform == Platform.XBOX360;
            NavigationItemHomebrew.Visible = Platform == Platform.PS3 | Platform == Platform.XBOX360;
            NavigationItemResources.Visible = Platform == Platform.PS3;
            NavigationItemPackages.Visible = Platform == Platform.PS3;
            NavigationItemApplications.Visible = Platform == Platform.PS4;
            NavigationItemGames.Visible = Platform == Platform.PS4;
            NavigationItemPlugins.Visible = Platform == Platform.XBOX360;
            //NavigationItemGameCheats.Visible = false;

            ButtonScanXboxConsoles.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;

            // PS3 Features

            ButtonToolsPsGameUpdates.Visibility =
                Platform == Platform.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsPsGameUpdates.Enabled = IsConsoleConnected && Platform == Platform.PS3;

            ButtonToolsPsBackupFilesManager.Visibility =
                Platform == Platform.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsPsBackupFilesManager.Enabled = IsConsoleConnected && Platform == Platform.PS3;

            ButtonToolsPsPackageManager.Visibility =
                Platform == Platform.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsPsPackageManager.Enabled = IsConsoleConnected && Platform == Platform.PS3;

            ButtonToolsPsConsoleManager.Visibility =
                Platform == Platform.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsPsConsoleManager.Enabled = IsConsoleConnected && Platform == Platform.PS3;

            ButtonToolsPsGameRegions.Visibility =
                Platform == Platform.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsPsGameRegions.Enabled = IsConsoleConnected && Platform == Platform.PS3;

            ButtonToolsPsBootPluginsEditor.Visibility =
                Platform == Platform.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsPsBootPluginsEditor.Enabled = IsConsoleConnected && IsWebManInstalled && Platform == Platform.PS3;

            RibbonGroupWebManCommands.Visible = Platform == Platform.PS3;
            RibbonGroupWebManCommands.Enabled = IsConsoleConnected && Platform == Platform.PS3;

            // PS4 Features



            // Xbox Features

            ButtonToolsXboxGameSaveResigner.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsXboxGameSaveResigner.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            ButtonToolsXboxGamesLauncher.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsXboxGamesLauncher.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            ButtonToolsXboxModuleLoader.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsXboxModuleLoader.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            ButtonToolsXboxXuidSpoofer.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsXboxXuidSpoofer.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            ButtonToolsXboxDashlaunchEditor.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsXboxDashlaunchEditor.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            ButtonToolsXboxHDKey.Visibility =
                Platform == Platform.XBOX360
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            ButtonToolsXboxHDKey.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            RibbonGroupXbdmCommands.Visible = Platform == Platform.XBOX360;
            RibbonGroupXbdmCommands.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            // Reload Pages
            SearchGameSaves();
            //SearchGameCheats();
#endif
        }

        /// <summary>
        /// Set the current connected console status in the tool strip.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            RibbonControlMain.ApplicationButtonText = consoleProfile.Name;
            ConsoleProfile = consoleProfile;
            Platform = consoleProfile.Platform;
            EnableConsoleActions();
            LoadOurFavoriteGames();
            LoadOurFavoriteMods();
        }

        /// <summary>
        /// Set the current status of the connection in the tool strip.
        /// </summary>
        /// <param name="isConnected"> </param>
        private void SetStatusIsConnected(bool isConnected)
        {
            IsConsoleConnected = isConnected;

            if (IsConsoleConnected)
            {
                if (Settings.AlwaysShowCurrentGamePlaying)
                {
                    StatusLabelHeaderCurrentGame.Visibility = BarItemVisibility.Always;
                    StatusLabelCurrentGame.Visibility = BarItemVisibility.Always;
                    TimerCurrentGame.Enabled = true;
                }
                else
                {
                    StatusLabelHeaderCurrentGame.Visibility = BarItemVisibility.Never;
                    StatusLabelCurrentGame.Visibility = BarItemVisibility.Never;
                    TimerCurrentGame.Enabled = false;
                }

                StatusLabelHeaderIsConnected.Caption = ResourceLanguage.GetString("CONNECTED");
            }
            else
            {
                TimerCurrentGame.Enabled = false;
                StatusLabelHeaderIsConnected.Caption = ResourceLanguage.GetString("NOT_CONNECTED");
                StatusLabelCurrentGame.Caption = ResourceLanguage.GetString("LABEL_NONE");
            }
        }

        private void TimerCurrentGame_Tick(object sender, EventArgs e)
        {
            if (ConsoleProfile.Platform == Platform.PS3)
            {
                string game = WebManExtensions.GetGame(ConsoleProfile.Address);

                if (IsWebManInstalled)
                {
                    if (string.IsNullOrWhiteSpace(game))
                    {
                        game = "XMB Menu";
                    }
                }
                else
                {
                    game = "webMAN Required";
                }

                StatusLabelCurrentGame.Caption = game;
            }
            else
            {
                if (XboxConsole.GetTitleId() != 0)
                {
                    string game = XboxConsole.GetTitleId().ToString("X");

                    if (string.IsNullOrWhiteSpace(game))
                    {
                        game = "Dashboard";
                    }
                    else
                    {
                        game = Database.GamesTitleIdsXbox.GetTitleFromTitleId(game);
                    }

                    StatusLabelCurrentGame.Caption = game;
                }
            }
        }

        /// <summary>
        /// Set the current process status in the tool strip.
        /// </summary>
        /// <param name="status"> </param>
        /// <param name="ex"> </param>
        public void SetStatus(string status, Exception ex = null)
        {
            switch (ex)
            {
                case null:
                    Program.Log.Info(status);
                    break;

                default:
                    Program.Log.Error(ex, status);
                    XtraMessageBox.Show(this, string.Format(ResourceLanguage.GetString("ERROR_OCCURRED"), ex.Message), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
                    break;
            }

            StatusLabelStatus.Caption = status;
        }

        /// <summary>
        /// Load the users settings data.
        /// </summary>
        public void LoadApplicationSettings()
        {
            try
            {
                Program.Log.Info("Loading application settings data...");

                if (!Directory.Exists(UserFolders.AppData))
                {
                    Directory.CreateDirectory(UserFolders.AppData);
                }

                if (!File.Exists(UserFolders.SettingsData))
                {
                    using (StreamWriter streamWriter = new(UserFolders.SettingsData))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(Settings));
                    }

                    Program.Log.Info("Settings data doesn't exist, a new one has been created.");
                }

                using (StreamReader streamReader = new(UserFolders.SettingsData))
                {
                    Settings = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                }

                if (!File.Exists(UserFolders.BackupFilesData))
                {
                    using (StreamWriter streamWriter = new(UserFolders.BackupFilesData))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(BackupFiles));
                    }

                    Program.Log.Info("Backup files data doesn't exist, a new one has been created.");
                }

                using (StreamReader streamReader = new(UserFolders.BackupFilesData))
                {
                    BackupFiles = JsonConvert.DeserializeObject<BackupFilesData>(streamReader.ReadToEnd());
                }

                foreach (ConsoleProfile console in Settings.ConsoleProfiles)
                {
                    console.Id ??= DataExtensions.GenerateUniqueId();
                }

                Program.Log.Info("Successfully loaded application settings data.");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to load application settings data. {ResourceLanguage.GetString("ERROR")}: {ex.Message}", ex);
                XtraMessageBox.Show(this, string.Format("There is a problem loading the application settings data.\n\n{0}: {1}", ResourceLanguage.GetString("ERROR"), ex.Message), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save the users settings data.
        /// </summary>
        public void SaveApplicationSettings()
        {
            try
            {
                Program.Log.Info("Saving application settings data...");

                if (!Directory.Exists(UserFolders.AppData))
                {
                    Directory.CreateDirectory(UserFolders.AppData);
                }

                using (StreamWriter streamWriter = new(UserFolders.SettingsData))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(Settings));
                }

                using (StreamWriter streamWriter = new(UserFolders.BackupFilesData))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(BackupFiles));
                }

                Program.Log.Info("Successfully saved application settings data.");
            }
            catch (Exception ex)
            {
                Program.Log.Info(ex, $"Unable to save application data. {ResourceLanguage.GetString("ERROR")}: {ex.Message}");
                XtraMessageBox.Show(this, string.Format("There is a problem saving the application settings data.\n\n{0}: {1}", ResourceLanguage.GetString("ERROR"), ex.Message), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigationMenu_CustomDrawElement(object sender, CustomDrawElementEventArgs e)
        {
            if (e.ObjectInfo.Element == NavigationItemDashboard | e.ObjectInfo.Element == NavigationItemSettings)
            {
                e.DrawHeaderBackground();
                e.DrawExpandCollapseButton();
                e.DrawImage();
                e.DrawContextButtons();
                e.DrawText();
                DrawSeparator(e.Cache, e.ObjectInfo);
                e.Handled = true;
            }
        }

        protected SkinElement GetSeparatorSkinElement(UserLookAndFeel lookAndFeel)
        {
            SkinElement elem = AccordionControlSkins.GetSkin(lookAndFeel.ActiveLookAndFeel)[AccordionControlSkins.SkinSeparator];

            if (elem != null)
            {
                return elem;
            }

            return CommonSkins.GetSkin(lookAndFeel.ActiveLookAndFeel)[CommonSkins.SkinLabelLine];
        }

        protected void DrawSeparator(GraphicsCache cache, AccordionElementBaseViewInfo elementInfo)
        {
            SkinElement skinElem = GetSeparatorSkinElement(elementInfo.ControlInfo.LookAndFeel);
            Rectangle rect = new(elementInfo.HeaderBounds.X, elementInfo.HeaderBounds.Bottom - skinElem.Size.MinSize.Height + 2, elementInfo.HeaderBounds.Width, skinElem.Size.MinSize.Height + 1);
            SkinElementInfo skinElemInfo = new(skinElem, rect);
            ObjectPainter.DrawObject(cache, SkinElementPainter.Default, skinElemInfo);
        }

        private void RibbonControl1_MouseDown(object sender, MouseEventArgs e)
        {
            RibbonHitInfo info = (sender as RibbonControl).CalcHitInfo(e.Location);

            if (info.HitTest == RibbonHitTest.ApplicationButton)
            {
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            }
        }

        private void GridViewDownloads_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_PLATFORM"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    //int indent = cellViewInfo.Bounds.X + 7;
            //    int indent = cellViewInfo.Bounds.X;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewInstalledMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_PLATFORM"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewGameMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_GAME"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewHomebrew_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewResources_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewPackages_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewPlugins_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewGameSaves_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_GAME"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }

        private void GridViewGameCheats_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_GAME"))
            //{
            //    GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

            //    int indent = cellViewInfo.Bounds.X + 7;

            //    cellViewInfo.CellValueRect.X = indent;
            //    cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            //}
        }
    }
}