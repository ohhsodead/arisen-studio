using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Database;
using ModioX.Models.Resources;

namespace ModioX.Database
{
    /// <summary>
    /// Get the mod information.
    /// </summary>

    public class ModsOffsets
    {
        public int Id { get; set; }

        public string ConsoleType { get; set; }

        public string GameId { get; set; }

        public string GameVersion { get; set; }

        public List<Memory> Memory { get; set; }
    }

    public class Memory
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string GameMode { get; set; }

        public bool Toggleable { get; set; }

        public List<Offset> Offsets { get; set; }
    }

    public class Offset
    {
        public string Address { get; set; }

        public string Enable { get; set; }

        public string Disable { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }
    }
}