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

namespace ModioX.Extensions
{
    internal static class Utilities
    {
        /// <summary>
        ///     Application user's data roaming directory
        /// </summary>
        internal static string AppDataPath { get; } = $@"{Application.UserAppDataPath}\";

        /// <summary>
        ///     Web URL pointing to the project repo hosted on GitHub
        /// </summary>
        internal const string ProjectRepoUrl = "https://github.com/wh1ter0se-x/ModioX/";

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
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://www.dropbox.com/s/9kzqk21hkz2nt14/modsdata.json?raw=true").Result;

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (IsValidJson(responseData))
                    return JsonConvert.DeserializeObject<ModsData>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.Message.ToString());
            }
        }
        
        /// <summary>
        ///     Download and return the information for supported games
        /// </summary>
        /// <returns></returns>
        internal static GamesData GetGamesData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://www.dropbox.com/s/98bp8y8ii1o7y64/gamedata.json?raw=true").Result;

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (IsValidJson(responseData))
                    return JsonConvert.DeserializeObject<GamesData>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.Message.ToString());
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
            foreach (GamesData.Game game in gamesData.Games)
            {
                if (game.Title.Equals(gameTitle))
                {
                    return game;
                }
            }

            throw new Exception("Unable to find game data for the given title");
        }

        /// <summary>
        ///     Retrieve the mods data from the loaded database
        /// </summary>
        /// <param name="modsData">Name of the mod</param>
        /// <param name="modId">Name of the mod</param>
        /// <returns>Mod information</returns>
        internal static ModsData.ModItem GetModById(ModsData modsData, long modId)
        {
            foreach (ModsData.ModItem mod in modsData.Mods)
            {
                if (mod.Id == modId)
                {
                    return mod;
                }
            }

            throw new Exception($"Unable to match with modId : {modId}");
        }

        /// <summary>
        ///     Returns the users game region, either automatically set region by searching existing console directories or prompt
        ///     the user to select one
        /// </summary>
        /// <param name="ipAddress">Selected game</param>
        /// <param name="game">Automatically retrieve users region</param>
        /// <param name="detectRegion">Automatically retrieve users region</param>
        /// <returns></returns>
        internal static string GetUsersGameRegion(string ipAddress, GamesData.Game game, bool detectRegion)
        {
            if (detectRegion)
            {
                using (var ps3 = new FtpConnection(ipAddress))
                {
                    foreach (var region in game.Regions)
                    {
                        if (ps3.DirectoryExists($"dev_hdd0/game/{region}/"))
                        {
                            return region;
                        }
                    }
                }
            }
            else
            {
                using (Windows.RegionsWindow frmRegions = new Windows.RegionsWindow())
                {
                    foreach (var region in game.Regions)
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
        ///     Download modded files from the URL of the ModsData to the path specified by the user
        /// </summary>
        /// <param name="modItem">Mod to download</param>
        /// <param name="downloadPath">Mod to download</param>
        internal static void DownloadToLocation(ModsData.ModItem modItem, string downloadPath)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(modItem.Url),$"{downloadPath}/{modItem.Name} (v{modItem.Version}) ({modItem.Author}).zip");
            }
        }

        /// <summary>
        ///     Downloads the compressed archive for the mods and then extracts the archive to the appdata path
        /// </summary>
        /// <param name="modItem">Mod Item</param>
        internal static void DownloadExtractFiles(ModsData.ModItem modItem)
        {
            string archivePath = $"{AppDataPath}{modItem.GameId}{modItem.Name}";
            string archiveFilePath = $"{AppDataPath}{modItem.GameId}{modItem.Name}.zip";

            if (Directory.Exists(archivePath))
            {
                Directory.Delete(archivePath, true);
            }

            if (File.Exists(archiveFilePath))
            {
                File.Delete(archiveFilePath);
            }

            DownloadToLocation(modItem, archiveFilePath);
            ZipFile.ExtractToDirectory(archiveFilePath, archiveFilePath);
        }

        /// <summary>
        ///     Upload the specified local file to the appropriate location on the console
        /// </summary>
        /// <param name="ipAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void InstallFile(string ipAddress, string localFile, string consoleFile)
        {
            using (FtpConnection ps3 = new FtpConnection(ipAddress))
            {
                var fileName = consoleFile.Contains("/")
                    ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                    : consoleFile;

                var dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                ps3.SetCurrentDirectory(dirPath);
                ps3.PutFile(localFile, fileName);
            }
        }

        /// <summary>
        ///     Uninstall modded files specified in the InstallPath from the users console, ignore game specific files as this
        ///     could cause game to stop working (only .sprx files)
        /// </summary>
        /// <param name="ipAddress">Console address to connect to</param>
        /// <param name="modItem">Mod to uninstall</param>
        internal static void UninstallModFiles(string ipAddress, ModsData.ModItem modItem)
        {
            foreach (string installFilePath in modItem.InstallPaths)
            {
                using (FtpConnection ps3 = new FtpConnection(ipAddress))
                {
                    string dirPath = installFilePath.Contains("/")
                        ? installFilePath.Substring(0, installFilePath.LastIndexOf('/')) + '/'
                        : "dev_hdd0/";

                    string fileName = installFilePath.Contains("/")
                        ? installFilePath.Substring(installFilePath.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                        : installFilePath;

                    if (ps3.FileExists(installFilePath) && !installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ps3.RemoveFile(installFilePath);
                    }
                }
            }
        }

        /// <summary>
        ///     Uninstall modded files specified in the InstallPath from the users console, ignore game specific files as this
        ///     could cause game to stop working (only .sprx files)
        /// </summary>
        /// <param name="ipAddress">Mod to uninstall</param>
        /// <param name="remoteFile">Mod to uninstall</param>
        /// <param name="modItem">Mod to uninstall</param>
        internal static void DownloadOriginalGameFile(string ipAddress, string remoteFile, ModsData.ModItem modItem)
        {
            /*foreach (var installFilePath in modInfo.InstallPaths)
            {
                using (var ps3 = new FtpConnection(ipAddress))
                {
                    if (ps3.FileExists(installFilePath) && !installFilePath.StartsWith("dev_hdd0/game/{REGION}/", StringComparison.InvariantCultureIgnoreCase))
                        ps3.RemoveFile(installFilePath);
                }
            }*/

            using (FtpConnection ps3 = new FtpConnection(ipAddress))
            {

                string dirPath = remoteFile.Contains("/")
                    ? remoteFile.Substring(0, remoteFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                string fileName = remoteFile.Contains("/")
                    ? remoteFile.Substring(remoteFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                    : remoteFile;

                string localFilePath = $@"{AppDataPath}{modItem.GameId}\{modItem.Name}\";

                Directory.CreateDirectory(localFilePath);

                ps3.SetCurrentDirectory(dirPath);
                ps3.GetFile(remoteFile, $@"{localFilePath}{fileName}".Replace("/", @"\"), false);
                //ps3.PutFile(localFile, fileName);
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
                          $"body=Mod Id: {modItem.Id}%0A" +
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

        /// <summary>
        ///     Determines a valid json response
        /// </summary>
        /// <param name="data">Json data to validate</param>
        /// <returns>Whether text is valid json format</returns>
        private static bool IsValidJson(string data)
        {
            try
            {
                var unused = JToken.Parse(data);
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