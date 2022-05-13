using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Modio.Extensions
{
    internal static class StringExtensions
    {
        private static readonly Dictionary<char, byte> hexmap = new()
        {
            { 'a', 0xA },
            { 'b', 0xB },
            { 'c', 0xC },
            { 'd', 0xD },
            { 'e', 0xE },
            { 'f', 0xF },
            { 'A', 0xA },
            { 'B', 0xB },
            { 'C', 0xC },
            { 'D', 0xD },
            { 'E', 0xE },
            { 'F', 0xF },
            { '0', 0x0 },
            { '1', 0x1 },
            { '2', 0x2 },
            { '3', 0x3 },
            { '4', 0x4 },
            { '5', 0x5 },
            { '6', 0x6 },
            { '7', 0x7 },
            { '8', 0x8 },
            { '9', 0x9 }
        };

        /// <summary>
        /// Replace all invalid file name characters with an underscore character.
        /// </summary>
        /// <param name="fileName"> File Name </param>
        /// <returns>  </returns>
        public static string RemoveInvalidChars(this string fileName)
        {
            if (fileName.IsNullOrWhiteSpace())
            {
                return null;
            }

            return string.Join(string.Empty, fileName.Split(Path.GetInvalidFileNameChars()));
        }

        /// <summary>
        /// Replace all URLs with the <paramref name="message" />
        /// </summary>
        /// <param name="text">String possibly containing URLs</param>
        /// <param name="message">String to replace URL with.</param>
        /// <returns>Return the string with URLs removed.</returns>
        public static string ReplaceUrls(this string text, string message)
        {
            return Regex.Replace(text,
                @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$",
                message);
        }

        /// <summary>
        /// </summary>
        /// <param name="str"> </param>
        /// <param name="value"> </param>
        /// <param name="nth"> </param>
        /// <returns> </returns>
        public static int IndexOfNth(this string str, string value, int nth = 0)
        {
            switch (nth)
            {
                case < 0:
                    throw new ArgumentException("Can not find a negative index of substring in string. Must start with 0");
            }

            int offset = str.IndexOf(value, StringComparison.Ordinal);

            int tries = 0;
            while (offset != -1 && tries < nth)
            {
                offset = str.IndexOf(value, offset + 1, StringComparison.Ordinal);
                tries++;
            }

            return offset;
        }

        public static string ConvertStringToHex(this string input, Encoding encoding)
        {
            byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.Append($"{b:X2}");
            }
            return sbBytes.ToString();
        }

        public static int Find(this string String, string _Ptr)
        {
            if (_Ptr.Length != 0 && String.Length != 0)
            {
                for (int i = 0; i < String.Length; i++)
                {
                    if (String[i] == _Ptr[0])
                    {
                        bool flag = true;
                        int num2 = 0;
                        while (true)
                        {
                            if (num2 >= _Ptr.Length)
                            {
                                if (!flag)
                                {
                                    break;
                                }

                                return i;
                            }

                            if (String[i + num2] != _Ptr[num2])
                            {
                                flag = false;
                            }

                            num2++;
                        }
                    }
                }
            }

            return -1;
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

        /// <inheritdoc cref="string.Contains" />
        public static bool AnyContainsIgnoreCase(this string[] value, string value2)
        {
            return value.Any(x => x.ToLower().Contains(value2.ToLower()));
        }

        /// <inheritdoc cref="string.Equals" />
        public static bool EndsWithIgnoreCase(this string value, string value2)
        {
            return value.ToLower().EndsWith(value2.ToLower());
        }
    }
}