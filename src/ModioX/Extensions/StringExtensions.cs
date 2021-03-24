using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

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

        public static byte[] TestBytes(this string bytes)
        {
            return bytes.Select(s => byte.Parse(Convert.ToString(s), NumberStyles.HexNumber)).ToArray();
        }

        public static byte[] ToBytes(this string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);

            return bytes;
        }

        public static byte[] GetBytes(uint offset, int length, PS3Lib.PS3API PS3)
        {
            byte[] array = new byte[length];
            byte[] result;
            if (PS3.GetCurrentAPI() == PS3Lib.SelectAPI.ControlConsole)
            {
                result = PS3.GetBytes(offset, length);
            }
            else
            {
                if (PS3.GetCurrentAPI() == PS3Lib.SelectAPI.TargetManager)
                {
                    array = PS3.GetBytes(offset, length);
                }
                result = array;
            }
            return result;
        }

        private readonly static Dictionary<char, byte> hexmap = new()
        {
            { 'a', 0xA },{ 'b', 0xB },{ 'c', 0xC },{ 'd', 0xD },
            { 'e', 0xE },{ 'f', 0xF },{ 'A', 0xA },{ 'B', 0xB },
            { 'C', 0xC },{ 'D', 0xD },{ 'E', 0xE },{ 'F', 0xF },
            { '0', 0x0 },{ '1', 0x1 },{ '2', 0x2 },{ '3', 0x3 },
            { '4', 0x4 },{ '5', 0x5 },{ '6', 0x6 },{ '7', 0x7 },
            { '8', 0x8 },{ '9', 0x9 }
        };

        public static byte[] HexToBytes(this string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
                throw new ArgumentException("Hex cannot be null/empty/whitespace");

            if (hex.Length % 2 != 0)
                throw new FormatException("Hex must have an even number of characters");

            bool startsWithHexStart = hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase);

            if (startsWithHexStart && hex.Length == 2)
                throw new ArgumentException("There are no characters in the hex string");


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
            if ((_Ptr.Length != 0) && (String.Length != 0))
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

        /// <inheritdoc cref="string.Equals" />
        public static bool EndsWithIgnoreCase(this string value, string value2)
        {
            return value.ToLower().EndsWith(value2.ToLower());
        }
    }
}