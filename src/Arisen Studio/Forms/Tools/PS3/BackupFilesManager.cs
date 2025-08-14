using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Humanizer;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Data;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using ArisenStudio.Models.Database;

namespace ArisenStudio.Forms.Tools.PS3
{
    public partial class BackupFilesManager : XtraForm
    {
        public BackupFilesManager()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        private void BackupFilesManager_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("BACKUP_FILES_MANAGER");

            ButtonEdit.Text = Language.GetString("LABEL_EDIT");
            ButtonDelete.Text = Language.GetString("LABEL_DELETE");
            ButtonDeleteAll.Text = Language.GetString("LABEL_DELETE_ALL");
            ButtonBackupFile.Text = Language.GetString("LABEL_BACKUP_FILE");
            ButtonRestoreFile.Text = Language.GetString("LABEL_RESTORE_FILE");

            LoadBackupFiles();
        }

        private void LoadBackupFiles()
        {
            GridBackupFiles.DataSource = null;

            DataTable dt = new();
            _ = dt.Columns.Add(Language.GetString("LABEL_GAME_TITLE"), typeof(string));
            _ = dt.Columns.Add(Language.GetString("LABEL_FILE_NAME"), typeof(string));
            _ = dt.Columns.Add(Language.GetString("LABEL_FILE_SIZE"), typeof(string));
            _ = dt.Columns.Add(Language.GetString("LABEL_CREATED_ON"), typeof(string));

            foreach (BackupFile backupFile in MainWindow.BackupFiles.BackupFiles)
            {
                long fileBytes = File.Exists(backupFile.LocalPath) ? new FileInfo(backupFile.LocalPath).Length : 0;

                _ = dt.Rows.Add(MainWindow.Database.CategoriesData.GetCategoryById(backupFile.CategoryId).Title,
                    backupFile.FileName,
                    File.Exists(backupFile.LocalPath)
                        ? MainWindow.Settings.UseFormattedFileSizes ? fileBytes.Bytes().Humanize() : fileBytes + " " + Language.GetString("LABEL_BYTES")
                        : "No File Exists",
                    backupFile.CreatedDate.ToLocalTime());
            }

            GridBackupFiles.DataSource = dt;

            GridViewBackupFiles.Columns[0].Width = 200;
            GridViewBackupFiles.Columns[1].Width = 200;
            GridViewBackupFiles.Columns[2].Width = 125;
            GridViewBackupFiles.Columns[3].Width = 125;
        }

        private void GridViewBackupFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewBackupFiles.SelectedRowsCount)
            {
                case > 0:
                    try
                    {
                        BackupFile backupFile = MainWindow.BackupFiles.BackupFiles[GridViewBackupFiles.FocusedRowHandle];
                        CategoryItem category = MainWindow.Database.CategoriesData.GetCategoryById(backupFile.CategoryId);

                        long fileSize = File.Exists(backupFile.LocalPath) ? new FileInfo(backupFile.LocalPath).Length : 0;

                        LabelGameTitle.Text = category.Title;
                        LabelFileName.Text = backupFile.FileName;
                        LabelFileSize.Text = File.Exists(backupFile.LocalPath)
                            ? MainWindow.Settings.UseFormattedFileSizes ? fileSize.Bytes().Humanize()
                            : fileSize.ToString("{0:n}") + " " + Language.GetString("LABEL_BYTES")
                            : "No File Exists";
                        LabelCreatedOn.Text = backupFile.CreatedDate.ToLocalTime().ToString();
                        LabelLocalPath.Text = backupFile.LocalPath;
                        LabelInstallPath.Text = backupFile.InstallPath;


                        if (!File.Exists(backupFile.LocalPath))
                        {
                            _ = XtraMessageBox.Show($"Local file: {backupFile.FileName} for game: {category.Title} can't be found at path: {backupFile.LocalPath}.\n\nIf you have moved this file then edit the backup and choose the locate the file, otherwise re-install your game update and backup the orginal game file again.", "No Local File");
                        }
                    }
                    catch
                    {
                        // Will throw index out of range if deleting the last item
                    }

                    break;
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

            BackupFile backupFile = MainWindow.BackupFiles.BackupFiles[backupFileIndex];

            BackupFile newBackupFile = DialogExtensions.ShowBackupFileDetails(this, backupFile);

            if (newBackupFile != null)
            {
                MainWindow.BackupFiles.UpdateBackupFile(backupFileIndex, newBackupFile);
            }

            LoadBackupFiles();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, Language.GetString("CONFIRM_DELETE_ITEM"), Language.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.BackupFiles.BackupFiles.RemoveAt(GridViewBackupFiles.FocusedRowHandle);
                LoadBackupFiles();
            }
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, Language.GetString("CONFIRM_DELETE_ALL_ITEMS"), Language.GetString("CONFIRM_DELETE_ALL"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.BackupFiles.BackupFiles.Clear();
                LoadBackupFiles();
            }
        }

        private void ButtonBackupFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainWindow.BackupFiles.BackupFiles[GridViewBackupFiles.FocusedRowHandle];
            BackupGameFile(backupFile);
        }

        private void ButtonRestoreFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainWindow.BackupFiles.BackupFiles[GridViewBackupFiles.FocusedRowHandle];
            RestoreGameFile(backupFile);
        }

        /// <summary>
        /// </summary>
        /// <param name="backupFile"> </param>
        public void BackupGameFile(BackupFile backupFile)
        {
            try
            {
                _ = MainWindow.FtpClient.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
                _ = XtraMessageBox.Show(this, $"Successfully backed up file {backupFile.FileName} from {backupFile.InstallPath}.", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to backup game file. Error: {ex.Message}");
                _ = XtraMessageBox.Show(this, "There was a problem downloading the file. Make sure the file exists on your console.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    _ = XtraMessageBox.Show(this, "This file backup doesn't exist on your computer. If your game doesn't have mods installed, then I would suggest you backup the original files.", "No File Found");
                    return;
                }

                _ = FtpExtensions.UploadFileAsync(backupFile.LocalPath, backupFile.InstallPath);
                _ = XtraMessageBox.Show($"Successfully restored file: {backupFile.FileName} to path: {backupFile.InstallPath}", Language.GetString("SUCCESS"));
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "There was an issue attempting to restore file.");
                _ = XtraMessageBox.Show(this, "There was an issue restoring this file. Make sure the file exists on your computer and try again.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}