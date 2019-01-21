using System.Windows.Forms;

namespace Ps3Xftp.Windows
{
    public partial class DataWindow : Form
    {
        public DataWindow()
        {
            InitializeComponent();
        }

        private void DataWindow_Scroll(object sender, ScrollEventArgs e)
        {
            panelItems.Update(); // Attempt to stop lag (not smooth) when scrolling
        }

        protected override void OnPaint(PaintEventArgs e) { }
        
        /*************************************************************************/
        /* Keyboard Shortcuts                                                    */
        /*************************************************************************/

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // Close window
                case Keys.Escape:
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}