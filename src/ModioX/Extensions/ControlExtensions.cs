using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class ControlExtensions
    {
        /// <summary>
        ///     Change button text and auto size
        /// </summary>
        /// <param name="ctrl">Control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlTextWidth(Control ctrl, string text)
        {
            ctrl.Text = text;
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int) Math.Round(mySize.Width, 0) + 16;
            ctrl.Refresh();
        }

        public static void SetValuesOnSubItems(List<ToolStripMenuItem> items)
        {
            items.ForEach(item =>
            {
                var dropdown = (ToolStripDropDownMenu)item.DropDown;
                if (dropdown != null)
                {
                    dropdown.ShowImageMargin = false;
                    SetValuesOnSubItems(item.DropDownItems.OfType<ToolStripMenuItem>().ToList());
                }
            });
        }
    }
}