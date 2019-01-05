using System.Collections.Generic;

namespace ps3xftp.Models
{
    public class GamesData
    {
        public string Version { get; set; }
        public IList<Game> Games { get; set; }

        public class Game
        {
            public string Title { get; set; }
            public string Prefix { get; set; }
            public IList<string> Regions { get; set; }
        }
    }
}