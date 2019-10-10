using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Database;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Windows
{
    public partial class EditBackupForm : DarkForm
    {
        public BackupFile BackupFile { get; set; } = new BackupFile();

        public EditBackupForm()
        {
            InitializeComponent();
        }

        private void EditBackupForm_Load(object sender, EventArgs e)
        {
            TextBoxName.Text = BackupFile.Name;
            TextBoxFileName.Text = BackupFile.File;
            TextBoxGameId.Text = BackupFile.GameId;
            TextBoxLocalPath.Text = BackupFile.LocalPath;
            TextBoxConsolePath.Text = BackupFile.InstallPath;
        }

        private void ButtonBackupSave_Click(object sender, EventArgs e)
        {
            if (BackupFile == CreateBackup())
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                DarkMessageBox.Show(this, "You must include a useful name for this file backup.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxLocalPath.Text) || TextBoxLocalPath.Text.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                DarkMessageBox.Show(this, "You must assign a local file path for this file backup.", "No Local Path", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsolePath.Text))
            {
                DarkMessageBox.Show(this, "You must assign a console path for this file backup. It's where the file will be restored to.", "No Console Path", MessageBoxIcon.Exclamation);
                return;
            }

            if (FtpExtensions.FileExists(MainForm.ProfileIP, TextBoxConsolePath.Text))
            {
                if (DarkMessageBox.Show(this, "Would you like to backup this console file now?", "Backup File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FtpExtensions.DownloadFile(MainForm.ProfileIP, BackupFile.LocalPath, BackupFile.InstallPath);
                }
            }

            MainForm.SettingsData.BackupFiles.Remove(BackupFile);
            MainForm.SettingsData.BackupFiles.Add(CreateBackup());

            Close();
        }

        private BackupFile CreateBackup()
        {
            BackupFile backupFile = new BackupFile()
            {
                Name = TextBoxName.Text,
                File = Path.GetFileName(TextBoxConsolePath.Text),
                GameId = TextBoxGameId.Text,
                LocalPath = TextBoxLocalPath.Text,
                InstallPath = TextBoxConsolePath.Text,
            };

            return backupFile;
        }

        private void ButtonLocalPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { CheckFileExists = true, Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxLocalPath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}