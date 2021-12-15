using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;

namespace ModioX.Forms.Dialogs
{
    public partial class SubmitModsDialog : XtraForm
    {
        public SubmitModsDialog()
        {
            InitializeComponent();
        }

        private void SubmitModsDialog_Load(object sender, EventArgs e)
        {
            ComboBoxConsole.SelectedIndex = 0;
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
                "Thanks for your request!\n\nA Google Forms page will now open with all the information pre-filled automatically. You can also upload a compressed archive containing the files. Click the 'Submit' button to send your request.",
                "Opening Request Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenGoogleFormsPreFill(TextBoxModName.Text, TextBoxDescription.Text, TextBoxGameCategory.Text, ComboBoxConsole.SelectedItem as string, TextBoxCreators.Text, TextBoxRegion.Text, TextBoxSourceLinks.Text);

            ForceRefresh();
        }

        private void OpenGoogleFormsPreFill(string name, string description, string category, string console, string creator, string region, string links)
        {
            string url = $"https://docs.google.com/forms/d/e/1FAIpQLScbeLBheZWjAp03d281pQHL2RvU93SLx2UXQZddx8i2nS2JmA/viewform?usp=pp_url" +
                $"&entry.1884265043={name}" +
                $"&entry.1389515172={description}" +
                $"&entry.841012679={category}" +
                $"&entry.188495311={console}" +
                $"&entry.491838807={creator}" +
                $"&entry.496892414={region}" +
                $"&entry.1503890983={links}";

            Process.Start(url);
        }
    }
}