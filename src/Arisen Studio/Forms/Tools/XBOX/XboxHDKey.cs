using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Resources;
using XDevkit;
using ArisenStudio.Extensions;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class XboxHDKey : XtraForm
    {
        public XboxHDKey()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        private void XboxHDKey_Load(object sender, EventArgs e)
        {
            ButtonImportFromFile.Text = Language.GetString("LABEL_IMPORT_FROM_KV_FILE");
            ButtonSaveFile.Text = Language.GetString("LABEL_SAVE_FILE");
        }

        private void ButtonImportFromFile_Click(object sender, EventArgs e)
        {
            string fileName = DialogExtensions.ShowOpenFileDialog(this, "Keyvault File", "Keyvault (*.bin)|*.bin|All Files (*.*)|*.*");

            if (!string.IsNullOrEmpty(fileName))
            {
                IMPORT_RESULT result = ImportXboxHDKey(fileName, out string consoleSerial, out string motherboardSerial);

                if (result == IMPORT_RESULT.ERROR_FILE_ACCESS)
                {
                    XtraMessageBox.Show(this, "Failed to access or read keyvault file.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == IMPORT_RESULT.ERROR_FILE_SIZE)
                {
                    XtraMessageBox.Show(this, "Selected file is not a valid keyvault file.\n\nInvalid size", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == IMPORT_RESULT.ERROR_BAD_REGION)
                {
                    XtraMessageBox.Show(this, "Selected file is not a valid keyvault file.\n\nInvalid region. Supplied keyvault file must be decrypted", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TextBoxConsoleSerial.Text = consoleSerial;
                    TextBoxMotherboardSerial.Text = motherboardSerial;
                    ButtonSaveFile.Enabled = true;
                }
            }
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxConsoleSerial.Text) && TextBoxConsoleSerial.Text.Length == 12 && StringExtensions.ValidNumericString(TextBoxConsoleSerial.Text))
            {
                if (!string.IsNullOrEmpty(TextBoxMotherboardSerial.Text) && TextBoxMotherboardSerial.Text.Length == 16 && StringExtensions.ValidHexadecimalString(TextBoxMotherboardSerial.Text))
                {
                    if (!string.IsNullOrEmpty(TextBoxXboxHDKey.Text))
                    {
                        DialogResult result = XtraMessageBox.Show(this, "Save the console/motherboard serial numbers to the file as well?", "Save to text file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Cancel) return;

                        bool save_serials = result == DialogResult.Yes;
                        StringBuilder output = new();
                        if (save_serials)
                        {
                            output.AppendLine($"Console serial: {TextBoxConsoleSerial.Text}");
                            output.AppendLine($"Motherboard serial: {TextBoxMotherboardSerial.Text.ToUpperInvariant()}");
                            output.AppendLine();
                        }
                        output.Append($"XboxHDKey: {TextBoxXboxHDKey.Text}");

                        string fileName = DialogExtensions.ShowSaveFileDialog(this, "Save File", "Text file (*.txt)|*.txt|All files (*.*)|*.*");

                        if (!string.IsNullOrWhiteSpace(fileName))
                        {
                            using FileStream stream = new(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                            using StreamWriter IO = new(stream, Encoding.UTF8);
                            IO.Write(output.ToString());
                            IO.Flush();
                            IO.Close();
                        }

                        Program.Log.Info("Successfully created XboxHDKey file.");
                        XtraMessageBox.Show("Successfully created XboxHDKey file.", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TextBoxConsoleSerial_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxConsoleSerial.Text) && TextBoxConsoleSerial.Text.Length == 12)
            {
                if (StringExtensions.ValidNumericString(TextBoxConsoleSerial.Text))
                {
                    TextBoxXboxHDKey.Text = MakeXboxHDKey(TextBoxConsoleSerial.Text, TextBoxMotherboardSerial.Text);
                }
                else
                {
                    Program.Log.Error("Invalid console serial value.");
                    XtraMessageBox.Show(this, "Invalid console serial value.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Program.Log.Error("Invalid console serial value.");
                XtraMessageBox.Show(this, "Invalid console serial value.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxMotherboardSerial_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxMotherboardSerial.Text) && TextBoxMotherboardSerial.Text.Length == 16)
            {
                if (StringExtensions.ValidHexadecimalString(TextBoxMotherboardSerial.Text))
                {
                    TextBoxXboxHDKey.Text = MakeXboxHDKey(TextBoxConsoleSerial.Text, TextBoxMotherboardSerial.Text);
                }
                else
                {
                    Program.Log.Error("Invalid motherboard serial value.");
                    XtraMessageBox.Show(this, "Invalid motherboard serial value.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Program.Log.Error("Invalid motherboard serial value.");
                XtraMessageBox.Show(this, "Invalid motherboard serial value.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string MakeXboxHDKey(string consoleSerial, string motherboarSerial)
        {
            if (!string.IsNullOrEmpty(consoleSerial) && consoleSerial.Length == 12 && StringExtensions.ValidNumericString(consoleSerial))
            {
                if (!string.IsNullOrEmpty(motherboarSerial) && motherboarSerial.Length == 16 && StringExtensions.ValidHexadecimalString(motherboarSerial))
                {
                    byte[] XboxHDKey = new byte[0x10];
                    byte[] consoleSerialBuffer = new byte[12];
                    byte[] motherboardSerialBuffer = new byte[16 / 2];

                    for (int i = 0; i < 12; i++)
                    {
                        consoleSerialBuffer[i] = Convert.ToByte(consoleSerial.Substring(i, 1)[0]);
                    }

                    for (int i = 0; i < 16; i += 2)
                    {
                        motherboardSerialBuffer[(i / 2)] = Convert.ToByte(motherboarSerial.Substring(i, 2), 16);
                    }

                    Array.Copy(motherboardSerialBuffer, 0, XboxHDKey, 4, 8);
                    Array.Copy(consoleSerialBuffer, 0, XboxHDKey, 12, 4);

                    return BitConverter.ToString(XboxHDKey, 0).Replace("-", "");
                }
            }

            return "";
        }

        enum IMPORT_RESULT
        {
            ERROR_SUCCESS,
            ERROR_FILE_ACCESS,
            ERROR_FILE_SIZE,
            ERROR_BAD_REGION,
        }

        IMPORT_RESULT ImportXboxHDKey(string keyvaultFile, out string consoleSerial, out string motherboardSerial)
        {
            const ushort REGION_CODE_NTSCU = 0x00FF;
            const ushort REGION_CODE_NTSCJ = 0x01FF;
            const ushort REGION_CODE_NTSCK = 0x01FC;
            const ushort REGION_CODE_PAL = 0x02FE;

            const int KEYVAULT_FILE_SIZE_A = 0x3FF0;
            const int KEYVAULT_FILE_SIZE_B = 0x4000;

            const int CONSOLE_SERIAL_OFFSET = 0xA0;
            const int CONSOLE_SERIAL_SIZE = 12;

            const int MOTHERBOARD_SERIAL_OFFSET = 0xB0;
            const int MOTHERBOARD_SERIAL_SIZE = 8;

            const int GAME_REGION_OFFSET = 0xB8;

            consoleSerial = "";
            motherboardSerial = "";

            if (!string.IsNullOrEmpty(keyvaultFile))
            {

                FileInfo file = new(keyvaultFile);
                int file_size = (int)file.Length;

                if (file_size != KEYVAULT_FILE_SIZE_A && file_size != KEYVAULT_FILE_SIZE_B)
                    return IMPORT_RESULT.ERROR_FILE_SIZE;

                byte[] buffer = new byte[file_size];

                try
                {
                    using FileStream IO = file.OpenRead();
                    if (IO.Read(buffer, 0, file_size) != file_size)
                        return IMPORT_RESULT.ERROR_FILE_ACCESS;
                }
                catch { return IMPORT_RESULT.ERROR_FILE_ACCESS; }

                int keyvault_type_offset = (file_size == KEYVAULT_FILE_SIZE_A ? 0 : 0x10);
                ushort current_region_code = BitConverter.ToUInt16(buffer, (GAME_REGION_OFFSET + keyvault_type_offset));
                current_region_code = (ushort)((current_region_code >> 8) | (current_region_code << 8)); //byte swap for BE

                if (current_region_code != REGION_CODE_NTSCU &&
                    current_region_code != REGION_CODE_PAL &&
                    current_region_code != REGION_CODE_NTSCJ &&
                    current_region_code != REGION_CODE_NTSCK)
                    return IMPORT_RESULT.ERROR_BAD_REGION;

                consoleSerial = Encoding.UTF8.GetString(buffer, (CONSOLE_SERIAL_OFFSET + keyvault_type_offset), CONSOLE_SERIAL_SIZE);
                motherboardSerial = BitConverter.ToString(buffer, (MOTHERBOARD_SERIAL_OFFSET + keyvault_type_offset), MOTHERBOARD_SERIAL_SIZE).Replace("-", "");

                return IMPORT_RESULT.ERROR_SUCCESS;
            }

            return IMPORT_RESULT.ERROR_FILE_ACCESS;
        }
    }
}