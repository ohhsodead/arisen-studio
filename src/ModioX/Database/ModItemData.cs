using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Database;
using ModioX.Models.Resources;

namespace ModioX.Database
{
    /// <summary>
    /// Get the mod item information.
    /// </summary>
    public class ModItemData
    {
        public string Platform { get; set; }

        public int Id { get; set; }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public string FirmwareType { get; set; } = "n/a";

        public string Region { get; set; } = "n/a";

        public string CreatedBy { get; set; }

        public string SubmittedBy { get; set; }

        public string Version { get; set; }

        public string GameMode { get; set; }

        public string ModType { get; set; }

        public string Description { get; set; }

        public List<DownloadFiles> DownloadFiles { get; set; }

        public PlatformPrefix GetPlatform()
        {
            return Platform switch
            {
                "PS3" => PlatformPrefix.PS3,
                "XBOX" => PlatformPrefix.XBOX,
                _ => PlatformPrefix.PS3
            };
        }

        /// <summary>
        /// Check whether mod is for any region.
        /// </summary>
        public bool IsAnyRegion => Region.Equals("ALL") || Region.Equals("-");

        /// <summary>
        /// Get all the mod types.
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<string> ModTypes => ModType.Split(new char[] { '/', '&' }).Select(x => x.Trim());

        /// <summary>
        /// Get all the authors.
        /// </summary>

        public IEnumerable<string> Creators => CreatedBy.Split(new char[] { '/', '&' }).Select(x => x.Trim());

        /// <summary>
        /// Get all the mod versions if there are multiple.
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<string> Versions
        {
            get
            {
                List<string> versions = new();

                switch (Version)
                {
                    case "n/a":
                        versions.Add("n/a");
                        break;

                    case "-":
                    case "":
                        versions.Add("-");
                        break;

                    default:
                        {
                            versions.AddRange(Version.Split('/').Select(version => version.Trim()));

                            break;
                        }
                }

                return versions;
            }
        }

        /// <summary>
        /// Get all the supported firmwares.
        /// </summary>
        /// <returns> </returns>
        public List<string> FirmwareTypes => FirmwareType.Split('/').ToList();

        /// <summary>
        /// Get the supported game regions.
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<string> Regions
        {
            get
            {
                List<string> regions = new();

                foreach (string region in Region.Split('/'))
                {
                    switch (region)
                    {
                        case "ALL":
                            regions.Add("All Regions");
                            break;

                        case "-":
                        case "n/a":
                            regions.Add("n/a");
                            break;

                        default:
                            regions.Add(region);
                            break;
                    }
                }

                return regions;
            }
        }

        /// <summary>
        /// Get the game modes actual names from their abbreviated names.
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<string> GameModes
        {
            get
            {
                List<string> modes = new();

                foreach (string mode in GameMode.Split('/'))
                {
                    switch (mode)
                    {
                        case "ALL":
                            modes.Add("All Game Modes");
                            break;

                        case "MP":
                            modes.Add("Multiplayer");
                            break;

                        case "ZM":
                            modes.Add("Zombies");
                            break;

                        case "SP":
                            modes.Add("Singleplayer");
                            break;

                        case "SPEC OPS":
                            modes.Add("Special Ops");
                            break;

                        case "EXT":
                            modes.Add("Extinction");
                            break;

                        case "-":
                            modes.Add("n/a");
                            break;

                        default:
                            modes.Add("n/a");
                            break;
                    }
                }

                return modes;
            }
        }

        /// <summary>
        /// Get the category data.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public Category GetCategory(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId)) ?? new Category() { Title = "<Can't Find Name>" };
        }

