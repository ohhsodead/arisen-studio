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

        public static SettingsData Settings { get; } = MainWindow.Settings;

        public ConsoleProfile ConsoleProfile { get; private set; }

        public TileConsoleItem SelectedConsole { get; private set; }

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
            SelectedConsole = null;

            var consoleIndex = 0;

            foreach (var consoleProfile in Settings.ConsoleProfiles)
            {
                Image consoleImage = consoleImage = Properties.Resources.PlayStation3Fat;

                switch (consoleProfile.Type)
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

                TileConsoleItem consoleItem = new TileConsoleItem(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                consoleItem.OnClick += new EventHandler(ConsoleItem_Click);
                PanelConsoleProfiles.Controls.Add(consoleItem);
                consoleIndex++;
            }
        }

        private void ConsoleItem_Click(object sender, EventArgs e)
        {
            ResetConsoleItems();

            Control SelectedItem;

            if (((Control)sender) is not TileConsoleItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as TileConsoleItem;
            }

            SelectedConsole = SelectedItem as TileConsoleItem;
            SelectedConsole.IsSelected = true;

            ConsoleProfile = SelectedConsole.ConsoleProfile;

            ButtonEdit.Enabled = ConsoleProfile != null;
            ButtonDelete.Enabled = ConsoleProfile != null;
            ButtonConnect.Enabled = ConsoleProfile != null;
        }

        private void ResetConsoleItems()
        {
            foreach (var ctrl in PanelConsoleProfiles.Controls)
            {
                TileConsoleItem item = ctrl as TileConsoleItem;
                item.IsSelected = false;
            }
        }

        private void ButtonNewConnection_Click(object sender, EventArgs e)
        {
            var consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
                MainWindow.Window.SaveSettings();
                MainWindow.Window.LoadSettings();
                LoadConsoles();
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Settings.ConsoleProfiles.Count == 1)
            {
                XtraMessageBox.Show("You must have at least one console saved.", "Cannot Delete");
            }
            else
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Settings.ConsoleProfiles.Remove(ConsoleProfile);
                    LoadConsoles();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var selectedIndex = Settings.ConsoleProfiles.IndexOf(ConsoleProfile);
            var oldConsoleProfile = Settings.ConsoleProfiles[selectedIndex];

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