using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using PS3Lib;
using System;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Tools.PS3
{
    public partial class ConsoleManager : XtraForm
    {
        public ConsoleManager()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        private PS3API Ps3 { get; } = new(SelectAPI.PS3Manager);

        private void ConsoleManager_Load(object sender, EventArgs e)
        {
            ButtonRefreshDetails.Text = Language.GetString("LABEL_REFRESH");
            ButtonSetLEDs.Text = Language.GetString("LABEL_SET_LEDS");
            ButtonRingBuzzer.Text = Language.GetString("LABEL_RING_BUZZER");
            ButtonSetIDPS.Text = Language.GetString("LABEL_SET");
            ButtonSetPSID.Text = Language.GetString("LABEL_SET");

            try
            {
                SetStatus(Language.GetString("CONNECTING_TO_CONSOLE"));

                _ = Ps3.PS3MAPI.ConnectTarget(MainWindow.ConsoleProfile.Address);

                if (Ps3.PS3MAPI.IsConnected())
                {
                    SetStatus(Language.GetString("SUCCESS_CONNECTED"));
                    LoadDetails();
                }
                else
                {
                    SetStatus("Console Manager: " + Language.GetString("UNABLE_TO_CONNECT"));
                    _ = XtraMessageBox.Show(this, Language.GetString("UNABLE_TO_CONNECT"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                SetStatus("Console Manager: " + Language.GetString("UNABLE_TO_CONNECT"), ex);
                _ = XtraMessageBox.Show(this, Language.GetString("UNABLE_TO_CONNECT"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ConsoleManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Ps3.PS3MAPI.IsConnected())
                {
                    _ = Ps3.PS3MAPI.DisconnectTarget();
                }
            }
            catch { }
        }

        private void ButtonRefreshDetails_Click(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void LoadDetails()
        {
            try
            {
                _ = Ps3.PS3MAPI.GetTemperatureCelcius(out uint tempCell, out uint tempRsx);

                LabelTempCELL.Text = Convert.ToString(tempCell) + " °C";
                LabelTempRSX.Text = Convert.ToString(tempRsx) + " °C";

                LabelFirmwareVersion.Text = Ps3.PS3MAPI.GetFirmwareVersion();
                LabelFirmwareType.Text = Ps3.PS3MAPI.GetFirmwareType();
                LabelCoreVersion.Text = Ps3.PS3MAPI.GetCoreVersion();

                SetStatus("Successfully loaded console details.");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to fetch console details.", ex);
                _ = XtraMessageBox.Show(this, $"Unable to fetch console details.\n\nError Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSetLEDs_Click(object sender, EventArgs e)
        {
            _ = Ps3.PS3MAPI.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, (PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode)RadioGroupLEDsGreen.SelectedIndex);
            _ = Ps3.PS3MAPI.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, (PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode)RadioGroupLEDsRed.SelectedIndex);
            SetStatus("Console LEDs have been set.");
        }

        private void ButtonRingBuzzer_Click(object sender, EventArgs e)
        {
            _ = Ps3.PS3MAPI.RingBuzzer((PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode)RadioGroupBuzzerMode.SelectedIndex);
            SetStatus("Ring buzzer set.");
        }

        private void ButtonSetIDPS_Click(object sender, EventArgs e)
        {
            _ = Ps3.PS3MAPI.SetConsoleID(TextBoxIDPS.Text);
            SetStatus("IDPS has been set.");
        }

        private void ButtonSetPSID_Click(object sender, EventArgs e)
        {
            _ = Ps3.PS3MAPI.SetPSID(TextBoxPSID.Text);
            SetStatus("PSID has been set.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            if (InvokeRequired)
            {
                _ = BeginInvoke((MethodInvoker)delegate
                {
                    LabelStatus.Caption = status;
                });
            }
            else
            {
                LabelStatus.Caption = status;
            }

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