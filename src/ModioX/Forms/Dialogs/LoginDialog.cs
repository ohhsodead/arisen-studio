using System;
using DarkUI.Forms;

namespace ModioX.Forms
{
    public partial class LoginDialog : DarkForm
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxUsername.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxPassword.Text);
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxUsername.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxPassword.Text);
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