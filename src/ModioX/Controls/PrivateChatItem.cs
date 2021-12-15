using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using TechLifeForum;

namespace ModioX.Controls
{
    public partial class PrivateChatItem : XtraUserControl
    {
        public PrivateChatItem()
        {
            InitializeComponent();
        }

        public static ImageCollection Images { get; } = ChatRoomWindow.Window.ImageCollection;

        public static List<ListItem> ListEmojis { get; } = ChatRoomWindow.ListEmojis;

        public IrcClient IrcClient { get; set; }

        public string UserName { get; set; }

        public string Recipient { get; set; }

        private void PrivateChatItem_Load(object sender, EventArgs e)
        {
            //ImageListBox.HtmlImages = Images;

            foreach (ListItem image in ListEmojis)
            {
                ImageListBox.Items.Add(image.Value);
            }
        }

        private void TextBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SendMessage(TextBoxMessage.Text);
                    break;
            }
        }

        private void TextBoxMessage_Enter(object sender, EventArgs e)
        {
            ImageListBox.Visible = false;
        }

        private void ImageShowEmoticons_Click(object sender, EventArgs e)
        {
            switch (ImageListBox.Visible)
            {
                case true:
                    ImageListBox.SelectedIndex = -1;
                    ImageListBox.Visible = false;
                    break;
                default:
                    ImageListBox.SelectedIndex = -1;
                    ImageListBox.Visible = true;
                    ImageListBox.Focus();
                    break;
            }
        }

        private void ImageListBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        ImageListBoxControl listBox = sender as ImageListBoxControl;
                        int index = listBox.IndexFromPoint(e.Location);

                        if (index != -1)
                        {
                            string[] chars = { ">", "<", "=", "image", ".png" };
                            TextBoxMessage.Text += $":{ImageListBox.SelectedItem.ToString().ReplaceAll(chars, string.Empty)}:";
                            ImageListBox.Visible = false;
                        }

                        break;
                    }
            }
        }

        private DateTime msgTimeStamp;

        public void SendMessage(string message)
        {
            if (message.IsNullOrWhiteSpace()) return;

            switch ((DateTime.Now - msgTimeStamp).Ticks)
            {
                case < 10000000:
                    return;
            }

            msgTimeStamp = DateTime.Now;

            IrcClient.SendMessage(Recipient, message);
            AddChatMessage(UserName, message);

            TextBoxMessage.Text = "";
            TextBoxMessage.Focus();
        }

        public void AddChatMessage(string userName, string message)
        {
            ChatMessageItem messageChatItem = new()
            {
                Dock = DockStyle.Top,
                UserName = userName,
                Message = message,
                TimeStamp = DateTime.Now.ToString("HH:mm:ss")
            };

            PanelMessages.Controls.Add(messageChatItem);
            messageChatItem.BringToFront();
            PanelMessages.ScrollControlIntoView(messageChatItem);
        }

        public void AddSystemMessage(string message)
        {
            ChatSystemMessageItem systemMessageItem = new()
            {
                Dock = DockStyle.Top,
                Message = message,
                TimeStamp = DateTime.Now.ToString("HH:mm:ss")
            };

            PanelMessages.Controls.Add(systemMessageItem);
            systemMessageItem.BringToFront();
            PanelMessages.ScrollControlIntoView(systemMessageItem);
        }
    }
}