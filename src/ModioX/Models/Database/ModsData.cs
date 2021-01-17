using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModioX.Models.Database
{
    public partial class ModsData
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<ModItem> Mods { get; set; }

        public partial class DownloadFiles
        {
            public string Name { get; set; }

            public string URL { get; set; }

            public List<string> InstallPaths { get; set; }

            /// <summary>
            /// Check whether any files are being installed to a game folder.
            /// </summary>
            public bool RequiresGameRegion => InstallPaths.Any(x => x.Contains("{REGION}"));

            /// <summary>
            /// Check whether any files are being installed to a profile user's folder.
            /// </summary>
            public bool RequiresUserId => InstallPaths.Any(x => x.Contains("{USERID}"));

            /// <summary>
            /// Check whether any files are being installed to a USB device.
            /// </summary>
            public bool RequiresUsbDevice => InstallPaths.Any(x => x.Contains("{USBDEV}"));

            /// <summary>
            /// Check whether any files are installed at the 'dev_rebug' (firmware) folder.
            /// </summary>
            /// <returns></returns>
            public bool IsInstallToRebugFolder => InstallPaths.Any(x => x.StartsWith("/dev_rebug/"));
        }

        /// <summary>
        /// Get all of the mod types from the specified <see cref="CategoriesData.Category.Id"/>
        /// </summary>
        /// <param name="categoryId"><see cref="CategoriesData.Category.Id"/></param>
        /// <returns></returns>
        public List<string> AllModTypesForCategoryId(string categoryId)
        {
            List<string> modTypes = new List<string>();

            foreach (ModItem modItem in Mods)
            {
                if (string.Equals(modItem.GameId, categoryId, StringComparison.CurrentCultureIgnoreCase))
                {
                    modTypes.AddRange(modItem.ModTypes);
                }
            }

            modTypes.Sort();
            return modTypes.Distinct().ToList();
        }

        /// <summary>
        /// Get the supported firmwares from all of the mods.
        /// </summary>
        /// <returns>Firmwares Supported</returns>
        public List<string> AllFirmwares
        {
            get
            {
                List<string> firmwares = new List<string>();

                foreach (ModItem modItem in Mods)
                {
                    foreach (string firmware in modItem.Firmware.Split('/'))
                    {
                        if (!firmwares.Contains(modItem.Firmware))
                        {
                            firmwares.Add(firmware);
                        }
                    }
                }

                firmwares.Sort();
                return firmwares;
            }
        }

        /// <summary>
        /// Gets all of the mods for the specified gameId, with results filtered by name, firmware and type
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        /// <param name="region"></param>
        /// <param name="isCustomList"></param>
        /// <returns></returns>
        public List<ModItem> GetModItems(string categoryId, string name, string firmware, string type, string region, bool isCustomList)
        {
            if (categoryId.Equals("fvrt"))
            {
                return (from ModItem modItem in Mods
                        where MainWindow.Settings.FavoritedIds.Contains(modItem.Id)
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmwares.Exists(x => x.ToLower().Contains(firmware.ToLower()))
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        && modItem.Region.ToLower().Contains(region.ToLower())
                        select modItem).ToList();
            }
            else if (isCustomList)
            {
                return (from customList in MainWindow.Settings.CustomLists
                        where customList.Name.Equals(categoryId)
                        from modItem in Mods
                        where customList.ModIds.Contains(modItem.Id)
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmwares.Exists(x => x.ToLower().Contains(firmware.ToLower()))
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        && modItem.Region.ToLower().Contains(region.ToLower())
                        select modItem).ToList();
            }
            else
            {
                return (from ModItem modItem in Mods
                        where string.Equals(modItem.GameId.ToLower(), categoryId.ToLower())
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmwares.Exists(x => x.ToLower().Contains(firmware.ToLower()))
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        && modItem.Region.ToLower().Contains(region.ToLower())
                        select modItem).ToList();
            }
        }

        /// <summary>
        /// Get the <see cref="ModItem"/> matching the specified <see cref="ModItem.Id"/>
        /// </summary>
        /// <param name="modId"><see cref="ModItem.Id"/></param>
        /// <returns>Mod details for the <see cref="ModItem.Id"/></returns>
        public ModItem GetModById(int modId)
        {
            return Mods.FirstOrDefault(modItem => modItem.Id.Equals(modId));
        }

        /// <summary>
        /// Get all the <see cref="ModItem"/> matching the specified <see cref="CategoriesData.Category.Id"/>.
        /// </summary>
        /// <returns></returns>
        public ModItem[] GetModsByCategoryId(string gameId)
        {
            return (from ModItem modItem in Mods
                    where modItem.GameId.Equals(gameId)
                    select modItem).ToArray();
        }

        /// <summary>
        /// Get the total number of game mods
        /// </summary>
        /// <returns></returns>
        public int TotalGameMods(CategoriesData categoriesData)
        {
            return (from ModItem modItem in Mods
                    where modItem.GetCategoryType(categoriesData) == CategoryType.Game
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Homebrew
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Resource
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Favorite
                    select modItem).Count();
        }

        /// <summary>
        /// Get the total number of resources.
        /// </summary>
        /// <returns></returns>
        public int TotalHomebrew(CategoriesData categoriesData)
        {
            return (from ModItem modItem in Mods
                    where modItem.GetCategoryType(categoriesData) == CategoryType.Homebrew
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Game
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Resource
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Favorite
                    select modItem).Count();
        }


        /// <summary>
        /// Get the total number of resources.
        /// </summary>
        /// <returns></returns>
        public int TotalResources(CategoriesData categoriesData)
        {
            return (from ModItem modItem in Mods
                    where modItem.GetCategoryType(categoriesData) == CategoryType.Resource
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Homebrew
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Game
                    && modItem.GetCategoryType(categoriesData) != CategoryType.Favorite
                    select modItem).Count();
        }
    }
}