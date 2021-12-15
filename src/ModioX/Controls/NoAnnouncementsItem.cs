using System;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;

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
            LabelTitle.Text = MainWindow.ResourceLanguage.GetString("NO ANNOUNCEMENTS");
            LabelSubTitle.Text = MainWindow.ResourceLanguage.GetString("No news is good news!");
        }
    }
}