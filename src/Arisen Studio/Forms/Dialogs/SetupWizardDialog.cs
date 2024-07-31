using ArisenStudio.Controls;
using ArisenStudio.Extensions;
using ArisenStudio.Models.Resources;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Properties;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArisenStudio.Models.Release_Data;
using XDevkit;
using JRPC_Client;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class SetupWizardDialog : XtraForm
    {
        public SetupWizardDialog()
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
        public ConsoleProfile ConsoleProfile { get; set; }

        /// <summary>
        /// Get the selected console.
        /// </summary>
        public ProfileItem SelectedConsole { get; set; }

        private Control SelectedItem;

        private void SetupWizardDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("SETUP_WIZARD");

            WizardControlMain.NextText = "&" + Language.GetString("LABEL_NEXT") + " >";
            WizardControlMain.PreviousText = "< &" + Language.GetString("LABEL_BACK");
            WizardControlMain.CancelText = Language.GetString("LABEL_CANCEL");
            WizardControlMain.HelpText = "&" + Language.GetString("HELP");

            WizardPageWelcome.Text = Language.GetString("LABEL_WELCOME");
            WizardPageConsoleProfiles.Text = Language.GetString("CONSOLE_PROFILES");
            WizardPageComplete.Text = Language.GetString("SETUP_COMPLETE");

            TabPageChangeLog.Text = Language.GetString("CHANGE_LOG");

            ButtonAddNewProfile.Text = Language.GetString("PROFILE_ADD_NEW");
            //ButtonFindXboxConsoles.SetControlText(Language.GetString("XBOX_SCAN_CONSOLES"), 26);
            ButtonEditProfile.Text = Language.GetString("PROFILE_EDIT");
            ButtonDeleteProfile.Text = Language.GetString("PROFILE_DELETE");

            LoadChangeLog();
            LoadConsoles();

            //RadioGroupConsoles.SelectedIndex = -1;
        }

        private void SetupWizardDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.ConsoleProfiles.Count == 0)
            {
                if (Platform == null)
                {
                    Platform platform = DialogExtensions.ShowPlatformList(this, true);
                    Settings.ConsoleProfiles.Add(Settings.CreateDefaultProfile(platform));
                }
                else
                {
                    Settings.ConsoleProfiles.Add(Settings.CreateDefaultProfile(Platform));
                }
            }
        }

        private void RadioGroupConsoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (RadioGroupConsoles.SelectedIndex)
            //{
            //    //case -1:
            //    //    break;
            //    case 0:
            //        Platform = ArisenStudio.Platform.PS3;
            //        break;
            //    case 1:
            //        Platform = ArisenStudio.Platform.PS4;
            //        break;
            //    case 2:
            //        Platform = ArisenStudio.Platform.XBOX360;
            //        break;
            //}

            //if (RadioGroupConsoles.SelectedIndex == 2)
            //{
            //    if (XtraMessageBox.Show(this, Language.GetString("NEIGHBORHOOD_SCAN"), "Neighborhood Scan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            foreach (var console in XboxExtensions.ScanForConsoles(this))
            //            {
            //                Settings.ConsoleProfiles.Add(console);
            //            }

            //            bool defaultExists = false;

            //            foreach (var console in Settings.ConsoleProfiles)
            //            {
            //                if (console.IsDefault)
            //                {
            //                    defaultExists = true;
            //                }
            //            }

            //            if (!defaultExists)
            //            {
            //                Settings.ConsoleProfiles[0].IsDefault = true;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MainWindow.Window.SetStatus(Language.GetString("NEIGHBORHOOD_SCAN_FAILED"), ex);
            //            XtraMessageBox.Show(this,
            //                                $"{Language.GetString("ADD_CONSOLES_MANUALLY")}\n\n{Language.GetString("ERROR")}: {ex.Message}",
            //                                Language.GetString("SCAN_FAILED"),
            //                                MessageBoxButtons.OK,
            //                                MessageBoxIcon.Error);
            //        }

            //    }
            //}
        }

        private void LoadChangeLog()
        {
            GitHubReleaseData gitHubData = UpdateExtensions.AllReleases[0];

            LabelChangeLogVersion.Text = gitHubData.Name;
            LabelChangeLog.Text = gitHubData.Body.Replace("- ", "• ");
        }

        private void LoadConsoles()
        {
            PanelConsoleProfiles.Controls.Clear();
            ConsoleProfile = null;
            SelectedConsole = null;

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
        }

        private void ResetConsoleItems()
        {
            foreach (Control ctrl in PanelConsoleProfiles.Controls)
            {
                ProfileItem item = ctrl as ProfileItem;
                item.IsSelected = false;
            }
        }

        private void ButtonAddNewProfile_Click(object sender, EventArgs e)
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

        private void WizardControlMain_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (WizardControlMain.SelectedPage == WizardPageWelcome)
            {

            }

            if (WizardControlMain.SelectedPage == WizardPageConsoleProfiles)
            {
                LoadConsoles();

                if (Settings.ConsoleProfiles.Count() == 0)
                {

                }
            }
        }

        private void WizardControlMain_CancelClick(object sender, CancelEventArgs e)
        {

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