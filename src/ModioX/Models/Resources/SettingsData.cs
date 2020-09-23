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
        ///     Local path at where the settings file will be stored on the machine
        /// </summary>
        public static readonly string SettingsDataFile = Path.Combine(KnownFolders.GetPath(KnownFolder.Documents), "ModioX", "SettingsData.json");

        public bool FirstTimeUse { get; set; } = true;

        public bool FirstTimeOpenAfterUpdate { get; set; } = true;

        public List<ConsoleProfile> ConsoleProfiles { get; set; } = new List<ConsoleProfile>();

        public bool ShowModIds { get; set; } = false;

        public bool RememberGameRegions { get; set; } = false;

        public bool AutoDetectGameRegion { get; set; } = false;

        public bool SaveLocalDirectoryPath { get; set; } = false;

        public string LocalDirectory { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public bool AlwaysDownloadInstallFiles { get; set; } = false;

        public List<string> FavoritedIds { get; set; } = new List<string>();

        public List<GameRegion> GameRegions { get; set; } = new List<GameRegion>();

        public List<BackupFile> BackupFiles { get; set; } = new List<BackupFile>();

        public List<CustomMod> CustomMods { get; set; } = new List<CustomMod>();

        public List<ExternalApplication> ExternalApplications { get; set; } = new List<ExternalApplication>();

        public List<GameModInstalled> InstalledGameMods { get; set; } = new List<GameModInstalled>();

        /// <summary>
        ///     Gets the users external applications file location for the specified application name
        /// </summary>
        /// <param name="name">Game Id</param>
        /// <returns>Game Region</returns>
        public string GetApplicationLocation(string name)
        {
            foreach (ExternalApplication application in from ExternalApplication application in ExternalApplications
                                                        where string.Equals(application.Name, name, StringComparison.CurrentCultureIgnoreCase)
                                                        select application)
            {
                return application.FileLocation;
            }

            return null;
        }

        /// <summary>
        ///     Either update or add the application name and file location
        /// </summary>
        /// <param name="name">Application Name</param>
        /// <param name="fileLocation">Application File Location</param>
        public void UpdateApplication(string name, string fileLocation)
        {
            ExternalApplication applicationIndex = ExternalApplications.Find(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase));

            ExternalApplication externalApplcation = new ExternalApplication(name, fileLocation);

            if (applicationIndex == null)
            {
                ExternalApplications.Add(externalApplcation);
                return;
            }
            else
            {
                ExternalApplications[ExternalApplications.IndexOf(applicationIndex)] = externalApplcation;
            }
        }

        /// <summary>
        ///     Gets the users game region for the specified game id
        /// </summary>
        /// <param name="gameId">Game Id</param>
        /// <returns>Game Region</returns>
        public string GetGameRegion(string gameId)
        {
            foreach (GameRegion gameRegion in from GameRegion gameRegion in GameRegions
                                              where string.Equals(gameRegion.GameId, gameId, StringComparison.CurrentCultureIgnoreCase)
                                              select gameRegion)
            {
                return gameRegion.Region;
            }

            return null;
        }

        /// <summary>
        ///     Either update or add the region to the specified game id
        /// </summary>
        /// <param name="gameId">Game Id</param>
        /// <param name="region">Game Region</param>
        public void UpdateGameRegion(string gameId, string region)
        {
            int gameIdIndex = GameRegions.FindIndex(x => string.Equals(x.GameId, gameId, StringComparison.CurrentCultureIgnoreCase));

            if (gameIdIndex == -1)
            {
                GameRegions.Add(new GameRegion(gameId, region));
                return;
            }

            GameRegions[gameIdIndex].Region = region;
        }

        /// <summary>
        ///     Gets the backup file information for the specified game id, file name and install path
        /// </summary>
        /// <param name="gameId">Game Id</param>
        /// <param name="fileName">File Name</param>
        /// <param name="installPath">File Install Path</param>
        /// <returns></returns>
        public BackupFile GetGameFileBackup(string gameId, string fileName, string installPath)
        {
            foreach (BackupFile backupFile in from BackupFile backupFile in BackupFiles
                                              where backupFile.CategoryId.ToLower().Equals(gameId.ToLower()) &&
                                              backupFile.FileName.ToLower().Contains(fileName.ToLower()) &&
                                              backupFile.InstallPath.ToLower().Contains(installPath.ToLower())
                                              select backupFile)
            {
                return backupFile;
            }

            return null;
        }

        /// <summary>
        ///     Create a folder for the specified game id
        /// </summary>
        /// <param name="modItem"></param>
        /// <returns></returns>
        public static string CreateBackupFileFolder(ModsData.ModItem modItem)
        {
            return Path.Combine(KnownFolders.GetPath(KnownFolder.Documents), "ModioX", "Backup Files", modItem.GameId);
        }

        /// <summary>
        ///     Creates and returns the backup file for the specified modded file name
        /// </summary>
        /// <param name="modItem"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string CreateBackupFilePath(ModsData.ModItem modItem, string fileName)
        {
            return Path.Combine(CreateBackupFileFolder(modItem), fileName);
        }

        /// <summary>
        ///     Adds a backup file to the collection
        /// </summary>
        /// <param name="backupFile"></param>
        public void AddBackupFile(BackupFile backupFile)
        {
            BackupFiles.Add(backupFile);
        }

        /// <summary>
        ///     Updates the collection of a backup file of index is present, or adds the backup file to the collection
        /// </summary>
        /// <param name="index"></param>
        /// <param name="backupFile"></param>
        public void UpdateBackupFile(int index, BackupFile backupFile)
        {
            if (BackupFiles[index] == null)
            {
                BackupFiles.Add(backupFile);
                return;
            }

            BackupFiles[index] = backupFile;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="customMod"></param>
        public void AddCustomMod(CustomMod customMod)
        {
            CustomMods.Add(customMod);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="index"></param>
        /// <param name="customMod"></param>
        public void UpdateCustomMod(int index, CustomMod customMod)
        {
            if (CustomMods[index] == null)
            {
                CustomMods.Add(customMod);
                return;
            }

            CustomMods[index] = customMod;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="index"></param>
        public void RemoveCustomMod(int index)
        {
            CustomMods.RemoveAt(index);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="gameRegion"></param>
        /// <param name="modId"></param>
        /// <param name="filesInstalled"></param>
        /// <param name="dateInstalled"></param>
        public void UpdateInstalledGameMod(string gameId, string gameRegion, long modId, int filesInstalled, DateTime dateInstalled)
        {
            RemoveInstalledGame(gameId);

            InstalledGameMods.Add(new GameModInstalled(gameId, gameRegion, modId, filesInstalled, dateInstalled));
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameId"></param>
        public void RemoveInstalledGame(string gameId)
        {
            _ = InstalledGameMods.RemoveAll(x => x.GameId.ToLower().Equals(gameId.ToLower()));
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="modId"></param>
        public void RemoveInstalledGameMod(string gameId, long modId)
        {
            _ = InstalledGameMods.RemoveAll(x => x.GameId.ToLower().Equals(gameId) && x.ModId.Equals(modId));
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public GameModInstalled GetInstalledGameMod(string gameId)
        {
            foreach (GameModInstalled modInstalled in InstalledGameMods)
            {
                if (modInstalled.GameId.ToLower().Equals(gameId.ToLower()))
                {
                    return modInstalled;
                }
            }

            return null;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public string GetInstalledGameModRegion(string gameId)
        {
            foreach (GameModInstalled gameMod in InstalledGameMods)
            {
                if (string.Equals(gameMod.GameId, gameId, StringComparison.CurrentCultureIgnoreCase))
                {
                    return gameMod.GameRegion;
                }
            }

            return null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ConsoleProfile
    {
        public ConsoleProfile(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return Name + " : " + Address;
        }
    }

    /// <summary>
    ///     
    /// </summary>
    public class BackupFile
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }

        public string FileName { get; set; }

        public string LocalPath { get; set; }

        public string InstallPath { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }

    /// <summary>
    ///     
    /// </summary>
    public class CustomMod
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }

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

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }

    /// <summary>
    ///     
    /// </summary>
    public class InstallFile
    {
        public InstallFile(string localPath, string consolePath)
        {
            LocalPath = localPath;
            ConsolePath = consolePath;
        }

        public string LocalPath { get; set; }

        public string ConsolePath { get; set; }
    }

    /// <summary>
    ///     
    /// </summary>
    public class GameModInstalled
    {
        public GameModInstalled(string gameId, string gameRegion, long modId, int files, DateTime dateInstalled)
        {
            GameId = gameId;
            GameRegion = gameRegion;
            ModId = modId;
            Files = files;
            DateInstalled = dateInstalled;
        }

        public string GameId { get; set; }

        public string GameRegion { get; set; }

        public long ModId { get; set; }

        public int Files { get; set; }

        public DateTime DateInstalled { get; set; } = DateTime.Now;
    }

    /// <summary>
    ///     Saved region for game id
    /// </summary>
    public class GameRegion
    {
        public GameRegion(string gameId, string region)
        {
            GameId = gameId;
            Region = region;
        }

        public string GameId { get; set; }

        public string Region { get; set; }
    }

    /// <summary>
    ///     
    /// </summary>
    public class ExternalApplication
    {
        public ExternalApplication(string name, string fileLocation)
        {
            Name = name;
            FileLocation = fileLocation;
        }

        public string Name { get; set; }

        public string FileLocation { get; set; }
    }
}