using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;
using FluentFTP;
using ModioX.Constants;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Net;
using ModioX.Templates;
using Newtonsoft.Json;
using PS3Lib;
using XDevkit;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Windows
{
    public partial class MainWindow : XtraForm
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
        }

        /// <summary>
        /// Contains this instance of the form
        /// </summary>
        public static MainWindow Window { get; private set; }

        /// <summary>
        /// Contains the users settings Database.
        /// </summary>
        public static SettingsData Settings { get; private set; } = new();

        /// <summary>
        /// Contains the data for the mods and categories.
        /// </summary>
        public static GitHubData Database { get; private set; }

        /// <summary>
        /// Contains the mods for either PS3 or XBOX.
        /// </summary>
        public static ModsData Mods { get; private set; }

        /// <summary>
        /// Determines whether the console is currently connected.
        /// </summary>
        public static bool IsConsoleConnected { get; private set; }

        /// <summary>
        /// Contains the console profile data.
        /// </summary>
        public static ConsoleProfile ConsoleProfile { get; private set; }

        /// <summary>
        /// Contains the selected console type prefix.
        /// </summary>
        public static ConsoleTypePrefix ConsoleType { get; private set; } = ConsoleTypePrefix.PS3;

        /// <summary>
        /// Contains the Xbox console information.
        /// </summary>
        public static IXboxConsole XboxConsole { get; private set; }

        /// <summary>
        /// Determines whether webMAN is installed on the console.
        /// </summary>
        public static bool IsWebManInstalled { get; private set; }

        /// <summary>
        /// Contains the FtpClient for faster and more reliable functions.
        /// </summary>
        public static FtpClient FtpClient { get; private set; }

        /// <summary>
        /// Creates an FTP connection for use with uploading mods, not reliable for the built-in
        /// file manager.
        /// </summary>
        /// <returns> </returns>
        public static FtpConnection FtpConnection
        {
            get
            {
                NetworkCredential credential = ConsoleProfile.UseDefaultCredentials ? new NetworkCredential("anonymous", "anonymous") : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password);
                FtpConnection connection = new(ConsoleProfile.Address, ConsoleProfile.Port, credential.UserName, credential.Password);
                connection.Open();
                connection.Login(credential.UserName, credential.Password);
                return connection;
            }
        }


        /// <summary>
        /// Get the colors for the current skin.
        /// </summary>
        public static SkinColors SkinColors { get; private set; }

        /// <summary>
        /// Form loading event.
        /// </summary>
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            FlowPanelModsDetails.MouseWheel += new MouseEventHandler(FlowPanelModsDetails_MouseWheel);
            UserLookAndFeel.Default.StyleChanged += MainWindow_StyleChanged;
            WindowsFormsSettings.AllowHoverAnimation = DefaultBoolean.True;

            LoadSettings();

            SplashScreenManager.ShowSkinSplashScreen(
                title: $@"ModioX",
                subtitle: "Browse, Download and Install Mods\nfor PlayStation 3 && Xbox 360",
                footer: "Copyright © 2021" + Environment.NewLine + "All Rights Reserved.",
                loading: "Starting...",
                parentForm: this,
                useFadeIn: true,
                useFadeOut: true
            );

            Text = $@"ModioX - {UpdateExtensions.CurrentVersionName}";

            if (await HttpExtensions.CheckForInternetAsync().ConfigureAwait(true))
            {
                UpdateExtensions.CheckApplicationVersion();

                if (Settings.FirstTimeOpenAfterUpdate)
                {
                    Settings.FirstTimeOpenAfterUpdate = false;
                    DialogExtensions.ShowWhatsNewWindow(this, UpdateExtensions.GitHubData);
                }

                if (Settings.FirstTimeUse)
                {
                    Settings.FirstTimeUse = false;
                    XtraMessageBox.Show(this, "First Time Use", "It is important to read the information about this using tool before installing/uninstalling mods so that you don't have any issues. Go to Help > More Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                SetStatus("Initializing the application database...");
                await Task.Run(async () => await LoadDataAsync().ConfigureAwait(true));
                InitializeFinished();
            }
            else
            {
                XtraMessageBox.Show(this, "No Internet Detected", "You must be connected to the Internet to use this application.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        /// <summary>
        /// Save application settings, and if console is connected then closes connections.
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();

            if (!IsConsoleConnected)
            {
                return;
            }

            try
            {
                switch (ConsoleProfile.TypePrefix)
                {
                    case ConsoleTypePrefix.PS3:
                        FtpClient.Dispose();
                        FtpConnection.Dispose();
                        break;

                    case ConsoleTypePrefix.XBOX:
                        FtpClient.Dispose();
                        FtpConnection.Dispose();
                        XboxConsole.CloseConnection(0);
                        break;
                }
            }
            catch
            {
                // false positive, if console is powered off then an error will be thrown
            }
        }

        private void MainWindow_StyleChanged(object sender, EventArgs e)
        {
            if (Settings.RememberSkinOnClose)
            {
                Settings.SkinName = CommonSkins.GetSkin(LookAndFeel).Name;
            }

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
                Program.Log.Error(ex, $"Unable to load the database. Error: {ex.Message}");
                Application.Exit();
            }
        }

        /// <summary>
        /// Finalize application data after being initialized.
        /// </summary>
        private void InitializeFinished()
        {
            SetStatus("Successfully loaded the database - Finalizing application data...");

            Mods = Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? Database.ModsPS3 : Database.ModsXBOX;
            RadioGroupDatabaseType.SelectedIndex = Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? 0 : 1;

            LoadCategories();

            ComboBoxSystemType.Properties.Items.Clear();
            ComboBoxSystemType.Properties.Items.Add("ANY");

            foreach (string firmware in Mods.AllFirmwares.Where(firmware => !ComboBoxSystemType.Properties.Items.Contains(firmware)))
            {
                ComboBoxSystemType.Properties.Items.Add(firmware);
            }

            SelectedCategory = Database.CategoriesData.Categories.OrderBy(x => x.Title).First(x => x.CategoryType == CategoryType.Game);

            LoadModsByCategoryId(SelectedCategory.Id,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                IsCustomListSelected);

            TextBoxSearch.Text = string.Empty;
            ComboBoxSystemType.SelectedIndex = 0;
            ComboBoxModType.SelectedIndex = 0;
            ComboBoxRegion.SelectedIndex = 0;

            LabelModsStats.Caption = $"{Database.ModsPS3.Mods.Count} Mods for PS3 / {Database.ModsXBOX.Mods.Count} Mods for Xbox 360 (Last Updated: {Database.ModsPS3.LastUpdated.ToLocalTime().ToShortDateString()})";

            SetStatus($"Initialized ModioX ({UpdateExtensions.CurrentVersionName}) - Ready to connect to console...");

            EnableConsoleActions();
            UpdateControlColors();
            Focus();

            SplashScreenManager.CloseForm();

            /// Fade in form
            TimerFade.Interval = 10;
            TimerFade.Tick += new EventHandler(FadeIn_Tick);
            TimerFade.Start();
        }

        private readonly Timer TimerFade = new();

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                TimerFade.Stop();
            }
            else
            {
                Opacity += 0.05;
            }
        }

        private void UpdateControlColors()
        {
            PanelModsLibraryFilters.BackColor = SkinColors.GetColor("Control");
            PanelModsLibraryFilters.ForeColor = SkinColors.GetColor("HighlightText");
            FlowPanelModsDetails.BackColor = SkinColors.GetColor("Control");
            FlowPanelModsDetails.ForeColor = SkinColors.GetColor("HighlightText");
        }

        #region Header Menu Bar

        // CONNECT

        private void ButtonConnectPS3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }
            else
            {
                ConsoleProfile consoleProfile = DialogExtensions.ShowConnectionDialog(this);

                if (consoleProfile != null)
                {
                    ConsoleProfile = consoleProfile;
                    ConnectConsole();
                }
            }
        }

        private void ButtonConnectXBOX_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }
            else
            {
                ConsoleProfile consoleProfile = DialogExtensions.ShowConnectionDialog(this);

                if (consoleProfile != null)
                {
                    ConsoleProfile = consoleProfile;
                    ConnectConsole();
                }
            }
        }

        // TOOLS MENU

        // PS3

        private void ButtonPS3GameBackupFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveSettings();
            DialogExtensions.ShowGameBackupFiles(this);
            SaveSettings();
        }

        private void ButtonPS3GameUpdateFinder_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameUpdatesFinderDialog(this);
        }

        private void ButtonPS3FileManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
        }

        private void ButtonPS3PackageManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowPackageManagerWindow(this);
        }

        private void ButtonPS3ShowSystemInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebManExtensions.NotifySystemInformation(ConsoleProfile.Address);
            SetStatus($"WebMAN Controls - Successfully Notified: System Information");
        }

        private void ButtonPS3ShowTemperatures_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebManExtensions.NotifyCPURSXTemperature(ConsoleProfile.Address);
            SetStatus($"WebMAN Controls - Successfully Notified: System Temperature");
        }

        private void ButtonPS3ShowMinimumVersion_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebManExtensions.NotifyMinimumVersion(ConsoleProfile.Address);
            SetStatus($"WebMAN Controls - Successfully Notified: System Minimum Version");
        }

        private void ButtonPS3MountBD_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games list...");

            List<ListItem> games = FtpExtensions.GetGamesBD();

            if (games.Count <= 0)
            {
                SetStatus($"WebMAN Controls - No Games Found.");
                XtraMessageBox.Show("No games can be found on your console. If you have them on external devices then enable this option in the settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (BD)", games);

            if (selectedGame.IsNullOrWhiteSpace())
            {
                SetStatus($"WebMAN Controls - Mount Game Cancelled.");
                return;
            }
            else
            {
                SetStatus($"WebMAN Controls - Mounting Game: {selectedGame}");
                WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame);
                SetStatus($"WebMAN Controls - Successfully Mounted Game: {selectedGame}");
            }
        }

        private void ButtonPS3MountISO_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games list...");

            List<ListItem> games = FtpExtensions.GetGamesISO();

            if (games.Count <= 0)
            {
                SetStatus($"WebMAN Controls - No Games Found.");
                XtraMessageBox.Show("No games can be found on your console. If you have them on external devices then enable this option in the settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (ISO)", games);

            if (selectedGame.IsNullOrWhiteSpace())
            {
                SetStatus($"WebMAN Controls - Mount Game Cancelled.");
                return;
            }
            else
            {
                SetStatus($"WebMAN Controls - Mounting Game: {selectedGame}");
                WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame);
                SetStatus($"WebMAN Controls - Successfully Mounted Game: {selectedGame}");
            }
        }

        private void ButtonPS3MountPSN_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Fetching games list...");

            List<ListItem> games = FtpExtensions.GetGamesPSN();

            if (games.Count <= 0)
            {
                SetStatus($"WebMAN Controls - No Games Found.");
                XtraMessageBox.Show("No games can be found on your console. If you have them on external devices then enable this option in the settings.", "No Games Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedGame = DialogExtensions.ShowListViewDialog(this, "Games List (PSN)", games);

            if (selectedGame.IsNullOrWhiteSpace())
            {
                SetStatus($"WebMAN Controls - Mount Game Cancelled.");
                return;
            }
            else
            {
                SetStatus($"WebMAN Controls - Mounting Game: {selectedGame}");
                WebManExtensions.MountGameFromPath(ConsoleProfile.Address, selectedGame);
                SetStatus($"WebMAN Controls - Successfully Mounted Game: {selectedGame}");
            }
        }

        private void ButtonPS3Unmount_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Unmounting...");
            WebManExtensions.Unmount(ConsoleProfile.Address);
            SetStatus($"WebMAN Controls - Successfully Unmounted");
        }

        private void ButtonPS3Shutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Shutting Down Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Shutdown);
            SetStatus($"WebMAN Controls - Successfully Shutdown Console.");
            DisconnectConsole();
        }

        private void ButtonPS3Restart_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Restarting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.Restart);
            SetStatus($"WebMAN Controls - Successfully Restarted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3SoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Soft Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.SoftReboot);
            SetStatus($"WebMAN Controls - Successfully Soft Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3HardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Hard Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.HardReboot);
            SetStatus($"WebMAN Controls - Successfully Hard Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3QuickReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Quick Rebooting Console...");
            WebManExtensions.Power(ConsoleProfile.Address, WebManExtensions.PowerFlags.QuickReboot);
            SetStatus($"WebMAN Controls - Successfully Quick Rebooted Console.");
            DisconnectConsole();
        }

        private void ButtonPS3NotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:");

            if (!notifyMessage.IsNullOrWhiteSpace())
            {
                WebManExtensions.NotifyPopup(ConsoleProfile.Address, notifyMessage);
                SetStatus($"WebMAN Controls - Message Notified: {notifyMessage}");
            }
        }

        private void ButtonPS3VirtualController_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus($"WebMAN Controls - Virtual Controller Opening in Web Browser");
            Process.Start("http://pad.aldostools.org/pad.html");
            SetStatus($"WebMAN Controls - Virtual Controller Opened in Web Browser");
        }

        // XBOX

        private void ButtonXboxFileManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
        }

        private void ButtonXboxLaunchFileEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowXboxPluginsEditor(this);
        }

        private void ButtonXboxXBDMShutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Shutdown();
        }

        private void ButtonXboxXBDMRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Title);
        }

        private void ButtonXboxXBDMSoftReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Cold);
        }

        private void ButtonXboxXBDMHardReboot_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole.Reboot(string.Empty, string.Empty, string.Empty, XboxRebootFlags.Warm);
        }

        private void ButtonXboxTakeScreenshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            string filePath = DialogExtensions.ShowSaveFileDialog(this, "Save Screenshot File", "Bitmap Image (*.bmp)|*.bmp");

            if (filePath.IsNullOrWhiteSpace())
            {
                SetStatus($"No file path selected. Cancelled.");
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
                "System Temperature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonXboxXNotifyMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:");
            XboxConsole.XNotify(notifyMessage);
        }

        // OPTIONS MENU

        private void ButtonAddNewConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
            }

            SaveSettings();
            LoadSettings();
        }

        private void ButtonEditGameRegions_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameRegionsDialog(this);
            SaveSettings();
            LoadSettings();
        }

        private void ButtonEditYourLists_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowCustomListsDialog(this, IsConsoleConnected ? ConsoleProfile.TypePrefix : Settings.LoadConsoleMods);
            SaveSettings();
            LoadSettings();
            LoadListsCategories();
        }

        private void ButtonSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowSettingsWindow(this);
            SaveSettings();
            LoadSettings();
        }

        // HELP MENU

        private void ButtonReportBug_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start($"{Urls.GitHubRepo}issues/new");
        }

        private void ButtonOfficialSource_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Urls.GitHubRepo);
        }

        private void ButtonDiscordServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Urls.DiscordServer);
        }

        private void ButtonCheckForUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateExtensions.CheckApplicationVersion();
        }

        private void ButtonWhatsNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Showing latest Change Log...");
            DialogExtensions.ShowWhatsNewWindow(this, UpdateExtensions.GitHubData);
        }

        private void ButtonOpenLogFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Opening Log file...");
            string logFile = $"{UserFolders.AppLogsDirectory}latest.log";
            if (File.Exists(logFile))
            {
                try
                {
                    Process.Start(logFile);
                }
                catch (Exception ex)
                {
                    SetStatus("Failed to open Log file...", ex);
                    XtraMessageBox.Show("Failed to open the log file.\nIt may have been deleted, that's ok.", "Failed to Open Log.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SetStatus("Failed to find Log file...");
                XtraMessageBox.Show("Failed to find the log file.\nIt may have been deleted, that's ok.", "Failed to Find Log.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonOpenLogFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetStatus("Opening Log folder...");

            if (!Directory.Exists(UserFolders.AppLogsDirectory))
            {
                Directory.CreateDirectory(UserFolders.AppLogsDirectory);
            }

            Process.Start(UserFolders.AppLogsDirectory);
        }

        private void ButtonAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowAboutWindow(this);
        }

        // RIGHT MENU

        private void MenuBarItemRequestMods_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowRequestModsDialog(this);
        }

        #endregion Header Menu Bar

        #region Connect & Disconnect Console Functions

        /// <summary>
        /// Attempt to connect to the console profile by opening the FTP connection.
        /// </summary>
        public void ConnectConsole()
        {
            try
            {
                SetStatus($"Connecting to {ConsoleProfile.Name} ({ConsoleProfile.Address})...");

                using (FtpConnection ftpConnection = FtpConnection)
                {
                    ;
                }

                FtpClient = new FtpClient
                {
                    Host = ConsoleProfile.Address,
                    Port = ConsoleProfile.Port,
                    Credentials = ConsoleProfile.UseDefaultCredentials
                    ? new NetworkCredential("anonymous", "anonymous")
                    : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password)
                };

                FtpClient.Connect();

                IsConsoleConnected = true;
                SetStatusConsole(ConsoleProfile);

                if (ConsoleProfile.TypePrefix == ConsoleTypePrefix.PS3)
                {
                    IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address, ConsoleProfile.Port);

                    if (IsWebManInstalled)
                    {
                        WebManExtensions.NotifyPopup(ConsoleProfile.Address, "You are now connected to ModioX ★");
                    }

                    ConsoleType = ConsoleProfile.TypePrefix;
                    Mods = Database.ModsPS3;

                    ButtonConnectToPS3.Caption = "Disconnect from Console...";
                    ButtonConnectToXBOX.Enabled = false;
                }
                else if (ConsoleProfile.TypePrefix == ConsoleTypePrefix.XBOX)
                {
                    XboxConsole = new XboxManager().OpenConsole(ConsoleProfile.Address);
                    XboxConsole.XNotify("You are now connected to ModioX ★");

                    ConsoleType = ConsoleProfile.TypePrefix;
                    Mods = Database.ModsXBOX;

                    ButtonConnectToXBOX.Caption = "Disconnect from Console...";
                    ButtonConnectToPS3.Enabled = false;
                }

                RadioGroupDatabaseType.SelectedIndex = Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? 0 : 1;

                SetStatus("Successfully connected to console.");
                XtraMessageBox.Show("Successfully connected to console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableConsoleActions();

                // Only reload categories if the console type hasn't been changed
                if (ConsoleType != Settings.LoadConsoleMods)
                {
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Can't connect to {ConsoleProfile.Name} ({ConsoleProfile.Address}).", ex);
                XtraMessageBox.Show($"Can't connect to {ConsoleProfile.Name} ({ConsoleProfile.Address})\n\nError: {ex.Message}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disconnects from the console and flushes all resources from the FTP connections.
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus("Disconnecting from console...");

            if (ConsoleType == ConsoleTypePrefix.PS3)
            {
                try
                {
                    FtpConnection.Dispose();
                    FtpConnection.Close();

                    FtpClient.Dispose();
                }
                catch
                {
                    // False positive, if console is powered off then an error will be thrown.
                }
            }
            else if (ConsoleType == ConsoleTypePrefix.XBOX)
            {
                try
                {
                    FtpConnection.Dispose();
                    FtpConnection.Close();

                    FtpClient.Dispose();

                    XboxConsole.CloseConnection(0);
                }
                catch
                {
                    // False positive, if console is powered off then an error will be thrown.
                }
            }

            IsConsoleConnected = false;
            SetStatusConsole(null);
            EnableConsoleActions();

            ButtonConnectToPS3.Enabled = true;
            ButtonConnectToPS3.Caption = "Connect to Console...";

            ButtonConnectToXBOX.Enabled = true;
            ButtonConnectToXBOX.Caption = "Connect to Console...";

            SetStatus("Disconnected from console.");

            XtraMessageBox.Show(this, "Successfully disconnected from console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Connect & Disconnect Console Functions

        #region Search & Filtering Mods Functions

        /// <summary>
        /// Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterModsFirmware { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterModsName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the region for filtering mods.
        /// </summary>
        private string FilterModsRegion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the type for filtering mods.
        /// </summary>
        private string FilterModsType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set whether a custom list is selected by the user.
        /// </summary>
        private static bool IsCustomListSelected { get; set; }

        /// <summary>
        /// Get/set the selected game data selected by the user.
        /// </summary>
        private static Category SelectedCategory { get; set; }

        /// <summary>
        /// Get/set the selected mods info selected by the user.
        /// </summary>
        private static ModItem SelectedModItem { get; set; }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            FilterModsName = TextBoxSearch.Text;

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ComboBoxSystemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsFirmware = ComboBoxSystemType.SelectedIndex == 0 ? string.Empty : ComboBoxSystemType.SelectedItem.ToString();

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ComboBoxModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsType = ComboBoxModType.SelectedIndex == 0 ? string.Empty : ComboBoxModType.SelectedItem.ToString();

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ComboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsRegion = ComboBoxRegion.SelectedIndex == 0 ? string.Empty : ComboBoxRegion.SelectedItem.ToString();

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        #endregion Search & Filtering Mods Functions

        #region Popup Menu for Mods

        private void GridViewMods_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                GridView view = sender as GridView;
                view.FocusedRowHandle = e.HitInfo.RowHandle;

                ModsMenu.ShowPopup(Cursor.Position);
            }
        }

        private void ModsMenu_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ModItem modItem = Mods.GetModById(int.Parse(GridViewMods.GetRowCellDisplayText(GridViewMods.FocusedRowHandle, "Id")));

            ButtonModInstallFiles.Enabled = IsConsoleConnected;

            if (modItem != null)
            {
                if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
                {
                    ButtonModUninstallFiles.Enabled = Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
                }
                else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
                {
                    ButtonModUninstallFiles.Enabled = IsConsoleConnected;
                }
                else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Resource)
                {
                    ButtonModUninstallFiles.Enabled = !modItem.DownloadFiles.Any(x => x.InstallsToRebugFolder) && IsConsoleConnected;
                }
            }

            ModsMenu.DrawMenuSideStrip = DefaultBoolean.False;
        }

        private void ButtonModInstallFiles_ItemClick(object sender, EventArgs e)
        {
            ButtonModInstall.PerformClick();
        }

        private void ButtonModUninstallFiles_ItemClick(object sender, EventArgs e)
        {
            ButtonModInstall.PerformClick();
        }

        private void ButtonModDownloadArchive_ItemClick(object sender, EventArgs e)
        {
            ButtonModDownload.PerformClick();
        }

        private void ButtonModAddToList_ItemClick(object sender, EventArgs e)
        {
            string listName = DialogExtensions.ShowListViewDialog(this, "Your Lists", Settings.CustomLists.ConvertAll(x => new ListItem() { Value = x.Name, Name = x.Name }));

            if (!string.IsNullOrWhiteSpace(listName))
            {
                Category category = Database.CategoriesData.GetCategoryById(SelectedModItem.GameId);
                Settings.AddModToCustomList(listName, SelectedModItem.Id, IsConsoleConnected ? ConsoleProfile.TypePrefix : Settings.LoadConsoleMods);
                SetStatus($"{category.Title}: {SelectedModItem.Name} ({SelectedModItem.Type}) - Added to '{listName}' list.");
            }
        }

        private void ButtonModRemoveFromList_ItemClick(object sender, EventArgs e)
        {
            string listName = DialogExtensions.ShowListViewDialog(this, "Your Lists", Settings.CustomLists.ConvertAll(x => new ListItem() { Value = x.Name, Name = x.Name }));

            if (!string.IsNullOrWhiteSpace(listName))
            {
                Category category = Database.CategoriesData.GetCategoryById(SelectedModItem.GameId);
                Settings.RemoveModFromCustomList(listName, SelectedModItem.Id, IsConsoleConnected ? ConsoleProfile.TypePrefix : Settings.LoadConsoleMods);
                SetStatus($"{category.Title}: {SelectedModItem.Name} ({SelectedModItem.Type}) - Removed from '{listName}' list.");
            }
        }

        private void ButtonModReportAnIssue_ItemClick(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder()
               .Append("You will be redirected to the GitHub Issues for ModioX. All details will be filled automatically for you.\n")
               .AppendLine("Log in to GitHub and click the 'Submit' button to open a new issue so we can investigate it.");

            XtraMessageBox.Show(message.ToString(), "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplate(SelectedModItem, Database.CategoriesData.GetCategoryById(SelectedModItem.GameId));
        }

        #endregion Popup Menu for Mods

        #region MODS LIBRARY

        private void GridViewMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewMods.SelectedRowsCount != 0)
            {
                ModItem modItem = Mods.GetModById(int.Parse(GridViewMods.GetRowCellDisplayText(GridViewMods.GetSelectedRows()[0], "Id")));

                if (modItem != null)
                {
                    ShowModInformation(modItem.Id);
                }
            }

            ButtonModInstall.Enabled = GridViewMods.SelectedRowsCount != 0 && IsConsoleConnected;
            ButtonModDownload.Enabled = GridViewMods.SelectedRowsCount != 0;
            ButtonModFavorite.Enabled = GridViewMods.SelectedRowsCount != 0;
        }

        #endregion MODS LIBRARY

        #region Categories

        private void LoadCategories()
        {
            NavGroupGames.ItemLinks.Clear();
            NavGroupHomebrewApps.ItemLinks.Clear();
            NavGroupResources.ItemLinks.Clear();
            NavGroupMyLists.ItemLinks.Clear();

            foreach (Category category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                List<ModItem> modsByCategory = Mods.GetModsByCategoryId(category.Id).ToList();

                if (modsByCategory.Any() || category.Id.Equals("fvrt"))
                {
                    NavBarItem categoryItem = NavBarCategories.Items.Add();
                    categoryItem.Caption = $@"{category.Title.Replace("&", "&&")} ({(category.Id.Equals("fvrt") ? Settings.FavoritedIds.Count : modsByCategory.Count)})";
                    categoryItem.Name = category.Id;

                    switch (category.CategoryType)
                    {
                        case CategoryType.Game:
                            NavGroupGames.ItemLinks.Add(categoryItem);
                            break;

                        case CategoryType.Homebrew:
                            NavGroupHomebrewApps.ItemLinks.Add(categoryItem);
                            break;

                        case CategoryType.Resource:
                            NavGroupResources.ItemLinks.Add(categoryItem);
                            break;

                        case CategoryType.Favorite:
                            NavGroupMyLists.ItemLinks.Add(categoryItem);
                            break;
                    }
                }
            }

            foreach (CustomList customList in Settings.CustomLists.Where(x => x.ConsoleType == Settings.LoadConsoleMods))
            {
                NavBarItem gameItem = NavBarCategories.Items.Add();
                gameItem.Caption = $@"{customList.Name.Replace("&", "&&")} ({customList.ModIds.Count})";
                gameItem.Name = customList.Name;
                NavGroupMyLists.ItemLinks.Add(gameItem);
            }

            NavGroupHomebrewApps.Visible = NavGroupHomebrewApps.ItemLinks.Count > 0;
            NavGroupResources.Visible = NavGroupResources.ItemLinks.Count > 0;

            NavGroupGames.SelectedLinkIndex = 0;
            NavGroupGames.ItemLinks.First().PerformClick();
        }

        private void LoadListsCategories()
        {
            NavGroupMyLists.ItemLinks.Clear();

            foreach (Category category in Database.CategoriesData.Categories)
            {
                if (category.Id.Equals("fvrt"))
                {
                    NavBarItem gameItem = NavBarCategories.Items.Add();
                    gameItem.Caption = $@"{category.Title.Replace("&", "&&")} ({Settings.FavoritedIds.Count})";
                    gameItem.Name = category.Id;
                    NavGroupMyLists.ItemLinks.Add(gameItem);
                }
            }

            foreach (CustomList customList in Settings.CustomLists.FindAll(x => x.ConsoleType == Settings.LoadConsoleMods))
            {
                NavBarItem gameItem = NavBarCategories.Items.Add();
                gameItem.Caption = $@"{customList.Name.Replace("&", "&&")} ({customList.ModIds.Count})";
                gameItem.Name = customList.Name;
                NavGroupMyLists.ItemLinks.Add(gameItem);
            }
        }

        private void NavigationBar_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string categoryId = e.Link.ItemName;

            // Check whether item is a custom list
            bool isCustomList = Settings.CustomLists.Any(customList => customList.Name.Equals(categoryId));
            IsCustomListSelected = isCustomList;

            if (isCustomList)
            {
                CustomList customList = Settings.GetCustomListByName(categoryId, IsConsoleConnected ? ConsoleProfile.TypePrefix : Settings.LoadConsoleMods);
                SelectedCategory = new Category { Id = categoryId, Title = categoryId, Regions = Settings.GetRegionsForModIDs(Mods, customList.ModIds).ToArray() };
            }
            else
            {
                SelectedCategory = Database.CategoriesData.GetCategoryById(categoryId);
            }

            FilterModsType = string.Empty;
            FilterModsRegion = string.Empty;

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                isCustomList);

            if (string.IsNullOrEmpty(FilterModsType))
            {
                ComboBoxModType.SelectedIndex = 0;
                return;
            }

            foreach (object item in ComboBoxModType.Properties.Items)
            {
                if (item.Equals(FilterModsType))
                {
                    ComboBoxModType.SelectedIndex = ComboBoxModType.Properties.Items.IndexOf(FilterModsType);
                    return;
                }

                ComboBoxModType.SelectedIndex = 0;
                return;
            }
        }

        #endregion Categories

        #region Display Mods by Category Id with the user's filters

        private void RadioGroupDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioGroupDatabaseType.SelectedIndex == 0 && ConsoleType == ConsoleTypePrefix.PS3)
            {
                return;
            }
            else if (RadioGroupDatabaseType.SelectedIndex == 1 && ConsoleType == ConsoleTypePrefix.XBOX)
            {
                return;
            }

            switch (RadioGroupDatabaseType.SelectedIndex)
            {
                case 0:
                    ConsoleType = ConsoleTypePrefix.PS3;
                    Mods = Database.ModsPS3;
                    break;
                case 1:
                    ConsoleType = ConsoleTypePrefix.XBOX;
                    Mods = Database.ModsXBOX;
                    break;
                default:
                    break;
            }

            LoadCategories();
        }

        /// <summary>
        /// Load all mods for the specified categoryId, matching with filters: name, firmware, type, region 
        /// and region
        /// </summary>
        /// <param name="categoryId"> Filter by CategoryId </param>
        /// <param name="name"> Filter by Name </param>
        /// <param name="firmware"> Filter by Firmware </param>
        /// <param name="type"> Filter by Type </param>
        /// <param name="region"> Filter by Region </param>
        /// <param name="isCustomList"> Filter by Region </param>
        private void LoadModsByCategoryId(string categoryId, string name, string firmware, string type, string region, bool isCustomList)
        {
            LoadInstalledGameMods();

            string categoryTitle = categoryId.Equals("fvrt") || isCustomList ? categoryId : Database.CategoriesData.GetCategoryById(categoryId).Title;

            GroupModsLibrary.Text = $"MODS LIBRARY - {(categoryId.Equals("fvrt") || isCustomList ? categoryId : categoryTitle)}";

            GridControlMods.DataSource = null;

            ComboBoxModType.Properties.Items.Clear();
            ComboBoxModType.Properties.Items.Add("ANY");

            if (categoryId.Equals("fvrt"))
            {
                ComboBoxModType.Properties.Items.AddRange(Settings.GetModTypesForModIDs(Mods, Settings.FavoritedIds).ToArray());
            }
            else if (isCustomList)
            {
                ComboBoxModType.Properties.Items.AddRange(Settings.GetModTypesForModIDs(Mods, Settings.GetCustomListByName(categoryId, IsConsoleConnected ? ConsoleProfile.TypePrefix : Settings.LoadConsoleMods).ModIds).ToArray());
            }
            else
            {
                foreach (string modType in Mods.AllModTypesForCategoryId(categoryId))
                {
                    ComboBoxModType.Properties.Items.Add(modType);
                }
            }

            ComboBoxRegion.Properties.Items.Clear();
            ComboBoxRegion.Properties.Items.Add("ANY");

            if (categoryId.Equals("fvrt"))
            {
                ComboBoxRegion.Properties.Items.AddRange(Settings.GetRegionsForModIDs(Mods, Settings.FavoritedIds).ToArray());
            }
            else if (isCustomList)
            {
                ComboBoxRegion.Properties.Items.AddRange(Settings.GetRegionsForModIDs(Mods, Settings.GetCustomListByName(categoryId, IsConsoleConnected ? ConsoleProfile.TypePrefix : Settings.LoadConsoleMods).ModIds).ToArray());
            }
            else
            {
                foreach (string categoryRegion in SelectedCategory.Regions)
                {
                    ComboBoxRegion.Properties.Items.Add(categoryRegion);
                }
            }

            DataTable dt = new();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Mod Name", typeof(string));
            dt.Columns.Add("System Type", typeof(string));
            dt.Columns.Add("Mod Type", typeof(string));
            dt.Columns.Add("Region", typeof(string));
            dt.Columns.Add("Version", typeof(string));
            dt.Columns.Add("Creator", typeof(string));
            dt.Columns.Add("# of Files", typeof(string));

            foreach (ModItem modItem in Mods.GetModItems(categoryId, name, firmware, type, region, isCustomList).OrderBy(x => x.Name))
            {
                List<string> installFiles = new();

                if (modItem.DownloadFiles.Count > 1)
                {
                    installFiles.AddRange(from installPaths in modItem.DownloadFiles
                                          from installPath in installPaths.InstallPaths
                                          where !installFiles.Contains(installPath)
                                          select installPath);
                }
                else
                {
                    installFiles.AddRange(modItem.DownloadFiles.First().InstallPaths);
                }

                dt.Rows.Add(modItem.Id,
                    modItem.Name,
                    modItem.Firmware,
                    modItem.Type,
                    modItem.Region,
                    modItem.Versions.Join(" & "),
                    modItem.Author,
                    installFiles.Count() + (installFiles.Count() > 1 ? " Files" : " File"));
            }

            GridControlMods.DataSource = dt;

            GridViewMods.Columns[0].Visible = false;

            //GridViewMods.Columns[1].GetHeaderBestWidth();
            GridViewMods.Columns[2].Width = 50;
            GridViewMods.Columns[3].Width = 50;
            GridViewMods.Columns[4].Width = 45;
            GridViewMods.Columns[5].Width = 35;
            GridViewMods.Columns[6].Width = 50;
            GridViewMods.Columns[7].Width = 35;

            ProgressMods.Visible = GridViewMods.RowCount == 0;

            if (GridViewMods.RowCount > 0)
            {
                GridViewMods.SelectRow(0);
                ShowModInformation(int.Parse(GridViewMods.GetRowCellDisplayText(GridViewMods.GetSelectedRows()[0], "Id")));
            }

            ComboBoxModType.SelectedIndexChanged -= ComboBoxModType_SelectedIndexChanged;
            ComboBoxModType.SelectedIndex = string.IsNullOrEmpty(type) ? 0 : ComboBoxModType.Properties.Items.IndexOf(type);
            ComboBoxModType.SelectedIndexChanged += ComboBoxModType_SelectedIndexChanged;

            ComboBoxRegion.SelectedIndexChanged -= ComboBoxRegion_SelectedIndexChanged;
            ComboBoxRegion.SelectedIndex = string.IsNullOrEmpty(region) ? 0 : ComboBoxRegion.Properties.Items.IndexOf(region);
            ComboBoxRegion.SelectedIndexChanged += ComboBoxRegion_SelectedIndexChanged;
        }

        #endregion Load & Display Mods by Category Id with the user's filters

        #region Install, Uninstall, Download & Favorite Buttons

        private void ButtonModInstall_Click(object sender, EventArgs e)
        {
            InstallMods(SelectedModItem);
        }

        private void ButtonModUninstall_Click(object sender, EventArgs e)
        {
            CategoryType categoryType = SelectedModItem.GetCategoryType(Database.CategoriesData);

            InstalledMod installedMod;

            if (categoryType == CategoryType.Game)
            {
                installedMod = Settings.GetInstalledGameMod(SelectedModItem.GetConsoleType(), SelectedModItem.GameId);
            }
            else
            {
                installedMod = null;
            }

            if (installedMod == null)
            {
                UninstallMods(SelectedModItem);
            }
            else
            {
                UninstallMods(SelectedModItem, installedMod.Region);
            }
        }

        private void ButtonModDownload_Click(object sender, EventArgs e)
        {
            DownloadModArchive(SelectedModItem);
        }

        private void ButtonModFavorite_Click(object sender, EventArgs e)
        {
            FavoriteMod(SelectedModItem);
        }

        private void ButtonModFavorite_TextChanged(object sender, EventArgs e)
        {
            ControlExtensions.SetControlTextWidth(ButtonModFavorite, ButtonModFavorite.Text);
        }

        #endregion Install, Uninstall, Download & Favorite Buttons

        #region Installed Mods/Plugins

        private void GridViewInstalledGameMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewInstalledGameMods.SelectedRowsCount > 0)
            {
                ModItem modItem = Mods.GetModById(int.Parse(GridViewInstalledGameMods.GetRowCellDisplayText(GridViewInstalledGameMods.GetSelectedRows()[0], "Id")));

                if (modItem != null)
                {
                    ShowModInformation(modItem.Id);
                }
            }

            ButtonUninstallAllMods.Enabled = GridViewInstalledGameMods.SelectedRowsCount > 0 && IsConsoleConnected;
        }

        private void GridViewInstalledGameMods_RowClick(object sender, RowClickEventArgs e)
        {
            ButtonUninstallAllMods.Enabled = GridViewInstalledGameMods.SelectedRowsCount > 0 && IsConsoleConnected;
        }

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void LoadInstalledGameMods()
        {
            GridViewInstalledGameMods.FocusedRowChanged -= GridViewInstalledGameMods_FocusedRowChanged;

            GridControlInstalledGameMods.DataSource = null;

            int totalFiles = 0;

            DataTable dt = new();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Platform", typeof(string));
            dt.Columns.Add("Game Title", typeof(string));
            dt.Columns.Add("Game Region", typeof(string));
            dt.Columns.Add("Mod Name", typeof(string));
            dt.Columns.Add("Mod Type", typeof(string));
            dt.Columns.Add("Version", typeof(string));
            dt.Columns.Add("# Files", typeof(string));
            dt.Columns.Add("Installed On", typeof(string));

            foreach (InstalledMod installedMod in Settings.InstalledGameMods)
            {
                Category modCategory = Database.CategoriesData.GetCategoryById(installedMod.CategoryId);

                ModItem modInstalled;

                if (installedMod.ConsoleType == ConsoleTypePrefix.PS3)
                {
                    modInstalled = Database.ModsPS3.GetModById(installedMod.ModId);
                }
                else
                {
                    modInstalled = Database.ModsXBOX.GetModById(installedMod.ModId);
                }

                dt.Rows.Add(modInstalled.Id.ToString(),
                    installedMod.ConsoleType.GetDescription(),
                    modCategory.Title,
                    installedMod.Region,
                    modInstalled.Name,
                    modInstalled.Type,
                    modInstalled.Version == "n/a" ? "-" : modInstalled.Version,
                    installedMod.Files + (installedMod.Files > 1 ? " Files" : " File"),
                    $"{installedMod.DateInstalled:g}");

                totalFiles += installedMod.Files;
            }

            GridControlInstalledGameMods.DataSource = dt;
            GridViewInstalledGameMods.Columns[0].Visible = false;
            GridViewInstalledGameMods.Columns[1].Width = 50;
            GridViewInstalledGameMods.Columns[2].Width = 100;
            GridViewInstalledGameMods.Columns[3].Width = 50;
            GridViewInstalledGameMods.Columns[4].Width = 100;
            GridViewInstalledGameMods.Columns[5].Width = 50;
            GridViewInstalledGameMods.Columns[6].Width = 35;
            GridViewInstalledGameMods.Columns[7].Width = 35;
            GridViewInstalledGameMods.Columns[8].Width = 50;

            LabelModsInstalled.Text = $"{Settings.InstalledGameMods.Count} {(Settings.InstalledGameMods.Count > 1 ? "Mods" : "Mod")} Installed ({totalFiles} {(totalFiles > 1 ? "Files" : "File")} Total)";

            ButtonUninstallAllMods.Enabled = IsConsoleConnected && Settings.InstalledGameMods.Count != 0;

            ProgressInstalledMods.Visible = GridViewInstalledGameMods.RowCount == 0;

            GridViewInstalledGameMods.FocusedRowChanged += GridViewInstalledGameMods_FocusedRowChanged;
        }

        private void ButtonUninstallAllMods_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                foreach (InstalledMod installedGameMod in Settings.InstalledGameMods)
                {
                    ModItem modItem = Mods.GetModById(installedGameMod.ModId);

                    InstalledMod installedMod = Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId);
                    UninstallMods(modItem, installedMod == null ? string.Empty : installedMod.Region);
                }
            }
        }

        #endregion Installed Mods/Plugins

        #region Display Mods Information on the Right-Side Panel Function

        /// <summary>
        /// Set the UI to display the specified mod details
        /// </summary>
        /// <param name="modId"> Specifies the <see cref="ModsData.ModItem.Id" /> </param>
        private void ShowModInformation(int modId)
        {
            ModItem modItem = Mods.GetModById(modId);

            if (modItem == null)
            {
                return;
            }

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelName.Text = modItem.Name.Replace("&", "&&");
            LabelCategory.Text = Database.CategoriesData.GetCategoryById(Mods.GetModById(modId).GameId).Title;
            LabelType.Text = modItem.Type;
            LabelVersion.Text = modItem.Versions.Join(" & ").Replace("&", "&&");
            LabelFirmware.Text = modItem.Firmware;
            LabelRegion.Text = string.Join(", ", modItem.GameRegions);
            LabelAuthor.Text = modItem.Author.Replace("&", "&&");
            LabelSubmittedBy.Text = modItem.SubmittedBy.Replace("&", "&&");
            LabelGameType.Text = string.Join(", ", modItem.GameModes);
            LabelDescription.Text = string.IsNullOrWhiteSpace(modItem.Description)
                ? "Can't find any other details yet."
                : modItem.Description.Replace("&", "&&");

            // Append extra information for modded game saves in the description
            if (modItem.IsGameSave)
            {
                StringBuilder extraDescription = new StringBuilder("\n---------------------------------------------\n")
                    .AppendLine("Important Notes for Installing Game Saves:\n")
                    .AppendLine("- You must have at least one USB device connected to the console before installing the game save files.\n")
                    .Append("- It's suggested to use 'Apollo Tool' (Homebrew > Applications) for patching and resigning game save files directly on your console.");

                LabelDescription.Text += extraDescription.ToString();
            }

            GridControlModsInstallFiles.DataSource = null;

            DataTable dt = new();
            dt.Columns.Add(string.Empty, typeof(string));

            if (modItem.DownloadFiles.Count > 1)
            {
                GroupInstallFiles.Text = $"DOWNLOADS ({modItem.DownloadFiles.Count()})";
                modItem.DownloadFiles.ForEach(x => dt.Rows.Add($"{x.Name} ({x.InstallPaths.Count} {(x.InstallPaths.Count() == 1 ? "File" : "Files")})"));
            }
            else
            {
                GroupInstallFiles.Text = $"FILES ({modItem.DownloadFiles.First().InstallPaths.Count()})";
                modItem.DownloadFiles.First().InstallPaths.ForEach(x => dt.Rows.Add(x));
            }

            GridControlModsInstallFiles.DataSource = dt;

            ButtonModInstall.Enabled = IsConsoleConnected;

            if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
            {
                ButtonModUninstall.Enabled = Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
                ButtonModUninstallFiles.Enabled = Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
            }
            else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
            {
                ButtonModUninstall.Enabled = IsConsoleConnected;
                ButtonModUninstallFiles.Enabled = IsConsoleConnected;
            }
            else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Resource)
            {
                ButtonModUninstall.Enabled = !modItem.DownloadFiles.Any(x => x.InstallsToRebugFolder) && IsConsoleConnected;
                ButtonModUninstallFiles.Enabled = !modItem.DownloadFiles.Any(x => x.InstallsToRebugFolder) && IsConsoleConnected;
            }

            ButtonModFavorite.Text = Settings.FavoritedIds.Contains(modItem.Id) ? "Unfavorite" : "Favorite";

            UpdateScrollBars();
        }

        private void FlowPanelModsDetails_MouseWheel(object sender, MouseEventArgs e)
        {
            ScrollBarModInformation.Value = FlowPanelModsDetails.VerticalScroll.Value;
        }

        private void FlowPanelDetails_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarModInformation.Value = FlowPanelModsDetails.VerticalScroll.Value;
        }

        private void ScrollBarModInformation_Scroll(object sender, ScrollEventArgs e)
        {
            FlowPanelModsDetails.VerticalScroll.Value = ScrollBarModInformation.Value;
            FlowPanelModsDetails.Refresh();
        }

        private void UpdateScrollBars()
        {
            FlowPanelModsDetails.HorizontalScroll.Visible = false;
            FlowPanelModsDetails.VerticalScroll.Visible = false;

            ScrollBarModInformation.Visible = FlowPanelModsDetails.VerticalScroll.Visible;
            ScrollBarModInformation.Minimum = FlowPanelModsDetails.VerticalScroll.Minimum;
            ScrollBarModInformation.Maximum = FlowPanelModsDetails.VerticalScroll.Maximum;
            ScrollBarModInformation.SmallChange = FlowPanelModsDetails.VerticalScroll.SmallChange;
            ScrollBarModInformation.LargeChange = FlowPanelModsDetails.VerticalScroll.LargeChange;
            ScrollBarModInformation.Value = FlowPanelModsDetails.VerticalScroll.Value;
        }

        #endregion Show Mod's Information on the Right-Side Panel Function

        #region Install, Uninstall, Download & Favorite Functions

        /// <summary> Install the specified <paramref name="modItem"/> files. </summary> <param
        /// name="modItem">The <see cref="ModsData.ModItem"/> to install.<param>
        public void InstallMods(ModItem modItem)
        {
            Category category = Database.CategoriesData.GetCategoryById(modItem.GameId);
            string categoryTitle = category.Title;

            string gameRegion;
            string userId;
            string usbDevice;

            DownloadFiles downloadFiles;

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Preparing to install files...");

            // Check whether this mod is already installed
            InstalledMod installedGameMod = Settings.InstalledGameMods.FirstOrDefault(gameMod => gameMod.CategoryId.Equals(modItem.GameId, StringComparison.OrdinalIgnoreCase) && gameMod.ModId.Equals(modItem.Id));

            if (installedGameMod != null)
            {
                StringBuilder message = new StringBuilder("You have already installed ")
                    .AppendLine($"'{modItem.Name} v{modItem.Version}' to '{category.Title}'")
                    .Append("Do you want to reinstall the files again?");

                if (XtraMessageBox.Show(message.ToString(), "Files Already Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                    return;
                }
            }

            if (ConsoleType == ConsoleTypePrefix.PS3)
            {
                // Checks whether a mod is already installed to the same game then uninstall it
                InstalledMod modInstalled = Settings.GetInstalledGameMod(modItem.GetConsoleType(), category.Id);

                if (modInstalled != null)
                {
                    ModItem currentModItem = Mods.GetModById(modInstalled.ModId);

                    StringBuilder message = new StringBuilder($"'{currentModItem.Name} v{currentModItem.Version} ({currentModItem.Type})'")
                        .AppendLine($" is currently installed to: {category.Title}\n")
                        .Append("Multiple mods installed could possibly conflict with each other. Do you want to uninstall the current one?");

                    if (XtraMessageBox.Show(message.ToString(), "Mods Already Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        UninstallMods(Mods.GetModById(modInstalled.ModId), modInstalled.Region);
                    }
                }

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting archive download link...");
                downloadFiles = modItem.GetDownloadFiles();

                if (downloadFiles == null)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No archive download selected. Installation cancelled.");
                    return;
                }

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found archive download link.");

                // Check whether mods are being installed to the firmware folder and let the user
                // know if they want to cancel
                if (downloadFiles.InstallsToRebugFolder)
                {
                    StringBuilder message = new StringBuilder("Files are being installed to the firmware folder (dev_rebug), ")
                            .Append("which is for REBUG Custom Firmware only.")
                            .Append("It's recommended to create a backup of the entire ")
                            .Append("folder before installing any files.")
                            .Append("Also ensure that you're running Rebug custom firmware ")
                            .Append("and that the REBUG TOOLBOX application is open before proceeding.")
                            .AppendLine("Any missing or incorrect files in this folder ")
                            .Append("can impact your console performance.")
                            .AppendLine("If you have issues after rebooting console then you must enter ")
                            .Append("recovery mode and reinstall your custom firmware. ")
                            .Append("Only continue at your own risk and only if you know what you're doing.\n")
                            .AppendLine("Do you want to install the files?");

                    if (XtraMessageBox.Show(message.ToString(), "Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                        return;
                    }
                }

                try
                {
                    // Check whether a game region must be provided to install
                    if (downloadFiles.RequiresGameRegion)
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching region...");

                        gameRegion = category.GetGameRegion(modItem.GameId);
                        categoryTitle = $"{category.Title} ({gameRegion})";

                        if (string.IsNullOrEmpty(gameRegion))
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No region selected. Installation cancelled.");
                            return;
                        }

                        if (!modItem.IsAnyRegion && !modItem.Region.Equals(gameRegion))
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Region isn't supported. Installation cancelled.");
                            return;
                        }

                        if (Settings.RememberGameRegions)
                        {
                            Settings.UpdateGameRegion(modItem.GameId, gameRegion);
                        }

                        // Check whether the game update for this region exists
                        if (!FtpExtensions.GetFolderNames("/dev_hdd0/game/").Any(x => x.Name.Contains(gameRegion)))
                        {
                            XtraMessageBox.Show("Game update folder for this region cannot be found on your console.\nYou must install the correct update for this game or maybe you specified the wrong region.", "Can't Find Game Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region.");
                    }
                    else
                    {
                        gameRegion = string.Empty;
                    }

                    // Check whether a user id must be provided and prompts the user to choose one
                    if (downloadFiles.RequiresUserId)
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching user id...");

                        userId = FtpExtensions.GetUserProfileId(this);
                        categoryTitle = $"{category.Title} ({userId})";

                        if (string.IsNullOrEmpty(userId))
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No user id selected. Installation cancelled.");
                            return;
                        }

                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found user id.");
                    }
                    else
                    {
                        userId = string.Empty;
                    }

                    // If it's a game save then alert the user that a USB device must be connected
                    // to console.
                    if (downloadFiles.RequiresUsbDevice)
                    {
                        if (modItem.IsGameSave)
                        {
                            if (XtraMessageBox.Show("Before installing this game save you must have completed the following steps:\n- Insert your USB device to any port on the console.\n- Install the Apollo Tool PKG from the Homebrew Packages category on your console to unlock, patch and resign save-game files directly on your PS3."
                                    + "\nThis will only work if you have your USB device connected. Click 'Yes' if you have done this. Otherwise click 'No' and this game-save will not be installed.", "Installing Game Saves",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                                DialogResult.Yes)
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");

                                usbDevice = FtpExtensions.GetUsbPath();
                                categoryTitle = $"{category.Title} ({usbDevice})";

                                if (string.IsNullOrEmpty(usbDevice))
                                {
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device connected. Installation cancelled.");
                                    return;
                                }

                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");
                            }
                            else
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            if (XtraMessageBox.Show("One or more files needs to be installed at a USB device that is connected to your console. It could be required for the mods to work, such as a configuration or plugin file. I suggest you read the complete description for more details on this."
                                    + "\nTo allow for these files to be installed, you must have a USB inserted before you continue. Would you like to proceed, click 'Yes' to continue. Otherwise click 'No' and all USB files will be ignored.", "Installing Files to USB",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");

                                usbDevice = FtpExtensions.GetUsbPath();
                                categoryTitle = $"{category.Title} ({gameRegion})";

                                if (string.IsNullOrEmpty(usbDevice))
                                {
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device connected. Installation cancelled.");
                                    return;
                                }

                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");
                            }
                            else
                            {
                                usbDevice = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        usbDevice = string.Empty;
                    }

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloading and extracting files archive...");
                    modItem.DownloadInstallFiles(downloadFiles);
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloaded and extracted files archive.");

                    int indexFiles = 1;
                    int totalFiles = downloadFiles.InstallPaths.Count;

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Starting install...");

                    foreach (string installFilePath in downloadFiles.InstallPaths)
                    {
                        // Install folders
                        foreach (string localFolderPath in Directory.GetDirectories(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                        {
                            if (!Path.HasExtension(installFilePath))
                            {
                                if (installFilePath.Contains(localFolderPath.Replace(modItem.DownloadDataDirectory(downloadFiles), string.Empty).Replace(@"\", "/")))
                                {
                                    if (!FtpClient.DirectoryExists(installFilePath))
                                    {
                                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating folder: {installFilePath}");

                                        if (FtpExtensions.CreateDirectory(installFilePath))
                                        {
                                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created folder.");
                                        }
                                    }
                                }
                            }
                        }

                        // Install files
                        foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                        {
                            string installFileName = Path.GetFileName(installFilePath);

                            string installPath = installFilePath
                                .Replace("{REGION}", gameRegion)
                                .Replace("{USERID}", userId)
                                .Replace("{USBDEV}", usbDevice);

                            string parentDirectoryPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                            // Create parent directory if it doesn't exist on the console
                            if (!FtpClient.DirectoryExists(parentDirectoryPath))
                            {
                                FtpExtensions.CreateDirectory(parentDirectoryPath);
                            }

                            /*if (installPath.Contains("dev_hdd0/tmp/"))
                            {
                                // Create all the parent directories in the /tmp folder
                                if (!FtpClient.DirectoryExists(installFilePathWithoutFileName))
                                {
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating directories: {installFilePathWithoutFileName}");
                                    FtpExtensions.CreateDirectories(installFilePathWithoutFileName);
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created directories.");
                                }
                            }*/

                            // Check whether install file matches the specified install file
                            if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                            {
                                // Check whether this file is installed to a game folder
                                if (installPath.Contains("dev_hdd0/game/"))
                                {
                                    // Get the backup details for this game file if one has been created
                                    BackupFile backupFile = Settings.GetGameFileBackup(modItem.GameId, installFileName, installPath);

                                    // A backup hasn't been created for this file, so it will be
                                    // ignored and kept alone - in case issues occur with the game
                                    if (backupFile == null)
                                    {
                                        // Alert the user there is no backup for this file and ask
                                        // the user if one would like to be created
                                        if (XtraMessageBox.Show("Would you like to backup the current game file? This will be restored when you choose to uninstall.\n\nGame File Name: " +
                                            Path.GetFileName(installFilePath), "Backup File", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        {
                                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating backup of file: {installFileName}...");
                                            Settings.CreateBackupFile(modItem, installFileName, installPath);
                                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created backup file.");

                                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                            FtpExtensions.UploadFile(localFilePath, installPath);
                                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");
                                            indexFiles++;
                                        }
                                        else
                                        {
                                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                            FtpExtensions.UploadFile(localFilePath, installPath);
                                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                            indexFiles++;
                                        }
                                    }
                                    // Install the local file, like SPRX or key files
                                    else
                                    {
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                        FtpExtensions.UploadFile(localFilePath, installPath);
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                        indexFiles++;
                                    }
                                }
                                // Check whether file is installed to a USB device
                                else if (installFilePath.Contains("{USBDEV}"))
                                {
                                    if (!string.IsNullOrEmpty(usbDevice))
                                    {
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                        FtpExtensions.UploadFile(localFilePath, installPath);
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                        indexFiles++;
                                    }
                                }
                                // Otherwise, install the file as normal
                                else
                                {
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                    FtpExtensions.UploadFile(localFilePath, installPath);
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                    indexFiles++;
                                }
                            }
                        }

                        if (category.CategoryType == CategoryType.Homebrew)
                        {
                            Settings.UpdateInstalledPackageFile(modItem.Id, installFilePath, modItem.Version, downloadFiles);
                        }
                    }

                    // Update the installed game mods, if this isn't for a game save
                    if (category.CategoryType == CategoryType.Game && !modItem.IsGameSave)
                    {
                        Settings.UpdateInstalledGameMod(ConsoleProfile.TypePrefix, category.Id, modItem.Id, gameRegion, indexFiles - 1, DateTime.Now, downloadFiles);
                    }

                    if (IsWebManInstalled)
                    {
                        WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{categoryTitle}\nInstalled: {modItem.Name} ({indexFiles - 1} files)");
                    }

                    // Log status
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed {indexFiles - 1} files.");
                    XtraMessageBox.Show($"Successfully installed {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {categoryTitle}" : "")}{(category.CategoryType == CategoryType.Game ? "\nReady to start game." : string.Empty)}", "Success");
                }
                catch (Exception ex)
                {
                    SetStatus($"Error installing files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                    XtraMessageBox.Show($"An error occurred installing files for {modItem.Name} (#{modItem.Id}). You can open an issue to help us fix this by navigating to 'Help > Report Bug' and attach the log.txt file, which can be found in the installation path." + "\nError Message: " + ex.Message, "Unable to Install Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ConsoleType == ConsoleTypePrefix.XBOX)
            {
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting archive download link...");
                downloadFiles = modItem.GetDownloadFiles();

                if (downloadFiles == null)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No archive download selected. Installation cancelled.");
                    return;
                }

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found archive download link.");

                try
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloading and extracting files archive...");
                    modItem.DownloadInstallFiles(downloadFiles);
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloaded and extracted files archive.");

                    int indexFiles = 1;
                    int totalFiles = downloadFiles.InstallPaths.Count;

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Starting install...");

                    foreach (string installFilePath in downloadFiles.InstallPaths)
                    {
                        // Install folders
                        foreach (string localFolderPath in Directory.GetDirectories(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                        {
                            if (!Path.HasExtension(installFilePath))
                            {
                                if (installFilePath.Contains(localFolderPath.Replace(modItem.DownloadDataDirectory(downloadFiles), string.Empty).Replace(@"\", "/")))
                                {
                                    if (!FtpClient.DirectoryExists(installFilePath))
                                    {
                                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating folder: {installFilePath}");

                                        if (FtpExtensions.CreateDirectory(installFilePath))
                                        {
                                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created folder.");
                                        }
                                    }
                                }
                            }
                        }

                        // Install files
                        foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                        {
                            string installFileName = Path.GetFileName(installFilePath);

                            string parentDirectoryPath = Path.GetDirectoryName(installFilePath).Replace(@"\", "/");

                            // Create parent directory if it doesn't exist on the console
                            if (!FtpClient.DirectoryExists(parentDirectoryPath))
                            {
                                FtpExtensions.CreateDirectory(parentDirectoryPath);
                            }

                            // Check whether install file matches the specified install file
                            if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                XboxConsole.SendFile(localFilePath, installFilePath);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                indexFiles++;
                            }
                        }
                    }

                    // Update the installed game mods and plugins
                    Settings.UpdateInstalledGameMod(ConsoleProfile.TypePrefix, category.Id, modItem.Id, "", indexFiles - 1, DateTime.Now, downloadFiles);
                    SaveSettings();
                    LoadInstalledGameMods();

                    // Log status
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed {indexFiles - 1} files.");
                    XtraMessageBox.Show($"Successfully installed {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {categoryTitle}." : ".")}{(category.CategoryType == CategoryType.Game ? "\nReady to start game." : string.Empty)}", "Success");
                }
                catch (WebException ex)
                {
                    SetStatus($"Error installing files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                    XtraMessageBox.Show($"An error occurred installing files for {modItem.Name} (#{modItem.Id}). You can open an issue to help us fix this by navigating to 'Help > Report Bug' and attaching the log.txt file located in the installation path." + "\n\nError Message: " + ex.Message, "Unable to Install Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    SetStatus($"Error installing files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                    XtraMessageBox.Show($"An error occurred installing files for {modItem.Name} (#{modItem.Id}). You can open an issue to help us fix this by navigating to 'Help > Report Bug' and attaching the log.txt file located in the installation path." + "\n\nError Message: " + ex.Message, "Unable to Install Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Uninstall all of the files for the <paramref name="modItem" />.
        /// </summary>
        /// <param name="modItem"> Mod details from the <see cref="ModsData.ModItem" /> </param>
        /// <param name="region"> Game region </param>
        public void UninstallMods(ModItem modItem, string region = "")
        {
            Category category = Database.CategoriesData.GetCategoryById(modItem.GameId);
            string categoryTitle = category.Title;

            string gameRegion;
            string userId;
            string usbDevice;

            DownloadFiles downloadFiles;

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Preparing to uninstall files...");

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting previous install details...");

            InstalledMod installedMod;

            if (category.CategoryType == CategoryType.Game)
            {
                installedMod = Settings.GetInstalledGameMod(modItem.GetConsoleType(), modItem.GameId);
            }
            else
            {
                installedMod = null;
            }

            // Can't find the previous install details
            if (installedMod == null)
            {
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No previous install found. Fetching download files...");
                gameRegion = region;
                downloadFiles = modItem.GetDownloadFiles();
            }
            else
            {
                gameRegion = installedMod.Region;
                downloadFiles = installedMod.DownloadFiles;
            }

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found download files.");

            if (ConsoleType == ConsoleTypePrefix.PS3)
            {
                try
                {
                    // Alerts the user that uninstalling files from dev_rebug folders isn't allowed
                    if (downloadFiles.InstallsToRebugFolder)
                    {
                        XtraMessageBox.Show("You cannot uninstall files from the firmware folder. Any missing files could affect your console performance.", "Forbidden",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Cancelled installation.");
                        return;
                    }

                    // If a game region isn't provided already, then prompt the user to choose one
                    if (!string.IsNullOrWhiteSpace(region))
                    {
                        gameRegion = region;
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region: {gameRegion}");
                    }

                    // Check whether a game region needs to be provided if one hasn't been already
                    if (downloadFiles.RequiresGameRegion && string.IsNullOrWhiteSpace(region))
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching region...");
                        gameRegion = category.GetGameRegion(modItem.GameId);
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region: {gameRegion}");

                        if (string.IsNullOrEmpty(gameRegion))
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No region selected. Cancelled installation.");
                            return;
                        }

                        if (Settings.RememberGameRegions)
                        {
                            Settings.UpdateGameRegion(modItem.GameId, gameRegion);
                        }
                    }
                    else
                    {
                        gameRegion = region;
                    }

                    // Whether or not a UserId is required and prompt the user to choose one
                    if (downloadFiles.RequiresUserId)
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching user ID...");

                        userId = FtpExtensions.GetUserProfileId(this);

                        if (string.IsNullOrEmpty(userId))
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No user ID selected. Cancelled installation.");
                            return;
                        }

                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found user ID: {userId}");
                    }
                    else
                    {
                        userId = string.Empty;
                    }

                    // If this mod requires a usb device to be connected to console, ask the user
                    // whether they want to continue with this
                    if (downloadFiles.RequiresUsbDevice)
                    {
                        // If this is a modded gamesave then inform the user they must remove the
                        // gamesave from their usb themselves
                        if (modItem.IsGameSave)
                        {
                            XtraMessageBox.Show("You can't uninstall games saves. You must remove the game save folder from your USB device or use the XMB menu.", "Can't Uninstall");
                            return;
                        }

                        // Inform the user a USB device must be connected for the mods
                        if (XtraMessageBox.Show(
                            "Some files may have been files to be installed to a USB device. You can either choose to uninstall them now or manually delete them yourself." +
                            "\n\nIf you would like to uninstall the files, then connect the same USB device to your console and click 'Yes' to continue." +
                            "\n\nIf you wouldn't like to uninstall the files from your USB device, then click 'No' and all of these files will be ignored.", "Uninstalling USB File",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");
                            usbDevice = FtpExtensions.GetUsbPath();
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device found. Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            usbDevice = string.Empty;
                        }
                    }
                    else
                    {
                        usbDevice = string.Empty;
                    }

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling files...");

                    int indexFiles = 1;
                    int totalFiles = downloadFiles.InstallPaths.Count();

                    // Loop through the install file paths
                    foreach (string installFilePath in downloadFiles.InstallPaths)
                    {
                        // Format install file path with specified info: region/userId/USB
                        string installPath = installFilePath
                            .Replace("{REGION}", $"{gameRegion}")
                            .Replace("{USERID}", $"{userId}")
                            .Replace("{USBDEV}", $"{usbDevice}");

                        string installFilePathWithoutFileName = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                        // Uninstall files
                        if (Path.HasExtension(installPath))
                        {
                            // Check whether file is being installed to game update folder
                            if (installPath.Contains("dev_hdd0/game/"))
                            {
                                // Get the backup details for this game file if one has been created
                                BackupFile backupFile = Settings.GetGameFileBackup(modItem.GameId, Path.GetFileName(installPath), installPath);

                                // Check whether a backup has been created for this game file
                                if (backupFile != null)
                                {
                                    // Check whether the backup file exists on users computer
                                    if (File.Exists(backupFile.LocalPath))
                                    {
                                        // Install the backup file to the original game file path
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing backup file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) to {installFilePathWithoutFileName})");
                                        FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed backup file.");
                                        indexFiles++;
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show($"You have created a game file backup, but the file: {Path.GetFileName(installPath)} can't be found on your computer. " +
                                            "If you have moved this file then navigate to Tools > Game Backup Files and set the local file again. If this file has been deleted, " +
                                            "you should delete the game backup file data and re-backup the file again. For now, this file will be not be uninstalled to prevent any issues with missing game files for the game.", "No File Exists",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    XtraMessageBox.Show($"You do have a backup for file: {Path.GetFileName(installPath)} so it can't be uninstalled. This file will be ignored to prevent any issues with missing game files. To restore the file to original then you must reinstall the game update.", "No Game Backup File",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {installFilePathWithoutFileName}");
                                FtpExtensions.DeleteFile(FtpClient, installPath);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled file.");
                                indexFiles++;
                            }
                        }
                    }

                    foreach (string installPath in downloadFiles.InstallPaths)
                    {
                        if (!Path.HasExtension(installPath))
                        {
                            try
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleting folder: {installPath}");
                                FtpExtensions.DeleteDirectory(FtpClient, installPath);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully deleted folder.");
                            }
                            catch (Exception ex)
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Unable to delete folder. Error: {ex.Message}", ex);
                            }
                        }
                    }

                    // Delete empty folders from the /tmp folder
                    foreach (string installPath in downloadFiles.InstallPaths.Where(x => x.Contains("dev_hdd0/tmp/")))
                    {
                        string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                        if (!parentFolderPath.Equals("/dev_hdd0/tmp/"))
                        {
                            if (FtpClient.DirectoryExists(parentFolderPath) && FtpExtensions.IsDirectoryEmpty(FtpClient, parentFolderPath))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleting folder: {installPath}");
                                FtpExtensions.DeleteDirectory(FtpClient, parentFolderPath);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully deleted folder.");
                            }
                        }
                    }

                    // Remove data from settings if this isn't a game save.
                    if (category.CategoryType == CategoryType.Game && !modItem.IsGameSave)
                    {
                        Settings.RemoveInstalledGameMod(modItem.GetConsoleType(), category.Id);
                        SaveSettings();
                        LoadInstalledGameMods();
                    }

                    if (IsWebManInstalled)
                    {
                        WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{categoryTitle}\nUninstalled: {modItem.Name} ({indexFiles - 1} files)");
                    }

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled {indexFiles - 1} files.");
                    XtraMessageBox.Show($"Successfully uninstalled: {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {categoryTitle}." : string.Empty)}", "Installed Files");
                }
                catch (Exception ex)
                {
                    SetStatus($"Error uninstalling files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                    XtraMessageBox.Show($"An error occurred installing files for {modItem.Name} (#{modItem.Id}). You can open an issue to help us fix this by navigating to 'Help > Report Bug' and attach the log.txt file, which can be found in the installation path." + "\nError Message: " + ex.Message, "Unable to Uninstall Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ConsoleType == ConsoleTypePrefix.XBOX)
            {
                try
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling files...");

                    int indexFiles = 1;
                    int totalFiles = downloadFiles.InstallPaths.Count();

                    // Loop through the install file paths
                    foreach (string installFilePath in downloadFiles.InstallPaths)
                    {
                        string installFilePathWithoutFileName = Path.GetDirectoryName(installFilePath).Replace(@"\", "/");

                        // Uninstall files
                        if (Path.HasExtension(installFilePath))
                        {
                            // Check whether file is being installed to game update folder
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling file: {Path.GetFileName(installFilePath)} ({indexFiles}/{totalFiles}) from {installFilePathWithoutFileName}");
                            FtpExtensions.DeleteFile(FtpClient, installFilePath);
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled file.");
                            indexFiles++;
                        }
                    }

                    // Uninstall folders
                    foreach (string installPath in downloadFiles.InstallPaths)
                    {
                        if (!Path.HasExtension(installPath))
                        {
                            try
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleting folder: {installPath}");
                                FtpExtensions.DeleteDirectory(FtpClient, installPath);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully deleted folder.");
                            }
                            catch (Exception ex)
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Unable to delete folder. Error: {ex.Message}", ex);
                            }
                        }
                    }

                    // Remove from installed game mods and plugins
                    Settings.RemoveInstalledGameMod(ConsoleProfile.TypePrefix, category.Id, modItem.Id);
                    SaveSettings();
                    LoadInstalledGameMods();

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled {indexFiles - 1} files.");
                    XtraMessageBox.Show($"Successfully uninstalled: {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {categoryTitle}." : string.Empty)}", "Installed Files");
                }
                catch (Exception ex)
                {
                    SetStatus($"Error uninstalling files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                    XtraMessageBox.Show($"An error occurred installing files for {modItem.Name} (#{modItem.Id}). You can open an issue to help us fix this by navigating to 'Help > Report Bug' and attach the log.txt file, which can be found in the installation path." + "\nError Message: " + ex.Message, "Unable to Uninstall Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Download the modded files archive to the user's specified path.
        /// </summary>
        /// <param name="modItem"> </param>
        private void DownloadModArchive(ModItem modItem)
        {
            Category category = Database.CategoriesData.GetCategoryById(modItem.GameId);
            string categoryTitle = category.Title;

            DownloadFiles download;

            try
            {
                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Downloading archive...");

                download = modItem.GetDownloadFiles();

                if (download == null)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Download archive cancelled.");
                    return;
                }

                string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the archive.");

                if (folderPath != null)
                {
                    modItem.DownloadArchiveAtPath(Database.CategoriesData, download, folderPath);
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Successfully downloaded archive at path: {folderPath}");
                    Process.Start(folderPath);
                }
                else
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Download archive cancelled.");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download archive {categoryTitle}: {modItem.Name} ({modItem.Id}). Error:  {ex.Message}", ex);
                XtraMessageBox.Show(this, "An error occurred downloading files archive. (Access maybe denied at this path, try a different folder). See log file for more information about this issue." + "\nError Message: " + ex.Message, "Unable to Download Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adds or removes the specified <see cref="ModsData.ModItem" /> to the users favorites list.
        /// </summary>
        /// <param name="modItem"> </param>
        private void FavoriteMod(ModItem modItem)
        {
            Category category = Database.CategoriesData.GetCategoryById(modItem.GameId);

            string categoryTitle = category.Title;

            if (Settings.FavoritedIds.Contains(modItem.Id))
            {
                Settings.FavoritedIds.Remove(modItem.Id);

                if (SelectedCategory.Id.Equals("fvrt"))
                {
                    ShowModInformation(SelectedModItem.Id);
                }

                SetStatus($"{categoryTitle}: {modItem.Name} ({ modItem.Type}) - Removed from favorites list.");
            }
            else
            {
                Settings.FavoritedIds.Add(modItem.Id);

                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Added to favorites list.");
            }

            ButtonModFavorite.Text = Settings.FavoritedIds.Contains(modItem.Id) ? "Unfavorite" : "Favorite";
        }

        #endregion Install, Uninstall, Download & Favorite Functions

        /// <summary>
        /// Enable or disable console-only actions.
        /// </summary>
        private void EnableConsoleActions()
        {
            // PS3 Features
            ButtonPS3GameBackupFiles.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3 || Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonPS3GameBackupFiles.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3;

            ButtonPS3GameUpdateFinder.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3 || Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonPS3GameUpdateFinder.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3;

            ButtonPS3FileManager.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3 || Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonPS3FileManager.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3;

            ButtonPS3PackageManager.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3 || Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonPS3PackageManager.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3;

            ButtonPS3WebManControls.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.PS3 || Settings.LoadConsoleMods == ConsoleTypePrefix.PS3 ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonPS3WebManControls.Enabled = IsConsoleConnected && IsWebManInstalled && ConsoleType == ConsoleTypePrefix.PS3;

            // Xbox Features
            ButtonXboxFileManager.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.XBOX || Settings.LoadConsoleMods == ConsoleTypePrefix.XBOX ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonXboxFileManager.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.XBOX;

            ButtonXboxPluginsEditor.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.XBOX || Settings.LoadConsoleMods == ConsoleTypePrefix.XBOX ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonXboxPluginsEditor.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.XBOX;

            ButtonXboxXBDMMenu.Visibility = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.XBOX || Settings.LoadConsoleMods == ConsoleTypePrefix.XBOX ? BarItemVisibility.Always : BarItemVisibility.Never;
            ButtonXboxXBDMMenu.Enabled = IsConsoleConnected && ConsoleType == ConsoleTypePrefix.XBOX;

            // Install & Uninstall Features
            ButtonModInstall.Enabled = IsConsoleConnected;

            if (ButtonModUninstall.Enabled)
            {
                ButtonModUninstall.Enabled = IsConsoleConnected;
            }
        }

        /// <summary>
        /// Set the current connected console status in the tool strip.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            LabelConsoleConnected.Caption = consoleProfile == null ? "Idle" : consoleProfile.ToString();
        }

        /// <summary>
        /// Set the current process status in the tool strip.
        /// </summary>
        /// <param name="status"> </param>
        /// <param name="ex"> </param>
        public void SetStatus(string status, Exception ex = null)
        {
            LabelStatus.Caption = status;

            switch (ex)
            {
                case null:
                    Program.Log.Info(status);
                    break;

                default:
                    Program.Log.Error(ex, status);
                    break;
            }
        }

        /// <summary>
        /// Load application settings from a Json file.
        /// </summary>
        public void LoadSettings()
        {
            try
            {
                SetStatus("Loading settings data...");

                if (!File.Exists(UserFolders.AppSettingsFile))
                {
                    SetStatus("Settings file doesn't exist, a new one has been created.");
                    return;
                }

                using (StreamReader streamReader = new(UserFolders.AppSettingsFile))
                {
                    Settings = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                }

                SetStatus("Successfully loaded settings file.");

                if (Settings.RememberSkinOnClose)
                {
                    UserLookAndFeel.Default.SetSkinStyle(Settings.SkinName);
                }

                if (Settings.ConsoleProfiles.Count <= 0)
                {
                    Settings.ConsoleProfiles.Add(
                        new ConsoleProfile
                        {
                            Name = "Default Console",
                            Type = Models.Resources.ConsoleType.PlayStation3Fat,
                            TypePrefix = ConsoleTypePrefix.PS3,
                            Address = "192.168.0.42",
                            Port = 21,
                            Username = string.Empty,
                            Password = string.Empty,
                            UseDefaultCredentials = true
                        });
                }
            }
            catch (Exception ex)
            {
                SetStatus("Unable to load settings file. A new one have been created and the application will be restarted. Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "There is a problem loading the settings file. A new one have been created and the application will be restarted.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Settings = new SettingsData();
                SaveSettings();
                Application.Restart();
            }
        }

        /// <summary>
        /// Save application settings to a Json file.
        /// </summary>
        public void SaveSettings()
        {
            try
            {
                SetStatus("Saving settings file...");

                if (!Directory.Exists(UserFolders.AppDataDirectory))
                {
                    Directory.CreateDirectory(UserFolders.AppDataDirectory);
                }

                using (StreamWriter streamWriter = new(UserFolders.AppSettingsFile))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(Settings));
                }

                SetStatus("Successfully saved settings file.");
            }
            catch (Exception ex)
            {
                SetStatus("Unable to save settings file. Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "There is a problem saving the settings file. A new one will be created on the next startup.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonModsOffsets_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowModsOffsetsDialog(this);
        }
    }
}