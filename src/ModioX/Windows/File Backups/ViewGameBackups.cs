using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Resources;
using ModioX.Models.Database;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Windows
{
    public partial class ViewGameBackups : DarkForm
    {
        public ViewGameBackups()
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
                string gameId = string.IsNullOrEmpty(backupFile.CategoryId) ? "n/a" : backupFile.CategoryId;

                if (File.Exists(backupFile.LocalPath))
                {
                    FileInfo fileInfo = new FileInfo(backupFile.LocalPath);
                    DgvBackups.Rows.Add(backupFile.Name, backupFile.FileName, gameId.ToUpper(), fileInfo.Length.ToString("#,##0") + " bytes", fileInfo.LastWriteTime);
                }
                else
                {
                    DgvBackups.Rows.Add(backupFile.Name + " (No Local File Found)", backupFile.FileName, gameId.ToUpper(), "n/a", "n/a");
                }
            }
        }

        private void DgvBackupFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBackups.SelectedRows.Count > 0)
            {
                BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];

                LabelName.Text = backupFile.Name;
                LabelGame.Text = string.IsNullOrEmpty(backupFile.CategoryId) ? "n/a" : MainForm.Categories.GetCategoryById(backupFile.CategoryId).Title;
                LabelFileName.Text = backupFile.FileName;
                LabelLocalPath.Text = backupFile.LocalPath;
                LabelConsolePath.Text = backupFile.InstallPath;

                if (!File.Exists(backupFile.LocalPath))
                {
                    LabelName.Text += " (No Local File Found)";
                    DarkMessageBox.Show(this, string.Format("Local file for {0} can't be found at path {1}.\n\nYou can either edit the backup and choose your local file again, or re-install your game update and re-backup the game file.", backupFile.Name, backupFile.LocalPath));
                }
            }

            ToolItemEditBackup.Enabled = DgvBackups.SelectedRows.Count > 0;
            ToolItemDeleteBackup.Enabled = DgvBackups.SelectedRows.Count > 0;
            ToolItemBackupFile.Enabled = DgvBackups.SelectedRows.Count > 0 && MainForm.IsConsoleConnected;
            ToolItemRestoreFile.Enabled = DgvBackups.SelectedRows.Count > 0 && MainForm.IsConsoleConnected;
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
            MainForm.SettingsData.BackupFiles.RemoveAt(DgvBackups.CurrentRow.Index);
            LoadBackups();
        }

        private void ToolItemBackupFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];
            BackupGameFile(backupFile);
        }

        private void ToolItemRestoreFile_Click(object sender, EventArgs e)
        {
            BackupFile backupFile = MainForm.SettingsData.BackupFiles[DgvBackups.CurrentRow.Index];
            RestoreGameFile(backupFile);
        }

        public void BackupGameFile(BackupFile backupFile)
        {
            CategoriesData.Category category = MainForm.Categories.GetCategoryById(backupFile.CategoryId);

            try
            {
                FtpExtensions.DownloadFile(MainForm.ConsoleProfile.Address, backupFile.LocalPath, backupFile.InstallPath);
                DarkMessageBox.Show(this, string.Format("Successfully backed up {0} for file {1} from {2}", backupFile.Name, backupFile.FileName, backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was an issue attempting to backup game file.", ex);
                DarkMessageBox.Show(this, string.Format("There was an issue when attempting to restore file to console. Make sure the local file path exists on your computer and that there isn't a typos", Path.GetFileName(backupFile.LocalPath), backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Error);
            }
        }

        public void RestoreGameFile(BackupFile backupFile)
        {
            try
            {
                if (!File.Exists(backupFile.LocalPath))
                {
                    DarkMessageBox.Show(this, "This file backup doesn't exist on your computer. If your game doesn't have mods installed, then I would suggest you backup the original files.", "No Backup File", MessageBoxIcon.Information);
                    return;
                }

                FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, backupFile.LocalPath, backupFile.InstallPath);
                DarkMessageBox.Show(this, string.Format("Successfully restored {0} for file {1} to {2}", backupFile.Name, backupFile.FileName, backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was an issue attempting to restore game file.", ex);
                DarkMessageBox.Show(this, string.Format("There was an issue attempting to restore game file. Make sure the local file path exists on your computer and that there isn't a typos", Path.GetFileName(backupFile.LocalPath), backupFile.InstallPath), "Backup File Restored", MessageBoxIcon.Error);
            }
        }
    }
}