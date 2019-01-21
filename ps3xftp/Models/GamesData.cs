namespace Ps3Xftp.Models
{
    public class GamesData
    {
        public Game[] Games;

        public class Game
        {
            public string Id;
            public string Title;
            public string[] Regions;
        }
    }
}