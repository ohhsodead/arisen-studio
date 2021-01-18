//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        public static string Response;

        public static bool Connected { get; set; }
        public static TcpClient XboxName { get; set; }
        public uint ConnectTimeout { get; private set; }
        public uint ConversationTimeout { get; private set; }

        /// <summary>
        /// Connects Local Tcp Connection From Device To Xbox Console
        /// 
        /// </summary>
        public bool Connect(string XboxNameOrIP = "default")
        {
            return Connected;
        }

        /// <summary>
        /// Connects Local Tcp Connection From Device To Xbox Console
        /// 
        /// </summary>
        public bool Connect(string XboxNameOrIP = "default", int Port = 730)
        {
            return Connected;
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
                    Console.WriteLine("Failed to SendTextCommand ==> All Checks Failed.. <==");
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
                FlushSocketBuffer();

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


    }
}