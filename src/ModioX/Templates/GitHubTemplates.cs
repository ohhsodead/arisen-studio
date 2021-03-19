using System.Diagnostics;
using System.Text;
using ModioX.Constants;
using ModioX.Database;
using ModioX.Extensions;

namespace ModioX.Templates
{
    public static class GitHubTemplates
    {
        /// <summary>
        /// Open a new issue template for reporting errors.
        /// </summary>
        /// <param name="name"> Mod info to fill with </param>
        internal static void OpenErrorTemplate(string name)
        {
            StringBuilder template = new StringBuilder("issues/new?")
                .Append("title=%5BERROR REPORT%5D")
                .Append("&labels=error report&")
                .Append($"body=- Error Name: {name}%0A")
                .Append("-Describe how the error occurred:%0A%0A")
                .Append("%0A----------------------- %0A")
                .Append("*Please attach the latest.log file in the report and include any extra information.");

            Process.Start(Urls.GitHubRepo + template.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }

        /// <summary>
        /// Open a new issue template for requesting mods.
        /// </summary>
        /// <param name="modItem"></param>
        /// <param name="category"></param>
        internal static void OpenReportTemplate(ModItem modItem, Category category)
        {
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26").Replace("/", "%2F").Replace(@"\", "%5C");

            string template = 
                $"title=%5BMOD REPORT%5D {formatModName} (ID%23{modItem.Id}) ({modItem.ConsoleType})&"
                + "labels=mod request&"
                + "assignee=ohhsodead&"
                + "body="
                + $"- Console Type: {modItem.GetConsoleType().GetDescription()}%0A"
                + $"- Category: {category.Title}%0A"
                + $"- Name: {formatModName} (ID%23{modItem.Id})%0A"
                + $"- System Type: {modItem.Firmware}%0A"
                + $"- Mod Type: {modItem.Type}%0A"
                + $"- Author: {modItem.Author}%0A"
                + $"- Version: {modItem.Version}%0A"
                + $"- Region: {modItem.Region}%0A"
                + "----------------------- %0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template.Replace("/", "%2F").Replace(@"\", "%5C"));
        }

        /// <summary>
        /// Open a new issue template for requesting mods.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="creator"></param>
        /// <param name="version"></param>
        /// <param name="systemType"></param>
        /// <param name="description"></param>
        /// <param name="links"></param>
        internal static void OpenRequestTemplate(string name, string category, string creator, string version, string systemType, string description, string links)
        {
            StringBuilder template = new StringBuilder("issues/new?")
                .Append($"title=[MOD REQUEST] {name}&")
                .Append("labels=mod request&")
                .Append("assignee=ohhsodead&")
                .Append("body=")
                .Append($"- Name: {name}%)0A")
                .Append($"- Category: {category}%0A")
                .Append($"- System Type: {systemType}%0A")
                .Append($"- Author: {creator}%0A")
                .Append($"- Version: {version}%0A")
                .Append($"- Description: {description}%0A")
                .Append($"- Links: {links}%0A")
                .Append("----------------------- %0A")
                .Append("*Please include any other additional information we may need here.");

            Process.Start(Urls.GitHubRepo + template.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }
    }
}