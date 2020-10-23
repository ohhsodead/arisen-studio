using DarkUI.Forms;
using System;

namespace ModioX.Forms
{
    public partial class InputDialog : DarkForm
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxName.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}