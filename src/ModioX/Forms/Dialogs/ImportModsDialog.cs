using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;

namespace ModioX.Forms.Dialogs
{
    public partial class ImportModsDialog : XtraForm
    {
        public ImportModsDialog()
        {
            InitializeComponent();
        }

        public PlatformPrefix ConsoleType { get; set; }

        private void ImportModsDialog_Load(object sender, EventArgs e)
        {
            ComboBoxConsoleType.SelectedIndex = 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxModName.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the mod name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxGameCategory.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the game title or category.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxDescription.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include some description, such as useful details, what is it or how it works.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxSourceLinks.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include at least one link to the download link or source code.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            XtraMessageBox.Show(this,
                "Thanks for your contribution! GitHub Issues tracker page will now open and all the information will be auto-filled for you. You must create or login with your GitHub account and click the 'Submit' button to open a request.",
                "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}