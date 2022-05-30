using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using Microsoft.Web.WebView2.Core;
using System;

namespace NeoModsX.Forms.Dialogs
{
    public partial class RequestModsDialog : ToolbarForm
    {
        public RequestModsDialog()
        {
            InitializeComponent();
        }

        private void RequestModsDialog_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebView.Source = new Uri("https://docs.google.com/forms/d/e/1FAIpQLScbeLBheZWjAp03d281pQHL2RvU93SLx2UXQZddx8i2nS2JmA/viewform?embedded=true");
        }

        private void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            ProgressPanel.Visible = true;
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            ProgressPanel.Visible = false;
        }
    }
}