using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Forms;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Models.Database
{
    public partial class CategoriesData
    {
        public List<Category> Categories { get; set; }

        public partial class Category
        {
            public string Id { get; set; }

            public string Title { get; set; }

            public string Type { get; set; }

            public string[] Regions { get; set; }

            public CategoryType GetCategoryType()
            {
                if (Type.Equals("game"))
                {
                    return CategoryType.Game;
                }
                else if (Type.Equals("resource"))
                {
                    return CategoryType.Resource;
                }
                else if (Type.Equals("favorite"))
                {
                    return CategoryType.Favorite;
                }
                else
                {
                    return CategoryType.Game;
                }
            }

            /// <summary>
            ///     Returns the users game region, either automatically set region by searching existing console directories or prompt
            ///     the user to select one
            /// </summary>
            /// <param name="hostAddress">Console ip address</param>
            /// <returns></returns>
            public string GetGameRegion(string hostAddress)
            {
                if (MainForm.SettingsData.AutoDetectGameRegion)
                {
                    List<string> detectedRegions = new List<string>();

                    using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
                    {
                        foreach (string region in Regions)
                        {
                            if (ftpConnection.DirectoryExists($"/dev_hdd0/game/{region}"))
                            {
                                detectedRegions.Add(region);
                            }
                        }
                    }

                    foreach (string region in detectedRegions)
                    {
                        if (DarkMessageBox.Show(MainForm.mainForm, string.Format("We have detected your region for '{0}' is {1} - Is this correct?", Title, region), "Detected Game Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            return region;
                        }
                    }

                    DarkMessageBox.Show(MainForm.mainForm, "Could not find any regions on your console for this game title. Make sure you have installed the game update on your console.", "No Region Detected", MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    using (ListViewDialog listViewDialog = new ListViewDialog() { Text = "Game Regions", Items = Regions.ToList() })
                    {
                        listViewDialog.ShowDialog();
                        return listViewDialog.SelectedItem;
                    }
                }
            }

            /// <summary>
            ///     Returns the users game region, either automatically set region by searching existing console directories or prompt
            ///     the user to select one
            /// </summary>
            /// <param name="hostAddress">Console ip address</param>
            /// <returns></returns>
            public string GetUserId(string hostAddress)
            {
                List<string> userIds = FtpExtensions.GetFolderNames(hostAddress, "/dev_hdd0/home/");

                if (userIds.Count < 1)
                {
                    DarkMessageBox.Show(MainForm.mainForm, "Could not find any userId's on your console. Make sure you have created at least one user profile.", "No UserId's Detected", MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    using (ListViewDialog listViewDialog = new ListViewDialog() { Text = "Profile User IDs", Items = userIds })
                    {
                        listViewDialog.ShowDialog();
                        return listViewDialog.SelectedItem;
                    }
                }
            }
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="id">Title of the game</param>
        /// <returns>Game information</returns>
        public Category GetCategoryById(string id)
        {
            foreach (Category game in from Category game in Categories
                                      where game.Id.ToLower().Equals(id.ToLower())
                                      select game)
            {
                return game;
            }

            throw new Exception("Unable to find game data for the specified game id");
        }

        /// <summary>
        ///     Get the game data matching the specified title
        /// </summary>
        /// <param name="title">Title of the game</param>
        /// <returns>Game information</returns>
        public Category GetCategoryByTitle(string title)
        {
            foreach (Category game in from Category game in Categories
                                      where game.Title.ToLower().Equals(title.ToLower())
                                      select game)
            {
                return game;
            }

            throw new Exception("Unable to find game data for the specified game id");
        }

        /// <summary>
        /// Gets the total number of games, these are defined by having regions
        /// </summary>
        /// <returns></returns>
        public int TotalGames => (from Category category in Categories
                                  where category.Regions.Length > 0
                                  select category).Count();
    }

    public enum CategoryType
    {
        Game,
        Resource,
        Favorite
    }
}