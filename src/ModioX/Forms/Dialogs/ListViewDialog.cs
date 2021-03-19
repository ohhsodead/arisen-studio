using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ModioX.Extensions;
using static ModioX.Extensions.DataExtensions;

namespace ModioX.Forms.Dialogs
{
    public partial class ListViewDialog : XtraForm
    {
        public ListViewDialog()
        {
            InitializeComponent();
        }

        public List<ListItem> Items { get; set; }

        public string SelectedItem { get; set; }

        private void ListViewDialog_Load(object sender, EventArgs e)
        {
            GridListItems.DataSource = null;

            DataTable dataTable = CreateDataTable(new List<DataColumn>() 
            {
                new DataColumn("Value", typeof(string)),
                new DataColumn("Name", typeof(string))
            });

            foreach (ListItem item in Items)
            {
                dataTable.Rows.Add(item.Value, item.Name);
            }

            GridListItems.DataSource = dataTable;

            GridViewListItems.Columns[0].Visible = false;
            GridViewListItems.Columns[1].Width = GridViewListItems.Columns[1].GetBestWidth();

            // Increase form size to fit listview contents
            if (Items.Count > 0)
            {
                Width = GridViewListItems.Columns[1].GetBestWidth() + 70;
                Refresh();
            }
        }

        private void GridViewListItems_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewListItems.SelectedRowsCount > 0)
            {
                SelectedItem = GridViewListItems.GetRowCellDisplayText(e.RowHandle, "Value");
                Close();
            }
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ListBoxItems.SelectedIndex != -1)
            //{
            //    SelectedItem = ListBoxItems.SelectedItem.ToString();
            //    Close();
            //}
        }

        private void ListBoxItems_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (ListBoxItems.SelectedIndex != -1)
            //{
            //    SelectedItem = ListBoxItems.SelectedItem.ToString();
            //    Close();
            //}
        }

        private void ListBoxItems_Click(object sender, EventArgs e)
        {
            //if (ListBoxItems.SelectedIndex != -1)
            //{
            //    SelectedItem = ListBoxItems.SelectedItem.ToString();
            //    Close();
            //}
        }
    }
}