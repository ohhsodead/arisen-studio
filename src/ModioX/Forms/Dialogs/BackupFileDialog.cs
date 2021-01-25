using DevExpress.XtraEditors;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms
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
            TextBoxConsolePath.Text = BackupFile.InstallPath;
            TextBoxLocalPath.Text = BackupFile.LocalPath;
        }

        private void ButtonBrowseLocalPath_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog { CheckFileExists = true, Multiselect = false };
            openFileDialog.InitialDirectory = Path.GetDirectoryName(TextBoxLocalPath.Text);

            if (openFileDialog.ShowDialog() == DialogResult.OK) TextBoxLocalPath.Text = openFileDialog.FileName;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLocalPath.Text) ||
                TextBoxLocalPath.Text.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                _ = XtraMessageBox.Show("You must include a local file path for the game file backup.",
                    "Empty Local Path");
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsolePath.Text))
            {
                _ = XtraMessageBox.Show(
                    "You must include a console path for for the game file backup. This is where the file will be restored at on the console.",
                    "Empty Console Path");
                return;
            }

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