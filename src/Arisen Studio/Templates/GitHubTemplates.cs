using ArisenStudio.Constants;
using ArisenStudio.Database;
using System;
using System.Diagnostics;
using System.Web;

namespace ArisenStudio.Templates
{
    public static class GitHubTemplates
    {
        /// <summary>
        /// Open a new issue template for reporting game mods.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplate(Category category, ModItemData modItem)
        {
            //string formatModName = modItem.Name
            //    .Replace("&", "and")
            //    .Replace("%", "%25")
            //    .Replace("(", "%28")
            //    .Replace(")", "%29")
            //    .Replace("/", "%2F")
            //    .Replace(@"\", "%5C");

            //string template =
            //    $"assignees=ohhsodead&" +
            //    $"title=[MOD REPORT] {modItem.Name.Replace("&", "and")} ({modItem.Platform})&"
            //    + "body="
            //    + $"- Platform: {modItem.Platform}%0D%0A"
            //    + $"- Category: {category.Title}%0D%0A"
            //    + $"- Id: %23{modItem.Id}%0D%0A"
            //    + $"- Name: {modItem.Name}%0D%0A"
            //    + $"- System Type: {modItem.FirmwareType.Replace("&", "and")}%0D%0A"
            //    + $"- Mod Type: {modItem.ModType.Replace("&", "and")}%0D%0A"
            //    + $"- Creators: {modItem.CreatedBy.Replace("&", "and")}%0D%0A"
            //    + $"- Version: {modItem.Version.Replace("&", "and")}%0D%0A"
            //    + $"- Region: {modItem.Region.Replace("&", "and")}%0D%0A"
            //    + "----------------------- %0D%0A"
            //    + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            string template =
                $"assignees=ohhsodead&" +
                $"title=[Mod Report] {modItem.Name.Replace("&", "and")} ({modItem.Platform})&"
                + "body="
                + $"- Platform: {modItem.Platform}\n"
                + $"- Category: {category.Title}\n"
                + $"- Id: %23{modItem.Id}\n"
                + $"- Name: {modItem.Name}\n"
                + $"- System Type: {modItem.FirmwareType.Replace("&", "and")}\n"
                + $"- Mod Type: {modItem.ModType.Replace("&", "and")}\n"
                + $"- Creators: {modItem.CreatedBy.Replace("&", "and")}\n"
                + $"- Version: {modItem.Version.Replace("&", "and")}\n"
                + $"- Region: {modItem.Region.Replace("&", "and")}\n"
                + "----------------------- \n"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(new Uri(Urls.GitHubDatabase + "issues/new?" + HttpUtility.UrlEncode(template)).ToString());
                //.Replace("/", "%2F")
                //.Replace(@"\", "%5C")
                //.Replace("(", "%28")
                //.Replace(")", "%29"));
        }

        /// <summary>
        /// Open a new issue template for reporting plugins.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplatePlugins(Category category, ModItemData modItem)
        {
            //string formatModName = modItem.Name
            //    .Replace("-", "%2D")
            //    .Replace("&", "and")
            //    .Replace("%", "%25")
            //    .Replace("(", "%28")
            //    .Replace(")", "%29")
            //    .Replace("[", "%5B")
            //    .Replace("]", "%5D")
            //    .Replace("/", "%2F")
            //    .Replace(@"\", "%5C");

            string template =
            $"assignees=ohhsodead&" +
            $"title=[MOD REPORT] {modItem.Name.Replace("&", "and")} ({modItem.Platform})&"
            + "body="
            + $"- Category: {category.Title}%0D%0A"
            + $"- Id: %23{modItem.Id}%0D%0A"
            + $"- Name: {modItem.Name}%0D%0A"
            + $"- Version: {modItem.Version.Replace("&", "and")}%0D%0A"
            + $"- Game Type: {modItem.ModType.Replace("&", "and")}%0D%0A"
            + "----------------------- %0D%0A"
            + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(new Uri(Urls.GitHubDatabase + "issues/new?" + HttpUtility.UrlEncode(template)).ToString());
                //.Replace("-", "%2D")
                //.Replace("&", "and")
                //.Replace("%", "%25")
                //.Replace("(", "%28")
                //.Replace(")", "%29")
                //.Replace("[", "%5B")
                //.Replace("]", "%5D")
                //.Replace("/", "%2F")
                //.Replace(@"\", "%5C");
        }

