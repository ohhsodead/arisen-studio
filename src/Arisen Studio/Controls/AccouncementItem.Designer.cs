
namespace ArisenStudio.Controls
{
    partial class AccouncementItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccouncementItem));
            this.LabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelMessage = new DevExpress.XtraEditors.LabelControl();
            this.LabelTimeStamp = new DevExpress.XtraEditors.LabelControl();
            this.ImageDismiss = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDismiss)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTitle.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTitle.Location = new System.Drawing.Point(8, 6);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(414, 17);
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
            this.LabelTimeStamp.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTimeStamp.Appearance.Options.UseFont = true;
            this.LabelTimeStamp.Appearance.Options.UseTextOptions = true;
            this.LabelTimeStamp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelTimeStamp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTimeStamp.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTimeStamp.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTimeStamp.Location = new System.Drawing.Point(430, 6);
            this.LabelTimeStamp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTimeStamp.Name = "LabelTimeStamp";
            this.LabelTimeStamp.Size = new System.Drawing.Size(95, 15);
            this.LabelTimeStamp.TabIndex = 1171;
            this.LabelTimeStamp.Text = "Time Stamp";
            // 
            // ImageDismiss
            // 
            this.ImageDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDismiss.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageDismiss.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDismiss.ContextButtonOptions.PanelCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDismiss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDismiss.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.ImageDismiss.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ImageDismiss.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageDismiss.Location = new System.Drawing.Point(530, 3);
            this.ImageDismiss.Name = "ImageDismiss";
            this.ImageDismiss.ShowToolTips = DevExpress.Utils.DefaultBoolean.False;
            this.ImageDismiss.Size = new System.Drawing.Size(20, 20);
            this.ImageDismiss.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageDismiss.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageDismiss.SvgImage")));
            this.ImageDismiss.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ImageDismiss.TabIndex = 1172;
            this.ImageDismiss.Text = "Dismiss";
            this.ImageDismiss.Click += new System.EventHandler(this.ImageDismiss_Click);
            // 
            // AccouncementItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ImageDismiss);
            this.Controls.Add(this.LabelTimeStamp);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelTitle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.Name = "AccouncementItem";
            this.Size = new System.Drawing.Size(554, 56);
            this.Load += new System.EventHandler(this.AccouncementItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageDismiss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl LabelMessage;
        public DevExpress.XtraEditors.LabelControl LabelTitle;
        public DevExpress.XtraEditors.LabelControl LabelTimeStamp;
        private DevExpress.XtraEditors.SvgImageBox ImageDismiss;
    }
}
