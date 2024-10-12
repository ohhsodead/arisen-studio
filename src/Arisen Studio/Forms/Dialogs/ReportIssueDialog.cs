using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using Microsoft.Web.WebView2.Core;
using ArisenStudio.Constants;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using ArisenStudio.Forms.Windows;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class ReportIssueDialog : ToolbarForm
    {
        public ReportIssueDialog()
        {
            InitializeComponent();
        }

        public Exception ExceptionThrown { get; set; } = null;

        public string FormUrl { get; set; } = Urls.FormReportIssue;

        private Timer WebPageTimer { get; } = new();

        private void ReportIssueDialog_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(Width, MainWindow.Window.Height - 40);
            CenterToParent();
            //StartPosition = FormStartPosition.CenterParent;

            WebView.Source = new Uri(FormUrl);

            if (ExceptionThrown != null)
            {
                FormUrl = Urls.GenerateIssueFormUrl(ExceptionThrown, false);
            }

            WebPageTimer.Tick += WebPageTimer_Tick;
            WebPageTimer.Interval = 15000;
            WebPageTimer.Enabled = true;
            WebPageTimer.Start();

            //XtraMessageBox.Show(this,
            //    "This form lets you report bugs easily without needing an account. Please use it responsibly, as misuse may result in a restriction from future use.", 
            //    "Report Issues",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WebPageTimer_Tick(object sender, EventArgs e)
        {
            WebPageTimer.Enabled = false;

            if (XtraMessageBox.Show(this,
                "It looks like the form is taking a while to load. Would you like to open it in your web browser?", 
                "Open Browser",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _ = Process.Start(Urls.ReportIssue);
            }
        }

        private void ButtonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebView.Source = new Uri(FormUrl);
        }

        private void ButtonOpenLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            _ = Process.Start(Urls.ReportIssue);
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
                WebPageTimer.Enabled = false;
            }
        }
    }
}