using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Templates;
using System;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using ArisenStudio.Models.Resources;
using System.Drawing;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class GameTrainersDialog : XtraForm
    {
        public GameTrainersDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;

        public TrainerItem TrainerItem = null;

        private DataTable DataTableCheats { get; } = DataExtensions.CreateDataTable(
            [
                new("Name", typeof(string)),
                new("Type", typeof(string)),
                new("Last Updated", typeof(string)),
                new("# Files", typeof(string)),
            ]);

        private void GameTrainersDialog_Load(object sender, EventArgs e)
        {
            try
            {
                // Display details in UI
                LabelGame.Text = MainWindow.Database.TitleIdsX360.GetTitleFromTitleId(TrainerItem.TitleId);
                LabelTitleId.Text = "(" + TrainerItem.TitleId + ")";

                DataTableCheats.Rows.Clear();

                foreach (Trainer trainer in TrainerItem.Trainers)
                {
                    DataTableCheats.Rows.Add(
                        trainer.Name,
                        trainer.Type,
                        trainer.LastUpdated,
                        trainer.InstallPaths.Count());
                }

                GridControlCheats.DataSource = DataTableCheats;

                ButtonInstallTrainer.Text = Language.GetString("LABEL_APPLY_CHEAT");
                ButtonReportIssue.Text = Language.GetString("LABEL_REPORT_ISSUE");
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
            ButtonInstallTrainer.Enabled = GridViewCheats.SelectedRowsCount > 0;
        }

        private void ButtonInstallTrainer_Click(object sender, EventArgs e)
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Pen pen = new(Color.Transparent, 0);
            e.Graphics.DrawPath(pen, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 4));
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Brush brush = new SolidBrush(BackColor);
            e.Graphics.FillPath(brush, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 4));
        }

        private const int WmHscroll = 0x114;
        private const int WmVscroll = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WmHscroll || m.Msg == WmVscroll)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
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