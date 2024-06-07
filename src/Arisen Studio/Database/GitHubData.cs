using ArisenStudio.Constants;
using ArisenStudio.Extensions;
using ArisenStudio.Models.Dashboard;
using ArisenStudio.Models.Database;
using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Tomlyn;

namespace ArisenStudio.Database
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
        public GamePatchesData GamePatchesXbox { get; private set; }

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
        public FavoriteGamesData FavoriteGames { get; private set; }

        /// <summary>
        /// Contains favorite mods.
        /// </summary>
        public FavoriteModsData FavoriteMods { get; private set; }

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
                DLCsPs3 = await GetDLCsPackagesAsync(),
                AvatarsPs3 = await GetAvatarsPackagesAsync(),
                ThemesPs3 = await GetThemesPackagesAsync(),
                GameCheatsPs3 = await GetGameCheatsPs3Async(),
                GamePatchesXbox = await GetGamePatchesXboxAsync(),
                GamesTitleIdsXbox = await GetGamesTitleIdsXboxAsync(),
                FavoriteGames = await GetFavoriteGamesAsync(),
                FavoriteMods = await GetFavoriteModsAsync(),
            };

            //data.GamePatchesXbox = await GetGamePatchesXboxAsync();

            //data.CategoriesData.Categories.Add(new() { Id = "package", Regions = new string[] { }, Title = "Package", Type = "package" });

            data.CategoriesData.Categories = data.CategoriesData.Categories.OrderBy(o => o.Title).ToList();

            return data;
        }

        private static readonly HttpClient _instance = new HttpClient();

        public static HttpClient Instance
        {
            get { return _instance; }
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

            //var client = HttpExtensions.HttpClientInstance;

            //using (var data = HttpExtensions.HttpClientSingleton(Urls.AnnouncementsData, ""))
            //{
            //    using StreamReader streamReader = new(data);
            //    using JsonReader jsonReader = new JsonTextReader(streamReader);
            //    return new JsonSerializer().Deserialize<AnnouncementsData>(jsonReader);
            //}

            return new JsonSerializer().Deserialize<AnnouncementsData>(jsonReader);
        }

        /// <summary>
        /// Download and return the categories data.
        /// </summary>
        /// <returns> CategoriesData </returns>
        private static async Task<CategoriesData> GetCategoriesAsync()
        {
            //using HttpClient client = new();
            using Stream stream = await _instance.GetStreamAsync(Urls.CategoriesData).ConfigureAwait(true);
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

        static int pkgId = 0;

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

            //return new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            PackagesData games = new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            foreach (PackageItemData package in games.Packages)
            {
                package.Id = pkgId++;
            }

            return games;
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

            //return new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            PackagesData demos = new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            foreach (PackageItemData package in demos.Packages)
            {
                package.Id = pkgId++;
            }

            return demos;
        }

        /// <summary>
        /// Download and return the DLCs packages data.
        /// </summary>
        /// <returns> ModsData </returns>
        private static async Task<PackagesData> GetDLCsPackagesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.PackagesDLCsDataPs3).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            //return new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            PackagesData dlcs = new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            foreach (PackageItemData package in dlcs.Packages)
            {
                package.Id = pkgId++;
            }

            return dlcs;
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

            //return new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            PackagesData avatars = new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            foreach (PackageItemData package in avatars.Packages)
            {
                package.Id = pkgId++;
            }

            return avatars;
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

            //return new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            PackagesData themes = new JsonSerializer().Deserialize<PackagesData>(jsonReader);

            foreach (PackageItemData package in themes.Packages)
            {
                package.Id = pkgId++;
            }

            return themes;
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

                default:
                    break;
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
        private static Task<GamePatchesData> GetGamePatchesXboxAsync()
        {
            //using HttpClient client = new();
            //using Stream stream = await client.GetStreamAsync(Urls.GameCheatsDataXbox).ConfigureAwait(true);
            //using StreamReader streamReader = new(stream);
            //using JsonReader jsonReader = new JsonTextReader(streamReader);

            //return new JsonSerializer().Deserialize<GameCheatsData>(jsonReader);

            GamePatchesData gamePatchesData = new();

            WebRequest webRequest = WebRequest.Create(Urls.GamePatchesDataXbox);
            webRequest.Method = "GET";
            WebResponse webResponse = webRequest.GetResponse();

            using (var responseStream = webResponse.GetResponseStream())
            using (var ms = new MemoryStream())
            {
                // Copy entire file into memory. Use a file if you expect a lot of data
                responseStream.CopyTo(ms);

                var zipFile = new ZipFile(ms);

                foreach (ZipEntry item in zipFile)
                {
                    using var s = new StreamReader(zipFile.GetInputStream(item));
                    //Console.WriteLine(s.ReadToEnd());
                    gamePatchesData.GamePatches.Add(Toml.ToModel<GamePatchItemData>(s.ReadToEnd()));
                }
            }

            return Task.FromResult(gamePatchesData);
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
        private static async Task<FavoriteGamesData> GetFavoriteGamesAsync()
        {
            using HttpClient client = new();
            using Stream stream = await client.GetStreamAsync(Urls.FavoriteGamesData).ConfigureAwait(true);
            using StreamReader streamReader = new(stream);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            return new JsonSerializer().Deserialize<FavoriteGamesData>(jsonReader);
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