using System;

namespace ArisenStudio.Database
{
    /// <summary>
    /// Get the downloads information.
    /// </summary>
    public class AppItemFile
    {
        public DateTime LastUpdated { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string PlayableVersion { get; set; }

        public string InstallPath { get; set; }

        /// <summary>
        /// Get file URL hosted on pkg-zone with the specified fields.
        /// </summary>
        /// <param name="titleId"></param>
        /// <returns></returns>
        public string GetFileUrl(string titleId)
        {
            // Example: https://pkg-zone.com/download/ps4/LAPY20009/2.03
            return $"https://pkg-zone.com/download/ps4/{titleId}/{Version}";
        }

        /// <summary>
        /// Get the file name of the download file.
        /// </summary>
        /// <param name="titleId">TitleId of the file</param>
        /// <returns></returns>
        public string GetFileName(string titleId)
        {
            // Example: "/data/pkg/{title_id}/{name}-{version}.pkg";
            return $"{titleId}/{Version}";
        }

        /// <summary>
        /// Get the file install path with the formatted appropriately.
        /// </summary>
        /// <param name="titleId">TitleId of the file</param>
        /// <returns></returns>
        public string GetInstallPath(string titleId)
        {
            // Example: "/data/pkg/{title_id}/{name}-{version}.pkg";
            return InstallPath.Replace("{title_id}", titleId).Replace("{name}", Name).Replace("{version}", Version);
        }
    }
}