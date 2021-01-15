using System;
using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Database;
using ModioX.Models.Resources;

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
            DgvCustomLists.Rows.Clear();            

            foreach (CustomList customList in MainWindow.Settings.CustomLists)
            {
                DgvCustomLists.Rows.Add(customList.Name, customList.ModIds.Count + " Mods");
            }

            LabelNoListsCreated.Visible = DgvCustomLists.Rows.Count < 1;

            LabelTotalCustomLists.Text = $@"{DgvCustomLists.Rows.Count} Lists";

            ToolStripDeleteAll.Enabled = DgvCustomLists.Rows.Count > 0;
        }

        private void DgvCustomLists_SelectionChanged(object sender, EventArgs e)
        {
            ContextMenuCustomListsRename.Enabled = DgvCustomLists.CurrentRow != null;
            ContextMenuCustomListsDelete.Enabled = DgvCustomLists.CurrentRow != null;
            ToolStripDeleteSelected.Enabled = DgvCustomLists.CurrentRow != null;
        }

        private void ContextMenuCustomListsRename_Click(object sender, EventArgs e)
        {
            string currentListName = DgvCustomLists.Rows[DgvCustomLists.CurrentRow.Index].Cells[0].Value.ToString();
            string newListName = DialogExtensions.ShowTextInputDialog(this, "Rename List", "List Name:", currentListName);

            if (!string.IsNullOrWhiteSpace(newListName))
            {
                if (currentListName != newListName && CustomListNameExists(newListName))
                {
                    DarkMessageBox.ShowWarning("A list with this name already exists.", "List Name Exists");
                }
                else
                {
                    MainWindow.Settings.UpdateCustomListName(currentListName, newListName);
                    LoadCustomLists();
                }
            }
        }

        private void ContextMenuCustomListsDelete_Click(object sender, EventArgs e)
        {
            ToolStripDeleteSelected.PerformClick();
        }

        private void ToolStripCreateNewList_Click(object sender, EventArgs e)
        {
            string listName = DialogExtensions.ShowTextInputDialog(this, "Create New List", "List Name:", "");

            if (!string.IsNullOrWhiteSpace(listName))
            {
                if (CustomListNameExists(listName))
                {
                    DarkMessageBox.ShowWarning("A list with this name already exists.", "List Name Exists");
                }
                else
                {
                    MainWindow.Settings.CustomLists.Add(new CustomList() { Name = listName });
                    LoadCustomLists();
                }
            }
        }

        private void ToolStripDeleteSelected_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.ShowExclamation("Do you really want to delete the selected list?", "Confirm", DarkDialogButton.YesNo) == DialogResult.Yes)
            {
                MainWindow.Settings.CustomLists.RemoveAt(DgvCustomLists.CurrentRow.Index);
                LoadCustomLists();
            }
        }

        private void ToolStripDeleteAll_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.ShowExclamation("Do you really to delete all of your created lists?", "Confirm", DarkDialogButton.YesNo) == DialogResult.Yes)
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

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}