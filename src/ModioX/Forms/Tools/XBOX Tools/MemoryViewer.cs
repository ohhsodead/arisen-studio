using Be.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using XDevkit;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class MemoryViewer : XtraForm
    {
        #region variables

        private readonly AutoCompleteStringCollection _data = new AutoCompleteStringCollection();

        /// <summary>
        /// Get the instance of the current Xbox connection.
        /// </summary>
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;

        private readonly bool ButtonPokeIsPressed = false;
        private byte[] _old;

        #endregion variables

        public string GameTitle { get; set; }

        public MemoryViewer()
        {
            InitializeComponent();
            ChangeNumericMaxMin();
            ChangeNumericColor();
        }

        private void MemoryViewer_Load(object sender, EventArgs e)
        {
            HexBox.ForeColor = MainWindow.Settings.HexBoxForeColor;
            HexBox.BackColor = MainWindow.Settings.HexBoxBackColor;
        }

        private void MemoryViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(Xbox.XboxName == null)
            //{
            //    string Name = Assembly.GetExecutingAssembly().GetName().Name;
            //    foreach (var process in Process.GetProcessesByName(Name))
            //    {
            //        process.Kill();
            //    }
            //}
            //else
            //{
            //    //XConsole.Disconnect();
            //}
        }

        #region Handlers

        private void HexBoxSelectionStartChanged(object sender, EventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            var prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            var address = Functions.BytesToInt32(prev);
            TextBoxSelectedAddress.Text = string.Format((address + (int)HexBox.SelectionStart).ToString("X8"));
        }

        private void IsSignedCheckedChanged(object sender, EventArgs e)
        {
            ChangeNumericMaxMin();
            ChangeNumericValue();
        }

        private void NumericIntKeyPress(object sender, KeyPressEventArgs e)
        {
            if (HexBox.ByteProvider != null)
            {
                ChangedNumericValue(sender);
            }
        }

        private void NumericValueChanged(object sender, EventArgs e)
        {
            if (HexBox.ByteProvider != null)
            {
                ChangedNumericValue(sender);
            }
        }

        private void FixTheAddresses(object sender, EventArgs e)
        {
            var Sender = sender as TextEdit;

            try
            {
                if (Sender.Text == "") //If the users wiped the box we fill it with 4(00), an empty box is bad.
                {
                    Sender.Text = "00000000";
                    return;
                }

                if (Sender == PeekPokeAddressTextBox) //Address specific formatting. [32 Bit Address, no "0x"]
                {
                    var math = Sender.Text.Contains("+") ? "+" : "-";
                    //Checks for addition or subtraction symbol, defaults to subtract which is harmless if its not there.
                    Sender.Text = Sender.Text.ToUpper().StartsWith("0X")
                                      ? (Sender.Text.ToUpper().Substring(2).Trim())
                                      : Sender.Text.ToUpper().Trim();
                    //If has 0x remove it, set to upper and traim spaces.
                    var adrsample = Sender.Text.Split(Convert.ToChar(math));
                    //Now we check for addition commands
                    if (adrsample.Length >= 2)
                    {
                        var adrhex = ((uint)new UInt32Converter().ConvertFromString("0x" + adrsample[0]));
                        //Formats address to have 4 bytes and be hex.
                        if (!adrsample[1].Contains("0x"))
                            adrsample[1] = ("0x" + adrsample[1]); //Preps for conversion.
                        var adrhex2 = ((uint)new UInt32Converter().ConvertFromString(adrsample[1]));
                        //Formats address to have 4 bytes and be hex.
                        Sender.Text = math == "+"
                                          ? (adrhex + adrhex2).ToString("X8")
                                          : (adrhex - adrhex2).ToString("X8");
                    }

                    if (!Functions.IsHex(Sender.Text))
                    //Last check to see if its usable, if not the users an idiot.
                    {
                        while (Sender.Text.Length < 8) //pad out the address
                        {
                            Sender.Text = ("0" + Sender.Text);
                        }
                        //Sender.Text = (Sender.Text.ToString("X8"));
                        //ShowMessageBox("Input must be hex.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return; //End of Addressbox Specific code
                }
                if (!Functions.IsHex(Sender.Text))
                {
                    Sender.Text = Sender.Text.ToUpper().StartsWith("0X")
                                      ? (Sender.Text.ToUpper().Substring(2))
                                      : ((uint)new UInt32Converter().ConvertFromString(Sender.Text)).ToString(
                                          "X");
                }
            }
            catch
            {
            }
        }

        private void NewPeek()
        {
            //Clean up
            PeekPokeAddressTextBox.Text = "C0000000";
            peekLengthTextBox.Text = "FF";
            TextBoxSelectedAddress.Text = string.Empty;
            TextBoxPeekPokeFeedback.Text = string.Empty;
            NumericInt8.Value = 0;
            NumericInt16.Value = 0;
            NumericInt32.Value = 0;
            NumericFloatTextBox.Text = "0";
            HexBox.ByteProvider = null;
            HexBox.Refresh();
        }

        private void HexBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                HexBox.CopyHex();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                HexBox.SelectAll();

                e.SuppressKeyPress = true;
            }
        }

        private void HexBoxMouseUp(object sender, MouseEventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            if (HexBox.ByteProvider == null) return;
            var prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            var address = Functions.BytesToInt32(prev);
            TextBoxSelectedAddress.Text = string.Format((address + (int)HexBox.SelectionStart).ToString("X8"));
        }

        #endregion Handlers

        #region Functions

        private void ChangeNumericMaxMin()
        {
            if (SwitchIsSigned.IsOn)
            {
                NumericInt8.Properties.MaxValue = sbyte.MaxValue;
                NumericInt8.Properties.MinValue = sbyte.MinValue;
                NumericInt16.Properties.MaxValue = short.MaxValue;
                NumericInt16.Properties.MinValue = short.MinValue;
                NumericInt32.Properties.MaxValue = int.MaxValue;
                NumericInt32.Properties.MinValue = int.MinValue;
            }
            else
            {
                NumericInt8.Properties.MaxValue = byte.MaxValue;
                NumericInt8.Properties.MinValue = byte.MinValue;
                NumericInt16.Properties.MaxValue = ushort.MaxValue;
                NumericInt16.Properties.MinValue = ushort.MinValue;
                NumericInt32.Properties.MaxValue = uint.MaxValue;
                NumericInt32.Properties.MinValue = uint.MinValue;
            }
        }

        private void ChangeNumericValue()
        {
            if (HexBox.ByteProvider == null) return;
            var buffer = HexBox.ByteProvider.Bytes;
            if (SwitchIsSigned.IsOn)
            {
                NumericInt8.Value = (buffer.Count - HexBox.SelectionStart) > 0
                                        ? Functions.ByteToSByte(HexBox.ByteProvider.ReadByte(HexBox.SelectionStart))
                                        : 0;
                NumericInt16.Value = (buffer.Count - HexBox.SelectionStart) > 1
                                         ? Functions.BytesToInt16(
                                             buffer.GetRange((int)HexBox.SelectionStart, 2).ToArray())
                                         : 0;
                NumericInt32.Value = (buffer.Count - HexBox.SelectionStart) > 3
                                         ? Functions.BytesToInt32(
                                             buffer.GetRange((int)HexBox.SelectionStart, 4).ToArray())
                                         : 0;

                NumericFloatTextBox.MaskBox.Clear();
                var f = (buffer.Count - HexBox.SelectionStart) > 3
                              ? Functions.BytesToSingle(buffer.GetRange((int)HexBox.SelectionStart, 4).ToArray())
                              : 0;
                NumericFloatTextBox.Text = f.ToString();
            }
            else
            {
                NumericInt8.Value = (buffer.Count - HexBox.SelectionStart) > 0
                                        ? buffer[(int)HexBox.SelectionStart]
                                        : 0;
                NumericInt16.Value = (buffer.Count - HexBox.SelectionStart) > 1
                                         ? Functions.BytesToUInt16(
                                             buffer.GetRange((int)HexBox.SelectionStart, 2).ToArray())
                                         : 0;
                NumericInt32.Value = (buffer.Count - HexBox.SelectionStart) > 3
                                         ? Functions.BytesToUInt32(
                                             buffer.GetRange((int)HexBox.SelectionStart, 4).ToArray())
                                         : 0;

                NumericFloatTextBox.MaskBox.Clear();
                var f = (buffer.Count - HexBox.SelectionStart) > 3
                              ? Functions.BytesToSingle(buffer.GetRange((int)HexBox.SelectionStart, 4).ToArray())
                              : 0;
                NumericFloatTextBox.Text = f.ToString();
            }
            var prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            var address = Functions.BytesToInt32(prev);
            TextBoxSelectedAddress.Text = string.Format((address + (int)HexBox.SelectionStart).ToString("X8"));
        }

        private void ChangedNumericValue(object numfield)
        {
            if (HexBox.SelectionStart >= HexBox.ByteProvider.Bytes.Count) return;
            if (numfield.GetType() == typeof(NumericUpDown))
            {
                var numeric = (NumericUpDown)numfield;
                switch (numeric.Name)
                {
                    case "NumericInt8":
                        if (SwitchIsSigned.IsOn)
                        {
                            Console.WriteLine(((sbyte)numeric.Value).ToString("X2"));
                            HexBox.ByteProvider.WriteByte(HexBox.SelectionStart, Functions.HexToBytes(((sbyte)numeric.Value).ToString("X2"))[0]);
                        }
                        else
                        {
                            HexBox.ByteProvider.WriteByte(HexBox.SelectionStart, Convert.ToByte((byte)numeric.Value));
                        }
                        break;

                    case "NumericInt16":
                        for (var i = 0; i < 2; i++)
                        {
                            HexBox.ByteProvider.WriteByte(HexBox.SelectionStart + i, SwitchIsSigned.IsOn ? Functions.Int16ToBytes((short)numeric.Value)[i] : Functions.UInt16ToBytes((ushort)numeric.Value)[i]);
                        }
                        break;

                    case "NumericInt32":
                        for (var i = 0; i < 4; i++)
                        {
                            HexBox.ByteProvider.WriteByte(HexBox.SelectionStart + i,
                                                          SwitchIsSigned.IsOn ? Functions.Int32ToBytes((int)numeric.Value)[i] : Functions.UInt32ToBytes((uint)numeric.Value)[i]);
                        }
                        break;
                }
            }
            else
            {
                var textbox = (TextBox)numfield;
                for (var i = 0; i < 4; i++)
                {
                    HexBox.ByteProvider.WriteByte(HexBox.SelectionStart + i, Functions.FloatToByteArray(Convert.ToSingle(textbox.Text))[i]);
                }
            }

            HexBox.Refresh();
        }

        private void AutoComplete()
        {
            PeekPokeAddressTextBox.MaskBox.AutoCompleteCustomSource = _data; //put the auto complete data into the textbox
            var count = _data.Count;
            for (var index = 0; index < count; index++)
            {
                var value = _data[index];
                //if the text in peek or poke text box is not in autocomplete data - Add it
                if (!ReferenceEquals(value, PeekPokeAddressTextBox.Text))
                    _data.Add(PeekPokeAddressTextBox.Text);
            }
        }

        #endregion Functions

        #region Thread Safe

        private void SetHexBoxByteProvider(DynamicByteProvider value)
        {
            if (HexBox.InvokeRequired)
                Invoke((MethodInvoker)(() => SetHexBoxByteProvider(value)));
            else
            {
                HexBox.ByteProvider = value;
            }
        }

        private void SetHexBoxRefresh()
        {
            if (HexBox.InvokeRequired)
                Invoke((MethodInvoker)(SetHexBoxRefresh));
            else
            {
                HexBox.Refresh();
            }
        }

        private DynamicByteProvider GetHexBoxByteProvider()
        {
            //recursion
            var returnVal = new DynamicByteProvider(new byte[] { 0, 0, 0, 0 });
            if (HexBox.InvokeRequired)
                HexBox.Invoke((MethodInvoker)
                              delegate { returnVal = GetHexBoxByteProvider(); });
            else
                return (DynamicByteProvider)HexBox.ByteProvider;
            return returnVal;
        }

        #endregion Thread Safe

        #region Thread Function

        private void Peek()
        {
            try
            {
                if (string.IsNullOrEmpty(peekLengthTextBox.Text) || Convert.ToUInt32(peekLengthTextBox.Text, 16) == 0)
                    throw new Exception("Invalid peek length!");

                if (string.IsNullOrEmpty(PeekPokeAddressTextBox.Text) || Convert.ToUInt32(PeekPokeAddressTextBox.Text, 16) == 0)
                    throw new Exception("Address cannot be 0 or null");
                //convert peek result string values to byte

                var retValue =
                    Functions.StringToByteArray(XboxConsole.Peek(PeekPokeAddressTextBox.Text, peekLengthTextBox.Text, PeekPokeAddressTextBox.Text, peekLengthTextBox.Text));
                var buffer = new DynamicByteProvider(retValue); //object initilizer

                _old = new byte[buffer.Bytes.Count];
                buffer.Bytes.CopyTo(_old);

                SetHexBoxByteProvider(buffer);
                SetHexBoxRefresh();
            }
            catch
            {
            }
        }

        private void Poke()
        {
            try
            {
                var dumplength = (uint)HexBox.ByteProvider.Length / 2;
                XboxConsole.DumpOffset = Functions.Convert(PeekPokeAddressTextBox.Text); //Set the dump offset
                XboxConsole.DumpLength = dumplength; //The length of data to dump

                var buffer = GetHexBoxByteProvider();
                if (SwitchFillMemory.IsOn)
                {
                    for (var i = 0; i < dumplength; i++)
                    {
                        var value = Convert.ToUInt32(PeekPokeAddressTextBox.Text, 16);
                        var address = string.Format((value + i).ToString("X8"));
                        XboxConsole.Poke(address, string.Format("{0,0:X2}", Convert.ToByte(TextBoxFillValue.Text, 16)));
                    }
                }
                else
                {
                    for (var i = 0; i < buffer.Bytes.Count; i++)
                    {
                        if (buffer.Bytes[i] == _old[i]) continue;

                        var value = Convert.ToUInt32(PeekPokeAddressTextBox.Text, 16);
                        var address = string.Format((value + i).ToString("X8"));
                        XboxConsole.Poke(address, string.Format("{0,0:X2}", buffer.Bytes[i]));
                        //success
                    }
                }
            }
            catch
            {
            }
        }

        #endregion Thread Function

        private void ButtonPeek_Click(object sender, EventArgs e)
        {
        }

        private void ButtonPoke_Click(object sender, EventArgs e)
        {
            AutoComplete(); //run function
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            NewPeek();
        }

        private void AutoPeek_Tick(object sender, EventArgs e)
        {
        }

        private void AutoPoke_Tick(object sender, EventArgs e)
        {
        }

        private void ChangeNumericColor()
        {
            NumericInt8.BackColor = NumericFloatTextBox.BackColor;
            NumericInt8.ForeColor = NumericFloatTextBox.ForeColor;
            NumericInt16.BackColor = NumericFloatTextBox.BackColor;
            NumericInt16.ForeColor = NumericFloatTextBox.ForeColor;
            NumericInt32.BackColor = NumericFloatTextBox.BackColor;
            NumericInt32.ForeColor = NumericFloatTextBox.ForeColor;
        }

        private void ButtonSelectedAddress_DoubleClick(object sender, EventArgs e)
        {
            PeekPokeAddressTextBox.Text = TextBoxSelectedAddress.Text;
        }

        private void ButtonDumpMemory_Click(object sender, EventArgs e)
        {
            if (ButtonPokeIsPressed == true) //when button poke is press then
            {
                try
                {
                    var sfd = new SaveFileDialog
                    {
                        Filter = "Text File|*.txt"
                    };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        //disable here
                        var path = sfd.FileName;
                        var bw = new BinaryWriter(File.Create(path));
                        HexBox.SelectAll();//selectsall
                        HexBox.CopyHex();//copy's hex
                        TextBoxPasteClipboard.Text = Clipboard.GetText();//clipboards it and paste iT to text file
                        bw.Write(TextBoxPasteClipboard.Text);
                        bw.Dispose();
                        //enable here
                        XtraMessageBox.Show("Your Live Dump Has Been Logged To - " + sfd.FileName, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                }
            }

            if (ButtonPokeIsPressed == false)
            {
                XtraMessageBox.Show("You Must Seek Bytes To Dump The Load");
            }
        }

        private void SwitchFreezeConsole_Toggled(object sender, EventArgs e)
        {
            if (XboxClient.XboxName == null)
            {
                SwitchFreezeConsole.IsOn = false;
            }
            else
            {
                switch (SwitchFreezeConsole.IsOn)
                {
                    case true:
                        XboxConsole.FreezeConsole(XboxSwitch.True);
                        break;

                    case false:
                        XboxConsole.FreezeConsole(XboxSwitch.False);
                        break;
                }
            }
        }

        private string GetTextBoxText(Control control)
        {
            //recursion
            var returnVal = "";
            if (control.InvokeRequired)
                control.Invoke((MethodInvoker)
                               delegate { returnVal = GetTextBoxText(control); });
            else
                return control.Text;
            return returnVal;
        }

        private void SwitchIsSigned_Toggled(object sender, EventArgs e)
        {
            ChangeNumericMaxMin();
            ChangeNumericValue();
        }

        private void HexBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                HexBox.CopyHex();
                e.SuppressKeyPress = true;
            }
        }

        private void HexBox_SelectionStartChanged(object sender, EventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            var prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            var address = Functions.BytesToInt32(prev);
            TextBoxSelectedAddress.Text = string.Format((address + (int)HexBox.SelectionStart).ToString("X8"));
        }

        private void HexBox_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            if (HexBox.ByteProvider == null) return;
            var prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            var address = Functions.BytesToInt32(prev);
            TextBoxSelectedAddress.Text = string.Format((address + (int)HexBox.SelectionStart).ToString("X8"));
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
        }

        private void PeekPokeAddressTextBox_Click_1(object sender, EventArgs e)
        {
        }

        private void NumericInt8_Click(object sender, EventArgs e)
        {
        }

        private void NumericInt16_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(NumericInt16.Value.ToString());
        }

        private void NumericInt8_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(NumericInt8.Value.ToString());
        }

        private void NumericInt32_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(NumericInt32.Value.ToString());
        }

        private void NumericFloatTextBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(NumericFloatTextBox.Text);
        }

        private void PeekPokeAddressTextBox_DoubleClick(object sender, EventArgs e)
        {
            PeekPokeAddressTextBox.Text = Clipboard.GetText();
        }

        private void MemoryViewer_BackColorChanged(object sender, EventArgs e)
        {
            ChangeNumericColor();
        }

        private void TextBoxPeekPokeFeedback_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBoxPeekPokeFeedback.Text);
        }
    }
}