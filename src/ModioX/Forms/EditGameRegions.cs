using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class EditGameRegions : DarkForm
    {
        public EditGameRegions()
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

            foreach (GameRegion gameRegion in MainForm.SettingsData.GameRegions)
            {
                DgvGameRegions.Rows.Add(MainForm.Categories.GetCategoryById(gameRegion.GameId).Title, gameRegion.Region);
            }

            LabelTotalGameRegions.Text = $"{DgvGameRegions.Rows.Count} Saved Game Regions";

            LabelNoGameRegionsSaved.Visible = DgvGameRegions.Rows.Count < 1;
            ToolItemDeleteAll.Enabled = DgvGameRegions.Rows.Count > 0;

            foreach (var category in MainForm.Categories.Categories)
            {
                if (category.CategoryType == Models.Database.CategoryType.Game)
                {
                    ComboBoxGameTitle.Items.Add(category.Title);
                }
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
            if (DarkMessageBox.Show(this, $"Are you sure that you would like to delete of all the specified regions for games?", "Delete All Game Regions", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MainForm.SettingsData.GameRegions.Clear();
                _ = DarkMessageBox.Show(this, $"All specified regions for games have now been deleted.", "Deleted All Game Regions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }            
        }

        private void ComboBoxGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex != -1)
            {
                ComboBoxGameRegion.Items.Clear();

                string gameTitle = ComboBoxGameTitle.GetItemText(ComboBoxGameTitle.SelectedItem);
                string gameId = MainForm.Categories.GetCategoryByTitle(gameTitle).Id;

                ComboBoxGameRegion.Items.AddRange(MainForm.Categories.GetGameRegions(gameId).ToArray());
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

            string gameId = MainForm.Categories.GetCategoryByTitle(gameTitle).Id;

            MainForm.SettingsData.UpdateGameRegion(gameId, gameRegion);
            UpdateUI();
        }

        private void ButtonSaveGameRegions_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;

            foreach (DataGridViewRow row in DgvGameRegions.Rows)
            {
                string gameTitle = row.Cells[0].Value.ToString();
                string gameRegion = row.Cells[1].Value.ToString();

                string gameId = MainForm.Categories.GetCategoryByTitle(gameTitle).Id;

                if (MainForm.Categories.GetGameRegions(gameId).Contains(gameRegion))
                {
                    MainForm.SettingsData.UpdateGameRegion(gameId, gameRegion);
                }
                else
                {
                    _ = DarkMessageBox.Show(this, $"Game Region: {gameRegion} is not supported for: {gameTitle}\nPlease change the region to one that is supported by this game.", "Not Supported Game Region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isSuccess = false;
                    break;
                }
            }

            if (isSuccess)
            {
                _ = DarkMessageBox.Show(this, $"All game regions have now been saved.", "Saved Game Regions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}