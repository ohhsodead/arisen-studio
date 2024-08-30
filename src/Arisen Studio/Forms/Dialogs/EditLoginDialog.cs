using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class EditLoginDialog : XtraForm
    {
        public EditLoginDialog()
        {
            InitializeComponent();
        }

        private void EditLoginDialog_Load(object sender, EventArgs e)
        {
            Text = MainWindow.ResourceLanguage.GetString("LABEL_EDIT_LOGIN_CREDENTIALS");

            LabelUsername.Text = MainWindow.ResourceLanguage.GetString("LABEL_USERNAME") + ":";
            LabelPassword.Text = MainWindow.ResourceLanguage.GetString("LABEL_PASSWORD") + ":";

            ButtonUseDefault.Text = MainWindow.ResourceLanguage.GetString("LABEL_USE_DEFAULT");
            ButtonSave.Text = MainWindow.ResourceLanguage.GetString("LABEL_SAVE");
            ButtonCancel.Text = MainWindow.ResourceLanguage.GetString("LABEL_CANCEL");
        }

        private void TextBoxUsername_EditValueChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = !string.IsNullOrWhiteSpace(TextBoxUsername.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxPassword.Text);
        }

        private void TextBoxPassword_EditValueChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = !string.IsNullOrWhiteSpace(TextBoxUsername.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxPassword.Text);
        }
    }
}