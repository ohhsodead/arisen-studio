using DevExpress.XtraEditors;
using NeoModsX.Forms.Windows;
using NeoModsX.Io;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NeoModsX
{
    internal static class Program
    {
        public static Mutex mutex = new(true, "NeoModsX");
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                ConfigureLogger();

                Application.ThreadException += Application_ThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.Skins.SkinManager.EnableMdiFormSkins();

                Application.Run(new MainWindow());

                mutex.ReleaseMutex();
                mutex.Dispose();
            }
        }

        private static void ConfigureLogger()
        {
            LoggingConfiguration config = new();

            // String to use for exceptions
            const string exc = @"${exception:format=ToString:seperator=\n}";

            // String for getting thread name and id;
            const string threadInfo = @"<${threadname\::whenEmpty=}${threadid}>";

            // String to use as a layout for logged messages.
            string layout =
                $@"${{date:format=HH\:mm\:ss}} [${{level:uppercase=true}}] {threadInfo}: ${{message}} ${{onexception:inner={exc}}}";

            // Target where to log to.
            FileTarget file = new("file")
            {
                FileName = $"{UserFolders.Logs}latest.log",
                AutoFlush = true,
                ArchiveOldFileOnStartup = true,
                EnableArchiveFileCompression = true,
                MaxArchiveFiles = 7,
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveDateFormat = "${shortdate}",
                ArchiveFileName = UserFolders.Logs + "NeoModsX-${shortdate}.zip",
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
            StringBuilder message = new StringBuilder()
                .Append("Should NeoModsX exit?")
                .AppendLine("\nIf you keep receiving this error, please open a new issue on GitHub or a open ticket in our Discord Server.");

            MainWindow.Window.SetStatus($"An unknown error occurred: {e.Exception.Message}", e.Exception);

            DialogResult closeResult = XtraMessageBox.Show(MainWindow.Window, $"An error occurred: {e.Exception.Message}\n\n" + message.ToString(), "Unhandled Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            switch (closeResult)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;

            StringBuilder message = new StringBuilder()
                .Append("Should NeoModsX exit?")
                .AppendLine("\nIf you keep receiving this error, please open a new issue on GitHub or a open ticket in our Discord Server.");

            MainWindow.Window.SetStatus($"An unknown error occurred: {exception.Message}", exception);

            DialogResult closeResult = XtraMessageBox.Show(MainWindow.Window, $"An error occurred: {exception.Message}\n\n" + message.ToString(), "Unhandled Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            switch (closeResult)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }


    }
}