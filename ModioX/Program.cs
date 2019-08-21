using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using DarkUI.Win32;

namespace ModioX
{
    internal static class Program
    {
        public static readonly WebClient WebClient = new WebClient();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.AddMessageFilter(new ControlScrollFilter());
            Application.Run(new Windows.MainForm());
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogMessage("ERROR : " + e.Exception.Message);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogMessage("ERROR : " +  ((Exception)e.ExceptionObject).Message);
        }

        private static string LogFile { get; } = $@"{Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)}\log.txt";

        public static void LogMessage(string message)
        {
            using (StreamWriter logFile = File.AppendText(LogFile))
            {
                logFile.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - {message}");
                logFile.Close();
            }
        }
    }
}