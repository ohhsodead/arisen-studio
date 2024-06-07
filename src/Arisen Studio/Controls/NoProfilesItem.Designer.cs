
namespace ArisenStudio.Controls
{
    partial class NoProfilesItem
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
            this.components = new System.ComponentModel.Container();
            this.LabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.ImageIcon = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.LabelSubTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Appearance.Options.UseBackColor = true;
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.Appearance.Options.UseTextOptions = true;
            this.LabelTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTitle.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTitle.Location = new System.Drawing.Point(32, 149);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(250, 20);
            this.LabelTitle.TabIndex = 1168;
            this.LabelTitle.Text = "NO CONSOLE PROFILES";
            // 
            // ImageIcon
            // 
            this.ImageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageIcon.EditValue = global::ArisenStudio.Properties.Resources.icons8_no_profile;
            this.ImageIcon.Location = new System.Drawing.Point(102, 27);
            this.ImageIcon.Name = "ImageIcon";
            this.ImageIcon.Properties.AllowFocused = false;
            this.ImageIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ImageIcon.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageIcon.Properties.Appearance.Options.UseBackColor = true;
            this.ImageIcon.Properties.Appearance.Options.UseForeColor = true;
            this.ImageIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageIcon.Properties.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageIcon.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageIcon.Size = new System.Drawing.Size(110, 110);
            this.ImageIcon.TabIndex = 1169;
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSubTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelSubTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.LabelSubTitle.Appearance.Options.UseBackColor = true;
            this.LabelSubTitle.Appearance.Options.UseFont = true;
            this.LabelSubTitle.Appearance.Options.UseTextOptions = true;
            this.LabelSubTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelSubTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelSubTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelSubTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelSubTitle.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelSubTitle.Location = new System.Drawing.Point(0, 173);
            this.LabelSubTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(315, 19);
            this.LabelSubTitle.TabIndex = 1170;
            this.LabelSubTitle.Text = "Click \'Add New Console\' to create a profile";
            // 
            // NoProfilesItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LabelSubTitle);
            this.Controls.Add(this.ImageIcon);
            this.Controls.Add(this.LabelTitle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "NoProfilesItem";
            this.Size = new System.Drawing.Size(315, 250);
            this.Load += new System.EventHandler(this.NoConsolesItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl LabelTitle;
        private DevExpress.XtraEditors.PictureEdit ImageIcon;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        public DevExpress.XtraEditors.LabelControl LabelSubTitle;
    }
}
