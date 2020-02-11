using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms.Connection;
using ModioX.Forms.Console_Profiles;
using ModioX.Forms.Custom_Mods;
using ModioX.Forms.File_Explorer;
using ModioX.Forms.Game_File_Backups;
using ModioX.Models.Database;
using ModioX.Models.Resources;
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

namespace ModioX.Forms
{
    public partial class MainForm : DarkForm
    {
        /// <summary>
        ///     Initialize application form
        /// </summary>
        public MainForm()
        {
            mainForm = this;
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public static MainForm mainForm;

        /// <summary>
        ///     Contains the users settings data
        /// </summary>
        public static SettingsData SettingsData { get; set; } = new SettingsData();

        /// <summary>
        ///     Form loading event
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = string.Format("ModioX - Beta {0}", Updater.Updater.CurrentVersion.ToString().Remove(0, 2));

            SetStatus($"Initializing application data...");

            Updater.Updater.CheckApplicationVersion();
            LoadSettingsData();
            Worker.RunWorkAsync(LoadData, InitializeFinished);

            EnableConsoleActions();
        }

        /// <summary>
        ///     Form closing event
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsData();
        }

        /// <summary>
        /// 
        /// </summary>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            UpdateScrollBarCategories();
            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     Contains the latest games data retrieved from the database
        /// </summary>
        public static CategoriesData Categories;

        /// <summary>
        ///     Contains the latest mods data retrieved from the database
        /// </summary>
        public static ModsData Mods;

        /// <summary>
        ///     Retrieves the games and mods data into the application
        /// </summary>
        private static void LoadData()
        {
            Categories = Utilities.GetCategoriesData();
            Mods = Utilities.GetModsData();
        }

        /// <summary>
        ///     Finalize application data after being initialized
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded the database - Finalizing data...");

            Categories.Categories = Categories.Categories.OrderBy(o => o.Title).ToList();

            LoadModsCategories();

            ComboBoxFirmware.Items.Clear(); _ = ComboBoxFirmware.Items.Add("ANY");

            foreach (ModsData.ModItem modItem in Mods.Mods)
            {
                if (!ComboBoxFirmware.Items.Contains(modItem.Firmware))
                {
                    ComboBoxFirmware.Items.Add(modItem.Firmware);
                }
            }

            SelectedCategory = Categories.Categories.First(x => x.GetCategoryType() == CategoryType.Game);

            LoadModsByCategoryId(
                SelectedCategory.Id,
                "",
                "",
                "");

            ComboBoxFirmware.SelectedIndex = 0;

            ToolStripLabelStats.Text = string.Format("{0} Mods for {1} Games, {2} Game Updates, {3} Homebrew, {4} Resources && {5} Themes", Mods.TotalGameMods, Categories.TotalGames, Mods.TotalGameUpdates, Mods.TotalHomebrew, Mods.TotalResources, Mods.TotalThemes);

