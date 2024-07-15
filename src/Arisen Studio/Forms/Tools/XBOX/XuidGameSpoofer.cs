using DevExpress.XtraEditors;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using XDevkit;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class XuidGameSpoofer : XtraForm
    {
        public XuidGameSpoofer()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static IXboxConsole XboxConsole = MainWindow.XboxConsole;

        private readonly uint XUserFindUserAddress = 0x81829158/*17502 0x81829018*/, XamFreeMemory = 0x81AA2000;

        private enum XuidAddr : uint
        {
            Cod4 = 0x84C24BBC,
            Waw = 0x852336B5,
            Mw2 = 0x838BA824,
            Bo1 = 0x841987D5,
            Mw3 = 0x839691AC,
            Bo2 = 0x841E1B30,
            Ghosts = 0x83F0A35C,
            Aw = 0x84493A94
        };

        public enum Title : uint
        {
            Dashboard = 0xFFFE07D1,
            XexMenu = 0xFFFF0055,
            XexMenuAlt = 0xC0DE9999,
            Xshell = 0xFFFE07FF,
            GtaV = 0x545408A7,
            Cod4 = 0x415607E6,
            Mw2 = 0x41560817,
            Bo1 = 0x41560855,
            Mw3 = 0x415608CB,
            Bo2 = 0x415608C3,
            Ghosts = 0x415608FC,
            Aw = 0x41560914,
            Bo3 = 0x4156091D
        };

        private void XuidGameSpoofer_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("GAMES_LAUNCHER");
            ButtonGetXuid.Text = Language.GetString("LABEL_GET_XUID");
            ButtonSetXuid.Text = Language.GetString("LABEL_SET_XUID");
        }

        private void ButtonGetXuid_Click(object sender, EventArgs e)
        {
            if (TextBoxGamertag.Text.Length > 4 && TextBoxGamertag.Text.Length <= 15)
            {
                string result = GetXuid(TextBoxGamertag.Text);

                if (result == "ERROR")
                {
                    XtraMessageBox.Show(this, Language.GetString("YOU_MUST_BE_CONNECTED_TO_USE_FEATURE"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result != "")
                {
                    TextBoxXuid.Text = result;
                }
                else
                {
                    XtraMessageBox.Show(this, Language.GetString("XUID_GET_ERROR"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ButtonSetXuid_Click(object sender, EventArgs e)
        {
            bool success = SetXuid(XuidAddress(), TextBoxGamertag.Text, TextBoxXuid.Text);

            if (success)
            {
                XtraMessageBox.Show(this, Language.GetString("XUID_SET_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, Language.GetString("XUID_SET_ERROR"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetXuid(string gamertag)
        {
            if (MainWindow.IsConsoleConnected)
            {
                if (XboxConsole.Call<uint>(XUserFindUserAddress, [0x9000006F93463L, 0, gamertag, 0x18, XamFreeMemory, 0]) == 0)
                {
                    return BitConverter.ToString(XboxConsole.ReadBytes(XamFreeMemory, 8)).Replace("-", "");
                }
            }

            return "ERROR";
        }

        private uint XuidAddress()
        {
            try
            {
                if (MainWindow.IsConsoleConnected)
                {
                    return XboxConsole.GetCurrentTitleId() switch
                    {
                        (uint)Title.Cod4 => (uint)XuidAddr.Cod4,
                        (uint)Title.Mw2 => (uint)XuidAddr.Mw2,
                        (uint)Title.Bo1 => (uint)XuidAddr.Bo1,
                        (uint)Title.Mw3 => (uint)XuidAddr.Mw3,
                        (uint)Title.Bo2 => (uint)XuidAddr.Bo2,
                        (uint)Title.Ghosts => (uint)XuidAddr.Ghosts,
                        (uint)Title.Aw => (uint)XuidAddr.Aw,
                        _ => 0xDE,
                    };
                }
                else
                {
                    return 0xDEAD;
                }
            }
            catch { return 0xEE; }
        }

        private byte[] ReverseBytes(string input)
        {
            return Encoding.UTF8.GetBytes(input).Reverse().ToArray();
        }

        private bool SetXuid(uint address, string gt, string xuid)
        {
            if (address == 0xEE || address == 0xDE)
            {
                XtraMessageBox.Show(this, string.Format("{0}", address == 0xDE ? Language.GetString("GAME_NOT_SUPPORTED") : (address == 0xDEAD ? Language.GetString("YOU_MUST_BE_CONNECTED_TO_USE_FEATURE") : Language.GetString("XUID_SET_ERROR"))), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool bo2 = XboxConsole.GetCurrentTitleId() == (uint)Title.Bo2;

            if (address != 0)
            {
                if (gt.Length > 0)
                {
                    if (bo2)
                    {
                        XboxConsole.WriteBytes(0x81AA2C8C, ReverseBytes(gt + "\0"));
                    }

                    XboxConsole.WriteBytes(address, Encoding.UTF8.GetBytes(gt + "\0"));
                }
                if (xuid.Length == 16)
                {
                    XboxConsole.WriteBytes(address + (uint)(bo2 ? 0x20 : 0x24), StringExtensions.HexStringToBytes(xuid));
                    XboxConsole.WriteBytes(address + (uint)(bo2 ? 0x28 : 0x2C), StringExtensions.HexStringToBytes(StringExtensions.ConvertStringToHex(xuid, Encoding.ASCII)));

                    if (bo2)
                    {
                        XboxConsole.WriteBytes(0x825DE218, [0x48, 0x00, 0x00, 0x00]); // XUID Check
                    }
                }
                else
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void UpdateStatus(string status, Exception ex = null)
        {
            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(ex, status);
            }
        }
    }
}