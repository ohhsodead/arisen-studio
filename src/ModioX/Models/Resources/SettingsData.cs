using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Models.Database;

namespace ModioX.Models.Resources
{
    public class SettingsData
    {
        public bool FirstTimeUse { get; set; } = true;

        public bool FirstTimeOpenAfterUpdate { get; set; } = true;

        public bool SaveSkinOnClose { get; set; } = true;

        public string SkinName { get; set; } = "Office 2019 Black";

        public bool ShowFileSizeInBytes { get; set; } = true;

        public Color HexBoxForeColor { get; set; } = Color.Green;

        public Color HexBoxBackColor { get; set; } = Color.FromArgb(54, 54, 54);

        public List<ConsoleProfile> ConsoleProfiles { get; set; } = new();

        public ConsoleTypePrefix LoadConsoleMods { get; set; } = ConsoleTypePrefix.PS3;

        public bool AutoDetectGameRegions { get; set; } = false;

        public bool AutoDetectGameTitles { get; set; } = true;

        public bool RememberGameRegions { get; set; } = false;

        public bool SaveLocalPath { get; set; } = false;

        public string LocalPathPS3 { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public string LocalPathXBOX { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public bool SaveConsolePath { get; set; } = false;

        public string ConsolePathPS3 { get; set; } = "/dev_hdd0/";

        public string ConsolePathXBOX { get; set; } = "/Hdd/";

        public string LaunchIniFilePath { get; set; } = "/Hdd1/launch.ini";

        public List<int> FavoritedIds { get; set; } = new();

        public List<BackupFile> BackupFiles { get; set; } = new();

        public List<GameRegion> GameRegions { get; set; } = new();

        public List<ExternalApplication> ExternalApplications { get; set; } = new();

        public List<CustomList> CustomLists { get; set; } = new();

        public List<InstalledMod> InstalledGameMods { get; set; } = new();

        public List<PackageFile> InstalledPackageFiles { get; set; } = new();

        /// <summary>
        /// Create/store a backup of the specified file, and then downloads it locally to a known path
        /// </summary>
        /// <param name="modItem"> </param>
        /// <param name="fileName"> </param>
        /// <param name="installFilePath"> </param>
        public void CreateBackupFile(ModItem modItem, string fileName, string installFilePath)
        {
            var fileBackupFolder = GetGameBackupFolder(modItem);

            Directory.CreateDirectory(fileBackupFolder);

            var backupFile = new BackupFile
            {
                CategoryId = modItem.GameId,
                FileName = fileName,
                LocalPath = Path.Combine(fileBackupFolder, fileName),
                InstallPath = installFilePath
            };

            FtpExtensions.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);

            BackupFiles.Add(backupFile);
        }

        /// <summary>
        /// Gets the <see cref="BackupFile" /> information for the specified game id, file name and
        /// install path
        /// </summary>
        /// <param name="gameId"> Game Id </param>
        /// <param name="fileName"> File Name </param>
        /// <param name="installPath"> File Install Path </param>
        /// <returns> </returns>
        public BackupFile GetGameFileBackup(string gameId, string fileName, string installPath)
        {
            return BackupFiles.FirstOrDefault(backupFile =>
            backupFile.CategoryId.Equals(gameId, StringComparison.OrdinalIgnoreCase)
            && backupFile.FileName.ToLower().Contains(fileName.ToLower())
            && backupFile.InstallPath.ToLower().Contains(installPath.ToLower()));
        }

        /// <summary>
        /// Gets the external applications file location for the specified application name.
        /// </summary>
        /// <param name="appName"> Application name with extension. </param>
        /// <returns> Game Region </returns>
        public string GetApplicationLocation(string appName)
        {
            return ExternalApplications.FirstOrDefault(app => app.Name.Equals(appName, StringComparison.OrdinalIgnoreCase))?.FileLocation;
        }

        /// <summary>
        /// Either update or add the application name and file location.
        /// </summary>
        /// <param name="appName"> Application Name </param>
        /// <param name="fileLocation"> Application File Location </param>
        public void UpdateApplication(string appName, string fileLocation)
        {
            var applicationIndex = ExternalApplications.Find(x => string.Equals(x.Name, appName, StringComparison.OrdinalIgnoreCase));

            var externalApplication = new ExternalApplication(appName, fileLocation);

            if (applicationIndex == null)
            {
                ExternalApplications.Add(externalApplication);
            }
            else
            {
                ExternalApplications[ExternalApplications.IndexOf(applicationIndex)] = externalApplication;
            }
        }

        /// <summary>
        /// Add a custom list with the specified name.
        /// </summary>
        /// <param name="name"> Custom list name </param>
        public void AddCustomList(string name)
        {
            CustomLists.Add(new CustomList { Name = name });
        }

        /// <summary>
        /// Either update or add the custom list details.
        /// </summary>
        /// <param name="listName"> Custom list name </param>
        /// <param name="newListName"> Mod Id to add to list </param>
        public void RenameCustomList(string oldName, string newName)
        {
            var customList = CustomLists.Find(x => string.Equals(x.Name, oldName, StringComparison.OrdinalIgnoreCase));

            if (customList == null)
            {
                CustomLists.Add(new CustomList { Name = newName });
            }
            else
            {
                CustomLists[CustomLists.IndexOf(customList)] = new CustomList { Name = newName, ModIds = customList.ModIds };
            }
        }

        /// <summary>
        /// Either update or add the custom list details.
        /// </summary>
        /// <param name="listName"> Custom list name </param>
        /// <param name="newListName"> Mod Id to add to list </param>
        public void AddModToCustomList(string name, int modId)
        {
            var customList = CustomLists.Find(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));

            if (!customList.ModIds.Contains(modId))
            {
                customList.ModIds.Add(modId);
            }
        }

