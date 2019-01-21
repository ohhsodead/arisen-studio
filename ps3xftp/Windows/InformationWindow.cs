using System.Diagnostics;
using System.Windows.Forms;

namespace Ps3Xftp.Windows
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