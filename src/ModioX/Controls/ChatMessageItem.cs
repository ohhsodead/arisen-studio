using System;
using System.Linq;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;

namespace ModioX.Controls
{
    public partial class ChatMessageItem : XtraUserControl
    {
        public ChatMessageItem()
        {
            InitializeComponent();
        }

        public static ImageCollection Images { get; } = ChatRoomWindow.Window.ImageCollection;

        public string UserName { get; set; }

        public string TimeStamp { get; set; }

        public string Message { get; set; }

        private void ChatMessageItem_Load(object sender, EventArgs e)
        {
            LabelMessage.HtmlImages = Images;

            LabelUserName.Text = UserName;
            LabelTimeStamp.Text = TimeStamp;
            LabelMessage.Text = ConvertToEmojis(Message).CensorString().ReplaceUrls("<No Links Allowed>");
        }

        public string GetEmoji(string emoji)
        {
            foreach (ListItem item in from ListItem item in ChatRoomWindow.ListEmojis
                                      where item.Name.EqualsIgnoreCase(emoji)
                                      select item)
                return item.Value;

            return "";
        }

        public string ConvertToEmojis(string message)
        {
            string splitEmojis = message.Contains("::") ? message.Replace("::", ": :") : message;

            foreach (string emoji in splitEmojis.Split(new[] { " " }, StringSplitOptions.None))
            {
                if (ChatRoomWindow.ListEmojis.Any(x => x.Name.EqualsIgnoreCase(emoji)))
                {
                    message = message.Replace(emoji, GetEmoji(emoji));
                }
            }

            return message;
        }
    }
}