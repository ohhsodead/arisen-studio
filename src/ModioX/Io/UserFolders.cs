using System;
using System.IO;

namespace ModioX.Io
{
    public class UserFolders
    {
        /// <summary>
        ///     Get the user's Documents folder.
        /// </summary>
        internal static string AppData { get; } = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\ModioX\";

        /// <summary>
        ///     Get the directory to download modded files at.
        /// </summary>
        internal static string AppModsData { get; } = $@"{AppData}Mods\";

        /// <summary>
        ///     Get the game backup files directory for downloading backup files to.
        /// </summary>
        internal static string AppGameBackupFiles { get; } = $@"{AppData}Game Backup Files\";

        /// <summary>
        ///     Local path at where the settings file will be stored on the machine
        /// </summary>
        internal static readonly string AppSettingsFile = $@"{AppData}\SettingsData.json";

        /// <summary>
        ///     Depth-first recursive delete, with handling for descendant directories.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            foreach (var directory in Directory.GetDirectories(path))
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