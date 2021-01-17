namespace XDevkit
{
    using System;
    using System.IO;

    public class EndianReader : BinaryReader
    {
        public EndianType endianstyle;

        public EndianReader(Stream stream, EndianType endianstyle) : base(stream)
        {
            this.endianstyle = endianstyle;
        }

        public string ReadAsciiString(int Length) =>
            this.ReadAsciiString(Length, this.endianstyle);

        public string ReadAsciiString(int Length, EndianType EndianType)
        {
            string str = "";
            int num = 0;
            int num2 = 0;
            while (true)
            {
                if (num2 < Length)
                {
                    char ch = (char)this.ReadByte();
                    num++;
                    if (ch != '\0')
                    {
                        str = str + ch;
                        num2++;
                        continue;
                    }
                }
                int num3 = Length - num;
                this.BaseStream.Seek(num3, SeekOrigin.Current);
                return str;
            }
        }

        public override double ReadDouble() =>
            this.ReadDouble(this.endianstyle);

        public double ReadDouble(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(8);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToDouble(array, 0);
        }

        public override short ReadInt16() =>
            this.ReadInt16(this.endianstyle);

        public short ReadInt16(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(2);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToInt16(array, 0);
        }

        public int ReadInt24() =>
            this.ReadInt24(this.endianstyle);

        public int ReadInt24(EndianType EndianType)
        {
            byte[] destinationArray = new byte[4];
            Array.Copy(base.ReadBytes(3), 0, destinationArray, 0, 3);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(destinationArray);
            }
            return BitConverter.ToInt32(destinationArray, 0);
        }

        public override int ReadInt32() =>
            this.ReadInt32(this.endianstyle);

        public int ReadInt32(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(4);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToInt32(array, 0);
        }

        public override long ReadInt64() =>
            this.ReadInt64(this.endianstyle);

        public long ReadInt64(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(8);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToInt64(array, 0);
        }

        public string ReadNullTerminatedString()
        {
            string str = "";
            while (true)
            {
                char ch;
                bool flag = (ch = this.ReadChar()) != '\0';
                if (!flag || (ch == '\0'))
                {
                    return str;
                }
                str = str + ch;
            }
        }

        public override float ReadSingle() =>
            this.ReadSingle(this.endianstyle);

        public float ReadSingle(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(4);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToSingle(array, 0);
        }

        public override string ReadString()
        {
            string str = "";
            int num = 0;
            while (true)
            {
                char ch = (char)this.ReadByte();
                num++;
                if (ch == '\0')
                {
                    int num2 = str.Length - num;
                    this.BaseStream.Seek(num2 + 1, SeekOrigin.Current);
                    return str;
                }
                str = str + ch;
            }
        }

        public string ReadString(int Length) =>
            this.ReadAsciiString(Length);

        public override ushort ReadUInt16() =>
            this.ReadUInt16(this.endianstyle);

        public ushort ReadUInt16(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(2);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToUInt16(array, 0);
        }

        public override uint ReadUInt32() =>
            this.ReadUInt32(this.endianstyle);

        public uint ReadUInt32(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(4);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToUInt32(array, 0);
        }

        public override ulong ReadUInt64() =>
            this.ReadUInt64(this.endianstyle);

        public ulong ReadUInt64(EndianType EndianType)
        {
            byte[] array = base.ReadBytes(8);
            if (EndianType == EndianType.BigEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToUInt64(array, 0);
        }

        public string ReadUnicodeString(int Length) =>
            this.ReadUnicodeString(Length, this.endianstyle);

        public string ReadUnicodeString(int Length, EndianType EndianType)
        {
            string str = "";
            int num = 0;
            int num2 = 0;
            while (true)
            {
                if (num2 < Length)
                {
                    char ch = (char)this.ReadUInt16(EndianType);
                    num++;
                    if (ch != '\0')
                    {
                        str = str + ch;
                        num2++;
                        continue;
                    }
                }
                int num3 = (Length - num) * 2;
                this.BaseStream.Seek(num3, SeekOrigin.Current);
                return str;
            }
        }

        public void SeekTo(int offset)
        {
            this.SeekTo(offset, SeekOrigin.Begin);
        }

        public void SeekTo(long offset)
        {
            this.SeekTo((int)offset, SeekOrigin.Begin);
        }

        public void SeekTo(uint offset)
        {
            this.SeekTo((int)offset, SeekOrigin.Begin);
        }

        public void SeekTo(int offset, SeekOrigin SeekOrigin)
        {
            this.BaseStream.Seek(offset, SeekOrigin);
        }
    }
}

