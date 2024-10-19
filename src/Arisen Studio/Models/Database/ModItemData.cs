using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using Humanizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArisenStudio.Models.Database
{
    public class ModItemData
    {
        public string Platform { get; set; }
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string FirmwareType { get; set; } = "n/a";
        public string Region { get; set; } = "n/a";
        public string CreatedBy { get; set; } = "Unknown";
        public string SubmittedBy { get; set; }
        public string Version { get; set; }
        public string GameMode { get; set; }
        public string ModType { get; set; }
        public string Description { get; set; }
        public List<DownloadFiles> DownloadFiles { get; set; }

        public Platform GetPlatform()
        {
            return Platform switch
            {
                "PS3" => ArisenStudio.Platform.PS3,
                "PS4" => ArisenStudio.Platform.PS4,
                "XBOX" => ArisenStudio.Platform.XBOX360,
                _ => ArisenStudio.Platform.PS3
            };
        }

        public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());
        public List<string> FirmwareTypes => FirmwareType.Split('/').ToList();
        public IEnumerable<string> ModTypes => ModType.Split(['/', '&']).Select(x => x.Trim());

        public IEnumerable<string> Versions
        {
            get
            {
                if (string.IsNullOrEmpty(Version)) return new List<string> { "-" };
                return Version.Split('/').Select(version => version.Trim()).ToList();
            }
        }

        public bool IsAnyRegion => Region.Equals("ALL") || Region.Equals("-");

        public IEnumerable<string> Regions
        {
            get
            {
                return Region.Split('/').Select(region =>
                    region switch
                    {
                        "ALL" => "All Regions",
                        "-" => "n/a",
                        _ => region
                    }).ToList();
            }
        }

        public IEnumerable<string> GameModes
        {
            get
            {
                return GameMode.Split('/').Select(mode =>
                    mode switch
                    {
                        "ALL" => "All Game Modes",
                        "MP" => "Multiplayer",
                        "ZM" => "Zombies",
                        "SP" => "Singleplayer",
                        "CO OP" => "Co-Operative",
                        "SPEC OPS" => "Special Ops",
                        "EXT" => "Extinction",
                        _ => "n/a"
                    }).ToList();
            }
        }

        public string GetVersion(DownloadFiles downloadFiles)
        {
            return string.IsNullOrEmpty(downloadFiles.Version) ? string.Empty : $"-{downloadFiles.Version}";
        }

        public Category GetCategory(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId)) ?? new Category { Title = "<Can't Find Name>" };
        }

        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.CategoryType ?? CategoryType.Game;
        }

        public string GetCategoryName(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.Title ?? "<Can't Find Name>";
        }
    }
}