using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Forms;
using FluentFTP;
using Microsoft.VisualBasic.FileIO;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Models.Resources;
using ModioX.Net;
using ModioX.Properties;
using FtpException = FluentFTP.FtpException;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Windows
{
    public partial class FileManagerWindow : DarkForm
    {
        private readonly DriveInfo[] localDrives = DriveInfo.GetDrives();

        public FileManagerWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Contains the console profile data.
        /// </summary>
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;

        /// <summary>
        ///     Creates an FTP connection for use with uploading mods, not reliable for the built-in file manager.
        /// </summary>
        public static FtpConnection FtpConnection = MainWindow.FtpConnection;

        /// <summary>
        ///     Conntains the FtpClient for use with the built-in file manager.
        /// </summary>
        public static FtpClient FtpClient { get; set; } = MainWindow.FtpClient;

        /// <summary>
        ///     Gets/sets the current local directory path
        /// </summary>
        public string LocalDirectoryPath { get; set; } = @"C:\";

        /// <summary>
        ///     Get/sets the current ftp directory path
        /// </summary>
        public string FtpDirectoryPath { get; set; } = "/dev_hdd0/";

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            MenuItemSettingsSaveLocalPath.Checked = MainWindow.Settings.SaveLocalPath;
            MenuItemSettingsSaveConsolePath.Checked = MainWindow.Settings.SaveConsolePath;

            _ = DgvLocalFiles.Focus();

            SetConsoleStatus("Fetching drives...");

            foreach (var driveInfo in localDrives)
            {
                _ = ComboBoxLocalDrives.Items.Add(driveInfo.Name.Replace(@"\", ""));
            }

            if (MainWindow.Settings.SaveLocalPath)
            {
                if (MainWindow.Settings.LocalPath.Equals(@"\") || string.IsNullOrEmpty(MainWindow.Settings.LocalPath))
                {
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                }
                else
                {
                    LoadLocalDirectory(MainWindow.Settings.LocalPath);
                }
            }
            else
            {
                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
            }
        }

        private void FileExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxLocalPath.Text))
            {
                MainWindow.Settings.LocalPath = TextBoxLocalPath.Text;
            }

            if (!string.IsNullOrWhiteSpace(TextBoxConsolePath.Text))
            {
                MainWindow.Settings.ConsolePath = TextBoxConsolePath.Text;
            }
        }

        private void MenuItemSettingsSaveLocalDirectoryPath_Click(object sender, EventArgs e)
        {
            MainWindow.Settings.SaveLocalPath = MenuItemSettingsSaveLocalPath.Checked;
        }

        private void MenuItemSettingsSaveConsolePath_Click(object sender, EventArgs e)
        {
            MainWindow.Settings.SaveConsolePath = MenuItemSettingsSaveConsolePath.Checked;
        }

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            SetConsoleStatus("Fetching root directories...");

            foreach (var driveName in FtpExtensions.GetFolderNames("/").ToArray())
            {
                _ = ComboBoxConsoleDrives.Items.Add(driveName.Replace(@"/", ""));
            }

            if (MainWindow.Settings.SaveConsolePath)
            {
                if (MainWindow.Settings.ConsolePath.Equals(@"/") || string.IsNullOrEmpty(MainWindow.Settings.ConsolePath))
                {
                    LoadConsoleDirectory("/dev_hdd0/");
                }
                else
                {
                    LoadConsoleDirectory(MainWindow.Settings.ConsolePath);
                }
            }
            else
            {
                LoadConsoleDirectory("/dev_hdd0/");
            }

            WaitLoadConsole.Enabled = false;
        }

        /* Local Explorer */

        private void ComboBoxLocalDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocalDirectory(ComboBoxLocalDrives.GetItemText(ComboBoxLocalDrives.SelectedItem) + @"\");
        }

        private void ButtonLocalDirectory_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog { ShowNewFolderButton = true })
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    LocalDirectoryPath = folderBrowser.SelectedPath;

                    if (Directory.Exists(folderBrowser.SelectedPath))
                    {
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
            }
        }

        private void DgvLocalFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var type = DgvLocalFiles.CurrentRow == null ? "" : DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
            var name = DgvLocalFiles.CurrentRow == null ? "" : DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            if (name == "..")
            {
                var trimLastIndex = Path.GetDirectoryName(LocalDirectoryPath).TrimEnd('\\');
                var parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";

                if (Directory.Exists(parentDirectory))
                {
                    LoadLocalDirectory(parentDirectory);
                }
            }
            else if (type == "folder")
            {
                LoadLocalDirectory(LocalDirectoryPath + DgvLocalFiles.CurrentRow.Cells[2].Value + @"\");
            }

            ToolStripLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalPath.Text);
        }

        private void DgvLocalFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                var type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripLocalUpload.Enabled = (type == "file") & (name != "..");
                ToolStripLocalDelete.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuLocallUploadFile.Enabled = (type == "file") & (type != "..");
                ContextMenuLocalDeleteFile.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuLocalRenameFile.Enabled = (type == "file") & (name != "..");
                ContextMenuLocalRenameFolder.Enabled = (type == "folder") & (name != "..");
            }
        }

        private void DgvLocalFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                var type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripLocalUpload.Enabled = (type == "file") & (name != "..");
                ToolStripLocalDelete.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuLocallUploadFile.Enabled = (type == "file") & (name != "..");
                ContextMenuLocalDeleteFile.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuLocalRenameFile.Enabled = (type == "file") & (name != "..");
                ContextMenuLocalRenameFolder.Enabled = (type == "folder") & (name != "..");
            }
        }

        private void ToolStripLocalUploadFile_Click(object sender, EventArgs e)
        {
            UploadLocalFile();
        }

        private void ToolStripLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalItem();
        }

        private void ToolStripLocalNewFolder_Click(object sender, EventArgs e)
        {
            var newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ", "");

            if (newName != null)
            {
                _ = Directory.CreateDirectory(TextBoxLocalPath.Text + @"\" + newName);
                LoadLocalDirectory(LocalDirectoryPath);
            }
        }

        private void ToolStripLocalRefresh_Click(object sender, EventArgs e)
        {
            LoadLocalDirectory(LocalDirectoryPath);
        }

        private void ToolStripLocalOpenExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                _ = Process.Start("explorer.exe", TextBoxLocalPath.Text);
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error opening file explorer for path: {TextBoxLocalPath.Text} - {ex.Message}", ex);
            }
        }

        private void ContextMenuLocalFileUpload_Click(object sender, EventArgs e)
        {
            ToolStripLocalUpload.PerformClick();
        }

        private void ContextMenuLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalItem();
        }

        private void ContextMenuLocalRenameFile_Click(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                var oldFileName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                var filePath = TextBoxLocalPath.Text + @"\" + oldFileName;

                var newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name: ", oldFileName);

                var newFilePath = TextBoxLocalPath.Text + @"\" + newFileName;

                if (newFileName != null && newFileName.Equals(oldFileName))
                {
                    if (!File.Exists(newFilePath))
                    {
                        SetConsoleStatus($"A file with this name already exists.");
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming file {filePath} to: {newFileName}");
                        FileSystem.RenameFile(filePath, newFileName);
                        SetConsoleStatus($"Successfully renamed file to: {newFileName}");
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
            }
        }

        private void ContextMenuLocalRenameFolder_Click(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                var oldFolderName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                var folderPath = TextBoxLocalPath.Text + @"\" + oldFolderName;

                var newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name: ", oldFolderName);

                var newFolderPath = TextBoxLocalPath.Text + @"\" + newFolderName;

                if (newFolderName != null && newFolderName.Equals(oldFolderName))
                {
                    if (!Directory.Exists(newFolderPath))
                    {
                        SetLocalStatus($"A folder with this name already exists.");
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming file {folderPath} to: {newFolderName}");
                        FileSystem.RenameDirectory(folderPath, newFolderName);
                        SetConsoleStatus($"Successfully renamed folder to: {newFolderName}");
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
            }
        }

        private void ContextMenuLocalRefresh_Click(object sender, EventArgs e)
        {
            LoadLocalDirectory(LocalDirectoryPath);
        }

        /// <summary>
        ///     Loads files and folders into the local datagridview
        /// </summary>
        /// <param name="directoryPath"></param>
        public void LoadLocalDirectory(string directoryPath)
        {
            try
            {
                DgvLocalFiles.Rows.Clear();

                LocalDirectoryPath = directoryPath.Replace("\\", @"\");
                TextBoxLocalPath.Text = LocalDirectoryPath;

                SetLocalStatus($"Fetching directory listing of '{LocalDirectoryPath}'...");

                ComboBoxLocalDrives.SelectedIndexChanged -= ComboBoxLocalDrives_SelectedIndexChanged;
                ComboBoxLocalDrives.SelectedItem = LocalDirectoryPath.Substring(0, 2);
                ComboBoxLocalDrives.SelectedIndexChanged += ComboBoxLocalDrives_SelectedIndexChanged;

                var isParentRoot = localDrives.Any(x => x.Name.Equals(LocalDirectoryPath.Replace(@"\\", @"\")));

                if (!isParentRoot)
                {
                    _ = DgvLocalFiles.Rows.Add("folder", Resources.folder, "..", "<DIRECTORY>",
                        Directory.GetLastWriteTime(LocalDirectoryPath));
                }

                int folders = 0;
                int files = 0;
                long totalBytes = 0;

                foreach (var directoryItem in Directory.GetDirectories(LocalDirectoryPath))
                {
                    _ = DgvLocalFiles.Rows.Add("folder", Resources.folder, Path.GetFileName(directoryItem), "<DIRECTORY>", Directory.GetLastWriteTime(directoryItem));

                    folders++;
                }

                foreach (var fileItem in Directory.GetFiles(LocalDirectoryPath))
                {
                    var fileBytes = new FileInfo(fileItem).Length;

                    _ = DgvLocalFiles.Rows.Add("file", Resources.file, Path.GetFileName(fileItem), fileBytes.ToString("n0", CultureInfo.CurrentCulture) + " bytes", File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                string statusFiles = files > 0 ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : "")}" : "" + $"{(folders < 1 ? "." : "")}";
                string statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = files > 0 ? $"Total size: {totalBytes.ToString("n0", CultureInfo.CurrentCulture)} bytes" : "";

                if (files < 1 && folders < 1)
                {
                    SetLocalStatus("Empty directory.");
                }
                else
                {
                    SetLocalStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error fetching directory listing for path: {LocalDirectoryPath} - {ex.Message}", ex);

                try
                {
                    // Attempt to reload the parent directory listing
                    LoadLocalDirectory(Path.GetDirectoryName(LocalDirectoryPath) + @"\");
                }
                catch
                {
                }
            }
        }

        /* Console Explorer */

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConsoleDirectory("/" + ComboBoxConsoleDrives.GetItemText(ComboBoxConsoleDrives.SelectedItem) + "/");
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsolePath.Text);
        }

        private void DgvConsoleFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (name == "..") // Go to parent directory
                {
                    var trimLastIndex = Path.GetDirectoryName(FtpDirectoryPath).Replace(@"\", "/").TrimEnd('/');
                    var parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf("/")) + "/";

                    LoadConsoleDirectory(parentDirectory);
                }
                else if (type == "folder") // Go to selected folder directory
                {
                    LoadConsoleDirectory(FtpDirectoryPath + DgvConsoleFiles.CurrentRow.Cells[2].Value + "/");
                }
            }
        }

        private void DgvConsoleFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripConsoleDownload.Enabled = (type == "file") & (name != "..");
                ToolStripConsoleDelete.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuItemConsoleDownloadFile.Enabled = (type == "file") & (name != "..");
                ContextMenuItemConsoleDeleteFile.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuItemConsoleRenameFile.Enabled = (type == "file") & (name != "..");
                ContextMenuItemConsoleRenameFolder.Enabled = (type == "folder") & (name != "..");
            }
        }

        private void DgvConsoleFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripConsoleDownload.Enabled = (type == "file") & (name != "..");
                ToolStripConsoleDelete.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuItemConsoleDownloadFile.Enabled = (type == "file") & (name != "..");
                ContextMenuItemConsoleDeleteFile.Enabled = type == "file" || (type == "folder") & (name != "..");
                ContextMenuItemConsoleRenameFile.Enabled = (type == "file") & (name != "..");
                ContextMenuItemConsoleRenameFolder.Enabled = (type == "folder") & (name != "..");
            }
        }

        private void ToolStripConsoleDownload_Click(object sender, EventArgs e)
        {
            DownloadFromConsole();
        }

        private void ToolStripConsoleDelete_Click(object sender, EventArgs e)
        {
            DeleteConsoleItem();
        }

        private void ToolStripConsoleNewFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ", "");

                if (folderName != null)
                {
                    _ = FtpExtensions.CreateDirectory(FtpDirectoryPath + "/" + folderName);
                    LoadConsoleDirectory(FtpDirectoryPath);
                }
            }
            catch (FtpException ex)
            {
                _ = DarkMessageBox.Show(this, $"Unable to create new folder. Error: {ex.Message}", "Error",
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _ = DarkMessageBox.Show(this, $"Unable to create new folder. Error: {ex.Message}", "Error",
                    MessageBoxIcon.Error);
            }
        }

        private void ToolStripConsoleFileRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        private void ContextMenuConsoleDownloadFile_Click(object sender, EventArgs e)
        {
            ToolStripConsoleDownload.PerformClick();
        }

        private void ContextMenuConsoleDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteConsoleItem();
        }

        private void ContextMenuConsoleRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        private void ContextMenuItemConsoleRenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                var oldFileName = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                var filePath = TextBoxConsolePath.Text + oldFileName;

                var newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName);

                var newConsoleFilePath = TextBoxConsolePath.Text + newFileName;                

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (FtpClient.FileExists(newConsoleFilePath))
                    {
                        SetConsoleStatus($"A file with this name already exists.");
                        return;
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming file {filePath} to {newFileName}");
                        FtpExtensions.RenameFileOrFolder(FtpConnection, filePath, newFileName);
                        SetConsoleStatus($"Successfully renamed file to: {newFileName}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Unable to rename file. Error: {ex.Message}", ex);
            }
        }

        private void ContextMenuItemConsoleRenameFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var oldFolderName = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                var folderPath = TextBoxConsolePath.Text + oldFolderName;

                var newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName);

                var newFolderPath = TextBoxConsolePath.Text + newFolderName;                

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpClient.DirectoryExists(folderPath))
                    {
                        SetConsoleStatus($"A folder with this name already exists.");
                        return;
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming folder: {folderPath} to: {newFolderName}");
                        FtpExtensions.RenameFileOrFolder(FtpConnection, folderPath, newFolderName);
                        SetConsoleStatus($"Successfully renamed folder to: {newFolderName}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Unable to rename folder. Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        ///     Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath">Console path to retrieve</param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                DgvConsoleFiles.Rows.Clear();

                FtpDirectoryPath = directoryPath.Replace("//", "/");
                TextBoxConsolePath.Text = directoryPath.Replace("//", "/");

                SetConsoleStatus(string.Format("Fetching directory listing of '{0}'...", FtpDirectoryPath));

                var secondIndexOfSlash = FtpDirectoryPath.TrimStart('/').IndexOfNth("/");
                var rootPath = FtpDirectoryPath.Substring(1, secondIndexOfSlash);

                ComboBoxConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxConsoleDrives.SelectedItem = rootPath;
                ComboBoxConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                var isRoot = ComboBoxConsoleDrives.Items.Contains(FtpDirectoryPath.Replace("/", ""));

                if (!isRoot)
                {
                    _ = DgvConsoleFiles.Rows.Add("folder", Resources.folder, "..", "<DIRECTORY>", DateTime.MinValue);
                }

                FtpClient.SetWorkingDirectory(FtpDirectoryPath);

                List<FtpListItem> folders = new List<FtpListItem>();
                List<FtpListItem> files = new List<FtpListItem>();

                long totalBytes = 0;

                foreach (FtpListItem listItem in FtpClient.GetListing(FtpDirectoryPath))
                {
                    switch (listItem.Type)
                    {
                        case FtpFileSystemObjectType.Directory:
                            folders.Add(listItem);
                            break;

                        case FtpFileSystemObjectType.File:
                            files.Add(listItem);
                            break;

                        case FtpFileSystemObjectType.Link:
                            break;
                    }
                }

                foreach (FtpListItem listItem in folders.OrderBy(x => x.Name))
                {
                    _ = DgvConsoleFiles.Rows.Add("folder", Resources.folder, listItem.Name, "<DIRECTORY>", listItem.Modified);
                }

                foreach (FtpListItem listItem in files.OrderBy(x => x.Name))
                {
                    _ = DgvConsoleFiles.Rows.Add("file", Resources.file, listItem.Name, listItem.Size.ToString("n0", CultureInfo.CurrentCulture) + " bytes", listItem.Modified);
                    totalBytes += listItem.Size;
                }

                string statusFiles = files.Count > 0 ? $"{files.Count} {(files.Count <= 1 ? "file" : "files")} {(files.Count > 0 && folders.Count > 0 ? "and " : "")}" : "" + $"{(folders.Count < 1 ? "." : "")}";
                string statusFolders = folders.Count > 0 ? $"{folders.Count} {(folders.Count <= 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = files.Count > 0 ? $"Total size: {totalBytes.ToString("n0", CultureInfo.CurrentCulture)} bytes" : "";

                if (files.Count < 1 && folders.Count < 1)
                {
                    SetConsoleStatus("Empty directory.");
                }
                else
                {
                    SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                }
            }
            catch (FtpException ex)
            {
                SetConsoleStatus($"Error fetching directory listing for path: {FtpDirectoryPath}", ex);
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Error fetching directory listing for path: {FtpDirectoryPath}", ex);
            }
        }

        public void UploadLocalFile()
        {
            try
            {
                var type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                var localName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (type.Equals("file"))
                {
                    var localPath = TextBoxLocalPath.Text + localName;
                    var consolePath = TextBoxConsolePath.Text + localName;

                    if (File.Exists(localPath))
                    {
                        SetLocalStatus($"Uploading file to {consolePath}...");
                        FtpExtensions.UploadFile(MainWindow.FtpConnection, localPath, consolePath);
                        SetLocalStatus($"Successfully uploaded file: {Path.GetFileName(localPath)}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                    else
                    {
                        SetLocalStatus("Unable to upload file as it doesn't exist on your computer.");
                    }
                }
                else if (type.Equals("folder"))
                {
                    var localPath = TextBoxLocalPath.Text + localName + @"\";
                    var consolePath = TextBoxConsolePath.Text + localName;

                    SetLocalStatus($"Uploading folder to {consolePath}...");
                    //MainWindow.FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
                    SetLocalStatus($"Successfully uploaded folder: {localPath}");
                    LoadConsoleDirectory(FtpDirectoryPath);
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Unable to upload to console. Error: {ex.Message}", ex);
            }
        }

        public void DeleteLocalItem()
        {
            try
            {
                if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    var type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                    var name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                    if (!name.Equals(".."))
                    {
                        var selectedItem = TextBoxLocalPath.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value;

                        if (type.Equals("folder"))
                        {
                            SetLocalStatus($"Deleting folder: {selectedItem}");
                            UserFolders.DeleteDirectory(selectedItem);
                            SetLocalStatus($"Successfully deleted folder: {name}");
                        }
                        else if (type.Equals("file"))
                        {
                            if (File.Exists(selectedItem))
                            {
                                SetLocalStatus($"Deleting file: {selectedItem}");
                                File.Delete(selectedItem);
                                SetLocalStatus($"Successfully deleted file: {name}");
                            }
                        }
                    }

                    DgvLocalFiles.Rows.RemoveAt(DgvLocalFiles.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Unable to delete item. Error: {ex.Message}", ex);
            }
        }

        public void DownloadFromConsole()
        {
            try
            {
                var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (type.Equals("file"))
                {
                    var consoleFile = TextBoxConsolePath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value;
                    var localFile = TextBoxLocalPath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value;

                    if (File.Exists(localFile))
                    {
                        File.Delete(localFile);
                    }

                    SetConsoleStatus($"Downloading file: {Path.GetFileName(localFile)}");
                    FtpExtensions.DownloadFile(localFile, consoleFile);
                    //_ = MainWindow.FtpClient.DownloadFile(localFile, consoleFile);
                    SetConsoleStatus($"Successfully downloaded file: {Path.GetFileName(localFile)}");
                }
                else if (type.Equals("folder"))
                {
                    var consolePath = TextBoxConsolePath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value + "/";
                    var localPath = TextBoxLocalPath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value;

                    if (Directory.Exists(localPath))
                    {
                        Directory.Delete(localPath, true);
                    }

                    SetConsoleStatus($"Downloading folder: {consolePath}");
                    //FtpExtensions.DownloadDirectory(consolePath, localPath);
                    FtpClient.DownloadDirectory(localPath, consolePath, FtpFolderSyncMode.Mirror, FtpLocalExists.Overwrite);
                    SetConsoleStatus($"Successfully downloaded folder to: {localPath}");
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Error downloading console file. {ex.Message}", ex);
            }

            LoadLocalDirectory(LocalDirectoryPath);
        }

        public void DeleteConsoleItem()
        {
            try
            {
                if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                    var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                    var itemPath = TextBoxConsolePath.Text + name;

                    if (type.Equals("folder"))
                    {
                        SetConsoleStatus($"Deleting folder: {itemPath}");

                        FtpExtensions.DeleteDirectory(FtpClient, itemPath);

                        SetConsoleStatus("Successfully deleted folder.");
                    }
                    else if (type.Equals("file"))
                    {
                        SetConsoleStatus($"Deleting file: {itemPath}");
                        FtpExtensions.DeleteFile(FtpClient, itemPath);
                        SetConsoleStatus("Successfully deleted file.");
                    }

                    DgvConsoleFiles.Rows.RemoveAt(DgvConsoleFiles.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Unable to delete item. Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        ///     Set the current status in the local tool strip
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetLocalStatus(string status, Exception ex = null)
        {
            ToolStripLabelLocalStatus.Text = status;

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
        ///     Set the current process status in the console tool strip
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetConsoleStatus(string status, Exception ex = null)
        {
            ToolStripLabelConsoleStatus.Text = status;

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

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Removes dotted borders from the cells on focus
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }
    }
}