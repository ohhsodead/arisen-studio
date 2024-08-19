using ArisenStudio.Database;
using ArisenStudio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.Database
{
    public class TitleIdsDataXbox
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<TitleIdsXbox> Games { get; set; }

        /// <summary>
        /// Get the game title for the specified titleId.
        /// </summary>
        /// <param name="titleId"></param>
        /// <returns></returns>
        public string GetTitleFromTitleId(string titleId)
        {
            string gameTitle = Games.FirstOrDefault(x => x.TitleId.EqualsIgnoreCase(titleId)).GameTitle;

            return gameTitle == null ? "Unknown Game Title" : gameTitle;
        }

        /// <summary>
        /// Get the gameId for the specified game title.
        /// </summary>
        /// <param name="gameTitle"></param>
        /// <returns></returns>
        public string GetTitleIdFromTitle(string gameTitle)
        {
            string gameId = Games.FirstOrDefault(x => x.GameTitle.EqualsIgnoreCase(gameTitle)).TitleId;

            return gameId == null ? "Unknown Game ID" : gameId;
        }
    }
}