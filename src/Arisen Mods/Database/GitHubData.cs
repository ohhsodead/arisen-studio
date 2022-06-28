using ArisenMods.Constants;
using ArisenMods.Models.Dashboard;
using ArisenMods.Models.Database;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArisenMods.Database
{
    public class GitHubData
    {
        /// <summary>
        /// Contains the categories from the database.
        /// </summary>
        public CategoriesData CategoriesData { get; private set; }

        /// <summary>
        /// Contains the mods from the PS3 database.
        /// </summary>
        public ModsData GameModsPs3 { get; private set; }

        /// <summary>
        /// Contains the mods from the PS3 database.
        /// </summary>
        public ModsData HomebrewPs3 { get; private set; }

        /// <summary>
        /// Contains the mods from the PS3 database.
        /// </summary>
        public ModsData ResourcesPs3 { get; private set; }

        /// <summary>
        /// Contains PS3 Games in PKG format.
        /// </summary>
        public PackagesData GamesPs3 { get; private set; }

        /// <summary>
        /// Contains PS3 DLCs in PKG format.
        /// </summary>
        public PackagesData DemosPs3 { get; private set; }

        /// <summary>
        /// Contains PS3 DLCs in PKG format.
        /// </summary>
        public PackagesData DLCsPs3 { get; private set; }

        /// <summary>
        /// Contains PS3 Avatars in PKG format.
        /// </summary>
        public PackagesData AvatarsPs3 { get; private set; }

        /// <summary>
        /// Contains PS3 Avatars in PKG format.
        /// </summary>
        public PackagesData ThemesPs3 { get; private set; }

        /// <summary>
        /// Contains the mods from the Xbox database.
        /// </summary>
        public ModsData PluginsXbox { get; private set; }

        /// <summary>
        /// Contains the game saves for both platforms
        /// </summary>
        public GameSavesData GameSaves { get; private set; }

        /// <summary>
        /// Contains the game cheats for PS3
        /// </summary>
        public GameCheatsData GameCheatsPs3 { get; private set; }

        /// <summary>
        /// Contains the game cheats for Xbox 360
        /// </summary>
        public GameCheatsData GameCheatsXbox { get; private set; }

        /// <summary>
        /// Contains the Xbox 360 Games Title IDs.
        /// </summary>
        public GamesTitleIdsDataXbox GamesTitleIdsXbox { get; private set; }

        /// <summary>
        /// Contains announcements.
        /// </summary>
        public AnnouncementsData Announcements { get; private set; }

        /// <summary>
        /// Contains favorite mods.
        /// </summary>
        public FavoriteModsData FavoritesMods { get; private set; }

        /// <summary>
        /// Initialization of the class.
        /// </summary>
        /// <returns> instance of the class. </returns>
        public static async Task<GitHubData> InitializeAsync()
        {
            GitHubData data = new()
            {
                Announcements = await GetAnnouncementsAsync(),
                CategoriesData = await GetCategoriesAsync(),
                GameModsPs3 = await GetGameModsPs3Async(),
                HomebrewPs3 = await GetHomebrewPs3Async(),
                ResourcesPs3 = await GetResourcesPs3Async(),
                PluginsXbox = await GetPluginsXboxAsync(),
                GameSaves = await GetGameSavesAsync(),
                GamesPs3 = await GetGamesPackagesAsync(),
                DemosPs3 = await GetDemosPackagesAsync(),
                DLCsPs3 = await GetDlCsPackagesAsync(),
                AvatarsPs3 = await GetAvatarsPackagesAsync(),
                ThemesPs3 = await GetThemesPackagesAsync(),
                GameCheatsPs3 = await GetGameCheatsPs3Async(),
                GameCheatsXbox = await GetGameCheatsXboxAsync(),
                GamesTitleIdsXbox = await GetGamesTitleIdsXboxAsync(),
                FavoritesMods = await GetFavoriteModsAsync(),
            };

            data.CategoriesData.Categories = data.CategoriesData.Categories.OrderBy(o => o.Title).ToList();

            return data;
        }

        /// <summary>
        /// Download and return the announcements data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<AnnouncementsData> GetAnnouncementsAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.AnnouncementsData).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<AnnouncementsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the categories data.
        /// </summary>
        /// <returns> CategoriesData </returns>
        private static async Task<CategoriesData> GetCategoriesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.CategoriesData).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<CategoriesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the game mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<ModsData> GetGameModsPs3Async()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameModsDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the homebrew data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<ModsData> GetHomebrewPs3Async()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.HomebrewDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the resources data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<ModsData> GetResourcesPs3Async()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.ResourcesDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the games packages data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetGamesPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PackagesGamesDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetDemosPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PackagesDemosDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the DLCs packages data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetDlCsPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PackagesDlCsDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the avatars packages data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetAvatarsPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PackagesAvatarsDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the theme packages data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetThemesPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PackagesThemesDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the plugins data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<ModsData> GetPluginsXboxAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PluginsDataXbox).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the game saves data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<GameSavesData> GetGameSavesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameSavesData).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<GameSavesData>(jsonReader);
        }

        public PackageItemData GetPackage(string category, string url)
        {
            switch (category)
            {
                case "Games":
                {
                    foreach (PackageItemData package in GamesPs3.Packages.Where(package => package.Url == url))
                    {
                        return package;
                    }

                    break;
                }
                case "Demos":
                {
                    foreach (PackageItemData package in DemosPs3.Packages.Where(package => package.Url == url))
                    {
                        return package;
                    }

                    break;
                }
                case "DLCs":
                {
                    foreach (PackageItemData package in DLCsPs3.Packages.Where(package => package.Url == url))
                    {
                        return package;
                    }

                    break;
                }
                case "Avatars":
                {
                    foreach (PackageItemData package in AvatarsPs3.Packages.Where(package => package.Url == url))
                    {
                        return package;
                    }

                    break;
                }
                case "Themes":
                {
                    foreach (PackageItemData package in ThemesPs3.Packages.Where(package => package.Url == url))
                    {
                        return package;
                    }

                    break;
                }
            }

            return null;
        }

        public int PackagesCount()
        {
            int count = 0;

            count += GamesPs3.Packages.Count;
            count += DemosPs3.Packages.Count;
            count += DLCsPs3.Packages.Count;
            count += AvatarsPs3.Packages.Count;
            count += ThemesPs3.Packages.Count;

            return count;
        }

        /// <summary>
        /// Download and return the game cheats data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<GameCheatsData> GetGameCheatsPs3Async()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameCheatsDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<GameCheatsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the game cheats data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<GameCheatsData> GetGameCheatsXboxAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameCheatsDataXbox).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<GameCheatsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the Xbox title Ids data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<GamesTitleIdsDataXbox> GetGamesTitleIdsXboxAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameTitleIdsXbox).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<GamesTitleIdsDataXbox>(jsonReader);
        }

        /// <summary>
        /// Download and return the favorite mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<FavoriteModsData> GetFavoriteModsAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.FavoriteModsData).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<FavoriteModsData>(jsonReader);
        }

        public ModItemData GetModItem(Platform platform, CategoryType categoryType, int modId)
        {
            if (platform == Platform.PS3 && categoryType == CategoryType.Game)
            {
                return GameModsPs3.GetModById(platform, modId);
            }
            else if (platform == Platform.PS3 && categoryType == CategoryType.Homebrew)
            {
                return HomebrewPs3.GetModById(platform, modId);
            }
            else if (platform == Platform.PS3 && categoryType == CategoryType.Resource)
            {
                return ResourcesPs3.GetModById(platform, modId);
            }
            else if (platform == Platform.XBOX360)
            {
                return PluginsXbox.GetModById(platform, modId);
            }
            else
            {
                return null;
            }
        }
    }
}