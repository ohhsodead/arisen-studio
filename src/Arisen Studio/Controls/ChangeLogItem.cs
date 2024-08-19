using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Forms.Windows;
using System;
using System.Diagnostics;
using System.Globalization;
using ArisenStudio.Extensions;
using System.Drawing;
using System.Windows.Forms;

namespace ArisenStudio.Controls
{
    public partial class ChangeLogItem : XtraUserControl
    {
        public ChangeLogItem(string version, string changeLog, DateTime timeStamp)
        {
            InitializeComponent();
            LabelVersion.Text = version;
            LabelChangeLog.Text = changeLog;
            LabelTimeStamp.Text = MainWindow.Settings.UseRelativeTimes ? timeStamp.Humanize() : timeStamp.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
        }

        private void ChangeLogItem_Load(object sender, EventArgs e)
        {

        }

        private void LabelMessage_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
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
    }
}