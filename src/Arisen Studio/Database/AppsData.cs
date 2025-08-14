using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.Database
{
    public class AppsData
    {
        /// <summary>
        /// Get the apps from the database.
        /// </summary>
        public List<AppItemData> Library { get; set; }

        /// <summary>
        /// Get the supported firmwares from all of the mods.
        /// </summary>
        /// <returns> Firmwares Supported </returns>
        public List<string> Versions
        {
            get
            {
                List<string> firmwares = Library.SelectMany(x => x.Versions).Where(x => !x.EqualsIgnoreCase("-")).Distinct().ToList();
                firmwares.Sort();
                return firmwares.Distinct().ToList();
            }
        }

        /// <summary>
        /// Get all of the apps matching the specified filters.
        /// </summary>
        /// <param name="categoriesData"></param>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="fwVersion"></param>
        /// <param name="version"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        public List<AppItemData> GetHomebrew(CategoriesData categoriesData, string categoryId, string name, string version, string fwVersion, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    //x.GetCategoryName(categoriesData).EqualsIgnoreCase(categoryId) &&
                    //x.GetCategoryType(categoriesData) == CategoryType.Homebrew &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareVersions.Exists(y => y.ContainsIgnoreCase(fwVersion)) &&
                    //x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Versions.Exists(y => y.ContainsIgnoreCase(version)))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    //x.GetCategoryName(categoriesData).EqualsIgnoreCase(categoryId) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareVersions.Exists(y => y.ContainsIgnoreCase(fwVersion)) &&
                    //x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Versions.Exists(y => y.ContainsIgnoreCase(version)))
                    .ToList();
            }
        }

        /// <summary>
        /// Get all of the apps matching the specified filters.
        /// </summary>
        /// <param name="categoriesData"></param>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="fwVersion"></param>
        /// <param name="version"></param>
        /// <param name="favorites"></param>
        /// <returns></returns>
        public List<AppItemData> GetGames(CategoriesData categoriesData, string categoryId, string name, string version, string fwVersion, bool favorites = false)
        {
            if (favorites)
            {
                return Library.Where(x =>
                    MainWindow.Settings.FavoriteMods.Exists(y => y.ModId == x.Id) &&
                    //x.GetCategoryName(categoriesData).EqualsIgnoreCase(categoryId) &&
                    //x.GetCategoryType(categoriesData) == CategoryType.Game &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareVersions.Exists(y => y.ContainsIgnoreCase(fwVersion)) &&
                    //x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Versions.Exists(y => y.ContainsIgnoreCase(version)))
                    .ToList();
            }
            else
            {
                return Library.Where(x =>
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    //x.GetCategoryName(categoriesData).EqualsIgnoreCase(categoryId) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.FirmwareVersions.Exists(y => y.ContainsIgnoreCase(fwVersion)) &&
                    //x.Versions.ToArray().AnyContainsIgnoreCase(version) &&
                    x.Versions.Exists(y => y.ContainsIgnoreCase(version)))
                    .ToList();
            }
        }

        /// <summary>
        /// Get the <see cref="AppItemData" /> matching the specified <see cref="AppItemData.Id" />.
        /// </summary>
        /// <param name="id">
        /// <see cref="AppItemData.Id" />
        /// </param>
        /// <returns> App details for the <see cref="AppItemData.Id" /> </returns>
        public AppItemData GetModById(int id)
        {
            return Library.First(modItem => modItem.Id.Equals(id));
        }
    }
}