using System;
using System.Windows.Forms;
using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Renderers;

namespace ModioX.Windows
{
    public partial class RegionsWindow : DarkForm
    {
        public RegionsWindow()
        {
            InitializeComponent();
        }

        public string SelectedRegion { get; private set; }

        private void ListViewRegions_SelectedIndicesChanged(object sender, EventArgs e)
        {
            SelectedRegion = ListViewRegions.Items[ListViewRegions.SelectedIndices[0]].Text;
            Close();
        }
    }
}