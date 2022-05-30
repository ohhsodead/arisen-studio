using DevExpress.Utils.Drawing;
using DevExpress.XtraSplashScreen;
using System.Drawing;

namespace NeoModsX.Controls
{
    internal class FeatureNotAvailableOverlay : OverlayWindowPainterBase
    {
        // Defines the string’s font.
        readonly Font drawFont;

        // Defines the string's message.
        readonly string messageString;

        public FeatureNotAvailableOverlay(string message)
        {
            drawFont = new Font("Segoe UI", 14.5F);
            messageString = message;
        }

        protected override void Draw(OverlayWindowCustomDrawContext context)
        {
            //The Handled event parameter should be set to true. 
            //to disable the default drawing algorithm. 
            context.Handled = true;
            //Provides access to the drawing surface. 
            GraphicsCache cache = context.DrawArgs.Cache;
            //Adjust the TextRenderingHint option
            //to improve the image quality.
            cache.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //Overlapped control bounds. 
            Rectangle bounds = context.DrawArgs.Bounds;
            //Draws the default background. 
            context.DrawBackground();
            //Specify the string that will be drawn on the Overlay Form instead of the wait indicator.
            //string drawString = "You must have webMAN installed to use this feature.";
            //Get the system's black brush.
            Brush drawBrush = Brushes.Gainsboro;
            //Calculate the size of the message string.
            SizeF textSize = cache.CalcTextSize(messageString, drawFont);
            //A point that specifies the upper-left corner of the rectangle where the string will be drawn.
            PointF drawPoint = new(bounds.Left + (bounds.Width / 2) - (textSize.Width / 2),
                                   bounds.Top + (bounds.Height / 2) - (textSize.Height / 2));
            //Draw the string on the screen.
            cache.DrawString(messageString, drawFont, drawBrush, drawPoint);
        }
    }
}