using System;
using System.Globalization;
using System.Text;
using JRPC_Client;
using XDevkit;

namespace ArisenMods.Extensions
{
    internal static class XboxExtensions
    {
        public static void XNotify(this IXboxConsole console, string text, XNotifyLogo icon)
        {
            string command = "consolefeatures ver=2" + " type=12 params=\"A\\0\\A\\2\\" + 2 + "/" + text.Length + "\\" + text.ConvertStringToHex(Encoding.ASCII) + "\\" + 1 + "\\";
            command += icon + "\\\"";
            console.SendTextCommand(0, command, out _);
        }

        public static void Notify(this IXboxConsole console, string text)
        {
            console.CallVoid(JRPC.ThreadType.Title, "xam.xex", 656, 34, 0xFF, 2, text.ToWCHAR(), 1);
        }

        public static void LaunchTitle(this IXboxConsole console, string path, string directory)
        {
            string[] lines = path.Split("\\".ToCharArray());

            for (int i = 0; i < lines.Length - 1; i++)
            {
                directory += lines[i] + "\\";
            }

            console.SendTextCommand(0, "magicboot title=\"" + path + "\" directory=\"" + directory + "\"", out _);
        }

        public static void LaunchXEX(this IXboxConsole console, string xexPath, string xexDirectory)
        {
            try
            {
                console.SendTextCommand(0, NewMethod(xexPath, xexDirectory), out _);
            }
            catch
            {

            }
        }

        private static string NewMethod(string xexPath, string xexDirectory)
        {
            return string.Format("magicboot title=\"{0}\" directory=\"{1}\"", xexPath, xexDirectory);
        }

        public static void Shutdown(this IXboxConsole console)
        {
            try
            {
                //console.SendTextCommand(0, "consolefeatures ver=" + "2" + " type=11 params=\"A\\0\\A\\0\\\"", out string response);
                console.Shutdown();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Retrieves Current Title ID
        /// </summary>
        /// <returns></returns>
        public static uint GetTitleID(this IXboxConsole console)
        {
            try
            {
                //object[] objArray = new object[] { "consolefeatures ver=", "2", " type=16 params=\"A\\0\\A\\0\\\"" };
                //string command = string.Concat(objArray);
                //console.SendTextCommand(0, command, out string response);
                //return uint.Parse(response.Substring(Find(response, " ") + 1), NumberStyles.HexNumber);

                return console.XamGetCurrentTitleId();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't get current title ID.");
            }
        }

        public static uint GetCurrentTitleID(this IXboxConsole console)
        {
            try
            {
                //return Call<uint>(console, "xam.xex", 463, new object[] { });

                return console.ResolveFunction("xam.xex", 463);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't get current title ID.");
            }
        }

        public static T Call<T>(this IXboxConsole console, uint address, params object[] args) where T : struct
        {
            try
            {
                return console.Call<T>(address, args);
            }
            catch (Exception)
            {
                throw new Exception("Error while calling the function!");
            }
        }

        public static T Call<T>(this IXboxConsole console, string moduleName, int ordinal, params object[] args) where T : struct
        {
            try
            {
                return console.Call<T>(moduleName, ordinal, args);
            }
            catch (Exception)
            {
                throw new Exception("Error while calling the function!");
            }
        }

        private static readonly byte[] memoryBuffer = new byte[32];

        public static byte[] ReadBytes(this IXboxConsole xbCon, uint offset, uint size)
        {
            byte[] temp = new byte[size];
            xbCon.DebugTarget.GetMemory(offset, size, temp, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, size);
            return temp;
        }

        public static sbyte ReadSByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return (sbyte)memoryBuffer[0];
        }

        public static bool ReadBool(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return memoryBuffer[0] != 0;
        }

        public static short ReadInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(memoryBuffer, 0, 2);
            return BitConverter.ToInt16(memoryBuffer, 0);
        }

        public static int ReadInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToInt32(memoryBuffer, 0);
        }

