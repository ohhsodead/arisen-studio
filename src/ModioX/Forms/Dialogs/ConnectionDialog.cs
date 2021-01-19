using DevExpress.XtraEditors;
using ModioX.Controls;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class ConnectionDialog : XtraForm
    {
        public ConnectionDialog()
        {
            InitializeComponent();
        }

        public ConsoleProfile ConsoleProfile { get; private set; }

        private void ConnectConsole_Load(object sender, EventArgs e)
        {
            LoadConsoles();
        }

        private void ConnectionDialogTest_SizeChanged(object sender, EventArgs e)
        {
            UpdateScrollBar();
        }

        private void LoadConsoles()
        {
            PanelConsoleProfiles.Controls.Clear();

            int consoleIndex = 0;

            foreach (var console in MainWindow.Settings.ConsoleProfiles)
            {
                Image consoleImage = Properties.Resources.PlayStation3Slim;

                switch (console.Type)
                {
                    case ConsoleType.PlayStation3Fat:
                        consoleImage = Properties.Resources.PlayStation3Fat;
                        break;
                    case ConsoleType.PlayStation3Slim:
                        consoleImage = Properties.Resources.PlayStation3Slim;
                        break;
                    case ConsoleType.PlayStation3SuperSlim:
                        consoleImage = Properties.Resources.PlayStation3Slim;
                        break;
                    case ConsoleType.Xbox360FatWhite:
                        consoleImage = Properties.Resources.XboxFat;
                        break;
                    case ConsoleType.Xbox360EliteFatBlack:
                        consoleImage = Properties.Resources.XboxFatElite;
                        break;
                    case ConsoleType.Xbox360Slim:
                        consoleImage = Properties.Resources.XboxSlim;
                        break;
                    case ConsoleType.Xbox360SlimE:
                        consoleImage = Properties.Resources.XboxSlimE;
                        break;
                }

                var consoleItem = new TileViewConsoleItem(console.Name, consoleImage) { Name = consoleIndex.ToString() };                
                consoleItem.OnClick += new EventHandler(ConsoleItem_Click);
                PanelConsoleProfiles.Controls.Add(consoleItem);
                consoleIndex++;
            }
        }

        Control SelectedItem;

        private void ConsoleItem_Click(object sender, EventArgs e)
        {
            if (((Control)sender) is not TileViewConsoleItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as TileViewConsoleItem;
            }

            var consoleProfile = MainWindow.Settings.ConsoleProfiles[int.Parse(SelectedItem.Name)];

            ConsoleProfile = consoleProfile;

            XtraMessageBox.Show("Selected Console: " + ConsoleProfile.Name);

            ButtonEdit.Enabled = ConsoleProfile != null;
            ButtonDelete.Enabled = ConsoleProfile != null;
            ButtonConnect.Enabled = ConsoleProfile != null;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MainWindow.Settings.ConsoleProfiles.Count == 1)
            {
                XtraMessageBox.Show("You can't delete this because there must be at least one console.", "Can't Delete Console");
            }
            else
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MainWindow.Settings.ConsoleProfiles.Remove(ConsoleProfile);
                    LoadConsoles();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var selectedIndex = MainWindow.Settings.ConsoleProfiles.IndexOf(ConsoleProfile);
            var oldConsoleProfile = MainWindow.Settings.ConsoleProfiles[selectedIndex];

            var newConsoleProfile = DialogExtensions.ShowNewConnectionWindow(this, oldConsoleProfile, true);
            
            if (newConsoleProfile != null) oldConsoleProfile = newConsoleProfile;

            LoadConsoles();
        }

        private void PanelConsoleProfiles_ControlAddedOrRemoved(object sender, ControlEventArgs e)
        {
            UpdateScrollBar();
        }

        private void ScrollBarConsoleProfiles_Scroll(object sender, ScrollEventArgs e)
        {
            PanelConsoleProfiles.VerticalScroll.Value = ScrollBarConsoleProfiles.Value;
            Refresh();
        }

        private void UpdateScrollBar()
        {
            ScrollBarConsoleProfiles.Visible = PanelConsoleProfiles.VerticalScroll.Visible;
            ScrollBarConsoleProfiles.Minimum = PanelConsoleProfiles.VerticalScroll.Minimum;
            ScrollBarConsoleProfiles.Maximum = PanelConsoleProfiles.VerticalScroll.Maximum;
            ScrollBarConsoleProfiles.SmallChange = PanelConsoleProfiles.VerticalScroll.SmallChange;
            ScrollBarConsoleProfiles.LargeChange = PanelConsoleProfiles.VerticalScroll.LargeChange;
            ScrollBarConsoleProfiles.Value = PanelConsoleProfiles.VerticalScroll.Value;
        }
    }
}