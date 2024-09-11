using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;
using System.Resources;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;
using ArisenStudio.Extensions;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class NeighborhoodEditor : XtraForm
    {
        public NeighborhoodEditor()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        private IXboxConsole Xbox { get; } = MainWindow.XboxConsole;

        private void ConsoleInfo_Load(object sender, EventArgs e)
        {
            //Text = Language.GetString("NEIGHBORHOOD_EDITOR");
        }

        private void TextBoxXboxName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Xbox.ChangeXboxName(TextBoxXboxName.Text);

            _ = XtraMessageBox.Show(this, "Changed Xbox Name. Refresh Neighborhood to see the new name.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBoxXboxIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxXboxIcon.SelectedIndex == 0)
            {
                Xbox.ChangeXboxIcon(IconColor.Black);
            }
            else if (ComboBoxXboxIcon.SelectedIndex == 1)
            {
                Xbox.ChangeXboxIcon(IconColor.Blue);
            }
            else if (ComboBoxXboxIcon.SelectedIndex == 2)
            {
                Xbox.ChangeXboxIcon(IconColor.BlueGray);
            }
            else if (ComboBoxXboxIcon.SelectedIndex == 3)
            {
                Xbox.ChangeXboxIcon(IconColor.White);
            }

            _ = XtraMessageBox.Show(this, "Changed Xbox Icon. Refresh Neighborhood to see the new icon.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}