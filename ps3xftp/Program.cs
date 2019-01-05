using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ps3xftp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ps3xftp());
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            WriteToLog("ERROR : " + e.Exception.Message);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteToLog("ERROR : " +  (e.ExceptionObject as Exception).Message);
        }

        static string LogFile { get; } = $@"{Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)}\log.txt";

        public static void WriteToLog(string message)
        {
            using (StreamWriter FtpLog = File.AppendText(LogFile))
            {
                FtpLog.WriteLine(string.Format("[{0}] - {1}", DateTime.Now.ToString(), message)); FtpLog.Close();
            }
        }
    }
}