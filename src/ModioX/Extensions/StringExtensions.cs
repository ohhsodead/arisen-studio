using System;
using System.IO;

namespace ModioX.Extensions
{
    internal static class StringExtensions
    {
        public static string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

        public static int IndexOfNth(this string str, string value, int nth = 0)
        {
            if (nth < 0)
            {
                throw new ArgumentException("Can not find a negative index of substring in string. Must start with 0");
            }

            var offset = str.IndexOf(value);
            for (var i = 0; i < nth; i++)
            {
                if (offset == -1)
                {
                    return -1;
                }

                offset = str.IndexOf(value, offset + 1);
            }

            return offset;
        }

        public static string RemoveFirstInstanceOfString(this string value, string removeString)
        {
            int index = value.IndexOf(removeString, StringComparison.Ordinal);
            return index < 0 ? value : value.Remove(index, removeString.Length);
        }

        // Load all suffixes in an array  
        static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

        public static string FormatSize(this string bytes)
        {
            int counter = 0;
            decimal number = long.Parse(bytes);
            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }
            return string.Format("{0:n1} {1}", number, suffixes[counter]);
        }
    }
}