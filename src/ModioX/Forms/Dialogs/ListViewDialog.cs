using System;
using System.Collections.Generic;
using System.Linq;
using DarkUI.Controls;
using DarkUI.Forms;
using DevExpress.XtraEditors;

namespace ModioX.Windows
{
    public partial class ListViewDialog : XtraForm
    {
        public ListViewDialog()
        {
            InitializeComponent();
        }

        public List<string> Items { get; set; }

        public string SelectedItem { get; private set; }

        private void ListViewDialog_Load(object sender, EventArgs e)
        {
            foreach (var item in Items) ListViewItems.Items.Add(new DarkListItem { Text = item });

            // Increase form size to fit listview contents
            Width = ListViewItems.Width + Items.Max(w => w.Length) + 70;
            Refresh();
        }

        private void ListViewRegions_SelectedIndicesChanged(object sender, EventArgs e)
        {
            SelectedItem = ListViewItems.Items[ListViewItems.SelectedIndices[0]].Text;
            Close();
        }
    }
}