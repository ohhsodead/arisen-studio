using ModioX.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace ModioX.Models
{
    public partial class ModsData
    {
        public ModItem[] Mods { get; set; }

        public class ModItem
        {
            public long Id { get; set; }
            public string GameId { get; set; }
            public string Name { get; set; }
            public string Firmware { get; set; }
            public string Author { get; set; }
            public string SubmittedBy { get; set; }
            public string Version { get; set; }
            public string Configuration { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public string[] InstallPaths { get; set; }
        }

        /// <summary>
        /// Gets modds that match the specified game id
        /// </summary>
        /// <returns></returns>
        public List<ModItem> GetModsByGameId(string gameId)
        {
            List<ModItem> modsById = new List<ModItem>();

            foreach (ModItem modItem in Mods)
            {
                if (modItem.GameId.Equals(gameId))
                {
                    modsById.Add(modItem);
                }
            }

            return modsById;
        }

        /// <summary>
        /// Gets the total number of game mods
        /// </summary>
        /// <returns></returns>
        public int GetTotalGameMods()
        {
            int countGameMods = 0;

            foreach (ModItem modItem in Mods)
            {
                if (!modItem.GameId.Equals("fvrt") && !modItem.GameId.Equals("gu") && !modItem.GameId.Equals("hhr") && !modItem.GameId.Equals("ha") && !modItem.GameId.Equals("hg") && !modItem.GameId.Equals("th") && !modItem.GameId.Equals("xmbr"))
                {
                    countGameMods++;
                }
            }

            return countGameMods;
        }

        /// <summary>
        /// Gets the total number of homebrew packages
        /// </summary>
        /// <returns></returns>
        public int GetTotalHomebrew()
        {
            int countHomebrew = 0;

            foreach (ModItem modItem in Mods)
            {
                if (modItem.GameId.Equals("ha") || modItem.GameId.Equals("hg"))
                {
                    countHomebrew++;
                }
            }

            return countHomebrew;
        }

        /// <summary>
        /// Gets the total number of game update packages
        /// </summary>
        /// <returns></returns>
        public int GetTotalGameUpdates()
        {
            int countGameUpdates = 0;

            foreach (ModItem modItem in Mods)
            {
                if (modItem.GameId.Equals("gu"))
                {
                    countGameUpdates++;
                }
            }

            return countGameUpdates;
        }

        /// <summary>
        /// Gets the total number of themes
        /// </summary>
        /// <returns></returns>
        public int GetTotalThemes()
        {
            int countThemes = 0;

            foreach (ModItem modItem in Mods)
            {
                if (modItem.Type.Equals("P3T"))
                {
                    countThemes++;
                }
            }

            return countThemes;
        }

        /// <summary>
        /// Gets the total number of resources
        /// </summary>
        /// <returns></returns>
        public int GetTotalResources()
        {
            int countThemes = 0;

            foreach (ModItem modItem in Mods)
            {
                if (modItem.GameId.Equals("hhr") || modItem.GameId.Equals("xmbr"))
                {
                    countThemes++;
                }
            }

            return countThemes;
        }
    }
}