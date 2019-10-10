using DarkUI.Controls;
using DarkUI.Forms;
using System;
using System.Collections.Generic;

namespace ModioX.Windows
{
    public partial class GameRegionDialog : DarkForm
    {
        public GameRegionDialog()
        {
            InitializeComponent();
        }

        public List<string> Regions { get; set; }
        public string SelectedRegion { get; private set; }

        private void GameRegionsWindow_Load(object sender, EventArgs e)
        {
            foreach (string region in Regions)
            {
                ListViewRegions.Items.Add(new DarkListItem() { Text = region });
            }
        }

        private void ListViewRegions_SelectedIndicesChanged(object sender, EventArgs e)
        {
            SelectedRegion = ListViewRegions.Items[ListViewRegions.SelectedIndices[0]].Text;
            Close();
        }
    }
}