using DarkUI.Controls;
using DarkUI.Forms;
using Microsoft.Extensions.Logging.Abstractions;
using ModioX.Extensions;
using ModioX.Forms.Dialogs;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Properties;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class MainWindow : DarkForm
    {
        /// <summary>
        ///     Initialize application form
        /// </summary>
        public MainWindow()
        {
            mainForm = this;
            InitializeComponent();
        }

        /// <summary>
        ///     Get/set the 
        /// </summary>
        public static MainWindow mainForm;

        /// <summary>
        ///     Contains the users settings data.
        /// </summary>
        public static SettingsData SettingsData { get; set; } = new SettingsData();

        /// <summary>
        ///     Form loading event.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = $"ModioX - Beta v{Utilities.GetCurrentVersion().ToString().Remove(0, 2)}";

            SetStatus($"Initializing application data...");

            LoadSettingsData();
            UpdateExtensions.CheckApplicationVersion();

            if (SettingsData.FirstTimeOpenAfterUpdate)
            {
                SettingsData.FirstTimeOpenAfterUpdate = false;
                DialogExtensions.ShowWhatsNewWindow(this, UpdateExtensions.GitHubData);
            }

            if (SettingsData.FirstTimeUse)
            {
                SettingsData.FirstTimeUse = false;
                DarkMessageBox.Show(this, "Before using this tool, it is important to read the information about this tool so you don't have any issues. Go to HELP > More Information.", "First Time Use", MessageBoxIcon.Information);
            }

            Worker.RunWorkAsync(LoadData, InitializeFinished);

            EnableConsoleActions();
        }

        /// <summary>
        ///     Save application settings on form close event.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsData();
        }

        /// <summary>
        ///     Update scrollbar properties when form resized
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
            try
            {
                Categories = Utilities.GetCategoriesData();
                Mods = Utilities.GetModsData();
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        ///     Finalize application data properties after being initialized
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded the database - Finalizing data...");

            Categories.Categories = Categories.Categories.OrderBy(o => o.Title).ToList();

            LoadModsCategories();

            ComboBoxSystemType.Items.Clear(); _ = ComboBoxSystemType.Items.Add("ANY");

            foreach (string firmware in Mods.AllFirmwares)
            {
                if (!ComboBoxSystemType.Items.Contains(firmware))
                {
                    _ = ComboBoxSystemType.Items.Add(firmware);
                }
            }

            SelectedCategory = Categories.Categories.First(x => x.CategoryType == CategoryType.Game);

            LoadModsByCategoryId(SelectedCategory.Id,
                                 "",
                                 "",
                                 "",
                                 "");

            ComboBoxSystemType.SelectedIndex = 0;

            ToolStripLabelStats.Text = $"{Mods.TotalGameMods} Mods for {Categories.TotalGames} Games, {Mods.TotalGameSaves} Game Saves, {Mods.TotalGameUpdates} Game Updates, {Mods.TotalHomebrew} Homebrew, {Mods.TotalResources} Resources && {Mods.TotalThemes} Themes";

            SetStatus($"Initialized ModioX (Beta v{UpdateExtensions.CurrentVersion.ToString().Remove(0, 2)}) - Ready to connect to console...");

            Focus();
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
        ///     
        /// </summary>
        /// <returns></returns>
        public static FtpConnection GetFtpConnection()
        {
            FtpConnection ftpConnection = new FtpConnection(ConsoleProfile.Address, ConsoleProfile.Port);
            NetworkCredential ftpCredentials = ConsoleProfile.UseDefaultCredentials
                    ? new NetworkCredential("anonymous", "anonymous")
                    : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password);
            ftpConnection.Login(ftpCredentials.UserName, ftpCredentials.Password);
            ftpConnection.Open();
            return ftpConnection;            
        }

        /// <summary>
        ///     Test and verify the connection to the console address
        /// </summary>
        public void ConnectConsole()
        {
            try
            {
                SetStatus($"Connecting to {ConsoleProfile.Name} ({ConsoleProfile.Address})...");

                GetFtpConnection();

                SetStatusConsole(ConsoleProfile);
                IsConsoleConnected = true;

                LoadInstalledMods();
                EnableConsoleActions();

                MenuStripConnectPS3Console.Text = "Disconnect from console...";
                SetStatus($"Successfully connected to console.");
            }
            catch (Exception ex)
            {
                SetStatus($"Can't connect to {ConsoleProfile.Name} ({ConsoleProfile.Address}).", ex);
                _ = DarkMessageBox.Show(this, string.Format("Can't connect to {0}. Error: {1}", ConsoleProfile.Name, ex.Message), "Connection Failed", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus($"Disconnecting from {ConsoleProfile.Name} ({ConsoleProfile.Address})...");

            GetFtpConnection().Dispose();
            GetFtpConnection().Close();

            IsConsoleConnected = false;
            SetStatusConsole(null);
            EnableConsoleActions();

            MenuStripConnectPS3Console.Text = "Connect to console...";

            SetStatus("Disconnected from console.");
        }

        private void MenuStripConnectPS3Console_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }
            else
            {
                DialogExtensions.ShowConnectionDialog(this);
            }
        }

        private void MenuItemToolsBackupFileManager_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowBackupFiles(this);
        }

        private void MenuItemToolsFileManager_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
        }

        private void MenuStripResourcesForumsPsxPlacePs3Mods_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.psx-place.com/resources/categories/playstation-3-ps3.3/");
        }

        private void MenuStripResourcesForumsPsxPlaceGameMods_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.psx-place.com/forums/game-mods.91/");
        }

        private void MenuStripResourcesForumsPsxScenePs3Mods_Click(object sender, EventArgs e)
        {
            _ = Process.Start("http://psx-scene.com/forums/ps3-general-discussion/");
        }

        private void MenuStripResourcesForumsPsxSceneGameMods_Click(object sender, EventArgs e)
        {
            _ = Process.Start("http://psx-scene.com/forums/ps3-game-modding/");
        }

        private void MenuStripResourcesForumsNguPs3Mods_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.nextgenupdate.com/forums/ps3-mods-cheats/");
        }

        private void MenuStripResourcesForumsNguGameMods_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.nextgenupdate.com/forums/ps3-mods-cheats/");
        }

        private void MenuStripResourcesCustomFirmwareRebug_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://rebug.me/");
        }

        private void MenuStripResourcesRedditPs3Hacks_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.reddit.com/r/ps3hacks/");
        }

        private void MenuStripResourcesRedditPs3Homebrew_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.reddit.com/r/ps3homebrew/");
        }

        private void PS3ModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.se7ensins.com/forums/forums/playstation-3-modding-tutorials.83/");
        }

        private void GameModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.se7ensins.com/forums/#gaming.275");
        }

        private void PS3ModsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.thetechgame.com/Forums/f=322/prefix=modding&prefix=playstation-3/playstation-forum.html");
        }

        private void GameModsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.thetechgame.com/Forums/f=296/prefix=modding/gaming-discussion.html");
        }

        private void BrewologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://store.brewology.com/homebrew.php?lang=");
        }

        private void MenuStripResourcesGamesPsnDLv3_Click(object sender, EventArgs e)
        {
            _ = Process.Start("http://psndl.net/packages");
        }

        private void MenuStripResourcesGamesNoPsv2_Click(object sender, EventArgs e)
        {
            _ = Process.Start("http://nopaystation.com/");
        }

        private void MenuStripContribute_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Utilities.GitHubRepo);
        }

        private void MenuItemSettingsShowModID_Click(object sender, EventArgs e)
        {
            SettingsData.ShowModIds = MenuItemSettingsShowModID.Checked;
        }

        private void MenuItemSettingsAutoDetectGameRegion_Click(object sender, EventArgs e)
        {
            SettingsData.AutoDetectGameRegion = MenuItemSettingsAutoDetectGameRegion.Checked;
        }

        private void MenuItemSettingsRememberGameRegions_Click(object sender, EventArgs e)
        {
            SettingsData.RememberGameRegions = MenuItemSettingsRememberGameRegions.Checked;
        }

        private void MenuItemSettingsAlwaysDownloadInstallFiles_Click(object sender, EventArgs e)
        {
            SettingsData.AlwaysDownloadInstallFiles = MenuItemSettingsAlwaysDownloadInstallFiles.Checked;
        }

        private void MenuItemSettingsAddNewConsole_Click(object sender, EventArgs e)
        {
            SaveSettingsData();

            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile());

            if (consoleProfile != null)
            {
                SettingsData.ConsoleProfiles.Add(consoleProfile);
            }

            SaveSettingsData();
        }

        private void MenuItemSettingsEditGameRegions_Click(object sender, EventArgs e)
        {
            SaveSettingsData();

            using (EditGameRegions gameRegions = new EditGameRegions())
            {
                _ = gameRegions.ShowDialog(this);
            }
        }

        private void MenuItemSettingsEditExternalApplications_Click(object sender, EventArgs e)
        {
            SaveSettingsData();

            using (EditExternalApplications applications = new EditExternalApplications())
            {
                _ = applications.ShowDialog(this);
                LoadSettingsData();
            }
        }

        private void MenuItemSettingsResetAllOptions_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, "Are you sure that you want to reset all of your settings to default? This cannot be undone.", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SettingsData OldSettingsData = SettingsData; // Current user settings
                SettingsData NewSettingsData = new SettingsData(); // New user settings

                if (IsConsoleConnected)
                {
                    if (SettingsData.InstalledGameMods.Count > 0)
                    {
                        if (DarkMessageBox.Show(this, "You have mods installed to games that won't be remembered after you reset your settings. Would you like to uninstall the mods? (Recommended)", "Game Mods Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {
                                foreach (GameModInstalled modInstalled in SettingsData.InstalledGameMods)
                                {
                                    ModsData.ModItem modItem = Mods.GetModById(modInstalled.ModId);

                                    UninstallMods(modItem, SettingsData.GetInstalledGameModRegion(modItem.GameId));
                                }
                            }
                            catch (Exception ex)
                            {
                                Program.Log.Error(string.Format("Unable to uninstall mods.", ex));
                                _ = DarkMessageBox.Show(this, "Unable to uninstall mods. See log file for more information.", "Error Uninstalling Mods", MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    // If user isn't connected to console then don't remove installed game mods data
                    NewSettingsData.InstalledGameMods = OldSettingsData.InstalledGameMods;
                }

                SettingsData = NewSettingsData;
                _ = DarkMessageBox.Show(this, "Your settings have been reset. ModioX will now restart to apply changes.", "Settings Reset", MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void MenuStripHelpSourceCode_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://github.com/ohhsoash/ModioX");
        }

        private void MenuStripHelpReportBugSuggestions_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://github.com/ohhsoash/ModioX/issues/new");
        }

        private void MenuItemHelpDiscordServer_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://discord.gg/6TBtu8b");
        }

        private void MenuStripHelpCheckForUpdates_Click(object sender, EventArgs e)
        {
            UpdateExtensions.CheckApplicationVersion();
        }

        private void MenuItemInstallUninstallNotes_Click(object sender, EventArgs e)
        {
            _ = DarkMessageBox.Show(this, "Installing/Uninstalling Mods:\n"
                                          + "You must have Multiman or Rebug Toolbox open before installing/uninstalling any files to your PS3. Do NOT install/uninstall files while you're in game. You shouldn't be signed into PSN while connected to this app.\n\n"
                                          + "Installing to USB devices:\n"
                                          + "You must use a USB device that has a minimum capacity of ~3GB. Some files (except for game-saves) are optional. But some mods may not work as they were inteded by the creator if they're not installed to your USB device. Read the full description for mods about USB files.\n\n"
                                          + "Uninstalling Game Saves:\n"
                                          + "For removing installed game saves, you must either delete the game save through the XMB menu or connect the USB device into your computer and delete the save you installed earlier.\n\n"
                                          + "Uninstalling from REBUG folders:\n"
                                          + "It's not recommended to uninstall any files from the firmware folder as this can cause major problems. Before installing mods to the 'dev_rebug' folder, it's recommended to create a backup of this folder so have the original files which you can be restored in the case any files get corrupted.",
                                          "More Information", MessageBoxIcon.Information);
        }

        private void MenuStripHelpAbout_Click(object sender, EventArgs e)
        {
            //_ = DarkMessageBox.Show(this, "ModioX was developed by @ohhsodead and few friends, with the only intention of providing an efficient tool for browsing, downloading and installing mods directly to your console. All credits are given to those appropriate creators/authors of the mods used in this application. If you have any questions please send a message at my Discord: ohhsodead#2519 with your much welcomed comments, suggestions and feedback to help support this project.", "Information", MessageBoxIcon.Information);

            DialogExtensions.ShowAboutWindow(this);
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
            DialogExtensions.ShowRequestModsWindow(this);
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

        /// <summary>
        ///     
        /// </summary>
        private string FilterModsName { get; set; } = "";

        /// <summary>
        ///     
        /// </summary>
        private string FilterModsFirmware { get; set; } = "";

        /// <summary>
        ///     
        /// </summary>
        private string FilterModsType { get; set; } = "";

        /// <summary>
        ///     
        /// </summary>
        private string FilterModsRegion { get; set; } = "";

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
            if (ComboBoxSystemType.SelectedIndex == 0)
            {
                FilterModsFirmware = "";
            }
            else
            {
                FilterModsFirmware = ComboBoxSystemType.GetItemText(ComboBoxSystemType.SelectedItem);
            }

            LoadModsByCategoryId(SelectedCategory.Id,
                                 FilterModsName,
                                 FilterModsFirmware,
                                 FilterModsType,
                                 FilterModsRegion);
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxModType.SelectedIndex == 0)
            {
                FilterModsType = "";
            }
            else
            {
                FilterModsType = ComboBoxModType.GetItemText(ComboBoxModType.SelectedItem);
            }

            LoadModsByCategoryId(SelectedCategory.Id,
                                 FilterModsName,
                                 FilterModsFirmware,
                                 FilterModsType,
                                 FilterModsRegion);
        }

        private void ComboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxRegion.SelectedIndex == 0)
            {
                FilterModsRegion = "";
            }
            else
            {
                FilterModsRegion = ComboBoxRegion.GetItemText(ComboBoxRegion.SelectedItem);
            }

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
                DisplayModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
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

                if (modItem != null) DisplayModDetails(modItem.Id);

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

                    if (SettingsData.FavoritedIds.Contains(modItem.ToString()))
                    {
                        DgvMods.CurrentRow.Cells[10].Value = ImageExtensions.ResizeBitmap(Resources.icons8_heart_fill_22, 19, 19);
                    }
                    else
                    {
                        DgvMods.CurrentRow.Cells[10].Value = ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 19, 19);
                    }
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

            string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want the README to be extracted");

            if (folderPath != null)
            {
                SelectedModItem.GenerateReadMeAtPath(folderPath);
                SetStatus($"{SelectedModItem.Name} ({SelectedModItem.Type}) for {category.Title} - Successfully created readme file at path: '{folderPath}'");
            }
        }

        private void ContextMenuModsReportOnGitHub_Click(object sender, EventArgs e)
        {
            _ = DarkMessageBox.Show(this, "You will be directed to the GitHub Issues tracking page for ModioX. All of the details will be auto-filled for you. Create or login with your GitHub account and click the 'Submit' button to open a new issue for us to investigate this issue.", "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utilities.OpenReportTemplate(SelectedModItem);
        }

        private void DgvModsInstalled_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvModsInstalled.CurrentRow != null)
            {
                ModsData.ModItem modItem = Mods.GetModById(int.Parse(DgvModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                DisplayModDetails(modItem.Id);
            }
        }

        private void DgvModsInstalled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModsData.ModItem modItem = Mods.GetModById(int.Parse(DgvModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                DisplayModDetails(modItem.Id);

                if (DgvModsInstalled.CurrentCell.ColumnIndex.Equals(8))
                {
                    if (IsConsoleConnected)
                    {
                        UninstallMods(modItem, SettingsData.GetInstalledGameModRegion(modItem.GameId));
                    }
                }
            }
        }

        private void ToolItemUninstallAllGameMods_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                foreach (GameModInstalled installedMod in SettingsData.InstalledGameMods)
                {
                    ModsData.ModItem modItem = Mods.GetModById(installedMod.ModId);

                    UninstallMods(modItem, SettingsData.GetInstalledGameModRegion(modItem.GameId));
                }
            }
        }

        private void ToolStripInstallFiles_Click(object sender, EventArgs e)
        {
            InstallMods(SelectedModItem);
        }

        private void ToolStripUninstallFiles_Click(object sender, EventArgs e)
        {
            UninstallMods(SelectedModItem);
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
                    // Mods Category Title
                    Label CategoryTitle = new Label
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
                        Text = category.Id.Equals("fvrt") ? string.Format("{0} ({1})", category.Title.Replace("&", "&&"), SettingsData.FavoritedIds.Count) : string.Format("{0} ({1})", category.Title.Replace("&", "&&"), Mods.GetModsByCategoryId(category.Id).Length)
                    };

                    CategoryTitle.Click += new EventHandler(CategoryTitle_Click);
                    CategoryTitle.MouseEnter += new EventHandler(CategoryTitle_MouseEnter);
                    CategoryTitle.MouseLeave += new EventHandler(CategoryTitle_MouseLeave);

                    if (category.CategoryType == CategoryType.Game)
                    {
                        PanelGames.Controls.Add(CategoryTitle);
                    }
                    else if (category.CategoryType == CategoryType.Resource)
                    {
                        PanelResources.Controls.Add(CategoryTitle);
                    }
                    else if (category.CategoryType == CategoryType.Favorite)
                    {
                        PanelLists.Controls.Add(CategoryTitle);
                    }
                }
            }


            UpdateScrollBarCategories();
        }

        private void CategoryTitle_Click(object sender, EventArgs e)
        {
            SelectedCategory = Categories.GetCategoryById(((Label)sender).Name);

            FilterModsType = "";
            FilterModsRegion = "";

            LoadModsByCategoryId(SelectedCategory.Id,
                                    FilterModsName,
                                    FilterModsFirmware,
                                    FilterModsType,
                                    FilterModsRegion);

            ComboBoxModType.SelectedIndex = string.IsNullOrEmpty(FilterModsType) ? 0 : ComboBoxModType.FindStringExact(FilterModsType);
        }

        private void CategoryTitle_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(75, 110, 175);
        }

        private void CategoryTitle_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SelectedCategory.Id.Equals(((Label)sender).Name) ? Color.FromArgb(75, 110, 175) : Color.FromArgb(60, 63, 65);
        }

        /// <summary>
        ///     Loads all the mods for the specified gameId, matching with filters: name, firmware, type and region
        /// </summary>
        /// <param name="gameId">Filter GameId</param>
        /// <param name="name">Filter by Name</param>
        /// <param name="firmware">Filter by Firmware</param>
        /// <param name="type">Filter by Type</param>
        /// <param name="region">Filter by Region</param>
        private void LoadModsByCategoryId(string gameId, string name, string firmware, string type, string region)
        {
            UpdateCategoryTitles();
            LoadInstalledMods();

            DgvMods.Rows.Clear();

            ComboBoxModType.Items.Clear();
            _ = ComboBoxModType.Items.Add("ANY");

            ComboBoxModType.Items.AddRange(Mods.AllModTypesForCategoryId(gameId).ToArray());

            ComboBoxRegion.Items.Clear();
            _ = ComboBoxRegion.Items.Add("ANY");

            ComboBoxRegion.Items.AddRange(SelectedCategory.Regions.ToArray());

            foreach (ModsData.ModItem modItem in Mods.GetModItems(gameId, name, firmware, type, region))
            {
                _ = DgvMods.Rows.Add(modItem.Id,
                                     modItem.Name,
                                     modItem.Firmware,
                                     modItem.Type,
                                     modItem.Region,
                                     modItem.Version == "n/a" || modItem.Version == "-" || modItem.Version == "" ? "-" : "v" + modItem.Version,
                                     modItem.Author,
                                     modItem.InstallPaths.Length + (modItem.InstallPaths.Length > 1 ? " Files" : " File"),
                                     ImageExtensions.ResizeBitmap(Resources.icons8_software_installer_22, 19, 19),
                                     ImageExtensions.ResizeBitmap(Resources.icons8_download_from_the_cloud_22, 19, 19),
                                     SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) ?
                                     ImageExtensions.ResizeBitmap(Resources.icons8_heart_fill_22, 20, 20) :
                                     ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 19, 19));

            }

            LabelNoModsFound.Visible = DgvMods.Rows.Count == 0;

            DgvMods.Sort(DgvMods.Columns[1], ListSortDirection.Ascending);

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
        ///     Loads all of the currently installed game mods
        /// </summary>
        private void LoadInstalledMods()
        {
            DgvModsInstalled.Rows.Clear();

            int totalFiles = 0;

            foreach (GameModInstalled installedMod in SettingsData.InstalledGameMods)
            {
                CategoriesData.Category modCategory = Categories.GetCategoryById(installedMod.GameId);

                ModsData.ModItem modInstalled = Mods.GetModById(installedMod.ModId);

                _ = DgvModsInstalled.Rows.Add(modInstalled.Id.ToString(),
                                              modCategory.Title,
                                              installedMod.GameRegion,
                                              modInstalled.Name,
                                              modInstalled.Type,
                                              modInstalled.Version == "n/a" ? "-" : "v" + modInstalled.Version,
                                              installedMod.Files + (installedMod.Files > 1 ? " Files" : " File"),
                                              string.Format("{0:g}", installedMod.DateInstalled),
                                              ImageExtensions.ResizeBitmap(Resources.icons8_uninstall_programs_22, 19, 19));

                totalFiles += installedMod.Files;
            }

            LabelInstalledGameModsStatus.Text = string.Format("{0} Mods Installed ({1} Files)", SettingsData.InstalledGameMods.Count, totalFiles);

            ToolItemUninstallAllGameMods.Enabled = IsConsoleConnected && SettingsData.InstalledGameMods.Count > 0;

            LabelNoModsInstalled.Visible = DgvModsInstalled.Rows.Count == 0;
        }

        /// <summary>
        ///     Sets the UI to display the selected mod's details
        /// </summary>
        /// <param name="modId">Specifies the <see cref="ModsData.ModItem.Id"/></param>
        private void DisplayModDetails(long modId)
        {
            ModsData.ModItem modItem = Mods.GetModById(modId);

            if (modItem == null)
            {
                return;
            }

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = string.Format("{0} {1}", modItem.Name.Replace("&", "&&"), SettingsData.ShowModIds ? "(ID # " + modItem.Id.ToString() + ")" : "");
            LabelCategory.Text = Categories.GetCategoryById(Mods.GetModById(modId).GameId).Title;
            LabelType.Text = modItem.Type;
            LabelVersion.Text = modItem.Version;
            LabelFirmware.Text = modItem.Firmware;
            LabelRegion.Text = string.Join(", ", modItem.GameRegions);
            LabelAuthor.Text = modItem.Author.Replace("&", "&&");
            LabelSubmittedBy.Text = modItem.SubmittedBy.Replace("&", "&&");
            LabelConfig.Text = string.Join(", ", modItem.GameModes);
            LabelDescription.Text = string.IsNullOrEmpty(modItem.Description) ? "No other details can be found for this yet." : modItem.Description.Replace("&", "&&");

            // Append extra information for modded game saves in the description
            if (modItem.IsGameSave)
            {
                LabelDescription.Text += "\n\n--------------------------------\n\nImportant Notes for Installing Game Saves:\n\n-You must have at least one USB device connected to the console before installing the game save files.\n- It's suggested to use 'Apollo Tool' (find at Homebrew Packages) for patching and resigning game save files directly on your console.";
            }

            DgvInstallPaths.Rows.Clear();

            foreach (string filePath in modItem.InstallPaths)
            {
                _ = DgvInstallPaths.Rows.Add(filePath);
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
                ToolItemUninstallMod.Enabled = !modItem.IsInstallToRebugFolder && IsConsoleConnected;
            }

            ToolItemFavoriteMod.Image = SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) ? ImageExtensions.ResizeBitmap(Resources.icons8_heart_fill_22, 19, 19) : ImageExtensions.ResizeBitmap(Resources.icons8_heart_outline_22, 19, 19);
            ToolItemFavoriteMod.Text = SettingsData.FavoritedIds.Contains(modItem.Id.ToString()) ? "Unfavorite" : "Favorite";
            ToolItemFavoriteMod.AutoSize = false;
            ToolItemFavoriteMod.AutoSize = true;

            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     
        /// </summary>
        public void UpdateCategoryTitles()
        {
            foreach (object ctrl in PanelGames.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name) ? Color.FromArgb(75, 110, 175) : Color.FromArgb(60, 63, 65);
            }

            foreach (object ctrl in PanelResources.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name) ? Color.FromArgb(75, 110, 175) : Color.FromArgb(60, 63, 65);
            }

            foreach (object ctrl in PanelLists.Controls)
            {
                ((Label)ctrl).BackColor = SelectedCategory.Id.Equals(((Label)ctrl).Name) ? Color.FromArgb(75, 110, 175) : Color.FromArgb(60, 63, 65);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        public void UpdateScrollBarCategories()
        {
            ScrollBarCategories.Minimum = FlowPanelCategories.VerticalScroll.Minimum;
            ScrollBarCategories.Maximum = FlowPanelCategories.VerticalScroll.Maximum;
            ScrollBarCategories.ViewSize = FlowPanelCategories.VerticalScroll.LargeChange - 30;
            ScrollBarCategories.Value = 0;
            ScrollBarCategories.UpdateScrollBar();
        }

        /// <summary>
        ///     
        /// </summary>
        public void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        private void FlowPanelDetails_MouseWheel(object sender, MouseEventArgs e)
        {
            try { ScrollBarDetails.Value = FlowPanelDetails.VerticalScroll.Value + 10; } catch { }
        }

        private void FlowPanelCategories_MouseWheel(object sender, MouseEventArgs e)
        {
            try { ScrollBarCategories.Value = FlowPanelCategories.VerticalScroll.Value + 10; } catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ScrollBarCategories_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            try 
            {
                FlowPanelCategories.VerticalScroll.Value = ScrollBarCategories.Value;
                FlowPanelCategories.Update();
            }            
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ScrollBarDetails_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            try
            {
                FlowPanelDetails.VerticalScroll.Value = ScrollBarDetails.Value;
                FlowPanelDetails.Update();
            }            
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FlowPanelDetails_Scroll(object sender, ScrollEventArgs e)
        {
            try { ScrollBarDetails.Value = FlowPanelDetails.VerticalScroll.Value; } catch { }
        }

        /// <summary>
        ///     Installs the specified <paramref name="modItem"/> files to the connected console
        /// </summary>
        /// <param name="modItem">Contains the mod details, such as name, download files, install locations, etc.</param>
        public void InstallMods(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(SelectedModItem.GameId);

            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Preparing to install files...");

            // Check whether this mod is already installed
            foreach (GameModInstalled installedGameMod in SettingsData.InstalledGameMods)
            {
                if (installedGameMod.GameId.Equals(modItem.GameId) && installedGameMod.ModId.Equals(modItem.Id))
                {
                    if (DarkMessageBox.Show(this, $"You have already installed: '{modItem.Name} v{modItem.Version}' to game: '{category.Title}'" +
                        $"\nDo you still want to install the files again?", "Mod Already Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Installation cancelled.");
                        return;
                    }
                }
            }

            // Check whether is being installed the firmware folder, let the user know ask if they want to cancel
            if (modItem.IsInstallToRebugFolder)
            {
                if (DarkMessageBox.Show(this, "Important: For this mod to work it needs to be installed to the firmware developer (dev_rebug/) folder, which is for the REBUG Custom Firmware only. It's recommended to create a backup of the entire folder yourself before installing any mods to this location. Also ensure that you're running the correct firmware and the REBUG TOOLBOX application is open while the files are being installed. Any missing or incorrect files in this folder can impact your console performance. If you have issues after rebooting console then enter recovery mode and reinstall your custom firmware.\n\nProceed at your own risk and only if you know what you're doing.\nWould you like to cancel this install?", "Install to Rebug Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Installation cancelled.");
                    return;
                }
            }

            try
            {
                string gameRegion = "";
                string userId = "";
                string usbDevice = "";

                string gameTitle = category.Title;

                // Check whether a game region must be provided and prompts the user to choose one
                if (modItem.RequiresGameRegion)
                {
                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching region...");

                    gameRegion = category.GetGameRegion(this, modItem.GameId);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No region selected. Installation cancelled.");
                        return;
                    }

                    if (!modItem.IsAnyRegion && !modItem.Region.Equals(gameRegion))
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Region isn't supported for this mod. Installation cancelled.");
                        return;
                    }

                    if (SettingsData.RememberGameRegions)
                    {
                        SettingsData.UpdateGameRegion(modItem.GameId, gameRegion);
                    }
                }

                // Check whether a user id must be provided and prompts the user to choose one
                if (modItem.RequiresUserId)
                {
                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching user id...");

                    userId = FtpExtensions.GetUserId(this);
                    gameTitle = $"{category.Title} ({userId})";

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No user id selected. Installation cancelled.");
                        return;
                    }
                }

                // If it's a game save then alert the user that a usb device must be connected to console
                if (modItem.RequiresUsbDevice)
                {
                    if (modItem.IsGameSave)
                    {
                        if (DarkMessageBox.Show(this,
                        "Before installing this game save you must have completed the following steps:\n- Insert your USB device to any port on the console.\n- Install the Apollo Tool PKG from the Homebrew Packages category on your console to unlock, patch and resign save-game files directly on your PS3."
                        + "\nThis will only work if you have your USB device connected. Click 'Yes' if you have done this. Otherwise click 'No' and this game-save will not be installed.", "Install Game Save to USB Device", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            gameTitle = $"{category.Title} ({usbDevice})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No USB device connected. Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Installation cancelled.");
                            return;
                        }
                    }
                    else
                    {
                        if (DarkMessageBox.Show(this,
                        "One or more files needs to be installed at a USB device that is connected to your console. It could be required for the mods to work, such as a configuration or plugin file. I suggest you read the complete description for more details on this."
                        + "\nTo allow for these files to be installed, you must have a USB inserted before you continue. Would you like to proceed, click 'Yes' to continue. Otherwise click 'No' and all USB files will be ignored.", "Install Files to USB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            gameTitle = $"{category.Title} ({gameRegion})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No USB device connected. Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            usbDevice = "";
                        }
                    }
                }

                // Checks whether it's a game mod, and if mod is already installed to the same game then ask whether to uninstall the current one
                if (category.CategoryType == CategoryType.Game)
                {
                    GameModInstalled modInstalled = SettingsData.GetInstalledGameMod(category.Id);

                    if (modInstalled != null)
                    {
                        ModsData.ModItem currentModItem = Mods.GetModById(modInstalled.ModId);

                        if (DarkMessageBox.Show(this, $"'{currentModItem.Name} v{currentModItem.Version} ({currentModItem.Type})' is currently installed to: {category.Title}."
                                                      + "\nAny previous mods must be uninstalled before installing new mods, this is to prevent conflict between mods and having an affect on game performance.\n\nDo you want to cancel this install?",
                                                      "Mod Currently Installed",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Installation Cancelled.");
                            return;
                        }
                        else
                        {
                            UninstallMods(Mods.GetModById(modInstalled.ModId), gameRegion);
                        }
                    }
                }

                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Downloading install files...");
                modItem.DownloadInstallFiles();

                int indexFiles = 1;
                int totalFiles = modItem.InstallPaths.Length;

                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing files...");

                foreach (string installFilePath in modItem.InstallPaths)
                {
                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory, "*.*", SearchOption.AllDirectories))
                    {
                        string installFileName = Path.GetFileName(installFilePath);

                        string installPath = installFilePath.Replace("{REGION}", $"{gameRegion}")
                                                            .Replace("{USERID}", $"{userId}")
                                                            .Replace("{USBDEV}", $"{usbDevice}");

                        string installPathWithoutFileName = Path.GetDirectoryName(installPath);//.Replace(@"\", "/");

                        // Whether install file matches the specified install file
                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            // Whether this file is being istalled to a game folder (can be sesnsitive)
                            if (installPath.Contains("/dev_hdd0/game/"))
                            {
                                // Gets the backup details for this game file
                                BackupFile backupFile = SettingsData.GetGameFileBackup(modItem.GameId, installFileName, installPath);

                                // A backup hasn't been created for this file, so it will be ignored and kept alone - in case issues occur with the game
                                if (backupFile == null)
                                {
                                    // Alert the user there is no backup for this file and it will be skipped due to crashing the game
                                    if (DarkMessageBox.Show(this, "There is no backup for this file. Would you like to create a backup for the current game file? You can then revert the mods at anytime when uninstalling, or using 'TOOLS > Backup Files' to restore the file the original state.\n\nGame File Name: " + Path.GetFileName(installFilePath), "Backup Game File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SetStatus($"{modItem.Name} v{modItem.Version} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Creating backup file: {installFileName}...");

                                        CreateBackupFile(modItem, installFileName, installPath);

                                        SetStatus($"{modItem.Name} v{modItem.Version}  v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");

                                        FtpExtensions.UploadFile( localFilePath, installPath);
                                        indexFiles++;
                                    }
                                    // A backup for the this file does exists, so it will be installed to the game
                                    else
                                    {
                                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");

                                        FtpExtensions.UploadFile(localFilePath, installPath);
                                        indexFiles++;
                                    }
                                }
                                // Install the local file, like sprx or key files
                                else
                                {
                                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");

                                    FtpExtensions.UploadFile(localFilePath, installPath);
                                    indexFiles++;
                                }
                            }
                            // Whether this file is being installed to a USB device
                            else if (installFilePath.Contains("{USBDEV}"))
                            {
                                if (!string.IsNullOrEmpty(usbDevice))
                                {
                                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");

                                    FtpExtensions.UploadFile( localFilePath, installPath);
                                    indexFiles++;
                                }
                            }
                            // Otherwise, install the file as normal
                            else
                            {
                                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName}");

                                FtpExtensions.UploadFile(localFilePath, installPath);
                                indexFiles++;
                            }
                        }
                    }
                }

                // Determines whether it's a game and not a game save
                if (category.CategoryType == CategoryType.Game && !modItem.IsGameSave)
                {
                    SettingsData.UpdateInstalledGameMod(category.Id, gameRegion, modItem.Id, indexFiles - 1, DateTime.Now);
                    SaveSettingsData();
                    LoadInstalledMods();
                }

                // Log status
                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Successfully installed {indexFiles - 1} files");
                _ = DarkMessageBox.Show(this, string.Format("Installed {0} ({1} files) for {2}{3}.", modItem.Name, indexFiles - 1, category.Title, category.CategoryType == CategoryType.Game ? "\nReady to start game" : ""), "Mods Installed", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Log status
                SetStatus($"Error installing files for {modItem.Name} v{modItem.Version} (#{modItem.Id}) for {category.Title} ({category.Id.ToUpper()}) - {ex.Message}", ex);
                _ = DarkMessageBox.Show(this, $"An error occurred installing files for {modItem.Name} (#{modItem.Id}). See menu 'HELP > Report Bug' to open an issue about this, you can also attach the log file so it can be quickly investigated and fixed." +
                    "\nError Message: " + ex.Message, "Unable to Install", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Uninstall all of the files for the <paramref name="modItem"/>.
        /// </summary>
        /// <param name="modItem">Contains the mod details object <see cref="ModsData.modItem"/></param>
        /// <param name="region">Contains the game region</param>
        public void UninstallMods(ModsData.ModItem modItem, string region = null)
        {
            CategoriesData.Category category = Categories.GetCategoryById(modItem.GameId);

            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Preparing to uninstall files...");

            // Alerts the user that uninstalling files from dev_rebug folders is now allowed
            if (modItem.IsInstallToRebugFolder)
            {
                _ = DarkMessageBox.Show(this, "This mod has been installed to the 'dev_rebug' folder, which is a developer folder for the REBUG Custom Firmware. You cannot uninstall files from this folder as any missing files can impact your console performance.", "Developer Folder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Cancelled installation.");
                return;
            }

            try
            {
                string gameTitle = category.Title;

                string gameRegion = "";
                string userId = "";
                string usbDevice = "";

                // If a game region isn't provided already, then prompt the user to choose one
                if (!string.IsNullOrEmpty(region))
                {
                    gameRegion = region;
                    gameTitle = $"{category.Title} ({gameRegion})";

                    userId = null;
                }

                // Check whether a game region needs to be provided, if one hasn't already
                if (modItem.RequiresGameRegion && string.IsNullOrEmpty(region))
                {
                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching region...");

                    gameRegion = category.GetGameRegion(this, modItem.GameId);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    userId = null;

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No region selected. Cancelled installation.");
                        return;
                    }

                    if (SettingsData.RememberGameRegions)
                    {
                        SettingsData.UpdateGameRegion(modItem.GameId, gameRegion);
                    }
                }

                // Whether or not a UserId is required and prompt the user to choose one
                if (modItem.RequiresUserId)
                {
                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching user id...");

                    userId = FtpExtensions.GetUserId(this);

                    gameTitle = $"{category.Title} ({userId})";
                    gameRegion = null;

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No userId selected. Cancelled installation.");
                        return;
                    }
                }

                // If this mod requires a usb device to be connected to console, ask the user whether they want to continue with this
                if (modItem.RequiresUsbDevice)
                {
                    // If this is a modded gamesave then inform the user they must remove the gamesave from their usb themselves
                    if (modItem.IsGameSave)
                    {
                        _ = DarkMessageBox.Show(this,
                                            "Unfortunately, you can't uninstall gamesaves using this tool. You must remove the gamesave from the USB device yourself.",
                                            "Can't Uninstall Gamesave",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                        usbDevice = null;
                        gameTitle = $"{category.Title}";
                    }
                    else
                    {
                        if (DarkMessageBox.Show(this, "Some modded files may have been installed to a usb device connected to your console if you specified when installing mods. You can choose to uninstall them now or manually delete them yourself." +
                            "\nIf you would like to uninstall the files from your USB now, you must connect the same USB device into the front of console then click 'YES' to continue." +
                            "\nIf you specified not to install any files to your USB device, then click 'NO' and the files will be ignored.",
                            "Uninstall USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            gameTitle = $"{category.Title} ({usbDevice})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {category.Title} - No USB device connected. Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            usbDevice = "";
                        }
                    }
                }

                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Uninstalling files...");

                int indexFiles = 1;
                int totalFiles = modItem.InstallPaths.Length;

                // Loop through specified install file paths
                foreach (string installFilePath in modItem.InstallPaths)
                {
                    // Format install file path with specified info: region/userId
                    string installPath = installFilePath.Replace("{REGION}", $"{gameRegion}")
                                                        .Replace("{USERID}", $"{userId}")
                                                        .Replace("{USBDEV}", $"{usbDevice}");

                    string installPathWithoutFileName = Path.GetDirectoryName(installPath);

                    if (installPath.Contains("dev_hdd0/game/")) // Check whether file is installed to game folder
                    {
                        // Get the backup data if one has been created for this file matching: game id, file name and install path
                        BackupFile backupFile = SettingsData.GetGameFileBackup(modItem.GameId, Path.GetFileName(installPath), installPath);

                        if (backupFile != null) // Check whether a backup has been created for this file
                        {
                            if (File.Exists(backupFile.LocalPath)) // If the backup file still exists on the users computer
                            {
                                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Installing backup file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName})");

                                // Install the backup file to the original game file path
                                FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                indexFiles++;
                            }
                            else
                            {
                                _ = DarkMessageBox.Show(this, $"There is data for a game file backup, but the file '{Path.GetFileName(installPath)}' can't be found on your computer. If this file has been moved then go to Tools > Backup Files, and then locate and set the local file again. If this file has been deleted, you must backup the file again. This file will be ignored to prevent any issues with missing game files.", "No Backup File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            _ = DarkMessageBox.Show(this, $"There is no backup file for '{Path.GetFileName(installPath)}' so it can't be uninstalled. This file will be ignored to prevent any issues with missing game files. To restore the file to original then you must reinstall the game update.", "No Backup File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (installFilePath.Contains("{USBDEV}"))
                    {
                        if (!modItem.IsGameSave)
                        {
                            if (!string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {installPathWithoutFileName}");

                                // Uninstall modded file from usb device
                                FtpExtensions.DeleteFile(installPath);
                                indexFiles++;
                            }
                        }
                    }
                    else
                    {
                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {installPathWithoutFileName}");

                        // Uninstall modded file from console install path
                        FtpExtensions.DeleteFile(installPath);
                        indexFiles++;
                    }
                }

                // If it's a game mod, remove data from settings
                if (category.CategoryType == CategoryType.Game)
                {
                    try
                    {
                        SettingsData.RemoveInstalledGameMod(category.Id, modItem.Id);
                        SaveSettingsData();
                        LoadInstalledMods();
                    }
                    catch { }
                }

                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) for {gameTitle} - Successfully uninstalled {indexFiles - 1} files");
                _ = DarkMessageBox.Show(this, string.Format("Uninstalled {0} ({1} files) for {2}", modItem.Name, indexFiles - 1, category.Title), "Mods Uninstalled", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Error uninstalling '{modItem.Name} v{modItem.Version} (#{modItem.Id}) for {category.Title} ({category.Id.ToUpper()}) - {ex.Message}", ex);
                _ = DarkMessageBox.Show(this, $"An error occurred uninstalling the files for {modItem.Name} (#{modItem.Id}).. See Help > Report Issue/Suggestions to submit an issue, and attach the log.txt file found in the program's installation path." +
                   "\nError Message: " + ex.Message, "Unable to Uninstall", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Download the mod archive to the user specified path
        /// </summary>
        /// <param name="modItem"></param>
        public void DownloadModArchive(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(modItem.GameId);

            try
            {
                SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Downloading archive...");

                string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want the README to be extracted");

                if (folderPath != null)
                {
                    modItem.DownloadArchiveAtPath(folderPath);
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Successfully downloaded archive at path: {folderPath}");
                    _ = Process.Start(folderPath);
                }
                else
                {
                    SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Download archive cancelled.");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download archive {modItem.Name} ({modItem.Id}) for {category.Title} - {ex.Message}", ex);
                _ = DarkMessageBox.Show(this, "An error occurred downloading archive. (Access maybe denied at this path, so try a different folder). See log file for more information about this issue." +
                   "\nError Message: " + ex.Message, "Unable to Download Archive", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Adds/removes the specified mod to the users favorites list
        /// </summary>
        /// <param name="modItem"></param>
        private void AddModToFavorites(ModsData.ModItem modItem)
        {
            CategoriesData.Category category = Categories.GetCategoryById(modItem.GameId);

            if (SettingsData.FavoritedIds.Contains(modItem.Id.ToString()))
            {
                _ = SettingsData.FavoritedIds.Remove(modItem.Id.ToString());

                DisplayModDetails(SelectedModItem.Id);

                if (SelectedCategory.Id.Equals("fvrt"))
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }

                SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Removed from your favorites");
            }
            else
            {
                SettingsData.FavoritedIds.Add(modItem.Id.ToString());

                DisplayModDetails(SelectedModItem.Id);

                SetStatus($"{modItem.Name} ({modItem.Type}) for {category.Title} - Added to your favorites");
            }

            ToolItemFavoriteMod.AutoSize = false;
            ToolItemFavoriteMod.AutoSize = true;

            ToolStripArchiveInformation.Update();
        }

        /// <summary>
        ///     Create/store a backup of the specified file, and then downloads it locally to a known path
        /// </summary>
        /// <param name="modItem"></param>
        /// <param name="fileName"></param>
        /// <param name="installFilePath"></param>
        public static void CreateBackupFile(ModsData.ModItem modItem, string fileName, string installFilePath)
        {
            _ = Directory.CreateDirectory(SettingsData.CreateBackupFileFolder(modItem));

            BackupFile backupFile = new BackupFile()
            {
                Name = "Current Game File",
                CategoryId = modItem.GameId,
                FileName = fileName,
                LocalPath = SettingsData.CreateBackupFilePath(modItem, fileName),
                InstallPath = installFilePath
            };

            SettingsData.BackupFiles.Add(backupFile);

            FtpExtensions.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
        }

        /// <summary>
        ///     Set the current connected console status in the tool strip
        /// </summary>
        /// <param name="consoleProfile"></param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            ToolStripLabelConsole.Text = consoleProfile == null ? "Idle" : consoleProfile.Name;
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

        /// <summary>
        ///     Enable/disable console actions
        /// </summary>
        private void EnableConsoleActions()
        {
            MenuItemToolsFileManager.Enabled = IsConsoleConnected;
            ToolItemInstallMod.Enabled = IsConsoleConnected;
            ToolItemDownloadMod.Enabled = IsConsoleConnected;
            ContextMenuModsInstallToConsole.Enabled = IsConsoleConnected;
            ContextMenuModsUninstallFromConsole.Enabled = IsConsoleConnected;
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
        ///     Save application settings json data file
        /// </summary>
        public static void SaveSettingsData()
        {
            try
            {
                Program.Log.Info("Saving settings data to file...");

                if (!Directory.Exists(Utilities.DocumentsFolder))
                {
                    _ = Directory.CreateDirectory(Utilities.DocumentsFolder);
                }

                using (StreamWriter streamWriter = new StreamWriter(SettingsData.SettingsDataFile))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(SettingsData));
                }

                Program.Log.Info("Successfully saved settings data");
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to save settings data : " + ex.Message, ex);
            }
        }

        /// <summary>
        ///     Load application settings json data file
        /// </summary>
        public void LoadSettingsData()
        {
            try
            {
                Program.Log.Info("Loading settings data from file...");

                if (File.Exists(SettingsData.SettingsDataFile))
                {
                    using (StreamReader streamReader = new StreamReader(SettingsData.SettingsDataFile))
                    {
                        SettingsData = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                    }
                }

                Program.Log.Info("Successfully loaded settings data");
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load settings data : " + ex.Message, ex);
                return;
            }

            if (SettingsData.ConsoleProfiles.Count == 0)
            {
                SettingsData.ConsoleProfiles.Add(new ConsoleProfile() { Name = "Default Console", Address = "192.168.0.42" });
            }

            if (SettingsData.ExternalApplications.Count == 0)
            {
                SettingsData.ExternalApplications.Add(
                    new ExternalApplication("Control Console (CCAPI)",
                                            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ControlConsoleAPI\CCAPIConsoleManager.exe"))
                    );

                SettingsData.ExternalApplications.Add(
                    new ExternalApplication("FileZilla",
                                            @"C:\Program Files\FileZilla FTP Client\filezilla.exe")
                    );
            }

            // Update UI Properties from Settings
            MenuItemApplications.DropDownItems.Clear();
            foreach (ExternalApplication application in SettingsData.ExternalApplications)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(application.Name, null, MenuItemApplications_Click);
                _ = MenuItemApplications.DropDownItems.Add(menuItem);
            }

            MenuItemSettingsShowModID.Checked = SettingsData.ShowModIds;
            MenuItemSettingsAutoDetectGameRegion.Checked = SettingsData.AutoDetectGameRegion;
            MenuItemSettingsRememberGameRegions.Checked = SettingsData.RememberGameRegions;
            MenuItemSettingsAlwaysDownloadInstallFiles.Checked = SettingsData.AlwaysDownloadInstallFiles;
        }

        private void MenuItemApplications_Click(object sender, EventArgs e)
        {
            string menuItemText = ((ToolStripMenuItem)sender).Text;

            foreach (ExternalApplication application in SettingsData.ExternalApplications)
            {
                if (application.Name.Equals(menuItemText))
                {
                    if (File.Exists(application.FileLocation))
                    {
                        _ = Process.Start(application.FileLocation);
                    }
                    else
                    {
                        _ = DarkMessageBox.Show(this, $"Could not locate the file at location: {application.FileLocation} for application: {application.Name}\n\nGo to Settings > Edit Applications and set the correct file path for this application.", "Application Not Found", MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}