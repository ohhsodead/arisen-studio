using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArisenStudio.Models.Database
{
    public class CategoryItem
    {
        public string Id { get; set; }
        
        public string Title { get; set; }
        
        public string Type { get; set; }

        public string[] Regions { get; set; }

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
        public async Task<string> GetGameRegionAsync(Form owner, string gameId)
        {
            // Check if we should return a remembered game region from the settings
            if (MainWindow.Settings.RememberGameRegions)
            {
                string gameRegion = MainWindow.Settings.GetGameRegion(gameId);

                if (!string.IsNullOrEmpty(gameRegion))
                {
                    return gameRegion;
                }
            }

            // Auto-detect the game region if the setting is enabled
            if (MainWindow.Settings.AutoDetectGameRegions)
            {
                List<string> foundRegions = new List<string>();

                // Create tasks for each region and check if the directory exists asynchronously
                var regionTasks = Regions.Select(async region =>
                {
                    bool exists = await FtpExtensions.DirectoryExistsAsync($"/dev_hdd0/game/{region}");
                    return new { region, exists };
                }).ToList();

                // Await all the tasks and collect the results
                var results = await Task.WhenAll(regionTasks);

                // Filter the regions that exist
                foundRegions = results.Where(r => r.exists).Select(r => r.region).ToList();

                // Ask user for confirmation for each region found
                foreach (string region in foundRegions)
                {
                    var result = XtraMessageBox.Show(owner,
                        $"Game Region: {region} has been found for: {Title}\n\nIs this correct?",
                        "Game Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        return region;
                    }
                }

                // If no regions were found or confirmed by the user
                _ = XtraMessageBox.Show(owner,
                    "Could not find any regions on your console for this game title. You must install the game update for this title first.",
                    "No Game Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return null;
            }
            else
            {
                // If AutoDetectGameRegions is false, show a manual selection dialog
                ListItem selectedItem = DialogExtensions.ShowListViewDialog(owner,
                    "Game Regions",
                    Regions.ToList().ConvertAll(x => new ListItem { Value = x, Name = x }));

                return selectedItem?.Value;
            }
        }
    }
}