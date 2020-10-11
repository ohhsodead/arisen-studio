using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.Linq.Expressions;
using System.Net;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class NewConnectionDialog : DarkForm
    {
        public NewConnectionDialog()
        {
            InitializeComponent();
        }

        public ConsoleProfile ConsoleProfile = new ConsoleProfile();
        public bool IsEditingConsole = false;

        private void ConsolesWindow_Load(object sender, EventArgs e)
        {
            TextBoxConnectionName.Text = ConsoleProfile.Name;
            TextBoxConsoleAddress.Text = ConsoleProfile.Address;
            TextBoxConsolePort.Text = ConsoleProfile.Port.ToString();

            LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials ? "Default" : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            TextBoxConnectionName.SelectionStart = 0;
        }

        private static bool ProfileExists(string name)
        {
            foreach (ConsoleProfile console in MainWindow.SettingsData.ConsoleProfiles)
            {
                if (console.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

        private void ButtonChangeCredentials_Click(object sender, EventArgs e)
        {
            using (LoginDialog consoleCredentials = new LoginDialog())
            {
                DialogResult setCredentials = consoleCredentials.ShowDialog(this);

                if (setCredentials == DialogResult.OK)
                {
                    LabelUserPass.Text = ConsoleProfile.Username + " / " + ConsoleProfile.Password;

                    ConsoleProfile.Username = consoleCredentials.TextBoxUsername.Text;
                    ConsoleProfile.Password = consoleCredentials.TextBoxPassword.Text;
                    ConsoleProfile.UseDefaultCredentials = false;
                }
                else if (setCredentials == DialogResult.Abort)
                {
                    LabelUserPass.Text = "Default";

                    ConsoleProfile.Username = "";
                    ConsoleProfile.Password = "";
                    ConsoleProfile.UseDefaultCredentials = true;
                }
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxConnectionName.Text))
            {
                _ = DarkMessageBox.Show(this, @"You must enter a connection name.", "Error", MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TextBoxConsoleAddress.Text))
            {
                _ = DarkMessageBox.Show(this, @"You must enter an IP Address.", "Error", MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TextBoxConsolePort.Text))
            {
                _ = DarkMessageBox.Show(this, @"Please enter a port value. The default value is 21.", "Error", MessageBoxIcon.Error);
                return;
            }


            bool isAddressValid = IPAddress.TryParse(TextBoxConsoleAddress.Text, out IPAddress address);
            bool isPortValid = int.TryParse(TextBoxConsolePort.Text, out int port);

            if (isAddressValid)
            {
                if (isPortValid)
                {
                    if (IsEditingConsole)
                    {
                        ConsoleProfile.Name = TextBoxConnectionName.Text;
                        ConsoleProfile.Address = address.ToString();
                        ConsoleProfile.Port = port;
                        Close();
                    }
                    else
                    {
                        if (ProfileExists(TextBoxConnectionName.Text))
                        {
                            _ = DarkMessageBox.Show(this, @"A console with this connection name already exists.", "Connection 3 Exists", MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            ConsoleProfile.Name = TextBoxConnectionName.Text;
                            ConsoleProfile.Address = address.ToString();
                            ConsoleProfile.Port = port;
                            Close();
                        }
                    }
                }
                else
                {
                    _ = DarkMessageBox.Show(this, @"Port isn't an integer value.", "Invalid Port", MessageBoxIcon.Error);
                }
            }
            else
            {
                _ = DarkMessageBox.Show(this, @"IP Address isn't in the correct format. Make sure it's copied exactly from the System Information displayed on your console.", "Invalid IP Address", MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}