using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;

namespace ModioX.Forms.Tools.PS3_Tools
{
    public partial class GameBackupFiles : XtraForm
    {
        public GameBackupFiles()
        {
            InitializeComponent();
        }

        private void GameBackupFiles_Load(object sender, EventArgs e)
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
                long fileBytes = File.Exists(backupFile.LocalPath) ? new FileInfo(backupFile.LocalPath).Length : 0;

                dt.Rows.Add(MainWindow.Database.CategoriesData.GetCategoryById(backupFile.CategoryId).Title,
                    backupFile.FileName,
                    File.Exists(backupFile.LocalPath)
                    ? MainWindow.Settings.ShowFileSizeInBytes ? fileBytes.ToString() + " bytes" : fileBytes.FormatBytes()
                    : "No File Exists",
                    backupFile.CreatedDate.ToLocalTime());
            }

            GridBackupFiles.DataSource = dt;

            GridViewBackupFiles.Columns[0].Width = 200;
            GridViewBackupFiles.Columns[1].Width = 200;
            GridViewBackupFiles.Columns[2].Width = 125;
            GridViewBackupFiles.Columns[3].Width = 125;

            ProgressBackupFiles.Visible = dt.Rows.Count < 1;
        }

        private void GridViewBackupFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewBackupFiles.SelectedRowsCount > 0)
            {
                try
                {
                    BackupFile backupFile = MainWindow.Settings.BackupFiles[GridViewBackupFiles.FocusedRowHandle];
                    Database.Category category = MainWindow.Database.CategoriesData.GetCategoryById(backupFile.CategoryId);

                    long fileSize = File.Exists(backupFile.LocalPath) ? new FileInfo(backupFile.LocalPath).Length : 0;

                    LabelGameTitle.Text = category.Title;
                    LabelFileName.Text = backupFile.FileName;
                    LabelFileSize.Text = File.Exists(backupFile.LocalPath)
                    ? (MainWindow.Settings.ShowFileSizeInBytes ? fileSize.ToString("{0:n}") + " bytes" : fileSize.FormatBytes())
                    : "No File Exists";
                    LabelCreatedOn.Text = backupFile.CreatedDate.ToLocalTime().ToString();
                    LabelLocalPath.Text = backupFile.LocalPath;
                    LabelInstallPath.Text = backupFile.InstallPath;


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

            ButtonEdit.Enabled = GridViewBackupFiles.SelectedRowsCount > 0;
            ButtonDelete.Enabled = GridViewBackupFiles.SelectedRowsCount > 0;
            ButtonDeleteAll.Enabled = GridViewBackupFiles.SelectedRowsCount > 0;
            ButtonBackupFile.Enabled = GridViewBackupFiles.SelectedRowsCount > 0 && MainWindow.IsConsoleConnected;
            ButtonRestoreFile.Enabled = GridViewBackupFiles.SelectedRowsCount > 0 && MainWindow.IsConsoleConnected;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int backupFileIndex = GridViewBackupFiles.FocusedRowHandle;

            BackupFile backupFile = MainWindow.Settings.BackupFiles[backupFileIndex];

            BackupFile newBackupFile = DialogExtensions.ShowBackupFileDetails(this, backupFile);

            if (newBackupFile != null)
            {
                MainWindow.Settings.UpdateBackupFile(backupFileIndex, newBackupFile);
            }

            LoadBackupFiles();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete the selected item? This cannot be undone.", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.Settings.BackupFiles.RemoveAt(GridViewBackupFiles.FocusedRowHandle);
                LoadBackupFiles();
            }
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete all of the backup files? This cannot be undone.", "Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.Settings.BackupFiles.Clear();
                LoadBackupFiles();
            }
        }

        private void ButtonBackupFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainWindow.Settings.BackupFiles[GridViewBackupFiles.FocusedRowHandle];
            BackupGameFile(backupFile);
        }

        private void ButtonRestoreFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainWindow.Settings.BackupFiles[GridViewBackupFiles.FocusedRowHandle];
            RestoreGameFile(backupFile);
        }

        /// <summary>
        /// </summary>
        /// <param name="backupFile"> </param>
        public void BackupGameFile(BackupFile backupFile)
        {
            try
            {
                FtpExtensions.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
                XtraMessageBox.Show(this, $"Successfully backed up file {backupFile.FileName} from {backupFile.InstallPath}.", "Success");
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to backup game file. Error: {ex.Message}");
                XtraMessageBox.Show(this, "There was a problem downloading the file. Make sure the file exists on your console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="backupFile"> </param>
        public void RestoreGameFile(BackupFile backupFile)
        {
            try
            {
                if (!File.Exists(backupFile.LocalPath))
                {
                    XtraMessageBox.Show(this,
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
                XtraMessageBox.Show(this, "There was an issue restoring file. Make sure the local file exists on your computer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}