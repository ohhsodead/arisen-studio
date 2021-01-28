using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using FluentFTP;
using Microsoft.VisualBasic.FileIO;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Resources;
using ModioX.Net;
using ModioX.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FtpException = FluentFTP.FtpException;
using FtpExtensions = ModioX.Extensions.FtpExtensions;
using StringExtensions = ModioX.Extensions.StringExtensions;

namespace ModioX.Forms.Tools.PS3_Tools
{
    public partial class FileManagerWindow : XtraForm
    {
        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get the FTP connection for use with uploading mods, not reliable for uploading files.
        /// </summary>
        public static FtpConnection FtpConnection { get; }// = MainWindow.FtpConnection;

        /// <summary>
        /// Get the FtpClient for getting directory listings and some other commands.
        /// </summary>
        public static FtpClient FtpClient { get; }// = MainWindow.FtpClient;

        /// <summary>
        /// Get/set the current local directory path.
        /// </summary>
        public string DirectoryPathLocal { get; set; } = "/dev_hdd0/";

        /// <summary>
        /// Gets/set the current console directory path.
        /// </summary>
        public string DirectoryPathConsole { get; set; } = @"C:\";

        /// <summary>
        /// 
        /// </summary>
        private readonly Image ImageFile = ImageExtensions.ResizeBitmap(Resources.file, 20, 20);

        /// <summary>
        /// 
        /// </summary>
        private readonly Image ImageFolder = ImageExtensions.ResizeBitmap(Resources.folder, 20, 20);

        /// <summary>
        /// Get the user's local computer drives.
        /// </summary>
        private readonly DriveInfo[] localDrives = DriveInfo.GetDrives();

        public FileManagerWindow()
        {
            InitializeComponent();
        }

        private void FileManagerWindow_Load(object sender, EventArgs e)
        {
            WaitLoadConsole.Enabled = false;

            GridLocalFiles.Focus();

            SetStatus("Fetching drives...");

            foreach (DriveInfo driveInfo in localDrives) ComboBoxLocalDrives.Properties.Items.Add(driveInfo.Name.Replace(@"\", ""));

            if (Settings.SaveLocalPath)
            {
                if (Settings.LocalPathPS3.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathPS3))
                {
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                }
                else
                {
                    LoadLocalDirectory(Settings.LocalPathPS3);
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
                Settings.LocalPathPS3 = TextBoxLocalPath.Text;
            }

            if (!string.IsNullOrWhiteSpace(TextBoxConsolePath.Text))
            {
                Settings.ConsolePathPS3 = TextBoxConsolePath.Text;
            }
        }

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            SetStatus("Fetching root directories...");

            foreach (string driveName in FtpExtensions.GetFolderNames("/").ToArray())
            {
                ComboBoxConsoleDrives.Properties.Items.Add(driveName.Replace(@"/", ""));
            }

            if (Settings.SaveConsolePath)
            {
                if (Settings.ConsolePathPS3.Equals(@"/") || string.IsNullOrEmpty(Settings.ConsolePathPS3))
                {
                    LoadConsoleDirectory("/dev_hdd0/");
                }
                else
                {
                    LoadConsoleDirectory(Settings.ConsolePathPS3);
                }
            }
            else
            {
                LoadConsoleDirectory("/dev_hdd0/");
            }

            WaitLoadConsole.Enabled = false;
        }

        #region Local File Explorer

        private void ComboBoxLocalDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocalDirectory(ComboBoxLocalDrives.SelectedItem.ToString() + @"\");
        }

        private void ButtonBrowseLocalDirectory_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowser = new FolderBrowserDialog { ShowNewFolderButton = true };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                DirectoryPathLocal = folderBrowser.SelectedPath;

                if (Directory.Exists(folderBrowser.SelectedPath))
                {
                    LoadLocalDirectory(DirectoryPathLocal);
                }
            }
        }

