namespace ModioX.Models
{
    public partial class GamesData
    {
        public Game[] Games { get; set; }

        public partial class Game
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Icon { get; set; }
            public string[] Regions { get; set; }
        }

        /// <summary>
        /// Gets the total number of games
        /// </summary>
        /// <returns></returns>
        public int TotalGames
        {
            get
            {
                int countGames = 0;

                foreach (Game game in Games)
                {
                    if (game.Regions.Length > 0)
                    {
                        countGames++;
                    }
                }

                return countGames;
            }
        }
    }
}