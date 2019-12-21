using ModioX.Models.Database;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModioX.Models.Resources
{
    public partial class SettingsData
    {
        public List<ConsoleProfile> ConsoleProfiles { get; set; } = new List<ConsoleProfile>();

        public bool AutoDetectGameRegion { get; set; } = false;

        public bool EnableFileExplorer { get; set; } = false;

        public bool SaveLocalDirectory { get; set; } = false;

        public string LocalDirectory { get; set; } = "";

        public bool ShowModIds { get; set; } = false;

        public List<string> FavoritedIds { get; set; } = new List<string>();

        public List<BackupFile> BackupFiles { get; set; } = new List<BackupFile>();

        public List<CustomMod> CustomMods { get; set; } = new List<CustomMod>();

        public BackupFile GetGameFileBackup(string gameId, string fileName, string installPath)
        {
            foreach (BackupFile backupFile in from BackupFile backupFile in BackupFiles
                                              where backupFile.CategoryId.ToLower().Equals(gameId.ToLower())
                                              && backupFile.FileName.ToLower().Contains(fileName.ToLower())
                                              && backupFile.InstallPath.ToLower().Contains(installPath.ToLower())
                                              select backupFile)
            {
                return backupFile;
            }

            return null;
        }

        public static string CreateBackupFileFolder(ModsData.ModItem modItem)
        {
            return Path.Combine(modItem.GetDirectoryGameData(), "Game Backup Files");
        }

        public static string CreateBackupFile(ModsData.ModItem modItem, string fileName)
        {
            return Path.Combine(CreateBackupFileFolder(modItem), fileName);
        }

        public void AddMod(CustomMod customMod)
        {
            CustomMods.Add(customMod);
        }

        public void UpdateMod(int index, CustomMod customMod)
        {
            if (CustomMods[index] == null)
            {
                CustomMods.Add(customMod);
                return;
            }

            CustomMods[index] = customMod;
        }

        public void RemoveMod(int index)
        {
            CustomMods.RemoveAt(index);
        }

    }

    public class ConsoleProfile
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return Name + " : " + Address;
        }
    }

    public class BackupFile
    {
        public string Name { get; set; }

        public string FileName { get; set; }

        public string CategoryId { get; set; }

        public string LocalPath { get; set; }

        public string InstallPath { get; set; }
    }

    public class CustomMod
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }

        public string Description { get; set; }

        public List<InstallFile> InstallFiles { get; set; } = new List<InstallFile>();
    }

    public class InstallFile
    {
        public string LocalPath { get; set; }

        public string ConsolePath { get; set; }
    }
}