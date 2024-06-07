using System.Collections.Generic;

namespace ArisenStudio.Models.Dashboard
{
    public partial class FavoriteGamesData
    {
        /// <summary>
        /// Get the top games.
        /// </summary>
        public List<Favorite> Favorites { get; set; }

        public partial class Favorite
        {
            public string CategoryId { get; set; }

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