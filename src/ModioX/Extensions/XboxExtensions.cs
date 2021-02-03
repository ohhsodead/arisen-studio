using System;
using System.Net;
using System.Text;
using XDevkit;

namespace ModioX.Extensions
{
    public static class XboxExtensions
    {
        private static readonly byte[] memoryBuffer = new byte[32];
        private static uint OutInt;

        public static byte[] ReadBytes(this IXboxConsole xbCon, uint offset, uint size)
        {
            byte[] temp = new byte[size];
            xbCon.DebugTarget.GetMemory(offset, size, temp, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, size);
            return temp;
        }

        public static sbyte ReadSByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return (sbyte)memoryBuffer[0];
        }

        public static bool ReadBool(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return memoryBuffer[0] != 0;
        }

        public static short ReadInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(memoryBuffer, 0, 2);
            return BitConverter.ToInt16(memoryBuffer, 0);
        }

        public static int ReadInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToInt32(memoryBuffer, 0);
        }

        public static long ReadInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(memoryBuffer, 0, 8);
            return BitConverter.ToInt64(memoryBuffer, 0);
        }

        public static byte ReadByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return memoryBuffer[0];
        }

        public static ushort ReadUInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(memoryBuffer, 0, 2);
            return BitConverter.ToUInt16(memoryBuffer, 0);
        }

        public static uint ReadUInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToUInt32(memoryBuffer, 0);
        }

        public static ulong ReadUInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(memoryBuffer, 0, 8);
            return BitConverter.ToUInt64(memoryBuffer, 0);
        }

        public static float ReadFloat(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToSingle(memoryBuffer, 0);
        }

        public static string ReadString(this IXboxConsole xbCon, uint offset, byte[] readBuffer)
        {
            xbCon.DebugTarget.GetMemory(offset, (uint)readBuffer.Length, readBuffer, out OutInt);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, (uint)readBuffer.Length);
            string stringValue = new string(Encoding.ASCII.GetChars(readBuffer));
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
            xbCon.DebugTarget.SetMemory(offset, 1, memoryBuffer, out OutInt);
        }

        public static void WriteInt16(this IXboxConsole xbCon, uint offset, short input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, memoryBuffer, out OutInt);
        }

        public static void WriteInt32(this IXboxConsole xbCon, uint offset, int input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out OutInt);
        }

        public static void WriteInt64(this IXboxConsole xbCon, uint offset, long input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, memoryBuffer, out OutInt);
        }

        public static void WriteByte(this IXboxConsole xbCon, uint offset, byte input)
        {
            memoryBuffer[0] = input;
            xbCon.DebugTarget.SetMemory(offset, 1, memoryBuffer, out OutInt);
        }

        public static void WriteUInt16(this IXboxConsole xbCon, uint offset, ushort input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, memoryBuffer, out OutInt);
        }

        public static void WriteUInt32(this IXboxConsole xbCon, uint offset, uint input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out OutInt);
        }

        public static void WriteUInt64(this IXboxConsole xbCon, uint offset, ulong input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, memoryBuffer, out OutInt);
        }

        public static void WriteFloat(this IXboxConsole xbCon, uint offset, float input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out OutInt);
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
            xbCon.DebugTarget.SetMemory(Address, (uint)array.Length, array, out OutInt);
        }

        public static void WriteBytes(this IXboxConsole xbCon, uint offset, byte[] memory)
        {
            xbCon.DebugTarget.SetMemory(offset, (uint)memory.Length, memory, out OutInt);
        }

        public static void Reboot(this IXboxConsole xbCon)
        {
            xbCon.Reboot(null, null, null, XboxRebootFlags.Cold);
        }

        public static string GetConsoleIP(this IXboxConsole xbCon)
        {
            return new IPAddress(xbCon.IPAddress).ToString();
        }
    }
}