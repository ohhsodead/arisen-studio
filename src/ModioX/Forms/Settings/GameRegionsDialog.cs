using DarkUI.Forms;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class GameRegionsDialog : DarkForm
    {
        public GameRegionsDialog()
        {
            InitializeComponent();
        }

        private void EditGameRegions_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            DgvGameRegions.Rows.Clear();
            ComboBoxGameTitle.Items.Clear();
            ComboBoxGameRegion.Items.Clear();

            foreach (GameRegion gameRegion in MainWindow.SettingsData.GameRegions)
            {
                _ = DgvGameRegions.Rows.Add(MainWindow.Database.Categories.GetCategoryById(gameRegion.GameId).Title, gameRegion.Region);
            }

            LabelTotalGameRegions.Text = $"{DgvGameRegions.Rows.Count} Regions Saved";

            LabelNoGameRegionsSaved.Visible = DgvGameRegions.Rows.Count < 1;
            ToolItemDeleteAll.Enabled = DgvGameRegions.Rows.Count > 0;

            foreach (CategoriesData.Category category in MainWindow.Database.Categories.GetCategoriesByType(CategoryType.Game))
            {
                _ = ComboBoxGameTitle.Items.Add(category.Title);
            }

            DgvGameRegions.Sort(DgvGameRegions.Columns[0], ListSortDirection.Ascending);

            if (DgvGameRegions.Rows.Count > 0)
            {
                DgvGameRegions.CurrentCell = DgvGameRegions[0, 0];
            }
        }

        private void DgvGameRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvGameRegions.SelectedRows.Count > 0)
            {
                string gameTitle = DgvGameRegions.SelectedRows[0].Cells[0].Value.ToString();
                string gameRegion = DgvGameRegions.SelectedRows[0].Cells[1].Value.ToString();

                ComboBoxGameTitle.SelectedItem = gameTitle;
                ComboBoxGameRegion.SelectedItem = gameRegion;
            }
        }

        private void ToolItemDeleteAll_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, $"Do you really want delete of all your saved game regions? This cannot be undone.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainWindow.SettingsData.GameRegions.Clear();
            }
        }

        private void ComboBoxGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxGameRegion.Enabled = ComboBoxGameTitle.SelectedIndex != -1;

            if (ComboBoxGameTitle.SelectedIndex != -1)
            {
                ComboBoxGameRegion.Items.Clear();

                string gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
                string gameId = MainWindow.Database.Categories.GetCategoryByTitle(gameTitle).Id;

                ComboBoxGameRegion.Items.AddRange(MainWindow.Database.Categories.GetGameRegions(gameId).ToArray());
            }
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex == -1)
            {
                _ = DarkMessageBox.Show(this, $"You must first specify a game title.", "No Game Title", MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxGameRegion.SelectedIndex == -1)
            {
                _ = DarkMessageBox.Show(this, $"You must specify a game region to be added to the game.", "No Game Region", MessageBoxIcon.Exclamation);
                return;
            }

            string gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
            string gameRegion = ComboBoxGameRegion.GetItemText(ComboBoxGameRegion.SelectedItem);

            string gameId = MainWindow.Database.Categories.GetCategoryByTitle(gameTitle).Id;

            MainWindow.SettingsData.UpdateGameRegion(gameId, gameRegion);
            UpdateUI();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;

            foreach (DataGridViewRow row in DgvGameRegions.Rows)
            {
                string gameTitle = row.Cells[0].Value.ToString();
                string gameRegion = row.Cells[1].Value.ToString();

                string gameId = MainWindow.Database.Categories.GetCategoryByTitle(gameTitle).Id;

                if (MainWindow.Database.Categories.GetGameRegions(gameId).Contains(gameRegion))
                {
                    MainWindow.SettingsData.UpdateGameRegion(gameId, gameRegion);
                }
                else
                {
                    _ = DarkMessageBox.Show(this, $"Region: {gameRegion} is not supported for game: {gameTitle}\nPlease change the region to one that is supported.", "Invalid Region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isSuccess = false;
                    break;
                }
            }

            if (isSuccess)
            {
                _ = DarkMessageBox.Show(this, $"All game regions have now been saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}