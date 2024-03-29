﻿using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;
using System.Resources;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;
using ArisenStudio.Extensions;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class ConsoleInfo : XtraForm
    {
        public ConsoleInfo()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        private IXboxConsole Xbox { get; } = MainWindow.XboxConsole;

        private void ConsoleInfo_Load(object sender, EventArgs e)
        {
            ButtonRefreshDetails.Text = Language.GetString("LABEL_REFRESH");
            ButtonSetLEDs.Text = Language.GetString("LABEL_SET_LEDS");
            ButtonDiscTrayOpen.Text = Language.GetString("LABEL_OPEN");
            ButtonDiscTrayClose.Text = Language.GetString("LABEL_CLOSE");
            ButtonSetFanSpeed.Text = Language.GetString("LABEL_SET_FAN_SPEED");

            LoadDetails();
        }

        private void ConsoleInfo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ButtonRefreshDetails_Click(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void LoadDetails()
        {
            try
            {
                LabelIPAddress.Text = Xbox.IPAddress.ToString();
                LabelCPUKey.Text = Xbox.GetCPUKey();
                LabelKernel.Text = Xbox.GetKernalVersion().ToString();
                LabelTitleID.Text = Xbox.XamGetCurrentTitleId().ToString();

                LabelTempCPU.Text = Xbox.GetTemperature(JRPC.TemperatureType.CPU) + " °C";
                LabelTempGPU.Text = Xbox.GetTemperature(JRPC.TemperatureType.GPU) + " °C";
                LabelTempRAM.Text = Xbox.GetTemperature(JRPC.TemperatureType.EDRAM) + " °C";
                LabelTempMB.Text = Xbox.GetTemperature(JRPC.TemperatureType.MotherBoard) + " °C";

                SetStatus("Successfully loaded console details.");
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to fetch console details.", ex);
                XtraMessageBox.Show(this, $"Unable to fetch console details.\n\nError Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSetLEDs_Click(object sender, EventArgs e)
        {
            JRPC.LEDState ledTopLeft = RadioGroupLEDsTopLeft.SelectedIndex switch
            {
                0 => JRPC.LEDState.GREEN,
                1 => JRPC.LEDState.ORANGE,
                2 => JRPC.LEDState.RED,
                3 => JRPC.LEDState.OFF,
                _ => JRPC.LEDState.GREEN,
            };

            JRPC.LEDState ledTopRight = RadioGroupLEDsTopRight.SelectedIndex switch
            {
                0 => JRPC.LEDState.GREEN,
                1 => JRPC.LEDState.ORANGE,
                2 => JRPC.LEDState.RED,
                3 => JRPC.LEDState.OFF,
                _ => JRPC.LEDState.GREEN,
            };

            JRPC.LEDState ledBottomLeft = RadioGroupLEDsBottomLeft.SelectedIndex switch
            {
                0 => JRPC.LEDState.GREEN,
                1 => JRPC.LEDState.ORANGE,
                2 => JRPC.LEDState.RED,
                3 => JRPC.LEDState.OFF,
                _ => JRPC.LEDState.GREEN,
            };

            JRPC.LEDState ledBottomRight = RadioGroupLEDsBottomRight.SelectedIndex switch
            {
                0 => JRPC.LEDState.GREEN,
                1 => JRPC.LEDState.ORANGE,
                2 => JRPC.LEDState.RED,
                3 => JRPC.LEDState.OFF,
                _ => JRPC.LEDState.GREEN,
            };

            Xbox.SetLeds(ledTopLeft, ledTopRight, ledBottomLeft, ledBottomRight);
            SetStatus("Console LEDs colors set.");
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
                BeginInvoke((MethodInvoker)delegate
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

        private void ButtonDiscTrayOpen_Click(object sender, EventArgs e)
        {
            Xbox.SetTrayState(TrayState.Open);
        }

        private void ButtonDiscTrayClose_Click(object sender, EventArgs e)
        {
            Xbox.SetTrayState(TrayState.Close);
        }

        private void ButtonSetFanSpeed_Click(object sender, EventArgs e)
        {
            Xbox.SetFanSpeed(0, TrackBarFanSpeed.Value);
        }
    }
}