using Newtonsoft.Json;
using System.Collections.Generic;

namespace ArisenStudio.Models.Database
{
    /// <summary>
    /// Get the game patch information.
    /// </summary>
    public partial class GamePatchItemData
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("title_id")]
        public string TitleId { get; set; }

        [JsonProperty("title_name")]
        public string TitleName { get; set; }

        [JsonProperty("patch")]
        public List<Patch> Patch { get; set; }
    }

    public partial class Patch
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; } = null;

        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("be32", NullValueHandling = NullValueHandling.Ignore)]
        public List<Be32> Be32 { get; set; } = null;

        [JsonProperty("be16", NullValueHandling = NullValueHandling.Ignore)]
        public List<Be16> Be16 { get; set; } = null;

        [JsonProperty("be8", NullValueHandling = NullValueHandling.Ignore)]
        public List<Be8> Be8 { get; set; } = null;
    }

    public partial class Be8
    {
        [JsonProperty("address")]
        public uint Address { get; set; }

        [JsonProperty("value")]
        public byte Value { get; set; }
    }

    public partial class Be16
    {
        [JsonProperty("address")]
        public uint Address { get; set; }

        [JsonProperty("value")]
        public ushort Value { get; set; }
    }

    public partial class Be32
    {
        [JsonProperty("address")]
        public uint Address { get; set; }

        [JsonProperty("value")]
        public uint Value { get; set; }
    }
}