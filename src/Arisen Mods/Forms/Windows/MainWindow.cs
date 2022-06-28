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
using ArisenMods.Constants;
using ArisenMods.Controls;
using ArisenMods.Database;
using ArisenMods.Extensions;
using ArisenMods.Io;
using ArisenMods.Models.Database;
using ArisenMods.Models.Release_Data;
using ArisenMods.Models.Resources;
using Newtonsoft.Json;
using PS3Lib;
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
using FtpExtensions = ArisenMods.Extensions.FtpExtensions;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace ArisenMods.Forms.Windows
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
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
        }

        /// <summary>
        /// Get the current language resources.
        /// </summary>
        public static ResourceManager ResourceLanguage { get; set; } = new ResourceManager("ArisenMods.Languages.en_US", Assembly.GetExecutingAssembly());

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
        //{
        //    get
        //    {
        //        return ConsoleProfile;
        //    }

        //    set
        //    {
        //        ConsoleProfile = value;
        //        ribbonControl1.ApplicationButtonText = ConsoleProfile.Name;
        //    }
        //}

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
        public static PS3API Ps3Api { get; private set; }

        /// <summary>
        /// Determines whether webMAN is installed on the console.
        /// </summary>
        public static bool IsWebManInstalled { get; private set; }

        /// <summary>
        /// Get the colors for the current skin.
        /// </summary>
        public static SkinColors SkinColors { get; private set; }

        /// <summary>
        /// Form loading event.
        /// </summary>
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            Enabled = false;

            SuppressFormShadowShowing();

            UserLookAndFeel.Default.StyleChanged += MainWindow_StyleChanged;
            WindowsFormsSettings.AllowHoverAnimation = DefaultBoolean.True;

            SplashScreenManager.ShowSkinSplashScreen(
                $"Arisen Mods",
                "Browse, Download and Install Mods\nfor PlayStation 3 && Xbox 360",
                "Copyright © 2022\nAll Rights Reserved.",
                "Initializing...",
                this);

            Text = $@"Arisen Mods [{UpdateExtensions.CurrentVersionName}]";

            LoadApplicationSettings();

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
                await Task.Run(async () => await LoadDataAsync().ConfigureAwait(true));
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
                DiscordClient.ClearPresence();
                DiscordClient.Deinitialize();
                DiscordClient.Dispose();
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
                                Settings.LocalPathPs3 = TextBoxFileManagerLocalPath.Text;
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
                                Settings.ConsolePathPs3 = TextBoxFileManagerConsolePath.Text;
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
                        case Platform.XBOX360:
                            XboxConsole.CloseConnection(0);
                            break;
                    }
                }
                catch
                {
                    // false positive; the console might be powered off
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
                Database = await GitHubData.InitializeAsync().ConfigureAwait(true);
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
            Enabled = true;
            WindowState = Settings.WindowState;

            SetStatus(ResourceLanguage.GetString("SUCCESS_LOADED_DB"));

            foreach (string firmwareType in Database.GameModsPs3.AllFirmwareTypes.Where(firmwareType => !ComboBoxGameModsFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxGameModsFilterSystemType.Properties.Items.Add(firmwareType);
            }

            foreach (string firmwareType in Database.HomebrewPs3.AllFirmwareTypes.Where(firmwareType => !ComboBoxHomebrewFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxHomebrewFilterSystemType.Properties.Items.Add(firmwareType);
            }

            foreach (string firmwareType in Database.ResourcesPs3.AllFirmwareTypes.Where(firmwareType => !ComboBoxResourcesFilterSystemType.Properties.Items.Contains(firmwareType)))
            {
                ComboBoxResourcesFilterSystemType.Properties.Items.Add(firmwareType);
            }

            SetStatus($"{ResourceLanguage.GetString("INITIALIZED")} Arisen Mods ({UpdateExtensions.CurrentVersionName}) - {ResourceLanguage.GetString("READY_TO_CONNECT")}");

            // Settings tab
            LoadLanguages();
            LoadSettings();

            // Dashboard tab
            LoadStatistics();
            LoadChangeLog();
            LoadAnnouncements();
            LoadNewsFeed();

            // Downloads tab
            LoadDownloads();

            // Installed Mods tab
            LoadInstalledMods();

            if (Settings.Language != "English")
            {
                ChangeLanguage(Settings.Language);
            }

            SetAboutInfo();

            SplashScreenManager.CloseForm();
            CreateFormShadow();
            Opacity = 1;
            BringToFront();

            PageDashboard.AutoScroll = true;

            EnableConsoleActions();
            UpdateControlColors();
            Focus();

            NavigationMenu.SelectElement(NavigationItemDashboard);

            SetConsoleProfile();
            LoadOurFavoriteMods();
            LoadRecentlyUpdated();

#if !DEBUG
            if (ConsoleProfile.Platform == Platform.PS3)
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
        }

        private void SetConsoleProfile()
        {
            if (Settings.ConsoleProfiles.Count() == 0)
            {
                ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

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
                XtraMessageBox.Show(this, "You must have one console profile set as default.", ResourceLanguage.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogExtensions.ShowEditConnectionsDialog(this, true);

                SetConsoleProfile();

                //if (defaultProfile == null)
                //{
                //    SetConsoleProfile();
                //}
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

        private IOverlaySplashScreenHandle HandleOverlayRequiresWebMan = null;

        private void CloseOverlayRequiresWebMan(NavigationPage page, IOverlaySplashScreenHandle handle)
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
            Extensions.Helpers.ScanForXboxConsoles(this);
            SetStatus(ResourceLanguage.GetString("SCANNING_XBOX_FINISHED"));
        }

        private void ButtonEditConsoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowEditConnectionsDialog(this, true);
        }

        private void ButtonHowToGuides_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(this, "Our How-To-Guides have been moved to our Discord server.", "How-To Guides", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(Urls.DiscordServer);
        }

        private void ButtonDownloadsFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetDownloadsLocation();
        }

        private void ButtonDiscordPresence_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (ButtonDiscordPresence.Checked)
            {
                Settings.AlwaysShowPresence = true;
                EnableDiscordRpc();
            }
            else
            {
                Settings.AlwaysShowPresence = false;
                DisableDiscordRpc();
            }
        }

        private void ButtonInstallModsToUSB_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Settings.InstallGameModsPluginsToUsbDevice = ButtonInstallModsToUSB.Checked;
        }

        private void ButtonAdvancedSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            NavigationMenu.SelectElement(NavigationItemSettings);
            NavigationFrame.SelectedPage = PageSettings;
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
            SetStatus("WebMAN Controls - Shutting Down Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Shutdown);
            SetStatus("WebMAN Controls - Successfully Shutdown Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Restarting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Restart);
            SetStatus("WebMAN Controls - Successfully Restarted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerSoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Soft Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.SoftReboot);
            SetStatus("WebMAN Controls - Successfully Soft Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerHardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Hard Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.HardReboot);
            SetStatus("WebMAN Controls - Successfully Hard Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsPowerQuickReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Quick Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.QuickReboot);
            SetStatus("WebMAN Controls - Successfully Quick Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonToolsPsGamesMountBD_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (BD) list...");

            List<ListItem> games = FtpExtensions.GetGamesBd();

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

        private void ButtonToolsPsGamesMountISO_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (ISO) list...");

            List<ListItem> games = FtpExtensions.GetGamesIso();

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

        private void ButtonToolsPsGamesMountPSN_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games (PSN) list...");

            List<ListItem> games = FtpExtensions.GetGamesPsn();

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

        private void ButtonToolsPsGamesUnmount_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Unmounting Game...");
            WebManExtensions.Unmount(ConsoleProfile.Address);
            SetStatus("WebMAN Controls - Successfully Unmounted Game");
        }

        private void ButtonToolsPsNotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
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

        private void ButtonToolsPsVirtualController_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("WebMAN Controls - Virtual Controller: Opening in Web Browser");
            Process.Start("http://pad.aldostools.org/pad.html");
            SetStatus("WebMAN Controls - Virtual Controller: Opened in Web Browser");
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
                XtraMessageBox.Show($"Screenshot file saved to path:\n{filePath}", ResourceLanguage.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonToolsXboxConsoleManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxConsoleManager(this);
        }

        private void ButtonToolsXboxNotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, ResourceLanguage.GetString("NOTIFY_MESSAGE"), ResourceLanguage.GetString("MESSAGE"));

            List<string> notifyIcons = new();

            foreach (XNotifyLogo xNotifyIcon in Enum.GetValues(typeof(XNotifyLogo)) as XNotifyLogo[])
            {
                notifyIcons.Add(xNotifyIcon.Humanize());
            }

            string notifyIcon = DialogExtensions.ShowListItemDialog(this, ResourceLanguage.GetString("NOTIFY_ICON"), ResourceLanguage.GetString("ICON"), notifyIcons.ToArray());

            XboxConsole.XNotify(notifyMessage, notifyIcon.DehumanizeTo<XNotifyLogo>());
        }

        // Extra Menu (Top Right)

        private void MenuItemRequestMods_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowRequestModsDialog(this);
        }

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

        private void ButtonAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            NavigationMenu.SelectedElement = null;
            NavigationFrame.SelectedPage = PageAbout;
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
                SetStatus(string.Format(ResourceLanguage.GetString("CONNECTING_TO_CONSOLE"), $"{ConsoleProfile.Name} ({ConsoleProfile.Address})"));

                switch (ConsoleProfile.Platform)
                {
                    case Platform.PS3:
                        {
                            FtpClient = new FtpClient
                            {
                                Host = ConsoleProfile.Address,
                                Port = 21,
                                Credentials = ConsoleProfile.UseDefaultCredentials
                                ? new NetworkCredential("anonymous", "anonymous")
                                : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password),
                                SocketKeepAlive = true,
                                DataConnectionType = FtpDataConnectionType.PASV,
                                //ReadTimeout = -1,
                                //SslProtocols = System.Security.Authentication.SslProtocols.Tls12
                            };

                            FtpClient.Connect();

                            IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address);

                            switch (IsWebManInstalled)
                            {
                                case true:
                                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, ResourceLanguage.GetString("CONNECTED_NOTIFICATION"));
                                    break;
                            }

                            SetPlatform(ConsoleProfile.Platform);

                            break;
                        }
                    case Platform.XBOX360:
                        XboxManager = new XboxManager();

                        XboxConsole = ConsoleProfile.UseDefaultConsole
                            ? XboxManager.OpenConsole(XboxManager.DefaultConsole)
                            : XboxManager.OpenConsole(ConsoleProfile.Address);

                        SetPlatform(ConsoleProfile.Platform);

                        break;
                }

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

        private bool hasLoadedGameCheats = false;

        private void NavigationItemGameCheats_Click(object sender, EventArgs e)
        {
            NavigationFrame.SelectedPage = PageGameCheats;

            if (!hasLoadedGameCheats)
            {
                SearchGameCheats();
                hasLoadedGameCheats = true;
            }

            if (!IsConsoleConnected)
            {
                if (HandleOverlayRequiresWebMan == null)
                {
                    HandleOverlayRequiresWebMan = ShowOverlayFeatureNotAvailable(PageGameCheats, ResourceLanguage.GetString("YOU_MUST_BE_CONNECTED_TO_USE_FEATURE"));
                }
            }
            else
            {
                if (HandleOverlayRequiresWebMan != null)
                {
                    CloseOverlayRequiresWebMan(PageGameCheats, HandleOverlayRequiresWebMan);
                }

                if (!IsWebManInstalled)
                {
                    if (HandleOverlayRequiresWebMan == null)
                    {
                        HandleOverlayRequiresWebMan = ShowOverlayFeatureNotAvailable(PageGameCheats, ResourceLanguage.GetString("WEBMAN_REQUIRED"));
                    }
                }
                else
                {
                    if (HandleOverlayRequiresWebMan != null)
                    {
                        CloseOverlayRequiresWebMan(PageGameCheats, HandleOverlayRequiresWebMan);
                    }
                }
            }
        }

