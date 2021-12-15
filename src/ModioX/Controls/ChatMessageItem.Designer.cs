
namespace ModioX.Controls
{
    partial class ChatMessageItem
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
            this.LabelUserName = new DevExpress.XtraEditors.LabelControl();
            this.LabelMessage = new DevExpress.XtraEditors.LabelControl();
            this.Separator = new DevExpress.XtraEditors.SeparatorControl();
            this.LabelTimeStamp = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUserName
            // 
            this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUserName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelUserName.Appearance.Options.UseFont = true;
            this.LabelUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelUserName.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelUserName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelUserName.Location = new System.Drawing.Point(8, 7);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(365, 17);
            this.LabelUserName.TabIndex = 1168;
            this.LabelUserName.Text = "User Name";
            // 
            // LabelMessage
            // 
            this.LabelMessage.AllowHtmlString = true;
            this.LabelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMessage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelMessage.Appearance.Options.UseFont = true;
            this.LabelMessage.Appearance.Options.UseTextOptions = true;
            this.LabelMessage.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelMessage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelMessage.Location = new System.Drawing.Point(8, 31);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(435, 15);
            this.LabelMessage.TabIndex = 1169;
            this.LabelMessage.Text = "Message";
            // 
            // Separator
            // 
            this.Separator.AutoSizeMode = true;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator.LineAlignment = DevExpress.XtraEditors.Alignment.Near;
            this.Separator.Location = new System.Drawing.Point(0, 57);
            this.Separator.Name = "Separator";
            this.Separator.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Separator.Size = new System.Drawing.Size(450, 1);
            this.Separator.TabIndex = 1170;
            // 
            // LabelTimeStamp
            // 
            this.LabelTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTimeStamp.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelTimeStamp.Appearance.Options.UseFont = true;
            this.LabelTimeStamp.Appearance.Options.UseTextOptions = true;
            this.LabelTimeStamp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelTimeStamp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTimeStamp.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTimeStamp.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTimeStamp.Location = new System.Drawing.Point(371, 7);
            this.LabelTimeStamp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTimeStamp.Name = "LabelTimeStamp";
            this.LabelTimeStamp.Size = new System.Drawing.Size(70, 15);
            this.LabelTimeStamp.TabIndex = 1171;
            this.LabelTimeStamp.Text = "Time Stamp";
            // 
            // ChatMessageItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LabelTimeStamp);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelUserName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "ChatMessageItem";
            this.Size = new System.Drawing.Size(450, 58);
            this.Load += new System.EventHandler(this.ChatMessageItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl LabelMessage;
        public DevExpress.XtraEditors.LabelControl LabelUserName;
        private DevExpress.XtraEditors.SeparatorControl Separator;
        public DevExpress.XtraEditors.LabelControl LabelTimeStamp;
    }
}
