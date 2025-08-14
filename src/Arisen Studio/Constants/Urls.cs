using ArisenStudio.Extensions;
using System;
using System.Web;

namespace ArisenStudio.Constants
{
    public static class Urls
    {
        /// <summary>
        /// URL pointing to official project website.
        /// </summary>
        internal const string ProjectWebsite = "https://arisen.studio/";

        /// <summary>
        /// URL pointing to help page on the official project website.
        /// </summary>
        internal const string WebsiteHelp = "https://arisen.studio/help";

        /// <summary>
        /// URL pointing to the request mods form on the project website.
        /// </summary>
        internal const string RequestForm = "https://arisen.studio/submit"; //"https://github.com/OhhSoWzrd/arisen-studio/issues/new?assignees=&labels=mod+request&projects=&template=mod-request.yml&title=%5BMod+Request%5D%3A+"; 

        /// <summary>
        /// URL pointing to the report issues form on the project website.
        /// </summary>
        internal const string ReportIssue = "https://arisen.studio/report"; //"https://github.com/OhhSoWzrd/arisen-studio/issues/new?assignees=&labels=bug&projects=&template=bug.yml&title=%5BBug%5D%3A+"; 

        /// <summary>
        /// URL pointing to the project's Discord Server.
        /// </summary>
        internal const string DiscordServer = "https://discord.gg/FTCS3Xu";

        /// <summary>
        /// URL pointing to the donation page on Patreon.
        /// </summary>
        internal const string DonatePatreon = "https://patreon.com/OhhSoWzrd?utm_medium=unknown&utm_source=join_link&utm_campaign=creatorshare_creator&utm_content=copyLink";

        /// <summary>
        /// URL pointing to the donation page on PayPal.
        /// </summary>
        internal const string DonatePayPal = "https://paypal.me/OhhSoWzrd";

        /// <summary>
        /// URL pointing to the my Twitter/X profile.
        /// </summary>
        internal const string TwitterProfile = "https://twitter.com/OhhSoWzrd";

        /// <summary>
        /// URL pointing to the test file hosted on @Goldug's server for Arisen.
        /// </summary>
        internal const string StatusCheck = "https://db.arisen.studio/app/status.txt";

        /// <summary>
        /// URL pointing to the update data file hosted @Goldug's server for Arisen.
        /// </summary>
        internal const string UpdateData = "https://db.arisen.studio/app/update.xml";

        /// <summary>
        /// URL pointing to the announcements file hosted on @Goldug's server for Arisen.
        /// </summary>
        internal const string AnnouncementsData = "https://db.arisen.studio/app/announcements.json";

        /// <summary>
        /// URL pointing to the news feed file hosted on @Goldug's server for Arisen.
        /// </summary>
        internal const string RssFeedData = "https://db.arisen.studio/app/news.xml";

        /// <summary>
        /// URL pointing to the project repo hosted on GitHub.
        /// </summary>
        internal const string GitHubRepo = "https://github.com/OhhSoWzrd/arisen-studio/";

        /// <summary>
        /// URL pointing to the releases information via GitHub API.
        /// </summary>
        internal const string GitHubReleases = "https://api.github.com/repos/OhhSoWzrd/arisen-studio/releases";

        /// <summary>
        /// URL pointing to the stats file.
        /// </summary>
        internal const string StatsData = "https://raw.githubusercontent.com/OhhSoWzrd/arisen-studio/main/.github/stats/stats.json";

        /// <summary>
        /// URL pointing to the list of Categories database file.
        /// </summary>
        internal const string CategoriesData = "https://db.arisen.studio/data/categories.json";

        /// <summary>
        /// URL pointing to the current list of Favorite Games database file.
        /// </summary>
        internal const string FavoriteGamesData = "https://db.arisen.studio/data/favorite-games.json";

        /// <summary>
        /// URL pointing to the current list of Favorite Mods database file.
        /// </summary>
        internal const string FavoriteModsData = "https://db.arisen.studio/data/favorite-mods.json";

        /// <summary>
        /// URL pointing to the Game Saves database file for PS3 and Xbox 360.
        /// </summary>
        internal const string GameSavesData = "https://db.arisen.studio/data/game-saves.json";

        /// <summary>
        /// URL pointing to the Game Mods database file for PS3.
        /// </summary>
        internal const string GameModsDataPS3 = "https://db.arisen.studio/data/ps3/game-mods.json";

        /// <summary>
        /// URL pointing to the Homebrew database file for PS3.
        /// </summary>
        internal const string HomebrewDataPS3 = "https://db.arisen.studio/data/ps3/homebrew.json";

        /// <summary>
        /// URL pointing to the Resources database file for PS3.
        /// </summary>
        internal const string ResourcesDataPS3 = "https://db.arisen.studio/data/ps3/resources.json";

        /// <summary>
        /// URL pointing to the Avatars (Packages) database file for PS3.
        /// </summary>
        internal const string PackagesAvatarsDataPS3 = "https://db.arisen.studio/data/ps3/packages/avatars.json";

