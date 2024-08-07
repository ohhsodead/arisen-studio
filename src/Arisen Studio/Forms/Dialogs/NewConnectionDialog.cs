﻿using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using DevExpress.Utils.Mdi;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Humanizer;
using System;
using System.Drawing;
using System.Net;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class NewConnectionDialog : XtraForm
    {
        public NewConnectionDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public ConsoleProfile ConsoleProfile { get; set; } = new();

        public bool IsEditingProfile { get; set; } = false;

        private void NewConnectionDialog_Load(object sender, EventArgs e)
        {
            if (IsEditingProfile)
            {
                Text = Language.GetString("LABEL_EDIT_CONNECTION_DETAILS");
            }
            else
            {
                Text = Language.GetString("LABEL_NEW_CONNECTION_DETAILS");
            }

            LabelName.Text = Language.GetString("LABEL_CONNECTION_NAME") + ":";
            LabelPlatformType.Text = Language.GetString("LABEL_PLATFORM_TYPE") + ":";
            LabelAddress.Text = Language.GetString("LABEL_IP_ADDRESS") + ":";
            LabelLogin.Text = Language.GetString("LABEL_LOGIN") + ":";

            ButtonChangeLoginDetails.Text = Language.GetString("LABEL_CHANGE");
            ButtonSave.Text = Language.GetString("LABEL_SAVE");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            TextBoxConnectionName.Text = ConsoleProfile.Name;
            ComboBoxPlatform.SelectedIndex = ComboBoxPlatform.Properties.Items.IndexOf(ConsoleProfile.PlatformType.Humanize());
            TextBoxAddress.Text = ConsoleProfile.Address;

            LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials
                ? Language.GetString("LABEL_DEFAULT")
                : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            TextBoxConnectionName.SelectionStart = TextBoxConnectionName.Text.Length;

            LabelUserPass.Visible = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;
            ButtonChangeLoginDetails.Visible = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;

            CheckBoxUseDefaultConsole.Visible = ConsoleProfile.Platform == Platform.XBOX360;
            CheckBoxUseDefaultConsole.CheckState = ConsoleProfile.UseDefaultConsole ? CheckState.Checked : CheckState.Unchecked;
            //CheckBoxUseDefaultConsole.Checked = ConsoleProfile.UseDefaultConsole;

            int defaults = 0;

            foreach (ConsoleProfile console in MainWindow.Settings.ConsoleProfiles)
            {
                if (!console.Name.EqualsIgnoreCase(TextBoxConnectionName.Text))
                {
                    if (console.IsDefault)
                    {
                        defaults++;
                    }
                }
            }

            CheckBoxDefault.Checked = defaults == 0;
        }

        private void NewConnectionDialog_FormClosed(object sender, FormClosedEventArgs e)
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

            //        TextBoxConnectionName.Text = "New Console";
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

        private void NewConnectionDialog_FormClosing(object sender, FormClosingEventArgs e)
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

            //        TextBoxConnectionName.Text = "New Console";
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

        private void ComboBoxPlatformType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxPlatform.SelectedIndex)
            {
                case 0:
                    ConsoleProfile.PlatformType = PlatformType.PlayStation3Fat;
                    ConsoleProfile.Platform = Platform.PS3;
                    ImageConsole.Image = Properties.Resources.PlayStation3Fat;
                    break;

                case 1:
                    ConsoleProfile.PlatformType = PlatformType.PlayStation3Slim;
                    ConsoleProfile.Platform = Platform.PS3;
                    ImageConsole.Image = Properties.Resources.PlayStation3Slim;
                    break;

                case 2:
                    ConsoleProfile.PlatformType = PlatformType.PlayStation3SuperSlim;
                    ConsoleProfile.Platform = Platform.PS3;
                    ImageConsole.Image = Properties.Resources.PlayStation3SuperSlim;
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
                    ImageConsole.Image = Properties.Resources.XboxFat;
                    break;

                case 5:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360EliteFatBlack;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxFatElite;
                    break;

                case 6:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360Slim;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxSlim;
                    break;

                case 7:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360SlimE;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxSlimE;
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

            if (ConsoleProfile.Platform == Platform.PS3)
            {
                LabelLogin.Text = Language.GetString("LABEL_LOGIN") + ":";
            }
            else if (ConsoleProfile.Platform == Platform.PS4)
            {
                LabelLogin.Text = Language.GetString("LABEL_LOGIN") + ":";
            }
            else if (ConsoleProfile.Platform == Platform.XBOX360)
            {
                LabelLogin.Text = Language.GetString("LABEL_USE_DEFAULT") + ":";
            }

            LabelUserPass.Visible = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;
            ButtonChangeLoginDetails.Visible = ConsoleProfile.Platform == Platform.PS3 | ConsoleProfile.Platform == Platform.PS4;

            CheckBoxUseDefaultConsole.Visible = ConsoleProfile.Platform == Platform.XBOX360;
        }

        private void CheckBoxUseDefaultConsole_CheckStateChanged(object sender, EventArgs e)
        {
            //CheckBoxUseDefaultConsole.Checked = (bool)e.NewValue;

            ConsoleProfile.UseDefaultConsole = CheckBoxUseDefaultConsole.Checked;

            LabelAddress.Enabled = !CheckBoxUseDefaultConsole.Checked;
            TextBoxAddress.Enabled = !CheckBoxUseDefaultConsole.Checked;

            //TextBoxConsoleAddress.Text = ConsoleProfile.Platform == ConsolePlatform.PS3 ? ConsoleProfile.Address : "Default";
            TextBoxAddress.Text = CheckBoxUseDefaultConsole.Checked ? Language.GetString("LABEL_DEFAULT_CONSOLE") : ConsoleProfile.Address;
            ButtonChangeLoginDetails.Enabled = !CheckBoxUseDefaultConsole.Checked;
        }

        private void CheckBoxUseDefaultConsole_Properties_EditValueChanging(object sender, ChangingEventArgs e)
        {
            foreach (ConsoleProfile consoleProfile in MainWindow.Settings.ConsoleProfiles.FindAll(x => x.Platform == Platform.XBOX360))
            {
                if (consoleProfile != ConsoleProfile)
                {
                    if (consoleProfile.UseDefaultConsole)
                    {
                        e.Cancel = true;
                        XtraMessageBox.Show(this, string.Format(Language.GetString("DEFAULT_CONSOLE_ALREADY_EXISTS"), consoleProfile.Name), Language.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }

        private void ButtonChangeCredentials_Click(object sender, EventArgs e)
        {
            using LoginDialog consoleCredentials = new();

            consoleCredentials.TextBoxUsername.Text = ConsoleProfile.Username;
            consoleCredentials.TextBoxPassword.Text = ConsoleProfile.Password;

            DialogResult setCredentials = consoleCredentials.ShowDialog(this);

            switch (setCredentials)
            {
                case DialogResult.OK:
                    LabelUserPass.Text = consoleCredentials.TextBoxUsername.Text + @" / " + consoleCredentials.TextBoxPassword.Text;

                    ConsoleProfile.Username = consoleCredentials.TextBoxUsername.Text;
                    ConsoleProfile.Password = consoleCredentials.TextBoxPassword.Text;
                    ConsoleProfile.UseDefaultCredentials = false;
                    break;
                case DialogResult.Abort:
                    LabelUserPass.Text = Language.GetString("LABEL_DEFAULT");

                    ConsoleProfile.Username = string.Empty;
                    ConsoleProfile.Password = string.Empty;
                    ConsoleProfile.UseDefaultCredentials = true;
                    break;
            }
        }

        private void CheckBoxDefault_CheckStateChanged(object sender, EventArgs e)
        {
            int defaults = 0;

            foreach (ConsoleProfile console in MainWindow.Settings.ConsoleProfiles)
            {
                if (!console.Name.EqualsIgnoreCase(TextBoxConnectionName.Text))
                {
                    if (console.IsDefault)
                    {
                        defaults++;
                    }
                }
            }

            if (!CheckBoxDefault.Checked && defaults == 0)
            {
                XtraMessageBox.Show(this, Language.GetString("MUST_HAVE_DEFAULT_CONSOLE"), Language.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckBoxDefault.Checked = true;
                return;
            }

            ConsoleProfile.IsDefault = CheckBoxDefault.Checked;
        }

        private void CheckBoxDefault_EditValueChanging(object sender, ChangingEventArgs e)
        {
            foreach (ConsoleProfile consoleProfile in MainWindow.Settings.ConsoleProfiles)
            {
                if (!consoleProfile.Name.EqualsIgnoreCase(TextBoxConnectionName.Text))
                {
                    if (consoleProfile.IsDefault)
                    {
                        XtraMessageBox.Show(this, string.Format(Language.GetString("DEFAULT_CONSOLE_ALREADY_EXISTS"), consoleProfile.Name), Language.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Cancel = true;
                        return;
                    }
                }
            }

            ConsoleProfile.IsDefault = CheckBoxDefault.Checked;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxConnectionName.Text))
            {
                XtraMessageBox.Show(this, Language.GetString("MISSING_CONNECTION_NAME"), Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxAddress.Text))
            {
                XtraMessageBox.Show(this, ConsoleProfile.Platform == Platform.PS3 ? Language.GetString("MISSING_IP_ADDRESS") : Language.GetString("MISSING_IP_OR_NAME"), Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (ConsoleProfile.UseDefaultCredentials)
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

            if (ConsoleProfile.UseDefaultConsole)
            {
                isAddressValid = true;
            }
            else
            {
                isAddressValid = ConsoleProfile.Platform == Platform.XBOX360 ? true : IPAddress.TryParse(TextBoxAddress.Text, out _);
            }

            switch (isAddressValid)
            {
                case true:
                    {
                        switch (IsEditingProfile)
                        {
                            case true when ConsoleProfile.Name != TextBoxConnectionName.Text && ProfileExists(TextBoxConnectionName.Text):
                                XtraMessageBox.Show(this, Language.GetString("PROFILE_NAME_EXISTS"), Language.GetString("LABEL_CONNECTION_DETAILS"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case true:
                                ConsoleProfile.Name = TextBoxConnectionName.Text;
                                ConsoleProfile.Address = TextBoxAddress.Text;
                                DialogResult = DialogResult.OK;
                                break;
                            default:
                                {
                                    if (ProfileExists(TextBoxConnectionName.Text))
                                    {
                                        XtraMessageBox.Show(this, Language.GetString("PROFILE_NAME_EXISTS"), Language.GetString("LABEL_CONNECTION_DETAILS"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        ConsoleProfile.Id = DataExtensions.GenerateUniqueId();
                                        ConsoleProfile.Name = TextBoxConnectionName.Text;
                                        ConsoleProfile.Address = TextBoxAddress.Text;
                                        DialogResult = DialogResult.OK;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
                default:
                    XtraMessageBox.Show(this, Language.GetString("INCORRECT_IP_FORMAT"), Language.GetString("INVALID_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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