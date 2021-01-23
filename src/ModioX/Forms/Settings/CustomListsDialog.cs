using DarkUI.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Data;
using System.Windows.Forms;

namespace ModioX.Forms.Settings
{
    public partial class CustomListsDialog : XtraForm
    {
        public CustomListsDialog()
        {
            InitializeComponent();
        }

        private void CustomListsDialog_Load(object sender, EventArgs e)
        {
            LoadCustomLists();
        }

        public void LoadCustomLists()
        {
            GridCustomLists.DataSource = null;

            var dt = new DataTable();
            dt.Columns.Add("List Name", typeof(string));
            dt.Columns.Add("# of Mods", typeof(string));

            foreach (CustomList customList in MainWindow.Settings.CustomLists)
            {
                dt.Rows.Add(customList.Name, customList.ModIds.Count + " Mods");
            }

            GridCustomLists.DataSource = dt;

            GridViewCustomLists.Columns[1].Width = 200;
            GridViewCustomLists.Columns[2].Width = 50;

            ProgressCustomLists.Visible = GridViewCustomLists.RowCount < 1;

            ButtonDeleteAllLists.Enabled = GridViewCustomLists.RowCount > 0;

            if (GridViewCustomLists.RowCount > 0)
            {
                GridViewCustomLists.SelectRow(0);
            }
        }

        private void GridCustomLists_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            ButtonRenameList.Enabled = GridViewCustomLists.SelectedRowsCount != 0;
            ButtonDeleteList.Enabled = GridViewCustomLists.SelectedRowsCount != 0;
        }

        private void DgvCustomLists_SelectionChanged(object sender, EventArgs e)
        {
            //ContextMenuCustomListsRename.Enabled = DgvCustomLists.CurrentRow != null;
            //ContextMenuCustomListsDelete.Enabled = DgvCustomLists.CurrentRow != null;
            //ToolStripDeleteSelected.Enabled = DgvCustomLists.CurrentRow != null;
        }

        private void ButtonRenameList_Click(object sender, EventArgs e)
        {
            string currentListName = GridViewCustomLists.GetRowCellDisplayText(GridViewCustomLists.GetSelectedRows()[0], "List Name");
            string newListName = DialogExtensions.ShowTextInputDialog(this, "Rename List", "List Name:", currentListName);

            if (!string.IsNullOrWhiteSpace(newListName))
            {
                if (currentListName != newListName && CustomListNameExists(newListName))
                {
                    XtraMessageBox.Show("A list with this name already exists.", "List Name Exists");
                }
                else
                {
                    MainWindow.Settings.RenameCustomList(currentListName, newListName);
                    LoadCustomLists();
                }
            }
        }

        private void ContextMenuCustomListsDelete_Click(object sender, EventArgs e)
        {
            //ToolStripDeleteSelected.PerformClick();
        }

        private void ButtonCreateNewList_Click(object sender, EventArgs e)
        {
            string listName = DialogExtensions.ShowTextInputDialog(this, "Create New List", "List Name:", "");

            if (!string.IsNullOrWhiteSpace(listName))
            {
                if (CustomListNameExists(listName))
                {
                    XtraMessageBox.Show("A list with this name already exists.", "List Name Exists");
                }
                else
                {
                    MainWindow.Settings.AddCustomList(listName);
                    LoadCustomLists();
                }
            }
        }

        private void ButtonDeleteList_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected list?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MainWindow.Settings.CustomLists.RemoveAt(DgvCustomLists.CurrentRow.Index);
                LoadCustomLists();
            }
        }

        private void ButtonDeleteAllLists_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really to delete all of your created lists?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainWindow.Settings.CustomLists.Clear();
                LoadCustomLists();
            }
        }

        private static bool CustomListNameExists(string name)
        {
            foreach (CustomList customList in MainWindow.Settings.CustomLists)
            {
                if (string.Equals(customList.Name, name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}