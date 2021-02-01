using System;
using System.IO;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    public partial class InputTextDialog : XtraForm
    {
        public InputTextDialog()
        {
            InitializeComponent();
        }

        private void InputTextDialog_Load(object sender, EventArgs e)
        {
            try
            {
                if (Path.HasExtension(TextBoxName.Text))
                {
                    TextBoxName.Select(0, TextBoxName.Text.IndexOf(Path.GetExtension(TextBoxName.Text)));
                }
            }
            catch { }
        }

        private void TextBoxName_EditValueChanged(object sender, EventArgs e)
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