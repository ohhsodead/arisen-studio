using ArisenStudio.Database;
using ArisenStudio.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ArisenStudio.Models.Database
{
    public class PackagesData
    {
        /// <summary>
        /// Get the packages category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Get the packages.
        /// </summary>
        public List<PackageItemData> Packages { get; set; }

        /// <summary>
        /// Get the game title for the specified titleId.
        /// </summary>
        /// <param name="gameRegion"></param>
        /// <returns></returns>
        public string GetNameFromTitleId(string titleId)
        {
            return Packages.FirstOrDefault(x => x.Region.EqualsIgnoreCase(titleId)).Name;
        }

        /// <summary>
        /// Get the gameId for the specified game title.
        /// </summary>
        /// <param name="gameTitle"></param>
        /// <returns></returns>
        public string GetTitleIdFromName(string name)
        {
            return Packages.FirstOrDefault(x => x.Name.EqualsIgnoreCase(name)).TitleId;
        }
    }
}