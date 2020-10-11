using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class BackupFileDialog : DarkForm
    {
        public BackupFile BackupFile { get; set; } = new BackupFile();

        public BackupFileDialog()
        {
            InitializeComponent();
        }

        private void EditBackupForm_Load(object sender, EventArgs e)
        {
            TextBoxName.Text = BackupFile.Name;
            TextBoxFileName.Text = BackupFile.FileName;
            TextBoxGameId.Text = BackupFile.CategoryId;
            TextBoxLocalPath.Text = BackupFile.LocalPath;
            TextBoxConsolePath.Text = BackupFile.InstallPath;
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

        private void TextBoxConsolePath_TextChanged(object sender, EventArgs e)
        {
            TextBoxFileName.Text = Path.GetFileName(TextBoxConsolePath.Text);
        }

        private void ButtonBackupSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                _ = DarkMessageBox.Show(this, "You must include a name for the game file backup..", "Empty Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxLocalPath.Text) || TextBoxLocalPath.Text.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                _ = DarkMessageBox.Show(this, "You must include a local file path for the game file backup.", "Empty Local Path", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsolePath.Text))
            {
                _ = DarkMessageBox.Show(this, "You must include a console path for for the game file backup. This is where the file will be restored at on the console.", "Empty Console Path", MessageBoxIcon.Exclamation);
                return;
            }

            BackupFile.Name = TextBoxName.Text;
            BackupFile.CategoryId = TextBoxGameId.Text;
            BackupFile.FileName = Path.GetFileName(TextBoxConsolePath.Text);
            BackupFile.LocalPath = TextBoxLocalPath.Text;
            BackupFile.InstallPath = TextBoxConsolePath.Text;

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}