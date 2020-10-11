using DarkUI.Forms;
using ModioX.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class AboutDialog : DarkForm
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            _ = HideCaret(RichTextBoxCredits.Handle);
            _ = HideCaret(RichTextBoxThanks.Handle);
            _ = HideCaret(RichTextBoxLicence.Handle);
        }
        
        private void RichTextBoxLicence_MouseDown(object sender, MouseEventArgs e)
        {
            _ = HideCaret(RichTextBoxCredits.Handle);
            _ = HideCaret(RichTextBoxThanks.Handle);
            _ = HideCaret(RichTextBoxLicence.Handle);
        }

        private void RichTextBoxCredits_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ohhsodead/ModioX");
        }

        private void RichTextBoxLicence_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start("http://www.gnu.org/licenses/");
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xcx(object sender, PaintEventArgs e)
        {

        }
    }
}