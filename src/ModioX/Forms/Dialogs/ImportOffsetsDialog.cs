using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Humanizer;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;

namespace ModioX.Forms.Dialogs
{
    public partial class ImportOffsetsDialog : XtraForm
    {
        public ImportOffsetsDialog()
        {
            InitializeComponent();
        }

        public ModsOffsetValues ModsOffsetValues { get; set; } = new();

        public List<OffsetValue> OffsetsValues { get; set; } = new();

        private void ImportOffsetsDialog_Load(object sender, EventArgs e)
        {
            ComboBoxConsoleType.SelectedItem = ModsOffsetValues.ConsoleType.Humanize();
            UpdateCodes();
        }

        private readonly DataTable DataTableCodes = DataExtensions.CreateDataTable(new List<DataColumn>
            {
                new("Offset"),
                new("Value")
            });

        private void UpdateCodes()
        {
            GridControlMemoryOffsets.DataSource = null;

            foreach (OffsetValue offsetValues in OffsetsValues)
            {
                DataTableCodes.Rows.Add(
                    offsetValues.Offset,
                    offsetValues.Value);
            }

            GridControlMemoryOffsets.DataSource = DataTableCodes;
        }

        private void TextBoxName_EditValueChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = !string.IsNullOrWhiteSpace(TextBoxName.Text) && !string.IsNullOrWhiteSpace(TextBoxGame.Text);
        }

        private void TextBoxGame_EditValueChanged(object sender, EventArgs e)
        {
            ButtonSave.Enabled = !string.IsNullOrWhiteSpace(TextBoxName.Text) && !string.IsNullOrWhiteSpace(TextBoxGame.Text);
        }

        private void ComboBoxConsoleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModsOffsetValues.ConsoleType = ComboBoxConsoleType.SelectedIndex == 0 ? PlatformPrefix.PS3 : PlatformPrefix.XBOX;
        }

        private void ButtonAddCode_Click(object sender, EventArgs e)
        {
            OffsetValue offsetValue = DialogExtensions.ShowImportOffsetsValuesDialog(this, new());

            if (offsetValue != null)
            {
                OffsetsValues.Add(offsetValue);
                UpdateCodes();
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include a name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxGame.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include a game title.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<OffsetValue> offsetValues = new();

            for (int i = 0; i < GridViewMemoryOffsets.DataRowCount; i++)
            {
                OffsetValue offsetValue = new();

                offsetValue.Offset = GridViewMemoryOffsets.GetRowCellDisplayText(i, "Offset");
                offsetValue.Value = GridViewMemoryOffsets.GetRowCellDisplayText(i, "Value");

                offsetValues.Add(offsetValue);
            }

            ModsOffsetValues.OffsetsValues = offsetValues;

            MainWindow.Settings.UpdateOffsetValues(ModsOffsetValues);
            Close();
        }
    }
}