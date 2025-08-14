using Newtonsoft.Json;

namespace ArisenStudio.Models.Database
{
    public class StatsData
    {
        /// <summary>
        /// Get the total number of downloads of the application.
        /// </summary>
        [JsonProperty("totalDownloads")]
        public int TotalDownloads { get; set; }

        /// <summary>
        /// Get total number of mods in the database, not including packages.
        /// </summary>
        [JsonProperty("totalMods")]
        public int TotalMods { get; set; }
    }
}