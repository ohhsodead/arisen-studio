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
        /// <returns> </returns>
        public string GetFileUrl(string titleId)
        {
            // Example: https://pkg-zone.com/download/ps4/LAPY20009/2.03
            return $"https://pkg-zone.com/download/ps4/{titleId}/{Version}";
        }

        public string GetInstallPath(string titleId)
        {
            // Example: "/data/pkg/{title_id}/{name}-{version}.pkg";
            return InstallPath.Replace("{title_id}", titleId).Replace("{name}", Name).Replace("{version}", Version);
        }
    }
}