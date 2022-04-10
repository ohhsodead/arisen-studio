using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class AboutDialog : XtraForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            ButtonClose.Focus();
        }

        private void LabelCredits_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Text);
        }

        private void LabelLicense_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Text);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}