        public static long ReadInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(memoryBuffer, 0, 8);
            return BitConverter.ToInt64(memoryBuffer, 0);
        }

        public static byte ReadByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return memoryBuffer[0];
        }

        public static ushort ReadUInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(memoryBuffer, 0, 2);
            return BitConverter.ToUInt16(memoryBuffer, 0);
        }

        public static uint ReadUInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToUInt32(memoryBuffer, 0);
        }
        public static ulong ReadUInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(memoryBuffer, 0, 8);
            return BitConverter.ToUInt64(memoryBuffer, 0);
        }

        public static float ReadFloat(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, memoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(memoryBuffer, 0, 4);
            return BitConverter.ToSingle(memoryBuffer, 0);
        }

        public static short ReadShort(this IXboxConsole xbCon, uint address)
        {
            short result = 0;

            try
            {
                byte[] memoryBuffer = new byte[2];
                xbCon.DebugTarget.GetMemory(address, (uint)memoryBuffer.Length, memoryBuffer, out uint bytesRead);
                xbCon.DebugTarget.InvalidateMemoryCache(true, address, (uint)memoryBuffer.Length);
                Array.Reverse(memoryBuffer, 0, memoryBuffer.Length);
                result = BitConverter.ToInt16(memoryBuffer, 0);
            }
            catch (Exception)
            {
                throw new Exception("Could not read a short at 0x" + address.ToString("X"));
            }

            return result;
        }

        public static void WriteShort(this IXboxConsole xbCon, uint address, short input)
        {
            try
            {
                byte[] memoryBuffer = new byte[2];
                BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
                Array.Reverse(memoryBuffer, 0, memoryBuffer.Length);
                xbCon.DebugTarget.SetMemory(address, (uint)memoryBuffer.Length, memoryBuffer, out uint bytesWritten);
            }
            catch (Exception)
            {
                throw new Exception("Could not write a float at 0x" + address.ToString("X"));
            }
        }

        public static string ReadString(this IXboxConsole xbCon, uint offset, byte[] readBuffer)
        {
            xbCon.DebugTarget.GetMemory(offset, (uint)readBuffer.Length, readBuffer, out _);
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
            xbCon.DebugTarget.SetMemory(offset, 1, memoryBuffer, out _);
        }

        public static void WriteInt16(this IXboxConsole xbCon, uint offset, short input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, memoryBuffer, out _);
        }
        public static void WriteInt32(this IXboxConsole xbCon, uint offset, int input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out _);
        }

        public static void WriteInt64(this IXboxConsole xbCon, uint offset, long input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, memoryBuffer, out _);
        }

        public static void WriteByte(this IXboxConsole xbCon, uint offset, byte input)
        {
            memoryBuffer[0] = input;
            xbCon.DebugTarget.SetMemory(offset, 1, memoryBuffer, out _);
        }
        public static void WriteUInt16(this IXboxConsole xbCon, uint offset, ushort input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, memoryBuffer, out _);
        }

        public static void WriteUInt32(this IXboxConsole xbCon, uint offset, uint input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out _);
        }

        public static void WriteUInt64(this IXboxConsole xbCon, uint offset, ulong input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, memoryBuffer, out _);
        }

        public static void WriteFloat(this IXboxConsole xbCon, uint offset, float input)
        {
            BitConverter.GetBytes(input).CopyTo(memoryBuffer, 0);
            Array.Reverse(memoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, memoryBuffer, out _);
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
            xbCon.DebugTarget.SetMemory(Address, (uint)array.Length, array, out _);
        }

        public static void WriteBytes(this IXboxConsole xbCon, uint offset, byte[] memory)
        {
            xbCon.DebugTarget.SetMemory(offset, (uint)memory.Length, memory, out _);
        }
    }

    public enum XNotifyLogo : uint
    {
        XBOX_LOGO = 0,
        NEW_MESSAGE_LOGO = 1,
        FRIEND_REQUEST_LOGO = 2,
        NEW_MESSAGE = 3,
        FLASHING_XBOX_LOGO = 4,
        GAMERTAG_SENT_YOU_A_MESSAGE = 5,
        GAMERTAG_SINGED_OUT = 6,
        GAMERTAG_SIGNEDIN = 7,
        GAMERTAG_SIGNED_INTO_XBOX_LIVE = 8,
        GAMERTAG_SIGNED_IN_OFFLINE = 9,
        GAMERTAG_WANTS_TO_CHAT = 10,
        DISCONNECTED_FROM_XBOX_LIVE = 11,
        DOWNLOAD = 12,
        FLASHING_MUSIC_SYMBOL = 13,
        FLASHING_HAPPY_FACE = 14,
        FLASHING_FROWNING_FACE = 15,
        FLASHING_DOUBLE_SIDED_HAMMER = 16,
        GAMERTAG_WANTS_TO_CHAT_2 = 17,
        PLEASE_REINSERT_MEMORY_UNIT = 18,
        PLEASE_RECONNECT_CONTROLLERM = 19,
        GAMERTAG_HAS_JOINED_CHAT = 20,
        GAMERTAG_HAS_LEFT_CHAT = 21,
        GAME_INVITE_SENT = 22,
        FLASH_LOGO = 23,
        PAGE_SENT_TO = 24,
        FOUR_2 = 25,
        FOUR_3 = 26,
        ACHIEVEMENT_UNLOCKED = 27,
        FOUR_9 = 28,
        GAMERTAG_WANTS_TO_TALK_IN_VIDEO_KINECT = 29,
        VIDEO_CHAT_INVITE_SENT = 30,
        READY_TO_PLAY = 31,
        CANT_DOWNLOAD_X = 32,
        DOWNLOAD_STOPPED_FOR_X = 33,
        FLASHING_XBOX_CONSOLE = 34,
        X_SENT_YOU_A_GAME_MESSAGE = 35,
        DEVICE_FULL = 36,
        FOUR_7 = 37,
        FLASHING_CHAT_ICON = 38,
        ACHIEVEMENTS_UNLOCKED = 39,
        X_HAS_SENT_YOU_A_NUDGE = 40,
        MESSENGER_DISCONNECTED = 41,
        BLANK = 42,
        CANT_SIGN_IN_MESSENGER = 43,
        MISSED_MESSENGER_CONVERSATION = 44,
        FAMILY_TIMER_X_TIME_REMAINING = 45,
        DISCONNECTED_XBOX_LIVE_11_MINUTES_REMAINING = 46,
        KINECT_HEALTH_EFFECTS = 47,
        FOUR_5 = 48,
        GAMERTAG_WANTS_YOU_TO_JOIN_AN_XBOX_LIVE_PARTY = 49,
        PARTY_INVITE_SENT = 50,
        GAME_INVITE_SENT_TO_XBOX_LIVE_PARTY = 51,
        KICKED_FROM_XBOX_LIVE_PARTY = 52,
        NULLED = 53,
        DISCONNECTED_XBOX_LIVE_PARTY = 54,
        DOWNLOADED = 55,
        CANT_CONNECT_XBL_PARTY = 56,
        GAMERTAG_HAS_JOINED_XBL_PARTY = 57,
        GAMERTAG_HAS_LEFT_XBL_PARTY = 58,
        GAMER_PICTURE_UNLOCKED = 59,
        AVATAR_AWARD_UNLOCKED = 60,
        JOINED_XBL_PARTY = 61,
        PLEASE_REINSERT_USB_STORAGE_DEVICE = 62,
        PLAYER_MUTED = 63,
        PLAYER_UNMUTED = 64,
        FLASHING_CHAT_SYMBOL = 65,
        UPDATING = 76,
    }

    public enum TemperatureFlag
    {
        CPU,
        GPU,
        EDRAM,
        MotherBoard
    }
}