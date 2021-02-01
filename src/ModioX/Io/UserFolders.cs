using System;
using System.IO;
using NLog;

namespace ModioX.Io
{
    public static class UserFolders
    {
        /// <summary>
        /// Get the user's Documents folder.
        /// </summary>
        internal static readonly string AppDataDirectory = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\ModioX\";

        internal static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Get the directory to download modded files at.
        /// </summary>
        internal static readonly string AppModsDataDirectory = $@"{AppDataDirectory}Mods\";

        /// <summary>
        /// Get the directory for downloading backup files to.
        /// </summary>
        internal static readonly string AppBackupFilesDirectory = $@"{AppDataDirectory}Backup Files\";

        /// <summary>
        /// Get the Logs directory where the app's logs reside.
        /// </summary>
        internal static readonly string AppLogsDirectory = $@"{AppDataDirectory}Logs\";

        /// <summary>
        /// Local path at where the settings file will be stored on the machine.
        /// </summary>
        internal static readonly string AppSettingsFile = $@"{AppDataDirectory}SettingsData.json";

        /// <summary>
        /// Depth-first recursive delete, with handling for descendant directories.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            for (var i = 0; i < 3; i++)
            {
                try
                {
                    foreach (var dir in new DirectoryInfo(path).GetDirectories())
                    {
                        dir.Delete(true);
                    }
                    Directory.Delete(path, true);
                }
                catch (Exception ex)
                {
                    Logger.Warn(ex);
                    if (ex is UnauthorizedAccessException || ex is DirectoryNotFoundException) return;
                }
            }
        }
    }
}