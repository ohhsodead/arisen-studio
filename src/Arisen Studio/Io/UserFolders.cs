using System;

namespace ArisenStudio.Io
{
    public static class UserFolders
    {
        /// <summary>
        /// Get the user's Documents folder.
        /// </summary>
        //internal static readonly string AppData = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\Arisen Studio\";
        internal static readonly string AppData = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Arisen Studio\";

        /// <summary>
        /// Get the user's settings details file.
        /// </summary>
        internal static readonly string SettingsData = $@"{AppData}SettingsData.json";

        /// <summary>
        /// Get the backup files details file.
        /// </summary>
        internal static readonly string BackupFilesData = $@"{AppData}BackupFilesData.json";

        /// <summary>
        /// Get the game backup files directory path.
        /// </summary>
        internal static readonly string BackupFiles = $@"{AppData}Backup Files\";

        /// <summary>
        /// Get the directory path of the downloaded packages.
        /// </summary>
        internal static readonly string XboxProfiles = $@"{AppData}Xbox Profiles\";

        /// <summary>
        /// Get the Logs directory where the app's logs reside.
        /// </summary>
        internal static readonly string Logs = $@"{AppData}Logs\";
    }
}