using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms.Windows;

namespace ModioX.Models.Database
{
    public class CategoriesData
    {
        /// <summary>
        ///     Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        ///     Get all of the supported categories/games from the database.
        /// </summary>
        public List<Category> Categories { get; set; }

        /// <summary>
        ///     Get the total number of games.
        /// </summary>
        /// <returns></returns>
        public int TotalGames => (from Category category in Categories
                                  where category.CategoryType == CategoryType.Game
                                  select category).Count();

        /// <summary>
        ///     Get the game regions for the specified <see cref="Category.Id" />.
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public List<string> GetGameRegions(string gameId)
        {
            foreach (var category in from Category category in Categories
                where category.Id.Equals(gameId)
                select category)
            {
                return category.Regions.ToList();
            }

            throw new Exception("Unable to find game matching the specified id: " + gameId);
        }

        /// <summary>
        ///     Get all of the categories that is of <see cref="CategoryType" />.
        /// </summary>
        /// <param name="categoryType"></param>
        /// <returns></returns>
        public List<Category> GetCategoriesByType(CategoryType categoryType)
        {
            return (from Category game in Categories
                where game.CategoryType == categoryType
                select game).ToList();
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="categoryId">Title of the game</param>
        /// <returns>Game information</returns>
        public Category GetCategoryById(string categoryId)
        {
            foreach (var category in from Category category in Categories
                where category.Id.ToLower().Equals(categoryId.ToLower())
                select category)
            {
                return category;
            }

            throw new Exception("Unable to find game data matching the specified id: " + categoryId);
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="title">Title of the game</param>
        /// <returns>Game information</returns>
        public Category GetCategoryByTitle(string title)
        {
            foreach (var game in from Category game in Categories
                where game.Title.ToLower().Equals(title.ToLower())
                select game)
            {
                return game;
            }

            throw new Exception("Unable to find game data for the specified title: " + title);
        }

        /// <summary>
        ///     Get the category details, such as id, title, region and type.
        /// </summary>
        public class Category
        {
            public string Id { get; set; }

            public string Title { get; set; }

            public string Type { get; set; }

            public string[] Regions { get; set; }

            /// <summary>
            ///     Get the category type.
            /// </summary>
            public CategoryType CategoryType
            {
                get
                {
                    switch (Type)
                    {
                        case "game": return CategoryType.Game;
                        case "homebrew": return CategoryType.Homebrew;
                        case "resource": return CategoryType.Resource;
                        case "favorite": return CategoryType.Favorite;
                        default: return CategoryType.Game;
                    }
                }
            }

            /// <summary>
            ///     Return the user's game region, either automatically by searching existing console directories or prompt
            ///     the user to select one.
            /// </summary>
            /// <param name="owner">Parent form</param>
            /// <param name="gameId">Game Id</param>
            /// <returns></returns>
            public string GetGameRegion(Form owner, string gameId)
            {
                if (MainWindow.Settings.RememberGameRegions)
                {
                    var gameRegion = MainWindow.Settings.GetGameRegion(gameId);

                    if (!string.IsNullOrEmpty(gameRegion))
                    {
                        return gameRegion;
                    }
                }

                if (MainWindow.Settings.AutoDetectGameRegion)
                {
                    var foundRegions = Regions.Where(region => MainWindow.FtpConnection.DirectoryExists($"/dev_hdd0/game/{region}")).ToList();

                    foreach (var region in foundRegions.Where(region => DarkMessageBox.Show(MainWindow.Window,
                        $"Game Region: {region} has been found for: {Title}\nIs this correct?", "Found Game Region",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        return region;
                    }

                    _ = DarkMessageBox.Show(MainWindow.Window,
                        "Could not find any regions on your console for this game title. Make sure you have updated your game correctly, updates will be found under 'Game Data Utility' if you have this installed already.",
                        "No Game Region Found", MessageBoxIcon.Error);
                    return null;
                }

                return DialogExtensions.ShowListInputDialog(owner, "Game Regions", Regions.ToList());
            }
        }
    }

    /// <summary>
    ///     Category types
    /// </summary>
    public enum CategoryType
    {
        Game,
        Homebrew,
        Resource,
        Favorite
    }
}