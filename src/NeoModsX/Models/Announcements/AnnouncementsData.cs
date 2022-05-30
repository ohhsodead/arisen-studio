using System;
using System.Collections.Generic;

namespace NeoModsX.Models.Database
{
    public class AnnouncementsData
    {
        /// <summary>
        /// Get the announcements.
        /// </summary>
        public List<Announcement> Announcements { get; set; }

        public partial class Announcement
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string Message { get; set; }

            public DateTime DateStart { get; set; }

            public DateTime DateEnd { get; set; }
        }
    }
}