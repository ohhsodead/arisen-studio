//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XDevkit
{
    /// <summary>
    /// Xbox Emulation Class
    /// Made By TeddyHammer
    /// </summary>
    public partial class Xbox  //Networking Class
    {
        public string Name { get; set; } = Connected ? SendTextCommand("dbgname") : "Error";
        private const int listenPort = 730;
        public static string Response;
        public static bool Connected { get; set; }
        public static TcpClient XboxName { get; set; }
        [Browsable(false)]
        public static StreamReader Reader;
        public static int ConnectTimeout { get => XboxName.SendTimeout; set => XboxName.SendTimeout = value;
        }
        public static int ConversationTimeout { get => XboxName.ReceiveTimeout; set => XboxName.ReceiveTimeout = value;
        }
       // public string IPAddress { get; set; }
        public  IPAddress IPAddress { get; set; }
        public string DefaultConsole { get; set; }


        public void Disconnect()
        {
            if (Connected)
            {
                this.SendTextCommand("bye");
                XboxName.Close();
                Connected = false;
            }
        }

        /// <summary>
        /// Connects Local Tcp Connection From Device To Xbox Console
        /// 
        /// </summary>
        public bool Connect(string XboxNameOrIP = "")//NOTE: Edit if specified String is read then it will return true
        {
            //User Enter's Nothing
            if (XboxNameOrIP == "")
            {
                return Connect("", 730);
            }
            // If User Supply's IP To US.
            else
            {
                return Connect(XboxNameOrIP, 730);
            }
        }

        /// <summary>
        /// Auto Connects By Finding The IP Address
        /// </summary>
        /// <param name="ConsoleNameOrIP"></param>
        /// <param name="Port"></param>
        public bool Connect()//NOTE: Edit if specified String is read then it will return true
        {
            return Connect(string.Empty, 730);
        }




        /// <summary>
        /// Connects by using user's ConsoleNameOrIP and port number
        /// </summary>
        /// <param name="ConsoleNameOrIP"></param>
        /// <param name="Port"></param>
        public bool Connect(string ConsoleNameOrIP = "default", int Port = 730)
        {
            //User Enter's Nothing
            if (ConsoleNameOrIP == "")
            {
                XboxName = new TcpClient();
                if (FindConsole())//if true then continue
                {
                    XboxName = new TcpClient(IPAddress.ToString(), listenPort);//test...
                    Reader = new StreamReader(XboxName.GetStream());
                    Console.WriteLine("/Connection - F01/....(" + IPAddress + ")");//debugging purposes..
                    return Connected = true;
                }
                else// if top fails
                {
                    return Connected = false;
                }
            }
            // If User Supply's IP To US.
            else if (ConsoleNameOrIP.ToCharArray().Any(char.IsDigit))
            {
                string IPAddress = ConsoleNameOrIP;
                XboxName = new TcpClient(ConsoleNameOrIP, Port);
                Reader = new StreamReader(XboxName.GetStream());
                Console.WriteLine("/Connection - Degits/....(" + "Manual Connection Mode" + ")");
                return Connected = true;
            }
            //Get IP Via Name
            else if (ConsoleNameOrIP.ToCharArray().Any(char.IsLetter))//uses ip to find console makes user think it finds it via name 
            {
                Connected = FindConsole();
                XboxName = new TcpClient(IPAddress.ToString(), listenPort);//test...
                Reader = new StreamReader(XboxName.GetStream());
                Console.WriteLine("/Connection - F01/....(" + IPAddress + ")");//debugging purposes..
                return Connected;
            }
            else
            {
                return Connected;
            }
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        public string SendTextCommand(string Command, string emty)
        {
            try
            {
                SendTextCommand(Command, out Response);
            }
            catch
            {
            }
            return Response;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        public static string SendTextCommand(string Command)
        {
            try
            {
                SendTextCommand(Command, out Response);
               // SendTextCommand(Command, object[]{ })
            }
            catch
            {
            }
            return Response;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Command"></param>
        /// <param name="response"></param>
        public static void SendTextCommand(string Command, out string response)
        {
            response = string.Empty;
            try
            {
                // Max packet size is 1026
                byte[] Packet = new byte[1026];
                if (XboxName.Connected == true)
                {
                    Console.WriteLine("SendTextCommand " + Command + " ==> Sending Command... <==");
                    XboxName.Client.Send(Encoding.ASCII.GetBytes(Command + Environment.NewLine));
                    XboxName.Client.Receive(Packet);
                    response = Encoding.ASCII.GetString(Packet);

                }
                else
                {
                    Console.WriteLine("SendTextCommand ==> " + Assembly.GetEntryAssembly().GetName().Name + " Connection = " + Connected);
                }

            }
            catch
            {

            }
        }

        public void SendTextCommand(string command, params object[] args)
        {
            if (XboxName != null)
            {

                try
                {
                    XboxName.Client.Send(Encoding.ASCII.GetBytes(string.Format(command, args) + Environment.NewLine));
                }
                catch (Exception /*ex*/)
                {

                }
            }
            else throw new Exception("No Connection Detected");
        }
        #region test Area

        /// <summary>
        /// Working On a Way Detect IPS 
        /// </summary>
        private  void StartListener()
        {

            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress, listenPort);

            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast");
                    byte[] bytes = listener.Receive(ref groupEP);

                    Console.WriteLine($"Received broadcast from {groupEP} :");
                    Console.WriteLine($" {Encoding.ASCII.GetString(bytes, 0, bytes.Length)}");
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }
        private DoWorkEventHandler BackgroundSlave()
        {
            string ips = "192.168.0.";
            while (true)
            {
                int i = 0;

                for (; ; )
                {
                    if (i < 255)
                    {
                        XboxName = new TcpClient();
                        if (XboxName.ConnectAsync(ips + i, 730).Wait(10))//keep calm just code..
                        {
                            IPAddress = IPAddress.Parse(ips + i);
                            Connected = true;
                            return null;
                        }
                        else
                        {
                            i++;
                        }

                    }
                    else
                    {
                        Connected = false;
                        return null;
                    }
                }
            }
        }
        readonly BackgroundWorker FindConsoleBc = new BackgroundWorker();
        readonly BackgroundWorker FindConsolegc = new BackgroundWorker();
        private bool FindConsole()
        {
            if (FindConsoleBc.IsBusy == true)
            {
                FindConsolegc.RunWorkerAsync(); 
            }
            else
            {
                FindConsoleBc.RunWorkerAsync();
            }
            int n = 0;
            switch (n)
            {
                case 0:
                    BackgroundSlave();
                    goto case 1;
                case 1:
                    if (Connected == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (n < 3)
                        {
                            Console.WriteLine("Connection Fail Safe Activated....");
                            n++;
                            BackgroundSlave();
                        }
                        if (n < 6)
                        {
                            Console.WriteLine("Connection Must Not Be Available, Please Make Sure Your On the Same Network As Your Console Otherwise Please Try Again Later.....");
                            Console.WriteLine("Connection Fail Safe Terminated, Reason: FindConsole Has Failed User Not Connected To Network....");

                            return false;
                        }
                        n++;
                        goto case 1;
                    }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        private bool FindConsole(int retryAttepts)
        {
            return DoWithRetry(FindConsole(), TimeSpan.FromSeconds(5), 3);
        }

        public bool DoWithRetry(bool action, TimeSpan sleepPeriod, int tryCount = 3)
        {
            if (tryCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(tryCount));

            while (action == false)
            {
                try
                {
                    if (action)
                    {
                        return true;
                    }
                    break; // success!
                    //else retrun false fixes issue

                }
                catch
                {
                    if (--tryCount == 0)
                        throw;
                    Thread.Sleep(sleepPeriod);

                }

            }
            return false;
        }
        #endregion


    }
}