using ModioX.Forms.Windows;
using System;
using System.IO;

namespace ModioX.Io
{
    public static class UserFolders
    {
        /// <summary>
        /// Get the user's Documents folder.
        /// </summary>
        internal static readonly string AppData = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\ModioX\";

        /// <summary>
        /// Get the user's settings details file.
        /// </summary>
        internal static readonly string SettingsData = $@"{AppData}SettingsData.json";

        /// <summary>
        /// Get the backup files details file.
        /// </summary>
        internal static readonly string BackupFilesData = $@"{AppData}BackupFilesData.json";

        /// <summary>
        /// Get the directory path of the downloaded mods before their installed.
        /// </summary>
        internal static readonly string DownloadsLocationMods = $@"{MainWindow.Settings.DownloadsLocation}Mods\";

        /// <summary>
        /// Get the directory path of the downloaded mods before their installed.
        /// </summary>
        internal static readonly string DownloadsLocationPackages = $@"{MainWindow.Settings.DownloadsLocation}Packages\";

        /// <summary>
        /// Get the directory path of the downloaded mods before their installed.
        /// </summary>
        internal static readonly string DownloadsLocationPlugins = $@"{MainWindow.Settings.DownloadsLocation}Plugins\";

        /// <summary>
        /// Get the directory path of the downloaded mods before their installed.
        /// </summary>
        internal static readonly string DownloadsLocationGameSaves = $@"{MainWindow.Settings.DownloadsLocation}Game Saves\";

        /// <summary>
        /// Get the game backup files directory path.
        /// </summary>
        internal static readonly string BackupFiles = $@"{AppData}Backup Files\";

        /// <summary>
        /// Get the directory path of the downloaded packages.
        /// </summary>
        internal static readonly string Packages = $@"{AppData}Packages\";

        /// <summary>
        /// Get the directory path of the downloaded packages.
        /// </summary>
        internal static readonly string XboxProfiles = $@"{AppData}Xbox Profiles\";

        /// <summary>
        /// Get the Logs directory where the app's logs reside.
        /// </summary>
        internal static readonly string Logs = $@"{AppData}Logs\";

        /// <summary>
        /// Get the tmp directory path.
        /// </summary>
        internal static readonly string Tmp = $@"{AppData}tmp\";

        /// <summary>
        /// Depth-first recursive delete, with handling for descendant directories.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            DirectoryInfo dir = new(path);

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
                    switch (ex)
                    {
                        case UnauthorizedAccessException:
                        case DirectoryNotFoundException:
                            return;
                    }
                }
            }
        }
    }
}