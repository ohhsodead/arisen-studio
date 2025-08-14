using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System;
using System.Data;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ArisenStudio.Models.Resources;
using System.Drawing;
using Humanizer;
using ArisenStudio.Models.Database;

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

        public DatabaseClient Database = MainWindow.Database;

        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;

        public TrainerGameItem TrainerGameData = null;

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
                    _ = DataTableCheats.Rows.Add(
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
                ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");
                ButtonHelp.Text = Language.GetString("LABEL_HELP_SUPPORT");

                ButtonInstall.Enabled = MainWindow.IsConsoleConnected || MainWindow.Settings.InstallGameModsToUsbDevice;
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load trainers cheats.", ex);
                _ = XtraMessageBox.Show(this, string.Format("Unable to load game trainers. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _ = XtraMessageBox.Show(this, "Unable to install trainer. Error: " + ex.Message, Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
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