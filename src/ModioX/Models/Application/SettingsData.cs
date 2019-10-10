using ModioX.Models.Database;
using System.Collections.Generic;

namespace ModioX.Models.Application
{
    public partial class SettingsData
    {
        public List<string> ConsoleProfiles { get; set; } = new List<string>();
        public bool AutoDetectGameRegion { get; set; } = true;
        public bool SaveLocalDirectory { get; set; } = true;
        public string LocalDirectory { get; set; } = "";
        public bool EnableFileExplorer { get; set; } = true;
        public List<string> FavoritedIds { get; set; } = new List<string>();
        public List<BackupFile> BackupFiles { get; set; } = new List<BackupFile>();
    }
}