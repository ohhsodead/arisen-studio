using System;

namespace ArisenStudio.Models.Database
{
    public class AppItemFile
    {
        public DateTime LastUpdated { get; set; }

        public string Name { get; set; }
        
        public string Version { get; set; }
        
        public string PlayableVersion { get; set; }
        
        public string InstallPath { get; set; }

        public string GetFileUrl(string titleId)
        {
            return $"https://pkg-zone.com/download/ps4/{titleId}/{Version}";
        }

        public string GetFileName(string titleId)
        {
            return $"{titleId}/{Version}";
        }

        public string GetInstallPath(string titleId)
        {
            return InstallPath.Replace("{title_id}", titleId).Replace("{name}", Name).Replace("{version}", Version);
        }
    }
}