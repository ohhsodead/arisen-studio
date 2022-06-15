
namespace ArisenMods.Controls
{
    partial class NewsItem
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
            this.LabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelMessage = new DevExpress.XtraEditors.LabelControl();
            this.LabelTimeStamp = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTitle.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTitle.Location = new System.Drawing.Point(8, 7);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(411, 17);
            this.LabelTitle.TabIndex = 1168;
            this.LabelTitle.Text = "Title";
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
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(540, 15);
            this.LabelMessage.TabIndex = 1169;
            this.LabelMessage.Text = "Message";
            this.LabelMessage.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelMessage_HyperlinkClick);
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
            this.LabelTimeStamp.Location = new System.Drawing.Point(425, 7);
            this.LabelTimeStamp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTimeStamp.Name = "LabelTimeStamp";
            this.LabelTimeStamp.Size = new System.Drawing.Size(122, 15);
            this.LabelTimeStamp.TabIndex = 1171;
            this.LabelTimeStamp.Text = "Time Stamp";
            // 
            // NewsItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LabelTimeStamp);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelTitle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.Name = "NewsItem";
            this.Size = new System.Drawing.Size(554, 56);
            this.Load += new System.EventHandler(this.NewsItem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl LabelMessage;
        public DevExpress.XtraEditors.LabelControl LabelTitle;
        public DevExpress.XtraEditors.LabelControl LabelTimeStamp;
    }
}
