using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Renderers;
using ModioX.Extensions;
using ModioX.Models;
using ModioX.Properties;

namespace ModioX.Windows
{
    public partial class MainForm : DarkForm
    {
        public static MainForm mainForm;

        /// <summary>
        ///     Contains the latest mods data retrieved from the database
        /// </summary>
        public static ModsData ModsData = new ModsData();

        /// <summary>
        ///     Contains the latest games data retrieved from the database
        /// </summary>
        public static GamesData GamesData = new GamesData();

        /// <summary>
        ///     Contains the console name of the users selected console
        /// </summary>
        private static string UsersConsoleName { get; set; }

        /// <summary>
        ///     Contains the console IP of the users selected console
        /// </summary>
        private static string UsersConsoleIp { get; set; }

        /// <summary>
        ///     Contains the selected game data selected by the user
        /// </summary>
        private static GamesData.Game SelectedGame { get; set; }

        /// <summary>
        ///     Contains the selected mods info selected by the user
        /// </summary>
        private static ModsData.ModItem SelectedModItem { get; set; }

        /// <summary>
        ///     Contains the region response from the user
        /// </summary>
        private static string SelectedGameRegion { get; set; }

        /// <summary>
        ///     Whether the user's selected console has been connected
        /// </summary>
        private static bool IsConsoleConnected { get; set; }

        public MainForm()
        {
            mainForm = this;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatus($"Initializing application data...");

            Application.Update.CheckVersion();
            Worker.RunWorkAsync(LoadData, InitializeFinished);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConsoleConnected)
            {
                Settings.Default.CurrentLocalDirectory = TextBoxLocalDirectory.Text;
            }

            Settings.Default.Save();
        }

        /// <summary>
        ///     Retrieves the games and mods data into the application
        /// </summary>
        private static void LoadData()
        {
            GamesData = Utilities.GetGamesData();
            GamesData.Games = GamesData.Games.OrderBy(o => o.Title).ToArray();
            ModsData = Utilities.GetModsData();
        }

        /// <summary>
        ///     Set a few properties after being initialized
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded database into application - Finalizing data...");

            LoadConsoleProfiles();
            ComboBoxConsole.Enabled = true;
            ListViewGamesCategories.Items.Clear();

            foreach (GamesData.Game gameData in GamesData.Games)
            {
                ListViewGamesCategories.Items.Add(new DarkListItem()
                {
                    Tag = gameData.Id,
                    Text = gameData.Id.Equals("fvrt") ? string.Format("{0} ({1})", gameData.Title, ModsData.GetModsByGameId(gameData.Id).Count) : string.Format("{0} ({1})", gameData.Title, Settings.Default.FavoriteIds.Count)
                });
            }
            ListViewGamesCategories.SelectItem(0);

            SetComboBoxItems();
            ComboBoxFirmware.SelectedIndex = 0;

            SelectedGame = GamesData.Games[0];
            LoadMods(GamesData.Games[0].Id, "", "");

            ToolStripLabelStats.Text = string.Format("{0} Mods for {1} Games, {2} Game Updates, {3} Homebrew Packages, {4} Resources && {5} Themes", ModsData.GetTotalGameMods(), GamesData.TotalGames, ModsData.GetTotalGameUpdates(), ModsData.GetTotalHomebrew(), ModsData.GetTotalResources(), ModsData.GetTotalThemes());

            // Load Settings UI
            MenuStripSettingsAutoDetectGameRegion.Checked = Settings.Default.AutoGameRegion;
            MenuStripSettingsSaveCurrentLocalDirectory.Checked = Settings.Default.SaveCurrentLocalDirectory;
            MenuStripSettingsEnableFileManager.Checked = Settings.Default.EnableFileManager;

