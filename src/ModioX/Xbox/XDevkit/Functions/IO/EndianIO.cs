namespace XDevkit
{
    using System.IO;

    public class EndianIO
    {
        private readonly bool isfile;
        private bool isOpen;
        private System.IO.Stream stream;
        private readonly string filepath;
        private readonly EndianType endiantype;
        private EndianReader _in;
        private EndianWriter _out;

        public EndianIO(System.IO.Stream Stream, EndianType EndianStyle)
        {
            this.filepath = "";
            this.endiantype = EndianType.LittleEndian;
            this.endiantype = EndianStyle;
            this.stream = Stream;
            this.isfile = false;
        }

        public EndianIO(string FilePath, EndianType EndianStyle)
        {
            this.filepath = "";
            this.endiantype = EndianType.LittleEndian;
            this.endiantype = EndianStyle;
            this.filepath = FilePath;
            this.isfile = true;
        }

        public EndianIO(byte[] Buffer, EndianType EndianStyle)
        {
            this.filepath = "";
            this.endiantype = EndianType.LittleEndian;
            this.endiantype = EndianStyle;
            this.stream = new MemoryStream(Buffer);
            this.isfile = false;
        }

        public void Close()
        {
            if (this.isOpen)
            {
                this.stream.Close();
                this._in.Close();
                this._out.Close();
                this.isOpen = false;
            }
        }

        public void Open()
        {
            if (!this.isOpen)
            {
                if (this.isfile)
                {
                    this.stream = new FileStream(this.filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                }
                this._in = new EndianReader(this.stream, this.endiantype);
                this._out = new EndianWriter(this.stream, this.endiantype);
                this.isOpen = true;
            }
        }

        public void SeekTo(int offset)
        {
            this.SeekTo(offset, SeekOrigin.Begin);
        }

        public void SeekTo(uint offset)
        {
            this.SeekTo((int)offset, SeekOrigin.Begin);
        }

        public void SeekTo(int offset, SeekOrigin SeekOrigin)
        {
            this.stream.Seek(offset, SeekOrigin);
        }

        public bool Opened =>
            this.isOpen;

        public bool Closed =>
            !this.isOpen;

        public EndianReader In =>
            this._in;

        public EndianWriter Out =>
            this._out;

        public System.IO.Stream Stream =>
            this.stream;
    }
}

