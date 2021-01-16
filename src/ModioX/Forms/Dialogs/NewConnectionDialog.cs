using DarkUI.Forms;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Net;
using System.Windows.Forms;

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
            TextBoxConsoleAddress.Text = ConsoleProfile.Address;
            TextBoxConsolePort.Text = ConsoleProfile.Port.ToString();

            LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials
                ? "Default"
                : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            TextBoxConnectionName.SelectionStart = 0;
        }

        private static bool ProfileExists(string name)
        {
            foreach (var console in MainWindow.Settings.ConsoleProfiles)
                if (console.Name.Equals(name))
                    return true;

            return false;
        }

        private void ButtonChangeCredentials_Click(object sender, EventArgs e)
        {
            using var consoleCredentials = new LoginDialog();
            var setCredentials = consoleCredentials.ShowDialog(this);

            if (setCredentials == DialogResult.OK)
            {
                LabelUserPass.Text = ConsoleProfile.Username + @" / " + ConsoleProfile.Password;

                ConsoleProfile.Username = consoleCredentials.TextBoxUsername.Text;
                ConsoleProfile.Password = consoleCredentials.TextBoxPassword.Text;
                ConsoleProfile.UseDefaultCredentials = false;
            }
            else if (setCredentials == DialogResult.Abort)
            {
                LabelUserPass.Text = @"Default";

                ConsoleProfile.Username = "";
                ConsoleProfile.Password = "";
                ConsoleProfile.UseDefaultCredentials = true;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxConnectionName.Text))
            {
                DarkMessageBox.ShowExclamation("You must enter a connection name.", "Empty Field");
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsoleAddress.Text))
            {
                DarkMessageBox.ShowExclamation("You must enter an IP Address.", "Empty Field");
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsolePort.Text))
            {
                DarkMessageBox.ShowExclamation("You must enter a port value. The default value is 21.", "Empty Field");
                return;
            }


            var isAddressValid = IPAddress.TryParse(TextBoxConsoleAddress.Text, out var address);
            var isPortValid = int.TryParse(TextBoxConsolePort.Text, out var port);

            if (isAddressValid)
            {
                if (isPortValid)
                {
                    if (IsEditingProfile)
                    {
                        if (ConsoleProfile.Name != TextBoxConnectionName.Text && ProfileExists(TextBoxConnectionName.Text))
                        {
                            DarkMessageBox.ShowExclamation("A console with this name already exists.", "Console Name Exists");
                        }
                        else
                        {
                            ConsoleProfile.Name = TextBoxConnectionName.Text;
                            ConsoleProfile.Address = address.ToString();
                            ConsoleProfile.Port = port;
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        if (ProfileExists(TextBoxConnectionName.Text))
                        {
                            DarkMessageBox.ShowExclamation("A console with this name already exists.", "Console Name Exists");
                        }
                        else
                        {
                            ConsoleProfile.Name = TextBoxConnectionName.Text;
                            ConsoleProfile.Address = address.ToString();
                            ConsoleProfile.Port = port;
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    DarkMessageBox.ShowError("Port isn't an integer value.", "Invalid Port");
                }
            }
            else
            {
                DarkMessageBox.ShowError("IP Address isn't the correct format.", "Invalid IP Address");
            }
        }
    }
}