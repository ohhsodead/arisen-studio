using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace ArisenStudio.Models.Resources
{
    public class SettingsData
    {
        public FormWindowState WindowState { get; set; } = FormWindowState.Normal;

        public List<ConsoleProfile> ConsoleProfiles { get; set; } = [];

        public List<CustomItemData> CustomMods { get; set; } = [];

        public bool FirstTimeUse { get; set; } = true;

        public bool FirstTimeOpenAfterUpdate { get; set; } = true;

        public List<int> DismissedAnnouncements { get; set; } = [];

        public string Language { get; set; } = "English";

        public bool UseFormattedFileSizes { get; set; } = true;

        public bool UseRelativeTimes { get; set; } = true;

        public bool AlwaysShowCurrentGamePlaying { get; set; } = false;

        public bool AutoDetectGameRegions { get; set; } = false;

        public bool AutoDetectGameTitles { get; set; } = false;

        public bool ShowGamesFromExternalDevices { get; set; } = false;

        public bool AutoLoadDirectoryListings { get; set; } = false;

        public bool RememberLocalPath { get; set; } = false;

        public bool RememberConsolePath { get; set; } = false;

        public string LocalPathPs3 { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public string LocalPathXbox { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public string ConsolePathPs3 { get; set; } = "/dev_hdd0/";

        public string ConsolePathXbox { get; set; } = @"HDD:\";

        public List<DownloadedItem> DownloadedMods { get; set; } = [];

        // Transfer

        public bool InstallGameModsPluginsToUsbDevice { get; set; } = false;

        public bool InstallHomebrewToUsbDevice { get; set; } = false;

        public bool InstallResourcesToUsbDevice { get; set; } = false;

        public bool InstallPackagesToUsbDevice { get; set; } = false;

        public bool InstallApplicationsToUsbDevice { get; set; } = false;

        public bool InstallGameSavesToUsbDevice { get; set; } = false;

        public bool RememberGameRegions { get; set; } = true;

        public bool CleanUpLocalFilesAfterInstalling { get; set; } = false;

        public bool AlwaysBackupGameFiles { get; set; } = true;

        // Tools

        public string LaunchIniFilePath { get; set; } = @"Hdd:\launch.ini";

        public string BootPluginsFilePath { get; set; } = @"/dev_hdd0/boot_plugins.txt";

        public string PackageInstallPathPS3 { get; set; } = "/dev_hdd0/packages/";

        public string PackageInstallPathPS4 { get; set; } = "/data/pkg/{TitleId}/{Name}-{Version}.pkg";

        // Discord

        public bool AlwaysShowPresence { get; set; } = false;

        public bool ShowCurrentGamePlaying { get; set; } = false;

        // Paths

        public string PathBaseDirectory { get; set; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Arisen Studio\";

        public string PathDownloads { get; set; } = @"%BASE_DIR%\Downloads\";

        public string PathGameMods { get; set; } = @"%BASE_DIR%\Game Mods\";

        public string PathHomebrew { get; set; } = @"%BASE_DIR%\Homebrew\";

        public string PathResources { get; set; } = @"%BASE_DIR%\Resources\";

        public string PathPackages { get; set; } = @"%BASE_DIR%\Packages\";

        public string PathPlugins { get; set; } = @"%BASE_DIR%\Plugins\";

        public string PathGameSaves { get; set; } = @"%BASE_DIR%\Game Saves\";

        public string GetFullPath(string path)
        {
            return path.Replace(@"%BASE_DIR%", PathBaseDirectory);
        }

        // Custom Mods

        public List<CustomItemData> GetCustomMods(CategoriesData categoriesData, string platform, string category, string name, string modType, string version)
        {
            return CustomMods.Where(x =>
                    x.Platform.Humanize().Equals(platform) &&
                    x.Category.ContainsIgnoreCaseSymbols(category) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    //x.Region.ContainsIgnoreCase(region) &&
                    x.Version.EqualsIgnoreCase(version))
                    .ToList();
        }

        public CustomItemData GetCustomMod(int modId)
        {
            return CustomMods.Find(x => x.Id.Equals(modId));
        }

        // Favorites

        public List<FavoriteItem> FavoriteMods { get; set; } = [];

        public void AddRemoveFavoriteModItem(FavoriteItem favoriteItem)
        {
            if (FavoriteMods.Contains(favoriteItem))
            {
                FavoriteMods.RemoveAll(x => x == favoriteItem);
            }
            else
            {
                FavoriteMods.Add(favoriteItem);
            }
        }

        public FavoriteItem CreateFavoriteItem(CategoriesData categoriesData, ModItemData modItem)
        {
            return new() { CategoryType = modItem.GetCategoryType(categoriesData), CategoryId = modItem.CategoryId, ModId = modItem.Id, Platform = modItem.GetPlatform() };
        }

        public List<FavoriteItem> FavoriteGameSaves { get; set; } = [];

        public void AddRemoveGameSaveItem(FavoriteItem favoriteItem)
        {
            if (FavoriteGameSaves.Contains(favoriteItem))
            {
                FavoriteGameSaves.RemoveAll(x => x == favoriteItem);
            }
            else
            {
                FavoriteGameSaves.Add(favoriteItem);
            }
        }

        public FavoriteItem CreateFavoriteGameSaveItem(CategoriesData categoriesData, GameSaveItemData saveGameItem)
        {
            return new() { CategoryType = categoriesData.GetCategoryById(saveGameItem.CategoryId).CategoryType, CategoryId = saveGameItem.CategoryId, ModId = saveGameItem.Id, Platform = saveGameItem.GetPlatform() };
        }

        // PS3

        public List<GameRegion> GameRegionsPs3 { get; set; } = [];

        public List<InstalledPackageInfo> InstalledPackages { get; set; } = [];

        // Xbox 360

        public List<ListItem> GameFilesXbox { get; set; } = [];

        /// <summary>
        /// Gets the user's saved game region for the specified <see cref="ModsData.ModItem.GameId" />
        /// </summary>
        /// <param name="gameId"> Game Id </param>
        /// <returns> Game Region </returns>
        public string GetGameRegion(string gameId)
        {
            return GameRegionsPs3.FirstOrDefault(region => region.GameId.EqualsIgnoreCase(gameId))?.Region;
        }

        /// <summary>
        /// Either update or add the region to the specified game id
        /// </summary>
        /// <param name="gameId"> Specifies the <see cref="ModsData.ModItem.GameId" /> </param>
        /// <param name="region"> Specifies the Game Region </param>
        public void UpdateGameRegion(string gameId, string region)
        {
            int gameIdIndex =
                GameRegionsPs3.FindIndex(x => string.Equals(x.GameId, gameId, StringComparison.OrdinalIgnoreCase));

            switch (gameIdIndex)
            {
                case -1:
                    GameRegionsPs3.Add(new GameRegion() { GameId = gameId, Region = region });
                    break;
                default:
                    GameRegionsPs3[gameIdIndex].Region = region;
                    break;
            }
        }

        /// <summary>
        /// Update the list of installed mods.
        /// </summary>
        /// <param name="consoleProfile"></param>
        /// <param name="categoryId"></param>
        /// <param name="modId"></param>
        /// <param name="totalFiles"></param>
        /// <param name="dateInstalled"></param>
        /// <param name="downloadFiles"></param>
        /// <param name="isCustom"></param>
        public void UpdateInstalledMods(ConsoleProfile consoleProfile, string categoryId, CategoryType categoryType, int modId, int totalFiles, DateTime dateInstalled, DownloadFiles downloadFiles, bool isCustom = false)
        {
            if (consoleProfile != null)
            {
                RemoveInstalledMods(consoleProfile, categoryId, modId, isCustom);

                consoleProfile.InstalledMods.Add(new InstalledModInfo
                {
                    Platform = consoleProfile.Platform,
                    CategoryId = categoryId,
                    CategoryType = categoryType,
                    ModId = modId,
                    TotalFiles = totalFiles,
                    DateInstalled = dateInstalled,
                    DownloadFiles = downloadFiles,
                    IsCustom = isCustom
                });
            }
        }

        /// <summary>
        /// Remove the installed mod matching the <see cref="ModItemData.GameId" /> and <see cref="ModsData.ModItem.Id" />
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <param name="isCustom"> </param>
        public void RemoveInstalledMods(ConsoleProfile consoleProfile, string categoryId, int modId, bool isCustom)
        {
            consoleProfile.InstalledMods.RemoveAll(x => x.CategoryId.EqualsIgnoreCase(categoryId) && x.ModId.Equals(modId) && x.IsCustom == isCustom);
        }

        /// <summary>
        /// Get the <see cref="InstalledModInfo" /> for the <see cref="ModsData.ModItem.Id" /> if one exists.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <param name="isCustom"> </param>
        /// <returns> </returns>
        public InstalledModInfo GetInstalledMods(ConsoleProfile consoleProfile, string categoryId, int modId, bool isCustom)
        {
            return consoleProfile.InstalledMods.FirstOrDefault(x => x.CategoryId.EqualsIgnoreCase(categoryId) && x.ModId.Equals(modId) && x.IsCustom == isCustom);
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
        /// Get the <see cref="InstalledModInfo" /> for the <see cref="ModsData.ModItem.Id" /> if one exists.
        /// </summary>
        /// <param name="consoleProfile"> </param>
        /// <param name="categoryId"> </param>
        /// <param name="modId"> </param>
        /// <param name="isCustom"> </param>
        /// <returns> </returns>
        public InstalledModInfo GetInstalledMods(ConsoleProfile consoleProfile, CategoryType categoryType, int modId)
        {
            return consoleProfile.InstalledMods.FirstOrDefault(x => x.CategoryType.Equals(categoryType) && x.ModId.Equals(modId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modsData"> </param>
        /// <param name="modIds"> </param>
        /// <returns> </returns>
        public List<string> GetModTypesForMods(ModsData modsData, List<int> modIds)
        {
            List<string> modTypes = [];

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

        public ConsoleProfile CreateDefaultProfile(Platform? platform = null)
        {
            ConsoleProfile consoleProfile;

            if (!platform.HasValue)
            {
                PlatformType platformType;

                if (platform.Value == Platform.PS3)
                {
                    platformType = PlatformType.PlayStation3Fat;
                }
                else if(platform.Value == Platform.PS4)
                {
                    platformType = PlatformType.PlayStation4;
                }
                else
                {
                    platformType = PlatformType.Xbox360FatWhite;
                }

                consoleProfile = new()
                {
                    Id = DataExtensions.GenerateUniqueId(),
                    Platform = platform.Value,
                    PlatformType = platformType,
                    Name = "Default Profile",
                    IsDefault = true,
                    Address = "192.168.0.69",
                    Port = 21,
                    UseDefaultCredentials = true,
                    UseDefaultConsole = false
                };
            }
            else
            {
                consoleProfile = new()
                {
                    Id = DataExtensions.GenerateUniqueId(),
                    Platform = Platform.PS3,
                    PlatformType = PlatformType.PlayStation3Fat,
                    Name = "Default Profile",
                    IsDefault = true,
                    Address = "192.168.0.69",
                    Port = 21,
                    UseDefaultCredentials = true,
                    UseDefaultConsole = false
                };
            }

            return consoleProfile;
        }

        public ConsoleProfile GetDefaultProfile()
        {
            foreach (ConsoleProfile consoleProfile in ConsoleProfiles)
            {
                if (consoleProfile.IsDefault)
                {
                    return consoleProfile;
                }
            }

            return null;
        }
    }

    public class CustomItemData
    {
        public int Id { get; set; } = 0;

        public Platform Platform { get; set; } = Platform.PS3;

        public CategoryType CategoryType { get; set; } = CategoryType.Game;

        public string Category { get; set; }

        public string Name { get; set; }

        public string ModType { get; set; }

        public string Version { get; set; }

        public string Description { get; set; }

        public List<ListItem> Files { get; set; }
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

        public bool IsDefault { get; set; } = true;

        public List<InstalledModInfo> InstalledMods { get; set; } = [];

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

        public CategoryType CategoryType { get; set; }

        public int ModId { get; set; }

        public string Name { get; set; }

        public int TotalFiles { get; set; }

        public DateTime DateInstalled { get; set; }

        public DownloadFiles DownloadFiles { get; set; }

        public bool IsCustom { get; set; }
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

    public class DownloadedItem
    {
        public Platform Platform { get; set; } = Platform.PS3;

        public int ModId { get; set; }

        public string CategoryId { get; set; }

        public string FilePath { get; set; }

        public string Url { get; set; }

        public DownloadFiles DownloadFile { get; set; }

        public DateTime DateTime { get; set; }
    }

    public class FavoriteItem
    {
        public CategoryType CategoryType { get; set; }

        public Platform Platform { get; set; }

        public int ModId { get; set; }

        public string CategoryId { get; set; }
    }
}