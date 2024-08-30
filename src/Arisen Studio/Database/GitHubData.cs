using ArisenStudio.Constants;
using ArisenStudio.Extensions;
using ArisenStudio.Models.Dashboard;
using ArisenStudio.Models.Database;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArisenStudio.Database
{
    public class GitHubData
    {
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
        public ModsData GameModsX360 { get; private set; }

        /// <summary>
        /// Contains the mods from the Xbox database.
        /// </summary>
        public ModsData HomebrewX360 { get; private set; }

        /// <summary>
        /// Contains the trainers from the Xbox database.
        /// </summary>
        public TrainersData TrainersX360 { get; private set; }

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
        public GamePatchesData GamePatchesX360 { get; private set; }

        /// <summary>
        /// Contains the Xbox 360 Games Title IDs.
        /// </summary>
        public XboxTitleIds TitleIdsX360 { get; private set; }

        /// <summary>
        /// Stores database files in memory and then locally.
        /// </summary>
        private readonly SimpleCache<CategoriesData> _categoriesCache;
        private readonly SimpleCache<ModsData> _gameModsCachePS3;
        private readonly SimpleCache<ModsData> _homebrewCachePS3;
        private readonly SimpleCache<ModsData> _resourcesCachePS3;
        private readonly SimpleCache<ModsData> _gameModsCacheX360;
        private readonly SimpleCache<ModsData> _homebrewCacheX360;
        private readonly SimpleCache<TrainersData> _trainersCacheX360;
        private readonly SimpleCache<AppsData> _homebrewCachePS4;
        private readonly SimpleCache<PackagesData> _gamePackagesCachePS3;
        private readonly SimpleCache<PackagesData> _demoPackagesCachePS3;
        private readonly SimpleCache<PackagesData> _avatarPackagesCachePS3;
        private readonly SimpleCache<PackagesData> _dlcPackagesCachePS3;
        private readonly SimpleCache<PackagesData> _themePackagesCachePS3;
        private readonly SimpleCache<GameCheatsData> _gameCheatsCachePS3;
        private readonly SimpleCache<GameSavesData> _gameSavesCache;
        private readonly SimpleCache<XboxTitleIds> _titleIdsCacheX360;
        private readonly SimpleCache<FavoriteGamesData> _favoriteGamesCache;
        private readonly SimpleCache<FavoriteModsData> _favoriteModsCache;

        private readonly HttpClient _httpClient;

        /// <summary>
        /// Fetch the database files hosted in our GitHub repo.
        /// </summary>
        public GitHubData()
        {
            _favoriteGamesCache = new SimpleCache<FavoriteGamesData>("favoriteGamesCache.json");
            _favoriteModsCache = new SimpleCache<FavoriteModsData>("favoriteModsCache.json");
            _categoriesCache = new SimpleCache<CategoriesData>("categoriesCache.json");
            _gameModsCachePS3 = new SimpleCache<ModsData>("gameModsCachePS3.json");
            _homebrewCachePS3 = new SimpleCache<ModsData>("homebrewCachePS3.json");
            _resourcesCachePS3 = new SimpleCache<ModsData>("resourcesCachePS3.json");
            _gameCheatsCachePS3 = new SimpleCache<GameCheatsData>("gameCheatsCachePS3.json");
            _gameModsCacheX360 = new SimpleCache<ModsData>("gameModsX360.json");
            _homebrewCacheX360 = new SimpleCache<ModsData>("homebrewX360.json");
            _trainersCacheX360 = new SimpleCache<TrainersData>("trainersCacheX360.json");
            _homebrewCachePS4 = new SimpleCache<AppsData>("homebrewPS4.json");
            _gamePackagesCachePS3 = new SimpleCache<PackagesData>("gamePackageCachePS3.json");
            _demoPackagesCachePS3 = new SimpleCache<PackagesData>("demoPackageCachePS3.json");
            _avatarPackagesCachePS3 = new SimpleCache<PackagesData>("avatarPackageCachePS3.json");
            _dlcPackagesCachePS3 = new SimpleCache<PackagesData>("dlcPackageCachePS3.json");
            _themePackagesCachePS3 = new SimpleCache<PackagesData>("themePackageCachePS3.json");
            _gameSavesCache = new SimpleCache<GameSavesData>("gameSavesCache.json");
            _titleIdsCacheX360 = new SimpleCache<XboxTitleIds>("titleIdsCacheX360.json");

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("ArisenStudio");
        }

        /// <summary>
        /// Fetch the specified data from either the cached file and store it locally if it hasn't been already.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache"></param>
        /// <param name="cacheKey"></param>
        /// <param name="fetchFunction"></param>
        /// <returns></returns>
        public async Task<T> GetFromCacheOrFetchAsync<T>(SimpleCache<T> cache, string cacheKey, string filePath, Func<Task<T>> fetchFunction)
        {
            string fileUrl = $"https://db.arisen.studio/data/{filePath}";

            // Try to get the cached data and its metadata
            if (cache.TryGetValue(cacheKey, out var cachedData, out var cacheMetadata))
            {
                // Extract the ETag or Last-Modified value from the cache metadata
                var eTag = cacheMetadata.ETag;
                var lastModified = cacheMetadata.LastModified;

                var request = new HttpRequestMessage(HttpMethod.Get, fileUrl);

                // Add the If-None-Match or If-Modified-Since header based on cached metadata
                if (!string.IsNullOrEmpty(eTag))
                {
                    request.Headers.IfNoneMatch.Add(new System.Net.Http.Headers.EntityTagHeaderValue(eTag));
                }
                else if (lastModified.HasValue)
                {
                    request.Headers.IfModifiedSince = lastModified.Value;
                }

                var response = await _httpClient.SendAsync(request);

                // Check if the file has not been modified (304 Not Modified)
                if (response.StatusCode == HttpStatusCode.NotModified)
                {
                    return cachedData;
                }
                else if (response.IsSuccessStatusCode)
                {
                    // Fetch new data and update the cache
                    var newData = await fetchFunction();

                    // Update the cache with new data and metadata
                    cache.Add(cacheKey, newData, new CacheMetadata
                    {
                        ETag = response.Headers.ETag?.Tag,
                        LastModified = response.Content.Headers.LastModified
                    });

                    return newData;
                }
            }

            // If no cached data, fetch fresh data and cache it
            var data = await fetchFunction();

            var fetchResponse = await _httpClient.GetAsync(fileUrl);
            cache.Add(cacheKey, data, new CacheMetadata
            {
                ETag = fetchResponse.Headers.ETag?.Tag,
                LastModified = fetchResponse.Content.Headers.LastModified
            });

            return data;
        }

        /// <summary>
        /// Initialization of the class.
        /// </summary>
        /// <returns> instance of the class. </returns>
        public static async Task<GitHubData> InitializeAsync()
        {
            GitHubData fetcher = new();

            GitHubData data = new()
            {
                Announcements = await fetcher.GetAnnouncements(),
                FavoriteGames = await fetcher.GetFavoriteGames(),
                FavoriteMods = await fetcher.GetFavoriteMods(),
                CategoriesData = await fetcher.GetCategories(),
                GameModsPS3 = await fetcher.GetGameModsPS3(),
                HomebrewPS3 = await fetcher.GetHomebrewPS3(),
                ResourcesPS3 = await fetcher.GetResourcesPS3(),
                GameModsX360 = await fetcher.GetGameModsX360(),
                HomebrewX360 = await fetcher.GetHomebrewX360(),
                TrainersX360 = await fetcher.GetTrainersX360(),
                HomebrewPS4 = await fetcher.GetHomebrewPS4(),
                GamesPS3 = await fetcher.GetGamesPkgsPS3(),
                DemosPS3 = await fetcher.GetDemosPkgsPS3(),
                DLCsPS3 = await fetcher.GetDLCsPkgsPS3(),
                AvatarsPS3 = await fetcher.GetAvatarsPkgsPS3(),
                ThemesPS3 = await fetcher.GetThemesPkgsPS3(),
                GameSaves = await fetcher.GetGameSaves(),
                GameCheatsPS3 = await fetcher.GetGameCheats(),
                TitleIdsX360 = await fetcher.GetTitleIds()
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
            string response = await _httpClient.GetStringAsync(Urls.AnnouncementsData);
            return JsonConvert.DeserializeObject<AnnouncementsData>(response);
        }

        /// <summary>
        /// Fetch the current Favorite Games data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<FavoriteGamesData> GetFavoriteGames() => GetFromCacheOrFetchAsync(_favoriteGamesCache, "favoriteGames", "favorite-games.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.FavoriteGamesData);
            return JsonConvert.DeserializeObject<FavoriteGamesData>(response);
        });

        /// <summary>
        /// Fetch the current Favorite Mods data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<FavoriteModsData> GetFavoriteMods() => GetFromCacheOrFetchAsync(_favoriteModsCache, "favoriteMods", "favorite-mods.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.FavoriteModsData);
            return JsonConvert.DeserializeObject<FavoriteModsData>(response);
        });

        /// <summary>
        /// Fetch the Categories data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public Task<CategoriesData> GetCategories() => GetFromCacheOrFetchAsync(_categoriesCache, "categories", "categories.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.CategoriesData);
            return JsonConvert.DeserializeObject<CategoriesData>(response);
        });

        /// <summary>
        /// Fetch the Game Mods data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        public Task<ModsData> GetGameModsPS3() => GetFromCacheOrFetchAsync(_gameModsCachePS3, "gameModsPS3", "ps3/game-mods.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.GameModsDataPS3);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Homebrew data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        private Task<ModsData> GetHomebrewPS3() => GetFromCacheOrFetchAsync(_homebrewCachePS3, "homebrewPS3", "ps3/homebrew.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.HomebrewDataPS3);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Resources data either from cache or the source file.
        /// </summary>
        /// <returns></returns>
        private Task<ModsData> GetResourcesPS3() => GetFromCacheOrFetchAsync(_resourcesCachePS3, "resourcesPS3", "ps3/resources.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.ResourcesDataPS3);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        private static int pkgId = 0;

        /// <summary>
        /// Fetch the Game Packages data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        private Task<PackagesData> GetGamesPkgsPS3() => GetFromCacheOrFetchAsync(_gamePackagesCachePS3, "gamesPkgsPS3", "ps3/packages/games.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.PackagesGamesDataPS3);

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
        private Task<PackagesData> GetDemosPkgsPS3() => GetFromCacheOrFetchAsync(_demoPackagesCachePS3, "demosPkgsPS3", "ps3/packages/demos.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.PackagesDemosDataPS3);
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
        private Task<PackagesData> GetDLCsPkgsPS3() => GetFromCacheOrFetchAsync(_dlcPackagesCachePS3, "DLCsPkgsPS3", "ps3/packages/dlcs.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.PackagesDLCsDataPS3);
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
        private Task<PackagesData> GetAvatarsPkgsPS3() => GetFromCacheOrFetchAsync(_avatarPackagesCachePS3, "avatarsPkgsPS3", "ps3/packages/avatars.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.PackagesAvatarsDataPS3);
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
        private Task<PackagesData> GetThemesPkgsPS3() => GetFromCacheOrFetchAsync(_themePackagesCachePS3, "themesPkgsPS3", "ps3/packages/themes.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.PackagesThemesDataPS3);
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
        public Task<AppsData> GetHomebrewPS4() => GetFromCacheOrFetchAsync(_homebrewCachePS4, "homebrewPS4", "ps4/homebrew.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.HomebrewDataPS4);
            return JsonConvert.DeserializeObject<AppsData>(response);
        });

        /// <summary>
        /// Fetch the Plugins data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<ModsData> GetGameModsX360() => GetFromCacheOrFetchAsync(_gameModsCacheX360, "gameModsXB360", "xbox360/game-mods.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.GameModsDataXbox);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Plugins data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<ModsData> GetHomebrewX360() => GetFromCacheOrFetchAsync(_homebrewCacheX360, "homebrewXB360", "xbox360/homebrew.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.HomebrewDataXbox);
            return JsonConvert.DeserializeObject<ModsData>(response);
        });

        /// <summary>
        /// Fetch the Plugins data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<TrainersData> GetTrainersX360() => GetFromCacheOrFetchAsync(_trainersCacheX360, "trainersX360", "xbox360/trainers.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.TrainersDataXbox);
            return JsonConvert.DeserializeObject<TrainersData>(response);
        });

        /// <summary>
        /// Fetch the Game Saves data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<GameSavesData> GetGameSaves() => GetFromCacheOrFetchAsync(_gameSavesCache, "gameSaves", "game-saves.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.GameSavesData);
            return JsonConvert.DeserializeObject<GameSavesData>(response);
        });

        /// <summary>
        /// Fetch the Game Cheats data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<GameCheatsData> GetGameCheats() => GetFromCacheOrFetchAsync(_gameCheatsCachePS3, "gameCheatsPS3", "ps3/game-cheats.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.GameCheatsDataPS3);
            return JsonConvert.DeserializeObject<GameCheatsData>(response);
        });

        /// <summary>
        /// Fetch the Game Title Ids data either from cache or the source file.
        /// </summary>
        /// <returns> ModsData </returns>
        public Task<XboxTitleIds> GetTitleIds() => GetFromCacheOrFetchAsync(_titleIdsCacheX360, "titleIdsX360", "xbox360/titleids.json", async () =>
        {
            string response = await _httpClient.GetStringAsync(Urls.GameTitleIdsXbox);
            return JsonConvert.DeserializeObject<XboxTitleIds>(response);
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
            else if (platform == Platform.XBOX360 && categoryType == CategoryType.Game)
            {
                return GameModsX360.GetModById(platform, modId);
            }
            else if (platform == Platform.XBOX360 && categoryType == CategoryType.Homebrew)
            {
                return HomebrewX360.GetModById(platform, modId);
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