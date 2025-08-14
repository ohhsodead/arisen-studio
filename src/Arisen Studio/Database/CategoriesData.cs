﻿using ArisenStudio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.Database
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
        public List<CategoryItem> Categories { get; set; }

        /// <summary>
        /// Get the total number of games.
        /// </summary>
        /// <returns> </returns>
        public int TotalGames => Categories.Count(x => x.CategoryType == CategoryType.Game);

        /// <summary>
        /// Get all of the categories that is of <see cref="CategoryType" />.
        /// </summary>
        /// <param name="categoryType"> </param>
        /// <returns> </returns>
        public IEnumerable<CategoryItem> GetCategoriesByType(CategoryType categoryType)
        {
            return Categories.Where(x => x.CategoryType == categoryType);
        }

        /// <summary>
        /// Get the Category data matching the specified CategoryId
        /// </summary>
        /// <param name="categoryId"> Title of the game </param>
        /// <returns> Game information </returns>
        public CategoryItem GetCategoryById(string categoryId)
        {
            CategoryItem category = Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(categoryId));

            if (category != null)
            {
                return category;
            }

            throw new Exception("Unable to find category data matching the specified id: " + categoryId);
        }

        /// <summary>
        /// Get the Category data for the first match of the Title
        /// </summary>
        /// <param name="title"> Title of the game </param>
        /// <returns> Game information </returns>
        public CategoryItem GetCategoryByTitle(string title)
        {
            CategoryItem category = Categories.FirstOrDefault(x => x.Title.EqualsIgnoreCase(title));

            if (category != null)
            {
                return category;
            }

            throw new Exception("Unable to find game data for the specified title: " + title);
        }
    }
}