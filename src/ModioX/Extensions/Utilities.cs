using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ModioX.Models;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using ModioX.Windows;

namespace ModioX.Extensions
{
    internal static class Utilities
    {
        /// <summary>
        ///     Application user's data roaming directory
        /// </summary>
        internal static string AppDataPath { get; } = $@"{System.Windows.Forms.Application.UserAppDataPath}\";

        /// <summary>
        ///     Web URL pointing to the project repo hosted on GitHub
        /// </summary>
        internal const string ProjectRepoUrl = "https://github.com/ohhsoash/ModioX/";

        /// <summary>
        ///     Web URL pointing to the project's version file
        /// </summary>
        internal const string ProjectVersionUrl = "https://dl.dropbox.com/s/1dvbz2ejh0239mv/version.txt?raw=true";

        /// <summary>
        ///     Get the current application product version
        /// </summary>
        /// <returns></returns>
        internal static string GetCurrentVersion()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }
        
        /// <summary>
        ///     Download and return the mods information
        /// </summary>
        /// <returns></returns>
        internal static ModsData GetModsData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://www.dropbox.com/s/9kzqk21hkz2nt14/modsdata.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"Bad response {response.StatusCode}");

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                        return JsonConvert.DeserializeObject<ModsData>(responseData);

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }
        
        /// <summary>
        ///     Download and return the information for supported games
        /// </summary>
        /// <returns></returns>
        internal static GamesData GetGamesData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://www.dropbox.com/s/98bp8y8ii1o7y64/gamedata.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"Bad response {response.StatusCode}");

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                        return JsonConvert.DeserializeObject<GamesData>(responseData);

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="gamesData"></param>
        /// <param name="gameTitle">Title of the game</param>
        /// <returns>Game information</returns>
        internal static GamesData.Game GetGameByTitle(GamesData gamesData, string gameTitle)
        {
            foreach (GamesData.Game game in from GamesData.Game game in gamesData.Games
                                 where game.Title.Equals(gameTitle)
                                 select game)
            {
                return game;
            }

            throw new Exception("Unable to find game data for the specified game title");
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="gamesData"></param>
        /// <param name="gameId">Title of the game</param>
        /// <returns>Game information</returns>
        internal static GamesData.Game GetGameById(GamesData gamesData, string gameId)
        {
            foreach (GamesData.Game game in from GamesData.Game game in gamesData.Games
                                 where game.Id.Equals(gameId)
                                 select game)
            {
                return game;
            }

            throw new Exception("Unable to find game data for the specified game id");
        }

        /// <summary>
        ///     Retrieve the mods data from the loaded database
        /// </summary>
        /// <param name="modsData">Name of the mod</param>
        /// <param name="modId">Name of the mod</param>
        /// <returns>Mod information</returns>
        internal static ModsData.ModItem GetModById(ModsData modsData, long modId)
        {
            foreach (ModsData.ModItem mod in from ModsData.ModItem mod in modsData.Mods
                                where mod.Id == modId
                                select mod)
            {
                return mod;
            }

            throw new Exception($"Unable to match with modId : {modId}");
        }

        /// <summary>
        ///     Returns the users game region, either automatically set region by searching existing console directories or prompt
        ///     the user to select one
        /// </summary>
        /// <param name="hostAddress">Selected game</param>
        /// <param name="game">Automatically retrieve users region</param>
        /// <param name="detectRegion">Automatically retrieve users region</param>
        /// <returns></returns>
        internal static string GetUsersGameRegion(FtpConnection ftpConnection, GamesData.Game game, bool detectRegion)
        {
            if (detectRegion)
            {
                List<string> detectedRegions = new List<string>();

                foreach (string region in game.Regions)
                {
                    if (ftpConnection.DirectoryExists($"dev_hdd0/game/{region}"))
                    {
                        detectedRegions.Add(region);
                    }
                }

                foreach (string region in detectedRegions)
                {
                    if (DarkUI.Forms.DarkMessageBox.Show(MainForm.mainForm, string.Format("We have detected your region for '{0}' could be {1} - Is this correct?", game.Title, region), "Detected Region", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        return region;
                    }
                }

                DarkUI.Forms.DarkMessageBox.Show(MainForm.mainForm, "Could not find any regions on your console for this title", "No Region Detected");
            }
            else
            {
                using (RegionsWindow frmRegions = new Windows.RegionsWindow())
                {
                    foreach (string region in game.Regions)
                    {
                        frmRegions.ListViewRegions.Items.Add(new DarkUI.Controls.DarkListItem() { Text = region });
                    }
                    frmRegions.ShowDialog();
                    return frmRegions.SelectedRegion;
                }                    
            }

            return null;
        }

        /// <summary>
        ///     Determines whether the game needs a region to be selected before installing mods
        /// </summary>
        /// <param name="game">Selected game</param>
        /// <returns></returns>
        internal static bool InstallNeedsRegion(GamesData.Game game)
        {
            return game.Regions.Length > 0;
        }

        /// <summary>
        ///     Download modded files from the URL of the ModsData to the path specified by the user
        /// </summary>
        /// <param name="modItem">Mod item to download</param>
        /// <param name="downloadPath">Path for downloading mods archive to</param>
        internal static void DownloadToLocation(ModsData.ModItem modItem, string downloadPath)
        {
            string zipFileName = string.Format("{0} v{1} ({2}).zip", modItem.Name, modItem.Version, modItem.Id);
            string zipFilePath = Path.Combine(downloadPath, zipFileName);

            WriteReadMeFile(modItem, GetDirectoryDownloadData(modItem));

            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(modItem.Url), zipFilePath);
                AddFilesToZip(zipFilePath, new string[] { Path.Combine(GetDirectoryDownloadData(modItem), "README.txt") });
            }
        }

        internal static void WriteReadMeFile(ModsData.ModItem modItem, string directoryPath)
        {
            // Create contents and write them to readme file 
            string[] contents = new string[]
            {
                modItem.Id.ToString(),
                modItem.GameId,
                modItem.Name,
                modItem.Firmware,
                modItem.Type,
                modItem.Version,
                modItem.Author,
                modItem.SubmittedBy,
                modItem.Configuration,
                modItem.Description,
                string.Join(", ", modItem.InstallPaths),
                modItem.Url
            };

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllLines(Path.Combine(directoryPath, "README.txt"), contents);
        }
        /// <summary>
        ///     Downloads the compressed archive for the mods and then extracts the archive to the appdata path
        /// </summary>
        /// <param name="modItem">Mod Item</param>
        internal static void DownloadExtractFiles(ModsData.ModItem modItem)
        {
            string archivePath = GetDirectoryDownloadData(modItem);
            string archiveFilePath = GetArchiveZipFile(modItem);

            if (Directory.Exists(archivePath))
            {
                DeleteDirectory(archivePath);
            }

            if (File.Exists(archiveFilePath))
            {
                File.Delete(archiveFilePath);
            }

            Directory.CreateDirectory(GetDirectoryDownloadData(modItem));

            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(modItem.Url), archiveFilePath);
                ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
            }
        }

        /// <summary>
        ///     Upload the specified local file to the appropriate location on the console
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void InstallFile(string hostAddress, string localFile, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                string dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                string fileName = consoleFile.Contains("/")
                        ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                        : consoleFile;

                if (!ftpConnection.DirectoryExists(dirPath))
                {
                    ftpConnection.CreateDirectory(dirPath);
                }

                ftpConnection.SetCurrentDirectory(dirPath);
                ftpConnection.PutFile(localFile, fileName);
            }                
        }

        /// <summary>
        ///     Uninstall modded files specified in the InstallPath from the users console, ignore game specific files as this
        ///     could cause game to stop working (only .sprx files)
        /// </summary>
        /// <param name="hostAddress">Console address to connect to</param>
        /// <param name="consoleFile">Mod to uninstall</param>
        internal static void UninstallFile(string hostAddress, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                string dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                string fileName = consoleFile.Contains("/")
                    ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                    : consoleFile;

                ftpConnection.SetCurrentDirectory(dirPath);

                if (ftpConnection.FileExists(consoleFile))
                {
                    ftpConnection.RemoveFile(consoleFile);
                }
            }                
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void DownloadConsoleFile(string hostAddress, string localFile, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                string dirPath = consoleFile.Contains("/")
                ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                : "dev_hdd0/";

                string fileName = consoleFile.Contains("/")
                        ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                        : consoleFile;

                ftpConnection.SetLocalDirectory(Path.GetDirectoryName(localFile));
                ftpConnection.SetCurrentDirectory(dirPath);
                ftpConnection.GetFile(consoleFile, localFile, false);
            }                
        }

        /// <summary>
        ///     Deletes the specified file from the console
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void DeleteConsoleFile(string hostAddress, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                string fileName = consoleFile.Contains("/")
                       ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                       : consoleFile;

                string dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                ftpConnection.SetCurrentDirectory(dirPath);

                if (ftpConnection.FileExists(fileName))
                {
                    ftpConnection.RemoveFile(fileName);
                }
            }                
        }

        internal static string GetDirectoryGameData(ModsData.ModItem modItem)
        {
            return $@"{AppDataPath}{modItem.GameId}\";
        }

        /// <summary>
        /// Retrieves the directory structure for extracting modded files to
        /// </summary>
        /// <param name="modItem"></param>
        /// <returns></returns>
        internal static string GetDirectoryDownloadData(ModsData.ModItem modItem)
        {
            return $@"{AppDataPath}{modItem.GameId}\{modItem.Author}\{modItem.Name.Replace(":", "")} (v{modItem.Version}) ({modItem.Id})\";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modItem"></param>
        /// <returns></returns>
        internal static string GetArchiveZipFile(ModsData.ModItem modItem)
        {
            return $@"{AppDataPath}{modItem.GameId}\{modItem.Author}\{modItem.Name.Replace(":", "")} (v{modItem.Version}) ({modItem.Id}).zip";
        }

        /// <summary>
        /// Depth-first recursive delete, with handling for descendant 
        /// directories open in Windows Explorer.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        /// <summary>
        ///     Open a new issue template for reporting mods
        /// </summary>
        /// <param name="modItem">Mod info to fill with</param>
        internal static void OpenReportTemplate(ModsData.ModItem modItem)
        {
            Process.Start($"{ProjectRepoUrl}issues/new?" +
                          $"title=[Report] {modItem.Name} ({modItem.Type}) ({modItem.GameId.ToUpper()})" +
                          $"&labels=report-mod&" +
                          $"body=Id: {modItem.Id}%0A" +
                          $"Author: {modItem.Author}%0A" +
                          $"Version: {modItem.Version}%0A" +
                          $"Configuration: {modItem.Configuration}%0A" +
                          $"Files: {string.Join(" | ", modItem.InstallPaths)}%0A" +
                          "----------------------- %0A" +
                          "*Please include some additional information about the issue you are experiencing, such as how to reproduce the problem, what happened before this occurred, etc...");
        }

        /// <summary>
        ///     Open a new issue template for requesting mods
        /// </summary>
        internal static void OpenRequestTemplate()
        {
            Process.Start($"{ProjectRepoUrl}issues/new?" +
                          $"title=[Request] Mod Name (SPRX/EBOOT/etc.)" +
                          $"&labels=request-mod&" +
                          $"body=Enter some information about the mods you'd like to be added, as well as any links you can find that showcase the mods.%0A" +
                          $"Author: Creator / Developer%0A" +
                          $"Version: Version%0A" +
                          $"Configuration: Singleplayer / Multiplayer / Zombies%0A" +
                          $"Files: Download Link%0A" +
                          "----------------------- %0A" +
                          "*Please include any other additional information you can find on the mods.");
        }

        public static void AddFilesToZip(string zipPath, string[] files)
        {
            if (files == null || files.Length == 0)
            {
                return;
            }

            using (var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
                }
            }
        }

        /// <summary>
        ///     Determines a valid json response
        /// </summary>
        /// <param name="data">Json data to validate</param>
        /// <returns>Whether text is valid json format</returns>
        public static bool IsValidJson(string data)
        {
            try
            {
                JToken unused = JToken.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DateTime? ToDateTime(this WINAPI.FILETIME time)
        {
            if ((time.dwHighDateTime == 0) && (time.dwLowDateTime == 0))
            {
                return null;
            }

            uint dwLowDateTime = (uint)time.dwLowDateTime;
#pragma warning disable CS0675 // Bitwise-or operator used on a sign-extended operand
            long fileTime = (time.dwHighDateTime << 0x20) | dwLowDateTime;
#pragma warning restore CS0675 // Bitwise-or operator used on a sign-extended operand
            return new DateTime?(DateTime.FromFileTimeUtc(fileTime));
        }
    }
}