#region

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

#endregion

namespace XDevkit
{
    /// <summary>Contains function/s that deals with I/O reading and writing of Data</summary>
    public class RwStream
    {


        private bool _accessed;
        private BinaryReader _bReader;
        private BinaryWriter _bWriter;
        private Stream _fStream;
        private string _fileName;
        private bool _stopSearch;

        #region RwStream Constructors

        /// <summary>Makes a temporary file Stream</summary>
        public RwStream()
        {
            try
            {
                _fileName = Path.GetTempPath() + Guid.NewGuid() + ".ISOLib";
                _fStream = new FileStream(_fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                _bReader = new BinaryReader(_fStream);
                _bWriter = new BinaryWriter(_fStream);
                _accessed = true;
                _stopSearch = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// RW Stream Constructor
        /// </summary>
        /// <param name="filename">The file name</param>
        public RwStream(string filename)
        {
            try
            {
                _fileName = filename;
                _fStream = new FileStream(_fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                _bReader = new BinaryReader(_fStream);
                _bWriter = new BinaryWriter(_fStream);
                _accessed = true;
                _stopSearch = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion

        #region Methods

        /// <summary>Clears buffer by Flushing and Closes theI/O Stream</summary>
        /// <param name="delete">Delete file </param>
        public void Close(bool delete)
        {
            try
            {
                if (_accessed)
                {
                    Flush();
                    _bWriter.Close();
                    _bWriter = null;
                    _bReader.Close();
                    _bReader = null;
                    _fStream.Close();
                    _fStream = null;
                    _accessed = false;
                    if (_fileName != null)
                    {
                        if (delete) File.Delete(_fileName);
                        _fileName = null;
                    }
                    Dispose();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>Release all resources used by reader and writer stream</summary>
        private void Dispose()
        {
            try
            {
                if (_accessed)
                {
                    if (_bReader != null)
                    {
                        _bReader.BaseStream.Dispose();
                    }
                    if (_bWriter != null)
                    {
                        _bWriter.BaseStream.Dispose();
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>Clears buffer for this stream and any unbuffered data will be written</summary>
        public void Flush()
        {
            try
            {
                _bReader.BaseStream.Flush();
                _bWriter.BaseStream.Flush();
                _fStream.Flush();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        #endregion

        #region Reader

        /// <summary>Reads a set size of bytes</summary>
        /// <param name="length">The byte array length</param>
        /// <returns>Byte Array</returns>
        public byte[] ReadBytes(int length)
        {
            try
            {
                if (Position == Length)
                {
                    throw new Exception("Cannot move position past file size");
                }
                if (length == 0)
                    return new byte[0];
                var buffer = new byte[length];
                _fStream.Read(buffer, 0, length);

                return buffer;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private static bool ByteArrayCompare(byte[] b1, byte[] b2)
        {
            // Validate buffers are the same length.
            // This also ensures that the count does not exceed the length of either buffer.
            return b1.Length == b2.Length && memcmp(b1, b2, b1.Length) == 0;
        }

        private static int IndexOfInt(byte[] arr, byte value, int start)
        {
            for (int i = start; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Search Hex String
        /// </summary>
        /// <param name="pattern">The pattern you are searching for</param>
        /// <param name="startDumpOffset">The Offset you want to start dump from</param>
        /// <returns></returns>
        public BindingList<SearchResults> SearchHexString(byte[] pattern, uint startDumpOffset)
        {
            var buffer = new byte[_fStream.Length];
            _fStream.Read(buffer, 0, (int)_fStream.Length);
            int i = IndexOfInt(buffer, pattern[0], 0);
            var positions = new BindingList<SearchResults>();

            int x = 1;
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                if (_stopSearch) return positions;

                var segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);

                if (ByteArrayCompare(segment, pattern))
                {
                    var results = new SearchResults
                    {
                        Offset = String.Format("{0:X}", startDumpOffset + (uint)i)
                    };

                    var hex = new StringBuilder(segment.Length * 2);
                    foreach (byte b in segment)
                        hex.AppendFormat("{0:x2}", b);

                    results.Value = hex.ToString().ToUpper();
                    results.ID = x.ToString();
                    positions.Add(results);

                    //if (positions.Count == 1000) return positions;
                    if (_stopSearch) return positions;
                    i = IndexOfInt(buffer, pattern[0], i + pattern.Length);
                    x++;
                }
                else
                {
                    if (_stopSearch) return positions;
                    i = IndexOfInt(buffer, pattern[0], i + 1);
                }
                if (_stopSearch) return positions;
            }
            return positions;
        }

        #endregion

        #region Writer

        /// <summary>Writes a region of a byte array to the current stream</summary>
        /// <param name="buffer">A byte array containing the data to write</param>
        /// <param name="index">The starting point to start writing</param>
        /// <param name="count">The amount of bytes to write</param>
        public void WriteBytes(byte[] buffer, int index, int count)
        {
            try
            {
                _bWriter.Write(buffer, index, count);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        #endregion

        #region Properties

        /// <summary>Get/Set if current initialization length</summary>
        private long Length
        {
            get { return _fStream.Length; }
        }

        /// <summary>Get/Set if current initialization position</summary>
        public long Position
        {
            private get { return _fStream.Position; }
            set
            {
                try
                {
                    if ((value != _fStream.Position) || (value <= _fStream.Length))
                    {
                        _fStream.Position = value;
                    }
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        /// <summary>
        /// If the object is accessed
        /// </summary>
        public bool Accessed
        {
            get { return _accessed; }
        }

        /// <summary>
        /// Stop the search
        /// </summary>
        public bool StopSearch
        {
            get { return _stopSearch; }
            set { _stopSearch = value; }
        }

        #endregion

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int memcmp(byte[] b1, byte[] b2, long count);
    }
}