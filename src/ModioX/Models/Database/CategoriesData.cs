using System;
using System.Collections.Generic;
using System.Linq;

namespace ModioX.Models.Database
{
    public class CategoriesData
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get all of the supported categories/games from the database.
        /// </summary>
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Get the total number of games.
        /// </summary>
        /// <returns></returns>
        public int TotalGames => (from Category category in Categories
                                  where category.CategoryType == CategoryType.Game
                                  select category).Count();

        /// <summary>
        /// Get the game regions for the specified <see cref="Category.Id" />.
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
        /// Get all of the categories that is of <see cref="CategoryType" />.
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
        /// Get the game data matching the specified title
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
        /// Get the game data matching the specified title
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
    }

    /// <summary>
    /// Category types
    /// </summary>
    public enum CategoryType
    {
        Game,
        Homebrew,
        Resource,
        Favorite
    }
}