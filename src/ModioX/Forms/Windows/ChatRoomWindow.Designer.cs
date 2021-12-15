using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ModioX.Forms.Windows
{
    partial class ChatRoomWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRoomWindow));
            this.ColumnPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.StatusBar = new DevExpress.XtraBars.Bar();
            this.LabelHeaderUserName = new DevExpress.XtraBars.BarStaticItem();
            this.LabelUserName = new DevExpress.XtraBars.BarStaticItem();
            this.LabeHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MenuButtonUserMention = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonUserPrivateMessage = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonUserIgnore = new DevExpress.XtraBars.BarCheckItem();
            this.ListBoxUsers = new DevExpress.XtraEditors.ListBoxControl();
            this.PopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.TabPageMainChat = new DevExpress.XtraTab.XtraTabPage();
            this.ImageShowEmoticons = new DevExpress.XtraEditors.PictureEdit();
            this.ImageListBox = new DevExpress.XtraEditors.ImageListBoxControl();
            this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ContainerMessages = new DevExpress.XtraEditors.PanelControl();
            this.PanelMessages = new DevExpress.XtraEditors.XtraScrollableControl();
            this.TextBoxMessage = new DevExpress.XtraEditors.TextEdit();
            this.TabControlChats = new DevExpress.XtraTab.XtraTabControl();
            this.LabelOnlineUsers = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.TabPageMainChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowEmoticons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMessages)).BeginInit();
            this.ContainerMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlChats)).BeginInit();
            this.TabControlChats.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnPackageName
            // 
            this.ColumnPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPackageName.HeaderText = "Package File Name";
            this.ColumnPackageName.Name = "ColumnPackageName";
            this.ColumnPackageName.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.StatusBar});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelStatus,
            this.LabeHeaderStatus,
            this.MenuButtonUserMention,
            this.MenuButtonUserPrivateMessage,
            this.LabelHeaderUserName,
            this.LabelUserName,
            this.MenuButtonUserIgnore});
            this.BarManager.MaxItemId = 21;
            this.BarManager.StatusBar = this.StatusBar;
            // 
            // StatusBar
            // 
            this.StatusBar.BarItemVertIndent = 5;
            this.StatusBar.BarName = "Status bar";
            this.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.StatusBar.DockCol = 0;
            this.StatusBar.DockRow = 0;
            this.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.StatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderUserName),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelUserName),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabeHeaderStatus, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.StatusBar.OptionsBar.AllowQuickCustomization = false;
            this.StatusBar.OptionsBar.DrawDragBorder = false;
            this.StatusBar.OptionsBar.UseWholeRow = true;
            this.StatusBar.Text = "Status bar";
            // 
            // LabelHeaderUserName
            // 
            this.LabelHeaderUserName.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderUserName.Caption = "User Name:";
            this.LabelHeaderUserName.Id = 7;
            this.LabelHeaderUserName.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderUserName.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderUserName.LeftIndent = 4;
            this.LabelHeaderUserName.Name = "LabelHeaderUserName";
            // 
            // LabelUserName
            // 
            this.LabelUserName.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelUserName.Caption = "User";
            this.LabelUserName.Id = 8;
            this.LabelUserName.Name = "LabelUserName";
            // 
            // LabeHeaderStatus
            // 
            this.LabeHeaderStatus.AllowRightClickInMenu = false;
            this.LabeHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabeHeaderStatus.Caption = "Status:";
            this.LabeHeaderStatus.Id = 3;
            this.LabeHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabeHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabeHeaderStatus.LeftIndent = 2;
            this.LabeHeaderStatus.Name = "LabeHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.LabelStatus.AllowRightClickInMenu = false;
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Stretch;
            this.LabelStatus.Id = 2;
            this.LabelStatus.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.LabelStatus.ItemAppearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisWord;
            this.LabelStatus.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.LabelStatus.ItemInMenuAppearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisWord;
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.RightIndent = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(665, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(665, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(665, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // MenuButtonUserMention
            // 
            this.MenuButtonUserMention.Caption = "Mention";
            this.MenuButtonUserMention.DropDownEnabled = false;
            this.MenuButtonUserMention.Id = 4;
            this.MenuButtonUserMention.Name = "MenuButtonUserMention";
            this.MenuButtonUserMention.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuButtonUserMention_ItemClick);
            // 
            // MenuButtonUserPrivateMessage
            // 
            this.MenuButtonUserPrivateMessage.Caption = "Private Message";
            this.MenuButtonUserPrivateMessage.DropDownEnabled = false;
            this.MenuButtonUserPrivateMessage.Id = 5;
            this.MenuButtonUserPrivateMessage.Name = "MenuButtonUserPrivateMessage";
            this.MenuButtonUserPrivateMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuButtonUserPrivateMessage_ItemClick);
            // 
            // MenuButtonUserIgnore
            // 
            this.MenuButtonUserIgnore.Caption = "Ignore";
            this.MenuButtonUserIgnore.Id = 13;
            this.MenuButtonUserIgnore.Name = "MenuButtonUserIgnore";
            this.MenuButtonUserIgnore.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuButtonUserIgnore_CheckedChanged);
            // 
            // ListBoxUsers
            // 
            this.ListBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxUsers.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ListBoxUsers.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ListBoxUsers.Appearance.Options.UseBackColor = true;
            this.ListBoxUsers.Appearance.Options.UseFont = true;
            this.ListBoxUsers.Location = new System.Drawing.Point(497, 32);
            this.ListBoxUsers.Name = "ListBoxUsers";
            this.BarManager.SetPopupContextMenu(this.ListBoxUsers, this.PopupMenu);
            this.ListBoxUsers.ShowFocusRect = false;
            this.ListBoxUsers.Size = new System.Drawing.Size(156, 421);
            this.ListBoxUsers.TabIndex = 0;
            this.ListBoxUsers.SelectedIndexChanged += new System.EventHandler(this.ListBoxUsers_SelectedIndexChanged);
            // 
            // PopupMenu
            // 
            this.PopupMenu.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuButtonUserPrivateMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuButtonUserMention),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuButtonUserIgnore)});
            this.PopupMenu.Manager = this.BarManager;
            this.PopupMenu.Name = "PopupMenu";
            this.PopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.PopupMenu_BeforePopup);
            // 
            // TabPageMainChat
            // 
            this.TabPageMainChat.Controls.Add(this.ImageShowEmoticons);
            this.TabPageMainChat.Controls.Add(this.ImageListBox);
            this.TabPageMainChat.Controls.Add(this.ContainerMessages);
            this.TabPageMainChat.Controls.Add(this.TextBoxMessage);
            this.TabPageMainChat.Name = "TabPageMainChat";
            this.TabPageMainChat.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.TabPageMainChat.Size = new System.Drawing.Size(477, 418);
            this.TabPageMainChat.Text = "Main Chat";
            // 
            // ImageShowEmoticons
            // 
            this.ImageShowEmoticons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageShowEmoticons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageShowEmoticons.EditValue = global::ModioX.Properties.Resources.smile_icon;
            this.ImageShowEmoticons.Location = new System.Drawing.Point(448, 389);
            this.ImageShowEmoticons.Name = "ImageShowEmoticons";
            this.ImageShowEmoticons.Properties.AllowFocused = false;
            this.ImageShowEmoticons.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ImageShowEmoticons.Properties.Appearance.Options.UseBackColor = true;
            this.ImageShowEmoticons.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageShowEmoticons.Properties.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageShowEmoticons.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageShowEmoticons.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ImageShowEmoticons.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ImageShowEmoticons.Properties.SvgImageSize = new System.Drawing.Size(24, 24);
            this.ImageShowEmoticons.Size = new System.Drawing.Size(21, 21);
            this.ImageShowEmoticons.TabIndex = 7;
            this.ImageShowEmoticons.Click += new System.EventHandler(this.ImageShowEmoticons_Click);
            // 
            // ImageListBox
            // 
            this.ImageListBox.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ImageListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageListBox.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ImageListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ImageListBox.Appearance.Options.UseBackColor = true;
            this.ImageListBox.Appearance.Options.UseFont = true;
            this.ImageListBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageListBox.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.ImageListBox.HtmlImages = this.ImageCollection;
            this.ImageListBox.ItemAutoHeight = true;
            this.ImageListBox.Location = new System.Drawing.Point(7, 330);
            this.ImageListBox.MultiColumn = true;
            this.ImageListBox.Name = "ImageListBox";
            this.ImageListBox.ShowFocusRect = false;
            this.ImageListBox.Size = new System.Drawing.Size(463, 51);
            this.ImageListBox.TabIndex = 6;
            this.ImageListBox.Visible = false;
            this.ImageListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageListBox_MouseDown);
            // 
            // ImageCollection
            // 
            this.ImageCollection.ImageSize = new System.Drawing.Size(18, 18);
            this.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection.ImageStream")));
            this.ImageCollection.Images.SetKeyName(0, "amazed.png");
            this.ImageCollection.Images.SetKeyName(1, "angel.png");
            this.ImageCollection.Images.SetKeyName(2, "angry.png");
            this.ImageCollection.Images.SetKeyName(3, "confused.png");
            this.ImageCollection.Images.SetKeyName(4, "cry_tear.png");
            this.ImageCollection.Images.SetKeyName(5, "flushed.png");
            this.ImageCollection.Images.SetKeyName(6, "grin.png");
            this.ImageCollection.Images.SetKeyName(7, "grinning.png");
            this.ImageCollection.Images.SetKeyName(8, "happy.png");
            this.ImageCollection.Images.SetKeyName(9, "heart.png");
            this.ImageCollection.Images.SetKeyName(10, "heart_break.png");
            this.ImageCollection.Images.SetKeyName(11, "joy.png");
            this.ImageCollection.Images.SetKeyName(12, "kiss_heart.png");
            this.ImageCollection.Images.SetKeyName(13, "neutral_face.png");
            this.ImageCollection.Images.SetKeyName(14, "no_mouth.png");
            this.ImageCollection.Images.SetKeyName(15, "open_mouth.png");
            this.ImageCollection.Images.SetKeyName(16, "sad_sweat.png");
            this.ImageCollection.Images.SetKeyName(17, "smile.png");
            this.ImageCollection.Images.SetKeyName(18, "sunglasses.png");
            this.ImageCollection.Images.SetKeyName(19, "thumbsup.png");
            this.ImageCollection.Images.SetKeyName(20, "tongue_out.png");
            this.ImageCollection.Images.SetKeyName(21, "weary.png");
            this.ImageCollection.Images.SetKeyName(22, "wink.png");
            this.ImageCollection.Images.SetKeyName(23, "wink_tongue.png");
            // 
            // ContainerMessages
            // 
            this.ContainerMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerMessages.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ContainerMessages.Appearance.Options.UseBackColor = true;
            this.ContainerMessages.Controls.Add(this.PanelMessages);
            this.ContainerMessages.Location = new System.Drawing.Point(6, 7);
            this.ContainerMessages.Name = "ContainerMessages";
            this.ContainerMessages.Size = new System.Drawing.Size(465, 375);
            this.ContainerMessages.TabIndex = 4;
            // 
            // PanelMessages
            // 
            this.PanelMessages.AlwaysScrollActiveControlIntoView = false;
            this.PanelMessages.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PanelMessages.Appearance.Options.UseBackColor = true;
            this.PanelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMessages.FireScrollEventOnMouseWheel = true;
            this.PanelMessages.Location = new System.Drawing.Point(2, 2);
            this.PanelMessages.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMessages.Name = "PanelMessages";
            this.PanelMessages.Size = new System.Drawing.Size(461, 371);
            this.PanelMessages.TabIndex = 3;
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMessage.Enabled = false;
            this.TextBoxMessage.Location = new System.Drawing.Point(6, 388);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Properties.AllowFocused = false;
            this.TextBoxMessage.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxMessage.Properties.Appearance.Options.UseFont = true;
            this.TextBoxMessage.Properties.AutoHeight = false;
            this.TextBoxMessage.Properties.HtmlImages = this.ImageCollection;
            this.TextBoxMessage.Properties.MaxLength = 280;
            this.TextBoxMessage.Properties.NullValuePrompt = "Send a message..";
            this.TextBoxMessage.Size = new System.Drawing.Size(436, 24);
            this.TextBoxMessage.TabIndex = 0;
            this.TextBoxMessage.Enter += new System.EventHandler(this.TextBoxMessage_Enter);
            this.TextBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMessage_KeyDown);
            // 
            // TabControlChats
            // 
            this.TabControlChats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlChats.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.TabControlChats.Location = new System.Drawing.Point(12, 12);
            this.TabControlChats.Name = "TabControlChats";
            this.TabControlChats.SelectedTabPage = this.TabPageMainChat;
            this.TabControlChats.Size = new System.Drawing.Size(479, 441);
            this.TabControlChats.TabIndex = 13;
            this.TabControlChats.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageMainChat});
            this.TabControlChats.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlChat_SelectedPageChanged);
            this.TabControlChats.CloseButtonClick += new System.EventHandler(this.TabControlChat_CloseButtonClick);
            // 
            // LabelOnlineUsers
            // 
            this.LabelOnlineUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelOnlineUsers.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelOnlineUsers.Appearance.Options.UseFont = true;
            this.LabelOnlineUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelOnlineUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelOnlineUsers.Location = new System.Drawing.Point(497, 12);
            this.LabelOnlineUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelOnlineUsers.Name = "LabelOnlineUsers";
            this.LabelOnlineUsers.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelOnlineUsers.Size = new System.Drawing.Size(94, 15);
            this.LabelOnlineUsers.TabIndex = 1158;
            this.LabelOnlineUsers.Text = "Online Users (0)";
            // 
            // ChatRoomWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(665, 491);
            this.Controls.Add(this.ListBoxUsers);
            this.Controls.Add(this.LabelOnlineUsers);
            this.Controls.Add(this.TabControlChats);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ChatRoomWindow.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(667, 523);
            this.Name = "ChatRoomWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatRoomWindow_FormClosing);
            this.Load += new System.EventHandler(this.ChatRoomWindow_Load);
            this.StyleChanged += new System.EventHandler(this.ChatRoomWindow_StyleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.TabPageMainChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowEmoticons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMessages)).EndInit();
            this.ContainerMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlChats)).EndInit();
            this.TabControlChats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn ColumnPackageName;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewImageColumn ColumnDownload;
        private BarDockControl barDockControlLeft;
        private BarManager BarManager;
        private Bar StatusBar;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlRight;
        private BarStaticItem LabelStatus;
        private BarStaticItem LabeHeaderStatus;
        private BarButtonItem MenuButtonUserMention;
        private BarButtonItem MenuButtonUserPrivateMessage;
        private DevExpress.XtraTab.XtraTabControl TabControlChats;
        private DevExpress.XtraTab.XtraTabPage TabPageMainChat;
        private TextEdit TextBoxMessage;
        private BarStaticItem LabelHeaderUserName;
        private BarStaticItem LabelUserName;
        private LabelControl LabelOnlineUsers;
        private XtraScrollableControl PanelMessages;
        private BarCheckItem MenuButtonUserIgnore;
        private PopupMenu PopupMenu;
        public PanelControl ContainerMessages;
        private ImageListBoxControl ImageListBox;
        private PictureEdit ImageShowEmoticons;
        public DevExpress.Utils.ImageCollection ImageCollection;
        private ListBoxControl ListBoxUsers;
    }
}