#endregion

    #region Dashboard Page

        private void LoadOurFavoriteMods()
        {
            //TileGroupOurFavoriteMods.Items.Clear();
            TileItemFavoriteMods.Visible = false;

            foreach (Models.Dashboard.FavoriteModsData.Favorite favorite in Database.FavoritesMods.Favorites)
            {
                if (favorite.GetPlatform() == ConsoleProfile.Platform)
                {
                    TileGroupOurFavoriteMods.Items.Add(FavoriteModsItem(favorite.GetPlatform(), favorite.CategoryId, favorite.ModId, favorite.Name));
                }
            }
        }

        private TileItem FavoriteModsItem(Platform platform, string categoryId, int modId, string modName)
        {
            TileItem tileItem = new();

            tileItem.TextAlignment = TileItemContentAlignment.TopLeft;
            tileItem.ItemSize = TileItemSize.Medium;

            tileItem.Elements.Assign(TileItemFavoriteMods.Elements);
            //tileItem.Elements.Add(new TileItemElement() { Text = Database.CategoriesData.GetCategoryById(categoryId).Title, AnchorAlignment = AnchorAlignment.Top, TextAlignment = TileItemContentAlignment.MiddleCenter, TextLocation = new Point(0, -20) });
            //tileItem.Elements.Add(new TileItemElement() { Text = modName, AnchorAlignment = AnchorAlignment.Bottom, AnchorElement = tileItem.Elements[0], AnchorIndent = 20, AnchorOffset = new Point(-2, 0), TextAlignment = TileItemContentAlignment.MiddleCenter });
            //tileItem.Elements.Add(new TileItemElement() { Text = platform.Humanize(), ColumnIndex = 2 });

            tileItem.Elements[0].Text = Database.CategoriesData.GetCategoryById(categoryId).Title;
            //tileItem.Elements[0].Appearance.Normal.Font = new Font("Segoe UI", 10.95F, FontStyle.Regular);
            //tileItem.Elements[0].Appearance.Normal.TextOptions.HAlignment = HorzAlignment.Center;
            //tileItem.Elements[0].Appearance.Normal.TextOptions.Trimming = Trimming.EllipsisCharacter;
            //tileItem.Elements[0].Appearance.Normal.TextOptions.WordWrap = WordWrap.Wrap;

            tileItem.Elements[1].Text = modName;
            //tileItem.Elements[1].Appearance.Normal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            //tileItem.Elements[1].Appearance.Normal.TextOptions.HAlignment = HorzAlignment.Center;
            //tileItem.Elements[1].Appearance.Normal.TextOptions.VAlignment = VertAlignment.Center;
            //tileItem.Elements[1].Appearance.Normal.TextOptions.Trimming = Trimming.EllipsisCharacter;
            //tileItem.Elements[1].Appearance.Normal.TextOptions.WordWrap = WordWrap.Wrap;

            tileItem.Tag = platform.Humanize() + "|" + modId.ToString();

            if (platform == Platform.PS3)
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
            Category category = Database.CategoriesData.GetCategoryByTitle(categoryTitle);
            string modName = tileItem.Elements[1].Text;
            Platform platform = tileItem.Tag.ToString().Split('|')[0].DehumanizeTo<Platform>();
            int modId = int.Parse(tileItem.Tag.ToString().Split('|')[1]);

            if (platform == Platform.PS3)
            {
                ShowDetails(platform, categoryTitle, modId);

                //if (category.CategoryType == CategoryType.Game)
                //{
                //    //NavigationFrame.SelectedPage = PageGameMods;
                //    //NavigationMenu.SelectElement(NavigationItemGameMods);
                //    //ComboBoxGameModsFilterGame.SelectedItem = category.Title;
                //    //SearchGameMods();
                //}
            }
            else if (platform == Platform.XBOX360)
            {
                ShowDetails(platform, categoryTitle, modId);

                //if (category.CategoryType == CategoryType.Game)
                //{
                //    //NavigationFrame.SelectedPage = PageGameMods;
                //    //NavigationMenu.SelectElement(NavigationItemGameMods);
                //    //ComboBoxGameModsFilterGame.SelectedItem = category.Title;
                //    //SearchGameMods();
                //}
            }
        }

        private void LoadRecentlyUpdated()
        {
            TileItemRecentlyUpdated.Visible = false;

            foreach (ModItemData item in Database.GameModsPs3.Mods.OrderBy(x => x.LastUpdated).ToList().Take(3))
            {
                TileGroupRecentlyUpdated.Items.Add(RecentlyUpdatedItem(item.GetPlatform(), item.CategoryId, item.Id, item.Name));
            }

            foreach (ModItemData item in Database.HomebrewPs3.Mods.OrderBy(x => x.LastUpdated).ToList().Take(3))
            {
                TileGroupRecentlyUpdated.Items.Add(RecentlyUpdatedItem(item.GetPlatform(), item.CategoryId, item.Id, item.Name));
            }
        }

        private TileItem RecentlyUpdatedItem(Platform platform, string categoryId, int modId, string modName)
        {
            Category category = Database.CategoriesData.GetCategoryById(categoryId);

            TileItem tileItem = new();

            tileItem.TextAlignment = TileItemContentAlignment.TopLeft;
            tileItem.ItemSize = TileItemSize.Medium;

            tileItem.Elements.Assign(TileItemRecentlyUpdated.Elements);

            tileItem.Elements[0].Text = Database.CategoriesData.GetCategoryById(categoryId).Title;
            tileItem.Elements[1].Text = modName;

            tileItem.Tag = platform.Humanize() + "|" + modId.ToString();

            tileItem.AppearanceItem.Normal.BackColor = Color.Coral;
            tileItem.AppearanceItem.Normal.BorderColor = Color.Coral;

            tileItem.ItemClick += RecentlyUpdatedItem_Click;

            return tileItem;
        }

        private void RecentlyUpdatedItem_Click(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = sender as TileItem;
            string categoryTitle = tileItem.Elements[0].Text;
            Category category = Database.CategoriesData.GetCategoryByTitle(categoryTitle);
            string modName = tileItem.Elements[1].Text;
            Platform platform = tileItem.Tag.ToString().Split('|')[0].DehumanizeTo<Platform>();
            int modId = int.Parse(tileItem.Tag.ToString().Split('|')[1]);

            if (platform == Platform.PS3)
            {
                ShowDetails(platform, categoryTitle, modId);

                //if (category.CategoryType == CategoryType.Game)
                //{
                //    //NavigationFrame.SelectedPage = PageGameMods;
                //    //NavigationMenu.SelectElement(NavigationItemGameMods);
                //    //ComboBoxGameModsFilterGame.SelectedItem = category.Title;
                //    //SearchGameMods();
                //}
            }
            else if (platform == Platform.XBOX360)
            {
                ShowDetails(platform, categoryTitle, modId);

                //if (category.CategoryType == CategoryType.Game)
                //{
                //    //NavigationFrame.SelectedPage = PageGameMods;
                //    //NavigationMenu.SelectElement(NavigationItemGameMods);
                //    //ComboBoxGameModsFilterGame.SelectedItem = category.Title;
                //    //SearchGameMods();
                //}
            }
        }

        private void LoadStatistics()
        {
            LabelHeaderStatistics.Text = ResourceLanguage.GetString("TITLE_STATISTICS");

            LabelStatisticsPlayStation3.Text =
                $"{Database.GameModsPs3.Mods.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Game).Count:N0} {ResourceLanguage.GetString("LABEL_GAME_MODS")}\n" +
                $"{Database.HomebrewPs3.Mods.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew).Count:N0} {ResourceLanguage.GetString("LABEL_HOMEBREW")}\n" +
                $"{Database.ResourcesPs3.Mods.FindAll(x => x.GetCategoryType(Database.CategoriesData) == CategoryType.Resource).Count:N0} {ResourceLanguage.GetString("LABEL_RESOURCES")}\n" +
                $"{Database.PackagesCount():N0} {ResourceLanguage.GetString("LABEL_PACKAGES")}\n" +
                $"{Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == Platform.PS3).ToList().Count:N0} {ResourceLanguage.GetString("LABEL_GAME_SAVES")}\n" +
                $"{Database.GameCheatsPs3.GetTotalCheats():N0} {ResourceLanguage.GetString("LABEL_GAME_CHEATS")}";

            LabelStatisticsXbox360.Text =
                $"{Database.PluginsXbox.Mods.Count:N0} {ResourceLanguage.GetString("LABEL_PLUGINS")}\n" +
                $"{Database.GameSaves.GameSaves.Where(x => x.GetPlatform() == Platform.XBOX360).ToList().Count:N0} {ResourceLanguage.GetString("LABEL_GAME_SAVES")}\n" +
                $"{Database.GameCheatsXbox.GetTotalCheats():N0} {ResourceLanguage.GetString("LABEL_GAME_CHEATS")}";

            LabelStatisticsLastUpdated.Text = $"{ResourceLanguage.GetString("LAST_UPDATED")}: {Database.CategoriesData.LastUpdated.ToLocalTime().ToShortDateString()}";
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

        private int ChangeLogsCurrent;
        private int ChangeLogsMaximum;

        private void LoadChangeLog()
        {
            ChangeLogsCurrent = 0;
            ChangeLogsMaximum = UpdateExtensions.AllReleases.Count();

            GitHubReleaseData gitHubData = UpdateExtensions.AllReleases[0];

            LabelChangeLogVersion.Text = $"{gitHubData.Name} ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = gitHubData.Body.Replace("- ", "• ");
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

        // Change Log

        private static List<GitHubReleaseData> GitHubAllReleases { get; set; } = UpdateExtensions.AllReleases;

        private void ButtonChangeLogPrevious_Click(object sender, EventArgs e)
        {
            ChangeLogsCurrent++;

            GitHubReleaseData gitHubData = GitHubAllReleases[ChangeLogsCurrent];

            string releaseBody = gitHubData.Body.Substring(0, gitHubData.Body.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

            LabelChangeLogVersion.Text = $"{gitHubData.Name} ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = releaseBody.Replace("- ", "• ");

            ButtonChangeLogPrevious.Enabled = ChangeLogsCurrent != ChangeLogsMaximum - 1;
            ButtonChangeLogNext.Enabled = ChangeLogsCurrent != 0;
        }

        private void ButtonChangeLogNext_Click(object sender, EventArgs e)
        {
            ChangeLogsCurrent--;

            GitHubReleaseData gitHubData = GitHubAllReleases[ChangeLogsCurrent];

            string releaseBody = gitHubData.Body.Substring(0, gitHubData.Body.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

            LabelChangeLogVersion.Text = $"{gitHubData.Name} ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})";
            LabelChangeLog.Text = releaseBody.Replace("- ", "• ");

            ButtonChangeLogPrevious.Enabled = ChangeLogsCurrent != ChangeLogsMaximum;
            ButtonChangeLogNext.Enabled = ChangeLogsCurrent != 0;
        }

#endregion

    #region Downloads Page

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
            if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE_ITEM_DOWNLOADS"), ResourceLanguage.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                new("ModId", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_PLATFORM"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_DOWNLOADED_ON"), typeof(string))
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

                //ModItemData modItemData = downloadedItem.Platform == Platform.PS3
                //    ? Database.ModsPS3(Database).GetModById(downloadedItem.Platform, downloadedItem.ModId)
                //    : Database.PluginsXBOX.GetModById(downloadedItem.Platform, downloadedItem.ModId);

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
            }

            GridControlDownloads.DataSource = DataTableDownloads;

            GridViewDownloads.FocusedRowHandle = -1;

            GridViewDownloads.Columns[0].Visible = false;

            GridViewDownloads.Columns[1].MinWidth = 104;
            GridViewDownloads.Columns[1].MaxWidth = 104;

            GridViewDownloads.Columns[2].MinWidth = 226;
            GridViewDownloads.Columns[2].MaxWidth = 226;

            //GridViewDownloads.Columns[3].MinWidth = 100; // Ignore column

            GridViewDownloads.Columns[4].MinWidth = 116;
            GridViewDownloads.Columns[4].MaxWidth = 116;

            GridViewDownloads.Columns[5].MinWidth = 90;
            GridViewDownloads.Columns[5].MaxWidth = 90;

            GridViewDownloads.Columns[6].MinWidth = 68;
            GridViewDownloads.Columns[6].MaxWidth = 68;

            GridViewDownloads.Columns[7].MinWidth = 96;
            GridViewDownloads.Columns[7].MaxWidth = 96;

            TileItemDownloadsDeleteAllItems.Enabled = GridViewDownloads.RowCount > 0;
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

                //ModItemData modItemData = downloadedItem.Platform == Platform.PS3
                //    ? Database.ModsPS3(Database).GetModById(downloadedItem.Platform, downloadedItem.ModId)
                //    : Database.PluginsXBOX.GetModById(downloadedItem.Platform, downloadedItem.ModId);

                ModItemData modItemData = Database.GetModItem(downloadedItem.Platform, Database.CategoriesData.GetCategoryById(downloadedItem.CategoryId).CategoryType, downloadedItem.ModId);

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
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;

            GridViewDownloads.HideLoadingPanel();
        }

        private void GridViewDownloads_RowClick(object sender, RowClickEventArgs e)
        {
            TileItemDownloadsOpenFile.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;
        }

        private void GridViewDownloads_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            TileItemDownloadsOpenFile.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsDeleteItem.Enabled = GridViewDownloads.SelectedRowsCount > 0;
            TileItemDownloadsViewDetails.Enabled = GridViewDownloads.SelectedRowsCount > 0;
        }

#endregion

    #region Installed Mods Page

        private void TileItemInstalledModsDeleteItem_ItemClick(object sender, TileItemEventArgs e)
        {
            if (GridViewInstalledMods.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE"), ResourceLanguage.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int consoleId = int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[0]));
                    int modId = int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[1]));
                    Platform platform = GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[2]).DehumanizeTo<Platform>();

                    InstalledModInfo installedModInfo = Settings.ConsoleProfiles.Find(x => x.Platform == platform && x.Id == consoleId).InstalledMods.Find(x => x.ModId == modId);
                    Settings.ConsoleProfiles.Find(x => x.Platform == platform && x.Id == consoleId).InstalledMods.Remove(installedModInfo);
                    XtraMessageBox.Show(this, ResourceLanguage.GetString("DELETE_ITEM_SUCCESS"), ResourceLanguage.GetString("DELETED"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void TileItemInstalledModsDeleteAll_ItemClick(object sender, TileItemEventArgs e)
        {
            if (GridViewInstalledMods.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("CONFIRM_DELETE_ALL_ITEMS"), ResourceLanguage.GetString("CONFIRM_DELETE_ALL"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
                    {
                        consoleProfile.InstalledMods.Clear();
                    }
                }

                DataTableInstalledMods.Rows.Clear();
                XtraMessageBox.Show(this, ResourceLanguage.GetString("DELETE_ITEMS_SUCCESS"), ResourceLanguage.GetString("DELETED"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TileItemInstalledModsViewDetails_ItemClick(object sender, TileItemEventArgs e)
        {
            int modId = int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[1]));
            //Platform platform = GridViewInstalledMods.GetRowCellDisplayText(GridViewInstalledMods.FocusedRowHandle, ResourceLanguage.GetString("LABEL_PLATFORM")).DehumanizeTo<Platform>();
            Platform platform = GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[2]).DehumanizeTo<Platform>();
            string category = GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[3]);

            //ModItemData modItemData = platform == Platform.PS3
            //    ? Database.ModsPS3(Database).GetModById(platform, int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[1])))
            //    : Database.PluginsXBOX.GetModById(platform, int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[1])));

            ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryByTitle(category).CategoryType, modId);

            if (modItemData != null)
            {
                ShowDetails(modItemData.GetPlatform(), category, modItemData.Id);
            }
        }

        private void TileItemInstalledModsUninstallAll_ItemClick(object sender, TileItemEventArgs e)
        {
            foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
            {
                foreach (InstalledModInfo installedMod in consoleProfile.InstalledMods)
                {
                    if (!IsConsoleConnected && ConsoleProfile == null)
                    {
                        XtraMessageBox.Show(this, string.Format(ResourceLanguage.GetString("YOU_MUST_BE_CONNECTED_TO_UNINSTALL_FILES"), $"{consoleProfile.Name} ({consoleProfile.Platform.Humanize()})"), ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (IsConsoleConnected && ConsoleProfile.Id != consoleProfile.Id)
                    {
                        XtraMessageBox.Show(this, $"{ResourceLanguage.GetString("FILES_NOT_INSTALLED_TO_CONNECTED_CONSOLE")} {string.Format(ResourceLanguage.GetString("YOU_MUST_BE_CONNECTED_TO_UNINSTALL_FILES"), $"{consoleProfile.Name} ({consoleProfile.Platform.Humanize()})")}", ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //ModItemData modItemData = installedMod.Platform == Platform.PS3
                    //? Database.ModsPS3(Database).GetModById(installedMod.Platform, installedMod.ModId)
                    //: Database.PluginsXBOX.GetModById(installedMod.Platform, installedMod.ModId);

                    ModItemData modItemData = Database.GetModItem(installedMod.Platform, Database.CategoriesData.GetCategoryById(installedMod.CategoryId).CategoryType, installedMod.ModId);

                    InstalledModInfo installedModInfo = ConsoleProfile != null ? Settings.GetInstalledMods(consoleProfile, modItemData.CategoryId, modItemData.Id) : null;

                    ShowTransferModsDialog(this, TransferType.UninstallMods, modItemData, null, installedModInfo == null ? string.Empty : installedModInfo.DownloadFiles.Region);
                }
            }

            LoadInstalledMods();
        }

        private void TileItemInstalledModsUninstallSelected_ItemClick(object sender, TileItemEventArgs e)
        {
            if (GridViewInstalledMods.SelectedRowsCount > 0)
            {
                int consoleId = int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[0]));
                int modId = int.Parse(GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[1]));
                Platform platform = GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[2]).DehumanizeTo<Platform>();
                string category = GridViewInstalledMods.GetFocusedRowCellDisplayText(GridViewInstalledMods.Columns[3]);

                foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles.FindAll(x => x.Id == consoleId))
                {
                    foreach (InstalledModInfo installedModInfo in consoleProfile.InstalledMods)
                    {
                        if (!IsConsoleConnected && ConsoleProfile == null)
                        {
                            XtraMessageBox.Show(this, $"You must be connected to: {consoleProfile.Name} ({consoleProfile.Platform.Humanize()}) to uninstall the files.", ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (IsConsoleConnected && ConsoleProfile.Id != consoleProfile.Id)
                        {
                            XtraMessageBox.Show(this, $"These files weren't installed to the connected console. You must connect to: {consoleProfile.Name} ({consoleProfile.Platform.Humanize()}) to uninstall the files.", ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //ModItemData selectedmodItemData = platform == Platform.PS3
                        //    ? Database.ModsPS3(Database).GetModById(platform, modId)
                        //    : Database.PluginsXBOX.GetModById(platform, modId);

                        //ModItemData modItemData = platform == Platform.PS3
                        //    ? Database.ModsPS3(Database).GetModById(platform, installedModInfo.ModId)
                        //    : Database.PluginsXBOX.GetModById(platform, installedModInfo.ModId);

                        ModItemData selectedmodItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, modId);
                        ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                        if (modItemData.Id == selectedmodItemData.Id)
                        {
                            ShowTransferModsDialog(this, TransferType.UninstallMods, modItemData, null, installedModInfo == null ? string.Empty : installedModInfo.DownloadFiles.Region);
                            break;
                        }
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
                new("ConsoleId", typeof(int)),
                new("ModId", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_PLATFORM"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CREATOR"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_TOTAL_FILES"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_INSTALLED_ON"), typeof(string))
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

            foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
            {
                foreach (InstalledModInfo installedModInfo in consoleProfile.InstalledMods)
                {
                    Category modCategory = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                    //ModItemData modItemData = installedModInfo.Platform == Platform.PS3
                    //    ? Database.ModsPS3(Database).GetModById(installedModInfo.Platform, installedModInfo.ModId)
                    //    : Database.PluginsXBOX.GetModById(installedModInfo.Platform, installedModInfo.ModId);

                    ModItemData modItemData = Database.GetModItem(installedModInfo.Platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                    DataTableInstalledMods.Rows.Add(consoleProfile.Id,
                                                    modItemData.Id.ToString(),
                                                    installedModInfo.Platform.Humanize(),
                                                    modCategory.Title,
                                                    installedModInfo.DownloadFiles.Name,
                                                    modItemData.ModType,
                                                    installedModInfo.DownloadFiles.Region,
                                                    installedModInfo.DownloadFiles.Version,
                                                    modItemData.CreatedBy,
                                                    $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? $" {ResourceLanguage.GetString("FILES")}" : $" {ResourceLanguage.GetString("FILE")}")}",
                                                    Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");

                    totalFiles += installedModInfo.TotalFiles;
                }
            }

            GridControlInstalledMods.DataSource = DataTableInstalledMods;

            GridViewInstalledMods.FocusedRowHandle = -1;

            GridViewInstalledMods.Columns[0].Visible = false;
            GridViewInstalledMods.Columns[1].Visible = false;

            GridViewInstalledMods.Columns[2].MinWidth = 104;
            GridViewInstalledMods.Columns[2].MaxWidth = 104;

            GridViewInstalledMods.Columns[3].MinWidth = 226;
            GridViewInstalledMods.Columns[3].MaxWidth = 226;

            //GridViewInstalledMods.Columns[4].MinWidth = 80;
            //GridViewInstalledMods.Columns[4].MaxWidth = 80;

            GridViewInstalledMods.Columns[5].MinWidth = 116;
            GridViewInstalledMods.Columns[5].MaxWidth = 116;

            GridViewInstalledMods.Columns[6].MinWidth = 88;
            GridViewInstalledMods.Columns[6].MaxWidth = 88;

            GridViewInstalledMods.Columns[7].MinWidth = 70;
            GridViewInstalledMods.Columns[7].MaxWidth = 70;

            GridViewInstalledMods.Columns[8].MinWidth = 132;
            GridViewInstalledMods.Columns[8].MaxWidth = 132;

            GridViewInstalledMods.Columns[9].MinWidth = 76;
            GridViewInstalledMods.Columns[9].MaxWidth = 76;

            GridViewInstalledMods.Columns[10].MinWidth = 94;
            GridViewInstalledMods.Columns[10].MaxWidth = 94;

            //TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            //TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;

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

            foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
            {
                foreach (InstalledModInfo installedModInfo in consoleProfile.InstalledMods)
                {
                    Category modCategory = Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId);

                    //ModItemData modItemData = installedModInfo.Platform == Platform.PS3
                    //    ? Database.ModsPS3(Database).GetModById(installedModInfo.Platform, installedModInfo.ModId)
                    //    : Database.PluginsXBOX.GetModById(installedModInfo.Platform, installedModInfo.ModId);

                    ModItemData modItemData = Database.GetModItem(installedModInfo.Platform, Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

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
                                                        modCategory.Title,
                                                        installedModInfo.DownloadFiles.Name,
                                                        modItemData.ModType,
                                                        installedModInfo.DownloadFiles.Region,
                                                        installedModInfo.DownloadFiles.Version,
                                                        modItemData.CreatedBy,
                                                        $"{installedModInfo.TotalFiles}{(installedModInfo.TotalFiles > 1 ? $" {ResourceLanguage.GetString("FILES")}" : $" {ResourceLanguage.GetString("FILE")}")}",
                                                        Settings.UseRelativeTimes ? installedModInfo.DateInstalled.Humanize() : $"{installedModInfo.DateInstalled:g}");

                        totalFiles += installedModInfo.TotalFiles;
                    }
                }
            }

            GridControlInstalledMods.DataSource = DataTableInstalledMods;

            GridViewInstalledMods.FocusedRowHandle = -1;

            TileItemInstalledModsDeleteItem.Enabled = GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsDeleteAll.Enabled = GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;
            TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledMods.SelectedRowsCount > 0;

            GridViewInstalledMods.HideLoadingPanel();
        }

        private void GridViewInstalledMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            TileItemInstalledModsDeleteItem.Enabled = GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsDeleteAll.Enabled = GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;
            TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledMods.SelectedRowsCount > 0;
        }

        private void GridViewInstalledMods_RowClick(object sender, RowClickEventArgs e)
        {
            TileItemInstalledModsDeleteItem.Enabled = GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsDeleteAll.Enabled = GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsUninstallItem.Enabled = IsConsoleConnected && GridViewInstalledMods.SelectedRowsCount > 0;
            TileItemInstalledModsUninstallAllItems.Enabled = IsConsoleConnected && GridViewInstalledMods.RowCount > 0;
            TileItemInstalledModsViewDetails.Enabled = GridViewInstalledMods.SelectedRowsCount > 0;
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
                        if (Settings.LocalPathPs3.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathPs3))
                        {
                            LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                        }
                        else
                        {
                            LoadLocalDirectory(Settings.LocalPathPs3);
                        }

                        break;
                    }
                case true:
                    {
                        switch (Platform)
                        {
                            case Platform.XBOX360 when Settings.LocalPathXbox.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathXbox):
                                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                                break;
                            case Platform.XBOX360:
                                LoadLocalDirectory(Settings.LocalPathXbox);
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

                            if (Settings.ConsolePathPs3.Equals("/") || Settings.ConsolePathPs3.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory("/" + ComboBoxFileManagerConsoleDrives.Properties.Items[0] + "/");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathPs3);
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
            new List<DataColumn>
            {
                new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                new() { Caption = ResourceLanguage.GetString("LABEL_NAME"), ColumnName = ResourceLanguage.GetString("LABEL_NAME"), DataType = typeof(string) },
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
                GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;

                if (downHitInfo == null)
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
            new List<DataColumn>
            {
                new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                new() { Caption = ResourceLanguage.GetString("LABEL_NAME"), ColumnName = ResourceLanguage.GetString("LABEL_NAME"), DataType = typeof(string) },
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
                                                   ImageFolderUp,
                                                   "..",
                                                   string.Empty,
                                                   string.Empty);
                }

                if (Platform == Platform.PS3)
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
                                        : string.Empty;
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
                                       ? $" ({Database.GamesTitleIdsXbox.GetTitleFromTitleId(folder.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty))})"
                                       : string.Empty;
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageFolder,
                                                           $"{folder.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty)}{gameTitle}",
                                                           "<GAME>",
                                                           folder.ChangeTime);
                        }
                        else
                        {
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageFolder,
                                                           folder.Name.Replace(DirectoryPathConsole, string.Empty).Replace(@"\", string.Empty),
                                                           "<DIRECTORY>",
                                                           folder.ChangeTime);
                        }
                    }

                    foreach (IXboxFile file in files)
                    {
                        DataTableConsoleFiles.Rows.Add("file",
                                                       ImageFile,
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
                GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
                if (downHitInfo == null)
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
            { "English", "ArisenMods.Languages.en_US" },
            { "Español", "ArisenMods.Languages.es_ES" },
            { "Svenska", "ArisenMods.Languages.sv_SE" },
            { "Türkçe", "ArisenMods.Languages.tr_TR" },
            //{ "Português", "ArisenMods.Languages.pt_PT" },
            //{ "Português (Brasil)", "ArisenMods.Languages.pt_BR" }
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
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(ResourceLanguage.BaseName.Replace("_", "-").Replace("ArisenMods.Languages.", ""));

                // Ribbon Bar
                RibbonPageHome.Text = ResourceLanguage.GetString("HOME");
                RibbonPageModdingTools.Text = ResourceLanguage.GetString("MODDING_TOOLS");
                RibbonGroupConnection.Text = ResourceLanguage.GetString("CONNECTION");
                RibbonGroupConnsoleProfiles.Text = ResourceLanguage.GetString("CONSOLE_PROFILES");
                RibbonGroupQuickSettings.Text = ResourceLanguage.GetString("QUICK_SETTINGS");
                RibbonGroupTools.Text = ResourceLanguage.GetString("TOOLS");
                RibbonGroupWebManCommands.Text = ResourceLanguage.GetString("WEBMAN_COMMANDS");
                RibbonGroupXbdmCommands.Text = ResourceLanguage.GetString("XBDM_COMMANDS");

                ButtonConnectConsole.Caption = ResourceLanguage.GetString("CONNECT_CONSOLE");
                ButtonDisconnectConsole.Caption = ResourceLanguage.GetString("DISCONNECT_CONSOLE");
                ButtonChangeProfile.Caption = ResourceLanguage.GetString("CHANGE_PROFILE");
                ButtonAddNewProfile.Caption = ResourceLanguage.GetString("ADD_NEW_PROFILE");
                ButtonScanXboxConsoles.Caption = ResourceLanguage.GetString("SCAN_XBOX_CONSOLES");
                ButtonEditProfiles.Caption = ResourceLanguage.GetString("EDIT_PROFILES");
                ButtonHowToGuides.Caption = ResourceLanguage.GetString("HOW_TO_GUIDES");
                ButtonDownloadsFolder.Caption = ResourceLanguage.GetString("DOWNLOADS_FOLDER");
                ButtonDiscordPresence.Caption = ResourceLanguage.GetString("DISCORD_RICH_PRESENCE");
                ButtonInstallModsToUSB.Caption = ResourceLanguage.GetString("INSTALL_MODS_TO_USB");
                ButtonAdvancedSettings.Caption = ResourceLanguage.GetString("ADVANCED_SETTINGS");

                ButtonToolsPsGameUpdates.Caption = ResourceLanguage.GetString("GAME_UPDATES");
                ButtonToolsPsBackupFilesManager.Caption = ResourceLanguage.GetString("BACKUP_FILES_MANAGER");
                ButtonToolsPsPackageManager.Caption = ResourceLanguage.GetString("PACKAGE_MANAGER");
                ButtonToolsPsConsoleManager.Caption = ResourceLanguage.GetString("CONSOLE_MANAGER");
                ButtonToolsPsGameRegions.Caption = ResourceLanguage.GetString("GAME_REGIONS");
                ButtonToolsPsBootPluginsEditor.Caption = ResourceLanguage.GetString("BOOT_PLUGINS_EDITOR");

                ButtonToolsXboxGameSaveResigner.Caption = ResourceLanguage.GetString("GAME_SAVE_RESIGNER");
                ButtonToolsXboxGamesLauncher.Caption = ResourceLanguage.GetString("GAMES_LAUNCHER");
                ButtonToolsXboxModuleLoader.Caption = ResourceLanguage.GetString("MODULE_LOADER");
                ButtonToolsXboxXuidSpoofer.Caption = ResourceLanguage.GetString("XUID_SPOOFER");
                ButtonToolsXboxDashlaunchEditor.Caption = ResourceLanguage.GetString("DASHLAUNCH_EDITOR");

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

                ButtonToolsXboxPower.Caption = ResourceLanguage.GetString("POWER");
                ButtonToolsXboxPowerShutdown.Caption = ResourceLanguage.GetString("SHUTDOWN");
                ButtonToolsXboxPowerSoftReboot.Caption = ResourceLanguage.GetString("SOFT_REBOOT");
                ButtonToolsXboxPowerHardReboot.Caption = ResourceLanguage.GetString("HARD_REBOOT");
                ButtonToolsXboxTakeScreenshot.Caption = ResourceLanguage.GetString("TAKE_SCREENSHOT");
                ButtonToolsXboxConsoleManager.Caption = ResourceLanguage.GetString("CONSOLE_MANAGER");
                ButtonToolsXboxNotifyMessage.Caption = ResourceLanguage.GetString("NOTIFY_MESSAGE");

                // Navigation Menu
                NavigationItemDashboard.Text = ResourceLanguage.GetString("NAVIGATION_DASHBOARD");
                NavigationItemInstalledMods.Text = ResourceLanguage.GetString("NAVIGATION_INSTALLED_MODS");
                NavigationItemDownloads.Text = ResourceLanguage.GetString("NAVIGATION_DOWNLOADS");
                NavigationItemFileManager.Text = ResourceLanguage.GetString("NAVIGATION_FILE_MANAGER");
                NavigationItemSettings.Text = ResourceLanguage.GetString("NAVIGATION_SETTINGS");

                NavigationItemGameMods.Text = ResourceLanguage.GetString("NAVIGATION_GAME_MODS");
                NavigationItemHomebrew.Text = ResourceLanguage.GetString("NAVIGATION_HOMEBREW");
                NavigationItemResources.Text = ResourceLanguage.GetString("NAVIGATION_RESOURCES");
                NavigationItemPackages.Text = ResourceLanguage.GetString("NAVIGATION_PACKAGES");
                NavigationItemPlugins.Text = ResourceLanguage.GetString("NAVIGATION_PLUGINS");
                NavigationItemGameSaves.Text = ResourceLanguage.GetString("NAVIGATION_GAME_SAVES");
                NavigationItemGameCheats.Text = ResourceLanguage.GetString("NAVIGATION_GAME_CHEATS");

                // Dashboard
                LabelHeaderOurFavoriteMods.Text = ResourceLanguage.GetString("TITLE_OUR_FAVORITE_MODS");
                LabelHeaderRecentlyUpdated.Text = ResourceLanguage.GetString("TITLE_RECENTLY_UPDATED");
                LabelHeaderAnnouncements.Text = ResourceLanguage.GetString("TITLE_ANNOUNCEMENTS");
                LabelHeaderLatestNews.Text = ResourceLanguage.GetString("TITLE_LATEST_NEWS");
                LabelHeaderChangeLog.Text = ResourceLanguage.GetString("TITLE_CHANGE_LOG");
                ButtonChangeLogNext.Text = ResourceLanguage.GetString("LABEL_NEXT");
                ButtonChangeLogPrevious.Text = ResourceLanguage.GetString("LABEL_PREVIOUS");
                LoadStatistics();
                LoadNewsFeed();
                LoadAnnouncements();
                NoAnnouncementsItem.LoadText();

                // Downloads
                TileItemDownloadsOpenFolder.Text = ResourceLanguage.GetString("OPEN_FOLDER");
                TileItemDownloadsOpenFile.Text = ResourceLanguage.GetString("OPEN_FILE");
                TileItemDownloadsDeleteAllItems.Text = ResourceLanguage.GetString("DELETE_ALL_ITEMS");
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
                TileItemInstalledModsDeleteAll.Text = ResourceLanguage.GetString("DELETE_ALL_ITEMS");
                TileItemInstalledModsDeleteItem.Text = ResourceLanguage.GetString("DELETE_ITEM");
                TileItemInstalledModsUninstallAllItems.Text = ResourceLanguage.GetString("UNINSTALL_ALL_ITEMS");
                TileItemInstalledModsUninstallItem.Text = ResourceLanguage.GetString("UNINSTALL_ITEM");
                TileItemInstalledModsViewDetails.Text = ResourceLanguage.GetString("VIEW_DETAILS");

                LabelInstalledModsFilterPlatform.Text = ResourceLanguage.GetString("LABEL_PLATFORM");
                LabelInstalledModsFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelInstalledModsFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelInstalledModsFilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelInstalledModsFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelInstalledModsFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelInstalledModsFilterCreator.Text = ResourceLanguage.GetString("LABEL_CREATOR");
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

                LabelSettingsAdvanced.Text = ResourceLanguage.GetString("ADVANCED");
                LabelSettingsEnableHardwareAcceleration.Text = ResourceLanguage.GetString("ENABLE_HARDWARE_ACCELERATION");

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

                // Settings: Tools
                LabelSettingsPackagesFilePath.Text = ResourceLanguage.GetString("PACKAGES_INSTALL_FILE_PATH");
                LabelSettingsLaunchIniFilePath.Text = ResourceLanguage.GetString("LAUNCH_FILE_PATH");

                // Settings: Paths
                LabelSettingsPathBaseDirectory.Text = ResourceLanguage.GetString("LABEL_BASE_DIRECTORY");
                LabelSettingsPathDownloads.Text = ResourceLanguage.GetString("LABEL_DOWNLOADS");
                LabelSettingsPathGameMods.Text = ResourceLanguage.GetString("LABEL_GAME_MODS");
                LabelSettingsPathPackages.Text = ResourceLanguage.GetString("LABEL_PACKAGES");
                LabelSettingsPathPlugins.Text = ResourceLanguage.GetString("LABEL_PLUGINS");
                LabelSettingsPathGameSaves.Text = ResourceLanguage.GetString("LABEL_GAME_SAVES");

                LabelSettingsReferToBaseDirectory.Text = ResourceLanguage.GetString("REFER_TO_BASE_DIRECTORY");
                LabelSettingsDirectoriesMustBeWritable.Text = ResourceLanguage.GetString("DIRECTORIES_MUST_BE_WRITABLE");

                // Settings: Discord
                LabelSettingsRichPresence.Text = ResourceLanguage.GetString("RICH_PRESENCE");
                LabelSettingsShowCurrentGamePlaying.Text = ResourceLanguage.GetString("SHOW_CURRENT_GAME_PLAYING");

                // Game Mods
                TileItemGameModsShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemGameModsSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelGameModsFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelGameModsFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelGameModsFilterSystemType.Text = ResourceLanguage.GetString("LABEL_SYSTEM_TYPE");
                LabelGameModsFilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelGameModsFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelGameModsFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelGameModsFilterCreator.Text = ResourceLanguage.GetString("LABEL_CREATOR");
                LabelGameModsFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                ComboBoxGameModsFilterStatus.Properties.Items.Clear();
                ComboBoxGameModsFilterStatus.Properties.Items.Add("<" + ResourceLanguage.GetString("LABEL_ALL") + ">");
                ComboBoxGameModsFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
                ComboBoxGameModsFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_INSTALLED"));
                ComboBoxGameModsFilterStatus.Properties.Items.Add(ResourceLanguage.GetString("LABEL_DOWNLOADED"));

                // Homebrew
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemHomebrewSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelHomebrewFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelHomebrewFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelHomebrewFilterSystemType.Text = ResourceLanguage.GetString("LABEL_SYSTEM_TYPE");
                LabelHomebrewFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelHomebrewFilterCreator.Text = ResourceLanguage.GetString("LABEL_CREATOR");
                LabelHomebrewFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                // Resources
                TileItemResourcesShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemResourcesSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelResourcesFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelResourcesFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelResourcesFilterSystemType.Text = ResourceLanguage.GetString("LABEL_SYSTEM_TYPE");
                LabelResourcesFilterModType.Text = ResourceLanguage.GetString("LABEL_MOD_TYPE");
                LabelResourcesFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelResourcesFilterCreator.Text = ResourceLanguage.GetString("LABEL_CREATOR");
                LabelResourcesFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                // Packages
                TileItemPackagesSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelPackagesFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelPackagesFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelPackagesFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelPackagesFilterModifiedDate.Text = ResourceLanguage.GetString("LABEL_MODIFIED_DATE");
                LabelPackagesFilterFileSize.Text = ResourceLanguage.GetString("LABEL_FILE_SIZE");
                LabelPackagesFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                // Plugins
                TileItemPluginsShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                TileItemPluginsSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelPluginsFilterCategory.Text = ResourceLanguage.GetString("LABEL_CATEGORY");
                LabelPluginsFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelPluginsFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelPluginsFilterCreator.Text = ResourceLanguage.GetString("LABEL_CREATOR");
                LabelPluginsFilterStatus.Text = ResourceLanguage.GetString("LABEL_STATUS");

                // Game Saves
                TileItemGameSavesSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelGameSavesFilterGame.Text = ResourceLanguage.GetString("LABEL_GAME");
                LabelGameSavesFilterName.Text = ResourceLanguage.GetString("LABEL_NAME");
                LabelGameSavesFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                LabelGameSavesFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");
                LabelGameSavesFilterCreator.Text = ResourceLanguage.GetString("LABEL_CREATOR");

                // Game Cheats
                TileItemGameCheatsSortOptions.Text = ResourceLanguage.GetString("LABEL_SORT_OPTIONS");

                LabelGameCheatsFilterGame.Text = ResourceLanguage.GetString("LABEL_GAME");
                //LabelGameCheatsFilterRegion.Text = ResourceLanguage.GetString("LABEL_REGION");
                //LabelGameCheatsFilterVersion.Text = ResourceLanguage.GetString("LABEL_VERSION");

                // About
                LabelAboutHeaderLibraries.Text = ResourceLanguage.GetString("LABEL_LIBRARIES");
                LabelAboutHeaderContributors.Text = ResourceLanguage.GetString("LABEL_CONTRIBUTORS");
                LabelAboutHeaderTranslators.Text = ResourceLanguage.GetString("LABEL_TRANSLATORS");
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
            Process.Start("https://crowdin.com/project/arisenmods");
        }

        private void LoadSettings()
        {
            /* Appearance */

            // Customization
            ToggleSettingsUseFormattedFileSizes.IsOn = Settings.UseFormattedFileSizes;
            ToggleSettingsUseRelativeTimes.IsOn = Settings.UseRelativeTimes;

            // Advanced

            ToggleSettingsEnableHardwareAcceleration.IsOn = Settings.EnableHardwareAcceleration;

            // Automation
            ToggleSettingsShowGamesFromExternalDevices.IsOn = Settings.ShowGamesFromExternalDevices;
            ToggleSettingsAutoDetectGameRegions.IsOn = Settings.AutoDetectGameRegions;
            ToggleSettingsAutoDetectGameTitles.IsOn = Settings.AutoDetectGameTitles;
            ToggleSettingsAutoLoadDirectoryListings.IsOn = Settings.AutoLoadDirectoryListings;
            ToggleSettingsRememberLocalPath.IsOn = Settings.RememberLocalPath;
            ToggleSettingsRememberConsolePath.IsOn = Settings.RememberConsolePath;

            /* Transfer */
            ToggleSettingsInstallModsToUsbDevice.IsOn = Settings.InstallGameModsPluginsToUsbDevice;
            ToggleSettingsInstallHomebrewToUsbDevice.IsOn = Settings.InstallHomebrewToUsbDevice;
            ToggleSettingsInstallResourcesToUsbDevice.IsOn = Settings.InstallResourcesToUsbDevice;
            ToggleSettingsInstallGameSavesToUsbDevice.IsOn = Settings.InstallGameSavesToUsbDevice;
            ToggleSettingsCleanUpLocalFilesAfterInstalling.IsOn = Settings.CleanUpLocalFilesAfterInstalling;
            ToggleSettingsRememberGameRegions.IsOn = Settings.RememberGameRegions;
            ToggleSettingsAlwaysBackupGameFiles.IsOn = Settings.AlwaysBackupGameFiles;


            /* Tools */

            // Packages File Path
            TextBoxSettingsPackagesInstallPath.Text = Settings.PackageInstallPath;

            // Launch.ini File Path
            TextBoxSettingsLaunchIniFilePath.Text = Settings.LaunchIniFilePath;

            /* Paths */
            TextBoxSettingsPathBaseDirectory.Text = Settings.PathBaseDirectory;
            TextBoxSettingsPathDownloads.Text = Settings.PathDownloads;
            TextBoxSettingsPathGameMods.Text = Settings.PathGameMods;
            TextBoxSettingsPathHomebrew.Text = Settings.PathHomebrew;
            TextBoxSettingsPathResources.Text = Settings.PathResources;
            TextBoxSettingsPathPackages.Text = Settings.PathPackages;
            TextBoxSettingsPathPlugins.Text = Settings.PathPlugins;
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

        public void EnableDiscordRpc()
        {
            DiscordClient = new DiscordRpcClient("842507057256595536");
            DiscordClient.Initialize();

            SetPresence();

            timer.Elapsed += (sender, args) => { if (DiscordClient != null) { SetPresence(); DiscordClient.Invoke();} };
            timer.Start();
        }

        public void DisableDiscordRpc()
        {
            timer.Stop();
            DiscordClient.ClearPresence();
            DiscordClient.Dispose();
            DiscordClient = null;
        }

        private readonly System.Timers.Timer timer = new(10000);

        public void SetPresence()
        {
            if (Settings.AlwaysShowPresence)
            {
                DiscordClient.SetPresence(new RichPresence()
                {
                    Details = "Browsing Library",
                    Buttons = new DiscordRPC.Button[]
                    {
                        new DiscordRPC.Button()
                        {
                            Label = "Download Arisen Mods",
                            Url = "https://github.com/ohhsodead/ArisenMods"
                        },
                        new DiscordRPC.Button()
                        {
                            Label = "Join Our Discord",
                            Url = "https://discord.gg/h22szNhF7V"
                        }
                    },
                    Assets = new Assets()
                    {
                        LargeImageKey = "ArisenMods",
                        LargeImageText = "ArisenMods"
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

                        DiscordClient.SetPresence(new RichPresence()
                        {
                            Details = game,
                            //State = "Playing Game",
                            Buttons = new DiscordRPC.Button[] { new DiscordRPC.Button() { Label = "Download Arisen Mods", Url = "https://github.com/ohhsodead/arisenmods" } },
                            Assets = new Assets()
                            {
                                LargeImageKey = "Arisen Mods",
                                LargeImageText = "Arisen Mods",
                                SmallImageKey = image,
                                SmallImageText = Platform.Humanize(),
                            }
                        });
                    }
                }
            }
            else
            {
                DiscordClient.ClearPresence();
                DiscordClient.Dispose();
                DiscordClient = null;
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

        // Advanced

        private void ToggleSettingsEnableDirectXHardwareAcceleration_Toggled(object sender, EventArgs e)
        {
            if (Settings.EnableHardwareAcceleration != ToggleSettingsEnableHardwareAcceleration.IsOn)
            {
                Settings.EnableHardwareAcceleration = ToggleSettingsEnableHardwareAcceleration.IsOn;

                if (XtraMessageBox.Show(this, ResourceLanguage.GetString("RESTART_TAKE_AFFECT"), ResourceLanguage.GetString("RESTART_REQUIRED"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        // Automation

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
            Settings.InstallGameModsPluginsToUsbDevice = ToggleSettingsInstallModsToUsbDevice.IsOn;
        }

        private void ToggleSettingsInstallHomebrewToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallHomebrewToUsbDevice = ToggleSettingsInstallHomebrewToUsbDevice.IsOn;
        }

        private void ToggleSettingsInstallResourcesToUsbDevice_Toggled(object sender, EventArgs e)
        {
            Settings.InstallResourcesToUsbDevice = ToggleSettingsInstallResourcesToUsbDevice.IsOn;
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
            Settings.PathBaseDirectory = TextBoxSettingsPathBaseDirectory.Text;
        }

        private void ButtonSettingsPathBaseDirectory_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_BASE_DIRECTORY"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathBaseDirectory.Text = path;
            }
        }

        private void TextBoxSettingsPathDownloads_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathDownloads = TextBoxSettingsPathDownloads.Text;
        }

        private void ButtonSettingsPathDownloads_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_DOWNLOADS"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathDownloads.Text = path;
            }
        }

        private void TextBoxSettingsPathGameMods_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathGameMods = TextBoxSettingsPathGameMods.Text;
        }

        private void ButtonSettingsPathGameMods_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_GAME_MODS"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathGameMods.Text = path;
            }
        }

        private void TextBoxSettingsPathHomebrew_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathHomebrew = TextBoxSettingsPathHomebrew.Text;
        }

        private void ButtonSettingsPathHomebrew_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_HOMEBREW"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathHomebrew.Text = path;
            }
        }

        private void TextBoxSettingsPathResources_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathResources = TextBoxSettingsPathResources.Text;
        }

        private void ButtonSettingsPathResources_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_RESOURCES"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathResources.Text = path;
            }
        }

        private void TextBoxSettingsPathPackages_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathPackages = TextBoxSettingsPathPackages.Text;
        }

        private void ButtonSettingsPathPackages_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_PACKAGES"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathPackages.Text = path;
            }
        }

        private void TextBoxSettingsPathPlugins_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathPlugins = TextBoxSettingsPathPlugins.Text;
        }

        private void ButtonSettingsPathPlugins_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_PLUGINS"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathPlugins.Text = path;
            }
        }

        private void TextBoxSettingsPathGameSaves_EditValueChanged(object sender, EventArgs e)
        {
            Settings.PathGameSaves = TextBoxSettingsPathGameSaves.Text;
        }

        private void ButtonSettingsPathGameSaves_Click(object sender, EventArgs e)
        {
            string path = DialogExtensions.ShowFolderBrowseDialog(this, ResourceLanguage.GetString("LABEL_GAME_SAVES"));

            if (!path.IsNullOrEmpty())
            {
                TextBoxSettingsPathGameSaves.Text = path;
            }
        }

        // Tools

        /* PlayStation 3 */

        private void TextBoxSettingsPackagesFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSettingsPackagesInstallPath.Text.IsNullOrEmpty() | TextBoxSettingsPackagesInstallPath.Text.IsNullOrWhiteSpace())
                {
                    TextBoxSettingsPackagesInstallPath.Text = Settings.PackageInstallPath;
                    return;
                }

                Settings.PackageInstallPath = TextBoxSettingsPackagesInstallPath.Text;
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
            ButtonDiscordPresence.Checked = ToggleSettingsAlwaysShowPresence.IsOn;
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

                if (DiscordClient != null)
                {
                    DiscordClient.ClearPresence();
                    DiscordClient.Dispose();
                    DiscordClient = null;
                }

                timer.Stop();
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
                if (DiscordClient != null)
                {
                    DiscordClient.ClearPresence();
                    DiscordClient.Dispose();
                    DiscordClient = null;
                }

                timer.Stop();
            }
        }