        private void GridLocalFiles_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                string type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                ButtonLocalUpload.Enabled = type == "file" && name != "..";
                ButtonLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
            }
        }

        private void GridViewLocalFiles_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                string type = GridViewLocalFiles.GetRowCellValue(e.RowHandle, "Type").ToString();
                string name = GridViewLocalFiles.GetRowCellValue(e.RowHandle, "Name").ToString();

                ButtonLocalUpload.Enabled = type == "file" && name != "..";
                ButtonLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
            }
        }

        private void GridViewLocalFiles_DoubleClick(object sender, EventArgs e)
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                string type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                if (name == "..")
                {
                    string trimLastIndex = Path.GetDirectoryName(DirectoryPathLocal).TrimEnd('\\');
                    string parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";

                    if (Directory.Exists(parentDirectory))
                    {
                        LoadLocalDirectory(parentDirectory);
                    }
                }
                else if (type == "folder")
                {
                    LoadLocalDirectory(DirectoryPathLocal + @"\" + name + @"\");
                }

                ButtonLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalPath.Text);
            }
        }

        private void ButtonLocalUpload_Click(object sender, EventArgs e)
        {
            UploadLocalFile();
        }

        private void ButtonLocalDelete_Click(object sender, EventArgs e)
        {
            DeleteLocalItem();
        }

        private void ButtonLocalRename_Click(object sender, EventArgs e)
        {
            string type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();

            switch (type)
            {
                case "folder":
                    RenameLocalFolder();
                    break;
                case "file":
                    RenameLocalFile();
                    break;
                default:
                    break;
            }
        }

        private void ButtonLocalNewFolder_Click(object sender, EventArgs e)
        {
            CreateLocalFolder();
        }

        private void ButtonLocalRefresh_Click(object sender, EventArgs e)
        {
            LoadLocalDirectory(DirectoryPathLocal);
        }

        private void ButtonLocalOpenExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", TextBoxLocalPath.Text);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to open File Explorer for directory: {TextBoxLocalPath.Text} Error: {ex.Message}", ex);
            }
        }

        public void CreateLocalFolder()
        {
            try
            {
                string newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ", "");

                if (newName != null)
                {
                    string folderPath = TextBoxLocalPath.Text + @"\" + newName;

                    if (Directory.Exists(folderPath))
                    {
                        XtraMessageBox.Show($"A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Directory.CreateDirectory(folderPath);
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
            }
            catch (FtpException ex)
            {
                SetStatus($"Unable to create a new folder. Error: {ex.Message}");
                XtraMessageBox.Show($"Unable to create a new folder. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to create a new folder. Error: {ex.Message}");
                XtraMessageBox.Show($"Unable to create a new folder. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateConsoleFolder()
        {
            try
            {
                string folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ", "");

                if (folderName != null)
                {
                    string folderPath = DirectoryPathConsole + "/" + folderName;

                    if (FtpClient.DirectoryExists(folderPath))
                    {
                        XtraMessageBox.Show($"A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        FtpExtensions.CreateDirectory(folderPath);
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (FtpException ex)
            {
                SetStatus($"Unable to create a new folder. Error: {ex.Message}");
                XtraMessageBox.Show($"Unable to create a new folder. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to create a new folder. Error: {ex.Message}");
                XtraMessageBox.Show($"Unable to create a new folder. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UploadLocalFile()
        {
            try
            {
                string type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                if (type.Equals("file"))
                {
                    string localPath = TextBoxLocalPath.Text + name;
                    string consolePath = TextBoxConsolePath.Text + name;

                    if (File.Exists(localPath))
                    {
                        SetStatus($"Uploading file to {consolePath}...");
                        FtpExtensions.UploadFile(localPath, consolePath);
                        SetStatus($"Successfully uploaded file: {Path.GetFileName(localPath)}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                    else
                    {
                        SetStatus("Unable to upload file as it doesn't exist on your computer.");
                    }
                }
                else if (type.Equals("folder"))
                {
                    string localPath = TextBoxLocalPath.Text + name + @"\";
                    string consolePath = TextBoxConsolePath.Text + name;

                    SetStatus($"Uploading folder to {consolePath}...");
                    //FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
                    SetStatus($"Successfully uploaded folder: {localPath}");
                    LoadConsoleDirectory(DirectoryPathConsole);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to upload to console. Error: {ex.Message}", ex);
            }
        }

        public void DeleteLocalItem()
        {
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                    string name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                    if (!name.Equals(".."))
                    {
                        string selectedItem = TextBoxLocalPath.Text + @"\" + name;

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

                    GridViewLocalFiles.DeleteRow(GridViewLocalFiles.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to delete item. Error: {ex.Message}", ex);
            }
        }

        private void RenameLocalFile()
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                string oldFileName = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();
                string oldFilePath = TextBoxLocalPath.Text + @"\" + oldFileName;

                string newFileName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName));

                string newFilePath = TextBoxLocalPath.Text + @"\" + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (!File.Exists(newFilePath))
                    {
                        SetStatus($"A file with this name already exists.");
                    }
                    else
                    {
                        SetStatus($"Renaming file to: {newFileName}");
                        FileSystem.RenameFile(oldFilePath, newFileName);
                        SetStatus($"Successfully renamed file to: {newFileName}");
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
            }
        }

        private void RenameLocalFolder()
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                string oldFolderName = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();
                string oldFolderPath = TextBoxLocalPath.Text + @"\" + oldFolderName;

                string newFolderName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName));

                string newFolderPath = TextBoxLocalPath.Text + @"\" + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (!Directory.Exists(newFolderPath))
                    {
                        SetStatus($"A folder with this name already exists.");
                    }
                    else
                    {
                        SetStatus($"Renaming folder to: {newFolderName}");
                        FileSystem.RenameDirectory(oldFolderPath, newFolderName);
                        SetStatus($"Successfully renamed folder to: {newFolderName}");
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
            }
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

                DataTable localFiles = DataExtensions.CreateDataTable(
                    new List<DataColumn>
                    {
                        new DataColumn() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                        new DataColumn() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                        new DataColumn() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                        new DataColumn() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                        new DataColumn() { Caption = "Last Modified", ColumnName = "LastModified", DataType = typeof(string) }
                    });

                DirectoryPathLocal = directoryPath.Replace(@"\\", @"\");
                TextBoxLocalPath.Text = DirectoryPathLocal;

                SetStatus($"Fetching directory listing of '{DirectoryPathLocal}'...");

                ComboBoxLocalDrives.SelectedIndexChanged -= ComboBoxLocalDrives_SelectedIndexChanged;
                ComboBoxLocalDrives.SelectedItem = DirectoryPathLocal.Substring(0, 2);
                ComboBoxLocalDrives.SelectedIndexChanged += ComboBoxLocalDrives_SelectedIndexChanged;

                bool isParentRoot = localDrives.Any(x => x.Name.Equals(DirectoryPathLocal.Replace(@"\\", @"\")));

                if (!isParentRoot)
                {
                    localFiles.Rows.Add("folder", ImageFolder, "..", "<DIRECTORY>", Directory.GetLastWriteTime(DirectoryPathLocal));
                }

                int folders = 0;
                int files = 0;
                long totalBytes = 0;

                foreach (string directoryItem in Directory.GetDirectories(DirectoryPathLocal))
                {
                    localFiles.Rows.Add("folder", ImageFolder, Path.GetFileName(directoryItem), "<DIRECTORY>", Directory.GetLastWriteTime(directoryItem));

                    folders++;
                }

                foreach (string fileItem in Directory.GetFiles(DirectoryPathLocal))
                {
                    long fileBytes = new FileInfo(fileItem).Length;

                    localFiles.Rows.Add("file", ImageFile, Path.GetFileName(fileItem), Settings.ShowFileSizeInBytes ? fileBytes.ToString("#,0") + " bytes" : fileBytes.ToString().FormatSize(), File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                string statusFiles = files > 0 ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : "")}" : "" + $"{(folders < 1 ? "." : "")}";
                string statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = files > 0 ? $"Total size: {(Settings.ShowFileSizeInBytes ? totalBytes.ToString("#,0") + " bytes" : StringExtensions.FormatSize(totalBytes.ToString()))}" : "";

                if (files < 1 && folders < 1)
                {
                    SetLocalStatus("Empty directory.");
                }
                else
                {
                    SetLocalStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                }

                GridLocalFiles.DataSource = localFiles;

                GridViewLocalFiles.Columns[0].Visible = false;
                GridViewLocalFiles.Columns[1].Caption = " ";
                GridViewLocalFiles.Columns[1].Width = 8;
                GridViewLocalFiles.Columns[2].Width = 300;
                GridViewLocalFiles.Columns[3].Width = 100;
                GridViewLocalFiles.Columns[4].Width = 100;
            }
            catch (Exception ex)
            {
                SetStatus($"Error fetching directory listing for path: {DirectoryPathLocal} - {ex.Message}", ex);

                try
                {
                    // Attempt to load the parent directory listing instead
                    LoadLocalDirectory(Path.GetDirectoryName(DirectoryPathLocal) + @"\");
                }
                catch
                {
                    SetStatus($"Error fetching directory listing for path: {Path.GetDirectoryName(DirectoryPathLocal) + @"\"} - {ex.Message}", ex);
                }
            }
        }

        #endregion

        #region Console File Explorer

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConsoleDirectory("/" + ComboBoxConsoleDrives.SelectedItem.ToString() + "/");
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsolePath.Text);
        }

        private void GridConsoleFiles_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            if (GridViewConsoleFiles.SelectedRowsCount > 0)
            {
                string type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                ButtonConsoleDownload.Enabled = type == "file" && name != "..";
                ButtonConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonConsoleRename.Enabled = type == "file" && name != "..";
            }
        }

        private void GridViewConsoleFiles_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewConsoleFiles.SelectedRowsCount > 0)
            {
                string type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                ButtonConsoleDownload.Enabled = type == "file" && name != "..";
                ButtonConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonConsoleRename.Enabled = type == "file" && name != "..";
            }
        }

        private void GridConsoleFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GridViewConsoleFiles.SelectedRowsCount > 0)
            {
                string type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                if (name == "..") // Go to parent directory
                {
                    string trimLastIndex = Path.GetDirectoryName(DirectoryPathConsole).Replace(@"\", "/").TrimEnd('/');
                    string parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf("/")) + "/";

                    LoadConsoleDirectory(parentDirectory);
                }
                else if (type == "folder") // Go to selected folder directory
                {
                    if (DirectoryPathConsole == "/dev_hdd0/home/")
                    {
                        LoadConsoleDirectory(DirectoryPathConsole + name.Split()[0] + "/");
                    }
                    else if (DirectoryPathConsole == "/dev_hdd0/game/")
                    {
                        LoadConsoleDirectory(DirectoryPathConsole + name.Split()[0] + "/");
                    }
                    else
                    {
                        LoadConsoleDirectory(DirectoryPathConsole + name + "/");
                    }
                }
            }
        }

        private void ButtonConsoleDownload_Click(object sender, EventArgs e)
        {
            DownloadFromConsole();
        }

        private void ButtonConsoleDelete_Click(object sender, EventArgs e)
        {
            DeleteConsoleItem();
        }

        private void ButtonConsoleRename_Click(object sender, EventArgs e)
        {
            string type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();

            switch (type)
            {
                case "folder":
                    RenameConsoleFolder();
                    break;
                case "file":
                    RenameConsoleFile();
                    break;
                default:
                    break;
            }
        }

        private void ButtonConsoleNewFolder_Click(object sender, EventArgs e)
        {
            CreateConsoleFolder();
        }

        private void ButtonConsoleRefresh_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(DirectoryPathConsole);
        }

        /// <summary>
        /// Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath">Console path to retrieve</param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                GridConsoleFiles.DataSource = null;

                DataTable consoleFiles = DataExtensions.CreateDataTable(
                    new List<DataColumn>
                    {
                        new DataColumn() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                        new DataColumn() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                        new DataColumn() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                        new DataColumn() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                        new DataColumn() { Caption = "Last Modified", ColumnName = "LastModified", DataType = typeof(string) }
                    });

                DirectoryPathConsole = directoryPath.Replace("//", "/");
                TextBoxConsolePath.Text = DirectoryPathConsole;

                SetStatus($"Fetching directory listing of '{DirectoryPathConsole}'...");

                int secondIndexOfSlash = DirectoryPathConsole.TrimStart('/').IndexOfNth("/");
                string rootPath = DirectoryPathConsole.Substring(1, secondIndexOfSlash);

                ComboBoxConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxConsoleDrives.SelectedItem = rootPath;
                ComboBoxConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                bool isRoot = ComboBoxConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace("/", ""));

                if (!isRoot)
                {
                    consoleFiles.Rows.Add("folder", ImageFolder, "..", "<DIRECTORY>", DateTime.MinValue);
                }

                FtpClient.SetWorkingDirectory(DirectoryPathConsole);

                List<FtpListItem> folders = new List<FtpListItem>();
                List<FtpListItem> files = new List<FtpListItem>();

                long totalBytes = 0;

                foreach (FtpListItem listItem in FtpClient.GetListing(DirectoryPathConsole))
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
                    if (DirectoryPathConsole == "/dev_hdd0/home/")
                    {
                        string profileName = FtpExtensions.GetUserNameFromUserId(listItem.Name);
                        consoleFiles.Rows.Add("folder", ImageFolder, $"{listItem.Name} ({profileName})", "<PROFILE>", listItem.Modified);
                    }
                    else if (DirectoryPathConsole == "/dev_hdd0/game/")
                    {
                        string gameTitle = Settings.AutoDetectGameTitles ? $" ({HttpExtensions.GetGameTitleFromTitleID(listItem.Name)})" : "";
                        consoleFiles.Rows.Add("folder", ImageFolder, $"{listItem.Name}{gameTitle}", "<GAMEUPDATE>", listItem.Modified);
                    }
                    else
                    {
                        consoleFiles.Rows.Add("folder", ImageFolder, listItem.Name, "<DIRECTORY>", listItem.Modified);
                    }
                }

                foreach (FtpListItem listItem in files.OrderBy(x => x.Name))
                {
                    consoleFiles.Rows.Add("file", ImageFile, listItem.Name, Settings.ShowFileSizeInBytes ? listItem.Size.ToString("#,0") + " bytes" : StringExtensions.FormatSize(listItem.Size.ToString()), listItem.Modified);
                    totalBytes += listItem.Size;
                }


                string statusFiles = files.Count > 0 ? $"{files.Count} {(files.Count == 1 ? "file" : "files")} {(files.Count > 0 && folders.Count > 0 ? "and " : "")}" : "" + $"{(folders.Count == 0 ? "." : "")}";
                string statusFolders = folders.Count > 0 ? $"{folders.Count} {(folders.Count == 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = totalBytes > 0 ? $"Total size: {(Settings.ShowFileSizeInBytes ? totalBytes.ToString("#,0") + " bytes" : StringExtensions.FormatSize(totalBytes.ToString()))}" : "";

                if (files.Count < 1 && folders.Count < 1)
                {
                    SetConsoleStatus("Empty directory.");
                }
                else
                {
                    SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                }

                GridConsoleFiles.DataSource = consoleFiles;

                GridViewConsoleFiles.Columns[0].Visible = false;
                GridViewConsoleFiles.Columns[1].Caption = " ";
                GridViewConsoleFiles.Columns[1].Width = 8;
                GridViewConsoleFiles.Columns[2].Width = 300;
                GridViewConsoleFiles.Columns[3].Width = 100;
                GridViewConsoleFiles.Columns[4].Width = 100;
            }
            catch (FtpException ex)
            {
                SetStatus($"Error fetching directory listing for path: {DirectoryPathConsole}", ex);
            }
            catch (Exception ex)
            {
                SetStatus($"Error fetching directory listing for path: {DirectoryPathConsole}", ex);
            }
        }

        public void DownloadFromConsole()
        {
            try
            {
                string type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                string name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                if (type.Equals("file"))
                {
                    string consoleFile = DirectoryPathConsole + name;
                    string localFile = DirectoryPathLocal + name;

                    if (File.Exists(localFile))
                    {
                        File.Delete(localFile);
                    }

                    SetStatus($"Downloading file: {Path.GetFileName(localFile)}");
                    FtpExtensions.DownloadFile(localFile, consoleFile);
                    SetStatus($"Successfully downloaded file: {Path.GetFileName(localFile)}");
                }
                else if (type.Equals("folder"))
                {
                    string consolePath = DirectoryPathConsole + name + "/";
                    string localPath = DirectoryPathLocal + name;

                    if (Directory.Exists(localPath))
                    {
                        UserFolders.DeleteDirectory(localPath);
                    }

                    SetStatus($"Downloading folder: {consolePath}");
                    //FtpExtensions.DownloadDirectory(consolePath, localPath);
                    //FtpClient.DownloadDirectory(localPath, consolePath, FtpFolderSyncMode.Mirror, FtpLocalExists.Overwrite);
                    SetStatus($"Successfully downloaded folder to: {localPath}");
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Error downloading console file. {ex.Message}", ex);
            }

            LoadLocalDirectory(DirectoryPathLocal);
        }

        public void DeleteConsoleItem()
        {
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                    string name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                    string itemPath = DirectoryPathConsole + name;

                    if (type.Equals("folder"))
                    {
                        if (DirectoryPathConsole == "/dev_hdd0/home/")
                        {
                            itemPath = DirectoryPathConsole + name.Split()[0];
                        }

                        SetStatus($"Deleting folder: {itemPath}");
                        FtpExtensions.DeleteDirectory(FtpClient, itemPath);
                        SetStatus("Successfully deleted folder.");
                    }
                    else if (type.Equals("file"))
                    {
                        SetStatus($"Deleting file: {itemPath}");
                        FtpExtensions.DeleteFile(FtpClient, itemPath);
                        SetStatus("Successfully deleted file.");
                    }

                    GridViewConsoleFiles.DeleteRow(GridViewConsoleFiles.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to delete item. Error: {ex.Message}", ex);
            }
        }

        private void RenameConsoleFile()
        {
            try
            {
                string oldFileName = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();
                string oldFilePath = TextBoxConsolePath.Text + oldFileName;

                string newFileName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName));

                string newConsoleFilePath = TextBoxConsolePath.Text + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (FtpClient.FileExists(newConsoleFilePath))
                    {
                        SetStatus($"A file with this name already exists.");
                        return;
                    }
                    else
                    {
                        SetStatus($"Renaming file to: {newFileName}");
                        FtpExtensions.RenameFileOrFolder(FtpConnection, oldFilePath, newFileName);
                        SetStatus($"Successfully renamed file to: {newFileName}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to rename file. Error: {ex.Message}", ex);
            }
        }

        private void RenameConsoleFolder()
        {
            try
            {
                string oldFolderName = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();
                string oldFileName = TextBoxConsolePath.Text + oldFolderName;

                string newFolderName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName));

                string newFolderPath = TextBoxConsolePath.Text + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpClient.DirectoryExists(oldFileName))
                    {
                        SetStatus($"A folder with this name already exists.");
                        return;
                    }
                    else
                    {
                        SetStatus($"Renaming folder: {oldFileName} to: {newFolderName}");
                        FtpExtensions.RenameFileOrFolder(FtpConnection, oldFileName, newFolderName);
                        SetStatus($"Successfully renamed folder to: {newFolderName}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to rename folder. Error: {ex.Message}", ex);
            }
        }

        #endregion

        /// <summary>
        /// Set the current status in the local panel.
        /// </summary>
        /// <param name="status"></param>
        public void SetLocalStatus(string status)
        {
            LabelLocalStatus.Text = status;
            Refresh();
        }

        /// <summary>
        /// Set the current status in the console panel.
        /// </summary>
        /// <param name="status"></param>
        public void SetConsoleStatus(string status)
        {
            LabelConsoleStats.Text = status;
            Refresh();
        }

        /// <summary>
        /// Set the current status.
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
    }
}