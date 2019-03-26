namespace ModioX.Models
{
    public class ModsData
    {
        public string Version;
        public ModItem[] Mods;

        public class ModItem
        {
            public long Id;
            public string Name;
            public string GameId;
            public string Author;
            public string Version;
            public string Configuration;
            public string Type;
            public string Description;
            public string Url;
            public string[] InstallPaths;
        }
    }
}