#endregion

    #region Game Mods Page

        private void TileItemGameModsShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterGameModsShowFavorites)
            {
                FilterGameModsShowFavorites = false;
                TileItemGameModsShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchGameMods();
            }
            else
            {
                FilterGameModsShowFavorites = true;
                TileItemGameModsShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchGameMods();
            }
        }

        private void TileItemGameModsSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameModsSortOption, new List<string> { ResourceLanguage.GetString("LABEL_GAME"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_MOD_TYPE"), ResourceLanguage.GetString("LABEL_REGION"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR") }, FilterGameModsSortOrder);

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
        private string FilterGameModsSortOption { get; set; } = ResourceLanguage.GetString("LABEL_GAME");

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

        private void ComboBoxGameModsFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameModsFilterGame.SelectedIndex == 0 | ComboBoxGameModsFilterGame.SelectedIndex == -1)
            {
                FilterGameModsCategoryId = string.Empty;
            }
            else
            {
                string selectedCategory = ComboBoxGameModsFilterGame.SelectedItem as string;
                Category category = Database.CategoriesData.GetCategoryByTitle(selectedCategory);
                FilterGameModsCategoryId = category.Id;
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
            ComboBoxGameModsFilterGame.Properties.Items.Clear();

            ComboBoxGameModsFilterGame.SelectedIndexChanged -= ComboBoxGameModsFilterCategory_SelectedIndexChanged;
            ComboBoxGameModsFilterGame.SelectedIndex = -1;
            ComboBoxGameModsFilterGame.SelectedIndexChanged += ComboBoxGameModsFilterCategory_SelectedIndexChanged;

            ComboBoxGameModsFilterGame.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxGameModsFilterGame.Properties.Items.Add(category.Title);
            }
        }

        private DataTable DataTableGameMods { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_GAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CREATOR"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
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
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterGameModsCategoryId);
            }

            ComboBoxGameModsFilterModType.Properties.Items.Clear();
            ComboBoxGameModsFilterModType.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxGameModsFilterRegion.Properties.Items.Clear();
            ComboBoxGameModsFilterRegion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxGameModsFilterVersion.Properties.Items.Clear();
            ComboBoxGameModsFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxGameModsFilterCreator.Properties.Items.Clear();
            ComboBoxGameModsFilterCreator.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            switch (FilterGameModsCategoryId)
            {
                case "fvrt":
                    //ComboBoxGameModsFilterModType.Properties.Items.AddRange(Settings.GetModTypesForMods(Database.ModsPS3, ConsoleProfile.FavoriteIds).ToArray());
                    break;
                default:
                    {
                        foreach (string modType in Database.GameModsPs3.AllModTypesForCategoryId(category.Id))
                        {
                            ComboBoxGameModsFilterModType.Properties.Items.Add(modType);
                        }

                        break;
                    }
            }

            switch (FilterGameModsCategoryId)
            {
                case "fvrt":
                    //ComboBoxGameModsFilterRegion.Properties.Items.AddRange(Settings.GetRegionsForMods(Database.ModsPS3, ConsoleProfile.FavoriteIds).ToArray());
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

            DataTableGameMods.Rows.Clear();

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.GameModsPs3.GetGameMods(Database.CategoriesData, FilterGameModsCategoryId, FilterGameModsName, FilterGameModsSystemType, FilterGameModsType, FilterGameModsRegion, FilterGameModsVersion, FilterGameModsCreator, FilterGameModsShowFavorites))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id) != null;

                    bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                    bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                    if (FilterGameModsStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                    {
                        continue;
                    }
                    else if (FilterGameModsStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                    {
                        continue;
                    }
                    else if (FilterGameModsStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
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
                                               modItemData.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : modItemData.CreatedBy,
                                               isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));

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

            //DataTableGameMods.DefaultView.Sort = $"[{FilterGameModsSortOption}] ASC";
            //DataTableGameMods.AcceptChanges();

            GridControlGameMods.DataSource = DataTableGameMods;

            //GridViewGameMods.SelectRow(0);
            //GridViewGameMods.FocusedRowHandle = 0;
            //GridViewGameMods.ClearSelection();
            //GridViewGameMods.MoveFirst();

            GridViewGameMods.Columns[0].Visible = false;

            GridViewGameMods.Columns[1].MinWidth = 232;
            GridViewGameMods.Columns[1].MaxWidth = 232;

            //GridViewGameMods.Columns[2].MinWidth = 30;

            GridViewGameMods.Columns[3].MinWidth = 88;
            GridViewGameMods.Columns[3].MaxWidth = 88;

            GridViewGameMods.Columns[4].MinWidth = 116;
            GridViewGameMods.Columns[4].MaxWidth = 116;

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

            //if (GridViewGameMods.RowCount > 0)
            //{
            //    GridViewGameMods.ClearSelection();
            //    GridViewGameMods.TopRowIndex = 0;
            //    GridViewGameMods.SelectRow(0);
            //    GridViewGameMods.FocusedRowHandle = 0;
            //    GridViewGameMods.ClearSelection();
            //}

            //GridViewGameMods.ClearSelection();
            //GridViewGameMods.TopRowIndex = 0;
            //GridViewGameMods.SelectRow(0);
            //GridViewGameMods.FocusedRowHandle = 0;
            //GridViewGameMods.ClearSelection();

            //GridViewGameMods.OptionsSelection.MultiSelect = true;
            //GridViewGameMods.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            //GridViewGameMods.SelectRow(0);
            //GridViewGameMods.FocusedRowHandle = 0;

            //GridViewGameMods.SelectRow(0);
            //GridViewGameMods.FocusedRowHandle = 0;
            //GridViewGameMods.MoveFirst();
            GridViewGameMods.FocusedRowHandle = 0;
        }

        private void GridViewGameMods_RowClick(object sender, RowClickEventArgs e)
        {
            int modId = (int)GridViewGameMods.GetRowCellValue(e.RowHandle, GridViewGameMods.Columns[0]);
            ShowGameModDetails(modId);
        }

        private void GridControlGameMods_DataSourceChanged(object sender, EventArgs e)
        {
            //GridViewGameMods.FocusedRowHandle = 0;
        }

