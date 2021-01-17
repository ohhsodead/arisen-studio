//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace XDevkit
{
    /// <summary>
    /// Creates a standard xbox memory stream.
    /// </summary>
    public class XboxMemoryStream : Stream
    {
        #region Fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Xbox Xbox;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        int bufferSize = 0x20000; // 128kb
        public int BufferSize { get { return bufferSize; } set { bufferSize = value; } }

        /// <summary>
        /// Use this as a precautionary method against crashes due to invalid memory addresses.
        /// </summary>
        public bool SafeMode { get { return safeMode; } set { safeMode = value; } }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool safeMode;

        protected uint position;
        public override long Position
        {
            get { return position; }
            set { position = (uint)value; }
        }
        public override bool CanRead { get { return Xbox.Connected; } }
        public override bool CanSeek { get { return Xbox.Connected; } }
        public override bool CanWrite { get { return Xbox.Connected; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new memory stream using a client connection to a debug xbox.
        /// </summary>
        /// <param name="client">Connection to use.</param>
        public XboxMemoryStream(Xbox client)
        {
            Xbox = client;
            if (client == null || !client.Connected)
                throw new Exception("Not Connected!");
            position = 0x10000; // start at a valid memory address
        }
        #endregion

        #region Methods
        public override void Flush() { throw new Exception("Not Supported"); }
        public override long Seek(long offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin: return position = (uint)offset; // zero-based offset
                case SeekOrigin.Current: return position += (uint)offset;
                default: throw new Exception("Invalid SeekOrigin.");
            }
        }
        public long SeekTo(long offset) { return position = (uint)offset; }
        public override long Length { get { throw new Exception("Not Supported"); } }
        public override void SetLength(long value) { throw new Exception("Not Supported"); }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int read = 0;
            Read(position, count, buffer, offset, ref read);
            position += (uint)read;
            return read;
        }

        public void Read(uint address, int length, byte[] buffer, int offset, ref int read)
        {
            // only check base address - would add too much overhead to check range
            // plus, it's much more likely that the entire range will be valid if the base address is
            if (safeMode & !Xbox.IsValidAddress(address))
                throw new Exception("Safe Mode detected invalid base address");

            int iterations = (int)length / bufferSize;
            int remainder = (int)length % bufferSize;
            read = 0;


            for (int i = 0; i < iterations; i++)
            {
                Xbox.SendCommand("getmem2 addr=0x{0} length={1}", Convert.ToString(address + read, 16).PadLeft(8, '0'), bufferSize);
                Xbox.Wait(bufferSize);
                Xbox.XboxName.Client.Receive(buffer, (int)(offset + read), bufferSize, SocketFlags.None);
                read += bufferSize;
            }

            if (remainder > 0)
            {
                Xbox.SendCommand("getmem2 addr=0x{0} length={1}", Convert.ToString(address + read, 16).PadLeft(8, '0'), remainder);
                Xbox.Wait(remainder);
                Xbox.XboxName.Client.Receive(buffer, (int)(offset + read), remainder, SocketFlags.None);
                read += remainder;
            }
        }

        /// <summary>
        /// Writes to xbox memory. Performance of ~10MB/s due to a simple xbdm.dll modification.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="length"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        public void Write(uint address, int length, byte[] buffer, int offset)
        {
            // only check base address - would add too much overhead to check range
            // plus, it's much more likely that the entire range will be valid anyways
            if (safeMode & !Xbox.IsValidAddress(address))
                throw new Exception("Safe Mode detected invalid base address");

            int iterations = length / bufferSize;
            int remainder = length % bufferSize;
            int index = 0;


            for (int i = 0; i < iterations; i++)
            {
                // hack: hijacked writefile routine in xbdm v7887 so that we can send binary data to memory instead of length-limited ascii
                Xbox.SendTextCommand("writefile name=| offset=0x" + Convert.ToString(address, 16) + " length=" + bufferSize);
                //reponse here
                    Xbox.XboxName.Client.Send(buffer, offset, bufferSize, SocketFlags.None);
                    // check for failure
                    index += bufferSize;
            }

            if (remainder > 0)
            {
                Xbox.SendTextCommand("writefile name=| offset=0x" + Convert.ToString(address, 16) + " length=" + remainder);
                //response here
                    Xbox.XboxName.Client.Send(buffer, offset, remainder, SocketFlags.None);
                    // check for failure - parse message and determine bytes written, then return 
                    index += bufferSize;
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Write(position, count, buffer, offset);
            position += (uint)count;
        }
        #endregion
    };
}