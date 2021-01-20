using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class AboutDialog : XtraForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            ButtonClose.Focus();
        }

        private void LabelCredits_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            Process.Start(e.Text);
        }

        private void LabelLicense_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            Process.Start(e.Text);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}