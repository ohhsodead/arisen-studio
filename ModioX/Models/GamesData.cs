namespace ModioX.Models
{
    public class GamesData
    {
        public Game[] Games;

        public class Game
        {
            public string Id;
            public string Title;
            public string ImageUrl;
            public string[] Regions;
        }
    }
}