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
            _ = ImageEasterEgg.LoadAsync("https://db.arisen.studio/images/slots-event.gif");
            _ = XtraMessageBox.Show(this, "Congrats! You found our little easter egg!\n\nFor those who don't know, on this date our Arisen Studio Discord Server hosted a first of its kind game using the simple concept of the Slots Machine. You type and enter the '.slot' command to roll your slot machine and the our bot responds with your randomly generated results.\nSo, for the next 10 minutes it was complete carnage and we felt like we nearly broke Discord, but it was so much fun!\nWe still do run the game sometimes so if you would like to play (or just watch) the mess of the channel then you're welcome to join us!", "Found Easter Egg <3");
        }

        private void ImageEasterEgg_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://db.arisen.studio/images/slots-event.gif");
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