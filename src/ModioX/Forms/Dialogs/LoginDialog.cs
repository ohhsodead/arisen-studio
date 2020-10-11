using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.Net;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class LoginDialog : DarkForm
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void ConsoleCredentials_Load(object sender, EventArgs e)
        {
            
        }


        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrEmpty(TextBoxUsername.Text) && !string.IsNullOrEmpty(TextBoxPassword.Text);
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrEmpty(TextBoxUsername.Text) && !string.IsNullOrEmpty(TextBoxPassword.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonUseDefault_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}