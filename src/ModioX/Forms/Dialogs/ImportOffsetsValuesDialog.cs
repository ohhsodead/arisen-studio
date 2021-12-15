using System;
using DevExpress.XtraEditors;
using ModioX.Models.Resources;

namespace ModioX.Forms.Dialogs
{
    public partial class ImportOffsetsValuesDialog : XtraForm
    {
        public ImportOffsetsValuesDialog()
        {
            InitializeComponent();
        }

        public OffsetValue OffsetValue { get; set; }

        private void ImportOffsetsValuesDialog_Load(object sender, EventArgs e)
        {
            TextBoxOffset.Text = OffsetValue.Offset;
            TextBoxValue.Text = OffsetValue.Value;
        }

        private void TextBoxOffset_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxOffset.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxValue.Text);
        }

        private void TextBoxValue_EditValueChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = !string.IsNullOrWhiteSpace(TextBoxOffset.Text) &&
                               !string.IsNullOrWhiteSpace(TextBoxValue.Text);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            OffsetValue = new() { Offset = TextBoxOffset.Text, Value = TextBoxValue.Text };
        }
    }
}