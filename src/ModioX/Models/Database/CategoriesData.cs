using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms;
using ModioX.Models.Resources;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Models.Database
{
    public partial class CategoriesData
    {
        /// <summary>
        ///     
        /// </summary>
        public List<Category> Categories { get; set; }

        /// <summary>
        ///     
        /// </summary>
        public partial class Category
        {
            public string Id { get; set; }

            /// <summary>
            ///     
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            ///     
            /// </summary>
            public string Type { get; set; }

            /// <summary>
            ///     
            /// </summary>
            public string[] Regions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public CategoryType CategoryType
            {
                get
                {
                    switch (Type)
                    {
                        case "game": return CategoryType.Game;
                        case "resource": return CategoryType.Resource;
                        case "favorite": return CategoryType.Favorite;
                        default: return CategoryType.Game;
                    }
                }
            }

            /// <summary>
            ///     Returns the users game region, either automatically set region by searching existing console directories or prompt
            ///     the user to select one
            /// </summary>
            /// <param name="hostAddress">Console ip address</param>
            /// <param name="gameId">Game Id</param>
            /// <returns></returns>
            public string GetGameRegion(string hostAddress, string gameId)
            {
                if (MainForm.SettingsData.RememberGameRegions)
                {
                    string gameRegion = MainForm.SettingsData.GetGameRegion(gameId);

                    if (!string.IsNullOrEmpty(gameRegion))
                    {
                        return gameRegion;
                    }
                }

                if (MainForm.SettingsData.AutoDetectGameRegion)
                {
                    List<string> detectedRegions = new List<string>();

                    using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
                    {
                        foreach (string region in Regions)
                        {
                            if (ftpConnection.DirectoryExists($"/dev_hdd0/game/{region}"))
                            {
                                detectedRegions.Add(region);
                            }
                        }
                    }

                    foreach (string region in detectedRegions)
                    {
                        if (DarkMessageBox.Show(MainForm.mainForm, $"Game Region: {region} has been found for: {Title}\nIs this the correct game region?", "Found Game Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            return region;
                        }
                    }

                    _ = DarkMessageBox.Show(MainForm.mainForm, "Could not find any regions on your console for this game title. Make sure you have updated your game correctly, updates will be found under 'Game Data Utility' if you have this installed already.", "No Game Region Found", MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return Utilities.GetItemFromList("Game Regions", Regions.ToList());
                }
            }
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public List<string> GetGameRegions(string gameId)
        {
            foreach (Category category in Categories)
            {
                if (category.CategoryType == CategoryType.Game)
                {
                    if (category.Id.Equals(gameId))
                    {
                        return category.Regions.ToList();
                    }
                }
            }

            throw new Exception("Unable to find game matching the specified game id");
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="categoryId">Title of the game</param>
        /// <returns>Game information</returns>
        public Category GetCategoryById(string categoryId)
        {
            foreach (Category game in from Category game in Categories
                                      where game.Id.ToLower().Equals(categoryId.ToLower())
                                      select game)
            {
                return game;
            }
            throw new Exception("Unable to find game data matching the specified game id");
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="title">Title of the game</param>
        /// <returns>Game information</returns>
        public Category GetCategoryByTitle(string title)
        {
            foreach (Category game in from Category game in Categories
                                      where game.Title.ToLower().Equals(title.ToLower())
                                      select game)
            {
                return game;
            }

            throw new Exception("Unable to find game data for the specified game title");
        }

        /// <summary>
        /// Gets the total number of games, these are defined by having regions
        /// </summary>
        /// <returns></returns>
        public int TotalGames => (from Category category in Categories
                                  where category.Regions.Length > 0
                                  select category).Count();
    }

    /// <summary>
    ///     
    /// </summary>
    public enum CategoryType
    {
        Game,
        Resource,
        Favorite
    }
}