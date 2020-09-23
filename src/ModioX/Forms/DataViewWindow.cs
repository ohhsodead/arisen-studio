using DarkUI.Forms;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class DataViewWindow : DarkForm
    {
        /// <summary>
        ///     Initialize application form
        /// </summary>
        public DataViewWindow()
        {
            InitializeComponent();
        }

        private void DataViewWindow_Scroll(object sender, ScrollEventArgs e)
        {
            panelItems.Update(); // Removes 'Lag/Bad Drawing' when scrolling
        }
    }
}