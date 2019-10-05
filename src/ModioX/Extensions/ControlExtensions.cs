using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal abstract class ControlExtensions
    {
        /// <summary>
        /// Change button text and auto size
        /// </summary>
        /// <param name="ctrl">Control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlTextWidth(Control ctrl, string text)
        {
            ctrl.Text = text;
            Font myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            SizeF mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int)Math.Round(mySize.Width, 0) + 16;
            ctrl.Refresh();
        }
    }
}