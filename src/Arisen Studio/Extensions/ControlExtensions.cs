using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArisenStudio.Extensions
{
    internal static class ControlExtensions
    {
        /// <summary>
        /// Set control width to fit the text content.
        /// </summary>
        /// <param name="ctrl"> Control to set text </param>
        /// <param name="extra"> Extra padding to the width </param>
        public static void SetControlTextWidth(this Control ctrl, int extra = 0)
        {
            Font myFont = new(ctrl.Font.FontFamily, ctrl.Font.Size);
            SizeF mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int)Math.Round(mySize.Width, 0) + 19 + extra;
            ctrl.Refresh();
        }

        //public static void SetTileItemStatus(this, TileItem tileItem, bool enabled)
        //{
        //    if (tileItem != null && (!tileItem.Enabled))
        //    {
        //        using (var img = new Bitmap(tileItem.Image, tileItem.ClientSize))
        //        {
        //            ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pict.BackColor);
        //        }
        //    }
        //}

        //public static void SetTileItemStatus(this, TileItem tileItem, bool enabled)
        //{
        //    if (tileItem != null && (!tileItem.Enabled))
        //    {
        //        using (var img = new Bitmap(tileItem.Image, tileItem.ClientSize))
        //        {
        //            ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pict.BackColor);
        //        }
        //    }
        //}
    }
}