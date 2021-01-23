using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XDevkit;

namespace XDevkit
{
    public static class XboxClient
    {
        #region Property's
        public static TcpClient XboxName { get; set; } = new TcpClient();
        public static bool Connected { get; set; }
        private static Xbox xboxConsole { get; set; } = new Xbox();
        [Browsable(false)]
        public static StreamReader Reader; 
        #endregion

        /// <summary>
        /// Connect Set's User's Object To XboxClass, Default Attempts To Find Console
        /// </summary>
        /// <param name="console"></param>
        /// <param name="Console"></param>
        /// <param name="XboxNameOrIP"></param>
        /// <returns></returns>
        public static bool Connect(this Xbox console, out Xbox Console, string XboxNameOrIP = "default")
        {
            Console = xboxConsole;//sets Class For Client
            if (XboxNameOrIP == "default")
            {
                return TCPConnect(xboxConsole.DefaultConsole);
            }
            else
            {
                try
                {
                    return TCPConnect(XboxNameOrIP);
                }
                catch
                {
                    return false;
                }
            }
        }

        #region Networking
        /// <summary>
        /// Connects by using user's ConsoleNameOrIP and port number
        /// </summary>
        /// <param name="ConsoleNameOrIP"></param>
        /// <param name="Port"></param>
        static bool TCPConnect(string ConsoleNameOrIP = "default", int Port = 730)
        {
            //User Enter's Nothing
            if (ConsoleNameOrIP == "")
            {
                XboxName = new TcpClient();
                if (FindConsole())//if true then continue
                {
                    XboxName = new TcpClient(xboxConsole.IPAddress, 730);//test...
                    Reader = new StreamReader(XboxName.GetStream());
                    Console.WriteLine("/Connection - F01/....(" + xboxConsole.IPAddress + ")");//debugging purposes..
                    // set class properties once connected 
                    xboxConsole.IPAddress = ConsoleNameOrIP;
                    XboxClient.XboxName = XboxName;
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
                XboxName = new TcpClient(xboxConsole.IPAddress, 730);//test...
                Reader = new StreamReader(XboxName.GetStream());
                Console.WriteLine("/Connection - F01/....(" + xboxConsole.IPAddress + ")");//debugging purposes..
                return Connected;
            }
            else
            {
                return Connected;
            }
        }
        static DoWorkEventHandler BackgroundSlave()
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
                            xboxConsole.IPAddress = ips + i;
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
        static readonly BackgroundWorker FindConsoleBc = new BackgroundWorker();
        static readonly BackgroundWorker FindConsolegc = new BackgroundWorker();


        static bool FindConsole()
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

        public static void Disconnect()
        {
            try
            {
                if (Connected)
                {
                    Xbox.SendTextCommand("bye");
                   XboxName.Close();
                    Connected = false;
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        static bool FindConsole(int retryAttepts)
        {
            return DoWithRetry(FindConsole(), TimeSpan.FromSeconds(5), 3);
        }

        static bool DoWithRetry(bool action, TimeSpan sleepPeriod, int tryCount = 3)
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
