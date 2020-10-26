using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Resources;

namespace ModioX.Forms.Windows
{
    public partial class GameBackupFilesWindow : DarkForm
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
            DgvBackups.Rows.Clear();

            foreach (var backupFile in MainWindow.Settings.BackupFiles)
            {
                _ = DgvBackups.Rows.Add(MainWindow.Database.Categories.GetCategoryById(backupFile.CategoryId).Title,
                    backupFile.FileName,
                    File.Exists(backupFile.LocalPath) 
                        ? new FileInfo(backupFile.LocalPath).Length.ToString("n0") + " bytes"
                        : "File Doesn't Exist", backupFile.CreatedDate.ToLocalTime().ToString(CultureInfo.CurrentCulture));
            }
        }

        private void DgvBackupFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBackups.CurrentRow != null)
            {
                try
                {
                    var backupFile = MainWindow.Settings.BackupFiles[DgvBackups.CurrentRow.Index];
                    var category = MainWindow.Database.Categories.GetCategoryById(backupFile.CategoryId);

                    LabelGameTitle.Text = category.Title;
                    LabelCreatedDate.Text = backupFile.CreatedDate.ToLocalTime().ToString(CultureInfo.CurrentCulture);
                    LabelFileName.Text = backupFile.FileName;
                    LabelFileSize.Text = File.Exists(backupFile.LocalPath)
                        ? new FileInfo(backupFile.LocalPath).Length.ToString("n0") + " bytes"
                        : "File Doesn't Exist";
                    LabelLocalPath.Text = backupFile.LocalPath;
                    LabelConsolePath.Text = backupFile.InstallPath;

                    if (!File.Exists(backupFile.LocalPath))
                    {
                        _ = DarkMessageBox.Show(this,
                            $"Local file: {backupFile.FileName} for game: {category.Title} can't be found at path: {backupFile.LocalPath}.\n\nIf you have moved this file then edit the backup and choose the locate the file, otherwise re-install your game update and backup the orginal game file again.",
                            "No Local File", MessageBoxIcon.Warning);
                    }
                }
                catch 
                {
                    // Will throw index out of range if deleting the last item 
                }
            }

            ToolItemEditBackup.Enabled = DgvBackups.CurrentRow != null;
            ToolItemDeleteBackup.Enabled = DgvBackups.CurrentRow != null;
            ToolItemBackupFile.Enabled = DgvBackups.CurrentRow != null && MainWindow.IsConsoleConnected;
            ToolItemRestoreFile.Enabled = DgvBackups.CurrentRow != null && MainWindow.IsConsoleConnected;
        }

        private void ToolItemEditBackup_Click(object sender, EventArgs e)
        {
            var backupFileIndex = DgvBackups.CurrentRow.Index;

            var backupFile = MainWindow.Settings.BackupFiles[backupFileIndex];

            var newBackupFile = DialogExtensions.ShowBackupFileDetails(this, backupFile);

            if (newBackupFile != null)
            {
                MainWindow.Settings.UpdateBackupFile(backupFileIndex, newBackupFile);
            }

            LoadBackupFiles();
        }

        private void ToolItemDeleteBackup_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.Settings.BackupFiles.RemoveAt(DgvBackups.CurrentRow.Index);
                LoadBackupFiles();
            }
        }

        private void ToolItemBackupFile_Click(object sender, EventArgs e)
        {
            var backupFile = MainWindow.Settings.BackupFiles[DgvBackups.CurrentRow.Index];
            BackupGameFile(backupFile);
        }

        private void ToolItemRestoreFile_Click(object sender, EventArgs e)
        {
            var backupFile = MainWindow.Settings.BackupFiles[DgvBackups.CurrentRow.Index];
            RestoreGameFile(backupFile);
        }

        /// <summary>
        /// </summary>
        /// <param name="backupFile"></param>
        public void BackupGameFile(BackupFile backupFile)
        {
            try
            {
                FtpExtensions.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
                _ = DarkMessageBox.Show(this,
                    $"Successfully backed up file {backupFile.FileName} from {backupFile.InstallPath}.",
                    "Success", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error($"Unable to backup game file. Error: {ex.Message}", ex);
                _ = DarkMessageBox.Show(this,
                    "There was a problem downloading the file. Make sure the file exists on your console.",
                    "Error", MessageBoxIcon.Error);
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
                    _ = DarkMessageBox.Show(this,
                        "This file backup doesn't exist on your computer. If your game doesn't have mods installed, then I would suggest you backup the original files.",
                        "No File Found", MessageBoxIcon.Information);
                    return;
                }

                FtpExtensions.UploadFile(MainWindow.FtpConnection, backupFile.LocalPath, backupFile.InstallPath);
                _ = DarkMessageBox.Show(this,
                    $"Successfully restored file: {backupFile.FileName} to path: {backupFile.InstallPath}",
                    "Success", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was an issue attempting to restore file.", ex);
                _ = DarkMessageBox.Show(this,
                    "There was an issue restoring file. Make sure the local file exists on your computer.",
                    "Error", MessageBoxIcon.Error);
            }
        }
    }
}