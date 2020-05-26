using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Properties;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class FileExplorer : DarkForm
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            SetStatus($"Initializing application data...");

            MenuItemSettingsSaveLocalDirectoryPath.Checked = MainForm.SettingsData.SaveLocalDirectoryPath;

            if (MainForm.SettingsData.SaveLocalDirectoryPath)
            {
                // Load saved local directory path
                if (MainForm.SettingsData.LocalDirectory.Equals(@"\") || MainForm.SettingsData.LocalDirectory.Equals(""))
                {
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
                }
                else
                {
                    LoadLocalDirectory(MainForm.SettingsData.LocalDirectory);
                }
            }
            else
            {
                // Load users documents path by default
                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents));
            }
        }

        private void FileExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxLocalDirectory.Text))
            {
                MainForm.SettingsData.LocalDirectory = TextBoxLocalDirectory.Text;
            }
        }

        private void MenuItemSettingsSaveLocalDirectoryPath_Click(object sender, EventArgs e)
        {
            MainForm.SettingsData.SaveLocalDirectoryPath = MenuItemSettingsSaveLocalDirectoryPath.Checked;
        }

        private void ButtonLocalDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    LocalDirectoryPath = folderBrowser.SelectedPath;
                    LoadLocalDirectory(LocalDirectoryPath);
                }
            }
        }

        private void ButtonConsoleExplorerNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsoleDirectory.Text);
        }

        private void DgvLocalFiles_SelectionChanged(object sender, EventArgs e)
        {
            string type = DgvLocalFiles.SelectedRows.Count == 0 ? "" : DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();

            ToolStripItemLocalUploadFile.Enabled = type == "file";
            ToolStripLocalDeleteFile.Enabled = type == "file";
            ContextMenuStripLocalUploadFile.Enabled = type == "file";
            ContextMenuStripLocalDeleteFile.Enabled = type == "file";
        }

        private void DgvConsoleFiles_SelectionChanged(object sender, EventArgs e)
        {
            string type = DgvConsoleFiles.SelectedRows.Count == 0 ? "" : DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();

            ToolStripItemConsoleFileDownload.Enabled = type == "file";
            ToolStripItemConsoleFileDelete.Enabled = type == "file";
            ContextMenuConsoleDownloadFile.Enabled = type == "file";
            ContextMenuConsoleDeleteFile.Enabled = type == "file";
        }

        private void DgvLocalFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = DgvLocalFiles.CurrentRow == null ? "" : DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
            string name = DgvLocalFiles.CurrentRow == null ? "" : DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            if (name == "..")
            {
                string parentDirecory = Directory.GetParent(LocalDirectoryPath).FullName;

                if (Directory.Exists(parentDirecory))
                {
                    LoadLocalDirectory(parentDirecory);
                }
            }
            else if (type == "folder")
            {
                LoadLocalDirectory(LocalDirectoryPath + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString());
            }

            ToolStripItemLocalUploadFile.Enabled = type == "file";
            ToolStripLocalDeleteFile.Enabled = type == "file";
            ContextMenuStripLocalUploadFile.Enabled = type == "file";
            ContextMenuStripLocalDeleteFile.Enabled = type == "file";

            ToolStripItemLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalDirectory.Text);
        }

        private void DgvConsoleFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsoleFiles.CurrentRow != null)
            {
                string type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                string name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (name == ".")
                {
                    LoadConsoleDirectory("/");
                }
                else if (name == "..")
                {
                    LoadConsoleDirectory(Path.GetDirectoryName(FtpDirectoryPath).Replace(@"\", "/"));
                }
                else if (type == "folder")
                {
                    LoadConsoleDirectory(FtpDirectoryPath + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString());
                }

                ToolStripItemConsoleFileDownload.Enabled = type == "file";
                ToolStripItemConsoleFileDelete.Enabled = type == "file";
                ContextMenuConsoleDownloadFile.Enabled = type == "file";
                ContextMenuConsoleDeleteFile.Enabled = type == "file";
            }
        }

        /// <summary>
        ///     Gets/sets the current local directory path
        /// </summary>
        public string LocalDirectoryPath { get; set; } = @"\";

        /// <summary>
        ///     Loads both files and folders into the local dgv
        /// </summary>
        /// <param name="directoryPath"></param>
        public void LoadLocalDirectory(string directoryPath)
        {
            DgvLocalFiles.Rows.Clear();
            DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, "..", "", ".", DateTime.Now);

            try
            {
                LocalDirectoryPath = directoryPath.Replace("\\", @"\");
                TextBoxLocalDirectory.Text = directoryPath.Replace("\\", @"\");

                SetStatus($"Retrieving directory listing of '{directoryPath}'...");

                foreach (string directoryItem in Directory.GetDirectories(directoryPath))
                {
                    DgvLocalFiles.Rows.Add("folder", Resources.icons8_folder_16, Path.GetFileName(directoryItem), "-", "file-folder", Directory.GetLastWriteTime(directoryItem));
                }

                foreach (string fileItem in Directory.GetFiles(directoryPath))
                {
                    DgvLocalFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(fileItem), new FileInfo(fileItem).Length.ToString("#,##0") + " bytes", Path.GetExtension(fileItem).ToUpper().Trim('.') + " File", File.GetLastWriteTime(fileItem));
                }

                SetStatus($"Local directory listing for path: {directoryPath}' successful ({DgvLocalFiles.Rows.Count} items)");
            }
            catch (Exception ex)
            {
                SetStatus($"Error retrieving local directory listing for path: {directoryPath} - {ex.Message}", ex);

                try
                {
                    // Attempt to load the parent directory if the current path crashes
                    LoadLocalDirectory(Directory.GetParent(LocalDirectoryPath).FullName);
                }
                catch { }
            }
        }

        /// <summary>
        ///     Get/sets the current ftp directory path
        /// </summary>
        public string FtpDirectoryPath { get; set; } = "/";

        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                SetStatus("Connecting to console...");

                using (FtpConnection ftpConnection = new FtpConnection(MainForm.ConsoleProfile.Address))
                {
                    ftpConnection.Open();

                    DgvConsoleFiles.Rows.Clear();

                    SetStatus(string.Format("Retrieving console directory listing of '{0}'...", directoryPath.Replace("//", "/")));

                    FtpDirectoryPath = directoryPath.Replace("//", "/");
                    TextBoxConsoleDirectory.Text = directoryPath.Replace("//", "/");

                    ftpConnection.SetCurrentDirectory(FtpDirectoryPath);

                    //FtpDirectoryInfo rootDirectoryInfo = FtpConnection.GetCurrentDirectoryInfo();

                    foreach (FtpDirectoryInfo ftpDirectoryInfo in ftpConnection.GetDirectories(FtpDirectoryPath))
                    {
                        DgvConsoleFiles.Rows.Add("folder", Resources.icons8_folder_16, ftpDirectoryInfo.Name, "-", "file-folder", ftpDirectoryInfo.LastWriteTimeUtc);
                    }

                    foreach (FtpFileInfo ftpFileInfo in ftpConnection.GetFiles(FtpDirectoryPath))
                    {
                        long ftpFileSize = 0;

                        try
                        {
                            ftpFileSize = ftpConnection.GetFileSize(ftpFileInfo.FullName);
                        }
                        catch (FtpException ex)
                        {
                            Program.Log.Error(string.Format("An error occurred fetching console file size for {0}", ftpFileInfo.FullName), ex);
                        }
                        catch (Exception ex)
                        {
                            Program.Log.Error(string.Format("An error occurred fetching console file size for {0}", ftpFileInfo.FullName), ex);
                        }

                        DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, ftpFileInfo.Name, ftpFileSize.ToString("#,##0") + " bytes", Path.GetExtension(ftpFileInfo.FullName).ToUpper().Trim('.') + " File", ftpFileInfo.LastWriteTimeUtc);
                    }

                    SetStatus(string.Format("Console directory listing of '{0}' successful ({1} items)", FtpDirectoryPath, DgvConsoleFiles.Rows.Count));
                }
            }
            catch (FtpException ex)
            {
                SetStatus($"Error retrieving console directory listing for path: {directoryPath} - {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                SetStatus($"Error retrieving console directory listing for path: {directoryPath} - {ex.Message}", ex);
            }
        }

        private void ToolStripLocalUploadFile_Click(object sender, EventArgs e)
        {
            UploadLocalFile();

        }

        private void ToolStripLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalFile();
        }

        private void ToolStripLocalOpenExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", TextBoxLocalDirectory.Text);
            }
            catch (Exception ex)
            {
                SetStatus(string.Format("Error opening file explorer for path: {0} - {1}", TextBoxLocalDirectory.Text, ex.Message), ex);
            }
        }

        private void ToolStripItemConsoleFileDownload_Click(object sender, EventArgs e)
        {
            DownloadConsoleFile();
        }

        private void ToolStripItemConsoleFileDelete_Click(object sender, EventArgs e)
        {
            DeleteConsoleFile();
        }

        private void ToolStripConsoleFileRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        private void ContextMenuStripLocalFileUpload_Click(object sender, EventArgs e)
        {
            UploadLocalFile();
        }

        private void ContextMenuStripLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalFile();
        }

        private void ContextMenuConsoleDownloadFile_Click(object sender, EventArgs e)
        {
            DownloadConsoleFile();
        }

        private void ContextMenuConsoleDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteConsoleFile();
        }

        private void ContextMenuConsoleRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        public void UploadLocalFile()
        {
            try
            {
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                string installFile = TextBoxConsoleDirectory.Text + "/" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                if (File.Exists(localFile))
                {
                    SetStatus($"Starting upload of local file to console...");
                    FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, localFile, installFile);
                    DgvConsoleFiles.Rows.Add("file", Resources.icons8_file_16, Path.GetFileName(installFile), new FileInfo(localFile).Length.ToString("#,##0") + " bytes", Path.GetExtension(localFile).ToUpper().Trim('.') + " File", File.GetLastWriteTime(installFile));
                    SetStatus(string.Format("File Explorer : Successfully uploaded file {0} to console path {1}", Path.GetFileName(localFile), Path.GetDirectoryName(installFile)));
                }
                else
                {
                    SetStatus($"Unable to install local file as it doesn't exist on drive.");
                }

            }
            catch (Exception ex)
            {
                SetStatus($"Error uploading local file to console - {ex.Message}", ex);
            }
        }

        public void DeleteLocalFile()
        {
            string localFile = TextBoxLocalDirectory.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

            if (File.Exists(localFile))
            {
                File.Delete(localFile);
                DgvLocalFiles.Rows.RemoveAt(DgvLocalFiles.CurrentRow.Index);
            }
        }

        public void DownloadConsoleFile()
        {
            try
            {
                string consoleFile = TextBoxConsoleDirectory.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (File.Exists(localFile))
                {
                    File.Delete(localFile);
                }

                SetStatus($"Downloading console file: {Path.GetFileName(localFile)} to path: {localFile}...");
                FtpExtensions.DownloadFile(MainForm.ConsoleProfile.Address, localFile, consoleFile);
                SetStatus($"Successfully downloaded file {Path.GetFileName(localFile)} to path: {localFile}");

            }
            catch (Exception ex)
            {
                SetStatus($"Error downloading console file - {ex.Message}", ex);
            }

            LoadLocalDirectory(LocalDirectoryPath);
        }

        public void DeleteConsoleFile()
        {
            try
            {
                string consoleFile = TextBoxConsoleDirectory.Text + "/" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                string localFile = TextBoxLocalDirectory.Text + @"\" + DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                SetStatus($"Delete console file: {consoleFile}...");
                FtpExtensions.DeleteFile(MainForm.ConsoleProfile.Address, consoleFile);
                DgvConsoleFiles.Rows.RemoveAt(DgvConsoleFiles.CurrentRow.Index);
                SetStatus($"Successfully deleted console file: {consoleFile}");
            }
            catch (Exception ex)
            {
                SetStatus($"Error deleting console file - {ex.Message}", ex);
            }
        }        

        /// <summary>
        ///     Set the current process status in the tool strip
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            ToolStripLabelStatus.Text = status;

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
            // Removes dotted borders from the cells upon focus
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainForm.IsConsoleConnected)
            {
                LoadConsoleDirectory(FtpDirectoryPath);
            }

            timer1.Enabled = false;
        }
    }
}