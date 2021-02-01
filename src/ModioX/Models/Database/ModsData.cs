using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using ModioX.Database;
using ModioX.Extensions;

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
        public List<ModItem> Mods { get; set; }

        /// <summary>
        /// Get all of the mod types from the specified <see cref="Category.Id" />
        /// </summary>
        /// <param name="categoryId"> <see cref="Category.Id" /> </param>
        /// <returns> </returns>
        public IEnumerable<string> AllModTypesForCategoryId(string categoryId)
        {
            var modTypes = Mods.Where(x => x.GameId.EqualsIgnoreCase(categoryId)).SelectMany(x => x.ModTypes).Distinct().ToList();
            modTypes.Sort();
            return modTypes;
        }

        /// <summary>
        /// Get the supported firmwares from all of the mods.
        /// </summary>
        /// <returns> Firmwares Supported </returns>
        public List<string> AllFirmwares
        {
            get
            {
                var firmwares = Mods.SelectMany(x => x.Firmwares).Where(x => !x.EqualsIgnoreCase("-")).Distinct().ToList();
                firmwares.Sort();
                return firmwares.ToList();
            }
        }

        /// <summary>
        /// Gets all of the mods for the specified gameId, with results filtered by name, firmware
        /// and type
        /// </summary>
        /// <param name="categoryId"> </param>
        /// <param name="name"> </param>
        /// <param name="firmware"> </param>
        /// <param name="type"> </param>
        /// <param name="region"> </param>
        /// <param name="isCustomList"> </param>
        /// <returns> </returns>
        public IEnumerable<ModItem> GetModItems(string categoryId, string name, string firmware, string type, string region, bool isCustomList)
        {
            if (categoryId.Equals("fvrt"))
            {
                return Mods.Where(x => MainWindow.Settings.FavoritedIds.Contains(x.Id)
                                       && x.Name.EqualsIgnoreCase(name)
                                       && x.Firmwares.Contains(firmware)
                                       && x.Type.EqualsIgnoreCase(type)
                                       && x.Region.EqualsIgnoreCase(region));
            }
            if (isCustomList)
            {
                return MainWindow.Settings.CustomLists
                    .Where(x => x.Name.EqualsIgnoreCase(categoryId))
                    .SelectMany(y => Mods.Where(x => y.ModIds.Contains(x.Id)
                                                     && x.Name.EqualsIgnoreCase(name)
                                                     && x.Firmwares.Contains(firmware)
                                                     && x.Type.EqualsIgnoreCase(type)
                                                     && x.Region.EqualsIgnoreCase(region)));
            }

            return Mods.Where(x => x.GameId.EqualsIgnoreCase(categoryId)
                                   && x.Name.EqualsIgnoreCase(name)
                                   && x.Firmwares.Contains(firmware)
                                   && x.Type.EqualsIgnoreCase(type)
                                   && x.Region.EqualsIgnoreCase(region));
        }

        /// <summary>
        /// Get the <see cref="ModItem" /> matching the specified <see cref="ModItem.Id" />.
        /// </summary>
        /// <param name="id"> <see cref="ModItem.Id" /> </param>
        /// <returns> Mod details for the <see cref="ModItem.Id" /> </returns>
        public ModItem GetModById(int id)
        {
            return Mods.FirstOrDefault(modItem => modItem.Id.Equals(id));
        }

        /// <summary>
        /// Get all the <see cref="ModItem" /> matching the specified <see cref="Category.Id" />.
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<ModItem> GetModsByCategoryId(string gameId)
        {
            return Mods.Where(x => x.GameId.EqualsIgnoreCase(gameId));
        }

        /// <summary>
        /// Get the total number of game mods.
        /// </summary>
        /// <returns> </returns>
        public int TotalGameMods(CategoriesData categoriesData)
        {
            return Mods.Count(x => x.GetCategoryType(categoriesData) == CategoryType.Game);
        }

        /// <summary>
        /// Get the total number of homebrew applications.
        /// </summary>
        /// <returns> </returns>
        public int TotalHomebrew(CategoriesData categoriesData)
        {
            return Mods.Count(x => x.GetCategoryType(categoriesData) == CategoryType.Homebrew);
        }

        /// <summary>
        /// Get the total number of resources.
        /// </summary>
        /// <returns> </returns>
        public int TotalResources(CategoriesData categoriesData)
        {
            return Mods.Count(x => x.GetCategoryType(categoriesData) == CategoryType.Resource);
        }
    }
}