using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatus($"Initializing application data...");

            Extensions.Update.CheckVersion();
            Worker.RunWorkAsync(LoadData, InitializeFinished);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        /// <summary>
        ///     Retrieves the games and mods data into the application
        /// </summary>
        private static void LoadData()
        {
            GamesData = Utilities.GetGamesData();
            ModsData = Utilities.GetModsData();
        }

        /// <summary>
        ///     Set a few properties after being initialized
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Initialized application (Version {Utilities.GetCurrentVersion()}) - Ready to connect...");

            LoadConsoles();
            ComboBoxConsole.Enabled = true;
            FlowPanelGames.Controls.Clear();

            foreach (GamesData.Game gameData in GamesData.Games)
            {
                AddGameTitle(gameData);
            }

            SelectedGame = GamesData.Games[0];
            LoadGameMods(GamesData.Games[0].Id);
            UpdateScrollBarGames();
            UpdateGameControls();

            ToolStripLabelStats.Text = string.Format("{0} Mods Overall for {1} Games", ModsData.Mods.Length, GamesData.Games.Length);

            // Load Settings UI
            MenuStripSettingsAutoDetectRegion.Checked = Settings.Default.AutoGameRegion;
        }

        private void LoadConsoles()
        {
            ComboBoxConsole.Items.Clear();

            foreach (var console in Settings.Default.UserConsoles)
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
            Application.Exit();
        }

        private void MenuStripContribute_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utilities.ProjectRepoUrl);
        }

        private void MenuStripInformation_Click(object sender, EventArgs e)
        {
            DarkMessageBox.ShowInformation("ModioX is developed by wh1ter0se-x, with the intended purpose of proving an efficient method of browsing, downloading and installing popular game mods. All credits given to those appropriate creators/authors of all the mods used for this database. If you have any questions please send a message at my Discord: wh1ter0se#7480 with your much welcomed comments, suggestions and feedback to help support this project.", "Information");
        }

        private void MenuStripHelp_Click(object sender, EventArgs e)
        {
            using (HelpWindow helpWindow = new HelpWindow())
            {
                helpWindow.ShowDialog();
            }
        }

        private void MenuStripSettingsEditConsoles_Click(object sender, EventArgs e)
        {
            using (ConsolesWindow consolesWindow = new ConsolesWindow())
            {
                consolesWindow.ShowDialog(this);
                LoadConsoles();
            }
        }

        private void MenuStripSettingsAutoDetectRegion_Click(object sender, EventArgs e)
        {
            Settings.Default.AutoGameRegion = MenuStripSettingsAutoDetectRegion.Checked;
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

            UsersConsoleIp = TextBoxAddress.Text;

            EnableButton(ButtonConnectConsole, !string.IsNullOrWhiteSpace(TextBoxAddress.Text));
        }

        private void ButtonConnectConsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConsoleConnected)
                {
                    SetStatus($"Disconnecting from {UsersConsoleName} - Please wait...");
                    ComboBoxConsole.Enabled = true;
                    ButtonConnectConsole.Text = @"Connect";
                    SetStatusConsole("None", "0.0.0.0");
                    SetStatus("Disconnected from console");
                    IsConsoleConnected = false;
                    EnableConsoleActions(false);
                }
                else
                {
                    SetStatus($"Connecting to {UsersConsoleName} - Please wait...");

                    using (new FtpConnection(UsersConsoleIp))
                    {
                    } // Just test a connection to the console address, no actual connection made permanently

                    ComboBoxConsole.Enabled = false;
                    ButtonConnectConsole.Text = @"Disconnect";
                    SetStatusConsole(UsersConsoleName, UsersConsoleIp);
                    SetStatus("Connected to console, ready to install mods");
                    IsConsoleConnected = true;
                    EnableConsoleActions(true);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to connect - Error: {ex.Message}");
            }
        }

        private void EnableConsoleActions(bool enable)
        {
            ButtonInstallFiles.Enabled = enable;
            ButtonUninstallFiles.Enabled = enable;
            ButtonInstallCustom.Enabled = enable;
        }

        private void TextBoxSelectedConsole_Enter(object sender, EventArgs e)
        {
            TextBoxSelectedConsole.Enabled = false;
            TextBoxSelectedConsole.Enabled = true;
        }

        private void TextBoxSelectedConsole_Click(object sender, EventArgs e)
        {
            ComboBoxConsole.DroppedDown = ComboBoxConsole.Enabled;
        }

        private void ComboBoxConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxConsole.SelectedIndex != -1)
            {
                TextBoxSelectedConsole.Text = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem);

                UsersConsoleName = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem)
                    .Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[0];
                UsersConsoleIp = ComboBoxConsole.GetItemText(ComboBoxConsole.SelectedItem)
                    .Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1];

                TextBoxAddress.Text = UsersConsoleIp;
            }

            EnableButton(ButtonConnectConsole, !string.IsNullOrWhiteSpace(TextBoxAddress.Text));
        }

        private void ButtonRequestMods_Click(object sender, EventArgs e)
        {
            Utilities.OpenRequestTemplate();
        }

        private void GameTitle_Click(object sender, EventArgs e)
        {
            SelectedGame = Utilities.GetGameByTitle(GamesData, ((Label)sender).Text);

            LoadGameMods(SelectedGame.Id);

            DgvMods.Enabled = DgvMods.Rows.Count != 0;
            DgvMods.Sort(ColumnName, ListSortDirection.Ascending);

            UpdateGameControls();
        }

        private void GameTitle_MouseLeave(object sender, EventArgs e)
        {
            if (((Label)sender).Name == SelectedGame.Id)
            {
                ((Label)sender).BackColor = Color.FromArgb(71, 75, 77);
                ((Label)sender).ForeColor = Color.White;
            }
            else
            {
                ((Label)sender).BackColor = Color.Transparent;
                ((Label)sender).ForeColor = Color.Gainsboro;
            }
        }

        private void GameTitle_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(71, 75, 77);
            ((Label)sender).ForeColor = Color.White;
        }

        private void TextBoxSelectedCategory_Enter(object sender, EventArgs e)
        {
            TextBoxSelectedCategory.Enabled = false;
            TextBoxSelectedCategory.Enabled = true;
        }

        private void TextBoxSelectedCategory_Click(object sender, EventArgs e)
        {
            ComboBoxCategory.DroppedDown = ComboBoxCategory.Enabled;
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCategory.SelectedIndex != -1)
            {
                TextBoxSelectedCategory.Text = ComboBoxCategory.GetItemText(ComboBoxCategory.SelectedItem);
            }

            if (ComboBoxCategory.SelectedIndex == 0)
            {
                LoadGameMods(SelectedGame.Id);
            }
            else
            {
                LoadGameMods(SelectedGame.Id, ComboBoxCategory.GetItemText(ComboBoxCategory.SelectedItem));
            }
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvMods.CurrentRow != null)
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

            EnableButton(ButtonInstallFiles, DgvMods.SelectedRows.Count != 0 && IsConsoleConnected);
            EnableButton(ButtonUninstallFiles, DgvMods.SelectedRows.Count != 0 && IsConsoleConnected);
            EnableButton(ButtonDownloadFiles, DgvMods.SelectedRows.Count != 0);
            EnableButton(ButtonReport, DgvMods.SelectedRows.Count != 0);
        }

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

            EnableButton(ButtonInstallFiles, e.RowIndex != -1 && IsConsoleConnected);
            EnableButton(ButtonUninstallFiles, e.RowIndex != -1 && IsConsoleConnected);
            EnableButton(ButtonDownloadFiles, e.RowIndex != -1);
            EnableButton(ButtonReport, e.RowIndex != -1);
        }

        private void DgvMods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
        }

        /// <summary>
        ///     Loads all the specified types of mods for the given game into the gridview
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="modType"></param>
        private void LoadGameMods(string gameId, string modType = "")
        {
            DgvMods.Rows.Clear();
            ComboBoxCategory.Items.Clear();
            ComboBoxCategory.Items.Add("ANY");

            foreach (var modData in ModsData.Mods)
            {
                if (string.Equals(modData.GameId, gameId) && modData.Type.Contains(modType))
                {
                    DgvMods.Rows.Add(modData.Id, modData.Name, modData.Version, modData.Author);

                    if (!ComboBoxCategory.Items.Contains(modData.Type))
                    {
                        ComboBoxCategory.Items.Add(modData.Type);
                    }
                }
            }

            UpdateScrollBarMods();
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
            LabelHeaderName.Text = $"{modItem.Name} ({modItem.Type})";
            LabelByAuthor.Text = $"Created by {modItem.Author}";
            LabelVersion.Text = modItem.Version;
            LabelConfiguration.Text = modItem.Configuration;
            LabelDescription.Text = modItem.Description;

            DgvInstallPaths.Rows.Clear();
            foreach (string filePath in modItem.InstallPaths)
            {
                DgvInstallPaths.Rows.Add(filePath);
            }

            UpdateScrollBarDetails();
            UpdateScrollBarInstallPaths();
        }

        /// <summary>
        ///     Creates and adds the game title object into the list of games
        /// </summary>
        /// <param name="game">Game data item</param>
        public void AddGameTitle(GamesData.Game game)
        {
            Label gameTitle = new Label
            {
                AutoSize = false,
                Height = 26,
                Width = FlowPanelGames.Width - 20,
                Text = game.Title,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Gainsboro,
                Margin = new Padding(0, 0, 0, 0),
                Padding = new Padding(5, 0, 0, 0),
                Cursor = Cursors.Hand,
                Name = game.Id
            };

            gameTitle.MouseEnter += GameTitle_MouseEnter;
            gameTitle.MouseLeave += GameTitle_MouseLeave;
            gameTitle.Click += GameTitle_Click;
            FlowPanelGames.Controls.Add(gameTitle);
        }

        /// <summary>
        ///     Reloads and sets the selected game from the list
        /// </summary>
        private void UpdateGameControls()
        {
            foreach (Label title in FlowPanelGames.Controls)
            {
                if (title.Name == SelectedGame.Id)
                {
                    title.BackColor = Color.FromArgb(71, 75, 77);
                    title.ForeColor = Color.White;
                }
                else
                {
                    title.BackColor = Color.Transparent;
                    title.ForeColor = Color.Gainsboro;
                }                
            }
        }

        public void UpdateScrollBarGames()
        {
            FlowPanelGames.HorizontalScroll.Visible = false;
            ScrollBarGames.Visible = FlowPanelGames.VerticalScroll.Visible;
            ScrollBarGames.Minimum = FlowPanelGames.VerticalScroll.Minimum;
            ScrollBarGames.Maximum = FlowPanelGames.VerticalScroll.Maximum;
            ScrollBarGames.ViewSize = FlowPanelGames.VerticalScroll.LargeChange;
            ScrollBarGames.Value = 0;
            ScrollBarGames.UpdateScrollBar();
        }

        public void UpdateScrollBarMods()
        {
            DgvMods.ScrollBars = ScrollBars.None;
            ScrollBarMods.Maximum = DgvMods.RowCount;
            ScrollBarMods.ViewSize = DgvMods.DisplayedRowCount(true);
            ScrollBarMods.Value = 0;
            ScrollBarMods.UpdateScrollBar();
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

        private void ScrollBarGames_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            FlowPanelGames.VerticalScroll.Value = ScrollBarGames.Value;
            FlowPanelGames.Update();
        }

        private void FlowPanelGames_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarGames.Value = e.NewValue;
        }

        private void ScrollBarMods_ValueChanged(object sender, ScrollValueEventArgs e)
        {
            try { DgvMods.FirstDisplayedScrollingRowIndex = ScrollBarMods.Value; } catch { }
        }

        private void DgvMods_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarMods.Value = e.NewValue;
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

        private void ButtonInstallFiles_Click(object sender, EventArgs e)
        {
            SetStatus($"Installing '{SelectedModItem.Name}' to console - Detecting game region...");

            try
            {
                SelectedGameRegion = Utilities.GetUsersGameRegion(UsersConsoleIp, SelectedGame, Settings.Default.AutoGameRegion);

                if (!string.IsNullOrEmpty(SelectedGameRegion))
                {
                    SetStatus($"Installing '{SelectedModItem.Name}' to console - Downloading files...");
                    Utilities.DownloadExtractFiles(SelectedModItem);

                    int currentFileNo = 0;
                    int totalFileNo = Directory.GetFiles($@"{Utilities.AppDataPath}{SelectedModItem.Name}\").Length;
                    foreach (string installFilePath in SelectedModItem.InstallPaths)
                    {
                        foreach (string modFilePath in Directory.GetFiles($@"{Utilities.AppDataPath}{SelectedModItem.Name}\"))
                        {
                            if (string.Equals(Path.GetFileName(installFilePath), Path.GetFileName(modFilePath), StringComparison.CurrentCultureIgnoreCase))
                            {
                                currentFileNo++;

                                /*if (installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    SetStatus($"Installing '{SelectedModItem.Name}' to console - Downloading backup of original game files...");
                                    Utilities.DownloadOriginalGameFile(UsersConsoleIp, installFilePath.Replace("/{REGION}/", $"/{SelectedGameRegion}/"), SelectedModItem);
                                }*/

                                SetStatus($"Installing '{SelectedModItem.Name}' to console - Uploading {currentFileNo} of {totalFileNo} files: {Path.GetFileName(modFilePath)}");
                                Utilities.InstallFile(UsersConsoleIp, modFilePath, installFilePath.Replace("/{REGION}/", $"/{SelectedGameRegion}/"));
                            }
                        }
                    }

                    SetStatus($"{SelectedModItem.Name} ({totalFileNo} files) have been installed. Ready to start: {SelectedGame.Title}");
                }
                else
                {
                    SetStatus("Aborted - Game region could not be found");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to install '{SelectedModItem.Name}' for some weird reason, see log file - Error: {ex.Message}");
            }
        }

        private void ButtonUninstallFiles_Click(object sender, EventArgs e)
        {
            SetStatus($"Uninstalling '{SelectedModItem.Name}' files from console...");

            try
            {
                SelectedGameRegion = Utilities.GetUsersGameRegion(UsersConsoleIp, SelectedGame, Settings.Default.AutoGameRegion);
                if (!string.IsNullOrEmpty(SelectedGameRegion))
                {
                    SetStatus("Uninstalling files...");
                    Utilities.UninstallModFiles(UsersConsoleIp, SelectedModItem);
                    SetStatus($"{SelectedModItem.Name} files uninstalled");
                }
                else
                {
                    SetStatus("Aborted - Game region is not specified");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to uninstall files - Error: {ex.Message}");
            }
        }

        private void ButtonDownloadFiles_Click(object sender, EventArgs e)
        {
            SetStatus($"Downloading files for '{SelectedModItem.Name}' locally...");

            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (folderBrowser.ShowDialog() != DialogResult.OK)
                    {
                        Utilities.DownloadToLocation(SelectedModItem, folderBrowser.SelectedPath);
                        SetStatus($"Downloaded compressed archive for '{SelectedModItem.Name}' to {folderBrowser.SelectedPath}");
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download '{SelectedModItem.Name}' files - Error: {ex.Message}");
            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            Utilities.OpenReportTemplate(SelectedModItem);
        }

        private void ButtonBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxLocalFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void ComboBoxInstallPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxInstallPath.Text = ComboBoxInstallPath.GetItemText(ComboBoxInstallPath.SelectedItem);
        }

        private void ButtonInstallCustom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLocalFile.Text) || string.IsNullOrWhiteSpace(TextBoxInstallPath.Text))
            {
                SetStatus("One or more fields are not completed.");
            }
            else
            {
                try
                {
                    SetStatus($"Installing custom file to console - Uploading files...");

                    var localFile = TextBoxLocalFile.Text;
                    var installFilePath = TextBoxInstallPath.Text;

                    if (installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                    {
                        SelectedGameRegion = Utilities.GetUsersGameRegion(UsersConsoleIp, SelectedGame, Settings.Default.AutoGameRegion);
                        Utilities.InstallFile(UsersConsoleIp, localFile, installFilePath.Replace("/{REGION}/", $"/{SelectedGameRegion}/"));
                    }
                    else
                    {
                        Utilities.InstallFile(UsersConsoleIp, localFile, installFilePath);
                    }

                    SetStatus($"Custom file has been installed. Ready to load game.");
                }
                catch (Exception ex)
                {
                    SetStatus($"Unable to install your custom file for some weird reason, see log file - Error: {ex.Message}");
                }
            }
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
        private void SetStatus(string status)
        {
            ToolStripLabelStatus.Text = status;
            Program.LogMessage(status);
            Refresh();
        }

        /// <summary>
        ///     Enable/disable button
        /// </summary>
        /// <param name="button">Button to enable/disable</param>
        /// <param name="enabled">True enables the button</param>
        public static void EnableButton(Button button, bool enabled)
        {
            button.Enabled = enabled;
        }
    }
}