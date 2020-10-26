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

            foreach (var category in MainWindow.Database.Categories.GetCategoriesByType(CategoryType.Game))
            {
                _ = ComboBoxGameTitle.Items.Add(category.Title);
            }

            DgvGameRegions.Sort(DgvGameRegions.Columns[0], ListSortDirection.Ascending);

            if (DgvGameRegions.Rows.Count > 0)
            {
                DgvGameRegions.CurrentCell = DgvGameRegions[0, 0];
            }

            LoadSavedRegions();
        }

        public void LoadSavedRegions()
        {
            DgvGameRegions.Rows.Clear();            

            foreach (var gameRegion in MainWindow.Settings.GameRegions)
            {
                _ = DgvGameRegions.Rows.Add(MainWindow.Database.Categories.GetCategoryById(gameRegion.GameId).Title, gameRegion.Region);
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

        private void ToolStripDeleteAll_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this,
                    "Do you really want delete of all your saved game regions?", "Delete All",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.Settings.GameRegions.Clear();
                LoadSavedRegions();
            }
        }

        private void ToolStripDeleteSelected_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this,
                    "Do you really want delete the selected saved game regions?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.Settings.GameRegions.RemoveAt(DgvGameRegions.CurrentRow.Index);
                LoadSavedRegions();
            }
        }

        private void ComboBoxGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex != -1)
            {
                ComboBoxGameRegion.Items.Clear();

                var gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
                var gameId = MainWindow.Database.Categories.GetCategoryByTitle(gameTitle).Id;

                foreach (var gameRegion in MainWindow.Database.Categories.GetGameRegions(gameId))
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
                _ = DarkMessageBox.Show(this, "You must first specify a game title.", "No Game Title",
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxGameRegion.SelectedIndex == -1)
            {
                _ = DarkMessageBox.Show(this, "You must specify a game region.", "No Game Region",
                    MessageBoxIcon.Exclamation);
                return;
            }

            var gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
            var gameRegion = ComboBoxGameRegion.GetItemText(ComboBoxGameRegion.SelectedItem);

            var gameId = MainWindow.Database.Categories.GetCategoryByTitle(gameTitle).Id;

            DgvGameRegions.Rows.Add(gameTitle, gameRegion);
            MainWindow.Settings.UpdateGameRegion(gameId, gameRegion);
            LoadSavedRegions();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvGameRegions.Rows)
            {
                var gameTitle = row.Cells[0].Value.ToString();
                var gameRegion = row.Cells[1].Value.ToString();

                var gameId = MainWindow.Database.Categories.GetCategoryByTitle(gameTitle).Id;

                if (MainWindow.Database.Categories.GetGameRegions(gameId).Contains(gameRegion))
                {
                    MainWindow.Settings.UpdateGameRegion(gameId, gameRegion);
                }
                else
                {
                    _ = DarkMessageBox.Show(this,
                        $"Region: {gameRegion} is not supported for Game: {gameTitle}\nPlease change the region to one that is supported for this game.", "Invalid Region",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            _ = DarkMessageBox.Show(this, "All game regions have now been saved.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}