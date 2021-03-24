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
    public class ModItem
    {
        public string ConsoleType { get; set; }

        public int Id { get; set; }

        public string GameId { get; set; }

        public string Name { get; set; }

        public string Firmware { get; set; }

        public string Region { get; set; }

        public string Author { get; set; }

        public string SubmittedBy { get; set; }

        public string Version { get; set; }

        public string Configuration { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public List<DownloadFiles> DownloadFiles { get; set; }

        public ConsoleTypePrefix GetConsoleType()
        {
            return ConsoleType switch
            {
                "PS3" => ConsoleTypePrefix.PS3,
                "XBOX" => ConsoleTypePrefix.XBOX,
                _ => ConsoleTypePrefix.PS3
            };
        }

        /// <summary>
        /// Get the category type.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(GameId))?.CategoryType ?? CategoryType.Game;
        }

        /// <summary>
        /// Check whether mod is for any region.
        /// </summary>
        public bool IsAnyRegion => Region.Equals("ALL") || Region.Equals("-");

        /// <summary>
        /// Check whether this mod is a game save.
        /// </summary>
        public bool IsGameSave => Type.Equals("GAMESAVE");

        /// <summary>
        /// Get all the mod types.
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<string> ModTypes => Type.Split('/');

        /// <summary>
        /// Get all the mod versions if there are multiple.
        /// </summary>
        /// <returns> </returns>
        public List<string> Versions
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
                            versions.AddRange(Version.Split('/').Select(version => "v" + version));

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
        public List<string> Firmwares => Firmware.Split('/').ToList();

        /// <summary>
        /// Get the supported game regions.
        /// </summary>
        /// <returns> </returns>
        public List<string> GameRegions
        {
            get
            {
                List<string> regions = new();

                foreach (string region in Region.Split('/'))
                {
                    switch (region)
                    {
                        case "ALL":
                        case "-":
                            regions.Add("All Regions");
                            break;

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
        public List<string> GameModes
        {
            get
            {
                List<string> gameModes = new();

                foreach (string mode in Configuration.Split('/'))
                {
                    switch (mode)
                    {
                        case "ALL":
                            gameModes.Add("All Modes");
                            break;

                        case "MP":
                            gameModes.Add("Multiplayer");
                            break;

                        case "ZM":
                            gameModes.Add("Zombies");
                            break;

                        case "SP":
                            gameModes.Add("Singleplayer");
                            break;

                        case "SPEC OPS":
                            gameModes.Add("Special Ops");
                            break;

                        case "-":
                            gameModes.Add("n/a");
                            break;

                        default:
                            gameModes.Add("n/a");
                            break;
                    }
                }

                return gameModes;
            }
        }

        /// <summary>
        /// Get the download URL specified by the user if there are multiple types.
        /// </summary>
        /// <returns> Download Archive URL </returns>
        public DownloadFiles GetDownloadFiles()
        {
            if (DownloadFiles.Count <= 1) return DownloadFiles.First();

            List<string> downloadNames = DownloadFiles.Select(x => x.Name).ToList();
            string downloadName = DialogExtensions.ShowListViewDialog(MainWindow.Window, "Install Downloads", downloadNames.ConvertAll(x => new ListItem() { Value = x, Name = x }));

            return string.IsNullOrEmpty(downloadName) ? null : DownloadFiles.First(x => x.Name.Equals(downloadName));
        }

        /// <summary>
        /// Get the directory for extracting modded files.
        /// </summary>
        /// <returns> </returns>
        public string DownloadDataDirectory(DownloadFiles downloadFiles)
        {
            return $@"{UserFolders.AppModsDataDirectory}{GameId}\{Author}\{Name.ReplaceInvalidChars()} ({downloadFiles.Name.ReplaceInvalidChars()}) (#{Id})\";
        }

        /// <summary>
        /// Gets the downloaded mods archive file path.
        /// </summary>
        /// <returns> Mods Archive File Path </returns>
        public string ArchiveZipFile(DownloadFiles downloadFiles)
        {
            return $@"{UserFolders.AppModsDataDirectory}{GameId}\{Author}\{Name.ReplaceInvalidChars()} ({downloadFiles.Name.ReplaceInvalidChars()}) (#{Id}).zip";
        }

        /// <summary>
        /// Downloads the modded files archive and extracts all files to <see cref="DownloadDataDirectory"/>
        /// </summary>
        /// <param name="downloadFiles"> </param>
        public void DownloadInstallFiles(DownloadFiles downloadFiles)
        {
            string archivePath = DownloadDataDirectory(downloadFiles);
            string archiveFilePath = ArchiveZipFile(downloadFiles);

            if (Directory.Exists(archivePath))
            {
                UserFolders.DeleteDirectory(archivePath);
            }

            if (!Directory.Exists(archivePath))
            {
                Directory.CreateDirectory(archivePath);
            }

            if (File.Exists(archiveFilePath))
            {
                File.Delete(archiveFilePath);
            }

            Directory.CreateDirectory(archivePath);

            using (WebClient webClient = new())
            {
                webClient.Headers.Add("Accept: application/zip");
                webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                webClient.DownloadFile(new Uri(downloadFiles.URL), archiveFilePath);
            }

            ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
        }

        /// <summary>
        /// Download mods archive to the specified local folder path
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <param name="downloadFiles"> </param>
        /// <param name="localPath"> Folder path to download the archive </param>
        public void DownloadArchiveAtPath(CategoriesData categoriesData, DownloadFiles downloadFiles, string localPath)
        {
            string zipFileName = $"{downloadFiles.Name.ReplaceInvalidChars()} v{Version.Replace(@"/", " & ")}.zip";
            string zipFilePath = Path.Combine(localPath, zipFileName);

            GenerateReadMeAtPath(categoriesData, DownloadDataDirectory(downloadFiles));

            using WebClient webClient = new();
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(new Uri(downloadFiles.URL), zipFilePath);
            Archives.AddFilesToZip(zipFilePath, new[] { Path.Combine(DownloadDataDirectory(downloadFiles), "README.txt") });
        }

        /// <summary>
        /// Creates and writes the mod information to a text file at the specified path
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
                    "Category: " + categoriesData.GetCategoryById(GameId).Title,
                    "Name: " + Name,
                    "System Type: " + string.Join(", ", Firmwares),
                    "Mod Type: " + Type,
                    "Version: " + Version,
                    "Region: " + string.Join(", ", GameRegions),
                    "Created By: " + Author,
                    "Submitted By: " + SubmittedBy,
                    "Game Type: " + string.Join(", ", GameModes),
                    "-------------------------------------------------",
                    "Description:\n" + Description
            });
        }
    }
}