using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class SortOptionsDialog : XtraForm
    {
        public SortOptionsDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public List<string> SortOptions { get; set; } = [];

        public string SortOption { get; set; }

        public ColumnSortOrder SortOrder { get; set; } = ColumnSortOrder.Ascending;

        private void SortOptionsDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("LABEL_SORT_OPTIONS");

            LabelSortBy.Text = Language.GetString("LABEL_SORT_BY") + ":";
            LabelSortOrder.Text = Language.GetString("LABEL_SORT_ORDER") + ":";

            RadioGroupSortOrder.Properties.Items[0].Description = Language.GetString("LABEL_ASCENDING");
            RadioGroupSortOrder.Properties.Items[1].Description = Language.GetString("LABEL_DESCENDING");

            ButtonOK.Text = Language.GetString("LABEL_OK");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

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