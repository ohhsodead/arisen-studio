//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

namespace XDevkit
{
    /// <summary>
    /// Xbox Emulation Class
    /// Made By TeddyHammer
    /// </summary>
    public partial class Xbox
    {
        private const string XAMModule = "xam.xex";
        private const string krnlModule = "xboxkrnl.exe";
        #region Features
        public string GetAvatarURL(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<img src=\"(.*)\" alt=\"(.*)\" title=\"(.*)\" class=\"avatarBig\" />";
            return Regex.Matches(input, pattern)[0].Groups[1].Value.Split(new char[]
            {
                '"'
            })[0];
        }

        public string GetGamerPicture(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2) 
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<img src=\"(.*)\" alt=\"(.*)\" title=\"(.*)\" class=\"avatarTile\"/>";
            return Regex.Matches(input, pattern)[0].Groups[1].Value.Split(new char[]
            {
                '"'
            })[0];
        }

        public string TotalGames(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<p class=\"\">Total Games Played: (.*)</p>";
            return Regex.Matches(input, pattern)[0].Groups[1].Value;
        }

        public string GamesCompleted(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<p class=\"\">Games Completed: (.*)</p>";
            return Regex.Matches(input, pattern)[0].Groups[1].Value;
        }

        public string AverageCompleted(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<p class=\"\">Average Completion: (.*)</p>";
            return Regex.Matches(input, pattern)[0].Groups[1].Value;
        }

        public string LastSeen(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "Last seen (.*)";
            return Regex.Matches(input, pattern)[0].Groups[1].Value;
        }

        public string Gamerscore(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<p class=\"rightGS\"><img src=\"/resources/images/gamerscore_icon.png\" alt=\"(.*)\" title=\"(.*)\">(.*)</p>";
            return Regex.Matches(input, pattern)[0].Groups[3].Value.Replace(" ", string.Empty);
        }

        public List<string> GetRecentGames(string gamertag)
        {
            bool flag = gamertag.Contains(" ");
            bool flag2 = flag;
            if (flag2)
            {
                gamertag.Replace(" ", "+");
            }
            List<string> list = new List<string>();
            string input = new WebClient().DownloadString(string.Format("https://www.xboxgamertag.com/search/{0}", gamertag));
            string pattern = "<p class=\"gameName\"><a href=\"(.*)\">(.*)</a></p>";
            foreach (Match match in new Regex(pattern).Matches(input))
            {
                list.Add(match.Groups[2].Value);
            }
            return list;
        }


        public void NOP(uint address)
        {
            
            byte[] buffer1 = new byte[4];
            buffer1[0] = 0x60;
            byte[] data = buffer1;
            SetMemory(address, data);
        }

