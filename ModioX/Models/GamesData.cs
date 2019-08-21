namespace ModioX.Models
{
    public partial class GamesData
    {
        public Game[] Games { get; set; }

        public partial class Game
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string[] Regions { get; set; }
        }
    }
}