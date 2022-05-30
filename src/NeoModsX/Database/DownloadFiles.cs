using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

namespace NeoModsX.Database
{
    // Get the downloads information.
    public class DownloadFiles
    {
        public string Name { get; set; }

        [DataMember]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("n/a")]
        public string Region { get; set; } = string.Empty;

        public string Version { get; set; }

        public DateTime LastUpdated { get; set; }

        public string Url { get; set; }

        public List<string> InstallPaths { get; set; }

        /// <summary>
        /// Check whether any files are being installed to a game folder.
        /// </summary>
        public bool RequiresGameRegion => InstallPaths.Any(x => x.Contains("{REGION}"));

        /// <summary>
        /// Check whether any files are being installed to a profile user's folder.
        /// </summary>
        public bool RequiresUserId => InstallPaths.Any(x => x.Contains("{USERID}"));

        /// <summary>
        /// Check whether any files are being installed to a USB device.
        /// </summary>
        public bool RequiresUsbDevice => InstallPaths.Any(x => x.Contains("{USBDEV}"));

        /// <summary>
        /// Check whether any files are installed at the 'dev_rebug' (firmware) folder.
        /// </summary>
        /// <returns> </returns>
        public bool InstallsToGameFolder => InstallPaths.Any(x => x.Contains("dev_hdd0/game/"));

        /// <summary>
        /// Check whether any files are installed at the 'dev_rebug' (firmware) folder.
        /// </summary>
        /// <returns> </returns>
        public bool InstallsToRebugFolder => InstallPaths.Any(x => x.StartsWith("/dev_rebug/"));
    }
}