using DarkUI.Controls;
using DarkUI.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Windows
{
    public partial class MainWindow : XtraForm
    {
        /// <summary>
        /// Initialize application
        /// </summary>
        public MainWindow()
        {
            Window = this;
            InitializeComponent();
        }

        private void AboutBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowAboutWindow(this);
        }

        private void AddConsoleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveSettings();

            var consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
            }

            SaveSettings();
        }

        /// <summary>
        /// Adds or removes the specified <see cref="ModsData.ModItem" /> to the users favorites list.
        /// </summary>
        /// <param name="modItem"></param>
        private void AddModToFavorites(ModItem modItem)
        {
            var category = Database.CategoriesData.GetCategoryById(modItem.GameId);

            string categoryTitle = category.Title;

            if (Settings.FavoritedIds.Contains(modItem.Id))
            {
                _ = Settings.FavoritedIds.Remove(modItem.Id);

                DisplayModDetails(SelectedModItem.Id);

                if (SelectedCategory.Id.Equals("fvrt"))
                {
                    DgvMods.Rows.RemoveAt(DgvMods.CurrentRow.Index);
                }

                SetStatus($"{categoryTitle}: {modItem.Name} ({ modItem.Type}) - Removed from favorites list.");
            }
            else
            {
                Settings.FavoritedIds.Add(modItem.Id);

                DisplayModDetails(SelectedModItem.Id);

                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Added to favorites list.");
            }

            ToolItemModAddToFavorite.AutoSize = false;
            ToolItemModAddToFavorite.AutoSize = true;

            ToolStripArchiveInformation.Update();
        }

        private void AppExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void barButtonItem15_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var notifyMessage = DialogExtensions.ShowTextInputDialog(this, "Notify Message", "Message:", string.Empty);

            if (!string.IsNullOrWhiteSpace(notifyMessage))
            {
                WebManExtensions.NotifyPopup(ConsoleProfile.Address, notifyMessage);
                SetStatus($"WebMAN Controls: Message Notified - {notifyMessage}");
            }


        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("http://pad.aldostools.org/pad.html");

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(IsConsoleConnected)
            {
            WebManExtensions.RebootSoft(ConsoleProfile.Address);
            DisconnectConsole();
            }
            else
            {

                XtraMessageBox.Show("No Connection Detected...");
            }

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsConsoleConnected)
            {
                WebManExtensions.RebootHard(ConsoleProfile.Address);
                DisconnectConsole();
            }
            else
            {
                XtraMessageBox.Show("No Connection Detected...");
            }
        }


        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebManExtensions.NotifySystemInformation(ConsoleProfile.Address);
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebManExtensions.NotifyCPURSXTemperature(ConsoleProfile.Address);

        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebManExtensions.NotifyMinimumVersion(ConsoleProfile.Address);

        }

        private void CategoryTitle_Click(object sender, EventArgs e)
        {
            SelectedCategory = Database.CategoriesData.GetCategoryById(((Label)sender).Name);
            IsCustomListSelected = false;

            FilterModsType = string.Empty;
            FilterModsRegion = string.Empty;

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);

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

        private void CheckForUpdateButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateExtensions.CheckApplicationVersion();
        }

        private void ComboBoxFirmware_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsFirmware = ComboBoxSystemType.SelectedIndex == 0 ? string.Empty : ComboBoxSystemType.GetItemText(ComboBoxSystemType.SelectedItem);

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ComboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsRegion = ComboBoxRegion.SelectedIndex == 0 ? string.Empty : ComboBoxRegion.GetItemText(ComboBoxRegion.SelectedItem);

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsType = ComboBoxModType.SelectedIndex == 0 ? string.Empty : ComboBoxModType.GetItemText(ComboBoxModType.SelectedItem);

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ContextMenuModsAddToList_Click(object sender, EventArgs e)
        {
            var listName = DialogExtensions.ShowListInputDialog("Your Lists", Settings.CustomLists.Select(x => x.Name).ToList());

            if (!string.IsNullOrWhiteSpace(listName))
            {
                var category = Database.CategoriesData.GetCategoryById(SelectedModItem.GameId);
                Settings.AddModToCustomList(listName, SelectedModItem.Id);
                SetStatus($"{category.Title}: {SelectedModItem.Name} ({SelectedModItem.Type}) - Added to '{listName}' list.");
            }
        }

        private void ContextMenuModsDownloadArchive_Click(object sender, EventArgs e)
        {
            ToolItemModDownload.PerformClick();
        }

        private void ContextMenuModsInstallToConsole_Click(object sender, EventArgs e)
        {
            ToolItemModInstall.PerformClick();
        }

        private void ContextMenuModsRemoveFromList_Click(object sender, EventArgs e)
        {
            var listName = DialogExtensions.ShowListInputDialog("Your Lists", Settings.CustomLists.Select(x => x.Name).ToList());

            if (!string.IsNullOrWhiteSpace(listName))
            {
                var category = Database.CategoriesData.GetCategoryById(SelectedModItem.GameId);
                Settings.RemoveModFromCustomList(listName, SelectedModItem.Id);
                SetStatus($"{category.Title}: {SelectedModItem.Name} ({SelectedModItem.Type}) - Removed from '{listName}' list.");
            }
        }

        private void ContextMenuModsReportOnGitHub_Click(object sender, EventArgs e)
        {
            var message = new StringBuilder()
               .Append("You will be redirected to the GitHub Issues for ModioX. ")
               .AppendLine("All details will be filled automatically.")
               .Append("Log in to GitHub and click the 'Submit' button to open a new issue so we can investigate it.");

            DarkMessageBox.ShowInformation(message.ToString(), "Opening GitHub Issues");
            GitHubTemplates.OpenReportTemplate(SelectedModItem, Database.CategoriesData.GetCategoryById(SelectedModItem.GameId));
        }

        private void ContextMenuModsUninstallFromConsole_Click(object sender, EventArgs e)
        {
            ToolItemModUninstall.PerformClick();
        }

        private void CustomCategoryTitle_Click(object sender, EventArgs e)
        {
            string customListName = ((Label)sender).Name;
            CustomList customList = Settings.GetCustomListByName(customListName);

            SelectedCategory = new Category() { Id = customListName, Title = customListName, Regions = Settings.GetRegionsForModIDs(Database.Mods, customList.ModIds).ToArray() };
            IsCustomListSelected = true;

            FilterModsType = string.Empty;
            FilterModsRegion = string.Empty;

            LoadModsByCategoryId(customListName,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);

            ComboBoxModType.SelectedIndex = string.IsNullOrEmpty(FilterModsType)
                ? 0
                : ComboBoxModType.FindStringExact(FilterModsType);
        }

        private void CustomCategoryTitle_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(75, 110, 175);
        }

        private void CustomCategoryTitle_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SelectedCategory.Id.Equals(((Label)sender).Name)
                ? Color.FromArgb(75, 110, 175)
                : Color.FromArgb(60, 63, 65);
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

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                var modItem = Database.Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

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

                    DgvMods.CurrentRow.Cells[10].Value = ImageExtensions.ResizeBitmap(Settings.FavoritedIds.Contains(modItem.Id) ? Resources.filled_heart : Resources.heart, 20, 20);
                }
            }

            ToolItemModInstall.Enabled = DgvMods.CurrentRow != null && IsConsoleConnected;
            ToolItemModDownload.Enabled = DgvMods.CurrentRow != null;
            ToolItemModAddToFavorite.Enabled = DgvMods.CurrentRow != null;
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                var modItem = Database.Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                if (modItem != null)
                {
                    DisplayModDetails(modItem.Id);
                }
            }

            ToolItemModInstall.Enabled = DgvMods.CurrentRow != null && IsConsoleConnected;
            ToolItemModDownload.Enabled = DgvMods.CurrentRow != null;
            ToolItemModAddToFavorite.Enabled = DgvMods.CurrentRow != null;
        }

        private void DgvModsInstalled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvGameModsInstalled.CurrentRow != null)
            {
                var modItem = Database.Mods.GetModById(int.Parse(DgvGameModsInstalled.CurrentRow.Cells[0].Value.ToString()));

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

        private void DgvModsInstalled_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvGameModsInstalled.CurrentRow != null)
            {
                var modItem = Database.Mods.GetModById(int.Parse(DgvGameModsInstalled.CurrentRow.Cells[0].Value.ToString()));

                DisplayModDetails(modItem.Id);
            }
        }

        /// <summary>
        /// Disconnects from the console and flushes all resources from the FTP connections.
        /// </summary>
        private void DisconnectConsole()
        {
            SetStatus($"Disconnecting from console...");

            try
            {
                FtpConnection.Dispose();
                FtpConnection.Close();

                FtpClient.Dispose();
            }
            catch
            {
                // False positive, if console is powered off then an error will be thrown.
            }

            IsConsoleConnected = false;
            SetStatusConsole(null);
            EnableConsoleActions();

            PS3ConnectButton.Caption = "Connect to console...";

            SetStatus("Disconnected from console.");

            DarkMessageBox.ShowInformation("Successfully disconnected from console.", "Success");
        }

        private void DiscordServerButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(Urls.DiscordServer);
        }

        /// <summary>
        /// Set the UI to display the specified mod details
        /// </summary>
        /// <param name="modId">Specifies the <see cref="ModsData.ModItem.Id" /></param>
        private void DisplayModDetails(int modId)
        {
            var modItem = Database.Mods.GetModById(modId);

            if (modItem == null)
            {
                return;
            }

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelName.Text = modItem.Name.Replace("&", "&&");
            LabelCategory.Text = Database.CategoriesData.GetCategoryById(Database.Mods.GetModById(modId).GameId).Title;
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
                var extraDescription = new StringBuilder("\n---------------------------------------------\n")
                    .AppendLine("Important Notes for Installing Game Saves:\n")
                    .AppendLine("- You must have at least one USB device connected to the console before installing the game save files.\n")
                    .Append("- It's suggested to use 'Apollo Tool' (Homebrew > Applications) for patching and resigning game save files directly on your console.");

                LabelDescription.Text += extraDescription.ToString();
            }

            DgvInstallationFiles.Rows.Clear();

            if (modItem.DownloadFiles.Count > 1)
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

            if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Game)
            {
                ToolItemModUninstall.Enabled = Settings.GetInstalledGameMod(modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
                ContextMenuModsUninstallFiles.Enabled = Settings.GetInstalledGameMod(modItem.GameId) != null && Settings.GetInstalledGameMod(modItem.GameId).ModId.Equals(modItem.Id) && IsConsoleConnected;
            }
            else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Homebrew)
            {
                ToolItemModUninstall.Enabled = IsConsoleConnected;
                ContextMenuModsUninstallFiles.Enabled = IsConsoleConnected;
            }
            else if (modItem.GetCategoryType(Database.CategoriesData) == CategoryType.Resource)
            {
                ToolItemModUninstall.Enabled = !modItem.DownloadFiles.Any(x => x.InstallsToRebugFolder) && IsConsoleConnected;
                ContextMenuModsUninstallFiles.Enabled = !modItem.DownloadFiles.Any(x => x.InstallsToRebugFolder) && IsConsoleConnected;
            }

            ToolItemModAddToFavorite.Image = Settings.FavoritedIds.Contains(modItem.Id)
                ? ImageExtensions.ResizeBitmap(Resources.filled_heart, 20, 20)
                : ImageExtensions.ResizeBitmap(Resources.heart, 20, 20);
            ToolItemModAddToFavorite.Text = Settings.FavoritedIds.Contains(modItem.Id) ? "Unfavorite" : "Favorite";
            ToolItemModAddToFavorite.AutoSize = false;
            ToolItemModAddToFavorite.AutoSize = true;

            UpdateScrollBarDetails();
        }

        /// <summary>
        /// Download the modded files archive to the user's specified path.
        /// </summary>
        /// <param name="modItem"></param>
        private void DownloadModArchive(ModItem modItem)
        {
            var category = Database.CategoriesData.GetCategoryById(modItem.GameId);

            var categoryTitle = category.Title;

            try
            {
                SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Downloading archive...");

                var download = modItem.GetDownloadFiles();

                if (download == null)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Download archive cancelled.");
                    return;
                }

                string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the archive.");

                if (folderPath != null)
                {
                    modItem.DownloadArchiveAtPath(Database.CategoriesData, download, folderPath);
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Successfully downloaded archive at path: {folderPath}");
                    Process.Start(folderPath);
                }
                else
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} ({modItem.Type}) - Download archive cancelled.");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to download archive {categoryTitle}: {modItem.Name} ({modItem.Id}). Error:  {ex.Message}", ex);
                DarkMessageBox.ShowError("An error occurred downloading files archive. (Access maybe denied at this path, try a different folder). See log file for more information about this issue." + "\nError Message: " + ex.Message, "Unable to Download Archive");
            }
        }

        private void EditApplicationsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowExternalApplicationsDialog(this);
            LoadSettings();
        }

        private void EditGameRegionButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameRegionsDialog(this);
            LoadSettings();
        }

        private void EditYourLists_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowCustomListsDialog(this);
            LoadSettings();
            LoadListsCategories();
        }

        /// <summary>
        /// Enable or disable console-only actions.
        /// </summary>
        private void EnableConsoleActions()
        {
            PackageManagerButton.Enabled = IsConsoleConnected;
            FileManagerButton.Enabled = IsConsoleConnected;
            WebManControlsMenu.Enabled = IsConsoleConnected && IsWebManInstalled;
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

        private void FileManagerButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowFileManager(this);
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
        }//fixed

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

        private void GameBackupFilesButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveSettings();
            DialogExtensions.ShowGameBackupFiles(this);
            SaveSettings();
        }

        private void GameUpdateFinderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowGameUpdatesFinderDialog(this);

        }

        /// <summary>
        /// Finalize application data after being initialized.
        /// </summary>
        private void InitializeFinished()
        {
            XtraDgvMods.CreateView("bla");
            SetStatus($"Successfully loaded the database - Finalizing application data...");

            LoadCategories();

            ComboBoxSystemType.Items.Clear();
            ComboBoxSystemType.Items.Add("ANY");

            foreach (var firmware in Database.Mods.AllFirmwares.Where(firmware => !ComboBoxSystemType.Items.Contains(firmware)))
            {
                _ = ComboBoxSystemType.Items.Add(firmware);
            }

            SelectedCategory = Database.CategoriesData.Categories.OrderBy(x => x.Title).First(x => x.CategoryType == CategoryType.Game);

            LoadModsByCategoryId(SelectedCategory.Id,
string.Empty,
string.Empty,
string.Empty,
string.Empty,
                IsCustomListSelected);

            ComboBoxSystemType.SelectedIndex = 0;

            ToolStripLabelStats.Text = $"{Database.Mods.TotalGameMods(Database.CategoriesData)} Mods for {Database.CategoriesData.TotalGames} Games, {Database.Mods.TotalHomebrew(Database.CategoriesData)} Homebrew Packages && {Database.Mods.TotalResources(Database.CategoriesData)} Resources (Last Updated: {Database.Mods.LastUpdated.ToLocalTime().ToShortDateString()})";

            SetStatus($"Initialized ModioX ({UpdateExtensions.CurrentVersionName}) - Ready to connect to console...");

            Focus();
        }

        private void LoadCategories()
        {
            PanelGames.Controls.Clear();
            PanelHomebrew.Controls.Clear();
            PanelResources.Controls.Clear();
            PanelLists.Controls.Clear();

            foreach (var category in Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                var modsByCategory = Database.Mods.GetModsByCategoryId(category.Id);

                if (modsByCategory.Length > 0 || category.Id.Equals("fvrt"))
                {
                    // Category Title
                    Label categoryTitle = ControlExtensions.GetCategoryTitle();
                    categoryTitle.Name = category.Id;
                    categoryTitle.Size = new Size(PanelGames.Width, 24);
                    categoryTitle.MaximumSize = new Size(PanelGames.Width, 24);
                    categoryTitle.Text = $@"{category.Title.Replace("&", "&&")} ({(category.Id.Equals("fvrt") ? Settings.FavoritedIds.Count : modsByCategory.Length)})";

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

            foreach (CustomList customList in Settings.CustomLists)
            {
                // Custom List Category Title
                Label categoryTitle = ControlExtensions.GetCategoryTitle();
                categoryTitle.Name = customList.Name;
                categoryTitle.Size = new Size(PanelGames.Width, 24);
                categoryTitle.MaximumSize = new Size(PanelGames.Width, 24);
                categoryTitle.Text = $@"{customList.Name.Replace("&", "&&")} ({customList.ModIds.Count})";

                categoryTitle.Click += CustomCategoryTitle_Click;
                categoryTitle.MouseEnter += CustomCategoryTitle_MouseEnter;
                categoryTitle.MouseLeave += CustomCategoryTitle_MouseLeave;

                PanelLists.Controls.Add(categoryTitle);
            }

            UpdateScrollBarCategories();
        }

        /// <summary>
        /// Retrieves the categories and mods into the application.
        /// </summary>
        private static async Task LoadData()
        {
            try
            {
                Database = await DropboxData.Initialize();
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to load database. Error: {ex.Message}");
                Application.Exit();
            }
        }

        private void LoadListsCategories()
        {
            PanelLists.Controls.Clear();

            foreach (var category in Database.CategoriesData.Categories)
            {
                var modsByCategory = Database.Mods.GetModsByCategoryId(category.Id);

                if (category.Id.Equals("fvrt"))
                {
                    // Custom List Category Title
                    Label categoryTitle = ControlExtensions.GetCategoryTitle();
                    categoryTitle.Name = category.Id;
                    categoryTitle.Size = new Size(PanelGames.Width, 24);
                    categoryTitle.MaximumSize = new Size(PanelGames.Width, 24);
                    categoryTitle.Text = $@"{category.Title.Replace("&", "&&")} ({Settings.FavoritedIds.Count})";

                    categoryTitle.Click += CategoryTitle_Click;
                    categoryTitle.MouseEnter += CategoryTitle_MouseEnter;
                    categoryTitle.MouseLeave += CategoryTitle_MouseLeave;

                    PanelLists.Controls.Add(categoryTitle);
                }
            }

            foreach (CustomList customList in Settings.CustomLists)
            {
                // Custom Category Title
                Label categoryTitle = ControlExtensions.GetCategoryTitle();
                categoryTitle.Name = customList.Name;
                categoryTitle.Size = new Size(PanelGames.Width, 24);
                categoryTitle.MaximumSize = new Size(PanelGames.Width, 24);
                categoryTitle.Text = $@"{customList.Name.Replace("&", "&&")} ({customList.ModIds.Count})";

                categoryTitle.Click += CustomCategoryTitle_Click;
                categoryTitle.MouseEnter += CustomCategoryTitle_MouseEnter;
                categoryTitle.MouseLeave += CustomCategoryTitle_MouseLeave;

                PanelLists.Controls.Add(categoryTitle);
            }

            UpdateScrollBarCategories();
        }

        /// <summary>
        /// Loads all the mods for the specified gameId, matching with filters: name, firmware, type and region
        /// </summary>
        /// <param name="categoryId">Filter by GameId</param>
        /// <param name="name">Filter by Name</param>
        /// <param name="firmware">Filter by Firmware</param>
        /// <param name="type">Filter by Type</param>
        /// <param name="region">Filter by Region</param>
        /// <param name="isCustomList">Filter by Region</param>
        private void LoadModsByCategoryId(string categoryId, string name, string firmware, string type, string region, bool isCustomList)
        {
            UpdateCategoryTitles();
            LoadInstalledGameMods();

            DgvMods.Rows.Clear();

            ComboBoxModType.Items.Clear();
            ComboBoxModType.Items.Add("ANY");

            if (categoryId.Equals("fvrt"))
            {
                ComboBoxModType.Items.AddRange(Settings.GetModTypesForModIDs(Database.Mods, Settings.FavoritedIds).ToArray());
            }
            else if (isCustomList)
            {
                ComboBoxModType.Items.AddRange(Settings.GetModTypesForModIDs(Database.Mods, Settings.GetCustomListByName(categoryId).ModIds).ToArray());
            }
            else
            {
                foreach (string modType in Database.Mods.AllModTypesForCategoryId(categoryId))
                {
                    ComboBoxModType.Items.Add(modType);
                }
            }

            ComboBoxRegion.Items.Clear();
            ComboBoxRegion.Items.Add("ANY");

            if (categoryId.Equals("fvrt"))
            {
                ComboBoxRegion.Items.AddRange(Settings.GetRegionsForModIDs(Database.Mods, Settings.FavoritedIds).ToArray());
            }
            else if (isCustomList)
            {
                ComboBoxRegion.Items.AddRange(Settings.GetRegionsForModIDs(Database.Mods, Settings.GetCustomListByName(categoryId).ModIds).ToArray());
            }
            else
            {
                foreach (string categoryRegion in SelectedCategory.Regions)
                {
                    ComboBoxRegion.Items.Add(categoryRegion);
                }
            }

            foreach (var modItem in Database.Mods.GetModItems(categoryId, name, firmware, type, region, isCustomList).OrderBy(x => x.Name))
            {
                List<string> installFiles = new List<string>();

                if (modItem.DownloadFiles.Count > 1)
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
                    Settings.FavoritedIds.Contains(modItem.Id)
                    ? ImageExtensions.ResizeBitmap(Resources.filled_heart, 20, 20)
                    : ImageExtensions.ResizeBitmap(Resources.heart, 20, 20));

                gridView1.AddNewRow();
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModId, modItem.Id);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModName, modItem.Name);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModSystemType, modItem.Firmware);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModType, modItem.Type);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModRegion, modItem.Region);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModVersion, modItem.Version);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModCreator, modItem.Author);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModNoOfFiles, installFiles.Count() + (installFiles.Count() > 1 ? " Files" : " File"));
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModDownload, ImageExtensions.ResizeBitmap(Resources.install, 20, 20));
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, ColumnModInstall, ImageExtensions.ResizeBitmap(Resources.download_from_the_cloud, 20, 20));
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
        /// Save application settings on form closing event.
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Form loading event.
        /// </summary>
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            Text = $@"ModioX - {UpdateExtensions.CurrentVersionName}";

            ControlExtensions.SetValuesOnSubItems(MainMenu.Items.OfType<ToolStripMenuItem>().ToList());

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
                    DarkMessageBox.ShowInformation("It is important to read the information about this using tool before installing/uninstalling mods so that you don't have any issues. Go to Help Menu > More Information.", "First Time Use");
                }

                SetStatus("Initializing the application database...");
                await Task.Run(async () => await LoadData());
                InitializeFinished();
            }
            else
            {
                DarkMessageBox.ShowError("You must be connected to the Internet to use this application.", "No Internet");
                Application.Exit();
            }
        }

        /// <summary>
        /// Update scrollbars when the form is resized.
        /// </summary>
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            UpdateScrollBarCategories();
            UpdateScrollBarDetails();
        }

        private void MenuItemApplications_Click(object sender, EventArgs e)
        {
            var menuItemText = ((ToolStripMenuItem)sender).Text;

            foreach (var application in Settings.ExternalApplications.Where(application => application.Name.Equals(menuItemText, StringComparison.OrdinalIgnoreCase)))
            {
                if (File.Exists(application.FileLocation))
                {
                    Process.Start(application.FileLocation);
                }
                else
                {
                    DarkMessageBox.ShowError($"Could not locate application: {application.Name} at location: {application.FileLocation}\n\nGo to Settings > Edit Applications and set the correct file path for this application.", "Application Not Found");
                }
            }
        }



        private async void MenuItemRefreshData_Click(object sender, EventArgs e)
        {
            SetStatus("Initializing application database...");

            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }

            SaveSettings();
            LoadSettings();

            await Task.Run(async () => await LoadData());
            InitializeFinished();
        }

        private void OfficailSourceButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(Urls.GitHubRepo);
        }

        private void OpenLogFileButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetStatus("Opening Log file...");
            var logFile = $"{UserFolders.AppLogsDirectory}latest.txt";
            if (File.Exists(logFile))
            {
                try
                {
                    Process.Start(logFile);
                }
                catch (Exception ex)
                {
                    SetStatus("Failed to open Log file...", ex);
                    DarkMessageBox.ShowError("Failed to open the log file.\nIt may have been deleted, that's ok.", "Failed to open log.");
                }
            }
            else
            {
                SetStatus("Failed to find Log file...");
                DarkMessageBox.ShowError("Failed to find the log file.\nIt may have been deleted, that's ok.", "Failed to find log.");
            }
        }

        private void OpenLogFolderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetStatus("Opening Log folder...");
            if (!Directory.Exists(UserFolders.AppLogsDirectory)) Directory.CreateDirectory(UserFolders.AppLogsDirectory);
            Process.Start(UserFolders.AppLogsDirectory);
        }

        private void PackageManagerButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowPackageManagerWindow(this);

        }

        private void PS3ConnectButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsConsoleConnected)
            {
                DisconnectConsole();
            }
            else
            {
                var consoleProfile = DialogExtensions.ShowConnectionDialog(this);

                if (consoleProfile != null)
                {
                    ConsoleProfile = consoleProfile;
                    ConnectConsole();
                }
            }
        }

        private void ReportBugButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Urls.GitHubRepo}issues/new");
        }

        private void RestartButtonBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsConsoleConnected)
            {
                WebManExtensions.Restart(ConsoleProfile.Address);
                DisconnectConsole();
            }
            else
            {

                XtraMessageBox.Show("No Connection Detected");
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

        /// <summary>
        /// Set the current connected console status in the tool strip.
        /// </summary>
        /// <param name="consoleProfile"></param>
        private void SetStatusConsole(ConsoleProfile consoleProfile)
        {
            ToolStripLabelConsole.Text = consoleProfile == null ? "Idle" : $"{consoleProfile.Name} ({consoleProfile.Address})";
        }

        private void Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogExtensions.ShowSettingsWindow(this);
            LoadSettings();
        }

        private void ShutDownButtonBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsConsoleConnected)
            {       
            WebManExtensions.Shutdown(ConsoleProfile.Address);
            DisconnectConsole();
            }
            else
            {
                XtraMessageBox.Show("No Connection Detected...");
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterModsName = TextBoxSearch.Text;

            LoadModsByCategoryId(SelectedCategory.Id,
                FilterModsName,
                FilterModsFirmware,
                FilterModsType,
                FilterModsRegion,
                IsCustomListSelected);
        }

        private void ToolItemUninstallAllGameMods_Click(object sender, EventArgs e)
        {
            if (IsConsoleConnected)
            {
                foreach (var installedGameMod in Settings.InstalledGameMods)
                {
                    var modItem = Database.Mods.GetModById(installedGameMod.ModId);

                    InstalledMod installedMod = Settings.GetInstalledGameMod(modItem.GameId);
                    UninstallMods(modItem, installedMod == null ? string.Empty : installedMod.Region);
                }
            }
        }

        private void ToolsMenuBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ToolStripDownloadArchive_Click(object sender, EventArgs e)
        {
            DownloadModArchive(SelectedModItem);
        }

        private void ToolStripFavorite_Click(object sender, EventArgs e)
        {
            AddModToFavorites(SelectedModItem);
        }

        private void ToolStripInstallFiles_Click(object sender, EventArgs e)
        {
            InstallMods(SelectedModItem);
        }

        private void ToolStripUninstallFiles_Click(object sender, EventArgs e)
        {
            var categoryType = SelectedModItem.GetCategoryType(Database.CategoriesData);

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

        /// <summary>
        /// Updates the category titles to the selected/non-selected colors.
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
        /// Update the categories scrollbar properties.
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
        /// Update the mods details scrollbar properties.
        /// </summary>
        private void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        private void WhatsNewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetStatus("Showing latest Changelog...");
            DialogExtensions.ShowWhatsNewWindow(this, UpdateExtensions.GitHubData);
        }

        /// <summary>
        /// Get/set the firmware for filtering mods.
        /// </summary>
        private string FilterModsFirmware { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the name for filtering mods.
        /// </summary>
        private string FilterModsName { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the region for filtering mods.
        /// </summary>
        private string FilterModsRegion { get; set; } = string.Empty;

        /// <summary>
        /// Get/set the type for filtering mods.
        /// </summary>
        private string FilterModsType { get; set; } = string.Empty;

        /// <summary>
        /// Get/set whether a custom list is selected by the user.
        /// </summary>
        private static bool IsCustomListSelected { get; set; } = false;

        /// <summary>
        /// Get/set the selected game data selected by the user.
        /// </summary>
        private static Category SelectedCategory { get; set; }

        /// <summary>
        /// Get/set the selected mods info selected by the user.
        /// </summary>
        private static ModItem SelectedModItem { get; set; }

        /// <summary>
        /// Attempt to connect to the console profile by opening the FTP connections.
        /// </summary>
        public void ConnectConsole()
        {
            try
            {
                SetStatus($"Connecting to {ConsoleProfile.Name} ({ConsoleProfile.Address})...");

                using (var ftpConnection = FtpConnection)
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

                IsConsoleConnected = true;
                SetStatusConsole(ConsoleProfile);

                IsWebManInstalled = WebManExtensions.IsWebManInstalled(ConsoleProfile.Address, ConsoleProfile.Port);

                if (IsWebManInstalled)
                {
                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, "You are now connected to ModioX ★");
                }

                PS3ConnectButton.Caption = "Disconnect from console...";
                SetStatus($"Successfully connected to console.");

                EnableConsoleActions();
                LoadInstalledGameMods();

                DarkMessageBox.ShowInformation("Successfully connected to console.", "Success");
            }
            catch (Exception ex)
            {
                SetStatus($"Can't connect to {ConsoleProfile.Name} ({ConsoleProfile.Address}).", ex);
                DarkMessageBox.ShowError($"Can't connect to {ConsoleProfile.Name} ({ConsoleProfile.Address})\n\nError: {ex.Message}", "Connection Failed");
            }
        }

        /// <summary>
        /// Install the specified <paramref name="modItem"/> files.
        /// </summary>
        /// <param name="modItem">The <see cref="ModsData.ModItem"/> to install.<param>
        public void InstallMods(ModItem modItem)
        {
            var category = Database.CategoriesData.GetCategoryById(modItem.GameId);
            var categoryTitle = category.Title;

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Preparing to install files...");

            // Check whether this mod is already installed
            var installedGameMod = Settings.InstalledGameMods.FirstOrDefault(gameMod =>
                gameMod.CategoryId.Equals(modItem.GameId, StringComparison.OrdinalIgnoreCase) &&
                gameMod.ModId.Equals(modItem.Id));
            if (installedGameMod != null)
            {
                var message = new StringBuilder("You have already installed ")
                    .AppendLine($"'{modItem.Name} v{modItem.Version}' to '{category.Title}'")
                    .Append("Do you want to reinstall the files again?");

                if (DarkMessageBox.ShowQuestion(message.ToString(), "Files Already Installed", DarkDialogButton.YesNo) == DialogResult.No)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                    return;
                }
            }

            // Checks whether a mod is already installed to the same game then uninstall it
            var modInstalled = Settings.GetInstalledGameMod(category.Id);

            if (modInstalled != null)
            {
                var currentModItem = Database.Mods.GetModById(modInstalled.ModId);

                var message = new StringBuilder($"'{currentModItem.Name} v{currentModItem.Version} ({currentModItem.Type})'")
                    .AppendLine($" is currently installed to: {category.Title}\n")
                    .Append("Previous mods could conflict with each other. Do you want to uninstall the current one?");

                if (DarkMessageBox.ShowQuestion(message.ToString(), "Mods Already Installed", DarkDialogButton.YesNo) == DialogResult.Yes)
                {
                    UninstallMods(Database.Mods.GetModById(modInstalled.ModId), modInstalled.Region);
                }
            }

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting archive download link...");
            var downloadFiles = modItem.GetDownloadFiles();

            if (downloadFiles == null)
            {
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No archive download selected. Installation cancelled.");
                return;
            }

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found archive download link.");

            // Check whether mods are being installed to the firmware folder and let the user know if they want to cancel
            if (downloadFiles.InstallsToRebugFolder)
            {
                var message = new StringBuilder("Files are being installed to the firmware folder (dev_rebug),")
                        .AppendLine(" which is for REBUG Custom Firmware only.")
                        .Append("It's recommended to create a backup of the entire")
                        .AppendLine(" folder before installing any files.")
                        .Append("Also, please ensure that you're running Rebug custom firmware ")
                        .AppendLine("and that the REBUG TOOLBOX application is open before proceeding.")
                        .Append("Any missing or incorrect files in this folder ")
                        .AppendLine("can impact your console performance.")
                        .Append("If you have issues after rebooting console then enter ")
                        .AppendLine("recovery mode and reinstall your custom firmware.\n")
                        .AppendLine("Only continue at your own risk and only if you know what you're doing.\n")
                        .Append("Do you still want to install the files?");

                if (DarkMessageBox.ShowExclamation(message.ToString(), "Important Message", DarkDialogButton.YesNo) == DialogResult.No)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                    return;
                }
            }

            try
            {
                // Check whether a game region must be provided to install
                string gameRegion;
                if (downloadFiles.RequiresGameRegion)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching region...");

                    gameRegion = category.GetGameRegion(modItem.GameId);
                    categoryTitle = $"{category.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No region selected. Installation cancelled.");
                        return;
                    }

                    if (!modItem.IsAnyRegion && !modItem.Region.Equals(gameRegion))
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Region isn't supported. Installation cancelled.");
                        return;
                    }

                    if (Settings.RememberGameRegions)
                    {
                        Settings.UpdateGameRegion(modItem.GameId, gameRegion);
                    }

                    // Check whether the game update for this region exists
                    if (!FtpExtensions.GetFolderNames($"/dev_hdd0/game/").Contains(gameRegion))
                    {
                        DarkMessageBox.ShowWarning("Game update folder for this region cannot be found on your console.\nYou must install the correct update for this game or maybe you specified the wrong region.", "Can't Find Game Update");
                        return;
                    }

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region.");
                }
                else
                {
                    gameRegion = string.Empty;
                }

                // Check whether a user id must be provided and prompts the user to choose one
                string userId;
                if (downloadFiles.RequiresUserId)
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching user id...");

                    userId = FtpExtensions.GetUserId();
                    categoryTitle = $"{category.Title} ({userId})";

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No user id selected. Installation cancelled.");
                        return;
                    }

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found user id.");
                }
                else
                {
                    userId = string.Empty;
                }

                // If it's a game save then alert the user that a USB device must be connected to console.
                string usbDevice;
                if (downloadFiles.RequiresUsbDevice)
                {
                    if (modItem.IsGameSave)
                    {
                        if (DarkMessageBox.ShowAsterisk("Before installing this game save you must have completed the following steps:\n- Insert your USB device to any port on the console.\n- Install the Apollo Tool PKG from the Homebrew Packages category on your console to unlock, patch and resign save-game files directly on your PS3."
                                + "\nThis will only work if you have your USB device connected. Click 'Yes' if you have done this. Otherwise click 'No' and this game-save will not be installed.",
                                "Install Game Save to USB Device", DarkDialogButton.YesNo) ==
                            DialogResult.Yes)
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            categoryTitle = $"{category.Title} ({usbDevice})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device connected. Installation cancelled.");
                                return;
                            }

                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");
                        }
                        else
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installation cancelled.");
                            return;
                        }
                    }
                    else
                    {
                        if (DarkMessageBox.ShowInformation(
                                "One or more files needs to be installed at a USB device that is connected to your console. It could be required for the mods to work, such as a configuration or plugin file. I suggest you read the complete description for more details on this."
                                + "\nTo allow for these files to be installed, you must have a USB inserted before you continue. Would you like to proceed, click 'Yes' to continue. Otherwise click 'No' and all USB files will be ignored.",
                                "Install Files to USB", DarkDialogButton.YesNo) == DialogResult.Yes)
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");

                            usbDevice = FtpExtensions.GetUsbPath();
                            categoryTitle = $"{category.Title} ({gameRegion})";

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device connected. Installation cancelled.");
                                return;
                            }

                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");
                        }
                        else
                        {
                            usbDevice = string.Empty;
                        }
                    }
                }
                else
                {
                    usbDevice = string.Empty;
                }

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloading and extracting files archive...");
                modItem.DownloadInstallFiles(downloadFiles);
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Downloaded and extracted files archive.");

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count;

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Starting install...");

                foreach (string installFilePath in downloadFiles.InstallPaths)
                {
                    // Install folders
                    foreach (string localFolderPath in Directory.GetDirectories(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                    {
                        if (!Path.HasExtension(installFilePath))
                        {
                            if (installFilePath.Contains(localFolderPath.Replace(modItem.DownloadDataDirectory(downloadFiles), string.Empty).Replace(@"\", "/")))
                            {
                                if (!FtpClient.DirectoryExists(installFilePath))
                                {
                                    SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating folder: {installFilePath}");

                                    if (FtpExtensions.CreateDirectory(installFilePath))
                                    {
                                        SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created folder.");
                                    }
                                }
                            }
                        }
                    }

                    // Install files
                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                    {
                        string installFileName = Path.GetFileName(installFilePath);

                        string installPath = installFilePath
                            .Replace("{REGION}", gameRegion)
                            .Replace("{USERID}", userId)
                            .Replace("{USBDEV}", usbDevice);

                        string parentDirectoryPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                        // Create parent directory if it doesn't exist on the console
                        if (!FtpClient.DirectoryExists(parentDirectoryPath))
                        {
                            FtpExtensions.CreateDirectory(parentDirectoryPath);
                        }

                        /*if (installPath.Contains("dev_hdd0/tmp/"))
                        {
                            // Create all the parent directories in the /tmp folder
                            if (!FtpClient.DirectoryExists(installPathWithoutFileName))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating directories: {installPathWithoutFileName}");
                                FtpExtensions.CreateDirectories(installPathWithoutFileName);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created directories.");
                            }
                        }*/

                        // Check whether install file matches the specified install file
                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
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
                                    if (DarkMessageBox.ShowQuestion("Would you like to backup the current game file? This will be restored when you choose to uninstall.\n\nGame File Name: " +
                                        Path.GetFileName(installFilePath), "Backup File", DarkDialogButton.YesNo) == DialogResult.Yes)
                                    {
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Creating backup of file: {installFileName}...");
                                        Settings.CreateBackupFile(modItem, installFileName, installPath);
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully created backup file.");

                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                        FtpExtensions.UploadFile(localFilePath, installPath);
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");
                                        indexFiles++;
                                    }
                                    else
                                    {
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                        FtpExtensions.UploadFile(localFilePath, installPath);
                                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                        indexFiles++;
                                    }
                                }
                                // Install the local file, like SPRX or key files
                                else
                                {
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                    FtpExtensions.UploadFile(localFilePath, installPath);
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                    indexFiles++;
                                }
                            }
                            // Check whether file is installed to a USB device
                            else if (installFilePath.Contains("{USBDEV}"))
                            {
                                if (!string.IsNullOrEmpty(usbDevice))
                                {
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                    FtpExtensions.UploadFile(localFilePath, installPath);
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                    indexFiles++;
                                }
                            }
                            // Otherwise, install the file as normal
                            else
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentDirectoryPath}");
                                FtpExtensions.UploadFile(localFilePath, installPath);
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed file.");

                                indexFiles++;
                            }
                        }

                        if (category.CategoryType == CategoryType.Homebrew)
                        {
                            Settings.UpdateInstalledPackageFile(modItem.Id, installFileName, modItem.Version, downloadFiles);
                            SaveSettings();
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
                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{categoryTitle}\nInstalled: {modItem.Name} ({indexFiles - 1} files)");
                }

                // Log status
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed {indexFiles - 1} files.");
                DarkMessageBox.ShowInformation($"Successfully installed {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {categoryTitle}." : ".")}{(category.CategoryType == CategoryType.Game ? "\nReady to start game." : string.Empty)}", "Success");
            }
            catch (Exception ex)
            {
                SetStatus($"Error installing files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                DarkMessageBox.ShowError($"An error occurred installing files for {modItem.Name} (#{modItem.Id}). See menu 'HELP > Report Bug' to open an issue and attach the log.txt file, which will be found in the program's installation path, so it can be investigated." + "\nError Message: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Load all of the currently installed game mods
        /// </summary>
        public void LoadInstalledGameMods()
        {
            DgvGameModsInstalled.Rows.Clear();

            int totalFiles = 0;

            foreach (InstalledMod installedMod in Settings.InstalledGameMods)
            {
                var modCategory = Database.CategoriesData.GetCategoryById(installedMod.CategoryId);

                var modInstalled = Database.Mods.GetModById(installedMod.ModId);

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
        /// Load application settings from a json data file.
        /// </summary>
        public void LoadSettings()
        {
            try
            {
                SetStatus("Loading settings data...");

                if (File.Exists(UserFolders.AppSettingsFile))
                {
                    using StreamReader streamReader = new StreamReader(UserFolders.AppSettingsFile);
                    Settings = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                }
                else
                {
                    return;
                }

                SetStatus("Successfully loaded settings data.");

                if (Settings.ConsoleProfiles.Count < 1)
                {
                    Settings.ConsoleProfiles.Add(
                        new ConsoleProfile
                        {
                            Name = "Default Console",
                            Address = "192.168.0.42",
                            Port = 21,
                            Username = "anonymous",
                            Password = string.Empty,
                            UseDefaultCredentials = true
                        });
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
                MenuItemApplications.DropDownItems.Clear();//TODO: MUST FIX!!!!

                foreach (ExternalApplication application in Settings.ExternalApplications)
                {
                    var menuItem = new ToolStripMenuItem(application.Name, null, MenuItemApplications_Click);
                    ApplicationsMenu.DropDownItems.Add(menuItem);
                }
            }
            catch (Exception ex)
            {
                SetStatus("Unable to load settings data. A new settings file will be created to fix this. Error: " + ex.Message, ex);
                Settings = new SettingsData();
                SaveSettings();
                Application.Restart();
            }
        }

        /// <summary>
        /// Save application settings to a json data file.
        /// </summary>
        public void SaveSettings()
        {
            try
            {
                SetStatus("Saving settings data...");

                if (!Directory.Exists(UserFolders.AppDataDirectory))
                {
                    _ = Directory.CreateDirectory(UserFolders.AppDataDirectory);
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
        /// Set the current process status in the tool strip.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            ToolStripLabelStatus.Text = status;
            //Refresh();

            switch (ex)
            {
                case null:
                    Program.Log.Info(status);
                    break;
                default:
                    Program.Log.Error(ex, status);
                    break;
            }
        }

        /// <summary>
        /// Uninstall all of the files for the <paramref name="modItem" />.
        /// </summary>
        /// <param name="modItem">Mod details from the <see cref="ModsData.ModItem" /></param>
        /// <param name="region">Game region</param>
        public void UninstallMods(ModItem modItem, string region = "")
        {
            var category = Database.CategoriesData.GetCategoryById(modItem.GameId);
            var categoryTitle = category.Title;

            string gameRegion;
            string userId;
            string usbDevice;

            DownloadFiles downloadFiles;

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Preparing to uninstall files...");

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Getting previous install details...");

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
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No previous install found. Fetching download...");
                gameRegion = region;
                downloadFiles = modItem.GetDownloadFiles();
            }
            else
            {
                gameRegion = installedMod.Region;
                downloadFiles = installedMod.DownloadFiles;
            }

            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found previous install details.");

            // Alerts the user that uninstalling files from dev_rebug folders isn't allowed
            if (modItem.IsInstallToRebugFolder)
            {
                _ = DarkMessageBox.ShowWarning(
                    "You cannot uninstall files from the firmware folder. Any missing files could affect your console performance.",
                    "Not Allowed", DarkDialogButton.Ok);
                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Cancelled installation.");
                return;
            }

            try
            {
                // If a game region isn't provided already, then prompt the user to choose one
                if (!string.IsNullOrWhiteSpace(region))
                {
                    gameRegion = region;
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region: {gameRegion}");
                }

                // Check whether a game region needs to be provided if one hasn't been already
                if (downloadFiles.RequiresGameRegion && string.IsNullOrWhiteSpace(region))
                {
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching region...");
                    gameRegion = category.GetGameRegion(modItem.GameId);
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found region: {gameRegion}");

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No region selected. Cancelled installation.");
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
                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching user ID...");

                    userId = FtpExtensions.GetUserId();

                    if (string.IsNullOrEmpty(userId))
                    {
                        SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No user ID selected. Cancelled installation.");
                        return;
                    }

                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found user ID: {userId}");
                }
                else
                {
                    userId = string.Empty;
                }

                // If this mod requires a usb device to be connected to console, ask the user whether they want to continue with this
                if (downloadFiles.RequiresUsbDevice)
                {
                    // If this is a modded gamesave then inform the user they must remove the gamesave from their usb themselves
                    if (modItem.IsGameSave)
                    {
                        DarkMessageBox.ShowExclamation("You can't uninstall games saves. You must remove the game save folder from your USB device or use the XMB menu.", "Can't Uninstall");
                        return;
                    }
                    else
                    {
                        // Inform the user a USB device must be connected for the mods
                        if (DarkMessageBox.ShowQuestion(
                            "Some files may have been files to be installed to a USB device. You can either choose to uninstall them now or manually delete them yourself." +
                            "\n\nIf you would like to uninstall the files, then connect the same USB device to your console and click 'Yes' to continue." +
                            "\n\nIf you wouldn't like to uninstall the files from your USB device, then click 'No' and all of these files will be ignored.",
                            "Uninstall USB File", DarkDialogButton.YesNo) == DialogResult.Yes)
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Fetching USB device...");
                            usbDevice = FtpExtensions.GetUsbPath();
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Found USB device.");

                            if (string.IsNullOrEmpty(usbDevice))
                            {
                                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - No USB device found. Installation cancelled.");
                                return;
                            }
                        }
                        else
                        {
                            usbDevice = string.Empty;
                        }
                    }
                }
                else
                {
                    usbDevice = string.Empty;
                }

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling files...");

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
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Installing backup file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) to {installPathWithoutFileName})");
                                    FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                    SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully installed backup file.");
                                    indexFiles++;
                                }
                                else
                                {
                                    DarkMessageBox.ShowExclamation($"You have created a game file backup, but the file: {Path.GetFileName(installPath)} can't be found on your computer. " +
                                        $"If you have moved this file then navigate to Tools > Game Backup Files and set the local file again. If this file has been deleted, " +
                                        $"you should delete the game backup file data and re-backup the file again. For now, this file will be not be uninstalled to prevent any issues with missing game files for the game.",
                                        "No File Exists", DarkDialogButton.Ok);
                                }
                            }
                            else
                            {
                                DarkMessageBox.ShowExclamation($"There is no backup for file: {Path.GetFileName(installPath)} so it can't be uninstalled. This file will be ignored to prevent any issues with missing game files. To restore the file to original then you must reinstall the game update.",
                                    "No Game Backup File", DarkDialogButton.Ok);
                            }
                        }
                        else
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {installPathWithoutFileName}");
                            FtpExtensions.DeleteFile(FtpClient, installPath);
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled file.");
                            indexFiles++;
                        }
                    }
                }

                foreach (string installPath in downloadFiles.InstallPaths)
                {
                    if (!Path.HasExtension(installPath))
                    {
                        try
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleting folder: {installPath}");
                            FtpExtensions.DeleteDirectory(FtpClient, installPath);
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully deleted folder.");
                        }
                        catch (Exception ex)
                        {
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Unable to delete folder. Error: {ex.Message}", ex);
                        }
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
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Deleting folder: {installPath}");
                            FtpExtensions.DeleteDirectory(FtpClient, parentFolderPath);
                            SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully deleted folder.");
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
                    WebManExtensions.NotifyPopup(ConsoleProfile.Address, $"{categoryTitle}\nUninstalled: {modItem.Name} ({indexFiles - 1} files)");
                }

                SetStatus($"{categoryTitle}: {modItem.Name} v{modItem.Version} ({modItem.Type}) - Successfully uninstalled {indexFiles - 1} files.");
                DarkMessageBox.ShowExclamation($"Successfully uninstalled: {modItem.Name} ({indexFiles - 1} files){(category.CategoryType == CategoryType.Game ? $" for {categoryTitle}." : string.Empty)}", "Success");
            }
            catch (Exception ex)
            {
                SetStatus($"Error uninstalling files for {categoryTitle}: {modItem.Name} v{modItem.Version} (#{modItem.Id}) ({category.Id.ToUpper()}) - {ex.Message}", ex);
                DarkMessageBox.ShowError($"An error occurred uninstalling files for {modItem.Name} (#{modItem.Id}). See Help > Report Issue/Suggestions to submit an issue and attach the log.txt file, which will be found in the program's installation path, so that we can investigate this." + "\nError Message: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Contains the console profile data.
        /// </summary>
        public static ConsoleProfile ConsoleProfile { get; private set; }

        /// <summary>
        /// Contains the data for the mods and categories.
        /// </summary>
        public static DropboxData Database { get; private set; }

        /// <summary>
        /// Conntains the FtpClient for faster and more reliable functions.
        /// </summary>
        public static FtpClient FtpClient { get; private set; }

        /// <summary>
        /// Creates an FTP connection for use with uploading mods, not reliable for the built-in file manager.
        /// </summary>
        /// <returns></returns>
        public static FtpConnection FtpConnection
        {
            get
            {
                var ftpCredentials = ConsoleProfile.UseDefaultCredentials
                    ? new NetworkCredential("anonymous", "anonymous")
                    : new NetworkCredential(ConsoleProfile.Username, ConsoleProfile.Password);
                var ftpConnection = new FtpConnection(ConsoleProfile.Address, ConsoleProfile.Port, ftpCredentials.UserName, ftpCredentials.Password);
                ftpConnection.Open();
                ftpConnection.Login(ftpCredentials.UserName, ftpCredentials.Password);
                return ftpConnection;
            }
        }

        /// <summary>
        /// Determines whether the console is currently connected.
        /// </summary>
        public static bool IsConsoleConnected { get; private set; }

        /// <summary>
        /// Determines whether webMAN is installed on the console.
        /// </summary>
        public static bool IsWebManInstalled { get; private set; }

        /// <summary>
        /// Contains the users settings Database.
        /// </summary>
        public static SettingsData Settings { get; private set; } = new();

        /// <summary>
        /// Get/set the current instance of the MainWindow
        /// </summary>
        public static MainWindow Window { get; private set; }
    }
}