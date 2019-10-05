using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DarkUI.Win32;
using log4net;
using ModioX.Windows;

namespace ModioX
{
    internal static class Program
    {
        [DllImport("user32.dll")]
        public static extern bool HideCaret(IntPtr hWnd);

        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static readonly WebClient WebClient = new WebClient();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Initialize log4net.
            log4net.Config.XmlConfigurator.Configure();
            Log.Info("Successfully configured logging.");

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.AddMessageFilter(new ControlScrollFilter());
            System.Windows.Forms.Application.Run(new MainForm());
            System.Windows.Forms.Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception.Message, e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Log.Error(((Exception)e.ExceptionObject).Message, (Exception)e.ExceptionObject);
        }
    }
}