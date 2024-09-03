using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using PS3Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;
//using JRPC_Client;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class GamePatchesDialog : XtraForm
    {
        public GamePatchesDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        //public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        public GamePatchItemData GamePatchItem = null;

        private DataTable DataTablePatch { get; } = DataExtensions.CreateDataTable(
            [
                new("Name", typeof(string)),
                new("Author", typeof(string)),
                //new("Enabled", typeof(string))
            ]);

        private void GamePatchesDialog_Load(object sender, EventArgs e)
        {
            //if (!JRPC.Connect(MainWindow.XboxConsole, out _))
            //{
            //    XtraMessageBox.Show(this, "You must have JRPC2 module set as a plugin on your console.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Close();
            //}

            DataTablePatch.Rows.Clear();

            // Display details in UI
            LabelGame.Text = GamePatchItem.TitleName;
            LabelRegion.Text = $"({GamePatchItem.TitleId})";

            foreach (Patch patch in GamePatchItem.Patch)
            {
                _ = DataTablePatch.Rows.Add(patch.Name, patch.Author);
            }

            GridControlCheats.DataSource = DataTablePatch;

            SelectedPatchItem = GamePatchItem.Patch[0];

            GridViewCheats.Columns[1].MinWidth = 130;
            GridViewCheats.Columns[1].MaxWidth = 130;

            ButtonApplyCheat.Text = Language.GetString("LABEL_APPLY_CHEAT");
            ButtonReportIssue.Text = Language.GetString("LABEL_REPORT_ISSUE");
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridViewCheats_RowClick(object sender, RowClickEventArgs e)
        {
            SelectedPatchItem = GamePatchItem.Patch[e.RowHandle];
            //MessageBox.Show(SelectedPatchItem.Name);
        }

        private void GridViewCheats_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonApplyCheat.Enabled = GridViewCheats.SelectedRowsCount > 0;
            SelectedPatchItem = GridViewCheats.SelectedRowsCount > 0 ? GamePatchItem.Patch[e.FocusedRowHandle] : null;
        }

        private Patch SelectedPatchItem { get; set; } = null;

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedPatchItem == null)
                {
                    _ = XtraMessageBox.Show(this, "SelectedPatchItem is null", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (SelectedPatchItem.Be8 != null)
                    {
                        foreach (Be8 be8 in SelectedPatchItem.Be8)
                        {
                            //MainWindow.XboxConsole.WriteUInt32(Convert.ToUInt32(be8.Address), BitConverter.GetBytes(be8.Value));
                            //MainWindow.XboxConsole.WriteBytes(Convert.ToUInt32(be8.Address), BitConverter.GetBytes(be8.Value));
                            //MainWindow.XboxConsole.WriteInt16(Convert.ToUInt16(be8.Address), BitConverter.GetBytes(be8.Value));
                            //MainWindow.XboxConsole.SetMemory((byte)be8.Address, BitConverter.GetBytes(be8.Value));

                            MainWindow.XboxConsole.WriteByte(be8.Address, be8.Value);
                        }
                    }

                    if (SelectedPatchItem.Be16 != null)
                    {
                        foreach (Be16 be16 in SelectedPatchItem.Be16)
                        {
                            //MainWindow.XboxConsole.WriteUInt32(Convert.ToUInt32(be16.Address), be16.Value));
                            //MainWindow.XboxConsole.WriteByte(Convert.ToUInt32(be16.Address), BitConverter.GetBytes(be16.Value));
                            //MainWindow.XboxConsole.SetMemory((ushort)be16.Address, BitConverter.GetBytes(be16.Value));

                            MainWindow.XboxConsole.WriteUInt16(be16.Address, be16.Value);
                        }
                    }

                    if (SelectedPatchItem.Be32 != null)
                    {
                        foreach (Be32 be32 in SelectedPatchItem.Be32)
                        {
                            //byte[] bytes = BitConverter.GetBytes(be32.Value);

                            //if (BitConverter.IsLittleEndian)
                            //{
                            //    Array.Reverse(bytes);
                            //}

                            //MainWindow.XboxConsole.WriteUInt32(Convert.ToUInt32(be32.Address), BitConverter.GetBytes(be32.Value));
                            //MainWindow.XboxConsole.WriteUInt32((uint)be32.Address, Convert.ToByte(be32.Value));
                            //MainWindow.XboxConsole.SetMemory((uint)be32.Address, BitConverter.GetBytes(be32.Value));
                            //MainWindow.XboxConsole.SetMemory((uint)be32.Address, bytes);

                            MainWindow.XboxConsole.WriteUInt32(be32.Address, be32.Value);
                        }
                    }

                    _ = XtraMessageBox.Show(this, Language.GetString("CHEAT_APPLIED"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to apply cheat for Xbox 360. Error: " + ex.Message, ex);
                _ = XtraMessageBox.Show(this, string.Format(Language.GetString("CHEAT_NOT_APPLIED"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if (!IsEnabled(SelectedPatchItem))
            //{

            //}
            //else
            //{
            //    //XtraMessageBox.Show(this, Language.GetString("CHEAT_NOT_SUPPORTED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder()
                .Append("You will now be redirected to our GitHub Issues page for ArisenStudio. All details will be automatically filled for you. Please provide information about the issue to help us fix your problem.\n")
                .AppendLine("Click the 'Submit' button to open a new issue which can help us fix any problems.");

            _ = XtraMessageBox.Show(message.ToString(), "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //GitHubTemplates.OpenReportTemplateGameCheat(GameCheatItem, SelectedCheatItem, SelectedCheatItem.Offsets[GridViewCheats.FocusedRowHandle]);
        }

        private bool IsEnabled(Patch patch)
        {
            return patch.IsEnabled;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}