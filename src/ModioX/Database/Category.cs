using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Models.Database
{
    /// <summary>
    /// Get the category information.
    /// </summary>
    public class Category
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string[] Regions { get; set; }

        /// <summary>
        /// Get the category type.
        /// </summary>
        public CategoryType CategoryType
        {
            get
            {
                return Type switch
                {
                    "game" => CategoryType.Game,
                    "homebrew" => CategoryType.Homebrew,
                    "resource" => CategoryType.Resource,
                    "favorite" => CategoryType.Favorite,
                    _ => CategoryType.Game,
                };
            }
        }

        /// <summary>
        /// Return the user's game region, either automatically by searching existing console directories or prompt
        /// the user to select one.
        /// </summary>
        /// <param name="owner">Parent form</param>
        /// <param name="gameId">Game Id</param>
        /// <returns></returns>
        public string GetGameRegion(string gameId)
        {
            if (MainWindow.Settings.RememberGameRegions)
            {
                var gameRegion = MainWindow.Settings.GetGameRegion(gameId);

                if (!string.IsNullOrEmpty(gameRegion))
                {
                    return gameRegion;
                }
            }

            if (MainWindow.Settings.AutoDetectGameRegions)
            {
                var foundRegions = Regions.Where(region => MainWindow.FtpConnection.DirectoryExists($"/dev_hdd0/game/{region}")).ToList();

                foreach (var region in foundRegions.Where(region => DarkMessageBox.ShowQuestion(
                    $"Game Region: {region} has been found for: {Title}\nIs this correct?", "Found Game Region",
                    DarkDialogButton.YesNo) == DialogResult.Yes))
                {
                    return region;
                }

                _ = DarkMessageBox.ShowError(
                    "Could not find any regions on your console for this game title. You must install the game update for this title first.",
                    "No Game Update");
                return null;
            }

            return DialogExtensions.ShowListInputDialog("Game Regions", Regions.ToList());
        }
    }
}