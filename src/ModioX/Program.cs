using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using ModioX.Io;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace ModioX
{
    internal static class Program
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ConfigureLogger();

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        private static void ConfigureLogger()
        {
            var config = new LoggingConfiguration();

            // String to use for exceptions
            const string exc = @"${exception:format=ToString:seperator=\n}";

            // String for getting thread name and id;
            const string threadInfo = @"<${threadname\::whenEmpty=}${threadid}>";

            // String to use as a layout for logged messages.
            var layout = $@"${{date:format=HH\:mm\:ss}} [${{level:uppercase=true}}] {threadInfo}: ${{message}} ${{onexception:inner={exc}}}";

            // Target where to log to.
            var file = new FileTarget("file")
            {
                FileName = $"{UserFolders.AppLogsDirectory}latest.log",
                AutoFlush = true,
                ArchiveOldFileOnStartup = true,
                EnableArchiveFileCompression = true,
                MaxArchiveFiles = 7,
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveDateFormat = "${shortdate}",
                ArchiveFileName = UserFolders.AppLogsDirectory + "ModioX-${shortdate}.zip",
                ArchiveNumbering = ArchiveNumberingMode.Date,
                Layout = layout,
                CreateDirs = true
            };

#if DEBUG
            // Rules for mapping loggers to targets
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, file);
#else
            config.AddRule(LogLevel.Info, LogLevel.Fatal, file);
#endif
            // Apply config
            LogManager.Configuration = config;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var message = new StringBuilder()
                .AppendLine("Should ModioX exit?\n")
                .Append("If you keep receiving this error, please make a report on GitHub or join our Discord Server.");

            MainWindow.Window.SetStatus($"An unknown error occurred: {e.Exception.Message}", e.Exception);

            var resume = XtraMessageBox.Show(MainWindow.Window, $"An error occurred: {e.Exception.Message}.", message.ToString(), MessageBoxButtons.YesNo);

            if (resume == DialogResult.Yes) Application.Exit();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = e.ExceptionObject as Exception;
            var message = new StringBuilder()
                .AppendLine("Should ModioX exit?\n")
                .Append("If you keep receiving this error, please make a report on GitHub or join our Discord Server.");

            MainWindow.Window.SetStatus($"An unknown error occurred: {exception?.Message}", exception);

            var resume = XtraMessageBox.Show(MainWindow.Window, $"An error occurred: {exception?.Message}.", message.ToString(), MessageBoxButtons.YesNo);

            if (resume == DialogResult.Yes) Application.Exit();
        }
    }
}