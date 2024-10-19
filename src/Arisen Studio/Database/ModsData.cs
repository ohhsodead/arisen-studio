using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.Database
{
    public class ModsData
    {
        /// <summary>
        /// Get the Library from the database.
        /// </summary>
        public List<ModItemData> Library { get; set; }

        /// <summary>
        /// Get the supported firmwares from the Library.
        /// </summary>
        /// <returns> Firmwares Supported </returns>
        public List<string> AllFirmwareTypes
        {
            get
            {
                List<string> firmwares = Library.SelectMany(x => x.FirmwareTypes).Where(x => !x.EqualsIgnoreCase("-")).Distinct().ToList();
                firmwares.Sort();
                return firmwares.Distinct().ToList();
            }
        }

        /// <summary>
        /// Get all of the mod types from the specified <see cref="Category.Id" />
        /// </summary>
        /// <param name="categoryId">
        /// <see cref="Category.Id" />
        /// </param>
        /// <returns> </returns>
        public List<string> AllModTypesForCategoryId(string categoryId)
        {
            List<string> modTypes = Library.Where(x => x.CategoryId.EqualsIgnoreCase(categoryId)).SelectMany(x => x.ModTypes).Distinct().ToList();
            modTypes.Sort();
            return modTypes;
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoriesData"></param>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="modType"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        public List<ModItemData> GetGameMods(CategoriesData categoriesData, string categoryId, string name, string firmware, string modType, string region, string version, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Region.ContainsIgnoreCase(region) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Region.ContainsIgnoreCase(region) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoriesData"></param>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="version"></param>
        /// <param name="favorites"
        /// <returns></returns>
        public List<ModItemData> GetHomebrew(CategoriesData categoriesData, string categoryId, string name, string firmware, string version, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="modType"></param>
        /// <param name="version"></param>
        /// <param name="favorites"</param>
        /// <returns></returns>
        public List<ModItemData> GetResources(CategoriesData categoriesData, string categoryId, string name, string firmware, string modType, string version, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Resource &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Resource &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="modId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="creator"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        public List<ModItemData> GetGameModsXbox(CategoriesData categoriesData, string categoryId, string name, string version, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="creator"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        public List<ModItemData> GetHomebrewXbox(CategoriesData categoriesData, string categoryId, string name, string version, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version))
                    .ToList();
            }
        }

        /// <summary>
        /// Get the <see cref="ModItemData" /> matching the specified <see cref="ModItemData.Id" />.
        /// </summary>
        /// <param name="id">
        /// <see cref="ModItemData.Id" />
        /// </param>
        /// <returns> Mod details for the <see cref="ModItemData.Id" /> </returns>
        public ModItemData GetModById(Platform platform, int id)
        {
            return Library.FirstOrDefault(modItem => modItem.GetPlatform() == platform && modItem.Id.Equals(id));
        }
    }
}