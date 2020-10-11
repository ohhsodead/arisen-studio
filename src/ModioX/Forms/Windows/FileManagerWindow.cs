using DarkUI.Forms;
using Microsoft.AspNetCore.Builder;
using Microsoft.VisualBasic.FileIO;
using ModioX.Extensions;
using ModioX.Properties;
using System;
using System.Diagnostics;
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
            
        }

        private void FileExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxLocalDirectory.Text))
            {
                MainWindow.SettingsData.LocalDirectory = TextBoxLocalDirectory.Text;
            }
        }

        private void MenuItemSettingsSaveLocalDirectoryPath_Click(object sender, EventArgs e)
        {
            MainWindow.SettingsData.SaveLocalDirectoryPath = MenuItemSettingsSaveLocalDirectoryPath.Checked;
        }

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            DgvLocalFiles.Focus();

            foreach (DriveInfo driveInfo in localDrives)
            {
                ComboBoxLocalDrives.Items.Add(driveInfo.Name.Replace(@"\", ""));
            }

            ComboBoxLocalDrives.SelectedItem = MainWindow.SettingsData.LocalDirectory.Substring(0, 2);

            MenuItemSettingsSaveLocalDirectoryPath.Checked = MainWindow.SettingsData.SaveLocalDirectoryPath;

            if (MainWindow.SettingsData.SaveLocalDirectoryPath)
            {
                // Load saved local directory path
                if (MainWindow.SettingsData.LocalDirectory.Equals(@"\") || MainWindow.SettingsData.LocalDirectory.Equals(""))
                {
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
                }
                else
                {
                    LoadLocalDirectory(MainWindow.SettingsData.LocalDirectory);
                }
            }
            else
            {
                // Load users documents path by default
                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
            }

            foreach (string driveName in FtpExtensions.GetFolderNames("/").ToArray())
            {
                ComboBoxConsoleDrives.Items.Add(driveName.Replace(@"/", ""));
            }

            ComboBoxConsoleDrives.SelectedItem = "dev_hdd0";

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
                string parentDirectory = Directory.GetParent(LocalDirectoryPath.TrimEnd(new char[] { '\\' })).FullName;

                if (Directory.Exists(parentDirectory))
                {
                    LoadLocalDirectory(parentDirectory);
                }
            }
            else if (type == "folder")
            {
                LoadLocalDirectory(LocalDirectoryPath + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString() + @"\");
            }

            ToolStripLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalDirectory.Text);
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
                string type = DgvLocalFiles.SelectedRows.Count == 0 ? "" : DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();

                ToolStripLocalUpload.Enabled = type == "file";
                ToolStripLocalDelete.Enabled = type == "file" | type == "folder" & type != "..";
                ContextMenuLocallUploadFile.Enabled = type == "file";
                ContextMenuLocalDeleteFile.Enabled = type == "file" | type == "folder" & type != "..";
            }

        }

        private void DgvLocalFiles_SelectionChanged(object sender, EventArgs e)
        {
            string type = DgvLocalFiles.SelectedRows.Count == 0 ? "" : DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
            string name = DgvLocalFiles.SelectedRows.Count == 0 ? "" : DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            ToolStripLocalUpload.Enabled = type == "file" & name != "..";
            ToolStripLocalDelete.Enabled = type == "file" | type == "folder" & name != "..";
            ContextMenuLocallUploadFile.Enabled = type == "file" & name != "..";
            ContextMenuLocalDeleteFile.Enabled = type == "file" | type == "folder" & name != "..";
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
                Directory.CreateDirectory(TextBoxLocalDirectory.Text + @"\" + newName);
                LoadLocalDirectory(LocalDirectoryPath);
            }

        }

        private void ToolStripLocalOpenExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                _ = Process.Start("explorer.exe", TextBoxLocalDirectory.Text);
            }
            catch (Exception ex)
            {
                SetLocalStatus(string.Format("Error opening file explorer for path: {0} - {1}", TextBoxLocalDirectory.Text, ex.Message), ex);
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

        private void ContextMenuLocalRename_Click(object sender, EventArgs e)
        {
            if (DgvLocalFiles.CurrentRow != null)
            {
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();

                string fileName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                string filePath = TextBoxLocalDirectory.Text + @"\" + fileName;

                if (type == "file")
                {
                    string newName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name: ", fileName);

                    if (newName != null)
                    {
                        FileSystem.RenameFile(filePath, newName);
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
                else if (type == "folder")
                {
                    string newName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name: ", fileName);

                    if (newName != null)
                    {
                        FileSystem.RenameDirectory(filePath, newName);
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
                TextBoxLocalDirectory.Text = LocalDirectoryPath;

                SetLocalStatus($"Fetching directory listing of '{LocalDirectoryPath}'...");

                ComboBoxLocalDrives.SelectedItem = LocalDirectoryPath.Substring(0, 2);

                bool isParentRoot = localDrives.Any(x => x.Name.Equals(LocalDirectoryPath.Replace(@"\\", @"\")));

                if (!isParentRoot)
                {
                    _ = DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, "..", "<DIRECTORY>", Directory.GetLastWriteTime(LocalDirectoryPath));
                }

                int folderCount = 0;
                foreach (string directoryItem in Directory.GetDirectories(LocalDirectoryPath))
                {
                    folderCount++;
                    _ = DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, Path.GetFileName(directoryItem), "<DIRECTORY>", Directory.GetLastWriteTime(directoryItem));
                }

                int fileCount = 0;
                foreach (string fileItem in Directory.GetFiles(LocalDirectoryPath))
                {
                    fileCount++;
                    _ = DgvLocalFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(fileItem), new FileInfo(fileItem).Length.ToString("#,##0") + " bytes", File.GetLastWriteTime(fileItem));
                }

                SetLocalStatus(string.Format("{0} {1}, {2} {3}", fileCount, fileCount <= 1 ? "file" : "files", folderCount, folderCount <= 1 ? "directory" : "directories"));
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error fetching directory listing for path: {LocalDirectoryPath} - {ex.Message}", ex);

                try
                {
                    // Try to load the parent directory
                    LoadLocalDirectory(Directory.GetParent(LocalDirectoryPath).FullName);
                }
                catch { }
            }
        }

        /* Console Explorer */

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConsoleDirectory("/" + ComboBoxConsoleDrives.GetItemText(ComboBoxConsoleDrives.SelectedItem) + "/", false);
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsoleDirectory.Text, true);
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

                    if (ComboBoxConsoleDrives.Items.Contains(parentDirectory.Replace("/", "")))
                    {
                        LoadConsoleDirectory(parentDirectory, false);
                    }
                    else
                    {
                        LoadConsoleDirectory(parentDirectory, true);
                    }
                }
                else if (type == "folder") // Go to selected directory
                {
                    LoadConsoleDirectory(FtpDirectoryPath + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString() + "/", true);
                }
            }
        }

        private void DgvConsoleFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsoleFiles.SelectedRows.Count > 0)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripConsoleDownload.Enabled = type == "file" & name != "..";
                ToolStripConsoleDelete.Enabled = type == "file" | type == "folder" & name != "..";
                ContextMenuConsoleDownloadFile.Enabled = type == "file" & name != "..";
                ContextMenuConsoleDeleteFile.Enabled = type == "file" | type == "folder" & name != "..";
            }
        }

        private void DgvConsoleFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvConsoleFiles.SelectedRows.Count > 0)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                ToolStripConsoleDownload.Enabled = type == "file" & name != "..";
                ToolStripConsoleDelete.Enabled = type == "file" | type == "folder" & name != "..";
                ContextMenuConsoleDownloadFile.Enabled = type == "file" & name != "..";
                ContextMenuConsoleDeleteFile.Enabled = type == "file" | type == "folder" & name != "..";
            }
        }

        /// <summary>
        ///     Get/sets the current ftp directory path
        /// </summary>
        public string FtpDirectoryPath { get; set; } = "/";

        /// <summary>
        ///     Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath">Console path to retrieve</param>
        public void LoadConsoleDirectory(string directoryPath, bool showRoot)
        {
            try
            {
                SetConsoleStatus("Connecting to console...");

                FtpConnection ftpConnection = MainWindow.GetFtpConnection();

                DgvConsoleFiles.Rows.Clear();

                SetConsoleStatus(string.Format("Fetching directory listing of '{0}'...", directoryPath.Replace("//", "/")));

                FtpDirectoryPath = directoryPath.Replace("//", "/");
                TextBoxConsoleDirectory.Text = directoryPath.Replace("//", "/");

                ftpConnection.SetCurrentDirectory(FtpDirectoryPath);

                FtpDirectoryInfo directoryInfo = ftpConnection.GetCurrentDirectoryInfo();

                if (showRoot)
                {
                    _ = DgvConsoleFiles.Rows.Add("folder", Resources.icons8_folder_16, "..", "<DIRECTORY>", DateTime.MinValue);
                }

                int folderCount = 0;
                foreach (FtpDirectoryInfo ftpDirectoryInfo in ftpConnection.GetDirectories(FtpDirectoryPath).Skip(2).OrderBy(x => x.Name))
                {
                    if (!ComboBoxConsoleDrives.Items.Contains(ftpDirectoryInfo.Name.Replace("/", "")))
                    {
                        folderCount++;
                        _ = DgvConsoleFiles.Rows.Add("folder", Resources.icons8_folder_16, ftpDirectoryInfo.Name, "<DIRECTORY>", ftpDirectoryInfo.LastWriteTimeUtc);
                    }
                }

                int fileCount = 0;
                foreach (FtpFileInfo ftpFileInfo in ftpConnection.GetFiles(FtpDirectoryPath).OrderBy(x => x.Name))
                {
                    long ftpFileSize = 0;

                    try
                    {
                        ftpFileSize = ftpConnection.GetFileSize(ftpFileInfo.FullName);
                    }
                    catch (FtpException ex)
                    {
                        Program.Log.Error(string.Format("An error occurred fetching file size for {0}", ftpFileInfo.FullName), ex);
                    }
                    catch (Exception ex)
                    {
                        Program.Log.Error(string.Format("An error occurred fetching file size for {0}", ftpFileInfo.FullName), ex);
                    }

                    fileCount++;
                    _ = DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, ftpFileInfo.Name, ftpFileSize.ToString("#,##0") + " bytes", ftpFileInfo.LastWriteTimeUtc);
                }

                SetConsoleStatus(string.Format("{0} {1}, {2} {3}", fileCount, fileCount == 1 ? "file" : "files", folderCount, folderCount == 1 ? "directory" : "directories"));

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
                string newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ", "");

                if (newName != null)
                {
                    FtpExtensions.CreateDirectory(FtpDirectoryPath + "/" + newName);
                    LoadConsoleDirectory(FtpDirectoryPath, true);
                }
            }            
            catch (FtpException ex)
            {
                _ = DarkMessageBox.Show(this, "Unable to create new folder. " + ex.Message, "Error", MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                _ = DarkMessageBox.Show(this, "Unable to create new folder. " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        private void ToolStripConsoleFileRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath, true);
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
            LoadConsoleDirectory(FtpDirectoryPath, true);
        }

        public void UploadLocalFile()
        {
            try
            {
                string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (!name.Equals(".."))
                {
                    if (type.Equals("file"))
                    {
                        string localFile = TextBoxLocalDirectory.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                        string installFile = TextBoxConsoleDirectory.Text + "/" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                        if (File.Exists(localFile))
                        {
                            SetLocalStatus($"Starting upload of local file to console...");
                            FtpExtensions.UploadFile(localFile, installFile);
                            DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(installFile), new FileInfo(localFile).Length.ToString("#,##0") + " bytes", File.GetLastWriteTime(installFile));
                            SetLocalStatus(string.Format("Successfully uploaded {0} to {1}", Path.GetFileName(localFile), Path.GetDirectoryName(installFile)));
                            LoadConsoleDirectory(FtpDirectoryPath, true);
                        }
                        else
                        {
                            SetLocalStatus($"Unable to install local file as it doesn't exist on drive.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error uploading file to console. {ex.Message}", ex);
            }
        }

        public void DeleteLocalItem()
        {
            string type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
            string name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            if (!name.Equals(".."))
            {
                string selectedItem = TextBoxLocalDirectory.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (type == "folder")
                {
                    Utilities.DeleteDirectory(selectedItem);
                }
                else if (type == "file")
                {
                    if (File.Exists(selectedItem))
                    {
                        File.Delete(selectedItem);
                        DgvLocalFiles.Rows.RemoveAt(DgvLocalFiles.CurrentRow.Index);
                    }
                }
            }
        }

        public void DownloadFromConsole()
        {
            try
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (!name.Equals(".."))
                {
                    string consoleFile = TextBoxConsoleDirectory.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                    string localFile = TextBoxLocalDirectory.Text + @"\" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                    if (File.Exists(localFile))
                    {
                        File.Delete(localFile);
                    }

                    SetConsoleStatus($"Downloading console file: {Path.GetFileName(localFile)}");
                    FtpExtensions.DownloadFile(localFile, consoleFile);
                    SetConsoleStatus($"Successfully downloaded file: {Path.GetFileName(localFile)}");
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
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                
                if (!name.Equals(".."))
                {
                    string consoleFile = TextBoxConsoleDirectory.Text + "/" + name;

                    if (type == "folder")
                    {
                        SetConsoleStatus($"Deleting folder: {consoleFile}...");
                        FtpExtensions.DeleteDirectory(consoleFile);
                        SetConsoleStatus($"Successfully deleted folder.");
                    }
                    else if (type == "file")
                    {
                        SetConsoleStatus($"Deleting file: {consoleFile}...");
                        FtpExtensions.DeleteFile(consoleFile);
                        SetConsoleStatus($"Successfully deleted file.");
                    }

                    DgvConsoleFiles.Rows.RemoveAt(DgvConsoleFiles.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Error: {ex.Message}", ex);
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