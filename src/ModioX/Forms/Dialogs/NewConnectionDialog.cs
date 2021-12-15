using System;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Humanizer;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;

namespace ModioX.Forms.Dialogs
{
    public partial class NewConnectionDialog : XtraForm
    {
        public NewConnectionDialog()
        {
            InitializeComponent();
        }

        public ConsoleProfile ConsoleProfile { get; set; } = new();

        public bool IsEditingProfile { get; set; } = false;

        private void ConsolesWindow_Load(object sender, EventArgs e)
        {
            TextBoxConnectionName.Text = ConsoleProfile.Name;
            ComboBoxConsoleType.SelectedIndex = ComboBoxConsoleType.Properties.Items.IndexOf(ConsoleProfile.Type.Humanize());
            TextBoxConsoleAddress.Text = ConsoleProfile.Address;

            LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials
                ? "Default"
                : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            TextBoxConnectionName.SelectionStart = TextBoxConnectionName.Text.Length;

            LabelUserPass.Visible = ConsoleProfile.TypePrefix == PlatformPrefix.PS3;
            ButtonChangeCredentials.Visible = ConsoleProfile.TypePrefix == PlatformPrefix.PS3;

            CheckBoxUseDefaultConsole.Visible = ConsoleProfile.TypePrefix == PlatformPrefix.XBOX;
            CheckBoxUseDefaultConsole.CheckState = ConsoleProfile.UseDefaultConsole ? CheckState.Checked : CheckState.Unchecked;
            //CheckBoxUseDefaultConsole.Checked = ConsoleProfile.UseDefaultConsole;
        }

        private void ComboBoxConsoleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxConsoleType.SelectedIndex)
            {
                case 0:
                    ConsoleProfile.Type = PlatformType.PlayStation3Fat;
                    ConsoleProfile.TypePrefix = PlatformPrefix.PS3;
                    ImageConsole.Image = Properties.Resources.PlayStation3Fat;
                    break;

                case 1:
                    ConsoleProfile.Type = PlatformType.PlayStation3Slim;
                    ConsoleProfile.TypePrefix = PlatformPrefix.PS3;
                    ImageConsole.Image = Properties.Resources.PlayStation3Slim;
                    break;

                case 2:
                    ConsoleProfile.Type = PlatformType.PlayStation3SuperSlim;
                    ConsoleProfile.TypePrefix = PlatformPrefix.PS3;
                    ImageConsole.Image = Properties.Resources.PlayStation3SuperSlim;
                    break;

                case 3:
                    ConsoleProfile.Type = PlatformType.Xbox360FatWhite;
                    ConsoleProfile.TypePrefix = PlatformPrefix.XBOX;
                    ImageConsole.Image = Properties.Resources.XboxFat;
                    break;

                case 4:
                    ConsoleProfile.Type = PlatformType.Xbox360EliteFatBlack;
                    ConsoleProfile.TypePrefix = PlatformPrefix.XBOX;
                    ImageConsole.Image = Properties.Resources.XboxFatElite;
                    break;

                case 5:
                    ConsoleProfile.Type = PlatformType.Xbox360Slim;
                    ConsoleProfile.TypePrefix = PlatformPrefix.XBOX;
                    ImageConsole.Image = Properties.Resources.XboxSlim;
                    break;

                case 6:
                    ConsoleProfile.Type = PlatformType.Xbox360SlimE;
                    ConsoleProfile.TypePrefix = PlatformPrefix.XBOX;
                    ImageConsole.Image = Properties.Resources.XboxSlimE;
                    break;
                default:
                    goto case 0;
            }

            LabelConsoleAddress.Text = ConsoleProfile.TypePrefix == PlatformPrefix.PS3 ? "Address" : "Address/Name";

