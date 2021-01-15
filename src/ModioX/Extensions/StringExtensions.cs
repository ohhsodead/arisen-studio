using System;
using System.IO;

namespace ModioX.Extensions
{
    internal static class StringExtensions
    {
        // Load all suffixes in an array
        private static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

        public static string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

        public static int IndexOfNth(this string str, string value, int nth = 0)
        {
            if (nth < 0)
                throw new ArgumentException("Can not find a negative index of substring in string. Must start with 0");

            var offset = str.IndexOf(value, StringComparison.Ordinal);

            var tries = 0;
            while (offset != -1 && tries < nth)
            {
                offset = str.IndexOf(value, offset + 1, StringComparison.Ordinal);
                tries++;
            }

            return offset;
        }

        public static string RemoveFirstInstanceOfString(this string value, string removeString)
        {
            var index = value.IndexOf(removeString, StringComparison.Ordinal);
            return index < 0 ? value : value.Remove(index, removeString.Length);
        }

        public static string FormatSize(this string bytes)
        {
            var counter = 0;
            decimal number = long.Parse(bytes);
            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }

            return $"{number:n1} {suffixes[counter]}";
        }
    }
}