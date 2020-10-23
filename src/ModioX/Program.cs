using DarkUI.Forms;
using DarkUI.Win32;
using log4net;
using ModioX.Forms;
using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ModioX
{
    internal static class Program
    {
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static readonly WebClient WebClient = new WebClient();

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Initialize log4net.
            _ = log4net.Config.XmlConfigurator.Configure();
            Log.Info("Configured logging settings.");

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.AddMessageFilter(new ControlScrollFilter());
            Application.Run(new MainWindow());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MainWindow.mainWindow.SetStatus($"An unknown error occurred: {e.Exception.Message}", e.Exception);
            _ = DarkMessageBox.Show(MainWindow.mainWindow, $"An unknown error occurred: {e.Exception.Message}. If you keep receiving this issue when then report it on GitHub so we can investigate.");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MainWindow.mainWindow.SetStatus($"An unknown error occurred: {((Exception)e.ExceptionObject).Message}", (Exception)e.ExceptionObject);
            _ = DarkMessageBox.Show(MainWindow.mainWindow, $"An unknown error occurred: {((Exception)e.ExceptionObject).Message}. If you keep receiving this issue when then report it on GitHub so we can investigate.");
        }
    }
}