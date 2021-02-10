using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FluentFTP;
using Humanizer;
using Microsoft.VisualBasic.FileIO;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Resources;
using ModioX.Net;
using ModioX.Properties;
using FtpException = FluentFTP.FtpException;
using FtpExtensions = ModioX.Extensions.FtpExtensions;
using StringExtensions = ModioX.Extensions.StringExtensions;

namespace ModioX.Forms.Windows
{
    public partial class FileManagerWindow : XtraForm
    {
        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        private static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get the user's connected consoles type.
        /// </summary>
        private static ConsoleTypePrefix ConsoleType { get; } = MainWindow.ConsoleType;

        /// <summary>
        /// Get the FTP connection for use with uploading mods, not reliable for uploading files.
        /// </summary>
        private static FtpConnection FtpConnection { get; } = MainWindow.FtpConnection;

        /// <summary>
        /// Get the FtpClient for getting directory listings and some other commands.
        /// </summary>
        private static FtpClient FtpClient { get; } = MainWindow.FtpClient;

        /// <summary>
        /// Get/set the current local directory path.
        /// </summary>
        private string DirectoryPathLocal { get; set; } = @"C:\";

        /// <summary>
        /// Gets/set the current console directory path.
        /// </summary>
        private string DirectoryPathConsole { get; set; } = ConsoleType == ConsoleTypePrefix.PS3 ? "/dev_hdd0/" : "/Hdd1/";

        /// <summary>
        /// Get the user's local computer drives.
        /// </summary>
        private readonly DriveInfo[] LocalDrives = DriveInfo.GetDrives();

        /// <summary>
        /// </summary>
        private readonly Image ImageFile = ImageExtensions.ResizeBitmap(Resources.file, 20, 20);

        /// <summary>
        /// </summary>
        private readonly Image ImageFolder = ImageExtensions.ResizeBitmap(Resources.folder, 20, 20);

        public FileManagerWindow()
        {
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            GridLocalFiles.Focus();

            SetStatus("Fetching drives...");

            foreach (var driveInfo in LocalDrives)
            {
                ComboBoxLocalDrives.Properties.Items.Add(driveInfo.Name.Replace(@"\", ""));
            }

            if (Settings.SaveLocalPath)
            {
                if (ConsoleType == ConsoleTypePrefix.PS3)
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
                else if (ConsoleType == ConsoleTypePrefix.XBOX)
                {
                    if (Settings.LocalPathXBOX.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathXBOX))
                    {
                        LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                    }
                    else
                    {
                        LoadLocalDirectory(Settings.LocalPathXBOX);
                    }
                }
            }
            else
            {
                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
            }
        }

        private void FileExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TextBoxLocalPath.Text.IsNullOrWhiteSpace())
            {
                if (ConsoleType == ConsoleTypePrefix.PS3)
                {
                    Settings.LocalPathPS3 = TextBoxLocalPath.Text;
                }
                else if (ConsoleType == ConsoleTypePrefix.XBOX)
                {
                    Settings.LocalPathXBOX = TextBoxLocalPath.Text;
                }
            }

            if (!TextBoxConsolePath.Text.IsNullOrWhiteSpace())
            {
                if (ConsoleType == ConsoleTypePrefix.PS3)
                {
                    Settings.ConsolePathPS3 = TextBoxConsolePath.Text;
                }
                else if (ConsoleType == ConsoleTypePrefix.XBOX)
                {
                    Settings.ConsolePathXBOX = TextBoxConsolePath.Text;
                }
            }
        }

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            WaitLoadConsole.Enabled = false;

            SetStatus("Fetching root directories...");

            if (ConsoleType == ConsoleTypePrefix.PS3)
            {
                foreach (var driveName in FtpExtensions.GetFolderNames("/", false).ToArray())
                {
                    ComboBoxConsoleDrives.Properties.Items.Add(driveName.Replace(@"/", ""));
                }
            }
            else if (ConsoleType == ConsoleTypePrefix.XBOX)
            {
                ComboBoxConsoleDrives.Properties.Items.AddRange(MainWindow.XboxConsole.Drives.Split(','));
            }

