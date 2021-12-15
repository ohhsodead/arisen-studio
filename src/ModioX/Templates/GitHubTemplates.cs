using System.Diagnostics;
using ModioX.Constants;
using ModioX.Database;

namespace ModioX.Templates
{
    public static class GitHubTemplates
    {
        /// <summary>
        /// Open a new issue template for reporting mods.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplate(Category category, ModItemData modItem)
        {
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29")
                .Replace("&", "%26").Replace("/", "%2F").Replace(@"\", "%5C");

            string template =
                $"title=%5BMOD REPORT%5D {formatModName} (ID%23{modItem.Id}) ({modItem.Platform})&"
                + "labels=mod report&"
                + "assignee=ohhsodead&"
                + "body="
                + $"- Platform: {modItem.Platform}%0A"
                + $"- Category: {category.Title}%0A"
                + $"- Name: {formatModName} (ID%23{modItem.Id})%0A"
                + $"- System Type: {modItem.FirmwareType}%0A"
                + $"- Mod Type: {modItem.ModType}%0A"
                + $"- Creators: {modItem.CreatedBy}%0A"
                + $"- Version: {modItem.Version}%0A"
                + $"- Region: {modItem.Region}%0A"
                + "----------------------- %0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template.Replace("/", "%2F").Replace(@"\", "%5C")
                .Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }

        /// <summary>
        /// Open a new issue template for reporting mods.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplatePlugins(Category category, ModItemData modItem)
        {
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29")
                .Replace("&", "%26").Replace("/", "%2F").Replace(@"\", "%5C");

            string template =
                $"title=%5BPLUGIN REPORT%5D {formatModName} (ID%23{modItem.Id})&"
                + "labels=mod report&"
                + "assignee=ohhsodead&"
                + "body="
                + $"- Category: {category.Title}%0A"
                + $"- Name: {formatModName} (ID%23{modItem.Id})%0A"
                + $"- Version: {modItem.Version}%0A"
                + $"- Game Type: {modItem.ModType}%0A"
                + $"- Creators: {modItem.CreatedBy}%0A"
                + "----------------------- %0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template.Replace("/", "%2F").Replace(@"\", "%5C")
                .Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }

        /// <summary>
        /// Open a new issue template for reporting mods.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplateGameSave(Category category, GameSaveItemData modItem)
        {
            string formatModName = modItem.Name.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29")
                .Replace("&", "%26").Replace("/", "%2F").Replace(@"\", "%5C");

            string template =
                $"title=%5BGAME SAVE REPORT%5D {formatModName} (ID%23{modItem.Id}) ({modItem.Platform})&"
                + "labels=mod report&"
                + "assignee=ohhsodead&"
                + "body="
                + $"- Platform: {modItem.Platform}%0A"
                + $"- Category: {category.Title}%0A"
                + $"- Name: {formatModName} (ID%23{modItem.Id})%0A"
                + $"- Creator: {modItem.CreatedBy}%0A"
                + $"- Version: {modItem.Version}%0A"
                + $"- Region: {modItem.Region}%0A"
                + "----------------------- %0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template.Replace("/", "%2F").Replace(@"\", "%5C")
                .Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }
    }
}