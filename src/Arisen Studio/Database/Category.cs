using DevExpress.XtraEditors;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System.Linq;
using System.Windows.Forms;

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
            "plugin" => CategoryType.Plugin,
            _ => CategoryType.Game
        };

        /// <summary>
        /// Return the user's game region, either automatically by searching existing console
        /// directories or prompt the user to select one.
        /// </summary>
        /// <param name="gameId"> Game Id </param>
        /// <returns> </returns>
        public string GetGameRegion(Form owner, string gameId)
        {
            switch (MainWindow.Settings.RememberGameRegions)
            {
                case true:
                    {
                        string gameRegion = MainWindow.Settings.GetGameRegion(gameId);

                        switch (string.IsNullOrEmpty(gameRegion))
                        {
                            case false:
                                return gameRegion;
                        }
                        break;
                    }
            }

            switch (MainWindow.Settings.AutoDetectGameRegions)
            {
                case true:
                    {
                        System.Collections.Generic.List<string> foundRegions = Regions.Where(region => FtpExtensions.DirectoryExists($"/dev_hdd0/game/{region}")).ToList();

                        foreach (string region in foundRegions.Where(region => XtraMessageBox.Show($"Game Region: {region} has been found for: {Title}\n\nIs this correct?", "Game Region",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            return region;
                        }

                        XtraMessageBox.Show(
                            MainWindow.Window.LookAndFeel,
                            "Could not find any regions on your console for this game title. You must install the game update for this title first.",
                            "No Game Update", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return null;
                    }
                default:
                    ListItem selectedItem = DialogExtensions.ShowListViewDialog(owner, "Game Regions", Regions.ToList().ConvertAll(x => new ListItem { Value = x, Name = x }));
                    return selectedItem?.Value;

                    //return DialogExtensions.ShowListItemDialog(owner, Title, "Game Region:", Regions);
            }
        }
    }
}