using ModioX.Database;
using ModioX.Extensions;
using ModioX.Io;
using ModioX.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModioX.Models.Resources
{
    public class SettingsData
    {
        public bool FirstTimeUse{ get; set; } = true;

        public List<ConsoleProfile> ConsoleProfiles { get; set; } = new();

        public bool FirstTimeOpenAfterUpdate { get; set; } = true;

        public List<int> DismissedAnnouncements { get; set; } = new();

        public string Language { get; set; } = "English";

        public Platform StartupLibrary { get; set; } = Platform.PS3;

        public bool UseFormattedFileSizes { get; set; } = true;

        public bool UseRelativeTimes { get; set; } = true;

        public bool EnableHardwareAcceleration { get; set; } = false;

        public bool InstallModsToUsbDevice { get; set; } = false;

        public bool InstallHomebrewToUsbDevice { get; set; } = false;

        public bool InstallResourcesToUsbDevice { get; set; } = false;

        public bool InstallPackagesToUsbDevice { get; set; } = false;

        public bool InstallGameSavesToUsbDevice { get; set; } = false;

        public bool AutoDetectGameRegions { get; set; } = false;

        public bool AutoDetectGameTitles { get; set; } = false;

        public bool ShowGamesFromExternalDevices { get; set; } = false;

        public bool RememberGameRegions { get; set; } = true;

        public bool AutoLoadDirectoryListings { get; set; } = false;

        public bool RememberLocalPath { get; set; } = false;

        public bool RememberConsolePath { get; set; } = false;

        public string LocalPathPS3 { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public string LocalPathXBOX { get; set; } = KnownFolders.GetPath(KnownFolder.Documents);

        public string ConsolePathPS3 { get; set; } = "/dev_hdd0/";

        public string ConsolePathXBOX { get; set; } = @"HDD:\";

        public string LaunchIniFilePath { get; set; } = @"Hdd:\launch.ini";

        public string PackagesInstallPath { get; set; } = "/dev_hdd0/packages/";

        public bool ShowCurrentGamePlaying { get; set; } = false;

        public List<string> FavoritePackages { get; set; } = new();

        public string DownloadsLocation { get; set; } = UserFolders.AppData;

        public List<DownloadedItem> DownloadedMods { get; set; } = new();

        public List<ImportedMod> ImportedMods { get; set; } = new();

        public List<CustomList> CustomLists { get; set; } = new();

        public List<int> FavoriteModsPS3 { get; set; } = new();

        public List<int> FavoriteModsXBOX { get; set; } = new();

        public List<int> FavoriteGameSaves { get; set; } = new();

        public void AddFavoriteForPS3(int modId)
        {
            if (!FavoriteModsPS3.Contains(modId))
            {
                FavoriteModsPS3.Add(modId);
            }
        }

        public void RemoveFavoriteForPS3(int modId)
        {
            FavoriteModsPS3.RemoveAll(x => x == modId);
        }

        public void AddFavoriteForXBOX(int modId)
        {
            if (!FavoriteModsXBOX.Contains(modId))
            {
                FavoriteModsXBOX.Add(modId);
            }
        }

        public void RemoveFavoriteForXBOX(int modId)
        {
            FavoriteModsXBOX.RemoveAll(x => x == modId);
        }

        // PS3 

        public List<GameRegion> GameRegionsPS3 { get; set; } = new();

        public List<InstalledPackageInfo> InstalledPackages { get; set; } = new();

        // Xbox 360

        public List<ListItem> GameFilesXBOX { get; set; } = new();

        public void AddFavoritePackage(string modId)
        {
            FavoritePackages.Add(modId);
        }

        public void RemoveFavoritePackage(string modId)
        {
            FavoritePackages.RemoveAll(x => x == modId);
        }

        /// <summary>
        /// Add a custom list with the specified name.
        /// </summary>
        /// <param name="name"> Custom List Name </param>
        /// <param name="platform"> Console Type </param>
        public void AddCustomList(string name, Platform platform)
        {
            CustomLists.Add(new CustomList
            {
                Platform = platform,
                Name = name
            });
        }

        /// <summary>
        /// Either update or add the custom list details.
        /// </summary>
        /// <param name="oldName"> Old list name </param>
        /// <param name="newName"> New list name </param>
        /// <param name="platform"> Console Type </param>
        public void RenameCustomList(string oldName, string newName, Platform platform)
        {
            CustomList customList = CustomLists.Find(x => x.Platform == platform && x.Name.EqualsIgnoreCase(oldName));

            switch (customList)
            {
                case null:
                    CustomLists.Add(new CustomList { Platform = platform, Name = newName });
                    break;
                default:
                    CustomLists[CustomLists.IndexOf(customList)] = new CustomList
                    {
                        Platform = platform,
                        Name = newName,
                        ModIds = customList.ModIds
                    };
                    break;
            }
        }

        /// <summary>
        /// Add modId to a custom list for the console type.
        /// </summary>
        /// <param name="name"> Custom list name </param>
        /// <param name="modId"> Mod Id to add </param>
        /// <param name="platform"> Console type </param>
        public void AddModToCustomList(string name, int modId, Platform platform)
        {
            CustomList customList = CustomLists.Find(x => x.Platform == platform && x.Name.EqualsIgnoreCase(name));

            switch (customList.ModIds.Contains(modId))
            {
                case false:
                    customList.ModIds.Add(modId);
                    break;
            }
        }

        /// <summary>
        /// Remove modId from a custom list for the console type.
        /// </summary>
        /// <param name="name"> Custom list name </param>
        /// <param name="modId"> Mod Id to remove </param>
        /// <param name="platform"> Console type </param>
        public void RemoveModFromCustomList(string name, int modId, Platform platform)
        {
            CustomList customList = CustomLists.Find(x => x.Platform == platform && x.Name.EqualsIgnoreCase(name));
            customList.ModIds.Remove(modId);
        }

        /// <summary>
        /// Gets the user's saved game region for the specified <see cref="ModsData.ModItem.GameId" />
        /// </summary>
        /// <param name="gameId"> Game Id </param>
        /// <returns> Game Region </returns>
        public string GetGameRegion(string gameId)
        {
            return GameRegionsPS3.FirstOrDefault(region => region.GameId.EqualsIgnoreCase(gameId))?.Region;
        }

        /// <summary>
        /// Either update or add the region to the specified game id
        /// </summary>
        /// <param name="gameId"> Specifies the <see cref="ModsData.ModItem.GameId" /> </param>
        /// <param name="region"> Specifies the Game Region </param>
        public void UpdateGameRegion(string gameId, string region)
        {
            int gameIdIndex =
                GameRegionsPS3.FindIndex(x => string.Equals(x.GameId, gameId, StringComparison.OrdinalIgnoreCase));

            switch (gameIdIndex)
            {
                case -1:
                    GameRegionsPS3.Add(new GameRegion() { GameId = gameId, Region = region });
                    break;
                default:
                    GameRegionsPS3[gameIdIndex].Region = region;
                    break;
            }
        }

        /// <summary>
        /// Update the installed mods.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <param name="totalFiles"> </param>
        /// <param name="dateInstalled"> </param>
        /// <param name="downloadFiles"> </param>
        public void UpdateInstalledMods(ConsoleProfile consoleProfile, string categoryId, int modId, int totalFiles, DateTime dateInstalled, DownloadFiles downloadFiles)
        {
            RemoveInstalledMods(consoleProfile, categoryId, modId);

            consoleProfile.InstalledMods.Add(new InstalledModInfo
            {
                Platform = consoleProfile.Platform,
                CategoryId = categoryId,
                ModId = modId,
                TotalFiles = totalFiles,
                DateInstalled = dateInstalled,
                DownloadFiles = downloadFiles
            });
        }

        /// <summary>
        /// Remove the installed mod matching the <see cref="ModItemData.GameId" /> and <see cref="ModsData.ModItem.Id" />
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        public void RemoveInstalledMods(ConsoleProfile consoleProfile, string categoryId, int modId)
        {
            consoleProfile.InstalledMods.RemoveAll(x => x.CategoryId.EqualsIgnoreCase(categoryId) && x.ModId.Equals(modId));
        }

        /// <summary>
        /// Get the <see cref="InstalledModInfo" /> for the <see cref="ModsData.ModItem.Id" /> if one exists.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <returns> </returns>
        public InstalledModInfo GetInstalledMods(ConsoleProfile consoleProfile, string categoryId, int modId)
        {
            return consoleProfile.InstalledMods.FirstOrDefault(x => x.CategoryId.EqualsIgnoreCase(categoryId) && x.ModId.Equals(modId));
        }

        /// <summary>
        /// Get the <see cref="InstalledModInfo" /> for the <see cref="ModsData.ModItem.Id" /> if one exists.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <returns> </returns>
        public InstalledModInfo GetInstalledMods(ConsoleProfile consoleProfile, string categoryId)
        {
            return consoleProfile.InstalledMods.FirstOrDefault(x => x.CategoryId.EqualsIgnoreCase(categoryId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modsData"> </param>
        /// <param name="modIds"> </param>
        /// <returns> </returns>
        public List<string> GetModTypesForMods(ModsData modsData, List<int> modIds)
        {
            List<string> modTypes = new();

            foreach (ModItemData modItem in modsData.Mods)
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
        public List<string> GetRegionsForMods(ModsData modsData, List<int> modIds)
        {
            List<string> regions = new();

            foreach (ModItemData modItem in modsData.Mods)
                if (modIds.Contains(modItem.Id))
                    if (!modItem.Region.Equals("ALL") || !modItem.Regions.Contains("All Regions") ||
                        !modItem.Regions.Contains("-") || !modItem.Regions.Contains("n/a") ||
                        !modItem.Regions.Contains(string.Empty))
                        switch (regions.Any(x => modItem.Regions.Any(y => y == x)))
                        {
                            case false:
                                {
                                    switch (modItem.Regions.Contains("All Regions"))
                                    {
                                        case false:
                                            {
                                                switch (modItem.Regions.Contains("n/a"))
                                                {
                                                    case false:
                                                        regions.AddRange(modItem.Regions);
                                                        break;
                                                }

                                                break;
                                            }
                                    }

                                    break;
                                }
                        }

            return regions.Distinct().ToList();
        }

        /// <summary>
        /// Get the <see cref="InstalledModInfo" /> for the <see cref="PackageItemData" /> if one exists.
        /// </summary>
        /// <param name="platform"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <returns> </returns>
        public InstalledPackageInfo GetInstalledPackage(PackageItemData package)
        {
            return InstalledPackages.FirstOrDefault(x => x.Category.Equals(package.Category) && x.Url.Equals(package.Url));
        }

        /// <summary>
        /// Remove the installed mod matching the <see cref="ModItemData.GameId" /> and <see cref="ModsData.ModItem.Id" />
        /// </summary>
        /// <param name="platform"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        public void RemoveInstalledPackage(PackageItemData package)
        {
            InstalledPackages.RemoveAll(x => x.Category.Equals(package.Category) && x.Url.Equals(package.Url));
        }

        /// <summary>
        /// Update the installed mods.
        /// </summary>
        /// <param name="package"> </param>
        /// <param name="dateInstalled"> </param>
        public void UpdateInstalledPackage(PackageItemData package, string localFilePath, DateTime dateInstalled)
        {
            RemoveInstalledPackage(package);

            InstalledPackages.Add(new InstalledPackageInfo
            {
                Category = package.Category,
                Name = package.Name,
                TitleId = package.TitleId,
                Region = package.Region,
                Url = package.Url,
                LocalFile = localFilePath,
                DateTime = dateInstalled
            });
        }

        /// <summary>
        /// Get the custom list matching the specified name.
        /// </summary>
        /// <param name="name"> </param>
        /// <param name="platform"> </param>
        /// <returns> </returns>
        public CustomList GetCustomListByName(string name, Platform platform)
        {
            foreach (CustomList customList in from CustomList customList in CustomLists.FindAll(x => x.Platform == platform)
                                              where customList.Name.EqualsIgnoreCase(name)
                                              select customList)
            {
                return customList;
            }

            return null;
        }
    }

    /// <summary>
    /// Create a console profile class with the details.
    /// </summary>
    public class ConsoleProfile
    {
        public int? Id { get; set; } = null;

        public string Name { get; set; }

        public Platform Platform { get; set; } = Platform.PS3;

        public PlatformType PlatformType { get; set; } = PlatformType.PlayStation3Fat;

        public string Address { get; set; }

        public int Port { get; set; } = 21;

        public string Username { get; set; }

        public string Password { get; set; }

        public bool UseDefaultCredentials { get; set; } = true;

        public bool UseDefaultConsole { get; set; } = false;

        public List<InstalledModInfo> InstalledMods { get; set; } = new();

        /// <summary>
        /// Get the profile as format: Name (Address)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} ({Address})";
        }
    }

    /// <summary>
    /// Create a new installed mod class with the details.
    /// </summary>
    public class InstalledModInfo
    {
        public Platform Platform { get; set; }

        public string CategoryId { get; set; }

        public int ModId { get; set; }

        public int TotalFiles { get; set; }

        public DateTime DateInstalled { get; set; }

        public DownloadFiles DownloadFiles { get; set; }
    }

    public class ImportedMod
    {
        public string Type { get; set; }

        public Platform Platform { get; set; } = Platform.PS3;

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public string SystemType { get; set; }

        public string ModType { get; set; }

        public string Version { get; set; }

        public string Creator { get; set; }

        public List<InstallItem> Files { get; set; }
    }

    /// <summary>
    /// Create a new game region class with the specified <see cref="CategoriesData.Category.Id" />
    /// and <see cref="ModsData.ModItem.Region" />.
    /// </summary>
    public class GameRegion
    {
        public string GameId { get; set; }

        public string Region { get; set; }
    }

    public class InstalledPackageInfo
    {
        public string Category { get; set; }

        public string Name { get; set; }

        public string TitleId { get; set; }

        public string Region { get; set; }

        public string Url { get; set; }

        public string LocalFile { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Create a new custom list class with the specified details.
    /// </summary>
    public class CustomList
    {
        public Platform Platform { get; set; } = Platform.PS3;

        public string Name { get; set; }

        public List<int> ModIds { get; set; } = new();
    }

    public class DownloadedItem
    {
        public string Type { get; set; }

        public Platform Platform { get; set; } = Platform.PS3;

        public int ModId { get; set; }

        public string CategoryId { get; set; }

        public string FilePath { get; set; }

        public DownloadFiles DownloadFile { get; set; }

        public DateTime DateTime { get; set; }
    }
}