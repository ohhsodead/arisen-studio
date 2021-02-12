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
            ListBoxItems.SelectedIndexChanged -= ListBoxItems_SelectedIndexChanged;

            foreach (string item in Items)
            {
                ListBoxItems.Items.Add(item);
            }

            // Increase form size to fit listview contents
            if (Items.Count > 0)
            {
                Width = ListBoxItems.Width + Items.Max(w => w.Length) + 70;
                //Refresh();
            }

            ListBoxItems.SelectedIndexChanged += ListBoxItems_SelectedIndexChanged;
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedIndex != -1)
            {
                SelectedItem = ListBoxItems.SelectedItem.ToString();
                Close();
            }
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
            if (ListBoxItems.SelectedIndex != -1)
            {
                SelectedItem = ListBoxItems.SelectedItem.ToString();
                Close();
            }
        }
    }
}