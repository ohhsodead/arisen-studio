using ModioX.Forms;
using ModioX.Models.Database;
using ModioX.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
        internal const string ProjectRepoUrl = "https://github.com/ohhsodead/ModioX/";

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
        ///     Download and return the information for categories and games
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
        ///         
        /// </summary>
        /// <param name="title"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string GetItemFromList(string title, List<string> items)
        {
            using (ListItemPicker listViewDialog = new ListItemPicker() { Text = title, Items = items })
            {
                listViewDialog.ShowDialog();
                return listViewDialog.SelectedItem;
            }
        }

        /// <summary>
        ///     Depth-first recursive delete, with handling for descendant 
        ///     directories open in Windows Explorer.
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
            _ = Process.Start($"{ProjectRepoUrl}issues/new?"
                              + $"title={modItem.Name} ({modItem.Type}) ({modItem.GameId.ToUpper()})"
                              + $"&labels=mod report&"
                              + $"body=- Mod Name: {modItem.Name}%0A"
                              + $"- Mod Id: {modItem.Id}%0A"
                              + $"- Mod Type: {modItem.Type}%0A"
                              + $"- Category: {MainForm.Categories.GetCategoryById(modItem.GameId).Title}%0A"
                              + $"- Author: {modItem.Author}%0A"
                              + $"- Version: {modItem.Version}%0A"
                              + "----------------------- %0A"
                              + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...");
        }

        /// <summary>
        ///     Open a new issue template for requesting mods
        /// </summary>
        internal static void OpenRequestTemplate()
        {
            _ = Process.Start($"{ProjectRepoUrl}issues/new?"
                              + $"title=Mod Name (SPRX/EBOOT/etc.)"
                              + $"&labels=mod request&"
                              + $"body=Please provide as much information you can find about the mods, also any links you can find showcasing the mods will help to find more details.%0A"
                              + $"- Author: Creator/Developer%0A"
                              + $"- Version: Version%0A"
                              + $"- Game Type: Singleplayer/Multiplayer/Zombies%0A"
                              + $"- Files: Download Link%0A"
                              + "----------------------- %0A"
                              + "*Here you can include any other additional information we may need.");
        }

        /// <summary>
        ///     Open a new issue template for requesting mods
        /// </summary>
        internal static void OpenRequestTemplate(string name, string type, string categoryTitle, string author, string version, string description, string links)
        {
            string requestTemplate = $"{ProjectRepoUrl}issues/new?"
                                     + $"title=[Request Mod] {name} ({type})&"
                                     + $"labels=mod request&"
                                     + $"assignee=ohhsodead&"
                                     + $"body=Please provide as much information you can find about the mods, also any links you can find showcasing the mods will help to find more details.%0A"
                                     + $"- Name: {name}%0A"
                                     + $"- Type: {type}%0A"
                                     + $"- Category: {categoryTitle}%0A"
                                     + $"- Author: {author}%0A"
                                     + $"- Version: {version}%0A"
                                     + $"- Description: {description}%0A"
                                     + $"- Links: {links}%0A"
                                     + "----------------------- %0A"
                                     + "*You could include any other additional information we may need here.";

            _ = Process.Start(requestTemplate);
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