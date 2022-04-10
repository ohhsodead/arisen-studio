using DevExpress.XtraEditors;
using ModioX.Extensions;
using System;

namespace ModioX.Forms.Dialogs.Importing
{
    public partial class InstallFileDialog : XtraForm
    {
        public InstallFileDialog()
        {
            InitializeComponent();
        }

        public InstallItem InstallItem { get; set; } = new();

        private void InstallFileDialog_Load(object sender, EventArgs e)
        {
            TextBoxLocalFilePath.Text = InstallItem.InstallFilePath;
            TextBoxInstallFilePath.Text = InstallItem.InstallFilePath;
        }

        private void TextBoxLocalFilePath_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxLocalFilePath.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxInstallFilePath.Text);

            InstallItem.LocalFilePath = TextBoxLocalFilePath.Text;
        }

        private void TextBoxInstallFilePath_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxLocalFilePath.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxInstallFilePath.Text);

            InstallItem.InstallFilePath = TextBoxInstallFilePath.Text;
        }

        private void ImageFileLocation_Click(object sender, EventArgs e)
        {
            string fileLocation = DialogExtensions.ShowOpenFileDialog(this, "Choose Install File", "All Files|*.*");

            if (!fileLocation.IsNullOrEmpty())
            {
                TextBoxLocalFilePath.Text = fileLocation;
            }
        }
    }
}