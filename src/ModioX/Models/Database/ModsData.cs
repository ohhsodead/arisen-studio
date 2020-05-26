using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ModioX.Models.Database
{
    public partial class ModsData
    {
        /// <summary>
        ///     Contains all of the mods
        /// </summary>
        public List<ModItem> Mods { get; set; }

        /// <summary>
        ///     Contains all of the mod information; Id, Name, Type, etc.
        /// </summary>
        public class ModItem
        {
            public long Id { get; set; }

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

            public string Url { get; set; }

            public string[] InstallPaths { get; set; }

            /// <summary>
            ///     Get the mods' category type
            /// </summary>
            /// <param name="categoriesData"></param>
            /// <returns></returns>
            public CategoryType GetCategoryType(CategoriesData categoriesData)
            {
                foreach (var category in categoriesData.Categories)
                {
                    if (category.Id.ToLower().Equals(GameId.ToLower()))
                    {
                        return category.CategoryType;
                    }
                }

                return CategoryType.Game;
            }


            /// <summary>
            ///     Check whether install requires a game region to be specified
            /// </summary>
            public bool RequiresGameRegion => InstallPaths.Any(x => x.Contains("{REGION}"));

            /// <summary>
            ///     Check whether install requires a user id to be specified
            /// </summary>
            public bool RequiresUserId => InstallPaths.Any(x => x.Contains("{USERID}"));

            /// <summary>
            ///     Check whether install requires a usb device to be connected to console
            /// </summary>
            public bool RequiresUsbDevice => InstallPaths.Any(x => x.Contains("{USBDEV}"));

            /// <summary>
            ///     Check whether this mod is a game save
            /// </summary>
            public bool IsGameSave => Type.Equals("GAMESAVE");

            /// <summary>
            ///     Checks whether any file installs are at the 'dev_rebug' (firmware) folder
            /// </summary>
            /// <returns></returns>
            public bool IsInstallToRebugFolder => InstallPaths.Any(x => x.Contains("dev_rebug/"));

            /// <summary>
            ///     Check whether mod is for any region
            /// </summary>
            public bool IsAnyRegion => Region.Equals("ALL") || Region.Equals("-");

            /// <summary>
            ///     Get all the supported firmwares
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
            ///     Get all the supported firmwares
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
            ///     Get the supported game regions
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
            ///     Gets the mod game modes 
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
            ///     Gets the directory structure for extracting modded files to
            /// </summary>
            /// <returns></returns>
            public string DirectoryDownloadData => $@"{Utilities.AppDataPath}{GameId}\{Author}\{StringExtensions.ReplaceInvalidChars(Name)} (v{Version}) ({Id})\";

            /// <summary>
            ///     Gets the downloaded mods archive file path
            /// </summary>
            /// <returns>Mods Archive File Path</returns>
            public string ArchiveZipFile => $@"{Utilities.AppDataPath}{GameId}\{Author}\{StringExtensions.ReplaceInvalidChars(Name)} (v{Version}) ({Id}).zip";


            /// <summary>
            ///     Downloads the modded files archive and extracts the files to the user's appdata path
            /// </summary>
            public void DownloadInstallFiles()
            {
                string archivePath = DirectoryDownloadData;
                string archiveFilePath = ArchiveZipFile;

                if (!MainForm.SettingsData.AlwaysDownloadInstallFiles && File.Exists(archiveFilePath))
                {
                    return;
                }

                if (Directory.Exists(archivePath))
                {
                    Utilities.DeleteDirectory(archivePath);
                }

                if (File.Exists(archiveFilePath))
                {
                    File.Delete(archiveFilePath);
                }

                Directory.CreateDirectory(DirectoryDownloadData);

                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept: application/zip");
                    wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    wc.DownloadFile(new Uri(Url), archiveFilePath);
                    ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
                }
            }

            /// <summary>
            ///     Download mods archive to the specified local folder path
            /// </summary>
            /// <param name="localPath">Path to downloads mods archive at folder</param>
            public void DownloadArchiveAtPath(string localPath)
            {
                string zipFileName = $"{StringExtensions.ReplaceInvalidChars(Name)} v{Version}.zip";
                string zipFilePath = Path.Combine(localPath, zipFileName);

                GenerateReadMeAtPath(DirectoryDownloadData);

                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept: application/zip");
                    wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    wc.DownloadFile(new Uri(Url), zipFilePath);
                    Utilities.AddFilesToZip(zipFilePath, new string[] { Path.Combine(DirectoryDownloadData, "README.txt") });
                }
            }

            /// <summary>
            ///     Creates and writes the mod information to a text file at the specified path
            /// </summary>
            /// <param name="directoryPath"></param>
            public void GenerateReadMeAtPath(string directoryPath)
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Create contents and write them to readme file 
                File.WriteAllLines(Path.Combine(directoryPath, "README.txt"), new string[]
                {
                    Id.ToString(),
                    GameId,
                    Name,
                    Firmware,
                    Type,
                    Version,
                    Author,
                    SubmittedBy,
                    Configuration,
                    Description,
                    string.Join(", ", InstallPaths),
                    Url
                });
            }
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<string> AllModTypesForCategoryId(string categoryId)
        {
            List<string> modTypes = new List<string>();

            foreach (ModItem modItem in Mods)
            {
                if (string.Equals(modItem.GameId, categoryId, StringComparison.CurrentCultureIgnoreCase))
                {
                    modTypes.AddRange(modItem.ModTypes);
                }
            }

            return modTypes.Distinct().ToList();
        }

        /// <summary>
        ///     Gets the supported firmwares from all the mods
        /// </summary>
        /// <returns>Firmwares Supported</returns>
        public List<string> AllFirmwares
        {
            get
            {
                List<string> firmwares = new List<string>();

                foreach (ModItem modItem in Mods)
                {
                    foreach (string firmware in modItem.Firmware.Split('/'))
                    {
                        if (!firmwares.Contains(modItem.Firmware))
                        {
                            firmwares.Add(firmware);
                        }
                    }
                }

                firmwares.Sort();
                return firmwares;
            }
        }

        /// <summary>
        ///     Gets all of the mods for the specified gameId, with results filtered by name, firmware and type
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public List<ModItem> GetModItems(string categoryId, string name, string firmware, string type, string region)
        {
            if (categoryId.Equals("fvrt"))
            {
                return (from ModItem modItem in Mods
                        where MainForm.SettingsData.FavoritedIds.Contains(modItem.Id.ToString())
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmwares.Exists(x => x.ToLower().Contains(firmware.ToLower()))
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        && modItem.Region.ToLower().Contains(region.ToLower())
                        select modItem).Distinct().ToList();
            }
            else
            {
                return (from ModItem modItem in Mods
                        where string.Equals(modItem.GameId.ToLower(), categoryId.ToLower())
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmwares.Exists(x => x.ToLower().Contains(firmware.ToLower()))
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        && modItem.Region.ToLower().Contains(region.ToLower())
                        select modItem).Distinct().ToList();
            }
        }

        /// <summary>
        ///     Get the <see cref="modItem"/> matching the specified modId
        /// </summary>
        /// <param name="modId">Name of the mod</param>
        /// <returns>Mod information</returns>
        public ModItem GetModById(long modId)
        {
            foreach (ModItem modItem in from ModItem modItem in Mods
                                        where modItem.Id.Equals(modId)
                                        select modItem)
            {
                return modItem;
            }

            throw new Exception($"Unable to match a mod matching with this id : {modId}");
        }

        /// <summary>
        ///     Gets all the mods matching the specified gameId
        /// </summary>
        /// <returns></returns>
        public ModItem[] GetModsByCategoryId(string gameId) => (from ModItem modItem in Mods
                                                                where modItem.GameId.Equals(gameId)
                                                                select modItem).ToArray();

        /// <summary>
        ///     Gets the total number of game mods
        /// </summary>
        /// <returns></returns>
        public int TotalGameMods => (from ModItem modItem in Mods
                                     where !modItem.GameId.Equals("fvrt")
                                     && !modItem.GameId.Equals("accr")
                                     && !modItem.GameId.Equals("cb")
                                     && !modItem.GameId.Equals("gu")
                                     && !modItem.GameId.Equals("hhr")
                                     && !modItem.GameId.Equals("ha")
                                     && !modItem.GameId.Equals("hg")
                                     && !modItem.GameId.Equals("th")
                                     && !modItem.GameId.Equals("xmbr")
                                     select modItem).Count();

        /// <summary>
        ///     Gets the total number of game mods
        /// </summary>
        /// <returns></returns>
        public int TotalGameSaves => (from ModItem modItem in Mods
                                      where modItem.Type.Equals("GAMESAVE")
                                      select modItem).Count();

        /// <summary>
        ///     Gets the total number of homebrew packages
        /// </summary>
        /// <returns></returns>
        public int TotalHomebrew => (from ModItem modItem in Mods
                                     where modItem.GameId.Equals("ha")
                                     || modItem.GameId.Equals("hg")
                                     select modItem).Count();

        /// <summary>
        /// Gets the total number of game update packages
        /// </summary>
        /// <returns></returns>
        public int TotalGameUpdates => (from ModItem modItem in Mods
                                        where modItem.GameId.Equals("gu")
                                        select modItem).Count();

        /// <summary>
        ///     Gets the total number of themes
        /// </summary>
        /// <returns></returns>
        public int TotalThemes => (from ModItem modItem in Mods
                                   where modItem.GameId.Equals("th")
                                   select modItem).Count();

        /// <summary>
        ///     Gets the total number of resources
        /// </summary>
        /// <returns></returns>
        public int TotalResources => (from ModItem modItem in Mods
                                      where modItem.GameId.Equals("accr")
                                      || modItem.GameId.Equals("cb")
                                      || modItem.GameId.Equals("hhr")
                                      || modItem.GameId.Equals("xmbr")
                                      select modItem).Count();
    }
}