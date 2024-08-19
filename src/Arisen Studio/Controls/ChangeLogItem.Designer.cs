
namespace ArisenStudio.Controls
{
    partial class ChangeLogItem
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
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelChangeLog = new DevExpress.XtraEditors.LabelControl();
            this.LabelTimeStamp = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelVersion.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelVersion.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelVersion.Location = new System.Drawing.Point(13, 13);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(253, 17);
            this.LabelVersion.TabIndex = 1168;
            this.LabelVersion.Text = "Version 1.0";
            // 
            // LabelChangeLog
            // 
            this.LabelChangeLog.AllowHtmlString = true;
            this.LabelChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelChangeLog.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelChangeLog.Appearance.Options.UseFont = true;
            this.LabelChangeLog.Appearance.Options.UseTextOptions = true;
            this.LabelChangeLog.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelChangeLog.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelChangeLog.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelChangeLog.Location = new System.Drawing.Point(13, 40);
            this.LabelChangeLog.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.LabelChangeLog.Name = "LabelChangeLog";
            this.LabelChangeLog.Size = new System.Drawing.Size(366, 17);
            this.LabelChangeLog.TabIndex = 1169;
            this.LabelChangeLog.Text = "• Change Log";
            this.LabelChangeLog.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelMessage_HyperlinkClick);
            // 
            // LabelTimeStamp
            // 
            this.LabelTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTimeStamp.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelTimeStamp.Appearance.Options.UseFont = true;
            this.LabelTimeStamp.Appearance.Options.UseTextOptions = true;
            this.LabelTimeStamp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelTimeStamp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTimeStamp.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTimeStamp.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTimeStamp.Location = new System.Drawing.Point(272, 13);
            this.LabelTimeStamp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTimeStamp.Name = "LabelTimeStamp";
            this.LabelTimeStamp.Size = new System.Drawing.Size(95, 18);
            this.LabelTimeStamp.TabIndex = 1171;
            this.LabelTimeStamp.Text = "Time Stamp";
            // 
            // ChangeLogItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LabelTimeStamp);
            this.Controls.Add(this.LabelChangeLog);
            this.Controls.Add(this.LabelVersion);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.Name = "ChangeLogItem";
            this.Size = new System.Drawing.Size(380, 71);
            this.Load += new System.EventHandler(this.ChangeLogItem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl LabelChangeLog;
        public DevExpress.XtraEditors.LabelControl LabelVersion;
        public DevExpress.XtraEditors.LabelControl LabelTimeStamp;
    }
}
