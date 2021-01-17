namespace XDevkit
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct BitmapSubmap
    {
        public int Width;
        public int Height;
        public int Depth;
        public TextureType Type;
        public TextureFormat Format;
        public int RawLength;
        public byte Index1;
        public byte Index2;
        public int vWidth =>
            this.GetVirtualDimension(this.Width);
        public int vHeight =>
            this.GetVirtualDimension(this.Height);
        public BitmapSubmap(EndianReader er)
        {
            this.Width = er.ReadInt16();
            this.Height = er.ReadInt16();
            this.Depth = er.ReadInt16();
            this.Type = (TextureType) er.ReadInt16();
            this.Format = (TextureFormat) er.ReadInt16();
            er.ReadInt16();
            er.ReadInt16();
            er.ReadInt16();
            er.ReadByte();
            er.ReadByte();
            this.Index1 = er.ReadByte();
            this.Index2 = er.ReadByte();
            er.ReadInt32();
            er.ReadInt32();
            er.ReadInt32();
            this.RawLength = er.ReadInt32();
            er.ReadInt32();
            er.ReadInt32();
        }

        public bool IsDefined =>
            Enum.IsDefined(typeof(TextureFormat), this.Format);
        public bool IsSupported =>
            (((((this.Format == TextureFormat.DXT1) || (this.Format == TextureFormat.DXT3)) || ((this.Format == TextureFormat.DXT5) || (this.Format == TextureFormat.CTX1))) || (this.Format == TextureFormat.DXN)) || (this.Format == TextureFormat.A8R8G8B8));
        public int GetVirtualDimension(int Size)
        {
            if ((Size % 0x80) != 0)
            {
                Size += 0x80 - (Size % 0x80);
            }
            return Size;
        }
        public enum TextureType : short
        {
            CubeMap = 2,
            DXT5 = 0x10,
            Sprite = 3,
            Texture2D = 0,
            Texture3D = 1,
            UIBitmap = 4
        }
    }
}

