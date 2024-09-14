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
                Layout = "${longdate} [${level:uppercase=true}] ${message} ${exception:format=ToString}"
            };

            // String to use for exceptions
            const string exc = @"${exception:format=ToString:seperator=\n}";

            // String for getting thread name and id;
            const string threadInfo = @"<${threadname\::whenEmpty=}${threadid}>";

            // String to use as a layout for logged messages.
            string layout = $@"${{date:format=HH\:mm\:ss}} [${{level:uppercase=true}}] {threadInfo}: ${{message}} ${{onexception:inner={exc}}}";

            // Define the file target with archiving
            FileTarget fileTarget = new("file")
            {
                FileName = UserFolders.Logs + "arisen-studio-${shortdate}.log",
                ArchiveFileName = UserFolders.Logs + "arisen-studio-{#####}.zip",
                ArchiveEvery = FileArchivePeriod.Day,
                MaxArchiveFiles = 7,
                EnableArchiveFileCompression = true,
                CreateDirs = true,
                Layout = layout,//"${longdate} [${level:uppercase=true}] ${message} ${exception:format=ToString}"
            };

            // Define the rolling file target (size-based)
            FileTarget rollingFileTarget = new("rollingFile")
            {
                FileName = UserFolders.Logs + "arisen-studio.log",
                ArchiveFileName = UserFolders.Logs + "arisen-studio-{#}.log",
                ArchiveAboveSize = 10485760, // 10 MB
                Layout = layout//"${longdate} [${level:uppercase=true}] ${message} ${exception:format=ToString}"
            };

            // Define and add targets to the configuration
            Target[] targets = [consoleTarget, fileTarget, rollingFileTarget];
            foreach (Target target in targets)
            {
                config.AddTarget(target);
            }

            // Define logging rules
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, consoleTarget);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, fileTarget);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, rollingFileTarget);

            // Apply configuration
            LogManager.Configuration = config;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MainWindow.Window.SetStatus($"An error occurred: {e.Exception.Message}", e.Exception);

            _ = XtraMessageBox.Show(MainWindow.Window,
                $"An error occurred: {e.Exception.Message}\n\n" +
                $"If this issue persists, please report it by <a href=\"https://github.com/ohhsodead/arisen-studio/issues/new?labels=bug&template=bug.yml\">opening a new issue</a> on our GitHub tracker or opening a ticket in our Discord Server.",
                "Arisen Studio Handled Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;

            MainWindow.Window.SetStatus($"An error occurred: {exception.Message}", exception);

            _ = XtraMessageBox.Show(MainWindow.Window,
                $"An error occurred: {exception.Message}\n\n" +
                $"If this issue persists, please report it by <a href=\"https://github.com/ohhsodead/arisen-studio/issues/new?labels=bug&template=bug.yml\">opening a new issue</a> on our GitHub tracker or opening a ticket in our Discord Server.",
                "Arisen Studio Handled Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}