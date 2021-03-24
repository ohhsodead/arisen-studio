using System;
using System.Globalization;
using System.Text;
using XDevkit;

namespace ModioX.Extensions
{
    internal static class XboxExtensions
    {
        public static void XNotify(this IXboxConsole console, string text)
        {
            console.XNotify(text, 0x22);
        }

        public static void XNotify(this IXboxConsole console, string text, uint type)
        {
            object[] objArray = new object[] { "consolefeatures ver=", "2", " type=12 params=\"A\\0\\A\\2\\", typeof(string), "/", text.Length, @"\", text.StringToHex(), @"\" };
            objArray[9] = typeof(int);
            objArray[10] = @"\";
            objArray[11] = type;
            objArray[12] = "\\\"";
            string command = string.Concat(objArray);
            console.SendTextCommand(0, command, out _);
        }

        public static void Shutdown(this IXboxConsole console)
        {
            try
            {
                console.SendTextCommand(0, "consolefeatures ver=" + "2" + " type=11 params=\"A\\0\\A\\0\\\"", out string response);
            }
            catch
            {
            }
        }

        public static uint GetTemperature(this IXboxConsole console, TemperatureFlag temperatureType)
        {
            object[] objArray = new object[] { "consolefeatures ver=", "2", " type=15 params=\"A\\0\\A\\1\\", typeof(int), @"\", (int)temperatureType, "\\\"" };
            string command = string.Concat(objArray);
            console.SendTextCommand(0, command, out string response);
            return uint.Parse(response.Substring(response.Find(" ") + 1), NumberStyles.HexNumber);
        }

        private static byte[] memoryBuffer = new byte[32];
        private static uint outInt = 0;

        public static byte[] ReadBytes(this IXboxConsole xbCon, uint offset, uint size)
        {
            byte[] temp = new byte[size];
            xbCon.DebugTarget.GetMemory(offset, size, temp, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, size);
            return temp;
        }

        public static sbyte ReadSByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return (sbyte)memoryBuffer[0];
        }
        public static bool ReadBool(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return memoryBuffer[0] != 0;
        }
        public static short ReadInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(memoryBuffer, 0, 2);
            return BitConverter.ToInt16(memoryBuffer, 0);
        }
        public static int ReadInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToInt32(memoryBuffer, 0);
        }
        public static long ReadInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(memoryBuffer, 0, 8);
            return BitConverter.ToInt64(memoryBuffer, 0);
        }
        public static byte ReadByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return memoryBuffer[0];
        }
        public static ushort ReadUInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(memoryBuffer, 0, 2);
            return BitConverter.ToUInt16(memoryBuffer, 0);
        }
        public static uint ReadUInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToUInt32(memoryBuffer, 0);
        }
        public static ulong ReadUInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(memoryBuffer, 0, 8);
            return BitConverter.ToUInt64(memoryBuffer, 0);
        }
        public static float ReadFloat(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToSingle(memoryBuffer, 0);
        }
        public static string ReadString(this IXboxConsole xbCon, uint offset, byte[] readBuffer)
        {
            xbCon.DebugTarget.GetMemory(offset, (uint)readBuffer.Length, readBuffer, out outInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, (uint)readBuffer.Length);
            string stringValue = new(Encoding.ASCII.GetChars(readBuffer));
            char[] separator = new char[1];
            return stringValue.Split(separator)[0];
        }
        public static string ReadString(this IXboxConsole xbCon, uint offset)
        {
            return ReadString(xbCon, offset, memoryBuffer);
        }
        public static void WriteSByte(this IXboxConsole xbCon, uint offset, sbyte input)
        {
            memoryBuffer[0] = (byte)input;
            xbCon.DebugTarget.SetMemory(offset, 1, memoryBuffer, out outInt);
        }

        public static void WriteInt16(this IXboxConsole xbCon, uint offset, short input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, memoryBuffer, out outInt);
        }
        public static void WriteInt32(this IXboxConsole xbCon, uint offset, int input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out outInt);
        }
        public static void WriteInt64(this IXboxConsole xbCon, uint offset, long input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, memoryBuffer, out outInt);
        }
        public static void WriteByte(this IXboxConsole xbCon, uint offset, byte input)
        {
            memoryBuffer[0] = input;
            xbCon.DebugTarget.SetMemory(offset, 1, memoryBuffer, out outInt);
        }
        public static void WriteUInt16(this IXboxConsole xbCon, uint offset, ushort input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, memoryBuffer, out outInt);
        }
        public static void WriteUInt32(this IXboxConsole xbCon, uint offset, uint input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out outInt);
        }
        public static void WriteUInt64(this IXboxConsole xbCon, uint offset, ulong input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, memoryBuffer, out outInt);
        }
        public static void WriteFloat(this IXboxConsole xbCon, uint offset, float input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out outInt);
        }

        public static void Push(this byte[] InArray, out byte[] OutArray, byte Value)
        {
            OutArray = new byte[InArray.Length + 1];
            InArray.CopyTo(OutArray, 0);
            OutArray[InArray.Length] = Value;
        }

        public static void WriteString(this IXboxConsole xbCon, uint Address, string String)
        {
            byte[] array = new byte[0];
            for (int i = 0; i < String.Length; i++)
            {
                byte value = (byte)String[i];
                array.Push(out array, value);
            }
            array.Push(out array, 0);
            xbCon.DebugTarget.SetMemory(Address, (uint)array.Length, array, out outInt);
        }

        public static void WriteBytes(this IXboxConsole xbCon, uint offset, byte[] memory)
        {
            xbCon.DebugTarget.SetMemory(offset, (uint)memory.Length, memory, out outInt);
        }
    }

    public enum TemperatureFlag
    {
        CPU,
        GPU,
        EDRAM,
        MotherBoard
    }
}