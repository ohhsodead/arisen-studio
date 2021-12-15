using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using ModioX.Constants;
using ModioX.Controls;
using ModioX.Extensions;
using ModioX.Models.Resources;
using TechLifeForum;

namespace ModioX.Forms.Windows
{
    [SuppressMessage("ReSharper", "CoVariantArrayConversion")]
    [SuppressMessage("ReSharper", "UnusedParameter.Local")]
    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
    public partial class ChatRoomWindow : XtraForm
    {
        public static ChatRoomWindow Window;

        public static List<ListItem> ListEmojis = new()
        {
            new ListItem { Name = ":joy:", Value = "<image=joy.png>" },
            new ListItem { Name = ":grin:", Value = "<image=grin.png>" },
            new ListItem { Name = ":grinning:", Value = "<image=grinning.png>" },
            new ListItem { Name = ":heart:", Value = "<image=heart.png>" },
            new ListItem { Name = ":neutral_face:", Value = "<image=neutral_face.png>" },
            new ListItem { Name = ":sad_sweat:", Value = "<image=sad_sweat.png>" },
            new ListItem { Name = ":angry:", Value = "<image=angry.png>" },
            new ListItem { Name = ":cry_tear:", Value = "<image=cry_tear.png>" },
            new ListItem { Name = ":angel:", Value = "<image=angel.png>" },
            new ListItem { Name = ":tongue_out:", Value = "<image=tongue_out.png>" },
            new ListItem { Name = ":heart_break:", Value = "<image=heart_break.png>" },
            new ListItem { Name = ":happy:", Value = "<image=happy.png>" },
            new ListItem { Name = ":wink:", Value = "<image=wink.png>" },
            new ListItem { Name = ":kiss_heart:", Value = "<image=kiss_heart.png>" },
            new ListItem { Name = ":wink_tongue:", Value = "<image=wink_tongue.png>" },
            new ListItem { Name = ":weary:", Value = "<image=weary.png>" },
            new ListItem { Name = ":confused:", Value = "<image=confused.png>" },
            new ListItem { Name = ":sunglasses:", Value = "<image=sunglasses.png>" },
            new ListItem { Name = ":open_mouth:", Value = "<image=open_mouth.png>" },
            new ListItem { Name = ":no_mouth:", Value = "<image=no_mouth.png>" },
            new ListItem { Name = ":smile:", Value = "<image=smile.png>" },
            new ListItem { Name = ":thumbsup:", Value = "<image=thumbsup.png>" },
            new ListItem { Name = ":amazed:", Value = "<image=amazed.png>" },
            new ListItem { Name = ":flushed:", Value = "<image=flushed.png>" }
        };

        public ChatRoomWindow()
        {
            Window = this;
            InitializeComponent();
        }

        public SettingsData Settings { get; } = MainWindow.Settings;

        private IrcClient IrcClient { get; set; }

        private static string CurrentServer { get; } = "irc.mibbit.net"; //"irc.irc.com"; //"hyojong.joseon.kr"; //"irc.joseon.kr"; //"chat.freenode.net";

        private static string CurrentRoom { get; } = "#ModioX";

        private static string UserName { get; set; }

        private List<string> IgnoredUsers { get; set; } = new();

        private List<string> WhiteListUsers { get; set; } = new();

        private List<PrivateChatItem> PrivateChats { get; } = new();

        private string SelectedUser { get; set; } = string.Empty;

        private void ChatRoomWindow_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.StyleChanged += ChatRoomWindow_StyleChanged;

            foreach (ListItem image in ListEmojis)
            {
                ImageListBox.Items.Add(image.Value);
            }

            UserName = Settings.ChatUserName;
            IgnoredUsers = Settings.ChatIgnoredUsers;
            WhiteListUsers = Settings.ChatWhiteListUsers;

            UserName = UserName.FormatUserName();
            LabelUserName.Caption = UserName;

            SetStatus("Connecting...");

            IrcClient = new IrcClient(CurrentServer, 6667)
            {
                Nick = UserName
            };

            AddListeners();
            IrcClient.Connect();
        }

        private void ChatRoomWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.ChatUserName = UserName.FormatUserName();
            Settings.ChatIgnoredUsers = IgnoredUsers;
            Settings.ChatWhiteListUsers = WhiteListUsers;

