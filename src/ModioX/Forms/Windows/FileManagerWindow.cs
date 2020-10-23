using DarkUI.Forms;
using FluentFTP;
using Microsoft.VisualBasic.FileIO;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Forms.Windows
{
    public partial class FileManagerWindow : DarkForm
    {
        public FileManagerWindow()
        {
            InitializeComponent();
        }

        private readonly DriveInfo[] localDrives = DriveInfo.GetDrives();

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            MenuItemSettingsSaveLocalPath.Checked = MainWindow.SettingsData.SaveLocalPath;
            MenuItemSettingsSaveConsolePath.Checked = MainWindow.SettingsData.SaveConsolePath;

            _ = DgvLocalFiles.Focus();

            SetConsoleStatus($"Fetching drives...");

            foreach (DriveInfo driveInfo in localDrives)
            {
                _ = ComboBoxLocalDrives.Items.Add(driveInfo.Name.Replace(@"\", ""));
            }

            if (MainWindow.SettingsData.SaveLocalPath)
            {
                if (MainWindow.SettingsData.LocalPath.Equals(@"\") || string.IsNullOrEmpty(MainWindow.SettingsData.LocalPath))
                {
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                }
                else
                {
                    LoadLocalDirectory(MainWindow.SettingsData.LocalPath);
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
                MainWindow.SettingsData.LocalPath = TextBoxLocalPath.Text;
            }

            if (!string.IsNullOrWhiteSpace(TextBoxConsolePath.Text))
            {
                MainWindow.SettingsData.ConsolePath = TextBoxConsolePath.Text;
            }
        }

        private void MenuItemSettingsSaveLocalDirectoryPath_Click(object sender, EventArgs e)
        {
            MainWindow.SettingsData.SaveLocalPath = MenuItemSettingsSaveLocalPath.Checked;
        }

        private void MenuItemSettingsSaveConsolePath_Click(object sender, EventArgs e)
        {
            MainWindow.SettingsData.SaveConsolePath = MenuItemSettingsSaveConsolePath.Checked;
        }

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            SetConsoleStatus($"Fetching root directories...");

            foreach (string driveName in Extensions.FtpExtensions.GetFolderNames(MainWindow.FtpClient, "/").ToArray())
            {
                _ = ComboBoxConsoleDrives.Items.Add(driveName.Replace(@"/", ""));
            }

            if (MainWindow.SettingsData.SaveConsolePath)
            {
                if (MainWindow.SettingsData.LocalPath.Equals(@"/") || string.IsNullOrEmpty(MainWindow.SettingsData.ConsolePath))
                {
                    LoadConsoleDirectory("/dev_hdd0/");
                }
                else
                {
                    LoadConsoleDirectory(MainWindow.SettingsData.ConsolePath);
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

        private void DgvLocalFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = DgvLocalFiles.CurrentRow == null ? "" : DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
            string name = DgvLocalFiles.CurrentRow == null ? "" : DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            if (name == "..")
            {
                //string parentDirectory = Directory.GetParent(LocalDirectoryPath.TrimEnd(new char[] { '\\' })).FullName;

                string trimLastIndex = Path.GetDirectoryName(LocalDirectoryPath).TrimEnd(new char[] { '\\' });
                string parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";

                if (Directory.Exists(parentDirectory))
                {
                    LoadLocalDirectory(parentDirectory);
                }
            }
            else if (type == "folder")
            {
                LoadLocalDirectory(LocalDirectoryPath + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString() + @"\");
            }

            ToolStripLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalPath.Text);
        }

        private void ButtonLocalDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
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

        private void DgvLocalFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripLocalUpload.Enabled = type == "file" & name != "..";
                ToolStripLocalDelete.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuLocallUploadFile.Enabled = type == "file"  & type != "..";
                ContextMenuLocalDeleteFile.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuLocalRenameFile.Enabled = type == "file" & name != "..";
                ContextMenuLocalRenameFolder.Enabled = type == "folder" & name != "..";
            }
        }

        private void DgvLocalFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripLocalUpload.Enabled = type == "file" & name != "..";
                ToolStripLocalDelete.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuLocallUploadFile.Enabled = type == "file" & name != "..";
                ContextMenuLocalDeleteFile.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuLocalRenameFile.Enabled = type == "file" & name != "..";
                ContextMenuLocalRenameFolder.Enabled = type == "folder" & name != "..";
            }
        }

        private void ToolStripLocalUploadFile_Click(object sender, EventArgs e)
        {
            UploadLocalFile();
        }

        private void ToolStripLocalDeleteFile_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteLocalItem();
            }
        }

        private void ToolStripLocalNewFolder_Click(object sender, EventArgs e)
        {
            string newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ", "");

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
                SetLocalStatus(string.Format("Error opening file explorer for path: {0} - {1}", TextBoxLocalPath.Text, ex.Message), ex);
            }
        }

        private void ContextMenuLocalFileUpload_Click(object sender, EventArgs e)
        {
            ToolStripLocalUpload.PerformClick();
        }

        private void ContextMenuLocalDeleteFile_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteLocalItem();
            }
        }

        private void ContextMenuLocalRenameFile_Click(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                string fileName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                string filePath = TextBoxLocalPath.Text + @"\" + fileName;

                string newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name: ", fileName);

                if (fileName != newFileName && newFileName != null)
                {
                    FileSystem.RenameFile(filePath, newFileName);
                    LoadLocalDirectory(LocalDirectoryPath);
                }              
            }            
        }

        private void ContextMenuLocalRenameFolder_Click(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                string fileName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                string folderPath = TextBoxLocalPath.Text + @"\" + fileName;

                string newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name: ", fileName);

                if (fileName != newFolderName && newFolderName != null)
                {
                    FileSystem.RenameDirectory(folderPath, newFolderName);
                    LoadLocalDirectory(LocalDirectoryPath);
                }
            }
        }

        private void ContextMenuLocalRefresh_Click(object sender, EventArgs e)
        {
            LoadLocalDirectory(LocalDirectoryPath);
        }

        /// <summary>
        ///     Gets/sets the current local directory path
        /// </summary>
        public string LocalDirectoryPath { get; set; } = @"C:\";

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

                bool isParentRoot = localDrives.Any(x => x.Name.Equals(LocalDirectoryPath.Replace(@"\\", @"\")));

                if (!isParentRoot)
                {
                    _ = DgvLocalFiles.Rows.Add("folder", Resources.folder, "..", "<DIRECTORY>", Directory.GetLastWriteTime(LocalDirectoryPath));
                }
                
                int totalFolderCount = 0;
                int totalFileCount = 0;
                long totalFileBytes = 0;

                foreach (string directoryItem in Directory.GetDirectories(LocalDirectoryPath))
                {
                    _ = DgvLocalFiles.Rows.Add("folder", Resources.folder, Path.GetFileName(directoryItem), "<DIRECTORY>", Directory.GetLastWriteTime(directoryItem));

                    totalFolderCount++;
                }

                foreach (string fileItem in Directory.GetFiles(LocalDirectoryPath))
                {
                    long fileBytes = new FileInfo(fileItem).Length;

                    _ = DgvLocalFiles.Rows.Add("file", Resources.file, Path.GetFileName(fileItem), fileBytes.ToString("n0", CultureInfo.CurrentCulture) + " bytes", File.GetLastWriteTime(fileItem));

                    totalFileCount++;
                    totalFileBytes += fileBytes;
                }

                SetLocalStatus($"{totalFileBytes.ToString("n0", CultureInfo.CurrentCulture)} bytes in {totalFileCount} {(totalFileCount <= 1 ? "file" : "files")}, {totalFolderCount} {(totalFolderCount <= 1 ? "directory" : "directories")}");
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error fetching directory listing for path: {LocalDirectoryPath} - {ex.Message}", ex);

                try
                {
                    // Attempt to reload the parent directory listing
                    LoadLocalDirectory(Path.GetDirectoryName(LocalDirectoryPath) + @"\");
                }
                catch { }
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
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (name == "..") // Go to parent directory
                {
                    string trimLastIndex = Path.GetDirectoryName(FtpDirectoryPath).Replace(@"\", "/").TrimEnd(new char[] { '/' });
                    string parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf("/")) + "/";

                    LoadConsoleDirectory(parentDirectory);
                }
                else if (type == "folder") // Go to selected directory
                {
                    LoadConsoleDirectory(FtpDirectoryPath + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString() + "/");
                }
            }
        }

        private void DgvConsoleFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripConsoleDownload.Enabled = type == "file" & name != "..";
                ToolStripConsoleDelete.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuItemConsoleDownloadFile.Enabled = type == "file" & name != "..";
                ContextMenuItemConsoleDeleteFile.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuItemConsoleRenameFile.Enabled = type == "file" & name != "..";
                ContextMenuItemConsoleRenameFolder.Enabled = type == "folder" & name != "..";
            }
        }

        private void DgvConsoleFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripConsoleDownload.Enabled = type == "file" & name != "..";
                ToolStripConsoleDelete.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuItemConsoleDownloadFile.Enabled = type == "file" & name != "..";
                ContextMenuItemConsoleDeleteFile.Enabled = type == "file" || type == "folder" & name != "..";
                ContextMenuItemConsoleRenameFile.Enabled = type == "file" & name != "..";
                ContextMenuItemConsoleRenameFolder.Enabled = type == "folder" & name != "..";
            }
        }

        private void ToolStripConsoleDownload_Click(object sender, EventArgs e)
        {
            DownloadFromConsole();
        }

        private void ToolStripConsoleDelete_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteConsoleItem();
            }
        }

        private void ToolStripConsoleNewFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ", "");

                if (folderName != null)
                {
                    _ = Extensions.FtpExtensions.CreateDirectory(FtpDirectoryPath + "/" + folderName);
                    LoadConsoleDirectory(FtpDirectoryPath);
                }
            }
            catch (FluentFTP.FtpException ex)
            {
                _ = DarkMessageBox.Show(this, $"Unable to create new folder. Error: {ex.Message}", "Error", MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                _ = DarkMessageBox.Show(this, $"Unable to create new folder. Error: {ex.Message}", "Error", MessageBoxIcon.Error);
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
            if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteConsoleItem();
            }
        }

        private void ContextMenuConsoleRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        private void ContextMenuItemConsoleRenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                string oldFilName = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string consoleFilePath = TextBoxConsolePath.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                int selectedIndex = DgvConsoleFiles.CurrentRow.Index;

                string newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFilName);

                if (newFileName != null)
                {
                    Extensions.FtpExtensions.RenameFile(consoleFilePath, newFileName);
                    SetConsoleStatus($"Renamed {oldFilName} file to: {newFileName}");
                    LoadConsoleDirectory(FtpDirectoryPath);
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
                string oldFolderName = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string consoleFolderPath = TextBoxConsolePath.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                string newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName);

                if (newFolderName != null)
                {
                    Extensions.FtpExtensions.RenameFile(consoleFolderPath, newFolderName);
                    SetConsoleStatus($"Renamed {oldFolderName} folder to: {newFolderName}");
                    LoadConsoleDirectory(FtpDirectoryPath);
                }
            }                
            catch (Exception ex)
            {
                SetConsoleStatus($"Unable to rename folder. Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        ///     Get/sets the current ftp directory path
        /// </summary>
        public string FtpDirectoryPath { get; set; } = "/dev_hdd0/";

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

                int secondIndexOfSlash = FtpDirectoryPath.TrimStart('/').IndexOfNth("/", 0);
                string rootPath = FtpDirectoryPath.Substring(1, secondIndexOfSlash);

                ComboBoxConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxConsoleDrives.SelectedItem = rootPath;
                ComboBoxConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                bool isRoot = ComboBoxConsoleDrives.Items.Contains(FtpDirectoryPath.Replace("/", ""));

                if (!isRoot)
                {
                    _ = DgvConsoleFiles.Rows.Add("folder", Resources.folder, "..", "<DIRECTORY>", DateTime.MinValue);
                }

                MainWindow.FtpClient.SetWorkingDirectory(FtpDirectoryPath);

                List<FtpListItem> folders = new List<FtpListItem>();
                List<FtpListItem> files = new List<FtpListItem>();

                long fileBytes = 0;

                foreach (FtpListItem listItem in MainWindow.FtpClient.GetListing(FtpDirectoryPath))
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
                    fileBytes += listItem.Size;
                }

                SetConsoleStatus($"{fileBytes.ToString("n0", CultureInfo.CurrentCulture)} bytes in {files.Count} {(files.Count == 1 ? "file" : "files")}, {folders.Count} {(folders.Count == 1 ? "directory" : "directories")}");
            }
            catch (FluentFTP.FtpException ex)
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
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                string localName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (type.Equals("file"))
                {
                    string localPath = TextBoxLocalPath.Text + localName;
                    string consolePath = TextBoxConsolePath.Text + localName;

                    if (File.Exists(localPath))
                    {
                        SetLocalStatus($"Uploading file to {consolePath}...");
                        Extensions.FtpExtensions.UploadFile(localPath, consolePath);
                        SetLocalStatus($"Successfully uploaded file: {Path.GetFileName(localPath)}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                    else
                    {
                        SetLocalStatus($"Unable to upload file as it doesn't exist on your computer.");
                    }
                }
                else if (type.Equals("folder"))
                {
                    string localPath = TextBoxLocalPath.Text + localName + @"\";
                    string consolePath = TextBoxConsolePath.Text + localName;

                    SetLocalStatus($"Uploading folder to {consolePath}...");
                    _ = MainWindow.FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
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
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (!name.Equals(".."))
                {
                    string selectedItem = TextBoxLocalPath.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                    if (type == "folder")
                    {
                        SetLocalStatus($"Deleting folder: {selectedItem}");
                        UserFolders.DeleteDirectory(selectedItem);
                        SetLocalStatus($"Successfully deleted folder: {selectedItem}");
                    }
                    else if (type == "file")
                    {
                        if (File.Exists(selectedItem))
                        {
                            SetLocalStatus($"Deleting file: {selectedItem}");
                            File.Delete(selectedItem);
                            SetLocalStatus($"Successfully deleted file: {selectedItem}");
                        }
                    }
                }

                DgvLocalFiles.Rows.RemoveAt(DgvLocalFiles.CurrentRow.Index);
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
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (type.Equals("file"))
                {
                    string consoleFile = TextBoxConsolePath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                    string localFile = TextBoxLocalPath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                    if (File.Exists(localFile))
                    {
                        File.Delete(localFile);
                    }

                    SetConsoleStatus($"Downloading file: {Path.GetFileName(localFile)}");
                    //Extensions.FtpExtensions.DownloadFile(localFile, consoleFile);
                    _ = MainWindow.FtpClient.DownloadFile(localFile, consoleFile);
                    SetConsoleStatus($"Successfully downloaded file: {Path.GetFileName(localFile)}");
                }
                else if (type.Equals("folder"))
                {
                    string consolePath = TextBoxConsolePath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString() + "/";
                    string localPath = TextBoxLocalPath.Text + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                    if (Directory.Exists(localPath))
                    {
                        Directory.Delete(localPath, true);
                    }

                    SetConsoleStatus($"Downloading folder: {consolePath}");
                    //Extensions.FtpExtensions.DownloadDirectory(consolePath, localPath);
                    _ = MainWindow.FtpClient.DownloadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpLocalExists.Overwrite);
                    SetConsoleStatus($"Successfully downloaded folder to: {localPath}");
                }
                else { }
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
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                string itemPath = TextBoxConsolePath.Text + name;

                if (type.Equals("folder"))
                {
                    SetConsoleStatus($"Deleting folder: {itemPath}");

                    MainWindow.FtpClient.DeleteDirectory(itemPath);

                    SetConsoleStatus($"Successfully deleted folder.");
                }
                else if (type.Equals("file"))
                {
                    SetConsoleStatus($"Deleting file: {itemPath}");
                    Extensions.FtpExtensions.DeleteFile(itemPath);
                    SetConsoleStatus($"Successfully deleted file.");
                }

                DgvConsoleFiles.Rows.RemoveAt(DgvConsoleFiles.CurrentRow.Index);
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