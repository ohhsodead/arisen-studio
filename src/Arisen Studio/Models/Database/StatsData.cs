using ArisenStudio.Database;
using ArisenStudio.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

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