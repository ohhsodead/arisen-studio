using ModioX.Extensions;
using ModioX.Models.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModioX.Models.Resources
{
    public partial class SettingsData
    {
        /// <summary>
        /// Local path at where the settings file will be stored on the machine
        /// </summary>
        public static readonly string SettingsDataFile = Path.Combine(Environment.CurrentDirectory, "SettingsData.json");

        public List<ConsoleProfile> ConsoleProfiles { get; set; } = new List<ConsoleProfile>();

        public bool ShowModIds { get; set; } = false;

        public bool AutoDetectGameRegion { get; set; } = false;

        public bool SaveLocalDirectoryPath { get; set; } = false;

        public string LocalDirectory { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public bool AlwaysDownloadInstallFiles { get; set; } = false;

        public List<string> FavoritedIds { get; set; } = new List<string>();

        public List<BackupFile> BackupFiles { get; set; } = new List<BackupFile>();

        public List<CustomMod> CustomMods { get; set; } = new List<CustomMod>();

        public List<InstalledGameMod> InstalledGameMods { get; set; } = new List<InstalledGameMod>();

        public BackupFile GetGameFileBackup(string gameId, string fileName, string installPath)
        {
            foreach (var backupFile in from BackupFile backupFile in BackupFiles
                                       where backupFile.CategoryId.ToLower().Equals(gameId.ToLower()) &&
                                       backupFile.FileName.ToLower().Contains(fileName.ToLower()) &&
                                       backupFile.InstallPath.ToLower().Contains(installPath.ToLower())
                                       select backupFile)
            {
                return backupFile;
            }

            return null;
        }

        public List<BackupFile> GetGameFileBackups(string gameId)
        {
            List<BackupFile> backupFiles = new List<BackupFile>();

            foreach (BackupFile backupFile in from BackupFile backupFile in BackupFiles
                                              where backupFile.CategoryId.ToLower().Equals(gameId.ToLower())
                                              select backupFile)
            {
                backupFiles.Add(backupFile);
            }

            return backupFiles;
        }

        public static string CreateBackupFileFolder(ModsData.ModItem modItem)
        {
            return Path.Combine(Utilities.AppDataPath, modItem.GameId, "Backup Files");
        }

        public static string CreateBackupFile(ModsData.ModItem modItem, string fileName)
        {
            return Path.Combine(CreateBackupFileFolder(modItem), fileName);
        }

        public void AddBackupFile(BackupFile backupFile)
        {
            BackupFiles.Add(backupFile);
        }

        public void UpdateBackupFile(int index, BackupFile backupFile)
        {
            if (BackupFiles[index] == null)
            {
                BackupFiles.Add(backupFile);
                return;
            }

            BackupFiles[index] = backupFile;
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

        public void UpdateInstalledGameMod(string gameId, string gameRegion, long modId, int filesInstalled)
        {
            RemoveInstalledGame(gameId);

            InstalledGameMods.Add(new InstalledGameMod() { GameId = gameId, GameRegion = gameRegion, ModId = modId, Files = filesInstalled });
        }

        public void RemoveInstalledGame(string gameId)
        {
            _ = InstalledGameMods.RemoveAll(x => x.GameId.ToLower().Equals(gameId.ToLower()));
        }

        public void RemoveInstalledGameMod(string gameId, long modId)
        {
            _ = InstalledGameMods.RemoveAll(x => x.GameId.ToLower().Equals(gameId) && x.ModId.Equals(modId));
        }

        public InstalledGameMod GetInstalledGameMod(string gameId)
        {
            foreach (InstalledGameMod gameMod in InstalledGameMods)
            {
                if (gameMod.GameId.ToLower().Equals(gameId.ToLower()))
                {
                    return gameMod;
                }
            }

            return null;
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

        public string CategoryTitle { get; set; }

        public string Description { get; set; }

        public List<InstallFile> InstallFiles { get; set; } = new List<InstallFile>();

        public bool RequiresRegion()
        {
            return InstallFiles.Any(x => x.ConsolePath.ToUpper().Contains("{REGION}"));
        }

        public bool RequiresUserId()
        {
            return InstallFiles.Any(x => x.ConsolePath.ToUpper().Contains("{USERID}"));
        }
    }

    public class InstallFile
    {
        public string LocalPath { get; set; }

        public string ConsolePath { get; set; }
    }

    public class InstalledGameMod
    {
        public string GameId { get; set; }

        public string GameRegion { get; set; }

        public long ModId { get; set; }

        public int Files { get; set; }
    }
}