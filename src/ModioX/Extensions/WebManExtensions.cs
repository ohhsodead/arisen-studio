using System;
using System.Net;
using System.Net.Sockets;

namespace ModioX.Extensions
{
    public static class WebManExtensions
    {
        /// <summary>
        /// Class By @FxckingCoder Check the below link for updates to this class Thanks for all the
        /// support :D http://www.GitHub.com/FxckingCoder
        /// </summary>

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
                Program.Log.Error(ex, "Unable to check if webMAN is installed on console. Error: " + ex.Message);
                return false;
            }
        }

        #region Mount HDD Game

        /// <summary>
        /// Mount a game from your HDD
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="region"> games region code Example- blus00000 or bles00000 </param>
        /// <param name="game">
        /// name of the game you want to mount - must be spelled correctly with a space between each
        /// word Example - 'Grand Theft Auto V' or 'Call of Duty Black Ops II'
        /// </param>
        /// <returns> </returns>
        public static string MountGame(string ip, string region, string game)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/mount.ps3/dev_hdd0/GAMES/{region}-[{game}]");
        }

        #endregion Mount HDD Game

        #region Ps3 On - Off

        /// <summary>
        /// Restarts the current ps3
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string Restart(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/restart.ps3");
        }

        /// <summary>
        /// Turns off current ps3
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string Shutdown(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/shutdown.ps3");
        }

        #endregion Ps3 On - Off

        #region Disc Games

        /// <summary>
        /// Ejects current game
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string Eject(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/eject.ps3");
        }

        /// <summary>
        /// Inserts a disc
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string Inject(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/inject.ps3");
        }

        #endregion Disc Games

        #region Digital Games

        /// <summary>
        /// Mount a game from path
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string MountGameFromPath(string ip, string path)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/mount.ps3/" + path);
        }

        /// <summary>
        /// Unmount current game
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string Unmount(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/mount.ps3/unmount");
        }

        /// <summary>
        /// External game data
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string External(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/extgd.ps3");
        }

        /// <summary>
        /// External game data
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string EnableExternal(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/extgd.ps3?enable");
        }

        /// <summary>
        /// Refresh game files
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string Refresh(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/refresh.ps3");
        }

        #endregion Digital Games

        #region Set idps & psid

        /// <summary>
        /// Set idps
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="id"> Change idps in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static string SetIdps1(string ip, string id)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/setidps.ps3mapi?idps1={id}");
        }

        /// <summary>
        /// Set idps2
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="id"> Change idps2 in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static string SetIdps2(string ip, string id)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/setidps.ps3mapi?idps2={id}");
        }

        /// <summary>
        /// Set psid
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="id"> Change psid in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static string SetPsid1(string ip, string id)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/setidps.ps3mapi?psid1={id}");
        }

        /// <summary>
        /// Set psid2
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="id"> Change psid2 in lv2 memory at system startup </param>
        /// <returns> </returns>
        public static string SetPsid2(string ip, string id)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/setidps.ps3mapi?psid2={id}");
        }

        #endregion Set idps & psid

        #region Ring Buzzers

        /// <summary>
        /// Single beep
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string SingleBuzzer(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=1");
        }

        /// <summary>
        /// Double beep
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string DoubleBuzzer(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=2");
        }

        /// <summary>
        /// Triple beep
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string TripleBuzzer(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=3");
        }

        #endregion Ring Buzzers

        #region Led Colors

        /// <summary>
        /// Change ps3 led to red
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string RedLED(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?color=0");
        }

        /// <summary>
        /// Change ps3 led to green
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string GreenLED(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?color=1");
        }

        /// <summary>
        /// Change ps3 led to yellow
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string YellowLED(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?color=2");
        }

        #endregion Led Colors

        #region Led Modes

        /// <summary>
        /// Ps3 led off
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string LEDOff(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?mode=0");
        }

        /// <summary>
        /// Ps3 led on
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string LEDOn(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?mode=1");
        }

        /// <summary>
        /// Makes ps3 led blink fast
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string LEDBlinkFast(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?mode=2");
        }

        /// <summary>
        /// Makes ps3 led blink slowly
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string LEDBlinkSlow(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/led.ps3mapi?mode=3");
        }

        #endregion Led Modes

        #region Notify Message

        /// <summary>
        /// Custom notify message
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="message"> notify message </param>
        /// <returns> </returns>
        public static string NotifyPopup(string ip, string message)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/popup.ps3/{message}");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <param name="message"> notify message </param>
        /// <returns> </returns>
        public static string NotifyPopupBottom(string ip, string message)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/popup.ps3*{message}");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string NotifySystemInformation(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/popup.ps3");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string NotifyCPURSXTemperature(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/cpursx.ps3");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string NotifyMinimumVersion(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/minver.ps3");
        }

        #endregion Notify Message

        #region Reboot

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string RebootSoft(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/reboot.ps3?soft");
        }

        /// <summary>
        /// Custom notify message in bottom of screen
        /// </summary>
        /// <param name="ip"> ps3 local ip </param>
        /// <returns> </returns>
        public static string RebootHard(string ip)
        {
            using WebClient client = new WebClient();
            return client.DownloadString($"http://{ip}/reboot.ps3?hard");
        }

        #endregion Reboot
    }
}