        /// <summary>
        /// URL pointing to the Demos (Packages) database file for PS3.
        /// </summary>
        internal const string PackagesDemosDataPS3 = "https://db.arisen.studio/data/ps3/packages/demos.json";

        /// <summary>
        /// URL pointing to the DLC (Packages) database file for PS3.
        /// </summary>
        internal const string PackagesDLCsDataPS3 = "https://db.arisen.studio/data/ps3/packages/dlcs.json";

        /// <summary>
        /// URL pointing to the Games (Packages) database file for PS3.
        /// </summary>
        internal const string PackagesGamesDataPS3 = "https://db.arisen.studio/data/ps3/packages/games.json";

        /// <summary>
        /// URL pointing to the Themes (Packages) database file for PS3.
        /// </summary>
        internal const string PackagesThemesDataPS3 = "https://db.arisen.studio/data/ps3/packages/themes.json";

        /// <summary>
        /// URL pointing to the Game Cheats database file for PS3.
        /// </summary>
        internal const string GameCheatsDataPS3 = "https://db.arisen.studio/data/ps3/game-cheats.json";

        /// <summary>
        /// URL pointing to the Game Cheats database file for PS3.
        /// </summary>
        internal const string GamesDataPS3 = "https://db.arisen.studio/data/ps3/cheats/games.json";

        /// <summary>
        /// URL pointing to the Game Cheats database file for PS3.
        /// </summary>
        internal const string GamesCheatsBasePS3 = "https://db.arisen.studio/data/ps3/cheats/game-cheats/";

        /// <summary>
        /// URL pointing to the Game Cheats database file for PS3.
        /// </summary>
        internal const string GameCheatsZipPS3 = "https://db.arisen.studio/data/ps3/cheats/game-cheats.zip";

        /// <summary>
        /// URL pointing to the Homebrew database file for PS4.
        /// </summary>
        internal const string HomebrewDataPS4 = "https://db.arisen.studio/data/ps4/homebrew.json";

        /// <summary>
        /// URL pointing to the Game Mods database file for Xbox 360.
        /// </summary>
        internal const string GameModsDataXbox = "https://db.arisen.studio/data/xbox360/game-mods.json";

        /// <summary>
        /// URL pointing to the Homebrew database file for Xbox 360.
        /// </summary>
        internal const string HomebrewDataXbox = "https://db.arisen.studio/data/xbox360/homebrew.json";

        /// <summary>
        /// URL pointing to the Trainers database file for Xbox 360.
        /// </summary>
        internal const string TrainersDataXbox = "https://db.arisen.studio/data/xbox360/trainers.json";

        /// <summary>
        /// URL pointing to the Game Cheats database file for Xbox 360.
        /// </summary>
        internal const string GameCheatsDataXbox = "https://db.arisen.studio/data/xbox360/game-cheats.json";

        /// <summary>
        /// URL pointing to the Game Patches database file for Xbox 360.
        /// </summary>
        internal const string GamePatchesDataXbox = "https://db.arisen.studio/data/xbox360/game-patches.zip";

        /// <summary>
        /// URL pointing to the list of Title IDs database file for Xbox 360.
        /// </summary>
        internal const string GameTitleIdsXbox = "https://db.arisen.studio/data/xbox360/titleids.json";

        /// <summary>
        /// URL pointing to the submit mods form.
        /// </summary>
        internal const string FormReportIssue = "https://form.jotform.com/OhhSoWzrd/arisen-studio-report-issue";

        /// <summary>
        /// URL pointing to the submit mods form.
        /// </summary>
        internal const string FormSubmitMods = "https://form.jotform.com/OhhSoWzrd/arisen-studio-submit-mods";

        /// <summary>
        /// Generate an issue form with the pre-populated exception error details.
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static string GenerateIssueFormUrl(Exception exception, bool externalBrowser)
        {
            string title = HttpUtility.UrlEncode("Exception: " + exception.Message);
            string description = externalBrowser ?
                HttpUtility.UrlEncode(
                "Version: " + UpdateExtensions.CurrentVersionName + Environment.NewLine +
                "Exception: " + Environment.NewLine + exception.ToString())
                :
                "Version: " + UpdateExtensions.CurrentVersionName + Environment.NewLine +
                "Exception: " + Environment.NewLine + exception.ToString();

            return FormReportIssue +
                "?title=" + title.Substring(0, 60) +
                "&description=" + description;
        }

        //public static string GenerateIssueFormUrl(Exception exception)
        //{
        //    return FormReportIssue +
        //        "?title=" + "error%20message" +
        //        "&description=" + "exception%20details";
        //}

        /// <summary>
        /// Generate an issue form with the pre-populated details.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="logFile"></param>
        /// <returns></returns>
        public static string GenerateIssueFormUrl(string title, string description, string logFile)
        {
            return FormReportIssue +
                "?title=" + title +
                "&description=" + description;
        }
    }
}