        public static void X360Text(string a)
        {

            XNotify.Show(a);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="MediaDirectory"></param>
        /// <param name="CmdLine"></param>
        /// <param name="Flags"></param>
        public void Reboot(string Name, string MediaDirectory, string CmdLine, XboxRebootFlags Flags)
        {
            
            string[] lines = Name.Split("\\".ToCharArray());
            for (int i = 0; i < lines.Length - 1; i++)
                MediaDirectory += lines[i] + "\\";
            object[] Reboot = new object[] { $"magicboot title=\"{Name}\" directory=\"{MediaDirectory}\"" };//todo
            SendTextCommand(string.Concat(Reboot));
        }

        /// <summary>
        /// Shortcuts To Guide
        /// </summary>
        /// <param name="Color"></param>
        public void XboxShortcut(XboxShortcuts UI)
        {
            
            if (XboxName.Connected)
                switch (UI)//works by getting the int of the UI and matches the numbers to execute things
                {
                    case XboxShortcuts.XboxHome:
                        Reboot(@"\Device\Harddisk0\SystemExtPartition\20449700\dash.xex",
                               @"\Device\Harddisk0\SystemExtPartition\20449700\dash.xex",
                               @"\Device\Harddisk0\SystemExtPartition\20445700\dash.xex", XboxRebootFlags.Title);
                        break;
                    case XboxShortcuts.AvatarEditor:
                        Reboot(@"\Device\Harddisk0\SystemExtPartition\20449700\AvatarEditor.xex",
                               @"\Device\Harddisk0\SystemExtPartition\20449700\AvatarEditor.xex",
                               @"\Device\Harddisk0\SystemExtPartition\20449700\AvatarEditor.xex", XboxRebootFlags.Title);

                        break;

                    case XboxShortcuts.Turn_Off_Console:
                        ShutDownConsole();
                        break;
                    case XboxShortcuts.Account_Management:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Account_Management),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Achievements:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Achievements),
                                      new object[]
                            { 0, 0, 0, 0 });//achievements
                        break;
                    case XboxShortcuts.Active_Downloads:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Active_Downloads),
                                      new object[]
                            { 0, 0, 0, 0 });//XamShowMarketplaceDownloadItemsUI
                        break;
                    case XboxShortcuts.Awards:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Awards),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Beacons_And_Activiy:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Beacons_And_Activiy),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Family_Settings:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Family_Settings),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Friends:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Friends),
                                      new object[]
                            { 0, 0, 0, 0 });//friends
                        break;
                    case XboxShortcuts.Guide_Button:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Guide_Button),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Messages:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Messages), 0);//messages tab
                        break;
                    case XboxShortcuts.My_Games:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.My_Games),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Open_Tray:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Open_Tray), new object[] { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Close_Tray:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Close_Tray),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Party:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Party), new object[] { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Preferences:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Preferences),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Private_Chat:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Private_Chat),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Profile:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Profile),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Recent:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Recent),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Redeem_Code:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Redeem_Code),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Select_Music:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Select_Music),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.System_Music_Player:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.System_Music_Player),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.System_Settings:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.System_Settings),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.System_Video_Player:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.System_Video_Player),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                    case XboxShortcuts.Windows_Media_Center:
                        XboxExtention.CallVoid(ResolveFunction(XAMModule, (int)XboxShortcuts.Windows_Media_Center),
                                      new object[]
                            { 0, 0, 0, 0 });
                        break;
                }
        }

        /// <summary>
        /// Get's Box Id.
        /// </summary>
        /// <param name="fileName">File to delete.</param>
        public string GetBoxID()
        {
            
            return SendTextCommand("BOXID").Replace("200- ", string.Empty);
        }

        /// <summary>
        /// Turns The Console's Default Neighborhood Icon to any of the following...(black , blue , bluegray , nosidecar
        /// , white) Also Changes The Type Of Console It Is.
        /// </summary>
        /// <param name="Color"></param>
        public void SetConsoleColor(XboxColor Color)
        {
            
            SendTextCommand("setcolor name=" + Enum.GetName(typeof(int), Color).ToLower());
        }

        /// <summary>
        /// Get's The Consoles ID.
        /// </summary>
        /// <returns></returns>
        public string GetConsoleID()
        {
            
            return SendTextCommand(string.Concat("getconsoleid")).Replace("200- consoleid=", string.Empty);
        }

        /// <summary>
        /// Gets the debug Monitor version Number.
        /// </summary>
        public string GetDMVersion()
        {
            
            return SendTextCommand("dmversion").Replace("200- ", string.Empty);

        }

        /// <summary>
        /// Get's Consoles System Information.
        /// </summary>
        /// <param name="Type"></param>
        /// <returns>Type Is The System Type Of Information you Want To Retrieve</returns>
        public string GetSystemInfo(Info Type)
        {
            if (XboxName == null)
            {
                Console.WriteLine("Console Is Not Connnected...");
            }
            else
            {
                Console.WriteLine("System Info Came Threw.. (Command Executed == " + Type + " )");
                switch (Type)
                {
                    case Info.HDD:
                        #region HDD
                        try
                        {
                            SendTextCommand(string.Concat("systeminfo"));
                            string[] Info = new[] { ReceiveMultilineResponse().ToString().ToLower() };
                            foreach (string s in Info)
                            {
                                int Start = s.IndexOf("hdd=");
                                int End = s.IndexOf("type=");
                                return s.Substring(Start + 4, End - 4);
                            }
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                    case Info.Type:
                        #region Console Type
                        try
                        {
                            return SendTextCommand(string.Concat("consoletype")).Replace("200- ", string.Empty);
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                    case Info.Platform:
                        #region Platform
                        try
                        {
                            SendTextCommand(string.Concat("systeminfo"));
                            string[] Info = new[] { ReceiveMultilineResponse().ToString().ToLower() };
                            foreach (string s in Info)
                            {
                                int Start = s.IndexOf("type=");
                                int End = s.IndexOf(" p");
                                return s.Substring(Start + 9, End - 1).Substring(Start);
                            }
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                    case Info.System:
                        #region System
                        try
                        {
                            SendTextCommand(string.Concat("systeminfo"));
                            string[] Info = new[] { ReceiveMultilineResponse().ToString().ToLower() };
                            foreach (string s in Info)
                            {
                                int Start = s.IndexOf("type=");
                                int End = s.IndexOf(" p");
                                return s.Substring(Start + End + 4, End - 4).Substring(Start);
                            }
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                    case Info.BaseKrnlVersion:
                        #region BaseKrnlVersion
                        try
                        {
                            SendTextCommand(string.Concat("systeminfo"));
                            string[] Info = new[] { ReceiveMultilineResponse().ToString().ToLower() };
                            foreach (string s in Info)
                            {
                                int Start = s.IndexOf(" krnl=");
                                int End = s.IndexOf(" ");
                                return s.Substring(Start - 10, End);
                            }
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                    case Info.KrnlVersion:
                        #region Kernal Version
                        try
                        {
                            SendTextCommand(string.Concat("systeminfo"));
                            string[] Info = new[] { ReceiveMultilineResponse().ToString().ToLower() };
                            foreach (string s in Info)
                            {
                                int Start = s.IndexOf(" krnl=");
                                int End = s.IndexOf(" ");
                                return s.Substring(Start + 6, End);
                            }
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                    case Info.XDKVersion:
                        #region XDK Version
                        try
                        {
                            SendTextCommand(string.Concat("systeminfo"), out Response);
                            string[] Info = new[] { ReceiveMultilineResponse().ToString().ToLower() };
                            foreach (string s in Info)
                            {
                                return s.Substring(s.IndexOf("xdk=") + 4, 12);
                            }
                        }
                        catch
                        {
                        }
                        #endregion
                        break;
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// Reboot Method flag types cold or warm reboot.
        /// </summary>
        public void Reboot(XboxReboot Warm_or_Cold)
        {
            
            if (Warm_or_Cold == XboxReboot.Cold)
            {
                SendTextCommand("magicboot cold");
            }
            if (Warm_or_Cold == XboxReboot.Warm)
            {
                SendTextCommand("magicboot warm");
            }
        }

        /// <summary>
        /// Freezes/Stops Console.
        /// </summary>
        public void Freeze_Console(XboxSwitch Freeze)
        {
            
            if (Freeze == XboxSwitch.True)
            {
                SendTextCommand("stop");
            }
            else if (Freeze == XboxSwitch.False)
            {
                SendTextCommand("go");
            }
        }
        /// <summary>
        /// XBEINFO Console.
        /// </summary>
        public string XBEINFO()
        {
            
            SendTextCommand("XBEINFO RUNNING");
            string str1 = ReceiveMultilineResponse();
            return str1.Substring(str1.find("name"));
        }
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string ConsoleType()
        {
            
            string str = string.Concat("consolefeatures ver=", 2, " type=17 params=\"A\\0\\A\\0\\\"");
            string str1 = SendTextCommand(str);
            return str1.Substring(str1.find(" ") + 1);
        }

        /// <summary>
        /// Retrieve's The Console's Central Processing Unit Key.
        /// </summary>
        public string GetCPUKey()
        {
            
            string str = string.Concat("consolefeatures ver=", 2, " type=10 params=\"A\\0\\A\\0\\\"");
            return SendTextCommand(str).Replace("200- ", string.Empty);
        }


        /// <summary>
        /// Version Of Kernal
        /// </summary>
        /// <returns></returns>
        public uint GetKernalVersion()
        {
            
            string str = string.Concat("consolefeatures ver=", 2, " type=13 params=\"A\\0\\A\\0\\\"");
            string str1 = SendTextCommand(str);
            return uint.Parse(str1.Substring(str1.find(" ") + 1));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="TemperatureType"></param>
        /// <returns></returns>
        public uint GetTemperature(TemperatureFlag TemperatureType)
        {
            
            object[] Version = new object[]
            { "consolefeatures ver=", 2, " type=15 params=\"A\\0\\A\\1\\", 1, "\\", (int)TemperatureType, "\\\"" };
            string str = SendTextCommand(string.Concat(Version));
            return uint.Parse(str.Substring(str.find(" ") + 1), NumberStyles.HexNumber);
        }

        #region Console Tempatures
        public string CPUTEMP() { return GetTemperature(TemperatureFlag.CPU) + "\x00b0C".ToString() + "%"; }
        public string GPUTEMP() { return GetTemperature(TemperatureFlag.GPU) + "\x00b0C".ToString() + "%"; }
        public string RamTEMP() { return GetTemperature(TemperatureFlag.EDRAM) + "\x00b0C".ToString() + "%"; }
        public string MOBOTEMP() { return GetTemperature(TemperatureFlag.MotherBoard) + "\x00b0C".ToString() + "%"; }
        #endregion

        /// <summary>
        ///
        /// </summary>
        /// <param name="Top_Left"></param>
        /// <param name="Top_Right"></param>
        /// <param name="Bottom_Left"></param>
        /// <param name="Bottom_Right"></param>
        public void SetLeds(LEDState Top_Left, LEDState Top_Right, LEDState Bottom_Left, LEDState Bottom_Right)
        {
            
            object[] Resolver = new object[]
            {
                "consolefeatures ver=",
                2,
                " type=14 params=\"A\\0\\A\\4\\",
                1,
                "\\",
                (uint)Top_Left,
                "\\",
                1,
                "\\",
                (uint)Top_Right,
                "\\",
                1,
                "\\",
                (uint)Bottom_Left,
                "\\",
                1,
                "\\",
                (uint)Bottom_Right,
                "\\\""
            };
            SendTextCommand(string.Concat(Resolver));
        }
        private uint GetModuleHandle(string ModuleName)
        {
            object[] arguments = new object[] { ModuleName };
            return Call<uint>(ModuleName, 0x44e, arguments);
        }
        private uint LaunchSystemDLLThread(string ThreadPath)
        {
            object[] arguments = new object[] { ThreadPath, 8, 0, 0 };
            return Call<uint>(krnlModule, 0x199, arguments);
        }
        private void UnloadImage(string ModuleName, bool isSysDll)
        {
            uint moduleHandle = GetModuleHandle(ModuleName);
            if (moduleHandle != 0)
            {
                if (isSysDll)
                {
                    GetInt16(moduleHandle + 0x40, 1);
                }
                object[] arguments = new object[] { moduleHandle };
                XboxExtention.CallVoid(krnlModule, 0x1a1, arguments);
            }
        }

        private uint XexPcToFileHeader(uint baseAddress)
        {
            uint num3;
            uint address = ResolveFunction(krnlModule, 0x19c);
            if (address == 0)
            {
                num3 = 0;
            }
            else
            {
                uint num2 = ResolveFunction(XAMModule, 0xa29) + 0x3000;
                object[] arguments = new object[] { baseAddress, num2 };
                XboxExtention.CallVoid(address, arguments);
                num3 = GetUInt32(num2);
            }
            return num3;
        }
        /// <summary>
        /// Gets a list of modules loaded by the xbox.
        /// </summary>
        public List<ModuleInfo> Modules { get { return modules; } }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly List<ModuleInfo> modules = null;
        /// <summary>
        /// Gets the notification listener registered with the xbox that listens for incoming notification session requests.
        /// </summary>
        [Browsable(false)]
        public TcpListener NotificationListener { get { return notificationListener; } }



        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly TcpListener notificationListener = null;
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public uint XamGetCurrentTitleId()
        {
            
            string str = string.Concat("consolefeatures ver=", 2, " type=16 params=\"A\\0\\A\\0\\\"");
            string str1 = SendTextCommand(str);
            return uint.Parse(str1.Substring(str1.find(" ") + 1), NumberStyles.HexNumber);
        }

        /// <summary>
        /// Turns Off Console.
        /// </summary>
        public void ShutDownConsole()
        {
            try
            {
                string str = string.Concat("consolefeatures ver=", 2, " type=11 params=\"A\\0\\A\\0\\\"");
                SendTextCommand(str);
            }
            catch
            {
            }
        }

        #endregion
        private object CallArgs(bool SystemThread, uint Type, Type t, string module, int ordinal, uint Address, uint ArraySize, params object[] Arguments)
        {
            uint Void = 0;
            uint Int = 1;
            uint Float = 3;
            uint ByteArray = 7;
            uint Uint64 = 8;
            uint Uint64Array = 9;
            uint Version = 2;
            if (!XboxExtention.IsValidReturnType(t))
                throw new Exception("Invalid type " + t.Name + Environment.NewLine + "supports Only: bool, byte, short, int, long, ushort, uint, ulong, float, double");
            ConnectTimeout = ConversationTimeout = 4000000U;
            object[] objArray1 = new object[13];
            objArray1[0] = "consolefeatures ver=";
            objArray1[1] = Version;
            objArray1[2] = " type=";
            objArray1[3] = Type;
            objArray1[4] = SystemThread ? " system" : "";
            object[] objArray2 = objArray1;
            string str1;
            if (module == null)
                str1 = "";
            else
                str1 = " module=\"" + module + "\" ord=" + ordinal;
            objArray2[5] = str1;
            objArray1[6] = " as=";
            objArray1[7] = ArraySize;
            objArray1[8] = " params=\"A\\";
            objArray1[9] = Address.ToString("X");
            objArray1[10] = "\\A\\";
            objArray1[11] = Arguments.Length;
            objArray1[12] = "\\";
            string str2 = string.Concat(objArray1);
            if (Arguments.Length > 37)
                throw new Exception("Can not use more than 37 paramaters in a call");
            foreach (object o in Arguments)
            {
                bool flag1 = false;
                if (o is uint num)
                {

                    str2 = str2 + Int + "\\" + Functions.UIntToInt(num) + "\\";
                    flag1 = true;
                }
                if (o is int || o is bool || o is byte)
                {
                    if (o is bool flag)
                        str2 = str2 + Int + "/" + Convert.ToInt32(flag) + "\\";
                    else
                        str2 = str2 + Int + "\\" + (o is byte ? Convert.ToByte(o).ToString() : Convert.ToInt32(o).ToString()) + "\\";
                    flag1 = true;
                }
                else if (o is int[] || o is uint[])
                {
                    byte[] numArray = Functions.IntArrayToByte((int[])o);
                    string str3 = str2 + ByteArray.ToString() + "/" + numArray.Length + "\\";
                    for (int index = 0; index < numArray.Length; ++index)
                        str3 += numArray[index].ToString("X2");
                    str2 = str3 + "\\";
                    flag1 = true;
                }
                else if (o is string)
                {
                    string str3 = (string)o;
                    str2 = str2 + ByteArray.ToString() + "/" + str3.Length + "\\" + ((string)o).ToHexString() + "\\";
                    flag1 = true;
                }
                else if (o is double)
                {
                    str2 = str2 + Float.ToString() + "\\" + o.ToString() + "\\";
                    flag1 = true;
                }
                else if (o is float)
                {
                    str2 = str2 + Float.ToString() + "\\" + o.ToString() + "\\";
                    flag1 = true;
                }
                else if (o is float[])
                {
                    float[] numArray = (float[])o;
                    string str3 = str2 + ByteArray.ToString() + "/" + (numArray.Length * 4).ToString() + "\\";
                    for (int index1 = 0; index1 < numArray.Length; ++index1)
                    {
                        byte[] bytes = BitConverter.GetBytes(numArray[index1]);
                        Array.Reverse(bytes);
                        for (int index2 = 0; index2 < 4; ++index2)
                            str3 += bytes[index2].ToString("X2");
                    }
                    str2 = str3 + "\\";
                    flag1 = true;
                }
                else if (o is byte[])
                {
                    byte[] numArray = (byte[])o;
                    string str3 = str2 + ByteArray.ToString() + "/" + numArray.Length + "\\";
                    for (int index = 0; index < numArray.Length; ++index)
                        str3 += numArray[index].ToString("X2");
                    str2 = str3 + "\\";
                    flag1 = true;
                }
                if (!flag1)
                    str2 = str2 + Uint64.ToString() + "\\" + Functions.ConvertToUInt64(o).ToString() + "\\";
            }
            string Command = str2 + "\"";
            string String = SendTextCommand(Command);
            uint num1;
            for (string _Ptr = "buf_addr="; String.Contains(_Ptr); String = SendTextCommand("consolefeatures " + _Ptr + "0x" + num1.ToString("X")))
            {
                Thread.Sleep(250);
                num1 = uint.Parse(String.Substring(String.find(_Ptr) + _Ptr.Length), NumberStyles.HexNumber);
            }
            ConversationTimeout = 2000U;
            ConnectTimeout = 5000U;
            switch (Type)
            {
                case 1:
                    uint num2 = uint.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(uint))
                        return num2;
                    if (t == typeof(int))
                        return Functions.UIntToInt(num2);
                    if (t == typeof(short))
                        return short.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(ushort))
                        return ushort.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    break;
                case 2:
                    string str4 = String.Substring(String.find(" ") + 1);
                    if (t == typeof(string))
                        return str4;
                    if (t == typeof(char[]))
                        return str4.ToCharArray();
                    break;
                case 3:
                    if (t == typeof(double))
                        return double.Parse(String.Substring(String.find(" ") + 1));
                    if (t == typeof(float))
                        return float.Parse(String.Substring(String.find(" ") + 1));
                    break;
                case 4:
                    byte num3 = byte.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(byte))
                        return num3;
                    if (t == typeof(char))
                        return (char)num3;
                    break;
                case 8:
                    if (t == typeof(long))
                        return long.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(ulong))
                        return ulong.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    break;
            }
            switch (Type)
            {
                case 5:
                    string str5 = String.Substring(String.find(" ") + 1);
                    int index3 = 0;
                    string s1 = "";
                    uint[] numArray1 = new uint[8];
                    foreach (char ch in str5)
                    {
                        switch (ch)
                        {
                            case ',':
                            case ';':
                                numArray1[index3] = uint.Parse(s1, NumberStyles.HexNumber);
                                ++index3;
                                s1 = "";
                                break;
                            default:
                                s1 += ch.ToString();
                                break;
                        }
                        if (ch == ';')
                            break;
                    }
                    return numArray1;
                case 6:
                    string str6 = String.Substring(String.find(" ") + 1);
                    int index4 = 0;
                    string s2 = "";
                    float[] numArray2 = new float[ArraySize];
                    foreach (char ch in str6)
                    {
                        switch (ch)
                        {
                            case ',':
                            case ';':
                                numArray2[index4] = float.Parse(s2);
                                ++index4;
                                s2 = "";
                                break;
                            default:
                                s2 += ch.ToString();
                                break;
                        }
                        if (ch == ';')
                            break;
                    }
                    return numArray2;
                case 7:
                    string str7 = String.Substring(String.find(" ") + 1);
                    int index5 = 0;
                    string s3 = "";
                    byte[] numArray3 = new byte[ArraySize];
                    foreach (char ch in str7)
                    {
                        switch (ch)
                        {
                            case ',':
                            case ';':
                                numArray3[index5] = byte.Parse(s3);
                                ++index5;
                                s3 = "";
                                break;
                            default:
                                s3 += ch.ToString();
                                break;
                        }
                        if (ch == ';')
                            break;
                    }
                    return numArray3;
                default:
                    if ((int)Type == (int)Uint64Array)
                    {
                        string str3 = String.Substring(String.find(" ") + 1);
                        int index1 = 0;
                        string s4 = "";
                        ulong[] numArray4 = new ulong[ArraySize];
                        foreach (char ch in str3)
                        {
                            switch (ch)
                            {
                                case ',':
                                case ';':
                                    numArray4[index1] = ulong.Parse(s4);
                                    ++index1;
                                    s4 = "";
                                    break;
                                default:
                                    s4 += ch.ToString();
                                    break;
                            }
                            if (ch == ';')
                                break;
                        }
                        if (t == typeof(ulong))
                            return numArray4;
                        if (t == typeof(long))
                        {
                            long[] numArray5 = new long[ArraySize];
                            for (int index2 = 0; index2 < ArraySize; ++index2)
                                numArray5[index2] = BitConverter.ToInt64(BitConverter.GetBytes(numArray4[index2]), 0);
                            return numArray5;
                        }
                    }
                    return (int)Type == (int)Void ? 0 : ulong.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
            }
        }
        public T Call<T>(string module, int ordinal, params object[] Arguments) where T : struct
        {
            return (T)CallArgs(true, TypeToType<T>(false), typeof(T), module, ordinal, 0U, 0U, Arguments);
        }
        private uint TypeToType<T>(bool Array) where T : struct
        {
            uint Int = 1;
            uint String = 2;
            uint Float = 3;
            uint Byte = 4;
            uint IntArray = 5;
            uint FloatArray = 6;
            uint ByteArray = 7;
            uint Uint64 = 8;
            uint Uint64Array = 9;
            Type type = typeof(T);
            if (type == typeof(int) || type == typeof(uint) || (type == typeof(short) || type == typeof(ushort)))
                return Array ? IntArray : Int;
            if (type == typeof(string) || type == typeof(char[]))
                return String;
            return type == typeof(float) || type == typeof(double) ? (Array ? FloatArray : Float) : (type == typeof(byte) || type == typeof(char) ? (Array ? ByteArray : Byte) : ((type == typeof(ulong) || type == typeof(long)) && Array ? Uint64Array : Uint64));
        }
    }
}