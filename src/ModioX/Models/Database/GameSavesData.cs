using System;
using System.Collections.Generic;
using System.Linq;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;

namespace ModioX.Models.Database
{
    public class GameSavesData
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<GameSaveItemData> GameSaves { get; set; }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="consoleType"></param>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        public List<GameSaveItemData> GetGameSaveItems(PlatformPrefix consoleType, string categoryId, string name, string region, string version, string author)
        {
            return categoryId switch
            {
                "fvrt" => GameSaves.Where(x =>
                MainWindow.Settings.FavoriteIds.Any(y => y.Platform.Equals(consoleType) && y.Ids.Contains(x.Id)) &&
                x.Name.ContainsIgnoreCase(name) &&
                x.Region.ContainsIgnoreCase(region) &&
                x.Version.ContainsIgnoreCase(version) &&
                x.Creators.ToArray().AnyContainsIgnoreCase(author))
                .ToList(),
                _ => GameSaves.Where(x =>
                    x.GetPlatform() == consoleType &&
                    (categoryId.IsNullOrEmpty() ? x.CategoryId.ContainsIgnoreCase(categoryId) : x.CategoryId.EqualsIgnoreCase(categoryId)) &&
                    x.Name.ContainsIgnoreCase(name) &&
                    x.Region.ContainsIgnoreCase(region) &&
                    x.Version.ContainsIgnoreCase(version) &&
                    x.Creators.ToArray().AnyContainsIgnoreCase(author))
                    .ToList()
            };
        }

        /// <summary>
        /// Get the <see cref="ModItemData" /> matching the specified <see cref="ModItemData.Id" />.
        /// </summary>
        /// <param name="id"> <see cref="ModItemData.Id" /> </param>
        /// <returns> Mod details for the <see cref="ModItemData.Id" /> </returns>
        public GameSaveItemData GetModById(PlatformPrefix consoleType, int id)
        {
            return GameSaves.FirstOrDefault(x => x.GetPlatform() == consoleType && x.Id.Equals(id));
        }

        /// <summary>
        /// Get all the <see cref="ModItemData" /> matching the specified <see cref="Category.Id" />.
        /// </summary>
        /// <returns> </returns>
        public List<GameSaveItemData> GetModsByCategoryId(string categoryId)
        {
            return GameSaves.Where(x => x.CategoryId.EqualsIgnoreCase(categoryId)).ToList();
        }
    }
}