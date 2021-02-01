using ModioX.Constants;
using ModioX.Models.Database;
using System.Diagnostics;
using System.Text;

namespace ModioX.Templates
{
    public static class GitHubTemplates
    {
        /// <summary>
        /// Open a new issue template for reporting errors
        /// </summary>
        /// <param name="name"> Mod info to fill with </param>
        internal static void OpenErrorTemplate(string name)
        {
            var template = new StringBuilder("issues/new?")
                .Append("title=%5BERROR REPORT%5D")
                .Append("&labels=error report&")
                .Append($"body=- Error Name: {name}%0A")
                .Append("-Describe how the error occurred:%0A%0A")
                .Append("%0A----------------------- %0A")
                .Append("*Please attach the latest.log file in the report and include any extra information.");

            Process.Start(Urls.GitHubRepo + template.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }

        /// <summary> Open a new issue template for reporting mods </summary> <param
        /// name="modItem">Mod Item</param> <param name="category">Mod's Category</param> <summary>
        internal static void OpenReportTemplate(ModItem modItem, Category category)
        {
            var template = new StringBuilder("issues/new?")
                .Append($"title=%5BMOD REPORT%5D {modItem.Name} ({modItem.GameId.ToUpper()})")
                .Append("&labels=mod report&")
                .Append($"body=- Mod Name: {modItem.Name} (ID%23{modItem.Id})%0A")
                .Append($"- Category: {category.Title}%0A")
                .Append($"- Mod Type: {modItem.Type}%0A")
                .Append($"- Author: {modItem.Author}%0A")
                .Append($"- Version: {modItem.Version}%0A")
                .Append("----------------------- %0A")
                .Append("*Please include additional information about the issue, ")
                .Append("details such as how to reproduce the problem, what happened before this occurred, etc...");

            Process.Start(Urls.GitHubRepo + template.Replace("%", "%25").Replace("(", "%28").Replace(")", "%29").Replace("&", "%26"));
        }
    }
}