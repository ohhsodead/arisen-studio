using ModioX.Extensions;
using ModioX.Io;
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
        public static readonly string SettingsDataFile = $@"{UserFolders.AppData}\SettingsData.json";

        public bool FirstTimeUse { get; set; } = true;

        public bool FirstTimeOpenAfterUpdate { get; set; } = true;

        public List<ConsoleProfile> ConsoleProfiles { get; set; } = new List<ConsoleProfile>();

        public bool ShowModIds { get; set; } = false;

        public bool RememberGameRegions { get; set; } = false;

        public bool AutoDetectGameRegion { get; set; } = false;

        public bool SaveLocalPath { get; set; } = false;

        public string LocalPath { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public bool SaveConsolePath { get; set; } = false;

        public string ConsolePath { get; set; } = "/dev_hdd0/";

        public bool AlwaysDownloadInstallFiles { get; set; } = false;

        public List<string> FavoritedIds { get; set; } = new List<string>();

        public List<BackupFile> BackupFiles { get; set; } = new List<BackupFile>();

        public List<GameRegion> GameRegions { get; set; } = new List<GameRegion>();

        public List<ExternalApplication> ExternalApplications { get; set; } = new List<ExternalApplication>();

        public List<InstalledGameMod> InstalledGameMods { get; set; } = new List<InstalledGameMod>();

        /// <summary>
        ///     Create/store a backup of the specified file, and then downloads it locally to a known path
        /// </summary>
        /// <param name="settingsData"></param>
        /// <param name="modItem"></param>
        /// <param name="fileName"></param>
        /// <param name="installFilePath"></param>
        public void CreateBackupFile(ModsData.ModItem modItem, string fileName, string installFilePath)
        {
            string fileBackupFolder = GetBackupFileFolder(modItem);

            _ = Directory.CreateDirectory(fileBackupFolder);

            BackupFile backupFile = new BackupFile()
            {
                CategoryId = modItem.GameId,
                FileName = fileName,
                LocalPath = Path.Combine(fileBackupFolder, fileName),
                InstallPath = installFilePath
            };

            BackupFiles.Add(backupFile);

            FtpExtensions.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
        }

        /// <summary>
        ///     Gets the <see cref="BackupFile"/> information for the specified game id, file name and install path
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
        ///     Gets the users external applications file location for the specified application name
        /// </summary>
        /// <param name="appName">Application name with extension.</param>
        /// <returns>Game Region</returns>
        public string GetApplicationLocation(string appName)
        {
            foreach (ExternalApplication application in from ExternalApplication application in ExternalApplications
                                                        where string.Equals(application.Name, appName, StringComparison.CurrentCultureIgnoreCase)
                                                        select application)
            {
                return application.FileLocation;
            }

            return null;
        }

        /// <summary>
        ///     Either update or add the application name and file location
        /// </summary>
        /// <param name="appName">Application Name</param>
        /// <param name="fileLocation">Application File Location</param>
        public void UpdateApplication(string appName, string fileLocation)
        {
            ExternalApplication applicationIndex = ExternalApplications.Find(x => string.Equals(x.Name, appName, StringComparison.CurrentCultureIgnoreCase));

            ExternalApplication externalApplcation = new ExternalApplication(appName, fileLocation);

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
        ///     Gets the user's saved game region for the specified <see cref="ModsData.ModItem.GameId"/>
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
        /// <param name="gameId">Specifies the <see cref="ModsData.ModItem.GameId"/></param>
        /// <param name="region">Specifies the Game Region</param>
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
        ///     Creates and returns the backup folder for the specified <see cref="ModsData.ModItem"/>.
        /// </summary>
        /// <param name="modItem"></param>
        /// <returns></returns>
        public static string GetBackupFileFolder(ModsData.ModItem modItem)
        {
            return Path.Combine(UserFolders.AppGameBackupFiles, modItem.GameId);
        }

        /// <summary>
        ///     Updates the collection of backup files at index if it's exists, otherwise adds a new one.
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
        ///     Updates the installed game mods.
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="gameRegion"></param>
        /// <param name="modId"></param>
        /// <param name="filesInstalled"></param>
        /// <param name="dateInstalled"></param>
        public void UpdateInstalledGameMod(string gameId, string gameRegion, long modId, int noOfFiles, DateTime dateInstalled)
        {
            RemoveInstalledGame(gameId);

            InstalledGameMods.Add(new InstalledGameMod() { GameId = gameId, GameRegion = gameRegion, ModId = modId, Files = noOfFiles, DateInstalled = dateInstalled });
        }

        /// <summary>
        ///     Removes the installed mods matching the <see cref="ModsData.ModItem.GameId"/>
        /// </summary>
        /// <param name="gameId"></param>
        public void RemoveInstalledGame(string gameId)
        {
            _ = InstalledGameMods.RemoveAll(x => string.Equals(x.GameId, gameId, StringComparison.CurrentCultureIgnoreCase));
        }

        /// <summary>
        ///     Removes the installed game mod matching the <see cref="ModsData.ModItem.GameId"/> and <see cref="ModsData.ModItem.Id"/>
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="modId"></param>
        public void RemoveInstalledGameMod(string gameId, long modId)
        {
            _ = InstalledGameMods.RemoveAll(x => string.Equals(x.GameId.ToLower(), gameId) && x.ModId.Equals(modId));
        }

        /// <summary>
        ///     Gets the current <see cref="InstalledGameMod"/> the <see cref="ModsData.ModItem.GameId"/>
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public InstalledGameMod GetInstalledGameMod(string gameId)
        {
            foreach (InstalledGameMod modInstalled in InstalledGameMods)
            {
                if (string.Equals(modInstalled.GameId, gameId, StringComparison.CurrentCultureIgnoreCase))
                {
                    return modInstalled;
                }
            }

            return null;
        }

        /// <summary>
        ///     Returns the game region of which the mod was used to installed to game matching the <see cref="ModsData.ModItem.GameId"/>.
        /// </summary>
        /// <param name="gameId"><see cref="CategoriesData.Category.Id"/> to match with the <see cref="InstalledGameMod"/></param>
        /// <returns></returns>
        public string GetInstalledGameModRegion(string gameId)
        {
            foreach (InstalledGameMod gameMod in InstalledGameMods)
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
    ///     Create a console profile class with the details.
    /// </summary>
    public class ConsoleProfile
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Port { get; set; } = 21;

        public string Username { get; set; }

        public string Password { get; set; }

        public bool UseDefaultCredentials { get; set; } = true;

        public override string ToString()
        {
            return Name + " : " + Address;
        }
    }

    /// <summary>
    ///     Create a backup file class with the details.
    /// </summary>
    public class BackupFile
    {
        public string CategoryId { get; set; }

        public string FileName { get; set; }

        public string LocalPath { get; set; }

        public string InstallPath { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }

    /// <summary>
    ///     Create a new installed game mod class with the details.
    /// </summary>
    public class InstalledGameMod
    {
        public string GameId { get; set; }

        public string GameRegion { get; set; }

        public long ModId { get; set; }

        public int Files { get; set; }

        public DateTime DateInstalled { get; set; }
    }

    /// <summary>
    ///     Create a new game region class with the specified <see cref="CategoriesData.Category.Id"/> and <see cref="ModsData.ModItem.Region"/>.
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
    ///     Create a new external application class with the specified name and file location.
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