#endregion

    #region Homebrew Page

        private void TileItemHomebrewShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterHomebrewShowFavorites)
            {
                FilterHomebrewShowFavorites = false;
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchHomebrew();
            }
            else
            {
                FilterHomebrewShowFavorites = true;
                TileItemHomebrewShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchHomebrew();
            }
        }

        private void TileItemHomebrewSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterHomebrewSortOption, new List<string> { ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR") }, FilterHomebrewSortOrder);

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
        private string FilterHomebrewSortOption { get; set; } = ResourceLanguage.GetString("LABEL_CATEGORY");

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
                FilterHomebrewCategoryId = category.Id;
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

            ComboBoxHomebrewFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Homebrew == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxHomebrewFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableHomebrew { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("ID", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CREATOR"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
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
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterHomebrewCategoryId);
            }

            ComboBoxHomebrewFilterVersion.Properties.Items.Clear();
            ComboBoxHomebrewFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxHomebrewFilterCreator.Properties.Items.Clear();
            ComboBoxHomebrewFilterCreator.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            DataTableHomebrew.Rows.Clear();

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            List<string> versions = new();
            List<string> authors = new();

            BeginInvoke(new Action(() =>
            {
                foreach (ModItemData modItemData in Database.HomebrewPs3.GetHomebrew(Database.CategoriesData, FilterHomebrewCategoryId, FilterHomebrewName, FilterHomebrewSystemType, FilterHomebrewVersion, FilterHomebrewCreator, FilterHomebrewShowFavorites))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id) != null;

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
                                               modItemData.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : modItemData.CreatedBy,
                                               isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));

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

            if (GridViewHomebrew.RowCount > 0)
            {
                GridViewHomebrew.FocusedRowHandle = 0;
            }
        }

        private void GridViewHomebrew_RowClick(object sender, RowClickEventArgs e)
        {
            int modId = (int)GridViewHomebrew.GetRowCellValue(e.RowHandle, GridViewHomebrew.Columns[0]);
            ShowHomebrewDetails(modId);
        }

        private void MenuItemHomebrewInstallFiles_ItemClick(object sender, EventArgs e)
        {
            ModItemData modItemData = SelectedHomebrewItem;
            InstalledModInfo installedModInfo = ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id) : null;
            bool isInstalled = installedModInfo != null;

            if (isInstalled)
            {
                ShowTransferModsDialog(Window, TransferType.UninstallMods, modItemData);
            }
            else
            {
                ShowTransferModsDialog(Window, TransferType.InstallMods, modItemData);
            }
        }

