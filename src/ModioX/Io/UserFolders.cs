using System;
using System.IO;

namespace ModioX.Io
{
    public static class UserFolders
    {
        /// <summary>
        /// Get the user's Documents folder.
        /// </summary>
        internal static readonly string AppDataDirectory = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\ModioX\";

        /// <summary>
        /// Local path at where the settings file will be stored on the machine.
        /// </summary>
        internal static readonly string AppSettingsFile = $@"{AppDataDirectory}SettingsData.json";

        /// <summary>
        /// Get the directory to download modded files at.
        /// </summary>
        internal static readonly string AppModsDataDirectory = $@"{AppDataDirectory}Mods\";

        /// <summary>
        /// Get the directory for downloading backup files to.
        /// </summary>
        internal static readonly string AppBackupFilesDirectory = $@"{AppDataDirectory}Game Backup Files\";

        /// <summary>
        /// Get the Logs directory where the app's logs reside.
        /// </summary>
        internal static readonly string AppLogsDirectory = $@"{AppDataDirectory}Logs\";

        /// <summary>
        /// Depth-first recursive delete, with handling for descendant directories.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(path);

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    foreach (DirectoryInfo subdir in dir.GetDirectories())
                    {
                        subdir.Delete(true);
                    }

                    dir.Delete(true);
                }
                catch (Exception ex)
                {
                    Program.Log.Warn(ex);
                    if (ex is UnauthorizedAccessException || ex is DirectoryNotFoundException) return;
                }
            }

        }
    }
}