using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using Modio.Forms.Windows;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Modio.Controls
{
    public partial class AccouncementItem : XtraUserControl
    {
        public int Id { get; set; }

        public AccouncementItem(int id, string title, string message, DateTime timeStamp)
        {
            InitializeComponent();
            Id = id;
            LabelTitle.Text = title;
            LabelMessage.Text = message;
            LabelTimeStamp.Text = MainWindow.Settings.UseRelativeTimes ? timeStamp.Humanize() : timeStamp.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
        }

        private void AccouncementItem_Load(object sender, EventArgs e)
        {

        }

        private void LabelMessage_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private void ImageDismiss_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow.Settings.DismissedAnnouncements.Add(Id);
                Hide();
            }
            catch { }
        }
    }
}