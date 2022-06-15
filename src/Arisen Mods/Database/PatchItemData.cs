using Humanizer;
using ArisenMods.Extensions;
using ArisenMods.Forms.Windows;
using ArisenMods.Models.Database;
using ArisenMods.Models.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ArisenMods.Database
{
    /// <summary>
    /// Get the mod item information.
    /// </summary>
    public class PatchItemData
    {
        public string title_name { get; set; }

        public string title_id { get; set; }

        public string hash { get; set; }

        public List<Patch> patch { get; set; }


        public class Patch
        {
            public string name { get; set; }
            
            public string desc { get; set; }
            
            public string author { get; set; }
            
            public bool is_enabled { get; set; }
            
            public List<Be32> be32 { get; set; }
            
            public List<Be8> be8 { get; set; }
        }

        public class Be8
        {
            public long address { get; set; }
            
            public int value { get; set; }
        }

        public class Be32
        {
            public object address { get; set; }

            public int value { get; set; }
        }
    }
}