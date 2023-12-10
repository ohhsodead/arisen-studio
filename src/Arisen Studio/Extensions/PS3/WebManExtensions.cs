using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ArisenStudio.Extensions
{
    public static class WebManExtensions
    {
        // Class By @FxckingCoder Check the below link for updates to this class Thanks for all the
        // support :D http://www.GitHub.com/FxckingCoder

        /// <summary>
        /// Check if WebMAN is installed on the console.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsWebManInstalled(string ip)
        {
            // alternative 
            //Ping ping = new();
            //IPAddress address = IPAddress.Parse(ip);
            //PingReply pong = ping.Send(address);
            //return pong.Status == IPStatus.Success;

            //Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                //WebRequest request = WebRequest.Create("http://" + ip + "/" + command);
                //WebResponse response = request.GetResponse();

                //using (Stream dataStream = response.GetResponseStream())
                //{
                //    StreamReader read = new(dataStream);
                //    read.ReadToEnd();
                //}

                //response.Close();

                SetConsoleLed(ip, LedColor.Green);

                return true;
                //socket.Connect(ip, 21);
                //return socket.Connected;
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to check if webMAN is installed on console. Error: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="command">  </param>
        private static void HandleRequest(string ip, string command)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://" + ip + "/" + command);
                WebResponse response = request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader read = new(dataStream);
                    read.ReadToEnd();
                }

                response.Close();
            }
            catch (WebException ex)
            {
                Program.Log.Error(ex, "Unable to handle webMAN commands. Error Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to handle webMAN commands. Error Message: " + ex.Message);
            }
        }

        /// <summary>
        /// Rebuilds the PS3 database.
        /// </summary>
        public static void RebuildDatabase(string ip)
        {
            HandleRequest(ip, "rebuild.ps3");
        }

        public static string GetGame(string ip)
        {
            try
            {
                string game;

                HtmlWeb web = new();

                HtmlDocument htmlDoc = web.Load("http://" + ip + "/cpursx.ps3?/sman.ps3");

                HtmlNodeCollection node = htmlDoc.DocumentNode.SelectNodes("//body//h2");

                string res = node[0].InnerText;

                //var soup = BeautifulSoup(html, "html.parser");
                //var strings = soup.findAll("h2");
                //var res = strings[0].text;

                if (res.StartsWith("BL") || res.StartsWith("NP") || res.StartsWith("BC"))
                {
                    //game = res.Split(" ", 1)[1].encode("ascii", "ignore").decode();
                    //game = game.Split(new string [ ' ' ]);
                    //game.Remove(-1);
                    //game = " ".join(game);

                    game = res.Substring(res.IndexOf(' ') + 1);
                    game = game.Substring(0, game.Length - 13);
                    game = game.Replace(" &nbsp; ", string.Empty);
                    game = game.Replace("á", "\u00e1");
                    game = game.Replace("Â", "\u00c2");
                    byte[] bytes = Encoding.ASCII.GetBytes(game);
                    game = Encoding.ASCII.GetString(bytes);
                    game = game.Replace("?", string.Empty);
                }
                else
                {
                    game = "XMB Menu";
                }

                return game;
            }
            catch
            {
                return string.Empty;
            }
        }

        #region Mount Game

        /// <summary>
        /// Mount a game from your HDD
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="region"> Games region code Example- blus00000 or bles00000 </param>
        /// <param name="game">
        /// Game title you want to mount - must be spelled correctly with a space between each
        /// word Example - 'Grand Theft Auto V' or 'Call of Duty Black Ops II'
        /// </param>
        /// <returns> </returns>
        public static void MountGame(string ip, string region, string game)
        {
            HandleRequest(ip, $"mount.ps3/dev_hdd0/GAMES/{region}-[{game}]");
        }

        /// <summary>
        /// Mount a game from path
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="path"> ps3 game path </param>
        /// <returns> </returns>
        public static void MountGameFromPath(string ip, string path)
        {
            HandleRequest(ip, $"mount_ps3/{path}");
        }

        /// <summary>
        /// Unmount current game
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void Unmount(string ip)
        {
            HandleRequest(ip, "mount.ps3/unmount");
        }

        /// <summary>
        /// Unmount current game
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void LaunchGame(string ip)
        {
            HandleRequest(ip, "play.ps3");
        }

        /// <summary>
        /// External game data
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void External(string ip)
        {
            HandleRequest(ip, "extgd.ps3");
        }

        #endregion Mount HDD Game

        #region Disc Games

        /// <summary>
        /// Ejects current game
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void Eject(string ip)
        {
            HandleRequest(ip, "eject.ps3");
        }

        /// <summary>
        /// Inserts a disc
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void Inject(string ip)
        {
            HandleRequest(ip, "inject.ps3");
        }

        #endregion Disc Games

        #region Digital Games

        /// <summary>
        /// External game data
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void EnableExternal(string ip)
        {
            HandleRequest(ip, "extgd.ps3?enable");
        }

        /// <summary>
        /// Refresh game files
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void Refresh(string ip)
        {
            HandleRequest(ip, "refresh.ps3");
        }

        #endregion Digital Games

        #region Notify Message

        /// <summary>
        /// Display notification message at the top right corner of the screen.
        /// </summary>
        /// <param name="Message"></param>
        public static void Notify(string ip, string message)
        {
            HandleRequest(ip, "notify.ps3mapi?msg=" + message);
        }

        /// <summary>
        /// Display notification message at the top right corner of the screen.
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="message"> Notify Message </param>
        /// <returns> </returns>
        public static void NotifyPopup(string ip, string message)
        {
            HandleRequest(ip, $"popup.ps3/{message}");
        }

        /// <summary>
        /// Display notification message at the bottom right of the screen.
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="message"> Notify Message </param>
        /// <returns> </returns>
        public static void NotifyPopupBottom(string ip, string message)
        {
            HandleRequest(ip, $"popup.ps3*{message}");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void NotifySystemInformation(string ip)
        {
            HandleRequest(ip, "popup.ps3");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void NotifyCpursxTemperature(string ip)
        {
            HandleRequest(ip, "cpursx.ps3");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <returns> </returns>
        public static void NotifyMinimumVersion(string ip)
        {
            HandleRequest(ip, "minver.ps3");
        }

        #endregion Notify Message

        #region Set idps & psid

        /// <summary>
        /// Set idps
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="idps"> Change idps in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static void SetIdps1(string ip, string idps)
        {
            HandleRequest(ip, $"setidps.ps3mapi?idps1={idps}");
        }

        /// <summary>
        /// Set idps2
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="idps"> Change idps2 in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static void SetIdps2(string ip, string idps)
        {
            HandleRequest(ip, $"setidps.ps3mapi?idps2={idps}");
        }

        /// <summary>
        /// Set psid
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="psid"> Change psid in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static void SetPsid1(string ip, string psid)
        {
            HandleRequest(ip, $"setidps.ps3mapi?psid1={psid}");
        }

        /// <summary>
        /// Set psid2
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="psid"> Change psid2 in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static void SetPsid2(string ip, string psid)
        {
            HandleRequest(ip, $"setidps.ps3mapi?psid2={psid}");
        }

        #endregion Set idps & psid

        #region Ring Buzzers

        public enum BuzzerMode
        {
            Single,
            Double,
            Triple
        }

        /// <summary>
        /// Triggers the buzzer function to create a beep sound. Use the BuzzerMode structure for the pre-defined modes.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="mode"></param>
        public static void RingBuzzer(string ip, BuzzerMode mode)
        {
            HandleRequest(ip, "buzzer.ps3mapi?mode=" + mode);
        }

        #endregion Ring Buzzers

        #region Led Colors & Modes

        public enum LedColor
        {
            Red = 0,
            Green = 1,
            Yellow = 2
        }

        public enum LedMode
        {
            Off = 0,
            On = 1,
            BlinkFast = 2,
            BlinkSlow = 3
        }

        /// <summary>
        /// Set the console led color and mode.
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="color"> LED Color </param>
        /// <param name="mode"> LED Mode </param>
        public static void SetConsoleLed(string ip, LedColor color, LedMode mode)
        {
            HandleRequest(ip, "led.ps3mapi?color=" + color + "&mode=" + mode);
        }

        /// <summary>
        /// Set the console led color.
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="color"> LED Color </param>
        public static void SetConsoleLed(string ip, LedColor color)
        {
            HandleRequest(ip, "led.ps3mapi?color=" + color);
        }

        /// <summary>
        /// Set the console led mode.
        /// </summary>
        /// <param name="ip"> PS3 Local IP Address </param>
        /// <param name="mode"> LED Mode </param>
        /// <returns> </returns>
        public static void SetModeLed(string ip, LedMode mode)
        {
            HandleRequest(ip, "led.ps3mapi?mode=" + mode);
        }

        #endregion Led Colors & Modes

        #region Power

        public enum PowerFlags
        {
            SoftReboot,
            HardReboot,
            QuickReboot,
            Shutdown,
            Restart
        }

        /// <summary>
        /// Commands to power off the console.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="flag"></param>
        public static void Power(string ip, PowerFlags flag)
        {
            switch (flag)
            {
                case PowerFlags.QuickReboot:
                    HandleRequest(ip, "reboot.ps3?quick");
                    break;
                case PowerFlags.SoftReboot:
                    HandleRequest(ip, "reboot.ps3?soft");
                    break;
                case PowerFlags.HardReboot:
                    HandleRequest(ip, "reboot.ps3?hard");
                    break;
                case PowerFlags.Shutdown:
                    HandleRequest(ip, "shutdown.ps3");
                    break;
                case PowerFlags.Restart:
                    HandleRequest(ip, "restart.ps3");
                    break;
            }
        }

        #endregion Power
    }
}