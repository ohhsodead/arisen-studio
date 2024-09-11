using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class DataViewDialog : XtraForm
    {
        /// <summary>
        /// Initialize application form
        /// </summary>
        public DataViewDialog()
        {
            InitializeComponent();
        }

        private void DataViewDialog_Load(object sender, EventArgs e)
        {
        }

        private void DataViewDialog_Scroll(object sender, ScrollEventArgs e)
        {
            PanelDetails.Update();
        }

        private void LabelBody_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }
    }
}