        /// <summary>
        /// Open a new issue template for reporting apps.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="appItemData"></param>
        internal static void OpenReportTemplateApps(Category category, AppItemData appItemData)
        {
            //string formatModName = appItemData.Name
            //    .Replace("-", "%2D")
            //    .Replace("&", "and")
            //    .Replace("%", "%25")
            //    .Replace("(", "%28")
            //    .Replace(")", "%29")
            //    .Replace("[", "%5B")
            //    .Replace("]", "%5D")
            //    .Replace("/", "%2F")
            //    .Replace(@"\", "%5C");

            string template =
                $"title=[MOD REPORT] {appItemData.Name.Replace("&", "and")} ({appItemData.Platform})&"
                + "body="
                + $"- Platform: {appItemData.Platform}%0D%0A"
                + $"- Category: {category.Title}%0D%0A"
                + $"- Id: %23{appItemData.Id}%0D%0A"
                + $"- Name: {appItemData.Name}%0D%0A"
                + $"- Playable Versions: {string.Join("/", appItemData.FirmwareVersions).Replace("&", "and")} + %0D%0A"
                + $"- Version: {appItemData.Version.Replace("&", "and")}%0D%0A"
                + $"- TitleId: {appItemData.TitleId.Replace("&", "and")}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(new Uri(Urls.GitHubDatabase + "issues/new?" + HttpUtility.UrlEncode(template)).ToString());
            //.Replace("-", "%2D")
            //.Replace("&", "and")
            //.Replace("%", "%25")
            //.Replace("(", "%28")
            //.Replace(")", "%29")
            //.Replace("[", "%5B")
            //.Replace("]", "%5D")
            //.Replace("/", "%2F")
            //.Replace(@"\", "%5C");
        }

        /// <summary>
        /// Open a new issue template for reporting game saves.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplateGameSave(Category category, GameSaveItemData modItem)
        {
            //string formatModName = modItem.Name
            //    .Replace("&", "and")
            //    .Replace("%", "%25")
            //    .Replace("(", "%28")
            //    .Replace(")", "%29")
            //    .Replace("/", "%2F")
            //    .Replace(@"\", "%5C");

            string template =
                $"assignees=ohhsodead&" +
                $"title=[MOD REPORT] {modItem.Name.Replace("&", "and")} ({modItem.Platform})&"
                + "body="
                + $"- Platform: {modItem.Platform}%0D%0A"
                + $"- Category: {category.Title}%0D%0A"
                + $"- Id: %23{modItem.Id}%0D%0A"
                + $"- Name: {modItem.Name}%0D%0A"
                + $"- Version: {modItem.Version.Replace("&", "and")}%0D%0A"
                + $"- Region: {modItem.Region.Replace("&", "and")}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(new Uri(Urls.GitHubDatabase + "issues/new?" + HttpUtility.UrlEncode(template)).ToString());
                //.Replace("/", "%2F")
                //.Replace(@"\", "%5C")
                //.Replace("(", "%28")
                //.Replace(")", "%29"));
        }

        /// <summary>
        /// Open a new issue template for reporting game saves.
        /// </summary>
        /// <param name="gameCheatItem"></param>
        /// <param name="cheat"></param>
        /// <param name="offset"></param>
        internal static void OpenReportTemplateGameCheat(GameCheatItemData gameCheatItem, Cheats cheat, Offsets offset)
        {
            //string formatModName = gameCheatItem.Game
            //    .Replace("&", "and")
            //    .Replace("%", "%25")
            //    .Replace("(", "%28")
            //    .Replace(")", "%29")
            //    .Replace("/", "%2F")
            //    .Replace(@"\", "%5C");

            string template =
                $"assignees=ohhsodead&" +
                $"title=[CHEAT REPORT] {gameCheatItem.Game.Replace("&", "and")}&"
                + "body="
                + $"- Game: {gameCheatItem.Game}%0D%0A"
                + $"- Region: {gameCheatItem.Region}%0D%0A"
                + $"- Version: {gameCheatItem.Version}%0D%0A"
                + $"- Cheat Name: {cheat.Name}%0D%0A"
                + $"- Cheat Opcode: {offset.Opcode}%0D%0A"
                + $"- Cheat Offset: {offset.Offset}%0D%0A"
                + $"- Cheat Value: {offset.Value}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(new Uri(Urls.GitHubDatabase + "issues/new?" + HttpUtility.UrlEncode(template)).ToString());
                //.Replace("/", "%2F")
                //.Replace(@"\", "%5C")
                //.Replace("(", "%28")
                //.Replace(")", "%29"));
        }
    }
}