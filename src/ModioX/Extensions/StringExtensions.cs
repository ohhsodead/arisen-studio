using System;
using System.IO;

namespace ModioX.Extensions
{
    internal static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="byteCount"></param>
        /// <returns>  </returns>
        public static string FormatBytes(this long byteCount)
        {
            string[] suf = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB

            if (byteCount != 0)
            {
                long bytes = Math.Abs(byteCount);
                int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
                double num = Math.Round(bytes / Math.Pow(1024, place), 1);
                return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
            }

            return "0 " + suf[0];
        }

        /// <summary>
        /// Replace all the invalid characters with the underscore symbol.
        /// </summary>
        /// <param name="fileName">  </param>
        /// <returns>  </returns>
        public static string ReplaceInvalidChars(this string fileName)
        {
            return string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
        }

        /// <summary>
        /// </summary>
        /// <param name="str"> </param>
        /// <param name="value"> </param>
        /// <param name="nth"> </param>
        /// <returns> </returns>
        public static int IndexOfNth(this string str, string value, int nth = 0)
        {
            if (nth < 0)
                throw new ArgumentException("Can not find a negative index of substring in string. Must start with 0");

            int offset = str.IndexOf(value, StringComparison.Ordinal);

            int tries = 0;
            while (offset != -1 && tries < nth)
            {
                offset = str.IndexOf(value, offset + 1, StringComparison.Ordinal);
                tries++;
            }

            return offset;
        }

        /// <summary>
        /// </summary>
        /// <param name="value"> </param>
        /// <param name="removeString"> </param>
        /// <returns> </returns>
        public static string RemoveFirstInstanceOfString(this string value, string removeString)
        {
            int index = value.IndexOf(removeString, StringComparison.Ordinal);
            return index < 0 ? value : value.Remove(index, removeString.Length);
        }

        /// <inheritdoc cref="IsNullOrEmpty" />
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <inheritdoc cref="IsNullOrWhiteSpace" />
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <inheritdoc cref="string.Equals" />
        public static bool EqualsIgnoreCase(this string value, string value2)
        {
            return string.Equals(value, value2, StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc cref="string.Contains" />
        public static bool ContainsIgnoreCase(this string value, string value2)
        {
            return value.ToLower().Contains(value2.ToLower());
        }

        /// <inheritdoc cref="string.Equals" />
        public static bool EndsWithIgnoreCase(this string value, string value2)
        {
            return value.ToLower().EndsWith(value2.ToLower());
        }
    }
}