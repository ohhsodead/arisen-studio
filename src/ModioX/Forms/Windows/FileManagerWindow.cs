using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FluentFTP;
using Humanizer;
using Microsoft.VisualBasic.FileIO;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Models.Resources;
using XDevkit;
using FtpException = FluentFTP.FtpException;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Windows
{
    public partial class FileManagerWindow : XtraForm
    {
        /// <summary>
        /// Get the user's local computer drives.
        /// </summary>
        private readonly DriveInfo[] LocalDrives = DriveInfo.GetDrives();

        private GridHitInfo downHitInfo;

        public FileManagerWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        private static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get the user's connected consoles type.
        /// </summary>
        private static PlatformPrefix ConsoleType { get; } = MainWindow.PlatformType;

        /// <summary>
        /// Get the FtpClient for getting directory listings and some other commands.
        /// </summary>
        private static FtpClient FtpClient { get; } = MainWindow.FtpClient;

        /// <summary>
        /// Get the xbox console connection.
        /// </summary>
        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        /// <summary>
        /// Get/set the current local directory path.
        /// </summary>
        private string DirectoryPathLocal { get; set; } = @"C:\";

        /// <summary>
        /// Gets/set the current console directory path.
        /// </summary>
        private string DirectoryPathConsole { get; set; } = ConsoleType == PlatformPrefix.PS3 ? "/dev_hdd0/" : @"Hdd:\";

        /// <summary>
        /// </summary>
        private Image ImageFile => ImageCollection.Images["file"];

        /// <summary>
        /// </summary>
        private Image ImageFolder => ImageCollection.Images["folder"];

        /// <summary>
        /// </summary>
        private Image ImageFolderUp => ImageCollection.Images["folder up"];

        private void FileManager_Load(object sender, EventArgs e)
        {
            GridLocalFiles.Focus();

            ButtonConsoleAddToGames.Visible = ConsoleType == PlatformPrefix.XBOX;

            SetStatus($"{MainWindow.ResourceLanguage.GetString("Fetching drives")}...");

            foreach (DriveInfo driveInfo in LocalDrives)
            {
                ComboBoxLocalDrives.Properties.Items.Add(driveInfo.Name.Replace(@"\", ""));
            }

            switch (Settings.RememberLocalPath)
            {
                case true when ConsoleType == PlatformPrefix.PS3:
                    {
                        if (Settings.LocalPathPS3.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathPS3))
                        {
                            LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                        }
                        else
                        {
                            LoadLocalDirectory(Settings.LocalPathPS3);
                        }

                        break;
                    }
                case true:
                    {
                        switch (ConsoleType)
                        {
                            case PlatformPrefix.XBOX when Settings.LocalPathXBOX.Equals(@"\") || string.IsNullOrWhiteSpace(Settings.LocalPathXBOX):
                                LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                                break;
                            case PlatformPrefix.XBOX:
                                LoadLocalDirectory(Settings.LocalPathXBOX);
                                break;
                        }

                        break;
                    }
                default:
                    LoadLocalDirectory(KnownFolders.GetPath(KnownFolder.Documents) + @"\");
                    break;
            }
        }

        private void FileExplorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TextBoxLocalPath.Text.IsNullOrWhiteSpace())
            {
                switch (ConsoleType)
                {
                    case PlatformPrefix.PS3:
                        Settings.LocalPathPS3 = TextBoxLocalPath.Text;
                        break;
                    case PlatformPrefix.XBOX:
                        Settings.LocalPathXBOX = TextBoxLocalPath.Text;
                        break;
                }
            }

            if (!TextBoxConsolePath.Text.IsNullOrWhiteSpace())
            {
                switch (ConsoleType)
                {
                    case PlatformPrefix.PS3:
                        Settings.ConsolePathPS3 = TextBoxConsolePath.Text;
                        break;
                    case PlatformPrefix.XBOX:
                        Settings.ConsolePathXBOX = TextBoxConsolePath.Text;
                        break;
                }
            }
        }

        private void WaitLoadConsole_Tick(object sender, EventArgs e)
        {
            WaitLoadConsole.Enabled = false;

            SetStatus($"{MainWindow.ResourceLanguage.GetString("Fetching root directories")}...");

            switch (ConsoleType)
            {
                case PlatformPrefix.PS3:
                    {
                        foreach (ListItem driveName in FtpExtensions.GetFolderNames("/"))
                        {
                            ComboBoxConsoleDrives.Properties.Items.Add(driveName.Name.Replace(@"/", ""));
                        }

                        break;
                    }

                case PlatformPrefix.XBOX:
                    {
                        foreach (string drive in MainWindow.XboxConsole.Drives.Split(','))
                        {
                            bool isStartUppercase = char.IsUpper(drive.First());

                            if (isStartUppercase)
                            {
                                ComboBoxConsoleDrives.Properties.Items.Add(drive.Transform(To.TitleCase));
                            }
                            else
                            {
                                ComboBoxConsoleDrives.Properties.Items.Add(drive);
                            }
                        }

                        break;
                    }

            }

            switch (Settings.RememberLocalPath)
            {
                case true:
                    switch (ConsoleType)
                    {
                        case PlatformPrefix.PS3:

                            if (Settings.ConsolePathPS3.Equals("/") || Settings.ConsolePathPS3.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory("/" + ComboBoxConsoleDrives.Properties.Items[0] + "/");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathPS3);
                            }

                            break;

                        case PlatformPrefix.XBOX:

                            if (Settings.ConsolePathXBOX.Equals(@"\") || Settings.ConsolePathXBOX.IsNullOrWhiteSpace())
                            {
                                LoadConsoleDirectory(ComboBoxConsoleDrives.Properties.Items[0] + @":\");
                            }
                            else
                            {
                                LoadConsoleDirectory(Settings.ConsolePathXBOX);
                            }

                            break;
                    }

                    break;
                case false:
                    switch (ConsoleType)
                    {
                        case PlatformPrefix.PS3:

                            LoadConsoleDirectory("/dev_hdd0/");
                            break;

                        case PlatformPrefix.XBOX:

                            LoadConsoleDirectory(ComboBoxConsoleDrives.Properties.Items[0] + @":\");
                            break;
                    }
                    break;
            }

            SetStatus($"{MainWindow.ResourceLanguage.GetString("Successfully fetched root directories")}.");

            WaitLoadConsole.Enabled = false;
        }

        private void GridViewLocalFiles_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (ModifierKeys != Keys.None)
            {
                return;
            }

            downHitInfo = e.Button switch
            {
                MouseButtons.Left when hitInfo.RowHandle >= 0 => hitInfo,
                _ => downHitInfo
            };
        }

        private void GridViewLocalFiles_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            switch (e.Button)
            {
                case MouseButtons.Left when downHitInfo != null:
                    {
                        Size dragSize = SystemInformation.DragSize;
                        Rectangle dragRect = new(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                            downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                        if (!dragRect.Contains(new Point(e.X, e.Y)))
                        {
                            DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                            view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                            downHitInfo = null;
                            DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        }

                        break;
                    }
            }
        }

        private void GridConsoleFiles_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void GridConsoleFiles_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;

            if (e.Data.GetData(typeof(DataRow)) is DataRow row && grid.DataSource is DataTable table && row.Table != table)
            {
                table.ImportRow(row);
            }
        }

        #region Local File Explorer

        private void ComboBoxLocalDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocalDirectory(ComboBoxLocalDrives.SelectedItem + @"\");
        }

        private void ButtonBrowseLocalDirectory_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowser = new() { ShowNewFolderButton = true };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                DirectoryPathLocal = folderBrowser.SelectedPath;

                if (Directory.Exists(folderBrowser.SelectedPath))
                {
                    LoadLocalDirectory(DirectoryPathLocal);
                }
            }
        }

        private DataTable DataTableLocalFiles { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>
            {
                    new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                    new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                    new() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                    new() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                    new() { Caption = "Last Modified", ColumnName = "Last Modified", DataType = typeof(string) }
            });

        /// <summary>
        /// Loads files and folders into the local datagridview
        /// </summary>
        /// <param name="directoryPath"> </param>
        public void LoadLocalDirectory(string directoryPath)
        {
            try
            {
                SetLocalStatus($"Fetching directory listing of '{directoryPath}'...");

                DataTableLocalFiles.Rows.Clear();

                DirectoryPathLocal = directoryPath.Replace(@"\\", @"\");
                TextBoxLocalPath.Text = DirectoryPathLocal;

                ComboBoxLocalDrives.SelectedIndexChanged -= ComboBoxLocalDrives_SelectedIndexChanged;
                ComboBoxLocalDrives.SelectedItem = DirectoryPathLocal.Substring(0, 2);
                ComboBoxLocalDrives.SelectedIndexChanged += ComboBoxLocalDrives_SelectedIndexChanged;

                bool isParentRoot = LocalDrives.Any(x => x.Name.Equals(DirectoryPathLocal.Replace(@"//", @"/")));

                switch (isParentRoot)
                {
                    case false:
                        DataTableLocalFiles.Rows.Add("folder",
                                                     ImageFolderUp,
                                                     "..",
                                                     "",
                                                     "");
                        break;
                }

                int folders = 0;
                int files = 0;
                long totalBytes = 0;

                foreach (string directoryItem in Directory.GetDirectories(DirectoryPathLocal))
                {
                    DataTableLocalFiles.Rows.Add("folder",
                                                 ImageFolder,
                                                 Path.GetFileName(directoryItem),
                                                 "<DIRECTORY>",
                                                 Directory.GetLastWriteTime(directoryItem));

                    folders++;
                }

                foreach (string fileItem in Directory.GetFiles(DirectoryPathLocal))
                {
                    long fileBytes = new FileInfo(fileItem).Length;

                    DataTableLocalFiles.Rows.Add("file",
                                        ImageFile,
                                        Path.GetFileName(fileItem),
                                        Settings.UseFormattedFileSizes ? fileBytes.Bytes().Humanize("#.##") : fileBytes + " Bytes",
                                        File.GetLastWriteTime(fileItem));

                    files++;
                    totalBytes += fileBytes;
                }

                SetLocalStatus("Successfully fetched directory listing.");

                string statusFiles = files > 0
                    ? $"{files} {(files <= 1 ? "file" : "files")} {(files > 0 && folders > 0 ? "and " : "")}"
                    : "" + $"{(folders < 1 ? "." : "")}";
                string statusFolders = folders > 0 ? $"{folders} {(folders <= 1 ? "directory" : "directories")}. " : "";
                string statusTotalBytes = files > 0
                    ? $"Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " bytes")}"
                    : "";

                switch (files)
                {
                    case < 1 when folders < 1:
                        SetLocalStatus("Empty directory.");
                        break;
                    default:
                        SetLocalStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                        break;
                }

                GridLocalFiles.DataSource = DataTableLocalFiles;

                GridViewConsoleFiles.FocusedRowHandle = -1;

                GridViewLocalFiles.Columns[0].Visible = false;
                GridViewLocalFiles.Columns[1].Caption = " ";
                GridViewLocalFiles.Columns[1].MinWidth = 22;
                GridViewLocalFiles.Columns[1].MaxWidth = 22;
                GridViewLocalFiles.Columns[1].ImageOptions.Alignment = StringAlignment.Center;
                //GridViewLocalFiles.Columns[1].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

                //GridViewLocalFiles.Columns[2].Width = 300;

                GridViewLocalFiles.Columns[3].MinWidth = 150;
                GridViewLocalFiles.Columns[3].MaxWidth = 150;

                GridViewLocalFiles.Columns[4].MinWidth = 125;
                GridViewLocalFiles.Columns[4].MaxWidth = 125;
            }
            catch (Exception ex)
            {
                SetLocalStatus($"Error fetching directory listing for path: {DirectoryPathLocal} - {ex.Message}", ex);

                try
                {
                    // Attempt to load the parent directory listing instead
                    LoadLocalDirectory(Path.GetDirectoryName(DirectoryPathLocal) + @"\");
                }
                catch
                {
                    SetLocalStatus($"Error fetching directory listing for path: {Path.GetDirectoryName(DirectoryPathLocal) + @"\"} - {ex.Message}", ex);
                }
            }
        }

        private void GridViewLocalFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewLocalFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewLocalFiles.GetFocusedRowCellDisplayText("Name");

                        ButtonLocalUpload.Enabled = type == "file" && name != "..";
                        ButtonLocalDelete.Enabled = (type == "file") | (type == "folder") && name != "..";
                        ButtonLocalRename.Enabled = (type == "file") | (type == "folder") && name != "..";
                        break;
                    }
            }
        }

        private void GridLocalFiles_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            //switch (GridViewLocalFiles.SelectedRowsCount)
            //{
            //    case > 0:
            //        {
            //            string type = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Type").ToString();
            //            string name = GridViewLocalFiles.GetRowCellValue(GridViewLocalFiles.FocusedRowHandle, "Name").ToString();

            //            ButtonLocalUpload.Enabled = type == "file" && name != "..";
            //            ButtonLocalDelete.Enabled = (type == "file") | (type == "folder") && name != "..";
            //            ButtonLocalRename.Enabled = (type == "file") | (type == "folder") && name != "..";
            //            break;
            //        }
            //}
        }

        private void GridViewLocalFiles_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewLocalFiles.GetRowCellValue(e.RowHandle, "Type").ToString();
                        string name = GridViewLocalFiles.GetRowCellValue(e.RowHandle, "Name").ToString();

                        ButtonLocalUpload.Enabled = type == "file" && name != "..";
                        ButtonLocalDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonLocalRename.Enabled = type == "file" | type == "folder" && name != "..";
                        break;
                    }
            }
        }

        private void GridViewLocalFiles_DoubleClick(object sender, EventArgs e)
        {
            switch (GridViewLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewLocalFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewLocalFiles.GetFocusedRowCellDisplayText("Name");

                        switch (name)
                        {
                            case "..":
                                {
                                    string trimLastIndex = Path.GetDirectoryName(DirectoryPathLocal).TrimEnd('\\');
                                    string parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";

                                    if (Directory.Exists(parentDirectory))
                                    {
                                        LoadLocalDirectory(parentDirectory);
                                    }

                                    break;
                                }
                            default:
                                {
                                    switch (type)
                                    {
                                        case "folder":
                                            LoadLocalDirectory(DirectoryPathLocal + @"\" + name + @"\");
                                            break;
                                    }

                                    break;
                                }
                        }

                        ButtonLocalOpenExplorer.Enabled = Directory.Exists(TextBoxLocalPath.Text);
                        break;
                    }
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
            string type = GridViewLocalFiles.GetFocusedRowCellDisplayText("Type");

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
                string newName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder name: ");

                if (newName != null)
                {
                    string folderPath = TextBoxLocalPath.Text + @"\" + newName;

                    if (Directory.Exists(folderPath))
                    {
                        XtraMessageBox.Show("A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetStatus($"Creating local folder: {folderPath}");
                        Directory.CreateDirectory(folderPath);
                        SetStatus($"Successfully created local folder: {folderPath}");
                        LoadLocalDirectory(DirectoryPathLocal);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to create a new folder on your computer. Error: {ex.Message}");
                XtraMessageBox.Show($"Unable to create a new folder on your computer. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UploadLocalFile()
        {
            try
            {
                string type = GridViewLocalFiles.GetFocusedRowCellDisplayText("Type");
                string name = GridViewLocalFiles.GetFocusedRowCellDisplayText("Name");

                switch (type)
                {
                    case "file":
                        {
                            string localPath = TextBoxLocalPath.Text + name;
                            string consolePath = TextBoxConsolePath.Text + name;

                            if (File.Exists(localPath))
                            {
                                SetStatus($"Uploading file to {consolePath}...");

                                switch (ConsoleType)
                                {
                                    case PlatformPrefix.PS3:
                                        FtpExtensions.UploadFile(localPath, consolePath);
                                        break;
                                    default:
                                        XboxConsole.SendFile(localPath, consolePath);
                                        break;
                                }

                                SetStatus($"Successfully uploaded local file: {Path.GetFileName(localPath)}");
                                LoadConsoleDirectory(DirectoryPathConsole);
                            }
                            else
                            {
                                SetStatus("Unable to upload local file as it doesn't exist on your computer.");
                            }

                            break;
                        }
                    case "folder":
                        {
                            string localPath = TextBoxLocalPath.Text + name + @"\";
                            string consolePath = TextBoxConsolePath.Text + name;

                            SetStatus($"Uploading folder to {consolePath}...");
                            //FtpClient.UploadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpRemoteExists.Overwrite);
                            SetStatus($"Successfully uploaded local folder: {localPath}");
                            LoadConsoleDirectory(DirectoryPathConsole);
                            break;
                        }
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
                    string type = GridViewLocalFiles.GetFocusedRowCellDisplayText("Type");
                    string name = GridViewLocalFiles.GetFocusedRowCellDisplayText("Name");

                    switch (name.Equals(".."))
                    {
                        case false:
                            {
                                string selectedItem = TextBoxLocalPath.Text + @"\" + name;

                                switch (type)
                                {
                                    case "folder":
                                        SetStatus($"Deleting local folder: {selectedItem}");
                                        UserFolders.DeleteDirectory(selectedItem);
                                        SetStatus($"Successfully deleted local folder: {name}");
                                        break;
                                    case "file":
                                        {
                                            if (File.Exists(selectedItem))
                                            {
                                                SetStatus($"Deleting local file: {selectedItem}");
                                                File.Delete(selectedItem);
                                                SetStatus($"Successfully deleted local file: {name}");
                                            }

                                            break;
                                        }
                                }

                                break;
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
            switch (GridViewLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string oldFileName = GridViewLocalFiles.GetFocusedRowCellDisplayText("Name");
                        string oldFilePath = TextBoxLocalPath.Text + @"\" + oldFileName;

                        string newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName).RemoveInvalidChars();

                        string newFilePath = TextBoxLocalPath.Text + @"\" + newFileName;

                        if (newFileName != null && !newFileName.Equals(oldFileName))
                        {
                            if (!File.Exists(newFilePath))
                            {
                                SetStatus("A file with this name already exists.");
                            }
                            else
                            {
                                SetStatus($"Renaming file local to: {newFileName}");
                                FileSystem.RenameFile(oldFilePath, newFileName);
                                SetStatus($"Successfully renamed local file to: {newFileName}");
                                LoadLocalDirectory(DirectoryPathLocal);
                            }
                        }

                        break;
                    }
            }
        }

        private void RenameLocalFolder()
        {
            switch (GridViewLocalFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string oldFolderName = GridViewLocalFiles.GetFocusedRowCellDisplayText("Name");
                        string oldFolderPath = TextBoxLocalPath.Text + @"\" + oldFolderName;

                        string newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName).RemoveInvalidChars();

                        string newFolderPath = TextBoxLocalPath.Text + @"\" + newFolderName;

                        if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                        {
                            if (!Directory.Exists(newFolderPath))
                            {
                                SetStatus("A folder with this name already exists.");
                            }
                            else
                            {
                                SetStatus($"Renaming local folder to: {newFolderName}");
                                FileSystem.RenameDirectory(oldFolderPath, newFolderName);
                                SetStatus($"Successfully renamed local folder to: {newFolderName}");
                                LoadLocalDirectory(DirectoryPathLocal);
                            }
                        }

                        break;
                    }
            }
        }

        #endregion

        #region Console File Explorer

        private void ComboBoxConsoleDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsoleType == PlatformPrefix.PS3)
            {
                LoadConsoleDirectory("/" + ComboBoxConsoleDrives.SelectedItem + "/");
            }
            else
            {
                LoadConsoleDirectory(ComboBoxConsoleDrives.SelectedItem + @":\");
            }
        }

        private void ButtonConsoleNavigate_Click(object sender, EventArgs e)
        {
            LoadConsoleDirectory(TextBoxConsolePath.Text);
        }

        private DataTable DataTableConsoleFiles { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>
            {
                new() { Caption = "Type", ColumnName = "Type", DataType = typeof(string) },
                new() { Caption = "Image", ColumnName = "Image", DataType = typeof(Image) },
                new() { Caption = "Name", ColumnName = "Name", DataType = typeof(string) },
                new() { Caption = "Size", ColumnName = "Size", DataType = typeof(string) },
                new() { Caption = "Last Modified", ColumnName = "Last Modified", DataType = typeof(string) }
            });

        /// <summary>
        /// Loads files and folders into the console datagridview
        /// </summary>
        /// <param name="directoryPath"> Console path to retrieve </param>
        public void LoadConsoleDirectory(string directoryPath)
        {
            try
            {
                SetConsoleStatus($"Fetching directory listing of '{directoryPath}'...");

                DataTableConsoleFiles.Rows.Clear();

                DirectoryPathConsole = ConsoleType == PlatformPrefix.PS3 ? directoryPath.Replace("//", "/") : directoryPath.Replace(@"\\", @"\");
                TextBoxConsolePath.Text = DirectoryPathConsole;

                int secondIndexOfSlash = DirectoryPathConsole.TrimStart('/').IndexOfNth("/");
                int indexOfFirstColon = DirectoryPathConsole.IndexOfNth(":");
                string rootPath = ConsoleType == PlatformPrefix.PS3 ? DirectoryPathConsole.Substring(1, secondIndexOfSlash) : DirectoryPathConsole.Substring(0, indexOfFirstColon);

                ComboBoxConsoleDrives.SelectedIndexChanged -= ComboBoxConsoleDrives_SelectedIndexChanged;
                ComboBoxConsoleDrives.SelectedItem = ConsoleType == PlatformPrefix.PS3 ? rootPath.Replace("/", string.Empty) : rootPath.ToUpper().Replace(@"\", string.Empty);
                ComboBoxConsoleDrives.SelectedIndexChanged += ComboBoxConsoleDrives_SelectedIndexChanged;

                bool isRoot = ConsoleType == PlatformPrefix.PS3 ? ComboBoxConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace("/", "")) : ComboBoxConsoleDrives.Properties.Items.Contains(DirectoryPathConsole.Replace(":", "").Replace(@"\", "").ToUpper());

                if (!isRoot)
                {
                    DataTableConsoleFiles.Rows.Add("folder",
                                                   ImageFolderUp,
                                                   "..",
                                                   "",
                                                   "");
                }

                if (ConsoleType == PlatformPrefix.PS3)
                {
                    FtpClient.SetWorkingDirectory(DirectoryPathConsole);

                    List<FtpListItem> folders = new();
                    List<FtpListItem> files = new();

                    int totalBytes = 0;

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
                        switch (DirectoryPathConsole)
                        {
                            case "/dev_hdd0/home/":
                                {
                                    string profileName = FtpExtensions.GetUserNameFromUserId(listItem.Name);
                                    DataTableConsoleFiles.Rows.Add("folder",
                                                                   ImageFolder,
                                                                   $"{listItem.Name} ({profileName})",
                                                                   "<PROFILE>",
                                                                   listItem.Modified);
                                    break;
                                }
                            case "/dev_hdd0/game/":
                                {
                                    string gameTitle = Settings.AutoDetectGameTitles
                                        ? $" ({FtpExtensions.GetParamTitle($"/dev_hdd0/game/{listItem.Name}/PARAM.SFO")})"
                                        : "";
                                    DataTableConsoleFiles.Rows.Add("folder",
                                                                   ImageFolder,
                                                                   $"{listItem.Name}{gameTitle}",
                                                                   "<UPDATE>",
                                                                   listItem.Modified);
                                    break;
                                }
                            default:
                                DataTableConsoleFiles.Rows.Add("folder",
                                                               ImageFolder,
                                                               listItem.Name,
                                                               "<DIRECTORY>",
                                                               listItem.Modified);
                                break;
                        }
                    }

                    foreach (FtpListItem listItem in files.OrderBy(x => x.Name))
                    {
                        DataTableConsoleFiles.Rows.Add("file",
                                                       ImageFile,
                                                       listItem.Name,
                                                       Settings.UseFormattedFileSizes ? listItem.Size.Bytes().Humanize("#.##") : listItem.Size + " Bytes",
                                                       Settings.UseRelativeTimes ? listItem.Modified.Humanize() : listItem.Modified);

                        totalBytes += Convert.ToInt32(listItem.Size);
                    }

                    string statusFiles = files.Count > 0
                        ? $"{files.Count} {(files.Count == 1 ? "file" : "files")} {(files.Count > 0 && folders.Count > 0 ? "and" : "")} "
                        : $"{$"{(folders.Count == 0 ? "." : "")}"}";
                    string statusFolders = folders.Count > 0
                        ? $" {folders.Count} {(folders.Count == 1 ? "directory" : "directories")}."
                        : "";
                    string statusTotalBytes = totalBytes > 0
                        ? $" Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " bytes")}"
                        : "";

                    switch (files.Count)
                    {
                        case < 1 when folders.Count < 1:
                            SetConsoleStatus("Empty directory.");
                            break;
                        default:
                            SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                            break;
                    }
                }
                else if (ConsoleType == PlatformPrefix.XBOX)
                {
                    List<IXboxFile> files = new();
                    List<IXboxFile> folders = new();

                    long totalBytes = 0;

                    IXboxFiles xboxDirectories = XboxConsole.DirectoryFiles(DirectoryPathConsole);

                    foreach (IXboxFile directory in xboxDirectories)
                    {
                        if (directory.IsDirectory)
                        {
                            folders.Add(directory);
                        }
                    }

                    IXboxFiles xboxFiles = XboxConsole.DirectoryFiles(DirectoryPathConsole);

                    foreach (IXboxFile file in xboxFiles)
                    {
                        //If the file is not a directory
                        if (!file.IsDirectory)
                        {
                            //Add it to the list
                            files.Add(file);
                        }
                    }

                    foreach (IXboxFile folder in folders)
                    {
                        if (DirectoryPathConsole.ToLower().StartsWith(@"hdd:\content\"))
                        {
                            //int profileIndex = DirectoryPathConsole.Length - DirectoryPathConsole.TrimEnd('\\').IndexOf(@"\", 13) - 1;
                            //string profileName = DirectoryPathConsole.Substring(profileIndex, 16);
                            //bool isProfilePath = false;

                            //if (profileIndex == 16 && profileName != null)
                            //{
                            //    isProfilePath = true;
                            //}

                            //string gameTitle = isProfilePath && Settings.AutoDetectGameTitles
                            //           ? $" ({MainWindow.Database.GamesXBOXTitleIds.GetTitleFromTitleId(folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""))})"
                            //           : "";
                            string gameTitle = Settings.AutoDetectGameTitles
                                       ? $" ({MainWindow.Database.GamesXBOXTitleIds.GetTitleFromTitleId(folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""))})"
                                       : "";
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageFolder,
                                                           $"{folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", "")}{gameTitle}",
                                                           "<GAME>",
                                                           folder.ChangeTime);
                        }
                        else
                        {
                            DataTableConsoleFiles.Rows.Add("folder",
                                                           ImageFolder,
                                                           folder.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""),
                                                           "<DIRECTORY>",
                                                           folder.ChangeTime);
                        }
                    }

                    foreach (IXboxFile file in files)
                    {
                        DataTableConsoleFiles.Rows.Add("file",
                                                       ImageFile,
                                                       file.Name.Replace(DirectoryPathConsole, "").Replace(@"\", ""),
                                                       Settings.UseFormattedFileSizes ? Convert.ToInt64(file.Size).Bytes().Humanize("#.##") : file.Size + " Bytes",
                                                       file.ChangeTime);

                        totalBytes += Convert.ToInt64(file.Size);
                    }

                    SetConsoleStatus("Successfully fetched directory listing.");

                    string statusFiles = files.Count > 0
                        ? $"{files.Count} {(files.Count == 1 ? "file" : "files")}{(files.Count > 0 && folders.Count > 0 ? " and " : "")}"
                        : $"{$"{(folders.Count == 0 ? "." : "")}"}";
                    string statusFolders = folders.Count > 0
                        ? $"{folders.Count} {(folders.Count == 1 ? "directory" : "directories")}. "
                        : "";
                    string statusTotalBytes = totalBytes > 0
                        ? $"Total size: {(Settings.UseFormattedFileSizes ? totalBytes.Bytes().Humanize("#.##") : totalBytes + " bytes")}"
                        : "";

                    switch (files.Count)
                    {
                        case < 1 when folders.Count < 1:
                            SetConsoleStatus("Empty directory.");
                            break;
                        default:
                            SetConsoleStatus($"{statusFiles}{statusFolders}{statusTotalBytes}");
                            break;
                    }
                }

                GridConsoleFiles.DataSource = DataTableConsoleFiles;

                GridViewConsoleFiles.FocusedRowHandle = -1;

                GridViewConsoleFiles.Columns[0].Visible = false;

                GridViewConsoleFiles.Columns[1].Caption = " ";
                GridViewConsoleFiles.Columns[1].MinWidth = 22;
                GridViewConsoleFiles.Columns[1].MaxWidth = 22;
                GridViewConsoleFiles.Columns[1].ImageOptions.Alignment = StringAlignment.Center;

                //GridViewConsoleFiles.Columns[2].Width = 300;

                GridViewConsoleFiles.Columns[3].MinWidth = 150;
                GridViewConsoleFiles.Columns[3].MaxWidth = 150;

                GridViewConsoleFiles.Columns[4].MinWidth = 125;
                GridViewConsoleFiles.Columns[4].MaxWidth = 125;
            }
            catch (FtpException ex)
            {
                SetConsoleStatus($"Error fetching directory listing for path: {DirectoryPathConsole}", ex);
            }
            catch (Exception ex)
            {
                SetConsoleStatus($"Error fetching directory listing for path: {DirectoryPathConsole}", ex);
            }
        }

        private void GridViewConsoleFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Name");

                        ButtonConsoleDownload.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonConsoleRename.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonConsoleAddToGames.Enabled = type == "file" && name.EndsWith(".xex");

                        break;
                    }

                default:
                    ButtonConsoleDownload.Enabled = false;
                    ButtonConsoleDelete.Enabled = false;
                    ButtonConsoleRename.Enabled = false;
                    ButtonConsoleAddToGames.Enabled = false;
                    break;
            }
        }

        private void GridConsoleFiles_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            //switch (GridViewConsoleFiles.SelectedRowsCount)
            //{
            //    case > 0:
            //        {
            //            string type = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Type");
            //            string name = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Name");

            //            ButtonConsoleDownload.Enabled = type == "file" && name != "..";
            //            ButtonConsoleDelete.Enabled = type == "file" /*  | type == "folder"   */  && name != "..";
            //            ButtonConsoleRename.Enabled = type == "file" && name != "..";

            //            break;
            //        }
            //}
        }

        private void GridViewConsoleFiles_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Name");

                        ButtonConsoleDownload.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonConsoleDelete.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonConsoleRename.Enabled = type == "file" | type == "folder" && name != "..";
                        ButtonConsoleAddToGames.Enabled = type == "file" && name.EndsWith(".xex");

                        break;
                    }

                default:
                    ButtonConsoleDownload.Enabled = false;
                    ButtonConsoleDelete.Enabled = false;
                    ButtonConsoleRename.Enabled = false;
                    ButtonConsoleAddToGames.Enabled = false;
                    break;
            }
        }

        private void GridConsoleFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (GridViewConsoleFiles.SelectedRowsCount)
            {
                case > 0:
                    {
                        string type = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Type");
                        string name = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Name");

                        switch (name)
                        {
                            // Go to parent directory
                            case "..":
                                {

                                    string trimLastIndex;
                                    string parentDirectory;

                                    if (ConsoleType == PlatformPrefix.PS3)
                                    {
                                        trimLastIndex = Path.GetDirectoryName(DirectoryPathConsole).Replace(@"\", "/").TrimEnd('/');
                                        parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf("/")) + "/";
                                    }
                                    else
                                    {
                                        trimLastIndex = Path.GetDirectoryName(DirectoryPathConsole).Replace("/", @"\").TrimEnd('\\');
                                        parentDirectory = trimLastIndex.Substring(0, trimLastIndex.LastIndexOf(@"\")) + @"\";
                                    }

                                    LoadConsoleDirectory(parentDirectory);

                                    break;
                                }
                            // Go to selected directory
                            default:
                                {
                                    if (ConsoleType == PlatformPrefix.PS3)
                                    {
                                        switch (type)
                                        {
                                            // Go to selected folder directory
                                            case "folder" when DirectoryPathConsole == "/dev_hdd0/home/":
                                            case "folder" when DirectoryPathConsole == "/dev_hdd0/game/":
                                                LoadConsoleDirectory(DirectoryPathConsole + name.Split()[0] + "/");
                                                break;
                                            case "folder":
                                                LoadConsoleDirectory(DirectoryPathConsole + name + "/");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        switch (type)
                                        {
                                            // Go to selected folder directory
                                            //case "folder" when DirectoryPathConsole.ToLower().StartsWith(@"Hdd:\Content\".ToLower()):
                                            //    LoadConsoleDirectory(DirectoryPathConsole + name.Split()[0] + @"\");
                                            //    break;
                                            case "folder":
                                                LoadConsoleDirectory(DirectoryPathConsole + name + @"\");
                                                break;
                                        }
                                    }

                                    break;
                                }
                        }

                        break;
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

        private void ButtonConsoleAddToGames_Click(object sender, EventArgs e)
        {
            string name = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Name");
            string fileName = name;

            if (XtraMessageBox.Show("Do you want to rename this file?\n\nNote: It will not affect being able to load the game.", "Rename File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", name);

                if (fileName.IsNullOrEmpty() | fileName.IsNullOrWhiteSpace())
                {
                    XtraMessageBox.Show("The file name can't be empty.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (Settings.GameFilesXBOX.Any(x => x.Name.EqualsIgnoreCase(fileName)))
            {
                XtraMessageBox.Show("You already have a file with this name in your games.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Settings.GameFilesXBOX.Add(new()
            {
                Name = fileName,
                Value = DirectoryPathConsole + name
            });
        }

        public void DownloadFromConsole()
        {
            try
            {
                string type = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Type");
                string name = GridViewConsoleFiles.GetFocusedRowCellDisplayText("Name");

                string consoleFile = DirectoryPathConsole + name;
                string localFile = DirectoryPathLocal + name;

                switch (type)
                {
                    case "file":
                        {
                            SetStatus($"Downloading console file: {Path.GetFileName(localFile)}");

                            if (ConsoleType == PlatformPrefix.PS3)
                            {
                                if (File.Exists(localFile))
                                {
                                    File.Delete(localFile);
                                }

                                FtpClient.DownloadFile(localFile, consoleFile);
                            }
                            else if (ConsoleType == PlatformPrefix.XBOX)
                            {
                                if (File.Exists(localFile))
                                {
                                    File.Delete(localFile);
                                }

                                XboxConsole.ReceiveFile(localFile, consoleFile);
                            }

                            SetStatus($"Successfully downloaded console file: {Path.GetFileName(localFile)}");

                            break;
                        }
                    case "folder":
                        {
                            if (ConsoleType == PlatformPrefix.PS3)
                            {
                                string consolePath = DirectoryPathConsole + name + "/";
                                string localPath = DirectoryPathLocal + name;

                                if (Directory.Exists(localPath))
                                {
                                    UserFolders.DeleteDirectory(localPath);
                                }

                                SetStatus($"Downloading console folder: {consolePath}");
                                FtpExtensions.DownloadDirectory(consolePath, localPath);
                                SetStatus($"Successfully downloaded console folder to: {localPath}");
                            }
                            else if (ConsoleType == PlatformPrefix.XBOX)
                            {
                                
                            }

                            break;
                        }
                }

                LoadConsoleDirectory(DirectoryPathConsole);
            }
            catch (Exception ex)
            {
                SetStatus($"Error downloading console file. {ex.Message}", ex);
            }
        }

        public void DeleteConsoleItem()
        {
            try
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string type = GridViewConsoleFiles.GetRowCellDisplayText(GridViewConsoleFiles.FocusedRowHandle, "Type");
                    string name = GridViewConsoleFiles.GetRowCellDisplayText(GridViewConsoleFiles.FocusedRowHandle, "Name");

                    string itemPath = DirectoryPathConsole + name;

                    switch (type)
                    {
                        case "folder":
                            {
                                itemPath = DirectoryPathConsole switch
                                {
                                    "/dev_hdd0/home/" => DirectoryPathConsole + name.Split()[0],
                                    _ => itemPath
                                };

                                SetStatus($"Deleting console folder: {itemPath}");

                                switch (ConsoleType)
                                {
                                    case PlatformPrefix.PS3:
                                        FtpExtensions.DeleteDirectory(itemPath);
                                        break;
                                    case PlatformPrefix.XBOX:
                                        XboxConsole.RemoveDirectory(itemPath);
                                        break;
                                }

                                SetStatus("Successfully deleted folder.");
                                break;
                            }
                        case "file":
                            SetStatus($"Deleting console file: {itemPath}");
                            FtpExtensions.DeleteFile(itemPath);
                            SetStatus("Successfully deleted console file.");
                            break;
                    }

                    GridViewConsoleFiles.DeleteRow(GridViewConsoleFiles.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to delete console item. Error: {ex.Message}", ex);
            }
        }

        private void RenameConsoleFile()
        {
            try
            {
                string oldFileName = GridViewConsoleFiles.GetRowCellDisplayText(GridViewConsoleFiles.FocusedRowHandle, "Name");
                string oldFilePath = TextBoxConsolePath.Text + oldFileName;

                string newFileName = DialogExtensions.ShowTextInputDialog(this, "Rename File", "File Name:", oldFileName).RemoveInvalidChars();

                string newConsoleFilePath = TextBoxConsolePath.Text + newFileName;

                if (newFileName != null && !newFileName.Equals(oldFileName))
                {
                    if (FtpExtensions.FileExists(newConsoleFilePath))
                    {
                        SetStatus("A file with this name already exists.");
                    }
                    else
                    {
                        SetStatus($"Renaming console file to: {newFileName}");

                        switch (ConsoleType)
                        {
                            case PlatformPrefix.PS3:
                                FtpExtensions.RenameFileOrFolder(oldFilePath, newConsoleFilePath);
                                break;
                            case PlatformPrefix.XBOX:
                                XboxConsole.RenameFile(oldFilePath, newConsoleFilePath);
                                break;
                        }

                        SetStatus($"Successfully renamed console  file to: {newFileName}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to rename console file. Error: {ex.Message}", ex);
            }
        }

        private void RenameConsoleFolder()
        {
            try
            {
                string oldFolderName = GridViewConsoleFiles.GetRowCellDisplayText(GridViewConsoleFiles.FocusedRowHandle, "Name");
                string oldFileName = TextBoxConsolePath.Text + oldFolderName;

                string newFolderName = DialogExtensions.ShowTextInputDialog(this, "Rename Folder", "Folder Name:", oldFolderName).RemoveInvalidChars();

                string newFolderPath = TextBoxConsolePath.Text + newFolderName;

                if (newFolderName != null && !newFolderName.Equals(oldFolderName))
                {
                    if (FtpExtensions.DirectoryExists(newFolderPath))
                    {
                        SetStatus("A folder with this name already exists.");
                    }
                    else
                    {
                        SetStatus($"Renaming console folder: {oldFileName} to: {newFolderName}");

                        switch (ConsoleType)
                        {
                            case PlatformPrefix.PS3:
                                FtpExtensions.RenameFileOrFolder(oldFileName, newFolderPath);
                                break;
                            case PlatformPrefix.XBOX:
                                XboxConsole.RenameFile(oldFileName, newFolderName);
                                break;
                        }

                        SetStatus($"Successfully renamed console folder to: {newFolderName}");
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
                string folderName = DialogExtensions.ShowTextInputDialog(this, "Add New Folder", "Folder Name: ");

                if (folderName != null)
                {
                    string folderPath = DirectoryPathConsole + "/" + folderName;

                    if (FtpClient.DirectoryExists(folderPath))
                    {
                        XtraMessageBox.Show("A folder with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetStatus($"Creating console folder: {folderName}");

                        switch (ConsoleType)
                        {
                            case PlatformPrefix.PS3:
                                FtpExtensions.CreateDirectory(folderPath);
                                break;
                            case PlatformPrefix.XBOX:
                                XboxConsole.MakeDirectory(folderPath.TrimStart('/').Replace("/", @"\"));
                                break;
                        }

                        SetStatus($"Successfully created console folder: {folderName}");
                        LoadConsoleDirectory(DirectoryPathConsole);
                    }
                }
            }
            catch (FtpException ex)
            {
                SetStatus($"Unable to create a new folder on your console. Error: {ex.Message}", ex);
                XtraMessageBox.Show($"Unable to create a new folder on your console. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to create a new folder on your console. Error: {ex.Message}", ex);
                XtraMessageBox.Show($"Unable to create a new folder on your console. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        /// <summary>
        /// Set the current status in the local panel.
        /// </summary>
        /// <param name="status"> </param>
        /// <param name="ex"> </param>
        public void SetLocalStatus(string status, Exception ex = null)
        {
            LabelLocalStatus.Text = status;

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

        /// <summary>
        /// Set the current status in the console panel.
        /// </summary>
        /// <param name="status"> </param>
        public void SetConsoleStatus(string status, Exception ex = null)
        {
            LabelConsoleStatus.Text = status;

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
    }
}