#endregion

    #region Resources Page

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

        private void TileItemResourcesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterResourcesSortOption, new List<string> { ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), ResourceLanguage.GetString("LABEL_MOD_TYPE"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR") }, FilterResourcesSortOrder);

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
        private string FilterResourcesSortOption { get; set; } = ResourceLanguage.GetString("LABEL_CATEGORY");

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

            ComboBoxResourcesFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>");

            foreach (Category category in Database.CategoriesData.Categories.FindAll(x => CategoryType.Resource == x.CategoryType).OrderBy(x => x.Title))
            {
                ComboBoxResourcesFilterCategory.Properties.Items.Add(category.Title);
            }
        }

        private static DataTable DataTableResources { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Id", typeof(int)),
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_SYSTEM_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MOD_TYPE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CREATOR"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
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
                    Title = $"<{ResourceLanguage.GetString("ALL_CATEGORIES")}>",
                    Type = "all"
                };
            }
            else
            {
                category = Database.CategoriesData.GetCategoryById(FilterResourcesCategoryId);
            }

            ComboBoxResourcesFilterModType.Properties.Items.Clear();
            ComboBoxResourcesFilterModType.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxResourcesFilterVersion.Properties.Items.Clear();
            ComboBoxResourcesFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            ComboBoxResourcesFilterCreator.Properties.Items.Clear();
            ComboBoxResourcesFilterCreator.Properties.Items.Add($"<{ResourceLanguage.GetString("ANY")}>");

            switch (FilterResourcesCategoryId)
            {
                case "fvrt":
                    //ComboBoxResourcesFilterModType.Properties.Items.AddRange(Settings.GetModTypesForMods(Database.ModsPS3, ConsoleProfile.FavoriteIds).ToArray());
                    break;
                default:
                    {
                        foreach (string modType in Database.ResourcesPs3.AllModTypesForCategoryId(category.Id))
                        {
                            ComboBoxResourcesFilterModType.Properties.Items.Add(modType);
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
                foreach (ModItemData modItemData in Database.ResourcesPs3.GetResources(Database.CategoriesData, FilterResourcesCategoryId, FilterResourcesName, FilterResourcesSystemType, FilterResourcesModType, FilterResourcesVersion, FilterResourcesCreator, FilterResourcesShowFavorites).OrderBy(x => x.Name))
                {
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id) != null;

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

                    DataTableResources.Rows.Add(modItemData.Id,
                                           modItemData.GetCategoryName(Database.CategoriesData),
                                           modItemData.Name,
                                           modItemData.FirmwareType,
                                           modItemData.ModType,
                                           string.Join(" & ", modItemData.Versions),
                                           modItemData.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : modItemData.CreatedBy,
                                           isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));

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

            GridViewResources.Columns[4].MinWidth = 108;
            GridViewResources.Columns[4].MaxWidth = 108;

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

            if (GridViewResources.RowCount > 0)
            {
                GridViewResources.FocusedRowHandle = 0;
            }
        }

        private void GridViewResources_RowClick(object sender, RowClickEventArgs e)
        {
            int modId = (int)GridViewResources.GetRowCellValue(e.RowHandle, GridViewResources.Columns[0]);
            ShowResourceDetails(modId);
        }

#endregion

    #region Packages Page

        private void TileItemPackagesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterPackagesSortOption, new List<string> { ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_REGION"), "Modified Date", "File Size", ResourceLanguage.GetString("LABEL_STATUS") }, FilterPackagesSortOrder);

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
        private string FilterPackagesSortOption { get; set; } = ResourceLanguage.GetString("LABEL_CATEGORY");

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
                PackagesData = Database.GamesPs3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Demos"))
            {
                PackagesData = Database.DemosPs3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("DLCs"))
            {
                PackagesData = Database.DLCsPs3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Avatars"))
            {
                PackagesData = Database.AvatarsPs3;
            }
            else if (ComboBoxFilterPackagesCategories.SelectedItem.Equals("Themes"))
            {
                PackagesData = Database.ThemesPs3;
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
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_MODIFIED_DATE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_FILE_SIZE"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
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
                                               package.IsDateMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(package.ModifiedDate).Humanize() : DateTime.Parse(package.ModifiedDate).ToString("MM/dd/yyyy"),
                                               package.IsSizeMissing ? ResourceLanguage.GetString("MISSING") : Settings.UseFormattedFileSizes ? long.Parse(package.Size).Bytes().Humanize("#.##") : package.Size + " " + ResourceLanguage.GetString("LABEL_BYTES"),
                                               isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
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

            if (GridViewPackages.RowCount > 0)
            {
                GridViewPackages.FocusedRowHandle = 0;
            }
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

            GridViewPackages.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewPackages.Columns[FilterPackagesSortOption], FilterPackagesSortOrder),
            });

            GridViewPackages.HideLoadingPanel();

            if (GridViewPackages.RowCount > 0)
            {
                GridViewPackages.FocusedRowHandle = 0;
            }
        }

        private static List<PackageItemData> GetAllPackages()
        {
            List<PackageItemData> packages = new();

            packages.AddRange(Database.GamesPs3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.DemosPs3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.DLCsPs3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.AvatarsPs3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));
            packages.AddRange(Database.ThemesPs3.Packages.Where(x => !x.IsNameMissing && !x.IsUrlMissing));

            return packages;
        }

        private void GridViewPackages_RowClick(object sender, RowClickEventArgs e)
        {
            ShowPackageDetails(GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[1]), GridViewPackages.GetFocusedRowCellDisplayText(GridViewPackages.Columns[0]));
        }

