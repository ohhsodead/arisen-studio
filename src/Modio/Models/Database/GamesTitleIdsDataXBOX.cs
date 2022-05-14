using Modio.Database;
using Modio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Modio.Models.Database
{
    public class GamesTitleIdsDataXBOX
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<GamesTitleIdsXBOX> Games { get; set; }

        /// <summary>
        /// Get the game title for the specified titleId.
        /// </summary>
        /// <param name="titleId"></param>
        /// <returns></returns>
        public string GetTitleFromTitleId(string titleId)
        {
            return Games.FirstOrDefault(x => x.TitleId.EqualsIgnoreCase(titleId)).GameTitle;
        }

        /// <summary>
        /// Get the gameId for the specified game title.
        /// </summary>
        /// <param name="gameTitle"></param>
        /// <returns></returns>
        public string GetTitleIdFromTitleId(string gameTitle)
        {
            return Games.FirstOrDefault(x => x.GameTitle.EqualsIgnoreCase(gameTitle)).TitleId;
        }
    }
}