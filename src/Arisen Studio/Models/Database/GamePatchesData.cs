using ArisenStudio.Database;
using ArisenStudio.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.Database
{
    public class GamePatchesData
    {
        /// <summary>
        /// Get the mods from the database.
        /// </summary>
        public List<GamePatchItemData> GamePatches { get; set; } = [];

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        //public List<GamePatchItemData> GetGameCheatsItems(string game, string region, string version)
        //{
        //    return GamePatches.Where(x =>
        //            (game.IsNullOrEmpty() ? x.Game.ContainsIgnoreCase(game) : x.Game.EqualsIgnoreCase(game)) &&
        //            x.Region.ContainsIgnoreCase(region) &&
        //            x.Version.ContainsIgnoreCase(version))
        //            .ToList();
        //}

        /// <summary>
        /// Get the <see cref="GamePatchItemData" /> matching the specified <see cref="GamePatchItemData.Id" />.
        /// </summary>
        /// <param name="game"> <see cref="GamePatchItemData.Game"/> </param>
        /// <param name="region"> <see cref="GamePatchItemData.Region" /> </param>
        /// <param name="version"> <see cref="GamePatchItemData.Version"/> </param>
        /// <returns> Mod details for the <see cref="GamePatchItemData.Region" /> and <see cref="GamePatchItemData.Game"/> </returns>
        public GamePatchItemData GetGamePatchByTitleId(string titleName, string titleId)
        {
            return GamePatches.FirstOrDefault(x => x.TitleName.Equals(titleName) && x.TitleId.Equals(titleId));
        }

        /// <summary>
        /// Get all the <see cref="GamePatchItemData" /> matching the specified <see cref="GamePatchItemData.Game" />.
        /// </summary>
        /// <returns> </returns>
        //public List<GamePatchItemData> GetGameCheatsByCategoryId(string game)
        //{
        //    return GamePatches.Where(x => x.Game.EqualsIgnoreCase(game)).ToList();
        //}

        /// <summary>
        /// Get all of the mods matching the specified filters.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="region"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public int GetTotalCheats()
        {
            HashSet<string> set = [];

            foreach (GamePatchItemData list in GamePatches)
            {
                foreach (Patch item in list.Patch)
                {
                    set.Add(item.Name);
                }
            }
            return set.Count;
        }
    }
}