using System;
using System.IO;
using System.Windows.Forms;

namespace XDevkit
{
    public partial class xex_slider : UserControl
    {
        private uint Offset;
        private string Type;
        public Stream stream;

        public xex_slider()
        {
            InitializeComponent();
        }
        public void setValues(string name, uint offset, float start, float range, string type)
        {
            Offset = offset;
            label1.Text = name;
            Type = type;
            trackBar1.SetRange(((int)start) * 10, ((int)range) * 10);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float num = trackBar1.Value;
            num /= 10f;
            streampoke(Offset, Type, num.ToString());
        }
        public void streampoke(uint offset, string poketype, string ammount)
        {

                EndianIO nio = new EndianIO(stream, EndianType.BigEndian);
                nio.Open();
                nio.Out.BaseStream.Position = offset;
                if (poketype == "Float")
                {
                    nio.Out.Write(float.Parse(ammount));
                }
                if (poketype == "Double")
                {
                    nio.Out.Write(double.Parse(ammount));
                }
                if (poketype == "String")
                {
                    nio.Out.Write(ammount);
                }
                if (poketype == "Short")
                {
                    nio.Out.Write((short)Convert.ToUInt32(ammount, 0x10));
                }
                if (poketype == "Byte")
                {
                    nio.Out.Write((byte)Convert.ToUInt32(ammount, 0x10));
                }
                if (poketype == "Long")
                {
                    nio.Out.Write((long)Convert.ToUInt32(ammount, 0x10));
                }
                if (poketype == "Quad")
                {
                    nio.Out.Write((long)Convert.ToUInt64(ammount, 0x10));
                }
                if (poketype == "Int")
                {
                    nio.Out.Write(Convert.ToUInt32(ammount, 0x10));
                }
        }
    }
}
