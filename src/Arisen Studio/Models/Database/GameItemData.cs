﻿namespace ArisenStudio.Models.Database
{
    /// <summary>
    /// Get the downloads information.
    /// </summary>
    public class GameItemData
    {
        public string Game { get; set; }

        public string Region { get; set; }

        public string Version { get; set; }

        public string File { get; set; }
    }
}