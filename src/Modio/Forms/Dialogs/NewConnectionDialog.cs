using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Humanizer;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Models.Resources;
using System;
using System.Net;
using System.Resources;
using System.Windows.Forms;

namespace Modio.Forms.Dialogs
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

        private void ConsolesWindow_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("LABEL_CONNECTION_DETAILS");

            LabelName.Text = Language.GetString("LABEL_CONNECTION_NAME");
            LabelPlatformType.Text = Language.GetString("LABEL_PLATFORM_TYPE");
            LabelAddress.Text = Language.GetString("LABEL_IP_ADDRESS");
            LabelLogin.Text = Language.GetString("LABEL_LOGIN");

            ButtonChangeLoginDetails.Text = Language.GetString("LABEL_CHANGE");
            ButtonOK.Text = Language.GetString("LABEL_OK");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            TextBoxConnectionName.Text = ConsoleProfile.Name;
            ComboBoxPlatform.SelectedIndex = ComboBoxPlatform.Properties.Items.IndexOf(ConsoleProfile.PlatformType.Humanize());
            TextBoxAddress.Text = ConsoleProfile.Address;

            LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials
                ? Language.GetString("LABEL_DEFAULT")
                : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            TextBoxConnectionName.SelectionStart = TextBoxConnectionName.Text.Length;

            LabelUserPass.Visible = ConsoleProfile.Platform == Platform.PS3;
            ButtonChangeLoginDetails.Visible = ConsoleProfile.Platform == Platform.PS3;

            CheckBoxUseDefaultConsole.Visible = ConsoleProfile.Platform == Platform.XBOX360;
            CheckBoxUseDefaultConsole.CheckState = ConsoleProfile.UseDefaultConsole ? CheckState.Checked : CheckState.Unchecked;
            //CheckBoxUseDefaultConsole.Checked = ConsoleProfile.UseDefaultConsole;
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
                    ConsoleProfile.PlatformType = PlatformType.Xbox360FatWhite;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxFat;
                    break;

                case 4:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360EliteFatBlack;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxFatElite;
                    break;

                case 5:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360Slim;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxSlim;
                    break;

                case 6:
                    ConsoleProfile.PlatformType = PlatformType.Xbox360SlimE;
                    ConsoleProfile.Platform = Platform.XBOX360;
                    ImageConsole.Image = Properties.Resources.XboxSlimE;
                    break;
                default:
                    goto case 0;
            }

            LabelAddress.Text = ConsoleProfile.Platform == Platform.PS3 ? Language.GetString("LABEL_IP_ADDRESS") : Language.GetString("LABEL_ADDRESS_NAME");

            LabelLogin.Text = ConsoleProfile.Platform == Platform.PS3 ? Language.GetString("LABEL_LOGIN") : Language.GetString("LABEL_USE_DEFAULT");
            LabelUserPass.Visible = ConsoleProfile.Platform == Platform.PS3;
            ButtonChangeLoginDetails.Visible = ConsoleProfile.Platform == Platform.PS3;

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
                        XtraMessageBox.Show(this, $"You have already marked: '{consoleProfile.Name}' as your default console.\n\nPlease edit that console and uncheck the 'Use Default' option to mark this one as default.", Language.GetString("LABEL_DEFAULT_CONSOLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxConnectionName.Text))
            {
                XtraMessageBox.Show(this, "You must enter a connection name.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxAddress.Text))
            {
                XtraMessageBox.Show(this, ConsoleProfile.Platform == Platform.PS3 ? "You must enter an IP Address." : "You must enter an IP Address or Console Name.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (ConsoleProfile.UseDefaultCredentials)
            {
                case true when ConsoleProfile.Platform == Platform.PS3:
                    ConsoleProfile.Username = "anonymous";
                    ConsoleProfile.Password = "anonymous";
                    break;
                case true when ConsoleProfile.Platform == Platform.XBOX360:
                    ConsoleProfile.Username = "xboxftp";
                    ConsoleProfile.Password = "xboxftp";
                    break;
            }

            bool isAddressValid = ConsoleProfile.Platform == Platform.XBOX360 ? true : IPAddress.TryParse(TextBoxAddress.Text, out _);

            switch (isAddressValid)
            {
                case true:
                    {
                        switch (IsEditingProfile)
                        {
                            case true when ConsoleProfile.Name != TextBoxConnectionName.Text && ProfileExists(TextBoxConnectionName.Text):
                                XtraMessageBox.Show(this, "A console profile with this name already exists.", "Profile Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                        XtraMessageBox.Show(this, "A console profile with this name already exists.", "Profile Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    XtraMessageBox.Show(this, "IP Address isn't in the correct format.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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