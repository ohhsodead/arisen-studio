using ps3xftp.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ps3xftp.Windows;

namespace ps3xftp
{
    public partial class Ps3xftp : Form
    {
        /// <summary>
        /// This is only instance of the main form
        /// </summary>
        public static Ps3xftp Form { get; set; } = null;

        public Ps3xftp()
        {
            InitializeComponent();
            Form = this;
            EnableModsUI(false);
        }

        /// <summary>
        /// Ps3xftp application loading event
        /// </summary>
        private void Ps3xftp_Load(object sender, EventArgs e)
        {
            SetStatus("Initializing ps3xftp...");
            Worker.RunWorkAsync(() => LoadData(), InitializeFinished);
        }

        /// <summary>
        /// Application closing event to save settings
        /// </summary>
        private void Ps3xftp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Retrieves the mods and games data from the database into the application
        /// </summary>
        private void LoadData()
        {
            ModsData = Utilities.GetModsData();
            GamesData = Utilities.GetGameData();
        }

        /// <summary>
        /// After data is initialized, load consoles and games into dropdown menu
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            DropdownConsoles.Enabled = true;
            DropdownConsoles.Items.Clear();
            DropdownGames.Items.Clear();
            foreach (var console in Properties.Settings.Default.UserConsoles)
                DropdownConsoles.Items.Add(console);
            foreach (var game in GamesData.Games)
                DropdownGames.Items.Add(game.Title);
            SetStatus(string.Format("Initialized ps3xftp data (version {0}) - Ready to connect...", ModsData.Version));
        }

        /// <summary>
        /// Application user's data roaming directory
        /// </summary>
        static string AppDataPath { get; } = $@"{Application.UserAppDataPath}\";

        /// <summary>
        /// Contains the latest mods data retrieved from the database
        /// </summary>
        public static Models.ModsData ModsData { get; set; } = new Models.ModsData();

        /// <summary>
        /// Contains the latest games data retrieved from the database
        /// </summary>
        public static Models.GamesData GamesData { get; set; } = new Models.GamesData();

