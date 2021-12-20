using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using FtpExtensions = ModioX.Extensions.FtpExtensions;
using CodeHollow.FeedReader;
using FluentFTP;
using Humanizer;
using ModioX.Constants;
using ModioX.Controls;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Dialogs;
using ModioX.Io;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using Newtonsoft.Json;
using PS3Lib;
using XDevkit;

namespace ModioX.Forms.Windows
{
    public partial class MainWindow : ToolbarForm
    {
        /// <summary>
        /// Initialize application.
        /// </summary>
        public MainWindow()
        {
            Window = this;
            InitializeComponent();
            SkinColors = CommonSkins.GetSkin(LookAndFeel).Colors;
            Opacity = 0;
            SuppressFormShadowShowing();

            // Disable RTM page for the moment, needs lots of work

#if DEBUG
            NavigationItemRealTimeMods.Visible = true;
#else
            NavigationItemRealTimeMods.Visible = false;
#endif
        }

        /// <summary>
        /// Get the current language resources.
        /// </summary>
        public static ResourceManager ResourceLanguage { get; set; } = new ResourceManager("ModioX.Languages.en", Assembly.GetExecutingAssembly());

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
        public static PlatformPrefix PlatformType { get; private set; }

        /// <summary>
        /// Set the current console type.
        /// </summary>
        public void SetConsoleType(PlatformPrefix value)
        {
            PlatformType = value;

#if !DEBUG
            EnableConsoleActions();
#endif
        }

        /// <summary>
        /// Contains the Xbox console functions.
        /// </summary>
        public static IXboxManager XboxManager { get; private set; }

        /// <summary>
        /// Contains the Xbox console functions.
        /// </summary>
        public static IXboxConsole XboxConsole { get; private set; }

        /// <summary>
        /// Contains the FTP client for faster and more reliable functions.
        /// </summary>
        public static FtpClient FtpClient { get; private set; }

        /// <summary>
        /// Contains the PS3 API for communicating with the console.
        /// </summary>
        public static PS3API PS3API { get; private set; }

        /// <summary>
        /// Determines whether webMAN is installed on the console.
        /// </summary>
        public static bool IsWebManInstalled { get; private set; }

        /// <summary>
        /// Get the colors for the current skin.
        /// </summary>
        public static SkinColors SkinColors { get; private set; }

        /// <summary>
        /// Splash screen handle.
        /// </summary>
        public static IOverlaySplashScreenHandle overlaySplashScreenHandle = null;

        /// <summary>
        /// Form loading event.
        /// </summary>
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            SuppressFormShadowShowing();

            UserLookAndFeel.Default.StyleChanged += MainWindow_StyleChanged;
            WindowsFormsSettings.AllowHoverAnimation = DefaultBoolean.True;

            SplashScreenManager.ShowSkinSplashScreen(
                $"ModioX",
                "Browse, Download and Install Mods\nfor PlayStation 3 && Xbox 360",
                "Copyright © 2021\nAll Rights Reserved.",
                "Initializing...",
                this);

            Text = $@"ModioX - {UpdateExtensions.CurrentVersionName}";

            LoadApplicationSettings();

            if (HttpExtensions.CheckForInternetConnection())
            {
                Program.Log.Info("Internet connection detected.");

                UpdateExtensions.CheckApplicationVersion();

                switch (Settings.FirstTimeOpenAfterUpdate)
                {
                    case true:
                        Settings.FirstTimeOpenAfterUpdate = false;
                        DialogExtensions.ShowWhatsNewDialog(this, UpdateExtensions.GitHubData);
                        break;
                }

                SetStatus(ResourceLanguage.GetString("Initializing the application database..."));
                await Task.Run(async () => await LoadDataAsync().ConfigureAwait(true));
                InitializeFinished();
            }
            else
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("You must be connected to the Internet to use this application."), ResourceLanguage.GetString("No Internet Detected"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetStatus(ResourceLanguage.GetString("No Internet connection detected."));
                Application.Exit();
            }
        }

        /// <summary>
        /// Save application settings, and if console is connected then closes connections.
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveApplicationSettings();

