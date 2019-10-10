using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Application;
using ModioX.Models.Database;
using ModioX.Properties;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        public static string ProfileName { get; set; }

        /// <summary>
        ///     Contains the selected console profile ip address
        /// </summary>
        public static string ProfileIP { get; set; }

        /// <summary>
        ///     Contains the selected game data selected by the user
        /// </summary>
        private static CategoriesData.Category SelectedCategory { get; set; }

        /// <summary>
        ///     Contains the selected mods info selected by the user
        /// </summary>
        private static ModsData.ModItem SelectedModItem { get; set; }

        /// <summary>
        ///     Whether the user's selected console has been connected
        /// </summary>
        private static bool IsConnected { get; set; }

        public static SettingsData SettingsData { get; set; } = new SettingsData();

        public static readonly string SettingsDataFile = Path.Combine(Environment.CurrentDirectory, "SettingsData.json");

        public MainForm()
        {
            mainForm = this;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatus($"Initializing application data...");

            Application.Update.CheckApplicationVersion();
            LoadSettingsData();
            Worker.RunWorkAsync(LoadData, InitializeFinished);

            // Load Settings UI
            MenuStripSettingsAutoDetectGameRegion.Checked = SettingsData.AutoDetectGameRegion;
            MenuStripSettingsSaveCurrentLocalDirectory.Checked = SettingsData.SaveLocalDirectory;
            MenuStripSettingsEnableFileManager.Checked = SettingsData.EnableFileExplorer;

            LoadProfiles();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
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

            ComboBoxConsole.Enabled = true;
            ListViewGamesCategories.Items.Clear();

            foreach (CategoriesData.Category category in Categories.Categories)
            {
                ListViewGamesCategories.Items.Add(new DarkListItem()
                {
                    Tag = category.Id,
                    Text = category.Id.Equals("fvrt") ? string.Format("{0} ({1})", category.Title, SettingsData.FavoritedIds.Count) : string.Format("{0} ({1})", category.Title, Mods.GetModsByGameId(category.Id).Length)
                });
            }
            ListViewGamesCategories.SelectItem(0);

            SetComboBoxItems();
            ComboBoxFirmware.SelectedIndex = 0;

            SelectedCategory = Categories.Categories[0];
            LoadModsByCategoryId(
                SelectedCategory.Id, 
                "", 
                "", 
                "");

            ToolStripLabelStats.Text = string.Format("{0} Mods for {1} Games, {2} Game Updates, {3} Homebrew Packages, {4} Resources && {5} Themes", Mods.TotalGameMods, Categories.TotalGames, Mods.TotalGameUpdates, Mods.TotalHomebrew, Mods.TotalResources, Mods.TotalThemes);

            SetStatus($"Initialized ModioX successful (Version {Utilities.GetCurrentVersion()}) - Ready to connect to console...");
        }

        private void LoadProfiles()
        {
            ComboBoxConsole.Items.Clear();

            foreach (string console in SettingsData.ConsoleProfiles)
            {
                ComboBoxConsole.Items.Add(console);
            }

            ComboBoxConsole.SelectedIndex = 0;
        }

        private void MenuStripFileRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Refreshing application data...");
            DisconnectConsole();
            Worker.RunWorkAsync(LoadData, InitializeFinished);
        }

        private void MenuStripFileExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MenuStripContribute_Click(object sender, EventArgs e)
        {
            Process.Start(Utilities.ProjectRepoUrl);
        }

        private void MenuStripSettingsEditConsoles_Click(object sender, EventArgs e)
        {
            using (ProfilesForm consolesWindow = new ProfilesForm())
            {
                consolesWindow.ShowDialog(this);
                LoadProfiles();
            }
        }

        private void MenuStripSettingsEnableFileManager_Click(object sender, EventArgs e)
        {
            SettingsData.EnableFileExplorer = MenuStripSettingsEnableFileManager.Checked;
        }

        private void MenuStripSettingsAutoDetectRegion_Click(object sender, EventArgs e)
        {
            SettingsData.AutoDetectGameRegion = MenuStripSettingsAutoDetectGameRegion.Checked;
        }

        private void MenuStripSettingsSaveCurrentLocalDirectory_Click(object sender, EventArgs e)
        {
            SettingsData.SaveLocalDirectory = MenuStripSettingsSaveCurrentLocalDirectory.Checked;
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

        private void MenuStripApplicationsCCAPI_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ControlConsoleAPI\CCAPIConsoleManager.exe");

            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                DarkMessageBox.Show(this, "Could not locate the Console Manager CCAPI application at the default installation path. This option could become customizable in future updates.", "Not Found", MessageBoxIcon.Error);
            }
        }

        private void MenuStripHelpSourceCode_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ohhsoash/ModioX");
        }

        private void MenuStripHelpGitHubIssues_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ohhsoash/ModioX/issues/new");
        }

        private void MenuStripHelpAbout_Click(object sender, EventArgs e)
        {
            DarkMessageBox.Show(this, "ModioX was developed by @ohhsoash and few friends, with the only intention of providing an efficient tool for browsing, downloading and installing game and console mods directly. All credits are given to those appropriate creators/authors of the mods used in this application. If you have any questions please send a message at my Discord: wh1ter0se#7480 with your much welcomed comments, suggestions and feedback to help support this project.", "Information", MessageBoxIcon.Information);
        }

        private void ButtonConnectConsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConnected)
                {
                    DisconnectConsole();
                }
                else
                {
                    ConnectConsole();
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Console : There was an issue connecting or disconnecting console {ProfileName} ({ProfileIP}) - {ex.Message}", ex);
            }
        }

        private void ConnectConsole()
        {
            SetStatus($"Console : {ProfileName} ({ProfileIP}) - Preparing to establish a connection...");
            FtpConnection = new FtpConnection(ProfileIP);
            SetStatusConsole(ProfileName, ProfileIP);
            ComboBoxConsole.Enabled = false;
            ButtonConnectConsole.Text = "Disconnect";
            IsConnected = true;
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
            SetStatus($"Console : {ProfileName} ({ProfileIP}) - Preparing for disconnection...");
            FtpConnection = null;
            ComboBoxConsole.Enabled = true;
            ButtonConnectConsole.Text = "Connect";
            SetStatusConsole("None", "n/a");
            SetStatus("Console : Disconnected from console");
            IsConnected = false;
            EnableConsoleActions(false);
        }

        private void ComboBoxConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxConsole.SelectedIndex != -1)
            {
                ProfileName = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem)
                    .Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[0];
                ProfileIP = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem)
                    .Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1];
            }

            ButtonConnectConsole.Enabled = !string.IsNullOrWhiteSpace(ProfileIP);
        }

        string SelectedModQuery { get; set; } = "";

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
                    SelectedModQuery,
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
                SelectedModQuery,
                SelectedModFirmware,
                SelectedModType);
        }

        private void ButtonRequestMods_Click(object sender, EventArgs e)
        {
            Utilities.OpenRequestTemplate();
        }

        private void ButtonPickRandom_Click(object sender, EventArgs e)
        {
            if (DgvMods.RowCount > 0)
            {
                DgvMods.CurrentCell = DgvMods[1, new Random().Next(0, DgvMods.RowCount)];
                ShowModDetails(long.Parse(DgvMods.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void ListViewGamesCategories_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (ListViewGamesCategories.SelectedIndices.Count > 0)
            {
                SelectedCategory = Categories.GetCategoryById(ListViewGamesCategories.Items[ListViewGamesCategories.SelectedIndices[0]].Tag.ToString());

                LoadModsByCategoryId(
                    SelectedCategory.Id, 
                    SelectedModQuery, 
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

            ToolStripInstallFiles.Enabled = DgvMods.SelectedRows.Count != 0 && IsConnected;
            ToolStripDownloadArchive.Enabled = DgvMods.SelectedRows.Count != 0;
            ToolStripFavorite.Enabled = DgvMods.SelectedRows.Count != 0;
        }

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                if (DgvMods.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
                {
                    ToolStripDownloadArchive.PerformClick();
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
                {
                    ToolStripFavorite.PerformClick();
                }
            }

            ToolStripInstallFiles.Enabled = e.RowIndex != -1 && IsConnected;
            ToolStripDownloadArchive.Enabled = e.RowIndex != -1;
            ToolStripFavorite.Enabled = e.RowIndex != -1;
        }

        private void DgvMods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
        }

        private void ContextMenuModsInstallToConsole_Click(object sender, EventArgs e)
        {
            ToolStripInstallFiles.PerformClick();
        }

        private void ContextMenuModsDownloadArchive_Click(object sender, EventArgs e)
        {
            ToolStripDownloadArchive.PerformClick();
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

        private void ToolStripInstallFiles_Click(object sender, EventArgs e)
        {
            CategoriesData.Category actualCategory = Categories.GetCategoryById(SelectedModItem.GameId);

            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - Preparing to install mods...");

            bool isGameMod = actualCategory.RequiresRegion();

            try
            {
                string gameTitle;
                string gameRegion;

                // Retrieve the users game region if needed
                if (isGameMod)
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - Retrieving game region...");
                    gameRegion = actualCategory.GetGameRegion(ProfileIP);
                    gameTitle = $"{actualCategory.Title} ({gameRegion})";
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{actualCategory.Title}";
                }

                if (isGameMod && string.IsNullOrEmpty(gameRegion))
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {actualCategory.Title} - No region chosen for game.");
                    DarkMessageBox.Show(this, "There was no region chosen for this game title. Install this again.", "No Region", MessageBoxIcon.Exclamation);
                    return;
                }

                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Downloading and extracting mods archive...");
                SelectedModItem.DownloadArchive();

                int indexOfFiles = 0;
                int totalLengthFiles = SelectedModItem.InstallPaths.Length;

                foreach (string installFilePath in SelectedModItem.InstallPaths)
                {
                    foreach (string localFilePath in Directory.GetFiles(SelectedModItem.GetDirectoryDownloadData(), "*.*", SearchOption.AllDirectories))
                    {
                        if (string.Equals(Path.GetFileName(installFilePath), Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            string installPath = installFilePath.Replace("/{REGION}/", $"/{gameRegion}/");

                            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Preparing to upload modded files...");

                            //if (installPath.StartsWith("/dev_hdd0/game/", StringComparison.InvariantCultureIgnoreCase))
                            if (installPath.Contains("dev_hdd0/game/"))
                            {
                                if (DarkMessageBox.Show(this, "A file is being uploaded to your game folder. Would you like to first backup the original game file before installing this file? You can then revert the mods at anytime using the Tools > Backup File Manager window to restore the game files to their original state.\n\nFile being installed : " + Path.GetFileName(installFilePath), "Backup Game File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Creating game backup file for {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to a folder...");

                                    string backupFileFolder = Path.Combine(SelectedModItem.GetDirectoryGameData(), "Game Backup Files");
                                    string backupGameFile = Path.Combine(backupFileFolder, Path.GetFileName(localFilePath));

                                    Directory.CreateDirectory(backupFileFolder);

                                    BackupFile backupFile = new BackupFile()
                                    {
                                        Name = "Original Game File",
                                        File = Path.GetFileName(installPath),
                                        GameId = SelectedModItem.GameId,
                                        LocalPath = backupGameFile,
                                        InstallPath = installPath
                                    };

                                    EditBackupDialog(backupFile);

                                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uploading {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ProfileIP, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                                else
                                {
                                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uploading {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ProfileIP, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                            }
                            else if (installFilePath.Contains("dev_usb000/"))
                            {
                                if (DarkMessageBox.Show(this, "A file wants to be uploaded to usb device - it maybe required for the mods to function, or not. I suggest reading the complete description to see if it's mentioned there. It could be used for configuration or settings purposes." +
                                    "\n\nIf you would still like to proceed, then plug your usb into the right-most slot of the console ports at the front. So, should the file be installed? Only click 'YES' if you've connected the usb device.", "USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uploading {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ProfileIP, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                            }
                            else
                            {
                                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uploading {Path.GetFileName(localFilePath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                FtpExtensions.UploadFile(ProfileIP, localFilePath, installPath);
                                indexOfFiles++;
                            }
                        }
                    }
                }

                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Successfully installed ({totalLengthFiles} files)");
            }
            catch (Exception ex)
            {
                SetStatus($"Mods Archive : Unable to install files '{SelectedModItem.Name} ({SelectedModItem.Id}) for {actualCategory.Title} - {ex.Message}", ex);
                DarkMessageBox.Show(this, "There was an issue installing the mods for some reason. I encourage you to submit your log.txt file contents to our GitHub issue tracker so this can be resolved. You can find us at 'ohhsoash/ModioX' on GitHub repos.", "Error");
            }
        }

        public void EditBackupDialog(BackupFile backupFile)
        {
            using (EditBackupForm editBackupForm = new EditBackupForm() { BackupFile = backupFile })
            {
                editBackupForm.ShowDialog(this);
            }
        }

        private void ToolStripDownloadArchive_Click(object sender, EventArgs e)
        {
            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Preparing to download mods archive...");

            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        SelectedModItem.DownloadArchiveAtPath(folderBrowser.SelectedPath);
                        SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Successfully downloaded mods archive to '{folderBrowser.SelectedPath}'");
                    }
                    else
                    {
                        SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Canceled request to download archive.");
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Mods Archive : Unable to download mods archive '{SelectedModItem.Name} ({SelectedModItem.Id}) for {SelectedCategory.Title}  (Access may be denied to the specified path, try a different one) - {ex.Message}", ex);
            }
        }

        private void ToolStripFavorite_Click(object sender, EventArgs e)
        {
            if (ToolStripFavorite.Text == "Favorite")
            {
                ToolStripFavorite.Text = "Unfavorite";
                SettingsData.FavoritedIds.Add(SelectedModItem.Id.ToString());
            }
            else
            {
                ToolStripFavorite.Text = "Favorite";
                SettingsData.FavoritedIds.Remove(SelectedModItem.Id.ToString());

                if (SelectedCategory.Id == "fvrt")
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }
            }

            ToolStripFavorite.AutoSize = false;
            ToolStripFavorite.AutoSize = true;
        }

        private void ButtonUninstallFiles_Click(object sender, EventArgs e)
        {
            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Preparing to uninstall files...");

            try
            {
                string gameTitle;
                string gameRegion;

                if (SelectedCategory.RequiresRegion())
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - Retrieving game region...");
                    gameRegion = SelectedCategory.GetGameRegion(ProfileIP);
                    gameTitle = $"{SelectedCategory.Title} ({gameRegion})";
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{SelectedCategory.Title}";
                }

                if (string.IsNullOrEmpty(gameRegion))
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedCategory.Title} - No region chosen for game.");
                    DarkMessageBox.Show(this, "You didn't select your game region when prompted. Try to do this again.", "No Region", MessageBoxIcon.Exclamation);
                    return;
                }

                int currentFileNo = 0;
                int totalFileNo = SelectedModItem.InstallPaths.Length;

                foreach (string installFilePath in SelectedModItem.InstallPaths)
                {
                    currentFileNo++;

                    if (!installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                    {
                        SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Uninstalling {Path.GetFileName(installFilePath)} ({currentFileNo}/{totalFileNo}) from {Path.GetDirectoryName(installFilePath)}");
                        FtpExtensions.DeleteFile(ProfileIP, "/" + installFilePath.Replace("/{REGION}/", $"/{gameRegion}/"));
                    }
                }

                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {gameTitle} - Successfully uninstalled files ({currentFileNo} files)");
            }
            catch (Exception ex)
            {
                SetStatus($"Mods Archive : Unable to uninstall files '{SelectedModItem.Name} ({SelectedModItem.Type}) ({SelectedModItem.Id}) for {SelectedCategory.Title} - {ex.Message}", ex);
            }
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

        private void ButtonNavigateConsoleExplorer_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsoleDirectory.Text);
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

                ToolItemLocalUploadFile.Enabled = type == "file";
                ToolItemLocalDeleteFile.Enabled = type == "file";
                ContextMenuStripLocalUploadFile.Enabled = type == "file";
                ContextMenuStripLocalDeleteFile.Enabled = type == "file";

                ToolItemLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalDirectory.Text);
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

                ToolItemConsoleDownloadFile.Enabled = type == "file";
                ToolItemConsoleDeleteFile.Enabled = type == "file";
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
                    DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, Path.GetFileName(directoryItem), "", "file-folder", Directory.GetLastWriteTime(directoryItem));
                }

                foreach (string fileItem in Directory.GetFiles(directoryPath))
                {
                    DgvLocalFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(fileItem), new FileInfo(fileItem).Length.ToString("#,##0") + " bytes", Path.GetExtension(fileItem).ToUpper().Trim('.') + " File", File.GetLastWriteTime(fileItem));
                }
            }
            catch (Exception ex)
            {
                SetStatus($"File Explorer : Unable to retrieve local directory listing - " + ex.Message, ex);
                LoadLocalDirectory(Directory.GetParent(LocalDirectoryPath).FullName);
            }
        }

        public string FtpDirectoryPath { get; set; } = "/";

        public FtpConnection FtpConnection { get; set; } = null;

        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                if (FtpConnection == null)
                {
                    FtpConnection = new FtpConnection(ProfileIP);
                }

                FtpConnection.Login();

                DgvConsoleFiles.Rows.Clear();

                SetStatus(string.Format("Retrieving console directory listing of '{0}'...", directoryPath.Replace("//", "/")));

                FtpDirectoryPath = directoryPath.Replace("//", "/");
                TextBoxConsoleDirectory.Text = directoryPath.Replace("//", "/");

                FtpConnection.SetCurrentDirectory(FtpDirectoryPath);

                //FtpDirectoryInfo rootDirectoryInfo = FtpConnection.GetCurrentDirectoryInfo();

                foreach (FtpDirectoryInfo ftpDirectoryInfo in FtpConnection.GetDirectories(FtpDirectoryPath))
                {
                    DgvConsoleFiles.Rows.Add("folder", Resources.icons8_folder_16, ftpDirectoryInfo.Name, "", "file-folder", ftpDirectoryInfo.LastWriteTimeUtc);
                }

                foreach (FtpFileInfo ftpFileInfo in FtpConnection.GetFiles(FtpDirectoryPath))
                {
                    long ftpFileSize = 0;

                    try
                    {
                        ftpFileSize = FtpConnection.GetFileSize(ftpFileInfo.FullName);
                    }
                    catch (Exception ex)
                    {
                        Program.Log.Error(string.Format("An error occurred fetching file size for file {0}", ftpFileInfo.FullName), ex);
                    }

                    //DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, ftpFileInfo.Name, Path.GetExtension(ftpFileInfo.FullName).ToUpper().Trim('.') + " File", ftpFileInfo.LastWriteTimeUtc);
                    DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, ftpFileInfo.Name, ftpFileSize.ToString("#,##0") + " bytes", Path.GetExtension(ftpFileInfo.FullName).ToUpper().Trim('.') + " File", ftpFileInfo.LastWriteTimeUtc);
                }

                SetStatus(string.Format("File Explorer : Console directory listing of '{0}' successful ({1} Items)", FtpDirectoryPath, DgvConsoleFiles.Rows.Count));
            }
            catch (Exception ex)
            {
                SetStatus($"File Explorer : An error occurred attempting to display directory listing - {ex.Message}", ex);
                try { LoadConsoleDirectory(Path.GetDirectoryName(new FtpDirectoryInfo(FtpConnection, FtpDirectoryPath).FullName).Replace(@"\", "/")); } catch { }
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
                SetStatus(string.Format("There was an issue opening this directory ({0}) in explorer : {1}", TextBoxLocalDirectory.Text, ex.Message), ex);
            }
        }

        private void ToolStripConsoleDownloadFile_Click(object sender, EventArgs e)
        {
            DownloadConsoleFile();
        }

        private void ToolStripConsoleDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteConsoleFile();
        }

        private void ToolStripConsoleRefresh_Click(object sender, EventArgs e)
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
                    SetStatus($"File Explorer : Starting upload of local file to console...");
                    FtpExtensions.UploadFile(ProfileIP, localFile, installFile);
                    DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(installFile), new FileInfo(localFile).Length.ToString("#,##0") + " bytes", Path.GetExtension(localFile).ToUpper().Trim('.') + " File", File.GetLastWriteTime(installFile));
                    SetStatus(string.Format("File Explorer : Successfully uploaded file {0} to console path {1}", Path.GetFileName(localFile), Path.GetDirectoryName(installFile)));
                }
                else
                {
                    SetStatus($"File Explorer : Unable to install local file as it doesn't exist on drive.");
                }

            }
            catch (Exception ex)
            {
                SetStatus($"File Explorer : There was an issue trying to upload this local file to the console : " + ex.Message, ex);
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

                SetStatus($"File Explorer : Starting download of file from console to your computer, locating the console file...");
                FtpExtensions.DownloadFile(ProfileIP, localFile, consoleFile);
                SetStatus(string.Format("File Explorer : Successfully downloaded file {0} to directory {1}", Path.GetFileName(localFile), Path.GetDirectoryName(localFile)));

            }
            catch (Exception ex)
            {
                SetStatus($"File Explorer : Unable to download console file to computer - " + ex.Message, ex);
            }

            LoadLocalDirectory(LocalDirectoryPath);
        }

        public void DeleteConsoleFile()
        {
            try
            {
                string consoleFile = TextBoxConsoleDirectory.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                SetStatus($"File Explorer : Starting delete of console file, locating the file...");
                FtpExtensions.DeleteFile(ProfileIP, consoleFile);
                SetStatus(string.Format("File Explorer : Successfully deleted console file {0}", Path.GetFileName(localFile)));
                DgvConsoleFiles.Rows.RemoveAt(DgvConsoleFiles.CurrentRow.Index);

            }
            catch (Exception ex)
            {
                SetStatus($"File Explorer : Unable to delete console file - " + ex.Message, ex);
            }
        }

        /// <summary>
        ///     Sets the UI to display the selected mod's details
        /// </summary>
        /// <param name="modId">Id of the mod item</param>
        private void ShowModDetails(long modId)
        {
            ModsData.ModItem modItem = Mods.GetModById(modId);

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = string.Format("{0} (#{1})", modItem.Name, modItem.Id.ToString());
            LabelCategory.Text = Categories.GetCategoryById(Mods.GetModById(modId).GameId).Title;
            LabelFirmware.Text = modItem.Firmware + " Systems";
            LabelType.Text = modItem.Type;
            LabelAuthor.Text = modItem.Author;
            LabelSubmittedBy.Text = modItem.SubmittedBy;
            LabelVersion.Text = modItem.Version;
            LabelConfig.Text = modItem.Configuration;
            LabelDescription.Text = modItem.Description;

            DgvInstallPaths.Rows.Clear();
            foreach (string filePath in modItem.InstallPaths)
            {
                DgvInstallPaths.Rows.Add(filePath);
            }

            ToolStripFavorite.Text = SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) ? "Unfavorite" : "Favorite";
            ToolStripFavorite.AutoSize = false;
            ToolStripFavorite.AutoSize = true;

            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     Loops and adds either entire or users favourites mods from the database for the given game and filter into the gridview
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="query"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        private void LoadModsByCategoryId(string gameId, string query, string firmware, string type)
        {
            DgvMods.Rows.Clear();

            ComboBoxType.Items.Clear();
            ComboBoxType.Items.Add("ANY");

            // Load favorite mods, otherwise all mods
            if (gameId.Equals("fvrt"))
            {
                foreach (ModsData.ModItem modItem in Mods.Mods)
                {
                    if (SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) && modItem.Firmware.ToLower().Contains(query) && modItem.Firmware.ToLower().Contains(firmware) && modItem.Type.ToLower().Contains(type))
                    {
                        DgvMods.Rows.Add(modItem.Id, modItem.Name, modItem.Firmware, modItem.Type, modItem.Version, modItem.Author, modItem.InstallPaths.Length + (modItem.InstallPaths.Length == 1 ? " file" : " files"), ImageExtensions.ResizeBitmap(Resources.icons8_download_22, 21, 21), ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 21, 21));

                        if (!ComboBoxType.Items.Contains(modItem.Type))
                        {
                            ComboBoxType.Items.Add(modItem.Type);
                        }
                    }
                }
            }
            else
            {
                foreach (ModsData.ModItem modItem in Mods.Mods)
                {
                    if (string.Equals(modItem.GameId, gameId) && modItem.Name.ToLower().Contains(query) && modItem.Firmware.Contains(firmware) && modItem.Type.ToLower().Contains(type))
                    {
                        DgvMods.Rows.Add(modItem.Id, modItem.Name, modItem.Firmware, modItem.Type, modItem.Version, modItem.Author, modItem.InstallPaths.Length + (modItem.InstallPaths.Length == 1 ? " file" : " files"), ImageExtensions.ResizeBitmap(Resources.icons8_download_22, 21, 21), ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 21, 21));

                        if (!ComboBoxType.Items.Contains(modItem.Type))
                        {
                            ComboBoxType.Items.Add(modItem.Type);
                        }
                    }
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
            ScrollBarDetails.Visible = FlowPanelDetails.VerticalScroll.Visible;
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
        /// <param name="name"></param>
        /// <param name="ip"></param>
        private void SetStatusConsole(string name, string ip)
        {
            ToolStripLabelConsole.Text = $@"{name} ({ip})";
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

        private void SetComboBoxItems()
        {
            ComboBoxFirmware.Items.Clear(); ComboBoxFirmware.Items.Add("ANY");

            foreach (ModsData.ModItem modItem in Mods.Mods)
            {
                if (!ComboBoxFirmware.Items.Contains(modItem.Firmware))
                {
                    ComboBoxFirmware.Items.Add(modItem.Firmware);
                }
            }
        }

        private void EnableConsoleActions(bool enable)
        {
            MenuItemToolsGameFileBackupManager.Enabled = enable;
            ToolItemConsoleDownloadFile.Enabled = enable;
            ToolItemConsoleDeleteFile.Enabled = enable;
            ToolStripInstallFiles.Enabled = enable;
            ToolStripDownloadArchive.Enabled = enable;
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
                SettingsData.ConsoleProfiles.Add("Default Console : 192.168.0.42");
            }
        }

        // Dark TextBox Fake Watermark - It doesn't support this yet, maybe add this to source eventually
        readonly string searchWatermark = "Enter text to search...";

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text.Equals(searchWatermark))
            {
                TextBoxSearch.Text = null;
                TextBoxSearch.ForeColor = Color.Gainsboro;
            }
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text.Equals(searchWatermark))
            {
                TextBoxSearch.Text = null;
                TextBoxSearch.ForeColor = Color.Gainsboro;
            }
        }

        private void MenuItemToolsBackupFileManager_Click(object sender, EventArgs e)
        {
            using (BackupManagerForm backupManagerForm = new BackupManagerForm())
            {
                backupManagerForm.ShowDialog(this);
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectedModQuery = TextBoxSearch.Text;

                LoadModsByCategoryId(
                    SelectedCategory.Id, 
                    SelectedModQuery, 
                    SelectedModFirmware,
                    SelectedModType);
            }
        }
    }
}