using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace XDevkit
{
    public static class Functions
    {
        private static string DateToHex(DateTime theDate)
        {
            string isoDate = theDate.ToString("yyyyMMddHHmmss");

            string resultString = string.Empty;

            for (int i = 0; i < isoDate.Length; i++)    // Amended
            {
                int n = char.ConvertToUtf32(isoDate, i);
                string hs = n.ToString("x");
                resultString += hs;

            }
            return resultString;
        }
        private static byte[] getData(long[] argument)
        {
            byte[] numArray = new byte[argument.Length * 8];
            int index = 0;
            foreach (long num in argument)
            {
                byte[] bytes = BitConverter.GetBytes(num);
                Array.Reverse(bytes);
                bytes.CopyTo(numArray, index);
                index += 8;
            }
            return numArray;
        }
        private static float[] toFloatArray(double[] arr)
        {
            if (arr == null)
                return null;
            int length = arr.Length;
            float[] numArray = new float[length];
            for (int index = 0; index < length; ++index)
                numArray[index] = (float)arr[index];
            return numArray;
        }

        internal static ulong ConvertToUInt64(object o)
        {
            if (o is bool)
            {
                if ((bool)o)
                {
                    return 1;
                }
                return 0;
            }
            if (o is byte)
            {
                return (byte)o;
            }
            if (o is short)
            {
                return (ulong)((short)o);
            }
            if (o is int)
            {
                return (ulong)(int)o;
            }
            if (o is long)
            {
                return (ulong)o;
            }
            if (o is ushort)
            {
                return (ushort)o;
            }
            if (o is uint)
            {
                return (uint)o;
            }
            if (o is ulong)
            {
                return (ulong)o;
            }
            if (o is float)
            {
                return (ulong)BitConverter.DoubleToInt64Bits((float)o);
            }
            if (!(o is double))
            {
                return 0;
            }
            return (ulong)BitConverter.DoubleToInt64Bits((double)o);
        }

        public static string ByteArrayToString(byte[] bytes)
        {
            var text = string.Empty;

            foreach (byte t in bytes)
            {
                text += String.Format("{0,0:X2}", t);
            }

            return text;
        }
        public static string BytesToHexString(byte[] data)
        {
            string str = string.Empty;
            int index = 0;
            while (index < data.Length)
            {
                string str2 = data[index].ToString("X");
                while (true)
                {
                    if (str2.Length == 2)
                    {
                        str = str + str2;
                        index++;
                        break;
                    }
                    str2 = "0" + str2;
                }
            }
            return str;
        }

        public static string BytesToString(byte[] data) =>
            RemoveWhiteSpacingFromString(Encoding.ASCII.GetString(data));
        #region byte to sbyte to byte
        /// <summary>
        /// Converts a unsigned byte to a signed one
        /// </summary>
        /// <param name="b"> byte </param>
        /// <returns>sbyte</returns>
        public static sbyte ByteToSByte(byte b)
        {
            int signed = b - ((b & 0x80) << 1);
            return (sbyte)signed;
        }
        #endregion

        public static int CalculatePadding(int integer, int interval) =>
            (interval - (integer % interval));

        public static uint Convert(string value)
        {
            if (value.Contains("0x"))
                return System.Convert.ToUInt32(value.Substring(2), 16);
            return System.Convert.ToUInt32(value, 16);
        }

        public static string ConvertHexToString(string hexInput, Encoding encoding)
        {
            int numberChars = hexInput.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = System.Convert.ToByte(hexInput.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }

        public static int ConvertSigned(string value)
        {
            if (value.Contains("0x"))
                return System.Convert.ToInt32(value.Substring(2), 16);
            return System.Convert.ToInt32(value, 16);
        }


        public static string ConvertStringToHex(string input, Encoding encoding)
        {
            byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.Append($"{b:X2}");
            }
            return sbBytes.ToString();
        }
        public static string CovertHexTime(string hexDate)
        {
            hexDate = DateToHex(DateTime.Now);

            string sDate = string.Empty;
            for (int i = 0; i < hexDate.Length - 1; i += 2)       // Amended
            {
                string ss = hexDate.Substring(i, 2);
                int nn = int.Parse(ss, NumberStyles.AllowHexSpecifier);

                string c = Char.ConvertFromUtf32(nn);
                sDate += c;
            }

            CultureInfo provider = CultureInfo.InvariantCulture;
            CultureInfo[] cultures = { new CultureInfo("fr-FR") };


            return DateTime.ParseExact(sDate, "yyyyMMddHHmmss", provider).ToString();
        }

        public static void DeleteBytes(string filePath, int startOffset, int size)
        {
            FileStream input = new FileStream(filePath, FileMode.Open);
            BinaryReader reader = new BinaryReader(input);
            Stream baseStream = reader.BaseStream;
            baseStream.Position += size;
            reader.Close();
            input.Close();
            input = new FileStream(filePath, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(input);
            writer.Write(reader.ReadBytes(startOffset));
            writer.Write(reader.ReadBytes(((int)reader.BaseStream.Length) - ((int)reader.BaseStream.Position)));
            input.Close();
            writer.Close();
        }

        public static byte[] GetBytesFromStream(BinaryReader br) =>
            GetBytesFromStream(br, 0, (int)br.BaseStream.Length);

        public static byte[] GetBytesFromStream(BinaryReader br, int offset, int size)
        {
            br.BaseStream.Position = offset;
            return br.ReadBytes(size);
        }
        public static byte[] HexStringToBytes(string hexString)
        {
            List<byte> list = new List<byte>();
            for (int i = 0; i < hexString.Length; i += 2)
            {
                if (hexString.Length > (i + 1))
                {
                    list.Add(byte.Parse(hexString[i] + hexString[i + 1].ToString(), NumberStyles.HexNumber));
                }
            }
            return list.ToArray();
        }

        /// <summary>Converts a Hex string to bytes</summary>
        /// <param name="input">Is the String input</param>
        public static byte[] HexToBytes(String input)
        {
            input = input.Replace(" ", string.Empty);
            input = input.Replace("-", string.Empty);
            input = input.Replace("0x", string.Empty);
            input = input.Replace("0X", string.Empty);
            if ((input.Length % 2) != 0)
                input = "0" + input;
            var output = new byte[(input.Length / 2)];

            try
            {
                int index;
                for (index = 0; index < output.Length; index++)
                {
                    output[index] = System.Convert.ToByte(input.Substring((index * 2), 2), 16);
                }
                return output;
            }
            catch
            {
                throw new Exception("Invalid byte Input");
            }
        }


        public static void InsertBytes(string filePath, int startOffset, int size)
        {
            FileStream input = new FileStream(filePath, FileMode.Open);
            BinaryReader reader = new BinaryReader(input)
            {
                BaseStream = { Position = startOffset }
            };
            reader.Close();
            input.Close();
            input = new FileStream(filePath, FileMode.Open);
            BinaryWriter writer = new BinaryWriter(input)
            {
                BaseStream = { Position = startOffset }
            };
            writer.Write(new byte[size]);
            writer.Write(reader.ReadBytes(((int)reader.BaseStream.Length) - ((int)reader.BaseStream.Position)));
            input.Close();
            writer.Close();
        }

        public static void InsertBytes(string filePath, int startOffset, byte[] data)
        {
            FileStream input = new FileStream(filePath, FileMode.Open);
            BinaryReader reader = new BinaryReader(input)
            {
                BaseStream = { Position = startOffset }
            };
            reader.Close();
            input.Close();
            input = new FileStream(filePath, FileMode.Open);
            BinaryWriter writer = new BinaryWriter(input)
            {
                BaseStream = { Position = startOffset }
            };
            writer.Write(data);
            writer.Write(reader.ReadBytes(((int)reader.BaseStream.Length) - ((int)reader.BaseStream.Position)));
            input.Close();
            writer.Close();
        }
        public static byte[] IntArrayToByte(int[] iArray)
        {
            byte[] bytes = new byte[iArray.Length * 4];
            int num = 0;
            int num1 = 0;
            while (num < iArray.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[num1 + i] = BitConverter.GetBytes(iArray[num])[i];
                }
                num++;
                num1 += 4;
            }
            return bytes;
        }
        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        /// <summary>Verifies if the given string is hex</summary>
        /// <param name="value">The string value to check</param>
        /// <returns>True if its hex and false if it isn't.</returns>
        public static bool IsHex(string value)
        {
            if (value.Length % 2 != 0) return false;
            //^ - Begin the match at the beginning of the line.
            //$ - End the match at the end of the line.
            return System.Text.RegularExpressions.Regex.IsMatch(value, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public static string RemoveWhiteSpacingFromString(string str) =>
            str.Replace("\0", string.Empty);
        /// <summary>
        /// Turn hex string to byte array
        /// </summary>
        /// <param name="text">The hex string</param>
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = System.Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static byte[] StringToBytes(string data) =>
            Encoding.ASCII.GetBytes(data);

        public static byte[] StringToUnicodeBytes(string text)
        {
            byte[] buffer = StringToBytes(text);
            byte[] buffer2 = new byte[buffer.Length * 2];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer2[i * 2] = buffer[i];
            }
            return buffer2;
        }

        public static byte[] StringToUnicodeBytes(string text, int Length)
        {
            byte[] buffer = StringToBytes(text);
            byte[] buffer2 = new byte[Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer2[i * 2] = buffer[i];
            }
            return buffer2;
        }

        public static void SwapBytes(ref byte[] data)
        {
            Array.Reverse(data);
        }
        public static string ToHexString(this string String)//help it depend on it's own
        {
            string str = string.Empty;
            string str1 = String;
            for (int i = 0; i < str1.Length; i++)
            {
                byte num = (byte)str1[i];
                str = string.Concat(str, num.ToString("X2"));
            }
            return str;
        }

        /// <summary>Convert Byte Array to String Hex</summary>
        /// <param name="value">The byte array</param>
        /// <returns>Returns an hex string value</returns>
        public static string ToHexString(byte[] value)
        {
            try
            {
                return BitConverter.ToString(value).Replace("-", string.Empty);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public static byte[] ToWCHAR(this string String)
        {
            return WCHAR(String);
        }

        /// <summary>Converts Unsigned Integer 32 to 4 Byte array</summary>
        /// <param name="value">The value to be converted</param>
        public static Byte[] UInt32ToBytes(UInt32 value)
        {
            var buffer = new Byte[4];
            buffer[3] = (Byte)(value & 0xFF);
            buffer[2] = (Byte)((value >> 8) & 0xFF);
            buffer[1] = (Byte)((value >> 16) & 0xFF);
            buffer[0] = (Byte)((value >> 24) & 0xFF);
            return buffer;
        }
        public static int UIntToInt(uint Value) =>
    BitConverter.ToInt32(BitConverter.GetBytes(Value), 0);

        public static byte[] ValueToBytes(byte data) =>
            new byte[] { data };

        public static byte[] ValueToBytes(short data)
        {
            MemoryStream stream = new MemoryStream();
            EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
            nio.Open();
            nio.Out.Write(data);
            nio.In.BaseStream.Position = 0L;
            byte[] buffer = nio.In.ReadBytes((int)nio.In.BaseStream.Length);
            nio.Close();
            stream.Close();
            return buffer;
        }

        public static byte[] ValueToBytes(int data)
        {
            MemoryStream stream = new MemoryStream();
            EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
            nio.Open();
            nio.Out.Write(data);
            nio.In.BaseStream.Position = 0L;
            byte[] buffer = nio.In.ReadBytes((int)nio.In.BaseStream.Length);
            nio.Close();
            stream.Close();
            return buffer;
        }

        public static byte[] ValueToBytes(float data)
        {
            MemoryStream stream = new MemoryStream();
            EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
            nio.Open();
            nio.Out.Write(data);
            nio.In.BaseStream.Position = 0L;
            byte[] buffer = nio.In.ReadBytes((int)nio.In.BaseStream.Length);
            nio.Close();
            stream.Close();
            return buffer;
        }

        public static byte[] ValueToBytes(ushort data)
        {
            MemoryStream stream = new MemoryStream();
            EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
            nio.Open();
            nio.Out.Write(data);
            nio.In.BaseStream.Position = 0L;
            byte[] buffer = nio.In.ReadBytes((int)nio.In.BaseStream.Length);
            nio.Close();
            stream.Close();
            return buffer;
        }

        public static byte[] ValueToBytes(uint data)
        {
            MemoryStream stream = new MemoryStream();
            EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
            nio.Open();
            nio.Out.Write(data);
            nio.In.BaseStream.Position = 0L;
            byte[] buffer = nio.In.ReadBytes((int)nio.In.BaseStream.Length);
            nio.Close();
            stream.Close();
            return buffer;
        }

        public static byte[] ValueToBytes(string data, bool unicode) =>
            (!unicode ? StringToBytes(data) : StringToUnicodeBytes(data));
        public static byte[] WCHAR(string String)
        {
            byte[] numArray = new byte[String.Length * 2 + 2];
            int num = 1;
            string str = String;
            for (int i = 0; i < str.Length; i++)
            {
                numArray[num] = (byte)str[i];
                num += 2;
            }
            return numArray;
        }
        public static byte[] WideChar(string text)
        {
            byte[] numArray = new byte[text.Length * 2 + 2];
            int index = 1;
            numArray[0] = 0;
            foreach (char ch in text)
            {
                numArray[index] = System.Convert.ToByte(ch);
                index += 2;
            }
            return numArray;
        }

        #region (u)int to byte array to (u)int
        /// <summary>
        /// Converts a Byte array to Int16
        /// </summary>
        /// <param name="bytes"> bytes array</param>
        /// <param name="isBigEndian"> if bigendian = true else false; default = false</param>
        /// <returns> returns Int16 </returns>
        public static Int16 BytesToInt16(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToInt16(bytes, 0);
        }
        /// <summary>
        /// Converts Int16 to a bytes array
        /// </summary>
        /// <param name="value"> Int16</param>
        /// <param name="isBigEndian">if bigendian = true else false; default = false</param>
        /// <returns> returns a bytes arraay</returns>
        public static Byte[] Int16ToBytes(Int16 value, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(value);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }
        /// <summary>
        /// Converts a Byte array to UInt16
        /// </summary>
        /// <param name="bytes"> bytes array</param>
        /// <param name="isBigEndian"> if bigendian = true else false; default = false</param>
        /// <returns> returns UInt16 </returns>
        public static UInt16 BytesToUInt16(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToUInt16(bytes, 0);
        }
        /// <summary>
        /// Converts UInt16 to a bytes array
        /// </summary>
        /// <param name="value"> UInt16</param>
        /// <param name="isBigEndian">if bigendian = true else false; default = false</param>
        /// <returns> returns a bytes arraay</returns>
        public static Byte[] UInt16ToBytes(UInt16 value, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(value);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }

        /// <summary>
        /// Converts a Byte array to Int32
        /// </summary>
        /// <param name="bytes"> bytes array</param>
        /// <param name="isBigEndian"> if bigendian = true else false; default = false</param>
        /// <returns> returns Int32 </returns>
        public static Int32 BytesToInt32(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToInt32(bytes, 0);
        }
        /// <summary>
        /// Converts Int32 to a bytes array
        /// </summary>
        /// <param name="value"> Int32</param>
        /// <param name="isBigEndian">if bigendian = true else false; default = false</param>
        /// <returns> returns a bytes arraay</returns>
        public static Byte[] Int32ToBytes(Int32 value, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(value);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }
        /// <summary>
        /// Converts a Byte array to UInt32
        /// </summary>
        /// <param name="bytes"> bytes array</param>
        /// <param name="isBigEndian"> if bigendian = true else false; default = false</param>
        /// <returns> returns UInt32 </returns>
        public static UInt32 BytesToUInt32(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToUInt32(bytes, 0);
        }
        /// <summary>
        /// Converts UInt32 to a bytes array
        /// </summary>
        /// <param name="value"> UInt32</param>
        /// <param name="isBigEndian">if bigendian = true else false; default = false</param>
        /// <returns> returns a bytes arraay</returns>
        public static Byte[] UInt32ToBytes(UInt32 value, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(value);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }

        /// <summary>
        /// Converts a Byte array to Int64
        /// </summary>
        /// <param name="bytes"> bytes array</param>
        /// <param name="isBigEndian"> if bigendian = true else false; default = false</param>
        /// <returns> returns Int64 </returns>
        public static Int64 BytesToInt64(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToInt64(bytes, 0);
        }
        /// <summary>
        /// Converts Int64 to a bytes array
        /// </summary>
        /// <param name="value"> Int64</param>
        /// <param name="isBigEndian">if bigendian = true else false; default = false</param>
        /// <returns> returns a bytes arraay</returns>
        public static Byte[] Int64ToBytes(Int64 value, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(value);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }
        /// <summary>
        /// Converts a Byte array to UInt64
        /// </summary>
        /// <param name="bytes"> bytes array</param>
        /// <param name="isBigEndian"> if bigendian = true else false; default = false</param>
        /// <returns> returns UInt64 </returns>
        public static UInt64 BytesToUInt64(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToUInt64(bytes, 0);
        }
        /// <summary>
        /// Converts UInt64 to a bytes array
        /// </summary>
        /// <param name="value"> UInt64</param>
        /// <param name="isBigEndian">if bigendian = true else false; default = false</param>
        /// <returns> returns a bytes arraay</returns>
        public static Byte[] UInt64ToBytes(UInt64 value, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(value);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }
        #endregion
        #region float/double to byte array to float/double
        public static Byte[] FloatToByteArray(Single f, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(f);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }
        public static Single BytesToSingle(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToSingle(bytes, 0);
        }
        public static Byte[] DoubleToByteArray(Double d, bool isBigEndian = true)
        {
            Byte[] buffer = BitConverter.GetBytes(d);
            if (isBigEndian)
                Array.Reverse(buffer);

            return buffer;
        }
        public static Double BytesToDouble(Byte[] bytes, bool isBigEndian = true)
        {
            if (isBigEndian)
                Array.Reverse(bytes);

            return BitConverter.ToDouble(bytes, 0);
        }
        #endregion
    }
}