        /// <summary>
        /// Either update or add the custom list details.
        /// </summary>
        /// <param name="listName"> Custom list name </param>
        /// <param name="modId"> Mod Id to add to list </param>
        public void RemoveModFromCustomList(string name, int modId)
        {
            var customList = CustomLists.Find(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
            customList.ModIds.Remove(modId);
        }

        /// <summary>
        /// Gets the user's saved game region for the specified <see cref="ModsData.ModItem.GameId" />
        /// </summary>
        /// <param name="gameId"> Game Id </param>
        /// <returns> Game Region </returns>
        public string GetGameRegion(string gameId)
        {
            return GameRegions.FirstOrDefault(region => region.GameId.Equals(gameId, StringComparison.OrdinalIgnoreCase))?.Region;
        }

        /// <summary>
        /// Either update or add the region to the specified game id
        /// </summary>
        /// <param name="gameId"> Specifies the <see cref="ModsData.ModItem.GameId" /> </param>
        /// <param name="region"> Specifies the Game Region </param>
        public void UpdateGameRegion(string gameId, string region)
        {
            var gameIdIndex = GameRegions.FindIndex(x => string.Equals(x.GameId, gameId, StringComparison.OrdinalIgnoreCase));

            if (gameIdIndex == -1)
            {
                GameRegions.Add(new GameRegion(gameId, region));
            }
            else
            {
                GameRegions[gameIdIndex].Region = region;
            }
        }

        /// <summary>
        /// Creates and returns the games backup folder for the specified <see
        /// cref="ModsData.ModItem" />.
        /// </summary>
        /// <param name="modItem"> </param>
        /// <returns> </returns>
        public static string GetGameBackupFolder(ModItem modItem)
        {
            return Path.Combine(UserFolders.AppBackupFilesDirectory, modItem.GameId);
        }

        /// <summary>
        /// Updates the collection of backup files at index if it's exists, otherwise adds a new one.
        /// </summary>
        /// <param name="index"> </param>
        /// <param name="backupFile"> </param>
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
        /// Update the installed game mods.
        /// </summary>
        /// <param name="consoleType"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <param name="region"> </param>
        /// <param name="noOfFiles"> </param>
        /// <param name="dateInstalled"> </param>
        /// <param name="downloadFiles"> </param>
        public void UpdateInstalledGameMod(ConsoleTypePrefix consoleType, string categoryId, int modId, string region, int noOfFiles, DateTime dateInstalled, DownloadFiles downloadFiles)
        {
            RemoveInstalledGameMod(consoleType, categoryId);

            InstalledGameMods.Add(new InstalledMod
            {
                ConsoleType = consoleType,
                CategoryId = categoryId,
                ModId = modId,
                Region = region,
                Files = noOfFiles,
                DateInstalled = dateInstalled,
                DownloadFiles = downloadFiles
            });
        }

        /// <summary>
        /// Remove the installed mods matching the <see cref="ModsData.ModItem.GameId" />
        /// </summary>
        /// <param name="categoryId"> </param>
        public void RemoveInstalledGameMod(ConsoleTypePrefix consoleType, string categoryId)
        {
            InstalledGameMods.RemoveAll(x => x.ConsoleType == consoleType && string.Equals(x.CategoryId, categoryId, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Remove the installed game mod matching the <see cref="ModsData.ModItem.GameId" /> and
        /// <see cref="ModsData.ModItem.Id" />
        /// </summary>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        public void RemoveInstalledGameMod(ConsoleTypePrefix consoleType, string categoryId, int modId)
        {
            InstalledGameMods.RemoveAll(x => x.ConsoleType == consoleType && string.Equals(x.CategoryId, categoryId, StringComparison.OrdinalIgnoreCase) && x.ModId.Equals(modId));
        }

        /// <summary>
        /// Get the current <see cref="InstalledGameMod" /> the <see cref="ModsData.ModItem.Id" />
        /// </summary>
        /// <param name="categoryId"> </param>
        /// <returns> </returns>
        public InstalledMod GetInstalledGameMod(ConsoleTypePrefix consoleType, string categoryId)
        {
            return InstalledGameMods.FirstOrDefault(x => x.ConsoleType == consoleType && x.CategoryId.Equals(categoryId, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// </summary>
        /// <param name="modsData"> </param>
        /// <param name="modIds"> </param>
        /// <returns> </returns>
        public List<string> GetModTypesForModIDs(ModsData modsData, List<int> modIds)
        {
            var modTypes = new List<string>();

            foreach (var modItem in modsData.Mods)
            {
                if (modIds.Contains(modItem.Id))
                {
                    modTypes.AddRange(modItem.ModTypes);
                }
            }

            return modTypes.Distinct().ToList();
        }

        /// <summary>
        /// </summary>
        /// <param name="modsData"> </param>
        /// <param name="modIds"> </param>
        /// <returns> </returns>
        public List<string> GetRegionsForModIDs(ModsData modsData, List<int> modIds)
        {
            var regions = new List<string>();

            foreach (var modItem in modsData.Mods)
            {
                if (modIds.Contains(modItem.Id))
                {
                    if (!modItem.Region.Equals("ALL") || !modItem.GameRegions.Contains("All Regions") || !modItem.GameRegions.Contains("-") || !modItem.GameRegions.Contains("n/a") || !modItem.GameRegions.Contains(""))
                    {
                        if (!regions.Any(x => modItem.GameRegions.Any(y => y == x)))
                        {
                            if (!modItem.GameRegions.Contains("All Regions"))
                            {
                                if (!modItem.GameRegions.Contains("n/a"))
                                {
                                    regions.AddRange(modItem.GameRegions);
                                }
                            }
                        }
                    }
                }
            }

            return regions.Distinct().ToList();
        }

        /// <summary>
        /// Get the custom list matching the specified name.
        /// </summary>
        /// <param name="name"> </param>
        /// <returns> </returns>
        public CustomList GetCustomListByName(string name)
        {
            foreach (var customList in from CustomList customList in CustomLists
                                       where string.Equals(customList.Name, name, StringComparison.OrdinalIgnoreCase)
                                       select customList)
            {
                return customList;
            }

            return null;
        }

        /// <summary>
        /// Update the installed package file details.
        /// </summary>
        /// <param name="id"> </param>
        /// <param name="name"> </param>
        /// <param name="version"> </param>
        /// <param name="downloadFiles"> </param>
        public void UpdateInstalledPackageFile(int id, string name, string version, DownloadFiles downloadFiles)
        {
            InstalledPackageFiles.Remove(InstalledPackageFiles.First(x => x.Id.Equals(id)));

            InstalledPackageFiles.Add(new PackageFile
            {
                Id = id,
                Name = name,
                Version = version,
                DownloadFiles = downloadFiles
            });
        }

        /// <summary>
        /// Get the installed package file matching the specified modId.
        /// </summary>
        /// <param name="modId"> </param>
        /// <returns> </returns>
        public PackageFile GetInstalledPackageFile(string name)
        {
            return InstalledPackageFiles.FirstOrDefault(x => x.Name.Equals(name)) ?? null;
        }

        /// <summary>
        /// Determines whether a installed package file is out of date by checking current package
        /// files in the database.
        /// </summary>
        /// <param name="modsData"> </param>
        /// <param name="categoriesData"> </param>
        /// <param name="packageFile"> </param>
        /// <returns> </returns>
        public bool IsPackageFileOldVersion(ModsData modsData, CategoriesData categoriesData, PackageFile packageFile)
        {
            foreach (var modItem in modsData.Mods)
            {
                if (modItem.GetCategoryType(categoriesData) == CategoryType.Homebrew)
                {
                    if (packageFile.Id.Equals(modItem.Id))
                    {
                        try
                        {
                            var oldVersion = Version.Parse(packageFile.Version);
                            var newVersion = Version.Parse(modItem.Version);

                            if (oldVersion.CompareTo(newVersion) < 0)
                            {
                                return true;
                            }
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }
    }

    /// <summary>
    /// Create a console profile class with the details.
    /// </summary>
    public class ConsoleProfile
    {
        public string Name { get; set; }

        public ConsoleType Type { get; set; } = ConsoleType.PlayStation3Fat;

        public ConsoleTypePrefix TypePrefix { get; set; } = ConsoleTypePrefix.PS3;

        public string Address { get; set; }

        public int Port { get; set; } = 21;

        public string Username { get; set; }

        public string Password { get; set; }

        public bool UseDefaultCredentials { get; set; } = true;

        public override string ToString()
        {
            return $"{Name} ({Address})";
        }
    }

    /// <summary>
    /// Determines the type of console.
    /// </summary>
    public enum ConsoleType
    {
        [Description("PlayStation 3 (Fat)")]
        PlayStation3Fat,

        [Description("PlayStation 3 (Slim)")]
        PlayStation3Slim,

        [Description("PlayStation 3 (Super Slim)")]
        PlayStation3SuperSlim,

        [Description("Xbox 360 (Fat/White)")]
        Xbox360FatWhite,

        [Description("Xbox 360 Elite (Fat/Black)")]
        Xbox360EliteFatBlack,

        [Description("Xbox 360 S (Slim)")]
        Xbox360Slim,

        [Description("Xbox 360 E (Slim E)")]
        Xbox360SlimE
    }

    /// <summary>
    /// Determines the prefix for the type of console.
    /// </summary>
    public enum ConsoleTypePrefix
    {
        [Description("PlayStation 3")]
        PS3,

        [Description("Xbox 360")]
        XBOX
    }

    /// <summary>
    /// Create a backup file class with the details.
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
    /// Create a new installed mod class with the details.
    /// </summary>
    public class InstalledMod
    {
        public ConsoleTypePrefix ConsoleType { get; set; } = ConsoleTypePrefix.PS3;

        public string CategoryId { get; set; }

        public int ModId { get; set; }

        public string Region { get; set; }

        public int Files { get; set; }

        public DateTime DateInstalled { get; set; }

        public DownloadFiles DownloadFiles { get; set; }
    }

    /// <summary>
    /// Create a new installed mod class with the details.
    /// </summary>
    public class PackageFile
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public DownloadFiles DownloadFiles { get; set; }
    }

    /// <summary>
    /// Create a new game region class with the specified <see cref="CategoriesData.Category.Id" />
    /// and <see cref="ModsData.ModItem.Region" />.
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
    /// Create a new custom list class with the specified details.
    /// </summary>
    public class CustomList
    {
        public ConsoleTypePrefix ConsoleType { get; set; } = ConsoleTypePrefix.PS3;

        public string Name { get; set; }

        public List<int> ModIds { get; set; } = new();
    }

    /// <summary>
    /// Create a new external application class with the specified name and file location.
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