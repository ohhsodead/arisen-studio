using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using FluentFTP;
using ModioX.Constants;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Net;
using ModioX.Properties;
using ModioX.Templates;
using Newtonsoft.Json;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Windows
{
    public partial class MainWindow : DarkForm
    {
        /// <summary>
        ///     Initialize application
        /// </summary>
        public MainWindow()
        {
            Window = this;
            InitializeComponent();
        }

        /// <summary>
        ///     Get/set the current instance of the MainWindow
        /// </summary>
        public static MainWindow Window { get; private set; }

        /// <summary>
        ///     Contains the users settings Database.
        /// </summary>
        public static SettingsData Settings { get; private set; } = new SettingsData();

        /// <summary>
        ///     Contains the data for the mods and categories.
        /// </summary>
        public static DropboxData Database { get; private set; }

        /// <summary>
        ///     Contains the console profile data.
        /// </summary>
        public static ConsoleProfile ConsoleProfile { get; private set; }


        /// <summary>
        ///     Creates an FTP connection for use with uploading mods, not reliable for the built-in file manager.
        /// </summary>
        /// <returns></returns>
        public static FtpConnection FtpConnection
        {
            get
            {
                NetworkCredential ftpCredentials = ConsoleProfile.UseDefaultCredentials
                    ? new NetworkCredential("anonymous", "anonymous")
                    : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password);
                FtpConnection ftpConnection = new FtpConnection(ConsoleProfile.Address, ConsoleProfile.Port, ftpCredentials.UserName, ftpCredentials.Password);
                ftpConnection.Open();
                ftpConnection.Login(ftpCredentials.UserName, ftpCredentials.Password);
                return ftpConnection;
            }
        }

        /// <summary>
        ///     Conntains the FtpClient for faster and more reliable functions.
        /// </summary>
        public static FtpClient FtpClient { get; private set; }

        /// <summary>
        ///     Determines whether the console is currently connected.
        /// </summary>
        public static bool IsConsoleConnected { get; private set; }

        /// <summary>
        ///     Determines whether webMAN is installed on the console.
        /// </summary>
        public static bool IsWebManInstalled { get; private set; }

        /// <summary>
        ///     Get/set the selected game data selected by the user.
        /// </summary>
        private static CategoriesData.Category SelectedCategory { get; set; }

        /// <summary>
        ///     Get/set the selected mods info selected by the user.
        /// </summary>
        private static ModsData.ModItem SelectedModItem { get; set; }

        /// <summary>
        ///     Get/set the name for filtering mods.
        /// </summary>
        private string FilterModsName { get; set; } = "";

        /// <summary>
        ///     Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterModsFirmware { get; set; } = "";

        /// <summary>
        ///     Get/set the type for filtering mods.
        /// </summary>
        private string FilterModsType { get; set; } = "";

        /// <summary>
        ///     Get/set the region for filtering mods.
        /// </summary>
        private string FilterModsRegion { get; set; } = "";

        /// <summary>
        ///     Form loading event.
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            ControlExtensions.SetValuesOnSubItems(MainMenuStrip.Items.OfType<ToolStripMenuItem>().ToList());

            Text = $@"ModioX - {UpdateExtensions.CurrentVersionName}";

            LoadSettings();
            EnableConsoleActions();

            SetStatus("Checking for Internet connection...");
            if (HttpExtensions.IsConnectedToInternet())
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
                    _ = DarkMessageBox.Show(this, "It is important to read the information about this using tool before installing/uninstalling mods so that you don't have any issues. Go to Help Menu > More Information.", "First Time Use", MessageBoxIcon.Information);
                }

                SetStatus("Initializing the application database...");
                WorkerExtensions.RunWorkAsync(LoadData, InitializeFinished);
            }
            else
            {
                _ = DarkMessageBox.Show(this, "You must be connected to the Internet to use this application.", "No Internet", MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        /// <summary>
        ///     Save application settings on form closing event.
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        ///     Update scrollbars when the form is resized.
        /// </summary>
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            UpdateScrollBarCategories();
            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     Retrieves the categories and mods into the application.
        /// </summary>
        private static void LoadData()
        {
            try
            {
                Database = new DropboxData();
            }
            catch (Exception ex)
            {
                Program.Log.Error($"Unable to load database. Error: {ex.Message}", ex);
                Application.Exit();
            }
        }

        /// <summary>
        ///     Finalize application data after being initialized.
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded the database - Finalizing application data...");

            LoadCategories();

            ComboBoxSystemType.Items.Clear(); _ = ComboBoxSystemType.Items.Add("ANY");

            foreach (string firmware in Database.Mods.AllFirmwares)
            {
                if (!ComboBoxSystemType.Items.Contains(firmware))
                {
                    _ = ComboBoxSystemType.Items.Add(firmware);
                }
            }

            SelectedCategory = Database.Categories.Categories.OrderBy(x => x.Title).First(x => x.CategoryType == CategoryType.Game);

            LoadModsByCategoryId(SelectedCategory.Id,
                "",
                "",
                "",
                "");

            ComboBoxSystemType.SelectedIndex = 0;

            ToolStripLabelStats.Text = $"{Database.Mods.TotalGameMods(Database.Categories)} Mods for {Database.Categories.TotalGames} Games, {Database.Mods.TotalHomebrew(Database.Categories)} Homebrew Packages && {Database.Mods.TotalResources(Database.Categories)} Resources (Last Updated: {Database.Mods.LastUpdated.ToLocalTime().ToShortDateString()})";

            SetStatus($"Initialized ModioX ({UpdateExtensions.CurrentVersionName}) - Ready to connect to console...");

            _ = Focus();
        }

        /// <summary>
        ///     Connect to the console profile and opens the FTP connections.
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

                SetStatusConsole(ConsoleProfile);
                IsConsoleConnected = true;

                MenuStripConnectPS3Console.Text = "Disconnect from console...";
                SetStatus($"Successfully connected to console.");

                IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address, ConsoleProfile.Port);

                if (IsWebManInstalled)
                {
                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, "You are now connected to ModioX ★");
                }

                LoadInstalledGameMods();
                EnableConsoleActions();

                DarkMessageBox.Show(this, "Successfully connected to console.", "Success", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Can't connect to {ConsoleProfile.Name} ({ConsoleProfile.Address}).", ex);
                _ = DarkMessageBox.Show(this, $"Can't connect to {ConsoleProfile.Name}. Error: {ex.Message}", "Connection Failed", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Disconnects from the console and releases all resources from the FTP connections.
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus($"Disconnecting from {ConsoleProfile.Name} ({ConsoleProfile.Address})...");

            FtpConnection.Dispose();
            FtpConnection.Close();

            FtpClient.Disconnect();
            FtpClient.Dispose();

            IsConsoleConnected = false;
            SetStatusConsole(null);
            EnableConsoleActions();

            MenuStripConnectPS3Console.Text = "Connect to console...";

            SetStatus("Disconnected from console.");

            DarkMessageBox.Show(this, "Successfully disconnected from console.", "Success", MessageBoxIcon.Information);
        }

        private void MenuStripConnectPS3Console_Click(object sender, EventArgs e)
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

        private void MenuStripConnectExit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void MenuItemToolsBackupFileManager_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowGameBackupFiles(this);
            SaveSettings();
        }

        private void MenuItemToolsGameUpdateFinder_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowGameUpdatesFinderDialog(this);
        }

        private void MenuItemToolsWebManShutdown_Click(object sender, EventArgs e)
        {
            DisconnectConsole();
            WebManExtensions.Shutdown(ConsoleProfile.Address);
        }

        private void MenuItemToolsWebManRestart_Click(object sender, EventArgs e)
        {
            DisconnectConsole();
            WebManExtensions.Restart(ConsoleProfile.Address);
        }

        private void MenuItemToolsWebManSoftReboot_Click(object sender, EventArgs e)
        {
            DisconnectConsole();
            WebManExtensions.RebootSoft(ConsoleProfile.Address);
        }

        private void MenuItemToolsWebManHardReboot_Click(object sender, EventArgs e)
        {
            DisconnectConsole();
            WebManExtensions.RebootHard(ConsoleProfile.Address);
        }

        private void MenuToolStripWebManShowSystemInformation_Click(object sender, EventArgs e)
        {
            WebManExtensions.NotifySystemInformation(ConsoleProfile.Address);
        }

        private void MenuItemToolsWebManShowCPURSX_Click(object sender, EventArgs e)
        {
            WebManExtensions.NotifyCPURSXTemperature(ConsoleProfile.Address);
        }

        private void MenuItemToolsWebManShowMinVersion_Click(object sender, EventArgs e)
        {
            WebManExtensions.NotifyMinimumVersion(ConsoleProfile.Address);
        }

        private void MenuItemToolsWebManNotify_Click(object sender, EventArgs e)
        {
            var notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:", "");

            if (!string.IsNullOrWhiteSpace(notifyMessage))
            {
                WebManExtensions.NotifyPopup(ConsoleProfile.Address, notifyMessage);
            }
        }

        private void MenuItemToolsWebManVirtualController_Click(object sender, EventArgs e)
        {
            Process.Start("http://pad.aldostools.org/pad.html");
        }

        private void MenuItemToolsFileManager_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
        }

        private void MenuItemApplications_Click(object sender, EventArgs e)
        {
            string menuItemText = ((ToolStripMenuItem)sender).Text;

            foreach (ExternalApplication application in Settings.ExternalApplications.Where(application => application.Name.Equals(menuItemText)))
            {
                if (File.Exists(application.FileLocation))
                {
                    _ = Process.Start(application.FileLocation);
                }
                else
                {
                    _ = DarkMessageBox.Show(this,
                        $"Could not locate file at location: {application.FileLocation} for application: {application.Name}\n\nGo to Settings > Edit Applications and set the correct file path for this application.",
                        "Application File Not Found", MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemOptionsSettings_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowSettingsWindow(this);
            SaveSettings();
        }

        private void MenuItemSettingsAddNewConsole_Click(object sender, EventArgs e)
        {
            SaveSettings();

            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
            }

            SaveSettings();
            LoadSettings();
        }

        private void MenuItemSettingsEditGameRegions_Click(object sender, EventArgs e)
        {
            SaveSettings();

            DialogExtensions.ShowGameRegionsDialog(this);

            SaveSettings();
            LoadSettings();
        }

        private void MenuItemSettingsEditExternalApplications_Click(object sender, EventArgs e)
        {
            SaveSettings();

            DialogExtensions.ShowExternalApplicationsDialog(this);

            SaveSettings();
            LoadSettings();
        }

        private void MenuItemSettingsResetAllOptions_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this,
                "Do you really want to reset all of your settings to default? This cannot be undone.", "Reset Settings",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SettingsData oldSettings = Settings; // Current user settings
                SettingsData newSettings = new SettingsData(); // New user settings

                if (IsConsoleConnected)
                {
                    if (Settings.InstalledGameMods.Count > 0)
                    {
                        if (DarkMessageBox.Show(this,
                            "There are mods installed that will not be saved after you reset your settings. Would you like to uninstall the mods? (Recommended)",
                            "Installed Mods", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {
                                foreach (ModsData.ModItem modItem in Settings.InstalledGameMods.Select(gameModInstalled => Database.Mods.GetModById(gameModInstalled.ModId)))
                                {
                                    UninstallMods(modItem, Settings.GetInstalledGameModRegion(modItem.GameId));
                                }
                            }
                            catch (Exception ex)
                            {
                                Program.Log.Error("Unable to uninstall mods.", ex);
                                _ = DarkMessageBox.Show(this,
                                    "Unable to uninstall mods. See log file for more information.",
                                    "Error Uninstalling Mods", MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    // If user isn't connected to console then we won't remove the installed mods data
                    newSettings.InstalledGameMods = oldSettings.InstalledGameMods;
                }

                Settings = newSettings;
                _ = DarkMessageBox.Show(this,
                    "Your settings have been reset. ModioX will now restart to apply these changes.", "All Settings Reset",
                    MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void MenuStripHelpReportBugSuggestions_Click(object sender, EventArgs e)
        {
            _ = Process.Start($"{Urls.GitHubRepo}issues/new");
        }

        private void MenuItemHelpOfficialSourceCode_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Urls.GitHubRepo);
        }

        private void MenuItemHelpDiscordServer_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://discord.gg/6TBtu8b");
        }

        private void MenuStripHelpCheckForUpdates_Click(object sender, EventArgs e)
        {
            UpdateExtensions.CheckApplicationVersion();
        }

        private void MenuStripHelpAbout_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowAboutWindow(this);
        }

        private void MenuStripItemRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Initializing application database...");

            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }

            SaveSettings();
            LoadSettings();

            WorkerExtensions.RunWorkAsync(LoadData, InitializeFinished);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterModsName = TextBoxSearch.Text;

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion);
        }

        private void ComboBoxFirmware_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsFirmware = ComboBoxSystemType.SelectedIndex == 0 ? "" : ComboBoxSystemType.GetItemText(ComboBoxSystemType.SelectedItem);

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion);
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsType = ComboBoxModType.SelectedIndex == 0 ? "" : ComboBoxModType.GetItemText(ComboBoxModType.SelectedItem);

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion);
        }

        private void ComboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsRegion = ComboBoxRegion.SelectedIndex == 0 ? "" : ComboBoxRegion.GetItemText(ComboBoxRegion.SelectedItem);

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion);
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ModsData.ModItem modItem = Database.Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                if (modItem != null)
                {
                    DisplayModDetails(modItem.Id);
                }
            }

            ToolItemModInstall.Enabled = DgvMods.CurrentRow != null && IsConsoleConnected;
            ToolItemModDownload.Enabled = DgvMods.CurrentRow != null;
            ToolItemModAddToFavorite.Enabled = DgvMods.CurrentRow != null;
        }

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ModsData.ModItem modItem = Database.Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                if (modItem != null)
                {
                    DisplayModDetails(modItem.Id);
                }

                if (DgvMods.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
                {
                    if (IsConsoleConnected)
                    {
                        InstallMods(modItem);
                    }
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
                {
                    DownloadModArchive(modItem);
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
                {
                    AddModToFavorites(modItem);

                    DgvMods.CurrentRow.Cells[10].Value = ImageExtensions.ResizeBitmap(Settings.FavoritedIds.Contains(modItem?.ToString()) ? Resources.filled_heart : Resources.heart, 20, 20);
                }
            }

            ToolItemModInstall.Enabled = DgvMods.CurrentRow != null && IsConsoleConnected;
            ToolItemModDownload.Enabled = DgvMods.CurrentRow != null;
            ToolItemModAddToFavorite.Enabled = DgvMods.CurrentRow != null;
        }

        private void ContextMenuModsInstallToConsole_Click(object sender, EventArgs e)
        {
            ToolItemModInstall.PerformClick();
        }

        private void ContextMenuModsUninstallFromConsole_Click(object sender, EventArgs e)
        {
            ToolItemModUninstall.PerformClick();
        }

        private void ContextMenuModsDownloadArchive_Click(object sender, EventArgs e)
        {
            ToolItemModDownload.PerformClick();
        }

        private void ContextMenuModsReportOnGitHub_Click(object sender, EventArgs e)
        {
            _ = DarkMessageBox.Show(this,
                "You will be directed to the GitHub Issues tracking page for ModioX. All of the details will be auto-filled for you. Create or login with your GitHub account and click the 'Submit' button to open a new issue for us to investigate this issue.",
                "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplate(SelectedModItem, Database.Categories.GetCategoryById(SelectedModItem.GameId));
        }

        private void DgvModsInstalled_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvGameModsInstalled.CurrentRow != null)
            {
                ModsData.ModItem modItem = Database.Mods.GetModById(int.Parse(DgvGameModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                DisplayModDetails(modItem.Id);
            }
        }

        private void DgvModsInstalled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvGameModsInstalled.CurrentRow != null)
            {
                ModsData.ModItem modItem = Database.Mods.GetModById(int.Parse(DgvGameModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                DisplayModDetails(modItem.Id);

                if (DgvGameModsInstalled.CurrentCell.ColumnIndex.Equals(8))
                {
                    if (IsConsoleConnected)
                    {
                        UninstallMods(modItem, Settings.GetInstalledGameMod(modItem.GameId).Region);
                    }
                }
            }
        }

        private void ToolItemUninstallAllGameMods_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                foreach (InstalledMod installedGameMod in Settings.InstalledGameMods)
                {
                    ModsData.ModItem modItem = Database.Mods.GetModById(installedGameMod.ModId);

                    InstalledMod installedMod = Settings.GetInstalledGameMod(modItem.GameId);
                    UninstallMods(modItem, installedMod == null ? "" : installedMod.Region);
                }
            }
        }

        private void ToolStripInstallFiles_Click(object sender, EventArgs e)
        {
            InstallMods(SelectedModItem);
        }

        private void ToolStripUninstallFiles_Click(object sender, EventArgs e)
        {
            CategoryType categoryType = SelectedModItem.GetCategoryType(Database.Categories);
            InstalledMod installedMod;

            if (categoryType == CategoryType.Game)
            {
                installedMod = Settings.GetInstalledGameMod(SelectedModItem.GameId);
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

        private void ToolStripDownloadArchive_Click(object sender, EventArgs e)
        {
            DownloadModArchive(SelectedModItem);
        }

        private void ToolStripFavorite_Click(object sender, EventArgs e)
        {
            AddModToFavorites(SelectedModItem);
        }

        private void LoadCategories()
        {
            PanelGames.Controls.Clear();
            PanelHomebrew.Controls.Clear();
            PanelResources.Controls.Clear();
            PanelLists.Controls.Clear();

            foreach (CategoriesData.Category category in Database.Categories.Categories.OrderBy(x => x.Title))
            {
                ModsData.ModItem[] modsByCategory = Database.Mods.GetModsByCategoryId(category.Id);

                if (modsByCategory.Length > 0 || category.Id.Equals("fvrt"))
                {
                    // Mods Category Title
                    Label categoryTitle = new Label
                    {
                        Name = category.Id,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Margin = new Padding(0, 0, 0, 0),
                        Padding = new Padding(2, 0, 0, 0),
                        Font = new Font("Segoe UI", 9F),
                        Size = new Size(PanelGames.Width, 24),
                        Cursor = Cursors.Hand,
                        BackColor = Color.Transparent,
                        ForeColor = Color.Gainsboro,
                        Text = $@"{category.Title.Replace("&", "&&")} ({(category.Id.Equals("fvrt") ? Settings.FavoritedIds.Count : modsByCategory.Length)})"
                    };

                    categoryTitle.Click += CategoryTitle_Click;
                    categoryTitle.MouseEnter += CategoryTitle_MouseEnter;
                    categoryTitle.MouseLeave += CategoryTitle_MouseLeave;

                    if (category.CategoryType == CategoryType.Game)
                    {
                        PanelGames.Controls.Add(categoryTitle);
                    }
                    else if (category.CategoryType == CategoryType.Homebrew)
                    {
                        PanelHomebrew.Controls.Add(categoryTitle);
                    }
                    else if (category.CategoryType == CategoryType.Resource)
                    {
                        PanelResources.Controls.Add(categoryTitle);
                    }
                    else if (category.CategoryType == CategoryType.Favorite)
                    {
                        PanelLists.Controls.Add(categoryTitle);
                    }
                }
            }

            UpdateScrollBarCategories();
        }

        private void CategoryTitle_Click(object sender, EventArgs e)
        {
            SelectedCategory = Database.Categories.GetCategoryById(((Label)sender).Name);

            FilterModsType = "";
            FilterModsRegion = "";

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion);

            ComboBoxModType.SelectedIndex = string.IsNullOrEmpty(FilterModsType)
                ? 0
                : ComboBoxModType.FindStringExact(FilterModsType);
        }

        private void CategoryTitle_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(75, 110, 175);
        }

        private void CategoryTitle_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SelectedCategory.Id.Equals(((Label)sender).Name)
                ? Color.FromArgb(75, 110, 175)
                : Color.FromArgb(60, 63, 65);
        }

        /// <summary>
        ///     Loads all the mods for the specified gameId, matching with filters: name, firmware, type and region
        /// </summary>
        /// <param name="categoryId">Filter by GameId</param>
        /// <param name="name">Filter by Name</param>
        /// <param name="firmware">Filter by Firmware</param>
        /// <param name="type">Filter by Type</param>
        /// <param name="region">Filter by Region</param>
        private void LoadModsByCategoryId(string categoryId, string name, string firmware, string type, string region)
        {
            UpdateCategoryTitles();
            LoadInstalledGameMods();

            DgvMods.Rows.Clear();

            ComboBoxModType.Items.Clear();
            _ = ComboBoxModType.Items.Add("ANY");
            foreach (string modType in Database.Mods.AllModTypesForCategoryId(categoryId))
            {
                ComboBoxModType.Items.Add(modType);
            }

            ComboBoxRegion.Items.Clear();
            _ = ComboBoxRegion.Items.Add("ANY");
            foreach (string categoryRegion in SelectedCategory.Regions)
            {
                ComboBoxRegion.Items.Add(categoryRegion);
            }

            foreach (ModsData.ModItem modItem in Database.Mods.GetModItems(categoryId, name, firmware, type, region).OrderBy(x => x.Name))
            {
                List<string> installFiles = new List<string>();

                if (modItem.DownloadFiles.Count() > 1)
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

                DgvMods.Rows.Add(modItem.Id,
                modItem.Name,
                modItem.Firmware,
                modItem.Type,
                modItem.Region,
                modItem.Versions.Join(" & "),
                modItem.Author,
                installFiles.Count() + (installFiles.Count() > 1 ? " Files" : " File"),
                ImageExtensions.ResizeBitmap(Resources.install, 20, 20),
                ImageExtensions.ResizeBitmap(Resources.download_from_the_cloud, 20, 20),
                Settings.FavoritedIds.Contains(modItem.Id.ToString())
                    ? ImageExtensions.ResizeBitmap(Resources.filled_heart, 20, 20)
                    : ImageExtensions.ResizeBitmap(Resources.heart, 20, 20));
            }

            LabelNoModsFound.Visible = DgvMods.Rows.Count == 0;

            if (DgvMods.Rows.Count > 0)
            {
                DgvMods.CurrentCell = DgvMods[1, 0];
                DisplayModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
                DgvMods.Enabled = true;
            }
            else
            {
                DgvMods.Enabled = false;
            }

            ComboBoxModType.SelectedIndexChanged -= ComboBoxType_SelectedIndexChanged;
            ComboBoxModType.SelectedIndex = string.IsNullOrEmpty(type) ? 0 : ComboBoxModType.Items.IndexOf(type);
            ComboBoxModType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;

            ComboBoxRegion.SelectedIndexChanged -= ComboBoxRegion_SelectedIndexChanged;
            ComboBoxRegion.SelectedIndex = string.IsNullOrEmpty(region) ? 0 : ComboBoxRegion.Items.IndexOf(region);
            ComboBoxRegion.SelectedIndexChanged += ComboBoxRegion_SelectedIndexChanged;
        }

        /// <summary>
        ///     Load all of the currently installed game mods
        /// </summary>
        public void LoadInstalledGameMods()
        {
            DgvGameModsInstalled.Rows.Clear();

            int totalFiles = 0;

            foreach (InstalledMod installedMod in Settings.InstalledGameMods)
            {
                CategoriesData.Category modCategory = Database.Categories.GetCategoryById(installedMod.CategoryId);

                ModsData.ModItem modInstalled = Database.Mods.GetModById(installedMod.ModId);

                _ = DgvGameModsInstalled.Rows.Add(modInstalled.Id.ToString(),
                    modCategory.Title,
                    installedMod.Region,
                    modInstalled.Name,
                    modInstalled.Type,
                    modInstalled.Version == "n/a" ? "-" : modInstalled.Version,
                    installedMod.Files + (installedMod.Files > 1 ? " Files" : " File"),
                    $"{installedMod.DateInstalled:g}",
                    ImageExtensions.ResizeBitmap(Resources.uninstall, 20, 20));

                totalFiles += installedMod.Files;
            }

            LabelInstalledGameModsStatus.Text = $@"{Settings.InstalledGameMods.Count} Mods Installed ({totalFiles} {(Settings.InstalledGameMods.Count > 1 ? "Files" : "File")} Total)";

            ToolItemGameModsUninstallAll.Enabled = IsConsoleConnected && Settings.InstalledGameMods.Count > 0;

            LabelNoModsInstalled.Visible = DgvGameModsInstalled.Rows.Count == 0;
        }

        /// <summary>
        ///     Set the UI to display the specified mod details
        /// </summary>
        /// <param name="modId">Specifies the <see cref="ModsData.ModItem.Id" /></param>
        private void DisplayModDetails(int modId)
        {
            ModsData.ModItem modItem = Database.Mods.GetModById(modId);

            if (modItem == null)
            {
                return;
            }

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelName.Text = modItem.Name.Replace("&", "&&");
            LabelCategory.Text = Database.Categories.GetCategoryById(Database.Mods.GetModById(modId).GameId).Title;
            LabelType.Text = modItem.Type;
            LabelVersion.Text = modItem.Versions.Join(" & ").Replace("&", "&&");
            LabelFirmware.Text = modItem.Firmware;
            LabelRegion.Text = string.Join(", ", modItem.GameRegions);
            LabelAuthor.Text = modItem.Author.Replace("&", "&&");
            LabelSubmittedBy.Text = modItem.SubmittedBy.Replace("&", "&&");
            LabelConfig.Text = string.Join(", ", modItem.GameModes);
            LabelDescription.Text = string.IsNullOrWhiteSpace(modItem.Description)
                ? "Can't find any other details yet."
                : modItem.Description.Replace("&", "&&");

            // Append extra information for modded game saves in the description
            if (modItem.IsGameSave)
            {
                LabelDescription.Text +=
                    @"

---------------------------------------------

Important Notes for Installing Game Saves:

- You must have at least one USB device connected to the console before installing the game save files.
- It's suggested to use 'Apollo Tool' (find under Homebrew > Applications) for patching and resigning game save files directly on your console.";
            }

            DgvInstallationFiles.Rows.Clear();

            if (modItem.DownloadFiles.Count() > 1)
            {
                LabelHeaderInstallationFiles.Text = $"DOWNLOADS ({modItem.DownloadFiles.Count()})";
                modItem.DownloadFiles.ForEach(x => DgvInstallationFiles.Rows.Add($"{x.Name} ({x.InstallPaths.Count} {(x.InstallPaths.Count() == 1 ? "File" : "Files")})"));
            }
            else
            {
                LabelHeaderInstallationFiles.Text = $"INSTALL FILES ({modItem.DownloadFiles.First().InstallPaths.Count()})";
                modItem.DownloadFiles.First().InstallPaths.ForEach(x => DgvInstallationFiles.Rows.Add(x));
            }

            ToolItemModInstall.Enabled = IsConsoleConnected;

            if (modItem.GetCategoryType(Database.Categories) == CategoryType.Game)
            {
                ToolItemModUninstall.Enabled = Settings.GetInstalledGameMod(modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
                ContextMenuModsUninstallFiles.Enabled = Settings.GetInstalledGameMod(modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
            }
            else if (modItem.GetCategoryType(Database.Categories) == CategoryType.Homebrew)
            {
                ToolItemModUninstall.Enabled = IsConsoleConnected;
                ContextMenuModsUninstallFiles.Enabled = IsConsoleConnected;
            }
            else if (modItem.GetCategoryType(Database.Categories) == CategoryType.Resource)
            {
                ToolItemModUninstall.Enabled = !modItem.DownloadFiles.Any(x => x.IsInstallToRebugFolder) && IsConsoleConnected;
                ContextMenuModsUninstallFiles.Enabled = !modItem.DownloadFiles.Any(x => x.IsInstallToRebugFolder) && IsConsoleConnected;
            }

            ToolItemModAddToFavorite.Image = Settings.FavoritedIds.Contains(modItem.Id.ToString())
                ? ImageExtensions.ResizeBitmap(Resources.filled_heart, 20, 20)
                : ImageExtensions.ResizeBitmap(Resources.heart, 20, 20);
            ToolItemModAddToFavorite.Text = Settings.FavoritedIds.Contains(modItem.Id.ToString()) ? "Unfavorite" : "Favorite";
            ToolItemModAddToFavorite.AutoSize = false;
            ToolItemModAddToFavorite.AutoSize = true;

            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     Changes the category titles to the selected/non-selected colors.
        /// </summary>
        private void UpdateCategoryTitles()
        {
            foreach (object ctrl in PanelGames.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name)
                    ? Color.FromArgb(75, 110, 175)
                    : Color.FromArgb(60, 63, 65);
            }

            foreach (object ctrl in PanelHomebrew.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name)
                    ? Color.FromArgb(75, 110, 175)
                    : Color.FromArgb(60, 63, 65);
            }

            foreach (object ctrl in PanelResources.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name)
                    ? Color.FromArgb(75, 110, 175)
                    : Color.FromArgb(60, 63, 65);
            }

            foreach (object ctrl in PanelLists.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name)
                    ? Color.FromArgb(75, 110, 175)
                    : Color.FromArgb(60, 63, 65);
            }
        }

        /// <summary>
        ///     Update the categories scrollbar properties.
        /// </summary>
        private void UpdateScrollBarCategories()
        {
            ScrollBarCategories.Minimum = FlowPanelCategories.VerticalScroll.Minimum;
            ScrollBarCategories.Maximum = FlowPanelCategories.VerticalScroll.Maximum;
            ScrollBarCategories.ViewSize = FlowPanelCategories.VerticalScroll.LargeChange - 30;
            ScrollBarCategories.Value = 0;
            ScrollBarCategories.UpdateScrollBar();
        }

        /// <summary>
        ///     Update the mods details scrollbar properties.
        /// </summary>
        private void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        private void FlowPanelDetails_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                ScrollBarDetails.Value = FlowPanelDetails.VerticalScroll.Value + 10;
            }
            catch
            {
                // ignored
            }
        }

        private void FlowPanelCategories_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                ScrollBarCategories.Value = FlowPanelCategories.VerticalScroll.Value + 10;
            }
            catch
            {
                // ignored
            }
        }

        private void ScrollBarCategories_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            try
            {
                FlowPanelCategories.VerticalScroll.Value = ScrollBarCategories.Value;
                FlowPanelCategories.Update();
            }
            catch
            {
                // ignored
            }
        }

        private void ScrollBarDetails_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            try
            {
                FlowPanelDetails.VerticalScroll.Value = ScrollBarDetails.Value;
                FlowPanelDetails.Update();
            }
            catch
            {
                // ignored
            }
        }

        private void FlowPanelDetails_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                ScrollBarDetails.Value = FlowPanelDetails.VerticalScroll.Value;
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        ///     Install the specified <paramref name="modItem"/> files.
        /// </summary>
        /// <param name="modItem">The <see cref="ModsData.ModItem"/> to install.<param>
        private void InstallMods(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Database.Categories.GetCategoryById(modItem.GameId);

            string gameTitle = category.Title;

            string gameRegion;
            string userId;
            string usbDevice;

            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Preparing to install files...");

            // Check whether this mod is already installed
            foreach (InstalledMod installedGameMod in Settings.InstalledGameMods)
            {
                if (string.Equals(installedGameMod.CategoryId, modItem.GameId, StringComparison.CurrentCultureIgnoreCase) && installedGameMod.ModId.Equals(modItem.Id))
                {
                    if (DarkMessageBox.Show(this,
                        $"You have already installed: '{modItem.Name} v{modItem.Version}' to: '{category.Title}'" +
                        "\nDo you want to reinstall the files again?", "Files Already Installed",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                        return;
                    }
                }
            }

            // Checks whether a mod is already installed to the same game then uninstall it
            InstalledMod modInstalled = Settings.GetInstalledGameMod(category.Id);

            if (modInstalled != null)
            {
                ModsData.ModItem currentModItem = Database.Mods.GetModById(modInstalled.ModId);

                if (DarkMessageBox.Show(this,
                    $"'{currentModItem.Name} v{currentModItem.Version} ({currentModItem.Type})' is currently installed to: {category.Title}"
                    + "\n\nPrevious mods could conflict with eachother. Do you want to uninstall the current one?",
                    "Mods Already Installed",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UninstallMods(Database.Mods.GetModById(modInstalled.ModId), modInstalled.Region);
                }
            }

            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting archive download link...");
            ModsData.DownloadFiles downloadFiles = modItem.GetDownloadFiles(this);

            if (downloadFiles == null)
            {
                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No archive download selected. Installation cancelled.");
                return;
            }

            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found archive download link.");

            // Check whether mods are being installed to the firmware folder and let the user know if they want to cancel
            if (downloadFiles.IsInstallToRebugFolder)
            {
                if (DarkMessageBox.Show(this,
                    "Files are being installed to the firmware folder (dev_rebug), which is for REBUG Custom Firmware only. It's recommended to create a backup of the entire folder before installing any files. Also, ensure that you're running this custom firmware and the REBUG TOOLBOX application is open before proceeding. Any missing or incorrect files in this folder can impact your console performance. If you have issues after rebooting console then enter recovery mode and reinstall your custom firmware.\n\nOnly continue at your own risk and only if you know what you're doing.\n\nDo you still want to install the files?",
                    "Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                    return;
                }
            }

            try
            {
                // Check whether a game region must be provided to install
                if (downloadFiles.RequiresGameRegion)
                {
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching region...");

                    gameRegion = category.GetGameRegion(this, modItem.GameId);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No region selected. Installation cancelled.");
                        return;
                    }

                    if (!modItem.IsAnyRegion && !modItem.Region.Equals(gameRegion))
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Region isn't supported. Installation cancelled.");
                        return;
                    }

                    if (Settings.RememberGameRegions)
                    {
                        Settings.UpdateGameRegion(modItem.GameId, gameRegion);
                    }

                    // Check whether the game update for this region exists
                    if (!FtpExtensions.GetFolderNames($"/dev_hdd0/game/").Contains(gameRegion))
                    {
                        DarkMessageBox.Show(this, "Game update folder for this region cannot be found on your console. You must install the correct update for this game or maybe you specified the wrong region.", "Can't Find Game Update", MessageBoxIcon.Warning);
                        return;
                    }

                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region.");
                }
                else
                {
                    gameRegion = "";
                }

                // Check whether a user id must be provided and prompts the user to choose one
                if (downloadFiles.RequiresUserId)
                {
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching user id...");

                    //userId = FtpExtensions.GetUserId(FtpClient, this);
                    userId = FtpExtensions.GetUserId(this);
                    gameTitle = $"{category.Title} ({userId})";

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No user id selected. Installation cancelled.");
                        return;
                    }

                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found user id.");
                }
                else
                {
                    userId = "";
                }

                // If it's a game save then alert the user that a usb device must be connected to console
                if (downloadFiles.IsInstallToRebugFolder)
                {
                    if (modItem.IsGameSave)
                    {
                        if (DarkMessageBox.Show(this,
                                "Before installing this game save you must have completed the following steps:\n- Insert your USB device to any port on the console.\n- Install the Apollo Tool PKG from the Homebrew Packages category on your console to unlock, patch and resign save-game files directly on your PS3."
                                + "\nThis will only work if you have your USB device connected. Click 'Yes' if you have done this. Otherwise click 'No' and this game-save will not be installed.",
                                "Install Game Save to USB Device", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) ==
                            DialogResult.Yes)
                        {
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            gameTitle = $"{category.Title} ({usbDevice})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device connected. Installation cancelled.");
                                return;
                            }

                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");
                        }
                        else
                        {
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                            return;
                        }
                    }
                    else
                    {
                        if (DarkMessageBox.Show(this,
                                "One or more files needs to be installed at a USB device that is connected to your console. It could be required for the mods to work, such as a configuration or plugin file. I suggest you read the complete description for more details on this."
                                + "\nTo allow for these files to be installed, you must have a USB inserted before you continue. Would you like to proceed, click 'Yes' to continue. Otherwise click 'No' and all USB files will be ignored.",
                                "Install Files to USB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.Yes)
                        {
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            gameTitle = $"{category.Title} ({gameRegion})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device connected. Installation cancelled.");
                                return;
                            }

                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");
                        }
                        else
                        {
                            usbDevice = "";
                        }
                    }
                }
                else
                {
                    usbDevice = "";
                }

                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloading and extracting files archive...");
                modItem.DownloadInstallFiles(downloadFiles);
                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloaded and extracted files archive.");

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count();

                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing files...");

                foreach (string installFilePath in downloadFiles.InstallPaths)
                {
                    // Install folders
                    foreach (string localFolderPath in Directory.GetDirectories(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                    {
                        if (string.Equals(Path.GetFileName(localFolderPath), Path.GetFileName(installFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!FtpClient.DirectoryExists(installFilePath))
                            {
                                if (FtpExtensions.CreateDirectory(installFilePath))
                                {
                                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Created folder.");
                                }
                            }
                        }    
                    }

                    // Install files
                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                    {
                        string installFileName = Path.GetFileName(installFilePath);

                        string installPath = installFilePath
                                .Replace("{REGION}", $"{gameRegion}")
                                .Replace("{USERID}", $"{userId}")
                                .Replace("{USBDEV}", $"{usbDevice}");

                        string installPathWithoutFileName = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                        // Create parent directory if it doesn't exist on the console
                        if (!FtpClient.DirectoryExists(installPathWithoutFileName))
                        {
                            FtpExtensions.CreateDirectory(installPathWithoutFileName);
                        }

                        // Check whether install file matches the specified install file
                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            // Check whether this file is installed to a game folder
                            if (installPath.Contains("dev_hdd0/game/"))
                            {
                                // Get the backup details for this game file if one has been created
                                BackupFile backupFile = Settings.GetGameFileBackup(modItem.GameId, installFileName, installPath);

                                // A backup hasn't been created for this file, so it will be ignored and kept alone - in case issues occur with the game
                                if (backupFile == null)
                                {
                                    // Alert the user there is no backup for this file and ask the user if one would like to be created
                                    if (DarkMessageBox.Show(this,
                                        "Would you like to backup the current game file? This will be restored when you choose to uninstall.\n\nGame File Name: " +
                                        Path.GetFileName(installFilePath), "Backup File", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating backup of file: {installFileName}...");
                                        Settings.CreateBackupFile(modItem, installFileName, installPath);
                                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created backup file.");

                                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");
                                        FtpExtensions.UploadFile(FtpConnection, localFilePath, installPath);
                                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file. ({indexFiles}/{totalFiles})");
                                        indexFiles++;
                                    }
                                    else
                                    {
                                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");
                                        FtpExtensions.UploadFile(FtpConnection, localFilePath, installPath);
                                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                        indexFiles++;
                                    }
                                }
                                // Install the local file, like SPRX or key files
                                else
                                {
                                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");
                                    FtpExtensions.UploadFile(FtpConnection, localFilePath, installPath);
                                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                    indexFiles++;
                                }
                            }
                            // Check whether file is installed to a USB device
                            else if (installFilePath.Contains("{USBDEV}"))
                            {
                                if (!string.IsNullOrEmpty(usbDevice))
                                {
                                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");
                                    FtpExtensions.UploadFile(FtpConnection, localFilePath, installPath);
                                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                    indexFiles++;
                                }
                            }
                            // Otherwise, install the file as normal
                            else
                            {
                                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");
                                FtpExtensions.UploadFile(FtpConnection, localFilePath, installPath);
                                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                indexFiles++;
                            }
                        }
                    }
                }

                // Update the installed game mods, if this isn't for a game save
                if (category.CategoryType == CategoryType.Game && !modItem.IsGameSave)
                {
                    Settings.UpdateInstalledGameMod(category.Id, modItem.Id, gameRegion, indexFiles - 1, DateTime.Now, downloadFiles);
                    SaveSettings();
                    LoadInstalledGameMods();
                }

                if (IsWebManInstalled)
                {
                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{gameTitle}\nInstalled: {modItem.Name} ({indexFiles - 1} files)");
                }

                // Log status
                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed {indexFiles - 1} files.");
                _ = DarkMessageBox.Show(this, $"Successfully installed {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {gameTitle}." : ".")}{(category.CategoryType == CategoryType.Game ? "\nReady to start game." : "")}", "Success", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Error installing files for {gameTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                _ = DarkMessageBox.Show(this,
                    $"An error occurred installing files for {modItem.Name} (#{modItem.Id}). See menu 'HELP > Report Bug' to open an issue and attach the log.txt file, which will be found in the program's installation path, so it can be investigated." +
                    "\nError Message: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Uninstall all of the files for the <paramref name="modItem" />.
        /// </summary>
        /// <param name="modItem">Mod details from the <see cref="ModsData.ModItem" /></param>
        /// <param name="region">Game region</param>
        public void UninstallMods(ModsData.ModItem modItem, string region = "")
        {
            CategoriesData.Category category = Database.Categories.GetCategoryById(modItem.GameId);

            string gameTitle = category.Title;

            string gameRegion;
            string userId;
            string usbDevice;

            ModsData.DownloadFiles downloadFiles;

            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Preparing to uninstall files...");

            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting previous install details...");

            InstalledMod installedMod;

            if (category.CategoryType == CategoryType.Game)
            {
                installedMod = Settings.GetInstalledGameMod(modItem.GameId);
            }
            else
            {
                installedMod = null;
            }

            // Mod hasn't been installed
            if (installedMod == null)
            {
                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No previous install found. Fetching download...");
                gameRegion = region;
                downloadFiles = modItem.GetDownloadFiles(this);
            }
            else
            {
                gameRegion = installedMod.Region;
                downloadFiles = installedMod.DownloadFiles;
            }

            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found previous install details.");

            // Alerts the user that uninstalling files from dev_rebug folders isn't allowed
            if (modItem.IsInstallToRebugFolder)
            {
                _ = DarkMessageBox.Show(this,
                    "You cannot uninstall files from the firmware folder. Any missing files could affect your console performance.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Cancelled installation.");
                return;
            }

            try
            {
                // If a game region isn't provided already, then prompt the user to choose one
                if (!string.IsNullOrWhiteSpace(region))
                {
                    gameRegion = region;
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region: {gameRegion}");
                }

                // Check whether a game region needs to be provided if one hasn't been already
                if (downloadFiles.RequiresGameRegion && string.IsNullOrWhiteSpace(region))
                {
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching region...");
                    gameRegion = category.GetGameRegion(this, modItem.GameId);
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region: {gameRegion}");

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No region selected. Cancelled installation.");
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
                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching user ID...");

                    userId = FtpExtensions.GetUserId(this);

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No user ID selected. Cancelled installation.");
                        return;
                    }

                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found user ID: {userId}");
                }
                else
                {
                    userId = "";
                }

                // If this mod requires a usb device to be connected to console, ask the user whether they want to continue with this
                if (downloadFiles.RequiresUsbDevice)
                {
                    // If this is a modded gamesave then inform the user they must remove the gamesave from their usb themselves
                    if (modItem.IsGameSave)
                    {
                        _ = DarkMessageBox.Show(this,
                            "You can't uninstall games saves. You must remove the game save folder from your USB device or use the XMB menu.",
                            "Can't Uninstall",
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        // Inform the user a USB device must be connected for the mods
                        if (DarkMessageBox.Show(this,
                            "Some files may have been files to be installed to a USB device. You can either choose to uninstall them now or manually delete them yourself." +
                            "\n\nIf you would like to uninstall the files, then connect the same USB device to your console and click 'Yes' to continue." +
                            "\n\nIf you wouldn't like to uninstall the files from your USB device, then click 'No' and all of these files will be ignored.",
                            "Uninstall USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");
                            usbDevice = FtpExtensions.GetUsbPath();
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device found. Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            usbDevice = "";
                        }
                    }
                }
                else
                {
                    usbDevice = "";
                }

                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling files...");

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

                    string installPathWithoutFileName = Path.GetDirectoryName(installPath).Replace(@"\", "/");

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
                                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing backup file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName})");
                                    FtpExtensions.UploadFile(FtpConnection, backupFile.LocalPath, installPath);
                                    SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installed backup file.");
                                    indexFiles++;
                                }
                                else
                                {
                                    _ = DarkMessageBox.Show(this,
                                        $"You have created a game file backup, but the file: {Path.GetFileName(installPath)} can't be found on your computer. If you have moved this file then navigate to Tools > Game Backup Files and set the local file again. If this file has been deleted, you should delete the game backup file data and re-backup the file again. For now, this file will be not be uninstalled to prevent any issues with missing game files for the game.",
                                        "No File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                _ = DarkMessageBox.Show(this,
                                    $"There is no backup for file: {Path.GetFileName(installPath)} so it can't be uninstalled. This file will be ignored to prevent any issues with missing game files. To restore the file to original then you must reinstall the game update.",
                                    "No Game Backup File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {installPathWithoutFileName}");
                            FtpExtensions.DeleteFile(FtpClient, installPath);
                            SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalled file.");
                            indexFiles++;
                        }
                    }
                    else // Uninstall folders
                    {
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleting folder: {installPath}");
                        FtpExtensions.DeleteDirectory(FtpClient, installPath);
                        SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleted folder.");
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
                            FtpExtensions.DeleteDirectory(FtpClient, parentFolderPath);
                        }
                    }
                }

                // Remove data from settings if this isn't a game save.
                if (category.CategoryType == CategoryType.Game && !modItem.IsGameSave)
                {
                    Settings.RemoveInstalledGameMod(category.Id, modItem.Id);
                    SaveSettings();
                    LoadInstalledGameMods();
                }

                if (IsWebManInstalled)
                {
                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{gameTitle}\nUninstalled: {modItem.Name} ({indexFiles - 1} files)");
                }

                SetStatus($"{gameTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled {indexFiles - 1} files{(category.CategoryType == CategoryType.Game ? $" for {gameTitle}." : ".")}");
                _ = DarkMessageBox.Show(this,
                    $"Successfully uninstalled: {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {gameTitle}." : "")}", "Success",
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Error uninstalling files for {gameTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                _ = DarkMessageBox.Show(this,
                    $"An error occurred uninstalling files for {modItem.Name} (#{modItem.Id}). See Help > Report Issue/Suggestions to submit an issue and attach the log.txt file, which will be found in the program's installation path, so that we can investigate this." +
                    "\nError Message: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Download the modded files archive to the user's specified path.
        /// </summary>
        /// <param name="modItem"></param>
        private void DownloadModArchive(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Database.Categories.GetCategoryById(modItem.GameId);

            string gameTitle = category.Title;

            try
            {
                SetStatus($"{gameTitle}: {modItem.Name} ({modItem.Type}) - Downloading archive...");

                ModsData.DownloadFiles download = modItem.GetDownloadFiles(this);

                if (download == null)
                {
                    SetStatus($"{gameTitle}: {modItem.Name} ({modItem.Type}) - Download archive cancelled.");
                    return;
                }

                string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the archive.");

                if (folderPath != null)
                {
                    modItem.DownloadArchiveAtPath(Database.Categories, download, folderPath);
                    SetStatus($"{gameTitle}: {modItem.Name} ({modItem.Type}) - Successfully downloaded archive at path: {folderPath}");
                    _ = Process.Start(folderPath);
                }
                else
                {
                    SetStatus($"{gameTitle}: {modItem.Name} ({modItem.Type}) - Download archive cancelled.");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download archive {gameTitle}: {modItem.Name} ({modItem.Id}). Error:  {ex.Message}", ex);
                _ = DarkMessageBox.Show(this,
                    "An error occurred downloading files archive. (Access maybe denied at this path, try a different folder). See log file for more information about this issue." +
                    "\nError Message: " + ex.Message, "Unable to Download Archive", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Adds or removes the specified <see cref="ModsData.ModItem" /> to the users favorites list.
        /// </summary>
        /// <param name="modItem"></param>
        private void AddModToFavorites(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Database.Categories.GetCategoryById(modItem.GameId);

            string gameTitle = category.Title;

            if (Settings.FavoritedIds.Contains(modItem.Id.ToString()))
            {
                _ = Settings.FavoritedIds.Remove(modItem.Id.ToString());

                DisplayModDetails(SelectedModItem.Id);

                if (SelectedCategory.Id.Equals("fvrt"))
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }

                SetStatus($"{gameTitle}: {modItem.Name} ({ modItem.Type}) - Removed from favorites list.");
            }
            else
            {
                Settings.FavoritedIds.Add(modItem.Id.ToString());

                DisplayModDetails(SelectedModItem.Id);

                SetStatus($"{gameTitle}: {modItem.Name} ({modItem.Type}) - Added to favorites list.");
            }

            ToolItemModAddToFavorite.AutoSize = false;
            ToolItemModAddToFavorite.AutoSize = true;

            ToolStripArchiveInformation.Update();
        }

        /// <summary>
        ///     Set the current connected console status in the tool strip.
        /// </summary>
        /// <param name="consoleProfile"></param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            ToolStripLabelConsole.Text = consoleProfile == null ? "Idle" : $"{consoleProfile.Name} ({consoleProfile.Address})";
        }

        /// <summary>
        ///     Set the current process status in the tool strip.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            ToolStripLabelStatus.Text = status;
            Refresh();

            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(status, ex);
            }
        }

        /// <summary>
        ///     Enable or disable console-only actions.
        /// </summary>
        private void EnableConsoleActions()
        {
            MenuItemToolsWebManControls.Enabled = IsConsoleConnected && IsWebManInstalled;
            MenuItemToolsFileManager.Enabled = IsConsoleConnected;
            ToolItemModInstall.Enabled = IsConsoleConnected;
            ContextMenuModsInstallFiles.Enabled = IsConsoleConnected;

            if (ToolItemModUninstall.Enabled)
            {
                ToolItemModUninstall.Enabled = IsConsoleConnected;
            }

            if (ContextMenuModsUninstallFiles.Enabled)
            {
                ContextMenuModsUninstallFiles.Enabled = IsConsoleConnected;
            }
        }

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Removes dotted borders from the cells upon focus
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        /// <summary>
        ///     Save application settings to a json data file.
        /// </summary>
        public void SaveSettings()
        {
            try
            {
                SetStatus("Saving settings data...");

                if (!Directory.Exists(UserFolders.AppData))
                {
                    _ = Directory.CreateDirectory(UserFolders.AppData);
                }

                using (StreamWriter streamWriter = new StreamWriter(UserFolders.AppSettingsFile))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(Settings));
                }

                SetStatus("Successfully saved settings data.");
            }
            catch (Exception ex)
            {
                SetStatus("Unable to save settings data. Error: " + ex.Message, ex);
            }
        }

        /// <summary>
        ///     Load application settings from a json data file.
        /// </summary>
        public void LoadSettings()
        {
            try
            {
                SetStatus("Loading settings data...");

                if (File.Exists(UserFolders.AppSettingsFile))
                {
                    using (StreamReader streamReader = new StreamReader(UserFolders.AppSettingsFile))
                    {
                        Settings = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                    }
                }

                SetStatus("Successfully loaded settings data.");
            }
            catch (Exception ex)
            {
                SetStatus("Unable to load settings data. Error: " + ex.Message, ex);
                return;
            }

            if (Settings.ConsoleProfiles.Count < 1)
            {
                Settings.ConsoleProfiles.Add(
                    new ConsoleProfile
                    {
                        Name = "Default Console",
                        Address = "192.168.0.42",
                        Port = 21,
                        Username = "anonymous",
                        Password = "",
                        UseDefaultCredentials = true
                    }) ;
            }

            if (Settings.ExternalApplications.Count < 1)
            {
                Settings.ExternalApplications.Add(
                    new ExternalApplication(
                        "Control Console (CCAPI)",
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ControlConsoleAPI\CCAPIConsoleManager.exe"))
                );

                Settings.ExternalApplications.Add(
                    new ExternalApplication(
                        "FileZilla",
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"FileZilla FTP Client\filezilla.exe"))
                );
            }

            // Update UI Properties from Settings
            MenuItemApplications.DropDownItems.Clear();

            foreach (ExternalApplication application in Settings.ExternalApplications)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(application.Name, null, MenuItemApplications_Click);
                _ = MenuItemApplications.DropDownItems.Add(menuItem);
            }
        }
    }
}