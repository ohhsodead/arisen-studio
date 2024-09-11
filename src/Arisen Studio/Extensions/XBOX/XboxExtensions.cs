using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using JRPC_Client;
using XDevkit;

namespace ArisenStudio.Extensions
{
    internal static class XboxExtensions
    {
        public static List<ConsoleProfile> ScanForConsoles(Form owner)
        {
            List<ConsoleProfile> consoles = [];

            IXboxManager xboxManager = new XboxManagerClass();

            foreach (IXboxConsole console in xboxManager.Consoles)
            {
                if (MainWindow.Settings.ConsoleProfiles.Exists(x => x.Platform == Platform.XBOX360 && x.Name.Equals(console.Name)))
                {
                    if (XtraMessageBox.Show(owner, string.Format(MainWindow.ResourceLanguage.GetString("CONSOLE_NAME_ALREADY_EXISTS"), console.Name), MainWindow.ResourceLanguage.GetString("DUPLICATE_NAME"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        consoles.Add(
                            new()
                            {
                                Id = DataExtensions.GenerateUniqueId(),
                                Name = console.Name,
                                Address = StringExtensions.UIntToIp(console.IPAddress),
                                Platform = Platform.XBOX360,
                                PlatformType = PlatformType.Xbox360FatWhite,
                                UseDefaultLogin = true
                            });
                    }
                }
                else
                {
                    consoles.Add(
                        new()
                        {
                            Id = DataExtensions.GenerateUniqueId(),
                            Name = console.Name,
                            Address = StringExtensions.UIntToIp(console.IPAddress),
                            Platform = Platform.XBOX360,
                            PlatformType = PlatformType.Xbox360FatWhite,
                            UseDefaultLogin = true
                        });
                }
            }

            return consoles;
        }

        public static void ScanForXboxConsoles(Form owner)
        {
            try
            {
                XboxManager xboxManager = new();

                int count = 0;

                foreach (string xbox in xboxManager.Consoles)
                {
                    if (MainWindow.Settings.ConsoleProfiles.Exists(x => x.Platform == Platform.XBOX360 && x.Name.Equals(xbox)))
                    {
                        if (XtraMessageBox.Show(owner, $"A console name: {xbox} already exists in your profiles.\n\nWould you like to it again?", "Duplicate Console", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            MainWindow.Settings.ConsoleProfiles.Add(
                                new()
                                {
                                    Name = xbox,
                                    Address = xbox,
                                    PlatformType = PlatformType.Xbox360EliteFatBlack,
                                    Platform = Platform.XBOX360
                                });

                            count++;
                        }
                    }
                    else
                    {
                        MainWindow.Settings.ConsoleProfiles.Add(
                               new()
                               {
                                   Name = xbox,
                                   Address = xbox,
                                   PlatformType = PlatformType.Xbox360EliteFatBlack,
                                   Platform = Platform.XBOX360
                               });

                        count++;
                    }
                }

                _ = XtraMessageBox.Show(owner, $"A total of {count} consoles were added to your profiles.", MainWindow.ResourceLanguage.GetString("XBOX_CONSOLES"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainWindow.Window.SetStatus("Unable to scan for Xbox consoles.", ex);
                _ = XtraMessageBox.Show(owner, $"Unable to scan for Xbox consoles.\n\nError: {ex.Message}", MainWindow.ResourceLanguage.GetString("XBOX_CONSOLES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ListItem GetXboxProfileFile(IXboxConsole xboxConsole, Form owner)
        {
            List<ListItem> consoleProfiles = [];
            List<string> consoleProfilesPaths = [];

            IXboxFiles xboxFiles = xboxConsole.DirectoryFiles(@"Hdd:\Content\");

            foreach (IXboxFile file in xboxFiles)
            {
                if (file.IsDirectory)
                {
                    _ = MessageBox.Show(file.Name);

                    if (!file.Name.Contains("0000000000000000"))
                    {
                        consoleProfilesPaths.Add(file.Name);
                    }
                }
            }

            foreach (string profile in consoleProfilesPaths)
            {
                string profilePath = @$"Hdd:\Content\{profile.Replace(@"Hdd:\Content\", string.Empty)}\FFFE07D1\00010000\";

                try
                {
                    foreach (IXboxFile file in xboxConsole.DirectoryFiles(profilePath))
                    {
                        if (!file.IsDirectory)
                        {
                            string profileName = profile.Replace(@"Hdd:\Content\", string.Empty).Replace(@"\FFFE07D1\00010000\", string.Empty);

                            consoleProfiles.Add(new()
                            {
                                Name = profileName,
                                Value = file.Name
                            });
                        }
                    }
                }
                catch
                {
                    // Profile file doesn't exist, so skip to next one
                    continue;
                }
            }

            if (consoleProfiles.Count > 0)
            {
                return DialogExtensions.ShowListViewDialog(owner, "Choose Profile", consoleProfiles);
            }
            else
            {
                return null;
            }
        }

        //public static void CreateDirectoryRecursive(this IXboxConsole xboxConsole, string path)
        //{
        //    Program.Log.Info($"Creating console directory path recursively: {path}");

        //    string[] directories = path.Split('\\');
        //    string currentPath = string.Empty;

        //    foreach (var directory in directories)
        //    {
        //        if (string.IsNullOrEmpty(directory))
        //            continue;

        //        currentPath += "\\" + directory;

        //        try
        //        {
        //            if (!currentPath.ContainsIgnoreCase("\\Hdd:"))
        //            {
        //                // Check if the directory exists
        //                if (!DirectoryExists(xboxConsole, currentPath))
        //                {
        //                    // Create the directory if it doesn't exist
        //                    xboxConsole.MakeDirectory(currentPath);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Program.Log.Error($"Failed to create directory '{currentPath}': {ex.Message}", ex);
        //            break;
        //        }
        //    }

        //    Program.Log.Info($"All directories have been created on the console.");
        //}

        public static void CreateDirectoryRecursive(this IXboxConsole xboxConsole, string path)
        {
            Program.Log.Info($"Creating console directory path recursively: {path}");

            // Normalize path to use Xbox format
            path = path.Replace("Hdd:\\", @"\Hdd:\");  // Ensures consistency in path format

            // Split the path into individual directories
            string[] directories = path.Split('\\');
            string currentPath = string.Empty;

            // Start creating directories after the root
            for (int i = 0; i < directories.Length; i++)
            {
                string directory = directories[i];

                if (string.IsNullOrEmpty(directory))
                    continue;

                // Skip the root ("Hdd:")
                if (directory.EndsWith(":"))
                {
                    currentPath = directory;  // Initialize with root (e.g., "Hdd:")
                    continue;
                }

                // Append the next directory to the path
                currentPath += "\\" + directory;

                try
                {
                    // Check if the directory exists
                    if (!DirectoryExists(xboxConsole, currentPath))
                    {
                        // Create the directory if it doesn't exist
                        xboxConsole.MakeDirectory(currentPath);
                    }
                }
                catch (Exception ex)
                {
                    Program.Log.Error($"Failed to create directory '{currentPath}': {ex.Message}");
                    break;
                }
            }

            Program.Log.Info($"All directories have been created on the console.");
        }

        public static bool DirectoryExists(this IXboxConsole xboxConsole, string path)
        {
            // This is a placeholder for a method that checks if the directory exists.
            // In the XDevKit API, there is no direct method like `Directory.Exists` in .NET, 
            // so you would need to use another method, such as trying to list files or handling exceptions.

            try
            {
                Program.Log.Info($"Checking if directory exists: {path}");

                // Attempt to list the files in the directory
                xboxConsole.DirectoryFiles(path);
                return true;
            }
            catch (Exception ex)
            {
                // If an exception is thrown, assume the directory does not exist
                Program.Log.Error($"Failed to check directory, assuming it doesn't exist. Error: {ex.Message}", ex);
                return false;
            }
        }

        public static string GetParentFolder(string filePath)
        {
            // Find the last occurrence of the backslash character
            int lastSlashIndex = filePath.LastIndexOf('\\');

            if (lastSlashIndex > 0)
            {
                // Extract the substring up to (but not including) the last backslash
                return filePath.Substring(0, lastSlashIndex);
            }

            // If there's no backslash, return an empty string (or handle as needed)
            return string.Empty;
        }

        public static bool PathExists(string path, string dirName)
        {
            IXboxFiles xboxDirectories = MainWindow.XboxConsole.DirectoryFiles(path);

            for (int i = 0; i < xboxDirectories.Count; i++)
            {
                if (xboxDirectories[i].IsDirectory && xboxDirectories[i].Name == (path + dirName))
                    return true;
            }
            return false;
        }

        public static bool FileExists(string path, string pathWithFileName)
        {
            IXboxFiles xboxDirectories = MainWindow.XboxConsole.DirectoryFiles(path);

            for (int i = 0; i < xboxDirectories.Count; i++)
            {
                if (!xboxDirectories[i].IsDirectory && xboxDirectories[i].Name == pathWithFileName)
                    return true;
            }
            return false;
        }

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

        public static void ChangeXboxName(this IXboxConsole console, string name)
        {
            console.SendTextCommand(0, "dbgname name=" + name, out _);
        }

        public static void ChangeXboxIcon(this IXboxConsole console, IconColor icon)
        {
            console.SendTextCommand(0, "setcolor name=" + icon.ToString().ToLower(), out _);
        }

        /// <summary>
        /// Open/Closes the tray
        /// </summary>
        /// <param name="console"></param>
        /// <param name="state"></param>
        public static void SetTrayState(this IXboxConsole console, TrayState state)
        {
            switch (state)
            {
                case TrayState.Open:
                    console.CallVoid(console.ResolveFunction("xam.xex", (int)XboxShortcuts.OpenTray), [0, 0, 0, 0]);
                    break;
                case TrayState.Close:
                    console.CallVoid(console.ResolveFunction("xam.xex", (int)XboxShortcuts.CloseTray), [0, 0, 0, 0]);
                    break;
            }
        }

        /// <summary>
        /// Controls the fan speed
        /// </summary>
        /// <param name="console"></param>
        /// <param name="value1"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool SetFanSpeed(this IXboxConsole console, int value1, int input)
        {
            uint uint0 = console.ResolveFunction("xboxkrnl.exe", 0x29);
            byte[] byte0 = new byte[0x10];
            byte[] byte1 = new byte[0x10];
            Array.Clear(byte0, 0, byte0.Length);
            Array.Clear(byte1, 0, byte1.Length);
            if (value1 == 1)
            {
                byte0[0] = 0x94;
            }
            else
            {
                if (value1 != 2)
                {
                    return false;
                }
                byte0[0] = 0x89;
            }
            if (input > 100)
            {
                input = 100;
            }
            if (input <= 0)
            {
                input = 10;
            }
            if (input < 0x2d)
            {
                byte0[1] = 0x7f;
            }
            else
            {
                byte0[1] = (byte)(input | 0x80);
            }
            object[] arguments = new object[2];
            arguments[0] = byte0;
            console.CallVoid(uint0, arguments);
            return true;
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

        public static void LaunchXex(this IXboxConsole console, string xexPath, string xexDirectory)
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
        public static uint GetTitleId(this IXboxConsole console)
        {
            try
            {
                //object[] objArray = new object[] { "consolefeatures ver=", "2", " type=16 params=\"A\\0\\A\\0\\\"" };
                //string command = string.Concat(objArray);
                //console.SendTextCommand(0, command, out string response);
                //return uint.Parse(response.Substring(Find(response, " ") + 1), NumberStyles.HexNumber);

                return console.XamGetCurrentTitleId();
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Couldn't get current title ID");
                return 0;
            }
        }

        public static uint GetCurrentTitleId(this IXboxConsole console)
        {
            try
            {
                return Call<uint>(console, "xam.xex", 463, []);

                //return console.ResolveFunction("xam.xex", 463);
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

        private static readonly byte[] MemoryBuffer = new byte[32];

        public static byte[] ReadBytes(this IXboxConsole xbCon, uint offset, uint size)
        {
            byte[] temp = new byte[size];
            xbCon.DebugTarget.GetMemory(offset, size, temp, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, size);
            return temp;
        }

        public static sbyte ReadSByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return (sbyte)MemoryBuffer[0];
        }

        public static bool ReadBool(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return MemoryBuffer[0] != 0;
        }

        public static short ReadInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(MemoryBuffer, 0, 2);
            return BitConverter.ToInt16(MemoryBuffer, 0);
        }

        public static int ReadInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(MemoryBuffer, 0, 4);
            return BitConverter.ToInt32(MemoryBuffer, 0);
        }

        public static long ReadInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(MemoryBuffer, 0, 8);
            return BitConverter.ToInt64(MemoryBuffer, 0);
        }

        public static byte ReadByte(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 1, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 1);
            return MemoryBuffer[0];
        }

        public static ushort ReadUInt16(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 2, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 2);
            Array.Reverse(MemoryBuffer, 0, 2);
            return BitConverter.ToUInt16(MemoryBuffer, 0);
        }

        public static uint ReadUInt32(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(MemoryBuffer, 0, 4);
            return BitConverter.ToUInt32(MemoryBuffer, 0);
        }

        public static ulong ReadUInt64(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 8, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 8);
            Array.Reverse(MemoryBuffer, 0, 8);
            return BitConverter.ToUInt64(MemoryBuffer, 0);
        }

        public static float ReadFloat(this IXboxConsole xbCon, uint offset)
        {
            xbCon.DebugTarget.GetMemory(offset, 4, MemoryBuffer, out _);
            xbCon.DebugTarget.InvalidateMemoryCache(true, offset, 4);
            Array.Reverse(MemoryBuffer, 0, 4);
            return BitConverter.ToSingle(MemoryBuffer, 0);
        }

        public static short ReadShort(this IXboxConsole xbCon, uint address)
        {
            short result;

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
            return ReadString(xbCon, offset, MemoryBuffer);
        }

        public static void WriteSByte(this IXboxConsole xbCon, uint offset, sbyte input)
        {
            MemoryBuffer[0] = (byte)input;
            xbCon.DebugTarget.SetMemory(offset, 1, MemoryBuffer, out _);
        }

        public static void WriteInt16(this IXboxConsole xbCon, uint offset, short input)
        {
            BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
            Array.Reverse(MemoryBuffer, 0, 2);
            xbCon.DebugTarget.SetMemory(offset, 2, MemoryBuffer, out _);
        }
        public static void WriteInt32(this IXboxConsole xbCon, uint offset, int input)
        {
            BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
            Array.Reverse(MemoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, MemoryBuffer, out _);
        }

        public static void WriteInt64(this IXboxConsole xbCon, uint offset, long input)
        {
            BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
            Array.Reverse(MemoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, MemoryBuffer, out _);
        }

        //public static void WriteByte(this IXboxConsole xbCon, uint offset, byte input)
        //{
        //    MemoryBuffer[0] = input;
        //    xbCon.DebugTarget.SetMemory(offset, 1, MemoryBuffer, out _);
        //}

        //public static void WriteUInt16(this IXboxConsole xbCon, uint offset, ushort input)
        //{
        //    BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
        //    Array.Reverse(MemoryBuffer, 0, 2);
        //    xbCon.DebugTarget.SetMemory(offset, 2, MemoryBuffer, out _);
        //}

        //public static void WriteUInt32(this IXboxConsole xbCon, uint offset, uint input)
        //{
        //    BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
        //    Array.Reverse(MemoryBuffer, 0, 4);
        //    xbCon.DebugTarget.SetMemory(offset, 4, MemoryBuffer, out _);
        //}

        public static void WriteUInt64(this IXboxConsole xbCon, uint offset, ulong input)
        {
            BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
            Array.Reverse(MemoryBuffer, 0, 8);
            xbCon.DebugTarget.SetMemory(offset, 8, MemoryBuffer, out _);
        }

        public static void WriteFloat(this IXboxConsole xbCon, uint offset, float input)
        {
            BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
            Array.Reverse(MemoryBuffer, 0, 4);
            xbCon.DebugTarget.SetMemory(offset, 4, MemoryBuffer, out _);
        }

        public static void Push(this byte[] inArray, out byte[] outArray, byte value)
        {
            outArray = new byte[inArray.Length + 1];
            inArray.CopyTo(outArray, 0);
            outArray[inArray.Length] = value;
        }

        public static void WriteString(this IXboxConsole xbCon, uint address, string @string)
        {
            byte[] array = [];
            for (int i = 0; i < @string.Length; i++)
            {
                byte value = (byte)@string[i];
                array.Push(out array, value);
            }
            array.Push(out array, 0);
            xbCon.DebugTarget.SetMemory(address, (uint)array.Length, array, out _);
        }

        public static void WriteBytes(this IXboxConsole xbCon, uint offset, byte[] memory)
        {
            xbCon.DebugTarget.SetMemory(offset, (uint)memory.Length, memory, out _);
        }
    }

    public enum IconColor
    {
        Black,
        Blue,
        BlueGray,
        NoSideCar,
        White,
    }

    public enum XNotifyLogo : uint
    {
        XboxLogo = 0,
        NewMessageLogo = 1,
        FriendRequestLogo = 2,
        NewMessage = 3,
        FlashingXboxLogo = 4,
        GamertagSentYouAMessage = 5,
        GamertagSingedOut = 6,
        GamertagSignedin = 7,
        GamertagSignedIntoXboxLive = 8,
        GamertagSignedInOffline = 9,
        GamertagWantsToChat = 10,
        DisconnectedFromXboxLive = 11,
        Download = 12,
        FlashingMusicSymbol = 13,
        FlashingHappyFace = 14,
        FlashingFrowningFace = 15,
        FlashingDoubleSidedHammer = 16,
        GamertagWantsToChat2 = 17,
        PleaseReinsertMemoryUnit = 18,
        PleaseReconnectControllerm = 19,
        GamertagHasJoinedChat = 20,
        GamertagHasLeftChat = 21,
        GameInviteSent = 22,
        FlashLogo = 23,
        PageSentTo = 24,
        Four2 = 25,
        Four3 = 26,
        AchievementUnlocked = 27,
        Four9 = 28,
        GamertagWantsToTalkInVideoKinect = 29,
        VideoChatInviteSent = 30,
        ReadyToPlay = 31,
        CantDownloadX = 32,
        DownloadStoppedForX = 33,
        FlashingXboxConsole = 34,
        XSentYouAGameMessage = 35,
        DeviceFull = 36,
        Four7 = 37,
        FlashingChatIcon = 38,
        AchievementsUnlocked = 39,
        XHasSentYouANudge = 40,
        MessengerDisconnected = 41,
        Blank = 42,
        CantSignInMessenger = 43,
        MissedMessengerConversation = 44,
        FamilyTimerXTimeRemaining = 45,
        DisconnectedXboxLive11MinutesRemaining = 46,
        KinectHealthEffects = 47,
        Four5 = 48,
        GamertagWantsYouToJoinAnXboxLiveParty = 49,
        PartyInviteSent = 50,
        GameInviteSentToXboxLiveParty = 51,
        KickedFromXboxLiveParty = 52,
        Nulled = 53,
        DisconnectedXboxLiveParty = 54,
        Downloaded = 55,
        CantConnectXblParty = 56,
        GamertagHasJoinedXblParty = 57,
        GamertagHasLeftXblParty = 58,
        GamerPictureUnlocked = 59,
        AvatarAwardUnlocked = 60,
        JoinedXblParty = 61,
        PleaseReinsertUsbStorageDevice = 62,
        PlayerMuted = 63,
        PlayerUnmuted = 64,
        FlashingChatSymbol = 65,
        Updating = 76,
    }

    public enum TemperatureFlag
    {
        Cpu,
        Gpu,
        Edram,
        MotherBoard
    }

    public enum TrayState
    {
        Open,
        Close
    }

    public enum XboxShortcuts : int
    {
        //Main Shortcut
        Recent = 0x2C8,
        GuideButton = 0x506,
        //End Of Main Shortcut

        //Games And Apps Tab
        Achievements = 0x2D0,
        Awards = 0x03C6,
        MyGames,
        ActiveDownloads = 0x02E7,
        RedeemCode,
        //End Of Games And Apps Tab

        //Main Guide
        XboxHome,
        Friends = 0x2BF,
        Party = 0x0305,
        Messages = 0x2C0,
        BeaconsAndActiviy = 0xB39,
        PrivateChat = 0x2C2,
        OpenTray = 0x60,
        CloseTray = 0x62,
        //End Of Main Guide

        //Media
        SystemVideoPlayer = 2,
        SystemMusicPlayer = 1,
        PictureViewer,
        WindowsMediaCenter,
        SelectMusic = 0,
        //End Of Media

        //settings
        DriveSelector = 5,
        Profile = 0x2c4,
        Preferences,
        FamilySettings,
        SystemSettings,
        AccountManagement = 4,
        TurnOffConsole = 0x0295,
        AvatarEditor = 0xB3A
        //End Of settings

    };
}