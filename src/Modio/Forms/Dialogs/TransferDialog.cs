using DevExpress.XtraEditors;
using FluentFTP;
using Humanizer;
using Modio.Database;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Models.Database;
using Modio.Models.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modio.Forms.Dialogs
{
    public partial class TransferDialog : XtraForm
    {
        public TransferDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings { get; set; } = MainWindow.Settings;

        public ConsoleProfile ConsoleProfile { get; set; }  = MainWindow.ConsoleProfile;

        public ResourceManager Language { get; set; } = MainWindow.ResourceLanguage;

        public TransferType TransferType { get; set; }

        public Category Category { get; set; }

        public ModItemData ModItem { get; set; }

        public PackageItemData PackageItem { get; set; }

        public GameSaveItemData GameSaveItem { get; set; }

        public string GameRegion { get; set; }

        public DownloadFiles DownloadFiles { get; set; }

        private void TransferDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString(TransferType.Humanize());

            ButtonOpenPath.Text = Language.GetString("LABEL_OPEN_PATH");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            if (TransferType is TransferType.InstallMods or TransferType.UninstallMods or TransferType.DownloadMods)
            {
                LabelModName.Text = $"{Category.Title}\n{ModItem.Name}".Replace("&", "&&");
            }
            else if (TransferType is TransferType.InstallPackage or TransferType.UninstallPackage or TransferType.DownloadPackage)
            {
                LabelModName.Text = $"{PackageItem.Category}\n{PackageItem.Name} ({PackageItem.Region})".Replace("&", "&&");
            }
            else if (TransferType is TransferType.InstallGameSave or TransferType.DownloadGameSave)
            {
                LabelModName.Text = $"{Category.Title}\n{GameSaveItem.Name}".Replace("&", "&&");
            }

            TransferFiles();
        }

        public async void TransferFiles()
        {
            switch (TransferType)
            {
                case TransferType.InstallMods:
                    await InstallMods(ModItem).ConfigureAwait(true);
                    break;
                case TransferType.UninstallMods:
                    await UninstallMods(ModItem, GameRegion).ConfigureAwait(true);
                    break;
                case TransferType.DownloadMods:
                    await DownloadMods(ModItem).ConfigureAwait(true);
                    break;
                case TransferType.InstallPackage:
                    await InstallPackageFile(PackageItem).ConfigureAwait(true);
                    break;
                case TransferType.UninstallPackage:
                    await UninstallPackageFile(PackageItem).ConfigureAwait(true);
                    break;
                case TransferType.DownloadPackage:
                    await DownloadPackageFile(PackageItem).ConfigureAwait(true);
                    break;
                case TransferType.InstallGameSave:
                    await InstallGameSave(GameSaveItem).ConfigureAwait(true);
                    break;
                case TransferType.DownloadGameSave:
                    await DownloadGameSave(GameSaveItem).ConfigureAwait(true);
                    break;
            }

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    ProgressBarStatus.Properties.Stopped = true;
                    ButtonCancel.Text = Language.GetString("LABEL_CLOSE");
                    ButtonCancel.Visible = true;
                    ButtonCancel.Focus();

                    ButtonOpenPath.Visible = !LocalPath.IsNullOrEmpty() && Directory.Exists(LocalPath) && IsSuccessful;
                }));
            }
            else
            {
                ProgressBarStatus.Properties.Stopped = true;
                ButtonCancel.Text = Language.GetString("LABEL_CLOSE");
                ButtonCancel.Visible = true;
                ButtonCancel.Focus();

                ButtonOpenPath.Visible = !LocalPath.IsNullOrEmpty() && Directory.Exists(LocalPath) && IsSuccessful;
            }
        }

        private DialogResult GetDialogResult(string caption, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return InvokeRequired
                ? (DialogResult)Invoke(new Func<DialogResult>(() => GetDialogResult(caption, title, buttons, icon)))
                : XtraMessageBox.Show(this, caption, title, buttons, icon);
        }

        private string LocalPath = string.Empty;

        private bool IsSuccessful = false;

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task InstallMods(ModItemData modItem)
        {
            await Task.Run(async () =>
            {
                UpdateStatus(Language.GetString("PREPARING_INSTALL"));

                UpdateStatus(Language.GetString("GETTING_DOWNLOAD_FILES"));

                DownloadFiles downloadFiles;

                if (DownloadFiles == null)
                {
                    downloadFiles = modItem.GetDownloadFiles(this);
                }
                else
                {
                    downloadFiles = DownloadFiles;
                }

                if (downloadFiles == null)
                {
                    UpdateStatus(string.Join(" ", Language.GetString("NO_DOWNLOAD_FILES_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                    return;
                }

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count;

                UpdateStatus(Language.GetString("DOWNLOADING_EXTRACTING_ARCHIVE"));
                modItem.DownloadInstallFiles(downloadFiles);

                if (Settings.InstallGameModsPluginsToUsbDevice)
                {
                    UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                    List<ListItem> localUsbDevices = UsbExtensions.GetUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        GetDialogResult(Language.GetString("INSERT_USB_DEVICE"), Language.GetString("NO_USB_DEVICES"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                        return;
                    }

                    ListItem selectedUsbDevice = DialogExtensions.ShowListViewDialog(this, Language.GetString("USB_DEVICES"), localUsbDevices);

                    if (selectedUsbDevice == null)
                    {
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICE_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                    }
                    else
                    {
                        string installPath = $@"{selectedUsbDevice.Value}Mods\{Category.Title.RemoveInvalidChars()}\{modItem.Name.RemoveInvalidChars()}\";
                        LocalPath = installPath;

                        try
                        {
                            Directory.CreateDirectory(installPath);

                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                // Install files
                                foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                {
                                    string localFileName = Path.GetFileName(localFilePath);

                                    string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                    // Check whether install file matches the specified install file
                                    if (installFilePath.EndsWith(localFileName))
                                    {
                                        UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{localFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}"));
                                        File.Copy(localFilePath, installPath + Path.GetFileName(localFilePath), true);
                                        UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                        indexFiles++;
                                    }
                                }
                            }

                            if (Settings.CleanUpLocalFilesAfterInstalling)
                            {
                                try
                                {
                                    UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                    Directory.Delete(modItem.DownloadDataDirectory(downloadFiles), true);
                                    File.Delete(modItem.ArchiveZipFile(downloadFiles));
                                }
                                catch { }
                            }

                            IsSuccessful = true;

                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (WebException ex)
                        {
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                    }

                    return;
                }

                // Check whether this mod is already installed
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItem.CategoryId, modItem.Id) != null;

                if (isInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("REINSTALL_FILES"), $"{modItem.Name} v{modItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                        return;
                    }
                }

                switch (ConsoleProfile.Platform)
                {
                    case Platform.PS3:
                        {
                            try
                            {
                                // Checks whether a mod is already installed and skip backing up game files
                                InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId) : null;

                                if (installedModInfo != null)
                                {
                                    ModItemData installedModItem = MainWindow.Database.GetModItem(installedModInfo.Platform, MainWindow.Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                                    if (GetDialogResult(string.Format(Language.GetString("ANOTHER_MOD_INSTALLED"), $"{installedModItem.Name} v{installedModItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        await UninstallMods(MainWindow.Database.GetModItem(installedModInfo.Platform, MainWindow.Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId), installedModInfo.DownloadFiles.Region);

                                        if (InvokeRequired)
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                LabelModName.Text = $"{Category.Title}\n{ModItem.Name}".Replace("&", "&&");
                                            }));
                                        }
                                        else
                                        {
                                            LabelModName.Text = $"{Category.Title}\n{ModItem.Name}".Replace("&", "&&");
                                        }
                                    }
                                }

                                if (downloadFiles.InstallsToRebugFolder)
                                {
                                    // Check whether mods are being installed to the firmware folder and let the user
                                    // know if they want to cancel

                                    if (GetDialogResult(Language.GetString("NOTICE_INSTALL_REBUG_FILES"), Language.GetString("IMPORTANT_MESSAGE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                    {
                                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                                        return;
                                    }
                                }
                                string gameRegion = string.Empty;
                                if (downloadFiles.RequiresGameRegion)
                                {
                                    // Check whether a game region must be provided to install

                                    UpdateStatus(Language.GetString("GETTING_GAME_REGION"));

                                    gameRegion = Category.GetGameRegion(this, modItem.CategoryId);

                                    if (string.IsNullOrEmpty(gameRegion))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NO_GAME_REGION_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                                        return;
                                    }

                                    if (modItem.IsAnyRegion && !Category.Regions.Any(x => x.EqualsIgnoreCase(gameRegion)))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NOT_SUPPORTED_GAME_REGION"), Language.GetString("INSTALL_CANCELED")));
                                        return;
                                    }

                                    // Check whether the game update for this region exists
                                    if (!FtpExtensions.GetFolderNames("/dev_hdd0/game/").Any(x => x.Name.ContainsIgnoreCase(gameRegion)))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NO_GAME_REGION_FOUND"), Language.GetString("INSTALL_CANCELED")));
                                        GetDialogResult(Language.GetString("NO_GAME_REGION_FOLDER_FOUND"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }

                                    switch (Settings.RememberGameRegions)
                                    {
                                        case true:
                                            Settings.UpdateGameRegion(modItem.CategoryId, gameRegion);
                                            break;
                                    }

                                    UpdateStatus(string.Format(Language.GetString("FOUND_GAME_REGION"), gameRegion));
                                }
                                else
                                {
                                    gameRegion = string.Empty;
                                }

                                string userId = string.Empty;
                                if (downloadFiles.RequiresUserId)
                                {
                                    // Check whether a user id must be provided and prompts the user to choose one

                                    UpdateStatus(Language.GetString("GETTING_USER_PROFILE"));

                                    userId = FtpExtensions.GetUserProfileId(this);

                                    if (string.IsNullOrEmpty(userId))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NO_USER_PROFILE_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                                        return;
                                    }

                                    UpdateStatus(string.Format(Language.GetString("FOUND_USER_PROFILE"), userId));
                                }
                                else
                                {
                                    userId = string.Empty;
                                }

                                string usbDevice = string.Empty;

                                // If it's a game save then alert the user that a USB device must be connected to console.
                                if (downloadFiles.RequiresUsbDevice)
                                {
                                    if (GetDialogResult(Language.GetString("INSERT_USB_DEVICE_TO_CONSOLE"), Language.GetString("INSTALL_FILES_TO_USB_DEVICE"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                    {
                                        UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                                        usbDevice = FtpExtensions.GetUsbPath();

                                        if (string.IsNullOrEmpty(usbDevice))
                                        {
                                            UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                                            return;
                                        }

                                        UpdateStatus(string.Format(Language.GetString("FOUND_USB_DEVICE"), usbDevice));
                                    }
                                    else
                                    {
                                        usbDevice = string.Empty;
                                    }
                                }
                                else
                                {
                                    usbDevice = string.Empty;
                                }

                                UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                bool askedToBackupFiles = false;
                                bool shouldBackupFiles = false;

                                bool backupGameFiles = Settings.AlwaysBackupGameFiles;

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                    {
                                        string installFileName = Path.GetFileName(localFilePath);

                                        string installPath = installFilePath
                                        .Replace("{REGION}", gameRegion)
                                        .Replace("{USERID}", userId)
                                        .Replace("{USBDEV}", usbDevice);

                                        string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                        // Check whether install file matches the specified install file
                                        if (installPath.EndsWith(installFileName))
                                        {
                                            // Check whether this file is installed to a game folder
                                            if (installPath.Contains("dev_hdd0/game/"))
                                            {
                                                // Get the backup details for this game file if one has been created
                                                BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(ConsoleProfile.Platform, modItem.CategoryId, installFileName, installPath);

                                                if (backupFile == null)
                                                {
                                                    if (Settings.AlwaysBackupGameFiles)
                                                    {
                                                        shouldBackupFiles = true;

                                                        MainWindow.BackupFiles.UpdateBackupFile(MainWindow.BackupFiles.BackupFiles.IndexOf(backupFile), backupFile);
                                                    }
                                                    else
                                                    {
                                                        // Alert the user there is no backup for this file and ask the if one should be created
                                                        if (!askedToBackupFiles)
                                                        {
                                                            if (GetDialogResult(Language.GetString("BACKUP_GAME_FILES"), Language.GetString("BACKUP_FILES"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                            {
                                                                askedToBackupFiles = true;
                                                                shouldBackupFiles = true;
                                                            }
                                                            else
                                                            {
                                                                askedToBackupFiles = true;
                                                                shouldBackupFiles = false;
                                                            }
                                                        }
                                                    }                                                    
                                                }

                                                if (shouldBackupFiles)
                                                {
                                                    if (backupFile == null)
                                                    {
                                                        UpdateStatus(string.Format(Language.GetString("FILE_BACKUP_CREATING"), installFileName));
                                                        MainWindow.BackupFiles.CreateBackupFile(ModItem, installFileName, installPath);
                                                        UpdateStatus(Language.GetString("FILE_BACKUP_CREATED"));
                                                    }
                                                    else
                                                    {
                                                        if (!File.Exists(backupFile.LocalPath))
                                                        {
                                                            UpdateStatus(string.Format(Language.GetString("FILE_BACKUP_CREATING"), installFileName));
                                                            MainWindow.FtpClient.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);

                                                            backupFile.LocalPath = Path.Combine(MainWindow.BackupFiles.GetGameBackupFolder(modItem), installFileName);
                                                            backupFile.InstallPath = installPath;

                                                            UpdateStatus(Language.GetString("FILE_BACKUP_CREATED"));
                                                        }

                                                        MainWindow.BackupFiles.UpdateBackupFile(MainWindow.BackupFiles.BackupFiles.IndexOf(backupFile), backupFile);
                                                    }
                                                }

                                                UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                FtpExtensions.UploadFile(localFilePath, installPath);
                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                indexFiles++;
                                            }
                                            // Check whether file is installed to a USB device
                                            else if (installFilePath.Contains("{USBDEV}"))
                                            {
                                                if (!string.IsNullOrEmpty(usbDevice))
                                                {
                                                    UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                    FtpExtensions.UploadFile(localFilePath, installPath);
                                                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                    indexFiles++;
                                                }
                                            }
                                            else
                                            {
                                                UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                FtpExtensions.UploadFile(localFilePath, installPath);
                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                indexFiles++;
                                            }
                                        }
                                    }
                                }

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(modItem.DownloadDataDirectory(downloadFiles), true);
                                        File.Delete(modItem.ArchiveZipFile(downloadFiles));
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (FtpCommandException ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                        }

                        break;
                    case Platform.XBOX360:
                        {
                            try
                            {
                                UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                    {
                                        string installFileName = Path.GetFileName(installFilePath);

                                        string installPath = installFilePath
                                        .Replace("{CATEGORYID}", modItem.CategoryId.ToUpper());

                                        string parentFolderPath = Path.GetDirectoryName(installFilePath) + @"\";

                                        // Check whether install file matches the specified install file
                                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                                        {
                                            UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                            MainWindow.XboxConsole.MakeDirectory(@"Hdd:\Modio\");
                                            MainWindow.XboxConsole.MakeDirectory(@"Hdd:\Modio\" + modItem.CategoryId.ToUpper() + @"\");
                                            MainWindow.XboxConsole.SendFile(localFilePath, installPath);
                                            UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                            indexFiles++;
                                        }
                                    }
                                }

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(modItem.DownloadDataDirectory(downloadFiles), true);
                                        File.Delete(modItem.ArchiveZipFile(downloadFiles));
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                // Update installed mods
                                Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                // Log status
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }

                            break;
                        }
                }
            });
        }

        /// <summary>
        /// Uninstall all of the files for the <paramref name="ModItem" />.
        /// </summary>
        /// <param name="modItem"> <see cref="ModsData.ModItem" /> </param>
        /// <param name="region"> Game Region, if it's been installed before. </param>
        public async Task UninstallMods(ModItemData modItem, string region = "")
        {
            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        LabelModName.Text = $"{Category.Title}\n{modItem.Name}".Replace("&", "&&");
                    }));
                }
                else
                {
                    LabelModName.Text = $"{Category.Title}\n{modItem.Name}".Replace("&", "&&");
                }

                DownloadFiles downloadFiles;

                UpdateStatus(Language.GetString("GETTING_PREVIOUS_INSTALL"));

                InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, modItem.CategoryId, modItem.Id) : null;

                string gameRegion;
                string userId;
                string usbDevice;

                bool isFilesInstalledToUsb;

                if (installedModInfo == null)
                {
                    // Can't find the previous install details
                    UpdateStatus(string.Join(" ", Language.GetString("NO_PREVIOUS_INSTALL_FOUND"), Language.GetString("GETTING_DOWNLOAD_FILES")));
                    downloadFiles = modItem.GetDownloadFiles(this);
                    gameRegion = region;
                    isFilesInstalledToUsb = false;
                }
                else
                {
                    downloadFiles = installedModInfo.DownloadFiles;
                    gameRegion = installedModInfo.DownloadFiles.Region;
                    isFilesInstalledToUsb = FtpExtensions.UsbPorts.Any(x => downloadFiles.InstallPaths.Any(y => y.Contains(x)));
                    UpdateStatus(Language.GetString("FOUND_PREVIOUS_INSTALL"));
                }

                switch (ConsoleProfile.Platform)
                {
                    case Platform.PS3:
                        try
                        {
                            switch (downloadFiles.InstallsToRebugFolder)
                            {
                                // Alerts the user that uninstalling files from dev_rebug folders isn't allowed
                                case true:
                                    GetDialogResult(Language.GetString("CANT_UNINSTALL_CFW_FILES"), Language.GetString("FORBIDDEN"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    Language.GetString("INSTALL_CANCELED");
                                    return;
                            }

                            if (!string.IsNullOrEmpty(region))
                            {
                                // If a game region isn't provided already, then prompt the user to choose one
                                gameRegion = region;
                                UpdateStatus(string.Format(Language.GetString("FOUND_GAME_REGION"), gameRegion));
                            }

                            // Check whether a game region needs to be provided if one hasn't been already
                            if (downloadFiles.RequiresGameRegion && string.IsNullOrEmpty(region))
                            {
                                UpdateStatus(Language.GetString("GETTING_GAME_REGION"));
                                gameRegion = Category.GetGameRegion(this, modItem.CategoryId);

                                if (string.IsNullOrEmpty(gameRegion))
                                {
                                    UpdateStatus(string.Join(" ", Language.GetString("NO_GAME_REGION_SELECTED"), Language.GetString("UNINSTALL_CANCELED")));
                                    return;
                                }

                                UpdateStatus(string.Format(Language.GetString("FOUND_GAME_REGION"), gameRegion));

                                if (Settings.RememberGameRegions)
                                {
                                    Settings.UpdateGameRegion(modItem.CategoryId, gameRegion);
                                }
                            }

                            // Whether or not a UserId is required and prompt the user to choose one
                            if (downloadFiles.RequiresUserId)
                            {
                                UpdateStatus(Language.GetString("GETTING_USER_PROFILE"));
                                userId = FtpExtensions.GetUserProfileId(this);

                                if (string.IsNullOrEmpty(userId))
                                {
                                    UpdateStatus(string.Join(" ", Language.GetString("NO_USER_PROFILE_SELECTED"), Language.GetString("UNINSTALL_CANCELED")));
                                    return;
                                }

                                UpdateStatus(string.Format(Language.GetString("FOUND_USER_PROFILE"), userId));
                            }
                            else
                            {
                                userId = string.Empty;
                            }

                            bool shouldUninstallUsbFiles = false;

                            // Whether or not a USB device is required and prompt the user to insert the same one
                            if (downloadFiles.RequiresUsbDevice)
                            {
                                UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                                if (isFilesInstalledToUsb)
                                {
                                    usbDevice = FtpExtensions.UsbPorts.Where(x => downloadFiles.InstallPaths.Contains(x)).First();

                                    if (GetDialogResult(Language.GetString("REQUIRES_PREVIOUS_USB_DEVICE"), Language.GetString("UNINSTALL_USB_FILES"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        shouldUninstallUsbFiles = true;
                                    }
                                    else
                                    {
                                        usbDevice = string.Empty;
                                        shouldUninstallUsbFiles = false;
                                    }
                                }
                                else if (GetDialogResult(Language.GetString("REQUIRES_PREVIOUS_USB_DEVICE"), Language.GetString("UNINSTALL_USB_FILES"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    usbDevice = FtpExtensions.GetUsbPath();

                                    if (string.IsNullOrEmpty(usbDevice))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICE_FOUND"), Language.GetString("UNINSTALL_CANCELED")));
                                        return;
                                    }

                                    UpdateStatus(Language.GetString("FOUND_USB_DEVICE"));

                                    shouldUninstallUsbFiles = true;
                                }
                                else
                                {
                                    usbDevice = string.Empty;
                                    shouldUninstallUsbFiles = false;
                                }
                            }
                            else
                            {
                                usbDevice = string.Empty;
                            }

                            UpdateStatus(Language.GetString("UNFILE_INSTALL_LOCATIONS"));

                            int indexFiles = 1;
                            int totalFiles = downloadFiles.InstallPaths.Count;

                            // Loop through the install file paths
                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                // Format install file path with specified info: region/userId/USB
                                string installPath = installFilePath
                                .Replace("{REGION}", $"{gameRegion}")
                                .Replace("{USERID}", $"{userId}")
                                .Replace("{USBDEV}", $"{usbDevice}");

                                string parentFolderPath = Path.GetDirectoryName(installFilePath).Replace(@"\", "/");

                                // Uninstall files
                                if (Path.HasExtension(installPath))
                                {
                                    // Check whether file is being installed to game update folder
                                    if (installPath.Contains("dev_hdd0/game/"))
                                    {
                                        // Get the backup details for this game file if one has been created
                                        BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(ConsoleProfile.Platform, modItem.CategoryId, Path.GetFileName(installPath), installPath);

                                        // Check whether a backup has been created for this game file
                                        if (backupFile != null)
                                        {
                                            // Check whether the backup file exists on users computer
                                            if (File.Exists(backupFile.LocalPath))
                                            {
                                                // Install the backup file to the original game file path
                                                UpdateStatus(string.Format(Language.GetString("INSTALLING_BACKUP_FILE_LOCATION"), $"{Path.GetFileName(installPath)} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                                                indexFiles++;
                                            }
                                            else
                                            {
                                                GetDialogResult(string.Format(Language.GetString("CANT_FIND_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                        else
                                        {
                                            GetDialogResult(string.Format(Language.GetString("NO_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                    }
                                    else if (installFilePath.Contains("{USBDEV}"))
                                    {
                                        if (shouldUninstallUsbFiles)
                                        {
                                            UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), $"{Path.GetFileName(installPath)} ({indexFiles}/{totalFiles})", parentFolderPath));
                                            FtpExtensions.DeleteFile(installPath);
                                            UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                                            indexFiles++;
                                        }
                                    }
                                    else
                                    {
                                        UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), $"{Path.GetFileName(installPath)} ({indexFiles}/{totalFiles})", parentFolderPath));
                                        FtpExtensions.DeleteFile(installPath);
                                        UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                                        indexFiles++;
                                    }
                                }
                            }

                            foreach (string installPath in downloadFiles.InstallPaths)
                            {
                                if (!Path.HasExtension(installPath))
                                {
                                    UpdateStatus(string.Format(Language.GetString("FOLDER_DELETING"), installPath));
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus(Language.GetString("FOLDER_DELETE_SUCCESS"));
                                }
                            }

                            // Delete empty folders from the /tmp folder
                            foreach (string installPath in downloadFiles.InstallPaths.Where(x => x.Contains("dev_hdd0/tmp/")))
                            {
                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                if (FtpExtensions.DirectoryExists(installPath) && FtpExtensions.IsDirectoryEmpty(installPath))
                                {
                                    UpdateStatus(string.Format(Language.GetString("FOLDER_DELETING"), installPath));
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus(Language.GetString("FOLDER_DELETE_SUCCESS"));
                                }
                            }

                            Settings.RemoveInstalledMods(ConsoleProfile, Category.Id, modItem.Id);

                            if (MainWindow.IsWebManInstalled)
                            {
                                WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nUninstalled: {downloadFiles.Name} ({indexFiles - 1} files)");
                            }

                            IsSuccessful = true;

                            UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_ERROR"), ex.Message), ex);
                        }

                        break;
                    case Platform.XBOX360:
                        try
                        {
                            UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                            int indexFiles = 1;
                            int totalFiles = downloadFiles.InstallPaths.Count;

                            // Loop through the install file paths
                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                string parentDirectoryPath = Path.GetDirectoryName(installFilePath).Replace(@"\", "/") + "/";

                                // Uninstall files
                                if (Path.HasExtension(installFilePath))
                                {
                                    // Check whether file is being installed to game update folder
                                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), $"{Path.GetFileName(installFilePath)} ({indexFiles}/{totalFiles})", parentDirectoryPath));
                                    MainWindow.XboxConsole.DeleteFile(installFilePath);
                                    UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                                    indexFiles++;
                                }
                            }

                            IsSuccessful = true;

                            Settings.RemoveInstalledMods(ConsoleProfile, Category.Id, modItem.Id);

                            UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_ERROR"), ex.Message), ex);
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task DownloadMods(ModItemData modItem)
        {
            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                DownloadFiles downloadFiles;

                if (DownloadFiles == null)
                {
                    downloadFiles = modItem.GetDownloadFiles(this);
                }
                else
                {
                    downloadFiles = DownloadFiles;
                }

                if (downloadFiles == null)
                {
                    UpdateStatus(string.Join(" ", Language.GetString("NO_DOWNLOAD_FILES_SELECTED"), Language.GetString("DOWNLOAD_CANCELED")));
                    return;
                }

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING"));
                modItem.DownloadInstallFiles(downloadFiles);

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS"));

                LocalPath = Path.GetDirectoryName(modItem.ArchiveZipFile(downloadFiles));

                IsSuccessful = true;
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task InstallPackageFile(PackageItemData packageItem)
        {
            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_INSTALL"));

                // Check whether this mod is already installed
                bool isInstalled = Settings.GetInstalledPackage(packageItem) != null;

                if (isInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("FILE_REINSTALL"), $"{packageItem.Name} ({packageItem.Category})"), MainWindow.ResourceLanguage.GetString("REINSTALL_FILE"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        Language.GetString("INSTALL_CANCELED");
                        return;
                    }
                }

                try
                {
                    Directory.CreateDirectory($@"{IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages)}{PackageItem.Name.RemoveInvalidChars()}\");

                    string localFilePathPKG = $@"{IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages)}{PackageItem.Name.RemoveInvalidChars()}\{PackageItem.Name.RemoveInvalidChars()}.pkg";
                    string localFilePathRAP = $@"{IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages)}{PackageItem.Name.RemoveInvalidChars()}\{PackageItem.ContentId.RemoveInvalidChars()}.rap";

                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.Name + ".pkg", IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages) + PackageItem.Name.RemoveInvalidChars()));
                    HttpExtensions.DownloadFile(PackageItem.Url, localFilePathPKG);
                    Language.GetString("FILE_DOWNLOAD_SUCCESS");

                    bool includeRAP = false;

                    if (PackageItem.IsRapRequired && !PackageItem.IsRapMissing)
                    {
                        UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.ContentId + ".rap", IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages) + PackageItem.Name.RemoveInvalidChars()));
                        HttpExtensions.DownloadFile(PackageItem.RapUrl, localFilePathRAP);
                        Language.GetString("FILE_DOWNLOAD_SUCCESS");
                        includeRAP = true;
                    }

                    UpdateStatus(Language.GetString("STARTING_INSTALL"));

                    string parentInstallFolderPKG = Path.GetDirectoryName(packageItem.InstallFilePathPKG).Replace(@"\", "/");
                    string parentInstallFolderRAP = Path.GetDirectoryName(packageItem.InstallFilePathRAP).Replace(@"\", "/");

                    UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), packageItem.Name + ".pkg", parentInstallFolderPKG));
                    FtpExtensions.UploadFile(localFilePathPKG, packageItem.InstallFilePathPKG);
                    Language.GetString("FILE_INSTALL_SUCCESS");

                    if (includeRAP)
                    {
                        UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), packageItem.ContentId + ".rap", parentInstallFolderRAP));
                        FtpExtensions.UploadFile(localFilePathRAP, packageItem.InstallFilePathRAP);
                        Language.GetString("FILE_INSTALL_SUCCESS");
                    }

                    // Update installed packages
                    Settings.UpdateInstalledPackage(PackageItem, localFilePathPKG, DateTime.Now);

                    if (Settings.CleanUpLocalFilesAfterInstalling)
                    {
                        try
                        {
                            UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                            Directory.Delete($@"{IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages)}{PackageItem.Name.RemoveInvalidChars()}", true);
                        }
                        catch { }
                    }

                    IsSuccessful = true;

                    // Log status
                    Language.GetString("FILE_INSTALL_SUCCESS");
                }
                catch (WebException ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task UninstallPackageFile(PackageItemData packageItem)
        {
            await Task.Run(() =>
            {
                Language.GetString("PREPARING_UNINSTALL");

                // Check whether this mod is already installed
                bool isNotInstalled = Settings.GetInstalledPackage(packageItem) == null;

                if (isNotInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("MOD_NOT_INSTALLED"), $"{packageItem.Name} ({packageItem.Category})"), Language.GetString("NOT_INSTALLED"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        Language.GetString("UNINSTALL_CANCELED");
                        return;
                    }
                }

                try
                {
                    Language.GetString("FILES_UNINSTALLING");

                    string parentInstallFolder = Path.GetDirectoryName(packageItem.InstallFilePathPKG).Replace(@"\", "/");

                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), packageItem.Name + ".pkg", parentInstallFolder));
                    FtpExtensions.DeleteFile(packageItem.InstallFilePathPKG);
                    Language.GetString("FILE_UNINSTALL_SUCCESS");

                    IsSuccessful = true;

                    // Update installed packages
                    Settings.RemoveInstalledPackage(PackageItem);

                    // Log status
                    Language.GetString("FILE_UNINSTALL_SUCCESS");
                }
                catch (WebException ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="PackageItemData"/> files.
        /// </summary>
        //public async Task DownloadPackageFile(PackageItemData packageItem)
        public async Task DownloadPackageFile(PackageItemData packageItem)
        {
            await Task.Run(() =>
            {
                Language.GetString("PREPARING_DOWNLOAD");

                try
                {
                    string downloadFolder = IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathPackages);

                    if (!Directory.Exists(downloadFolder))
                    {
                        Directory.CreateDirectory(downloadFolder);
                    }

                    string downloadLocationPKG = downloadFolder + @"\" + packageItem.Name.RemoveInvalidChars() + ".pkg";
                    string downloadLocationRAP = downloadFolder + @"\" + packageItem.ContentId.RemoveInvalidChars() + ".rap";

                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.Name + ".rap", downloadFolder));
                    HttpExtensions.DownloadFile(packageItem.Url, downloadLocationPKG);
                    Language.GetString("FILE_DOWNLOAD_SUCCESS");

                    if (PackageItem.IsRapRequired && !PackageItem.IsRapMissing)
                    {
                        UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.ContentId + ".rap", downloadFolder));
                        HttpExtensions.DownloadFile(PackageItem.RapUrl, downloadLocationRAP);
                        Language.GetString("FILE_DOWNLOAD_SUCCESS");
                    }

                    LocalPath = downloadFolder;

                    IsSuccessful = true;
                }
                catch (WebException ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="GameSaveItemData"/> files.
        /// </summary>
        public async Task InstallGameSave(GameSaveItemData gameSaveItem)
        {
            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_INSTALL"));

                DownloadFiles downloadFiles = null;

                if (DownloadFiles == null)
                {
                    downloadFiles = gameSaveItem.DownloadFiles[0];
                }
                else
                {
                    downloadFiles = DownloadFiles;
                }

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count;

                Language.GetString("ARCHIVE_DOWNLOADING_EXTRACTING_ARCHIVE");
                gameSaveItem.DownloadInstallFiles(downloadFiles);
                Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS");

                if (Settings.InstallGameSavesToUsbDevice)
                {
                    UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                    List<ListItem> localUsbDevices = UsbExtensions.GetUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        GetDialogResult(Language.GetString("INSERT_USB_DEVICE"), Language.GetString("NO_USB_DEVICES"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                        return;
                    }

                    ListItem selectedUsbDevice = DialogExtensions.ShowListViewDialog(this, Language.GetString("USB_DEVICES"), localUsbDevices);
                    UpdateStatus(Language.GetString("FOUND_USB_DEVICE"));

                    if (selectedUsbDevice == null)
                    {
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_SELECTED_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                    }
                    else
                    {
                        string installPath = $@"{selectedUsbDevice.Value}Game Saves\{Category.Title.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}\";
                        LocalPath = installPath;

                        try
                        {
                            Directory.CreateDirectory(installPath);

                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                // Install files
                                foreach (string localFilePath in Directory.GetFiles(gameSaveItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                {
                                    string localFileName = Path.GetFileName(localFilePath);

                                    string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                    // Check whether install file matches the specified install file
                                    if (installFilePath.EndsWith(localFileName))
                                    {
                                        UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{localFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                        File.Copy(localFilePath, installPath + Path.GetFileName(localFilePath), true);
                                        UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                        indexFiles++;
                                    }
                                }
                            }

                            if (Settings.CleanUpLocalFilesAfterInstalling)
                            {
                                try
                                {
                                    UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                    Directory.Delete(gameSaveItem.DownloadDataDirectory(downloadFiles), true);
                                    File.Delete(gameSaveItem.ArchiveZipFile(downloadFiles));
                                }
                                catch { }
                            }

                            IsSuccessful = true;

                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (WebException ex)
                        {
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                    }

                    return;
                }

                switch (gameSaveItem.GetPlatform())
                {
                    case Platform.PS3:
                        {
                            try
                            {
                                string usbDevice;

                                if (downloadFiles.RequiresUsbDevice)
                                {
                                    if (GetDialogResult("Before installing this game save you must have completed the following steps:\n- Insert your USB device to any port on the console.\n- Install the Apollo Tool PKG from the Homebrew Packages category on your console to unlock, patch and resign save-game files directly on your PS3." + "\nThis will only work if you have your USB device connected. Click 'Yes' if you have done this. Otherwise click 'No' and this game-save will not be installed.", "Installing Game Saves", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                                        usbDevice = FtpExtensions.GetUsbPath();

                                        if (string.IsNullOrEmpty(usbDevice))
                                        {
                                            UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                                            return;
                                        }

                                        UpdateStatus(Language.GetString("FOUND_USB_DEVICE"));
                                    }
                                    else
                                    {
                                        Language.GetString("INSTALL_CANCELED");
                                        return;
                                    }
                                }
                                else
                                {
                                    usbDevice = string.Empty;
                                }

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(gameSaveItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                    {
                                        string localFileName = Path.GetFileName(localFilePath);

                                        string installPath = installFilePath
                                        .Replace("{USBDEV}", usbDevice);

                                        string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                        // Check whether install file matches the specified install file
                                        if (installPath.EndsWith(localFileName))
                                        {
                                            UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{localFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                            FtpExtensions.UploadFile(localFilePath, installPath);
                                            UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                            indexFiles++;
                                        }
                                    }
                                }

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(gameSaveItem.DownloadDataDirectory(downloadFiles), true);
                                        File.Delete(gameSaveItem.ArchiveZipFile(downloadFiles));
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (FtpCommandException ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                        }

                        break;
                    case Platform.XBOX360:
                        {
                            try
                            {
                                UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(gameSaveItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                    {
                                        string installFileName = Path.GetFileName(installFilePath);

                                        string parentFolderPath = Path.GetDirectoryName(installFilePath);

                                        // Check whether install file matches the specified install file
                                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                                        {
                                            UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                            MainWindow.XboxConsole.MakeDirectory(parentFolderPath);
                                            MainWindow.XboxConsole.SendFile(localFilePath, installFilePath);
                                            UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                            indexFiles++;
                                        }
                                    }
                                }

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(gameSaveItem.DownloadDataDirectory(downloadFiles), true);
                                        File.Delete(gameSaveItem.ArchiveZipFile(downloadFiles));
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                // Log status
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }

                            break;
                        }
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="PackageItemData"/> files.
        /// </summary>
        public async Task DownloadGameSave(GameSaveItemData gameSaveItem)
        {
            await Task.Run(() =>
            {
                try
                {
                    UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                    string downloadFolder = IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathGameSaves);

                    if (!Directory.Exists(downloadFolder))
                    {
                        UpdateStatus(Language.GetString("DOWNLOAD_FOLDER_NOT_FOUND"));
                        return;
                    }

                    string downloadLocation = downloadFolder + @"\" + gameSaveItem.Name.RemoveInvalidChars() + ".pkg";

                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), $"{gameSaveItem.Name}.pkg", downloadFolder));
                    HttpExtensions.DownloadFile(gameSaveItem.DownloadFiles[0].Url, downloadLocation);
                    UpdateStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));

                    LocalPath = downloadFolder;

                    IsSuccessful = true;
                }
                catch (WebException ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
            });
        }

        private void ButtonOpenPath_Click(object sender, EventArgs e)
        {
            Process.Start(LocalPath);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateStatus(string status, Exception ex = null)
        {
            if (LabelStatus.InvokeRequired)
            {
                LabelStatus.BeginInvoke((MethodInvoker)delegate
                {
                    LabelStatus.Text = status;
                });
            }
            else
            {
                LabelStatus.Text = status;
            }

            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(ex, status);
            }
        }
    }
}