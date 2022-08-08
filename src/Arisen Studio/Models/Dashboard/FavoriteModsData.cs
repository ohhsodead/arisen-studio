using System.Collections.Generic;

namespace ArisenStudio.Models.Dashboard
{
    public partial class FavoriteModsData
    {
        /// <summary>
        /// Get the announcements.
        /// </summary>
        public List<Favorite> Favorites { get; set; }

        public partial class Favorite
        {
            public string CategoryId { get; set; }

            public int ModId { get; set; }

            public string Name { get; set; }

            public string Message { get; set; }

            public string ImageUrl { get; set; }

            public string Platform { get; set; }

            public Platform GetPlatform()
            {
                return Platform switch
                {
                    "PS3" => ArisenStudio.Platform.PS3,
                    "XBOX" => ArisenStudio.Platform.XBOX360,
                    _ => ArisenStudio.Platform.PS3
                };
            }
        }
    }
}