using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using Ps3Xftp.Extensions;
using Ps3Xftp.Models;
using Ps3Xftp.Properties;
using Ps3Xftp.Windows;

namespace Ps3Xftp
{
    public partial class Ps3Xftp : Form
    {
        /// <summary>
        ///     Contains the latest mods data retrieved from the database
        /// </summary>
        private static ModsData _modsData = new ModsData();

        /// <summary>
        ///     Contains the latest games data retrieved from the database
        /// </summary>
        public static GamesData GamesData = new GamesData();

        /// <summary>
        ///     Application user's data roaming directory
        /// </summary>
        private static string AppDataPath { get; } = $@"{Application.UserAppDataPath}\";

        public Ps3Xftp()
        {
            InitializeComponent();
            EnableModsUi(false);
        }

        /// <summary>
        ///     Ps3xftp application loading event
        /// </summary>
        private void Ps3xftp_Load(object sender, EventArgs e)
        {
            SetStatus("Initializing...");
            Worker.RunWorkAsync(LoadData, InitializeFinished);
        }

        /// <summary>
        ///     Application closing event to save settings
        /// </summary>
        private void Ps3xftp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        /// <summary>
        ///     Retrieves the mods and games data from the database into the application
        /// </summary>
        private static void LoadData()
        {
            _modsData = Utilities.GetModsData();
            GamesData = Utilities.GetGameData();
        }

        /// <summary>
        ///     After data is initialized, load consoles and games into dropdown menu
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            DropdownConsoles.Enabled = true;
            DropdownConsoles.Items.Clear();
            DropdownGames.Items.Clear();
            foreach (var console in Settings.Default.UserConsoles)
                DropdownConsoles.Items.Add(console);
            foreach (var game in GamesData.Games)
                DropdownGames.Items.Add(game.Title);
            SetStatus($"Initialized application (Version {_modsData.Version}) - Ready to connect...");
            DropdownConsoles.SelectedIndex = 0;
        }

