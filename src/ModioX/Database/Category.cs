using DarkUI.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
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
                string gameRegion = MainWindow.Settings.GetGameRegion(gameId);

                if (!string.IsNullOrEmpty(gameRegion))
                {
                    return gameRegion;
                }
            }

            if (MainWindow.Settings.AutoDetectGameRegions)
            {
                System.Collections.Generic.List<string> foundRegions = Regions.Where(region => MainWindow.FtpConnection.DirectoryExists($"/dev_hdd0/game/{region}")).ToList();

                foreach (string region in foundRegions.Where(region => XtraMessageBox.Show(
                    $"Game Region: {region} has been found for: {Title}\nIs this correct?", "Found Game Region",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    return region;
                }

                DarkMessageBox.ShowError(
                    "Could not find any regions on your console for this game title. You must install the game update for this title first.",
                    "No Game Update");
                return null;
            }

            return DialogExtensions.ShowListInputDialog("Game Regions", Regions.ToList());
        }
    }
}