        /// <summary>
        /// Get the category type.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.CategoryType ?? CategoryType.Game;
        }

        /// <summary>
        /// Get the category name.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public string GetCategoryName(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.Title ?? "<Can't Find Name>";
        }

        /// <summary>
        /// Get the download URL specified by the user if there are multiple types.
        /// </summary>
        /// <returns> Download Archive URL </returns>
        public DownloadFiles GetDownloadFiles(Form owner)
        {
            switch (DownloadFiles.Count)
            {
                case <= 1:
                    return DownloadFiles.First();
            }

            List<string> downloadNames = DownloadFiles.Select(x => x.Name).ToList();
            ListItem downloadName = DialogExtensions.ShowListViewDialog(owner, "Install Downloads", downloadNames.ConvertAll(x => new ListItem { Value = x, Name = x }));

            return downloadName != null ? DownloadFiles.First(x => x.Name.Equals(downloadName.Value)) : null;
        }

        /// <summary>
        /// Get the directory for extracting modded files.
        /// </summary>
        /// <returns> </returns>
        public string DownloadDataDirectory(DownloadFiles downloadFiles)
        {
            return $@"{UserFolders.DownloadsLocationMods}{Platform}\{CategoryId}\{CreatedBy}\{downloadFiles.Name.RemoveInvalidChars()} (#{Id})\";
        }

        /// <summary>
        /// Get the downloaded mods archive file path.
        /// </summary>
        /// <returns> Mods Archive File Path </returns>
        public string ArchiveZipFile(DownloadFiles downloadFiles)
        {
            return $@"{UserFolders.DownloadsLocationMods}{Platform}\{CategoryId}\{CreatedBy}\{downloadFiles.Name.RemoveInvalidChars()} (#{Id}).zip";
        }

        /// <summary>
        /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
        /// </summary>
        /// <param name="downloadFiles"> </param>
        public void DownloadInstallFiles(DownloadFiles downloadFiles)
        {
            string archivePath = DownloadDataDirectory(downloadFiles);
            string archiveFilePath = ArchiveZipFile(downloadFiles);

            if (Directory.Exists(archivePath))
            {
                try
                {
                    Directory.Delete(archivePath, true);
                }
                catch (Exception) { }
            }

            if (!Directory.Exists(archivePath))
            {
                Directory.CreateDirectory(archivePath);
            }

            if (!Directory.Exists(Path.GetDirectoryName(archiveFilePath)))
            {
                Directory.CreateDirectory(archiveFilePath);
            }

            if (File.Exists(archiveFilePath))
            {
                File.Delete(archiveFilePath);
            }

            using (WebClient webClient = new())
            {
                webClient.Headers.Add("Accept: application/zip");
                webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                webClient.DownloadFile(new Uri(downloadFiles.Url), archiveFilePath);
            }

            ZipFile.ExtractToDirectory(archiveFilePath, archivePath);

            DownloadedItem downloadItem = MainWindow.Settings.DownloadedMods.FirstOrDefault(x => x.Platform == GetPlatform() && x.ModId == Id);

            if (downloadItem == null)
            {
                MainWindow.Settings.DownloadedMods.Add(
                    new DownloadedItem()
                    {
                        Platform = GetPlatform(),
                        ModId = Id,
                        CategoryId = CategoryId,
                        DownloadFile = downloadFiles,
                        FilePath = archiveFilePath,
                        DateTime = DateTime.Now
                    });
            }
            else
            {
                MainWindow.Settings.DownloadedMods[MainWindow.Settings.DownloadedMods.IndexOf(downloadItem)] =
                    new DownloadedItem()
                    {
                        Platform = GetPlatform(),
                        ModId = Id,
                        CategoryId = CategoryId,
                        DownloadFile = downloadFiles,
                        FilePath = archiveFilePath,
                        DateTime = DateTime.Now
                    };
            }
        }

        /// <summary>
        /// Download mods archive to the specified local folder path.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <param name="downloadFiles"> </param>
        /// <param name="localPath"> Folder path to download the archive </param>
        public void DownloadArchiveAtPath(CategoriesData categoriesData, DownloadFiles downloadFiles, string localPath)
        {
            string zipFileName = $"{downloadFiles.Name.RemoveInvalidChars()} v{Version.Replace(@"/", " & ")}.zip";
            string zipFilePath = Path.Combine(localPath, zipFileName);

            GenerateReadMeAtPath(categoriesData, DownloadDataDirectory(downloadFiles));

            using WebClient webClient = new();
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(new Uri(downloadFiles.Url), zipFilePath);
            Archives.AddFilesToZip(zipFilePath, new[] { Path.Combine(DownloadDataDirectory(downloadFiles), "README.txt") });
            File.Delete(Path.Combine(DownloadDataDirectory(downloadFiles), "README.txt"));
        }

        /// <summary>
        /// Create and write the mod information to a text file at the specified path.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <param name="directoryPath"> </param>
        public void GenerateReadMeAtPath(CategoriesData categoriesData, string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Create contents and write them to readme file
            File.WriteAllLines(Path.Combine(directoryPath, "README.txt"), new[]
            {
                "Mod ID: #" + Id,
                "Category: " + categoriesData.GetCategoryById(CategoryId).Title,
                "Name: " + Name,
                "System Type: " + string.Join(", ", FirmwareTypes),
                "Mod Type: " + ModType,
                "Version: " + Version,
                "Region: " + string.Join(", ", Regions),
                "Created By: " + CreatedBy,
                "Submitted By: " + SubmittedBy,
                "Game Type: " + string.Join(", ", GameModes),
                "-------------------------------------------------",
                "Description:\n" + Description
            });
        }
    }
}