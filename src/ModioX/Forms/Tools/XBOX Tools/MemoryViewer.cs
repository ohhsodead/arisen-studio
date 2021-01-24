using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Be.Windows.Forms;
using XDevkit;
using System.IO;
using ModioX.Forms.Windows;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class Memory : XtraForm
    {
        #region variables
        private readonly AutoCompleteStringCollection _data = new AutoCompleteStringCollection();
        /// <summary>
        /// Creates an TCP connection for use with uploading mods, uploading files.
        /// </summary>
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;
        private bool button1WasClicked = false;
        private byte[] _old;

        #endregion variables

        public Memory()
        {

            InitializeComponent();
            ChangeNumericMaxMin();
            ChangeNumericColor();
            //try
            //{
            //    hexBox.ForeColor = Settings.Fore_Color;
            //    hexBox.BackColor = Settings.Back_Color;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Not Connected. Please check network");
            //    MessageBox.Show(ex.Message);

            //}
        }
        #region Handlers


        private void HexBoxSelectionStartChanged(object sender, EventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            byte[] prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            int address = Functions.BytesToInt32(prev);
            SelAddress.Text = string.Format((address + (int)hexBox.SelectionStart).ToString("X8"));
        }

        private void IsSignedCheckedChanged(object sender, EventArgs e)
        {
            ChangeNumericMaxMin();
            ChangeNumericValue();
        }

        private void NumericIntKeyPress(object sender, KeyPressEventArgs e)
        {
            if (hexBox.ByteProvider != null)
            {
                ChangedNumericValue(sender);
            }
        }

        private void NumericValueChanged(object sender, EventArgs e)
        {
            if (hexBox.ByteProvider != null)
            {
                ChangedNumericValue(sender);
            }
        }

        private void FixTheAddresses(object sender, EventArgs e)
        {
            var Sender = sender as TextEdit;
            {
                if (Sender != null)
                    try
                    {
                        if (Sender.Text == "") //If the users wiped the box we fill it with 4(00), an empty box is bad.
                        {
                            Sender.Text = "00000000";
                            return;
                        }

                        if (Sender == PeekPokeAddressTextBox) //Address specific formatting. [32 Bit Address, no "0x"]
                        {
                            string math = Sender.Text.Contains("+") ? "+" : "-";
                            //Checks for addition or subtraction symbol, defaults to subtract which is harmless if its not there.
                            Sender.Text = Sender.Text.ToUpper().StartsWith("0X")
                                              ? (Sender.Text.ToUpper().Substring(2).Trim())
                                              : Sender.Text.ToUpper().Trim();
                            //If has 0x remove it, set to upper and traim spaces.
                            string[] adrsample = Sender.Text.Split(Convert.ToChar(math));
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
        }


        

        private void NewPeek()
        {
            //Clean up
            PeekPokeAddressTextBox.Text = "C0000000";
            peekLengthTextBox.Text = "FF";
            SelAddress.Text = string.Empty;
            peekPokeFeedBackTextBox.Text = string.Empty;
            NumericInt8.Value = 0;
            NumericInt16.Value = 0;
            NumericInt32.Value = 0;
            NumericFloatTextBox.Text = "0";
            hexBox.ByteProvider = null;
            hexBox.Refresh();
        }


        private void HexBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                hexBox.CopyHex();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                hexBox.SelectAll();

                e.SuppressKeyPress = true;
            }

        }

        private void HexBoxMouseUp(object sender, MouseEventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            if (hexBox.ByteProvider == null) return;
            byte[] prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            int address = Functions.BytesToInt32(prev);
            SelAddress.Text = string.Format((address + (int)hexBox.SelectionStart).ToString("X8"));
        }

        #endregion Handlers

        #region Functions

        private void ChangeNumericMaxMin()
        {
            if (isSigned.IsOn)
            {
                NumericInt8.Maximum = SByte.MaxValue;
                NumericInt8.Minimum = SByte.MinValue;
                NumericInt16.Maximum = Int16.MaxValue;
                NumericInt16.Minimum = Int16.MinValue;
                NumericInt32.Maximum = Int32.MaxValue;
                NumericInt32.Minimum = Int32.MinValue;
            }
            else
            {
                NumericInt8.Maximum = Byte.MaxValue;
                NumericInt8.Minimum = Byte.MinValue;
                NumericInt16.Maximum = UInt16.MaxValue;
                NumericInt16.Minimum = UInt16.MinValue;
                NumericInt32.Maximum = UInt32.MaxValue;
                NumericInt32.Minimum = UInt32.MinValue;
            }
        }

        private void ChangeNumericValue()
        {
            if (hexBox.ByteProvider == null) return;
            List<byte> buffer = hexBox.ByteProvider.Bytes;
            if (isSigned.IsOn)
            {
                NumericInt8.Value = (buffer.Count - hexBox.SelectionStart) > 0
                                        ? Functions.ByteToSByte(hexBox.ByteProvider.ReadByte(hexBox.SelectionStart))
                                        : 0;
                NumericInt16.Value = (buffer.Count - hexBox.SelectionStart) > 1
                                         ? Functions.BytesToInt16(
                                             buffer.GetRange((int)hexBox.SelectionStart, 2).ToArray())
                                         : 0;
                NumericInt32.Value = (buffer.Count - hexBox.SelectionStart) > 3
                                         ? Functions.BytesToInt32(
                                             buffer.GetRange((int)hexBox.SelectionStart, 4).ToArray())
                                         : 0;

                NumericFloatTextBox.MaskBox.Clear();
                float f = (buffer.Count - hexBox.SelectionStart) > 3
                              ? Functions.BytesToSingle(buffer.GetRange((int)hexBox.SelectionStart, 4).ToArray())
                              : 0;
                NumericFloatTextBox.Text = f.ToString();
            }
            else
            {
                NumericInt8.Value = (buffer.Count - hexBox.SelectionStart) > 0
                                        ? buffer[(int)hexBox.SelectionStart]
                                        : 0;
                NumericInt16.Value = (buffer.Count - hexBox.SelectionStart) > 1
                                         ? Functions.BytesToUInt16(
                                             buffer.GetRange((int)hexBox.SelectionStart, 2).ToArray())
                                         : 0;
                NumericInt32.Value = (buffer.Count - hexBox.SelectionStart) > 3
                                         ? Functions.BytesToUInt32(
                                             buffer.GetRange((int)hexBox.SelectionStart, 4).ToArray())
                                         : 0;

                NumericFloatTextBox.MaskBox.Clear();
                float f = (buffer.Count - hexBox.SelectionStart) > 3
                              ? Functions.BytesToSingle(buffer.GetRange((int)hexBox.SelectionStart, 4).ToArray())
                              : 0;
                NumericFloatTextBox.Text = f.ToString();
            }
            byte[] prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            int address = Functions.BytesToInt32(prev);
            SelAddress.Text = string.Format((address + (int)hexBox.SelectionStart).ToString("X8"));
        }

        private void ChangedNumericValue(object numfield)
        {
            if (hexBox.SelectionStart >= hexBox.ByteProvider.Bytes.Count) return;
            if (numfield.GetType() == typeof(NumericUpDown))
            {
                var numeric = (NumericUpDown)numfield;
                switch (numeric.Name)
                {
                    case "NumericInt8":
                        if (isSigned.IsOn)
                        {
                            Console.WriteLine(((sbyte)numeric.Value).ToString("X2"));
                            hexBox.ByteProvider.WriteByte(hexBox.SelectionStart,
                                                          Functions.HexToBytes(((sbyte)numeric.Value).ToString("X2"))[0
                                                              ]);
                        }
                        else
                        {
                            hexBox.ByteProvider.WriteByte(hexBox.SelectionStart,
                                                          Convert.ToByte((byte)numeric.Value));
                        }
                        break;

                    case "NumericInt16":
                        for (int i = 0; i < 2; i++)
                        {
                            hexBox.ByteProvider.WriteByte(hexBox.SelectionStart + i, isSigned.IsOn
                                                                                         ? Functions.Int16ToBytes(
                                                                                             (short)numeric.Value)[i]
                                                                                         : Functions.UInt16ToBytes(
                                                                                             (ushort)numeric.Value)[i]);
                        }
                        break;

                    case "NumericInt32":
                        for (int i = 0; i < 4; i++)
                        {
                            hexBox.ByteProvider.WriteByte(hexBox.SelectionStart + i, isSigned.IsOn
                                                                                         ? Functions.Int32ToBytes(
                                                                                             (int)numeric.Value)[i]
                                                                                         : Functions.UInt32ToBytes(
                                                                                             (uint)numeric.Value)[i]);
                        }
                        break;
                }
            }
            else
            {
                var textbox = (TextBox)numfield;
                for (int i = 0; i < 4; i++)
                {
                    hexBox.ByteProvider.WriteByte(hexBox.SelectionStart + i,
                                                  Functions.FloatToByteArray(Convert.ToSingle(textbox.Text))[i]);
                }
            }
            hexBox.Refresh();
        }

        private void AutoComplete()
        {
            PeekPokeAddressTextBox.MaskBox.AutoCompleteCustomSource = _data; //put the auto complete data into the textbox
            int count = _data.Count;
            for (int index = 0; index < count; index++)
            {
                string value = _data[index];
                //if the text in peek or poke text box is not in autocomplete data - Add it
                if (!ReferenceEquals(value, PeekPokeAddressTextBox.Text))
                    _data.Add(PeekPokeAddressTextBox.Text);
            }
        }

        #endregion Functions

        #region Thread Safe

        private void SetHexBoxByteProvider(DynamicByteProvider value)
        {
            if (hexBox.InvokeRequired)
                Invoke((MethodInvoker)(() => SetHexBoxByteProvider(value)));
            else
            {
                hexBox.ByteProvider = value;
            }
        }

        private void SetHexBoxRefresh()
        {
            if (hexBox.InvokeRequired)
                Invoke((MethodInvoker)(SetHexBoxRefresh));
            else
            {
                hexBox.Refresh();
            }
        }

        private DynamicByteProvider GetHexBoxByteProvider()
        {
            //recursion
            var returnVal = new DynamicByteProvider(new byte[] { 0, 0, 0, 0 });
            if (hexBox.InvokeRequired)
                hexBox.Invoke((MethodInvoker)
                              delegate { returnVal = GetHexBoxByteProvider(); });
            else
                return (DynamicByteProvider)hexBox.ByteProvider;
            return returnVal;
        }

        #endregion Thread Safe

        #region Thread Function

        private void Peek(object a)
        {
            try
            {
                if (string.IsNullOrEmpty(peekLengthTextBox.Text) ||
                    Convert.ToUInt32(peekLengthTextBox.Text, 16) == 0)
                    throw new Exception("Invalid peek length!");
                if (string.IsNullOrEmpty(PeekPokeAddressTextBox.Text) ||
                    Convert.ToUInt32(PeekPokeAddressTextBox.Text, 16) == 0)
                    throw new Exception("Address cannot be 0 or null");
                //convert peek result string values to byte

                byte[] retValue =
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

        private void Poke(object a)
        {
            try
            {
                uint dumplength = (uint)hexBox.ByteProvider.Length / 2;
                XboxConsole.DumpOffset = Functions.Convert(PeekPokeAddressTextBox.Text); //Set the dump offset
                XboxConsole.DumpLength = dumplength; //The length of data to dump

                DynamicByteProvider buffer = GetHexBoxByteProvider();
                if (FilltoggleSwitch.IsOn)
                {
                    for (int i = 0; i < dumplength; i++)
                    {
                        uint value = Convert.ToUInt32(PeekPokeAddressTextBox.Text, 16);
                        string address = string.Format((value + i).ToString("X8"));
                        XboxConsole.Poke(address, String.Format("{0,0:X2}", Convert.ToByte(fillValueTextBox.Text, 16)));
                    }
                }
                else
                {
                    for (int i = 0; i < buffer.Bytes.Count; i++)
                    {
                        if (buffer.Bytes[i] == _old[i]) continue;

                        uint value = Convert.ToUInt32(PeekPokeAddressTextBox.Text, 16);
                        string address = string.Format((value + i).ToString("X8"));
                        XboxConsole.Poke(address, String.Format("{0,0:X2}", buffer.Bytes[i]));
                        //success
                    }
                }
            }
            catch
            {

            }
        }

        #endregion Thread Function

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            AutoComplete(); //run function
        }
        private void PeekPokeAddressTextBox_Click(object sender, EventArgs e)
        {



        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            NewPeek();
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

        private void AutoPeek_Tick(object sender, EventArgs e)
        {

        }

        private void AutoPoke_Tick(object sender, EventArgs e)
        {

        }

        private void MemoryViewer_Load(object sender, EventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void SelAddress_DoubleClick(object sender, EventArgs e)
        {
            PeekPokeAddressTextBox.Text = (SelAddress.Text);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (button1WasClicked == true) //when button poke is press then
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text File|*.txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        //disable here
                        string path = sfd.FileName;
                        BinaryWriter bw = new BinaryWriter(File.Create(path));
                        hexBox.SelectAll();//selectsall
                        hexBox.CopyHex();//copy's hex
                        txtPaste.Text = Clipboard.GetText();//clipboards it and paste iT to text file
                        bw.Write(txtPaste.Text);
                        bw.Dispose();
                        //enable here
                        MessageBox.Show("Your Live Dump Has Been Logged To - " + sfd.FileName, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch
                {

                }
            }
            if (button1WasClicked == false)
            {
                MessageBox.Show("You Must Seek Bytes To Dump The Load");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


        }


        private void toggleSwitch2_Toggled(object sender, EventArgs e)
        {
            if (XboxClient.XboxName == null)
            {
                toggleSwitch2.IsOn = false;

            }
            else
            {
                switch (toggleSwitch2.IsOn)
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
            string returnVal = "";
            if (control.InvokeRequired)
                control.Invoke((MethodInvoker)
                               delegate { returnVal = GetTextBoxText(control); });
            else
                return control.Text;
            return returnVal;
        }
        private void isSigned_Toggled(object sender, EventArgs e)
        {
            ChangeNumericMaxMin();
            ChangeNumericValue();
        }

        private void hexBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                hexBox.CopyHex();
                e.SuppressKeyPress = true;
            }
        }

        private void hexBox_SelectionStartChanged(object sender, EventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            byte[] prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            int address = Functions.BytesToInt32(prev);
            SelAddress.Text = string.Format((address + (int)hexBox.SelectionStart).ToString("X8"));
        }

        private void hexBox_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeNumericValue(); //When you select an offset on the hexbox

            if (hexBox.ByteProvider == null) return;
            byte[] prev = Functions.HexToBytes(PeekPokeAddressTextBox.Text);
            int address = Functions.BytesToInt32(prev);
            SelAddress.Text = string.Format((address + (int)hexBox.SelectionStart).ToString("X8"));
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
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

        private void peekPokeFeedBackTextBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(peekPokeFeedBackTextBox.Text);
        }

        private void Memory_Load(object sender, EventArgs e)
        {

        }
    }
}