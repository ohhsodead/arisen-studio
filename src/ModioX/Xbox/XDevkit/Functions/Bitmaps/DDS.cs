namespace XDevkit
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DDS
    {
        public int dwMagic;
        public int dwSize;
        public DDSD dwFlags;
        public int dwHeight;
        public int dwWidth;
        public int dwPitchOrLinearSize;
        public int dwDepth;
        public int dwMipMapCount;
        public int[] dwReserved1;
        public int dwSize2;
        public DDPF dwFlags2;
        public FourCC dwFourCC;
        public int dwRGBBitCount;
        public int dwRBitMask;
        public int dwGBitMask;
        public int dwBBitMask;
        public uint dwRGBAlphaBitMask;
        public DDSCAPS dwCaps1;
        public DDSCAPS2 dwCaps2;
        public int[] Reserved2;
        public int dwReserved3;
        public DDS(BitmapSubmap BitmapInfo)
        {
            this.dwMagic = 0x20534444;
            this.dwSize = 0x7c;
            this.dwFlags = 0;
            this.dwFlags |= DDSD.CAPS;
            this.dwFlags |= DDSD.HEIGHT;
            this.dwFlags |= DDSD.WIDTH;
            this.dwFlags |= DDSD.PIXELFORMAT;
            this.dwHeight = BitmapInfo.vHeight;
            this.dwWidth = BitmapInfo.vWidth;
            if (BitmapInfo.Format == TextureFormat.A8R8G8B8)
            {
                this.dwFlags |= DDSD.PITCH;
                this.dwPitchOrLinearSize = this.dwWidth * 4;
            }
            else
            {
                this.dwFlags |= DDSD.LINEARSIZE;
                this.dwPitchOrLinearSize = BitmapInfo.RawLength;
            }
            this.dwDepth = 0;
            this.dwMipMapCount = 0;
            this.dwReserved1 = new int[11];
            this.dwSize2 = 0x20;
            this.dwFlags2 = 0;
            this.dwFourCC = FourCC.None;
            switch (BitmapInfo.Format)
            {
                case TextureFormat.A8R8G8B8:
                    this.dwFlags2 |= DDPF.RGB;
                    this.dwFlags2 |= DDPF.ALPHAPIXELS;
                    break;

                case TextureFormat.DXT1:
                    this.dwFlags2 |= DDPF.FOURCC;
                    this.dwFourCC = FourCC.DXT1;
                    break;

                case TextureFormat.DXT3:
                    this.dwFlags2 |= DDPF.FOURCC;
                    this.dwFourCC = FourCC.DXT3;
                    break;

                case TextureFormat.DXT5:
                    this.dwFlags2 |= DDPF.FOURCC;
                    this.dwFourCC = FourCC.DXT5;
                    break;
            }
            if (BitmapInfo.Format == TextureFormat.A8R8G8B8)
            {
                this.dwRGBBitCount = 0x20;
                this.dwRBitMask = 0xff0000;
                this.dwGBitMask = 0xff00;
                this.dwBBitMask = 0xff;
                this.dwRGBAlphaBitMask = 0xff000000;
            }
            else
            {
                this.dwRGBBitCount = 0;
                this.dwRBitMask = 0;
                this.dwGBitMask = 0;
                this.dwBBitMask = 0;
                this.dwRGBAlphaBitMask = 0;
            }
            this.dwCaps1 = 0;
            this.dwCaps1 |= DDSCAPS.TEXTURE;
            this.dwCaps2 = 0;
            this.Reserved2 = new int[2];
            this.dwReserved3 = 0;
        }

        public void Read(BinaryReader br)
        {
            int num;
            this.dwMagic = br.ReadInt32();
            this.dwSize = br.ReadInt32();
            this.dwFlags = (DDSD) br.ReadInt32();
            this.dwHeight = br.ReadInt32();
            this.dwWidth = br.ReadInt32();
            this.dwPitchOrLinearSize = br.ReadInt32();
            this.dwDepth = br.ReadInt32();
            this.dwMipMapCount = br.ReadInt32();
            this.dwReserved1 = new int[11];
            for (num = 0; num < this.dwReserved1.Length; num++)
            {
                this.dwReserved1[num] = br.ReadInt32();
            }
            this.dwSize2 = br.ReadInt32();
            this.dwFlags2 = (DDPF) br.ReadInt32();
            this.dwFourCC = (FourCC) br.ReadInt32();
            this.dwRGBBitCount = br.ReadInt32();
            this.dwRBitMask = br.ReadInt32();
            this.dwGBitMask = br.ReadInt32();
            this.dwBBitMask = br.ReadInt32();
            this.dwRGBAlphaBitMask = br.ReadUInt32();
            this.dwCaps1 = (DDSCAPS) br.ReadInt32();
            this.dwCaps2 = (DDSCAPS2) br.ReadInt32();
            this.Reserved2 = new int[2];
            for (num = 0; num < this.Reserved2.Length; num++)
            {
                this.Reserved2[num] = br.ReadInt32();
            }
            this.dwReserved3 = br.ReadInt32();
        }

        public void Write(BinaryWriter bw)
        {
            int num;
            bw.Write(this.dwMagic);
            bw.Write(this.dwSize);
            bw.Write((int) this.dwFlags);
            bw.Write(this.dwHeight);
            bw.Write(this.dwWidth);
            bw.Write(this.dwPitchOrLinearSize);
            bw.Write(this.dwDepth);
            bw.Write(this.dwMipMapCount);
            for (num = 0; num < this.dwReserved1.Length; num++)
            {
                bw.Write(this.dwReserved1[num]);
            }
            bw.Write(this.dwSize2);
            bw.Write((int) this.dwFlags2);
            bw.Write((int) this.dwFourCC);
            bw.Write(this.dwRGBBitCount);
            bw.Write(this.dwRBitMask);
            bw.Write(this.dwGBitMask);
            bw.Write(this.dwBBitMask);
            bw.Write(this.dwRGBAlphaBitMask);
            bw.Write((int) this.dwCaps1);
            bw.Write((int) this.dwCaps2);
            for (num = 0; num < this.Reserved2.Length; num++)
            {
                bw.Write(this.Reserved2[num]);
            }
            bw.Write(this.dwReserved3);
        }
        [Flags]
        public enum DDPF
        {
            ALPHAPIXELS = 1,
            FOURCC = 4,
            RGB = 0x40
        }

        [Flags]
        public enum DDSCAPS
        {
            COMPLEX = 8,
            MIPMAP = 0x400000,
            TEXTURE = 0x1000
        }

        [Flags]
        public enum DDSCAPS2
        {
            CUBEMAP = 0x200,
            CUBEMAP_NEGATIVEX = 0x800,
            CUBEMAP_NEGATIVEY = 0x2000,
            CUBEMAP_NEGATIVEZ = 0x8000,
            CUBEMAP_POSITIVEX = 0x400,
            CUBEMAP_POSITIVEY = 0x1000,
            CUBEMAP_POSITIVEZ = 0x4000,
            VOLUME = 0x200000
        }

        [Flags]
        public enum DDSD
        {
            CAPS = 1,
            DEPTH = 0x800000,
            HEIGHT = 2,
            LINEARSIZE = 0x80000,
            MIPMAPCOUNT = 0x20000,
            PITCH = 8,
            PIXELFORMAT = 0x1000,
            WIDTH = 4
        }

        public enum FourCC
        {
            DXT1 = 0x31545844,
            DXT3 = 0x33545844,
            DXT5 = 0x35545844,
            None = 0
        }
    }
}

