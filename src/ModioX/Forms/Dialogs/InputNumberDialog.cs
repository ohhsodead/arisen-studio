using System;
using System.IO;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    public partial class InputNumberDialog : XtraForm
    {
        public InputNumberDialog()
        {
            InitializeComponent();
        }

        private void InputNumberDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBoxName_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(SpinEditValue.Text);
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