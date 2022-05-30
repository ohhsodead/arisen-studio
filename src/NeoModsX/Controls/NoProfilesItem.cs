using DevExpress.XtraEditors;
using NeoModsX.Forms.Windows;
using System;

namespace NeoModsX.Controls
{
    public partial class NoProfilesItem : XtraUserControl
    {
        public NoProfilesItem()
        {
            InitializeComponent();
        }

        private void NoConsolesItem_Load(object sender, EventArgs e)
        {
#if !DEBUG
            LoadText();
#endif
        }

        public void LoadText()
        {
            LabelTitle.Text = MainWindow.ResourceLanguage.GetString("NO_CONSOLE_PROFILES");
            LabelSubTitle.Text = MainWindow.ResourceLanguage.GetString("PROFILE_ADD_INSTRUCTION");
        }
    }
}