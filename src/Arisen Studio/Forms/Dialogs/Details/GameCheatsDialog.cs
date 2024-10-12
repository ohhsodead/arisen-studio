using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Controls;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Drawing;
using ArisenStudio.Constants;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using PS3Lib;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class GameCheatsDialog : XtraForm
    {
        public GameCheatsDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;

        public static PS3API PS3 = new();

        public GameItemData GameItem = null;

        public GameCheatsData GameCheats = null;

        private Cheats SelectedCheatItem = null;


        private DataTable DataTableCheats { get; } = DataExtensions.CreateDataTable(
            [
                new("Name", typeof(string))
            ]);

        private async void GameCheatsDialog_Load(object sender, EventArgs e)
        {
            try
            {
                GridViewCheats.ShowLoadingPanel();

                GameCheats = await GetGameCheatsPS3(GameItem.File);

#if !DEBUG
                try
                {

                    PS3 = new(SelectAPI.PS3Manager);
                    PS3.ConnectTarget(ConsoleProfile.Address);
                    PS3.AttachProcess();
                }
                catch (Exception ex)
                {
                    Program.Log.Error("Unable to connect or attach using webMAN API.", ex);
                    XtraMessageBox.Show(this, string.Format("Unable to connect or attach using webMAN. You must have PS3MAPI enabled in your webMAN settings. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
#endif

                LabelGame.Text = GameItem.Game;
                LabelVersion.Text = "- " + GameItem.Version;
                LabelRegion.Text = $"({GameItem.Region})";

                DataTableCheats.Rows.Clear();

                foreach (var cheat in GameCheats.Cheats)
                {
                    DataTableCheats.Rows.Add(cheat.Name);
                }

                GridControlCheats.DataSource = DataTableCheats;

                GridViewCheats.HideLoadingPanel();

                ButtonApplyCheat.Text = Language.GetString("LABEL_APPLY_CHEAT");
                ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");
                ButtonHelp.Text = Language.GetString("LABEL_HELP_SUPPORT");
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load game cheats.", ex);
                XtraMessageBox.Show(this, string.Format("Unable to load game cheats. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private readonly HttpClient _httpClient = new();

        ///// <summary>
        ///// URL pointing to the Game Cheats database file for PS3.
        ///// </summary>
        //internal const string GamesCheatsBasePS3 = "https://db.arisen.studio/data/ps3/cheats/game-cheats/";

        public async Task<GameCheatsData> GetGameCheatsPS3(string fileName)
        {
            //_httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("ArisenStudioDatabase");

            //string response = await _httpClient.GetStringAsync(Urls.GamesCheatsBasePS3 + fileName);
            string response = await _httpClient.GetStringAsync("https://raw.githubusercontent.com/ohhsodead/game-cheats/refs/heads/main/PS3/" + fileName);
            return JsonConvert.DeserializeObject<GameCheatsData>(response);
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridViewCheats_RowClick(object sender, RowClickEventArgs e)
        {
            SelectedCheatItem = GameCheats.Cheats[e.RowHandle];

            ButtonApplyCheat.Enabled = e.RowHandle != -1;
        }

        private void GridViewCheats_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            SelectedCheatItem = GameCheats.Cheats[e.FocusedRowHandle];

            ButtonApplyCheat.Enabled = e.FocusedRowHandle != -1;
        }

        private void ButtonApplyCheat_Click(object sender, EventArgs e)
        {
            if (!ContainsUnimplementedOpcodes())
            {
                string lastReturn = "00000000";

                foreach (Offsets cheat in SelectedCheatItem.Offsets)
                {
                    lastReturn = ApplyCheat(cheat, lastReturn);
                }

                _ = XtraMessageBox.Show(this, Language.GetString("CHEAT_APPLIED"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _ = XtraMessageBox.Show(this, Language.GetString("CHEAT_NOT_SUPPORTED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowReportIssueDialog(this);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Urls.WebsiteHelp);
        }

        private bool ContainsUnimplementedOpcodes()
        {
            return SelectedCheatItem.Offsets.Any(x => x.ContainsUnimplementedOpcodes());
        }

        private string ApplyCheat(Offsets offsets, string lastReturn)
        {
            try
            {
                if (offsets.Opcode == "00002000") // Int32
                {
                    uint offset = Convert.ToUInt32(offsets.Offset, 16);
                    uint value = Convert.ToUInt32(offsets.Value, 16);

                    if ((int)offset == 0)
                    {
                        offset = Convert.ToUInt32(lastReturn, 16);
                    }

                    PS3.Extension.WriteInt32(offset, (int)value);
                }
                else if (offsets.Opcode == "00002000")
                {
                    if (offsets.ValueType.ContainsIgnoreCase("AOB")) // Array of Bytes
                    {
                        uint offset = Convert.ToByte(offsets.Offset, 16);
                        byte[] value = Extensions.StringExtensions.HexStringToBytes(offsets.Value);

                        if ((int)offset == 0)
                        {
                            offset = Convert.ToUInt32(lastReturn, 16);
                        }

                        PS3.Extension.WriteBytes(offset, value);
                    }
                }
            }
            catch (Exception ex)
            {
                _ = XtraMessageBox.Show(this, string.Format(Language.GetString("CHEAT_NOT_APPLIED"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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