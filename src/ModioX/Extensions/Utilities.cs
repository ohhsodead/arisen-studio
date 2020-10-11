using ModioX.Forms;
using ModioX.Models.Database;
using ModioX.Models.Release_Data;
using ModioX.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class Utilities
    {
        /// <summary>
        ///     Retrieves the user's documents folder.
        /// </summary>
        internal static string DocumentsFolder { get; } = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\ModioX\";

        /// <summary>
        ///     Web URL for this projects repository on GitHub.
        /// </summary>
        internal const string GitHubRepo = "https://github.com/ohhsodead/ModioX/";

        /// <summary>
        ///     Get the current application product version.
        /// </summary>
        /// <returns></returns>
        internal static string GetCurrentVersion()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }

        /// <summary>
        ///     Download and return the data for mods.
        /// </summary>
        /// <returns></returns>
        internal static ModsData GetModsData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/9kzqk21hkz2nt14/mods.json?raw=true").Result)
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
        ///     Download and return the data for categories and games.
        /// </summary>
        /// <returns></returns>
        internal static CategoriesData GetCategoriesData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/98bp8y8ii1o7y64/categories.json?raw=true").Result)
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
        ///     Depth-first recursive delete, with handling for descendant directories open in Windows Explorer.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                Directory.Delete(directory, true);
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
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26");

            string reportTemplate = $"issues/new?"
                                    + $"title=%5BMOD REPORT%5D {formatModName} ({modItem.GameId.ToUpper()})"
                                    + $"&labels=mod report&"
                                    + $"body=- Mod Name: {formatModName} (ID%23{modItem.Id})%0A"
                                    + $"- Category: {MainWindow.Categories.GetCategoryById(modItem.GameId).Title}%0A"
                                    + $"- Mod Type: {modItem.Type}%0A"
                                    + $"- Author: {modItem.Author}%0A"
                                    + $"- Version: {modItem.Version}%0A"
                                    + "----------------------- %0A"
                                    + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            _ = Process.Start(GitHubRepo + reportTemplate);
        }

        /// <summary>
        ///     Open a new issue template for requesting mods
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="author"></param>
        /// <param name="version"></param>
        /// <param name="systemType"></param>
        /// <param name="description"></param>
        /// <param name="links"></param>
        internal static void OpenRequestTemplate(string name, string type, string category, string author, string version, string systemType, string description, string links)
        {
            string requestTemplate = $"issues/new?"
                                     + $"title={name} ({type})&"
                                     + $"labels=mod request&"
                                     + $"assignee=ohhsodead&"
                                     + $"body=Please provide as much information you can find about the mods, also any links showcasing the mods will help to find more details.%0A"
                                     + $"- Name: {name}%0A"
                                     + $"- Category: {category}%0A"
                                     + $"- Mod Type: {type}%0A"
                                     + $"- System Type: {systemType}%0A"
                                     + $"- Author: {author}%0A"
                                     + $"- Version: {version}%0A"
                                     + $"- Description: {description}%0A"
                                     + $"- Links: {links}%0A"
                                     + "----------------------- %0A"
                                     + "*You could include any other additional information we may need here.";

            _ = Process.Start(GitHubRepo + requestTemplate);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="zipPath"></param>
        /// <param name="files"></param>
        public static void AddFilesToZip(string zipPath, string[] files)
        {
            if (files == null || files.Length == 0)
            {
                return;
            }

            using (ZipArchive zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    _ = zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
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
    }
}