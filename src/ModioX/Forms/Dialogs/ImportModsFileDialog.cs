using System;
using DevExpress.XtraEditors;
using ModioX.Extensions;

namespace ModioX.Forms.Dialogs
{
    public partial class ImportModsFileDialog : XtraForm
    {
        public ImportModsFileDialog()
        {
            InitializeComponent();
        }

        private void TextBoxUsername_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxFileLocation.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxInstallPath.Text);
        }

        private void TextBoxPassword_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxFileLocation.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxInstallPath.Text);
        }

        private void ImageFileLocation_Click(object sender, EventArgs e)
        {
            string fileLocation = DialogExtensions.ShowOpenFileDialog(this, "Choose File", "All Files|*.*");

            if (!fileLocation.IsNullOrEmpty())
            {
                TextBoxFileLocation.Text = fileLocation;
            }
        }
    }
}