            SetStatus($"Initialized ModioX (Version Beta {Utilities.GetCurrentVersion().Remove(0, 2)}) - Ready to connect to console...");
        }


        /// <summary>
        ///     Contains the selected console profile name
        /// </summary>
        public static ConsoleProfile ConsoleProfile { get; set; }

        /// <summary>
        ///    Determines the connection status for the console
        /// </summary>
        public static bool IsConsoleConnected { get; set; }

        /// <summary>
        ///     Test and verify the connection to the console address
        /// </summary>
        public void ConnectConsole()
        {
            try
            {
                SetStatus($"{ConsoleProfile.Name} ({ConsoleProfile.Address}) - Connecting...");

                using (FtpConnection ftpConnection = new FtpConnection(ConsoleProfile.Address))
                {
                    ;
                }

                IsConsoleConnected = true;
                SetStatusConsole(ConsoleProfile);
                EnableConsoleActions();

                MenuStripConnectPS3Console.Text = "Disconnect Console...";

                SetStatus($"Successfully connected to console");
            }
            catch (Exception ex)
            {
                DarkMessageBox.Show(this, string.Format("An error occurred connecting to this console. Make sure the address is correct, console is powered on and connected to the same network as this computer. \n\nError:\n" + ex.Message), "Connection Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus($"{ConsoleProfile.Name} ({ConsoleProfile.Address}) - Disconnecting...");

            IsConsoleConnected = false;
            SetStatusConsole(null);
            EnableConsoleActions();

            MenuStripConnectPS3Console.Text = "Connect Console...";

            SetStatus("Successfully disconnected from console");
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

        private void MenuItemToolsFileExplorer_Click(object sender, EventArgs e)
        {
            using (FileExplorer fileExplorer = new FileExplorer())
            {
                fileExplorer.ShowDialog(this);
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

        private void MenuItemSettingsEditConsoleProfiles_Click(object sender, EventArgs e)
        {
            using (EditProfiles consolesWindow = new EditProfiles())
            {
                consolesWindow.ShowDialog(this);
            }
        }

        private void MenuItemSettingsShowModID_Click(object sender, EventArgs e)
        {
            SettingsData.ShowModIds = MenuItemSettingsShowModID.Checked;
        }

        private void MenuItemSettingsAutoDetectGameRegion_Click(object sender, EventArgs e)
        {
            SettingsData.AutoDetectGameRegion = MenuItemSettingsAutoDetectGameRegion.Checked;
        }

        private void MenuItemSettingsAlwaysDownloadInstallFiles_Click(object sender, EventArgs e)
        {
            SettingsData.AlwaysDownloadInstallFiles = MenuItemSettingsAlwaysDownloadInstallFiles.Checked;
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
            DarkMessageBox.Show(this, "ModioX was developed by @ohhsodead and few friends, with the only intention of providing an efficient tool for browsing, downloading and installing game and console mods directly. All credits are given to those appropriate creators/authors of the mods used in this application. If you have any questions please send a message at my Discord: wh1ter0se#7480 with your much welcomed comments, suggestions and feedback to help support this project.", "Information", MessageBoxIcon.Information);
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
        }

        private void MenuStripRequestMod_Click(object sender, EventArgs e)
        {
            Utilities.OpenRequestTemplate();
        }


        /*************************************** MODS LIBRARY ***************************************/


        /// <summary>
        ///     Contains the selected game data selected by the user
        /// </summary>
        public static CategoriesData.Category SelectedCategory { get; set; }

        /// <summary>
        ///     Contains the selected mods info selected by the user
        /// </summary>
        public static ModsData.ModItem SelectedModItem { get; set; }

        private void CategoryTitle_Click(object sender, EventArgs e)
        {
            SelectedCategory = Categories.GetCategoryById(((Label)sender).Name);

            LoadModsByCategoryId(
                SelectedCategory.Id,
                FilterModsName,
                FilterModsFW,
                FilterModsType);

            ComboBoxType.SelectedIndex = string.IsNullOrEmpty(FilterModsType) ? 0 : ComboBoxType.FindStringExact(FilterModsType);
        }

        private void CategoryTitle_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(75, 110, 175);
        }

        private void CategoryTitle_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SelectedCategory.Id.Equals(((Label)sender).Name) ? Color.FromArgb(75, 110, 175) : Color.FromArgb(60, 63, 65);
        }

        string FilterModsName { get; set; } = "";

        string FilterModsFW { get; set; } = "";

        string FilterModsType { get; set; } = "";

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterModsName = TextBoxSearch.Text;

            LoadModsByCategoryId(
                    SelectedCategory.Id,
                    FilterModsName,
                    FilterModsFW,
                    FilterModsType);
        }

        private void ComboBoxFirmware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFirmware.SelectedIndex == 0)
            {
                FilterModsFW = "";
            }
            else
            {
                FilterModsFW = ComboBoxFirmware.GetItemText(ComboBoxFirmware.SelectedItem);
            }

            LoadModsByCategoryId(
                    SelectedCategory.Id,
                    FilterModsName,
                    FilterModsFW,
                    FilterModsType);
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex == 0)
            {
                FilterModsType = "";
            }
            else
            {
                FilterModsType = ComboBoxType.GetItemText(ComboBoxType.SelectedItem);
            }

            LoadModsByCategoryId(
                SelectedCategory.Id,
                FilterModsName,
                FilterModsFW,
                FilterModsType);
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
            }

            ToolItemInstallMod.Enabled = DgvMods.SelectedRows.Count != 0 && IsConsoleConnected;
            ToolItemDownloadMod.Enabled = DgvMods.SelectedRows.Count != 0;
            ToolItemFavoriteMod.Enabled = DgvMods.SelectedRows.Count != 0;
        }

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ToolItemInstallMod.Enabled = e.RowIndex != -1 && IsConsoleConnected;
                ToolItemDownloadMod.Enabled = e.RowIndex != -1;
                ToolItemFavoriteMod.Enabled = e.RowIndex != -1;

                ModsData.ModItem modItem = Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                //ShowModDetails(modItem.Id);

                if (DgvMods.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
                {
                    if (IsConsoleConnected)
                    {
                        InstallModFiles(modItem);
                    }
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
                {
                    DownloadModArchive(modItem);
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
                {
                    AddModToFavorites(modItem);
                }
            }
        }

        private void ContextMenuModsInstallToConsole_Click(object sender, EventArgs e)
        {
            ToolItemInstallMod.PerformClick();
        }

        private void ContextMenuModsUninstallFromConsole_Click(object sender, EventArgs e)
        {
            ToolItemUninstallMod.PerformClick();
        }

        private void ContextMenuModsDownloadArchive_Click(object sender, EventArgs e)
        {
            ToolItemDownloadMod.PerformClick();
        }

        private void ContextMenuModsExtractInformation_Click(object sender, EventArgs e)
        {
            CategoriesData.Category category = Categories.GetCategoryById(SelectedModItem.GameId);

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    SelectedModItem.GenerateReadMeAtPath(folderBrowser.SelectedPath);
                    SetStatus($"{SelectedModItem.Name} ({SelectedModItem.Type}) for {category.Title} - Successfully written readme text file to '{folderBrowser.SelectedPath}'");
                }
            }
        }

        private void ContextMenuModsReportOnGitHub_Click(object sender, EventArgs e)
        {
            Utilities.OpenReportTemplate(SelectedModItem);
        }

        private void DgvModsInstalled_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvModsInstalled.CurrentRow != null)
            {
                ModsData.ModItem modItem = Mods.GetModById(int.Parse(DgvModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                ShowModDetails(modItem.Id);
            }
        }

        private void DgvModsInstalled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModsData.ModItem modItem = Mods.GetModById(int.Parse(DgvModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                ShowModDetails(modItem.Id);

                if (DgvModsInstalled.CurrentCell.ColumnIndex.Equals(8))
                {
                    if (IsConsoleConnected)
                    {
                        UninstallModFiles(modItem);
                    }
                }
            }
        }

        private void ToolItemUninstallAllGameMods_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                foreach (InstalledGameMod installedMod in SettingsData.InstalledGameMods)
                {
                    ModsData.ModItem modItem = Mods.GetModById(installedMod.ModId);

                    UninstallModFiles(modItem);
                }
            }
        }

        private void ToolStripInstallFiles_Click(object sender, EventArgs e)
        {
            InstallModFiles(SelectedModItem);
        }

        private void ToolStripUninstallFiles_Click(object sender, EventArgs e)
        {
            UninstallModFiles(SelectedModItem);
        }

        private void ToolStripDownloadArchive_Click(object sender, EventArgs e)
        {
            DownloadModArchive(SelectedModItem);
        }

        private void ToolStripFavorite_Click(object sender, EventArgs e)
        {
            AddModToFavorites(SelectedModItem);
        }

        private void LoadModsCategories()
        {
            PanelGames.Controls.Clear();
            PanelResources.Controls.Clear();
            PanelLists.Controls.Clear();

            foreach (CategoriesData.Category category in Categories.Categories)
            {
                if (Mods.GetModsByCategoryId(category.Id).Length > 0 || category.Id.Equals("fvrt"))
                {
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
                        //Dock = DockStyle.Left,
                        Text = category.Id.Equals("fvrt") ? string.Format("{0} ({1})", category.Title.Replace("&", "&&"), SettingsData.FavoritedIds.Count) : string.Format("{0} ({1})", category.Title.Replace("&", "&&"), Mods.GetModsByCategoryId(category.Id).Length)
                    };

                    categoryTitle.Click += new EventHandler(CategoryTitle_Click);
                    categoryTitle.MouseEnter += new EventHandler(CategoryTitle_MouseEnter);
                    categoryTitle.MouseLeave += new EventHandler(CategoryTitle_MouseLeave);

                    if (category.GetCategoryType() == CategoryType.Game)
                    {
                        PanelGames.Controls.Add(categoryTitle);
                    }
                    else if (category.GetCategoryType() == CategoryType.Resource)
                    {
                        PanelResources.Controls.Add(categoryTitle);
                    }
                    else if (category.GetCategoryType() == CategoryType.Favorite)
                    {
                        PanelLists.Controls.Add(categoryTitle);
                    }
                }
            }

            UpdateScrollBarCategories();
        }

        /// <summary>
        ///     Loops and adds either entire or users favourites mods from the database for the given game and filter into the gridview
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        private void LoadModsByCategoryId(string gameId, string name, string firmware, string type)
        {
            UpdateCategoryTitles();
            LoadInstalledMods();

            DgvMods.Rows.Clear();

            ComboBoxType.Items.Clear();
            ComboBoxType.Items.Add("ANY");

            foreach (ModsData.ModItem modItem in Mods.GetModItems(gameId, name, firmware, type))
            {
                _ = DgvMods.Rows.Add(
                    modItem.Id,
                    modItem.Name,
                    modItem.Configuration,
                    modItem.Firmware,
                    modItem.Type,
                    modItem.Version,
                    modItem.Author,
                    modItem.InstallPaths.Length + (modItem.InstallPaths.Length > 1 ? " Files" : " File"),
                    ImageExtensions.ResizeBitmap(Resources.icons8_software_installer_22, 19, 19),
                    ImageExtensions.ResizeBitmap(Resources.icons8_download_from_the_cloud_22, 19, 19),
                    ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 19, 19));

                if (!ComboBoxType.Items.Contains(modItem.Type))
                {
                    ComboBoxType.Items.Add(modItem.Type);
                }
            }

            DgvMods.Sort(DgvMods.Columns[1], ListSortDirection.Ascending);

            if (DgvMods.Rows.Count > 0)
            {
                DgvMods.CurrentCell = DgvMods[1, 0];
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
                DgvMods.Enabled = true;
            }
            else
            {
                DgvMods.Enabled = false;
            }

            ComboBoxType.SelectedIndexChanged -= ComboBoxType_SelectedIndexChanged;

            ComboBoxType.SelectedIndex = string.IsNullOrEmpty(type) ? 0 : ComboBoxType.Items.IndexOf(type);

            ComboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
        }

        private void LoadInstalledMods()
        {
            DgvModsInstalled.Rows.Clear();

            int totalFiles = 0;

            foreach (InstalledGameMod installedMod in SettingsData.InstalledGameMods)
            {
                CategoriesData.Category modCategory = Categories.GetCategoryById(installedMod.GameId);

                ModsData.ModItem modInstalled = Mods.GetModById(installedMod.ModId);

                _ = DgvModsInstalled.Rows.Add(modInstalled.Id.ToString(),
                                              modCategory.Title,
                                              installedMod.GameRegion,
                                              modInstalled.Name,
                                              modInstalled.Firmware,
                                              modInstalled.Type,
                                              modInstalled.Version,
                                              modInstalled.InstallPaths.Length + (modInstalled.InstallPaths.Length > 1 ? " Files" : " File"),
                                              ImageExtensions.ResizeBitmap(Resources.icons8_uninstall_programs_22, 19, 19));

                totalFiles += modInstalled.InstallPaths.Length;
            }

            LabelInstalledGameModsStatus.Text = string.Format("{0} Game Mods Installed ({1} Files Total)", SettingsData.InstalledGameMods.Count, totalFiles);
            ToolItemUninstallAllGameMods.Enabled = IsConsoleConnected;
        }

        /// <summary>
        ///     Sets the UI to display the selected mod's details
        /// </summary>
        /// <param name="modId">Mod Id to display information</param>
        private void ShowModDetails(long modId)
        {
            if (Mods.GetModById(modId) == null)
            {
                return;
            }

            ModsData.ModItem modItem = Mods.GetModById(modId);

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = string.Format("{0} {1}", modItem.Name.Replace("&", "&&"), SettingsData.ShowModIds ? "(ID # " + modItem.Id.ToString() + ")" : "");
            LabelCategory.Text = Categories.GetCategoryById(Mods.GetModById(modId).GameId).Title;
            LabelFirmware.Text = modItem.Firmware + " Systems";
            LabelType.Text = modItem.Type;
            LabelAuthor.Text = modItem.Author.Replace("&", "&&");
            LabelSubmittedBy.Text = modItem.SubmittedBy.Replace("&", "&&");
            LabelVersion.Text = modItem.Version;
            LabelConfig.Text = modItem.Equals("-") ? "-" : string.Join(", ", modItem.GetGameModes());
            LabelDescription.Text = modItem.Description.Replace("&", "&&");

            DgvInstallPaths.Rows.Clear();

            foreach (string filePath in modItem.InstallPaths)
            {
                DgvInstallPaths.Rows.Add(filePath);
            }

            ToolItemInstallMod.Enabled = IsConsoleConnected;

            if (modItem.GetCategoryType(Categories) == CategoryType.Game)
            {
                ToolItemUninstallMod.Enabled = SettingsData.GetInstalledGameMod(modItem.GameId) != null
                    ? IsConsoleConnected && SettingsData.GetInstalledGameMod(modItem.GameId).ModId.Equals(modItem.Id)
                    : false;
            }
            else if (modItem.GetCategoryType(Categories) == CategoryType.Resource)
            {
                ToolItemUninstallMod.Enabled = modItem.IsInstallToRebugFolder() ? false : IsConsoleConnected;
            }

            ToolItemFavoriteMod.Text = SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) ? "Unfavorite" : "Favorite";
            ToolItemFavoriteMod.AutoSize = false;
            ToolItemFavoriteMod.AutoSize = true;

            UpdateScrollBarDetails();
        }

        public void UpdateCategoryTitles()
        {
            foreach (object ctrl in PanelGames.Controls)
            {
                if (SelectedCategory.Id.Equals(((Label)ctrl).Name))
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(75, 110, 175);
                }
                else
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(60, 63, 65);
                }
            }

            foreach (object ctrl in PanelResources.Controls)
            {
                if (SelectedCategory.Id.Equals(((Label)ctrl).Name))
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(75, 110, 175);
                }
                else
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(60, 63, 65);
                }
            }

            foreach (object ctrl in PanelLists.Controls)
            {
                if (SelectedCategory.Id.Equals(((Label)ctrl).Name))
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(75, 110, 175);
                }
                else
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(60, 63, 65);
                }
            }
        }

        public void UpdateScrollBarCategories()
        {
            ScrollBarCategories.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            ScrollBarCategories.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
            ScrollBarCategories.ViewSize = flowLayoutPanel1.VerticalScroll.LargeChange - 30;
            ScrollBarCategories.Value = 0;
            ScrollBarCategories.UpdateScrollBar();
        }

        public void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        private void ScrollBarCategories_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = ScrollBarCategories.Value;
            flowLayoutPanel1.Update();
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
        ///     Installs the specified modded files to the users console
        /// </summary>
        /// <param name="modItem"></param>
        public void InstallModFiles(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(SelectedModItem.GameId);

            SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Preparing to install files...");

            // Asks the user if they want to cancel install to developer folder if there are any warnings for this mod
            if (modItem.IsInstallToRebugFolder())
            {
                if (DarkMessageBox.Show(this, "This mod is being installed to 'dev_rebug', which is a developer/update/cfw folder for the REBUG Custom Firmware only. You should create a backup of this folder before installing any mods here. Make sure that you are running REBUG Firmware on your console and you have the REBUG TOOLBOX application open. Missing or incorrect files in this folder can impact your console performance.\n\nProceed at your own risk if you know what you're doing.\n\nWould you like to cancel this install?", "Developer Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Cancelled installation.");
                    return;
                }
            }

            // Checks whether is the a game mod, and if a mod has been installed to this game already, allowing the user to uninstall the mod before installing this new one
            if (category.GetCategoryType() == CategoryType.Game)
            {
                InstalledGameMod installedGameMod = SettingsData.GetInstalledGameMod(category.Id);

                if (installedGameMod != null)
                {
                    if (DarkMessageBox.Show(this, string.Format("This mod '{0}' is currently installed to game: {1}. Would you like to uninstall this mod before installing?\n\nThis is recommended before installing any mods. Otherwise 'No' to ignore and install the mod anyway.", Mods.GetModById(installedGameMod.ModId).Name, category.Title), "Uninstall Mod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UninstallModFiles(Mods.GetModById(installedGameMod.ModId));
                    }
                }
            }

            try
            {
                string gameRegion;
                string gameTitle;

                string userId;

                if (modItem.RequiresRegion())
                {
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Retrieving region...");

                    gameRegion = category.GetGameRegion(ConsoleProfile.Address);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    userId = null;

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - No region selected. Cancelled installation.");
                        return;
                    }
                }
                else if (modItem.RequiresUserId())
                {
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Retrieving user id...");

                    userId = category.GetUserId(ConsoleProfile.Address);

                    gameTitle = $"{category.Title} ({userId})";
                    gameRegion = null;

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - No userId selected. Cancelled installation.");
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = category.Title;

                    userId = null;
                }

                SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Downloading install files...");
                modItem.DownloadInstallFiles();

                int indexOfFiles = 1;
                int totalLengthFiles = modItem.InstallPaths.Length;

                SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing files...");

                foreach (string installFilePath in modItem.InstallPaths)
                {
                    foreach (string localFilePath in Directory.GetFiles(modItem.GetDirectoryDownloadData(), "*.*", SearchOption.AllDirectories))
                    {
                        string installFileName = Path.GetFileName(installFilePath);

                        string installPath = installFilePath
                            .Replace("/{REGION}/", $"/{gameRegion}/")
                            .Replace("/{USERID}/", $"/{userId}/");

                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (installPath.Contains("dev_hdd0/game/"))
                            {
                                BackupFile backupFile = SettingsData.GetGameFileBackup(modItem.GameId, installFileName, installPath);

                                if (backupFile == null)
                                {
                                    if (DarkMessageBox.Show(this, "Would you like to backup the current game file before installing? You can then revert the mods at anytime using either the Uninstall option, or the Tools > Backup File Manager window to restore the game file its original state.\n\nFile being replaced: " + Path.GetFileName(installFilePath), "Backup Game File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Creating backup file for {installFileName} ({indexOfFiles}/{totalLengthFiles})...");

                                        CreateBackupFile(modItem, installFileName, installPath);

                                        SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing file {installFileName} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                        FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                        indexOfFiles++;
                                    }
                                    else
                                    {
                                        SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing file {installFileName} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                        FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                        indexOfFiles++;
                                    }
                                }
                                else
                                {
                                    SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing file {installFileName} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                            }
                            else if (installFilePath.Contains("dev_usb000/"))
                            {
                                if (DarkMessageBox.Show(this, "A file would like to install to a usb device that is connected to your console - it maybe required for the mods to function, like configuration or settings. I suggest you read the complete description to see if anything is mentioned there, such as for configuration or settings purposes." +
                                    "\n\nIf you want to continue, then insert your usb into the right-most slot of the console ports at the front. Only click 'YES' if you've connected the usb device. Otherwise click 'NO' and this file will be ignored.", "Install USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing file {installFileName} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                    FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                    indexOfFiles++;
                                }
                            }
                            else
                            {
                                SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing file {installFileName} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath)}");

                                FtpExtensions.UploadFile(ConsoleProfile.Address, localFilePath, installPath);
                                indexOfFiles++;
                            }
                        }
                    }
                }

                if (category.GetCategoryType() == CategoryType.Game)
                {
                    SettingsData.UpdateInstalledGameMod(category.Id, gameRegion, modItem.Id, indexOfFiles - 1);
                    SaveSettingsData();
                    LoadInstalledMods();
                }

                SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Successfully installed {indexOfFiles - 1} files");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to install files '{modItem.Name} (#{modItem.Id}) for {category.Title} - {ex.Message}", ex);
                DarkMessageBox.Show(this, "An error occurred installing the files for this mod. See menu HELP > Report Bug to open an issue about this, you can also attach your log.txt file contents so it can be investigated and fixed in detail." +
                    "\n\nError Message:\n" + ex.Message, "Install Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Uninstall all of the files for the modItem
        /// </summary>
        /// <param name="modItem"></param>
        public void UninstallModFiles(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(modItem.GameId);

            SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Preparing to uninstall files...");

            // Asks the user if they want to cancel install to developer folder if there are any warnings for this mod
            if (modItem.IsInstallToRebugFolder())
            {
                DarkMessageBox.Show(this, "This mod was installed to 'dev_rebug' folder, which is a developer/update/cfw folder for the REBUG Custom Firmware only. You cannot uninstall files from this folder as any missing files can impact your console performance.", "Developer Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Cancelled installation.");
                return;
            }

            try
            {
                string gameRegion;
                string gameTitle;

                string userId;

                if (modItem.RequiresRegion())
                {
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Retrieving region...");

                    gameRegion = category.GetGameRegion(ConsoleProfile.Address);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    userId = null;

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - No region selected. Cancelled installation.");
                        return;
                    }
                }
                else if (modItem.RequiresUserId())
                {
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Retrieving user id...");

                    userId = category.GetUserId(ConsoleProfile.Address);

                    gameTitle = $"{category.Title} ({userId})";
                    gameRegion = null;

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - No userId selected. Cancelled installation.");
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = category.Title;

                    userId = null;
                }

                SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Uninstalling files...");

                int indexOfFiles = 1;
                int totalLengthFiles = modItem.InstallPaths.Length;

                foreach (string installFilePath in modItem.InstallPaths)
                {
                    if (installFilePath.Contains("dev_hdd0/game/"))
                    {
                        string installPath = installFilePath.Replace("/{REGION}/", $"/{gameRegion}/");

                        BackupFile backupFile = SettingsData.GetGameFileBackup(modItem.GameId, Path.GetFileName(installFilePath), installPath);

                        if (backupFile != null)
                        {
                            if (File.Exists(backupFile.LocalPath))
                            {
                                SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Installing backup file {Path.GetFileName(installPath)} ({indexOfFiles}/{totalLengthFiles}) to {Path.GetDirectoryName(installPath).Replace(@"\", @"/")})");

                                FtpExtensions.UploadFile(ConsoleProfile.Address, backupFile.LocalPath, installPath);
                                indexOfFiles++;
                            }
                            else
                            {
                                DarkMessageBox.Show(this, "You have created a backup for this game file, but the file doesn't exist on your computer anymore. Open the Tools > Game File Backup Manager to edit your backup and set the local file again. This game file will be ignored for now.", "No Backup File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DarkMessageBox.Show(this, "You haven't created a backup for this game file. This game file will be ignored otherwise the game will have issues with missing files.", "No Backup File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (installFilePath.Contains("dev_usb000/"))
                    {
                        if (DarkMessageBox.Show(this, "A file wants to be uninstalled from your USB drive. If you installed any files here then insert your USB drive to the right slot of your console and click 'YES'. Otherwise click 'NO' and this file will be ignored." +
                            "\n\nIf you want to continue, then insert your USB drive into the right-most slot at the front of the console. Would you like to uninstall this file? Only click 'YES' if you've connected the USB device. Otherwise this file will be ignored." +
                            $"\n\nFile Details:\nFile Path: {installFilePath}\nFile Name: {Path.GetFileName(installFilePath)}", "Uninstall File from USB", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Uninstalling file {Path.GetFileName(installFilePath)} ({indexOfFiles}/{totalLengthFiles}) from {Path.GetDirectoryName(installFilePath).Replace(@"\", @"/")})");

                            FtpExtensions.DeleteFile(ConsoleProfile.Address, installFilePath);
                            indexOfFiles++;
                        }
                    }
                    else
                    {
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {gameTitle} - Uninstalling file {Path.GetFileName(installFilePath)} ({indexOfFiles}/{totalLengthFiles}) from {Path.GetDirectoryName(installFilePath).Replace(@"\", @"/")})");

                        FtpExtensions.DeleteFile(ConsoleProfile.Address, installFilePath);
                        indexOfFiles++;
                    }
                }

                if (category.GetCategoryType() == CategoryType.Game)
                {
                    SettingsData.RemoveInstalledGameMod(category.Id, modItem.Id);
                    SaveSettingsData();
                    LoadInstalledMods();
                }

                SetStatus($"Mods  : {modItem.Name} ({modItem.Type}) for {gameTitle} - Successfully uninstalled {indexOfFiles - 1} files");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to uninstall files '{modItem.Name} ({modItem.Type}) (#{modItem.Id}) for {category.Title} - {ex.Message}", ex);
                DarkMessageBox.Show(this, "An error occurred uninstalling the files for this mod. See menu HELP > Report Bug/Suggestions to submit an issue, and attach your log.txt file contents so this bug can be investigated and fixed." +
                   "\n\nError Message:\n" + ex.Message, "Uninstall Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modItem"></param>
        public void DownloadModArchive(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(modItem.GameId);

            SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Preparing to download mods archive...");

            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        modItem.DownloadArchiveAtPath(folderBrowser.SelectedPath);
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Successfully downloaded archive to '{folderBrowser.SelectedPath}'");
                    }
                    else
                    {
                        SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Archive download canceled.");
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download archive '{modItem.Name} ({modItem.Id}) for {category.Title} (Access may be denied to the specified path, try a different one) - {ex.Message}", ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modItem"></param>
        private void AddModToFavorites(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(modItem.GameId);

            if (SettingsData.FavoritedIds.Contains(modItem.Id.ToString()))
            {
                SettingsData.FavoritedIds.Remove(modItem.Id.ToString());

                ShowModDetails(SelectedModItem.Id);

                if (SelectedCategory.Id.Equals("fvrt"))
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }

                SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Removed from your favorites list");
            }
            else
            {
                SettingsData.FavoritedIds.Add(modItem.Id.ToString());

                ShowModDetails(SelectedModItem.Id);

                SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Added to your favorites list");
            }

            ToolItemFavoriteMod.AutoSize = false;
            ToolItemFavoriteMod.AutoSize = true;

            ToolStripArchiveInformation.Update();
        }

        /// <summary>
        ///     Create/store a backup of the specified file, and then downloads it locally somewhere
        /// </summary>
        /// <param name="modItem"></param>
        /// <param name="fileName"></param>
        /// <param name="installFilePath"></param>
        public static void CreateBackupFile(ModsData.ModItem modItem, string fileName, string installFilePath)
        {
            Directory.CreateDirectory(SettingsData.CreateBackupFileFolder(modItem));

            BackupFile backupFile = new BackupFile()
            {
                Name = "Original Game File",
                CategoryId = modItem.GameId,
                FileName = fileName,
                LocalPath = SettingsData.CreateBackupFile(modItem, fileName),
                InstallPath = installFilePath
            };

            SettingsData.BackupFiles.Add(backupFile);

            FtpExtensions.DownloadFile(ConsoleProfile.Address, backupFile.LocalPath, backupFile.InstallPath);
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
                ToolStripLabelConsole.Text = consoleProfile.Name;
            }
        }

        /// <summary>
        ///     Set the current process status in the tool strip
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
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

        private void EnableConsoleActions()
        {
            MenuItemToolsFileExplorer.Enabled = IsConsoleConnected;
            ToolItemInstallMod.Enabled = IsConsoleConnected;
            ToolItemUninstallMod.Enabled = IsConsoleConnected;
            ToolItemDownloadMod.Enabled = IsConsoleConnected;
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
        /// Save settings data to json file
        /// </summary>
        public void SaveSettingsData()
        {
            // Save settings to file
            using (StreamWriter streamWriter = new StreamWriter(SettingsData.SettingsDataFile))
            {
                streamWriter.Write(JsonConvert.SerializeObject(SettingsData));
            }
        }

        /// <summary>
        /// Load settings data json file into application
        /// </summary>
        public void LoadSettingsData()
        {
            if (File.Exists(SettingsData.SettingsDataFile))
            {
                using (StreamReader streamReader = new StreamReader(SettingsData.SettingsDataFile))
                {
                    SettingsData = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                }
            }

            if (SettingsData.ConsoleProfiles.Count == 0)
            {
                SettingsData.ConsoleProfiles.Add(new ConsoleProfile() { Name = "Default Console", Address = "192.168.0.42" });
            }

            // Load Settings UI
            MenuItemSettingsShowModID.Checked = SettingsData.ShowModIds;
            MenuItemSettingsAutoDetectGameRegion.Checked = SettingsData.AutoDetectGameRegion;
            MenuItemSettingsAlwaysDownloadInstallFiles.Checked = SettingsData.AlwaysDownloadInstallFiles;
        }
    }
}