using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DarkUI.Forms;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    public partial class AboutDialog : XtraForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            _ = ButtonClose.Focus();

            _ = HideCaret(RichTextBoxInformation.Handle);
            _ = HideCaret(RichTextBoxCredits.Handle);
            _ = HideCaret(RichTextBoxThanks.Handle);
            _ = HideCaret(RichTextBoxLicence.Handle);
        }

        private void RichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            _ = HideCaret(RichTextBoxInformation.Handle);
            _ = HideCaret(RichTextBoxCredits.Handle);
            _ = HideCaret(RichTextBoxThanks.Handle);
            _ = HideCaret(RichTextBoxLicence.Handle);
        }

        private void RichTextBoxCredits_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            _ = Process.Start(e.LinkText);
        }

        private void RichTextBoxLicence_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            _ = Process.Start(e.LinkText);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}