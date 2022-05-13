using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using Microsoft.Web.WebView2.Core;
using System;
using System.Diagnostics;

namespace Modio.Forms.Dialogs
{
    public partial class RequestModsDialog : ToolbarForm
    {
        public RequestModsDialog()
        {
            InitializeComponent();
        }

        private void RequestModsDialog_Load(object sender, EventArgs e)
        {
            //WebView.("https://forms.gle/EVZYx83Xoo3e4AWA9");
        }

        private void ButtonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            WebView.Source = new Uri("https://docs.google.com/forms/d/1ckg3ZRL13ocJH5NURPAfOMBKXoaK1WtP-upBDLj1PTM/viewform?embedded=true");
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