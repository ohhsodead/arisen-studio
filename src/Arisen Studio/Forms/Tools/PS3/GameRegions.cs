﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Data;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ArisenStudio.Models.Database;

namespace ArisenStudio.Forms.Tools.PS3
{
    public partial class GameRegions : XtraForm
    {
        public GameRegions()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        public static DatabaseClient Database = MainWindow.Database;

        private void GameRegions_Load(object sender, EventArgs e)
        {
            ButtonDetectRegions.Enabled = MainWindow.IsConsoleConnected;

            ComboBoxGameTitle.Properties.Items.Clear();
            ComboBoxGameRegion.Properties.Items.Clear();

            foreach (CategoryItem category in Database.CategoriesData.GetCategoriesByType(CategoryType.Game))
            {
                _ = ComboBoxGameTitle.Properties.Items.Add(category.Title);
            }

            LoadSavedGameRegions();
        }

        public void LoadSavedGameRegions()
        {
            GridGameRegions.DataSource = null;

            using (DataTable gameRegions = DataExtensions.CreateDataTable(
            [
                new("Game Title", typeof(string)),
                new("Game Region", typeof(string))
            ]))
            {
                foreach (GameRegion gameRegion in Settings.GameRegionsPs3)
                {
                    _ = gameRegions.Rows.Add(Database.CategoriesData.GetCategoryById(gameRegion.GameId).Title,
                        gameRegion.Region);
                }

                GridGameRegions.DataSource = gameRegions;
            }

            GridViewGameRegions.Columns[0].Width = 400;
            GridViewGameRegions.Columns[1].Width = 125;

            switch (GridViewGameRegions.RowCount)
            {
                case > 0:
                    GridViewGameRegions.SelectRow(0);
                    break;
            }

            ButtonDelete.Enabled = GridViewGameRegions.SelectedRowsCount > 0;
            ButtonDeleteAll.Enabled = GridViewGameRegions.RowCount > 0;
        }

        private void GridViewGameRegions_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewGameRegions.SelectedRowsCount)
            {
                case > 0:
                    {
                        string gameTitle = GridViewGameRegions.GetRowCellValue(e.FocusedRowHandle, "Game Title").ToString();
                        string gameRegion = GridViewGameRegions.GetRowCellValue(e.FocusedRowHandle, "Game Region").ToString();

                        ComboBoxGameTitle.SelectedItem = gameTitle;
                        ComboBoxGameRegion.SelectedItem = gameRegion;
                        break;
                    }
            }

            ButtonDelete.Enabled = GridViewGameRegions.SelectedRowsCount > 0;
        }

        private void GridViewGameRegions_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewGameRegions.SelectedRowsCount)
            {
                case > 0:
                    {
                        string gameTitle = GridViewGameRegions.GetRowCellValue(e.RowHandle, "Game Title").ToString();
                        string gameRegion = GridViewGameRegions.GetRowCellValue(e.RowHandle, "Game Region").ToString();

                        ComboBoxGameTitle.SelectedItem = gameTitle;
                        ComboBoxGameRegion.SelectedItem = gameRegion;
                        break;
                    }
            }

            ButtonDelete.Enabled = GridViewGameRegions.SelectedRowsCount > 0;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected saved game region?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.GameRegionsPs3.RemoveAt(GridViewGameRegions.FocusedRowHandle);
                LoadSavedGameRegions();
                _ = XtraMessageBox.Show("Saved game region has now been deleted.", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete all of your saved game regions?", Language.GetString("CONFIRM"),
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.GameRegionsPs3.Clear();
                LoadSavedGameRegions();
                _ = XtraMessageBox.Show("All saved game regions have now been deleted.", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxGameTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameTitle.SelectedIndex != -1)
            {
                ComboBoxGameRegion.Properties.Items.Clear();

                string gameTitle = ComboBoxGameTitle.SelectedItem.ToString();
                string gameId = Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

                foreach (string gameRegion in Database.CategoriesData.GetCategoryById(gameId).Regions)
                {
                    _ = ComboBoxGameRegion.Properties.Items.Add(gameRegion);
                }
            }

            ComboBoxGameRegion.Enabled = ComboBoxGameTitle.SelectedIndex != -1;
        }

        private void ButtonAddGameRegion_Click(object sender, EventArgs e)
        {
            switch (ComboBoxGameTitle.SelectedIndex)
            {
                case -1:
                    _ = XtraMessageBox.Show("You must first specify a game title.", "No Game Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            switch (ComboBoxGameRegion.SelectedIndex)
            {
                case -1:
                    _ = XtraMessageBox.Show("You must specify a game region for this game title.", "No Game Region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            string gameTitle = ComboBoxGameTitle.SelectedItem.ToString();
            string gameRegion = ComboBoxGameRegion.SelectedItem.ToString();

            string gameId = Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

            Settings.UpdateGameRegion(gameId, gameRegion);
            LoadSavedGameRegions();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridViewGameRegions.RowCount; i++)
            {
                string gameTitle = GridViewGameRegions.GetRowCellValue(i, "Game Title").ToString();
                string gameRegion = GridViewGameRegions.GetRowCellValue(i, "Game Region").ToString();

                string gameId = Database.CategoriesData.GetCategoryByTitle(gameTitle).Id;

                if (Database.CategoriesData.GetCategoryById(gameId).Regions.ToList().Contains(gameRegion))
                {
                    Settings.UpdateGameRegion(gameId, gameRegion);
                }
                else
                {
                    _ = XtraMessageBox.Show(
                        $"Game Region: {gameRegion} is not supported for Game Title: {gameTitle}\n\nPlease change it to one that's supported for this game.",
                        "Invalid Region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            _ = XtraMessageBox.Show("All game regions have now been saved.", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private async void ButtonDetectRegions_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("All saved game regions will be cleared. Do you want to continue?", "Game Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (CategoryItem category in Database.CategoriesData.Categories.Where(x => x.CategoryType == CategoryType.Game))
                {
                    foreach (string region in category.Regions)
                    {
                        if (await FtpExtensions.DirectoryExistsAsync($"/dev_hdd0/game/{region}"))
                        {
                            Settings.UpdateGameRegion(category.Id, region);
                        }
                    }
                }

                LoadSavedGameRegions();
            }
        }

        private void ComboBoxGameRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}