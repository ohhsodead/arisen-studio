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
using XDevkit;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class ConsoleManager : XtraForm
    {
        public ConsoleManager()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        private IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        private IXboxManager XboxManager { get; } = MainWindow.XboxManager;

        /// <summary>
        /// Get the console profile details.
        /// </summary>
        public ConsoleProfile ConsoleProfile { get; set; } = MainWindow.ConsoleProfile;

        /// <summary>
        /// Get the selected console.
        /// </summary>
        public ProfileItem SelectedConsole { get; private set; }

        private Control SelectedItem;

        private void ConsoleManager_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("CONSOLE_MANAGER");

            GroupConsoleProfiles.Text = Language.GetString("CONSOLE_PROFILES");

            ButtonAddNewProfile.SetControlText(Language.GetString("PROFILE_ADD_NEW"), 26);
            ButtonEditProfile.SetControlText(Language.GetString("PROFILE_EDIT"), 26);
            ButtonDeleteProfile.SetControlText(Language.GetString("PROFILE_DELETE"), 26);

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

            foreach (IXboxConsole console in XboxManager.Consoles)
            {
                ProfileItem consoleItem = new(console.Name, Resources.XboxSlim)
                {
                    ConsoleProfile = new()
                    {
                        Address = console.IPAddress.ToString(),
                        Platform = Platform.XBOX360,
                        PlatformType = PlatformType.Xbox360FatWhite
                    }
                };

                consoleItem.MouseClick += ConsoleItem_MouseDown;
                consoleItem.OnClick += ConsoleItem_Click;
                PanelConsoleProfiles.Controls.Add(consoleItem);
            }

            NoConsoleProfiles.Visible = PanelConsoleProfiles.Controls.Count == 0;
            ScrollBarConsoleProfiles.Visible = PanelConsoleProfiles.Controls.Count != 0 && PanelConsoleProfiles.VerticalScroll.Visible;

            ButtonEditProfile.Enabled = ConsoleProfile != null;
            ButtonDeleteProfile.Enabled = ConsoleProfile != null;
        }

        private void ConsoleItem_Click(object sender, EventArgs e)
        {
            //RefreshConsoles();
        }

        private void ConsoleItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //if (consoleIte)
                PopupMenuActions.ShowPopup(Cursor.Position);
            }
        }

        private void RefreshConosoles(object controlItem)
        {
            //ResetConsoleItems(controlItem);

            //if ((Control)controlItem is not ProfileItem)
            //{
            //    SelectedItem = (Controlsender).Parent;
            //}
            //else
            //{
            //    SelectedItem = (Control)controlItem as ProfileItem;
            //}

            //SelectedConsole = SelectedItem as ProfileItem;
            //SelectedConsole.IsSelected = true;

            //ConsoleProfile = SelectedConsole.ConsoleProfile;

            //ButtonEditProfile.Enabled = ConsoleProfile != null;
            //ButtonDeleteProfile.Enabled = ConsoleProfile != null;
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
            //ConsoleProfile newXboxProfile = DialogExtensions.ShowXboxConsoleManager(this);

            //foreach (object control in Settings.)
            //{
            //    if (control is ProfileItem item)
            //    {
            //        item.ShouldHover = false;
            //    }
            //}

            //ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            //if (consoleProfile != null)
            //{
            //    Settings.ConsoleProfiles.Add(consoleProfile);
            //    LoadConsoles();
            //}
            //else
            //{
            //    foreach (object control in PanelConsoleProfiles.Controls)
            //    {
            //        if (control is ProfileItem item)
            //        {
            //            item.ShouldHover = true;
            //        }
            //    }
            //}
        }

        private void ButtonEditConsole_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainWindow.IsConsoleConnected && MainWindow.ConsoleProfile == ConsoleProfile)
                {
                    XtraMessageBox.Show(this, "You can't edit the details while you're connected to it.", "Connected Console", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                XtraMessageBox.Show(this, "Error editing console.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonDeleteConsole_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MainWindow.IsConsoleConnected && MainWindow.ConsoleProfile == ConsoleProfile)
                {
                    XtraMessageBox.Show(this, "You can't edit the details while you're connected to it.", "Connected Console", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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