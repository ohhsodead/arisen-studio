using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ModioX.Extensions
{
    public partial class WebManExtensions
    {
        /// <summary>
        /// Class By @FxckingCoder
        /// Check the below link for updates to this class
        /// Thanks for all the support :D
        /// http://www.GitHub.com/FxckingCoder
        /// </summary>

        private static readonly WebClient c = new WebClient();

        public static bool IsWebManInstalled(string ip, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(ip, port);
                return socket.Connected;
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to check if webMAN is installed on console. Error: " + ex.Message, ex);
                return false;
            }
        }

        #region Ps3 On - Off
        /// <summary>
        /// Restarts the current ps3
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string Restart(string ip)
        {
            return c.DownloadString($"http://{ip}/restart.ps3");
        }

        /// <summary>
        /// Turns off current ps3
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string Shutdown(string ip)
        {
            return c.DownloadString($"http://{ip}/shutdown.ps3");
        }
        #endregion

        #region Disc Games
        /// <summary>
        /// Ejects current game
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string Eject(string ip)
        {
            return c.DownloadString($"http://{ip}/eject.ps3");
        }

        /// <summary>
        /// Inserts a disc
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string Inject(string ip)
        {
            return c.DownloadString($"http://{ip}/inject.ps3");
        }
        #endregion

        #region Digital Games
        /// <summary>
        /// Unmount current game
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string Unmount(string ip)
        {
            return c.DownloadString($"http://{ip}/mount.ps3/unmount");
        }

        /// <summary>
        /// External game data
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string External(string ip)
        {
            return c.DownloadString($"http://{ip}/extgd.ps3");
        }

        /// <summary>
        /// Refresh game files
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string Refresh(string ip)
        {
            return c.DownloadString($"http://{ip}/refresh.ps3");
        }
        #endregion

        #region Set idps & psid
        /// <summary>
        /// Set idps
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change idps in lv2 memory at system startup</param>
        /// <returns></returns>
        public static string SetIdps1(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?idps1={id}");
        }

        /// <summary>
        /// Set idps2
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change idps2 in lv2 memory at system startup</param>
        /// <returns></returns>
        public static string SetIdps2(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?idps2={id}");
        }

        /// <summary>
        /// Set psid
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change psid in lv2 memory at system startup</param>
        /// <returns></returns>
        public static string SetPsid1(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?psid1={id}");
        }

        /// <summary>
        /// Set psid2
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change psid2 in lv2 memory at system startup</param>
        /// <returns></returns>
        public static string SetPsid2(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?psid2={id}");
        }
        #endregion

        #region Ring Buzzers
        /// <summary>
        /// Single beep
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string SingleBuzzer(string ip)
        {
            return c.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=1");
        }

        /// <summary>
        /// Double beep
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string DoubleBuzzer(string ip)
        {
            return c.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=2");
        }

        /// <summary>
        /// Triple beep
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string TripleBuzzer(string ip)
        {
            return c.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=3");
        }
        #endregion

        #region Led Colors
        /// <summary>
        /// Change ps3 led to red
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string RedLED(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?color=0");
        }

        /// <summary>
        /// Change ps3 led to green
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string GreenLED(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?color=1");
        }

        /// <summary>
        /// Change ps3 led to yellow
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string YellowLED(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?color=2");
        }
        #endregion

        #region Led Modes
        /// <summary>
        /// Ps3 led off
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string LEDOff(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=0");
        }

        /// <summary>
        /// Ps3 led on
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string LEDOn(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=1");
        }

        /// <summary>
        /// Makes ps3 led blink fast
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string LEDBlinkFast(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=2");
        }

        /// <summary>
        /// Makes ps3 led blink slowly
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string LEDBlinkSlow(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=3");
        }
        #endregion

        #region Mount HDD Game
        /// <summary>
        /// Mount a game from your HDD
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="region">games region code Example- blus00000 or bles00000</param>
        /// <param name="game">name of the game you want to mount - must be spelled correctly with a space between each word Example - 'Grand Theft Auto V' or 'Call of Duty Black Ops II'</param>
        /// <returns></returns>
        public static string MountGame(string ip, string region, string game)
        {
            return c.DownloadString($"http://{ip}/mount.ps3/dev_hdd0/GAMES/{region}-[{game}]");
        }
        #endregion

        #region Notify Message
        /// <summary>
        /// Custom notify message
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="message">notify message</param>
        /// <returns></returns>
        public static string NotifyPopup(string ip, string message)
        {
            return c.DownloadString($"http://{ip}/popup.ps3/{message}");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="message">notify message</param>
        /// <returns></returns>
        public static string NotifyPopupBottom(string ip, string message)
        {
            return c.DownloadString($"http://{ip}/popup.ps3*{message}");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string NotifySystemInformation(string ip)
        {
            return c.DownloadString($"http://{ip}/popup.ps3");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string NotifyCPURSXTemperature(string ip)
        {
            return c.DownloadString($"http://{ip}/cpursx.ps3");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string NotifyMinimumVersion(string ip)
        {
            return c.DownloadString($"http://{ip}/minver.ps3");
        }
        #endregion

        #region Reboot

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string RebootSoft(string ip)
        {
            return c.DownloadString($"http://{ip}/reboot.ps3?soft");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public static string RebootHard(string ip)
        {
            return c.DownloadString($"http://{ip}/reboot.ps3?hard");
        }

        #endregion
    }
}