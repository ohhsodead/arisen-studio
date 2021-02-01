using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
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
            foreach (var item in Items) ListBoxItems.Items.Add(Text = item);

            // Increase form size to fit listview contents
            Width = ListBoxItems.Width + Items.Max(w => w.Length) + 70;
            Refresh();
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedIndex != -1)
            {
                SelectedItem = ListBoxItems.SelectedItem.ToString();
                Close();
            }
        }
    }
}