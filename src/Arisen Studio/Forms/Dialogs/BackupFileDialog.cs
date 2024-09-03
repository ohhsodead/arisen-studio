using DevExpress.XtraEditors;
using ArisenStudio.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class BackupFileDialog : XtraForm
    {
        public BackupFileDialog()
        {
            InitializeComponent();
        }

        public BackupFile BackupFile { get; set; } = new();

        private void EditBackupForm_Load(object sender, EventArgs e)
        {
            TextBoxFileName.Text = BackupFile.FileName;
            TextBoxGameId.Text = BackupFile.CategoryId;
            TextBoxInstallPathConsole.Text = BackupFile.InstallPath;
            TextBoxInstallPathLocal.Text = BackupFile.LocalPath;
        }

        private void ButtonBrowseLocalPath_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new() { CheckFileExists = true, Multiselect = false };
            openFileDialog.InitialDirectory = Path.GetDirectoryName(TextBoxInstallPathLocal.Text);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxInstallPathLocal.Text = openFileDialog.FileName;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxInstallPathLocal.Text) ||
                TextBoxInstallPathLocal.Text.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                _ = XtraMessageBox.Show("You must include a local file path for the game file backup.", "Empty Local Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxInstallPathConsole.Text))
            {
                _ = XtraMessageBox.Show(
                    "You must include a console path for for the game file backup. This is where the file will be restored at on the console.",
                    "Empty Console Path",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            BackupFile.CategoryId = TextBoxGameId.Text;
            BackupFile.FileName = Path.GetFileName(TextBoxInstallPathConsole.Text);
            BackupFile.LocalPath = TextBoxInstallPathLocal.Text;
            BackupFile.InstallPath = TextBoxInstallPathConsole.Text;

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}