#endregion

    #region Plugins Page

        private void TileItemPluginsShowFavorites_ItemClick(object sender, TileItemEventArgs e)
        {
            if (FilterPluginsShowFavorites)
            {
                FilterPluginsShowFavorites = false;
                TileItemPluginsShowFavorites.Text = ResourceLanguage.GetString("LABEL_SHOW_FAVORITES");
                SearchPlugins();
            }
            else
            {
                FilterPluginsShowFavorites = true;
                TileItemPluginsShowFavorites.Text = ResourceLanguage.GetString("LABEL_HIDE_FAVORITES");
                SearchPlugins();
            }
        }

        private void TileItemPluginsSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterPluginsSortOption, new List<string> { ResourceLanguage.GetString("LABEL_CATEGORY"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR"), ResourceLanguage.GetString("LABEL_STATUS") }, FilterPluginsSortOrder);

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
        private string FilterPluginsSortOption { get; set; } = ResourceLanguage.GetString("LABEL_CATEGORY");

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
                FilterPluginsCategoryId = category.Id;
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
                new(ResourceLanguage.GetString("LABEL_CATEGORY"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CREATOR"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_STATUS"), typeof(string))
            });

        /// <summary>
        /// Load all plugins for Xbox.
        /// </summary>
        public void SearchPlugins()
        {
            GridViewPlugins.ShowLoadingPanel();

            DataTablePlugins.Rows.Clear();

            foreach (ModItemData modItemData in Database.PluginsXbox.GetPluginItems(FilterPluginsCategoryId, FilterPluginsName, FilterPluginsVersion, FilterPluginsCreator, FilterPluginsShowFavorites))
            {
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItemData.CategoryId, modItemData.Id) != null;

                bool isDownloaded = Settings.DownloadedMods.Any(x => x.Platform == modItemData.GetPlatform() && x.ModId == modItemData.Id);

                bool isDownloadNotInstalled = isDownloaded && !isInstalled;

                if (FilterPluginsStatus == ResourceLanguage.GetString("LABEL_DOWNLOADED") && !isDownloaded)
                {
                    continue;
                }
                else if (FilterPluginsStatus == ResourceLanguage.GetString("LABEL_INSTALLED") && !isInstalled)
                {
                    continue;
                }
                else if (FilterPluginsStatus == ResourceLanguage.GetString("LABEL_NOT_INSTALLED") && isInstalled)
                {
                    continue;
                }

                Category category = Database.CategoriesData.GetCategoryById(modItemData.CategoryId);

                DataTablePlugins.Rows.Add(modItemData.Id,
                                          category.Title,
                                          modItemData.Name,
                                          modItemData.Version,
                                          modItemData.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : modItemData.CreatedBy,
                                          isDownloadNotInstalled ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : isInstalled ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
            }

            GridControlPlugins.DataSource = DataTablePlugins;

            GridViewPlugins.Columns[0].Visible = false;

            GridViewPlugins.Columns[1].MinWidth = 232;
            GridViewPlugins.Columns[1].MaxWidth = 232;

            //GridViewPlugins.Columns[2].MinWidth = 180; //125

            GridViewPlugins.Columns[3].MinWidth = 72;
            GridViewPlugins.Columns[3].MaxWidth = 72;

            GridViewPlugins.Columns[4].MinWidth = 132;
            GridViewPlugins.Columns[4].MaxWidth = 132;

            GridViewPlugins.Columns[5].MinWidth = 92;
            GridViewPlugins.Columns[5].MaxWidth = 92;

            GridViewPlugins.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewPlugins.Columns[FilterPluginsSortOption], FilterPluginsSortOrder),
            });

            GridViewPlugins.HideLoadingPanel();

            if (GridViewPlugins.RowCount > 0)
            {
                GridViewPlugins.FocusedRowHandle = 0;
            }
        }

        private void GridViewPlugins_RowClick(object sender, RowClickEventArgs e)
        {
            ModItemData selectedPlugin = Database.PluginsXbox.GetModById(Platform.XBOX360, int.Parse(GridViewPlugins.GetRowCellDisplayText(e.RowHandle, "Id")));
            ShowPluginDetails(selectedPlugin.Id);
        }

