using ModioX.Models.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Reflection;

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
                using (HttpResponseMessage response = client.GetAsync("https://www.dropbox.com/s/9kzqk21hkz2nt14/mods.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<ModsData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the information for categories and games
        /// </summary>
        /// <returns></returns>
        internal static CategoriesData GetCategoriesData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://www.dropbox.com/s/98bp8y8ii1o7y64/categories.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<CategoriesData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
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