            LabelLogin.Text = ConsoleProfile.TypePrefix == PlatformPrefix.PS3 ? "Login" : "Use Default";
            LabelUserPass.Visible = ConsoleProfile.TypePrefix == PlatformPrefix.PS3;
            ButtonChangeCredentials.Visible = ConsoleProfile.TypePrefix == PlatformPrefix.PS3;

            CheckBoxUseDefaultConsole.Visible = ConsoleProfile.TypePrefix == PlatformPrefix.XBOX;
        }


        private void CheckBoxUseDefaultConsole_CheckStateChanged(object sender, EventArgs e)
        {
            //CheckBoxUseDefaultConsole.Checked = (bool)e.NewValue;

            ConsoleProfile.UseDefaultConsole = CheckBoxUseDefaultConsole.Checked;

            LabelConsoleAddress.Enabled = !CheckBoxUseDefaultConsole.Checked;
            TextBoxConsoleAddress.Enabled = !CheckBoxUseDefaultConsole.Checked;

            //TextBoxConsoleAddress.Text = ConsoleProfile.TypePrefix == ConsoleTypePrefix.PS3 ? ConsoleProfile.Address : "Default";
            TextBoxConsoleAddress.Text = CheckBoxUseDefaultConsole.Checked ? "Default Console" : ConsoleProfile.Address;
        }

        private void CheckBoxUseDefaultConsole_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBoxUseDefaultConsole_Properties_EditValueChanging(object sender, ChangingEventArgs e)
        {
            foreach (ConsoleProfile consoleProfile in MainWindow.Settings.ConsoleProfiles.FindAll(x => x.TypePrefix == PlatformPrefix.XBOX))
            {
                if (consoleProfile != ConsoleProfile)
                {
                    if (consoleProfile.UseDefaultConsole)
                    {
                        e.Cancel = true;
                        XtraMessageBox.Show(this, $"You have already marked: '{consoleProfile.Name}' as your default console.\n\nPlease edit that console and uncheck the 'Use Default' option to mark this one as default.", "Default Console", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    LabelUserPass.Text = @"Default";

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
                XtraMessageBox.Show(this, "You must enter a connection name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsoleAddress.Text))
            {
                XtraMessageBox.Show(this, ConsoleProfile.TypePrefix == PlatformPrefix.PS3 ? "You must enter an IP Address." : "You must enter an IP Address or Console Name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (ConsoleProfile.UseDefaultCredentials)
            {
                case true when ConsoleProfile.TypePrefix == PlatformPrefix.PS3:
                    ConsoleProfile.Username = "anonymous";
                    ConsoleProfile.Password = "anonymous";
                    break;
                case true when ConsoleProfile.TypePrefix == PlatformPrefix.XBOX:
                    ConsoleProfile.Username = "xboxftp";
                    ConsoleProfile.Password = "xboxftp";
                    break;
            }

            bool isAddressValid = ConsoleProfile.TypePrefix == PlatformPrefix.XBOX ? true : IPAddress.TryParse(TextBoxConsoleAddress.Text, out _);

            switch (isAddressValid)
            {
                case true:
                    {
                        switch (IsEditingProfile)
                        {
                            case true when ConsoleProfile.Name != TextBoxConnectionName.Text && ProfileExists(TextBoxConnectionName.Text):
                                XtraMessageBox.Show(this, "A console with this name already exists.", "Console Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case true:
                                ConsoleProfile.Name = TextBoxConnectionName.Text;
                                ConsoleProfile.Address = TextBoxConsoleAddress.Text;
                                DialogResult = DialogResult.OK;
                                break;
                            default:
                                {
                                    if (ProfileExists(TextBoxConnectionName.Text))
                                    {
                                        XtraMessageBox.Show(this, "A console with this name already exists.", "Console Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        ConsoleProfile.Name = TextBoxConnectionName.Text;
                                        ConsoleProfile.Address = TextBoxConsoleAddress.Text;
                                        DialogResult = DialogResult.OK;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
                default:
                    XtraMessageBox.Show(this, "IP Address isn't the correct format.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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