            if (Settings.SaveLocalPath)
            {
                switch (ConsoleType)
                {
                    case ConsoleTypePrefix.PS3:
                        if (Settings.ConsolePathPS3.Equals(@"\") || Settings.ConsolePathPS3.IsNullOrWhiteSpace())
                        {
                            LoadConsoleDirectory("/dev_hdd0/");
                        }
                        else
                        {
                            LoadConsoleDirectory(Settings.ConsolePathPS3);
                        }
                        break;

                    case ConsoleTypePrefix.XBOX:
                        if (Settings.ConsolePathXBOX.Equals(@"\") || Settings.ConsolePathXBOX.IsNullOrWhiteSpace())
                        {
                            LoadConsoleDirectory("/Hdd1/");
                        }
                        else
                        {
                            LoadConsoleDirectory(Settings.ConsolePathXBOX);
                        }
                        break;
                }
            }
            else
            {
                LoadConsoleDirectory("/Hdd1/");
            }

            WaitLoadConsole.Enabled = false;
        }

        #region Local File Explorer

        private void ComboBoxLocalDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocalDirectory(ComboBoxLocalDrives.SelectedItem + @"\");
        }

        private void ButtonBrowseLocalDirectory_Click(object sender, EventArgs e)
        {
            using var folderBrowser = new FolderBrowserDialog { ShowNewFolderButton = true };

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
                var type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                ButtonLocalUpload.Enabled = type == "file" && name != "..";
                ButtonLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
            }
        }

        private void GridViewLocalFiles_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                var type = GridViewLocalFiles.GetRowCellValue(e.RowHandle, "Type").ToString();
                var name = GridViewLocalFiles.GetRowCellValue(e.RowHandle, "Name").ToString();

                ButtonLocalUpload.Enabled = type == "file" && name != "..";
                ButtonLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
            }
        }

