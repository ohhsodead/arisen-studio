
namespace ArisenStudio.Controls
{
    partial class CustomFileItem
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
            this.LabelHeaderLocalFile = new DevExpress.XtraEditors.LabelControl();
            this.LabelLastModified = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderLastModified = new DevExpress.XtraEditors.LabelControl();
            this.LabelSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelLocalFile = new DevExpress.XtraEditors.LabelControl();
            this.Separator = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageDownload = new DevExpress.XtraEditors.SvgImageBox();
            this.ImageInstall = new DevExpress.XtraEditors.SvgImageBox();
            this.ImageOpenFolder = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelLocalFile = new DevExpress.Utils.Layout.StackPanel();
            this.PanelInstalPath = new DevExpress.Utils.Layout.StackPanel();
            this.LabelHeaderInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelInstallPath = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOpenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLocalFile)).BeginInit();
            this.PanelLocalFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelInstalPath)).BeginInit();
            this.PanelInstalPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHeaderLocalFile
            // 
            this.LabelHeaderLocalFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderLocalFile.Appearance.Options.UseFont = true;
            this.LabelHeaderLocalFile.AutoEllipsis = true;
            this.LabelHeaderLocalFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLocalFile.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderLocalFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderLocalFile.Name = "LabelHeaderLocalFile";
            this.LabelHeaderLocalFile.Size = new System.Drawing.Size(62, 17);
            this.LabelHeaderLocalFile.TabIndex = 1190;
            this.LabelHeaderLocalFile.Text = "Local File:";
            // 
            // LabelLastModified
            // 
            this.LabelLastModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLastModified.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelLastModified.Appearance.Options.UseFont = true;
            this.LabelLastModified.Appearance.Options.UseTextOptions = true;
            this.LabelLastModified.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelLastModified.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelLastModified.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelLastModified.AutoEllipsis = true;
            this.LabelLastModified.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelLastModified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLastModified.Location = new System.Drawing.Point(464, 35);
            this.LabelLastModified.Name = "LabelLastModified";
            this.LabelLastModified.Size = new System.Drawing.Size(115, 15);
            this.LabelLastModified.TabIndex = 1195;
            this.LabelLastModified.Text = "30 Mar 2022";
            // 
            // LabelHeaderLastModified
            // 
            this.LabelHeaderLastModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderLastModified.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderLastModified.Appearance.Options.UseFont = true;
            this.LabelHeaderLastModified.Appearance.Options.UseTextOptions = true;
            this.LabelHeaderLastModified.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelHeaderLastModified.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelHeaderLastModified.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelHeaderLastModified.AutoEllipsis = true;
            this.LabelHeaderLastModified.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelHeaderLastModified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLastModified.Location = new System.Drawing.Point(464, 12);
            this.LabelHeaderLastModified.Name = "LabelHeaderLastModified";
            this.LabelHeaderLastModified.Size = new System.Drawing.Size(115, 17);
            this.LabelHeaderLastModified.TabIndex = 1194;
            this.LabelHeaderLastModified.Text = "Modified On";
            // 
            // LabelSize
            // 
            this.LabelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSize.Appearance.Options.UseFont = true;
            this.LabelSize.Appearance.Options.UseTextOptions = true;
            this.LabelSize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelSize.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelSize.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelSize.AutoEllipsis = true;
            this.LabelSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSize.Location = new System.Drawing.Point(585, 35);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(95, 15);
            this.LabelSize.TabIndex = 1197;
            this.LabelSize.Text = "1.0.0";
            // 
            // LabelHeaderSize
            // 
            this.LabelHeaderSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderSize.Appearance.Options.UseFont = true;
            this.LabelHeaderSize.Appearance.Options.UseTextOptions = true;
            this.LabelHeaderSize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelHeaderSize.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelHeaderSize.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelHeaderSize.AutoEllipsis = true;
            this.LabelHeaderSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelHeaderSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSize.Location = new System.Drawing.Point(585, 12);
            this.LabelHeaderSize.Name = "LabelHeaderSize";
            this.LabelHeaderSize.Size = new System.Drawing.Size(95, 17);
            this.LabelHeaderSize.TabIndex = 1196;
            this.LabelHeaderSize.Text = "Size";
            // 
            // LabelLocalFile
            // 
            this.LabelLocalFile.AllowHtmlString = true;
            this.LabelLocalFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelLocalFile.Appearance.Options.UseFont = true;
            this.LabelLocalFile.Appearance.Options.UseTextOptions = true;
            this.LabelLocalFile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelLocalFile.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelLocalFile.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelLocalFile.AutoEllipsis = true;
            this.LabelLocalFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLocalFile.Location = new System.Drawing.Point(68, 0);
            this.LabelLocalFile.MinimumSize = new System.Drawing.Size(380, 0);
            this.LabelLocalFile.Name = "LabelLocalFile";
            this.LabelLocalFile.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LabelLocalFile.Size = new System.Drawing.Size(380, 17);
            this.LabelLocalFile.TabIndex = 1198;
            this.LabelLocalFile.Text = "File Path";
            // 
            // Separator
            // 
            this.Separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator.LineAlignment = DevExpress.XtraEditors.Alignment.Near;
            this.Separator.LineColor = System.Drawing.SystemColors.WindowFrame;
            this.Separator.LineThickness = 2;
            this.Separator.Location = new System.Drawing.Point(0, 63);
            this.Separator.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Separator.Name = "Separator";
            this.Separator.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Separator.Size = new System.Drawing.Size(776, 1);
            this.Separator.TabIndex = 1199;
            // 
            // ImageDownload
            // 
            this.ImageDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDownload.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageDownload.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDownload.ContextButtonOptions.PanelCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDownload.ItemAppearance.Disabled.FillColor = System.Drawing.Color.Gray;
            this.ImageDownload.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Silver;
            this.ImageDownload.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.ImageDownload.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageDownload.Location = new System.Drawing.Point(716, 13);
            this.ImageDownload.Name = "ImageDownload";
            this.ImageDownload.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.ImageDownload.Size = new System.Drawing.Size(26, 26);
            this.ImageDownload.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageDownload.SvgImage = global::ArisenStudio.Properties.Resources.icons8_download_file;
            this.ImageDownload.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageDownload.TabIndex = 1200;
            this.ImageDownload.ToolTip = "Download Files";
            this.ImageDownload.Visible = false;
            this.ImageDownload.Click += new System.EventHandler(this.ImageDownload_Click);
            // 
            // ImageInstall
            // 
            this.ImageInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInstall.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageInstall.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstall.ContextButtonOptions.PanelCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstall.ItemAppearance.Disabled.FillColor = System.Drawing.Color.Gray;
            this.ImageInstall.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Silver;
            this.ImageInstall.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.ImageInstall.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageInstall.Location = new System.Drawing.Point(686, 13);
            this.ImageInstall.Name = "ImageInstall";
            this.ImageInstall.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.ImageInstall.Size = new System.Drawing.Size(26, 26);
            this.ImageInstall.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageInstall.SvgImage = global::ArisenStudio.Properties.Resources.icons8_install;
            this.ImageInstall.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageInstall.TabIndex = 1201;
            this.ImageInstall.ToolTip = "Install Files";
            this.ImageInstall.Visible = false;
            this.ImageInstall.Click += new System.EventHandler(this.ImageInstall_Click);
            // 
            // ImageOpenFolder
            // 
            this.ImageOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageOpenFolder.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageOpenFolder.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageOpenFolder.ContextButtonOptions.PanelCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageOpenFolder.ItemAppearance.Disabled.FillColor = System.Drawing.Color.Gray;
            this.ImageOpenFolder.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Silver;
            this.ImageOpenFolder.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.ImageOpenFolder.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageOpenFolder.Location = new System.Drawing.Point(746, 13);
            this.ImageOpenFolder.Name = "ImageOpenFolder";
            this.ImageOpenFolder.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.ImageOpenFolder.Size = new System.Drawing.Size(26, 26);
            this.ImageOpenFolder.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageOpenFolder.SvgImage = global::ArisenStudio.Properties.Resources.icons8_opened_folder;
            this.ImageOpenFolder.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageOpenFolder.TabIndex = 1205;
            this.ImageOpenFolder.ToolTip = "Open Folder";
            this.ImageOpenFolder.Click += new System.EventHandler(this.ImageCopyLink_Click);
            // 
            // PanelLocalFile
            // 
            this.PanelLocalFile.Controls.Add(this.LabelHeaderLocalFile);
            this.PanelLocalFile.Controls.Add(this.LabelLocalFile);
            this.PanelLocalFile.Location = new System.Drawing.Point(4, 11);
            this.PanelLocalFile.Name = "PanelLocalFile";
            this.PanelLocalFile.Size = new System.Drawing.Size(454, 17);
            this.PanelLocalFile.TabIndex = 1208;
            // 
            // PanelInstalPath
            // 
            this.PanelInstalPath.Controls.Add(this.LabelHeaderInstallPath);
            this.PanelInstalPath.Controls.Add(this.LabelInstallPath);
            this.PanelInstalPath.Location = new System.Drawing.Point(4, 33);
            this.PanelInstalPath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.PanelInstalPath.Name = "PanelInstalPath";
            this.PanelInstalPath.Size = new System.Drawing.Size(454, 17);
            this.PanelInstalPath.TabIndex = 1209;
            // 
            // LabelHeaderInstallPath
            // 
            this.LabelHeaderInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallPath.Appearance.Options.UseFont = true;
            this.LabelHeaderInstallPath.AutoEllipsis = true;
            this.LabelHeaderInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderInstallPath.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderInstallPath.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderInstallPath.Name = "LabelHeaderInstallPath";
            this.LabelHeaderInstallPath.Size = new System.Drawing.Size(74, 17);
            this.LabelHeaderInstallPath.TabIndex = 1190;
            this.LabelHeaderInstallPath.Text = "Install Path:";
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.AllowHtmlString = true;
            this.LabelInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelInstallPath.Appearance.Options.UseFont = true;
            this.LabelInstallPath.Appearance.Options.UseTextOptions = true;
            this.LabelInstallPath.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelInstallPath.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelInstallPath.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelInstallPath.AutoEllipsis = true;
            this.LabelInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstallPath.Location = new System.Drawing.Point(80, 0);
            this.LabelInstallPath.MaximumSize = new System.Drawing.Size(380, 0);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.LabelInstallPath.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LabelInstallPath.Size = new System.Drawing.Size(45, 17);
            this.LabelInstallPath.TabIndex = 1198;
            this.LabelInstallPath.Text = "File Path";
            // 
            // CustomFileItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ImageOpenFolder);
            this.Controls.Add(this.ImageInstall);
            this.Controls.Add(this.PanelInstalPath);
            this.Controls.Add(this.ImageDownload);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.LabelHeaderSize);
            this.Controls.Add(this.LabelLastModified);
            this.Controls.Add(this.LabelHeaderLastModified);
            this.Controls.Add(this.PanelLocalFile);
            this.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.Name = "CustomFileItem";
            this.Size = new System.Drawing.Size(776, 64);
            this.Load += new System.EventHandler(this.CustomFileItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOpenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLocalFile)).EndInit();
            this.PanelLocalFile.ResumeLayout(false);
            this.PanelLocalFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelInstalPath)).EndInit();
            this.PanelInstalPath.ResumeLayout(false);
            this.PanelInstalPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LabelHeaderLocalFile;
        private DevExpress.XtraEditors.LabelControl LabelLastModified;
        private DevExpress.XtraEditors.LabelControl LabelHeaderLastModified;
        private DevExpress.XtraEditors.LabelControl LabelSize;
        private DevExpress.XtraEditors.LabelControl LabelHeaderSize;
        private DevExpress.XtraEditors.LabelControl LabelLocalFile;
        private DevExpress.XtraEditors.SeparatorControl Separator;
        private DevExpress.XtraEditors.SvgImageBox ImageDownload;
        private DevExpress.XtraEditors.SvgImageBox ImageInstall;
        private DevExpress.XtraEditors.SvgImageBox ImageOpenFolder;
        private DevExpress.Utils.Layout.StackPanel PanelLocalFile;
        private DevExpress.Utils.Layout.StackPanel PanelInstalPath;
        private DevExpress.XtraEditors.LabelControl LabelHeaderInstallPath;
        private DevExpress.XtraEditors.LabelControl LabelInstallPath;
    }
}
