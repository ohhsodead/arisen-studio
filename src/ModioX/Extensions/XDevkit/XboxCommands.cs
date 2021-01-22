//Do Not Delete This Comment... 
//Made By TeddyHammer on 08/20/16
//Any Code Copied Must Source This Project (its the law (:P)) Please.. i work hard on it 3 years and counting...
//Thank You for looking love you guys...
using System;
using System.ComponentModel;
using System.IO;
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
    public partial class Xbox  //Command Class    
    {
        public string Name { get; set; } = Connected ? SendTextCommand("dbgname") : "Error";

        public static string Response;

        public static bool Connected { get; set; }

        public static int ConnectTimeout { get => XboxClient.XboxName.SendTimeout; set => XboxClient.XboxName.SendTimeout = value;
        }
        public static int ConversationTimeout { get => XboxClient.XboxName.ReceiveTimeout; set => XboxClient.XboxName.ReceiveTimeout = value;
        }
        public  string IPAddress { get; set; }

        public string DefaultConsole { get; set; }


        public void Disconnect()
        {
            if (Connected)
            {
                this.SendTextCommand("bye");
                XboxClient.XboxName.Close();
                Connected = false;
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
                if (XboxClient.XboxName.Connected == true)
                {
                    Console.WriteLine("SendTextCommand " + Command + " ==> Sending Command... <==");
                    XboxClient.XboxName.Client.Send(Encoding.ASCII.GetBytes(Command + Environment.NewLine));
                    XboxClient.XboxName.Client.Receive(Packet);
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
            if (XboxClient.XboxName != null)
            {

                try
                {
                    XboxClient.XboxName.Client.Send(Encoding.ASCII.GetBytes(string.Format(command, args) + Environment.NewLine));
                }
                catch (Exception /*ex*/)
                {

                }
            }
            else throw new Exception("No Connection Detected");
        }



        #region test Area
        #endregion


    }
}