//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace XDevkit
{
    /// <summary>
    /// Xbox Emulation Class
    /// Made By TeddyHammer
    /// </summary>
    public partial class Xbox
    {

        /// <summary>
        /// Determines whether or not the specified address exists in xbox memory.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool IsValidAddress(uint address)
        {
            SendCommand("getmem addr=0x{0} length=1", Convert.ToString(address, 16));
            string mem = ReceiveSocketLine();
            ReceiveSocketLine();
            return mem != "??";
        }

        public void SendCommand(string command, params object[] args)
        {
            if (XboxName != null)
            {
                FlushSocketBuffer();

                try
                {
                    XboxName.Client.Send(Encoding.ASCII.GetBytes(string.Format(command, args) + Environment.NewLine));
                }
                catch (Exception /*ex*/)
                {
                    Disconnect();
                    throw new Exception("No Connection Detected");
                }

               // StatusResponse response = ReceiveStatusResponse();

                //if (response.Success) return response;
               // else throw new ApiException(response.Full);
            }
            else throw new Exception("No Connection Detected");
        }

        /// <summary>
        /// Poke the Memory
        /// </summary>
        /// <param name="memoryAddress">The memory address to Poke Example:0xCEADEADE - Uses *.FindOffset</param>
        /// <param name="value">The value to poke Example:000032FF (hex string)</param>
        public void Poke(string memoryAddress, string value) { Poke(Functions.Convert(memoryAddress), value); }

        /// <summary>
        /// Poke the Memory
        /// </summary>
        /// <param name="memoryAddress">The memory address to Poke Example:0xCEADEADE - Uses *.FindOffset</param>
        /// <param name="value">The value to poke Example:000032FF (hex string)</param>
        public void Poke(uint memoryAddress, string value)
        {
            if (!Functions.IsHex(value))
                throw new Exception("Not a valid Hex String!");
            if (!CheckConnection())
                return; //Call function - If not connected return
            try
            {
                SetMemory(memoryAddress, value);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Peek into the Memory
        /// </summary>
        /// <param name="startDumpAddress">The Hex offset to start dump Example:0xC0000000</param>
        /// <param name="dumpLength">The Length or size of dump Example:0xFFFFFF</param>
        /// <param name="memoryAddress">The memory address to peek Example:0xC5352525</param>
        /// <param name="peekSize">The byte size to peek Example: "0x4" or "4"</param>
        /// <returns>Return the hex string of the value</returns>
        public string Peek(string startDumpAddress, string dumpLength, string memoryAddress, string peekSize)
        {
            return Peek(Functions.Convert(startDumpAddress),Functions.Convert(dumpLength),Functions.Convert(memoryAddress),Functions.ConvertSigned(peekSize));
        }

        /// <summary>
        /// Peek into the Memory
        /// </summary>
        /// <param name="startDumpAddress">The Hex offset to start dump Example:0xC0000000</param>
        /// <param name="dumpLength">The Length or size of dump Example:0xFFFFFF</param>
        /// <param name="memoryAddress">The memory address to peek Example:0xC5352525</param>
        /// <param name="peekSize">The byte size to peek Example: "0x4" or "4"</param>
        /// <returns>Return the hex string of the value</returns>
        private string Peek(uint startDumpAddress, uint dumpLength, uint memoryAddress, int peekSize)
        {
            uint total = (memoryAddress - startDumpAddress);
            if (memoryAddress > (startDumpAddress + dumpLength) || memoryAddress < startDumpAddress)
                throw new Exception("Memory Address Out of Bounds");

            if (!CheckConnection())
                return null; //Call function - If not connected return

            var readWriter = new RwStream();
            try
            {
                var data = new byte[1026]; //byte chuncks

                //Writing each byte chuncks========
                for (int i = 0; i < dumpLength / 1024; i++)
                {
                    XboxName.Client.Receive(data);
                    readWriter.WriteBytes(data, 2, 1024);
                }
                //Write whatever is left
                var extra = (int)(dumpLength % 1024);
                if (extra > 0)
                {
                    XboxName.Client.Receive(data);
                    readWriter.WriteBytes(data, 2, extra);
                }
                readWriter.Flush();
                readWriter.Position = total;
                byte[] value = readWriter.ReadBytes(peekSize);
                return Functions.ToHexString(value);
            }
            catch (SocketException se)
            {
                readWriter.Flush();
                readWriter.Position = total;
                byte[] value = readWriter.ReadBytes(peekSize);
                return Functions.ToHexString(value);
                throw new Exception(se.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Find pointer offset
        /// </summary>
        /// <param name="pointer"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public BindingList<SearchResults> FindHexOffset(string pointer)
        {
            _stopSearch = false;
            if (pointer == null)
                throw new Exception("Empty Search string!");
            if (!Functions.IsHex(pointer))
                throw new Exception(string.Format("{0} is not a valid Hex string.", pointer));
            if (!CheckConnection())
                return null; //Call function - If not connected return
            BindingList<SearchResults> values;
            try
            {
                //LENGTH or Size = Length of the dump
                uint size = DumpLength;
                _readWriter = new RwStream();
                var data = new byte[1026]; //byte chuncks

                //Writing each byte chuncks========
                //No need to mess with it :D
                for (int i = 0; i < size / 1024; i++)
                {
                    if (_stopSearch)
                        return new BindingList<SearchResults>();
                    XboxName.Client.Receive(data);
                    _readWriter.WriteBytes(data, 2, 1024);
                }
                //Write whatever is left
                var extra = (int)(size % 1024);
                if (extra > 0)
                {
                    if (_stopSearch)
                        return new BindingList<SearchResults>();
                    XboxName.Client.Receive(data);
                    _readWriter.WriteBytes(data, 2, extra);
                }
                _readWriter.Flush();
                //===================================
                //===================================
                if (_stopSearch)
                    return new BindingList<SearchResults>();
                _readWriter.Position = 0;
                values = _readWriter.SearchHexString(Functions.StringToByteArray(pointer), _startDumpOffset);
                return values;
            }
            catch (SocketException)
            {
                _readWriter.Flush();
                //===================================
                //===================================
                if (_stopSearch)
                    return new BindingList<SearchResults>();
                _readWriter.Position = 0;
                values = _readWriter.SearchHexString(Functions.StringToByteArray(pointer), _startDumpOffset);

                return values;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void constantMemorySet(uint Address, uint Value)
        { constantMemorySetting(Address, Value, false, 0, false, 0); }

        public void constantMemorySet(uint Address, uint Value, uint TitleID)
        { constantMemorySetting(Address, Value, false, 0, true, TitleID); }

        public void constantMemorySet(uint Address, uint Value, uint IfValue, uint TitleID)
        { constantMemorySetting(Address, Value, true, IfValue, true, TitleID); }

        public void constantMemorySetting(uint Address, uint Value, bool useIfValue, uint IfValue, bool usetitleID, uint TitleID)
        {
            object[] Version = new object[]
            {
                "consolefeatures ver=",
                2,
                " type=18 params=\"A\\",
                Address.ToString("X"),
                "\\A\\5\\",
                1,
                "\\",
                Functions.UIntToInt(Value),
                "\\",
                1,
                "\\",
                (useIfValue ? 1 : 0),
                "\\",
                1,
                "\\",
                IfValue,
                "\\",
                1,
                "\\",
                (usetitleID ? 1 : 0),
                "\\",
                1,
                "\\",
                Functions.UIntToInt(TitleID),
                "\\\""
            };
            SendTextCommand(string.Concat(Version));
        }

        public void SetMemory(uint address, string data)
        {
            FlushSocketBuffer();
            int sent = 0;
            try
            {
                // Send the setmem command
                XboxName.Client
                    .Send(Encoding.ASCII
                        .GetBytes(string.Format("SETMEM ADDR=0x{0} DATA={1}\r\n", address.ToString("X2"), data)));
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.WouldBlock ||
                    ex.SocketErrorCode == SocketError.IOPending ||
                    ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
                {
                    // socket buffer is probably full, wait and try again
                    Thread.Sleep(30);
                }
                else
                    throw new Exception(ex.Message + " - " + sent); // any serious error occurr
            }
        }

        public void SetMemory(uint Address, byte[] Data) { SetMemory(Address, 0, Data, out _); }

        public void SetMemory(uint Address, uint BytesToWrite, byte[] Data, out uint BytesWritten)//aka response
        {
            FlushSocketBuffer();
            // Send the setmem command
            XboxName.Client
                .Send(Encoding.ASCII
                    .GetBytes(string.Format("SETMEM ADDR=0x{0} DATA={1}\r\n",
                                            Address.ToString("X2"),
                                            BitConverter.ToString(Data).Replace("-", string.Empty))));

            // Check to see our response
            byte[] Packet = new byte[1026];
            XboxName.Client.Receive(Packet);
            BytesWritten = 0;
            //BytesWritten = Convert.ToUInt32(Encoding.ASCII.GetString(Packet));
            if (Encoding.ASCII.GetString(Packet).Replace("\0", string.Empty).Substring(0, 11) == "0 bytes set")
                throw new Exception("A problem occurred while writing bytes. 0 bytes set");
        }


        public byte[] GetMemory(uint Address, uint Length)
        {
            FlushSocketBuffer();
            byte[] numArray = new byte[Length];
            GetMemory(Address, Length, numArray, out _);
            InvalidateMemoryCache(true, Address, Length);
            return numArray;

        }
        public void GetMemory(uint Address, uint BytesToRead, byte[] Data, out uint BytesRead)
        {
            FlushSocketBuffer();
            BytesRead = 0;
            List<byte> ReturnData = new List<byte>();
            byte[] Packet = new byte[1026];
            Data = new byte[1024];

            // Send getmemex command.

            XboxName.Client
                .Send(Encoding.ASCII
                    .GetBytes(string.Format("GETMEMEX ADDR=0x{0} LENGTH=0x{1}\r\n",
                                            Address.ToString("X2"),
                                            BytesToRead.ToString("X2"))));

            // Receieve the 203 response to verify we are going to recieve raw data in packets
            XboxName.Client.Receive(Packet);

            if (Encoding.ASCII.GetString(Packet).Replace("\0", string.Empty).Substring(0, 3) != "203")
                throw new Exception("GETMEMEX 203 response not recieved. Cannot read memory.");

            // It will return with data in 1026 byte size packets, first two bytes I think are flags and the rest is the data
            // Length / 1024 will get how many packets there are to recieve
            for (uint i = 0; i < BytesToRead / 1024; i++)
            {
                XboxName.Client.Receive(Packet);

                // Store the data minus the first two bytes
                // This was a cheap way of removing the 2 byte header
                Array.Copy(Packet, 2, Data, 0, 1024);
                ReturnData.AddRange(Data);
            }
        }

        /// <summary>
        /// Dump the memory
        /// </summary>
        /// <param name="filename">The file to save to</param>
        /// <param name="startDumpAddress">The start dump address</param>
        /// <param name="dumpLength">The dump length</param>
        public void Dump(string filename, string startDumpAddress, string dumpLength)
        { Dump(filename, Functions.Convert(startDumpAddress), Functions.Convert(dumpLength)); }

        /// <summary>
        /// Dump the memory
        /// </summary>
        /// <param name="filename">The file to save to</param>
        /// <param name="startDumpAddress">The start dump address</param>
        /// <param name="dumpLength">The dump length</param>
        public void Dump(string filename, uint startDumpAddress, uint dumpLength)
        {
            FlushSocketBuffer();
            if (!CheckConnection())
                return; //Call function - If not connected return

            var readWriter = new RwStream(filename);
            try
            {
                var data = new byte[1026]; //byte chuncks
                //Writing each byte chuncks========
                for (int i = 0; i < dumpLength / 1024; i++)
                {
                    XboxName.Client.Receive(data);
                    readWriter.WriteBytes(data, 2, 1024);
                }
                //Write whatever is left
                var extra = (int)(dumpLength % 1024);
                if (extra > 0)
                {
                    XboxName.Client.Receive(data);
                    readWriter.WriteBytes(data, 2, extra);
                }
                readWriter.Flush();
            }
            catch (SocketException)
            {
                readWriter.Flush();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ModuleName"></param>
        /// <param name="Ordinal"></param>
        /// <returns></returns>
        public uint ResolveFunction(string ModuleName, uint Ordinal)
        {
            FlushSocketBuffer();
            object[] XBDMVersion = new object[] { "consolefeatures ver= 2", " type=9 params=\"A\\0\\A\\2\\0",  "/",  ModuleName.Length,  "\\", ModuleName.ToHexString(), "\\0", "\\", Ordinal,  "\\\""
            };
            string str = SendTextCommand(string.Concat(XBDMVersion));
            return uint.Parse(str.Substring(str.find(" ") + 1), NumberStyles.HexNumber);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="groupSize"></param>
        private void ReverseBytes(byte[] buffer, int groupSize)
        {
            if (buffer.Length % groupSize != 0)
            {
                throw new ArgumentException("Group size must be a multiple of the buffer length", "groupSize");
            }
            for (int i = 0; i < buffer.Length; i += groupSize)
            {
                int num = i;
                for (int j = i + groupSize - 1; num < j; j--)
                {
                    byte num1 = buffer[num];
                    buffer[num] = buffer[j];
                    buffer[j] = num1;
                    num++;
                }
            }
        }
    }
}