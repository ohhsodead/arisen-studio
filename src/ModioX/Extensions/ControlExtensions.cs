using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class ControlExtensions
    {
        /// <summary>
        /// Set control width to fit the text content.
        /// </summary>
        /// <param name="ctrl"> Control to set text </param>
        /// <param name="text"> Text to set to control </param>
        public static void SetControlTextWidth(this Control ctrl, int extra = 0)
        {
            Font myFont = new(ctrl.Font.FontFamily, ctrl.Font.Size);
            SizeF mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int)Math.Round(mySize.Width, 0) + 19 + extra;
            ctrl.Refresh();
        }

        public static void SetDoubleBuffered(this Control panel)
        {
            typeof(Control).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               panel,
               new object[] { true });
        }
    }
}