using ArisenStudio.Constants;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using DevExpress.Utils.Mdi;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Humanizer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class NewProfileDialog : XtraForm
    {
        public NewProfileDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public ConsoleProfile ConsoleProfile { get; set; } = new();

        public bool IsEditingProfile { get; set; } = false;

        private void NewProfileDialog_Load(object sender, EventArgs e)
        {
            if (IsEditingProfile)
            {
                Text = Language.GetString("LABEL_EDIT_PROFILE_DETAILS");
            }
            else
            {
                Text = Language.GetString("LABEL_NEW_PROFILE_DETAILS");
            }

            GroupBoxProfileInfo.Text = Language.GetString("PROFILE_INFO");
            LabelName.Text = Language.GetString("LABEL_PROFILE_NAME") + ":";
            LabelPlatformType.Text = Language.GetString("LABEL_PLATFORM_TYPE") + ":";
            LabelAddress.Text = Language.GetString("LABEL_IP_ADDRESS") + ":";
            LabelLoginDetails.Text = Language.GetString("LABEL_LOGIN_DETAILS") + ":";
            LabelOptions.Text = Language.GetString("OPTIONS") + ":";

            GroupBoxProfileInfo.Text = Language.GetString("ADVANCED_SETTINGS");
            CheckBoxDefaultLogin.Text = Language.GetString("LABEL_DEFAULT_CREDENTIALS");
            ButtonEditLoginDetails.Text = Language.GetString("LABEL_EDIT");
            CheckBoxDefaultProfile.Text = Language.GetString("LABEL_DEFAULT_PROFILE");
            CheckBoxPassiveMode.Text = Language.GetString("LABEL_PASSIVE_MODE");
            ButtonSave.Text = Language.GetString("LABEL_SAVE");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            TextBoxProfileName.Text = ConsoleProfile.Name;
            ComboBoxPlatform.SelectedIndex = ComboBoxPlatform.Properties.Items.IndexOf(ConsoleProfile.PlatformType.Humanize());
            TextBoxAddress.Text = ConsoleProfile.Address;

            //LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials
            //    ? Language.GetString("LABEL_DEFAULT")
            //    : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            //LabelUserPass.Visible = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;
            ButtonEditLoginDetails.Enabled = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;

            //CheckBoxDefaultLogin.Enabled = ConsoleProfile.Platform == Platform.XBOX360;
            //CheckBoxDefaultLogin.CheckState = ConsoleProfile.UseDefaultLogin ? CheckState.Checked : CheckState.Unchecked;
            if (IsEditingProfile)
            {
                CheckBoxDefaultLogin.Checked = false;
            }
            else
            {
                CheckBoxDefaultLogin.Checked = ConsoleProfile.UseDefaultLogin;
            }

            CheckBoxPassiveMode.Enabled = ConsoleProfile.Platform == Platform.PS3;
            CheckBoxPassiveMode.Checked = ConsoleProfile.PassiveMode;

            CheckBoxGoldHEN.Enabled = ConsoleProfile.Platform == Platform.PS3;
            CheckBoxGoldHEN.Checked = ConsoleProfile.GoldHEN;

            int defaults = 0;

            foreach (ConsoleProfile console in MainWindow.Settings.ConsoleProfiles)
            {
                if (!console.Name.EqualsIgnoreCase(TextBoxProfileName.Text.Trim()))
                {
                    if (console.IsDefault)
                    {
                        defaults++;
                    }
                }
            }

            CheckBoxDefaultProfile.Checked = defaults == 0;

            TextBoxProfileName.SelectionStart = TextBoxProfileName.Text.Length;
        }

        private void NewProfileDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (DialogResult == DialogResult.Cancel && CloseOnCancel)
            //if (MainWindow.Settings.ConsoleProfiles.Count == 0)
            //{
            //    if (XtraMessageBox.Show(this, string.Format("At least one console profile must be created to use Arisen Studio.\n\nWould you like to create the Default profile?"), Language.GetString("ERROR"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    {
            //        string userPlatform = DialogExtensions.ShowListItemDialog(this, "Default Platform", Language.GetString("LABEL_PLATFORM"), ["PlayStation 3", "Xbox 360"]);
            //        Platform platform = Platform.PS3;

            //        if (!string.IsNullOrEmpty(userPlatform))
            //        {
            //            platform = userPlatform.DehumanizeTo<Platform>();
            //        }

            //        TextBoxProfileName.Text = "New Console";
            //        ComboBoxPlatform.SelectedIndex = platform == Platform.PS3 ? 0 : 3;
            //        TextBoxAddress.Text = "192.168.1.1";
            //        CheckBoxDefault.Checked = true;
            //        ConsoleProfile.Platform = platform;

            //        //ConsoleProfile.Name = "Guest";
            //        //ConsoleProfile.Address = "192.168.1.1";
            //        //ConsoleProfile.Platform = platform;
            //        //ConsoleProfile.IsDefault = true;
            //        DialogResult = DialogResult.OK;
            //        e.Cnacel = false;
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void NewProfileDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ////if (DialogResult == DialogResult.Cancel && CloseOnCancel)
            //if (MainWindow.Settings.ConsoleProfiles.Count == 0)
            //{
            //    if (XtraMessageBox.Show(this, string.Format("At least one console profile must be created to use Arisen Studio.\n\nWould you like to create the Default profile?"), Language.GetString("ERROR"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    {
            //        string userPlatform = DialogExtensions.ShowListItemDialog(this, "Default Platform", Language.GetString("LABEL_PLATFORM"), ["PlayStation 3", "Xbox 360"]);
            //        Platform platform = Platform.PS3;

            //        if (!string.IsNullOrEmpty(userPlatform))
            //        {
            //            platform = userPlatform.DehumanizeTo<Platform>();
            //        }

            //        TextBoxProfileName.Text = "New Console";
            //        ComboBoxPlatform.SelectedIndex = platform == Platform.PS3 ? 0 : 3;
            //        TextBoxAddress.Text = "192.168.1.1";
            //        CheckBoxDefault.Checked = true;
            //        ConsoleProfile.Platform = platform;

            //        //ConsoleProfile.Name = "Guest";
            //        //ConsoleProfile.Address = "192.168.1.1";
            //        //ConsoleProfile.Platform = platform;
            //        //ConsoleProfile.IsDefault = true;
            //        DialogResult = DialogResult.OK;
            //        e.Cancel = false;
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void NewProfileDialog_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ = Process.Start(Urls.ProjectWebsite + "help");
        }

        private void ComboBoxPlatformType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxPlatform.SelectedIndex)
            {
                case 0:
                    ConsoleProfile.PlatformType = PlatformType.PlayStation3Fat;
                    ConsoleProfile.Platform = Platform.PS3;
                    //ImageConsole.Image = Properties.Resources.PlayStation3Fat;
                    break;

                case 1:
                    ConsoleProfile.PlatformType = PlatformType.PlayStation3Slim;
                    ConsoleProfile.Platform = Platform.PS3;
                    //ImageConsole.Image = Properties.Resources.PlayStation3Slim;
                    break;

                case 2:
                    ConsoleProfile.PlatformType = PlatformType.PlayStation3SuperSlim;
                    ConsoleProfile.Platform = Platform.PS3;
                    //ImageConsole.Image = Properties.Resources.PlayStation3SuperSlim;
                    break;

                case 3:
                    break;
                //ConsoleProfile.PlatformType = PlatformType.PlayStation4;
                //ConsoleProfile.Platform = Platform.PS4;
                //ImageConsole.Image = Properties.Resources.PlayStation4;
                //break;

                case 4:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360FatWhite;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    //ImageConsole.Image = Properties.Resources.XboxFat;
                    break;

                case 5:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360EliteFatBlack;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    //ImageConsole.Image = Properties.Resources.XboxFatElite;
                    break;

                case 6:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360Slim;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    //ImageConsole.Image = Properties.Resources.XboxSlim;
                    break;

                case 7:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360SlimE;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    //ImageConsole.Image = Properties.Resources.XboxSlimE;
                    break;
                default:
                    goto case 0;
            }

            //LabelAddress.Text = (ConsoleProfile.Platform == Platform.PS3 ? Language.GetString("LABEL_IP_ADDRESS") : Language.GetString("LABEL_IP_OR_NAME")) + ":";

            if (ConsoleProfile.Platform == Platform.PS3)
            {
                LabelAddress.Text = Language.GetString("LABEL_IP_ADDRESS") + ":";
            }
            else if (ConsoleProfile.Platform == Platform.PS4)
            {
                LabelAddress.Text = Language.GetString("LABEL_IP_ADDRESS") + ":";
            }
            else if (ConsoleProfile.Platform == Platform.XBOX360)
            {
                LabelAddress.Text = Language.GetString("LABEL_IP_OR_NAME") + ":";
            }

            //LabelLogin.Text = (ConsoleProfile.Platform == Platform.PS3 ? Language.GetString("LABEL_LOGIN") : Language.GetString("LABEL_USE_DEFAULT")) + ":";

            //if (ConsoleProfile.Platform == Platform.PS3)
            //{
            //    LabelLoginDetails.Text = Language.GetString("LABEL_LOGIN_DETAILS") + ":";
            //}
            //else if (ConsoleProfile.Platform == Platform.PS4)
            //{
            //    LabelLoginDetails.Text = Language.GetString("LABEL_LOGIN_DETAILS") + ":";
            //}
            //else if (ConsoleProfile.Platform == Platform.XBOX360)
            //{
            //    LabelLoginDetails.Text = Language.GetString("LABEL_USE_DEFAULT") + ":";
            //}

            //LabelUserPass.Visible = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;
            ButtonEditLoginDetails.Enabled = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;
            CheckBoxPassiveMode.Enabled = ConsoleProfile.Platform == Platform.PS3;
            CheckBoxPassiveMode.Checked = false;
            CheckBoxGoldHEN.Enabled = ConsoleProfile.Platform == Platform.PS3;
            CheckBoxGoldHEN.Checked = false;

            //CheckBoxDefault.Enabled = ConsoleProfile.Platform == Platform.XBOX360;
        }

        private void CheckBoxDefaultLogin_CheckStateChanged(object sender, EventArgs e)
        {
            ConsoleProfile.UseDefaultLogin = CheckBoxDefaultLogin.Checked;

            if (CheckBoxDefaultLogin.Checked)
            {
                if (ConsoleProfile.Platform == Platform.XBOX360)
                {
                    TextBoxAddress.Text = Language.GetString("LABEL_DEFAULT_PROFILE");
                    LabelAddress.Enabled = false;
                    TextBoxAddress.Enabled = false;
                }
                else
                {
                    TextBoxAddress.Text = ConsoleProfile.Address;
                    LabelAddress.Enabled = true;
                    TextBoxAddress.Enabled = true;
                }
            }
            else
            {
                TextBoxAddress.Text = ConsoleProfile.Address;
                LabelAddress.Enabled = true;
                ButtonEditLoginDetails.Enabled = true;
            }

            //LabelAddress.Enabled = CheckBoxDefaultLogin.Checked && ConsoleProfile.Platform != Platform.XBOX360;
            //TextBoxAddress.Enabled = CheckBoxDefaultLogin.Checked && ConsoleProfile.Platform != Platform.XBOX360;

            //TextBoxConsoleAddress.Text = ConsoleProfile.Platform == ConsolePlatform.PS3 ? ConsoleProfile.Address : "Default";
            //if (ConsoleProfile.Platform == Platform.PS3)
            //{
            //    if (CheckBoxDefaultLogin.Checked)
            //    {
            //        TextBoxAddress.Text = ConsoleProfile.Address;
            //        ButtonEditLoginDetails.Enabled = true;
            //    }
            //    else
            //    {
            //        TextBoxAddress.Text = ConsoleProfile.Address;
            //        ButtonEditLoginDetails.Enabled = true;
            //    }
            //}
            //else
            //{
            //    if (CheckBoxDefaultLogin.Checked)
            //    {
            //        TextBoxAddress.Text = Language.GetString("LABEL_DEFAULT_PROFILE");
            //        ButtonEditLoginDetails.Enabled = false;
            //    }
            //    else
            //    {
            //        TextBoxAddress.Text = ConsoleProfile.Address;
            //        ButtonEditLoginDetails.Enabled = true;
            //    }
            //}

            //TextBoxAddress.Text = CheckBoxDefaultLogin.Checked ? Language.GetString("LABEL_DEFAULT_PROFILE") : ConsoleProfile.Address;
            //ButtonEditLoginDetails.Enabled = !CheckBoxDefaultLogin.Checked;
        }

        private void CheckBoxDefaultLogin_Properties_EditValueChanging(object sender, ChangingEventArgs e)
        {
            foreach (ConsoleProfile consoleProfile in MainWindow.Settings.ConsoleProfiles.FindAll(x => x.Platform == Platform.XBOX360))
            {
                if (consoleProfile != ConsoleProfile)
                {
                    if (consoleProfile.UseDefaultLogin)
                    {
                        e.Cancel = true;
                        _ = XtraMessageBox.Show(this, string.Format(Language.GetString("DEFAULT_CONSOLE_ALREADY_EXISTS"), consoleProfile.Name), Language.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }

        private void ButtonEditCredentials_Click(object sender, EventArgs e)
        {
            using EditLoginDialog consoleCredentials = new();

            consoleCredentials.TextBoxUsername.Text = ConsoleProfile.Username;
            consoleCredentials.TextBoxPassword.Text = ConsoleProfile.Password;

            DialogResult setCredentials = consoleCredentials.ShowDialog(this);

            switch (setCredentials)
            {
                case DialogResult.OK:
                    ConsoleProfile.Username = consoleCredentials.TextBoxUsername.Text;
                    ConsoleProfile.Password = consoleCredentials.TextBoxPassword.Text;
                    ConsoleProfile.UseDefaultLogin = false;
                    break;
                case DialogResult.Abort:
                    ConsoleProfile.Username = string.Empty;
                    ConsoleProfile.Password = string.Empty;
                    ConsoleProfile.UseDefaultLogin = true;
                    break;
            }
        }

        private void CheckBoxPassiveMode_CheckStateChanged(object sender, EventArgs e)
        {
            ConsoleProfile.PassiveMode = CheckBoxPassiveMode.Checked;
        }

        private void CheckBoxGoldHEN_CheckStateChanged(object sender, EventArgs e)
        {
            ConsoleProfile.GoldHEN = CheckBoxGoldHEN.Checked;
        }

        private void CheckBoxDefaultProfile_CheckStateChanged(object sender, EventArgs e)
        {
            int defaults = 0;

            foreach (ConsoleProfile console in MainWindow.Settings.ConsoleProfiles)
            {
                if (!console.Name.EqualsIgnoreCase(TextBoxProfileName.Text.Trim()))
                {
                    if (console.IsDefault)
                    {
                        defaults++;
                    }
                }
            }

            if (!CheckBoxDefaultProfile.Checked && defaults == 0)
            {
                _ = XtraMessageBox.Show(this, Language.GetString("MUST_HAVE_DEFAULT_CONSOLE"), Language.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckBoxDefaultProfile.Checked = true;
                return;
            }

            ConsoleProfile.IsDefault = CheckBoxDefaultProfile.Checked;
        }

        private void CheckBoxDefaultProfile_EditValueChanging(object sender, ChangingEventArgs e)
        {
            foreach (ConsoleProfile consoleProfile in MainWindow.Settings.ConsoleProfiles)
            {
                if (!consoleProfile.Name.EqualsIgnoreCase(TextBoxProfileName.Text.Trim()))
                {
                    if (consoleProfile.IsDefault)
                    {
                        if (XtraMessageBox.Show(this, string.Format(Language.GetString("DEFAULT_PROFILE_ALREADY_EXISTS"), consoleProfile.Name), Language.GetString("LABEL_DEFAULT_PROFILE"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            consoleProfile.IsDefault = false;
                            e.Cancel = false;
                        }
                        else
                        {
                            e.Cancel = true;
                            return;
                        }

                        return;
                    }
                }
            }

            ConsoleProfile.IsDefault = CheckBoxDefaultProfile.Checked;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxProfileName.Text.Trim()))
            {
                _ = XtraMessageBox.Show(this, Language.GetString("MISSING_PROFILE_NAME"), Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxAddress.Text.Trim()))
            {
                _ = XtraMessageBox.Show(this, ConsoleProfile.Platform == Platform.PS3 ? Language.GetString("MISSING_IP_ADDRESS") : Language.GetString("MISSING_IP_OR_NAME"), Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (ConsoleProfile.UseDefaultLogin)
            {
                case true when ConsoleProfile.Platform == Platform.PS3:
                    ConsoleProfile.Username = "anonymous";
                    ConsoleProfile.Password = "anonymous";
                    break;
                case true when ConsoleProfile.Platform == Platform.PS4:
                    ConsoleProfile.Username = "";
                    ConsoleProfile.Password = "";
                    break;
                case true when ConsoleProfile.Platform == Platform.XBOX360:
                    ConsoleProfile.Username = "xboxftp";
                    ConsoleProfile.Password = "xboxftp";
                    break;
            }

            bool isAddressValid;

            if (ConsoleProfile.UseDefaultLogin)
            {
                isAddressValid = true;
            }
            else
            {
                isAddressValid = ConsoleProfile.Platform == Platform.XBOX360 ? true : IPAddress.TryParse(TextBoxAddress.Text.Trim(), out _);
            }

            switch (isAddressValid)
            {
                case true:
                    {
                        switch (IsEditingProfile)
                        {
                            case true when ConsoleProfile.Name != TextBoxProfileName.Text.Trim() && ProfileExists(TextBoxProfileName.Text.Trim()):
                                _ = XtraMessageBox.Show(this, Language.GetString("PROFILE_NAME_EXISTS"), Language.GetString("LABEL_PROFILE_DETAILS"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case true:
                                ConsoleProfile.Name = TextBoxProfileName.Text.Trim();
                                ConsoleProfile.Address = TextBoxAddress.Text.Trim();
                                DialogResult = DialogResult.OK;
                                break;
                            default:
                                {
                                    if (ProfileExists(TextBoxProfileName.Text.Trim()))
                                    {
                                        _ = XtraMessageBox.Show(this, Language.GetString("PROFILE_NAME_EXISTS"), Language.GetString("LABEL_PROFILE_DETAILS"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        ConsoleProfile.Id = DataExtensions.GenerateUniqueId();
                                        ConsoleProfile.Name = TextBoxProfileName.Text.Trim();
                                        ConsoleProfile.Address = TextBoxAddress.Text.Trim();
                                        DialogResult = DialogResult.OK;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
                default:
                    _ = XtraMessageBox.Show(this, Language.GetString("INCORRECT_IP_FORMAT"), Language.GetString("INVALID_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private static bool ProfileExists(string name)
        {
            foreach (ConsoleProfile console in MainWindow.Settings.ConsoleProfiles)
            {
                if (console.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}