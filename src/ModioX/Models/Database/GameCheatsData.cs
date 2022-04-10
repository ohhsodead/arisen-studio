using ModioX.Database;
using ModioX.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModioX.Models.Database
{
    public class GameCheatsData
    {
        /// <summary>
        /// Get the date/time the database was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<GameCheatItemData> GameCheats { get; set; } = new();

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<GameCheatItemData> GetGameCheatsItems(string game, string region, string version)
        {
            return GameCheats.Where(x =>
                    (game.IsNullOrEmpty() ? x.Game.ContainsIgnoreCase(game) : x.Game.EqualsIgnoreCase(game)) &&
                    x.Region.ContainsIgnoreCase(region) &&
                    x.Version.ContainsIgnoreCase(version))
                    .ToList();
        }

        /// <summary>
        /// Get the <see cref="GameCheatItemData" /> matching the specified <see cref="GameCheatItemData.Id" />.
        /// </summary>
        /// <param name="game"> <see cref="GameCheatItemData.Game"/> </param>
        /// <param name="region"> <see cref="GameCheatItemData.Region" /> </param>
        /// <param name="version"> <see cref="GameCheatItemData.Version"/> </param>
        /// <returns> Mod details for the <see cref="GameCheatItemData.Region" /> and <see cref="GameCheatItemData.Game"/> </returns>
        public GameCheatItemData GetGameCheatById(string game, string region, string version)
        {
            return GameCheats.FirstOrDefault(x => x.Region.Equals(region) && x.Game.Equals(game) && x.Version.Equals(version));
        }

        /// <summary>
        /// Get all the <see cref="GameCheatItemData" /> matching the specified <see cref="GameCheatItemData.Game" />.
        /// </summary>
        /// <returns> </returns>
        public List<GameCheatItemData> GetGameCheatsByCategoryId(string game)
        {
            return GameCheats.Where(x => x.Game.EqualsIgnoreCase(game)).ToList();
        }

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public int GetTotalCheats()
        {
            HashSet<string> set = new();

            foreach (var list in GameCheats)
            {
                foreach (var item in list.Cheats)
                {
                    set.Add(item.Name);
                }
            }
            return set.Count;
        }
    }
}