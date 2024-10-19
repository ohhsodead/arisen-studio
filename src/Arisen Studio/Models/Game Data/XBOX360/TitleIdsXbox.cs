using ArisenStudio.Database;
using ArisenStudio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.GameData.XBOX
{
    public class XboxTitleIds
    {
        /// <summary>
        /// Date/time the file was updated in ISO format
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// All of the title IDs for Xbox 360
        /// </summary>
        public List<GameXbox> Games { get; set; }

        /// <summary>
        /// Get the Game Title for the specified title ID
        /// </summary>
        /// <param name="titleId"></param>
        /// <returns></returns>
        public string GetTitleFromTitleId(string titleId)
        {
            string gameTitle = Games.FirstOrDefault(x => x.TitleId.EqualsIgnoreCase(titleId)).GameTitle;

            return gameTitle ?? "Unknown Title";
        }

        /// <summary>
        /// Get the Title ID for the specified Game Title
        /// </summary>
        /// <param name="gameTitle"></param>
        /// <returns></returns>
        public string GetTitleIdFromTitle(string gameTitle)
        {
            string gameId = Games.FirstOrDefault(x => x.GameTitle.EqualsIgnoreCase(gameTitle)).TitleId;

            return gameId ?? "Unknown Title ID";
        }
    }
}