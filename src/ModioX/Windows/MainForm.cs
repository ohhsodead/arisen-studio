using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Properties;
using ModioX.Windows.Connection;
using ModioX.Windows.Custom_Mods;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Windows
{
    public partial class MainForm : DarkForm
    {
        public static MainForm mainForm;

        /// <summary>
        ///     Contains the latest games data retrieved from the database
        /// </summary>
        public static CategoriesData Categories;

        /// <summary>
        ///     Contains the latest mods data retrieved from the database
        /// </summary>
        public static ModsData Mods;

        /// <summary>
        ///     Contains the selected console profile name
        /// </summary>
        public static ConsoleProfile ConsoleProfile { get; set; }

        /// <summary>
        ///    Determines the connection status for the console
        /// </summary>
        public static bool IsConsoleConnected { get; set; }

        /// <summary>
        ///     Contains the selected game data selected by the user
        /// </summary>
        public static CategoriesData.Category SelectedCategory { get; set; }

        /// <summary>
        ///     Contains the selected mods info selected by the user
        /// </summary>
        public static ModsData.ModItem SelectedModItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static SettingsData SettingsData { get; set; } = new SettingsData();

        /// <summary>
        /// 
        /// </summary>
        public static readonly string SettingsDataFile = Path.Combine(Environment.CurrentDirectory, "SettingsData.json");

        public MainForm()
        {
            mainForm = this;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = string.Format("ModioX - Beta {0}", Updater.Updater.CurrentVersion.ToString().Remove(0, 2));

            SetStatus($"Initializing application data...");

            Updater.Updater.CheckApplicationVersion();
            LoadSettingsData();
            Worker.RunWorkAsync(LoadData, InitializeFinished);

            // Load Settings UI
            MenuStripSettingsAutoDetectGameRegion.Checked = SettingsData.AutoDetectGameRegion;
            MenuStripSettingsSaveCurrentLocalDirectory.Checked = SettingsData.SaveLocalDirectory;
            MenuStripSettingsEnableConsoleFileExplorer.Checked = SettingsData.EnableFileExplorer;
            MenuStripSettingsShowModIDs.Checked = SettingsData.ShowModIds;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConsoleConnected)
            {
                if (!string.IsNullOrEmpty(TextBoxLocalDirectory.Text))
                {
                    SettingsData.LocalDirectory = TextBoxLocalDirectory.Text;
                }
            }

            SaveSettingsData();
        }

        /// <summary>
        ///     Retrieves the games and mods data into the application
        /// </summary>
        private static void LoadData()
        {
            Categories = Utilities.GetCategoriesData();
            Mods = Utilities.GetModsData();
        }

        /// <summary>
        ///     Set a few properties after being initialized
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded the database - Finalizing data...");

            Categories.Categories = Categories.Categories.OrderBy(o => o.Title).ToList();

            ListViewGamesCategories.Items.Clear();

            foreach (CategoriesData.Category category in Categories.Categories)
            {
                if (Mods.GetModsByCategoryId(category.Id).Length > 0 || category.Id.Equals("fvrt"))
                {
                    ListViewGamesCategories.Items.Add(new DarkListItem()
                    {
                        Tag = category.Id,
                        Text = category.Id.Equals("fvrt") ? string.Format("{0} ({1})", category.Title, SettingsData.FavoritedIds.Count) : string.Format("{0} ({1})", category.Title, Mods.GetModsByCategoryId(category.Id).Length)
                    });
                }                
            }

            ListViewGamesCategories.SelectItem(0);

            ComboBoxFirmware.Items.Clear(); ComboBoxFirmware.Items.Add("ANY");

            foreach (ModsData.ModItem modItem in Mods.Mods)
            {
                if (!ComboBoxFirmware.Items.Contains(modItem.Firmware))
                {
                    ComboBoxFirmware.Items.Add(modItem.Firmware);
                }
            }

            ComboBoxFirmware.SelectedIndex = 0;

            SelectedCategory = Categories.Categories[0];
            LoadModsByCategoryId(
                SelectedCategory.Id,
                "",
                "");

            ToolStripLabelStats.Text = string.Format("{0} Mods for {1} Games, {2} Game Updates, {3} Homebrew Packages, {4} Resources && {5} Themes", Mods.TotalGameMods, Categories.TotalGames, Mods.TotalGameUpdates, Mods.TotalHomebrew, Mods.TotalResources, Mods.TotalThemes);

            SetStatus($"Initialized ModioX successful (Version {Utilities.GetCurrentVersion().Remove(0, 2)}) - Ready to connect to console...");
        }

        public void ConnectConsole()
        {
            SetStatus($"Console : {ConsoleProfile.Name} ({ConsoleProfile.Address}) - Preparing to establish a connection...");

            FtpConnection = new FtpConnection(ConsoleProfile.Address);
            SetStatusConsole(ConsoleProfile);
            IsConsoleConnected = true;
            MenuStripConnectPS3.Text = "Disconnect Console...";
            EnableConsoleActions(true);

            SetStatus($"Console : Successfully connected - Ready for files to be installed...");

            if (SettingsData.EnableFileExplorer)
            {
                if (SettingsData.SaveLocalDirectory)
                {
                    // Load saved local directory path
                    if (SettingsData.LocalDirectory.Equals(@"\") || SettingsData.LocalDirectory.Equals(""))
                    {
                        LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
                    }
                    else
                    {
                        LoadLocalDirectory(SettingsData.LocalDirectory);
                    }
                }
                else
                {
                    // Load users documents path by default
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
                }

                LoadConsoleDirectory(FtpDirectoryPath);
            }
        }

        private void DisconnectConsole()
        {
            SetStatus($"Console : {ConsoleProfile.Name} ({ConsoleProfile.Address}) - Preparing for disconnection...");
            FtpConnection = null;
            SetStatusConsole(null);
            SetStatus("Console : Successfully disconnected");
            MenuStripConnectPS3.Text = "Connect Console...";
            IsConsoleConnected = false;
            EnableConsoleActions(false);
        }

        private void MenuStripConnectPS3Console_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }
            else
            {
                using (ConsoleConnection consoleConnection = new ConsoleConnection())
                {
                    consoleConnection.ShowDialog(this);
                }
            }
        }

        private void MenuItemToolsBackupFileManager_Click(object sender, EventArgs e)
        {
            using (ViewGameBackups backupManagerForm = new ViewGameBackups())
            {
                backupManagerForm.ShowDialog(this);
            }
        }

        private void MenuStripToolsCustomMods_Click(object sender, EventArgs e)
        {
            using (ViewCustomMods customModsManager = new ViewCustomMods())
            {
                customModsManager.ShowDialog(this);
            }
        }

        private void MenuStripApplicationsCCAPI_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ControlConsoleAPI\CCAPIConsoleManager.exe");

            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                DarkMessageBox.Show(this, "Could not locate application Console Manager (CCAPI) at the default installation path. This option could become customizable to set your own in future updates.", "Not Found", MessageBoxIcon.Error);
            }
        }

        private void MenuStripApplicationsFileZilla_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Program Files\FileZilla FTP Client\filezilla.exe";

            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                DarkMessageBox.Show(this, "Could not locate the application FileZilla at the default installation path. This option could become customizable to set your own in future updates.", "Not Found", MessageBoxIcon.Error);
            }
        }

        private void MenuStripResourcesForumsPsxPlacePs3Mods_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.psx-place.com/resources/categories/playstation-3-ps3.3/");
        }

        private void MenuStripResourcesForumsPsxPlaceGameMods_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.psx-place.com/forums/game-mods.91/");
        }

        private void MenuStripResourcesForumsPsxScenePs3Mods_Click(object sender, EventArgs e)
        {
            Process.Start("http://psx-scene.com/forums/ps3-general-discussion/");
        }

        private void MenuStripResourcesForumsPsxSceneGameMods_Click(object sender, EventArgs e)
        {
            Process.Start("http://psx-scene.com/forums/ps3-game-modding/");
        }

        private void MenuStripResourcesForumsNguPs3Mods_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nextgenupdate.com/forums/ps3-mods-cheats/");
        }

        private void MenuStripResourcesForumsNguGameMods_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nextgenupdate.com/forums/ps3-mods-cheats/");
        }

        private void MenuStripResourcesCustomFirmwareRebug_Click(object sender, EventArgs e)
        {
            Process.Start("https://rebug.me/");
        }

        private void MenuStripResourcesRedditPs3Hacks_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.reddit.com/r/ps3hacks/");
        }

        private void MenuStripResourcesRedditPs3Homebrew_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.reddit.com/r/ps3homebrew/");
        }

        private void PS3ModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.se7ensins.com/forums/forums/playstation-3-modding-tutorials.83/");
        }

        private void GameModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.se7ensins.com/forums/#gaming.275");
        }

        private void PS3ModsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.thetechgame.com/Forums/f=322/prefix=modding&prefix=playstation-3/playstation-forum.html");
        }

        private void GameModsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.thetechgame.com/Forums/f=296/prefix=modding/gaming-discussion.html");
        }

        private void BrewologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://store.brewology.com/homebrew.php?lang=");
        }

        private void MenuStripResourcesGamesPsnDLv3_Click(object sender, EventArgs e)
        {
            Process.Start("http://psndl.net/packages");
        }

        private void MenuStripResourcesGamesNoPsv2_Click(object sender, EventArgs e)
        {
            Process.Start("http://nopaystation.com/");
        }

        private void MenuStripContribute_Click(object sender, EventArgs e)
        {
            Process.Start(Utilities.ProjectRepoUrl);
        }

        private void MenuStripSettingsEditConsoles_Click(object sender, EventArgs e)
        {
            using (EditProfiles consolesWindow = new EditProfiles())
            {
                consolesWindow.ShowDialog(this);
            }
        }

        private void MenuStripSettingsEnableFileManager_Click(object sender, EventArgs e)
        {
            SettingsData.EnableFileExplorer = MenuStripSettingsEnableConsoleFileExplorer.Checked;
        }

        private void MenuStripSettingsAutoDetectRegion_Click(object sender, EventArgs e)
        {
            SettingsData.AutoDetectGameRegion = MenuStripSettingsAutoDetectGameRegion.Checked;
        }

        private void MenuStripSettingsShowModNumbers_Click(object sender, EventArgs e)
        {
            SettingsData.ShowModIds = MenuStripSettingsShowModIDs.Checked;
        }

        private void MenuStripSettingsSaveCurrentLocalDirectory_Click(object sender, EventArgs e)
        {
            SettingsData.SaveLocalDirectory = MenuStripSettingsSaveCurrentLocalDirectory.Checked;
        }

        private void MenuStripHelpSourceCode_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ohhsoash/ModioX");
        }

        private void MenuStripHelpReportBugSuggestions_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ohhsoash/ModioX/issues/new");
        }

        private void MenuStripHelpCheckForUpdates_Click(object sender, EventArgs e)
        {
            Updater.Updater.CheckApplicationVersion();
        }

        private void MenuStripHelpAbout_Click(object sender, EventArgs e)
        {
            DarkMessageBox.Show(this, "ModioX was developed by @ohhsoash and few friends, with the only intention of providing an efficient tool for browsing, downloading and installing game and console mods directly. All credits are given to those appropriate creators/authors of the mods used in this application. If you have any questions please send a message at my Discord: wh1ter0se#7480 with your much welcomed comments, suggestions and feedback to help support this project.", "Information", MessageBoxIcon.Information);
        }

        private void MenuStripItemRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus($"Initializing application data...");

            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }

            SaveSettingsData();
            LoadSettingsData();

            Worker.RunWorkAsync(LoadData, InitializeFinished);

            // Load Settings UI
            MenuStripSettingsAutoDetectGameRegion.Checked = SettingsData.AutoDetectGameRegion;
            MenuStripSettingsSaveCurrentLocalDirectory.Checked = SettingsData.SaveLocalDirectory;
            MenuStripSettingsEnableConsoleFileExplorer.Checked = SettingsData.EnableFileExplorer;
            MenuStripSettingsShowModIDs.Checked = SettingsData.ShowModIds;
        }

        private void MenuStripRequestMod_Click(object sender, EventArgs e)
        {
            Utilities.OpenRequestTemplate();
        }


        /***************                       MODS LIBRARY                        ***************/

        string SelectedModFirmware { get; set; } = "";

        string SelectedModType { get; set; } = "";

        private void ComboBoxFirmware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFirmware.SelectedIndex == 0)
            {
                SelectedModFirmware = "";
            }
            else
            {
                SelectedModFirmware = ComboBoxFirmware.GetItemText(ComboBoxFirmware.SelectedItem);
            }

            LoadModsByCategoryId(
                    SelectedCategory.Id,
                    SelectedModFirmware,
                    SelectedModType);
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex == 0)
            {
                SelectedModType = "";
            }
            else
            {
                SelectedModType = ComboBoxType.GetItemText(ComboBoxType.SelectedItem);
            }

            LoadModsByCategoryId(
                SelectedCategory.Id,
                SelectedModFirmware,
                SelectedModType);
        }

        private void ListViewGamesCategories_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (ListViewGamesCategories.SelectedIndices.Count > 0)
            {
                SelectedCategory = Categories.GetCategoryById(ListViewGamesCategories.Items[ListViewGamesCategories.SelectedIndices[0]].Tag.ToString());

                LoadModsByCategoryId(
                    SelectedCategory.Id,
                    SelectedModFirmware,
                    SelectedModType);

                if (string.IsNullOrEmpty(SelectedModType))
                {
                    ComboBoxType.SelectedIndex = 0;
                }
                else
                {
                    ComboBoxType.SelectedIndex = ComboBoxType.FindStringExact(SelectedModType);
                }
            }
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
            }

            ToolStripInstallMod.Enabled = DgvMods.SelectedRows.Count != 0 && IsConsoleConnected;
            ToolStripDownloadMod.Enabled = DgvMods.SelectedRows.Count != 0;
            ToolStripFavoriteMod.Enabled = DgvMods.SelectedRows.Count != 0;
        }

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                if (DgvMods.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
                {
                    ToolStripDownloadMod.PerformClick();
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
                {
                    ToolStripFavoriteMod.PerformClick();
                }
            }

            ToolStripInstallMod.Enabled = e.RowIndex != -1 && IsConsoleConnected;
            ToolStripDownloadMod.Enabled = e.RowIndex != -1;
            ToolStripFavoriteMod.Enabled = e.RowIndex != -1;
        }

        private void DgvMods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
        }

        private void ContextMenuModsInstallToConsole_Click(object sender, EventArgs e)
        {
            ToolStripInstallMod.PerformClick();
        }

        private void ContextMenuModsUninstallFromConsole_Click(object sender, EventArgs e)
        {
            ToolStripUninstallMod.PerformClick();
        }

        private void ContextMenuModsDownloadArchive_Click(object sender, EventArgs e)
        {
            ToolStripDownloadMod.PerformClick();
        }

        private void ContextMenuModsExtractInformation_Click(object sender, EventArgs e)
        {
            SetStatus(string.Format("Mods Archive : Choose a folder to write the readme file for '{0}'", SelectedModItem.Name));

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    SelectedModItem.GenerateReadMeAtPath(folderBrowser.SelectedPath);
                    SetStatus(string.Format("Mods Archive : Successfully written readme contents to file at {0}", folderBrowser.SelectedPath));
                }
            }
        }

        private void ContextMenuModsReportOnGitHub_Click(object sender, EventArgs e)
        {
            Utilities.OpenReportTemplate(SelectedModItem);
        }

        private void DgvInstallPaths_SelectionChanged(object sender, EventArgs e)
        {
            DgvInstallPaths.ClearSelection();
        }

        private void ToolStripInstallFiles_Click(object sender, EventArgs e)
        {
            CategoriesData.Category actualCategory = Categories.GetCategoryById(SelectedModItem.GameId);

            SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - Preparing to install files...");

            bool isGameMod = actualCategory.RequiresRegion();

            string gameTitle;
            string gameRegion;

            try
            {
                if (isGameMod)
                {
                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - Retrieving region...");
                    gameRegion = actualCategory.GetGameRegion(ConsoleProfile.Address);
                    gameTitle = $"{actualCategory.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - No region selected when prompted. Canceled.");
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{actualCategory.Title}";
                }

                SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Downloading and extracting archive...");
                SelectedModItem.DownloadArchive();

                int indexOfFiles = 1;
                int totalLengthFiles = SelectedModItem.InstallPaths.Length;

                foreach (string installFilePath in SelectedModItem.InstallPaths)
                {
                    foreach (string localFilePath in Directory.GetFiles(SelectedModItem.GetDirectoryDownloadData(), "*.*", SearchOption.AllDirectories))
                    {
                        if (string.Equals(Path.GetFileName(installFilePath), Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            string installPath = installFilePath.Replace("/{REGION}/", $"/{gameRegion}/");

                            SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Preparing to install files...");

                            if (installPath.Contains("dev_hdd0/game/"))
                            {
                                if (DarkMessageBox.Show(this, "A file is being uploaded to your game folder. Would you like to first backup the original game file before installing this file? You can then revert the mods at anytime using the Tools > Backup File Manager window to restore the game files to their original state.\n\nFile being installed : " + Path.GetFileName(installFilePath), "Backup Game File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Creating backup file for {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles})...");

                                    Directory.CreateDirectory(SettingsData.CreateBackupFileFolder(SelectedModItem));

                                    BackupFile backupFile = new BackupFile()
                                    {
                                        Name = "Original Game File",
                                        CategoryId = SelectedModItem.GameId,
                                        FileName = Path.GetFileName(installPath),
                                        LocalPath = SettingsData.CreateBackupFile(SelectedModItem, Path.GetFileName(localFilePath)),
                                        InstallPath = installPath
                                    };

                                    EditBackupDialog(backupFile);

                                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Downloading backup file {Path.GetFileName(backupFile.InstallPath)} from {backupFile.InstallPath}");

                                    FtpExtensions.DownloadFile(ConsoleProfile.Address, backupFile.LocalPath, backupFile.InstallPath);

                                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Installing file {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                                else
                                {
                                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Installing file {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                            }
                            else if (installFilePath.Contains("dev_usb000/"))
                            {
                                if (DarkMessageBox.Show(this, "A file wants to be installed to a usb device connected to the console - it maybe required for the mods to function, or not. I suggest reading the complete description to see if it's mentioned there. It could be used for configuration or settings purposes." +
                                    "\n\nIf you would still like to continue, then insert your usb into the right-most slot of the console ports at the front. So, should the file be installed? Only click 'YES' if you've connected the usb device. Otherwise this fine will be ignored.", "USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uploading {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                            }
                            else
                            {
                                SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uploading {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                indexOfFiles++;
                            }
                        }
                    }
                }

                SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Successfully installed {totalLengthFiles} files");
            }
            catch (Exception ex)
            {
                SetStatus($"Mods : Unable to install files '{SelectedModItem.Name} ({SelectedModItem.Id}) for {actualCategory.Title} - {ex.Message}", ex);
                DarkMessageBox.Show(this, "An error occurred installing the files for this mod. See menu HELP > Report Bug/Suggestions to submit an issue, and attach your log.txt file contents so this bug can be investigated and fixed." +
                    "\n\nError Message:\n" + ex.Message, "Install Error", MessageBoxIcon.Error);
            }
        }

        private void ToolStripUninstallFiles_Click(object sender, EventArgs e)
        {
            CategoriesData.Category actualCategory = Categories.GetCategoryById(SelectedModItem.GameId);

            SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - Preparing to uninstall modded files...");

            bool isGameMod = actualCategory.RequiresRegion();

            string gameTitle;
            string gameRegion;

            try
            {
                if (isGameMod)
                {
                    SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - Retrieving game region...");
                    gameRegion = actualCategory.GetGameRegion(ConsoleProfile.Address);
                    gameTitle = $"{actualCategory.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - No region selected when prompted. Canceled.");
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{actualCategory.Title}";
                }

                int indexOfFiles = 0;
                int totalLengthFiles = SelectedModItem.InstallPaths.Length;

                foreach (string installFilePath in SelectedModItem.InstallPaths)
                {
                    if (installFilePath.Contains("dev_hdd0/game/"))
                    {
                        BackupFile gameBackupFile = SettingsData.GetGameFileBackup(SelectedModItem.GameId, Path.GetFileName(installFilePath), installFilePath);

                        if (gameBackupFile != null)
                        {
                            string installPath = gameBackupFile.InstallPath.Replace("/{REGION}/", $"/{gameRegion}/");

                            if (File.Exists(gameBackupFile.LocalPath))
                            {
                                FtpExtensions.UploadFile(ConsoleProfile.Address, gameBackupFile.LocalPath, installPath);
                                SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Installed backup file {Path.GetFileName(installPath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath).Replace(@"\", @"/")})");
                                indexOfFiles++;
                            }
                            else
                            {
                                DarkMessageBox.Show(this, "You've created a backup for this game file, but the file doesn't exist anymore. Open the Tools > Game File Backup Manager to edit your backup set the local file. This game file will be ignored.", "No Backup File", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (installFilePath.Contains("dev_usb000/"))
                    {
                        if (DarkMessageBox.Show(this, "The mod wants to uninstall a file from your USB drive." +
                            "\n\nIf you would still like to continue, then insert your usb into the right-most slot at the front of the console. Would you like to continue? Only click 'YES' if you've connected the USB device. Otherwise this file will be ignored.", "Install USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            FtpExtensions.DeleteFile(ConsoleProfile.Address, installFilePath);
                            SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uninstalled file {Path.GetFileName(installFilePath)} ({indexOfFiles}/{totalLengthFiles}) from {Path.GetDirectoryName(installFilePath).Replace(@"\", @"/")})");
                            indexOfFiles++;
                        }
                    }
                    else
                    {
                        FtpExtensions.DeleteFile(ConsoleProfile.Address, installFilePath);
                        SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uninstalled file {Path.GetFileName(installFilePath)} ({indexOfFiles}/{totalLengthFiles}) from {Path.GetDirectoryName(installFilePath).Replace(@"\", @"/")})");
                        indexOfFiles++;
                    }
                }

                SetStatus($"Mods  : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Successfully uninstalled {indexOfFiles} files");
            }
            catch (Exception ex)
            {
                SetStatus($"Mods : Unable to uninstall files '{SelectedModItem.Name} ({SelectedModItem.Type}) ({SelectedModItem.Id}) for {actualCategory.Title} - {ex.Message}", ex);
                DarkMessageBox.Show(this, "An error occurred uninstalling the files for this mod. See menu HELP > Report Bug/Suggestions to submit an issue, and attach your log.txt file contents so this bug can be investigated and fixed." +
                   "\n\nError Message:\n" + ex.Message, "Uninstall Error", MessageBoxIcon.Error);
            }
        }

        private void ToolStripDownloadArchive_Click(object sender, EventArgs e)
        {
            SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Preparing to download mods archive...");

            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        SelectedModItem.DownloadArchiveAtPath(folderBrowser.SelectedPath);
                        SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Successfully downloaded archive to '{folderBrowser.SelectedPath}'");
                    }
                    else
                    {
                        SetStatus($"Mods : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Archive download canceled.");
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Mods : Unable to download archive '{SelectedModItem.Name} ({SelectedModItem.Id}) for {SelectedCategory.Title} (Access may be denied to the specified path, try a different one) - {ex.Message}", ex);
            }
        }

        private void ToolStripFavorite_Click(object sender, EventArgs e)
        {
            if (ToolStripFavoriteMod.Text == "Favorite")
            {
                ToolStripFavoriteMod.Text = "Unfavorite";
                SettingsData.FavoritedIds.Add(SelectedModItem.Id.ToString());
            }
            else
            {
                ToolStripFavoriteMod.Text = "Favorite";
                SettingsData.FavoritedIds.Remove(SelectedModItem.Id.ToString());

                if (SelectedCategory.Id == "fvrt")
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }
            }

            ToolStripFavoriteMod.AutoSize = false;
            ToolStripFavoriteMod.AutoSize = true;

            ToolStripArchiveInformation.Update();
        }

        private void ButtonLocalDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    LocalDirectoryPath = folderBrowser.SelectedPath;
                    LoadLocalDirectory(LocalDirectoryPath);
                }
            }
        }

        private void ButtonConsoleExplorerNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsoleDirectory.Text);
        }

        private void DgvLocalFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvLocalFiles.SelectedRows.Count > 0)
            {
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                ToolStripItemLocalUploadFile.Enabled = type == "file";
                ToolStripLocalDeleteFile.Enabled = type == "file";
                ContextMenuStripLocalUploadFile.Enabled = type == "file";
                ContextMenuStripLocalDeleteFile.Enabled = type == "file";
            }
        }

        private void DgvConsoleFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvConsoleFiles.SelectedRows.Count > 0)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                ToolStripItemConsoleFileDownload.Enabled = type == "file";
                ToolStripItemConsoleFileDelete.Enabled = type == "file";
                ContextMenuConsoleDownloadFile.Enabled = type == "file";
                ContextMenuConsoleDeleteFile.Enabled = type == "file";
            }
        }

        private void DgvLocalFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (name == "..")
                {
                    string parentDirecory = Directory.GetParent(LocalDirectoryPath).FullName;

                    if (Directory.Exists(parentDirecory))
                    {
                        LoadLocalDirectory(parentDirecory);
                    }
                }
                else if (type == "folder")
                {
                    LoadLocalDirectory(LocalDirectoryPath + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString());
                }

                ToolStripItemLocalUploadFile.Enabled = type == "file";
                ToolStripLocalDeleteFile.Enabled = type == "file";
                ContextMenuStripLocalUploadFile.Enabled = type == "file";
                ContextMenuStripLocalDeleteFile.Enabled = type == "file";

                ToolStripItemLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalDirectory.Text);
            }
        }

        private void DgvConsoleFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (name == ".")
                {
                    LoadConsoleDirectory("/");
                }
                else if (name == "..")
                {
                    LoadConsoleDirectory(Path.GetDirectoryName(new FtpDirectoryInfo(FtpConnection, FtpDirectoryPath).FullName).Replace(@"\", "/"));
                }
                else if (type == "folder")
                {
                    LoadConsoleDirectory(FtpDirectoryPath + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString());
                }

                ToolStripItemConsoleFileDownload.Enabled = type == "file";
                ToolStripItemConsoleFileDelete.Enabled = type == "file";
                ContextMenuConsoleDownloadFile.Enabled = type == "file";
                ContextMenuConsoleDeleteFile.Enabled = type == "file";
            }
        }

        public string LocalDirectoryPath { get; set; } = @"\";

        public void LoadLocalDirectory(string directoryPath)
        {
            DgvLocalFiles.Rows.Clear();
            DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, "..", "", ".", DateTime.Now);

            try
            {
                LocalDirectoryPath = directoryPath.Replace("\\", @"\");
                TextBoxLocalDirectory.Text = directoryPath.Replace("\\", @"\");

                foreach (string directoryItem in Directory.GetDirectories(directoryPath))
                {
                    DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, Path.GetFileName(directoryItem), "-", "file-folder", Directory.GetLastWriteTime(directoryItem));
                }

                foreach (string fileItem in Directory.GetFiles(directoryPath))
                {
                    DgvLocalFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(fileItem), new FileInfo(fileItem).Length.ToString("#,##0") + " bytes", Path.GetExtension(fileItem).ToUpper().Trim('.') + " File", File.GetLastWriteTime(fileItem));
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Local File Explorer : Unable to retrieve directory listing - " + ex.Message, ex);
                LoadLocalDirectory(Directory.GetParent(LocalDirectoryPath).FullName);
            }
        }

        public string FtpDirectoryPath { get; set; } = "/";

        public FtpConnection FtpConnection { get; set; } = null;

        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                SetStatus(string.Format("Console File Explorer : Preparing to connect to console..."));

                if (FtpConnection == null)
                {
                    FtpConnection = new FtpConnection(ConsoleProfile.Address);
                }

                using (FtpConnection)
                {
                    FtpConnection.Open(); /* Open the FTP connection */
                    FtpConnection.Login(); /* Login using previously provided credentials */

                    DgvConsoleFiles.Rows.Clear();

                    SetStatus(string.Format("Console File Explorer : Retrieving directory listing of '{0}'...", directoryPath.Replace("//", "/")));

                    FtpDirectoryPath = directoryPath.Replace("//", "/");
                    TextBoxConsoleDirectory.Text = directoryPath.Replace("//", "/");

                    FtpConnection.SetCurrentDirectory(FtpDirectoryPath);

                    //FtpDirectoryInfo rootDirectoryInfo = FtpConnection.GetCurrentDirectoryInfo();

                    foreach (FtpDirectoryInfo ftpDirectoryInfo in FtpConnection.GetDirectories(FtpDirectoryPath))
                    {
                        DgvConsoleFiles.Rows.Add("folder", Resources.icons8_folder_16, ftpDirectoryInfo.Name, "-", "file-folder", ftpDirectoryInfo.LastWriteTimeUtc);
                    }

                    foreach (FtpFileInfo ftpFileInfo in FtpConnection.GetFiles(FtpDirectoryPath))
                    {
                        long ftpFileSize = 0;

                        try
                        {
                            ftpFileSize = FtpConnection.GetFileSize(ftpFileInfo.FullName);
                        }
                        catch (FtpException ex)
                        {
                            Program.Log.Error(string.Format("An error occurred fetching file size for file {0}", ftpFileInfo.FullName), ex);
                        }
                        catch (Exception ex)
                        {
                            Program.Log.Error(string.Format("An error occurred fetching file size for file {0}", ftpFileInfo.FullName), ex);
                        }

                        DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, ftpFileInfo.Name, ftpFileSize.ToString("#,##0") + " bytes", Path.GetExtension(ftpFileInfo.FullName).ToUpper().Trim('.') + " File", ftpFileInfo.LastWriteTimeUtc);
                    }

                    SetStatus(string.Format("Console File Explorer : Directory listing of '{0}' successful ({1} Items)", FtpDirectoryPath, DgvConsoleFiles.Rows.Count));
                }
            }
            catch (FtpException ex)
            {
                SetStatus($"Console File Explorer : An error occurred attempting to display directory listing - {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                SetStatus($"Console File Explorer : An error occurred attempting to display directory listing - {ex.Message}", ex);
            }
        }

        private void ToolStripLocalUploadFile_Click(object sender, EventArgs e)
        {
            UploadLocalFile();

        }

        private void ToolStripLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalFile();
        }

        private void ToolStripLocalOpenExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", TextBoxLocalDirectory.Text);
            }
            catch (Exception ex)
            {
                SetStatus(string.Format("An error occurred retrieving this directory listing ({0}) - {1}", TextBoxLocalDirectory.Text, ex.Message), ex);
            }
        }

        private void ToolStripItemConsoleFileDownload_Click(object sender, EventArgs e)
        {
            DownloadConsoleFile();
        }

        private void ToolStripItemConsoleFileDelete_Click(object sender, EventArgs e)
        {
            DeleteConsoleFile();
        }

        private void ToolStripConsoleFileRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        private void ContextMenuStripLocalFileUpload_Click(object sender, EventArgs e)
        {
            UploadLocalFile();
        }

        private void ContextMenuStripLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalFile();
        }

        private void ContextMenuConsoleDownloadFile_Click(object sender, EventArgs e)
        {
            DownloadConsoleFile();
        }

        private void ContextMenuConsoleDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteConsoleFile();
        }

        private void ContextMenuConsoleRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        public void UploadLocalFile()
        {
            try
            {
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                string installFile = TextBoxConsoleDirectory.Text + "/" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (File.Exists(localFile))
                {
                    SetStatus($"Local File Explorer : Starting upload of local file to console...");
                    FtpExtensions.UploadFile(ConsoleProfile.Address, localFile, installFile);
                    DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(installFile), new FileInfo(localFile).Length.ToString("#,##0") + " bytes", Path.GetExtension(localFile).ToUpper().Trim('.') + " File", File.GetLastWriteTime(installFile));
                    SetStatus(string.Format("File Explorer : Successfully uploaded file {0} to console path {1}", Path.GetFileName(localFile), Path.GetDirectoryName(installFile)));
                }
                else
                {
                    SetStatus($"Local File Explorer : Unable to install local file as it doesn't exist on drive.");
                }

            }
            catch (Exception ex)
            {
                SetStatus($"Local File Explorer : An error occurred when upladoing this local file to console : " + ex.Message, ex);
            }
        }

        public void DeleteLocalFile()
        {
            string localFile = TextBoxLocalDirectory.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            if (File.Exists(localFile))
            {
                File.Delete(localFile);
                DgvLocalFiles.Rows.RemoveAt(DgvLocalFiles.CurrentRow.Index);
            }
        }

        public void DownloadConsoleFile()
        {
            try
            {
                string consoleFile = TextBoxConsoleDirectory.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (File.Exists(localFile))
                {
                    File.Delete(localFile);
                }

                SetStatus($"Console File Explorer : Starting download of file from console to computer...");
                FtpExtensions.DownloadFile(ConsoleProfile.Address, localFile, consoleFile);
                SetStatus(string.Format("Console File Explorer : Successfully downloaded file {0} to directory {1}", Path.GetFileName(localFile), Path.GetDirectoryName(localFile)));

            }
            catch (Exception ex)
            {
                SetStatus($"Console File Explorer : An error occurred downloading file - " + ex.Message, ex);
            }

            LoadLocalDirectory(LocalDirectoryPath);
        }

        public void DeleteConsoleFile()
        {
            try
            {
                string consoleFile = TextBoxConsoleDirectory.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                SetStatus($"Console File Explorer : Starting delete of file...");
                FtpExtensions.DeleteFile(ConsoleProfile.Address, consoleFile);
                DgvConsoleFiles.Rows.RemoveAt(DgvConsoleFiles.CurrentRow.Index);
                SetStatus(string.Format("Console File Explorer : Successfully delete {0} file", Path.GetFileName(localFile)));
            }
            catch (Exception ex)
            {
                SetStatus($"Console File Explorer : Unable to delete file - " + ex.Message, ex);
            }
        }

        public void EditBackupDialog(BackupFile backupFile)
        {
            using (EditBackupForm editBackupForm = new EditBackupForm() { BackupFile = backupFile })
            {
                editBackupForm.ShowDialog(this);
            }
        }

        /// <summary>
        ///     Sets the UI to display the selected mod's details
        /// </summary>
        /// <param name="modId">Id of the mod item</param>
        private void ShowModDetails(long modId)
        {
            DgvInstallPaths.Rows.Clear();

            ModsData.ModItem modItem = Mods.GetModById(modId);

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = string.Format("{0} {1}", modItem.Name, SettingsData.ShowModIds ? "(ID # " + modItem.Id.ToString() + ")" : "");
            LabelCategory.Text = Categories.GetCategoryById(Mods.GetModById(modId).GameId).Title;
            LabelFirmware.Text = modItem.Firmware + " Systems";
            LabelType.Text = modItem.Type;
            LabelAuthor.Text = modItem.Author;
            LabelSubmittedBy.Text = modItem.SubmittedBy;
            LabelVersion.Text = modItem.Version;
            LabelConfig.Text = modItem.Configuration;
            LabelDescription.Text = modItem.Description;

            foreach (string filePath in modItem.InstallPaths)
            {
                DgvInstallPaths.Rows.Add(filePath);
            }

            ToolStripFavoriteMod.Text = SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) ? "Unfavorite" : "Favorite";
            ToolStripFavoriteMod.AutoSize = false;
            ToolStripFavoriteMod.AutoSize = true;

            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     Loops and adds either entire or users favourites mods from the database for the given game and filter into the gridview
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        private void LoadModsByCategoryId(string gameId, string firmware, string type)
        {
            DgvMods.Rows.Clear();

            ComboBoxType.Items.Clear();
            ComboBoxType.Items.Add("ANY");

            foreach (var modItem in Mods.GetModItems(gameId, firmware, type))
            {
                DgvMods.Rows.Add(modItem.Id, modItem.Name, modItem.Configuration, modItem.Firmware, modItem.Type, modItem.Version, modItem.Author, modItem.InstallPaths.Length + (modItem.InstallPaths.Length == 1 ? " file" : " files"), ImageExtensions.ResizeBitmap(Resources.icons8_download_22, 21, 21), ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 21, 21));

                if (!ComboBoxType.Items.Contains(modItem.Type))
                {
                    ComboBoxType.Items.Add(modItem.Type);
                }
            }

            DgvMods.Sort(DgvMods.Columns[1], ListSortDirection.Ascending);

            if (DgvMods.Rows.Count > 0)
            {
                DgvMods.CurrentCell = DgvMods[1, 0];
                DgvMods.Enabled = true;
            }
            else
            {
                DgvMods.Enabled = false;
            }

            ComboBoxType.SelectedIndexChanged -= ComboBoxType_SelectedIndexChanged;
            if (string.IsNullOrEmpty(type))
            {
                ComboBoxType.SelectedIndex = 0;
            }
            else
            {
                ComboBoxType.SelectedIndex = ComboBoxType.Items.IndexOf(type);
            }
            ComboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
        }

        public void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        private void ScrollBarDetails_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            FlowPanelDetails.VerticalScroll.Value = ScrollBarDetails.Value;
            FlowPanelDetails.Update();
        }

        private void FlowPanelDetails_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarDetails.Value = FlowPanelDetails.VerticalScroll.Value;
        }

        /// <summary>
        ///     Set the current connected console status in the tool strip
        /// </summary>
        /// <param name="consoleProfile"></param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            if (consoleProfile == null)
            {
                ToolStripLabelConsole.Text = "Idle";
            }
            else
            {
                ToolStripLabelConsole.Text = $@"{consoleProfile.Name} ({consoleProfile.Address})";
            }
        }

        /// <summary>
        ///     Set the current process status in the tool strip
        /// </summary>
        /// <param name="status"></param>
        private void SetStatus(string status, Exception ex = null)
        {
            ToolStripLabelStatus.Text = status;

            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(status, ex);
            }

            Refresh();
        }

        private void EnableConsoleActions(bool enable)
        {
            MenuItemToolsFileBackupManager.Enabled = enable;
            ToolStripItemConsoleFileDownload.Enabled = enable;
            ToolStripItemConsoleFileDelete.Enabled = enable;
            ToolStripInstallMod.Enabled = enable;
            ToolStripUninstallMod.Enabled = enable;
            ToolStripDownloadMod.Enabled = enable;

            if (!enable)
            {
                DgvConsoleFiles.Rows.Clear();
            }
        }

        // Remove dotted borders from the cells upon focus
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void SaveSettingsData()
        {
            // Save settings to file
            using (StreamWriter streamWriter = new StreamWriter(SettingsDataFile))
            {
                streamWriter.Write(JsonConvert.SerializeObject(SettingsData));
            }
        }

        private void LoadSettingsData()
        {
            // Load settings into application
            if (File.Exists(SettingsDataFile))
            {
                using (StreamReader streamReader = new StreamReader(SettingsDataFile))
                {
                    SettingsData = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                }
            }

            if (SettingsData.ConsoleProfiles.Count == 0)
            {
                SettingsData.ConsoleProfiles.Add(new ConsoleProfile() { Name = "Default Console", Address = "192.168.0.42" });
            }
        }
    }
}
