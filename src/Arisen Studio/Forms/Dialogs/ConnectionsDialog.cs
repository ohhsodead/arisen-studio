using DevExpress.XtraEditors;
using ArisenStudio.Controls;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using ArisenStudio.Properties;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class ConnectionsDialog : XtraForm
    {
        public ConnectionsDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

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
        public Platform? Platform { get; set; } = null;

        /// <summary>
        /// Get the console profile details.
        /// </summary>
        public ConsoleProfile ConsoleProfile { get; private set; }

        /// <summary>
        /// Get the selected console.
        /// </summary>
        public ProfileItem SelectedConsole { get; private set; }

        private Control SelectedItem;

        private void ConnectionsDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("CONNECTIONS");

            GroupConsoleProfiles.Text = Language.GetString("CONSOLE_PROFILES");

            ButtonAddNewProfile.Text = Language.GetString("PROFILE_ADD_NEW");
            ButtonEditProfile.Text = Language.GetString("PROFILE_EDIT");
            ButtonDeleteProfile.Text = Language.GetString("PROFILE_DELETE");

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

                    switch (consoleProfile.PlatformType)
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

                        case PlatformType.PlayStation4:
                            consoleImage = Resources.PlayStation4;
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

                    ProfileItem consoleItem = new(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                    consoleItem.OnClick += ConsoleItem_Click;
                    consoleItem.OnDoubleClick += ConsoleItem_DoubleClick;
                    PanelConsoleProfiles.Controls.Add(consoleItem);
                }
            }
            else
            {
                if (Platform == null)
                {
                    foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
                    {
                        Image consoleImage = consoleImage = Resources.PlayStation3Fat;

                        switch (consoleProfile.PlatformType)
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

                            case PlatformType.PlayStation4:
                                consoleImage = Resources.PlayStation4;
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

                        ProfileItem consoleItem = new(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                        consoleItem.OnClick += ConsoleItem_Click;
                        consoleItem.OnDoubleClick += ConsoleItem_DoubleClick;
                        PanelConsoleProfiles.Controls.Add(consoleItem);
                    }
                }
                else
                {
                    foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles.FindAll(x => x.Platform == Platform))
                    {
                        Image consoleImage = consoleImage = Resources.PlayStation3Fat;

                        switch (consoleProfile.PlatformType)
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

                            case PlatformType.PlayStation4:
                                consoleImage = Resources.PlayStation4;
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

                        ProfileItem consoleItem = new(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                        consoleItem.OnClick += ConsoleItem_Click;
                        consoleItem.OnDoubleClick += ConsoleItem_DoubleClick;
                        PanelConsoleProfiles.Controls.Add(consoleItem);
                    }
                }
            }

            NoConsoleProfiles.Visible = PanelConsoleProfiles.Controls.Count == 0;
            ScrollBarConsoleProfiles.Visible = PanelConsoleProfiles.Controls.Count != 0 && PanelConsoleProfiles.VerticalScroll.Visible;

            ButtonEditProfile.Enabled = ConsoleProfile != null;
            ButtonDeleteProfile.Enabled = ConsoleProfile != null;
        }

        private void ConsoleItem_Click(object sender, EventArgs e)
        {
            ResetConsoleItems();

            if ((Control)sender is not ProfileItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as ProfileItem;
            }

            SelectedConsole = SelectedItem as ProfileItem;
            SelectedConsole.IsSelected = true;

            ConsoleProfile = SelectedConsole.ConsoleProfile;

            ButtonEditProfile.Enabled = ConsoleProfile != null;
            ButtonDeleteProfile.Enabled = ConsoleProfile != null;
        }

        private void ConsoleItem_DoubleClick(object sender, EventArgs e)
        {
            ResetConsoleItems();

            if ((Control)sender is not ProfileItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as ProfileItem;
            }

            SelectedConsole = SelectedItem as ProfileItem;
            SelectedConsole.IsSelected = true;

            ConsoleProfile = SelectedConsole.ConsoleProfile;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ResetConsoleItems()
        {
            foreach (Control ctrl in PanelConsoleProfiles.Controls)
            {
                ProfileItem item = ctrl as ProfileItem;
                item.IsSelected = false;
            }
        }

        private void ButtonAddNewConsole_Click(object sender, EventArgs e)
        {
            foreach (object control in PanelConsoleProfiles.Controls)
            {
                if (control is ProfileItem item)
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
                    if (control is ProfileItem item)
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
                    _ = XtraMessageBox.Show(this, "You can't edit the details while you're connected to it.", "Connected Console", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ConsoleProfile != null)
                {
                    foreach (object control in PanelConsoleProfiles.Controls)
                    {
                        if (control is ProfileItem item)
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
                _ = XtraMessageBox.Show(this, "Error editing console.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonDeleteConsole_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MainWindow.IsConsoleConnected && MainWindow.ConsoleProfile == ConsoleProfile)
                {
                    _ = XtraMessageBox.Show(this, "You can't edit the details while you're connected to it.", "Connected Console", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _ = Settings.ConsoleProfiles.Remove(ConsoleProfile);
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