using System;
using System.Diagnostics;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace ModioX.Controls
{
    public partial class ChatSystemMessageItem : XtraUserControl
    {
        public ChatSystemMessageItem(bool bold = true, bool italic = false)
        {
            InitializeComponent();

            switch (bold)
            {
                case true when italic:
                    LabelMessage.Appearance.FontStyleDelta = FontStyle.Italic | FontStyle.Bold;
                    break;
                case true:
                    LabelMessage.Appearance.FontStyleDelta = FontStyle.Bold;
                    break;
                default:
                    {
                        LabelMessage.Appearance.FontStyleDelta = italic switch
                        {
                            true => FontStyle.Italic,
                            _ => FontStyle.Regular
                        };

                        break;
                    }
            }
        }

        public string Message { get; set; }

        public string TimeStamp { get; set; }

        private void ChatSystemMessageItem_Load(object sender, EventArgs e)
        {
            LabelMessage.Text = Message;
            LabelTimeStamp.Text = TimeStamp;
        }

        private void LabelMessage_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }
    }
}