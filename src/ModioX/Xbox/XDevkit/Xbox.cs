//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...

using System;
using System.IO;
using System.Threading;

namespace XDevkit
{
    //Main Xbox Class
    /// <summary>
    /// Xbox Emulation Class
    /// Made By TeddyHammer
    /// </summary>
    public partial class Xbox
    {
        byte[] BitmapBuffer = new byte[56 + 640 * 480 * 4];
        byte[] FrameBuffer = new byte[64 + 640 * 480 * 4];
        FileSystem fileSystem { get; set; }
        string Name { get; set; }
        uint IPAddressTitle { get; }
        object SystemTime { get; set; }
        bool Shared { get; set; }
        XBOX_PROCESS_INFO RunningProcessInfo { get; }
        string Drives { get; }
        XboxDumpMode DumpMode { get; set; }
        XboxEventDeferFlags EventDeferFlags { get; set; }
        XboxAutomation XboxAutomation { get; set;}
        XboxConsoleFeatures ConsoleFeatures { get;  set; }
        /// <summary>
        /// Xbox memory stream.
        /// </summary>
        //[DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public XboxMemoryStream MemoryStream;

        public Xbox()
        {
            if (XboxName == null)
            {

            }
            else
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            XboxAutomation = new XboxAutomation();
            fileSystem = new FileSystem();
            Name = SendTextCommand("dbgname");
            DumpMode = XboxDumpMode.Smart;
            ConsoleFeatures = XboxConsoleFeatures.Debugging;


        }
        ~Xbox() { Dispose(); }

        public void Dispose()
        {
            Disconnect();
        }
        /// <summary>
        /// Pauses the game and returns an address to the current framebuffer once it's locked.
        /// </summary>
        /// <returns></returns>
        public uint LockGPU()
        {
            SendCommand("stop");
            DateTime before = DateTime.Now;

            ulong ptrs = GetUInt64(0xB0033DA0);
            uint ptr1 = (uint)(ptrs >> 32);
            uint ptr2 = (uint)(ptrs & 0xFFFFFFFF);

            // waits until present queue is empty (flipcounter == framecounter)
            while (GetUInt32(ptr1) != GetUInt32(ptr2))
            {
                TimeSpan elapse = DateTime.Now - before;
                if (elapse.TotalMilliseconds > Timeout)
                    throw new TimeoutException();
                Thread.Sleep(0);
            }
            return GetUInt32(0xFD600800) | 0x80000000;
        }
        /// <summary>
        /// Takes a screenshot of the xbox display.
        /// </summary>
        public System.Drawing.Image Screenshot()
        {
            int read = 0;
            MemoryStream.Read(LockGPU(), FrameBuffer.Length, FrameBuffer, 0, ref read);
            SendCommand("continue");
            int[] block = {
                              0,  1,  2,  3,  4,  5,  6,  7,  8,  9,  10, 11, 12, 13, 14, 15,
                              18, 19, 16, 17, 22, 23, 20, 21, 26, 27, 24, 25, 30, 31, 28, 29,
                              33, 34, 35, 32, 37, 38, 39, 36, 41, 42, 43, 40, 45, 46, 47, 44,
                              51, 48, 49, 50, 55, 52, 53, 54, 59, 56, 57, 58, 63, 60, 61, 62
                          };
            int swiz = 0, index = 0, offset = 0;
            int deswiz = 1226240;
            int i, j, k, l;
            for (i = 0; i < 30; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if ((i & 1) == 1)
                        if ((j & 1) == 1) deswiz -= 256;
                        else deswiz += 256;

                    for (l = 0; l < 4; l++)
                    {
                        for (k = 0; k < 16; k++)
                        {
                            offset = (((int)(block[index] & 0xFFFFFFFE) >> 2) * 256) + ((block[index] & 3) * 16);
                            index = (index + 1) & 63;
                            for (int v = 0; v < 15; v++)
                                if ((v & 3) != 3)
                                {
                                    BitmapBuffer[deswiz + v] = FrameBuffer[swiz + offset + v];
                                    BitmapBuffer[deswiz - 2560 + v] = FrameBuffer[swiz + offset + 64 + v];
                                    BitmapBuffer[deswiz - 5120 + v] = FrameBuffer[swiz + offset + 128 + v];
                                    BitmapBuffer[deswiz - 7680 + v] = FrameBuffer[swiz + offset + 192 + v];
                                }
                            deswiz += 16;
                        }
                        deswiz -= 10496;
                    }
                    deswiz += 41216;
                    swiz += 4096;

                    if ((i & 1) == 1)
                        if ((j & 1) == 1) deswiz += 256;
                        else deswiz -= 256;
                }
                deswiz -= 43520;
            }

            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                // BITMAPFILEHEADER
                bw.Write(new char[] { 'B', 'M' }); // ushort bfType - BM (19778)
                bw.Write((uint)824); // uint bfSize - Size of the file (bytes) - Header + ImageData + (ushort)0
                bw.Write((ushort)0); // ushort bfReserved1 - Zero
                bw.Write((ushort)0); // ushort bfReserved2 - Zero
                bw.Write((uint)54); // uint bfOffBits - Offset to image data
                                    // BITMAPINFOHEADER
                bw.Write((uint)40); // uint biSize - Size of BITMAPINFOHEADER (bytes)
                bw.Write((uint)640); // uint biWidth - Width of image (pixels)
                bw.Write((uint)480); // uint biHeight - Height of image (pixels)
                bw.Write((ushort)1); // ushort biPlanes - Number of planes of the target device (usually one)
                bw.Write((ushort)24); // ushort biBitCount - Bits per pixel (1=black/white, 4=16 colors, 8=256 colors, 24=16.7 million colors)
                bw.Write((uint)0); // uint biCompression - Type of compression (0=None)
                bw.Write((uint)770); // uint biSizeImage - Size of image data (bytes) - Zero if no compression
                bw.Write((uint)2834); // uint biXPelsPerMeter - Hoizontal pixels per meter (usually zero) (2834=72 Pixels Per Inch)
                bw.Write((uint)2834); // uint biYPelsPerMeter - Vertical pixels per meter (usually zero) (2834=72 Pixels Per Inch)
                bw.Write((uint)0); // uint biClrUsed - Number of colors used - If zero, calculated by biBitCount
                bw.Write((uint)0); // uint biClrImportant - Number of "important" colors (0=All)

                for (int off = 0; off < 1228800; off += 2560)
                {
                    for (int i2 = 0; i2 < 2560; i2 += 4)
                    {
                        bw.Write(BitmapBuffer[off + i2]);
                        bw.Write(BitmapBuffer[off + i2 + 1]);
                        bw.Write(BitmapBuffer[off + i2 + 2]);
                    }
                }
                bw.Write((ushort)0);
                bw.Flush();

                return System.Drawing.Image.FromStream(ms);
            }
        }
        public static uint xOut;

        public static string ByteArrayToString(byte[] ba) =>
            BitConverter.ToString(ba).Replace("-", "");

        public  byte[] GetMem(uint address, uint numBytes)
        {
            byte[] data = new byte[numBytes];
            GetMemory(address, numBytes, data, out xOut);
            InvalidateMemoryCache(true, address, numBytes);
            return data;
        }

        public  uint GetPointer(uint address) =>
            Convert.ToUInt32(ByteArrayToString(GetMem(address, 4)), 0x10);

        public void SetByte(uint address, uint b)
        {
            byte[] data = new byte[] { Convert.ToByte(b) };
            SetMem(address, data);
        }

        public  void SetMem(uint address, byte[] data)
        {
            SetMemory(address, (uint)data.Length, data, out xOut);
        }

    }


}