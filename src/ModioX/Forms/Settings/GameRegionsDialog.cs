using System;
using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Forms;
using ModioX.Forms.Windows;
using ModioX.Models.Database;

namespace ModioX.Forms.Settings
{
    public partial class GameRegionsDialog : DarkForm
    {
        public GameRegionsDialog()
        {
            InitializeComponent();
        }

        private void EditGameRegions_Load(object sender, EventArgs e)
        {
            ComboBoxGameTitle.Items.Clear();
            ComboBoxGameRegion.Items.Clear();

            foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Game))
            {
                _ = ComboBoxGameTitle.Items.Add(category.Title);
            }

            LoadSavedGameRegions();
        }

        public void LoadSavedGameRegions()
        {
            DgvGameRegions.Rows.Clear();

            foreach (var gameRegion in MainWindow.Settings.GameRegions)
            {
                _ = DgvGameRegions.Rows.Add(MainWindow.Database.CategoriesData.GetCategoryById(gameRegion.GameId).Title, gameRegion.Region);
            }

            if (DgvGameRegions.Rows.Count > 0)
            {
                DgvGameRegions.CurrentCell = DgvGameRegions[0, 0];
            }

            LabelTotalGameRegions.Text = $@"{DgvGameRegions.Rows.Count} Regions Saved";

            LabelNoGameRegionsSaved.Visible = DgvGameRegions.Rows.Count < 1;
            ToolStripDeleteSelected.Enabled = DgvGameRegions.CurrentRow != null;
            ToolStripDeleteAll.Enabled = DgvGameRegions.Rows.Count > 0;
        }

        private void DgvGameRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvGameRegions.CurrentRow != null)
            {
                var gameTitle = DgvGameRegions.SelectedRows[0].Cells[0].Value.ToString();
                var gameRegion = DgvGameRegions.SelectedRows[0].Cells[1].Value.ToString();

                ComboBoxGameTitle.SelectedItem = gameTitle;
                ComboBoxGameRegion.SelectedItem = gameRegion;
            }

            ToolStripDeleteSelected.Enabled = DgvGameRegions.CurrentRow != null;
        }

        private void ToolStripDeleteSelected_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.ShowWarning("Do you really want to delete the selected saved game region?", "Delete", DarkDialogButton.YesNo) == DialogResult.Yes)
            {
                MainWindow.Settings.GameRegions.RemoveAt(DgvGameRegions.CurrentRow.Index);
                LoadSavedGameRegions();
            }
        }

        private void ToolStripDeleteAll_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.ShowWarning("Do you really want to delete all of your saved game regions?", "Delete All", DarkDialogButton.YesNo) == DialogResult.Yes)
            {
                MainWindow.Settings.GameRegions.Clear();
                LoadSavedGameRegions();
            }
        }

        private void ComboBoxGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex != -1)
            {
                ComboBoxGameRegion.Items.Clear();

                var gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
                var gameId = MainWindow.Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

                foreach (var gameRegion in MainWindow.Database.CategoriesData.GetGameRegions(gameId))
                {
                    ComboBoxGameRegion.Items.Add(gameRegion);
                }
            }

            ComboBoxGameRegion.Enabled = ComboBoxGameTitle.SelectedIndex != -1;
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex == -1)
            {
                DarkMessageBox.ShowExclamation("You must first specify a game title.", "No Game Title");
                return;
            }

            if (ComboBoxGameRegion.SelectedIndex == -1)
            {
                DarkMessageBox.ShowExclamation( "You must specify a game region for this game.", "No Game Region");
                return;
            }

            var gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
            var gameRegion = ComboBoxGameRegion.GetItemText(ComboBoxGameRegion.SelectedItem);

            var gameId = MainWindow.Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

            MainWindow.Settings.UpdateGameRegion(gameId, gameRegion);
            LoadSavedGameRegions();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvGameRegions.Rows)
            {
                var gameTitle = row.Cells[0].Value.ToString();
                var gameRegion = row.Cells[1].Value.ToString();

                var gameId = MainWindow.Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

                if (MainWindow.Database.CategoriesData.GetGameRegions(gameId).Contains(gameRegion))
                {
                    MainWindow.Settings.UpdateGameRegion(gameId, gameRegion);
                }
                else
                {
                    _ = DarkMessageBox.ShowExclamation($"Region: {gameRegion} is not supported for Game: {gameTitle}\nPlease change the region to one that is supported for this game.", "Invalid Region");
                    return;
                }
            }

            _ = DarkMessageBox.ShowInformation("All game regions have now been saved.", "Saved");
            Close();
        }
    }
}