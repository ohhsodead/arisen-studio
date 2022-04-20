using Modio.Constants;
using Modio.Database;
using System.Diagnostics;

namespace Modio.Templates
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
            string formatModName = modItem.Name
                .Replace("&", "and")
                .Replace("%", "%25")
                .Replace("(", "%28")
                .Replace(")", "%29")
                .Replace("/", "%2F")
                .Replace(@"\", "%5C");

            string template =
                $"assignees=ohhsodead&" +
                $"title=[MOD REPORT] {formatModName.Replace("&", "and")} ({modItem.Platform})&"
                + "body="
                + $"- Platform: {modItem.Platform}%0D%0A"
                + $"- Category: {category.Title}%0D%0A"
                + $"- Id: %23{modItem.Id}%0D%0A"
                + $"- Name: {formatModName}%0D%0A"
                + $"- System Type: {modItem.FirmwareType.Replace("&", "and")}%0D%0A"
                + $"- Mod Type: {modItem.ModType.Replace("&", "and")}%0D%0A"
                + $"- Creators: {modItem.CreatedBy.Replace("&", "and")}%0D%0A"
                + $"- Version: {modItem.Version.Replace("&", "and")}%0D%0A"
                + $"- Region: {modItem.Region.Replace("&", "and")}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template
                .Replace("/", "%2F")
                .Replace(@"\", "%5C")
                .Replace("(", "%28")
                .Replace(")", "%29"));
        }

        /// <summary>
        /// Open a new issue template for reporting plugins.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplatePlugins(Category category, ModItemData modItem)
        {
            string formatModName = modItem.Name
                .Replace("&", "and")
                .Replace("%", "%25")
                .Replace("(", "%28")
                .Replace(")", "%29")
                .Replace("/", "%2F")
                .Replace(@"\", "%5C");

            string template =
                $"assignees=ohhsodead&" +
                $"title=[MOD REPORT] {formatModName.Replace("&", "and")} ({modItem.Platform})&"
                + "body="
                + $"- Category: {category.Title}%0D%0A"
                + $"- Id: %23{modItem.Id}%0D%0A"
                + $"- Name: {formatModName}%0D%0A"
                + $"- Version: {modItem.Version.Replace("&", "and")}%0D%0A"
                + $"- Game Type: {modItem.ModType.Replace("&", "and")}%0D%0A"
                + $"- Creators: {modItem.CreatedBy.Replace("&", "and")}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template
                .Replace("/", "%2F")
                .Replace(@"\", "%5C")
                .Replace("(", "%28")
                .Replace(")", "%29"));
        }

        /// <summary>
        /// Open a new issue template for reporting game saves.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplateGameSave(Category category, GameSaveItemData modItem)
        {
            string formatModName = modItem.Name
                .Replace("&", "and")
                .Replace("%", "%25")
                .Replace("(", "%28")
                .Replace(")", "%29")
                .Replace("/", "%2F")
                .Replace(@"\", "%5C");

            string template =
                $"assignees=ohhsodead&" +
                $"title=[MOD REPORT] {formatModName.Replace("&", "and")} ({modItem.Platform})&"
                + "body="
                + $"- Platform: {modItem.Platform}%0D%0A"
                + $"- Category: {category.Title}%0D%0A"
                + $"- Id: %23{modItem.Id}%0D%0A"
                + $"- Name: {formatModName}%0D%0A"
                + $"- Creator: {modItem.CreatedBy.Replace("&", "and")}%0D%0A"
                + $"- Version: {modItem.Version.Replace("&", "and")}%0D%0A"
                + $"- Region: {modItem.Region.Replace("&", "and")}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template
                .Replace("/", "%2F")
                .Replace(@"\", "%5C")
                .Replace("(", "%28")
                .Replace(")", "%29"));
        }

        /// <summary>
        /// Open a new issue template for reporting game saves.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        internal static void OpenReportTemplateGameCheat(GameCheatItemData gameCheatItem, Cheats cheat, Offsets offset)
        {
            string formatModName = gameCheatItem.Game
                .Replace("&", "and")
                .Replace("%", "%25")
                .Replace("(", "%28")
                .Replace(")", "%29")
                .Replace("/", "%2F")
                .Replace(@"\", "%5C");

            string template =
                $"assignees=ohhsodead&" +
                $"title=[CHEAT REPORT] {formatModName.Replace("&", "and")}&"
                + "body="
                + $"- Game: {gameCheatItem.Game}%0D%0A"
                + $"- Region: {gameCheatItem.Region}%0D%0A"
                + $"- Version: {gameCheatItem.Version}%0D%0A"
                + $"- Cheat Name: {cheat.Name}%0D%0A"
                + $"- Cheat Opcode: {offset.Opcode}%0D%0A"
                + $"- Cheat Offset: {offset.Param1}%0D%0A"
                + $"- Cheat Value: {offset.Param2}%0D%0A"
                + "----------------------- %0D%0A"
                + "*Please include additional information about the issue, details such as how to reproduce the problem, what happened before this occurred, etc...";

            Process.Start(Urls.GitHubRepo + "issues/new?" + template
                .Replace("/", "%2F")
                .Replace(@"\", "%5C")
                .Replace("(", "%28")
                .Replace(")", "%29"));
        }
    }
}