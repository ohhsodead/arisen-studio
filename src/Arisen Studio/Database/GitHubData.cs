using ArisenStudio.Constants;
using ArisenStudio.Models.Dashboard;
using ArisenStudio.Models.Database;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArisenStudio.Database
{
    public class GitHubData
    {
        /// <summary>
        /// Contains the Categories from the database.
        /// </summary>
        public CategoriesData CategoriesData { get; private set; }

        /// <summary>
        /// Contains the Game Mods for PS3.
        /// </summary>
        public ModsData GameModsPS3 { get; private set; }

        /// <summary>
        /// Contains the homebrew for PS3.
        /// </summary>
        public ModsData HomebrewPS3 { get; private set; }

        /// <summary>
        /// Contains the resources for PS3.
        /// </summary>
        public ModsData ResourcesPS3 { get; private set; }

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
        /// Contains the mods from the Xbox database.
        /// </summary>
        public ModsData GameModsXbox { get; private set; }

        /// <summary>
        /// Contains the mods from the Xbox database.
        /// </summary>
        public ModsData HomebrewXbox { get; private set; }

        /// <summary>
        /// Contains the homebrew from the PS4 database.
        /// </summary>
        public AppsData HomebrewPS4 { get; private set; }

        /// <summary>
        /// Contains the game saves for both platforms.
        /// </summary>
        public GameSavesData GameSaves { get; private set; }

        /// <summary>
        /// Contains the game cheats for PS3.
        /// </summary>
        public GameCheatsData GameCheatsPS3 { get; private set; }

        /// <summary>
        /// Contains the game cheats for Xbox 360.
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
        /// Stores database files in memory and then locally.
        /// </summary>
        private readonly SimpleCache<CategoriesData> _categoriesCache;
        private readonly SimpleCache<ModsData> _gameModsCache;
        private readonly SimpleCache<ModsData> _homebrewCache;
        private readonly SimpleCache<ModsData> _resourcesCache;
        private readonly SimpleCache<ModsData> _pluginsCache;
        private readonly SimpleCache<AppsData> _appsCache;
        private readonly SimpleCache<GameSavesData> _gameSavesCache;
        private readonly SimpleCache<PackagesData> _gamePackagesCache;
        private readonly SimpleCache<PackagesData> _demoPackagesCache;
        private readonly SimpleCache<PackagesData> _avatarPackagesCache;
        private readonly SimpleCache<PackagesData> _dlcPackagesCache;
        private readonly SimpleCache<PackagesData> _themePackagesCache;
        private readonly SimpleCache<GameCheatsData> _gameCheatsCache;
        private readonly SimpleCache<GamesTitleIdsDataXbox> _gameTitleIdsCache;
        private readonly SimpleCache<FavoriteGamesData> _favoriteGamesCache;
        private readonly SimpleCache<FavoriteModsData> _favoriteModsCache;

        private readonly HttpClient _httpClient;

        /// <summary>
        /// Fetch the database files hosted in our GitHub repo.
        /// </summary>
        public GitHubData()
        {
            _categoriesCache = new SimpleCache<CategoriesData>(TimeSpan.FromDays(7), "categoriesCache.json");
            _gameModsCache = new SimpleCache<ModsData>(TimeSpan.FromDays(7), "gameModsCache.json");
            _homebrewCache = new SimpleCache<ModsData>(TimeSpan.FromDays(7), "homebrewCache.json");
            _resourcesCache = new SimpleCache<ModsData>(TimeSpan.FromDays(7), "resourcesPlugins.json");
            _pluginsCache = new SimpleCache<ModsData>(TimeSpan.FromDays(7), "pluginsCache.json");
            _appsCache = new SimpleCache<AppsData>(TimeSpan.FromDays(7), "appsCache.json");
            _gameSavesCache = new SimpleCache<GameSavesData>(TimeSpan.FromDays(7), "gameSavesCache.json");
            _gamePackagesCache = new SimpleCache<PackagesData>(TimeSpan.FromDays(30), "gamePackageCache.json");
            _demoPackagesCache = new SimpleCache<PackagesData>(TimeSpan.FromDays(30), "demoPackageCache.json");
            _avatarPackagesCache = new SimpleCache<PackagesData>(TimeSpan.FromDays(30), "avatarPackageCache.json");
            _dlcPackagesCache = new SimpleCache<PackagesData>(TimeSpan.FromDays(30), "dlcPackageCache.json");
            _themePackagesCache = new SimpleCache<PackagesData>(TimeSpan.FromDays(30), "themePackageCache.json");
            _gameCheatsCache = new SimpleCache<GameCheatsData>(TimeSpan.FromDays(30), "gameCheatsCache.json");
            _gameTitleIdsCache = new SimpleCache<GamesTitleIdsDataXbox>(TimeSpan.FromDays(30), "gameTitleIdsCache.json");
            _favoriteGamesCache = new SimpleCache<FavoriteGamesData>(TimeSpan.FromDays(30), "favoriteGamesCache.json");
            _favoriteModsCache = new SimpleCache<FavoriteModsData>(TimeSpan.FromDays(30), "favoriteModsCache.json");

            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Fetch the specified data from either the cached file and store it locally if it hasn't been already.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache"></param>
        /// <param name="cacheKey"></param>
        /// <param name="fetchFunction"></param>
        /// <returns></returns>
        private async Task<T> GetFromCacheOrFetchAsync<T>(SimpleCache<T> cache, string cacheKey, Func<Task<T>> fetchFunction)
        {
            if (cache.TryGetValue(cacheKey, out var cachedData))
            {
                return cachedData;
            }

            var data = await fetchFunction();
            cache.Add(cacheKey, data);
            return data;
        }

        /// <summary>
        /// Initialization of the class.
        /// </summary>
        /// <returns> instance of the class. </returns>
        public static async Task<GitHubData> InitializeAsync()
        {
            var fetcher = new GitHubData();

            GitHubData data = new()
            {
                Announcements = await fetcher.GetAnnouncements(),
                CategoriesData = await fetcher.GetCategories(),
                GameModsPS3 = await fetcher.GetGameMods(),
                HomebrewPS3 = await fetcher.GetHomebrew(),
                ResourcesPS3 = await fetcher.GetResources(),
                GameModsXbox = await fetcher.GetGameModsXbox(),
                HomebrewXbox = await fetcher.GetHomebrewXbox(),
                HomebrewPS4 = await fetcher.GetHomebrewPS4(),
                GameSaves = await fetcher.GetGameSaves(),
                GamesPS3 = await fetcher.GetGamesPackages(),
                DemosPS3 = await fetcher.GetDemosPackages(),
                DLCsPS3 = await fetcher.GetDLCsPackages(),
                AvatarsPS3 = await fetcher.GetAvatarsPackages(),
                ThemesPS3 = await fetcher.GetThemePackages(),
                GameCheatsPS3 = await fetcher.GetGameCheats(),
                GamesTitleIdsXbox = await fetcher.GetGamesTitleIds(),
                FavoriteGames = await fetcher.GetFavoriteGames(),
                FavoriteMods = await fetcher.GetFavoriteMods()
            };

            data.CategoriesData.Categories = [.. data.CategoriesData.Categories.OrderBy(o => o.Title)];
            return data;
        }

        /// <summary>
        /// Fetch the Announcements data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public async Task<AnnouncementsData> GetAnnouncements()
        {
            var response = await _httpClient.GetStringAsync(Urls.AnnouncementsData);
            return JsonConvert.DeserializeObject<AnnouncementsData>(response);
        }

        /// <summary>
        /// Fetch the Categories data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public Task<CategoriesData> GetCategories() => GetFromCacheOrFetchAsync(_categoriesCache, "categories", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.CategoriesData);
            return JsonConvert.DeserializeObject<CategoriesData>(response);
        });

        /// <summary>
        /// Fetch the Game Mods data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public Task<ModsData> GetGameMods() => GetFromCacheOrFetchAsync(_gameModsCache, "gameMods", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.GameModsDataPS3);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Homebrew data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public Task<ModsData> GetHomebrew() => GetFromCacheOrFetchAsync(_homebrewCache, "homebrew", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.HomebrewDataPS3);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Resources data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public Task<ModsData> GetResources() => GetFromCacheOrFetchAsync(_resourcesCache, "resources", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.ResourcesDataPS3);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        private static int pkgId = 0;

        /// <summary>
        /// Fetch the Game Packages data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<PackagesData> GetGamesPackages() => GetFromCacheOrFetchAsync(_gamePackagesCache, "gamePackages", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.PackagesGamesDataPS3);

            PackagesData games = JsonConvert.DeserializeObject<PackagesData>(response);

            foreach (PackageItemData package in games.Packages)
            {
                package.Id = pkgId++;
            }

            return games;
        });

        /// <summary>
        /// Fetch the Demo Packages data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<PackagesData> GetDemosPackages() => GetFromCacheOrFetchAsync(_demoPackagesCache, "demoPackages", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.PackagesDemosDataPS3);
            PackagesData demos = JsonConvert.DeserializeObject<PackagesData>(response);

            foreach (PackageItemData package in demos.Packages)
            {
                package.Id = pkgId++;
            }

            return demos;
        });

        /// <summary>
        /// Fetch the DLC Packages data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<PackagesData> GetDLCsPackages() => GetFromCacheOrFetchAsync(_dlcPackagesCache, "dlcPackages", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.PackagesDLCsDataPS3);
            PackagesData dlcs = JsonConvert.DeserializeObject<PackagesData>(response);

            foreach (PackageItemData package in dlcs.Packages)
            {
                package.Id = pkgId++;
            }

            return dlcs;
        });

        /// <summary>
        /// Fetch the Avatar Packages data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<PackagesData> GetAvatarsPackages() => GetFromCacheOrFetchAsync(_avatarPackagesCache, "avatarPackages", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.PackagesAvatarsDataPS3);
            PackagesData avatars = JsonConvert.DeserializeObject<PackagesData>(response);

            foreach (PackageItemData package in avatars.Packages)
            {
                package.Id = pkgId++;
            }

            return avatars;
        });

        /// <summary>
        /// Fetch the Theme Packages data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<PackagesData> GetThemePackages() => GetFromCacheOrFetchAsync(_themePackagesCache, "themePackages", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.PackagesThemesDataPS3);
            PackagesData themes = JsonConvert.DeserializeObject<PackagesData>(response);

            foreach (PackageItemData package in themes.Packages)
            {
                package.Id = pkgId++;
            }

            return themes;
        });

        /// <summary>
        /// Fetch the Applications data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<AppsData> GetHomebrewPS4() => GetFromCacheOrFetchAsync(_appsCache, "homebrewPS4", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.HomebrewDataPS4);
            return JsonConvert.DeserializeObject<AppsData>(response);
        });

        /// <summary>
        /// Fetch the Plugins data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<ModsData> GetGameModsXbox() => GetFromCacheOrFetchAsync(_pluginsCache, "gameModsXbox", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.GameModsDataXbox);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Plugins data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<ModsData> GetHomebrewXbox() => GetFromCacheOrFetchAsync(_pluginsCache, "homebrewXbox", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.HomebrewDataXbox);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Game Saves data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<GameSavesData> GetGameSaves() => GetFromCacheOrFetchAsync(_gameSavesCache, "gameSaves", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.GameSavesData);
            return JsonConvert.DeserializeObject<GameSavesData>(response);
        });

        /// <summary>
        /// Fetch the Game Cheats data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<GameCheatsData> GetGameCheats() => GetFromCacheOrFetchAsync(_gameCheatsCache, "gameCheats", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.GameCheatsDataPS3);
            return JsonConvert.DeserializeObject<GameCheatsData>(response);
        });

        /// <summary>
        /// Fetch the Game Title Ids data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<GamesTitleIdsDataXbox> GetGamesTitleIds() => GetFromCacheOrFetchAsync(_gameTitleIdsCache, "gameTitleIds", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.GameTitleIdsXbox);
            return JsonConvert.DeserializeObject<GamesTitleIdsDataXbox>(response);
        });

        /// <summary>
        /// Fetch the current Favorite Games data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<FavoriteGamesData> GetFavoriteGames() => GetFromCacheOrFetchAsync(_favoriteGamesCache, "favoriteGames", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.FavoriteGamesData);
            return JsonConvert.DeserializeObject<FavoriteGamesData>(response);
        });

        /// <summary>
        /// Fetch the current Favorite Mods data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<FavoriteModsData> GetFavoriteMods() => GetFromCacheOrFetchAsync(_favoriteModsCache, "favoriteMods", async () =>
        {
            var response = await _httpClient.GetStringAsync(Urls.FavoriteModsData);
            return JsonConvert.DeserializeObject<FavoriteModsData>(response);
        });

        /// <summary>
        /// Get specific package matching the Category and Url.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public PackageItemData GetPackage(string category, string url)
        {
            switch (category)
            {
                case "Games":
                    {
                        foreach (PackageItemData package in GamesPS3.Packages.Where(package => package.Url == url))
                        {
                            return package;
                        }

                        break;
                    }
                case "Demos":
                    {
                        foreach (PackageItemData package in DemosPS3.Packages.Where(package => package.Url == url))
                        {
                            return package;
                        }

                        break;
                    }
                case "DLCs":
                    {
                        foreach (PackageItemData package in DLCsPS3.Packages.Where(package => package.Url == url))
                        {
                            return package;
                        }

                        break;
                    }
                case "Avatars":
                    {
                        foreach (PackageItemData package in AvatarsPS3.Packages.Where(package => package.Url == url))
                        {
                            return package;
                        }

                        break;
                    }
                case "Themes":
                    {
                        foreach (PackageItemData package in ThemesPS3.Packages.Where(package => package.Url == url))
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

            count += GamesPS3.Packages.Count;
            count += DemosPS3.Packages.Count;
            count += DLCsPS3.Packages.Count;
            count += AvatarsPS3.Packages.Count;
            count += ThemesPS3.Packages.Count;

            return count;
        }

        public ModItemData GetModItem(Platform platform, CategoryType categoryType, int modId)
        {
            if (platform == Platform.PS3 && categoryType == CategoryType.Game)
            {
                return GameModsPS3.GetModById(platform, modId);
            }
            else if (platform == Platform.PS3 && categoryType == CategoryType.Homebrew)
            {
                return HomebrewPS3.GetModById(platform, modId);
            }
            else if (platform == Platform.PS3 && categoryType == CategoryType.Resource)
            {
                return ResourcesPS3.GetModById(platform, modId);
            }
            else if (platform == Platform.XBOX360 && categoryType == CategoryType.Resource)
            {
                return GameModsXbox.GetModById(platform, modId);
            }
            else if (platform == Platform.XBOX360 && categoryType == CategoryType.Resource)
            {
                return HomebrewXbox.GetModById(platform, modId);
            }
            else
            {
                return null;
            }
        }

        public AppItemData GetAppItem(CategoryType categoryType, int modId)
        {
            if (categoryType == CategoryType.Homebrew)
            {
                return HomebrewPS4.GetModById(modId);
            }
            else if (categoryType == CategoryType.Game)
            {
                return HomebrewPS4.GetModById(modId);
            }
            else
            {
                return null;
            }
        }
    }
}