using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Ps3Xftp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ps3Xftp());
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            WriteToLog("ERROR : " + e.Exception.Message);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteToLog("ERROR : " +  ((Exception)e.ExceptionObject).Message);
        }

        private static string LogFile { get; } = $@"{Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)}\log.txt";

        public static void WriteToLog(string message)
        {
            using (var ftpLog = File.AppendText(LogFile))
            {
                ftpLog.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - {message}"); ftpLog.Close();
            }
        }
    }
}