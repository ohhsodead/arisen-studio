using System;
using System.Collections.Generic;
using System.Linq;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;

namespace ModioX.Models.Database
{
    public class ModsData
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<ModItemData> Mods { get; set; }

        /// <summary>
        /// Get the supported firmwares from all of the mods.
        /// </summary>
        /// <returns> Firmwares Supported </returns>
        public List<string> AllFirmwareTypes
        {
            get
            {
                List<string> firmwares = Mods.SelectMany(x => x.FirmwareTypes).Where(x => !x.EqualsIgnoreCase("-")).Distinct().ToList();
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
            List<string> modTypes = Mods.Where(x => x.CategoryId.EqualsIgnoreCase(categoryId)).SelectMany(x => x.ModTypes).Distinct().ToList();
            modTypes.Sort();
            return modTypes;
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="consoleType"></param>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="modType"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <param name="isCustomList"></param>
        /// <returns></returns>
        public List<ModItemData> GetModItems(CategoriesData categoriesData, string categoryId, string name, string firmware, string modType, string region, string version, string creator, bool favorites = false)
        {
            if (favorites)
            {
                return Mods.Where(x =>
                    MainWindow.Settings.FavoriteIds.Exists(y => y.Platform == PlatformPrefix.PS3 && y.Ids.Contains(x.Id)) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Region.ContainsIgnoreCase(region) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                    .ToList();
            }
            else
            {
                return Mods.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Region.ContainsIgnoreCase(region) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        public List<ModItemData> GetHomebrewItems(CategoriesData categoriesData, string categoryId, string name, string firmware, string version, string creator, bool favorites = false)
        {
            if (favorites)
            {
                return Mods.Where(x =>
                    MainWindow.Settings.FavoriteIds.Exists(y => y.Platform == PlatformPrefix.PS3 && y.Ids.Contains(x.Id)) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                    .ToList();
            }
            else
            {
                return Mods.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="version"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        public List<ModItemData> GetResourceItems(CategoriesData categoriesData, string categoryId, string name, string firmware, string modType, string version, string creator, bool favorites = false)
        {
            if (favorites)
            {
                return Mods.Where(x =>
                    MainWindow.Settings.FavoriteIds.Exists(y => y.Platform == PlatformPrefix.PS3 && y.Ids.Contains(x.Id)) &&
                    x.GetCategoryType(categoriesData) == CategoryType.Resource &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                    .ToList();
            }
            else
            {
                return Mods.Where(x =>
                    x.GetCategoryType(categoriesData) == CategoryType.Resource &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareTypes.Exists(y => y.ContainsIgnoreCase(firmware)) &&
                    x.ModType.ContainsIgnoreCase(modType) &&
                    x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        public List<ModItemData> GetPluginItems(string categoryId, string name, string version, string creator, bool favorites = false)
        {
            if (favorites)
            {
                return Mods.Where(x =>
                MainWindow.Settings.FavoriteIds.Exists(y => y.Platform == PlatformPrefix.XBOX && y.Ids.Contains(x.Id)) &&
                (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId))
                && x.Name.ContainsIgnoreCase(name)
                && x.Versions.ToArray().AnyContainsIgnoreCase(version)
                && x.Creators.ToArray().AnyContainsIgnoreCase(creator))
                .ToList();
            }
            else
            {
                return Mods.Where(x =>
                (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId))
                && x.Name.ContainsIgnoreCase(name)
                && x.Versions.ToArray().AnyContainsIgnoreCase(version)
                && x.Creators.ToArray().AnyContainsIgnoreCase(creator))
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
        public ModItemData GetModById(PlatformPrefix consoleType, int id)
        {
            return Mods.FirstOrDefault(modItem => modItem.GetPlatform() == consoleType && modItem.Id.Equals(id));
        }
    }
}