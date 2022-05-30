using DevExpress.XtraEditors;
using NeoModsX.Extensions;
using NeoModsX.Forms.Windows;
using System;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using XDevkit;

namespace NeoModsX.Forms.Tools.XBOX
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

        private enum XUIDAddr : uint
        {
            COD4 = 0x84C24BBC,
            WAW = 0x852336B5,
            MW2 = 0x838BA824,
            BO1 = 0x841987D5,
            MW3 = 0x839691AC,
            BO2 = 0x841E1B30,
            GHOSTS = 0x83F0A35C,
            AW = 0x84493A94
        };

        public enum Title : uint
        {
            DASHBOARD = 0xFFFE07D1,
            XEX_MENU = 0xFFFF0055,
            XEX_MENU_ALT = 0xC0DE9999,
            XSHELL = 0xFFFE07FF,
            GTA_V = 0x545408A7,
            COD4 = 0x415607E6,
            MW2 = 0x41560817,
            BO1 = 0x41560855,
            MW3 = 0x415608CB,
            BO2 = 0x415608C3,
            GHOSTS = 0x415608FC,
            AW = 0x41560914,
            BO3 = 0x4156091D
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
                string result = GetXUID(TextBoxGamertag.Text);

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
            bool success = SetXUID(XuidAddress(), TextBoxGamertag.Text, TextBoxXuid.Text);

            if (success)
            {
                XtraMessageBox.Show(this, Language.GetString("XUID_SET_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, Language.GetString("XUID_SET_ERROR"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetXUID(string gamertag)
        {
            if (MainWindow.IsConsoleConnected)
            {
                if (XboxConsole.Call<uint>(XUserFindUserAddress, new object[] { 0x9000006F93463L, 0, gamertag, 0x18, XamFreeMemory, 0 }) == 0)
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
                    return XboxConsole.GetCurrentTitleID() switch
                    {
                        (uint)Title.COD4 => (uint)XUIDAddr.COD4,
                        (uint)Title.MW2 => (uint)XUIDAddr.MW2,
                        (uint)Title.BO1 => (uint)XUIDAddr.BO1,
                        (uint)Title.MW3 => (uint)XUIDAddr.MW3,
                        (uint)Title.BO2 => (uint)XUIDAddr.BO2,
                        (uint)Title.GHOSTS => (uint)XUIDAddr.GHOSTS,
                        (uint)Title.AW => (uint)XUIDAddr.AW,
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

        private bool SetXUID(uint address, string GT, string XUID)
        {
            if (address == 0xEE || address == 0xDE)
            {
                XtraMessageBox.Show(this, string.Format("{0}", address == 0xDE ? Language.GetString("GAME_NOT_SUPPORTED") : (address == 0xDEAD ? Language.GetString("YOU_MUST_BE_CONNECTED_TO_USE_FEATURE") : Language.GetString("XUID_SET_ERROR"))), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool BO2 = XboxConsole.GetCurrentTitleID() == (uint)Title.BO2;

            if (address != 0)
            {
                if (GT.Length > 0)
                {
                    if (BO2)
                    {
                        XboxConsole.WriteBytes(0x81AA2C8C, ReverseBytes(GT + "\0"));
                    }

                    XboxConsole.WriteBytes(address, Encoding.UTF8.GetBytes(GT + "\0"));
                }
                if (XUID.Length == 16)
                {
                    XboxConsole.WriteBytes(address + (uint)(BO2 ? 0x20 : 0x24), StringExtensions.HexStringToBytes(XUID));
                    XboxConsole.WriteBytes(address + (uint)(BO2 ? 0x28 : 0x2C), StringExtensions.HexStringToBytes(StringExtensions.ConvertStringToHex(XUID, Encoding.ASCII)));

                    if (BO2)
                    {
                        XboxConsole.WriteBytes(0x825DE218, new byte[] { 0x48, 0x00, 0x00, 0x00 }); // XUID Check
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