            SetStatus($"Initialized ModioX successful (Version {Utilities.GetCurrentVersion()}) - Ready to connect to console...");
        }

        private void LoadConsoleProfiles()
        {
            ComboBoxConsole.Items.Clear();

            foreach (string console in Settings.Default.UserConsoles)
            {
                ComboBoxConsole.Items.Add(console);
            }

            ComboBoxConsole.SelectedIndex = 0;
        }

        private void MenuStripFileRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Refreshing all the data for games and mods...");
            IsConsoleConnected = false;
            ButtonConnectConsole.Text = "Connect";
            ComboBoxConsole.Enabled = false;
            ButtonConnectConsole.Enabled = false;
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
            using (ConsolesWindow consolesWindow = new ConsolesWindow())
            {
                consolesWindow.ShowDialog(this);
                LoadConsoleProfiles();
            }
        }

        private void MenuStripSettingsEnableFileManager_Click(object sender, EventArgs e)
        {
            Settings.Default.EnableFileManager = MenuStripSettingsEnableFileManager.Checked;
        }

        private void MenuStripSettingsAutoDetectRegion_Click(object sender, EventArgs e)
        {
            Settings.Default.AutoGameRegion = MenuStripSettingsAutoDetectGameRegion.Checked;
        }

        private void MenuStripSettingsSaveCurrentLocalDirectory_Click(object sender, EventArgs e)
        {
            Settings.Default.SaveCurrentLocalDirectory = MenuStripSettingsSaveCurrentLocalDirectory.Checked;
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
                DarkMessageBox.Show(this, "Could not locate the Console Manager CCAPI application at the default installation path. This option could become customizable in future updates.", "Not Found");
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
            DarkMessageBox.Show(this, "ModioX was developed by @ohhsoash, with the only intended purpose of providing an efficient method for browsing, downloading and installing popular console and game mods. All credits are given to those appropriate creators/authors of the mods used in this application. If you have any questions please send a message at my Discord: wh1ter0se#7480 with your much welcomed comments, suggestions and feedback to help support this project.", "Information");
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxConsole.SelectedIndex != -1)
            {
                UsersConsoleName = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem).Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[0];
                ComboBoxConsole.SelectedItem = $"{UsersConsoleName} : {UsersConsoleIp}";
            }
            else
            {
                UsersConsoleName = "Unsaved Console";
            }

            ButtonConnectConsole.Enabled = !string.IsNullOrWhiteSpace(UsersConsoleIp);
        }

        private void ButtonConnectConsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConsoleConnected)
                {
                    SetStatus($"Console : {UsersConsoleName} ({UsersConsoleIp}) - Preparing for disconnection...");
                    FtpConnection = null;
                    ComboBoxConsole.Enabled = true;
                    ButtonConnectConsole.Text = "Connect";
                    SetStatusConsole("None", "n/a");
                    SetStatus("Console : Disconnected from console");
                    IsConsoleConnected = false;
                    EnableConsoleActions(false);
                }
                else
                {
                    SetStatus($"Console : {UsersConsoleName} ({UsersConsoleIp}) - Preparing to establish connection...");
                    FtpConnection = new FtpConnection(UsersConsoleIp);
                    SetStatusConsole(UsersConsoleName, UsersConsoleIp);
                    ComboBoxConsole.Enabled = false;
                    ButtonConnectConsole.Text = "Disconnect";
                    IsConsoleConnected = true;
                    EnableConsoleActions(true);

                    SetStatus($"Console : Successfully connected - Ready for files to be installed...");

                    if (Settings.Default.EnableFileManager)
                    {
                        if (Settings.Default.SaveCurrentLocalDirectory)
                        {
                            // Load saved local directory path
                            if (Settings.Default.CurrentLocalDirectory.Equals(@"\") || Settings.Default.CurrentLocalDirectory.Equals(""))
                            {
                                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
                            }
                            else
                            {
                                LoadLocalDirectory(Settings.Default.CurrentLocalDirectory);
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
            }
            catch (Exception ex)
            {
                SetStatus($"Console : There was an issue connecting or disconnecting console {UsersConsoleName} ({UsersConsoleIp}) - {ex.Message}", ex);
            }
        }

        private void ComboBoxConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxConsole.SelectedIndex != -1)
            {
                UsersConsoleName = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem)
                    .Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[0];
                UsersConsoleIp = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem)
                    .Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1];
            }

            ButtonConnectConsole.Enabled = !string.IsNullOrWhiteSpace(UsersConsoleIp);
        }

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

            LoadMods(
                    SelectedGame.Id,
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

            LoadMods(
                SelectedGame.Id,
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
                SelectedGame = Utilities.GetGameById(GamesData, ListViewGamesCategories.Items[ListViewGamesCategories.SelectedIndices[0]].Tag.ToString());
                LoadMods(SelectedGame.Id, SelectedModFirmware, SelectedModType);

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

            ToolStripInstallFiles.Enabled = DgvMods.SelectedRows.Count != 0 && IsConsoleConnected;
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

            ToolStripInstallFiles.Enabled = e.RowIndex != -1 && IsConsoleConnected;
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
                    Utilities.WriteReadMeFile(SelectedModItem, folderBrowser.SelectedPath);
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
            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Preparing to install files...");

            bool isGameMod = Utilities.InstallNeedsRegion(SelectedGame);

            try
            {
                string GameTitle;

                // Retrieve the users game region if needed
                if (isGameMod)
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Retrieving game region...");
                    SelectedGameRegion = Utilities.GetUsersGameRegion(FtpConnection, SelectedGame, Settings.Default.AutoGameRegion);
                    GameTitle = $"{SelectedGame.Title} ({SelectedGameRegion})";
                }
                else
                {
                    GameTitle = $"{SelectedGame.Title}";
                }

                if (SelectedGameRegion == null)
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - No region chosen for game.");
                    DarkMessageBox.Show(this, "There was no region chosen for this game title. Install this again.", "No Region");
                    return;
                }

                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {GameTitle} - Downloading and extracting mods archive...");
                Utilities.DownloadExtractFiles(SelectedModItem);

                int currentFileNo = 0;
                int totalFileNo = SelectedModItem.InstallPaths.Length;

                foreach (string installFilePath in SelectedModItem.InstallPaths)
                {
                    foreach (string modFilePath in Directory.GetFiles(Utilities.GetDirectoryDownloadData(SelectedModItem), "*.*", SearchOption.AllDirectories))
                    {
                        if (string.Equals(Path.GetFileName(installFilePath), Path.GetFileName(modFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            currentFileNo++;

                            /*if (installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                            {
                                SetStatus($"Installing {SelectedModItem.Name} to console - Downloading backup of original game files...");
                                Utilities.DownloadOriginalGameFile(UsersConsoleIp, installFilePath.Replace("/{REGION}/", $"/{SelectedGameRegion}/"), SelectedModItem);
                            }*/

                            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {GameTitle} - Uploading {Path.GetFileName(modFilePath)} ({currentFileNo}/{totalFileNo}) to {Path.GetDirectoryName(installFilePath).Replace("/{REGION}/", $"/{SelectedGameRegion}/")}");

                            if (installFilePath.StartsWith("dev_usb000/"))
                            {
                                if (DarkMessageBox.Show(this, "This mod uploads files to be installed to your usb - it maybe required for the mods to function, or not. It could be used for configuration or settings purposes. If you'd like to proceed, plug your usb into the right-most slot of the console ports at the front. So, would you like to continue with installating your mods? Only click 'YES' if you've connected the usb device.", "USB File Detected", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Utilities.InstallFile(UsersConsoleIp, modFilePath, installFilePath);
                                }
                            }
                            else
                            {
                                Utilities.InstallFile(UsersConsoleIp, modFilePath, installFilePath.Replace("/{REGION}/", $"/{SelectedGameRegion}/"));
                            }
                        }
                    }
                }

                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {GameTitle} - Successfully installed ({totalFileNo} files)");
            }
            catch (Exception ex)
            {
                SetStatus($"Mods Archive : Unable to install files '{SelectedModItem.Name} ({SelectedModItem.Id}) for {SelectedGame.Title} - {ex.Message}", ex);
                DarkMessageBox.Show(this, "There was an issue installing the mods for some reason. I encourage you to submit your log.txt file contents to our GitHub issue tracker so this can be resolved. You can find us at 'ohhsoash/ModioX' on GitHub repos.", "Error");
            }
        }

        private void ToolStripDownloadArchive_Click(object sender, EventArgs e)
        {
            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Preparing to download mods archive...");

            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        Utilities.DownloadToLocation(SelectedModItem, folderBrowser.SelectedPath);
                        SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Successfully downloaded mods archive to '{folderBrowser.SelectedPath}'");
                    }
                    else
                    {
                        SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Canceled request to download archive.");
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Mods Archive : Unable to download mods archive '{SelectedModItem.Name} ({SelectedModItem.Id}) for {SelectedGame.Title}  (Access may be denied to the specified path, try a different one) - {ex.Message}", ex);
            }
        }

        private void ToolStripFavorite_Click(object sender, EventArgs e)
        {
            if (ToolStripFavorite.Text == "Favorite")
            {
                ToolStripFavorite.Text = "Unfavorite";
                Settings.Default.FavoriteIds.Add(SelectedModItem.Id.ToString());
            }
            else
            {
                ToolStripFavorite.Text = "Favorite";
                Settings.Default.FavoriteIds.Remove(SelectedModItem.Id.ToString());

                if (SelectedGame.Id == "fvrt")
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }
            }

            ToolStripFavorite.AutoSize = false;
            ToolStripFavorite.AutoSize = true;
        }

        private void ButtonUninstallFiles_Click(object sender, EventArgs e)
        {
            SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Preparing to uninstall files...");

            try
            {
                string GameTitle;

                if (Utilities.InstallNeedsRegion(SelectedGame))
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - Retrieving game region...");
                    SelectedGameRegion = Utilities.GetUsersGameRegion(FtpConnection, SelectedGame, Settings.Default.AutoGameRegion);
                    GameTitle = $"{SelectedGame.Title} ({SelectedGameRegion})";
                }
                else
                {
                    GameTitle = $"{SelectedGame.Title}";
                }

                if (SelectedGameRegion == null)
                {
                    SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {SelectedGame.Title} - No region chosen for game.");
                    DarkMessageBox.Show(this, "You didn't select your game region when prompted. Try to do this again.", "No Region");
                    return;
                }

                int currentFileNo = 0;
                int totalFileNo = SelectedModItem.InstallPaths.Length;

                foreach (string installFilePath in SelectedModItem.InstallPaths)
                {
                    currentFileNo++;

                    if (!installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                    {
                        SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {GameTitle} - Uninstalling {Path.GetFileName(installFilePath)} ({currentFileNo}/{totalFileNo}) from {Path.GetDirectoryName(installFilePath)}");
                        Utilities.DeleteConsoleFile(UsersConsoleIp, "/" + installFilePath.Replace("/{REGION}/", $"/{SelectedGameRegion}/"));
                    }
                }           

                SetStatus($"Mods Archive : {SelectedModItem.Name} ({SelectedModItem.Type}) for {GameTitle} - Successfully uninstalled files ({currentFileNo} files)");
            }
            catch (Exception ex)
            {
                SetStatus($"Mods Archive : Unable to uninstall files '{SelectedModItem.Name} ({SelectedModItem.Type}) ({SelectedModItem.Id}) for {SelectedGame.Title} - {ex.Message}", ex);
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

                ToolStripLocalUploadFile.Enabled = type == "file";
                ToolStripLocalDeleteFile.Enabled = type == "file";
                ContextMenuStripLocalUploadFile.Enabled = type == "file";
                ContextMenuStripLocalDeleteFile.Enabled = type == "file";

                ToolStripLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalDirectory.Text);
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

                ToolStripConsoleDownloadFile.Enabled = type == "file";
                ToolStripConsoleDeleteFile.Enabled = type == "file";
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
                    FtpConnection = new FtpConnection(UsersConsoleIp);
                }

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
                LoadConsoleDirectory(Path.GetDirectoryName(new FtpDirectoryInfo(FtpConnection, FtpDirectoryPath).FullName).Replace(@"\", "/"));

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
                    Utilities.InstallFile(UsersConsoleIp, localFile, installFile);
                    SetStatus(string.Format("File Explorer : Successfully uploaded file {0} to console path {1}", Path.GetFileName(localFile), Path.GetDirectoryName(installFile)));
                    DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(installFile), File.GetLastWriteTime(installFile));
                }
                else
                {
                    SetStatus($"File Explorer : Unable to install local file as it doesn't exist on the system.");
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
                Utilities.DownloadConsoleFile(UsersConsoleIp, localFile, consoleFile);
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
                Utilities.DeleteConsoleFile(UsersConsoleIp, consoleFile);
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
            ModsData.ModItem modItem = Utilities.GetModById(ModsData, modId);

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = string.Format("{0} (#{1})", modItem.Name, modItem.Id.ToString());
            LabelCategory.Text = Utilities.GetGameById(GamesData, Utilities.GetModById(ModsData, modId).GameId).Title;
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

            ToolStripFavorite.Text = Settings.Default.FavoriteIds.Contains(modItem.Id.ToString()) ? "Unfavorite" : "Favorite";
            ToolStripFavorite.AutoSize = false;
            ToolStripFavorite.AutoSize = true;

            UpdateScrollBarDetails();
            UpdateScrollBarInstallPaths();
        }

        /// <summary>
        ///     Loops and adds either entire or users favourites mods from the database for the given game and filter into the gridview
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        private void LoadMods(string gameId, string firmware, string type)
        {
            DgvMods.Rows.Clear();

            ComboBoxType.Items.Clear();
            ComboBoxType.Items.Add("ANY");

            // Load favorite mods, otherwise all mods
            if (gameId.Equals("fvrt"))
            {
                foreach (ModsData.ModItem modItem in ModsData.Mods)
                {
                    if (Settings.Default.FavoriteIds.Contains(modItem.Id.ToString()) && modItem.Firmware.Contains(firmware) && modItem.Type.Contains(type))
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
                foreach (ModsData.ModItem modItem in ModsData.Mods)
                {
                    if (string.Equals(modItem.GameId, gameId) && modItem.Firmware.Contains(firmware) && modItem.Type.Contains(type))
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
            //ScrollBarDetails.Visible = FlowPanelDetails.VerticalScroll.Visible
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        public void UpdateScrollBarInstallPaths()
        {
            DgvInstallPaths.ScrollBars = ScrollBars.None;
            ScrollBarInstallPaths.Maximum = DgvInstallPaths.RowCount;
            ScrollBarInstallPaths.ViewSize = DgvInstallPaths.DisplayedRowCount(true);
            ScrollBarInstallPaths.Value = 0;
            ScrollBarInstallPaths.UpdateScrollBar();
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

        private void DgvInstallPaths_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarInstallPaths.Value = e.NewValue;
        }

        private void ScrollBarInstallPaths_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            try { DgvInstallPaths.FirstDisplayedScrollingRowIndex = ScrollBarInstallPaths.Value; } catch { }
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

            foreach (ModsData.ModItem modItem in ModsData.Mods)
            {
                if (!ComboBoxFirmware.Items.Contains(modItem.Firmware))
                {
                    ComboBoxFirmware.Items.Add(modItem.Firmware);
                }
            }
        }

        private void EnableConsoleActions(bool enable)
        {
            ToolStripInstallFiles.Enabled = enable;
            ToolStripDownloadArchive.Enabled = enable;
        }

        // Remove dotted borders from the cells upon focus
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
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
    }
}