        private void MenuStripFileRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Refreshing data for games and mods updates...");
            EnableModsUI(false);
            DropdownConsoles.Enabled = false;
            ButtonConnectToConsole.Enabled = false;
            Worker.RunWorkAsync(() => LoadData(), InitializeFinished);
        }

        private void MenuStripFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStripConsolesEdit_Click(object sender, EventArgs e)
        {
            var consolesWindow = new ConsolesWindow();
            consolesWindow.ShowDialog(this);
            LoadConsoles();
        }
        
        private void MenuStripContribute_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utilities.URL_GITUBPROJECT);
        }

        private void MenuStripInformation_Click(object sender, EventArgs e)
        {
            var InfoWindow = new InformationWindow();
            InfoWindow.ShowDialog();
        }

        /// <summary>
        /// Loads and clears all the user's consoles into the dropdown menu
        /// </summary>
        private void LoadConsoles()
        {
            DropdownConsoles.Items.Clear();
            foreach (var profile in Properties.Settings.Default.UserConsoles)
                DropdownConsoles.Items.Add(profile);
        }

        /// <summary>
        /// Contains the IP address of the user's selected console
        /// </summary>
        static string UsersConsoleIP { get; set; }

        /// <summary>
        /// Contains data for the current user's selected game
        /// </summary>
        static Models.GamesData.Game UsersGame { get; set; }

        /// <summary>
        /// Contains info for the user's selected mod 
        /// </summary>
        static Models.ModsData.ModItem UsersGameMod { get; set; }

        /// <summary>
        /// Contains the region for the user's selected game
        /// </summary>
        static string UsersGameRegion { get; set; }

        /// <summary>
        /// Contains the region for the user's selected game
        /// </summary>
        static bool IsConsoleConnected { get; set; }= false;

        /// <summary>
        /// Set the selected dropdown item to console
        /// </summary>
        private void ComboBoxConsoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownConsoles.SelectedIndex != -1)
                UsersConsoleIP = DropdownConsoles.GetItemText(DropdownConsoles.SelectedItem).Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1];
            EnableButton(ButtonConnectToConsole, DropdownConsoles.SelectedIndex != -1);
        }

        /// <summary>
        /// Test connection to the console and enable ui controls
        /// </summary>
        private void ButtonConnectToConsole_Click(object sender, EventArgs e)
        {
            try {
                if (IsConsoleConnected) {
                    SetStatus(string.Format("Disconnecting from {0} - Please wait...", UsersConsoleIP));
                    EnableModsUI(false);
                    DropdownConsoles.Enabled = true;
                    ButtonConnectToConsole.Text = "Connect";
                    SetStatusConsole("none", false);
                    SetStatus("Successfully disconnected from console");
                }
                else {
                    SetStatus(string.Format("Connecting to {0} - Please wait...", UsersConsoleIP));
                    Refresh();
                    using (var PS3 = new PS3FTP(UsersConsoleIP)) { }
                    EnableModsUI(true);
                    DropdownConsoles.Enabled = false;
                    ButtonConnectToConsole.Text = "Disconnect";
                    DropdownGames.SelectedIndex = 0;
                    SetStatusConsole(DropdownConsoles.GetItemText(DropdownConsoles.SelectedItem), true);
                    SetStatus("Successfully connected to selected console");
                }
            }
            catch (Exception ex) {
                SetStatus(string.Format("Unable to connect, ensure your console is powered on - Error: {0}", ex.Message));
                EnableModsUI(false);
            }
        }

        /// <summary>
        /// Retrive the mods data information
        /// </summary>
        /// <param name="name">Name of the mod</param>
        /// <returns>Mod information</returns>
        private Models.ModsData.ModItem GetModsDetails(string name)
        {
            foreach (var mod in ModsData.Mods)
                if (mod.Name == name)
                    return mod;
            return null;
        }

        /// <summary>
        /// Loads all the mods for the user's selected game into the dropdown menu
        /// </summary>
        /// <param name="gamePrefix"></param>
        /// <param name="gameType"></param>
        private void LoadGameMods(string gamePrefix, string gameType = "")
        {
            DataModItems.Rows.Clear();

            foreach (var modData in ModsData.Mods)
                if (modData.GamePrefix == gamePrefix && modData.Type.Contains(gameType)) {
                    DataModItems.Rows.Add(modData.Name, modData.Type, modData.Version, modData.Author);
                    if (!DropdownTypes.Items.Contains(modData.Type))
                        DropdownTypes.Items.Add(modData.Type);
                }
        }

        private void DropdownGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsersGame = Utilities.GetGameByTitle(DropdownGames.GetItemText(DropdownGames.SelectedItem));

            LoadGameMods(UsersGame.Prefix);

            DropdownTypes.Items.Clear();
            DropdownTypes.Items.Add("ANY");
            DropdownTypes.SelectedIndex = 0;
            DataModItems.Enabled = DropdownGames.SelectedItem != null;
        }
        
        private void DropdownTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownTypes.SelectedIndex == 0)
                LoadGameMods(UsersGame.Prefix);
            else
                LoadGameMods(UsersGame.Prefix, DropdownTypes.GetItemText(DropdownTypes.SelectedItem));
        }

        private void DataItemsMods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowModsDetails(DataModItems.CurrentRow.Cells[0].Value.ToString());
        }

        private void DataItemsMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                ShowModsDetails(DataModItems.CurrentRow.Cells[0].Value.ToString());
            EnableButton(ButtonDownloadFiles, e.RowIndex != -1);
            EnableButton(ButtonInstallFiles, e.RowIndex != -1);
            EnableButton(ButtonDownloadInstallFiles, e.RowIndex != -1);
            EnableButton(ButtonUninstallFiles, e.RowIndex != -1);
        }

        /// <summary>
        /// Sets the UI to display the user's selected mod
        /// </summary>
        /// <param name="modName"></param>
        private void ShowModsDetails(string modName)
        {
            var modDetails = GetModsDetails(modName);
            LabelModName.Text = modDetails.Name;
            LabelModVersion.Text = modDetails.Version;
            LabelModAuthor.Text = modDetails.Author;
            LabelModType.Text = modDetails.Type;
            LabelModConfiguration.Text = modDetails.Configuration;
            LabelModDescription.Text = modDetails.Description;
            UsersGameMod = modDetails;
        }

        private void ButtonDownloadFiles_Click(object sender, EventArgs e)
        {
            SetStatus("Downloading mod files locally...");

            try {
                DownloadModFiles(UsersGameMod);
                SetStatus(string.Format("Downloaded {0} to ps3xftp data roaming directory.", UsersGameMod.Name));
            }
            catch (Exception ex) {
                SetStatus(string.Format("Error downloading files locally - {0}", ex.Message));
            }
        }

        private void ButtonInstallMods_Click(object sender, EventArgs e)
        {
            SetStatus(string.Format("Installing '{0}' to console - Detecting game region...", UsersGameMod.Name));

            try {
                UsersGameRegion = GetUsersGameRegion(UsersGame, CheckboxAutoRegion.Checked);
                if (!string.IsNullOrEmpty(UsersGameRegion)) {
                    SetStatus(string.Format("Installing files to console..."));
                    InstallModFiles(UsersGameMod);
                    SetStatus(string.Format("{0} files for {1} successfully uploaded. Ready to boot: {2}", UsersGameMod.InstallPaths.Count.ToString(), UsersGameMod.Name, UsersGame.Title));
                }
                else
                    SetStatus("Aborted. Game region cannot be null.");
            }
            catch (Exception ex) {
                SetStatus(string.Format("Error installing files to console - {0}", ex.Message));
            }
        }

        private void ButtonDownloadInstallMods_Click(object sender, EventArgs e)
        {
            SetStatus(string.Format("Installing '{0}' - Detecting game region...", UsersGameMod.Name));

            try {
                UsersGameRegion = GetUsersGameRegion(UsersGame, CheckboxAutoRegion.Checked);
                if (!string.IsNullOrEmpty(UsersGameRegion)) {
                    SetStatus(string.Format("Downloading files to appdata..."));
                    DownloadModFiles(UsersGameMod);
                    SetStatus(string.Format("Installing files to console..."));
                    InstallModFiles(UsersGameMod);
                    SetStatus(string.Format("{0} files for {1} successfully uploaded. Ready to boot: {2}", UsersGameMod.InstallPaths.Count.ToString(), UsersGameMod.Name, UsersGame.Title));
                }
                else
                    SetStatus("Aborted. Game region cannot be null.");
            }
            catch (Exception ex) {
                SetStatus(string.Format("Error downloading and installing files - {0}", ex.Message));
            }
        }

        private void ButtonUninstallFiles_Click(object sender, EventArgs e)
        {
            SetStatus(string.Format("Installing '{0}' - Detecting game region...", UsersGameMod.Name));

            try {
                UsersGameRegion = GetUsersGameRegion(UsersGame, CheckboxAutoRegion.Checked);
                if (!string.IsNullOrEmpty(UsersGameRegion)) {
                    SetStatus(string.Format("Uninstalling files from console..."));
                    UninstallModFiles(UsersGameMod);
                    SetStatus(string.Format("{0} files for {1} successfully removed.", UsersGameMod.InstallPaths.Count.ToString(), UsersGameMod.Name));
                }
                else
                    SetStatus("Aborted. Game region cannot be null.");
            }
            catch (Exception ex) {
                SetStatus(string.Format("Error downloading and installing files - {0}", ex.Message));
            }
        }

        public static string GetUsersGameRegion(Models.GamesData.Game game, bool autoRegion)
        {
            if (autoRegion) {
                using (var PS3 = new PS3FTP(UsersConsoleIP))
                    foreach (var region in game.Regions)
                        if (PS3.DirectoryExists($"dev_hdd0/game/{region}/"))
                            return region;
            }
            else { 
                var frmRegions = new RegionsWindow();
                foreach (var region in game.Regions)
                    frmRegions.ListboxRegions.Items.Add(region);
                frmRegions.ShowDialog();
                return frmRegions.SelectedRegion;
            }
            return null;
        }
        
        private void DownloadModFiles(Models.ModsData.ModItem modInfo)
        {
            string archiveLocation = $"{AppDataPath}{modInfo.Name}.zip";
            using (WebClient wc = new WebClient()) {
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(modInfo.URL), archiveLocation);
                System.IO.Compression.ZipFile.ExtractToDirectory(archiveLocation, AppDataPath);
            }
        }
        
        /// <summary>
        /// Starts the process of downloading and then installing the mod files from the database
        /// </summary>
        /// <param name="modInfo">Mod info</param>
        private void InstallModFiles(Models.ModsData.ModItem modInfo)
        {
            foreach (var installFilePath in modInfo.InstallPaths)
                foreach (var modFilePath in Directory.GetFiles($@"{AppDataPath}{modInfo.Name}\"))
                    if (Path.GetFileName(installFilePath).ToLower() == Path.GetFileName(modFilePath).ToLower())
                        Utilities.FileToPS3(UsersConsoleIP.ToString(), modFilePath, installFilePath
                               .Replace("/{REGION}/", $"/{UsersGameRegion}/"));
        }

        private void UninstallModFiles(Models.ModsData.ModItem modInfo)
        {
            foreach (var installFilePath in modInfo.InstallPaths)
                using (var PS3 = new PS3FTP(UsersConsoleIP))
                    if (installFilePath.EndsWith(".sprx", StringComparison.InvariantCultureIgnoreCase) && PS3.FileExists(installFilePath))
                        PS3.RemoveFile(installFilePath);
        }

        /// <summary>
        /// Set the current connected console status in the tool strip
        /// </summary>
        /// <param name="console"></param>
        /// <param name="connected"></param>
        private void SetStatusConsole(string console, bool connected)
        {
            ToolStripConsole.Text = console;
            if (connected)
                ToolStripConsole.ForeColor = Color.Green;
            else
                ToolStripConsole.ForeColor = Color.Red;
        }

        /// <summary>
        /// Set the current process status in the tool strip
        /// </summary>
        /// <param name="status"></param>
        private void SetStatus(string status)
        {
            ToolStripStatus.Text = status;
            Program.WriteToLog(status);
        }

        /// <summary>
        /// Enable/disable button
        /// </summary>
        /// <param name="button">Button to enable/disable</param>
        /// <param name="enabled">True enables the button</param>
        public static void EnableButton(Button button, bool enabled)
        {
            button.Enabled = enabled;
        }

        /// <summary>
        /// Enable/disable the mods user interface controls
        /// </summary>
        /// <param name="enabled">True/false</param>
        public void EnableModsUI(bool enabled)
        {
            LabelSelectGame.Enabled = enabled;
            LabelSelectType.Enabled = enabled;
            LabelDetailsName.Enabled = enabled;
            FlowPanelDetails.Enabled = enabled;
            DropdownGames.Enabled = enabled;
            DropdownTypes.Enabled = enabled;
            CheckboxAutoRegion.Enabled = enabled;
            DataModItems.Enabled = enabled;
        }

        /// <summary>
        /// Show raw text from the specified URL in a window box
        /// </summary>
        /// <param name="title">Title of file</param>
        /// <param name="filePath">Path pointing to info file</param>
        public static void ShowDataWindow(string title, string filePath)
        {
            var frmInfo = new DataWindow { Text = title };
            frmInfo.labelData.Text = File.ReadAllText(filePath);
            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, Form.Height - 100);
            frmInfo.ShowDialog(Form);
        }
    }
}
