
namespace ModioX.Controls
{
    partial class ChatSystemMessageItem
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
            this.LabelMessage = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorLine = new DevExpress.XtraEditors.SeparatorControl();
            this.LabelTimeStamp = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorLine)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMessage
            // 
            this.LabelMessage.AllowHtmlString = true;
            this.LabelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMessage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelMessage.Appearance.Options.UseFont = true;
            this.LabelMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelMessage.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelMessage.Location = new System.Drawing.Point(8, 7);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(365, 15);
            this.LabelMessage.TabIndex = 1168;
            this.LabelMessage.Text = "Message";
            this.LabelMessage.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelMessage_HyperlinkClick);
            // 
            // SeparatorLine
            // 
            this.SeparatorLine.AutoSizeMode = true;
            this.SeparatorLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorLine.LineAlignment = DevExpress.XtraEditors.Alignment.Near;
            this.SeparatorLine.Location = new System.Drawing.Point(0, 31);
            this.SeparatorLine.Name = "SeparatorLine";
            this.SeparatorLine.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SeparatorLine.Size = new System.Drawing.Size(450, 1);
            this.SeparatorLine.TabIndex = 1170;
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
            // ChatSystemMessageItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LabelTimeStamp);
            this.Controls.Add(this.SeparatorLine);
            this.Controls.Add(this.LabelMessage);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "ChatSystemMessageItem";
            this.Size = new System.Drawing.Size(450, 32);
            this.Load += new System.EventHandler(this.ChatSystemMessageItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl LabelMessage;
        public DevExpress.XtraEditors.LabelControl LabelTimeStamp;
        public DevExpress.XtraEditors.SeparatorControl SeparatorLine;
    }
}
