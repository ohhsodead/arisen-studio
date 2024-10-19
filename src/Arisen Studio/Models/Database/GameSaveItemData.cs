using Humanizer;
using ArisenStudio;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Io;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using ArisenStudio.Models.Database;
using System.Threading.Tasks;

namespace ArisenStudio.Models.Database
{
    /// <summary>
    /// Get the game save information.
    /// </summary>
    public class GameSaveItemData
    {
        public string Platform { get; set; }

        public int Id { get; set; }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public string Region { get; set; }

        public DateTime LastUpdated { get; set; }

        public string CreatedBy { get; set; }

        public string SubmittedBy { get; set; }

        public string Version { get; set; }

        public string GameMode { get; set; }

        public string Description { get; set; }

        public List<DownloadFiles> DownloadFiles { get; set; }

        public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());

        public Platform GetPlatform()
        {
            return Platform switch
            {
                "PS3" => ArisenStudio.Platform.PS3,
                "XBOX" => ArisenStudio.Platform.XBOX360,
                "PS4" => ArisenStudio.Platform.PS4,
                _ => ArisenStudio.Platform.PS3
            };
        }
    }
}