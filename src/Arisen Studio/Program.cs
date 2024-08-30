using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Io;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ArisenStudio
{
    internal static class Program
    {
        public static Mutex Mutex = new(true, "Arisen Studio");
        public static Logger Log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                ConfigureLogger();

                Application.ThreadException += Application_ThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                WindowsFormsSettings.SetDPIAware();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.Skins.SkinManager.EnableMdiFormSkins();

                Application.Run(new MainWindow());

                Mutex.ReleaseMutex();
                Mutex.Dispose();
            }
        }

        private static void ConfigureLogger()
        {
            // Create and configure NLog configuration
            LoggingConfiguration config = new();

            // Define the console target
            ConsoleTarget consoleTarget = new("console")
            {
                Layout = "${longdate} [${level:uppercase=true}] ${logger} ${message} ${exception:format=ToString}"
            };

            // Define the file target with archiving
            FileTarget fileTarget = new("file")
            {
                FileName = UserFolders.Logs + "app-${shortdate}.log",
                ArchiveFileName = UserFolders.Logs + "app-{#####}.zip",
                ArchiveEvery = FileArchivePeriod.Day,
                MaxArchiveFiles = 7,
                EnableArchiveFileCompression = true,
                CreateDirs = true,
                Layout = "${longdate} [${level:uppercase=true}] ${logger} ${message} ${exception:format=ToString}"
            };

            // Define the rolling file target (size-based)
            FileTarget rollingFileTarget = new("rollingFile")
            {
                FileName = UserFolders.Logs + "rolling-app.log",
                ArchiveFileName = UserFolders.Logs + "rolling-app-{#}.log",
                ArchiveAboveSize = 10485760, // 10 MB
                Layout = "${longdate} [${level:uppercase=true}] ${logger} ${message} ${exception:format=ToString}"
            };

            // Define the network target
            NetworkTarget networkTarget = new("network")
            {
                Name = "network",
                Address = "tcp://localhost:5151",
                Layout = "${longdate} [${level:uppercase=true}] ${logger} ${message} ${exception:format=ToString}"
            };

            // Define and add targets to the configuration
            Target[] targets = [consoleTarget, fileTarget, rollingFileTarget, networkTarget];
            foreach (Target target in targets)
            {
                config.AddTarget(target);
            }

            // Define logging rules
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, consoleTarget);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, fileTarget);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, rollingFileTarget);
            config.AddRule(LogLevel.Fatal, LogLevel.Fatal, networkTarget);

            // Apply configuration
            LogManager.Configuration = config;

            // Get logger instance and test logging
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.Info("This is an informational message.");
            logger.Error("This is an error message.");
            logger.Warn("This is a warning message.");
            logger.Debug("This is a debug message.");
            logger.Trace("This is a trace message.");

            // Keep the console window open for debugging
            //Console.WriteLine("Logging is configured. Press any key to exit...");
            //Console.ReadKey();

            //

            //var config = new LoggingConfiguration();

            //// Targets where to log to: File and Console
            //var logfile = new FileTarget("logfile") { FileName = "file.txt" };
            //var logconsole = new ConsoleTarget("logconsole");

            //// Rules for mapping loggers to targets            
            //config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            //config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            //// Apply config           
            //LogManager.Configuration = config;

            //

            //var config = new LoggingConfiguration();
            //var consoleTarget = new ConsoleTarget
            //{
            //    Name = "console",
            //    Layout = "${longdate}|${level:uppercase=true}|${logger}|${message}",
            //};
            //config.AddRule(LogLevel.Debug, LogLevel.Fatal, consoleTarget, "*");
            //LogManager.Configuration = config;

            //

            //            LoggingConfiguration config = new();

            //            // String to use for exceptions
            //            const string exc = @"${exception:format=ToString:seperator=\n}";

            //            // String for getting thread name and id;
            //            const string threadInfo = @"<${threadname\::whenEmpty=}${threadid}>";

            //            // String to use as a layout for logged messages.
            //            string layout =
            //                $@"${{date:format=HH\:mm\:ss}} [${{level:uppercase=true}}] {threadInfo}: ${{message}} ${{onexception:inner={exc}}}";

            //            // Target where to log to.
            //            FileTarget file = new("file")
            //            {
            //                FileName = $"{UserFolders.Logs}latest.log",
            //                AutoFlush = true,
            //                ArchiveOldFileOnStartup = true,
            //                EnableArchiveFileCompression = true,
            //                MaxArchiveFiles = 7,
            //                ArchiveEvery = FileArchivePeriod.Day,
            //                ArchiveDateFormat = "${shortdate}",
            //                ArchiveFileName = UserFolders.Logs + "ArisenStudio-${shortdate}.zip",
            //                ArchiveNumbering = ArchiveNumberingMode.Date,
            //                Layout = layout,
            //                CreateDirs = true
            //            };

            //#if DEBUG
            //            // Rules for mapping loggers to targets
            //            config.AddRule(LogLevel.Debug, LogLevel.Fatal, file);
            //#else
            //            config.AddRule(LogLevel.Info, LogLevel.Fatal, file);
            //#endif
            //            // Apply config
            //            LogManager.Configuration = config;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MainWindow.Window.SetStatus($"An unknown error occurred: {e.Exception.Message}", e.Exception);

            DialogResult closeResult = XtraMessageBox.Show(MainWindow.Window, $"An error occurred: {e.Exception.Message}\n\n" +
                $"Would you like to close Arisen Studio? If this issue persists, please report it by opening a new issue on GitHub or a ticket on our Discord Server.", "Arisen Studio Handled Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

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

            MainWindow.Window.SetStatus($"An unknown error occurred: {exception.Message}", exception);

            DialogResult closeResult = XtraMessageBox.Show(MainWindow.Window, $"An error occurred: {exception.Message}\n\n" +
                $"Would you like to close Arisen Studio? If this issue persists, please report it by opening a new issue on GitHub or a ticket on our Discord Server.", "Arisen Studio Handled Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            switch (closeResult)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }
    }
}