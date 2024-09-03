using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using FluentFTP.Exceptions;
using DevExpress.XtraLayout.Customization;
using XDevkit;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class TransferDialog : XtraForm
    {
        public TransferDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings { get; set; } = MainWindow.Settings;

        public ConsoleProfile ConsoleProfile { get; set; } = MainWindow.ConsoleProfile;

        public ResourceManager Language { get; set; } = MainWindow.ResourceLanguage;

        public TransferType TransferType { get; set; }

        public Database.Category Category { get; set; }

        public ModItemData ModItem { get; set; }

        public PackageItemData PackageItem { get; set; }

        public AppItemData AppItem { get; set; }

        public GameSaveItemData GameSaveItem { get; set; }

        public string GameRegion { get; set; }

        public DownloadFiles DownloadFiles { get; set; }

        public AppItemFile AppItemFile { get; set; }

        public CustomItemData CustomMod { get; set; }

        public TrainerGameData TrainerGame { get; set; }

        public TrainerItem TrainerItem { get; set; }

        public bool IsCustom { get; set; }

        private void TransferDialog_Load(object sender, EventArgs e)
        {
            _ = LoadTransferFilesAsync();
        }

        private async Task LoadTransferFilesAsync()
        {
            Text = Language.GetString(TransferType.Humanize());

            ButtonOpenFolder.Text = Language.GetString("OPEN_FOLDER");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            if (TransferType is TransferType.InstallMods or TransferType.UninstallMods or TransferType.DownloadMods)
            {
                LabelModName.Text = $"{Category.Title}\n{ModItem.Name}".Replace("&", "&&");
            }
            else if (TransferType is TransferType.InstallPackage or TransferType.UninstallPackage or TransferType.DownloadPackage)
            {
                LabelModName.Text = $"{PackageItem.Category}\n{PackageItem.Name} ({PackageItem.Region})".Replace("&", "&&");
            }
            else if (TransferType is TransferType.InstallApplication or TransferType.UninstallApplication or TransferType.DownloadApplication)
            {
                LabelModName.Text = $"{PackageItem.Category}\n{AppItem.Name} ({AppItem.Version})".Replace("&", "&&");
            }
            else if (TransferType is TransferType.InstallGameSave or TransferType.DownloadGameSave)
            {
                LabelModName.Text = $"{Category.Title}\n{GameSaveItem.Name}".Replace("&", "&&");
            }
            else if (TransferType is TransferType.InstallTrainer or TransferType.DownloadTrainer)
            {
                LabelModName.Text = $"{MainWindow.Database.TitleIdsX360.GetTitleFromTitleId(TrainerGame.TitleId)}\n{TrainerItem.Name}".Replace("&", "&&");
            }

            await TransferFilesAsync();
        }

        private bool _isDownloadInProgress;

        public async Task TransferFilesAsync()
        {
            if (_isDownloadInProgress)
            {
                // Prevent re-entrance if a download is already in progress
                return;
            }

            _isDownloadInProgress = true;

            try
            {
                var progress = new Progress<int>(value =>
                {
                    // Update the progress bar
                    ProgressBarStatus.Position = value;
                });

                switch (TransferType)
                {
                    case TransferType.InstallCustom:
                        await InstallCustom(CustomMod, progress);
                        break;
                    case TransferType.UninstallCustom:
                        await UninstallCustom(CustomMod, progress);
                        break;
                    case TransferType.InstallMods:
                        await InstallMods(ModItem, progress);
                        break;
                    case TransferType.UninstallMods:
                        await UninstallMods(ModItem, progress, GameRegion);
                        break;
                    case TransferType.DownloadMods:
                        await DownloadMods(ModItem, progress);
                        break;
                    case TransferType.InstallPackage:
                        await InstallPackageFile(PackageItem, progress);
                        break;
                    case TransferType.UninstallPackage:
                        await UninstallPackageFile(PackageItem, progress);
                        break;
                    case TransferType.DownloadPackage:
                        await DownloadPackageFile(PackageItem, progress);
                        break;
                    case TransferType.InstallApplication:
                        await InstallApplication(AppItem, progress);
                        break;
                    case TransferType.UninstallApplication:
                        await UninstallApplication(AppItem, progress);
                        break;
                    case TransferType.DownloadApplication:
                        await DownloadApplication(AppItem, progress);
                        break;
                    case TransferType.InstallGameSave:
                        await InstallGameSave(GameSaveItem, progress);
                        break;
                    case TransferType.DownloadGameSave:
                        await DownloadGameSave(GameSaveItem, progress);
                        break;
                    case TransferType.InstallTrainer:
                        await InstallTrainer(progress);
                        break;
                    case TransferType.DownloadTrainer:
                        await DownloadTrainer(progress);
                        break;
                }
            }
            finally
            {
                _isDownloadInProgress = false;

                // Update UI elements after completion
                if (InvokeRequired)
                {
                    _ = BeginInvoke(new Action(() =>
                    {
                        ButtonCancel.Text = Language.GetString("LABEL_CLOSE");
                        ButtonCancel.Visible = true;
                        _ = ButtonCancel.Focus();

                        ButtonOpenFolder.Visible = !LocalPath.IsNullOrEmpty() && Directory.Exists(LocalPath) && IsSuccessful;
                    }));
                }
                else
                {
                    ButtonCancel.Text = Language.GetString("LABEL_CLOSE");
                    ButtonCancel.Visible = true;
                    _ = ButtonCancel.Focus();

                    ButtonOpenFolder.Visible = !LocalPath.IsNullOrEmpty() && Directory.Exists(LocalPath) && IsSuccessful;
                }

                if (IsSuccessful)
                {
                    // Update progress bar properties if needed
                }
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
        public async Task InstallCustom(CustomItemData customItem, IProgress<int> progress)
        {
            UpdateStatus(Language.GetString("PREPARING_INSTALL"));

                await Task.Run(async () =>
                {
                    List<ListItem> installFiles = customItem.Files;

                    int indexFiles = 1;
                    int totalFiles = installFiles.Count;

                    UpdateStatus(Language.GetString("CHECKING_FILES"));

                    foreach (ListItem file in installFiles)
                    {
                        if (!File.Exists(file.Name))
                        {
                            UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                            _ = GetDialogResult(string.Format(Language.GetString("FILES_INSTALL_ERROR"), Language.GetString("FILE_UPLOAD_NOT_FOUND")), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    // Check whether this mod is already installed
                    bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, customItem.Category, customItem.Id, true) != null;

                    if (isInstalled)
                    {
                        if (GetDialogResult(string.Format(Language.GetString("REINSTALL_FILES"), $"{customItem.Name} v{customItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
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
                                    InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, customItem.CategoryType, customItem.Id) : null;

                                    // If another mod with the same category is installed already
                                    if (installedModInfo != null)
                                    {
                                        // Uninstall custom mod
                                        if (installedModInfo.IsCustom)
                                        {
                                            CustomItemData installedCustomItem = MainWindow.Settings.GetCustomMod(installedModInfo.ModId);

                                            if (GetDialogResult(string.Format(Language.GetString("ANOTHER_MOD_INSTALLED"), $"{installedCustomItem.Name} v{installedCustomItem.Version}", installedCustomItem.Category), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                            {
                                                await UninstallCustom(MainWindow.Settings.GetCustomMod(installedModInfo.ModId), progress);

                                                if (InvokeRequired)
                                                {
                                                    _ = Invoke(new Action(() =>
                                                    {
                                                        LabelModName.Text = $"{Category.Title}\n{customItem.Name}".Replace("&", "&&");
                                                    }));
                                                }
                                                else
                                                {
                                                    LabelModName.Text = $"{Category.Title}\n{customItem.Name}".Replace("&", "&&");
                                                }
                                            }
                                        }
                                        // Uninstall a non-custom game mod
                                        else
                                        {
                                            if (customItem.CategoryType == CategoryType.Game)
                                            {
                                                ModItemData installedModItem = MainWindow.Database.GetModItem(customItem.Platform, MainWindow.Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                                                if (GetDialogResult(string.Format(Language.GetString("ANOTHER_MOD_INSTALLED"), $"{installedModItem.Name} v{installedModItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                {
                                                    await UninstallMods(MainWindow.Database.GetModItem(customItem.Platform, MainWindow.Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId), progress);

                                                    if (InvokeRequired)
                                                    {
                                                        _ = Invoke(new Action(() =>
                                                        {
                                                            LabelModName.Text = $"{Category.Title}\n{customItem.Name}".Replace("&", "&&");
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        LabelModName.Text = $"{Category.Title}\n{customItem.Name}".Replace("&", "&&");
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                    bool askedToBackupFiles = false;
                                    bool shouldBackupFiles = false;

                                    foreach (ListItem installFile in installFiles)
                                    {
                                        string installFileName = Path.GetFileName(installFile.Value);

                                        string installPath = installFile.Value;

                                        string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                        // Check whether this file is installed to a game folder
                                        if (installPath.Contains("dev_hdd0/game/"))
                                        {
                                            // Get the backup details for this game file if one has been created
                                            BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(ConsoleProfile.Platform, customItem.Category, installFileName, installPath);

                                            if (backupFile == null)
                                            {
                                                if (Settings.AlwaysBackupGameFiles)
                                                {
                                                    shouldBackupFiles = true;
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
                                                        _ = MainWindow.FtpClient.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);

                                                        backupFile.LocalPath = Path.Combine(MainWindow.BackupFiles.GetGameBackupFolder(customItem), installFileName);
                                                        backupFile.InstallPath = installPath;

                                                        UpdateStatus(Language.GetString("FILE_BACKUP_CREATED"));
                                                    }

                                                    MainWindow.BackupFiles.UpdateBackupFile(MainWindow.BackupFiles.BackupFiles.IndexOf(backupFile), backupFile);
                                                }
                                            }

                                            UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                            _ = FtpExtensions.UploadFile(installFile.Name, installPath);
                                            UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                            indexFiles++;
                                        }
                                        else
                                        {
                                            UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                            _ = FtpExtensions.UploadFile(installFile.Name, installPath);
                                            UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                            indexFiles++;
                                        }
                                    }

                                    IsSuccessful = true;

                                    Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, customItem.CategoryType, customItem.Id, indexFiles - 1, DateTime.Now, null, true);

                                    if (MainWindow.IsWebManInstalled)
                                    {
                                        WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {customItem.Name} ({indexFiles - 1} files)");
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

                                    foreach (var installFile in installFiles)
                                    {
                                        string installFileName = Path.GetFileName(installFile.Value);

                                        string installPath = installFile.Value;

                                        string parentFolderPath = Path.GetDirectoryName(installFile.Value) + @"\";

                                        UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");

                                        if (!XboxExtensions.PathExists(@"Hdd:\", "ArisenStudio"))
                                        {
                                            MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\");
                                        }

                                        if (!XboxExtensions.PathExists(@"Hdd:\ArisenStudio\", customItem.Category.ToUpper()))
                                        {
                                            MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\" + customItem.Category.ToUpper() + @"\");
                                        }

                                        MainWindow.XboxConsole.SendFile(installFile.Name.Replace("\\\\", "\\").Replace("\\\\", "\\"), installPath);

                                        UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                        indexFiles++;
                                    }

                                    IsSuccessful = true;

                                    // Update installed mods
                                    Settings.UpdateInstalledMods(ConsoleProfile, customItem.Category, Category.CategoryType, customItem.Id, indexFiles - 1, DateTime.Now, null, true);

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
        /// Uninstall all of the files for the <paramref name="customItem" />.
        /// </summary>
        /// <param name="customItem"> <see cref="CustomItemData.CustomItemData" /> </param>
        public async Task UninstallCustom(CustomItemData customItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
                {
                    UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                    if (InvokeRequired)
                    {
                        _ = Invoke(new Action(() =>
                        {
                            LabelModName.Text = $"{Category.Title}\n{customItem.Name}".Replace("&", "&&");
                        }));
                    }
                    else
                    {
                        LabelModName.Text = $"{Category.Title}\n{customItem.Name}".Replace("&", "&&");
                    }

                    UpdateStatus(Language.GetString("GETTING_PREVIOUS_INSTALL"));

                    InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, customItem.Category, customItem.Id, true) : null;

                    if (installedModInfo == null)
                    {
                        // Can't find the previous install details
                        UpdateStatus(Language.GetString("NO_PREVIOUS_INSTALL_FOUND"));
                    }
                    else
                    {
                        UpdateStatus(Language.GetString("FOUND_PREVIOUS_INSTALL"));
                    }

                    progress.Report(20);

                    switch (ConsoleProfile.Platform)
                    {
                        case Platform.PS3:
                            try
                            {
                                int indexFiles = 1;
                                int totalFiles = installedModInfo.TotalFiles;

                                // Loop through the install file paths
                                foreach (ListItem installFilePath in customItem.Files)
                                {
                                    // Format install file path with specified info: region/userId/USB
                                    string installPath = installFilePath.Value;

                                    string parentFolderPath = Path.GetDirectoryName(installFilePath.Value).Replace(@"\", "/");

                                    // Uninstall files
                                    if (Path.HasExtension(installPath))
                                    {
                                        // Check whether file is being installed to game update folder
                                        if (installPath.Contains("dev_hdd0/game/"))
                                        {
                                            // Get the backup details for this game file if one has been created
                                            BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(ConsoleProfile.Platform, customItem.Category, Path.GetFileName(installPath), installPath);

                                            // Check whether a backup has been created for this game file
                                            if (backupFile != null)
                                            {
                                                // Check whether the backup file exists on users computer
                                                if (File.Exists(backupFile.LocalPath))
                                                {
                                                    // Install the backup file to the original game file path
                                                    UpdateStatus(string.Format(Language.GetString("INSTALLING_BACKUP_FILE_LOCATION"), $"{Path.GetFileName(installPath)} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                    _ = FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                                                    indexFiles++;
                                                }
                                                else
                                                {
                                                    _ = GetDialogResult(string.Format(Language.GetString("CANT_FIND_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                            }
                                            else
                                            {
                                                _ = GetDialogResult(string.Format(Language.GetString("NO_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                                progress.Report(80);

                                foreach (ListItem installPath in customItem.Files)
                                {
                                    if (!Path.HasExtension(installPath.Name))
                                    {
                                        UpdateStatus(string.Format(Language.GetString("FOLDER_DELETING"), installPath.Name));
                                        FtpExtensions.DeleteDirectory(installPath.Name);
                                        UpdateStatus(Language.GetString("FOLDER_DELETE_SUCCESS"));
                                    }
                                }

                                progress.Report(90);

                                // Delete empty folders from the /tmp folder
                                foreach (ListItem installPath in customItem.Files.Where(x => x.Value.Contains("dev_hdd0/tmp/")))
                                {
                                    string parentFolderPath = Path.GetDirectoryName(installPath.Name).Replace(@"\", "/");

                                    if (FtpExtensions.DirectoryExists(installPath.Name) && FtpExtensions.IsDirectoryEmpty(installPath.Name))
                                    {
                                        UpdateStatus(string.Format(Language.GetString("FOLDER_DELETING"), installPath));
                                        FtpExtensions.DeleteDirectory(installPath.Name);
                                        UpdateStatus(Language.GetString("FOLDER_DELETE_SUCCESS"));
                                    }
                                }

                                Settings.RemoveInstalledMods(ConsoleProfile, customItem.Category, customItem.Id, true);

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nUninstalled: {customItem.Name} ({indexFiles - 1} files)");
                                }

                                IsSuccessful = true;

                                progress.Report(100);

                                UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_SUCCESS"), indexFiles - 1));
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_ERROR"), ex.Message), ex);
                            }

                            break;
                        case Platform.XBOX360:
                            try
                            {
                                UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                                int indexFiles = 1;
                                int totalFiles = customItem.Files.Count;

                                progress.Report(50);

                                // Loop through the install file paths
                                foreach (ListItem installFilePath in customItem.Files)
                                {
                                    string installedPath = installFilePath.Name;
                                    string parentDirectoryPath = Path.GetDirectoryName(installedPath);

                                    // Uninstall files
                                    if (Path.HasExtension(installedPath))
                                    {
                                        // Check whether file is being installed to game update folder
                                        UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), $"{Path.GetFileName(installedPath)} ({indexFiles}/{totalFiles})", parentDirectoryPath));

                                        if (XboxExtensions.FileExists(parentDirectoryPath, installedPath))
                                        {
                                            MainWindow.XboxConsole.DeleteFile(installedPath);
                                        }

                                        UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                                        indexFiles++;
                                    }
                                }

                                progress.Report(90);

                                IsSuccessful = true;

                                Settings.RemoveInstalledMods(ConsoleProfile, customItem.Category, customItem.Id, true);

                                progress.Report(100);

                                UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_SUCCESS"), indexFiles - 1));
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
        public async Task InstallMods(ModItemData modItem, IProgress<int> progress)
        {
            progress.Report(0);

            UpdateStatus(string.Format(Language.GetString("PREPARING_INSTALL") + " : {0} ({1})", modItem.Name, modItem.CategoryId));

            await Task.Run(() =>
            {
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

                progress.Report(10);

                if (downloadFiles == null)
                {
                    UpdateStatus(string.Join(" ", Language.GetString("NO_DOWNLOAD_FILES_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                    progress.Report(0);
                    return;
                }

                progress.Report(20);

                int indexFiles = 1;
                int totalFiles = downloadFiles.InstallPaths.Count;

                UpdateStatus(Language.GetString("DOWNLOADING_EXTRACTING_ARCHIVE"));
                modItem.DownloadInstallFiles(downloadFiles, Category);

                progress.Report(40);

                if (Settings.InstallGameModsToUsbDevice)
                {
                    UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                    List<ListItem> localUsbDevices = UsbExtensions.GetLocalUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        _ = GetDialogResult(Language.GetString("INSERT_USB_DEVICE"), Language.GetString("NO_USB_DEVICES"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                        progress.Report(0);
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
                            _ = Directory.CreateDirectory(installPath);

                            progress.Report(60);

                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                // Install files
                                foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles, Category), "*.*", SearchOption.AllDirectories))
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

                            progress.Report(90);

                            if (Settings.CleanUpLocalFilesAfterInstalling)
                            {
                                try
                                {
                                    UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                    Directory.Delete(modItem.DownloadDataDirectory(downloadFiles, Category), true);
                                    File.Delete(modItem.ArchiveZipFile(downloadFiles, Category));
                                }
                                catch { }
                            }

                            IsSuccessful = true;

                            progress.Report(100);

                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (WebException ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                        catch (Exception ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                    }

                    return;
                }

                // Check whether this mod is already installed
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, modItem.CategoryId, modItem.Id, false) != null;

                if (isInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("REINSTALL_FILES"), $"{modItem.Name} v{modItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                        progress.Report(0);
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
                                        UninstallMods(MainWindow.Database.GetModItem(installedModInfo.Platform, MainWindow.Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId), progress, ((DownloadFiles)installedModInfo.DownloadFiles).Region);

                                        if (InvokeRequired)
                                        {
                                            _ = Invoke(new Action(() =>
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

                                progress.Report(50);

                                if (downloadFiles.InstallsToRebugFolder)
                                {
                                    // Check whether mods are being installed to the firmware folder and let the user
                                    // know if they want to cancel

                                    if (GetDialogResult(Language.GetString("NOTICE_INSTALL_REBUG_FILES"), Language.GetString("IMPORTANT_MESSAGE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                    {
                                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                                        progress.Report(0);
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
                                        progress.Report(0);
                                        return;
                                    }

                                    if (modItem.IsAnyRegion && !Category.Regions.Any(x => x.EqualsIgnoreCase(gameRegion)))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NOT_SUPPORTED_GAME_REGION"), Language.GetString("INSTALL_CANCELED")));
                                        progress.Report(0);
                                        return;
                                    }

                                    // Check whether the game update for this region exists
                                    if (!FtpExtensions.GetFolderNames("/dev_hdd0/game/").Any(x => x.Name.ContainsIgnoreCase(gameRegion)))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NO_GAME_REGION_FOUND"), Language.GetString("INSTALL_CANCELED")));
                                        _ = GetDialogResult(Language.GetString("NO_GAME_REGION_FOLDER_FOUND"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        progress.Report(0);
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

                                progress.Report(55);

                                string userId = string.Empty;
                                if (downloadFiles.RequiresUserId)
                                {
                                    // Check whether a user id must be provided and prompts the user to choose one

                                    UpdateStatus(Language.GetString("GETTING_USER_PROFILE"));

                                    userId = FtpExtensions.GetUserProfileId(this);

                                    if (string.IsNullOrEmpty(userId))
                                    {
                                        UpdateStatus(string.Join(" ", Language.GetString("NO_USER_PROFILE_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                                        progress.Report(0);
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
                                            progress.Report(0);
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

                                progress.Report(60);

                                UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                bool askedToBackupFiles = false;
                                bool shouldBackupFiles = false;

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles, Category), "*.*", SearchOption.AllDirectories))
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
                                                            _ = MainWindow.FtpClient.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);

                                                            backupFile.LocalPath = Path.Combine(MainWindow.BackupFiles.GetGameBackupFolder(modItem), installFileName);
                                                            backupFile.InstallPath = installPath;

                                                            UpdateStatus(Language.GetString("FILE_BACKUP_CREATED"));
                                                        }

                                                        MainWindow.BackupFiles.UpdateBackupFile(MainWindow.BackupFiles.BackupFiles.IndexOf(backupFile), backupFile);
                                                    }
                                                }

                                                UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                _ = FtpExtensions.UploadFile(localFilePath, installPath);
                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                indexFiles++;
                                            }
                                            // Check whether file is installed to a USB device
                                            else if (installFilePath.Contains("{USBDEV}"))
                                            {
                                                if (!string.IsNullOrEmpty(usbDevice))
                                                {
                                                    UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                    _ = FtpExtensions.UploadFile(localFilePath, installPath);
                                                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                    indexFiles++;
                                                }
                                            }
                                            else
                                            {
                                                UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                _ = FtpExtensions.UploadFile(localFilePath, installPath);
                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                indexFiles++;
                                            }
                                        }
                                    }
                                }

                                progress.Report(90);

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(modItem.DownloadDataDirectory(downloadFiles, Category), true);
                                        File.Delete(modItem.ArchiveZipFile(downloadFiles, Category));
                                        progress.Report(95);
                                    }
                                    catch { }
                                }

                                progress.Report(100);

                                IsSuccessful = true;

                                Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, Category.CategoryType, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (FtpCommandException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (WebException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
                                    foreach (string localFilePath in Directory.GetFiles(modItem.DownloadDataDirectory(downloadFiles, Category), "*.*", SearchOption.AllDirectories))
                                    {
                                        string installPath = installFilePath
                                        .Replace("{CATEGORYID}", modItem.CategoryId.ToUpper());

                                        string installFileName = Path.GetFileName(installFilePath);

                                        installPath = installPath.Replace("\\\\", "\\");

                                        // Check whether install file matches the specified install file
                                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                                        {
                                            UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPath}");

                                            /* Local Parent Folder Name */
                                            //int lastSlashIndex = localFilePath.Replace("\\\\", "\\").LastIndexOf('\\');
                                            //int secondLastSlashIndex = localFilePath.Replace("\\\\", "\\").LastIndexOf('\\', lastSlashIndex - 1);
                                            //string parentFolder = localFilePath.Replace("\\\\", "\\").Substring(secondLastSlashIndex + 1, lastSlashIndex - secondLastSlashIndex - 1);
                                            /* Local Parent Folder Name */

                                            string installFileParentPath = XboxExtensions.GetParentFolder(installPath.Replace("\\\\", "\\"));

                                            Program.Log.Info("Local File Path: " + localFilePath.Replace("\\\\", "\\").Replace("\\\\", "\\"));
                                            Program.Log.Info("Install Parent Path: " + installFileParentPath);
                                            Program.Log.Info("Install File Path: " + installPath);

                                            if (File.Exists(localFilePath))
                                            {
                                                UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPath}");

                                                MainWindow.XboxConsole.CreateDirectoryRecursive(installFileParentPath);

                                                MainWindow.XboxConsole.SendFile(localFilePath.Replace("\\\\", "\\").Replace("\\\\", "\\"), installPath);

                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                                indexFiles++;
                                            }
                                            else
                                            {
                                                progress.Report(0);
                                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), "Local File Doesn't Exist"));
                                            }

                                        }
                                    }
                                }

                                progress.Report(80);

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(modItem.DownloadDataDirectory(downloadFiles, Category), true);
                                        File.Delete(modItem.ArchiveZipFile(downloadFiles, Category));
                                        progress.Report(95);
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                // Update installed mods
                                Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, Category.CategoryType, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                progress.Report(100);

                                // Log status
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
        public async Task UninstallMods(ModItemData modItem, IProgress<int> progress, string region = "")
        {
            progress.Report(0);

            await Task.Run(() =>
                {
                    UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                    if (InvokeRequired)
                    {
                        _ = Invoke(new Action(() =>
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

                    InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, modItem.CategoryId, modItem.Id, false) : null;

                    string gameRegion;
                    string userId;
                    string usbDevice;

                    progress.Report(20);

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
                        downloadFiles = (DownloadFiles)installedModInfo.DownloadFiles;
                        gameRegion = downloadFiles.Region;
                        isFilesInstalledToUsb = FtpExtensions.UsbPorts.Any(x => downloadFiles.InstallPaths.Any(y => y.Contains(x)));
                        UpdateStatus(Language.GetString("FOUND_PREVIOUS_INSTALL"));
                    }

                    progress.Report(40);

                    switch (ConsoleProfile.Platform)
                    {
                        case Platform.PS3:
                            try
                            {
                                switch (downloadFiles.InstallsToRebugFolder)
                                {
                                    // Alerts the user that uninstalling files from dev_rebug folders isn't allowed
                                    case true:
                                        _ = GetDialogResult(Language.GetString("CANT_UNINSTALL_CFW_FILES"), Language.GetString("FORBIDDEN"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                                        progress.Report(0);
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
                                        progress.Report(0);
                                        return;
                                    }

                                    UpdateStatus(string.Format(Language.GetString("FOUND_GAME_REGION"), gameRegion));

                                    if (Settings.RememberGameRegions)
                                    {
                                        Settings.UpdateGameRegion(modItem.CategoryId, gameRegion);
                                    }
                                }

                                progress.Report(50);

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

                                progress.Report(60);

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
                                                    _ = FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                                                    indexFiles++;
                                                }
                                                else
                                                {
                                                    _ = GetDialogResult(string.Format(Language.GetString("CANT_FIND_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                            }
                                            else
                                            {
                                                _ = GetDialogResult(string.Format(Language.GetString("NO_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                                progress.Report(80);

                                foreach (string installPath in downloadFiles.InstallPaths)
                                {
                                    if (!Path.HasExtension(installPath))
                                    {
                                        UpdateStatus(string.Format(Language.GetString("FOLDER_DELETING"), installPath));
                                        FtpExtensions.DeleteDirectory(installPath);
                                        UpdateStatus(Language.GetString("FOLDER_DELETE_SUCCESS"));
                                    }
                                }

                                progress.Report(90);

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

                                Settings.RemoveInstalledMods(ConsoleProfile, Category.Id, modItem.Id, false);

                                progress.Report(95);

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nUninstalled: {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                IsSuccessful = true;

                                progress.Report(100);

                                UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_SUCCESS"), indexFiles - 1));
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_ERROR"), ex.Message), ex);
                            }

                            break;
                        case Platform.XBOX360:
                            try
                            {
                                UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                                int indexFiles = 1;
                                int totalFiles = downloadFiles.InstallPaths.Count;

                                progress.Report(70);

                                // Loop through the install file paths
                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    string installedPath = installFilePath.Replace("{CATEGORYID}", modItem.CategoryId.ToUpper());
                                    string parentDirectoryPath = Path.GetDirectoryName(installedPath);

                                    // Uninstall files
                                    if (Path.HasExtension(installedPath))
                                    {
                                        // Check whether file is being installed to game update folder
                                        UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), $"{Path.GetFileName(installedPath)} ({indexFiles}/{totalFiles})", parentDirectoryPath));

                                        if (XboxExtensions.FileExists(parentDirectoryPath, installedPath))
                                        {
                                            MainWindow.XboxConsole.DeleteFile(installedPath);
                                        }

                                        UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                                        indexFiles++;
                                    }
                                }

                                progress.Report(90);

                                IsSuccessful = true;

                                Settings.RemoveInstalledMods(ConsoleProfile, Category.Id, modItem.Id, false);

                                progress.Report(100);

                                UpdateStatus(string.Format(Language.GetString("FILES_UNINSTALL_SUCCESS"), indexFiles - 1));
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
        public async Task DownloadMods(ModItemData modItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(string.Format(Language.GetString("PREPARING_DOWNLOAD") + " : {0} ({1})", modItem.Name, modItem.CategoryId));

                DownloadFiles downloadFiles;

                if (DownloadFiles == null)
                {
                    downloadFiles = modItem.GetDownloadFiles(this);
                }
                else
                {
                    downloadFiles = DownloadFiles;
                }

                progress.Report(40);

                if (downloadFiles == null)
                {
                    progress.Report(0);
                    UpdateStatus(string.Join(" ", Language.GetString("NO_DOWNLOAD_FILES_SELECTED"), Language.GetString("DOWNLOAD_CANCELED")));
                    return;
                }

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING"));
                modItem.DownloadInstallFiles(downloadFiles, Category);

                progress.Report(75);

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS"));

                LocalPath = Path.GetDirectoryName(modItem.ArchiveZipFile(downloadFiles, Category));

                progress.Report(100);

                IsSuccessful = true;

                //UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                //DownloadFiles downloadFiles;

                //if (DownloadFiles == null)
                //{
                //    downloadFiles = modItem.GetDownloadFiles(this);
                //}
                //else
                //{
                //    downloadFiles = DownloadFiles;
                //}

                //progress.Report(40);

                //if (downloadFiles == null)
                //{
                //    UpdateStatus(string.Join(" ", Language.GetString("NO_DOWNLOAD_FILES_SELECTED"), Language.GetString("DOWNLOAD_CANCELED")));
                //    progress.Report(0);
                //    return;
                //}

                //UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING"));
                //modItem.DownloadInstallFiles(downloadFiles, Category);

                //progress.Report(75);

                //UpdateStatus(Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS"));

                //LocalPath = Path.GetDirectoryName(modItem.ArchiveZipFile(downloadFiles, Category));

                //progress.Report(100);

                //IsSuccessful = true;
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task InstallPackageFile(PackageItemData packageItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_INSTALL"));

                // Check whether this mod is already installed
                bool isInstalled = Settings.GetInstalledPackage(packageItem) != null;

                if (isInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("FILE_REINSTALL"), $"{packageItem.Name} ({packageItem.Category})"), MainWindow.ResourceLanguage.GetString("REINSTALL_FILE"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                        progress.Report(0);
                        return;
                    }
                }

                progress.Report(10);

                try
                {
                    string downloadPath = $@"{Settings.PathDownloads.GetFullPath(Settings.PathAppData)}\{PackageItem.Name.RemoveInvalidChars()}\";
                    _ = Directory.CreateDirectory(downloadPath);

                    string localFilePathPkg = $@"{downloadPath}\{PackageItem.Name.RemoveInvalidChars()}.pkg";
                    string localFilePathRap = $@"{downloadPath}\{PackageItem.ContentId.RemoveInvalidChars()}.rap";

                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.Name + ".pkg", downloadPath + PackageItem.Name.RemoveInvalidChars()));
                    HttpExtensions.DownloadFile(PackageItem.Url, localFilePathPkg);
                    UpdateStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));
                    progress.Report(30);

                    bool includeRap = false;

                    if (PackageItem.IsRapRequired && !PackageItem.IsRapMissing)
                    {
                        UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.ContentId + ".rap", downloadPath + PackageItem.Name.RemoveInvalidChars()));
                        HttpExtensions.DownloadFile(PackageItem.RapUrl, localFilePathRap);
                        UpdateStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));
                        includeRap = true;
                        progress.Report(40);
                    }

                    UpdateStatus(Language.GetString("STARTING_INSTALL"));

                    string parentInstallFolderPkg = Path.GetDirectoryName(packageItem.InstallFilePathPkg).Replace(@"\", "/");
                    string parentInstallFolderRap = Path.GetDirectoryName(packageItem.InstallFilePathRap).Replace(@"\", "/");

                    UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), packageItem.Name + ".pkg", parentInstallFolderPkg));
                    _ = FtpExtensions.UploadFile(localFilePathPkg, packageItem.InstallFilePathPkg);
                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                    progress.Report(60);

                    if (includeRap)
                    {
                        UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), packageItem.ContentId + ".rap", parentInstallFolderRap));
                        _ = FtpExtensions.UploadFile(localFilePathRap, packageItem.InstallFilePathRap);
                        UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                        progress.Report(80);
                    }

                    // Update installed packages
                    Settings.UpdateInstalledPackage(PackageItem, localFilePathPkg, DateTime.Now);

                    if (Settings.CleanUpLocalFilesAfterInstalling)
                    {
                        try
                        {
                            UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                            IoExtensions.DeleteDirectory($@"{downloadPath}");
                            progress.Report(90);
                        }
                        catch { }
                    }

                    IsSuccessful = true;

                    progress.Report(100);

                    // Log status
                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                }
                catch (WebException ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task UninstallPackageFile(PackageItemData packageItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                // Check whether this mod is already installed
                bool isNotInstalled = Settings.GetInstalledPackage(packageItem) == null;

                if (isNotInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("MOD_NOT_INSTALLED"), $"{packageItem.Name} ({packageItem.Category})"), Language.GetString("NOT_INSTALLED"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        UpdateStatus(Language.GetString("UNINSTALL_CANCELED"));
                        progress.Report(0);
                        return;
                    }
                }

                try
                {
                    progress.Report(50);

                    UpdateStatus(Language.GetString("FILES_UNINSTALLING"));

                    string parentInstallFolder = Path.GetDirectoryName(packageItem.InstallFilePathPkg).Replace(@"\", "/");

                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), packageItem.Name + ".pkg", parentInstallFolder));
                    FtpExtensions.DeleteFile(packageItem.InstallFilePathPkg);
                    UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));

                    IsSuccessful = true;

                    // Update installed packages
                    Settings.RemoveInstalledPackage(PackageItem);

                    progress.Report(100);

                    // Log status
                    UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                }
                catch (WebException ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="PackageItemData"/> files.
        /// </summary>
        public async Task DownloadPackageFile(PackageItemData packageItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                try
                {
                    string downloadFolder = $@"{Settings.PathDownloads.GetFullPath(Settings.PathAppData)}\Packages\{packageItem.Name.RemoveInvalidChars()} ({packageItem.Region})";

                    if (!Directory.Exists(downloadFolder))
                    {
                        _ = Directory.CreateDirectory(downloadFolder);
                    }

                    string downloadLocationPkg = Path.Combine(downloadFolder, packageItem.Name.RemoveInvalidChars() + ".pkg");
                    string downloadLocationRap = Path.Combine(downloadFolder, packageItem.ContentId.RemoveInvalidChars() + ".rap");

                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.Name + ".pkg", downloadFolder));
                    HttpExtensions.DownloadFile(packageItem.Url, downloadLocationPkg);
                    UpdateStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));

                    progress.Report(50);

                    if (PackageItem.IsRapRequired && !PackageItem.IsRapMissing)
                    {
                        UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), packageItem.ContentId + ".rap", downloadFolder));
                        HttpExtensions.DownloadFile(PackageItem.RapUrl, downloadLocationRap);
                        UpdateStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));
                    }

                    progress.Report(80);

                    Settings.DownloadedMods.Add(new()
                    {
                        ModId = PackageItem.Id,
                        CategoryId = "package",
                        DateTime = DateTime.Now,
                        DownloadFile = new()
                        {
                            InstallPaths = [PackageItem.InstallFilePathPkg + PackageItem.InstallFilePathRap],
                            LastUpdated = DateTime.Now,
                            Name = Name.RemoveInvalidChars(),
                            Region = packageItem.Region,
                            Url = packageItem.Url,
                            Version = "n/a"
                        }
                    });

                    LocalPath = downloadFolder;

                    progress.Report(100);

                    IsSuccessful = true;
                }
                catch (WebException ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task InstallApplication(AppItemData appItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(async () =>
            {
                UpdateStatus(Language.GetString("PREPARING_INSTALL"));

                UpdateStatus(Language.GetString("GETTING_DOWNLOAD_FILES"));

                AppItemFile downloadFiles = appItem.DownloadFiles.First();

                appItem.DownloadInstallFiles(downloadFiles);

                progress.Report(30);

                int indexFiles = 1;
                int totalFiles = 1;

                if (Settings.InstallGameModsToUsbDevice)
                {
                    UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                    List<ListItem> localUsbDevices = UsbExtensions.GetLocalUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        _ = GetDialogResult(Language.GetString("INSERT_USB_DEVICE"), Language.GetString("NO_USB_DEVICES"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                        progress.Report(0);
                        return;
                    }

                    ListItem selectedUsbDevice = DialogExtensions.ShowListViewDialog(this, Language.GetString("USB_DEVICES"), localUsbDevices);

                    if (selectedUsbDevice == null)
                    {
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICE_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                    }
                    else
                    {
                        string installPath = $@"{selectedUsbDevice.Value}PS4\Homebrew\{Category.Title.RemoveInvalidChars()}\{appItem.Name.RemoveInvalidChars()}\";
                        LocalPath = installPath;

                        try
                        {
                            progress.Report(40);

                            _ = Directory.CreateDirectory(installPath);

                            foreach (string localFilePath in Directory.GetFiles(appItem.DownloadFilesDirectory(downloadFiles), "*.*", SearchOption.AllDirectories))
                            {
                                string localFileName = Path.GetFileName(localFilePath);

                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{localFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                File.Copy(localFilePath, installPath + Path.GetFileName(localFilePath), true);
                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                            }

                            progress.Report(90);

                            if (Settings.CleanUpLocalFilesAfterInstalling)
                            {
                                try
                                {
                                    UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                    Directory.Delete(appItem.DownloadFilesDirectory(downloadFiles), true);
                                    File.Delete(appItem.LocalFilePath(downloadFiles));
                                }
                                catch { }
                            }

                            progress.Report(100);

                            IsSuccessful = true;

                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (WebException ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                        catch (Exception ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                    }

                    return;
                }

                // Check whether this mod is already installed
                bool isInstalled = ConsoleProfile != null && Settings.GetInstalledMods(ConsoleProfile, appItem.CategoryId, appItem.Id, false) != null;

                if (isInstalled)
                {
                    if (GetDialogResult(string.Format(Language.GetString("REINSTALL_FILES"), $"{appItem.Name} v{appItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                        progress.Report(0);
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
                                    AppItemData installedModItem = MainWindow.Database.GetAppItem(MainWindow.Database.CategoriesData.GetCategoryById(installedModInfo.CategoryId).CategoryType, installedModInfo.ModId);

                                    if (GetDialogResult(string.Format(Language.GetString("ANOTHER_MOD_INSTALLED"), $"{installedModItem.Name} v{installedModItem.Version}", Category.Title), Language.GetString("OVERWRITE_MODS"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        await UninstallApplication(installedModItem, progress);

                                        if (InvokeRequired)
                                        {
                                            _ = Invoke(new Action(() =>
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

                                progress.Report(40);

                                // Install Files

                                UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                string localFilePath = appItem.LocalFilePath(downloadFiles);

                                string installFileName = Path.GetFileName(downloadFiles.GetFileName(appItem.TitleId));

                                string installPath = downloadFiles.GetInstallPath(appItem.TitleId);

                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{installFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                _ = FtpExtensions.UploadFile(localFilePath, installPath);
                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                progress.Report(80);

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(appItem.DownloadFilesDirectory(downloadFiles), true);
                                        File.Delete(appItem.LocalFilePath(downloadFiles));
                                        progress.Report(90);
                                    }
                                    catch { }
                                }

                                progress.Report(95);

                                IsSuccessful = true;

                                Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, Category.CategoryType, appItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                progress.Report(100);

                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (FtpCommandException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (WebException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                        }

                        break;
                    case Platform.XBOX360:
                        {
                            try
                            {
                                progress.Report(40);

                                UpdateStatus(Language.GetString("STARTING_INSTALL"));

                                string installFileName = Path.GetFileName(downloadFiles.GetFileName(appItem.TitleId));

                                string installPath = downloadFiles.GetInstallPath(appItem.TitleId)
                                .Replace("{CATEGORYID}", appItem.CategoryId.ToUpper());

                                string parentFolderPath = Path.GetDirectoryName(installPath) + @"\";

                                UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {parentFolderPath}");

                                if (!XboxExtensions.PathExists(@"Hdd:\", "ArisenStudio"))
                                    MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\");

                                if (!XboxExtensions.PathExists(@"Hdd:\ArisenStudio\", appItem.CategoryId.ToUpper()))
                                    MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\" + appItem.CategoryId.ToUpper() + @"\");

                                progress.Report(50);

                                MainWindow.XboxConsole.SendFile(appItem.LocalFilePath(downloadFiles).Replace("\\\\", "\\").Replace("\\\\", "\\"), installPath);

                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                progress.Report(80);

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(appItem.DownloadFilesDirectory(downloadFiles), true);
                                        File.Delete(appItem.LocalFilePath(downloadFiles));
                                        progress.Report(90);
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                // Update installed mods
                                Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, Category.CategoryType, appItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                                progress.Report(100);

                                // Log status
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
        /// <param name="appItem"> <see cref="AppItemData" /> </param>
        public async Task UninstallApplication(AppItemData appItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
                {
                    UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                    if (InvokeRequired)
                    {
                        _ = Invoke(new Action(() =>
                        {
                            LabelModName.Text = $"{Category.Title}\n{appItem.Name}".Replace("&", "&&");
                        }));
                    }
                    else
                    {
                        LabelModName.Text = $"{Category.Title}\n{appItem.Name}".Replace("&", "&&");
                    }

                    AppItemFile downloadFiles;

                    UpdateStatus(Language.GetString("GETTING_PREVIOUS_INSTALL"));

                    InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? Settings.GetInstalledMods(ConsoleProfile, appItem.CategoryId, appItem.Id, false) : null;

                    bool isFilesInstalledToUsb;

                    if (installedModInfo == null)
                    {
                        // Can't find the previous install details
                        UpdateStatus(string.Join(" ", Language.GetString("NO_PREVIOUS_INSTALL_FOUND"), Language.GetString("GETTING_DOWNLOAD_FILES")));
                        downloadFiles = appItem.DownloadFiles.First();
                        isFilesInstalledToUsb = false;
                    }
                    else
                    {
                        downloadFiles = (AppItemFile)installedModInfo.DownloadFiles;
                        //TODO// isFilesInstalledToUsb = FtpExtensions.UsbPorts.Any(x => x.Contains(downloadFiles.InstallPath.Any(y => y.Contains(x)));
                        UpdateStatus(Language.GetString("FOUND_PREVIOUS_INSTALL"));
                    }

                    progress.Report(20);

                    switch (ConsoleProfile.Platform)
                    {
                        case Platform.PS3:
                            try
                            {
                                int indexFiles = 1;
                                int totalFiles = 1; ;

                                string localFilePath = appItem.LocalFilePath(downloadFiles);

                                string installFileName = Path.GetFileName(downloadFiles.GetFileName(appItem.TitleId));

                                string installPath = downloadFiles.GetInstallPath(appItem.TitleId);

                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                // Uninstall files
                                if (Path.HasExtension(installPath))
                                {
                                    // Check whether file is being installed to game update folder
                                    if (installPath.Contains("dev_hdd0/game/"))
                                    {
                                        // Get the backup details for this game file if one has been created
                                        BackupFile backupFile = MainWindow.BackupFiles.GetGameFileBackup(ConsoleProfile.Platform, appItem.CategoryId, Path.GetFileName(installPath), installPath);

                                        // Check whether a backup has been created for this game file
                                        if (backupFile != null)
                                        {
                                            // Check whether the backup file exists on users computer
                                            if (File.Exists(backupFile.LocalPath))
                                            {
                                                // Install the backup file to the original game file path
                                                UpdateStatus(string.Format(Language.GetString("INSTALLING_BACKUP_FILE_LOCATION"), $"{Path.GetFileName(installPath)} ({indexFiles}/{totalFiles})", parentFolderPath));
                                                _ = FtpExtensions.UploadFile(backupFile.LocalPath, installPath);
                                                UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                                                indexFiles++;
                                            }
                                            else
                                            {
                                                _ = GetDialogResult(string.Format(Language.GetString("CANT_FIND_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                        else
                                        {
                                            _ = GetDialogResult(string.Format(Language.GetString("NO_BACKUP_FILE"), Path.GetFileName(installPath)), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                                // Delete empty folders from the installation folder
                                if (FtpExtensions.DirectoryExists(installPath) && FtpExtensions.IsDirectoryEmpty(installPath))
                                {
                                    UpdateStatus(string.Format(Language.GetString("FOLDER_DELETING"), installPath));
                                    FtpExtensions.DeleteDirectory(installPath);
                                    UpdateStatus(Language.GetString("FOLDER_DELETE_SUCCESS"));
                                }

                                Settings.RemoveInstalledMods(ConsoleProfile, Category.Id, appItem.Id, false);

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
                                progress.Report(40);

                                UpdateStatus(Language.GetString("PREPARING_UNINSTALL"));

                                int indexFiles = 1;
                                int totalFiles = 1;

                                string localFilePath = appItem.LocalFilePath(downloadFiles);

                                string installFileName = Path.GetFileName(downloadFiles.GetFileName(appItem.TitleId));

                                string installPath = downloadFiles.GetInstallPath(appItem.TitleId);

                                string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                // Uninstall files
                                if (Path.HasExtension(installPath))
                                {
                                    // Check whether file is being installed to game update folder
                                    UpdateStatus(string.Format(Language.GetString("FILE_UNINSTALL_LOCATION"), $"{Path.GetFileName(installPath)} ({indexFiles}/{totalFiles})", parentFolderPath));

                                    if (XboxExtensions.FileExists(parentFolderPath, installPath))
                                    {
                                        MainWindow.XboxConsole.DeleteFile(installPath);
                                    }

                                    UpdateStatus(Language.GetString("FILE_UNINSTALL_SUCCESS"));
                                    indexFiles++;
                                }

                                IsSuccessful = true;

                                Settings.RemoveInstalledMods(ConsoleProfile, Category.Id, appItem.Id, false);

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
        public async Task DownloadApplication(AppItemData appItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                AppItemFile downloadFiles = appItem.DownloadFiles.First();

                progress.Report(50);

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING"));
                appItem.DownloadInstallFiles(downloadFiles);

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS"));

                LocalPath = Path.GetDirectoryName(downloadFiles.GetInstallPath(appItem.TitleId));

                progress.Report(100);

                IsSuccessful = true;
            });
        }

        /// <summary> 
        /// Install the specified <see cref="GameSaveItemData"/> files.
        /// </summary>
        public async Task InstallGameSave(GameSaveItemData gameSaveItem, IProgress<int> progress)
        {
            progress.Report(0);

            // Run the download operation
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

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING_EXTRACTING_ARCHIVE"));
                gameSaveItem.DownloadInstallFiles(downloadFiles, Category);
                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS"));

                progress.Report(40);

                if (Settings.InstallGameSavesToUsbDevice)
                {
                    UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                    List<ListItem> localUsbDevices = UsbExtensions.GetLocalUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        _ = GetDialogResult(Language.GetString("INSERT_USB_DEVICE"), Language.GetString("NO_USB_DEVICES"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                        progress.Report(0);
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
                            _ = Directory.CreateDirectory(installPath);

                            foreach (string installFilePath in downloadFiles.InstallPaths)
                            {
                                // Install files
                                foreach (string localFilePath in Directory.GetFiles(gameSaveItem.DownloadDataDirectory(downloadFiles, Category), "*.*", SearchOption.AllDirectories))
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

                            progress.Report(80);

                            if (Settings.CleanUpLocalFilesAfterInstalling)
                            {
                                try
                                {
                                    UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                    Directory.Delete(gameSaveItem.DownloadDataDirectory(downloadFiles, Category), true);
                                    File.Delete(gameSaveItem.ArchiveZipFile(downloadFiles, Category));
                                }
                                catch { }
                            }

                            IsSuccessful = true;

                            progress.Report(100);

                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (WebException ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                        catch (Exception ex)
                        {
                            progress.Report(0);
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
                                            progress.Report(0);
                                            return;
                                        }

                                        UpdateStatus(Language.GetString("FOUND_USB_DEVICE"));
                                    }
                                    else
                                    {
                                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                                        return;
                                    }
                                }
                                else
                                {
                                    usbDevice = string.Empty;
                                }

                                progress.Report(50);

                                foreach (string installFilePath in downloadFiles.InstallPaths)
                                {
                                    // Install files
                                    foreach (string localFilePath in Directory.GetFiles(gameSaveItem.DownloadDataDirectory(downloadFiles, Category), "*.*", SearchOption.AllDirectories))
                                    {
                                        string localFileName = Path.GetFileName(localFilePath);

                                        string installPath = installFilePath
                                        .Replace("{USBDEV}", usbDevice);

                                        string parentFolderPath = Path.GetDirectoryName(installPath).Replace(@"\", "/");

                                        // Check whether install file matches the specified install file
                                        if (installPath.EndsWith(localFileName))
                                        {
                                            UpdateStatus(string.Format(Language.GetString("FILE_INSTALL_LOCATION"), $"{localFileName} ({indexFiles}/{totalFiles})", parentFolderPath));
                                            _ = FtpExtensions.UploadFile(localFilePath, installPath);
                                            UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                            indexFiles++;
                                        }
                                    }
                                }

                                progress.Report(90);

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(gameSaveItem.DownloadDataDirectory(downloadFiles, Category), true);
                                        File.Delete(gameSaveItem.ArchiveZipFile(downloadFiles, Category));
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                if (MainWindow.IsWebManInstalled)
                                {
                                    WebManExtensions.NotifyPopup(MainWindow.ConsoleProfile.Address, $"{Category.Title}\nInstalled {downloadFiles.Name} ({indexFiles - 1} files)");
                                }

                                progress.Report(100);

                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (FtpCommandException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (WebException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
                                    foreach (string localFilePath in Directory.GetFiles(gameSaveItem.DownloadDataDirectory(downloadFiles, Category), "*.*", SearchOption.AllDirectories))
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

                                progress.Report(80);

                                if (Settings.CleanUpLocalFilesAfterInstalling)
                                {
                                    try
                                    {
                                        UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                        Directory.Delete(gameSaveItem.DownloadDataDirectory(downloadFiles, Category), true);
                                        File.Delete(gameSaveItem.ArchiveZipFile(downloadFiles, Category));
                                    }
                                    catch { }
                                }

                                IsSuccessful = true;

                                progress.Report(100);

                                // Log status
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + $" {(Category.CategoryType == CategoryType.Game ? Language.GetString("READY_TO_START_GAME") : string.Empty)}");
                            }
                            catch (WebException ex)
                            {
                                progress.Report(0);
                                UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                            }
                            catch (Exception ex)
                            {
                                progress.Report(0);
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
        public async Task DownloadGameSave(GameSaveItemData gameSaveItem, IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                try
                {
                    UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                    string downloadFolder = Settings.PathDownloads.GetFullPath(Settings.PathAppData);

                    if (!Directory.Exists(downloadFolder))
                    {
                        UpdateStatus(Language.GetString("DOWNLOAD_FOLDER_NOT_FOUND"));
                        progress.Report(0);
                        return;
                    }

                    string downloadLocation = downloadFolder + @"\" + gameSaveItem.Name.RemoveInvalidChars() + ".pkg";

                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_LOCATION"), $"{gameSaveItem.Name}.pkg", downloadFolder));
                    HttpExtensions.DownloadFile(gameSaveItem.DownloadFiles[0].Url, downloadLocation);
                    UpdateStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));

                    progress.Report(50);

                    LocalPath = downloadFolder;

                    progress.Report(100);

                    IsSuccessful = true;
                }
                catch (WebException ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILE_DOWNLOAD_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="ModItemData"/> files.
        /// </summary>
        public async Task InstallTrainer(IProgress<int> progress)
        {
            UpdateStatus(Language.GetString("PREPARING_INSTALL"));
            Program.Log.Info(TrainerItem.Name + " (" + TrainerGame.TitleId + ")");

            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("GETTING_DOWNLOAD_FILES"));

                int indexFiles = 1;
                int totalFiles = TrainerItem.InstallPaths.Count();

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING_EXTRACTING_ARCHIVE"));
                TrainerGame.DownloadInstallFiles(TrainerItem);

                progress.Report(30);

                if (Settings.InstallGameModsToUsbDevice)
                {
                    UpdateStatus(Language.GetString("GETTING_USB_DEVICE"));

                    List<ListItem> localUsbDevices = UsbExtensions.GetLocalUsbDevices();

                    if (localUsbDevices.Count < 1)
                    {
                        _ = GetDialogResult(Language.GetString("INSERT_USB_DEVICE"), Language.GetString("NO_USB_DEVICES"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICES_CONNECTED"), Language.GetString("INSTALL_CANCELED")));
                        progress.Report(0);
                        return;
                    }

                    ListItem selectedUsbDevice = DialogExtensions.ShowListViewDialog(this, Language.GetString("USB_DEVICES"), localUsbDevices);

                    if (selectedUsbDevice == null)
                    {
                        UpdateStatus(string.Join(" ", Language.GetString("NO_USB_DEVICE_SELECTED"), Language.GetString("INSTALL_CANCELED")));
                    }
                    else
                    {
                        string installPath = $@"{selectedUsbDevice.Value}Mods\{TrainerGame.TitleId.RemoveInvalidChars()}\{TrainerItem.Name.RemoveInvalidChars()}\";
                        LocalPath = installPath;

                        try
                        {
                            progress.Report(60);

                            _ = Directory.CreateDirectory(installPath);

                            foreach (string installFilePath in TrainerItem.InstallPaths)
                            {
                                // Install files
                                foreach (string localFilePath in Directory.GetFiles(TrainerGame.DownloadDataDirectory(TrainerItem), "*.*", SearchOption.AllDirectories))
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

                            progress.Report(90);

                            if (Settings.CleanUpLocalFilesAfterInstalling)
                            {
                                try
                                {
                                    UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                                    Directory.Delete(TrainerGame.DownloadDataDirectory(TrainerItem), true);
                                    File.Delete(TrainerGame.ArchiveZipFile(TrainerItem));
                                }
                                catch { }
                            }

                            progress.Report(100);

                            IsSuccessful = true;

                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1));
                        }
                        catch (WebException ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                        catch (Exception ex)
                        {
                            progress.Report(0);
                            UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                        }
                    }

                    return;
                }

                try
                {
                    UpdateStatus(Language.GetString("STARTING_INSTALL"));

                    progress.Report(50);

                    foreach (string installFilePath in TrainerItem.InstallPaths)
                    {
                        // Install files
                        foreach (string localFilePath in Directory.GetFiles(TrainerGame.DownloadDataDirectory(TrainerItem), "*.*", SearchOption.AllDirectories))
                        {
                            string installPath = installFilePath
                            .Replace("{AURORAPATH}", Settings.AuroraFolderPath);

                            string installFileName = Path.GetFileName(installPath);

                            installPath = installPath.Replace("\\\\", "\\");

                            // Check whether install file matches the specified install file
                            if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.OrdinalIgnoreCase))
                            {
                                UpdateStatus($"Installing file: {installFileName} ({indexFiles}/{totalFiles}) to {installPath}");

                                /* Local Parent Folder Name */
                                //int lastSlashIndex = localFilePath.Replace("\\\\", "\\").LastIndexOf('\\');
                                //int secondLastSlashIndex = localFilePath.Replace("\\\\", "\\").LastIndexOf('\\', lastSlashIndex - 1);
                                //string parentFolder = localFilePath.Replace("\\\\", "\\").Substring(secondLastSlashIndex + 1, lastSlashIndex - secondLastSlashIndex - 1);
                                /* Local Parent Folder Name */

                                string installFileParentPath = XboxExtensions.GetParentFolder(installPath.Replace("\\\\", "\\"));

                                /* Parent Folder Name & Path Leading to Parent Folder */
                                string auroraParentFolder = string.Empty;
                                string auroraParentFolderPath = string.Empty;

                                string normalizedPath = Settings.AuroraFolderPath.TrimEnd('\\', '/');

                                int lastSlashIndex = normalizedPath.LastIndexOf('\\');

                                if (lastSlashIndex >= 0)
                                {
                                    auroraParentFolder = normalizedPath.Substring(lastSlashIndex + 1);

                                    auroraParentFolderPath = normalizedPath.Substring(0, lastSlashIndex) + "\\";

                                    //Program.Log.Info("Aurora Parent folder: " + auroraParentFolder);
                                    //Program.Log.Info("Aurora Path leading up to the parent folder: " + auroraParentFolderPath);
                                }
                                else
                                {
                                    Program.Log.Error("Invalid Aurora Path");
                                }

                                //string auroraDirectoryPath = Path.GetDirectoryName(Settings.AuroraFolderPath.TrimEnd('\\'));
                                //DirectoryInfo auroraDirectoryInfo = new(auroraDirectoryPath);
                                //string auroraParentFolder = auroraDirectoryInfo.Name;
                                //string auroraParentFolderPath = auroraDirectoryInfo.Parent.FullName;
                                /* Parent Folder Name & Path Leading to Parent Folder */

                                /* Parent Folder Name & Path Leading to Parent Folder */
                                //string installDirectoryPath = Path.GetDirectoryName(installPath);
                                //DirectoryInfo installDirectoryInfo = new(installDirectoryPath);
                                //string installParentFolder = installDirectoryInfo.Name;
                                //string installParentFolderPath = installDirectoryInfo.Parent.FullName;
                                /* Parent Folder Name & Path Leading to Parent Folder */

                                Program.Log.Info("Local File Path: " + localFilePath.Replace("\\\\", "\\").Replace("\\\\", "\\"));
                                Program.Log.Info("Console File Parent Path: " + installFileParentPath);
                                Program.Log.Info("Console File Path: " + installPath);
                                Program.Log.Info("Aurora Parent Directory: " + auroraParentFolderPath);
                                Program.Log.Info("Aurora Parent Folder: " + auroraParentFolder);

                                if (TrainerItem.GetType() == TrainerType.Aurora)
                                {
                                    if (!XboxExtensions.PathExists(auroraParentFolderPath, auroraParentFolder))
                                    {
                                        _ = GetDialogResult(string.Format(Language.GetString("AURORA_PATH_DOESNT_EXIST"), Settings.AuroraFolderPath), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        UpdateStatus(Language.GetString("INSTALL_CANCELED"));
                                        return;
                                    }

                                    if (File.Exists(localFilePath))
                                    {
                                        MainWindow.XboxConsole.CreateDirectoryRecursive(installFileParentPath);

                                        MainWindow.XboxConsole.SendFile(localFilePath.Replace("\\\\", "\\").Replace("\\\\", "\\"), installPath);

                                        UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                        indexFiles++;
                                    }
                                    else
                                    {
                                        progress.Report(0);
                                        UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), "Local File Doesn't Exist"));
                                    }

                                    //if (!XboxExtensions.PathExists(@"Hdd:\", "ArisenStudio"))
                                    //    MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\");

                                    //if (!XboxExtensions.PathExists(@"Hdd:\ArisenStudio\", modItem.CategoryId.ToUpper()))
                                    //    MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\" + modItem.CategoryId.ToUpper() + @"\");
                                }
                                else
                                {
                                    if (!XboxExtensions.PathExists(@"Hdd:\ArisenStudio\Trainers\", TrainerGame.TitleId))
                                    {
                                        MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\Trainers\" + TrainerGame.TitleId + @"\");
                                    }

                                    if (!XboxExtensions.PathExists(@"Hdd:\ArisenStudio\Trainers\" + TrainerGame.TitleId, TrainerItem.Name))
                                    {
                                        MainWindow.XboxConsole.MakeDirectory(@"Hdd:\ArisenStudio\" + TrainerGame.TitleId.ToUpper() + @"\" + TrainerItem.Name + @"\");
                                    }

                                    MainWindow.XboxConsole.SendFile(localFilePath.Replace("\\\\", "\\").Replace("\\\\", "\\"), installPath);

                                    UpdateStatus(Language.GetString("FILE_INSTALL_SUCCESS"));

                                    indexFiles++;
                                }
                            }
                        }
                    }

                    progress.Report(80);

                    if (Settings.CleanUpLocalFilesAfterInstalling)
                    {
                        try
                        {
                            UpdateStatus(Language.GetString("CLEANING_INSTALL_FILES"));

                            Directory.Delete(TrainerGame.DownloadDataDirectory(TrainerItem), true);
                            File.Delete(TrainerGame.ArchiveZipFile(TrainerItem));
                        }
                        catch { }
                    }

                    progress.Report(100);

                    IsSuccessful = true;

                    // Update installed mods
                    //Settings.UpdateInstalledMods(ConsoleProfile, Category.Id, Category.CategoryType, modItem.Id, indexFiles - 1, DateTime.Now, downloadFiles);

                    // Log status
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_SUCCESS"), indexFiles - 1) + " " + Language.GetString("READY_TO_START_GAME"));
                }
                catch (WebException ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                }
                catch (Exception ex)
                {
                    progress.Report(0);
                    UpdateStatus(string.Format(Language.GetString("FILES_INSTALL_ERROR"), ex.Message), ex);
                }
            });
        }

        /// <summary> 
        /// Install the specified <see cref="TrainerItem"/> files.
        /// </summary>
        public async Task DownloadTrainer(IProgress<int> progress)
        {
            progress.Report(0);

            await Task.Run(() =>
            {
                UpdateStatus(Language.GetString("PREPARING_DOWNLOAD"));

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOADING"));

                TrainerGame.DownloadInstallFiles(TrainerItem);

                progress.Report(50);

                UpdateStatus(Language.GetString("ARCHIVE_DOWNLOAD_SUCCESS"));

                LocalPath = Path.GetDirectoryName(TrainerGame.ArchiveZipFile(TrainerItem));

                IsSuccessful = true;
            });

            // Report final progress (100%)
            progress.Report(100);

            UpdateStatus("DOWNLOAD COMPLETED");
        }

        private void ButtonOpenPath_Click(object sender, EventArgs e)
        {
            _ = Process.Start(LocalPath);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateStatus(string status, Exception ex = null)
        {
            if (LabelStatus.InvokeRequired)
            {
                _ = LabelStatus.BeginInvoke((MethodInvoker)delegate
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