using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using DarkUI.Forms;
using DarkUI.Win32;
using log4net;
using log4net.Config;
using ModioX.Forms.Windows;

namespace ModioX
{
    internal static class Program
    {
        public static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Initialize log4net.
            _ = XmlConfigurator.Configure();
            Log.Info("Configured logging settings.");

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.AddMessageFilter(new ControlScrollFilter());
            Application.Run(new MainWindow());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MainWindow.Window.SetStatus($"An unknown error occurred: {e.Exception.Message}", e.Exception);
            _ = DarkMessageBox.Show(MainWindow.Window,
                $"An unknown error occurred: {e.Exception.Message}. If you keep receiving this issue when then report it on GitHub so we can investigate.");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MainWindow.Window.SetStatus($"An unknown error occurred: {((Exception) e.ExceptionObject).Message}",
                (Exception) e.ExceptionObject);
            _ = DarkMessageBox.Show(MainWindow.Window,
                $"An unknown error occurred: {((Exception) e.ExceptionObject).Message}. If you keep receiving this issue when then report it on GitHub so we can investigate.");
        }
    }
}