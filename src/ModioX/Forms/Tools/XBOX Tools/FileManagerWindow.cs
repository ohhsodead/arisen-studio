using DarkUI.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using FluentFTP;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Net;
using ModioX.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FtpException = FluentFTP.FtpException;
using FtpExtensions = ModioX.Extensions.FtpExtensions;
using XDevkit;
using System.Data;
using System.Linq;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class FileManagerWindow : XtraForm
    {
        /// <summary>
        /// Creates an FTP connection for use with uploading mods, not reliable for uploading files.
        /// </summary>
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;

        /// <summary>
        /// Gets/set the current local directory path.
        /// </summary>
        public string LocalDirectoryPath { get; set; } = @"C:\";

        /// <summary>
        /// Get/sets the current ftp directory path.
        /// </summary>
        public string FtpDirectoryPath { get; set; } = "/dev_hdd0/";

        /// <summary>
        /// 
        /// </summary>
        private readonly Image ImageFile = ImageExtensions.ResizeBitmap(Resources.file, 20, 20);

        /// <summary>
        /// 
        /// </summary>
        private readonly Image ImageFolder = ImageExtensions.ResizeBitmap(Resources.folder, 20, 20);

        /// <summary>
        /// Contains the local computer drives.
        /// </summary>
        private readonly DriveInfo[] localDrives = DriveInfo.GetDrives();

        public FileManagerWindow()
        {
            InitializeComponent();
        }

        private void FileManagerWindow_Load(object sender, EventArgs e)
        {
            GridLocalFiles.Focus();

            SetStatus("Fetching drives...");

            foreach (var driveInfo in localDrives) _ = ComboBoxLocalDrives.Properties.Items.Add(driveInfo.Name.Replace(@"\", ""));

            if (MainWindow.Settings.SaveLocalPath)
            {
                if (MainWindow.Settings.LocalPath.Equals(@"\") || string.IsNullOrWhiteSpace(MainWindow.Settings.LocalPath))
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

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            SetStatus("Fetching root directories...");

            foreach (var driveName in FtpExtensions.GetFolderNames("/").ToArray())
            {
                ComboBoxConsoleDrives.Properties.Items.Add(driveName.Replace(@"/", ""));
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

        /************* Local File Explorer *************/

        private void ComboBoxLocalDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocalDirectory(ComboBoxLocalDrives.SelectedItem.ToString() + @"\");
        }

        private void ButtonBrowseLocalDirectory_Click(object sender, EventArgs e)
        {
            using var folderBrowser = new FolderBrowserDialog { ShowNewFolderButton = true };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                LocalDirectoryPath = folderBrowser.SelectedPath;

                if (Directory.Exists(folderBrowser.SelectedPath))
                {
                    LoadLocalDirectory(LocalDirectoryPath);
                }
            }
        }

        /*
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

        */

        private void ButtonLocalUploadFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            UploadLocalFile();
        }

        private void ButtonLocalDeleteFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteLocalItem();
        }

        private void ButtonLocalNewFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateLocalFolder();
        }

        private void ButtonLocalRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadLocalDirectory(LocalDirectoryPath);
        }

        private void ButtonLocalOpenExplorer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", TextBoxLocalPath.Text);
            }
            catch (Exception ex)
            {
                SetStatus($"Error opening file explorer for path: {TextBoxLocalPath.Text} - {ex.Message}", ex);
            }
        }

        private void ContextMenuLocalFileUpload_Click(object sender, EventArgs e)
        {
            //ToolStripLocalUpload.PerformClick();
        }

        private void ContextMenuLocalDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteLocalItem();
        }

        private void ContextMenuLocalRenameFile_Click(object sender, EventArgs e)
        {
            RenameLocalFile();
        }

        private void ContextMenuLocalRenameFolder_Click(object sender, EventArgs e)
        {
            RenameLocalFolder();
        }

        private void ContextMenuLocalRefresh_Click(object sender, EventArgs e)
        {
            LoadLocalDirectory(LocalDirectoryPath);
        }

        /// <summary>
        /// Loads files and folders into the local datagridview
        /// </summary>
        /// <param name="directoryPath"></param>
        public void LoadLocalDirectory(string directoryPath)
        {
            try
            {
                GridLocalFiles.DataSource = null;

                var dt = new DataTable();
                dt.Columns.Add("file-folder", typeof(string));
                dt.Columns.Add("image", typeof(Image));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("size", typeof(string));
                dt.Columns.Add("type", typeof(string));
                dt.Columns.Add("date modified", typeof(string));

                LocalDirectoryPath = directoryPath.Replace("\\", @"\");
                TextBoxLocalPath.Text = LocalDirectoryPath;

                SetStatus($"Fetching directory listing of '{LocalDirectoryPath}'...");

                ComboBoxLocalDrives.SelectedIndexChanged -= ComboBoxLocalDrives_SelectedIndexChanged;
                ComboBoxLocalDrives.SelectedItem = LocalDirectoryPath.Substring(0, 2);
                ComboBoxLocalDrives.SelectedIndexChanged += ComboBoxLocalDrives_SelectedIndexChanged;

                var isParentRoot = localDrives.Any(x => x.Name.Equals(LocalDirectoryPath.Replace(@"\\", @"\")));

                if (!isParentRoot)
                {
                    dt.Rows.Add("folder", ImageFolder, "..", "<DIRECTORY>", Directory.GetLastWriteTime(LocalDirectoryPath));
                }

                int folders = 0;
                int files = 0;
                long totalBytes = 0;

                foreach (var directoryItem in Directory.GetDirectories(LocalDirectoryPath))
                {
                    dt.Rows.Add("folder", ImageFolder, Path.GetFileName(directoryItem), "<DIRECTORY>", Directory.GetLastWriteTime(directoryItem));

                    folders++;
                }

                foreach (var fileItem in Directory.GetFiles(LocalDirectoryPath))
                {
                    var fileBytes = new FileInfo(fileItem).Length;

                    dt.Rows.Add("file", ImageFile, Path.GetFileName(fileItem), MainWindow.Settings.ShowFileSizeInBytes ? fileBytes.ToString("#,0") + " bytes" : fileBytes.ToString().FormatSize(), File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                string statusFiles = files > 0 ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : "")}" : "" + $"{(folders < 1 ? "." : "")}";
                string statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = files > 0 ? $"Total size: {(MainWindow.Settings.ShowFileSizeInBytes ? totalBytes.ToString("#,0") + " bytes" : StringExtensions.FormatSize(totalBytes.ToString()))}" : "";

                if (files < 1 && folders < 1)
                {
                    SetStatus("Empty directory.");
                }
                else
                {
                    SetStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Error fetching directory listing for path: {LocalDirectoryPath} - {ex.Message}", ex);

                try
                {
                    // Attempt to reload the parent directory listing
                    LoadLocalDirectory(Path.GetDirectoryName(LocalDirectoryPath) + @"\");
                }
                catch
                {
                    SetStatus($"Error fetching directory listing for path: {Path.GetDirectoryName(LocalDirectoryPath) + @"\"} - {ex.Message}", ex);
                }
            }
        }

        /************* Console File Explorer *************/

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConsoleDirectory("/" + ComboBoxConsoleDrives.SelectedItem.ToString() + "/");
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsolePath.Text);
        }

        private void DgvConsoleFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
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
                    if (FtpDirectoryPath == "/dev_hdd0/home/")
                    {
                        LoadConsoleDirectory(FtpDirectoryPath + name.Split()[0] + "/");
                    }
                    else if (FtpDirectoryPath == "/dev_hdd0/game/")
                    {
                        LoadConsoleDirectory(FtpDirectoryPath + name.Split()[0] + "/");
                    }
                    else
                    {
                        LoadConsoleDirectory(FtpDirectoryPath + name + "/");
                    }
                }
            }
            */
        }

        private void DgvConsoleFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
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
            */
        }

        private void DgvConsoleFiles_SelectionChanged(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void ButtonConsoleDownloadFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            DownloadFromConsole();
        }

        private void ButtonConsoleDeleteFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteConsoleItem();
        }

        private void ButtonConsoleNewFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateConsoleFolder();
        }

        private void ButtonConsoleRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadConsoleDirectory(FtpDirectoryPath);
        }

        private void ContextMenuConsoleDownloadFile_Click(object sender, EventArgs e)
        {
            //ToolStripConsoleDownload.PerformClick();
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
            RenameConsoleFile();
        }

        private void ContextMenuItemConsoleRenameFolder_Click(object sender, EventArgs e)
        {
            RenameConsoleFolder();
        }


        /// <summary>
        /// Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath">Console path to retrieve</param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            FtpDirectoryPath = directoryPath.Replace("//", "/");
            TextBoxConsolePath.Text = FtpDirectoryPath;

            var dt = new DataTable();

            foreach (var consoleiTems in XboxConsole.FileSystem.GetDirectories(FtpDirectoryPath))
            {
                dt.Rows.Add(consoleiTems);
            }

            GridConsoleFiles.DataSource = dt;

            /*
            try
            {
                DgvConsoleFiles.Rows.Clear();

                FtpDirectoryPath = directoryPath.Replace("//", "/");
                TextBoxConsolePath.Text = FtpDirectoryPath;

                SetConsoleStatus($"Fetching directory listing of '{FtpDirectoryPath}'...");

                var secondIndexOfSlash = FtpDirectoryPath.TrimStart('/').IndexOfNth("/");
                var rootPath = FtpDirectoryPath.Substring(1, secondIndexOfSlash);

                ComboBoxConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxConsoleDrives.SelectedItem = rootPath;
                ComboBoxConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                var isRoot = ComboBoxConsoleDrives.Items.Contains(FtpDirectoryPath.Replace("/", ""));

                if (!isRoot)
                {
                    _ = DgvConsoleFiles.Rows.Add("folder", ImageFolder, "..", "<DIRECTORY>", DateTime.MinValue);
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
                    if (FtpDirectoryPath == "/dev_hdd0/home/")
                    {
                        string profileName = FtpExtensions.GetUserNameFromUserId(listItem.Name);
                        _ = DgvConsoleFiles.Rows.Add("folder", ImageFolder, $"{listItem.Name} ({profileName})", "<PROFILE>", listItem.Modified);
                    }
                    else if (FtpDirectoryPath == "/dev_hdd0/game/")
                    {
                        string gameTitle = MainWindow.Settings.AutoDetectGameTitles ? $" ({HttpExtensions.GetGameTitleFromTitleID(listItem.Name)})" : "";
                        _ = DgvConsoleFiles.Rows.Add("folder", ImageFolder, $"{listItem.Name}{gameTitle}", "<GAMEUPDATE>", listItem.Modified);
                    }
                    else
                    {
                        _ = DgvConsoleFiles.Rows.Add("folder", ImageFolder, listItem.Name, "<DIRECTORY>", listItem.Modified);
                    }
                }

                foreach (FtpListItem listItem in files.OrderBy(x => x.Name))
                {
                    _ = DgvConsoleFiles.Rows.Add("file", ImageFile, listItem.Name, MainWindow.Settings.ShowFileSizeInBytes ? listItem.Size.ToString("#,0") + " bytes" : StringExtensions.FormatSize(listItem.Size.ToString()), listItem.Modified);
                    totalBytes += listItem.Size;
                }


                string statusFiles = files.Count > 0 ? $"{files.Count} {(files.Count == 1 ? "file" : "files")} {(files.Count > 0 && folders.Count > 0 ? "and " : "")}" : "" + $"{(folders.Count == 0 ? "." : "")}";
                string statusFolders = folders.Count > 0 ? $"{folders.Count} {(folders.Count == 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = totalBytes > 0 ? $"Total size: {(MainWindow.Settings.ShowFileSizeInBytes ? totalBytes.ToString("#,0") + " bytes" : StringExtensions.FormatSize(totalBytes.ToString()))}" : "";

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
            */
        }

        public void CreateLocalFolder()
        {
            try
            {
                var newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ", "");

                if (newName != null)
                {
                    string folderPath = TextBoxLocalPath.Text + @"\" + newName;

                    if (Directory.Exists(folderPath))
                    {
                        XtraMessageBox.Show($"A folder with this name already exists.", "Error");
                        return;
                    }
                    else
                    {
                        _ = Directory.CreateDirectory(folderPath);
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
            }
            catch (FtpException ex)
            {
                DarkMessageBox.ShowError($"Unable to create new folder. Error: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Unable to create new folder. Error: {ex.Message}", "Error");
            }
        }

        public void CreateConsoleFolder()
        {
            try
            {
                var folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ", "");

                if (folderName != null)
                {
                    string folderPath = FtpDirectoryPath + "/" + folderName;

                    if (XboxConsole.FileSystem.DirectoryExists(folderPath))
                    {
                        XtraMessageBox.Show($"A folder with this name already exists.", "Error");
                        return;
                    }
                    else
                    {
                        _ = FtpExtensions.CreateDirectory(folderPath);
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                }
            }
            catch (FtpException ex)
            {
                DarkMessageBox.ShowError($"Unable to create new folder. Error: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Unable to create new folder. Error: {ex.Message}", "Error");
            }
        }

        public void UploadLocalFile()
        {
            /*
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
                        SetStatus($"Uploading file to {consolePath}...");
                        FtpExtensions.UploadFile(localPath, consolePath);
                        SetStatus($"Successfully uploaded file: {Path.GetFileName(localPath)}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                    else
                    {
                        SetStatus("Unable to upload file as it doesn't exist on your computer.");
                    }
                }
                else if (type.Equals("folder"))
                {
                    var localPath = TextBoxLocalPath.Text + localName + @"\";
                    var consolePath = TextBoxConsolePath.Text + localName;

                    SetStatus($"Uploading folder to {consolePath}...");
                    //MainWindow.FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
                    SetStatus($"Successfully uploaded folder: {localPath}");
                    LoadConsoleDirectory(FtpDirectoryPath);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to upload to console. Error: {ex.Message}", ex);
            }
            */
        }

        public void DeleteLocalItem()
        {
            /*
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var type = DgvLocalFiles.CurrentRow.Cells[0].Value.ToString();
                    var name = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();

                    if (!name.Equals(".."))
                    {
                        var selectedItem = TextBoxLocalPath.Text + @"\" + DgvLocalFiles.CurrentRow.Cells[2].Value;

                        if (type.Equals("folder"))
                        {
                            SetStatus($"Deleting folder: {selectedItem}");
                            UserFolders.DeleteDirectory(selectedItem);
                            SetStatus($"Successfully deleted folder: {name}");
                        }
                        else if (type.Equals("file"))
                        {
                            if (File.Exists(selectedItem))
                            {
                                SetStatus($"Deleting file: {selectedItem}");
                                File.Delete(selectedItem);
                                SetStatus($"Successfully deleted file: {name}");
                            }
                        }
                    }

                    DgvLocalFiles.Rows.RemoveAt(DgvLocalFiles.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to delete item. Error: {ex.Message}", ex);
            }
            */
        }

        public void DownloadFromConsole()
        {
            /*
            try
            {
                var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                if (type.Equals("file"))
                {
                    var consoleFile = FtpDirectoryPath + name;
                    var localFile = LocalDirectoryPath + name;

                    if (File.Exists(localFile))
                    {
                        File.Delete(localFile);
                    }

                    SetConsoleStatus($"Downloading file: {Path.GetFileName(localFile)}");
                    FtpExtensions.DownloadFile(localFile, consoleFile);
                    SetConsoleStatus($"Successfully downloaded file: {Path.GetFileName(localFile)}");
                }
                else if (type.Equals("folder"))
                {
                    var consolePath = FtpDirectoryPath + name + "/";
                    var localPath = LocalDirectoryPath + name;

                    if (Directory.Exists(localPath))
                    {
                        UserFolders.DeleteDirectory(localPath);
                    }

                    SetConsoleStatus($"Downloading folder: {consolePath}");
                    //FtpExtensions.DownloadDirectory(consolePath, localPath);
                    //FtpClient.DownloadDirectory(localPath, consolePath, FtpFolderSyncMode.Mirror, FtpLocalExists.Overwrite);
                    SetConsoleStatus($"Successfully downloaded folder to: {localPath}");
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Error downloading console file. {ex.Message}", ex);
            }
            */

            LoadLocalDirectory(LocalDirectoryPath);
        }

        public void DeleteConsoleItem()
        {
            /*
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var type = DgvConsoleFiles.CurrentRow.Cells[0].Value.ToString();
                    var name = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();

                    var itemPath = FtpDirectoryPath + name;

                    if (type.Equals("folder"))
                    {
                        if (FtpDirectoryPath == "/dev_hdd0/home/")
                        {
                            itemPath = FtpDirectoryPath + name.Split()[0];
                        }

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
            */
        }

        private void RenameConsoleFile()
        {
            /*
            try
            {
                var oldFileName = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                var oldFilePath = TextBoxConsolePath.Text + oldFileName;

                var newFileName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName));

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
                        SetConsoleStatus($"Renaming file to: {newFileName}");
                        FtpExtensions.RenameFileOrFolder(FtpConnection, oldFilePath, newFileName);
                        SetConsoleStatus($"Successfully renamed file to: {newFileName}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Unable to rename file. Error: {ex.Message}", ex);
            }
            */
        }

        private void RenameConsoleFolder()
        {
            /*
            try
            {
                var oldFolderName = DgvConsoleFiles.CurrentRow.Cells[2].Value.ToString();
                var oldFileName = TextBoxConsolePath.Text + oldFolderName;

                var newFolderName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName));

                var newFolderPath = TextBoxConsolePath.Text + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpClient.DirectoryExists(oldFileName))
                    {
                        SetConsoleStatus($"A folder with this name already exists.");
                        return;
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming folder: {oldFileName} to: {newFolderName}");
                        FtpExtensions.RenameFileOrFolder(FtpConnection, oldFileName, newFolderName);
                        SetConsoleStatus($"Successfully renamed folder to: {newFolderName}");
                        LoadConsoleDirectory(FtpDirectoryPath);
                    }
                }
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Unable to rename folder. Error: {ex.Message}", ex);
            }
            */
        }

        private void RenameLocalFile()
        {
            /*
            if (DgvLocalFiles.CurrentRow != null)
            {
                var oldFileName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                var oldFilePath = TextBoxLocalPath.Text + @"\" + oldFileName;

                var newFileName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName));

                var newFilePath = TextBoxLocalPath.Text + @"\" + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (!File.Exists(newFilePath))
                    {
                        SetConsoleStatus($"A file with this name already exists.");
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming file to: {newFileName}");
                        FileSystem.RenameFile(oldFilePath, newFileName);
                        SetConsoleStatus($"Successfully renamed file to: {newFileName}");
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
            }
            */
        }

        private void RenameLocalFolder()
        {
            /*
            if (DgvLocalFiles.CurrentRow != null)
            {
                var oldFolderName = DgvLocalFiles.CurrentRow.Cells[2].Value.ToString();
                var oldFolderPath = TextBoxLocalPath.Text + @"\" + oldFolderName;

                var newFolderName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName));

                var newFolderPath = TextBoxLocalPath.Text + @"\" + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (!Directory.Exists(newFolderPath))
                    {
                        SetStatus($"A folder with this name already exists.");
                    }
                    else
                    {
                        SetConsoleStatus($"Renaming folder to: {newFolderName}");
                        FileSystem.RenameDirectory(oldFolderPath, newFolderName);
                        SetConsoleStatus($"Successfully renamed folder to: {newFolderName}");
                        LoadLocalDirectory(LocalDirectoryPath);
                    }
                }
            }
            */
        }

        /// <summary>
        /// Set the current process status in the console tool strip
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            LabelStatus.Caption = status;

            switch (ex)
            {
                case null:
                    Program.Log.Info(status);
                    break;
                default:
                    Program.Log.Error(ex, status);
                    break;
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