#endregion

    #region Game Saves Page

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

        /// <summary>
        /// Get/set the version for filtering game saves.
        /// </summary>
        private string FilterGameSavesCreator { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the downloads status for filtering game saves.
        /// </summary>
        private GameSaveItemData SelectedGameSaveItem { get; set; }

        private void TileItemGameSavesSortBy_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameSavesSortOption, new List<string> { ResourceLanguage.GetString("LABEL_GAME"), ResourceLanguage.GetString("LABEL_NAME"), ResourceLanguage.GetString("LABEL_REGION"), ResourceLanguage.GetString("LABEL_VERSION"), ResourceLanguage.GetString("LABEL_CREATOR") }, FilterGameSavesSortOrder);

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
                new(ResourceLanguage.GetString("LABEL_GAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_NAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_CREATOR"), typeof(string))
            });

        private void LoadGameSavesCategories()
        {
            ComboBoxGameSavesFilterCategory.Properties.Items.Clear();

            ComboBoxGameSavesFilterCategory.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_GAMES")}>");

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
            ComboBoxGameSavesFilterRegion.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL")}>");

            ComboBoxGameSavesFilterVersion.Properties.Items.Clear();
            ComboBoxGameSavesFilterVersion.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL")}>");

            ComboBoxGameSavesFilterCreator.Properties.Items.Clear();
            ComboBoxGameSavesFilterCreator.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL")}>");

            List<string> ignoreValues = new() { "n/a", "-", "all regions", "all", "n", "a" };

            foreach (GameSaveItemData gameSaveItem in Database.GameSaves.GetGameSaveItems(Platform, FilterGameSavesCategoryId, FilterGameSavesName, FilterGameSavesRegion, FilterGameSavesVersion, FilterGameSavesCreator))
            {
                Category category = Database.CategoriesData.GetCategoryById(gameSaveItem.CategoryId);

                DataTableGameSaves.Rows.Add(gameSaveItem.Id,
                                            category.Title,
                                            gameSaveItem.Name,
                                            gameSaveItem.Region,
                                            gameSaveItem.Version,
                                            gameSaveItem.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : gameSaveItem.CreatedBy);

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

            if (GridViewGameSaves.RowCount > 0)
            {
                GridViewGameSaves.FocusedRowHandle = 0;
            }
        }

        private void GridViewGameSaves_RowClick(object sender, RowClickEventArgs e)
        {
            GameSaveItemData selectedGameSave = Database.GameSaves.GetModById(Platform, int.Parse(GridViewGameSaves.GetRowCellDisplayText(e.RowHandle, "Id")));
            SelectedGameSaveItem = selectedGameSave;

            ShowGameSaveDetails(Platform, selectedGameSave.Id);
        }

        private void MenuItemGameSavesInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowTransferGameSavesFileDialog(Window, TransferType.InstallGameSave, SelectedGameSaveItem);
        }

