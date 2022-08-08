using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;

namespace ArisenStudio.Controls
{
    public partial class NoAnnouncementsItem : XtraUserControl
    {
        public NoAnnouncementsItem()
        {
            InitializeComponent();
        }

        private void NoAnnouncementsItem_Load(object sender, EventArgs e)
        {
            LoadText();
        }

        public void LoadText()
        {
            LabelTitle.Text = MainWindow.ResourceLanguage.GetString("NO_ANNOUNCEMENTS");
            LabelSubTitle.Text = MainWindow.ResourceLanguage.GetString("NO_NEWS_IS_GOOD_NEWS");
        }
    }
}