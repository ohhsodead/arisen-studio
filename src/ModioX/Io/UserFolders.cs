using System;
using System.IO;

namespace ModioX.Io
{
    public class UserFolders
    {
        /// <summary>
        /// Get the user's Documents folder.
        /// </summary>
        internal static readonly string AppDataDirectory = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\ModioX\";

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
            foreach (string directory in Directory.GetDirectories(path))
            {
                Directory.Delete(directory, true);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}