        private void GridViewLocalFiles_DoubleClick(object sender, EventArgs e)
        {
            if (GridViewLocalFiles.SelectedRowsCount > 0)
            {
                var type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                if (name == "..")
                {
                    var trimLastIndex = Path.GetDirectoryName(DirectoryPathLocal).TrimEnd('\\');
                    var parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";

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
            var type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();

            switch (type)
            {
                case "folder":
                    RenameLocalFolder();
                    break;

                case "file":
                    RenameLocalFile();
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
                var newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ", "");

                if (newName != null)
                {
                    var folderPath = TextBoxLocalPath.Text + @"\" + newName;

                    if (Directory.Exists(folderPath))
                    {
                        XtraMessageBox.Show("A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Directory.CreateDirectory(folderPath);
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
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
                var type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                if (type.Equals("file"))
                {
                    var localPath = TextBoxLocalPath.Text + name;
                    var consolePath = TextBoxConsolePath.Text + name;

                    if (File.Exists(localPath))
                    {
                        SetStatus($"Uploading file to {consolePath}...");

                        if (ConsoleType == ConsoleTypePrefix.PS3) 
                        { FtpExtensions.UploadFilePS3(localPath, consolePath); 
                        }
                        else
                        {
                            FtpExtensions.UploadFileXBOX(localPath, consolePath);
                        }

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
                    var localPath = TextBoxLocalPath.Text + name + @"\";
                    var consolePath = TextBoxConsolePath.Text + name;

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
                    var type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
                    var name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

                    if (!name.Equals(".."))
                    {
                        var selectedItem = TextBoxLocalPath.Text + @"\" + name;

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
                var oldFileName = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();
                var oldFilePath = TextBoxLocalPath.Text + @"\" + oldFileName;

                var newFileName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName));

                var newFilePath = TextBoxLocalPath.Text + @"\" + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (!File.Exists(newFilePath))
                    {
                        SetStatus("A file with this name already exists.");
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
                var oldFolderName = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();
                var oldFolderPath = TextBoxLocalPath.Text + @"\" + oldFolderName;

                var newFolderName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName));

                var newFolderPath = TextBoxLocalPath.Text + @"\" + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (!Directory.Exists(newFolderPath))
                    {
                        SetStatus("A folder with this name already exists.");
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
        /// <param name="directoryPath"> </param>
        public void LoadLocalDirectory(string directoryPath)
        {
            try
            {
                GridLocalFiles.DataSource = null;

                var localFiles = DataExtensions.CreateDataTable(
                    new List<DataColumn>
                    {
                        new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                        new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                        new() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                        new() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                        new() { Caption = "Last Modified", ColumnName = "Last Modified", DataType = typeof(string) }
                    });

                DirectoryPathLocal = directoryPath.Replace(@"\\", @"\");
                TextBoxLocalPath.Text = DirectoryPathLocal;

                SetStatus($"Fetching directory listing of '{DirectoryPathLocal}'...");

                ComboBoxLocalDrives.SelectedIndexChanged -= ComboBoxLocalDrives_SelectedIndexChanged;
                ComboBoxLocalDrives.SelectedItem = DirectoryPathLocal.Substring(0, 2);
                ComboBoxLocalDrives.SelectedIndexChanged += ComboBoxLocalDrives_SelectedIndexChanged;

                var isParentRoot = LocalDrives.Any(x => x.Name.Equals(DirectoryPathLocal.Replace(@"\\", @"\")));

                if (!isParentRoot)
                {
                    localFiles.Rows.Add("folder", ImageFolder, "..", "<DIRECTORY>", Directory.GetLastWriteTime(DirectoryPathLocal));
                }

                var folders = 0;
                var files = 0;
                long totalBytes = 0;

                foreach (var directoryItem in Directory.GetDirectories(DirectoryPathLocal))
                {
                    localFiles.Rows.Add("folder", ImageFolder, Path.GetFileName(directoryItem), "<DIRECTORY>", Directory.GetLastWriteTime(directoryItem));

                    folders++;
                }

                foreach (var fileItem in Directory.GetFiles(DirectoryPathLocal))
                {
                    var fileBytes = new FileInfo(fileItem).Length;

                    localFiles.Rows.Add("file", ImageFile, Path.GetFileName(fileItem), Settings.ShowFileSizeInBytes ? fileBytes.Bytes().Humanize() : fileBytes.Bytes().Humanize("MB"), File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                var statusFiles = files > 0 ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : "")}" : "" + $"{(folders < 1 ? "." : "")}";
                var statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : "";
                var statusTotalBytes = files > 0 ? $"Total size: {(Settings.ShowFileSizeInBytes ? totalBytes.Bytes().Humanize() : totalBytes.Bytes().Humanize("MB"))}" : "";

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

                SetStatus("Successfully fetched directory listing.");
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

        #endregion Local File Explorer

        #region Console File Explorer

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConsoleDirectory("/" + ComboBoxConsoleDrives.SelectedItem + "/");
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsolePath.Text);
        }

        private void GridConsoleFiles_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            if (GridViewConsoleFiles.SelectedRowsCount > 0)
            {
                var type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                ButtonConsoleDownload.Enabled = type == "file" && name != "..";
                ButtonConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonConsoleRename.Enabled = type == "file" && name != "..";
            }
        }

        private void GridViewConsoleFiles_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewConsoleFiles.SelectedRowsCount > 0)
            {
                var type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                ButtonConsoleDownload.Enabled = type == "file" && name != "..";
                ButtonConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                ButtonConsoleRename.Enabled = type == "file" && name != "..";
            }
        }

        private void GridConsoleFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GridViewConsoleFiles.SelectedRowsCount > 0)
            {
                var type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                if (name == "..") // Go to parent directory
                {
                    var trimLastIndex = Path.GetDirectoryName(DirectoryPathConsole).Replace(@"\", "/").TrimEnd('/');
                    var parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf("/")) + "/";

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
            var type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();

            switch (type)
            {
                case "folder":
                    RenameConsoleFolder();
                    break;

                case "file":
                    RenameConsoleFile();
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
        /// <param name="directoryPath"> Console path to retrieve </param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                GridConsoleFiles.DataSource = null;

                var consoleFiles = DataExtensions.CreateDataTable(
                    new List<DataColumn>
                    {
                        new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                        new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                        new() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                        new() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                        new() { Caption = "Last Modified", ColumnName = "Last Modified", DataType = typeof(string) }
                    });

                DirectoryPathConsole = directoryPath.Replace("//", "/");
                TextBoxConsolePath.Text = DirectoryPathConsole;

                SetStatus($"Fetching directory listing of '{DirectoryPathConsole}'...");

                var secondIndexOfSlash = DirectoryPathConsole.TrimStart('/').IndexOfNth("/");
                var rootPath = DirectoryPathConsole.Substring(1, secondIndexOfSlash);

                ComboBoxConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxConsoleDrives.SelectedItem = rootPath.Replace("/", string.Empty);
                ComboBoxConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                var isRoot = ComboBoxConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace("/", ""));

                if (!isRoot)
                {
                    consoleFiles.Rows.Add("folder", ImageFolder, "..", "<DIRECTORY>", DateTime.MinValue);
                }

                FtpClient.SetWorkingDirectory(DirectoryPathConsole);

                var folders = new List<FtpListItem>();
                var files = new List<FtpListItem>();

                long totalBytes = 0;

                foreach (var listItem in FtpClient.GetListing(DirectoryPathConsole))
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

                foreach (var listItem in folders.OrderBy(x => x.Name))
                {
                    if (DirectoryPathConsole == "/dev_hdd0/home/")
                    {
                        var profileName = FtpExtensions.GetUserNameFromUserId(listItem.Name);
                        consoleFiles.Rows.Add("folder", ImageFolder, $"{listItem.Name} ({profileName})", "<PROFILE>", listItem.Modified);
                    }
                    else if (DirectoryPathConsole == "/dev_hdd0/game/")
                    {
                        var gameTitle = Settings.AutoDetectGameTitles ? $" ({HttpExtensions.GetGameTitleFromTitleID(listItem.Name)})" : "";
                        consoleFiles.Rows.Add("folder", ImageFolder, $"{listItem.Name}{gameTitle}", "<GAMEUPDATE>", listItem.Modified);
                    }
                    else
                    {
                        consoleFiles.Rows.Add("folder", ImageFolder, listItem.Name, "<DIRECTORY>", listItem.Modified);
                    }
                }

                foreach (var listItem in files.OrderBy(x => x.Name))
                {
                    consoleFiles.Rows.Add("file", ImageFile, listItem.Name, Settings.ShowFileSizeInBytes ? listItem.Size.Bytes().Humanize() : listItem.Size.Bytes().Humanize("MB"), listItem.Modified);
                    totalBytes += listItem.Size;
                }

                var statusFiles = files.Count > 0 ? $"{files.Count} {(files.Count == 1 ? "file" : "files")} {(files.Count > 0 && folders.Count > 0 ? "and " : "")}" : "" + $"{(folders.Count == 0 ? "." : "")}";
                var statusFolders = folders.Count > 0 ? $"{folders.Count} {(folders.Count == 1 ? "directory" : "directories")}. " : "";
                var statusTotalBytes = totalBytes > 0 ? $"Total size: {(Settings.ShowFileSizeInBytes ? totalBytes.Bytes().Humanize() : totalBytes.Bytes().Humanize("MB"))}" : "";

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

                SetStatus("Successfully fetched directory listing.");
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
                var type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                var name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                if (type.Equals("file"))
                {
                    var consoleFile = DirectoryPathConsole + name;
                    var localFile = DirectoryPathLocal + name;

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
                    var consolePath = DirectoryPathConsole + name + "/";
                    var localPath = DirectoryPathLocal + name;

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
                    var type = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Type").ToString();
                    var name = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();

                    var itemPath = DirectoryPathConsole + name;

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
                var oldFileName = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();
                var oldFilePath = TextBoxConsolePath.Text + oldFileName;

                var newFileName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName));

                var newConsoleFilePath = TextBoxConsolePath.Text + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (FtpClient.FileExists(newConsoleFilePath))
                    {
                        SetStatus("A file with this name already exists.");
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
                var oldFolderName = GridViewConsoleFiles.GetRowCellValue(GridViewConsoleFiles.FocusedRowHandle, "Name").ToString();
                var oldFileName = TextBoxConsolePath.Text + oldFolderName;

                var newFolderName = StringExtensions.ReplaceInvalidChars(DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName));

                var newFolderPath = TextBoxConsolePath.Text + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpClient.DirectoryExists(oldFileName))
                    {
                        SetStatus("A folder with this name already exists.");
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

        public void CreateConsoleFolder()
        {
            try
            {
                var folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ", "");

                if (folderName != null)
                {
                    var folderPath = DirectoryPathConsole + "/" + folderName;

                    if (FtpClient.DirectoryExists(folderPath))
                    {
                        XtraMessageBox.Show("A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion Console File Explorer

        /// <summary>
        /// Set the current status in the local panel.
        /// </summary>
        /// <param name="status"> </param>
        public void SetLocalStatus(string status)
        {
            LabelLocalStatus.Text = status;
            Refresh();
        }

        /// <summary>
        /// Set the current status in the console panel.
        /// </summary>
        /// <param name="status"> </param>
        public void SetConsoleStatus(string status)
        {
            LabelConsoleStats.Text = status;
            Refresh();
        }

        /// <summary>
        /// Set the current status.
        /// </summary>
        /// <param name="status"> </param>
        /// <param name="ex"> </param>
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

        GridHitInfo downHitInfo = null;

        private void GridViewLocalFiles_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                downHitInfo = hitInfo;
        }

        private void GridViewLocalFiles_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void GridConsoleFiles_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void GridConsoleFiles_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row != null && table != null && row.Table != table)
            {
                table.ImportRow(row);
            }
        }
    }
}