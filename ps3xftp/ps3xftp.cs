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
            foreach (var console in Properties.Settings.Default.UserConsoles)
                DropdownConsoles.Items.Add(console);
            foreach (var game in GamesData.Games)
                DropdownGames.Items.Add(game.Title);
            SetStatus(string.Format("Initialized ps3xftp data (version {0}) - Ready to connect...", ModsData.Version));
        }

        /// <summary>
        /// Application user's data roaming directory
        /// </summary>
        static string AppDataPath = $@"{Application.UserAppDataPath}\";

        /// <summary>
        /// Contains the latest mods data retrieved from the database
        /// </summary>
        public static Models.ModsData ModsData = new Models.ModsData();

        /// <summary>
        /// Contains the latest games data retrieved from the database
        /// </summary>
        public static Models.GamesData GamesData = new Models.GamesData();

        private void MenuStripFileRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Refreshing data...");
            EnableModsUI(false);
            LoadData();
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
        static string SelectedConsole;

        /// <summary>
        /// Contains data for the current user's selected game
        /// </summary>
        private static Models.GamesData.Game SelectedGame;

        /// <summary>
        /// Contains the region for the user's selected game
        /// </summary>
        static string SelectedRegion;

        /// <summary>
        /// Contains info for the user's selected mod 
        /// </summary>
        static Models.ModsData.ModItem SelectedModInfo;

        /// <summary>
        /// Set the selected dropdown item to console
        /// </summary>
        private void ComboBoxConsoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownConsoles.SelectedIndex != -1)
                SelectedConsole = DropdownConsoles.GetItemText(DropdownConsoles.SelectedItem).Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1];
            EnableButton(ButtonConnectToConsole, DropdownConsoles.SelectedIndex != -1);
        }

        /// <summary>
        /// Test connection to the console and enable ui controls
        /// </summary>
        private void ButtonConnectToConsole_Click(object sender, EventArgs e)
        {
            try
            {
                SetStatus(string.Format("Connecting to {0} - Please wait...", SelectedConsole));
                Refresh();
                using (var PS3 = new PS3FTP(SelectedConsole)) { }
                EnableModsUI(true);
                DropdownGames.SelectedIndex = 0;
                SetConnectedConsole(DropdownConsoles.GetItemText(DropdownConsoles.SelectedItem));
                SetStatus("Successfully connected to selected console");

            }
            catch (Exception ex)
            {
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
            {
                if (modData.GamePrefix == gamePrefix && modData.Type.Contains(gameType))
                {
                    DataModItems.Rows.Add(modData.Name, modData.Type, modData.Version, modData.Author);

                    if (!DropdownTypes.Items.Contains(modData.Type))
                    {
                        DropdownTypes.Items.Add(modData.Type);
                    }
                }
            }
        }

        private void DropdownGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedGame = Utilities.GetGameByTitle(DropdownGames.GetItemText(DropdownGames.SelectedItem));

            LoadGameMods(SelectedGame.Prefix);

            DropdownRegions.Items.Clear();
            foreach (string region in SelectedGame.Regions)
                DropdownRegions.Items.Add(region);

            DropdownTypes.Items.Clear();
            DropdownTypes.Items.Add("ANY");
            DropdownTypes.SelectedIndex = 0;

            DropdownRegions.SelectedIndex = 0;

            DropdownRegions.Enabled = DropdownGames.SelectedItem != null;
            DataModItems.Enabled = DropdownRegions.SelectedItem != null;
        }


        private void DropdownRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRegion = DropdownRegions.GetItemText(DropdownRegions.SelectedItem);
        }

        private void DropdownTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownTypes.SelectedIndex == 0)
            {
                LoadGameMods(SelectedGame.Prefix);
            }
            else
            {
                LoadGameMods(SelectedGame.Prefix, DropdownTypes.GetItemText(DropdownTypes.SelectedItem));
            }
        }

        private void DataItemsMods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowModsDetails(DataModItems.CurrentRow.Cells[0].Value.ToString());
        }

        private void DataItemsMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
                ShowModsDetails(DataModItems.CurrentRow.Cells[0].Value.ToString());
            EnableButton(ButtonInstallMods, e.RowIndex != -1);
            EnableButton(ButtonUninstallMods, e.RowIndex != -1);
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
            SelectedModInfo = modDetails;
        }

        private void ButtonInstallMods_Click(object sender, EventArgs e)
        {
            SetStatus(string.Format("Download and installing mod files for '{0}'...", SelectedModInfo.Name));
            InstallMod(SelectedModInfo);
        }

        /// <summary>
        /// Starts the process of downloading and then installing the mod files from the database
        /// </summary>
        /// <param name="modInfo">Mod info</param>
        private void InstallMod(Models.ModsData.ModItem modInfo)
        {
            try
            {
                string archiveLocation = $"{AppDataPath}{modInfo.Name}.zip";

                SetStatus("Downloading mod archive data...");
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept: application/zip");
                    wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    wc.DownloadFile(new Uri(modInfo.URL), archiveLocation);
                    System.IO.Compression.ZipFile.ExtractToDirectory(archiveLocation, AppDataPath);
                }

                SetStatus("Downloaded. Installing files to console...");

                foreach (var installPath in modInfo.InstallPaths)
                    foreach (var modPath in Directory.GetFiles($@"{AppDataPath}{modInfo.Name}\"))
                        if (Path.GetFileName(installPath).ToLower() == Path.GetFileName(modPath).ToLower())
                        {
                            SetStatus($"Uploading {Path.GetFileName(modPath)}...");
                            Utilities.FileToPS3(SelectedConsole.ToString(), modPath, installPath
                                .Replace("/{REGION}/", $"/{SelectedRegion}/"));
                        }
            }
            catch (Exception exception)
            {
                SetStatus("There was an issue installing mod files - Error: " + exception.Message);
            }
        }

        /// <summary>
        /// Set the current connected console in the tool strip
        /// </summary>
        /// <param name="console"></param>
        private void SetConnectedConsole(string console)
        {
            ToolStripConsole.Text = console;
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
            LabelSelectRegion.Enabled = enabled;
            LabelSelectType.Enabled = enabled;
            LabelModDetails.Enabled = enabled;
            LabelDetailsName.Enabled = enabled;
            FlowPanelDetails.Enabled = enabled;
            DropdownGames.Enabled = enabled;
            DropdownRegions.Enabled = enabled;
            DropdownTypes.Enabled = enabled;
            DataModItems.Enabled = enabled;
        }

        /// <summary>
        /// Show raw text from the specified URL in a window box
        /// </summary>
        /// <param name="title">Title of file</param>
        /// <param name="filePath">Path pointing to info file</param>
        public static void ShowDataWindow(string title, string filePath)
        {
            DataWindow frmInfo = new DataWindow { Text = title };
            frmInfo.labelData.Text = File.ReadAllText(filePath);
            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, Form.Height - 100);
            frmInfo.ShowDialog(Form);
        }
    }
}
