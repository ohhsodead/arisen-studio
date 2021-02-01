using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ModioX.Forms.Settings
{
    public partial class SavedGameRegions : XtraForm
    {
        public SavedGameRegions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static DropboxData Database { get; } = MainWindow.Database;

        private void EditGameRegions_Load(object sender, EventArgs e)
        {
            ComboBoxGameTitle.Properties.Items.Clear();
            ComboBoxGameRegion.Properties.Items.Clear();

            foreach (var category in Database.CategoriesData.GetCategoriesByType(CategoryType.Game))
            {
                ComboBoxGameTitle.Properties.Items.Add(category.Title);
            }

            LoadSavedGameRegions();
        }

        public void LoadSavedGameRegions()
        {
            GridGameRegions.DataSource = null;

            var gameRegions = DataExtensions.CreateDataTable(new List<DataColumn> { new DataColumn("Game Title", typeof(string)), new DataColumn("Game Region", typeof(string)) });

            foreach (var gameRegion in Settings.GameRegions)
            {
                gameRegions.Rows.Add(Database.CategoriesData.GetCategoryById(gameRegion.GameId).Title, gameRegion.Region);
            }

            GridGameRegions.DataSource = gameRegions;

            GridViewGameRegions.Columns[0].Width = 400;
            GridViewGameRegions.Columns[1].Width = 125;

            if (GridViewGameRegions.RowCount > 0)
            {
                GridViewGameRegions.SelectRow(0);
            }

            ProgressLoading.Visible = GridViewGameRegions.RowCount < 1;

            ButtonDelete.Enabled = GridViewGameRegions.SelectedRowsCount > 0;
            ButtonDeleteAll.Enabled = GridViewGameRegions.RowCount > 0;
        }

        private void GridViewGameRegions_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewGameRegions.SelectedRowsCount > 0)
            {
                var gameTitle = GridViewGameRegions.GetRowCellValue(e.FocusedRowHandle, "Game Title").ToString();
                var gameRegion = GridViewGameRegions.GetRowCellValue(e.FocusedRowHandle, "Game Region").ToString();

                ComboBoxGameTitle.SelectedItem = gameTitle;
                ComboBoxGameRegion.SelectedItem = gameRegion;
            }

            ButtonDelete.Enabled = GridViewGameRegions.SelectedRowsCount > 0;
        }

        private void GridViewGameRegions_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewGameRegions.SelectedRowsCount > 0)
            {
                var gameTitle = GridViewGameRegions.GetRowCellValue(e.RowHandle, "Game Title").ToString();
                var gameRegion = GridViewGameRegions.GetRowCellValue(e.RowHandle, "Game Region").ToString();

                ComboBoxGameTitle.SelectedItem = gameTitle;
                ComboBoxGameRegion.SelectedItem = gameRegion;
            }

            ButtonDelete.Enabled = GridViewGameRegions.SelectedRowsCount > 0;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected saved game region?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.GameRegions.RemoveAt(GridViewGameRegions.FocusedRowHandle);
                LoadSavedGameRegions();
                XtraMessageBox.Show("Saved game region has now been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete all of your saved game regions?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.GameRegions.Clear();
                LoadSavedGameRegions();
                XtraMessageBox.Show("All saved game regions have now been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex != -1)
            {
                ComboBoxGameRegion.Properties.Items.Clear();

                var gameTitle = ComboBoxGameTitle.SelectedItem.ToString();
                var gameId = Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

                foreach (var gameRegion in Database.CategoriesData.GetCategoryById(gameId).Regions)
                {
                    ComboBoxGameRegion.Properties.Items.Add(gameRegion);
                }
            }

            ComboBoxGameRegion.Enabled = ComboBoxGameTitle.SelectedIndex != -1;
        }

        private void ButtonAddGameRegion_Click(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex == -1)
            {
                XtraMessageBox.Show("You must first specify a game title.", "No Game Title");
                return;
            }

            if (ComboBoxGameRegion.SelectedIndex == -1)
            {
                XtraMessageBox.Show("You must specify a game region for this game title.", "No Game Region");
                return;
            }

            var gameTitle = ComboBoxGameTitle.SelectedItem.ToString();
            var gameRegion = ComboBoxGameRegion.SelectedItem.ToString();

            var gameId = Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

            Settings.UpdateGameRegion(gameId, gameRegion);
            LoadSavedGameRegions();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < GridViewGameRegions.RowCount; i++)
            {
                var gameTitle = GridViewGameRegions.GetRowCellValue(i, "Game Title").ToString();
                var gameRegion = GridViewGameRegions.GetRowCellValue(i, "Game Region").ToString();

                var gameId = Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

                if (Database.CategoriesData.GetCategoryById(gameId).Regions.ToList().Contains(gameRegion))
                {
                    Settings.UpdateGameRegion(gameId, gameRegion);
                }
                else
                {
                    XtraMessageBox.Show($"Game Region: {gameRegion} is not supported for Game Title: {gameTitle}\n\nPlease change the it to one that is supported for this game title.", "Invalid Region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            XtraMessageBox.Show("All game regions have now been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}