            switch (IsConsoleConnected)
            {
                case false:
                    return;
                default:
                    try
                    {
                        if (!TextBoxFileManagerLocalPath.Text.IsNullOrWhiteSpace())
                        {
                            switch (PlatformType)
                            {
                                case PlatformPrefix.PS3:
                                    Settings.LocalPathPS3 = TextBoxFileManagerLocalPath.Text;
                                    break;
                                case PlatformPrefix.XBOX:
                                    Settings.LocalPathXBOX = TextBoxFileManagerLocalPath.Text;
                                    break;
                            }
                        }

                        if (!TextBoxFileManagerConsolePath.Text.IsNullOrWhiteSpace())
                        {
                            switch (PlatformType)
                            {
                                case PlatformPrefix.PS3:
                                    Settings.ConsolePathPS3 = TextBoxFileManagerConsolePath.Text;
                                    break;
                                case PlatformPrefix.XBOX:
                                    Settings.ConsolePathXBOX = TextBoxFileManagerConsolePath.Text;
                                    break;
                            }
                        }

                        switch (ConsoleProfile.TypePrefix)
                        {
                            case PlatformPrefix.PS3:
                                FtpClient.Dispose();
                                break;
                            case PlatformPrefix.XBOX:
                                XboxConsole.CloseConnection(0);
                                break;
                        }
                    }
                    catch
                    {
                        // false positive; the console might be powered off
                    }

                    break;
            }
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
                Database = await GitHubData.InitializeAsync().ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to load the database. {ResourceLanguage.GetString("Error")}: {ex.Message}");
                Application.Exit();
            }
        }

        /// <summary>
        /// Finalize application after being initialized.
        /// </summary>
        private void InitializeFinished()
        {
            SetStatus(ResourceLanguage.GetString("Successfully loaded the database - Finalizing application data..."));

            SetConsoleType(Settings.StartupLibrary);

            foreach (string firmwareType in Database.ModsPS3.AllFirmwareTypes.Where(firmwareType => !ComboBoxGameModsFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxGameModsFilterSystemType.Properties.Items.Add(firmwareType);
            }

            foreach (string firmwareType in Database.ModsPS3.AllFirmwareTypes.Where(firmwareType => !ComboBoxHomebrewFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxHomebrewFilterSystemType.Properties.Items.Add(firmwareType);
            }

            foreach (string firmwareType in Database.ModsPS3.AllFirmwareTypes.Where(firmwareType => !ComboBoxResourcesFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxResourcesFilterSystemType.Properties.Items.Add(firmwareType);
            }

            SetStatus($"{ResourceLanguage.GetString("Initialized")} ModioX ({UpdateExtensions.CurrentVersionName}) - {ResourceLanguage.GetString("Ready to connect to console")}...");

            EnableConsoleActions();
            UpdateControlColors();
            Focus();

            NavigationMenu.SelectElement(NavigationItemDashboard);

            // Dashboard tab
            SetTileDefaultModsText();
            LoadStatistics();
            LoadChangeLog();
            LoadAnnouncements();
            LoadNewsFeed();

            // Downloads tab
            LoadDownloads();

            // Installed Mods tab
            LoadInstalledMods();

            // Settings tab
            LoadLanguages();
            LoadSettings();

            if (Settings.Language != "English")
            {
                ChangeLanguage(Settings.Language);
            }

#if !DEBUG
            if (Settings.StartupLibrary == PlatformPrefix.PS3)
            {
                NavigationItemGameMods.Visible = true;
                NavigationItemPackages.Visible = true;
                NavigationItemHomebrew.Visible = true;
                NavigationItemResources.Visible = true;
                NavigationItemPlugins.Visible = false;
            }
            else
            {
                NavigationItemGameMods.Visible = false;
                NavigationItemPackages.Visible = false;
                NavigationItemHomebrew.Visible = false;
                NavigationItemResources.Visible = false;
                NavigationItemPlugins.Visible = true;
            }
#endif

            SplashScreenManager.CloseForm();
            CreateFormShadow();
            Opacity = 1;
            BringToFront();

            PageDashboard.AutoScroll = true;
        }

        private void UpdateControlColors()
        {
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.AccordionControl, LookAndFeel, "Item");
            element.ContentMargins.Top = 10;
            element.ContentMargins.Bottom = 10;
            element.ContentMargins.Left = 16;
        }

        private IOverlaySplashScreenHandle handle = null;

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

        #region Title Menu Bar

        // CONNECT

        private void MenuItemConnectToPS3_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (IsConsoleConnected)
            {
                case true:
                    DisconnectConsole();
                    break;
                default:
                    {
                        ConsoleProfile consoleProfile = DialogExtensions.ShowConnectionsDialog(this, PlatformPrefix.PS3);

                        if (consoleProfile != null)
                        {
                            ConsoleProfile = consoleProfile;
                            ConnectConsole();
                        }

                        break;
                    }
            }
        }

        private void MenuItemConnectToXBOX_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (IsConsoleConnected)
            {
                case true:
                    DisconnectConsole();
                    break;
                default:
                    {
                        ConsoleProfile consoleProfile = DialogExtensions.ShowConnectionsDialog(this, PlatformPrefix.XBOX);

                        if (consoleProfile != null)
                        {
                            ConsoleProfile = consoleProfile;
                            ConnectConsole();
                        }

                        break;
                    }
            }
        }

        // TOOLS MENU

        // PS3

        private void ButtonPS3GameBackupFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameBackupFiles(this);
        }

        private void ButtonPS3GameUpdateFinder_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameUpdatesFinder(this);
        }

        private void ButtonPS3PackageManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowPackageManager(this);
        }

        private void MenuItemPS3ConsoleManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowConsoleManager(this);
        }

        private void ButtonPS3FileManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
        }

        private void ButtonPS3ShowSystemInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Notifying: System Information");
            WebManExtensions.NotifySystemInformation(ConsoleProfile.Address);
            SetStatus("WebMAN Controls - Successfully Notified: System Information");
        }

        private void ButtonPS3ShowTemperatures_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebManExtensions.NotifyCPURSXTemperature(ConsoleProfile.Address);
            SetStatus("WebMAN Controls - Successfully Notified: System Temperature");
        }

        private void ButtonPS3ShowMinimumVersion_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebManExtensions.NotifyMinimumVersion(ConsoleProfile.Address);
            SetStatus("WebMAN Controls - Successfully Notified: System Minimum Version");
        }

        private void ButtonPS3MountBD_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (BD) list...");

            List<ListItem> games = FtpExtensions.GetGamesBD();

            switch (games.Count)
            {
                case <= 0:
                    SetStatus("WebMAN Controls - No Games (BD) Found.");
                    XtraMessageBox.Show(this, "No games (BD) can be found on your console. If you have them on external devices then enable this option in your settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            ListItem selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (BD)", games);

            switch (selectedGame)
            {
                case null:
                    SetStatus("WebMAN Controls - Mount Game (BD) Cancelled.");
                    break;
                default:
                    SetStatus($"WebMAN Controls - Mounting Game (BD): {selectedGame.Name}");
                    WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame.Value);
                    SetStatus($"WebMAN Controls - Successfully Mounted Game (BD): {selectedGame.Name}");
                    break;
            }
        }

        private void ButtonPS3MountISO_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (ISO) list...");

            List<ListItem> games = FtpExtensions.GetGamesISO();

            switch (games.Count)
            {
                case <= 0:
                    SetStatus("WebMAN Controls - No Games (ISO) Found.");
                    XtraMessageBox.Show(this, "No games (ISO) can be found on your console. If you have them on external devices then enable this option in your settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            ListItem selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (ISO)", games);

            switch (selectedGame)
            {
                case null:
                    SetStatus("WebMAN Controls - Mount Game (ISO) Cancelled.");
                    break;
                default:
                    SetStatus($"WebMAN Controls - Mounting Game (ISO): {selectedGame.Name}");
                    WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame.Value);
                    SetStatus($"WebMAN Controls - Successfully Mounted Game (ISO): {selectedGame.Name}");
                    break;
            }
        }

        private void ButtonPS3MountPSN_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (PSN) list...");

            List<ListItem> games = FtpExtensions.GetGamesPSN();

            switch (games.Count)
            {
                case <= 0:
                    SetStatus("WebMAN Controls - No Games (PSN) Found.");
                    XtraMessageBox.Show(this, "No games (PSN) can be found on your console. If you have them on external devices then enable this option in your settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            ListItem selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (PSN)", games);

            switch (selectedGame)
            {
                case null:
                    SetStatus("WebMAN Controls - Mount Game (PSN) Cancelled.");
                    break;
                default:
                    SetStatus($"WebMAN Controls - Mounting Game (PSN): {selectedGame.Name}");
                    WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame.Value);
                    SetStatus($"WebMAN Controls - Successfully Mounted Game (PSN): {selectedGame.Name}");
                    break;
            }
        }

        private void ButtonPS3Unmount_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Unmounting Game...");
            WebManExtensions.Unmount(ConsoleProfile.Address);
            SetStatus("WebMAN Controls - Successfully Unmounted Game");
        }

        private void ButtonPS3Shutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Shutting Down Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Shutdown);
            SetStatus("WebMAN Controls - Successfully Shutdown Console.");
            DisconnectConsole();
        }

        private void ButtonPS3Restart_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Restarting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Restart);
            SetStatus("WebMAN Controls - Successfully Restarted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3SoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Soft Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.SoftReboot);
            SetStatus("WebMAN Controls - Successfully Soft Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3HardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Hard Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.HardReboot);
            SetStatus("WebMAN Controls - Successfully Hard Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3QuickReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Quick Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.QuickReboot);
            SetStatus("WebMAN Controls - Successfully Quick Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3NotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:");

            if (notifyMessage.IsNullOrWhiteSpace())
            {
                SetStatus("No message was entered. Cancelled.");
            }
            {
                SetStatus("WebMAN Controls - Notifying Message...");
                WebManExtensions.NotifyPopup(ConsoleProfile.Address, notifyMessage);
                SetStatus($"WebMAN Controls - Message Notified: {notifyMessage}");
            }
        }

        private void ButtonPS3VirtualController_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Virtual Controller: Opening in Web Browser");
            Process.Start("http://pad.aldostools.org/pad.html");
            SetStatus("WebMAN Controls - Virtual Controller: Opened in Web Browser");
        }

        // XBOX

        private void ButtonXboxFileManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
        }

        private void ButtonXboxGameLauncher_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxGameLauncher(this);
        }

        private void ButtonXboxLaunchFileEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxPluginsEditor(this);
        }

        private void ButtonXboxGameSaveResigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxGameSaveResigner(this);
        }

        private void ButtonXboxXBDMShutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Shutdown();
            DisconnectConsole();
        }

        private void ButtonXboxXBDMSoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Cold);
            DisconnectConsole();
        }

        private void ButtonXboxXBDMHardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Warm);
            DisconnectConsole();
        }

        private void ButtonXboxTakeScreenshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            string filePath = DialogExtensions.ShowSaveFileDialog(this, "Save Screenshot File", "Bitmap Image (*.bmp)|*.bmp");

            if (filePath.IsNullOrWhiteSpace())
            {
                SetStatus("No file path selected. Cancelled.");
                XtraMessageBox.Show("You must choose a location to save the screenshot file.", "No File Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                XboxConsole.ScreenShot(filePath);
                SetStatus($"Screenshot file saved to path: {filePath}");
                XtraMessageBox.Show($"Screenshot file saved to path:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonXboxShowSystemInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(
                $"CPU: {XboxConsole.GetTemperature(TemperatureFlag.CPU)}°C\n" +
                $"EDRAM: {XboxConsole.GetTemperature(TemperatureFlag.EDRAM)}°C\n" +
                $"GPU: {XboxConsole.GetTemperature(TemperatureFlag.GPU)}°C\n" +
                $"Motherboard: {XboxConsole.GetTemperature(TemperatureFlag.MotherBoard)}°C",
                "System Temperatures", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonXboxXNotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:");

            List<string> notifyIcons = new();

            foreach (XNotifyLogo xNotifyIcon in Enum.GetValues(typeof(XNotifyLogo)) as XNotifyLogo[])
            {
                notifyIcons.Add(xNotifyIcon.Humanize());
            }

            string notifyIcon = DialogExtensions.ShowListItemDialog(this, "Notify Icon", "Icon:", notifyIcons.ToArray());

            XboxConsole.XNotify(notifyMessage, notifyIcon.DehumanizeTo<XNotifyLogo>());
        }

        // HELP MENU

        private void MenuItemSendFeedback_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start($"{Urls.GitHubRepo}/issues/new");
        }

        private void ButtonDiscordServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Urls.DiscordServer);
        }

        private void ButtonOfficialSource_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Urls.GitHubRepo);
        }

        private void ButtonCheckForUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateExtensions.CheckApplicationVersion();
        }

        private void ButtonWhatsNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Showing latest Change Log...");
            DialogExtensions.ShowWhatsNewDialog(this, UpdateExtensions.GitHubData);
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
                    XtraMessageBox.Show(this, "Failed to open the log file.\nIt may have been deleted, that's ok.", $"{ResourceLanguage.GetString("Error")}", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ButtonAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowAboutWindow(this);
        }

        // RIGHT MENU

        private void MenuItemButtonChatRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowChatRoom(this);
        }

        private void MenuItemButtonSubmitMods_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowSubmitModsDialog(this);
        }

        #endregion

        #region Connect & Disconnect Functions

        /// <summary>
        /// Attempt to connect to the console profile by opening the FTP connection.
        /// </summary>
        public void ConnectConsole()
        {
            try
            {
                SetStatus($"{ResourceLanguage.GetString("Connecting to")} {ConsoleProfile.Name} ({ConsoleProfile.Address})");

                FtpClient = new FtpClient
                {
                    Host = ConsoleProfile.Address,
                    Port = ConsoleProfile.TypePrefix == PlatformPrefix.PS3 ? 21 : 21,
                    Credentials = ConsoleProfile.UseDefaultCredentials
                    ? (ConsoleProfile.TypePrefix == PlatformPrefix.PS3
                    ? new NetworkCredential("anonymous", "anonymous")
                    : new NetworkCredential("xboxftp", "xboxftp"))
                    : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password),
                    SocketKeepAlive = true
                    //ReadTimeout = -1,
                    //SslProtocols = System.Security.Authentication.SslProtocols.Tls12
                };

                switch (ConsoleProfile.TypePrefix)
                {
                    case PlatformPrefix.PS3:
                        {
                            FtpClient.Connect();

                            IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address);

                            switch (IsWebManInstalled)
                            {
                                case true:
                                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{ResourceLanguage.GetString("You are now connected to")} ModioX ★");
                                    break;
                            }

                            SetConsoleType(ConsoleProfile.TypePrefix);

                            MenuItemConnectToPS3.Caption = $"{ResourceLanguage.GetString("Disconnect")}...";
                            MenuItemConnectToXBOX.Enabled = false;
                            break;
                        }
                    case PlatformPrefix.XBOX:
                        XboxManager = new XboxManager();

                        XboxConsole = ConsoleProfile.UseDefaultConsole
                            ? XboxManager.OpenConsole(XboxManager.DefaultConsole)
                            : XboxManager.OpenConsole(ConsoleProfile.Address);

                        //XboxConsole.XNotify($"{ResourceLanguage.GetString("You are now connected to")} ModioX", XNotifyLogo.FLASHING_HAPPY_FACE);

                        SetConsoleType(ConsoleProfile.TypePrefix);

                        MenuItemConnectToXBOX.Caption = $"{ResourceLanguage.GetString("Disconnect")}...";
                        MenuItemConnectToPS3.Enabled = false;
                        break;
                }

                IsConsoleConnected = true;
                SetStatusConsole(ConsoleProfile);

                SetStatus($"{ResourceLanguage.GetString("Successfully connected to console")}.");
                XtraMessageBox.Show(this, $"{ResourceLanguage.GetString("Successfully connected to console")}.", $"{ResourceLanguage.GetString("Success")}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableConsoleActions();

                if (Settings.AutoLoadDirectoryListings || NavigationFrame.SelectedPage == PageFileManager)
                {
                    if (NavigationFrame.SelectedPage == PageFileManager)
                    {
                        CloseOverlayFeatureNotAvailable(PageFileManager, handle);
                    }

                    StartFileManager();
                    TimerLoadConsole.Enabled = true;
                    hadLoadedFileManager = true;
                }

                // Only reload categories if the console type hasn't been changed
                if (PlatformType != Settings.StartupLibrary)
                {
                    LoadGameModsCategories();
                    LoadHomebrewCategories();
                    LoadResourcesCategories();
                }
            }
            catch (Exception ex)
            {
                SetStatus($"{ResourceLanguage.GetString("Unable to connect to")} {ConsoleProfile.Name} ({ConsoleProfile.Address}).", ex);
                XtraMessageBox.Show(this,
                    $"{ResourceLanguage.GetString("Unable to connect to")} {ConsoleProfile.Name} ({ConsoleProfile.Address}) {(ConsoleProfile.TypePrefix == PlatformPrefix.XBOX ? $"\n{ResourceLanguage.GetString("Make sure Neighborhood is installed on your computer")}." : string.Empty)}\n\n{ResourceLanguage.GetString("Error")}: {ex.Message}",
                    $"{ResourceLanguage.GetString("Connection Failed")}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disconnects from the console and flushes all resources from the FTP connections.
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus($"{ResourceLanguage.GetString("Disconnecting from console")}...");

            switch (PlatformType)
            {
                case PlatformPrefix.PS3:
                    try
                    {
                        FtpClient.Dispose();
                    }
                    catch
                    {
                        // False positive, if console is powered off then an error will be thrown.
                    }

                    break;
                case PlatformPrefix.XBOX:
                    try
                    {
                        XboxConsole.CloseConnection(0);
                    }
                    catch
                    {
                        // False positive, if console is powered off then an error will be thrown.
                    }

                    break;
            }

            IsConsoleConnected = false;
            SetStatusConsole(null);

            EnableFileManager(false);

            EnableConsoleActions();

            MenuItemConnectToPS3.Enabled = true;
            MenuItemConnectToPS3.Caption = $"{ResourceLanguage.GetString("Connect to console")}...";

            MenuItemConnectToXBOX.Enabled = true;
            MenuItemConnectToXBOX.Caption = $"{ResourceLanguage.GetString("Connect to console")}...";

            SetStatus($"{ResourceLanguage.GetString("Successfully disconnected from console")}.");

            XtraMessageBox.Show(this, $"{ResourceLanguage.GetString("Successfully disconnected from console")}.", $"{ResourceLanguage.GetString("Success")}", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SearchDownloads();
        }

        private void NavigationItemInstalledMods_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageInstalledMods;
            SearchInstalledMods();
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
                if (handle == null)
                {
                    handle = ShowOverlayFeatureNotAvailable(PageFileManager, ResourceLanguage.GetString("You must be connected to your console to use this feature."));
                }
            }
            else
            {
                if (handle != null)
                {
                    CloseOverlayFeatureNotAvailable(PageFileManager, handle);
                }
            }
        }

        private void NavigationItemSettings_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageSettings;
        }

        private bool hasLoadedGameMods = false;

        private void NavigationItemGameMods_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageGameMods;

            if (!hasLoadedGameMods)
            {
                LoadGameModsCategories();
                SearchGameMods();
                hasLoadedGameMods = true;
            }
        }

        private bool hasLoadedHomebrew = false;

        private void NavigationItemHomebrew_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageHomebrew;

            if (!hasLoadedHomebrew)
            {
                LoadHomebrewCategories();
                SearchHomebrew();
                hasLoadedHomebrew = true;
            }
        }

        private bool hasLoadedResources = false;

        private void NavigationItemResources_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageResources;

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
            NavigationFrame.SelectedPage = PagePackages;

            if (!hasLoadedPackages)
            {
                LoadPackages();
                hasLoadedPackages = true;
            }
        }

        private bool hasLoadedPlugins = false;

        private void NavigationItemPlugins_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PagePlugins;

            if (!hasLoadedPlugins)
            {
                SearchPlugins();
                hasLoadedPlugins = true;
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

        private bool hasLoadedRealTimeMods = false;

        private void NavigationItemRealTimeMods_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageRealTimeMods;

            if (!hasLoadedRealTimeMods)
            {
                LoadRealTimeMods();
                hasLoadedRealTimeMods = true;
            }
        }

        #endregion

        #region Dashboard Page

        private void LoadStatistics()
        {
            LabelHeaderStatistics.Text = ResourceLanguage.GetString("STATISTICS");

            LabelStatisticsPlayStation3.Text =
                $"{Database.ModsPS3.Mods.Count:N0} {ResourceLanguage.GetString("Mods Total")}\n" +
                $"{Database.PackagesCount():N0} {ResourceLanguage.GetString("Packages Total")}\n" +
                $"{Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == PlatformPrefix.PS3).ToList().Count:N0} {ResourceLanguage.GetString("Game Saves Total")}";

            LabelStatisticsXbox360.Text =
                $"{Database.PluginsXBOX.Mods.Count:N0} {ResourceLanguage.GetString("Plugins Total")}\n" +
                $"{Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == PlatformPrefix.XBOX).ToList().Count:N0} {ResourceLanguage.GetString("Game Saves Total")}";

            LabelStatisticsLastUpdated.Text = $"{ResourceLanguage.GetString("Last Updated")}: {Database.ModsPS3.LastUpdated.ToLocalTime().ToShortDateString()}";
        }

        private void LoadAnnouncements()
        {
            Database.Announcements.Announcements.Reverse();

            foreach (AnnouncementsData.Announcement announcement in Database.Announcements.Announcements)
            {
                if (!Settings.DismissedAnnouncements.Contains(announcement.Id))
                {
                    if (DateTime.Now >= announcement.DateStart && DateTime.Now <= announcement.DateEnd)
                    {
                        AccouncementItem announcementItem = new(announcement.Id, announcement.Title, announcement.Message, announcement.DateStart) { Dock = DockStyle.Top };
                        PanelAnnouncementsItems.Controls.Add(announcementItem);
                        announcementItem.BringToFront();
                        PanelAnnouncementsItems.ScrollControlIntoView(announcementItem);
                    }
                }
            }

            NoAnnouncementsItem.Visible = PanelAnnouncementsItems.Controls.Count < 1;
        }

        private async void LoadNewsFeed()
        {
            PanelNewsItems.Controls.Clear();

            Feed feed = await FeedReader.ReadAsync(Urls.RssFeedData);

            foreach (FeedItem item in feed.Items)
            {
                NewsItem newsItem = new(item.Title, item.Description, (DateTime)item.PublishingDate) { Dock = DockStyle.Top };
                PanelNewsItems.Controls.Add(newsItem);
            }
        }

        private void LoadChangeLog()
        {
            Models.Release_Data.GitHubData gitHubData = UpdateExtensions.GitHubData;

            string releaseBody = gitHubData.Body.Substring(0, gitHubData.Body.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

            LabelChangeLogVersion.Text = $"{gitHubData.Name} ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = releaseBody.Replace("- ", "• ");
        }

        // Setup Tile Items

        private void TileItemIntroductionDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            Process.Start("https://github.com/ohhsodead/ModioX#quick-guide");
        }

        private void TileItemAddNewConsole_ItemClick(object sender, TileItemEventArgs e)
        {
            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
            }
        }

        private void TileItemScanForXboxConsoles_ItemClick(object sender, TileItemEventArgs e)
        {
            SetStatus("Scanning for Xbox consoles...");
            Extensions.Helpers.ScanForXboxConsoles(this);
            SetStatus("Finished scanning for Xbox consoles.");
        }

        private void TileItemEditConsoleProfiles_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogExtensions.ShowEditConnectionsDialog(this, true);
        }

        private void TileItemStartupLibrary_ItemClick(object sender, TileItemEventArgs e)
        {
            if (PlatformType == PlatformPrefix.PS3)
            {
                SetConsoleType(PlatformPrefix.XBOX);
                Settings.StartupLibrary = PlatformPrefix.XBOX;
                e.Item.Elements[1].Text = "Xbox 360";
            }
            else if (PlatformType == PlatformPrefix.XBOX)
            {
                SetConsoleType(PlatformPrefix.PS3);
                Settings.StartupLibrary = PlatformPrefix.PS3;
                e.Item.Elements[1].Text = "PlayStation 3";
            }

            if (Settings.StartupLibrary != PlatformType)
            {
                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("You must restart the application for this change to take effect. Would you like to restart now?"), ResourceLanguage.GetString("Restart Required"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void TileItemSetDownloadsLocation_ItemClick(object sender, TileItemEventArgs e)
        {
            SetDownloadsLocation();
        }

        private void SetTileDefaultModsText()
        {
            if (PlatformType == PlatformPrefix.PS3)
            {
                TileItemStartupLibrary.Elements[1].Text = "PlayStation 3";
            }
            else if (PlatformType == PlatformPrefix.XBOX)
            {
                TileItemStartupLibrary.Elements[1].Text = "Xbox 360";
            }
        }

        // Tools Tile Items

        private void TileItemToolsGameBackupFiles_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!IsConsoleConnected)
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("You must be connected to your console to use this feature."), ResourceLanguage.GetString("Not Connected"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogExtensions.ShowGameBackupFiles(this);
        }

        private void TileItemToolsGameUpdateFinder_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogExtensions.ShowGameUpdatesFinder(this);
        }

        private void TileItemToolsPackageManager_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!IsConsoleConnected)
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("You must be connected to your console to use this feature."), ResourceLanguage.GetString("Not Connected"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogExtensions.ShowPackageManager(this);
        }

        private void TileItemToolsConsoleManager_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!IsConsoleConnected)
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("You must be connected to your console to use this feature."), ResourceLanguage.GetString("Not Connected"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogExtensions.ShowConsoleManager(this);
        }

        private void TileItemToolsCustomizeGameRegions_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogExtensions.ShowGameRegionsDialog(this);
        }

        private void TileItemToolsGameSaveResigner_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogExtensions.ShowXboxGameSaveResigner(this);
        }

        private void TileItemToolsGameLauncher_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!IsConsoleConnected)
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("You must be connected to your console to use this feature."), ResourceLanguage.GetString("Not Connected"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogExtensions.ShowXboxGameLauncher(this);
        }

        private void TileItemToolsLaunchFileEditor_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!IsConsoleConnected)
            {
                XtraMessageBox.Show(this, ResourceLanguage.GetString("You must be connected to your console to use this feature."), ResourceLanguage.GetString("Not Connected"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogExtensions.ShowXboxPluginsEditor(this);
        }

        private void PanelAnnouncementsItems_ControlAdded(object sender, ControlEventArgs e)
        {
            NoAnnouncementsItem.Visible = PanelAnnouncementsItems.Controls.Count < 1;
        }

        private void PanelAnnouncementsItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            NoAnnouncementsItem.Visible = PanelAnnouncementsItems.Controls.Count < 1;
        }

        private void ImageReloadNewsItems_Click(object sender, EventArgs e)
        {
            LoadNewsFeed();
        }

        #endregion

        #region Downloads Page

        private void TileItemDownloadsViewDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            PlatformPrefix consoleType = GridViewDownloads.GetRowCellDisplayText(GridViewDownloads.FocusedRowHandle, "Platform").DehumanizeTo<PlatformPrefix>();

            ModItemData modItem = consoleType == PlatformPrefix.PS3
                ? Database.ModsPS3.GetModById(consoleType, int.Parse(GridViewDownloads.GetRowCellDisplayText(GridViewDownloads.FocusedRowHandle, "Id")))
                : Database.PluginsXBOX.GetModById(consoleType, int.Parse(GridViewDownloads.GetRowCellDisplayText(GridViewDownloads.FocusedRowHandle, "Id")));

            if (modItem != null)
            {
                ShowDetails(consoleType.Humanize(), modItem.Id);
            }
        }

        private void TileItemDownloadsOpenFolder_ItemClick(object sender, TileItemEventArgs e)
        {
            Process.Start(Settings.DownloadsLocation);
        }

        private void TileItemDownloadsOpenFile_ItemClick(object sender, TileItemEventArgs e)
        {
            int? downloadItemModId = GridViewDownloads.GetFocusedRowCellValue("Id") as int?;
            string downloadItemPlatform = GridViewDownloads.GetFocusedRowCellValue("Platform") as string;
            DownloadedItem downloadedItem = Settings.DownloadedMods.FirstOrDefault(x => x.ModId.Equals(downloadItemModId) && x.Platform.Humanize().EqualsIgnoreCase(downloadItemPlatform));
            Process.Start("explorer.exe", $"/select,\"{downloadedItem.FilePath}\"");
            //Process.Start(downloadedItem.FilePath);
        }

        private void TileItemDownloadsDeleteAllItems_ItemClick(object sender, TileItemEventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete all of your downloads?", "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (string file in Directory.GetFiles(Settings.DownloadsLocation, "*.zip", System.IO.SearchOption.AllDirectories))
                {
                    File.Delete(file);
                }

                Settings.DownloadedMods.Clear();
                SearchDownloads();
            }
        }

        private void TileItemDownloadsDeleteItem_ItemClick(object sender, TileItemEventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete the selected item from your downloads?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? downloadItemModId = GridViewDownloads.GetFocusedRowCellValue("Id") as int?;
                string downloadItemPlatform = GridViewDownloads.GetFocusedRowCellValue("Platform") as string;
                DownloadedItem downloadedItem = Settings.DownloadedMods.FirstOrDefault(x => x.ModId.Equals(downloadItemModId) && x.Platform.Humanize().EqualsIgnoreCase(downloadItemPlatform));
                File.Delete(downloadedItem.FilePath);
                Settings.DownloadedMods.RemoveAll(x => x == downloadedItem);
                SearchDownloads();
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

        /// <summary>
        /// Get/set the downloads status for filtering downloads.
        /// </summary>
        private string FilterDownloadsStatus { get; set; } = string.Empty;

        private void ComboBoxDownloadsFilterPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDownloadsPlatform = ComboBoxDownloadsFilterPlatform.SelectedIndex is (-1) or 0
                ? string.Empty
                : ComboBoxDownloadsFilterPlatform.SelectedItem as string;

            SearchDownloads();
        }

        private void TextBoxDownloadsFilterFileName_EditValueChanged(object sender, EventArgs e)
        {
            FilterDownloadsFileName = TextBoxDownloadsFilterFileName.Text;

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

        private void ImageDownloadsFilterDownloadOnType_Click(object sender, EventArgs e)
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

        private void DateTimeFilterDownloadsDate_EditValueChanged(object sender, EventArgs e)
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
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Platform", typeof(string)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("Mod Type", typeof(string)),
                new("Region", typeof(string)),
                new("Version", typeof(string)),
                new("Downloaded On", typeof(string))
            });

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

                ModItemData modItemData = downloadedItem.Platform == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(downloadedItem.Platform, downloadedItem.ModId)
                    : Database.PluginsXBOX.GetModById(downloadedItem.Platform, downloadedItem.ModId);

                if (modItemData != null)
                {
                    DataTableDownloads.Rows.Add(modItemData.Id.ToString(),
                                                downloadedItem.Platform.Humanize(),
                                                category.Title,
                                                File.Exists(downloadedItem.FilePath) ? downloadedItem.DownloadFile.Name : $"{downloadedItem.DownloadFile.Name} (File Missing)",
                                                modItemData.ModType,
                                                downloadedItem.DownloadFile.Region,
                                                downloadedItem.DownloadFile.Version,
                                                Settings.UseRelativeTimes ? downloadedItem.DateTime.Humanize() : $"{downloadedItem.DateTime:g}");
                }
            }

            GridControlDownloads.DataSource = DataTableDownloads;

            GridViewDownloads.FocusedRowHandle = -1;

            GridViewDownloads.Columns[0].Visible = false;

            GridViewDownloads.Columns[1].MinWidth = 104;
            GridViewDownloads.Columns[1].MaxWidth = 104;

            GridViewDownloads.Columns[2].MinWidth = 226;
            GridViewDownloads.Columns[2].MaxWidth = 226;

            //GridViewDownloads.Columns[3].MinWidth = 100; // Ignore column

            GridViewDownloads.Columns[4].MinWidth = 100;
            GridViewDownloads.Columns[4].MaxWidth = 100;

            GridViewDownloads.Columns[5].MinWidth = 90;
            GridViewDownloads.Columns[5].MaxWidth = 90;

            GridViewDownloads.Columns[6].MinWidth = 68;
            GridViewDownloads.Columns[6].MaxWidth = 68;

            GridViewDownloads.Columns[7].MinWidth = 96;
            GridViewDownloads.Columns[7].MaxWidth = 96;

            TileItemDownloadsDeleteAllItems.Enabled = GridViewDownloads.RowCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;

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

                ModItemData modItemData = downloadedItem.Platform == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(downloadedItem.Platform, downloadedItem.ModId)
                    : Database.PluginsXBOX.GetModById(downloadedItem.Platform, downloadedItem.ModId);

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
                        DataTableDownloads.Rows.Add(modItemData.Id.ToString(),
                                                    downloadedItem.Platform.Humanize(),
                                                    category.Title,
                                                    File.Exists(downloadedItem.FilePath) ? downloadedItem.DownloadFile.Name : $"{downloadedItem.DownloadFile.Name} (File Missing)",
                                                    modItemData.ModType,
                                                    downloadedItem.DownloadFile.Region,
                                                    downloadedItem.DownloadFile.Version,
                                                    Settings.UseRelativeTimes ? downloadedItem.DateTime.Humanize() : $"{downloadedItem.DateTime:g}");
                    }
                }
            }

            GridControlDownloads.DataSource = DataTableDownloads;

            GridViewDownloads.FocusedRowHandle = -1;

            TileItemDownloadsDeleteAllItems.Enabled = GridViewDownloads.RowCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;

            GridViewDownloads.HideLoadingPanel();
        }

        private void GridViewDownloads_RowClick(object sender, RowClickEventArgs e)
        {
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsOpenFile.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;
        }

        private void GridViewDownloads_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsOpenFile.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;
        }

        #endregion

        #region Installed Mods Page

        private void TileItemInstalledModsViewDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            PlatformPrefix consoleType = GridViewInstalledMods.GetRowCellDisplayText(GridViewInstalledMods.FocusedRowHandle, "Platform").DehumanizeTo<PlatformPrefix>();

            ModItemData modItem = consoleType == PlatformPrefix.PS3
                ? Database.ModsPS3.GetModById(consoleType, int.Parse(GridViewInstalledMods.GetRowCellDisplayText(GridViewInstalledMods.FocusedRowHandle, "Id")))
                : Database.PluginsXBOX.GetModById(consoleType, int.Parse(GridViewInstalledMods.GetRowCellDisplayText(GridViewInstalledMods.FocusedRowHandle, "Id")));

            if (modItem != null)
            {
                ShowDetails(consoleType.Humanize(), modItem.Id);
            }
        }

        private void TileItemInstalledModsUninstallAll_ItemClick(object sender, TileItemEventArgs e)
        {
            List<InstalledModInfo> installedMods = Settings.InstalledMods;

            foreach (InstalledModInfo installedGameMod in installedMods)
            {
                ModItemData modItem = installedGameMod.Platform == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(installedGameMod.Platform, installedGameMod.ModId)
                    : Database.PluginsXBOX.GetModById(installedGameMod.Platform, installedGameMod.ModId);

                InstalledModInfo installedModInfo = Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);
                ShowTransferModsDialog(this, TransferType.UninstallMods, modItem, installedModInfo == null ? string.Empty : installedModInfo.DownloadFiles.Region);
            }

            LoadInstalledMods();
        }

        private void TileItemInstalledModsUninstallSelected_ItemClick(object sender, TileItemEventArgs e)
        {
            if (GridViewInstalledMods.SelectedRowsCount > 0)
            {
                PlatformPrefix consoleType = GridViewInstalledMods.GetFocusedRowCellDisplayText("Platform").DehumanizeTo<PlatformPrefix>();
                int modId = int.Parse(GridViewInstalledMods.GetRowCellDisplayText(GridViewInstalledMods.GetSelectedRows()[0], "Id"));

                ModItemData selectedModItem = consoleType == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(consoleType, modId)
                    : Database.PluginsXBOX.GetModById(consoleType, modId);

                foreach (InstalledModInfo installedModInfo in Settings.InstalledMods)
                {
                    ModItemData modItem = consoleType == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(consoleType, installedModInfo.ModId)
                    : Database.PluginsXBOX.GetModById(consoleType, installedModInfo.ModId);

                    if (modItem.Id == selectedModItem.Id)
                    {
                        ShowTransferModsDialog(this, TransferType.UninstallMods, modItem, installedModInfo == null ? string.Empty : installedModInfo.DownloadFiles.Region);
                        break;
                    }
                }

                LoadInstalledMods();
            }
        }

        /// <summary>
        /// Get/set the playform for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsPlatform { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the file name for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsFileName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the category Id for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsCategoryId { get; set; } = string.Empty;

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
        /// Get/set the version for filtering installed mods.
        /// </summary>
        private string FilterInstalledModsCreator { get; set; } = string.Empty;

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
            FilterInstalledModsPlatform = ComboBoxInstalledModsFilterPlatform.SelectedIndex == 0 | ComboBoxInstalledModsFilterPlatform.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledModsFilterPlatform.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
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

            SearchInstalledMods();
        }

        private void TextBoxFilterInstalledModsName_EditValueChanged(object sender, EventArgs e)
        {
            FilterInstalledModsFileName = TextBoxInstalledModsFilterName.Text;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsType = ComboBoxInstalledModsFilterType.SelectedIndex == 0 | ComboBoxInstalledModsFilterType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledModsFilterType.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsRegion = ComboBoxInstalledModsFilterRegion.SelectedIndex == 0 | ComboBoxInstalledModsFilterRegion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledModsFilterRegion.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsVersion = ComboBoxInstalledModsFilterVersion.SelectedIndex == 0 | ComboBoxInstalledModsFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledModsFilterVersion.SelectedItem as string;

            SearchInstalledMods();
        }

        private void ComboBoxInstalledModsFilterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstalledModsCreator = ComboBoxInstalledModsFilterCreator.SelectedIndex == 0 | ComboBoxInstalledModsFilterCreator.SelectedIndex == -1
                ? string.Empty
                : ComboBoxInstalledModsFilterCreator.SelectedItem as string;

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

            SearchDownloads();
        }

        private void NumericBoxFilterInstalledModsFiles_Properties_EditValueChanged(object sender, EventArgs e)
        {
            FilterInstalledModsTotalFiles = NumericBoxInstalledModsFilterTotalFiles.Value <= -1
                ? null
                : ((int)NumericBoxInstalledModsFilterTotalFiles.Value);

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

            SearchDownloads();
        }

        private void DateTimeBoxFilterInstalledModsInstalledOn_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTimeInstalledModsFilterInstalledOn.Text.ToString().IsValidDate("MM/dd/yyyy"))
            {
                FilterInstalledModsInstalledOn = DateTime.Parse(DateTimeInstalledModsFilterInstalledOn.EditValue.ToString());
                SearchInstalledMods();
            }
            else
            {
                DateTimeInstalledModsFilterInstalledOn.EditValue = null;
                FilterInstalledModsInstalledOn = null;
                SearchInstalledMods();
            }
        }

        private void LoadInstalledModsCategories()
        {
            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                ComboBoxInstalledModsFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableInstalledMods { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Platform", typeof(string)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("Mod Type", typeof(string)),
                new("Game Region", typeof(string)),
                new("Version", typeof(string)),
                new("Creator", typeof(string)),
                new("# Files", typeof(string)),
                new("Installed On", typeof(string))
            });

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void LoadInstalledMods()
        {
            LoadInstalledModsCategories();

            GridViewInstalledMods.ShowLoadingPanel();

            DataTableInstalledMods.Rows.Clear();

            int totalFiles = 0;

            foreach (InstalledModInfo installedModInfo in Settings.InstalledMods)
            {
                Category modCategory = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                ModItemData modItemData = installedModInfo.Platform == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(installedModInfo.Platform, installedModInfo.ModId)
                    : Database.PluginsXBOX.GetModById(installedModInfo.Platform, installedModInfo.ModId);

                DataTableInstalledMods.Rows.Add(modItemData.Id.ToString(),
                                                installedModInfo.Platform.Humanize(),
                                                modCategory.Title,
                                                installedModInfo.DownloadFiles.Name,
                                                modItemData.ModType,
                                                installedModInfo.DownloadFiles.Region,
                                                installedModInfo.DownloadFiles.Version,
                                                modItemData.CreatedBy,
                                                $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? " Files" : " File")}",
                                                Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");

                totalFiles += installedModInfo.TotalFiles;
            }

            GridControlInstalledMods.DataSource = DataTableInstalledMods;

            GridViewInstalledMods.FocusedRowHandle = -1;

            GridViewInstalledMods.Columns[0].Visible = false;

            GridViewInstalledMods.Columns[1].MinWidth = 104;
            GridViewInstalledMods.Columns[1].MaxWidth = 104;

            GridViewInstalledMods.Columns[2].MinWidth = 226;
            GridViewInstalledMods.Columns[2].MaxWidth = 226;

            //GridViewInstalledMods.Columns[3].MinWidth = 80;
            //GridViewInstalledMods.Columns[3].MaxWidth = 80;

            GridViewInstalledMods.Columns[4].MinWidth = 100;
            GridViewInstalledMods.Columns[4].MaxWidth = 100;

            GridViewInstalledMods.Columns[5].MinWidth = 88;
            GridViewInstalledMods.Columns[5].MaxWidth = 88;

            GridViewInstalledMods.Columns[6].MinWidth = 70;
            GridViewInstalledMods.Columns[6].MaxWidth = 70;

            GridViewInstalledMods.Columns[7].MinWidth = 132;
            GridViewInstalledMods.Columns[7].MaxWidth = 132;

            GridViewInstalledMods.Columns[8].MinWidth = 76;
            GridViewInstalledMods.Columns[8].MaxWidth = 76;

            GridViewInstalledMods.Columns[9].MinWidth = 94;
            GridViewInstalledMods.Columns[9].MaxWidth = 94;

            TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;

            GridViewInstalledMods.HideLoadingPanel();
        }

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void SearchInstalledMods()
        {
            GridViewInstalledMods.ShowLoadingPanel();

            DataTableInstalledMods.Rows.Clear();

            int totalFiles = 0;

            foreach (InstalledModInfo installedModInfo in Settings.InstalledMods)
            {
                Category modCategory = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                ModItemData modItemData = installedModInfo.Platform == PlatformPrefix.PS3
                    ? Database.ModsPS3.GetModById(installedModInfo.Platform, installedModInfo.ModId)
                    : Database.PluginsXBOX.GetModById(installedModInfo.Platform, installedModInfo.ModId);

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
                    DataTableInstalledMods.Rows.Add(modItemData.Id.ToString(),
                                                    installedModInfo.Platform.Humanize(),
                                                    modCategory.Title,
                                                    installedModInfo.DownloadFiles.Name,
                                                    modItemData.ModType,
                                                    installedModInfo.DownloadFiles.Region,
                                                    installedModInfo.DownloadFiles.Version,
                                                    modItemData.CreatedBy,
                                                    $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? " Files" : " File")}",
                                                    Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");

                    totalFiles += installedModInfo.TotalFiles;
                }
            }

            GridControlInstalledMods.DataSource = DataTableInstalledMods;

            GridViewInstalledMods.FocusedRowHandle = -1;

            TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;

            GridViewInstalledMods.HideLoadingPanel();
        }

        private void GridViewInstalledMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledMods.SelectedRowsCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;
        }

        private void GridViewInstalledMods_RowClick(object sender, RowClickEventArgs e)
        {
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledMods.SelectedRowsCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;
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
        private string DirectoryPathConsole { get; set; } = PlatformType == PlatformPrefix.PS3 ? "/dev_hdd0/" : @"Hdd:\";

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

            ButtonFileManagerConsoleAddToGames.Visible = PlatformType == PlatformPrefix.XBOX;

            SetLocalStatus($"{ResourceLanguage.GetString("Fetching drives")}...");

            foreach (DriveInfo driveInfo in LocalDrives)
            {
                ComboBoxFileManagerLocalDrives.Properties.Items.Add(driveInfo.Name.Replace(@"\", ""));
            }

            switch (Settings.RememberLocalPath)
            {
                case true when PlatformType == PlatformPrefix.PS3:
                    {
                        if (Settings.LocalPathPS3.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathPS3))
                        {
                            LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                        }
                        else
                        {
                            LoadLocalDirectory(Settings.LocalPathPS3);
                        }

                        break;
                    }
                case true:
                    {
                        switch (PlatformType)
                        {
                            case PlatformPrefix.XBOX when Settings.LocalPathXBOX.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathXBOX):
                                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                                break;
                            case PlatformPrefix.XBOX:
                                LoadLocalDirectory(Settings.LocalPathXBOX);
                                break;
                        }

                        break;
                    }
                default:
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                    break;
            }

            //EnableFileManager(true);
            hadLoadedFileManager = true;
        }

        private void TimerLoadConsole_Tick(object sender, EventArgs e)
        {
            TimerLoadConsole.Enabled = false;

            SetConsoleStatus($"{ResourceLanguage.GetString("Fetching root directories")}...");

            switch (PlatformType)
            {
                case PlatformPrefix.PS3:
                    {
                        foreach (ListItem driveName in FtpExtensions.GetFolderNames("/"))
                        {
                            ComboBoxFileManagerConsoleDrives.Properties.Items.Add(driveName.Name.Replace(@"/", ""));
                        }

                        break;
                    }

                case PlatformPrefix.XBOX:
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

            SetConsoleStatus($"{ResourceLanguage.GetString("Successfully fetched root directories")}.");

            switch (Settings.RememberLocalPath)
            {
                case true:
                    switch (PlatformType)
                    {
                        case PlatformPrefix.PS3:

                            if (Settings.ConsolePathPS3.Equals("/") || Settings.ConsolePathPS3.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory("/" + ComboBoxFileManagerConsoleDrives.Properties.Items[0] + "/");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathPS3);
                            }

                            break;

                        case PlatformPrefix.XBOX:

                            if (Settings.ConsolePathXBOX.Equals(@"\") || Settings.ConsolePathXBOX.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory(ComboBoxFileManagerConsoleDrives.Properties.Items[0] + @":\");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathXBOX);
                            }

                            break;
                    }

                    break;
                case false:
                    switch (PlatformType)
                    {
                        case PlatformPrefix.PS3:

                            LoadConsoleDirectory("/dev_hdd0/");
                            break;

                        case PlatformPrefix.XBOX:

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
            new List<DataColumn>
            {
                    new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                    new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                    new() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                    new() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                    new() { Caption = "Last Modified", ColumnName = "Last Modified", DataType = typeof(string) }
            });

        /// <summary>
        /// Loads files and folders into the local gridview
        /// </summary>
        /// <param name="directoryPath"> </param>
        public void LoadLocalDirectory(string directoryPath)
        {
            try
            {
                SetLocalStatus($"Fetching directory listing of '{directoryPath}'...");

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
                                                     "",
                                                     "");
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
                                        Settings.UseFormattedFileSizes ? fileBytes.Bytes().Humanize("#.##") : fileBytes + " Bytes",
                                        File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                SetLocalStatus("Successfully fetched directory listing.");

                string statusFiles = files > 0
                    ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : "")}"
                    : "" + $"{(folders < 1 ? "." : "")}";
                string statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = files > 0
                    ? $"Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " bytes")}"
                    : "";

                switch (files)
                {
                    case < 1 when folders < 1:
                        SetLocalStatus("Empty directory.");
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
                SetLocalStatus($"Error fetching directory listing for path: {DirectoryPathLocal} - {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error fetching directory listing for path: {DirectoryPathLocal} - {ex.Message}", ex);

                try
                {
                    // Attempt to load the parent directory listing instead
                    LoadLocalDirectory(Path.GetDirectoryName(DirectoryPathLocal) + @"\");
                }
                catch
                {
                    SetLocalStatus($"Error fetching directory listing for path: {Path.GetDirectoryName(DirectoryPathLocal) + @"\"} - {ex.Message}", ex);
                }
            }
        }

        private void GridViewLocalFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Name");

                        ButtonFileManagerLocalUpload.Enabled = type == "file" && name != "..";
                        ButtonFileManagerLocalDelete.Enabled = (type == "file") | (type == "folder") && name != "..";
                        ButtonFileManagerFileLocalRename.Enabled = (type == "file") | (type == "folder") && name != "..";
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
                        string type = GridViewFileManagerLocalFiles.GetRowCellValue(e.RowHandle, "Type").ToString();
                        string name = GridViewFileManagerLocalFiles.GetRowCellValue(e.RowHandle, "Name").ToString();

                        ButtonFileManagerLocalUpload.Enabled = type == "file" && name != "..";
                        ButtonFileManagerLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerFileLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
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
                        string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Name");

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
            string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Type");

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
                SetStatus($"Unable to open File Explorer for directory: {TextBoxFileManagerLocalPath.Text} Error: {ex.Message}", ex);
            }
        }

        public void CreateLocalFolder()
        {
            try
            {
                string newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ");

                if (newName != null)
                {
                    string folderPath = TextBoxFileManagerLocalPath.Text + @"\" + newName;

                    if (Directory.Exists(folderPath))
                    {
                        XtraMessageBox.Show("A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetStatus($"Creating local folder: {folderPath}");
                        Directory.CreateDirectory(folderPath);
                        SetStatus($"Successfully created local folder: {folderPath}");
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to create a new folder on your computer. Error: {ex.Message}");
                XtraMessageBox.Show($"Unable to create a new folder on your computer. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UploadLocalFile()
        {
            try
            {
                string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Type");
                string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Name");

                switch (type)
                {
                    case "file":
                        {
                            string localPath = TextBoxFileManagerLocalPath.Text + name;
                            string consolePath = TextBoxFileManagerConsolePath.Text + name;

                            if (File.Exists(localPath))
                            {
                                SetStatus($"Uploading file to {consolePath}...");

                                switch (PlatformType)
                                {
                                    case PlatformPrefix.PS3:
                                        FtpExtensions.UploadFile(localPath, consolePath);
                                        break;
                                    default:
                                        XboxConsole.SendFile(localPath, consolePath);
                                        break;
                                }

                                SetStatus($"Successfully uploaded local file: {Path.GetFileName(localPath)}");
                                LoadConsoleDirectory(DirectoryPathConsole);
                            }
                            else
                            {
                                SetStatus("Unable to upload local file as it doesn't exist on your computer.");
                            }

                            break;
                        }
                    case "folder":
                        {
                            string localPath = TextBoxFileManagerLocalPath.Text + name + @"\";
                            string consolePath = TextBoxFileManagerConsolePath.Text + name;

                            SetStatus($"Uploading folder to {consolePath}...");
                            FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
                            SetStatus($"Successfully uploaded local folder: {localPath}");
                            LoadConsoleDirectory(DirectoryPathConsole);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to upload to console. Error: {ex.Message}", ex);
            }
        }

        public void DeleteLocalItem()
        {
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Type");
                    string name = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Name");

                    switch (name.Equals(".."))
                    {
                        case false:
                            {
                                string selectedItem = TextBoxFileManagerLocalPath.Text + @"\" + name;

                                switch (type)
                                {
                                    case "folder":
                                        SetStatus($"Deleting local folder: {selectedItem}");
                                        UserFolders.DeleteDirectory(selectedItem);
                                        SetStatus($"Successfully deleted local folder: {name}");
                                        break;
                                    case "file":
                                        {
                                            if (File.Exists(selectedItem))
                                            {
                                                SetStatus($"Deleting local file: {selectedItem}");
                                                File.Delete(selectedItem);
                                                SetStatus($"Successfully deleted local file: {name}");
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
                SetStatus($"Unable to delete item. Error: {ex.Message}", ex);
            }
        }

        private void RenameLocalFile()
        {
            switch (GridViewFileManagerLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string oldFileName = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Name");
                        string oldFilePath = TextBoxFileManagerLocalPath.Text + @"\" + oldFileName;

                        string newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName).RemoveInvalidChars();

                        string newFilePath = TextBoxFileManagerLocalPath.Text + @"\" + newFileName;

                        if (newFileName != null && !newFileName.Equals(oldFileName))
                        {
                            if (File.Exists(newFilePath))
                            {
                                SetStatus("A file with this name already exists.");
                            }
                            else
                            {
                                SetStatus($"Renaming file local to: {newFileName}");
                                FileSystem.RenameFile(oldFilePath, newFileName);
                                SetStatus($"Successfully renamed local file to: {newFileName}");
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
                        string oldFolderName = GridViewFileManagerLocalFiles.GetFocusedRowCellDisplayText("Name");
                        string oldFolderPath = TextBoxFileManagerLocalPath.Text + @"\" + oldFolderName;

                        string newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName).RemoveInvalidChars();

                        string newFolderPath = TextBoxFileManagerLocalPath.Text + @"\" + newFolderName;

                        if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                        {
                            if (Directory.Exists(newFolderPath))
                            {
                                SetStatus("A folder with this name already exists.");
                            }
                            else
                            {
                                SetStatus($"Renaming local folder to: {newFolderName}");
                                FileSystem.RenameDirectory(oldFolderPath, newFolderName);
                                SetStatus($"Successfully renamed local folder to: {newFolderName}");
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
            if (PlatformType == PlatformPrefix.PS3)
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
            new List<DataColumn>
            {
                new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                new() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                new() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                new() { Caption = "Last Modified", ColumnName = "Last Modified", DataType = typeof(string) }
            });

        /// <summary>
        /// Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath"> Console path to retrieve </param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                SetConsoleStatus($"Fetching directory listing of '{directoryPath}'...");

                DataTableConsoleFiles.Rows.Clear();

                DirectoryPathConsole = PlatformType == PlatformPrefix.PS3 ? directoryPath.Replace("//", "/") : directoryPath.Replace(@"\\", @"\");
                TextBoxFileManagerConsolePath.Text = DirectoryPathConsole;

                int secondIndexOfSlash = DirectoryPathConsole.TrimStart('/').IndexOfNth("/");
                int indexOfFirstColon = DirectoryPathConsole.IndexOfNth(":");
                string rootPath = PlatformType == PlatformPrefix.PS3 ? DirectoryPathConsole.Substring(1, secondIndexOfSlash) : DirectoryPathConsole.Substring(0, indexOfFirstColon);

                ComboBoxFileManagerConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxFileManagerConsoleDrives.SelectedItem = PlatformType == PlatformPrefix.PS3 ? rootPath.Replace("/", string.Empty) : rootPath.ToUpper().Replace(@"\", string.Empty);
                ComboBoxFileManagerConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                bool isRoot = PlatformType == PlatformPrefix.PS3 ? ComboBoxFileManagerConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace("/", "")) : ComboBoxFileManagerConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace(":", "").Replace(@"\", "").ToUpper());

                if (!isRoot)
                {
                    DataTableConsoleFiles.Rows.Add("folder",
                                                   ImageFolderUp,
                                                   "..",
                                                   "",
                                                   "");
                }

                if (PlatformType == PlatformPrefix.PS3)
                {
                    FtpClient.SetWorkingDirectory(DirectoryPathConsole);

                    List<FtpListItem> folders = new();
                    List<FtpListItem> files = new();

                    int totalBytes = 0;

                    foreach (FtpListItem listItem in FtpClient.GetListing(DirectoryPathConsole))
                    {
                        switch (listItem.Type)
                        {
                            case FtpFileSystemObjectType.Directory:
                                folders.Add(listItem);
                                break;

                            case FtpFileSystemObjectType.File:
                                files.Add(listItem);
                                break;

                            case FtpFileSystemObjectType.Link:
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
                                                                   ImageFolder,
                                                                   $"{listItem.Name} ({profileName})",
                                                                   "<PROFILE>",
                                                                   listItem.Modified);
                                    break;
                                }
                            case "/dev_hdd0/game/":
                                {
                                    string gameTitle = Settings.AutoDetectGameTitles
                                        ? $" ({FtpExtensions.GetParamTitle($"/dev_hdd0/game/{listItem.Name}/PARAM.SFO")})"
                                        : "";
                                    DataTableConsoleFiles.Rows.Add("folder",
                                                                   ImageFolder,
                                                                   $"{listItem.Name}{gameTitle}",
                                                                   "<UPDATE>",
                                                                   listItem.Modified);
                                    break;
                                }
                            default:
                                DataTableConsoleFiles.Rows.Add("folder",
                                                               ImageFolder,
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
                                                       Settings.UseFormattedFileSizes ? listItem.Size.Bytes().Humanize("#.##") : listItem.Size + " Bytes",
                                                       Settings.UseRelativeTimes ? listItem.Modified.Humanize() : listItem.Modified);

                        totalBytes += Convert.ToInt32(listItem.Size);
                    }

                    string statusFiles = files.Count > 0
                        ? $"{files.Count} {(files.Count == 1 ? "file" : "files")} {(files.Count > 0 && folders.Count > 0 ? "and" : "")} "
                        : $"{$"{(folders.Count == 0 ? "." : "")}"}";
                    string statusFolders = folders.Count > 0
                        ? $" {folders.Count} {(folders.Count == 1 ? "directory" : "directories")}."
                        : "";
                    string statusTotalBytes = totalBytes > 0
                        ? $" Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " bytes")}"
                        : "";

                    switch (files.Count)
                    {
                        case < 1 when folders.Count < 1:
                            SetConsoleStatus("Empty directory.");
                            break;
                        default:
                            SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                            break;
                    }
                }
                else if (PlatformType == PlatformPrefix.XBOX)
                {
                    List<IXboxFile> files = new();
                    List<IXboxFile> folders = new();

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
                                       ? $" ({Database.GamesXBOXTitleIds.GetTitleFromTitleId(folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""))})"
                                       : "";
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageFolder,
                                                           $"{folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", "")}{gameTitle}",
                                                           "<GAME>",
                                                           folder.ChangeTime);
                        }
                        else
                        {
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageFolder,
                                                           folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""),
                                                           "<DIRECTORY>",
                                                           folder.ChangeTime);
                        }
                    }

                    foreach (IXboxFile file in files)
                    {
                        DataTableConsoleFiles.Rows.Add("file",
                                                       ImageFile,
                                                       file.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""),
                                                       Settings.UseFormattedFileSizes ? Convert.ToInt64(file.Size).Bytes().Humanize("#.##") : file.Size + " Bytes",
                                                       file.ChangeTime);

                        totalBytes += Convert.ToInt64(file.Size);
                    }

                    SetConsoleStatus("Successfully fetched directory listing.");

                    string statusFiles = files.Count > 0
                        ? $"{files.Count} {(files.Count == 1 ? "file" : "files")}{(files.Count > 0 && folders.Count > 0 ? " and " : "")}"
                        : $"{$"{(folders.Count == 0 ? "." : "")}"}";
                    string statusFolders = folders.Count > 0
                        ? $"{folders.Count} {(folders.Count == 1 ? "directory" : "directories")}. "
                        : "";
                    string statusTotalBytes = totalBytes > 0
                        ? $"Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " bytes")}"
                        : "";

                    switch (files.Count)
                    {
                        case < 1 when folders.Count < 1:
                            SetConsoleStatus("Empty directory.");
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
                SetConsoleStatus($"Error fetching directory listing for path: {DirectoryPathConsole}", ex);
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Error fetching directory listing for path: {DirectoryPathConsole}", ex);
            }
        }

        private void GridViewConsoleFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewFileManagerConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Name");

                        ButtonFileManagerConsoleDownload.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleRename.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleAddToGames.Enabled = type == "file" && name.EndsWith(".xex");

                        break;
                    }

                default:
                    ButtonFileManagerConsoleDownload.Enabled = false;
                    ButtonFileManagerConsoleDelete.Enabled = false;
                    ButtonFileManagerConsoleRename.Enabled = false;
                    ButtonFileManagerConsoleAddToGames.Enabled = false;
                    break;
            }
        }

        private void GridViewConsoleFiles_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewFileManagerConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Name");

                        ButtonFileManagerConsoleDownload.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleRename.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonFileManagerConsoleAddToGames.Enabled = type == "file" && name.EndsWith(".xex");

                        break;
                    }

                default:
                    ButtonFileManagerConsoleDownload.Enabled = false;
                    ButtonFileManagerConsoleDelete.Enabled = false;
                    ButtonFileManagerConsoleRename.Enabled = false;
                    ButtonFileManagerConsoleAddToGames.Enabled = false;
                    break;
            }
        }

        private void GridViewConsoleFiles_DoubleClick(object sender, EventArgs e)
        {
            switch (GridViewFileManagerConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Name");

                        switch (name)
                        {
                            // Go to parent directory
                            case "..":
                                {

                                    string trimLastIndex;
                                    string parentDirectory;

                                    if (PlatformType == PlatformPrefix.PS3)
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
                                    if (PlatformType == PlatformPrefix.PS3)
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
            string type = GridViewFileManagerConsoleFiles.GetRowCellValue(GridViewFileManagerConsoleFiles.FocusedRowHandle, "Type").ToString();

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

        private void ButtonConsoleAddToGames_Click(object sender, EventArgs e)
        {
            string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Name");
            string fileName = name;

            if (XtraMessageBox.Show("Do you want to rename this file?\n\nNote: It will not affect being able to load the game.", "Rename File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", name);

                if (fileName.IsNullOrEmpty() | fileName.IsNullOrWhiteSpace())
                {
                    XtraMessageBox.Show("The file name can't be empty.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (Settings.GameFilesXBOX.Any(x => x.Name.EqualsIgnoreCase(fileName)))
            {
                XtraMessageBox.Show("You already have a file with this name in your games.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Settings.GameFilesXBOX.Add(new()
            {
                Name = fileName,
                Value = DirectoryPathConsole + name
            });
        }

        public void DownloadFromConsole()
        {
            try
            {
                string type = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Type");
                string name = GridViewFileManagerConsoleFiles.GetFocusedRowCellDisplayText("Name");

                string consoleFile = DirectoryPathConsole + name;
                string localFile = DirectoryPathLocal + name;

                switch (type)
                {
                    case "file":
                        {
                            SetStatus($"Downloading console file: {Path.GetFileName(localFile)}");

                            if (PlatformType == PlatformPrefix.PS3)
                            {
                                if (File.Exists(localFile))
                                {
                                    File.Delete(localFile);
                                }

                                FtpClient.DownloadFile(localFile, consoleFile, FtpLocalExists.Overwrite);
                            }
                            else if (PlatformType == PlatformPrefix.XBOX)
                            {
                                if (File.Exists(localFile))
                                {
                                    File.Delete(localFile);
                                }

                                XboxConsole.ReceiveFile(localFile, consoleFile);
                            }

                            SetStatus($"Successfully downloaded console file: {Path.GetFileName(localFile)}");
                            LoadLocalDirectory(DirectoryPathLocal);

                            break;
                        }
                    case "folder":
                        {
                            if (PlatformType == PlatformPrefix.PS3)
                            {
                                string consolePath = DirectoryPathConsole + name + "/";
                                string localPath = DirectoryPathLocal + name;

                                if (Directory.Exists(localPath))
                                {
                                    UserFolders.DeleteDirectory(localPath);
                                }

                                SetStatus($"Downloading console folder: {consolePath}");
                                FtpExtensions.DownloadDirectory(consolePath, localPath);
                                LoadLocalDirectory(DirectoryPathLocal);
                                SetStatus($"Successfully downloaded console folder to: {localPath}");
                            }
                            else if (PlatformType == PlatformPrefix.XBOX)
                            {

                            }

                            break;
                        }
                }

                LoadConsoleDirectory(DirectoryPathConsole);
            }
            catch (Exception ex)
            {
                SetStatus($"Error downloading console file. {ex.Message}", ex);
            }
        }

        public void DeleteConsoleItem()
        {
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewFileManagerConsoleFiles.GetRowCellDisplayText(GridViewFileManagerConsoleFiles.FocusedRowHandle, "Type");
                    string name = GridViewFileManagerConsoleFiles.GetRowCellDisplayText(GridViewFileManagerConsoleFiles.FocusedRowHandle, "Name");

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

                                SetStatus($"Deleting console folder: {itemPath}");

                                switch (PlatformType)
                                {
                                    case PlatformPrefix.PS3:
                                        FtpExtensions.DeleteDirectory(itemPath);
                                        break;
                                    case PlatformPrefix.XBOX:
                                        XboxConsole.RemoveDirectory(itemPath);
                                        break;
                                }

                                SetStatus("Successfully deleted folder.");
                                break;
                            }
                        case "file":
                            SetStatus($"Deleting console file: {itemPath}");

                            switch (PlatformType)
                            {
                                case PlatformPrefix.PS3:
                                    FtpExtensions.DeleteFile(itemPath);
                                    break;
                                case PlatformPrefix.XBOX:
                                    XboxConsole.DeleteFile(itemPath);
                                    break;
                            }

                            SetStatus("Successfully deleted console file.");
                            break;
                    }

                    GridViewFileManagerConsoleFiles.DeleteRow(GridViewFileManagerConsoleFiles.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to delete console item. Error: {ex.Message}", ex);
            }
        }

        private void RenameConsoleFile()
        {
            try
            {
                string oldFileName = GridViewFileManagerConsoleFiles.GetRowCellDisplayText(GridViewFileManagerConsoleFiles.FocusedRowHandle, "Name");
                string oldFilePath = TextBoxFileManagerConsolePath.Text + oldFileName;

                string newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName).RemoveInvalidChars();

                string newConsoleFilePath = TextBoxFileManagerConsolePath.Text + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    SetStatus($"Renaming console file to: {newFileName}");

                    switch (PlatformType)
                    {
                        case PlatformPrefix.PS3:
                            if (FtpClient.FileExists(newConsoleFilePath))
                            {
                                SetStatus("A file with this name already exists.");
                                return;
                            }

                            FtpExtensions.RenameFileOrFolder(oldFilePath, newConsoleFilePath);
                            break;
                        case PlatformPrefix.XBOX:
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
                                SetStatus("A file with this name already exists.");
                                return;
                            }

                            XboxConsole.RenameFile(oldFilePath, newConsoleFilePath);
                            break;
                    }

                    SetStatus($"Successfully renamed console file to: {newFileName}");
                    LoadConsoleDirectory(DirectoryPathConsole);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to rename console file. Error: {ex.Message}", ex);
            }
        }

        private void RenameConsoleFolder()
        {
            try
            {
                string oldFolderName = GridViewFileManagerConsoleFiles.GetRowCellDisplayText(GridViewFileManagerConsoleFiles.FocusedRowHandle, "Name");
                string oldFileName = TextBoxFileManagerConsolePath.Text + oldFolderName;

                string newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName).RemoveInvalidChars();

                string newFolderPath = TextBoxFileManagerConsolePath.Text + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpClient.DirectoryExists(newFolderPath))
                    {
                        SetStatus("A folder with this name already exists.");
                    }
                    else
                    {
                        SetStatus($"Renaming console folder: {oldFileName} to: {newFolderName}");

                        switch (PlatformType)
                        {
                            case PlatformPrefix.PS3:
                                FtpExtensions.RenameFileOrFolder(oldFileName, newFolderPath);
                                break;
                            case PlatformPrefix.XBOX:
                                XboxConsole.RenameFile(oldFileName, newFolderName);
                                break;
                        }

                        SetStatus($"Successfully renamed console folder to: {newFolderName}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to rename folder. Error: {ex.Message}", ex);
            }
        }

        public void CreateConsoleFolder()
        {
            try
            {
                string folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ");

                if (folderName != null)
                {
                    string folderPath = DirectoryPathConsole + "/" + folderName;

                    if (FtpClient.DirectoryExists(folderPath))
                    {
                        XtraMessageBox.Show("A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetStatus($"Creating console folder: {folderName}");

                        switch (PlatformType)
                        {
                            case PlatformPrefix.PS3:
                                FtpClient.CreateDirectory(folderPath, true);
                                break;
                            case PlatformPrefix.XBOX:
                                XboxConsole.MakeDirectory(folderPath.TrimStart('/').Replace("/", @"\"));
                                break;
                        }

                        SetStatus($"Successfully created console folder: {folderName}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (FtpException ex)
            {
                SetStatus($"Unable to create a new folder on your console. Error: {ex.Message}", ex);
                XtraMessageBox.Show($"Unable to create a new folder on your console. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to create a new folder on your console. Error: {ex.Message}", ex);
                XtraMessageBox.Show($"Unable to create a new folder on your console. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            { "English", "ModioX.Languages.en" },
            { "Español", "ModioX.Languages.es" },
            //{ "Português", "ModioX.Languages.pt" },
            //{ "Português (Brasil)", "ModioX.Languages.pt-BR" }
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
                string languageResource = GetLanguageResource(languageName);

                if (languageResource.IsNullOrEmpty())
                {
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("Language not supported, can help"), ResourceLanguage.GetString("Language Not Supported"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                XtraMessageBox.Show(this, ResourceLanguage.GetString("Language not supported, can help"), ResourceLanguage.GetString("Language Not Supported"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ComboBoxSettingsLanguages.SelectedItem = CurrentLanguage;
                return;
            }

            // Menu Bar
            MenuButtonConnect.Caption = ResourceLanguage.GetString("CONNECT");
            MenuButtonTools.Caption = ResourceLanguage.GetString("TOOLS");
            MenuButtonOptions.Caption = ResourceLanguage.GetString("OPTIONS");
            MenuButtonHelp.Caption = ResourceLanguage.GetString("HELP");
            MenuItemConnectToPS3.Caption = ResourceLanguage.GetString("Connect to console") + "...";
            MenuItemConnectToXBOX.Caption = ResourceLanguage.GetString("Connect to console") + "...";

            // Navigation Menu
            NavigationItemDashboard.Text = ResourceLanguage.GetString("DASHBOARD");
            NavigationItemInstalledMods.Text = ResourceLanguage.GetString("INSTALLED MODS");
            NavigationItemDownloads.Text = ResourceLanguage.GetString("DOWNLOADS");
            NavigationItemFileManager.Text = ResourceLanguage.GetString("FILE MANAGER");
            NavigationItemSettings.Text = ResourceLanguage.GetString("SETTINGS");
            NavigationItemGameMods.Text = ResourceLanguage.GetString("GAME MODS");
            NavigationItemHomebrew.Text = ResourceLanguage.GetString("HOMEBREW");
            NavigationItemResources.Text = ResourceLanguage.GetString("RESOURCES");
            NavigationItemPackages.Text = ResourceLanguage.GetString("PACKAGES");
            NavigationItemPlugins.Text = ResourceLanguage.GetString("PLUGINS");
            NavigationItemGameSaves.Text = ResourceLanguage.GetString("GAME SAVES");

            // Dashboard
            LabelHeaderSetup.Text = ResourceLanguage.GetString("LET'S GET YOU SETUP");
            LabelHeaderTools.Text = ResourceLanguage.GetString("TOOLS");
            LabelHeaderAnnouncements.Text = ResourceLanguage.GetString("ANNOUNCEMENTS");
            LabelHeaderLatestNews.Text = ResourceLanguage.GetString("LATEST NEWS");
            LabelHeaderChangeLog.Text = ResourceLanguage.GetString("CHANGE LOG");
            LoadStatistics();
            LoadNewsFeed();
            LoadAnnouncements();
            NoAnnouncementsItem.LoadText();
            TileItemIntroductionDetails.Text = ResourceLanguage.GetString("Introduction Details");
            TileItemAddNewConsole.Text = ResourceLanguage.GetString("Add New Console Profile");
            TileItemScanForXboxConsoles.Text = ResourceLanguage.GetString("Scan For Xbox Consoles");
            TileItemEditConsoleProfiles.Text = ResourceLanguage.GetString("Edit Console Profiles");
            TileItemStartupLibrary.Text = ResourceLanguage.GetString("Startup Library");
            TileItemSetDownloadsLocation.Text = ResourceLanguage.GetString("Set Downloads Location");

            //TileItemToolsGameBackupFiles.Text = ResourceLanguage.GetString("");
        }

        private void ComboBoxSettingsLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSettingsLanguages.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                ChangeLanguage(ComboBoxSettingsLanguages.SelectedItem as string);
            }
        }

        private void LoadSettings()
        {
            /* Appearance */

            // Startup Database
            RadioGroupSettingsStartupLibrary.SelectedIndex = Settings.StartupLibrary switch
            {
                PlatformPrefix.PS3 => 0,
                PlatformPrefix.XBOX => 1,
                _ => 0
            };

            // Customization
            ToggleSwitchSettingsUseFormattedFileSizes.IsOn = Settings.UseFormattedFileSizes;
            ToggleSwitchSettingsUseRelativeTimes.IsOn = Settings.UseRelativeTimes;

            // Advanced

            ToggleSwitchSettingsEnableHardwareAcceleration.IsOn = Settings.EnableHardwareAcceleration;

            // Automation
            ToggleSwitchSettingsInstallModsToUsbDevice.IsOn = Settings.InstallModsToUsbDevice;
            ToggleSwitchSettingsInstallHomebrewToUsbDevice.IsOn = Settings.InstallHomebrewToUsbDevice;
            ToggleSwitchSettingsInstallResourcesToUsbDevice.IsOn = Settings.InstallResourcesToUsbDevice;
            ToggleSwitchSettingsInstallGameSavesToUsbDevice.IsOn = Settings.InstallGameSavesToUsbDevice;
            ToggleSwitchSettingsShowGamesFromExternalDevices.IsOn = Settings.ShowGamesFromExternalDevices;
            ToggleSwitchSettingsAutoDetectGameRegions.IsOn = Settings.AutoDetectGameRegions;
            ToggleSwitchSettingsAutoDetectGameTitles.IsOn = Settings.AutoDetectGameTitles;
            ToggleSwitchSettingsRememberGameRegions.IsOn = Settings.RememberGameRegions;
            ToggleSwitchSettingsAutoLoadDirectoryListings.IsOn = Settings.AutoLoadDirectoryListings;
            ToggleSwitchSettingsRememberLocalPath.IsOn = Settings.RememberLocalPath;
            ToggleSwitchSettingsRememberConsolePath.IsOn = Settings.RememberConsolePath;


            /* Tools */

            // Packages File Path
            TextBoxSettingsPackagesInstallPath.Text = Settings.PackagesInstallPath;

            // Launch.ini File Path
            TextBoxSettingsLaunchIniFilePath.Text = Settings.LaunchIniFilePath;


            /* Download */

            // Downloads Folder
            TextBoxSettingsDownloadsFolder.Text = Settings.DownloadsLocation;
            LabelSettingsDownloadLocation.Text = Settings.DownloadsLocation.Replace("{USERDATA}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));


            /* Chat Room */

            // Username
            TextBoxSettingsUserName.Text = Settings.ChatUserName;

            // Notifications
            switch (Settings.ChatNotificationType)
            {
                case ChatNotificationType.AllMessages:
                    RadioGroupSettingsChatRoom.SelectedIndex = 0;
                    break;
                case ChatNotificationType.Mentioned:
                    RadioGroupSettingsChatRoom.SelectedIndex = 1;
                    break;
                case ChatNotificationType.None:
                    RadioGroupSettingsChatRoom.SelectedIndex = 2;
                    break;
            }

            // Options
            ToggleSwitchSettingsBlockPrivateMessages.IsOn = Settings.ChatBlockPrivateMessages;
            ToggleSwitchSettingsMuteSounds.IsOn = Settings.ChatMuteSounds;
            ToggleSwitchSettingsHideUnreadMessagesCount.IsOn = Settings.ChatHideUnreadCount;
        }

        /* Interface */

        // Startup Library

        private void RadioSettingsStartupLibrary_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.StartupLibrary = RadioGroupSettingsStartupLibrary.SelectedIndex == 0 ? PlatformPrefix.PS3 : PlatformPrefix.XBOX;

            if (Settings.StartupLibrary != PlatformType)
            {
                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("You must restart the application for this change to take effect. Would you like to restart now?"), ResourceLanguage.GetString("Restart Required"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        // Customisation

        private void ToggleSwitchSettingsUseFormattedFileSizes_Toggled(object sender, EventArgs e)
        {
            Settings.UseFormattedFileSizes = ToggleSwitchSettingsUseFormattedFileSizes.IsOn;
        }

        private void ToggleSwitchSettingsUseRelativeTimes_Toggled(object sender, EventArgs e)
        {
            Settings.UseRelativeTimes = ToggleSwitchSettingsUseRelativeTimes.IsOn;
        }

        // Advanced

        private void ToggleSwitchSettingsEnableDirectXHardwareAcceleration_Toggled(object sender, EventArgs e)
        {
            if (Settings.EnableHardwareAcceleration != ToggleSwitchSettingsEnableHardwareAcceleration.IsOn)
            {
                Settings.EnableHardwareAcceleration = ToggleSwitchSettingsEnableHardwareAcceleration.IsOn;

                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("You must restart the application for this change to take effect. Would you like to restart now?"), ResourceLanguage.GetString("Restart Required"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        // Automation

        private void ToggleSwitchSettingsInstallModsToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallModsToUsbDevice = ToggleSwitchSettingsInstallModsToUsbDevice.IsOn;
        }

        private void ToggleSwitchSettingsInstallHomebrewToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallHomebrewToUsbDevice = ToggleSwitchSettingsInstallHomebrewToUsbDevice.IsOn;
        }

        private void ToggleSwitchSettingsInstallResourcesToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallResourcesToUsbDevice = ToggleSwitchSettingsInstallResourcesToUsbDevice.IsOn;
        }

        private void ToggleSwitchSettingsInstallGameSavesToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallGameSavesToUsbDevice = ToggleSwitchSettingsInstallGameSavesToUsbDevice.IsOn;
        }

        private void ToggleSwitchSettingsShowGamesFromExternalDevices_Toggled(object sender, EventArgs e)
        {
            Settings.ShowGamesFromExternalDevices = ToggleSwitchSettingsShowGamesFromExternalDevices.IsOn;
        }

        private void ToggleSwitchSettingsAutoDetectGameTitles_Toggled(object sender, EventArgs e)
        {
            Settings.AutoDetectGameTitles = ToggleSwitchSettingsAutoDetectGameTitles.IsOn;
        }

        private void ToggleSwitchSettingsRememberGameRegions_Toggled(object sender, EventArgs e)
        {
            Settings.RememberGameRegions = ToggleSwitchSettingsRememberGameRegions.IsOn;
        }

        private void ToggleSwitchSettingsAutoLoadFileManagerListings_Toggled(object sender, EventArgs e)
        {
            Settings.AutoLoadDirectoryListings = ToggleSwitchSettingsAutoLoadDirectoryListings.IsOn;
        }

        private void ToggleSwitchSettingsRememberConsolePath_Toggled(object sender, EventArgs e)
        {
            Settings.RememberConsolePath = ToggleSwitchSettingsRememberConsolePath.IsOn;
        }

        private void ToggleSwitchSettingsRememberLocalPath_Toggled(object sender, EventArgs e)
        {
            Settings.RememberLocalPath = ToggleSwitchSettingsRememberLocalPath.IsOn;
        }

        private void ToggleSwitchSettingsAutoDetectGameRegions_Toggled(object sender, EventArgs e)
        {
            Settings.AutoDetectGameRegions = ToggleSwitchSettingsAutoDetectGameRegions.IsOn;
        }

        /* Options */

        private void ToggleSwitchSettingsBlockPrivateMessages_Toggled(object sender, EventArgs e)
        {
            Settings.ChatBlockPrivateMessages = ToggleSwitchSettingsBlockPrivateMessages.IsOn;
        }

        private void ToggleSwitchSettingsMuteSounds_Toggled(object sender, EventArgs e)
        {
            Settings.ChatMuteSounds = ToggleSwitchSettingsMuteSounds.IsOn;
        }

        private void ToggleSwitchSettingsHideUnreadMessagesCount_Toggled(object sender, EventArgs e)
        {
            Settings.ChatHideUnreadCount = ToggleSwitchSettingsHideUnreadMessagesCount.IsOn;
        }

        // Tools

        /* PlayStation 3 */

        private void TextBoxSettingsPackagesFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSettingsPackagesInstallPath.Text.IsNullOrEmpty() | TextBoxSettingsPackagesInstallPath.Text.IsNullOrWhiteSpace())
                {
                    TextBoxSettingsPackagesInstallPath.Text = Settings.PackagesInstallPath;
                    return;
                }

                Settings.PackagesInstallPath = TextBoxSettingsPackagesInstallPath.Text;
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
            string downloadsLocation = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("Downloads Location"));

            if (!downloadsLocation.IsNullOrEmpty())
            {
                if (!Directory.Exists(downloadsLocation))
                {
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("Directory does not exist"), ResourceLanguage.GetString("Directory can't find"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Settings.DownloadsLocation = downloadsLocation + @"\";
                TextBoxSettingsDownloadsFolder.Text = Settings.DownloadsLocation;
                LabelSettingsDownloadLocation.Text = Settings.DownloadsLocation;
            }
        }

        private void LabelSettingsDownloadLocation_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Settings.DownloadsLocation))
            {
                Process.Start(Settings.DownloadsLocation);
            }
        }

        // Chat Room

        /* Username */

        private void TextBoxSettingsUserName_EditValueChanged(object sender, EventArgs e)
        {
            Settings.ChatUserName = TextBoxSettingsUserName.Text;
        }

        /* Notifications */

        private void RadioGroupSettingsChatRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RadioGroupSettingsChatRoom.SelectedIndex)
            {
                case 0:
                    Settings.ChatNotificationType = ChatNotificationType.AllMessages;
                    break;
                case 1:
                    Settings.ChatNotificationType = ChatNotificationType.Mentioned;
                    break;
                case 2:
                    Settings.ChatNotificationType = ChatNotificationType.None;
                    break;
            }
        }

        #endregion

        #region Game Mods Page

        private void TileItemGameModsShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterGameModsShowFavorites)
            {
                FilterGameModsShowFavorites = false;
                TileItemGameModsShowFavorites.Text = ResourceLanguage.GetString("Show Favorites");
                SearchGameMods();
            }
            else
            {
                FilterGameModsShowFavorites = true;
                TileItemGameModsShowFavorites.Text = ResourceLanguage.GetString("Hide Favorites");
                SearchGameMods();
            }
        }

        private void TileItemGameModsSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameModsSortOption, new List<string> { "Category", "Name", "System Type", "Mod Type", "Region", "Version", "Creator" }, FilterGameModsSortOrder);

            if (sortOptions != null)
            {
                FilterGameModsSortOption = sortOptions.SortOption;
                FilterGameModsSortOrder = sortOptions.SortOrder;
                SearchGameMods();
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private bool FilterGameModsShowFavorites { get; set; } = false;

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterGameModsSortOption { get; set; } = "Category";

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterGameModsSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterGameModsCategoryId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterGameModsName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the system type for filtering mods.
        /// </summary>
        private string FilterGameModsSystemType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the type for filtering mods.
        /// </summary>
        private string FilterGameModsType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the region for filtering mods.
        /// </summary>
        private string FilterGameModsRegion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering mods.
        /// </summary>
        private string FilterGameModsVersion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the author for filtering mods.
        /// </summary>
        private string FilterGameModsCreator { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the status for filtering mods.
        /// </summary>
        private string FilterGameModsStatus { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the selected mods info selected by the user.
        /// </summary>
        private static ModItemData SelectedGameModItem { get; set; }

        private void ComboBoxGameModsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameModsFilterCategory.SelectedIndex == 0 | ComboBoxGameModsFilterCategory.SelectedIndex == -1)
            {
                FilterGameModsCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxGameModsFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterGameModsCategoryId = category == null ? Settings.CustomLists.Find(x => x.Platform == PlatformType && x.Name.Equals(selectedCategory)).Name : category.Id;
            }

            SearchGameMods();
        }

        private void TextBoxFilterGameModsName_TextChanged(object sender, EventArgs e)
        {
            FilterGameModsName = TextBoxGameModsFilterName.Text;

            SearchGameMods();
        }

        private void ComboBoxGameModsFilterSystemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsSystemType = ComboBoxGameModsFilterSystemType.SelectedIndex == 0 | ComboBoxGameModsFilterSystemType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsFilterSystemType.SelectedItem.ToString();

            SearchGameMods();
        }

        private void ComboBoxGameModsFilterModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsType = ComboBoxGameModsFilterModType.SelectedIndex == 0 | ComboBoxGameModsFilterModType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsFilterModType.SelectedItem as string;

            SearchGameMods();
        }

        private void ComboBoxGameModsFilterRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsRegion = ComboBoxGameModsFilterRegion.SelectedIndex == 0 | ComboBoxGameModsFilterRegion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsFilterRegion.SelectedItem as string;

            SearchGameMods();
        }

        private void ComboBoxGameModsFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsVersion = ComboBoxGameModsFilterVersion.SelectedIndex == 0 | ComboBoxGameModsFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsFilterVersion.SelectedItem as string;

            SearchGameMods();
        }

        private void ComboBoxGameModsFilterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsCreator = ComboBoxGameModsFilterCreator.SelectedIndex == 0 | ComboBoxGameModsFilterCreator.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsFilterCreator.SelectedItem as string;

            SearchGameMods();
        }

        private void ComboBoxGameModsFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameModsStatus = ComboBoxGameModsFilterStatus.SelectedIndex == 0 | ComboBoxGameModsFilterStatus.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameModsFilterStatus.SelectedItem as string;

            SearchGameMods();
        }

        private void LoadGameModsCategories()
        {
            ComboBoxGameModsFilterCategory.Properties.Items.Clear();

            ComboBoxGameModsFilterCategory.SelectedIndexChanged -= ComboBoxGameModsFilterCategory_SelectedIndexChanged;
            ComboBoxGameModsFilterCategory.SelectedIndex = -1;
            ComboBoxGameModsFilterCategory.SelectedIndexChanged += ComboBoxGameModsFilterCategory_SelectedIndexChanged;

            ComboBoxGameModsFilterCategory.Properties.Items.Add("<All Categories>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxGameModsFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableGameMods { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("System Type", typeof(string)),
                new("Mod Type", typeof(string)),
                new("Region", typeof(string)),
                new("Version", typeof(string)),
                new("Creator", typeof(string)),
                new("Status", typeof(string))
            });

        /// <summary>
        /// Search for mods and display the results.
        /// </summary>
        private void SearchGameMods()
        {
            GridViewGameMods.ShowLoadingPanel();

            Category category;

            if (FilterGameModsCategoryId.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = new string[] { },
                    Title = "<All Categories>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterGameModsCategoryId);
            }

            bool isCustomList = Settings.CustomLists.Any(x => x.Platform == PlatformType && x.Name.Equals(FilterGameModsCategoryId));

            ComboBoxGameModsFilterModType.Properties.Items.Clear();
            ComboBoxGameModsFilterModType.Properties.Items.Add("<All>");

            ComboBoxGameModsFilterRegion.Properties.Items.Clear();
            ComboBoxGameModsFilterRegion.Properties.Items.Add("<All>");

            ComboBoxGameModsFilterVersion.Properties.Items.Clear();
            ComboBoxGameModsFilterVersion.Properties.Items.Add("<All>");

            ComboBoxGameModsFilterCreator.Properties.Items.Clear();
            ComboBoxGameModsFilterCreator.Properties.Items.Add("<All>");

            switch (FilterGameModsCategoryId)
            {
                case "fvrt":
                    ComboBoxGameModsFilterModType.Properties.Items.AddRange(Settings.GetModTypesForMods(Database.ModsPS3, Settings.FavoriteIds.Where(x => x.Platform.Equals(PlatformType)).FirstOrDefault().Ids).ToArray());
                    break;
                default:
                    {
                        switch (isCustomList)
                        {
                            case true:
                                ComboBoxGameModsFilterModType.Properties.Items.AddRange(Settings.GetModTypesForMods(Database.ModsPS3, Settings.GetCustomListByName(FilterGameModsCategoryId, PlatformType).ModIds).ToArray());
                                break;
                            default:
                                {
                                    foreach (string modType in Database.ModsPS3.AllModTypesForCategoryId(category.Id))
                                    {
                                        ComboBoxGameModsFilterModType.Properties.Items.Add(modType);
                                    }

                                    break;
                                }
                        }

                        break;
                    }
            }

            switch (FilterGameModsCategoryId)
            {
                case "fvrt":
                    ComboBoxGameModsFilterRegion.Properties.Items.AddRange(Settings.GetRegionsForMods(Database.ModsPS3, Settings.FavoriteIds.Where(x => x.Platform.Equals(PlatformType)).FirstOrDefault().Ids).ToArray());
                    break;
                default:
                    {
                        switch (isCustomList)
                        {
                            case true:
                                ComboBoxGameModsFilterRegion.Properties.Items.AddRange(Settings.GetRegionsForMods(Database.ModsPS3, Settings.GetCustomListByName(FilterGameModsCategoryId, PlatformType).ModIds).ToArray());
                                break;
                            default:
                                {
                                    foreach (string categoryRegion in category.Regions)
                                    {
                                        ComboBoxGameModsFilterRegion.Properties.Items.Add(categoryRegion);
                                    }

                                    break;
                                }
                        }

                        break;
                    }
            }

            DataTableGameMods.Rows.Clear();

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.ModsPS3.GetModItems(Database.CategoriesData, FilterGameModsCategoryId, FilterGameModsName, FilterGameModsSystemType, FilterGameModsType, FilterGameModsRegion, FilterGameModsVersion, FilterGameModsCreator, FilterGameModsShowFavorites).OrderBy(x => x.Name))
                {
                    bool isInstalled = Settings.GetInstalledMods(modItemData.GetPlatform(), modItemData.CategoryId, modItemData.Id) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterGameModsStatus == "Downloaded" && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterGameModsStatus == "Installed" && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterGameModsStatus == "Not Installed" && isInstalled)
                    {
                        continue;
                    }

                    DataTableGameMods.Rows.Add(modItemData.Id,
                                           modItemData.GetCategoryName(Database.CategoriesData),
                                           modItemData.Name,
                                           modItemData.FirmwareType,
                                           modItemData.ModType,
                                           modItemData.Region,
                                           string.Join(" & ", modItemData.Versions),
                                           modItemData.CreatedBy,
                                           isDownloadNotInstalled ? ResourceLanguage.GetString("Downloaded") : isInstalled ? ResourceLanguage.GetString("Installed") : ResourceLanguage.GetString("Not Installed"));

                    foreach (string modType in from string modType in modItemData.ModTypes
                                               where !ComboBoxGameModsFilterModType.Properties.Items.Contains(modType)
                                               where !ignoreValues.Exists(x => x.EqualsIgnoreCase(modType))
                                               select modType)
                    {
                        ComboBoxGameModsFilterModType.Properties.Items.Add(modType);
                    }

                    foreach (string region in from string region in modItemData.Regions
                                              where !ComboBoxGameModsFilterRegion.Properties.Items.Contains(region)
                                              where !ignoreValues.Exists(x => x.EqualsIgnoreCase(region))
                                              select region)
                    {
                        ComboBoxGameModsFilterRegion.Properties.Items.Add(region);
                    }

                    foreach (string version in from string version in modItemData.Versions
                                               where !ComboBoxGameModsFilterVersion.Properties.Items.Contains(version)
                                               where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                               select version)
                    {
                        ComboBoxGameModsFilterVersion.Properties.Items.Add(version);
                    }

                    foreach (string author in from string author in modItemData.Creators
                                              where !ComboBoxGameModsFilterCreator.Properties.Items.Contains(author)
                                              where !ignoreValues.Exists(x => x.EqualsIgnoreCase(author))
                                              select author)
                    {
                        ComboBoxGameModsFilterCreator.Properties.Items.Add(author);
                    }
                }
            }));

            GridControlGameMods.DataSource = DataTableGameMods;

            GridViewGameMods.Columns[0].Visible = false;

            GridViewGameMods.Columns[1].MinWidth = 232;
            GridViewGameMods.Columns[1].MaxWidth = 232;

            //GridViewGameMods.Columns[2].MinWidth = 30;

            GridViewGameMods.Columns[3].MinWidth = 88;
            GridViewGameMods.Columns[3].MaxWidth = 88;

            GridViewGameMods.Columns[4].MinWidth = 96;
            GridViewGameMods.Columns[4].MaxWidth = 96;

            GridViewGameMods.Columns[5].MinWidth = 90;
            GridViewGameMods.Columns[5].MaxWidth = 90;

            GridViewGameMods.Columns[6].MinWidth = 70;
            GridViewGameMods.Columns[6].MaxWidth = 70;

            GridViewGameMods.Columns[7].MinWidth = 132;
            GridViewGameMods.Columns[7].MaxWidth = 132;

            GridViewGameMods.Columns[8].MinWidth = 94;
            GridViewGameMods.Columns[8].MaxWidth = 94;

            GridViewGameMods.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewGameMods.Columns[FilterGameModsSortOption], FilterGameModsSortOrder),
            });

            ComboBoxGameModsFilterSystemType.SelectedIndexChanged -= ComboBoxGameModsFilterSystemType_SelectedIndexChanged;
            ComboBoxGameModsFilterSystemType.SelectedIndex = string.IsNullOrEmpty(FilterGameModsSystemType) ? -1 : ComboBoxGameModsFilterSystemType.Properties.Items.IndexOf(FilterGameModsSystemType);
            ComboBoxGameModsFilterSystemType.SelectedIndexChanged += ComboBoxGameModsFilterSystemType_SelectedIndexChanged;

            ComboBoxGameModsFilterModType.SelectedIndexChanged -= ComboBoxGameModsFilterModType_SelectedIndexChanged;
            ComboBoxGameModsFilterModType.SelectedIndex = string.IsNullOrEmpty(FilterGameModsType) ? -1 : ComboBoxGameModsFilterModType.Properties.Items.IndexOf(FilterGameModsType);
            ComboBoxGameModsFilterModType.SelectedIndexChanged += ComboBoxGameModsFilterModType_SelectedIndexChanged;

            ComboBoxGameModsFilterRegion.SelectedIndexChanged -= ComboBoxGameModsFilterRegion_SelectedIndexChanged;
            ComboBoxGameModsFilterRegion.SelectedIndex = string.IsNullOrEmpty(FilterGameModsRegion) ? -1 : ComboBoxGameModsFilterRegion.Properties.Items.IndexOf(FilterGameModsRegion);
            ComboBoxGameModsFilterRegion.SelectedIndexChanged += ComboBoxGameModsFilterRegion_SelectedIndexChanged;

            ComboBoxGameModsFilterVersion.SelectedIndexChanged -= ComboBoxGameModsFilterVersion_SelectedIndexChanged;
            ComboBoxGameModsFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterGameModsVersion) ? -1 : ComboBoxGameModsFilterVersion.Properties.Items.IndexOf(FilterGameModsVersion);
            ComboBoxGameModsFilterVersion.SelectedIndexChanged += ComboBoxGameModsFilterVersion_SelectedIndexChanged;

            ComboBoxGameModsFilterCreator.SelectedIndexChanged -= ComboBoxGameModsFilterCreator_SelectedIndexChanged;
            ComboBoxGameModsFilterCreator.SelectedIndex = string.IsNullOrEmpty(FilterGameModsCreator) ? -1 : ComboBoxGameModsFilterCreator.Properties.Items.IndexOf(FilterGameModsCreator);
            ComboBoxGameModsFilterCreator.SelectedIndexChanged += ComboBoxGameModsFilterCreator_SelectedIndexChanged;

            ComboBoxGameModsFilterStatus.SelectedIndexChanged -= ComboBoxGameModsFilterStatus_SelectedIndexChanged;
            ComboBoxGameModsFilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterGameModsStatus) ? -1 : ComboBoxGameModsFilterStatus.Properties.Items.IndexOf(FilterGameModsStatus);
            ComboBoxGameModsFilterStatus.SelectedIndexChanged += ComboBoxGameModsFilterStatus_SelectedIndexChanged;

            GridViewGameMods.HideLoadingPanel();
        }

        private void GridViewGameMods_RowClick(object sender, RowClickEventArgs e)
        {
            int modId = (int)GridViewGameMods.GetRowCellValue(e.RowHandle, GridViewGameMods.Columns[0]);
            ShowGameModDetails(modId);
        }

        private void GridViewGameMods_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            switch (e.HitInfo.InRow)
            {
                case true:
                    {
                        GridView view = sender as GridView;
                        view.FocusedRowHandle = e.HitInfo.RowHandle;

                        MenuGameMods.ShowPopup(Cursor.Position);
                        break;
                    }
            }
        }

        private void MenuGameMods_BeforePopup(object sender, CancelEventArgs e)
        {
            ModItemData modItem = SelectedGameModItem;

            if (modItem != null)
            {
                InstalledModInfo installedMod = Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);

                bool isInstalled = installedMod != null && installedMod.ModId.Equals(modItem.Id);

                MenuItemGameModsInstallFiles.Caption = isInstalled ? $"{ResourceLanguage.GetString("Uninstall Files")}..." : $"{ResourceLanguage.GetString("Install Files")}...";

                MenuItemGameModsInstallFiles.Enabled = Settings.InstallModsToUsbDevice | IsConsoleConnected;
            }
        }

        private void MenuItemGameModsInstallFiles_ItemClick(object sender, EventArgs e)
        {
            ModItemData modItem = SelectedGameModItem;
            InstalledModInfo installedModInfo = Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);

            if (installedModInfo != null)
            {
                ShowTransferModsDialog(Window, TransferType.UninstallMods, modItem, installedModInfo.DownloadFiles.Region);
            }
            else
            {
                ShowTransferModsDialog(Window, TransferType.InstallMods, modItem);
            }
        }

        #endregion

        #region Homebrew Page

        private void TileItemHomebrewShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterHomebrewShowFavorites)
            {
                FilterHomebrewShowFavorites = false;
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("Show Favorites");
                SearchHomebrew();
            }
            else
            {
                FilterHomebrewShowFavorites = true;
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("Hide Favorites");
                SearchHomebrew();
            }
        }

        private void TileItemHomebrewSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterHomebrewSortOption, new List<string> { "Category", "Name", "System Type", "Version", "Creator" }, FilterHomebrewSortOrder);

            if (sortOptions != null)
            {
                FilterHomebrewSortOption = sortOptions.SortOption;
                FilterHomebrewSortOrder = sortOptions.SortOrder;
                SearchHomebrew();
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterHomebrewSortOption { get; set; } = "Category";

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
        /// Get/set the author for filtering mods.
        /// </summary>
        private string FilterHomebrewCreator { get; set; } = string.Empty;

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
                FilterHomebrewCategoryId = category == null ? Settings.CustomLists.Find(x => x.Platform == PlatformType && x.Name.Equals(selectedCategory)).Name : category.Id;
            }

            SearchHomebrew();
        }

        private void TextBoxFilterHomebrewName_TextChanged(object sender, EventArgs e)
        {
            FilterHomebrewName = TextBoxHomebrewFilterName.Text;

            SearchHomebrew();
        }

        private void ComboBoxHomebrewFilterSystemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewSystemType = ComboBoxHomebrewFilterSystemType.SelectedIndex == 0 | ComboBoxHomebrewFilterSystemType.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterSystemType.SelectedItem.ToString();

            SearchHomebrew();
        }

        private void ComboBoxHomebrewFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewVersion = ComboBoxHomebrewFilterVersion.SelectedIndex == 0 | ComboBoxHomebrewFilterVersion.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterVersion.SelectedItem as string;

            SearchHomebrew();
        }

        private void ComboBoxHomebrewFilterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewCreator = ComboBoxHomebrewFilterCreator.SelectedIndex == 0 | ComboBoxHomebrewFilterCreator.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterCreator.SelectedItem as string;

            SearchHomebrew();
        }

        private void ComboBoxHomebrewFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterHomebrewStatus = ComboBoxHomebrewFilterStatus.SelectedIndex == 0 | ComboBoxHomebrewFilterStatus.SelectedIndex == -1
                ? string.Empty
                : ComboBoxHomebrewFilterStatus.SelectedItem as string;

            SearchHomebrew();
        }

        private void LoadHomebrewCategories()
        {
            ComboBoxHomebrewFilterCategory.Properties.Items.Clear();

            ComboBoxHomebrewFilterCategory.SelectedIndexChanged -= ComboBoxHomebrewFilterCategory_SelectedIndexChanged;
            ComboBoxHomebrewFilterCategory.SelectedIndex = -1;
            ComboBoxHomebrewFilterCategory.SelectedIndexChanged += ComboBoxHomebrewFilterCategory_SelectedIndexChanged;

            ComboBoxHomebrewFilterCategory.Properties.Items.Add("<All Categories>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Homebrew == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxHomebrewFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableHomebrew { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("System Type", typeof(string)),
                new("Version", typeof(string)),
                new("Creator", typeof(string)),
                new("Status", typeof(string))
            });

        /// <summary>
        /// Search for mods and display the results.
        /// </summary>
        private void SearchHomebrew()
        {
            GridViewHomebrew.ShowLoadingPanel();

            Category category;

            if (FilterHomebrewCategoryId.IsNullOrWhiteSpace())
            {
                category = new Category()
                {
                    Id = string.Empty,
                    Regions = new string[] { },
                    Title = "<All Categories>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterHomebrewCategoryId);
            }

            ComboBoxHomebrewFilterVersion.Properties.Items.Clear();
            ComboBoxHomebrewFilterVersion.Properties.Items.Add("<All>");

            ComboBoxHomebrewFilterCreator.Properties.Items.Clear();
            ComboBoxHomebrewFilterCreator.Properties.Items.Add("<All>");

            DataTableHomebrew.Rows.Clear();

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            List<string> versions = new();
            List<string> authors = new();

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.ModsPS3.GetHomebrewItems(Database.CategoriesData, FilterHomebrewCategoryId, FilterHomebrewName, FilterHomebrewSystemType, FilterHomebrewVersion, FilterHomebrewCreator, FilterHomebrewShowFavorites))
                {
                    bool isInstalled = Settings.GetInstalledMods(modItemData.GetPlatform(), modItemData.CategoryId, modItemData.Id) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterHomebrewStatus == "Downloaded" && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterHomebrewStatus == "Installed" && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterHomebrewStatus == "Not Installed" && isInstalled)
                    {
                        continue;
                    }

                    DataTableHomebrew.Rows.Add(modItemData.Id,
                                           modItemData.GetCategoryName(Database.CategoriesData),
                                           modItemData.Name,
                                           modItemData.FirmwareType,
                                           string.Join(" & ", modItemData.Versions),
                                           modItemData.CreatedBy,
                                           isDownloadNotInstalled ? ResourceLanguage.GetString("Downloaded") :isInstalled ? ResourceLanguage.GetString("Installed") :ResourceLanguage.GetString("Not Installed"));

                    foreach (string version in from string version in modItemData.Versions
                                               where !ComboBoxHomebrewFilterVersion.Properties.Items.Contains(version)
                                               where !ignoreValues.Exists(x => x.EqualsIgnoreCase(version))
                                               select version)
                    {
                        ComboBoxHomebrewFilterVersion.Properties.Items.Add(version);
                    }

                    foreach (string author in from string author in modItemData.Creators
                                              where !ComboBoxHomebrewFilterCreator.Properties.Items.Contains(author)
                                              where !ignoreValues.Exists(x => x.EqualsIgnoreCase(author))
                                              select author)
                    {
                        ComboBoxHomebrewFilterCreator.Properties.Items.Add(author);
                    }
                }
            }));

            GridControlHomebrew.DataSource = DataTableHomebrew;

            GridViewHomebrew.Columns[0].Visible = false;

            GridViewHomebrew.Columns[1].MinWidth = 232;
            GridViewHomebrew.Columns[1].MaxWidth = 232;

            //GridViewHomebrew.Columns[2].MinWidth = 30;

            GridViewHomebrew.Columns[3].MinWidth = 88;
            GridViewHomebrew.Columns[3].MaxWidth = 88;

            GridViewHomebrew.Columns[4].MinWidth = 70;
            GridViewHomebrew.Columns[4].MaxWidth = 70;

            GridViewHomebrew.Columns[5].MinWidth = 132;
            GridViewHomebrew.Columns[5].MaxWidth = 132;

            GridViewHomebrew.Columns[6].MinWidth = 94;
            GridViewHomebrew.Columns[6].MaxWidth = 94;

            GridViewHomebrew.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewHomebrew.Columns[FilterHomebrewSortOption], FilterHomebrewSortOrder),
            });

            ComboBoxHomebrewFilterSystemType.SelectedIndexChanged -= ComboBoxHomebrewFilterSystemType_SelectedIndexChanged;
            ComboBoxHomebrewFilterSystemType.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewSystemType) ? -1 : ComboBoxHomebrewFilterSystemType.Properties.Items.IndexOf(FilterHomebrewSystemType);
            ComboBoxHomebrewFilterSystemType.SelectedIndexChanged += ComboBoxHomebrewFilterSystemType_SelectedIndexChanged;

            ComboBoxHomebrewFilterVersion.SelectedIndexChanged -= ComboBoxHomebrewFilterVersion_SelectedIndexChanged;
            ComboBoxHomebrewFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewVersion) ? -1 : ComboBoxHomebrewFilterVersion.Properties.Items.IndexOf(FilterHomebrewVersion);
            ComboBoxHomebrewFilterVersion.SelectedIndexChanged += ComboBoxHomebrewFilterVersion_SelectedIndexChanged;

            ComboBoxHomebrewFilterCreator.SelectedIndexChanged -= ComboBoxHomebrewFilterCreator_SelectedIndexChanged;
            ComboBoxHomebrewFilterCreator.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewCreator) ? -1 : ComboBoxHomebrewFilterCreator.Properties.Items.IndexOf(FilterHomebrewCreator);
            ComboBoxHomebrewFilterCreator.SelectedIndexChanged += ComboBoxHomebrewFilterCreator_SelectedIndexChanged;

            ComboBoxHomebrewFilterStatus.SelectedIndexChanged -= ComboBoxHomebrewFilterStatus_SelectedIndexChanged;
            ComboBoxHomebrewFilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterHomebrewStatus) ? -1 : ComboBoxHomebrewFilterStatus.Properties.Items.IndexOf(FilterHomebrewStatus);
            ComboBoxHomebrewFilterStatus.SelectedIndexChanged += ComboBoxHomebrewFilterStatus_SelectedIndexChanged;

            GridViewHomebrew.HideLoadingPanel();
        }

        private void GridViewHomebrew_RowClick(object sender, RowClickEventArgs e)
        {
            int modId = (int)GridViewHomebrew.GetRowCellValue(e.RowHandle, GridViewHomebrew.Columns[0]);
            ShowHomebrewDetails(modId);
        }

        private void GridViewHomebrew_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            switch (e.HitInfo.InRow)
            {
                case true:
                    {
                        GridView view = sender as GridView;
                        view.FocusedRowHandle = e.HitInfo.RowHandle;

                        MenuHomebrew.ShowPopup(Cursor.Position);
                        break;
                    }
            }
        }

        private void MenuHomebrew_BeforePopup(object sender, CancelEventArgs e)
        {
            ModItemData modItem = SelectedHomebrewItem;

            if (modItem != null)
            {
                InstalledModInfo installedMod = Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);

                bool isInstalled = installedMod != null && installedMod.ModId.Equals(modItem.Id);

                MenuItemHomebrewInstallFiles.Caption = isInstalled ? $"{ResourceLanguage.GetString("Uninstall Files")}..." : $"{ResourceLanguage.GetString("Install Files")}...";

                MenuItemHomebrewInstallFiles.Enabled = Settings.InstallHomebrewToUsbDevice | IsConsoleConnected;
            }
        }

        private void MenuItemHomebrewInstallFiles_ItemClick(object sender, EventArgs e)
        {
            ModItemData modItem = SelectedHomebrewItem;
            InstalledModInfo installedModInfo = Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);
            bool isInstalled = installedModInfo != null;

            if (isInstalled)
            {
                ShowTransferModsDialog(Window, TransferType.UninstallMods, modItem);
            }
            else
            {
                ShowTransferModsDialog(Window, TransferType.InstallMods, modItem);
            }
        }

        #endregion

        #region Resources Page

        private void TileItemResourcesShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterResourcesShowFavorites)
            {
                FilterResourcesShowFavorites = false;
                TileItemResourcesShowFavorites.Text = ResourceLanguage.GetString("Show Favorites");
                SearchResources();
            }
            else
            {
                FilterResourcesShowFavorites = true;
                TileItemResourcesShowFavorites.Text = ResourceLanguage.GetString("Hide Favorites");
                SearchResources();
            }
        }

        private void TileItemResourcesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterResourcesSortOption, new List<string> { "Category", "Name", "System Type", "Mod Type", "Version", "Creator" }, FilterResourcesSortOrder);

            if (sortOptions != null)
            {
                FilterResourcesSortOption = sortOptions.SortOption;
                FilterResourcesSortOrder = sortOptions.SortOrder;
                SearchResources();
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterResourcesSortOption { get; set; } = "Category";

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
        /// Get/set the author for filtering mods.
        /// </summary>
        private string FilterResourcesCreator { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the status for filtering mods.
        /// </summary>
        private string FilterResourcesStatus { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the selected mods info selected by the user.
        /// </summary>
        private static ModItemData SelectedResourceItem { get; set; }

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
                FilterResourcesCategoryId = category == null ? Settings.CustomLists.Find(x => x.Platform == PlatformType && x.Name.Equals(selectedCategory)).Name : category.Id;
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

        private void ComboBoxResourcesFilterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResourcesCreator = ComboBoxResourcesFilterCreator.SelectedIndex == 0 | ComboBoxResourcesFilterCreator.SelectedIndex == -1
                ? string.Empty
                : ComboBoxResourcesFilterCreator.SelectedItem as string;

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

            ComboBoxResourcesFilterCategory.Properties.Items.Add("<All Categories>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Resource == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxResourcesFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableResources { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("System Type", typeof(string)),
                new("Mod Type", typeof(string)),
                new("Version", typeof(string)),
                new("Creator", typeof(string)),
                new("Status", typeof(string))
            });

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
                    Regions = new string[] { },
                    Title = "<All Categories>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterResourcesCategoryId);
            }

            bool isCustomList = Settings.CustomLists.Any(x => x.Platform == PlatformType && x.Name.Equals(FilterResourcesCategoryId));

            ComboBoxResourcesFilterModType.Properties.Items.Clear();
            ComboBoxResourcesFilterModType.Properties.Items.Add("<All>");

            ComboBoxResourcesFilterVersion.Properties.Items.Clear();
            ComboBoxResourcesFilterVersion.Properties.Items.Add("<All>");

            ComboBoxResourcesFilterCreator.Properties.Items.Clear();
            ComboBoxResourcesFilterCreator.Properties.Items.Add("<All>");

            switch (FilterResourcesCategoryId)
            {
                case "fvrt":
                    ComboBoxResourcesFilterModType.Properties.Items.AddRange(Settings.GetModTypesForMods(Database.ModsPS3, Settings.FavoriteIds.Where(x => x.Platform.Equals(PlatformType)).FirstOrDefault().Ids).ToArray());
                    break;
                default:
                    {
                        switch (isCustomList)
                        {
                            case true:
                                ComboBoxResourcesFilterModType.Properties.Items.AddRange(Settings.GetModTypesForMods(Database.ModsPS3, Settings.GetCustomListByName(FilterResourcesCategoryId, PlatformType).ModIds).ToArray());
                                break;
                            default:
                                {
                                    foreach (string modType in Database.ModsPS3.AllModTypesForCategoryId(category.Id))
                                    {
                                        ComboBoxResourcesFilterModType.Properties.Items.Add(modType);
                                    }

                                    break;
                                }
                        }

                        break;
                    }
            }

            DataTableResources.Rows.Clear();

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            List<string> modTypes = new();
            List<string> versions = new();
            List<string> authors = new();

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.ModsPS3.GetResourceItems(Database.CategoriesData, FilterResourcesCategoryId, FilterResourcesName, FilterResourcesSystemType, FilterResourcesModType, FilterResourcesVersion, FilterResourcesCreator, FilterResourcesShowFavorites).OrderBy(x => x.Name))
                {
                    bool isInstalled = Settings.GetInstalledMods(modItemData.GetPlatform(), modItemData.CategoryId, modItemData.Id) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterHomebrewStatus == "Downloaded" && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterHomebrewStatus == "Installed" && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterHomebrewStatus == "Not Installed" && isInstalled)
                    {
                        continue;
                    }

                    DataTableResources.Rows.Add(modItemData.Id,
                                           modItemData.GetCategoryName(Database.CategoriesData),
                                           modItemData.Name,
                                           modItemData.FirmwareType,
                                           modItemData.ModType,
                                           string.Join(" & ", modItemData.Versions),
                                           modItemData.CreatedBy,
                                           isDownloadNotInstalled ? ResourceLanguage.GetString("Downloaded") :isInstalled ? ResourceLanguage.GetString("Installed") :ResourceLanguage.GetString("Not Installed"));

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

                    foreach (string author in from string author in modItemData.Creators
                                              where !ComboBoxResourcesFilterCreator.Properties.Items.Contains(author)
                                              where !ignoreValues.Exists(x => x.EqualsIgnoreCase(author))
                                              select author)
                    {
                        ComboBoxResourcesFilterCreator.Properties.Items.Add(author);
                    }
                }
            }));

            GridControlResources.DataSource = DataTableResources;

            GridViewResources.Columns[0].Visible = false;

            GridViewResources.Columns[1].MinWidth = 232;
            GridViewResources.Columns[1].MaxWidth = 232;

            //GridViewResources.Columns[2].MinWidth = 30;

            GridViewResources.Columns[3].MinWidth = 88;
            GridViewResources.Columns[3].MaxWidth = 88;

            GridViewResources.Columns[4].MinWidth = 96;
            GridViewResources.Columns[4].MaxWidth = 96;

            GridViewResources.Columns[5].MinWidth = 70;
            GridViewResources.Columns[5].MaxWidth = 70;

            GridViewResources.Columns[6].MinWidth = 132;
            GridViewResources.Columns[6].MaxWidth = 132;

            GridViewResources.Columns[7].MinWidth = 94;
            GridViewResources.Columns[7].MaxWidth = 94;

            GridViewResources.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewResources.Columns[FilterResourcesSortOption], FilterResourcesSortOrder),
            });

            ComboBoxResourcesFilterSystemType.SelectedIndexChanged -= ComboBoxResourcesFilterSystemType_SelectedIndexChanged;
            ComboBoxResourcesFilterSystemType.SelectedIndex = string.IsNullOrEmpty(FilterResourcesSystemType) ? -1 : ComboBoxResourcesFilterSystemType.Properties.Items.IndexOf(FilterResourcesSystemType);
            ComboBoxResourcesFilterSystemType.SelectedIndexChanged += ComboBoxResourcesFilterSystemType_SelectedIndexChanged;

            ComboBoxResourcesFilterModType.SelectedIndexChanged -= ComboBoxResourcesFilterModType_SelectedIndexChanged;
            ComboBoxResourcesFilterModType.SelectedIndex = string.IsNullOrEmpty(FilterResourcesModType) ? -1 : ComboBoxResourcesFilterModType.Properties.Items.IndexOf(FilterResourcesModType);
            ComboBoxResourcesFilterModType.SelectedIndexChanged += ComboBoxResourcesFilterModType_SelectedIndexChanged;

            ComboBoxResourcesFilterVersion.SelectedIndexChanged -= ComboBoxResourcesFilterVersion_SelectedIndexChanged;
            ComboBoxResourcesFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterResourcesVersion) ? -1 : ComboBoxResourcesFilterVersion.Properties.Items.IndexOf(FilterResourcesVersion);
            ComboBoxResourcesFilterVersion.SelectedIndexChanged += ComboBoxResourcesFilterVersion_SelectedIndexChanged;

            ComboBoxResourcesFilterCreator.SelectedIndexChanged -= ComboBoxResourcesFilterCreator_SelectedIndexChanged;
            ComboBoxResourcesFilterCreator.SelectedIndex = string.IsNullOrEmpty(FilterResourcesCreator) ? -1 : ComboBoxResourcesFilterCreator.Properties.Items.IndexOf(FilterResourcesCreator);
            ComboBoxResourcesFilterCreator.SelectedIndexChanged += ComboBoxResourcesFilterCreator_SelectedIndexChanged;

            ComboBoxResourcesFilterStatus.SelectedIndexChanged -= ComboBoxResourcesFilterStatus_SelectedIndexChanged;
            ComboBoxResourcesFilterStatus.SelectedIndex = string.IsNullOrEmpty(FilterResourcesStatus) ? -1 : ComboBoxResourcesFilterStatus.Properties.Items.IndexOf(FilterResourcesStatus);
            ComboBoxResourcesFilterStatus.SelectedIndexChanged += ComboBoxResourcesFilterStatus_SelectedIndexChanged;

            GridViewResources.HideLoadingPanel();
        }

        private void GridViewResources_RowClick(object sender, RowClickEventArgs e)
        {
            int modId = (int)GridViewResources.GetRowCellValue(e.RowHandle, GridViewResources.Columns[0]);
            ShowResourceDetails(modId);
        }

        private void GridViewResources_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            switch (e.HitInfo.InRow)
            {
                case true:
                    {
                        GridView view = sender as GridView;
                        view.FocusedRowHandle = e.HitInfo.RowHandle;

                        MenuResources.ShowPopup(Cursor.Position);
                        break;
                    }
            }
        }

        private void MenuResources_BeforePopup(object sender, CancelEventArgs e)
        {
            ModItemData modItem = SelectedResourceItem;

            if (modItem != null)
            {
                MenuItemResourcesInstallFiles.Enabled = Settings.InstallResourcesToUsbDevice | IsConsoleConnected;
            }
        }

        private void MenuItemResourcesInstallFiles_ItemClick(object sender, EventArgs e)
        {
            ModItemData modItem = SelectedResourceItem;
            InstalledModInfo installedModInfo = Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);
            bool isInstalled = installedModInfo != null;

            if (isInstalled)
            {
                ShowTransferModsDialog(Window, TransferType.UninstallMods, modItem, installedModInfo.DownloadFiles.Region);
            }
            else
            {
                ShowTransferModsDialog(Window, TransferType.InstallMods, modItem);
            }
        }

        #endregion

        #region Packages Page

        private void TileItemPackagesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterPackagesSortOption, new List<string> { "Category", "Name", "Region", "Modified Date", "File Size", "Status" }, FilterPackagesSortOrder);

            if (sortOptions != null)
            {
                FilterPackagesSortOption = sortOptions.SortOption;
                FilterPackagesSortOrder = sortOptions.SortOrder;
                SearchPackages();
            }
        }

        private PackagesData PackagesData { get; set; }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterPackagesSortOption { get; set; } = "Category";

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
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
            //if (ComboBoxPackagesFilterModifiedDate.Text.IsValidDate("MM/dd/yyyy"))
            //{
            //    FilterPackagesModifiedDate = DateTime.Parse(ComboBoxPackagesFilterModifiedDate.Text);
            //    SearchPackages();
            //}
            //else
            //{
            //    ComboBoxPackagesFilterModifiedDate.Text = string.Empty;
            //    FilterPackagesModifiedDate = null;
            //}
        }

        private void ComboBoxPackagesFilterModifiedDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ComboBoxPackagesFilterModifiedDate.EditValue.ToString().IsValidDate("MM/dd/yyyy"))
                {
                    FilterPackagesModifiedDate = DateTime.Parse(ComboBoxPackagesFilterModifiedDate.EditValue.ToString(), CultureInfo.CurrentCulture);
                    SearchPackages();
                }
                else
                {
                    ComboBoxPackagesFilterModifiedDate.EditValue = null;
                    FilterPackagesModifiedDate = null;
                    SearchPackages();
                }
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
            new List<DataColumn>()
            {
                new("Url", typeof(string)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("Region", typeof(string)),
                new("Modified Date", typeof(string)),
                new("File Size", typeof(string)),
                new("Status", typeof(string))
            });

        /// <summary>
        /// Load packages into view.
        /// </summary>
        private void LoadPackages()
        {
            GridViewPackages.ShowLoadingPanel();

            DataTablePackages.Rows.Clear();

            BeginInvoke(new Action(() =>
            {
                foreach (PackageItemData package in GetAllPackages().OrderBy(x => x.Name))
                {
                    bool isInstalled = Settings.InstalledPackages.Any(x => x.Url.Equals(x.Url));

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

                    if (shouldLoad)
                    {
                        DataTablePackages.Rows.Add(package.Url,
                                               package.Category,
                                               package.Name,
                                               package.TitleId,
                                               package.IsDateMissing ? "MISSING" : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                               package.IsSizeMissing ? "MISSING" : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " Bytes",
                                               isInstalled ? ResourceLanguage.GetString("Installed") :ResourceLanguage.GetString("Not Installed"));
                    }
                }
            }));

            GridControlPackages.DataSource = DataTablePackages;

            GridViewPackages.Columns[0].Visible = false;

            GridViewPackages.Columns[1].MinWidth = 82;
            GridViewPackages.Columns[1].MaxWidth = 82;

            //GridViewGames.Columns[2].MinWidth = 232;
            //GridViewGames.Columns[2].MaxWidth = 232;

            GridViewPackages.Columns[3].MaxWidth = 86;
            GridViewPackages.Columns[3].MinWidth = 86;

            GridViewPackages.Columns[4].MaxWidth = 108;
            GridViewPackages.Columns[4].MinWidth = 108;

            GridViewPackages.Columns[5].MaxWidth = 92;
            GridViewPackages.Columns[5].MinWidth = 92;

            GridViewPackages.Columns[6].MaxWidth = 94;
            GridViewPackages.Columns[6].MinWidth = 94;

            GridViewPackages.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewPackages.Columns[FilterPackagesSortOption], FilterPackagesSortOrder),
            });

            GridViewPackages.HideLoadingPanel();
        }

        private void SearchPackages()
        {
            GridViewPackages.ShowLoadingPanel();

            DataTablePackages.Rows.Clear();

            List<PackageItemData> packages;

            if (FilterPackagesCategory.IsNullOrEmpty())
            {
                ComboBoxFilterPackagesCategories.SelectedIndex = -1;
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

                    if (shouldLoad)
                    {
                        switch (FilterPackagesStatus)
                        {
                            case "Installed" when isInstalled:
                                DataTablePackages.Rows.Add(package.Url,
                                                           package.Category,
                                                           package.Name,
                                                           package.TitleId,
                                                           package.IsDateMissing ? "MISSING" : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                           package.IsSizeMissing ? "MISSING" : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " Bytes",
                                                           isInstalled ? ResourceLanguage.GetString("Installed") :ResourceLanguage.GetString("Not Installed"));
                                break;
                            case "Not Installed" when !isInstalled:
                                DataTablePackages.Rows.Add(package.Url,
                                                           package.Category,
                                                           package.Name,
                                                           package.TitleId,
                                                           package.IsDateMissing ? "MISSING" : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                           package.IsSizeMissing ? "MISSING" : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " Bytes",
                                                           isInstalled ? ResourceLanguage.GetString("Installed") :ResourceLanguage.GetString("Not Installed"));
                                break;
                            default:
                                DataTablePackages.Rows.Add(package.Url,
                                                           package.Category,
                                                           package.Name,
                                                           package.TitleId,
                                                           package.IsDateMissing ? "MISSING" : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                                           package.IsSizeMissing ? "MISSING" : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " Bytes",
                                                           isInstalled ? ResourceLanguage.GetString("Installed") :ResourceLanguage.GetString("Not Installed"));
                                break;
                        }
                    }
                }
            }));

            GridControlPackages.DataSource = DataTablePackages;

            GridViewPackages.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewPackages.Columns[FilterPackagesSortOption], FilterPackagesSortOrder),
            });

            GridViewPackages.HideLoadingPanel();
        }

        private static List<PackageItemData> GetAllPackages()
        {
            List<PackageItemData> packages = new();

            packages.AddRange(Database.GamesPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.DemosPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.DLCsPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.AvatarsPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.ThemesPS3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));

            return packages;
        }

        private void GridViewPackages_RowClick(object sender, RowClickEventArgs e)
        {
            ShowPackageDetails(GridViewPackages.GetFocusedRowCellDisplayText("Category"), GridViewPackages.GetFocusedRowCellDisplayText("Url"));
        }

        #endregion

        #region Plugins Page

        private void TileItemPluginsShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterPluginsShowFavorites)
            {
                FilterPluginsShowFavorites = false;
                TileItemPluginsShowFavorites.Text = ResourceLanguage.GetString("Show Favorites");
                SearchPlugins();
            }
            else
            {
                FilterPluginsShowFavorites = true;
                TileItemPluginsShowFavorites.Text = ResourceLanguage.GetString("Hide Favorites");
                SearchPlugins();
            }
        }

        private void TileItemPluginsSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterPluginsSortOption, new List<string> { "Category", "Name", "Version", "Creator", "Status" }, FilterPluginsSortOrder);

            if (sortOptions != null)
            {
                FilterPluginsSortOption = sortOptions.SortOption;
                FilterPluginsSortOrder = sortOptions.SortOrder;
                SearchPlugins();
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterPluginsSortOption { get; set; } = "Category";

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterPluginsSortOrder { get; set; } = ColumnSortOrder.Ascending;

        /// <summary>
        /// Get/set option to filter by favorites.
        /// </summary>
        private bool FilterPluginsShowFavorites { get; set; } = false;

        private string FilterPluginsCategoryId { get; set; } = string.Empty;

        private string FilterPluginsName { get; set; } = string.Empty;

        private string FilterPluginsVersion { get; set; } = string.Empty;

        private string FilterPluginsCreator { get; set; } = string.Empty;

        private string FilterPluginsStatus { get; set; } = string.Empty;

        private void ComboBoxPluginsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPluginsFilterCategory.SelectedIndex == 0 | ComboBoxPluginsFilterCategory.SelectedIndex == -1)
            {
                FilterPluginsCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxPluginsFilterCategory.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterPluginsCategoryId = category == null ? Settings.CustomLists.Find(x => x.Platform == PlatformType && x.Name.Equals(selectedCategory)).Name : category.Id;
            }

            SearchPlugins();
        }

        private void TextBoxPluginsFilterName_TextChanged(object sender, EventArgs e)
        {
            FilterPluginsName = TextBoxPluginsFilterName.Text;
            SearchPackages();
        }

        private void ComboBoxPluginsFilterVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPluginsFilterVersion.SelectedIndex is (-1) or 0)
            {
                FilterPluginsVersion = string.Empty;
                SearchPlugins();
                return;
            }

            FilterPluginsVersion = ComboBoxPluginsFilterVersion.SelectedItem as string;
            SearchPlugins();
        }

        private void ComboBoxPluginsFilterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPluginsFilterCreator.SelectedIndex is (-1) or 0)
            {
                FilterPluginsCreator = string.Empty;
                SearchPlugins();
                return;
            }

            FilterPluginsCreator = ComboBoxPluginsFilterCreator.SelectedItem as string;
            SearchPlugins();
        }

        private void ComboBoxPluginsFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPluginsFilterStatus.SelectedIndex is (-1) or 0)
            {
                FilterPluginsStatus = string.Empty;
                SearchPlugins();
                return;
            }

            FilterPluginsStatus = ComboBoxPluginsFilterStatus.SelectedItem as string;
            SearchPlugins();
        }

        private static DataTable DataTablePlugins { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("Version", typeof(string)),
                new("Creator", typeof(string)),
                new("Status", typeof(string))
            });

        private void LoadPluginsCategories()
        {
            ComboBoxPluginsFilterCategory.SelectedIndexChanged -= ComboBoxPluginsFilterCategory_SelectedIndexChanged;
            ComboBoxPluginsFilterCategory.SelectedIndex = -1;
            ComboBoxPluginsFilterCategory.SelectedIndexChanged += ComboBoxPluginsFilterCategory_SelectedIndexChanged;

            ComboBoxPluginsFilterCategory.Properties.Items.Add("<All Categories>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => x.CategoryType == CategoryType.Game).OrderBy(x => x.Title))
            {
                ComboBoxPluginsFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        /// <summary>
        /// Load all plugins for Xbox.
        /// </summary>
        public void SearchPlugins()
        {
            GridViewPlugins.ShowLoadingPanel();

            DataTablePlugins.Rows.Clear();

            foreach (ModItemData modItemData in Database.PluginsXBOX.GetPluginItems(FilterPluginsCategoryId, FilterPluginsName, FilterPluginsVersion, FilterPluginsCreator, FilterPluginsShowFavorites))
            {
                bool isInstalled = Settings.GetInstalledMods(modItemData.GetPlatform(), modItemData.CategoryId, modItemData.Id) != null;

                bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                if (FilterPluginsStatus == "Downloaded" && !isDownloaded)
                {
                    continue;
                }
                else if (FilterPluginsStatus == "Installed" && !isInstalled)
                {
                    continue;
                }
                else if (FilterPluginsStatus == "Not Installed" && isInstalled)
                {
                    continue;
                }

                Category category = Database.CategoriesData.GetCategoryById(modItemData.CategoryId);

                DataTablePlugins.Rows.Add(modItemData.Id,
                                          category.Title,
                                          modItemData.Name,
                                          modItemData.Version,
                                          modItemData.CreatedBy,
                                          isDownloadNotInstalled ? ResourceLanguage.GetString("Downloaded") : isInstalled ? ResourceLanguage.GetString("Installed") : ResourceLanguage.GetString("Not Installed"));
            }

            GridControlPlugins.DataSource = DataTablePlugins;

            GridViewPlugins.Columns[0].Visible = false;

            GridViewPlugins.Columns[1].MinWidth = 232;
            GridViewPlugins.Columns[1].MaxWidth = 232;

            //GridViewPlugins.Columns[2].MinWidth = 180; //125

            GridViewPlugins.Columns[3].MinWidth = 68;
            GridViewPlugins.Columns[3].MaxWidth = 68;

            GridViewPlugins.Columns[4].MinWidth = 132;
            GridViewPlugins.Columns[4].MaxWidth = 132;

            GridViewPlugins.Columns[5].MinWidth = 92;
            GridViewPlugins.Columns[5].MaxWidth = 92;

            GridViewPlugins.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewPlugins.Columns[FilterPluginsSortOption], FilterPluginsSortOrder),
            });

            GridViewPlugins.HideLoadingPanel();
        }

        private void GridViewPlugins_RowClick(object sender, RowClickEventArgs e)
        {
            ModItemData selectedPlugin = Database.PluginsXBOX.GetModById(PlatformPrefix.XBOX, int.Parse(GridViewPlugins.GetRowCellDisplayText(e.RowHandle, "Id")));
            ShowPluginDetails(selectedPlugin.Id);
        }

        #endregion

        #region Game Saves Page

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterGameSavesSortOption { get; set; } = "Category";

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

        /// <summary>
        /// Get/set the version for filtering game saves.
        /// </summary>
        private string FilterGameSavesCreator { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the downloads status for filtering game saves.
        /// </summary>
        private string FilterGameSavesStatus { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the downloads status for filtering game saves.
        /// </summary>
        private GameSaveItemData SelectedGameSaveItem { get; set; }

        private void TileItemGameSavesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameSavesSortOption, new List<string> { "Category", "Name", "Region", "Version", "Creator" }, FilterGameSavesSortOrder);

            if (sortOptions != null)
            {
                FilterGameSavesSortOption = sortOptions.SortOption;
                FilterGameSavesSortOrder = sortOptions.SortOrder;
                SearchGameSaves();
            }
        }

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
                FilterGameSavesCategoryId = category == null ? Settings.CustomLists.Find(x => x.Platform == PlatformType && x.Name.Equals(selectedCategory)).Name : category.Id;
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

        private void ComboBoxGameSavesFilterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGameSavesCreator = ComboBoxGameSavesFilterCreator.SelectedIndex == 0 | ComboBoxGameSavesFilterCreator.SelectedIndex == -1
                ? string.Empty
                : ComboBoxGameSavesFilterCreator.SelectedItem as string;

            SearchGameSaves();
        }

        private static DataTable DataTableGameSaves { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("Region", typeof(string)),
                new("Version", typeof(string)),
                new("Creator", typeof(string))
            });

        private void LoadGameSavesCategories()
        {
            ComboBoxGameSavesFilterCategory.Properties.Items.Clear();

            ComboBoxGameSavesFilterCategory.Properties.Items.Add("<All Categories>");

            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                ComboBoxGameSavesFilterCategory.Properties.Items.Add(category.Title);
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

            ComboBoxGameSavesFilterRegion.Properties.Items.Clear();
            ComboBoxGameSavesFilterRegion.Properties.Items.Add("<All>");

            ComboBoxGameSavesFilterVersion.Properties.Items.Clear();
            ComboBoxGameSavesFilterVersion.Properties.Items.Add("<All>");

            ComboBoxGameSavesFilterCreator.Properties.Items.Clear();
            ComboBoxGameSavesFilterCreator.Properties.Items.Add("<All>");

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            foreach (GameSaveItemData gameSaveItem in Database.GameSaves.GetGameSaveItems(PlatformType, FilterGameSavesCategoryId, FilterGameSavesName, FilterGameSavesRegion, FilterGameSavesVersion, FilterGameSavesCreator))
            {
                Category category = Database.CategoriesData.GetCategoryById(gameSaveItem.CategoryId);

                DataTableGameSaves.Rows.Add(gameSaveItem.Id,
                                            category.Title,
                                            gameSaveItem.Name,
                                            gameSaveItem.Region,
                                            gameSaveItem.Version,
                                            gameSaveItem.CreatedBy);

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

                foreach (string author in from string author in gameSaveItem.Creators
                                          where !ComboBoxGameSavesFilterCreator.Properties.Items.Contains(author)
                                          where !ignoreValues.Exists(x => x.EqualsIgnoreCase(author))
                                          select author)
                {
                    ComboBoxGameSavesFilterCreator.Properties.Items.Add(author);
                }
            }

            GridControlGameSaves.DataSource = DataTableGameSaves;

            GridViewGameSaves.Columns[0].Visible = false;

            GridViewGameSaves.Columns[1].MinWidth = 232;
            GridViewGameSaves.Columns[1].MaxWidth = 232;

            //GridViewGameSaves.Columns[2].MinWidth = 180; // Ignore column

            GridViewGameSaves.Columns[3].MinWidth = 90;
            GridViewGameSaves.Columns[3].MaxWidth = 90;

            GridViewGameSaves.Columns[4].MinWidth = 70;
            GridViewGameSaves.Columns[4].MaxWidth = 70;

            GridViewGameSaves.Columns[5].MinWidth = 132;
            GridViewGameSaves.Columns[5].MaxWidth = 132;

            ComboBoxGameSavesFilterRegion.SelectedIndexChanged -= ComboBoxGameSavesFilterRegion_SelectedIndexChanged;
            ComboBoxGameSavesFilterRegion.SelectedIndex = string.IsNullOrEmpty(FilterGameSavesRegion) ? -1 : ComboBoxGameSavesFilterRegion.Properties.Items.IndexOf(FilterGameSavesRegion);
            ComboBoxGameSavesFilterRegion.SelectedIndexChanged += ComboBoxGameSavesFilterRegion_SelectedIndexChanged;

            ComboBoxGameSavesFilterVersion.SelectedIndexChanged -= ComboBoxGameSavesFilterVersion_SelectedIndexChanged;
            ComboBoxGameSavesFilterVersion.SelectedIndex = string.IsNullOrEmpty(FilterGameSavesVersion) ? -1 : ComboBoxGameSavesFilterVersion.Properties.Items.IndexOf(FilterGameSavesVersion);
            ComboBoxGameSavesFilterVersion.SelectedIndexChanged += ComboBoxGameSavesFilterVersion_SelectedIndexChanged;

            ComboBoxGameSavesFilterCreator.SelectedIndexChanged -= ComboBoxGameSavesFilterCreator_SelectedIndexChanged;
            ComboBoxGameSavesFilterCreator.SelectedIndex = string.IsNullOrEmpty(FilterGameSavesCreator) ? -1 : ComboBoxGameSavesFilterCreator.Properties.Items.IndexOf(FilterGameSavesCreator);
            ComboBoxGameSavesFilterCreator.SelectedIndexChanged += ComboBoxGameSavesFilterCreator_SelectedIndexChanged;

            GridViewGameSaves.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewGameSaves.Columns[FilterGameSavesSortOption], FilterGameSavesSortOrder),
            });

            GridViewGameSaves.HideLoadingPanel();
        }

        private void GridViewGameSaves_RowClick(object sender, RowClickEventArgs e)
        {
            GameSaveItemData selectedGameSave = Database.GameSaves.GetModById(PlatformType, int.Parse(GridViewGameSaves.GetRowCellDisplayText(e.RowHandle, "Id")));
            SelectedGameSaveItem = selectedGameSave;

            ShowGameSaveDetails(PlatformType, selectedGameSave.Id);
        }

        private void MenuGameSaves_BeforePopup(object sender, CancelEventArgs e)
        {
            if (SelectedGameSaveItem != null)
            {
                MenuItemGameSavesInstallFiles.Enabled = Settings.InstallGameSavesToUsbDevice | IsConsoleConnected;
            }
        }

        private void MenuItemGameSavesInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowTransferGameSavesFileDialog(Window, TransferType.InstallGameSave, SelectedGameSaveItem);
        }

        #endregion

        #region Real Time Mods Page

        private void LoadRealTimeModsCategories()
        {
            ComboBoxFilterRealTimeModsGame.Properties.Items.Clear();

            ComboBoxFilterRealTimeModsGame.Properties.Items.Add("<All Categories>");

            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                if (Database.ModsOffsets.Mods.Any(x => x.GameId.Equals(category.Id)))
                {
                    ComboBoxFilterRealTimeModsGame.Properties.Items.Add(category.Title);
                }
            }
        }

        /// <summary>
        /// Get/set the category Id for filtering game saves.
        /// </summary>
        private string FilterRealTimeModsGameId { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the file name for filtering game saves.
        /// </summary>
        private string FilterRealTimeModsName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the mod type for filtering game saves.
        /// </summary>
        private string FilterRealTimeModsCategory { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the version for filtering game saves.
        /// </summary>
        private string FilterRealTimeModsGameMode { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the downloads status for filtering game saves.
        /// </summary>
        private Memory SelectedRealTimeModItem { get; set; }

        private static DataTable DataTableRealTimeMods { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new("Game", typeof(string)),
                new("Mod Name", typeof(string)),
                new("Category", typeof(string)),
                new("Game Mode", typeof(string))
            });

        /// <summary>
        /// Load all game saves.
        /// </summary>
        public void LoadRealTimeMods()
        {
            if (PlatformType == PlatformPrefix.PS3 && !IsWebManInstalled)
            {
                handle = ShowOverlayFeatureNotAvailable(PageRealTimeMods, "You must have webMAN installed to use this feature.");
            }

            LoadRealTimeModsCategories();

            GridViewRealTimeMods.ShowLoadingPanel();

            DataTableRealTimeMods.Rows.Clear();

            foreach (ModsOffsets modsOffsets in Database.ModsOffsets.Mods.FindAll(x => x.GetPlatform() == PlatformType && x.GameId.ContainsIgnoreCase(FilterRealTimeModsGameId)))
            {
                Category category = Database.CategoriesData.GetCategoryById(modsOffsets.GameId);

                foreach (Memory memory in modsOffsets.Memory.FindAll(x => x.Name.ContainsIgnoreCase(FilterRealTimeModsName) && x.Category.ContainsIgnoreCase(FilterRealTimeModsCategory) && x.GameMode.ContainsIgnoreCase(FilterRealTimeModsGameMode)))
                {
                    DataTableRealTimeMods.Rows.Add(modsOffsets.Id,
                                               category.Title,
                                               memory.Name,
                                               memory.Category,
                                               memory.GameMode);
                }
            }

            GridControlRealTimeMods.DataSource = DataTableRealTimeMods;

            GridViewRealTimeMods.Columns[0].Visible = false;

            GridViewRealTimeMods.Columns[1].MinWidth = 232;
            GridViewRealTimeMods.Columns[1].MaxWidth = 232;

            //GridViewRealTimeMods.Columns[2].MinWidth = 180; //125

            GridViewRealTimeMods.Columns[3].MinWidth = 126;
            GridViewRealTimeMods.Columns[3].MaxWidth = 126;

            GridViewRealTimeMods.Columns[4].MinWidth = 85;
            GridViewRealTimeMods.Columns[4].MaxWidth = 85;

            GridViewRealTimeMods.HideLoadingPanel();
        }

        private void GridViewRealTimeMods_RowClick(object sender, RowClickEventArgs e)
        {
            int id = int.Parse(GridViewRealTimeMods.GetRowCellDisplayText(e.RowHandle, "Id"));
            string game = GridViewRealTimeMods.GetRowCellDisplayText(e.RowHandle, "Game");
            string modName = GridViewRealTimeMods.GetRowCellDisplayText(e.RowHandle, "Mod Name");
            string category = GridViewRealTimeMods.GetRowCellDisplayText(e.RowHandle, "Category");
            string gameMode = GridViewRealTimeMods.GetRowCellDisplayText(e.RowHandle, "Game Mode");

            ShowRealTimeModInfo(id, Database.CategoriesData.GetCategoryByTitle(game).Id, modName, category, gameMode);
        }

        private void ImageCloseRealTimeModsInfo_Click(object sender, EventArgs e)
        {
            FlyoutPanelRealTimeMods.HidePopup();
        }

        #endregion

        #region Show mods item's details

        private void ShowDetails(string platform, int modId)
        {
            PlatformPrefix Platform = platform.DehumanizeTo<PlatformPrefix>();

            if (Platform == PlatformPrefix.PS3)
            {
                ModItemData modItem = Database.ModsPS3.GetModById(PlatformPrefix.PS3, modId);

                if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
                {
                    ShowGameModDetails(modId);
                }
                else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
                {
                    ShowHomebrewDetails(modId);
                }
                else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Resource)
                {
                    ShowResourceDetails(modId);
                }
                else
                {
                    if (Database.GameSaves.GameSaves.Exists(x => x.GetPlatform() == Platform && x.Id.Equals(modId)))
                    {
                        ShowGameSaveDetails(Platform, modId);
                    }
                }
            }
            else if (Platform == PlatformPrefix.XBOX)
            {
                ModItemData modItem = Database.PluginsXBOX.GetModById(PlatformPrefix.XBOX, modId);

                if (modItem.ModType == "XEX")
                {
                    ShowPluginDetails(modId);
                }
                else
                {
                    if (Database.GameSaves.GameSaves.Exists(x => x.GetPlatform() == Platform && x.Id.Equals(modId)))
                    {
                        ShowGameSaveDetails(Platform, modId);
                    }
                }
            }
        }

        /// <summary>
        /// Set the UI with the mod details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.ModItem.Id" /> </param>
        private void ShowGameModDetails(int modId)
        {
            ModItemData modItem = Database.ModsPS3.GetModById(PlatformPrefix.PS3, modId);

            switch (modItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, PlatformType, Database.CategoriesData, modItem);
        }

        /// <summary>
        /// Set the UI with the mod details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.ModItem.Id" /> </param>
        private void ShowHomebrewDetails(int modId)
        {
            ModItemData modItem = Database.ModsPS3.GetModById(PlatformPrefix.PS3, modId);

            switch (modItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, PlatformType, Database.CategoriesData, modItem);
        }

        /// <summary>
        /// Set the UI with the mod details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.ModItem.Id" /> </param>
        private void ShowResourceDetails(int modId)
        {
            ModItemData modItem = Database.ModsPS3.GetModById(PlatformPrefix.PS3, modId);

            switch (modItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, PlatformType, Database.CategoriesData, modItem);
        }

        /// <summary>
        /// Set the UI with the package details and show the flyout panel.
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
        /// Set the UI with the plugin details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the Id of <see cref="ModItemData" /> </param>
        private void ShowPluginDetails(int modId)
        {
            ModItemData modItem = Database.PluginsXBOX.GetModById(PlatformPrefix.XBOX, modId);

            switch (modItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, PlatformType, Database.CategoriesData, modItem);
        }

        /// <summary>
        /// Set the UI with the game save details and show the flyout panel.
        /// </summary>
        /// <param name="consoleType"> Specifies the <see cref="PlatformPrefix" /> </param>
        /// <param name="id"> Specifies the <see cref="GameSaveItemData.Id" /> </param>
        private void ShowGameSaveDetails(PlatformPrefix consoleType, int id)
        {
            GameSaveItemData gameSaveItem = Database.GameSaves.GetModById(consoleType, id);

            switch (gameSaveItem)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemGameSaveDetailsDialog(this, gameSaveItem);
        }

        /// <summary>
        /// Set the UI with the real time mod details and show the flyout panel.
        /// </summary>
        /// <param name="id"> Specifies the <see cref="ModsOffsets.Id" /> </param>
        private void ShowRealTimeModInfo(int id, string gameId, string modName, string category, string gameMode)
        {
            ModsOffsets realTimeModInfo = Database.ModsOffsets.Mods.FirstOrDefault(x => x.Id == id && x.GetPlatform() == PlatformType && x.GameId.EqualsIgnoreCase(gameId));
            Memory memory = realTimeModInfo.Memory.FirstOrDefault(x => x.Name.Equals(modName) && x.Category.Equals(category) && x.GameMode.Equals(gameMode));
            List<Offset> offsets = memory.Offsets;

            switch (realTimeModInfo)
            {
                case null:
                    return;
            }

            // Set the selected mod item property
            SelectedRealTimeModItem = memory;

            // Display details in UI
            LabelRealTimeModsGameTitle.Text = Database.CategoriesData.GetCategoryById(realTimeModInfo.GameId).Title;
            LabelRealTimeModsGameVersion.Text = realTimeModInfo.GameVersion;
            LabelRealTimeModsCategory.Text = memory.Category;
            LabelRealTimeModsName.Text = memory.Name.Replace("&", "&&");
            LabelRealTimeModsGameMode.Text = memory.GameMode.Replace("&", "&&");
            LabelRealTimeModsDescription.Text = string.IsNullOrWhiteSpace(memory.Description)
                ? "No other details for this yet."
                : memory.Description.Replace("&", "&&");

            ButtonRealTimeModsSetValue.Visible = !memory.Toggleable;
            ButtonRealTimeModsEnable.Visible = memory.Toggleable;
            ButtonRealTimeModsDisable.Visible = memory.Toggleable;

            ButtonRealTimeModsSetValue.Enabled = IsConsoleConnected;
            ButtonRealTimeModsEnable.Enabled = IsConsoleConnected;
            ButtonRealTimeModsDisable.Enabled = IsConsoleConnected;

            FlyoutPanelRealTimeMods.ShowPopup();
        }

        #endregion

        #region Install, Uninstall, Download & Favorite Functions

        private void UpdateModsRowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewGameMods.RowCount; i++)
            {
                if ((int)GridViewGameMods.GetRowCellValue(i, GridViewGameMods.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewGameMods.SetRowCellValue(i, "Status", text);
                        }));
                    }
                    else
                    {
                        GridViewGameMods.SetRowCellValue(i, "Status", text);
                    }
                    break;
                }
            }
        }

        private void UpdateHomebrewRowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewHomebrew.RowCount; i++)
            {
                if ((int)GridViewHomebrew.GetRowCellValue(i, GridViewHomebrew.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewHomebrew.SetRowCellValue(i, "Status", text);
                        }));
                    }
                    else
                    {
                        GridViewHomebrew.SetRowCellValue(i, "Status", text);
                    }
                    break;
                }
            }
        }

        private void UpdateResourcesRowStatus(int modId, string text)
        {
            for (int i = 0; i < GridViewResources.RowCount; i++)
            {
                if ((int)GridViewResources.GetRowCellValue(i, GridViewResources.Columns[0]) == modId)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            GridViewResources.SetRowCellValue(i, "Status", text);
                        }));
                    }
                    else
                    {
                        GridViewResources.SetRowCellValue(i, "Status", text);
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
                            GridViewPackages.SetRowCellValue(i, "Status", text);
                        }));
                    }
                    else
                    {
                        GridViewPackages.SetRowCellValue(i, "Status", text);
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
                            GridViewGameSaves.SetRowCellValue(i, "Status", text);
                        }));
                    }
                    else
                    {
                        GridViewGameSaves.SetRowCellValue(i, "Status", text);
                    }
                    break;
                }
            }
        }

        public void ShowTransferModsDialog(Form owner, TransferType transferType, ModItemData modItem, string region = "")
        {
            UpdateModsRowStatus(modItem.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("Downloading...") :transferType == TransferType.InstallMods ? ResourceLanguage.GetString("Installing...") : ResourceLanguage.GetString("Uninstalling..."));

            DialogExtensions.ShowTransferModsDialog(owner, transferType, Database.CategoriesData.GetCategoryById(modItem.CategoryId), modItem, region);
            UpdateModsRowStatus(modItem.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("Downloaded") :transferType == TransferType.InstallMods ? ResourceLanguage.GetString("Installed") : ResourceLanguage.GetString("Not Installed"));
            LoadInstalledMods();
            LoadDownloads();
        }

        public void ShowTransferPackageFileDialog(Form owner, TransferType transferType, PackageItemData packageItem)
        {
            UpdatePackagesRowStatus(packageItem.Url, transferType == TransferType.DownloadPackage ? ResourceLanguage.GetString("Downloading") + "..." : transferType == TransferType.InstallPackage ? ResourceLanguage.GetString("Installing...") : ResourceLanguage.GetString("Uninstalling..."));

            DialogExtensions.ShowTransferPackagesDialog(owner, transferType, packageItem);
            UpdatePackagesRowStatus(packageItem.Url, transferType == TransferType.DownloadPackage ? ResourceLanguage.GetString("Downloaded") :transferType == TransferType.InstallPackage ? ResourceLanguage.GetString("Installed") : ResourceLanguage.GetString("Not Installed"));
            LoadDownloads();
        }

        public void ShowTransferGameSavesFileDialog(Form owner, TransferType transferType, GameSaveItemData gameSaveItem)
        {
            UpdateGameSavesRowStatus(gameSaveItem.Id, transferType == TransferType.DownloadGameSave ? ResourceLanguage.GetString("Downloading...") :ResourceLanguage.GetString("Installing..."));

            DialogExtensions.ShowTransferGameSavesDialog(owner, transferType, Database.CategoriesData.GetCategoryById(gameSaveItem.CategoryId), gameSaveItem);
            UpdateGameSavesRowStatus(gameSaveItem.Id, transferType == TransferType.DownloadGameSave ? ResourceLanguage.GetString("Downloaded") :ResourceLanguage.GetString("Installed"));
        }

        /// <summary>
        /// Download the modded files archive to the user's specified path.
        /// </summary>
        /// <param name="modItem"> </param>
        private void DownloadModArchive(ModItemData modItem)
        {
            Category category = Database.CategoriesData.GetCategoryById(modItem.CategoryId);
            string categoryTitle = category.Title;

            DownloadFiles download;

            try
            {
                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.ModType}) - Downloading archive...");

                download = modItem.GetDownloadFiles(this);

                switch (download)
                {
                    case null:
                        SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.ModType}) - Download archive cancelled.");
                        return;
                }

                string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the archive.");

                if (folderPath != null)
                {
                    modItem.DownloadArchiveAtPath(Database.CategoriesData, download, folderPath);
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.ModType}) - Successfully downloaded archive at path: {folderPath}");
                    Process.Start(folderPath);
                }
                else
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.ModType}) - Download archive cancelled.");
                }

                LoadDownloads();
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download archive {categoryTitle}: {modItem.Name} ({modItem.Id}). {ResourceLanguage.GetString("Error")}: {ex.Message}", ex);
                XtraMessageBox.Show(this,
                    "An error occurred downloading files archive. (Access maybe denied at this path, try a different folder). See log file for more information about this issue." +
                    $"\n{ResourceLanguage.GetString("Error")}: " + ex.Message, "Unable to Download Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adds or removes the specified <see cref="ModItemData" /> to the users favorites list.
        /// </summary>
        /// <param name="modItem"> </param>
        private void FavoriteMod(ModItemData modItem)
        {
            Category category = Database.CategoriesData.GetCategoryById(modItem.CategoryId);

            string categoryTitle = category.Title;

            List<int> favoritesList = Settings.FavoriteIds.FirstOrDefault(x => x.Platform == PlatformType).Ids;

            if (Settings.FavoriteIds.Any(x => x.Ids.Contains(modItem.Id)))
            {
                Settings.FavoriteIds.FirstOrDefault(x => x.Platform == PlatformType).Ids.Remove(modItem.Id);

                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.ModType}) - Removed from favorites list.");
            }
            else
            {
                Settings.FavoriteIds.FirstOrDefault(x => x.Platform == PlatformType).Ids.Add(modItem.Id);

                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.ModType}) - Added to favorites list.");
            }
        }

        #endregion

        /// <summary>
        /// Enable or disable console-only actions.
        /// </summary>
        private void EnableConsoleActions()
        {
#if !DEBUG
            NavigationItemGameMods.Visible = PlatformType == PlatformPrefix.PS3;
            NavigationItemHomebrew.Visible = PlatformType == PlatformPrefix.PS3;
            NavigationItemResources.Visible = PlatformType == PlatformPrefix.PS3;
            NavigationItemPackages.Visible = PlatformType == PlatformPrefix.PS3;
            NavigationItemPlugins.Visible = PlatformType == PlatformPrefix.XBOX;
#endif

            TileItemScanForXboxConsoles.Visible = PlatformType == PlatformPrefix.XBOX;
            SearchGameSaves();

            // PS3 Features

            MenuItemPS3GameBackupFiles.Visibility =
                PlatformType == PlatformPrefix.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemPS3GameBackupFiles.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.PS3;

            MenuItemPS3GameUpdateFinder.Visibility =
                PlatformType == PlatformPrefix.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemPS3GameUpdateFinder.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.PS3;

            MenuItemPS3ConsoleManager.Visibility =
                PlatformType == PlatformPrefix.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemPS3ConsoleManager.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.PS3;

            MenuItemPS3PackageManager.Visibility =
                PlatformType == PlatformPrefix.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemPS3PackageManager.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.PS3;

            MenuItemPS3WebManControls.Visibility =
                PlatformType == PlatformPrefix.PS3
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemPS3WebManControls.Enabled = IsConsoleConnected && IsWebManInstalled && PlatformType == PlatformPrefix.PS3;

            TileItemToolsGameBackupFiles.Visible = PlatformType == PlatformPrefix.PS3;
            TileItemToolsGameUpdateFinder.Visible = PlatformType == PlatformPrefix.PS3;
            TileItemToolsPackageManager.Visible = PlatformType == PlatformPrefix.PS3;
            TileItemToolsConsoleManager.Visible = PlatformType == PlatformPrefix.PS3;
            TileItemToolsCustomizeGameRegions.Visible = PlatformType == PlatformPrefix.PS3;


            // Xbox Features

            MenuItemXboxPluginsEditor.Visibility =
                PlatformType == PlatformPrefix.XBOX
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemXboxPluginsEditor.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.XBOX;

            MenuItemXboxGameLauncher.Visibility =
                PlatformType == PlatformPrefix.XBOX
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemXboxGameLauncher.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.XBOX;

            MenuItemXboxGameSaveResigner.Visibility =
                PlatformType == PlatformPrefix.XBOX ||
                Settings.StartupLibrary == PlatformPrefix.XBOX
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;

            MenuItemXboxXBDMControls.Visibility =
                PlatformType == PlatformPrefix.XBOX
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
            MenuItemXboxXBDMControls.Enabled = IsConsoleConnected && PlatformType == PlatformPrefix.XBOX;

            TileItemToolsGameSaveResigner.Visible = PlatformType == PlatformPrefix.XBOX;
            TileItemToolsGameLauncher.Visible = PlatformType == PlatformPrefix.XBOX;
            TileItemToolsLaunchFileEditor.Visible = PlatformType == PlatformPrefix.XBOX;
        }

        /// <summary>
        /// Set the current connected console status in the tool strip.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            StatusLabelConnectedConsole.Caption = consoleProfile == null ? "Idle" : consoleProfile.ToString();
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
                    XtraMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// Load the users settings data.
        /// </summary>
        public void LoadApplicationSettings()
        {
            try
            {
                SetStatus("Loading application settings data...");

                if (!File.Exists(UserFolders.SettingsData))
                {
                    using (StreamWriter streamWriter = new(UserFolders.SettingsData))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(Settings));
                    }

                    SetStatus("Settings data doesn't exist, a new one has been created.");
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

                    SetStatus("Backup files data doesn't exist, a new one has been created.");
                }

                using (StreamReader streamReader = new(UserFolders.BackupFilesData))
                {
                    BackupFiles = JsonConvert.DeserializeObject<BackupFilesData>(streamReader.ReadToEnd());
                }

                if (Settings.EnableHardwareAcceleration)
                {
                    WindowsFormsSettings.ForceDirectXPaint();
                }

                SetStatus("Successfully loaded application settings data.");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to load application settings data. {ResourceLanguage.GetString("Error")}: {ex.Message}", ex);
                XtraMessageBox.Show(this, $"There is a problem loading the application settings data.\n\n{ResourceLanguage.GetString("Error")}: " + ex.Message, ResourceLanguage.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save the users settings data.
        /// </summary>
        public void SaveApplicationSettings()
        {
            try
            {
                SetStatus("Saving application settings data...");

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

                SetStatus("Successfully saved application settings data.");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to save application data. {ResourceLanguage.GetString("Error")}: {ex.Message}", ex);
                XtraMessageBox.Show(this, $"There is a problem saving the application settings data.\n\n{ResourceLanguage.GetString("Error")}: " + ex.Message, ResourceLanguage.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (elem != null) return elem;
            return CommonSkins.GetSkin(lookAndFeel.ActiveLookAndFeel)[CommonSkins.SkinLabelLine];
        }

        protected void DrawSeparator(GraphicsCache cache, AccordionElementBaseViewInfo elementInfo)
        {
            SkinElement skinElem = GetSeparatorSkinElement(elementInfo.ControlInfo.LookAndFeel);
            Rectangle rect = new(elementInfo.HeaderBounds.X, elementInfo.HeaderBounds.Bottom - skinElem.Size.MinSize.Height + 2, elementInfo.HeaderBounds.Width, skinElem.Size.MinSize.Height + 3);
            SkinElementInfo skinElemInfo = new(skinElem, rect);
            ObjectPainter.DrawObject(cache, SkinElementPainter.Default, skinElemInfo);
        }

        private void GridViewInstalledMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Platform")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewDownloads_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Platform")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewGameMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Category")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewHomebrew_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Category")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewResources_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Category")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewPackages_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Category")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewPlugins_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Category")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewGameSaves_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Category")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewRealTimeMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Game")
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void ButtonAttachGame_Click(object sender, EventArgs e)
        {
            //var filePath = @"D:\Documents\Mods\PS3\Eboots\Modern Warfare 2\Normal Debug [EBOOT]\EBOOT.BIN";
            //var filePath = @"D:\Documents\Mods\XBOX 360\Plugins\Call of Duty Ghosts\Velonia v1.0.1\Velonia.xex";
            //var source = new FileByteProvider(filePath);
            ////new DynamicByteProvider(byte[]
            //HexBoxViewer.ByteProvider = source;

            if (PlatformType == PlatformPrefix.PS3)
            {
                if (IsWebManInstalled)
                {
                    PS3API = new(SelectAPI.PS3Manager);

                    if (PS3API.PS3MAPI.ConnectTarget(ConsoleProfile.Address))
                    {
                        if (PS3API.PS3MAPI.AttachProcess())
                        {
                            XtraMessageBox.Show(this, $"Successfully attached to process.", ResourceLanguage.GetString("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, $"You must have webMAN installed to use this feature.", ResourceLanguage.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (PlatformType == PlatformPrefix.XBOX)
            {

            }
        }
    }
}