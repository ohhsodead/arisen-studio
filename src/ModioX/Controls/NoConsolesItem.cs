using System;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;

namespace ModioX.Controls
{
    public partial class NoConsolesItem : XtraUserControl
    {
        public NoConsolesItem()
        {
            InitializeComponent();
        }

        private void NoConsolesItem_Load(object sender, EventArgs e)
        {
            LoadText();
        }

        public void LoadText()
        {
            LabelTitle.Text = MainWindow.ResourceLanguage.GetString("NO CONSOLE PROFILES");
            LabelSubTitle.Text = MainWindow.ResourceLanguage.GetString("Click 'Add New Console' to create a profile");
        }
    }
}