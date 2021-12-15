
namespace ModioX.Controls
{
    partial class PrivateChatItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxMessage = new DevExpress.XtraEditors.TextEdit();
            this.ContainerMessages = new DevExpress.XtraEditors.PanelControl();
            this.PanelMessages = new DevExpress.XtraEditors.XtraScrollableControl();
            this.ImageShowEmoticons = new DevExpress.XtraEditors.PictureEdit();
            this.ImageListBox = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMessages)).BeginInit();
            this.ContainerMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowEmoticons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMessage.Location = new System.Drawing.Point(6, 386);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Properties.AllowFocused = false;
            this.TextBoxMessage.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMessage.Properties.Appearance.Options.UseFont = true;
            this.TextBoxMessage.Properties.AutoHeight = false;
            this.TextBoxMessage.Properties.MaxLength = 280;
            this.TextBoxMessage.Properties.NullValuePrompt = "Send a message..";
            this.TextBoxMessage.Size = new System.Drawing.Size(424, 24);
            this.TextBoxMessage.TabIndex = 0;
            this.TextBoxMessage.Enter += new System.EventHandler(this.TextBoxMessage_Enter);
            this.TextBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMessage_KeyDown);
            // 
            // ContainerMessages
            // 
            this.ContainerMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerMessages.Controls.Add(this.PanelMessages);
            this.ContainerMessages.Location = new System.Drawing.Point(6, 7);
            this.ContainerMessages.Name = "ContainerMessages";
            this.ContainerMessages.Size = new System.Drawing.Size(453, 373);
            this.ContainerMessages.TabIndex = 5;
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
            this.PanelMessages.Size = new System.Drawing.Size(449, 369);
            this.PanelMessages.TabIndex = 3;
            // 
            // ImageShowEmoticons
            // 
            this.ImageShowEmoticons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageShowEmoticons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageShowEmoticons.EditValue = global::ModioX.Properties.Resources.smile_icon;
            this.ImageShowEmoticons.Location = new System.Drawing.Point(436, 387);
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
            this.ImageShowEmoticons.TabIndex = 8;
            this.ImageShowEmoticons.Click += new System.EventHandler(this.ImageShowEmoticons_Click);
            // 
            // ImageListBox
            // 
            this.ImageListBox.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ImageListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ImageListBox.Appearance.Options.UseFont = true;
            this.ImageListBox.ItemAutoHeight = true;
            this.ImageListBox.Location = new System.Drawing.Point(6, 329);
            this.ImageListBox.MultiColumn = true;
            this.ImageListBox.Name = "ImageListBox";
            this.ImageListBox.ShowFocusRect = false;
            this.ImageListBox.Size = new System.Drawing.Size(453, 51);
            this.ImageListBox.TabIndex = 9;
            this.ImageListBox.Visible = false;
            this.ImageListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageListBox_MouseDown);
            // 
            // PrivateChatItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ImageListBox);
            this.Controls.Add(this.ImageShowEmoticons);
            this.Controls.Add(this.ContainerMessages);
            this.Controls.Add(this.TextBoxMessage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PrivateChatItem";
            this.Size = new System.Drawing.Size(465, 416);
            this.Load += new System.EventHandler(this.PrivateChatItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMessages)).EndInit();
            this.ContainerMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowEmoticons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageListBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.TextEdit TextBoxMessage;
        public DevExpress.XtraEditors.XtraScrollableControl PanelMessages;
        public DevExpress.XtraEditors.PanelControl ContainerMessages;
        private DevExpress.XtraEditors.PictureEdit ImageShowEmoticons;
        private DevExpress.XtraEditors.ImageListBoxControl ImageListBox;
    }
}
