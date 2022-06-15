using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using Microsoft.Web.WebView2.Core;
using ArisenMods.Constants;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArisenMods.Forms.Dialogs
{
    public partial class RequestModsDialog : ToolbarForm
    {
        public RequestModsDialog()
        {
            InitializeComponent();
        }

        private readonly Timer LoadTimer = new();

        private void RequestModsDialog_Load(object sender, EventArgs e)
        {
            LoadTimer.Tick += LoadTimer_Tick;
            LoadTimer.Interval = 10000;
            LoadTimer.Enabled = true;
            LoadTimer.Start();
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            LoadTimer.Enabled = false;

            if (XtraMessageBox.Show(this, "It looks like the form is taking a while to load. Do you want to load it in your web browser?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Process.Start(Urls.RequestModsForm);
            }
        }

        private void ButtonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebView.Source = new Uri(Urls.RequestModsForm);
        }

        private void ButtonOpenLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Urls.RequestModsForm);
        }

        private void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            ProgressPanel.Visible = true;
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            ProgressPanel.Visible = false;

            if (e.IsSuccess)
            {
                LoadTimer.Enabled = false;
            }
        }
    }
}