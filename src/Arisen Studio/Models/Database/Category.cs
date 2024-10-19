namespace ArisenStudio.Models.Database
{
    public class Category
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string[] Regions { get; set; }

        public CategoryType CategoryType => Type switch
        {
            "game" => CategoryType.Game,
            "homebrew" => CategoryType.Homebrew,
            "resource" => CategoryType.Resource,
            "package" => CategoryType.Package,
            _ => CategoryType.Game
        };
    }
}