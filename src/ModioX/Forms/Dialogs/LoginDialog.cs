using System;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    public partial class LoginDialog : XtraForm
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void TextBoxUsername_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxUsername.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxPassword.Text);
        }

        private void TextBoxPassword_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxUsername.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxPassword.Text);
        }
    }
}