using System;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ArisenStudio.Extensions
{
    internal static class GraphicExtensions
    {
        public static GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Calculate new radius
            int newRadius = radius / 2;
            int newDiameter = newRadius * 2;

            // Top-left arc
            path.AddArc(rect.X, rect.Y, newDiameter, newDiameter, 180, 90);

            // Top-right arc
            path.AddArc(rect.Right - newDiameter, rect.Y, newDiameter, newDiameter, 270, 90);

            // Bottom-right arc
            path.AddArc(rect.Right - newDiameter, rect.Bottom - newDiameter, newDiameter, newDiameter, 0, 90);

            // Bottom-left arc
            path.AddArc(rect.X, rect.Bottom - newDiameter, newDiameter, newDiameter, 90, 90);

            path.CloseFigure();
            return path;
        }

    }
}
