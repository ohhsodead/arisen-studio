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

namespace XDevkit
{
    /// <summary>
    /// Xbox Emulation Class
    /// Made By TeddyHammer
    /// </summary>
    public partial class Xbox  //Networking Class
    {
        private const int listenPort = 730;
        public static string Response;
        public static bool Connected { get; set; }
        public static TcpClient XboxName { get; set; }
        [Browsable(false)]
        public static StreamReader Reader { get; set; }
        public static uint ConnectTimeout { get; set; }
        public static uint ConversationTimeout { get; set; }
        public static string IPAddress { get; set; }


        /// <summary>
        /// Connects Local Tcp Connection From Device To Xbox Console
        /// 
        /// </summary>
        public bool Connect(string XboxNameOrIP = "default")//NOTE: Edit if specified String is read then it will return true
        {
            //User Enter's Nothing
            if (XboxNameOrIP == "default")
            {
                return Connect("default", 730);
            }
            // If User Supply's IP To US.
            else
            {
                return Connect(XboxNameOrIP, 730);
            }
        }


    

        /// <summary>
        /// Connects Local Tcp Connection From Device To Xbox Console
        /// 
        /// </summary>
        public bool Connect(string XboxNameOrIP = "default", int Port = 730)
        {
            //User Enter's Nothing
            if (XboxNameOrIP == "default")
            {
                XboxName = new TcpClient();
                if (FindConsole())//if true then continue
                {
                    XboxName = new TcpClient(System.Net.IPAddress.Any.ToString(), listenPort);//test...
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
            else if (XboxNameOrIP.ToCharArray().Any(char.IsDigit))
            {
                string IPAddress = XboxNameOrIP;
                XboxName = new TcpClient(XboxNameOrIP, Port);
                Reader = new StreamReader(XboxName.GetStream());
                Console.WriteLine("/Connection - Degits/....(" + "Manual Connection Mode" + ")");
                return Connected = true;
            }
            //Get IP Via Name
            else if (XboxNameOrIP.ToCharArray().Any(char.IsLetter))//uses ip to find console makes user think it finds it via name 
            {
                new Exception("Not Yet Supported");
                return false;
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
        public static string SendTextCommand(string Command)
        {
            try
            {
                SendTextCommand(Command, out Response);
            }
            catch
            {
            }
            return string.Empty;
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
        private static void StartListener()
        {

            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(System.Net.IPAddress.Any, listenPort);

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
        private bool FindConsole()
        {
            StartListener();
            return true;
        }
        #endregion


    }
}