        private void MenuStripFileRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Refreshing data for games and mods updates...");
            EnableModsUi(false);
            IsConsoleConnected = false;
            ButtonConnectToConsole.Text = @"Connect";
            DropdownConsoles.Enabled = false;
            ButtonConnectToConsole.Enabled = false;
            Worker.RunWorkAsync(LoadData, InitializeFinished);
        }

        private void MenuStripFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStripContribute_Click(object sender, EventArgs e)
        {
            Process.Start(Utilities.GithubProject);
        }

        private void MenuStripInformation_Click(object sender, EventArgs e)
        {
            var infoWindow = new InformationWindow();
            infoWindow.ShowDialog();
        }

        /// <summary>
        ///     Reloads the consoles list into the dropdown menu
        /// </summary>
        private void LoadConsoles()
        {
            DropdownConsoles.Items.Clear();
            foreach (var profile in Settings.Default.UserConsoles)
                DropdownConsoles.Items.Add(profile);
        }

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
        private static GamesData.Game UsersGame { get; set; }

        /// <summary>
        ///     Contains the selected mods info selected by the user
        /// </summary>
        private static ModsData.ModItem UsersGameMod { get; set; }

        /// <summary>
        ///     Contains the region response from the user
        /// </summary>
        private static string UsersGameRegion { get; set; }

        /// <summary>
        ///     Whether the user's selected console has been connected
        /// </summary>
        private static bool IsConsoleConnected { get; set; }

        /// <summary>
        ///     Set the selected item from the dropdown menu to property
        /// </summary>
        private void ComboBoxConsoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownConsoles.SelectedIndex != -1)
            {
                UsersConsoleName = DropdownConsoles.GetItemText(DropdownConsoles.SelectedItem)
                    .Split(new[] {" : "}, StringSplitOptions.RemoveEmptyEntries)[0];
                UsersConsoleIp = DropdownConsoles.GetItemText(DropdownConsoles.SelectedItem)
                    .Split(new[] {" : "}, StringSplitOptions.RemoveEmptyEntries)[1];
            }

            EnableButton(ButtonConnectToConsole, DropdownConsoles.SelectedIndex != -1);
        }

        /// <summary>
        ///     Test connection to the console and enable user controls
        /// </summary>
        private void ButtonConnectToConsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConsoleConnected)
                {
                    SetStatus($"Disconnecting from {UsersConsoleName} - Please wait...");
                    EnableModsUi(false);
                    DropdownConsoles.Enabled = true;
                    ButtonConnectToConsole.Text = @"Connect";
                    SetStatusConsole("none", "0.0.0.0");
                    SetStatus("Disconnected from console");
                    IsConsoleConnected = false;
                }
                else
                {
                    SetStatus($"Connecting to {UsersConsoleName} - Please wait...");
                    using (new Ps3Ftp(UsersConsoleIp))
                    {
                    } // Just test a connection to the console

                    EnableModsUi(true);
                    DropdownConsoles.Enabled = false;
                    ButtonConnectToConsole.Text = @"Disconnect";
                    DropdownGames.SelectedIndex = 0;
                    SetStatusConsole(UsersConsoleName, UsersConsoleIp);
                    SetStatus("Connected to console, ready");
                    IsConsoleConnected = true;
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to connect to console - Error: {ex.Message}");
                EnableModsUi(false);
            }
        }

        private void ButtonEditConsoles_Click(object sender, EventArgs e)
        {
            var consolesWindow = new ConsolesWindow();
            consolesWindow.ShowDialog(this);
            LoadConsoles();
        }

        /// <summary>
        ///     Retrieve the mods data from the loaded database
        /// </summary>
        /// <param name="modId">Name of the mod</param>
        /// <returns>Mod information</returns>
        private static ModsData.ModItem GetModDetails(long modId)
        {
            foreach (var mod in _modsData.Mods)
                if (mod.Id == modId)
                    return mod;
            throw new Exception($"Unable to specified match modId : {modId}");
        }

        /// <summary>
        ///     Loads all the mods for the user's selected game into the dropdown menu
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="gameType"></param>
        private void LoadGameMods(string gameId, string gameType = "")
        {
            DataModItems.Rows.Clear();

            foreach (var modData in _modsData.Mods)
                if (string.Equals(modData.GameId, gameId) && modData.Type.Contains(gameType))
                {
                    DataModItems.Rows.Add(modData.Id, modData.Name, modData.Type, modData.Version, modData.Author);
                    if (!DropdownTypes.Items.Contains(modData.Type))
                        DropdownTypes.Items.Add(modData.Type);
                }
        }

        private void DropdownGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsersGame = Utilities.GetGameByTitle(DropdownGames.GetItemText(DropdownGames.SelectedItem));

            LoadGameMods(UsersGame.Id);

            DropdownTypes.Items.Clear();
            DropdownTypes.Items.Add("ANY");
            DropdownTypes.SelectedIndex = 0;
            DataModItems.Enabled = DropdownGames.SelectedItem != null;
            DataModItems.Sort(ColumnName, ListSortDirection.Ascending);
        }

        private void DropdownTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownTypes.SelectedIndex == 0)
                LoadGameMods(UsersGame.Id);
            else
                LoadGameMods(UsersGame.Id, DropdownTypes.GetItemText(DropdownTypes.SelectedItem));
        }

        private void DataItemsMods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataModItems.CurrentRow != null)
                ShowModDetails(Convert.ToInt64(DataModItems.CurrentRow.Cells[0].Value.ToString()));
        }

        private void DataModItems_SelectionChanged(object sender, EventArgs e)
        {
            if (DataModItems.CurrentRow != null)
                ShowModDetails(Convert.ToInt64(DataModItems.CurrentRow.Cells[0].Value.ToString()));
            EnableButton(ButtonDownloadLocally, DataModItems.SelectedRows.Count != 0);
            EnableButton(ButtonInstallToConsole, DataModItems.SelectedRows.Count != 0);
            EnableButton(ButtonUninstallFromConsole, DataModItems.SelectedRows.Count != 0);
            EnableButton(ButtonReportMod, DataModItems.SelectedRows.Count != 0);
        }

        private void DataItemsMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataModItems.CurrentRow != null)
                ShowModDetails(Convert.ToInt64(DataModItems.CurrentRow.Cells[0].Value.ToString()));
            EnableButton(ButtonDownloadLocally, e.RowIndex != -1);
            EnableButton(ButtonInstallToConsole, e.RowIndex != -1);
            EnableButton(ButtonUninstallFromConsole, e.RowIndex != -1);
            EnableButton(ButtonReportMod, e.RowIndex != -1);
        }

        /// <summary>
        ///     Sets the UI to display the user's selected mod
        /// </summary>
        /// <param name="modId">Id of the mod item</param>
        private void ShowModDetails(long modId)
        {
            var modDetails = GetModDetails(modId);
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
            SetStatus($"Downloading modded files for '{UsersGameMod.Name}' locally...");

            try
            {
                var folderBrowser = new FolderBrowserDialog {ShowNewFolderButton = true};
                if (folderBrowser.ShowDialog() != DialogResult.OK) return;
                DownloadModToLocation(UsersGameMod, folderBrowser.SelectedPath);
                SetStatus($"Downloaded compressed archive {UsersGameMod.Name} to specified folder");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download '{UsersGameMod.Name}' files - Error: {ex.Message}");
            }
        }

        private void ButtonDownloadInstallMods_Click(object sender, EventArgs e)
        {
            SetStatus($"Installing '{UsersGameMod.Name}' modded files to console - Detecting game region...");

            try
            {
                UsersGameRegion = GetUsersGameRegion(UsersGame, CheckboxAutoRegion.Checked);
                if (!string.IsNullOrEmpty(UsersGameRegion))
                {
                    SetStatus("Downloading archive to disk...");
                    DownloadExtractFiles(UsersGameMod);

                    var currentFileNo = 0;
                    var totalFileNo = Directory.GetFiles($@"{AppDataPath}{UsersGameMod.Name}\").Length;
                    foreach (var installFilePath in UsersGameMod.InstallPaths)
                    foreach (var modFilePath in Directory.GetFiles($@"{AppDataPath}{UsersGameMod.Name}\"))
                        if (string.Equals(Path.GetFileName(installFilePath), Path.GetFileName(modFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            currentFileNo++;
                            SetStatus($"Installing file {currentFileNo} of {totalFileNo} to console: {Path.GetFileName(modFilePath)}");
                            Utilities.FileToPs3(UsersConsoleIp, modFilePath, installFilePath
                                .Replace("/{REGION}/", $"/{UsersGameRegion}/"));
                        }

                    SetStatus($"{UsersGameMod.Name} ({totalFileNo}) has been installed. Ready to start: {UsersGame.Title}");
                }
                else
                {
                    SetStatus("Aborted - Game region could not be found");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to install files for '{UsersGameMod.Name}' - Error: {ex.Message}");
            }
        }

        private void ButtonUninstallFiles_Click(object sender, EventArgs e)
        {
            SetStatus($"Uninstalling '{UsersGameMod.Name}' modded files from console...");

            try
            {
                UsersGameRegion = GetUsersGameRegion(UsersGame, CheckboxAutoRegion.Checked);
                if (!string.IsNullOrEmpty(UsersGameRegion))
                {
                    SetStatus("Uninstalling files...");
                    UninstallModFiles(UsersGameMod);
                    SetStatus($"{UsersGameMod.Name} files uninstalled");
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

        private void ButtonReportMod_Click(object sender, EventArgs e)
        {
            Utilities.OpenReportTemplate(UsersGameMod);
        }

        /// <summary>
        ///     Returns the users game region, either automatically set region by searching existing console directories or prompt
        ///     the user to select one
        /// </summary>
        /// <param name="game">Selected game</param>
        /// <param name="autoRegion">Automatically retrieve users region</param>
        /// <returns></returns>
        private static string GetUsersGameRegion(GamesData.Game game, bool autoRegion)
        {
            if (autoRegion)
            {
                using (var ps3 = new Ps3Ftp(UsersConsoleIp))
                    foreach (var region in game.Regions)
                        if (ps3.DirectoryExists($"dev_hdd0/game/{region}/"))
                            return region;
            }
            else
            {
                var frmRegions = new RegionsWindow();
                foreach (var region in game.Regions)
                    frmRegions.ListboxRegions.Items.Add(region);
                frmRegions.ShowDialog();
                return frmRegions.SelectedRegion;
            }

            return null;
        }

        /// <summary>
        ///     Download modded files from the URL of the ModsData to the path specified by the user
        /// </summary>
        /// <param name="modInfo">Mod to download</param>
        /// <param name="downloadPath">Mod to download</param>
        private static void DownloadModToLocation(ModsData.ModItem modInfo, string downloadPath)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(modInfo.Url),
                    $"{downloadPath}/{modInfo.Name} (v{modInfo.Version}) ({modInfo.Author}).zip");
            }
        }

        /// <summary>
        ///     Downloads the compressed archive for the mods and then extracts the archive into the app data roaming director
        /// </summary>
        /// <param name="modInfo">Mod to download</param>
        private static void DownloadExtractFiles(ModsData.ModItem modInfo)
        {
            var archivePath = $"{AppDataPath}{modInfo.Name}";
            var archiveFilePath = $"{AppDataPath}{modInfo.Name}.zip";
            if (Directory.Exists(archivePath))
                Directory.Delete(archivePath, true);
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(modInfo.Url), archiveFilePath);
                ZipFile.ExtractToDirectory(archiveFilePath, AppDataPath);
            }
        }

        /// <summary>
        ///     Uninstall modded files specified in the InstallPath from the users console, ignore game specific files as this
        ///     could cause game to stop working (only .sprx files)
        /// </summary>
        /// <param name="modInfo">Mod to uninstall</param>
        private static void UninstallModFiles(ModsData.ModItem modInfo)
        {
            foreach (var installFilePath in modInfo.InstallPaths)
                using (var ps3 = new Ps3Ftp(UsersConsoleIp))
                {
                    if (installFilePath.StartsWith("dev_hdd0/game/{REGION}/",
                            StringComparison.InvariantCultureIgnoreCase) && ps3.FileExists(installFilePath))
                        ps3.RemoveFile(installFilePath);
                }
        }

        /// <summary>
        ///     Set the current connected console status in the tool strip
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ip"></param>
        private void SetStatusConsole(string name, string ip)
        {
            ToolStripConsole.Text = $@"{name} ({ip})";
        }

        /// <summary>
        ///     Set the current process status in the tool strip
        /// </summary>
        /// <param name="status"></param>
        private void SetStatus(string status)
        {
            ToolStripStatus.Text = status;
            Program.WriteToLog(status);
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

        /// <summary>
        ///     Enable/disable the mods user interface controls
        /// </summary>
        /// <param name="enabled">True/false</param>
        private void EnableModsUi(bool enabled)
        {
            DataModItems.Rows.Clear();
            LabelSelectGame.Enabled = enabled;
            LabelSelectType.Enabled = enabled;
            LabelDetailsName.Enabled = enabled;
            FlowPanelDetails.Enabled = enabled;
            DropdownGames.Enabled = enabled;
            DropdownTypes.Enabled = enabled;
            CheckboxAutoRegion.Enabled = enabled;
            DataModItems.Enabled = enabled;
        }
    }
}