#endregion

    #region Game Cheats Page

        private void TileItemGameCheatsSortOptions_ItemClick(object sender, TileItemEventArgs e)
        {
            Dialogs.SortOptionsDialog sortOptions = DialogExtensions.ShowSortOptions(this, FilterGameCheatsSortOption, new List<string> { ResourceLanguage.GetString("LABEL_GAME") }, FilterGameCheatsSortOrder);

            if (sortOptions != null)
            {
                FilterGameCheatsSortOption = sortOptions.SortOption;
                FilterGameCheatsSortOrder = sortOptions.SortOrder;
                SearchGameCheats();
            }
        }

        private static DataTable DataTableGameCheats { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new(ResourceLanguage.GetString("LABEL_GAME"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_REGION"), typeof(string)),
                new(ResourceLanguage.GetString("LABEL_VERSION"), typeof(string)),
                new("Cheats", typeof(string))
            });

        private void LoadGameCheatsCategories()
        {
            ComboBoxGameCheatsFilterGame.Properties.Items.Clear();

            ComboBoxGameCheatsFilterGame.Properties.Items.Add($"<{ResourceLanguage.GetString("ALL_GAMES")}>");

            foreach (GameCheatItemData gameCheat in Database.GameCheatsPs3.GameCheats.OrderBy(x => x.Game))
            {
                ComboBoxGameCheatsFilterGame.Properties.Items.Add(gameCheat.Game);
            }
        }

        /// <summary>
        /// Get/set the sort option column.
        /// </summary>
        private string FilterGameCheatsSortOption { get; set; } = ResourceLanguage.GetString("LABEL_GAME");

        /// <summary>
        /// Get/set the sort order.
        /// </summary>
        private ColumnSortOrder FilterGameCheatsSortOrder { get; set; } = ColumnSortOrder.Ascending;

        public string FilterGameCheatsGame { get; set; } = string.Empty;

        private void ComboBoxGameCheatsFilterGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameCheatsFilterGame.SelectedIndex == 0 | ComboBoxGameCheatsFilterGame.SelectedIndex == -1)
            {
                FilterGameCheatsGame = string.Empty;
            }
            else
            {
                FilterGameCheatsGame = ComboBoxGameCheatsFilterGame.SelectedItem as string;
            }

            SearchGameCheats();
        }

        /// <summary>
        /// Load all game saves.
        /// </summary>
        public void SearchGameCheats()
        {
            LoadGameCheatsCategories();

            GridViewGameCheats.ShowLoadingPanel();

            DataTableGameCheats.Rows.Clear();

            foreach (GameCheatItemData game in Database.GameCheatsPs3.GameCheats.FindAll(x => x.Game.ContainsIgnoreCase(FilterGameCheatsGame)).OrderBy(x => x.Game))
            {
                DataTableGameCheats.Rows.Add(
                    game.Game,
                    game.Region,
                    game.Version,
                    $"{game.Cheats.Count():N0} {ResourceLanguage.GetString("LABEL_CHEATS")}");
            }

            GridControlGameCheats.DataSource = DataTableGameCheats;

            //GridViewGameCheats.Columns[0].MinWidth = 232; // Ignore column

            GridViewGameCheats.Columns[1].MinWidth = 116;
            GridViewGameCheats.Columns[1].MaxWidth = 116;

            GridViewGameCheats.Columns[2].MinWidth = 70;
            GridViewGameCheats.Columns[2].MaxWidth = 70;

            GridViewGameCheats.Columns[3].MinWidth = 84;
            GridViewGameCheats.Columns[3].MaxWidth = 84;

            GridViewGameCheats.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(GridViewGameCheats.Columns[FilterGameCheatsSortOption], FilterGameCheatsSortOrder),
            });

            GridViewGameCheats.HideLoadingPanel();

            if (GridViewGameCheats.RowCount > 0)
            {
                GridViewGameCheats.FocusedRowHandle = 0;
            }
        }

        private void GridViewGameCheats_RowClick(object sender, RowClickEventArgs e)
        {
            GameCheatItemData selectedGameCheats = Database.GameCheatsPs3.GetGameCheatById(GridViewGameCheats.GetRowCellDisplayText(e.RowHandle, GridViewGameCheats.Columns[0]), GridViewGameCheats.GetRowCellDisplayText(e.RowHandle, GridViewGameCheats.Columns[1]), GridViewGameCheats.GetRowCellDisplayText(e.RowHandle, GridViewGameCheats.Columns[2]));

            ShowGameCheats(selectedGameCheats);
        }

#endregion

    #region Show mods item's details

        private void ShowDetails(Platform platform, string category, int modId)
        {
            ModItemData modItemData = Database.GetModItem(platform, Database.CategoriesData.GetCategoryByTitle(category).CategoryType, modId);

            if (platform == Platform.PS3)
            {
                if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
                {
                    ShowGameModDetails(modId);
                }
                else if (modItemData.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
                {
                    ShowHomebrewDetails(modId);
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
            else if (platform == Platform.XBOX360)
            {
                if (modItemData.ModType == "XEX")
                {
                    ShowPluginDetails(modId);
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
        /// Set the UI with the mod details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.modItemData.Id" /> </param>
        private void ShowGameModDetails(int modId)
        {
            ModItemData modItemData = Database.GameModsPs3.GetModById(Platform.PS3, modId);

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Platform, Database.CategoriesData, modItemData);
        }

        /// <summary>
        /// Set the UI with the mod details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.modItemData.Id" /> </param>
        private void ShowHomebrewDetails(int modId)
        {
            ModItemData modItemData = Database.HomebrewPs3.GetModById(Platform.PS3, modId);

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Platform, Database.CategoriesData, modItemData);
        }

        /// <summary>
        /// Set the UI with the mod details and show the flyout panel.
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.modItemData.Id" /> </param>
        private void ShowResourceDetails(int modId)
        {
            ModItemData modItemData = Database.ResourcesPs3.GetModById(Platform.PS3, modId);

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Platform, Database.CategoriesData, modItemData);
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
            ModItemData modItemData = Database.PluginsXbox.GetModById(Platform.XBOX360, modId);

            switch (modItemData)
            {
                case null:
                    return;
            }

            DialogExtensions.ShowItemDetailsDialog(this, Platform, Database.CategoriesData, modItemData);
        }

        /// <summary>
        /// Set the UI with the game save details and show the flyout panel.
        /// </summary>
        /// <param name=ResourceLanguage.GetString("LABEL_PLATFORM")> Specifies the <see cref="PlatformPrefix" /> </param>
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
        /// Set the UI with the game save details and show the flyout panel.
        /// </summary>
        /// <param name="id"> Specifies the <see cref="GameCheatItemData.Id" /> </param>
        private void ShowGameCheats(GameCheatItemData gameCheatItem)
        {
            DialogExtensions.ShowItemGameCheatsDialog(this, gameCheatItem);
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
                            GridViewGameMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
                        }));
                    }
                    else
                    {
                        GridViewGameMods.SetRowCellValue(i, ResourceLanguage.GetString("LABEL_STATUS"), text);
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

        public void ShowTransferModsDialog(Form owner, TransferType transferType, ModItemData modItemData, DownloadFiles downloadFiles = null, string region = "")
        {
            UpdateModsRowStatus(modItemData.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("DOWNLOADING") : transferType == TransferType.InstallMods ? ResourceLanguage.GetString("INSTALLING") : ResourceLanguage.GetString("UNINSTALLING"));

            DialogExtensions.ShowTransferFilesDialog(owner, transferType, Database.CategoriesData.GetCategoryById(modItemData.CategoryId), modItemData, downloadFiles, region);
            UpdateModsRowStatus(modItemData.Id, transferType == TransferType.DownloadMods ? ResourceLanguage.GetString("LABEL_DOWNLOADED") : transferType == TransferType.InstallMods ? ResourceLanguage.GetString("LABEL_INSTALLED") : ResourceLanguage.GetString("LABEL_NOT_INSTALLED"));
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
            LabelAboutTitle.Text = $@"Arisen Mods ({UpdateExtensions.CurrentVersionName})";
            LabelAboutSubTitle.Text = string.Format(LabelAboutSubTitle.Text, GitHubAllReleases[0].PublishedAt.DateTime.ToShortDateString());
        }

        private void LabelAboutSubTitle_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
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
            NavigationItemGameMods.Visible = Platform == Platform.PS3;
            NavigationItemHomebrew.Visible = Platform == Platform.PS3;
            NavigationItemResources.Visible = Platform == Platform.PS3;
            NavigationItemPackages.Visible = Platform == Platform.PS3;
            NavigationItemPlugins.Visible = Platform == Platform.XBOX360;
#endif

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

            RibbonGroupXbdmCommands.Visible = Platform == Platform.XBOX360;
            RibbonGroupXbdmCommands.Enabled = IsConsoleConnected && Platform == Platform.XBOX360;

            // Reload Pages
            SearchGameSaves();
            SearchGameCheats();
        }

        /// <summary>
        /// Set the current connected console status in the tool strip.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            ribbonControl1.ApplicationButtonText = consoleProfile.Name;
            ConsoleProfile = consoleProfile;
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
                StatusLabelHeaderIsConnected.Caption = ResourceLanguage.GetString("CONNECTED");
                //StatusLabelHeaderIsConnected.ItemAppearance.Normal.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                StatusLabelHeaderIsConnected.Caption = ResourceLanguage.GetString("NOT_CONNECTED");
                //StatusLabelHeaderIsConnected.ItemAppearance.Normal.ForeColor = Color.FromArgb(255, 0, 0);
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
                    if (console.Id == null)
                    {
                        console.Id = DataExtensions.GenerateUniqueId();
                    }
                }

                if (Settings.EnableHardwareAcceleration)
                {
                    WindowsFormsSettings.ForceDirectXPaint();
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
            Rectangle rect = new(elementInfo.HeaderBounds.X, elementInfo.HeaderBounds.Bottom - skinElem.Size.MinSize.Height + 2, elementInfo.HeaderBounds.Width, skinElem.Size.MinSize.Height + 3);
            SkinElementInfo skinElemInfo = new(skinElem, rect);
            ObjectPainter.DrawObject(cache, SkinElementPainter.Default, skinElemInfo);
        }

        private void GridViewDownloads_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_PLATFORM"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewInstalledMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_PLATFORM"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewGameMods_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_GAME"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewHomebrew_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewResources_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewPackages_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewPlugins_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_CATEGORY"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewGameSaves_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_GAME"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void GridViewGameCheats_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == ResourceLanguage.GetString("LABEL_GAME"))
            {
                GridCellInfo cellViewInfo = e.Cell as GridCellInfo;

                int indent = cellViewInfo.Bounds.X + 7;

                cellViewInfo.CellValueRect.X = indent;
                cellViewInfo.CellValueRect.Width = cellViewInfo.Bounds.Width - indent;
            }
        }

        private void RibbonControl1_MouseDown(object sender, MouseEventArgs e)
        {
            RibbonHitInfo info = (sender as RibbonControl).CalcHitInfo(e.Location);

            if (info.HitTest == RibbonHitTest.ApplicationButton)
            {
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            }
        }
    }
}