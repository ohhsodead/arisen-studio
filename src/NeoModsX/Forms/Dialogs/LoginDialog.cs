using DevExpress.XtraEditors;
using NeoModsX.Forms.Windows;
using System;

namespace NeoModsX.Forms.Dialogs
{
    public partial class LoginDialog : XtraForm
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            Text = MainWindow.ResourceLanguage.GetString("LABEL_LOGIN_DETAILS");

            LabelUsername.Text = MainWindow.ResourceLanguage.GetString("LABEL_USERNAME") + ":";
            LabelPassword.Text = MainWindow.ResourceLanguage.GetString("LABEL_PASSWORD") + ":";

            ButtonUseDefault.Text = MainWindow.ResourceLanguage.GetString("LABEL_USE_DEFAULT");
            ButtonOK.Text = MainWindow.ResourceLanguage.GetString("LABEL_OK");
            ButtonCancel.Text = MainWindow.ResourceLanguage.GetString("LABEL_CANCEL");
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