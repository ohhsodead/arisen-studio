using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ModioX.Extensions
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
        /// Remove the characters that aren't allowed in the username.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>A formatted username.</returns>
        public static string FormatUserName(this string userName)
        {
            string username = userName.Replace("@", "").Replace(" ", "-").Replace("_", "-").Trim();
            return Regex.Replace(username, @"[^0-9a-zA-Z_]+", "");
        }

        /// <summary>
        /// Remove all the bad words from a string and replaces them with an asterisk.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Returns same string without all of the bad words.</returns>
        public static string CensorString(this string text)
        {
            ProfanityFilter.ProfanityFilter filter = new();
            filter.AllowList.Add("lmao");
            filter.AllowList.Add("lmfao");
            filter.AllowList.Add("wtf");
            filter.AllowList.Add("ffs");
            filter.AllowList.Add("fs");
            filter.AllowList.Add("omg");
            filter.AllowList.Add("omfg");
            return filter.CensorString(text, '*', false);
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
        /// <param name="original"></param>
        /// <param name="toBeReplaced"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceAll(this string original, string[] toBeReplaced, string newValue)
        {
            if (string.IsNullOrEmpty(original) || toBeReplaced == null || toBeReplaced.Length <= 0)
            {
                return original;
            }

            newValue = newValue switch
            {
                null => string.Empty,
                _ => newValue
            };

            foreach (string str in from string str in toBeReplaced
                                   where !string.IsNullOrEmpty(str)
                                   select str)
            {
                original = original.Replace(str, newValue);
            }

            return original;
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

        public static string StringToHex(this string hexString)
        {
            StringBuilder sb = new();

            foreach (char t in hexString)
            {
                //Note: X for upper, x for lower case letters
                sb.Append(Convert.ToInt32(t).ToString("X"));
            }

            return sb.ToString();
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

        public static byte[] ToByteArray(this string bytes)
        {
            string[] bytesAsString = bytes.Split(',');
            List<byte> byteArray = new();

            foreach (string byteString in bytesAsString)
            {
                byteArray.Add(byte.Parse(byteString.Trim()));
            }

            return byteArray.ToArray();
        }

        public static byte[] StringToByteArray(this string hex)
        {
            return (from x in Enumerable.Range(0, hex.Length)
                    where x % 2 == 0
                    select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
        }

        public static byte[] ToBytes(this string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }

        public static byte[] HexToBytes(this string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
            {
                throw new ArgumentException("Hex cannot be null/empty/whitespace");
            }

            if (hex.Length % 2 != 0)
            {
                throw new FormatException("Hex must have an even number of characters");
            }

            bool startsWithHexStart = hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase);

            switch (startsWithHexStart)
            {
                case true when hex.Length == 2:
                    throw new ArgumentException("There are no characters in the hex string");
            }

            int startIndex = startsWithHexStart ? 2 : 0;

            byte[] bytesArr = new byte[(hex.Length - startIndex) / 2];

            char left;
            char right;

            try
            {
                int x = 0;
                for (int i = startIndex; i < hex.Length; i += 2, x++)
                {
                    left = hex[i];
                    right = hex[i + 1];
                    bytesArr[x] = (byte)((hexmap[left] << 4) | hexmap[right]);
                }

                return bytesArr;
            }
            catch (KeyNotFoundException)
            {
                throw new FormatException("Hex string has non-hex character");
            }
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