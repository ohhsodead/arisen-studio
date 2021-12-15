using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Controls;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using ModioX.Properties;

namespace ModioX.Forms.Dialogs
{
    public partial class ConnectionsDialog : XtraForm
    {
        public ConnectionsDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get whether user is editing console profiles.
        /// </summary>
        public bool IsEditing { get; set; } = false;

        /// <summary>
        /// Get the console profile details.
        /// </summary>
        public PlatformPrefix ConsoleType { get; set; }

        /// <summary>
        /// Get the console profile details.
        /// </summary>
        public ConsoleProfile ConsoleProfile { get; private set; }

        /// <summary>
        /// Get the selected console.
        /// </summary>
        public ConsoleItem SelectedConsole { get; private set; }

        private Control SelectedItem;

        private void ConnectionsDialog_Load(object sender, EventArgs e)
        {
            LoadConsoles();
        }

        private void ConnectionDialog_SizeChanged(object sender, EventArgs e)
        {
            UpdateScrollBar();
        }

        private void LoadConsoles()
        {
            PanelConsoleProfiles.Controls.Clear();
            ConsoleProfile = null;
            SelectedConsole = null;

            if (IsEditing)
            {
                foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
                {
                    Image consoleImage = consoleImage = Resources.PlayStation3Fat;

                    switch (consoleProfile.Type)
                    {
                        case PlatformType.PlayStation3Fat:
                            consoleImage = Resources.PlayStation3Fat;
                            break;

                        case PlatformType.PlayStation3Slim:
                            consoleImage = Resources.PlayStation3Slim;
                            break;

                        case PlatformType.PlayStation3SuperSlim:
                            consoleImage = Resources.PlayStation3Slim;
                            break;

                        case PlatformType.Xbox360FatWhite:
                            consoleImage = Resources.XboxFat;
                            break;

                        case PlatformType.Xbox360EliteFatBlack:
                            consoleImage = Resources.XboxFatElite;
                            break;

                        case PlatformType.Xbox360Slim:
                            consoleImage = Resources.XboxSlim;
                            break;

                        case PlatformType.Xbox360SlimE:
                            consoleImage = Resources.XboxSlimE;
                            break;
                    }

                    ConsoleItem consoleItem = new(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                    consoleItem.OnClick += ConsoleItem_Click;
                    consoleItem.OnDoubleClick += ConsoleItem_DoubleClick;
                    PanelConsoleProfiles.Controls.Add(consoleItem);
                }
            }
            else
            {
                foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles.FindAll(x => x.TypePrefix == ConsoleType))
                {
                    Image consoleImage = consoleImage = Resources.PlayStation3Fat;

                    switch (consoleProfile.Type)
                    {
                        case PlatformType.PlayStation3Fat:
                            consoleImage = Resources.PlayStation3Fat;
                            break;

                        case PlatformType.PlayStation3Slim:
                            consoleImage = Resources.PlayStation3Slim;
                            break;

                        case PlatformType.PlayStation3SuperSlim:
                            consoleImage = Resources.PlayStation3Slim;
                            break;

                        case PlatformType.Xbox360FatWhite:
                            consoleImage = Resources.XboxFat;
                            break;

                        case PlatformType.Xbox360EliteFatBlack:
                            consoleImage = Resources.XboxFatElite;
                            break;

                        case PlatformType.Xbox360Slim:
                            consoleImage = Resources.XboxSlim;
                            break;

                        case PlatformType.Xbox360SlimE:
                            consoleImage = Resources.XboxSlimE;
                            break;
                    }

                    ConsoleItem consoleItem = new(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                    consoleItem.OnClick += ConsoleItem_Click;
                    consoleItem.OnDoubleClick += ConsoleItem_DoubleClick;
                    PanelConsoleProfiles.Controls.Add(consoleItem);
                }
            }

            NoConsolesItem.Visible = PanelConsoleProfiles.Controls.Count == 0;
            ScrollBarConsoleProfiles.Visible = PanelConsoleProfiles.Controls.Count != 0 && PanelConsoleProfiles.VerticalScroll.Visible;

            ButtonEditConsole.Enabled = ConsoleProfile != null;
            ButtonDeleteConsole.Enabled = ConsoleProfile != null;
        }

        private void ConsoleItem_Click(object sender, EventArgs e)
        {
            ResetConsoleItems();

            if ((Control)sender is not ConsoleItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as ConsoleItem;
            }

            SelectedConsole = SelectedItem as ConsoleItem;
            SelectedConsole.IsSelected = true;

            ConsoleProfile = SelectedConsole.ConsoleProfile;

            ButtonEditConsole.Enabled = ConsoleProfile != null;
            ButtonDeleteConsole.Enabled = ConsoleProfile != null;
        }

        private void ConsoleItem_DoubleClick(object sender, EventArgs e)
        {
            ResetConsoleItems();

            if ((Control)sender is not ConsoleItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as ConsoleItem;
            }

            SelectedConsole = SelectedItem as ConsoleItem;
            SelectedConsole.IsSelected = true;

            ConsoleProfile = SelectedConsole.ConsoleProfile;

            if (!IsEditing)
            {
                if (ConsoleProfile != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void ResetConsoleItems()
        {
            foreach (Control ctrl in PanelConsoleProfiles.Controls)
            {
                ConsoleItem item = ctrl as ConsoleItem;
                item.IsSelected = false;
            }
        }

        private void ButtonAddNewConsole_Click(object sender, EventArgs e)
        {
            foreach (object control in PanelConsoleProfiles.Controls)
            {
                if (control is ConsoleItem item)
                {
                    item.ShouldHover = false;
                }
            }

            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
                LoadConsoles();
            }
            else
            {
                foreach (object control in PanelConsoleProfiles.Controls)
                {
                    if (control is ConsoleItem item)
                    {
                        item.ShouldHover = true;
                    }
                }
            }
        }

        private void ButtonEditConsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainWindow.IsConsoleConnected && MainWindow.ConsoleProfile == ConsoleProfile)
                {
                    XtraMessageBox.Show(this, "You can't edit the details because you're connected to the console.", "Console Connected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ConsoleProfile != null)
                {
                    foreach (object control in PanelConsoleProfiles.Controls)
                    {
                        if (control is ConsoleItem item)
                        {
                            item.ShouldHover = false;
                        }
                    }

                    int selectedIndex = Settings.ConsoleProfiles.IndexOf(ConsoleProfile);
                    ConsoleProfile oldConsoleProfile = Settings.ConsoleProfiles[selectedIndex];

                    ConsoleProfile newConsoleProfile = DialogExtensions.ShowNewConnectionWindow(this, oldConsoleProfile, true);

                    Settings.ConsoleProfiles[selectedIndex] = newConsoleProfile;

                    SelectedItem = null;
                    LoadConsoles();
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Error editing console.");
                XtraMessageBox.Show(this, "Error editing console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonDeleteConsole_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MainWindow.IsConsoleConnected && MainWindow.ConsoleProfile == ConsoleProfile)
                {
                    XtraMessageBox.Show(this, "You can't delete this console because you're connected to it.", "Console Connected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Settings.ConsoleProfiles.Remove(ConsoleProfile);
                SelectedItem = null;
                LoadConsoles();
            }
        }

        private void PanelConsoleProfiles_ControlAddedOrRemoved(object sender, ControlEventArgs e)
        {
            UpdateScrollBar();
        }

        private void PanelConsoleProfiles_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarConsoleProfiles.Value = PanelConsoleProfiles.VerticalScroll.Value;
        }

        private void ScrollBarConsoleProfiles_Scroll(object sender, ScrollEventArgs e)
        {
            PanelConsoleProfiles.VerticalScroll.Value = ScrollBarConsoleProfiles.Value;
            PanelConsoleProfiles.Refresh();
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