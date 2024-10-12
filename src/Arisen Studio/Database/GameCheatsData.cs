using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ArisenStudio.Database
{
    /// <summary>
    /// Get the game cheat information.
    /// </summary>
    public class GameCheatsData
    {
        public string Game { get; set; }

        public string Region { get; set; } = string.Empty;

        [DataMember]
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue("-")]
        public string Version { get; set; } = "-";

        public List<Cheats> Cheats { get; set; }
    }

    public class Cheats
    {
        public string Name { get; set; }

        public List<Offsets> Offsets { get; set; }
    }

    public class Offsets
    {
        public string ValueType { get; set; }

        public string DataType { get; set; }

        public string Opcode { get; set; }

        public string Offset { get; set; }

        public string Value { get; set; }

        public bool ContainsUnimplementedOpcodes()
        {
            return !(Opcode == "00002000");
        }
    }
}