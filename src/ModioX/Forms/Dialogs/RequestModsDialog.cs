using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Templates;

namespace ModioX.Forms.Dialogs
{
    public partial class RequestModsDialog : XtraForm
    {
        public RequestModsDialog()
        {
            InitializeComponent();
        }

        private void RequestModsDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonBrowseLocalPath_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new() { CheckFileExists = true, Multiselect = false };
            openFileDialog.InitialDirectory = Path.GetDirectoryName(TextBoxVersion.Text);

            if (openFileDialog.ShowDialog() == DialogResult.OK) TextBoxVersion.Text = openFileDialog.FileName;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxModName.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the mod name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxSystemType.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the supported system type. Examples: CEX, DEX, HEN, HAN.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxGameCategory.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the game title or category.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxCreators.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the creator's name. If you do not know then put \"Unknown\".", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxVersion.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the version. If you do not know then put \"Unknown\".", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxDescription.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include some description, such as useful details, what is it or how it works.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxSourceLinks.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include at least one link to the download link or source code.", "Empty Field");
                return;
            }

            XtraMessageBox.Show(this,
                "The GitHub Issues tracker page will now open and all the information you have provided will be auto-filled for you. You must create or login with your GitHub account and click the 'Submit' button to open the request.",
                "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GitHubTemplates.OpenRequestTemplate(TextBoxModName.Text, TextBoxGameCategory.Text, TextBoxCreators.Text, TextBoxVersion.Text, TextBoxSystemType.Text, TextBoxDescription.Text, TextBoxSourceLinks.Text);

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}