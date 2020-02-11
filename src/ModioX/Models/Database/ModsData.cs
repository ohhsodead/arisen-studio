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
        public List<ModItem> Mods { get; set; }

        public class ModItem
        {
            public long Id { get; set; }

            public string GameId { get; set; }

            public string Name { get; set; }

            public string Firmware { get; set; }

            public string Author { get; set; }

            public string SubmittedBy { get; set; }

            public string Version { get; set; }

            public string Configuration { get; set; }

            public string Type { get; set; }

            public string Description { get; set; }

            public string Url { get; set; }

            public string[] InstallPaths { get; set; }

            public bool RequiresRegion()
            {
                return InstallPaths.Any(x => x.Contains("{REGION}"));
            }

            public bool RequiresUserId()
            {
                return InstallPaths.Any(x => x.Contains("{USERID}"));
            }

            /// <summary>
            ///     Gets the mod game modes 
            /// </summary>
            /// <returns></returns>
            public List<string> GetGameModes()
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
                    else
                    {
                        gameModes.Add("n/a");
                    }
                }

                return gameModes;
            }

            /// <summary>
            ///     Downloads the modded files archive needed for the mods and extracts to the user's appdata path
            /// </summary>
            public void DownloadInstallFiles()
            {
                string archivePath = GetDirectoryDownloadData();
                string archiveFilePath = GetArchiveZipFile();

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

                Directory.CreateDirectory(GetDirectoryDownloadData());

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
                string zipFileName = string.Format("{0} v{1}.zip", Name.Replace(":", ""), Version);
                string zipFilePath = Path.Combine(localPath, zipFileName);

                GenerateReadMeAtPath(GetDirectoryDownloadData());

                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept: application/zip");
                    wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    wc.DownloadFile(new Uri(Url), zipFilePath);
                    Utilities.AddFilesToZip(zipFilePath, new string[] { Path.Combine(GetDirectoryDownloadData(), "README.txt") });
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

            /// <summary>
            ///     Gets the directory structure for extracting modded files to
            /// </summary>
            /// <returns></returns>
            public string GetDirectoryDownloadData()
            {
                return $@"{Utilities.AppDataPath}{GameId}\{Author}\{Name.Replace(":", "")} (v{Version})\";
            }

            /// <summary>
            ///     Gets the downloaded mods archive file path
            /// </summary>
            /// <returns>Mods Archive File Path</returns>
            public string GetArchiveZipFile()
            {
                return $@"{Utilities.AppDataPath}{GameId}\{Author}\{Name.Replace(":", "")} (v{Version}) ({Id}).zip";
            }

            /// <summary>
            ///     Checks whether any modded files are being installed to any sensitive folders, and asks if they would like to cancel
            /// </summary>
            /// <param name="form">Owner Form</param>
            /// <returns></returns>
            public bool IsInstallToRebugFolder()
            {
                return InstallPaths.Any(x => x.Contains("dev_rebug/"));
            }

            public CategoryType GetCategoryType(CategoriesData categoriesData)
            {
                foreach (var category in categoriesData.Categories)
                {
                    if (category.Id.ToLower().Equals(GameId.ToLower()))
                    {
                        return category.GetCategoryType();
                    }
                }

                return CategoryType.Game;
            }
        }

        /// <summary>
        ///     Gets all of the mods for the specified gameId, with results filtered by name, firmware and type
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="name"></param>
        /// <param name="firmware"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<ModItem> GetModItems(string gameId, string name, string firmware, string type)
        {
            if (gameId.Equals("fvrt"))
            {
                return (from ModItem modItem in Mods
                        where MainForm.SettingsData.FavoritedIds.Contains(modItem.Id.ToString())
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmware.ToLower().Contains(firmware.ToLower())
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        select modItem).Distinct().ToList();
            }
            else
            {
                return (from ModItem modItem in Mods
                        where string.Equals(modItem.GameId.ToLower(), gameId.ToLower())
                        && modItem.Name.ToLower().Contains(name.ToLower())
                        && modItem.Firmware.ToLower().Contains(firmware.ToLower())
                        && modItem.Type.ToLower().Contains(type.ToLower())
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
                                        where modItem.Id == modId
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
        public ModItem[] GetModsByCategoryId(string gameId)
        {
            return (from ModItem modItem in Mods
                    where modItem.GameId.Equals(gameId)
                    select modItem).ToArray();
        }

        /// <summary>
        ///     Gets the total number of game mods
        /// </summary>
        /// <returns></returns>
        public int TotalGameMods => (from ModItem modItem in Mods
                                     where !modItem.GameId.Equals("fvrt")
                                     && !modItem.GameId.Equals("accr")
                                     && !modItem.GameId.Equals("gu")
                                     && !modItem.GameId.Equals("hhr")
                                     && !modItem.GameId.Equals("ha")
                                     && !modItem.GameId.Equals("hg")
                                     && !modItem.GameId.Equals("th")
                                     && !modItem.GameId.Equals("xmbr")
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
                                      || modItem.GameId.Equals("hhr")
                                      || modItem.GameId.Equals("xmbr")
                                      select modItem).Count();
    }
}