using System.Diagnostics;
using System.Windows.Forms;

namespace ps3xftp.Windows
{
    public partial class InformationWindow : Form
    {
        public InformationWindow()
        {
            InitializeComponent();
        }

        private void LabelEmailMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:bettercodes1@gmail.com");
        }
    }
}