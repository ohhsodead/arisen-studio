using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ps3xftp.Windows
{
    public partial class RegionsWindow : Form
    {
        public RegionsWindow()
        {
            InitializeComponent();
        }

        public string SelectedRegion { get; set; }

        private void ListboxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRegion = ListboxRegions.GetItemText(ListboxRegions.SelectedItem);
            Close();
        }
    }
}
