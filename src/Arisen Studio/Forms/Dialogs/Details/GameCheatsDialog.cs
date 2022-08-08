using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Templates;
using PS3Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using ArisenStudio.Models.Resources;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class GameCheatsDialog : XtraForm
    {
        public GameCheatsDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public static ConsoleProfile ConsoleProfile { get; } = MainWindow.ConsoleProfile;

        public static PS3API PS3 { get; set; }

        public GameCheatItemData GameCheatItem = null;

        private DataTable DataTableCheats { get; } = DataExtensions.CreateDataTable(
            new List<DataColumn>()
            {
                new("Cheat Name", typeof(string))
            });

        private void GameCheatsDialog_Load(object sender, EventArgs e)
        {
            try
            {
                PS3 = new(SelectAPI.TargetManager);
                PS3.ConnectTarget(ConsoleProfile.Address);
                PS3.AttachProcess();

                // Display details in UI
                LabelGame.Text = GameCheatItem.Game;
                LabelVersion.Text = "- " + GameCheatItem.Version;
                LabelRegion.Text = $"({GameCheatItem.Region})";

                DataTableCheats.Rows.Clear();

                foreach (Cheats cheat in GameCheatItem.Cheats)
                {
                    DataTableCheats.Rows.Add(cheat.Name);
                }

                GridControlCheats.DataSource = DataTableCheats;

                ButtonApplyCheat.SetControlText(Language.GetString("LABEL_APPLY_CHEAT"), 26);
                ButtonReportIssue.SetControlText(Language.GetString("LABEL_REPORT_ISSUE"), 26);
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load game cheats.", ex);
                XtraMessageBox.Show(this, string.Format("Unable to load game cheats. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridViewCheats_RowClick(object sender, RowClickEventArgs e)
        {
            SelectedCheatItem = GameCheatItem.Cheats[e.RowHandle];
        }

        private void GridViewCheats_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonApplyCheat.Enabled = GridViewCheats.SelectedRowsCount > 0;
        }

        private Cheats SelectedCheatItem { get; set; }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (!ContainsUnimplementedOpcodes())
            {
                string lastReturn = "00000000";

                foreach (Offsets cheat in SelectedCheatItem.Offsets)
                {
                    lastReturn = ApplyCheat(cheat, lastReturn);
                }

                XtraMessageBox.Show(this, Language.GetString("CHEAT_APPLIED"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, Language.GetString("CHEAT_NOT_SUPPORTED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ContainsUnimplementedOpcodes()
        {
            return SelectedCheatItem.Offsets.Any(x => x.ContainsUnimplementedOpcodes());
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder()
                .Append("You will now be redirected to our GitHub Issues page for ArisenStudio. All details will be automatically filled for you. Please provide information about the issue to help us fix your problem.\n")
                .AppendLine("Click the 'Submit' button to open a new issue which can help us fix any problems.");

            XtraMessageBox.Show(message.ToString(), "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplateGameCheat(GameCheatItem, SelectedCheatItem, SelectedCheatItem.Offsets[GridViewCheats.FocusedRowHandle]);
        }

        private string ApplyCheat(Offsets offsets, string lastReturn)
        {
            try
            {
                if (offsets.Opcode == "00002000")
                {
                    uint offset = Convert.ToUInt32(offsets.Offset, 16);
                    uint value = Convert.ToUInt32(offsets.Value, 16);

                    if ((int)offset == 0)
                    {
                        offset = Convert.ToUInt32(lastReturn, 16);
                    }

                    PS3.PS3MAPI.Extension.WriteInt32(offset, (int)value);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, string.Format(Language.GetString("CHEAT_NOT_APPLIED"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return "00000000";
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