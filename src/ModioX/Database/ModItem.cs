using ModioX.Extensions;
using ModioX.Io;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace ModioX.Models.Database
{
    /// <summary>
    /// Get the mod information.
    /// </summary>
    public class ModItem
    {
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

        /// <summary>
        /// Get the category type.
        /// </summary>
        /// <param name="categoriesData"></param>
        /// <returns></returns>
        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            foreach (Category category in categoriesData.Categories)
            {
                if (category.Id.ToLower().Equals(GameId.ToLower()))
                {
                    return category.CategoryType;
                }
            }

            return CategoryType.Game;
        }

        /// <summary>
        /// Check whether install requires a game region to be specified.
        /// </summary>
        public bool RequiresGameRegion => DownloadFiles.Any(x => x.RequiresGameRegion);

        /// <summary>
        /// Check whether install requires a user id to be specified.
        /// </summary>
        public bool RequiresUserId => DownloadFiles.Any(x => x.RequiresGameRegion);

        /// <summary>
        /// Check whether install requires a USB device to be connected to console
        /// </summary>
        public bool RequiresUsbDevice => DownloadFiles.Any(x => x.RequiresUsbDevice);

        /// <summary>
        /// Check whether any files are installed at the 'dev_rebug' (firmware) folder.
        /// </summary>
        /// <returns></returns>
        public bool IsInstallToRebugFolder => DownloadFiles.Any(x => x.InstallsToRebugFolder);

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
        /// <returns></returns>
        public List<string> ModTypes
        {
            get
            {
                List<string> modTypes = new List<string>();

                foreach (string modType in Type.Split('/'))
                {
                    modTypes.Add(modType);
                }

                return modTypes;
            }
        }

        /// <summary>
        /// Get all the mod versions if there are multiple.
        /// </summary>
        /// <returns></returns>
        public List<string> Versions
        {
            get
            {
                List<string> versions = new List<string>();

                if (Version == "n/a")
                {
                    versions.Add("n/a");
                }
                else if (Version == "-")
                {
                    versions.Add("-");
                }
                else if (Version == "")
                {
                    versions.Add("-");
                }
                else
                {
                    foreach (string version in Version.Split('/'))
                    {
                        versions.Add("v" + version);
                    }
                }

                return versions;
            }
        }

        /// <summary>
        /// Get all the supported firmwares.
        /// </summary>
        /// <returns></returns>
        public List<string> Firmwares
        {
            get
            {
                List<string> firmwares = new List<string>();

                foreach (string firmware in Firmware.Split('/'))
                {
                    firmwares.Add(firmware);
                }

                return firmwares;
            }
        }

        /// <summary>
        /// Get the supported game regions.
        /// </summary>
        /// <returns></returns>
        public List<string> GameRegions
        {
            get
            {
                List<string> regions = new List<string>();

                foreach (string region in Region.Split('/'))
                {
                    if (region.Equals("ALL"))
                    {
                        regions.Add("All Regions");
                    }
                    else if (region.Equals("-"))
                    {
                        regions.Add("All Regions");
                    }
                    else if (region.Equals("n/a"))
                    {
                        regions.Add("n/a");
                    }
                    else
                    {
                        regions.Add(region);
                    }
                }

                return regions;
            }
        }

        /// <summary>
        /// Get the game modes actual names from their abbreviated names.
        /// </summary>
        /// <returns></returns>
        public List<string> GameModes
        {
            get
            {
                List<string> gameModes = new List<string>();

                foreach (string mode in Configuration.Split('/'))
                {
                    if (mode.Equals("ALL"))
                    {
                        gameModes.Add("All Modes");
                    }
                    else if (mode.Equals("MP"))
                    {
                        gameModes.Add("Multiplayer");
                    }
                    else if (mode.Equals("ZM"))
                    {
                        gameModes.Add("Zombies");
                    }
                    else if (mode.Equals("SP"))
                    {
                        gameModes.Add("Singleplayer");
                    }
                    else if (mode.Equals("SPEC OPS"))
                    {
                        gameModes.Add("Special Ops");
                    }
                    else if (mode.Equals("-"))
                    {
                        gameModes.Add("n/a");
                    }
                    else
                    {
                        gameModes.Add("n/a");
                    }
                }

                return gameModes;
            }
        }

        /// <summary>
        /// Get the download url specified by the user if there are multiple types
        /// </summary>
        /// <returns>Download Archive URL</returns>
        public DownloadFiles GetDownloadFiles()
        {
            if (DownloadFiles.Count > 1)
            {
                List<string> downloadNames = DownloadFiles.Select(x => x.Name).ToList();
                string downloadName = DialogExtensions.ShowListInputDialog("Install Downloads", downloadNames);

                if (string.IsNullOrEmpty(downloadName))
                {
                    return null;
                }

                return DownloadFiles.First(x => x.Name.Equals(downloadName));
            }
            else
            {
                return DownloadFiles.First();
            }
        }

        /// <summary>
        /// Get the directory for extracting modded files to.
        /// </summary>
        /// <returns></returns>
        public string DownloadDataDirectory(DownloadFiles downloadFiles) => $@"{UserFolders.AppModsDataDirectory}{GameId}\{Author}\{StringExtensions.ReplaceInvalidChars(Name)} ({StringExtensions.ReplaceInvalidChars(downloadFiles.Name)}) (#{Id})\";

        /// <summary>
        /// Gets the downloaded mods archive file path.
        /// </summary>
        /// <returns>Mods Archive File Path</returns>
        public string ArchiveZipFile(DownloadFiles downloadFiles) => $@"{UserFolders.AppModsDataDirectory}{GameId}\{Author}\{StringExtensions.ReplaceInvalidChars(Name)} ({StringExtensions.ReplaceInvalidChars(downloadFiles.Name)}) (#{Id}).zip";

        /// <summary>
        /// Downloads the modded files archive and extracts all files to <see cref="DownloadDataDirectory"/>
        /// </summary>
        /// <param name="downloadFiles"></param>
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

            using (WebClient webClient = new WebClient())
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
        /// <param name="categoriesData"></param>
        /// <param name="downloadFiles"></param>
        /// <param name="localPath">Path to downloads mods archive at folder</param>
        public void DownloadArchiveAtPath(CategoriesData categoriesData, DownloadFiles downloadFiles, string localPath)
        {
            string zipFileName = $"{StringExtensions.ReplaceInvalidChars(Name)} v{Version} for {GameId.ToUpper()}.zip";
            string zipFilePath = Path.Combine(localPath, zipFileName);

            GenerateReadMeAtPath(categoriesData, DownloadDataDirectory(downloadFiles));

            using WebClient webClient = new WebClient();
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(new Uri(downloadFiles.URL), zipFilePath);
            Archives.AddFilesToZip(zipFilePath, new string[] { Path.Combine(DownloadDataDirectory(downloadFiles), "README.txt") });
        }

        /// <summary>
        /// Creates and writes the mod information to a text file at the specified path
        /// </summary>
        /// <param name="categoriesData"></param>
        /// <param name="directoryPath"></param>
        public void GenerateReadMeAtPath(CategoriesData categoriesData, string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Create contents and write them to readme file 
            File.WriteAllLines(Path.Combine(directoryPath, "README.txt"), new string[]
            {
                    "Mod ID: #" + Id.ToString(),
                    "Category: " + categoriesData.GetCategoryById(GameId).Title,
                    "Name: " + Name,
                    "System Type: " + string.Join(", ", Firmwares),
                    "Mod Type: " + Type,
                    "Version: " + Version,
                    "Region: " + string.Join(", ", GameRegions),
                    "Created By: " + Author,
                    "Submitted By: " + SubmittedBy,
                    "Game Type: " + string.Join(", ", GameModes),
                    "Downloads: " + string.Join(", ", DownloadFiles.Select(x => x.URL)),
                    "-------------------------------------------------",
                    "Description:\n" + Description
            });
        }
    }
}