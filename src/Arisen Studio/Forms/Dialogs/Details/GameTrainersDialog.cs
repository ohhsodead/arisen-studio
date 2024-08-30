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
using Humanizer;
using DevExpress.XtraCharts.Native;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class GameTrainersDialog : XtraForm
    {
        public GameTrainersDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings = MainWindow.Settings;

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public GitHubData Database = MainWindow.Database;

        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;

        public TrainerGameData TrainerGameData = null;

        public TrainerItem SelectedTrainerItem = null;

        private DataTable DataTableCheats { get; } = DataExtensions.CreateDataTable(
            [
                new("Url", typeof(string)),
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
                LabelGame.Text = MainWindow.Database.TitleIdsX360.GetTitleFromTitleId(TrainerGameData.TitleId);
                LabelTitleId.Text = "(" + TrainerGameData.TitleId + ")";

                DataTableCheats.Rows.Clear();

                foreach (TrainerItem trainer in TrainerGameData.Trainers)
                {
                    DataTableCheats.Rows.Add(
                        trainer.Url,
                        trainer.Name,
                        trainer.Type,
                        Settings.UseRelativeTimes ? trainer.LastUpdated.Humanize() : trainer.LastUpdated,
                        trainer.InstallPaths.Count());
                }

                GridControlTrainers.DataSource = DataTableCheats;

                GridViewTrainers.Columns[0].Visible = false;

                //GridViewTrainers.Columns[1].MinWidth = 112;
                //GridViewTrainers.Columns[1].MaxWidth = 112;

                GridViewTrainers.Columns[2].MinWidth = 82;
                GridViewTrainers.Columns[2].MaxWidth = 82;

                GridViewTrainers.Columns[3].MinWidth = 124;
                GridViewTrainers.Columns[3].MaxWidth = 124;

                GridViewTrainers.Columns[4].MinWidth = 92;
                GridViewTrainers.Columns[4].MaxWidth = 92;

                SelectedTrainerItem = TrainerGameData.Trainers[0];

                ButtonDownload.Text = Language.GetString("LABEL_DOWNLOAD");
                ButtonInstall.Text = Language.GetString("LABEL_INSTALL");
                ButtonReportIssue.Text = Language.GetString("LABEL_REPORT_ISSUE");

                ButtonInstall.Enabled = MainWindow.IsConsoleConnected || MainWindow.Settings.InstallGameModsToUsbDevice;
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load trainers cheats.", ex);
                XtraMessageBox.Show(this, string.Format("Unable to load game trainers. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridViewCheats_RowClick(object sender, RowClickEventArgs e)
        {
            var selectedRow = (string)GridViewTrainers.GetRowCellValue(e.RowHandle, GridViewTrainers.Columns[0]);
            SelectedTrainerItem = Database.TrainersX360.GetTrainerByUrl(selectedRow);
        }

        private void GridViewCheats_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonInstall.Enabled = GridViewTrainers.SelectedRowsCount > 0;
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.DownloadTrainer, TrainerGameData, SelectedTrainerItem);
        }

        private void ButtonInstallTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogExtensions.ShowTransferFilesDialog(this, TransferType.InstallTrainer, TrainerGameData, SelectedTrainerItem);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Unable to install trainer. Error: " + ex.Message, Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder()
                .Append("You will now be redirected to our GitHub Issues page for ArisenStudio. All details will be automatically filled for you. Please provide information about the issue to help us fix your problem.\n")
                .AppendLine("Click the 'Submit' button to open a new issue which can help us fix any problems.");

            XtraMessageBox.Show(message.ToString(), "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //GitHubTemplates.OpenReportTemplateGameCheat(GameCheatItem, SelectedCheatItem, SelectedCheatItem.Offsets[GridViewTrainers.FocusedRowHandle]);
        }

        private string ApplyCheat(Offsets offsets, string lastReturn)
        {
            try
            {
                //if (offsets.Opcode == "00002000")
                //{
                //    uint offset = Convert.ToUInt32(offsets.Offset, 16);
                //    uint value = Convert.ToUInt32(offsets.Value, 16);

                //    if ((int)offset == 0)
                //    {
                //        offset = Convert.ToUInt32(lastReturn, 16);
                //    }

                //    PS3.PS3MAPI.Extension.WriteInt32(offset, (int)value);
                //}
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
            e.Graphics.DrawPath(pen, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 6));
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Brush brush = new SolidBrush(BackColor);
            e.Graphics.FillPath(brush, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 6));
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