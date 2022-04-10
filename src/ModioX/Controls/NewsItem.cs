using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ModioX.Forms.Windows;
using System;
using System.Diagnostics;
using System.Globalization;

namespace ModioX.Controls
{
    public partial class NewsItem : XtraUserControl
    {
        public NewsItem(string title, string message, DateTime timeStamp)
        {
            InitializeComponent();
            LabelTitle.Text = title;
            LabelMessage.Text = message;
            LabelTimeStamp.Text = MainWindow.Settings.UseRelativeTimes ? timeStamp.Humanize() : timeStamp.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
        }

        private void NewsItem_Load(object sender, EventArgs e)
        {

        }

        private void LabelMessage_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }
    }
}