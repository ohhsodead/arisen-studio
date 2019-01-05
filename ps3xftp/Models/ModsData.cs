using System.Collections.Generic;

namespace ps3xftp.Models
{
    public class ModsData
    {
        public string Version { get; set; }
        public IList<ModItem> Mods { get; set; }

        public class ModItem
        {
            public string GamePrefix { get; set; }
            public string Name { get; set; }
            public string Author { get; set; }
            public string Version { get; set; }
            public string Configuration { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public string URL { get; set; }
            public IList<string> InstallPaths { get; set; }
        }
    }
}