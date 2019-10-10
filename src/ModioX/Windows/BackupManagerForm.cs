using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Database;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Windows
{
    public partial class BackupManagerForm : DarkForm
    {
        public BackupManagerForm()
        {
            InitializeComponent();
        }

        private void BackupManagerForm_Load(object sender, EventArgs e)
        {
            LoadBackups();
        }

        private void LoadBackups()
        {
            DgvBackups.Rows.Clear();

            foreach (BackupFile backupFile in MainForm.SettingsData.BackupFiles)
            {
                FileInfo fileInfo = new FileInfo(backupFile.LocalPath);
                string gameId = string.IsNullOrEmpty(backupFile.GameId) ? "n/a" : backupFile.GameId;
                DgvBackups.Rows.Add(backupFile.Name, backupFile.File, gameId.ToUpper(), fileInfo.Length.ToString("#,##0") + " bytes", fileInfo.LastWriteTime);
            }
        }

        private void DgvBackupFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBackups.SelectedRows.Count > 0)
            {
                BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];

                LabelName.Text = backupFile.Name;
                LabelFileName.Text = backupFile.File;
                LabelGame.Text = string.IsNullOrEmpty(backupFile.GameId) ? "n/a" : MainForm.Categories.GetCategoryById(backupFile.GameId).Title;
                LabelLocalPath.Text = backupFile.LocalPath;
                LabelConsolePath.Text = backupFile.InstallPath;
            }

            ToolItemEditBackup.Enabled = DgvBackups.SelectedRows.Count > 0;
            ToolItemDeleteBackup.Enabled = DgvBackups.SelectedRows.Count > 0;
            ToolItemRestoreFile.Enabled = DgvBackups.SelectedRows.Count > 0;
        }

        private void ToolItemEditBackup_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];

            using (EditBackupForm editBackupForm = new EditBackupForm()
            {
                BackupFile = backupFile
            })
            {
                editBackupForm.ShowDialog(this);
            }

            LoadBackups();
        }

        private void ToolItemDeleteBackup_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];

            if (File.Exists(backupFile.LocalPath))
            {
                File.Delete(backupFile.LocalPath);
            }

            MainForm.SettingsData.BackupFiles.RemoveAt(DgvBackups.CurrentRow.Index);
            LoadBackups();
        }

        private void ToolItemBackupFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];

            try
            {
                FtpExtensions.DownloadFile(MainForm.ProfileIP, backupFile.LocalPath, backupFile.InstallPath);
                DarkMessageBox.Show(this, string.Format("Successfully backed up game file {0} to local path : {1}", backupFile.File, backupFile.LocalPath), "Backup File Restored", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was an issue when attempting to backup game file from console.", ex);
                DarkMessageBox.Show(this, string.Format("There was an issue when attempting to backup game file from console. Make sure the game file exists.", Path.GetFileName(backupFile.LocalPath), backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Error);
            }
        }

        private void ToolItemRestoreFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];

            try
            {
                FtpExtensions.UploadFile(MainForm.ProfileIP, backupFile.LocalPath, backupFile.InstallPath);
                DarkMessageBox.Show(this, string.Format("Successfully restored local file {0} to console path : {1}", backupFile.File, backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was an issue when attempting to restore file to console.", ex);
                DarkMessageBox.Show(this, string.Format("There was an issue when attempting to restore file to console. Make sure the local file path exists on your computer and that there isn't a typos", Path.GetFileName(backupFile.LocalPath), backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Error);
            }
        }
    }
}