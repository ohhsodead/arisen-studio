using ModioX.Constants;
using ModioX.Models.Database;
using System.Diagnostics;

namespace ModioX.Templates
{
    public static class GitHubTemplates
    {
        /// <summary>
        ///     Open a new issue template for reporting mods
        /// </summary>
        /// <param name="modItem">Mod info to fill with</param>
        /// <param name="category">Mod info to fill with</param>
        internal static void OpenReportTemplate(ModsData.ModItem modItem, CategoriesData.Category category)
        {
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26");

            string reportTemplate = $"issues/new?"
                                    + $"title=%5BMOD REPORT%5D {formatModName} ({modItem.GameId.ToUpper()})"
                                    + $"&labels=mod report&"
                                    + $"body=- Mod Name: {formatModName} (ID%23{modItem.Id})%0A"
                                    + $"- Category: {category.Title}%0A"
                                    + $"- Mod Type: {modItem.Type}%0A"
                                    + $"- Author: {modItem.Author}%0A"
                                    + $"- Version: {modItem.Version}%0A"
                                    + "----------------------- %0A"
                                    + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            _ = Process.Start(Urls.GitHubRepo + reportTemplate);
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

            _ = Process.Start(Urls.GitHubRepo + requestTemplate);
        }
    }
}
