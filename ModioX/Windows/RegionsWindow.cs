using System;
using System.Windows.Forms;

namespace ModioX.Windows
{
    public partial class RegionsWindow : Form
    {
        public RegionsWindow()
        {
            InitializeComponent();
        }

        public string SelectedRegion { get; private set; }

        private void ListboxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRegion = ListboxRegions.GetItemText(ListboxRegions.SelectedItem);
            Close();
        }
    }
}
