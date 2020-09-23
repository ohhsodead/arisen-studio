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
        ///     Application user's data roaming directory
        /// </summary>
        internal static string AppDataPath { get; } = $@"{Application.UserAppDataPath}\";

        /// <summary>
        ///     Web URL for this projects repository on GitHub.
        /// </summary>
        internal const string GitHubRepo = "https://github.com/ohhsodead/ModioX/";

        /// <summary>
        ///     Web API for this projects repository on GitHub with the latest release information.
        /// </summary>
        internal const string GitHubRelease = "https://api.github.com/repos/ohhsodead/ModioX/releases/latest";

        /// <summary>
        ///     Get the current application product version.
        /// </summary>
        /// <returns></returns>
        internal static string GetCurrentVersion()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }

        /// <summary>
        ///     Download and return the mods information.
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
        ///     Download and return the information for categories and games.
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
        ///         Returns the item selected from the list item picker.
        /// </summary>
        /// <param name="title">Window title</param>
        /// <param name="items">Items to select from</param>
        /// <returns></returns>
        public static string GetItemFromList(string title, List<string> items)
        {
            using (ListItemPicker listViewDialog = new ListItemPicker() { Text = title, Items = items })
            {
                _ = listViewDialog.ShowDialog();
                return listViewDialog.SelectedItem;
            }
        }

        /// <summary>
        ///     Depth-first recursive delete, with handling for descendant directories open in Windows Explorer.
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
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26");

            string reportTemplate = $"issues/new?"
                                    + $"title=%5BMOD REPORT%5D {formatModName} ({modItem.GameId.ToUpper()})"
                                    + $"&labels=mod report&"
                                    + $"body=- Mod Name: {formatModName} (ID%23{modItem.Id})%0A"
                                    + $"- Category: {MainForm.Categories.GetCategoryById(modItem.GameId).Title}%0A"
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

        /// <summary>
        ///     
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
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

        /// <summary>
        ///     Shows the data view window with the specified parameters
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="title"></param>
        /// <param name="subtitle"></param>
        /// <param name="body"></param>
        public static void ShowDataViewWindow(Form owner, string title, string subtitle, string body)
        {
            using (DataViewWindow dataViewWindow = new DataViewWindow { Text =  title })
            {
                dataViewWindow.LabelTitle.Text = subtitle;
                dataViewWindow.LabelData.Text = body;

                dataViewWindow.MaximumSize = new Size(dataViewWindow.MaximumSize.Width, owner.Height + 100);
                dataViewWindow.Size = new Size(dataViewWindow.Width, dataViewWindow.Height + 15);
                _ = dataViewWindow.ShowDialog(owner);
            }
        }

        /// <summary>
        ///     Shows the changelog form with the new Github release data
        /// </summary>
        /// <param name="owner">Parent owner of the data view window</param>
        public static void ShowWhatsNewWindow(Form owner)
        {
            try
            {
                GitHubData GitHubData = GetGitHubReleaseData();

                string releaseBody = GitHubData.Body;
                string releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine));

                ShowDataViewWindow(owner, GitHubData.Name + " - What's New", "Change Log", releaseBodyWithoutLastLine.Replace("-", "•"));
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load github release data.", ex);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        public static GitHubData GetGitHubReleaseData()
        {
            GitHubData GitHubReleaseData;

            using (StreamReader streamReader = new StreamReader(HttpExtensions.GetStream(GitHubRelease)))
            {
                GitHubReleaseData = JsonConvert.DeserializeObject<GitHubData>(streamReader.ReadToEnd());
            }

            return GitHubReleaseData;
        }
    }
}