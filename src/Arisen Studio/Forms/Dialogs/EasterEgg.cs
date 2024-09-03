using DevExpress.XtraEditors;
using ArisenStudio.Extensions;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class EasterEgg : XtraForm
    {
        public EasterEgg()
        {
            InitializeComponent();
        }

        private void EasterEgg_Load(object sender, EventArgs e)
        {
            _ = ImageEasterEgg.LoadAsync("https://arisen.studio/images/slots-event.gif");
        }

        private void ImageEasterEgg_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://arisen.studio/images/slots-event.gif");
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