using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ModioX.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class SortOptionsDialog : XtraForm
    {
        public SortOptionsDialog()
        {
            InitializeComponent();
        }

        public List<string> SortOptions { get; set; } = new();

        public string SortOption { get; set; }

        public ColumnSortOrder SortOrder { get; set; } = ColumnSortOrder.Ascending;

        private void SortOptionsDialog_Load(object sender, EventArgs e)
        {
            RadioGroupSortOptions.Properties.Items.Clear();

            foreach (string sortOption in SortOptions)
            {
                RadioGroupSortOptions.Properties.Items.Add(new RadioGroupItem(sortOption, sortOption));
            }

            if (SortOption.IsNullOrEmpty())
            {
                RadioGroupSortOptions.SelectedIndex = 0;
            }
            else
            {
                RadioGroupSortOptions.SelectedIndex = RadioGroupSortOptions.Properties.Items.GetItemIndexByValue(SortOption);
            }

            RadioGroupSortOrder.SelectedIndex = (int)SortOrder - 1;
        }

        private void SortOptionsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            SortOption = RadioGroupSortOptions.Properties.Items[RadioGroupSortOptions.SelectedIndex].Description;
        }

        private void RadioGroupSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortOption = RadioGroupSortOptions.Properties.Items[RadioGroupSortOptions.SelectedIndex].Description;
        }

        private void RadioGroupSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortOrder = RadioGroupSortOrder.SelectedIndex == 0 ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending;
        }
    }
}