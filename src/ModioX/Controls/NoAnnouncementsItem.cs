using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using System;

namespace ModioX.Controls
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