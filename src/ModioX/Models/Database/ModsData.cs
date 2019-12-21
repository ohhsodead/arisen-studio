using ModioX.Extensions;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

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

            /// <summary>
            ///     Downloads the compressed archive for the mods and then extracts the archive to the appdata path
            /// </summary>
            public void DownloadArchive()
            {
                string archivePath = GetDirectoryDownloadData();
                string archiveFilePath = GetArchiveZipFile();

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
            /// 
            /// </summary>
            /// <param name="directoryPath"></param>
            public void GenerateReadMeAtPath(string directoryPath)
            {
                // Create contents and write them to readme file 
                string[] contents = new string[]
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
                };

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.WriteAllLines(Path.Combine(directoryPath, "README.txt"), contents);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public string GetDirectoryGameData()
            {
                return $@"{Utilities.AppDataPath}{GameId}\";
            }

            /// <summary>
            /// Retrieves the directory structure for extracting modded files to
            /// </summary>
            /// <returns></returns>
            public string GetDirectoryDownloadData()
            {
                return $@"{Utilities.AppDataPath}{GameId}\{Author}\{Name.Replace(":", "")} (v{Version})\";
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public string GetArchiveZipFile()
            {
                return $@"{Utilities.AppDataPath}{GameId}\{Author}\{Name.Replace(":", "")} (v{Version}) ({Id}).zip";
            }
        }

        public List<ModItem> GetModItems(string categoryId, string firmware, string type)
        {
            if (categoryId.Equals("fvrt"))
            {
                return (from ModItem modItem in Mods
                        where MainForm.SettingsData.FavoritedIds.Contains(modItem.Id.ToString())
                        && modItem.Firmware.ToLower().Contains(firmware.ToLower())
                        && modItem.Type.ToLower().Contains(type)
                        select modItem).Distinct().ToList();
            }
            else
            {
                return (from ModItem modItem in Mods
                        where string.Equals(modItem.GameId.ToLower(), categoryId.ToLower())
                        //&& modItem.Name.ToLower().Contains(name)
                        && modItem.Firmware.ToLower().Contains(firmware.ToLower())
                        && modItem.Type.ToLower().Contains(type.ToLower())
                        select modItem).Distinct().ToList();
            }
        }

        /// <summary>
        ///     Retrieve the mods data from the loaded database
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

            throw new Exception($"Unable to match with modId : {modId}");
        }

        /// <summary>
        /// Gets mods that match the specified game id
        /// </summary>
        /// <returns></returns>
        public ModItem[] GetModsByCategoryId(string gameId) => (from ModItem modItem in Mods
                                                                where modItem.GameId.Equals(gameId)
                                                                select modItem).ToArray();

        /// <summary>
        /// Gets the total number of game mods
        /// </summary>
        /// <returns></returns>
        public int TotalGameMods => (from ModItem modItem in Mods
                                     where !modItem.GameId.Equals("fvrt")
                                     && !modItem.GameId.Equals("gu")
                                     && !modItem.GameId.Equals("hhr")
                                     && !modItem.GameId.Equals("ha")
                                     && !modItem.GameId.Equals("hg")
                                     && !modItem.GameId.Equals("th")
                                     && !modItem.GameId.Equals("xmbr")
                                     select modItem).Count();

        /// <summary>
        /// Gets the total number of homebrew packages
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
        /// Gets the total number of themes
        /// </summary>
        /// <returns></returns>
        public int TotalThemes => (from ModItem modItem in Mods
                                   where modItem.Type.Equals("P3T")
                                   select modItem).Count();

        /// <summary>
        /// Gets the total number of resources
        /// </summary>
        /// <returns></returns>
        public int TotalResources => (from ModItem modItem in Mods
                                      where modItem.GameId.Equals("hhr")
                                      || modItem.GameId.Equals("xmbr")
                                      select modItem).Count();
    }
}