            switch (IrcClient)
            {
                case null:
                    return;
            }

            switch (IrcClient.Connected)
            {
                case true:
                    try
                    {
                        IrcClient.Disconnect();
                    }
                    catch (Exception ex)
                    {
                        MainWindow.Window.SetStatus("Unable to disconnect from chat room.", ex);
                    }

                    break;
            }
        }

        private void ChatRoomWindow_StyleChanged(object sender, EventArgs e)
        {
            UpdateColors();
        }

        private void AddListeners()
        {
            IrcClient.ExceptionThrown += ex =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                }

                SetStatus("There was an error with the chat. Error Message: " + ex.Message, ex);
                XtraMessageBox.Show("There was an error with the chat. Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            };

            IrcClient.NickTaken += delegate
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                    default:
                        XtraMessageBox.Show("This username is already taken, please choose another one. You can choose a new username in the Settings page.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                        break;
                }
            };

            IrcClient.OnConnect += () =>
            {
                IrcClient.JoinChannel(CurrentRoom);
                SetStatus("Successfully connected to the chat room.");

                AddSystemMessage(
                    "Welcome to the ModioX chat room!" +
                    "\r\nThis is only for help and general discussions between modders." +
                    $"\r\nYou can also open a ticket in our <a href=\"{Urls.DiscordServer}\">Discord Server</a>" +
                    "\r\n----------------------------------------------------------------------" +
                    "\r\nImportant Rules:" +
                    "\r\n• No spamming" +
                    "\r\n• No overusing caps" +
                    "\r\n• No advertising or self promoting" +
                    "\r\n• No personal attacks or harassment" +
                    "\r\n• No impersonating users or other accounts" +
                    "\r\n• No inappropriate (e.g. vulgar, offensive etc) content",
                    true, false);

                TextBoxMessage.Enabled = true;
                TextBoxMessage.Focus();
            };

            IrcClient.UpdateUsers += (c, users) =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                }

                foreach (string user in users)
                {
                    if (!ListBoxUsers.Items.Contains(user))
                    {
                        ListBoxUsers.Items.Add(user);
                    }
                }

                LabelOnlineUsers.Text = $@"Online Users ({ListBoxUsers.Items.Count})";
            };

            IrcClient.ChannelMessage += (s, user, message) =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                }

                if (IgnoredUsers.Contains(user))
                {
                    return;
                }

                if (Settings.ChatNotificationType == ChatNotificationType.AllMessages)
                {
                    NotifyMessage(ChatNotificationType.AllMessages);
                }

                AddChatMessage(user, message);
            };

            IrcClient.UserJoined += (c, user) =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                }

                AddSystemMessage($"{user} has joined the chat.", true, true);

                if (!ListBoxUsers.Items.Contains(user))
                {
                    ListBoxUsers.Items.Add(user.Replace("~", ""));
                }

                LabelOnlineUsers.Text = $"Online Users ({ListBoxUsers.Items.Count})";
            };

            IrcClient.UserLeft += (c, user) =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                }

                AddSystemMessage($"{user} has left the chat.", true, true);

                ListBoxUsers.Items.Remove(user);

                LabelOnlineUsers.Text = $"Online Users ({ListBoxUsers.Items.Count})";
            };

            //IrcClient.ServerMessage += (m) =>
            //{
            //    AddChatMessage("Server Message", m);
            //};

            IrcClient.PrivateMessage += (user, message) =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                }

                if (user.EqualsIgnoreCase("Mibbit"))
                {
                    return;
                }

                if (user.EqualsIgnoreCase("ChanServ"))
                {
                    return;
                }

                switch (Settings.ChatBlockPrivateMessages)
                {
                    case true when !Settings.BlackListUserNames.AnyContainsIgnoreCase(user):
                        {
                            if (IgnoredUsers.Contains(user))
                            {
                                return;
                            }

                            switch (WhiteListUsers.Contains(user))
                            {
                                case false:
                                    {
                                        bool canIShowMessageBox = true;
                                        object exLocker = new();

                                        lock (exLocker)
                                        {
                                            switch (canIShowMessageBox)
                                            {
                                                case true:
                                                    canIShowMessageBox = false;
                                                    break;
                                                default:
                                                    return;
                                            }
                                        }

                                        if (XtraMessageBox.Show(this, "A private message was blocked from user: " + user + "\n\nWould you like to allow private messages from this user?", "Blocked Private Message",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                        {
                                            IgnoredUsers.Remove(user);
                                            WhiteListUsers.Add(user);
                                        }
                                        else
                                        {
                                            IgnoredUsers.Add(user);
                                            WhiteListUsers.Remove(user);
                                            RemovePrivateChat(user);

                                            return;
                                        }

                                        lock (exLocker)
                                        {
                                            canIShowMessageBox = true;
                                        }

                                        break;
                                    }
                            }

                            break;
                        }
                }

                SendPrivateMessage(user, message);
            };

            IrcClient.UserNickChange += (oldUser, newUser) =>
            {
                switch (IrcClient)
                {
                    case null:
                        return;
                    default:
                        AddSystemMessage($"{oldUser.FormatUserName()} has changed their username to: {newUser.FormatUserName()}", true, true);

                        ListBoxUsers.Items[ListBoxUsers.Items.IndexOf(oldUser.FormatUserName())] = newUser.FormatUserName();
                        break;
                }
            };
        }

        private void TabControlChat_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (TabControlChats.TabPages.First() == e.Page)
            {
                PanelMessages.VerticalScroll.Value = PanelMessages.VerticalScroll.Maximum;
                TextBoxMessage.Focus();
                TextBoxMessage.SelectionStart = TextBoxMessage.Text.Length;
                return;
            }

            e.Page.Text = e.Page.Text.Split()[0];

            PrivateChatItem privateChat = e.Page.Controls[0] as PrivateChatItem;

            switch (privateChat)
            {
                case null:
                    return;
                default:
                    privateChat.PanelMessages.VerticalScroll.Value = privateChat.PanelMessages.VerticalScroll.Maximum;
                    privateChat.TextBoxMessage.Focus();
                    privateChat.TextBoxMessage.SelectionStart = TextBoxMessage.Text.Length;
                    break;
            }
        }

        private void TabControlChat_CloseButtonClick(object sender, EventArgs e)
        {
            if (e is not ClosePageButtonEventArgs arg)
            {
                return;
            }

            XtraTabPage tabPage = arg.Page as XtraTabPage;
            PrivateChats.RemoveAt(TabControlChats.TabPages.IndexOf(tabPage) - 1);
            TabControlChats.TabPages.Remove(tabPage);
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
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            switch (sender)
            {
                case ImageListBoxControl listBox:
                    {
                        int index = listBox.IndexFromPoint(e.Location);
                        switch (index)
                        {
                            case -1:
                                return;
                        }
                        break;
                    }
            }

            switch (ImageListBox.SelectedItem)
            {
                case null:
                    return;
            }

            string[] chars = { ">", "<", "=", "image", ".png" };
            TextBoxMessage.Text += $":{ImageListBox.SelectedItem.ToString().ReplaceAll(chars, string.Empty)}:";
            ImageListBox.Visible = false;
        }

        private DateTime msgTimeStamp;

        private void SendMessage(string message)
        {
            if (message.IsNullOrWhiteSpace())
            {
                return;
            }

            switch ((DateTime.Now - msgTimeStamp).Ticks)
            {
                case < 20000000:
                    return;
            }

            msgTimeStamp = DateTime.Now;

            IrcClient.SendMessage(CurrentRoom, message);
            AddChatMessage(UserName, message);

            TextBoxMessage.Text = "";
            TextBoxMessage.Focus();
        }

        private void ListBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxUsers.SelectedIndex == -1)
            {
                SelectedUser = string.Empty;
                return;
            }

            if (ListBoxUsers.SelectedItem.Equals(UserName))
            {
                SelectedUser = string.Empty;
                return;
            }

            SelectedUser = ListBoxUsers.SelectedItem as string;

            if (SelectedUser.Contains("@"))
            {
                SelectedUser = SelectedUser.Remove(0, 1);
            }
        }

        private void PopupMenu_BeforePopup(object sender, CancelEventArgs e)
        {
            MenuButtonUserPrivateMessage.Enabled = !SelectedUser.IsNullOrWhiteSpace() && !UserName.Equals(SelectedUser);

            MenuButtonUserMention.Enabled = !SelectedUser.IsNullOrWhiteSpace() && !UserName.Equals(SelectedUser);

            MenuButtonUserIgnore.Enabled = !SelectedUser.IsNullOrWhiteSpace() && !UserName.Equals(SelectedUser) && !Settings.BlackListUserNames.AnyContainsIgnoreCase(SelectedUser);
            MenuButtonUserIgnore.Checked = IgnoredUsers.Contains(SelectedUser);
        }

        private void MenuButtonUserPrivateMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SelectedUser.IsNullOrEmpty())
            {
                return;
            }

            IgnoredUsers.Remove(SelectedUser);
            StartPrivateChat(SelectedUser);
        }

        private void MenuButtonUserMention_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SelectedUser.IsNullOrEmpty())
            {
                return;
            }

            TabPageMainChat.Show();
            TextBoxMessage.Text = "@" + SelectedUser + " ";
            TextBoxMessage.Focus();
            TextBoxMessage.SelectionStart = TextBoxMessage.Text.Length;
        }

        private void MenuButtonUserIgnore_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (SelectedUser.IsNullOrEmpty())
            {
                return;
            }

            if (IgnoredUsers.Contains(SelectedUser))
            {
                IgnoredUsers.Remove(SelectedUser);
            }
            else
            {
                IgnoredUsers.Add(SelectedUser);
            }
        }

        private void AddChatMessage(string userName, string message)
        {
            ChatMessageItem messageChatItem = new()
            {
                Dock = DockStyle.Top,
                UserName = userName,
                Message = message,
                TimeStamp = DateTime.Now.ToString("HH:mm:ss")
            };
            
            if (message.Contains("@" + UserName) && Settings.ChatNotificationType == ChatNotificationType.Mentioned)
            {
                messageChatItem.BackColor = MainWindow.SkinColors.GetColor("Highlight");

                if (!Settings.ChatMuteSounds)
                {
                    SystemSounds.Beep.Play();
                }

                NotifyMessage(ChatNotificationType.Mentioned);
            }

            PanelMessages.Controls.Add(messageChatItem);
            messageChatItem.BringToFront();
            PanelMessages.ScrollControlIntoView(messageChatItem);
        }

        private void AddSystemMessage(string message, bool bold = false, bool italic = false)
        {
            ChatSystemMessageItem systemMessageItem = new(bold, italic) { Dock = DockStyle.Top, Message = message, TimeStamp = DateTime.Now.ToString("HH:mm:ss") };
            PanelMessages.Controls.Add(systemMessageItem);
            systemMessageItem.BringToFront();
            PanelMessages.ScrollControlIntoView(systemMessageItem);
        }

        private void SendPrivateMessage(string user, string message)
        {
            if (PrivateChats.Any(x => x.Recipient.Equals(user)))
            {
                XtraTabPage tabPage = TabControlChats.TabPages.FirstOrDefault(x => x.Text.Split()[0].Equals(user));

                switch (tabPage?.Controls[0])
                {
                    case PrivateChatItem privateChat:
                        privateChat.AddChatMessage(user, message);
                        break;
                }

                if (TabControlChats.SelectedTabPage == tabPage)
                {
                    return;
                }

                switch (tabPage)
                {
                    case null:
                        return;
                    default:
                        tabPage.Text = Settings.ChatHideUnreadCount ? user : 
                            user + (tabPage.Text.Contains(" ")
                            ? $" ({int.Parse(tabPage.Text.Split(' ')[1].TrimStart('(').TrimEnd(')')) + 1})"
                            : " (1)");
                        break;
                }
            }
            else
            {
                bool canIShowMessageBox = true;
                object exLocker = new();

                XtraTabPage tabPage = new() { Text = user, ShowCloseButton = DefaultBoolean.True };
                PrivateChatItem privateChat = new() { Dock = DockStyle.Fill, IrcClient = IrcClient, UserName = UserName, Recipient = user };
                tabPage.Controls.Add(privateChat);
                TabControlChats.TabPages.Add(tabPage);

                privateChat.AddSystemMessage(user + " has started a private chat with you!");
                privateChat.AddChatMessage(user, message);
                PrivateChats.Add(privateChat);

                if (TabControlChats.SelectedTabPage != tabPage)
                {
                    tabPage.Text = Settings.ChatHideUnreadCount ? user :
                        user + (tabPage.Text.Contains(" ")
                        ? $" ({int.Parse(tabPage.Text.Split(' ')[1].TrimStart('(').TrimEnd(')')) + 1})"
                        : " (1)");
                }

                lock (exLocker)
                {
                    switch (canIShowMessageBox)
                    {
                        case true:
                            canIShowMessageBox = false;
                            break;
                        default:
                            return;
                    }
                }

                XtraMessageBox.Show(this, "A user has started a private chat with you!", "New Private Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lock (exLocker)
                {
                    canIShowMessageBox = true;
                }
            }
        }

        private void StartPrivateChat(string user)
        {
            if (PrivateChats.Any(x => x.Recipient.Equals(user)))
            {
                XtraTabPage tabPage = TabControlChats.TabPages.FirstOrDefault(x => x.Text.Split()[0].Equals(user));
                tabPage?.Show();
            }
            else
            {
                XtraTabPage tabPage = new() { Text = user, ShowCloseButton = DefaultBoolean.True };
                PrivateChatItem privateChat = new() { Dock = DockStyle.Fill, IrcClient = IrcClient, UserName = UserName, Recipient = user };
                tabPage.Controls.Add(privateChat);
                TabControlChats.TabPages.Add(tabPage);
                tabPage.Show();

                PrivateChats.Add(privateChat);
                privateChat.AddSystemMessage($"You have started a private chat with user: {user}");
                privateChat.SendMessage("Hi, I would like to start a private chat with you!");
            }
        }

        private void RemovePrivateChat(string user)
        {
            if (PrivateChats.Any(x => x.Recipient.Equals(user)))
            {
                XtraTabPage tabPage = TabControlChats.TabPages.FirstOrDefault(x => x.Text.Split()[0].Equals(user));
                PrivateChats.RemoveAt(TabControlChats.TabPages.IndexOf(tabPage) - 1);
                TabControlChats.TabPages.Remove(tabPage);
            }
        }

        private void NotifyMessage(ChatNotificationType notificationType)
        {
            if (notificationType == ChatNotificationType.AllMessages && notificationType == Settings.ChatNotificationType)
            {
                XtraMessageBox.Show(this, "A new message has been received.", "New Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (notificationType == ChatNotificationType.Mentioned && notificationType == Settings.ChatNotificationType)
            {
                XtraMessageBox.Show(this, "You have been mentioned by someone!", "New Mention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void UpdateColors()
        {
            LabelOnlineUsers.ForeColor = MainWindow.SkinColors.GetColor("ControlText");

            TabPageMainChat.BackColor = MainWindow.SkinColors.GetColor("Control");
            TabPageMainChat.ForeColor = MainWindow.SkinColors.GetColor("ControlText");

            ContainerMessages.BackColor = MainWindow.SkinColors.GetColor("Control");
            ContainerMessages.ForeColor = MainWindow.SkinColors.GetColor("ControlText");

            PanelMessages.BackColor = MainWindow.SkinColors.GetColor("Control");
            PanelMessages.ForeColor = MainWindow.SkinColors.GetColor("ControlText");

            foreach (XtraTabPage tabPage in TabControlChats.TabPages.Skip(1))
            {
                tabPage.BackColor = MainWindow.SkinColors.GetColor("Control");
                tabPage.ForeColor = MainWindow.SkinColors.GetColor("ControlText");

                using PrivateChatItem privateChat = tabPage.Controls[0] as PrivateChatItem;
                switch (privateChat)
                {
                    case null:
                        continue;
                }
                privateChat.BackColor = MainWindow.SkinColors.GetColor("Control");
                privateChat.ForeColor = MainWindow.SkinColors.GetColor("ControlText");
                privateChat.ContainerMessages.BackColor = MainWindow.SkinColors.GetColor("Control");
                privateChat.ContainerMessages.ForeColor = MainWindow.SkinColors.GetColor("ControlText");
                privateChat.PanelMessages.BackColor = MainWindow.SkinColors.GetColor("Control");
                privateChat.PanelMessages.ForeColor = MainWindow.SkinColors.GetColor("ControlText");
            }
        }

        /// <summary>
        /// Set the current status.
        /// </summary>
        /// <param name="text"> </param>
        /// <param name="ex"> </param>
        private void SetStatus(string text, Exception ex = null)
        {
            LabelStatus.Caption = text;
            LabelStatus.Refresh();

            if (ex != null)
            {
                Program.Log.Error(ex, text);
            }
        }
    }
}