using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace XDevkit
{
    public partial class xex_value : UserControl
    {
        public string offset;
        private string origvalue;
        public Stream stream;

        public xex_value()
        {
            InitializeComponent();
            foreach (Control control in base.Controls)
            {
                control.ContextMenuStrip = contextMenuStrip1;
            }
        }
        public void pokeXbox(uint offset, string poketype, string ammount)
        {
            if (!checkBox1.Checked)
            {
                ammount = int.Parse(ammount).ToString("X");
            }
            try
            {
                EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
                nio.Open();
                nio.Out.BaseStream.Position = offset;
                if (poketype == "Unicode String")
                {
                    nio.Out.WriteUnicodeString(ammount, ammount.Length);
                }
                if (poketype == "ASCII String")
                {
                    nio.Out.WriteUnicodeString(ammount, ammount.Length);
                }
                if ((poketype == "String") | (poketype == "string"))
                {
                    nio.Out.Write(ammount);
                }
                if ((poketype == "Float") | (poketype == "float"))
                {
                    nio.Out.Write(float.Parse(ammount));
                }
                if ((poketype == "Double") | (poketype == "double"))
                {
                    nio.Out.Write(double.Parse(ammount));
                }
                if ((poketype == "Short") | (poketype == "short"))
                {
                    nio.Out.Write((short)Convert.ToUInt32(ammount, 0x10));
                }
                if ((poketype == "Byte") | (poketype == "byte"))
                {
                    nio.Out.Write((byte)Convert.ToUInt32(ammount, 0x10));
                }
                if ((poketype == "Long") | (poketype == "long"))
                {
                    nio.Out.Write((long)Convert.ToUInt32(ammount, 0x10));
                }
                if ((poketype == "Quad") | (poketype == "quad"))
                {
                    nio.Out.Write((long)Convert.ToUInt64(ammount, 0x10));
                }
                if ((poketype == "Int") | (poketype == "int"))
                {
                    nio.Out.Write(Convert.ToUInt32(ammount, 0x10));
                }
                if ((poketype == "Bytes") | (poketype == "bytes"))
                {
                    nio.Out.Write(Functions.HexStringToBytes(ammount), 0, Functions.HexStringToBytes(ammount).Count());
                }

            }
            catch
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pokeXbox(Convert.ToUInt32(offset, 0x10), Type.Text, Value.Text);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Value.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Address.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Value.Text = Clipboard.GetText();
        }

        private void revertValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Value.Text = origvalue;
        }

        public void setvalues(string o, string v, string t, Dictionary<string, Items> itmlst)
        {
            offset = "0x" + o;
            origvalue = v;
            if (itmlst.ContainsKey("0x" + o))
            {
                o = itmlst["0x" + o].Name;
            }
            Address.Text = o;
            Value.Text = v;
            Type.Text = t;
        }
        public void set(string ADDR, string value, string type)
        {
            Address.Text = ADDR;
            Value.Text = value;
            Type.Text = type;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if checked it will set to 99999999 else change it to 1 then add a revert option
        }
    }
}
