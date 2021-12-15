using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Database;
using ModioX.Models.Resources;

namespace ModioX.Forms.Dialogs
{
    public partial class TransferDialog : XtraForm
    {
        public TransferDialog()
        {
            InitializeComponent();
        }

        public TransferType TransferType { get; set; }

        public Category Category { get; set; }

        public ModItemData ModItem { get; set; }

        public PackageItemData PackageItem { get; set; }

        public GameSaveItemData GameSaveItem { get; set; }

        public string GameRegion { get; set; }

        private void TransferDialog_Load(object sender, EventArgs e)
        {
            if (TransferType is TransferType.InstallMods or TransferType.UninstallMods or TransferType.DownloadMods)
            {
                LabelModName.Text = $"{ModItem.Name}\n{Category.Title}";
            }
            else if (TransferType is TransferType.InstallPackage or TransferType.UninstallPackage or TransferType.DownloadPackage)
            {
                LabelModName.Text = $"{PackageItem.Name} ({PackageItem.Region})\n{PackageItem.Category}";
            }
            else if (TransferType is TransferType.InstallGameSave or TransferType.DownloadGameSave)
            {
                LabelModName.Text = $"{GameSaveItem.Name}\n{Category.Title}";
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
                    ButtonCancel.Text = "Close";
                    ButtonCancel.Visible = true;
                    ButtonCancel.Focus();

                    ButtonOpenPath.Visible = !LocalPath.IsNullOrEmpty() && Directory.Exists(LocalPath) && IsSuccessful;
                }));
            }
            else
            {
                ProgressBarStatus.Properties.Stopped = true;
                ButtonCancel.Text = "Close";
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
                UpdateStatus($"Preparing to install files...");

                DownloadFiles downloadFiles;

                UpdateStatus($"Getting archive file download link...");
                downloadFiles = modItem.GetDownloadFiles(this);

                if (downloadFiles == null)
                {
                    UpdateStatus($"No archive file download selected. Installation cancelled.");
                    return;
                }

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count;

                UpdateStatus($"Found archive file download link.");

                UpdateStatus($"Downloading and extracting archive...");
                modItem.DownloadInstallFiles(downloadFiles);
                UpdateStatus($"Downloaded and extracted archive.");

                if (MainWindow.Settings.InstallModsToUsbDevice)
                {
                    UpdateStatus($"Fetching USB device...");

                    List<ListItem> localUsbDevices = UsbExtensions.GetUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        GetDialogResult($"You have enabled the option to install mods to your USB device but you don't have one connected to your computer.\nInsert a USB device first and install the mods again.", "No USB Devices", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus($"No USB device connected. Installation cancelled.");
                        return;
                    }

                    ListItem selectedUsbDevice = DialogExtensions.ShowListViewDialog(this, "USB Devices", localUsbDevices);
                    UpdateStatus($"Found USB device.");

                    if (selectedUsbDevice == null)
                    {
                        UpdateStatus($"No USB device selected. Installation cancelled.");
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
                                        UpdateStatus($"Installing file: {localFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                        File.Copy(localFilePath, installPath + Path.GetFileName(localFilePath), true);
                                        UpdateStatus($"Successfully installed file.");

                                        indexFiles++;
                                    }
                                }
                            }

                            IsSuccessful = true;

                            UpdateStatus($"Successfully installed {indexFiles - 1} files.");
                        }
                        catch (WebException ex)
                        {
                            UpdateStatus($"Error installing files. Error: {ex.Message}", ex);
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus($"Error installing files. Error: {ex.Message} Path: {installPath}", ex);
                        }
                    }

                    return;
                }

                // Check whether this mod is already installed
                bool isInstalled = MainWindow.Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id) != null;

                if (isInstalled)
                {
                    if (GetDialogResult($"{modItem.Name} v{modItem.Version} is already installed for: {Category.Title}\n\n" +
                        $"Would you like to reinstall the files again?", "Files Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus($"Installation cancelled.");
                        return;
                    }
                }

                switch (modItem.GetPlatform())
                {
                    case PlatformPrefix.PS3:
                        {
                            try
                            {
                                UpdateStatus($"Doing a few checks...");

                                // Checks whether a mod is already installed and skip backing up game files
                                InstalledModInfo installedModInfo = MainWindow.Settings.GetInstalledMods(modItem.GetPlatform(), Category.Id);

                                if (installedModInfo != null)
                                {
                                    ModItemData installedModItem = MainWindow.Database.ModsPS3.GetModById(installedModInfo.Platform, installedModInfo.ModId);

                                    StringBuilder message = new StringBuilder($"'{installedModItem.Name} v{installedModItem.Version}' is currently installed to: {Category.Title}\n")
                                            .Append("Having mulitple mods installed for the same game could cause issues.\n\nWould you like to uninstall the current files?");

                                    if (GetDialogResult(message.ToString(), "Files Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        await UninstallMods(MainWindow.Database.ModsPS3.GetModById(installedModInfo.Platform, installedModInfo.ModId), installedModInfo.DownloadFiles.Region);

                                        if (InvokeRequired)
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                LabelModName.Text = $"{ModItem.Name}\n{Category.Title}";
                                            }));
                                        }
                                        else
                                        {
                                            LabelModName.Text = $"{ModItem.Name}\n{Category.Title}";
                                        }
                                    }
                                }

                                if (downloadFiles.InstallsToRebugFolder)
                                {
                                    // Check whether mods are being installed to the firmware folder and let the user
                                    // know if they want to cancel
                                    StringBuilder message = new StringBuilder("Files are being installed to the firmware folder (dev_rebug), ")
                                                    .Append("which is for REBUG Custom Firmware only.")
                                                    .Append("It's recommended to first create a backup of the entire ")
                                                    .Append("folder before installing any files.")
                                                    .Append("Also ensure that you're console is using Rebug custom firmware ")
                                                    .Append("and that the REBUG TOOLBOX application is open before proceeding.")
                                                    .AppendLine("Any missing or incorrect files in this folder ")
                                                    .Append("can impact your console performance.")
                                                    .AppendLine("If you have issues after rebooting console then you must enter ")
                                                    .Append("recovery mode and reinstall your custom firmware. ")
                                                    .Append("Only continue at your own risk and only if you know what you're doing.\n")
                                                    .AppendLine("Do you want to continue?");

                                    if (GetDialogResult(message.ToString(), "Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                    {
                                        UpdateStatus($"Installation cancelled.");
                                        return;
                                    }
                                }
                                string gameRegion = string.Empty;
                                if (downloadFiles.RequiresGameRegion)
                                {
                                    // Check whether a game region must be provided to install

                                    UpdateStatus($"Fetching region...");

                                    gameRegion = Category.GetGameRegion(this, modItem.CategoryId);

                                    if (string.IsNullOrEmpty(gameRegion))
                                    {
                                        UpdateStatus($"No region selected. Installation cancelled.");
                                        return;
                                    }

                                    if (modItem.IsAnyRegion && !Category.Regions.Any(x => x.EqualsIgnoreCase(gameRegion)))
                                    {
                                        UpdateStatus($"Region isn't supported. Installation cancelled.");
                                        return;
                                    }

                                    // Check whether the game update for this region exists
                                    if (!FtpExtensions.GetFolderNames("/dev_hdd0/game/").Any(x => x.Name.ContainsIgnoreCase(gameRegion)))
                                    {
                                        UpdateStatus($"Game region cannot be found on console. Installation cancelled.");
                                        GetDialogResult("Game update folder for this region cannot be found on your console.\nYou must install the correct update for this game or maybe you specified the wrong region.",
                                            "Can't Find Game Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }

                                    switch (MainWindow.Settings.RememberGameRegions)
                                    {
                                        case true:
                                            MainWindow.Settings.UpdateGameRegion(modItem.CategoryId, gameRegion);
                                            break;
                                    }

                                    UpdateStatus($"Found region.");
                                }
                                else
                                {
                                    gameRegion = string.Empty;
                                }

                                string userId = string.Empty;
                                if (downloadFiles.RequiresUserId)
                                {
                                    // Check whether a user id must be provided and prompts the user to choose one

                                    UpdateStatus($"Fetching user id...");

                                    userId = FtpExtensions.GetUserProfileId(this);

                                    if (string.IsNullOrEmpty(userId))
                                    {
                                        UpdateStatus($"No user id selected. Installation cancelled.");
                                        return;
                                    }

                                    UpdateStatus($"Found user id.");
                                }
                                else
                                {
                                    userId = string.Empty;
                                }

                                string usbDevice = string.Empty;

                                // If it's a game save then alert the user that a USB device must be connected to console.
                                if (downloadFiles.RequiresUsbDevice)
                                {
                                    if (GetDialogResult("One or more files needs to be installed at a USB device that is connected to your console. It could be required for the mods to work, such as a configuration or plugin file. I suggest you read the complete description for more details on this." + "\nTo allow for these files to be installed, you must have a USB inserted before you continue. Would you like to proceed, click 'Yes' to continue. Otherwise click 'No' and all USB files will be ignored.", "Installing Files to USB", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                    {
                                        UpdateStatus($"Fetching USB device...");

                                        usbDevice = FtpExtensions.GetUsbPath();

                                        if (string.IsNullOrEmpty(usbDevice))
                                        {
                                            UpdateStatus($"No USB device connected. Installation cancelled.");
                                            return;
                                        }

                                        UpdateStatus($"Found USB device.");
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

                                UpdateStatus($"Starting install...");

                                bool askedToBackupFiles = false;
                                bool shouldBackupFiles = false;

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
                                                BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(modItem.GetPlatform(), modItem.CategoryId, installFileName, installPath);

                                                if (backupFile == null)
                                                {
                                                    // Alert the user there is no backup for this file and ask the if one should be created
                                                    if (!askedToBackupFiles)
                                                    {
                                                        if (GetDialogResult("Would you like to backup all of the current game files?\nThese will be restored when uninstalling the modded files.",
                                                            "Backup Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                                                if (shouldBackupFiles)
                                                {
                                                    UpdateStatus($"Creating backup of file: {installFileName}...");
                                                    MainWindow.BackupFiles.CreateBackupFile(ModItem, installFileName, installPath);
                                                    UpdateStatus($"Successfully created backup file.");
                                                }

                                                UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                                FtpExtensions.UploadFile(localFilePath, installPath);
                                                UpdateStatus($"Successfully installed file.");

                                                indexFiles++;
                                            }
                                            // Check whether file is installed to a USB device
                                            else if (installFilePath.Contains("{USBDEV}"))
                                            {
                                                if (!string.IsNullOrEmpty(usbDevice))
                                                {
                                                    UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                                    FtpExtensions.UploadFile(localFilePath, installPath);
                                                    UpdateStatus($"Successfully installed file.");

                                                    indexFiles++;
                                                }
                                            }
                                            else
                                            {
                                                UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                                FtpExtensions.UploadFile(localFilePath, installPath);
                                                UpdateStatus($"Successfully installed file.");

                                                indexFiles++;
                                            }
                                        }
                                    }
                                }

                                IsSuccessful = true;

                                MainWindow.Settings.UpdateInstalledMods(modItem.GetPlatform(), Category.Id, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                UpdateStatus($"Successfully installed {indexFiles - 1} files.{(Category.CategoryType == CategoryType.Game ? " Ready to start game." : string.Empty)}");
                            }
                            catch (FluentFTP.FtpCommandException ex)
                            {
                                UpdateStatus($"Unable to install files. Error Message: {ex.Message}", ex);
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus($"Unable to install files. Error Message: {ex.Message}", ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus($"Unable to install files. Error Message: {ex.Message}", ex);
                            }
                        }

                        break;
                    case PlatformPrefix.XBOX:
                        {
                            try
                            {
                                UpdateStatus($"Starting install...");

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                                    {
                                        string installFileName = Path.GetFileName(installFilePath);

                                        string installPath = installFilePath
                                        .Replace("{CATEGORYID}", modItem.CategoryId.ToUpper());

                                        string parentFolderPath = Path.GetDirectoryName(installFilePath) + @"\"; //.Replace(@"\", "/");
                                        Program.Log.Info("Parent Folder Path: " + parentFolderPath);
                                        Program.Log.Info("Install File Path: " + installFilePath);
                                        Program.Log.Info("Install File Path ID: " + installPath);
                                        Program.Log.Info("Install File Name: " + installFileName);
                                        Program.Log.Info("Local File Path: " + localFilePath);

                                        // Check whether install file matches the specified install file
                                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                                        {
                                            UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                            MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ModioX\");
                                            MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ModioX\" + modItem.CategoryId.ToUpper() + @"\");
                                            MainWindow.XboxConsole.SendFile(localFilePath, installPath);
                                            UpdateStatus($"Successfully installed file.");

                                            indexFiles++;
                                        }
                                    }
                                }

                                IsSuccessful = true;

                                // Update installed mods
                                MainWindow.Settings.UpdateInstalledMods(modItem.GetPlatform(), Category.Id, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                // Log status
                                UpdateStatus($"Successfully installed {indexFiles - 1} files. {(Category.CategoryType == CategoryType.Game ? "Ready to start game." : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus($"Error installing files. Error: {ex.Message}", ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus($"Error installing files. Error: {ex.Message}", ex);
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
                UpdateStatus($"Preparing to uninstall files...");

                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() =>
                    {
                        LabelModName.Text = $"{modItem.Name}\n{Category.Title}";
                    }));
                }
                else
                {
                    LabelModName.Text = $"{modItem.Name}\n{Category.Title}";
                }

                DownloadFiles downloadFiles;

                UpdateStatus($"Getting previous install details...");

                InstalledModInfo installedModInfo = MainWindow.Settings.GetInstalledMods(modItem.GetPlatform(), modItem.CategoryId, modItem.Id);

                string gameRegion;
                string userId;
                string usbDevice;

                bool isFilesInstalledToUsb;

                if (installedModInfo == null)
                {
                    // Can't find the previous install details
                    UpdateStatus($"No previous installation found. Fetching download files...");
                    downloadFiles = modItem.GetDownloadFiles(this);
                    gameRegion = region;
                    isFilesInstalledToUsb = false;
                }
                else
                {
                    downloadFiles = installedModInfo.DownloadFiles;
                    gameRegion = installedModInfo.DownloadFiles.Region;
                    isFilesInstalledToUsb = FtpExtensions.UsbPorts.Any(x => downloadFiles.InstallPaths.Any(y => y.Contains(x)));
                    UpdateStatus($"Found previous installation details.");
                }

                switch (modItem.GetPlatform())
                {
                    case PlatformPrefix.PS3:
                        try
                        {
                            UpdateStatus($"Doing a few checks...");

                            switch (downloadFiles.InstallsToRebugFolder)
                            {
                                // Alerts the user that uninstalling files from dev_rebug folders isn't allowed
                                case true:
                                    GetDialogResult("You cannot uninstall files from the firmware folder. Any missing files could affect your console performance.", "Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    UpdateStatus($"Installation cancelled.");
                                    return;
                            }

                            if (!string.IsNullOrEmpty(region))
                            {
                                // If a game region isn't provided already, then prompt the user to choose one
                                gameRegion = region;
                                UpdateStatus($"Found game region: {gameRegion}");
                            }

                            if (downloadFiles.RequiresGameRegion && string.IsNullOrEmpty(region))
                            {
                                // Check whether a game region needs to be provided if one hasn't been already
                                UpdateStatus($"Fetching game region...");
                                gameRegion = Category.GetGameRegion(this, modItem.CategoryId);

                                if (string.IsNullOrEmpty(gameRegion))
                                {
                                    UpdateStatus($"No region selected. Installation cancelled.");
                                    return;
                                }

                                UpdateStatus($"Found game region: {gameRegion}");

                                if (MainWindow.Settings.RememberGameRegions)
                                {
                                    MainWindow.Settings.UpdateGameRegion(modItem.CategoryId, gameRegion);
                                }
                            }

                            // Whether or not a UserId is required and prompt the user to choose one
                            if (downloadFiles.RequiresUserId)
                            {
                                UpdateStatus($"Fetching user profile...");
                                userId = FtpExtensions.GetUserProfileId(this);

                                if (string.IsNullOrEmpty(userId))
                                {
                                    UpdateStatus($"No user profile selected. Installation cancelled.");
                                    return;
                                }

                                UpdateStatus($"Found user profile: {userId}");
                            }
                            else
                            {
                                userId = string.Empty;
                            }

                            bool shouldUninstallUsbFiles = false;

                            // Whether or not a USB device is required and prompt the user to insert the same one
                            if (downloadFiles.RequiresUsbDevice)
                            {
                                UpdateStatus($"Fetching USB device...");

                                if (isFilesInstalledToUsb)
                                {
                                    usbDevice = FtpExtensions.UsbPorts.Where(x => downloadFiles.InstallPaths.Contains(x)).First();

                                    if (GetDialogResult($"One or more files have been installed to a USB device. You can either choose to uninstall them now or manually delete them yourself." +
                                    $"\n\nIf you would like to uninstall the files, then connect the same USB device into the same port ({usbDevice}) of your console and click 'Yes' to continue." +
                                    $"\n\nIf you don't like to uninstall these files, then click 'No' and all of these files will be ignored.", "Uninstall USB Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        shouldUninstallUsbFiles = true;
                                    }
                                    else
                                    {
                                        usbDevice = string.Empty;
                                        shouldUninstallUsbFiles = false;
                                    }
                                }
                                else if (GetDialogResult("Some files may have been installed to a USB device. You can either choose to uninstall them now or manually delete them yourself." +
                                    "\n\nIf you would like to uninstall the files, then connect the same USB device where the files was installed into the same port of your console and click 'Yes' to continue." +
                                    "\n\nIf you don't like to uninstall these files, then click 'No' and all of these files will be ignored.", "Uninstall USB Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    usbDevice = FtpExtensions.GetUsbPath();

                                    if (string.IsNullOrEmpty(usbDevice))
                                    {
                                        UpdateStatus($"No USB device found. Installation cancelled.");
                                        return;
                                    }

                                    UpdateStatus($"Found USB device.");

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

                            UpdateStatus($"Uninstalling files...");

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
                                        BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(modItem.GetPlatform(), modItem.CategoryId, Path.GetFileName(installPath), installPath);

                                        // Check whether a backup has been created for this game file
                                        if (backupFile != null)
                                        {
                                            // Check whether the backup file exists on users computer
                                            if (File.Exists(backupFile.LocalPath))
                                            {
                                                // Install the backup file to the original game file path
                                                UpdateStatus($"Installing backup file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                                FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                                UpdateStatus($"Successfully installed backup file.");
                                                indexFiles++;
                                            }
                                            else
                                            {
                                                GetDialogResult($"You have created a backup file for: {Path.GetFileName(installPath)}, but it's either missing or has been deleted.\n\n" +
                                                    $"If you moved this file then navigate to Tools > Game Backup Files and set the local file again. If this file has been deleted, you will need to delete the game backup file data and backup the file again.\n\n" +
                                                    "This file will be ignored to prevent issues with missing game files.", "No Backup File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                        else
                                        {
                                            GetDialogResult($"You don't have a backup for file: {Path.GetFileName(installPath)} so it can't be uninstalled. This file will be ignored to prevent issues with missing game files. You must reinstall the game update to restore the original file.", "No Backup File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                    }
                                    else if (installFilePath.Contains("{USBDEV}"))
                                    {
                                        if (shouldUninstallUsbFiles)
                                        {
                                            UpdateStatus($"Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {parentFolderPath}");
                                            FtpExtensions.DeleteFile(installPath);
                                            UpdateStatus($"Successfully uninstalled file.");
                                            indexFiles++;
                                        }
                                    }
                                    else
                                    {
                                        UpdateStatus($"Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {parentFolderPath}");
                                        FtpExtensions.DeleteFile(installPath);
                                        UpdateStatus($"Successfully uninstalled file.");
                                        indexFiles++;
                                    }
                                }
                            }

                            foreach (string installPath in downloadFiles.InstallPaths)
                            {
                                if (!Path.HasExtension(installPath))
                                {
                                    UpdateStatus($"Deleting folder: {installPath}");
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus($"Successfully deleted folder.");
                                }
                            }

                            // Delete empty folders from the /tmp folder
                            foreach (string installPath in downloadFiles.InstallPaths.Where(x => x.Contains("dev_hdd0/tmp/")))
                            {
                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                if (FtpExtensions.DirectoryExists(installPath) && FtpExtensions.IsDirectoryEmpty(installPath))
                                {
                                    UpdateStatus($"Deleting folder: {installPath}");
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus($"Successfully deleted folder.");
                                }
                            }

                            MainWindow.Settings.RemoveInstalledMods(modItem.GetPlatform(), Category.Id, modItem.Id);

                            if (MainWindow.IsWebManInstalled)
                            {
                                WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nUninstalled: {downloadFiles.Name} ({indexFiles - 1} files)");
                            }

                            IsSuccessful = true;

                            UpdateStatus($"Successfully uninstalled {indexFiles - 1} files.");
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus($"Unable to uninstall files. Error: {ex.Message}", ex);
                        }

                        break;
                    case PlatformPrefix.XBOX:
                        try
                        {
                            UpdateStatus($"Preparing to uninstall files...");

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
                                    UpdateStatus($"Uninstalling file: {Path.GetFileName(installFilePath)} ({indexFiles}/{totalFiles}) from {parentDirectoryPath}");
                                    MainWindow.XboxConsole.DeleteFile(installFilePath);
                                    UpdateStatus($"Successfully uninstalled file.");
                                    indexFiles++;
                                }
                            }

                            IsSuccessful = true;

                            MainWindow.Settings.RemoveInstalledMods(modItem.GetPlatform(), Category.Id, modItem.Id);

                            UpdateStatus($"Successfully uninstalled {indexFiles - 1} files.");
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus($"Unable to uninstall files. Error: {ex.Message}", ex);
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
                UpdateStatus($"Preparing to download archive...");

                DownloadFiles downloadFiles;

                UpdateStatus($"Getting archive file download link...");
                downloadFiles = modItem.GetDownloadFiles(this);

                if (downloadFiles == null)
                {
                    UpdateStatus($"No archive file download selected. Installation cancelled.");
                    return;
                }

                UpdateStatus($"Found archive file download link.");

                UpdateStatus($"Downloading archive file...");
                modItem.DownloadInstallFiles(downloadFiles);

                UpdateStatus($"Successfully downloaded archive file.");

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
                UpdateStatus($"Preparing to install package file...");

                // Check whether this mod is already installed
                bool isInstalled = MainWindow.Settings.GetInstalledPackage(packageItem) != null;

                if (isInstalled)
                {
                    if (GetDialogResult($"{packageItem.Name} ({packageItem.Category}) is already installed.\n\n" +
                        $"Would you like to reinstall the package file again?", "Package File Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus($"Installation cancelled.");
                        return;
                    }
                }

                try
                {
                    UpdateStatus($"Downloading package file...");

                    string localFilePathPKG = $@"{UserFolders.Packages}PKG\{PackageItem.Name.RemoveInvalidChars()}.pkg";
                    string localFilePathRAP = $@"{UserFolders.Packages}RAP\{PackageItem.ContentId.RemoveInvalidChars()}.rap";

                    UpdateStatus($@"Downloading package file: {packageItem.Name}.pkg to {UserFolders.Packages}");
                    HttpExtensions.DownloadFile(PackageItem.Url, localFilePathPKG);
                    UpdateStatus($"@Successfully downloaded package file.");

                    bool includeRAP = false;

                    if (PackageItem.IsRapRequired && !PackageItem.IsRapMissing)
                    {
                        UpdateStatus($@"Downloading RAP file: {packageItem.ContentId}.rap to {UserFolders.Packages}\PKG\");
                        HttpExtensions.DownloadFile(PackageItem.GetRapUrl, localFilePathRAP);
                        UpdateStatus($@"Successfully downloaded RAP file.");
                        includeRAP = true;
                    }

                    UpdateStatus($"Starting install...");

                    string parentInstallFolderPKG = Path.GetDirectoryName(packageItem.InstallFilePathPKG).Replace(@"\", "/");
                    string parentInstallFolderRAP = Path.GetDirectoryName(packageItem.InstallFilePathRAP).Replace(@"\", "/");

                    UpdateStatus($"Installing package file: {packageItem.Name}.pkg to {parentInstallFolderPKG}");
                    FtpExtensions.UploadFile(localFilePathPKG, packageItem.InstallFilePathPKG);
                    UpdateStatus($"Successfully installed package file.");

                    if (includeRAP)
                    {
                        UpdateStatus($"Installing RAP file: {packageItem.ContentId}.rap to {parentInstallFolderRAP}");
                        FtpExtensions.UploadFile(localFilePathRAP, packageItem.InstallFilePathRAP);
                        UpdateStatus($"Successfully installed RAP file.");
                    }

                    // Update installed packages
                    MainWindow.Settings.UpdateInstalledPackage(PackageItem, localFilePathPKG, DateTime.Now);

                    IsSuccessful = true;

                    // Log status
                    UpdateStatus($"Successfully installed package file.");
                }
                catch (WebException ex)
                {
                    UpdateStatus($"Error installing package file. Error: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Error installing package file. Error: {ex.Message}", ex);
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
                UpdateStatus($"Preparing to uninstall package file...");

                // Check whether this mod is already installed
                bool isNotInstalled = MainWindow.Settings.GetInstalledPackage(packageItem) == null;

                if (isNotInstalled)
                {
                    if (GetDialogResult($"{packageItem.Name} ({packageItem.Category}) is not installed on your console.\n\n" +
                        $"Would you like to uninstall the package file anyway?", "Package Not Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus($"Installation cancelled.");
                        return;
                    }
                }

                try
                {
                    UpdateStatus($"Uninstall package file...");

                    string parentInstallFolder = Path.GetDirectoryName(packageItem.InstallFilePathPKG).Replace(@"\", "/");

                    UpdateStatus($"Uninstalling package file: {packageItem.Name}.pkg from {parentInstallFolder}");
                    FtpExtensions.DeleteFile(packageItem.InstallFilePathPKG);
                    UpdateStatus($"Successfully uninstalled package file.");

                    IsSuccessful = true;

                    // Update installed packages
                    MainWindow.Settings.RemoveInstalledPackage(PackageItem);

                    // Log status
                    UpdateStatus($"Successfully package uninstalled file.");
                }
                catch (WebException ex)
                {
                    UpdateStatus($"Error uninstalling package file. Error: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Error uninstalling package file. Error: {ex.Message}", ex);
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
                UpdateStatus($"Preparing to download package file...");

                try
                {
                    string downloadFolder = UserFolders.DownloadsLocationPackages;

                    if (!Directory.Exists(downloadFolder))
                    {
                        Directory.CreateDirectory(downloadFolder);
                    }

                    string downloadLocationPKG = downloadFolder + @"\" + packageItem.Name.RemoveInvalidChars() + ".pkg";
                    string downloadLocationRAP = downloadFolder + @"\" + packageItem.ContentId.RemoveInvalidChars() + ".rap";

                    UpdateStatus($"Downloading package file: {packageItem.Name}.pkg to {downloadFolder}");
                    HttpExtensions.DownloadFile(packageItem.Url, downloadLocationPKG);
                    UpdateStatus($"Successfully downloaded package file.");

                    if (PackageItem.IsRapRequired && !PackageItem.IsRapMissing)
                    {
                        UpdateStatus($@"Downloading RAP file: {packageItem.ContentId}.rap to {downloadFolder}");
                        HttpExtensions.DownloadFile(PackageItem.GetRapUrl, downloadLocationRAP);
                        UpdateStatus($@"Successfully downloaded RAP file.");
                    }

                    LocalPath = downloadFolder;

                    IsSuccessful = true;
                }
                catch (WebException ex)
                {
                    UpdateStatus($"Error downloading package file. Error: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Error downloading package file. Error: {ex.Message}", ex);
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
                UpdateStatus($"Preparing to install files...");

                GameSaveDownloadFiles downloadFiles = gameSaveItem.DownloadFiles[0];

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count;

                UpdateStatus($"Found archive file download link.");

                UpdateStatus($"Downloading and extracting archive...");
                gameSaveItem.DownloadInstallFiles(downloadFiles);
                UpdateStatus($"Downloaded and extracted archive.");

                if (MainWindow.Settings.InstallGameSavesToUsbDevice)
                {
                    UpdateStatus($"Fetching USB device...");

                    List<ListItem> localUsbDevices = UsbExtensions.GetUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        GetDialogResult($"You have enabled the option to install game saves to your USB device but you don't have one connected to your computer.\nInsert a USB device first and install the mods again.", "No USB Devices", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus($"No USB devices connected. Installation cancelled.");
                        return;
                    }

                    ListItem selectedUsbDevice = DialogExtensions.ShowListViewDialog(this, "USB Devices", localUsbDevices);
                    UpdateStatus($"Found USB device.");

                    if (selectedUsbDevice == null)
                    {
                        UpdateStatus($"No USB device selected. Installation cancelled.");
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
                                        UpdateStatus($"Installing file: {localFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                        File.Copy(localFilePath, installPath + Path.GetFileName(localFilePath), true);
                                        UpdateStatus($"Successfully installed file.");

                                        indexFiles++;
                                    }
                                }
                            }

                            IsSuccessful = true;

                            UpdateStatus($"Successfully installed {indexFiles - 1} files.");
                        }
                        catch (WebException ex)
                        {
                            UpdateStatus($"Error installing files. Error: {ex.Message}", ex);
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus($"Error installing files. Error: {ex.Message} Path: {installPath}", ex);
                        }
                    }

                    return;
                }

                switch (gameSaveItem.GetPlatform())
                {
                    case PlatformPrefix.PS3:
                        {
                            try
                            {
                                UpdateStatus($"Starting install...");

                                string usbDevice;

                                if (downloadFiles.RequiresUsbDevice)
                                {
                                    if (GetDialogResult("Before installing this game save you must have completed the following steps:\n- Insert your USB device to any port on the console.\n- Install the Apollo Tool PKG from the Homebrew Packages category on your console to unlock, patch and resign save-game files directly on your PS3." + "\nThis will only work if you have your USB device connected. Click 'Yes' if you have done this. Otherwise click 'No' and this game-save will not be installed.", "Installing Game Saves", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        UpdateStatus($"Fetching USB device...");

                                        usbDevice = FtpExtensions.GetUsbPath();

                                        if (string.IsNullOrEmpty(usbDevice))
                                        {
                                            UpdateStatus($"No USB device connected. Installation cancelled.");
                                            return;
                                        }

                                        UpdateStatus($"Found USB device.");
                                    }
                                    else
                                    {
                                        UpdateStatus($"Installation cancelled.");
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
                                            UpdateStatus($"Installing file: {localFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                            FtpExtensions.UploadFile(localFilePath, installPath);
                                            UpdateStatus($"Successfully installed file.");

                                            indexFiles++;
                                        }
                                    }
                                }

                                IsSuccessful = true;

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                UpdateStatus($"Successfully installed {indexFiles - 1} files.{(Category.CategoryType == CategoryType.Game ? " Ready to start game." : string.Empty)}");
                            }
                            catch (FluentFTP.FtpCommandException ex)
                            {
                                UpdateStatus($"Unable to install files. Error Message: {ex.Message}", ex);
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus($"Unable to install files. Error Message: {ex.Message}", ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus($"Unable to install files. Error Message: {ex.Message}", ex);
                            }
                        }

                        break;
                    case PlatformPrefix.XBOX:
                        {
                            try
                            {
                                UpdateStatus($"Starting install...");

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
                                            UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");
                                            MainWindow.XboxConsole.MakeDirectory(parentFolderPath);
                                            MainWindow.XboxConsole.SendFile(localFilePath, installFilePath);
                                            UpdateStatus($"Successfully installed file.");

                                            indexFiles++;
                                        }
                                    }
                                }

                                IsSuccessful = true;

                                // Log status
                                UpdateStatus($"Successfully installed {indexFiles - 1} files. {(Category.CategoryType == CategoryType.Game ? "Ready to start game." : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                UpdateStatus($"Error installing files. Error: {ex.Message}", ex);
                            }
                            catch (Exception ex)
                            {
                                UpdateStatus($"Error installing files. Error: {ex.Message}", ex);
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
        public async Task UninstallGameSave(GameSaveItemData gameSaveItem)
        {
            await Task.Run(() =>
            {
                UpdateStatus($"Preparing to uninstall files...");

                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() =>
                    {
                        LabelModName.Text = $"{gameSaveItem.Name}\n{Category.Title}";
                    }));
                }
                else
                {
                    LabelModName.Text = $"{gameSaveItem.Name}\n{Category.Title}";
                }

                GameSaveDownloadFiles downloadFiles = gameSaveItem.DownloadFiles[0];

                string usbDevice;

                switch (gameSaveItem.GetPlatform())
                {
                    case PlatformPrefix.PS3:
                        try
                        {
                            UpdateStatus($"Doing a few checks...");

                            // Whether or not a USB device is required and prompt the user to insert the same one
                            if (downloadFiles.RequiresUsbDevice)
                            {
                                UpdateStatus($"Fetching USB device...");

                                if (GetDialogResult("Please insert the USB device (that contains this game save) into the same port into your console. Click 'OK' to continue uninstalling the files.", "Uninstall Game Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    usbDevice = FtpExtensions.GetUsbPath();

                                    if (string.IsNullOrEmpty(usbDevice))
                                    {
                                        UpdateStatus($"No USB device found. Installation cancelled.");
                                        return;
                                    }

                                    UpdateStatus($"Found USB device.");
                                }
                                else
                                {
                                    UpdateStatus($"Installation cancelled.");
                                    return;
                                }
                            }
                            else
                            {
                                usbDevice = string.Empty;
                            }

                            UpdateStatus($"Uninstalling files...");

                            int indexFiles = 1;
                            int totalFiles = downloadFiles.InstallPaths.Count;

                            // Loop through the install file paths
                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                // Format install file path with specified info: region/userId/USB
                                string installPath = installFilePath
                                .Replace("{USBDEV}", $"{usbDevice}");

                                string parentFolderPath = Path.GetDirectoryName(installFilePath).Replace(@"\", "/");

                                // Uninstall files
                                if (Path.HasExtension(installPath))
                                {
                                    UpdateStatus($"Uninstalling file: {Path.GetFileName(installPath)} ({indexFiles}/{totalFiles}) from {parentFolderPath}");
                                    FtpExtensions.DeleteFile(installPath);
                                    UpdateStatus($"Successfully uninstalled file.");
                                    indexFiles++;
                                }
                            }

                            foreach (string installPath in downloadFiles.InstallPaths)
                            {
                                if (!Path.HasExtension(installPath))
                                {
                                    UpdateStatus($"Deleting folder: {installPath}");
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus($"Successfully deleted folder.");
                                }
                            }

                            // Delete empty folders from the /tmp folder
                            foreach (string installPath in downloadFiles.InstallPaths.Where(x => x.Contains("dev_hdd0/tmp/")))
                            {
                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                if (FtpExtensions.DirectoryExists(installPath) && FtpExtensions.IsDirectoryEmpty(installPath))
                                {
                                    UpdateStatus($"Deleting folder: {installPath}");
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus($"Successfully deleted folder.");
                                }
                            }

                            if (MainWindow.IsWebManInstalled)
                            {
                                WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nUninstalled: {downloadFiles.Name} ({indexFiles - 1} files)");
                            }

                            IsSuccessful = true;

                            UpdateStatus($"Successfully uninstalled {indexFiles - 1} files.");
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus($"Unable to uninstall files. Error: {ex.Message}", ex);
                        }

                        break;
                    case PlatformPrefix.XBOX:
                        try
                        {
                            UpdateStatus($"Preparing to uninstall files...");

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
                                    UpdateStatus($"Uninstalling file: {Path.GetFileName(installFilePath)} ({indexFiles}/{totalFiles}) from {parentDirectoryPath}");
                                    MainWindow.XboxConsole.DeleteFile(installFilePath);
                                    UpdateStatus($"Successfully uninstalled file.");
                                    indexFiles++;
                                }
                            }

                            IsSuccessful = true;

                            UpdateStatus($"Successfully uninstalled {indexFiles - 1} files.");
                        }
                        catch (Exception ex)
                        {
                            UpdateStatus($"Unable to uninstall files. Error: {ex.Message}", ex);
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
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
                    UpdateStatus($"Preparing to download archive...");

                    string downloadFolder = UserFolders.DownloadsLocationGameSaves;

                    if (!Directory.Exists(downloadFolder))
                    {
                        UpdateStatus($"Download folder doesn't exist on your computer. Change this in your settings.");
                        return;
                    }

                    string downloadLocation = downloadFolder + @"\" + gameSaveItem.Name.RemoveInvalidChars() + ".pkg";

                    UpdateStatus($"Downloading game savearchive: {gameSaveItem.Name}.pkg to {downloadFolder}");
                    HttpExtensions.DownloadFile(gameSaveItem.DownloadFiles[0].Url, downloadLocation);
                    UpdateStatus($"Successfully downloaded game save archive.");

                    LocalPath = downloadFolder;

                    IsSuccessful = true;
                }
                catch (WebException ex)
                {
                    UpdateStatus($"Error downloading game save archive. Error: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Error downloading game save archive. Error: {ex.Message}", ex);
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