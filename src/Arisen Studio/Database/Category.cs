using DevExpress.XtraEditors;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ArisenStudio.Database
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
        public CategoryType CategoryType => Type switch
        {
            "game" => CategoryType.Game,
            "homebrew" => CategoryType.Homebrew,
            "resource" => CategoryType.Resource,
            "package" => CategoryType.Package,
            _ => CategoryType.Game
        };

        /// <summary>
        /// Return the user's game region, either automatically by searching existing console
        /// directories or prompt the user to select one.
        /// </summary>
        /// <param name="owner"> Parent Form for Dialogs </param>
        /// <param name="gameId"> Game Id </param>
        /// <returns> </returns>
        public string GetGameRegion(Form owner, string gameId)
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
                List<string> foundRegions = Regions.Where(region => FtpExtensions.DirectoryExists($"/dev_hdd0/game/{region}")).ToList();

                foreach (string region in foundRegions.Where(region => XtraMessageBox.Show(owner, $"Game Region: {region} has been found for: {Title}\n\nIs this correct?", "Game Region",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    return region;
                }

                XtraMessageBox.Show(owner,
                    "Could not find any regions on your console for this game title. You must install the game update for this title first.", "No Game Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return null;
            }
            else
            {
                ListItem selectedItem = DialogExtensions.ShowListViewDialog(owner, "Game Regions", Regions.ToList().ConvertAll(x => new ListItem { Value = x, Name = x }));
                return selectedItem?.Value;
            }
        }
    }
}