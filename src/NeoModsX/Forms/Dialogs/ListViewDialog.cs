using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using NeoModsX.Extensions;
using NeoModsX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Data;
using static NeoModsX.Extensions.DataExtensions;

namespace NeoModsX.Forms.Dialogs
{
    public partial class ListViewDialog : XtraForm
    {
        public ListViewDialog()
        {
            InitializeComponent();
        }

        public List<ListItem> Items { get; set; }

        public ListItem SelectedItem { get; set; }

        private void ListViewDialog_Load(object sender, EventArgs e)
        {
            GroupListItems.Text = MainWindow.ResourceLanguage.GetString("CHOOSE_ITEM");

            using (DataTable dataTable = CreateDataTable(new List<DataColumn>
            {
                new("Value", typeof(string)),
                new("Name", typeof(string))
            }))
            {
                foreach (ListItem item in Items)
                {
                    dataTable.Rows.Add(item.Value, item.Name);
                }

                GridControlListItems.DataSource = dataTable;
            }

            GridViewListItems.Columns[0].Visible = false;
            GridViewListItems.Columns[1].Width = GridViewListItems.Columns[1].GetBestWidth();

            switch (Items.Count)
            {
                // Increase form size to fit list contents
                case > 0:
                    Width = GridViewListItems.Columns[1].GetBestWidth() + 70;
                    Refresh();
                    break;
            }

            //GridViewListItems.InvertRowSelection(0);
            //GridViewListItems.ClearSelection();
            GridViewListItems.FocusedRowHandle = -1;
            GridViewListItems.UnselectRow(0);
        }

        private void GridViewListItems_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewListItems.SelectedRowsCount)
            {
                case > 0:
                    SelectedItem = new ListItem
                    {
                        Name = GridViewListItems.GetRowCellDisplayText(e.RowHandle, "Name"),
                        Value = GridViewListItems.GetRowCellDisplayText(e.RowHandle, "Value")
                    };

                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}