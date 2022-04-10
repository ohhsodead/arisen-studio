using ModioX.Constants;
using ModioX.Models.Database;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModioX.Database
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
        public ModsData ModsPS3 { get; private set; }

        /// <summary>
        /// Contains the mods from the Xbox database.
        /// </summary>
        public ModsData PluginsXBOX { get; private set; }

        /// <summary>
        /// Contains the mods from the Xbox database.
        /// </summary>
        public GameSavesData GameSaves { get; private set; }

        /// <summary>
        /// Contains the Xbox 360 Games Title IDs.
        /// </summary>
        public GamesTitleIdsDataXBOX GamesXBOXTitleIds { get; private set; }

        /// <summary>
        /// Contains PS3 Games in PKG format.
        /// </summary>
        public PackagesData GamesPS3 { get; private set; }

        /// <summary>
        /// Contains PS3 DLCs in PKG format.
        /// </summary>
        public PackagesData DemosPS3 { get; private set; }

        /// <summary>
        /// Contains PS3 DLCs in PKG format.
        /// </summary>
        public PackagesData DLCsPS3 { get; private set; }

        /// <summary>
        /// Contains PS3 Avatars in PKG format.
        /// </summary>
        public PackagesData AvatarsPS3 { get; private set; }

        /// <summary>
        /// Contains PS3 Avatars in PKG format.
        /// </summary>
        public PackagesData ThemesPS3 { get; private set; }

        /// <summary>
        /// Contains PS3 Avatars in PKG format.
        /// </summary>
        public GameCheatsData GameCheatsPS3 { get; private set; }

        /// <summary>
        /// Contains announcements.
        /// </summary>
        public AnnouncementsData Announcements { get; private set; }

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
                ModsPS3 = await GetModsPS3Async(),
                PluginsXBOX = await GetPluginsXBOXAsync(),
                GameSaves = await GetGameSavesAsync(),
                GamesXBOXTitleIds = await GetGamesTitleIdsXBOXAsync(),
                GamesPS3 = await GetGamesPackagesAsync(),
                DemosPS3 = await GetDemosPackagesAsync(),
                DLCsPS3 = await GetDLCsPackagesAsync(),
                AvatarsPS3 = await GetAvatarsPackagesAsync(),
                ThemesPS3 = await GetThemesPackagesAsync(),
                GameCheatsPS3 = await GetGameCheatsAsync()
            };

            data.CategoriesData.Categories = data.CategoriesData.Categories.OrderBy(o => o.Title).ToList();

            return data;
        }

        /// <summary>
        /// Download and return the mods data.
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
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<ModsData> GetModsPS3Async()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.ModsDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetGamesPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GamesPackagesDataPS3).ConfigureAwait(true);
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
            using Stream stream = await client.GetStreamAsync(Urls.DemosPackagesDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetDLCsPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.DLCsPackagesDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetAvatarsPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.AvatarsPackagesDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetThemesPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.ThemesPackagesDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<PackagesData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<ModsData> GetPluginsXBOXAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.ModsDataXBOX).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<ModsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<GamesTitleIdsDataXBOX> GetGamesTitleIdsXBOXAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameTitleIdsXBOX).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<GamesTitleIdsDataXBOX>(jsonReader);
        }


        /// <summary>
        /// Download and return the mods data.
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
            if (category == "Games")
            {
                foreach (PackageItemData package in GamesPS3.Packages)
                {
                    if (package.Url == url)
                    {
                        return package;
                    }
                }
            }
            else if (category == "Demos")
            {
                foreach (PackageItemData package in DemosPS3.Packages)
                {
                    if (package.Url == url)
                    {
                        return package;
                    }
                }
            }
            else if (category == "DLCs")
            {
                foreach (PackageItemData package in DLCsPS3.Packages)
                {
                    if (package.Url == url)
                    {
                        return package;
                    }
                }
            }
            else if (category == "Avatars")
            {
                foreach (PackageItemData package in AvatarsPS3.Packages)
                {
                    if (package.Url == url)
                    {
                        return package;
                    }
                }
            }
            else if (category == "Themes")
            {
                foreach (PackageItemData package in ThemesPS3.Packages)
                {
                    if (package.Url == url)
                    {
                        return package;
                    }
                }
            }

            return null;
        }

        public int PackagesCount()
        {
            int count = 0;

            count += GamesPS3.Packages.Count;
            count += DemosPS3.Packages.Count;
            count += DLCsPS3.Packages.Count;
            count += AvatarsPS3.Packages.Count;
            count += ThemesPS3.Packages.Count;

            return count;
        }

        /// <summary>
        /// Download and return the mods data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<GameCheatsData> GetGameCheatsAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.GameCheatsDataPS3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<GameCheatsData>(jsonReader);
        }
    }
}