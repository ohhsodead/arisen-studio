using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ArisenStudio.Extensions
{
    internal static class ImageExtensions
    {
        public static Bitmap Resize(this Bitmap bmp, int width, int height)
        {
            Bitmap result = new(width, height);
            using Graphics g = Graphics.FromImage(result);
            g.DrawImage(bmp, 0, 0, width, height);

            return result;
        }

        public static Image ChangeColor(this Image bmp, Color oldColor, Color newColor)
        {
            Bitmap img = (Bitmap)bmp;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixelColor = img.GetPixel(i, j);
                    //img.SetPixel(i, j, newColor);
                    if (pixelColor == oldColor)
                    {
                        img.SetPixel(i, j, newColor);
                    }
                }
            }

            return img;
        }

        public static BitmapSource ConvertBitmap(Bitmap source)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                source.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        }
    }
}