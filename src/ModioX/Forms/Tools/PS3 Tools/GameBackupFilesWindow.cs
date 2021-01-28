using DarkUI.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms.Tools.PS3_Tools
{
    public partial class GameBackupFilesWindow : XtraForm
    {
        public GameBackupFilesWindow()
        {
            InitializeComponent();
        }

        private void GameBackupFilesWindow_Load(object sender, EventArgs e)
        {
            LoadBackupFiles();
        }

        private void LoadBackupFiles()
        {
            GridBackupFiles.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Game Title", typeof(string));
            dt.Columns.Add("File Name", typeof(string));
            dt.Columns.Add("File Size", typeof(string));
            dt.Columns.Add("Created On", typeof(string));

            foreach (BackupFile backupFile in MainWindow.Settings.BackupFiles)
            {
                long fileSize = new FileInfo(backupFile.LocalPath).Length;

                dt.Rows.Add(MainWindow.Database.CategoriesData.GetCategoryById(backupFile.CategoryId).Title,
                    backupFile.FileName,
                    File.Exists(backupFile.LocalPath)
                    ? (MainWindow.Settings.ShowFileSizeInBytes ? fileSize.ToString("#,0") + " bytes" : StringExtensions.FormatSize(fileSize.ToString()))
                    : "No File Exists", 
                    backupFile.CreatedDate.ToLocalTime());
            }

            GridBackupFiles.DataSource = dt;

            GridViewBackupFiles.Columns[0].Width = 200;
            GridViewBackupFiles.Columns[1].Width = 200;
            GridViewBackupFiles.Columns[2].Width = 110;
            GridViewBackupFiles.Columns[3].Width = 80;

            ProgressBackupFiles.Visible = dt.Rows.Count < 1;
        }

        private void DgvBackupFiles_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (DgvBackupFiles.CurrentRow != null)
            {
                try
                {
                    var backupFile = MainWindow.Settings.BackupFiles[DgvBackupFiles.CurrentRow.Index];
                    var category = MainWindow.Database.CategoriesData.GetCategoryById(backupFile.CategoryId);

                    var fileSize = new FileInfo(backupFile.LocalPath).Length;

                    LabelGameTitle.Text = category.Title;
                    LabelCreatedDate.Text = backupFile.CreatedDate.ToLocalTime().ToString(CultureInfo.CurrentCulture);
                    LabelFileName.Text = backupFile.FileName;
                    LabelFileSize.Text = File.Exists(backupFile.LocalPath)
                    ? (MainWindow.Settings.ShowFileSizeInBytes ? fileSize.ToString("{0:n}") + " bytes" : StringExtensions.FormatSize(fileSize.ToString()))
                        : "No File Exists";
                    LabelLocalPath.Text = backupFile.LocalPath;
                    LabelConsolePath.Text = backupFile.InstallPath;

                    if (!File.Exists(backupFile.LocalPath))
                    {
                        XtraMessageBox.Show(
                            $"Local file: {backupFile.FileName} for game: {category.Title} can't be found at path: {backupFile.LocalPath}.\n\nIf you have moved this file then edit the backup and choose the locate the file, otherwise re-install your game update and backup the orginal game file again.",
                            "No Local File");
                    }
                }
                catch
                {
                    // Will throw index out of range if deleting the last item 
                }
            }

            ToolItemEditBackup.Enabled = DgvBackupFiles.CurrentRow != null;
            ToolItemDeleteBackup.Enabled = DgvBackupFiles.CurrentRow != null;
            ToolItemBackupFile.Enabled = DgvBackupFiles.CurrentRow != null && MainWindow.IsConsoleConnected;
            ToolItemRestoreFile.Enabled = DgvBackupFiles.CurrentRow != null && MainWindow.IsConsoleConnected;

            */
        }

        private void ToolItemEditBackup_Click(object sender, EventArgs e)
        {
            /*
            var backupFileIndex = DgvBackupFiles.CurrentRow.Index;

            var backupFile = MainWindow.Settings.BackupFiles[backupFileIndex];

            var newBackupFile = DialogExtensions.ShowBackupFileDetails(this, backupFile);

            if (newBackupFile != null)
            {
                MainWindow.Settings.UpdateBackupFile(backupFileIndex, newBackupFile);
            }

            */

            LoadBackupFiles();
        }

        private void ToolItemDeleteBackup_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MainWindow.Settings.BackupFiles.RemoveAt(DgvBackupFiles.CurrentRow.Index);
                LoadBackupFiles();
            }
        }

        private void ToolItemBackupFile_Click(object sender, EventArgs e)
        {
            //var backupFile = MainWindow.Settings.BackupFiles[DgvBackupFiles.CurrentRow.Index];
            //BackupGameFile(backupFile);
        }

        private void ToolItemRestoreFile_Click(object sender, EventArgs e)
        {
            //var backupFile = MainWindow.Settings.BackupFiles[DgvBackupFiles.CurrentRow.Index];
            //RestoreGameFile(backupFile);
        }

        /// <summary>
        /// </summary>
        /// <param name="backupFile"></param>
        public void BackupGameFile(BackupFile backupFile)
        {
            try
            {
                FtpExtensions.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
                XtraMessageBox.Show($"Successfully backed up file {backupFile.FileName} from {backupFile.InstallPath}.", "Success");
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to backup game file. Error: {ex.Message}");
                DarkMessageBox.ShowError("There was a problem downloading the file. Make sure the file exists on your console.", "Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="backupFile"></param>
        public void RestoreGameFile(BackupFile backupFile)
        {
            try
            {
                if (!File.Exists(backupFile.LocalPath))
                {
                    XtraMessageBox.Show(
                        "This file backup doesn't exist on your computer. If your game doesn't have mods installed, then I would suggest you backup the original files.",
                        "No File Found");
                    return;
                }

                FtpExtensions.UploadFile(backupFile.LocalPath, backupFile.InstallPath);
                XtraMessageBox.Show(
                    $"Successfully restored file: {backupFile.FileName} to path: {backupFile.InstallPath}",
                    "Success");
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "There was an issue attempting to restore file.");
                DarkMessageBox.ShowError(
                    "There was an issue restoring file. Make sure the local file exists on your computer.",
                    "Error");
            }
        }
    }
}