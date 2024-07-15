using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using Microsoft.Web.WebView2.Core;
using ArisenStudio.Constants;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class RequestModsDialog : ToolbarForm
    {
        public RequestModsDialog()
        {
            InitializeComponent();
        }

        private const string FormUrl = "https://form.jotform.com/223613539362355";

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

            if (XtraMessageBox.Show(this, "It looks like the form is taking a while to load. Do you want to load it in your web browser?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(FormUrl);
            }
        }

        private void ButtonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebView.Source = new Uri(FormUrl);
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