using System.Collections.Generic;

namespace ModioX.Database
{
    /// <summary>
    /// Get the game cheat information.
    /// </summary>
    public class GameCheatItemData
    {
        public string Region { get; set; }

        public string Game { get; set; }

        public string Version { get; set; }

        public List<Cheats> Cheats { get; set; }
    }

    public class Cheats
    {
        public string Name { get; set; }

        public List<Offsets> Offsets { get; set; }
    }

    public class Offsets
    {
        public string Opcode { get; set; }

        public string Param1 { get; set; }

        public string Param2 { get; set; }

        public bool ContainsUnimplementedOpcodes()
        {
            return !(Opcode == "00002000");
        }
    }
}