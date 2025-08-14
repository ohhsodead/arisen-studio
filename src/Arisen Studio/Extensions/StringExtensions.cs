using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;

namespace ArisenStudio.Extensions
{
    internal static class StringExtensions
    {
        private static readonly Dictionary<char, byte> Hexmap = new()
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
        /// Convert boolean values to either Yes/No
        /// </summary>
        /// <param name="value"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static string ToYesNoString(this bool value, ResourceManager resource)
        {
            return value ? resource.GetString("LABEL_YES") : resource.GetString("LABEL_NO");
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
                _ = sbBytes.Append($"{b:X2}");
            }
            return sbBytes.ToString();
        }

        public static string BytesToHexString(byte[] buffer)
        {
            string str = "";
            for (int i = 0; i < buffer.Length; i++)
            {
                str = str + buffer[i].ToString("X2");
            }

            return str;
        }

        public static byte[] HexStringToBytes(string hex)
        {
            Func<int, byte> func2 = null;
            try
            {
                hex = hex.Replace(" ", "").Replace("0x", "");
                if (func2 == null)
                {
                    func2 = x => Convert.ToByte(hex.Substring(x, 2), 0x10);
                }

                Func<int, byte> selector = func2;
                return (from x in Enumerable.Range(0, hex.Length)
                        where (x % 2) == 0
                        select x).Select<int, byte>(selector).ToArray<byte>();
            }
            catch (Exception) { return new byte[1]; }
        }

        public static string ValueToHex(long Value) { return string.Format("0x{0:X}", Value); }

        public static string ValueToHex(ulong Value) { return string.Format("0x{0:X}", Value); }

        public static ulong ValueFromHex(string Value)
        {
            if (Value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) Value = Value.Substring(2);
            return ulong.Parse(Value, NumberStyles.HexNumber);
        }

        public static string UIntToIp(uint input)
        {
            return $"{(input >> 24) & 0xFF}.{(input >> 16) & 0xFF}.{(input >> 8) & 0xFF}.{input & 0xFF}";
        }

        public static int GetRandomExcept(int minValue, int maxValue, IEnumerable<int> except)
        {
            return GetRandoms(minValue, maxValue).Except(except).First();
        }

        public static IEnumerable<int> GetRandoms(int minValue, int maxValue)
        {
            var random = new Random();
            while (true) yield return random.Next(minValue, maxValue);
        }

        public static bool ValidNumericString(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 0)
            {
                char[] valid_characters = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
                bool valid;
                foreach (char character in value)
                {
                    valid = false;
                    foreach (char valid_character in valid_characters)
                    {
                        if (character == valid_character)
                        {
                            valid = true;
                            break;
                        }
                    }
                    if (!valid)
                        return false;

                }

                return true;
            }

            return false;
        }

        public static bool ValidHexadecimalString(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 0)
            {
                char[] valid_characters = [
                    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                    'A', 'B', 'C', 'D', 'E', 'F',
                    'a', 'b', 'c', 'd', 'e', 'f'
                ];
                bool valid;
                foreach (char character in value)
                {
                    valid = false;
                    foreach (char valid_character in valid_characters)
                    {
                        if (character == valid_character)
                        {
                            valid = true;
                            break;
                        }
                    }
                    if (!valid)
                        return false;

                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Remove special characters from a string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(this string value)
        {
            return Regex.Replace(value, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
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

        /// <inheritdoc cref="string.Equals" />
        public static bool EqualsIgnoreCaseSymbols(this string value, string value2)
        {
            return string.Equals(value.RemoveSpecialCharacters(), value2.RemoveSpecialCharacters(), StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc cref="string.Contains" />
        public static bool ContainsIgnoreCase(this string value, string value2)
        {
            return value.ToLower().Contains(value2.ToLower());
        }

        /// <inheritdoc cref="string.Contains" />
        public static bool ContainsIgnoreCaseSymbols(this string value, string value2)
        {
            return value.RemoveSpecialCharacters().ToLower().Contains(value2.RemoveSpecialCharacters().ToLower());
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