using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class ControlExtensions
    {
        public static Label GetCategoryTitle()
        {
            return new Label()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false,
                Margin = new Padding(0, 0, 0, 0),
                Padding = new Padding(2, 0, 0, 0),
                Font = new Font("Segoe UI", 9F),
                Cursor = Cursors.Hand,
                BackColor = Color.FromArgb(38, 38, 38),
                ForeColor = Color.Gainsboro,
                AutoEllipsis = true,
            };
        }

        /// <summary>
        /// Change button size to fit text and resizes to fit content.
        /// </summary>
        /// <param name="ctrl">Control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlTextWidth(Control ctrl, string text)
        {
            ctrl.Text = text;
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int)Math.Round(mySize.Width, 0) + 16;
            ctrl.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public static void SetValuesOnSubItems(List<ToolStripMenuItem> items)
        {
            items.ForEach(item =>
            {
                if (item.DropDown is not ToolStripDropDownMenu dropdown) return;

                dropdown.ShowImageMargin = false;
                SetValuesOnSubItems(item.DropDownItems.OfType<ToolStripMenuItem>().ToList());
            });
        }
    }
}