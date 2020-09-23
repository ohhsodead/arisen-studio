using DarkUI.Controls;
using DarkUI.Forms;
using System;
using System.Collections.Generic;

namespace ModioX.Windows
{
    public partial class ListItemPicker : DarkForm
    {
        public ListItemPicker()
        {
            InitializeComponent();
        }

        public List<string> Items { get; set; }

        public string SelectedItem { get; private set; }

        private void ListViewDialog_Load(object sender, EventArgs e)
        {
            SectionItems.SectionHeader = Text;
            Text = "Choose Item...";

            foreach (string item in Items)
            {
                ListViewItems.Items.Add(new DarkListItem() { Text = item });
            }
        }

        private void ListViewRegions_SelectedIndicesChanged(object sender, EventArgs e)
        {
            SelectedItem = ListViewItems.Items[ListViewItems.SelectedIndices[0]].Text;
            Close();
        }
    }
}