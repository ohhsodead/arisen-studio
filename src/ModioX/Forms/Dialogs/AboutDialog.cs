using DarkUI.Forms;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class AboutDialog : DarkForm
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            _ = ButtonClose.Focus();

            _ = HideCaret(RichTextBoxCredits.Handle);
            _ = HideCaret(RichTextBoxThanks.Handle);
            _ = HideCaret(RichTextBoxLicence.Handle);
        }
        
        private void RichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            _ = HideCaret(RichTextBoxCredits.Handle);
            _ = HideCaret(RichTextBoxThanks.Handle);
            _ = HideCaret(RichTextBoxLicence.Handle);
        }

        private void RichTextBoxCredits_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            _ = Process.Start("https://github.com/ohhsodead/ModioX");
        }

        private void RichTextBoxLicence_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            _ = Process.Start("http://www.gnu.org/licenses/");
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}