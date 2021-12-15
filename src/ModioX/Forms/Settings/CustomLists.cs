using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Humanizer;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;

namespace ModioX.Forms.Settings
{
    public partial class CustomLists : XtraForm
    {
        public CustomLists()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the user's current settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get the current selected console type.
        /// </summary>
        public PlatformPrefix ConsoleType { get; set; }

        private void CustomListsDialog_Load(object sender, EventArgs e)
        {
            GroupCustomLists.Text += $" ({ConsoleType.Humanize()})";
            LoadCustomLists();
        }

        public void LoadCustomLists()
        {
            GridCustomLists.DataSource = null;

            DataTable dataTable = DataExtensions.CreateDataTable(new List<DataColumn>
            {
                new("List Name", typeof(string)),
                new("# of Mods", typeof(string))
            });

            foreach (CustomList customList in Settings.CustomLists.FindAll(x => x.Platform == ConsoleType))
            {
                dataTable.Rows.Add(customList.Name, customList.ModIds.Count + " Mods");
            }

            GridCustomLists.DataSource = dataTable;

            GridViewCustomLists.Columns[0].Width = 200;
            GridViewCustomLists.Columns[1].Width = 50;

            ButtonDeleteAllLists.Enabled = GridViewCustomLists.RowCount > 0;

            switch (GridViewCustomLists.RowCount)
            {
                case > 0:
                    GridViewCustomLists.SelectRow(0);
                    break;
            }

            ButtonRenameList.Enabled = GridViewCustomLists.SelectedRowsCount > 0;
            ButtonDeleteList.Enabled = GridViewCustomLists.SelectedRowsCount > 0;
        }

        private void GridCustomLists_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            ButtonRenameList.Enabled = GridViewCustomLists.SelectedRowsCount > 0;
            ButtonDeleteList.Enabled = GridViewCustomLists.SelectedRowsCount > 0;
        }

        private void ButtonCreateNewList_Click(object sender, EventArgs e)
        {
            string listName = DialogExtensions.ShowTextInputDialog(this, "Create New List", "List Name:");

            switch (string.IsNullOrWhiteSpace(listName))
            {
                case false when CustomListNameExists(listName):
                    XtraMessageBox.Show("A list with this name already exists.", "List Name Exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case false when MainWindow.Database.CategoriesData.Categories.Exists(x => x.Title.EqualsIgnoreCase(listName)):
                    XtraMessageBox.Show("A list name can't be the same as a category title.", "Category Exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case false:
                    Settings.AddCustomList(listName, ConsoleType);
                    LoadCustomLists();
                    break;
            }
        }

        private void ButtonRenameList_Click(object sender, EventArgs e)
        {
            string currentListName =
                GridViewCustomLists.GetRowCellDisplayText(GridViewCustomLists.FocusedRowHandle, "List Name");
            string newListName = DialogExtensions.ShowTextInputDialog(this, "Rename List", "List Name:", currentListName);

            switch (string.IsNullOrWhiteSpace(newListName))
            {
                case false when currentListName != newListName && CustomListNameExists(newListName):
                    XtraMessageBox.Show("A list with this name already exists.", "List Name Exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case false when MainWindow.Database.CategoriesData.Categories.Exists(x => x.Title.EqualsIgnoreCase(newListName)):
                    XtraMessageBox.Show("A list name can't be the same as a category title.", "Category Exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case false:
                    Settings.RenameCustomList(currentListName, newListName, ConsoleType);
                    LoadCustomLists();
                    break;
            }
        }

        private void ButtonDeleteList_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected list? This can't be undone.", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Settings.CustomLists.RemoveAt(GridViewCustomLists.FocusedRowHandle);
                LoadCustomLists();
            }
        }

        private void ButtonDeleteAllLists_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really to delete all of your created lists? This can't be undone.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Settings.CustomLists.Clear();
                LoadCustomLists();
            }
        }

        private static bool CustomListNameExists(string name)
        {
            foreach (CustomList customList in Settings.CustomLists)
            {
                if (customList.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}