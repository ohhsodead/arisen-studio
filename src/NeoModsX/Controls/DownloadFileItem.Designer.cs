
namespace NeoModsX.Controls
{
    partial class DownloadFileItem
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
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelLastUpdated = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderLastUpdated = new DevExpress.XtraEditors.LabelControl();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelFilesCount = new DevExpress.XtraEditors.LabelControl();
            this.Separator = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageDownload = new DevExpress.XtraEditors.SvgImageBox();
            this.ImageInstall = new DevExpress.XtraEditors.SvgImageBox();
            this.ListBoxInstallFiles = new DevExpress.XtraEditors.ListBoxControl();
            this.LabelInstallationFiles = new DevExpress.XtraEditors.LabelControl();
            this.SvgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.ImageExpand = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxInstallFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageExpand.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.AutoEllipsis = true;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(12, 11);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 1, 3, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(36, 17);
            this.LabelName.TabIndex = 1190;
            this.LabelName.Text = "Name";
            // 
            // LabelHeaderRegion
            // 
            this.LabelHeaderRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderRegion.Appearance.Options.UseFont = true;
            this.LabelHeaderRegion.Appearance.Options.UseTextOptions = true;
            this.LabelHeaderRegion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelHeaderRegion.AutoEllipsis = true;
            this.LabelHeaderRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderRegion.Location = new System.Drawing.Point(551, 12);
            this.LabelHeaderRegion.Name = "LabelHeaderRegion";
            this.LabelHeaderRegion.Size = new System.Drawing.Size(39, 15);
            this.LabelHeaderRegion.TabIndex = 1188;
            this.LabelHeaderRegion.Text = "Region";
            // 
            // LabelRegion
            // 
            this.LabelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelRegion.Appearance.Options.UseFont = true;
            this.LabelRegion.Appearance.Options.UseTextOptions = true;
            this.LabelRegion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelRegion.AutoEllipsis = true;
            this.LabelRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRegion.Location = new System.Drawing.Point(551, 33);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(62, 15);
            this.LabelRegion.TabIndex = 1193;
            this.LabelRegion.Text = "BLES/BLUS";
            // 
            // LabelLastUpdated
            // 
            this.LabelLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLastUpdated.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelLastUpdated.Appearance.Options.UseFont = true;
            this.LabelLastUpdated.Appearance.Options.UseTextOptions = true;
            this.LabelLastUpdated.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelLastUpdated.AutoEllipsis = true;
            this.LabelLastUpdated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLastUpdated.Location = new System.Drawing.Point(432, 33);
            this.LabelLastUpdated.Name = "LabelLastUpdated";
            this.LabelLastUpdated.Size = new System.Drawing.Size(70, 15);
            this.LabelLastUpdated.TabIndex = 1195;
            this.LabelLastUpdated.Text = "30 Mar 2022";
            // 
            // LabelHeaderLastUpdated
            // 
            this.LabelHeaderLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderLastUpdated.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderLastUpdated.Appearance.Options.UseFont = true;
            this.LabelHeaderLastUpdated.Appearance.Options.UseTextOptions = true;
            this.LabelHeaderLastUpdated.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelHeaderLastUpdated.AutoEllipsis = true;
            this.LabelHeaderLastUpdated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLastUpdated.Location = new System.Drawing.Point(432, 12);
            this.LabelHeaderLastUpdated.Name = "LabelHeaderLastUpdated";
            this.LabelHeaderLastUpdated.Size = new System.Drawing.Size(73, 15);
            this.LabelHeaderLastUpdated.TabIndex = 1194;
            this.LabelHeaderLastUpdated.Text = "Last Updated";
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.Appearance.Options.UseTextOptions = true;
            this.LabelVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelVersion.AutoEllipsis = true;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(651, 33);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(27, 15);
            this.LabelVersion.TabIndex = 1197;
            this.LabelVersion.Text = "1.0.0";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderVersion.Appearance.Options.UseTextOptions = true;
            this.LabelHeaderVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelHeaderVersion.AutoEllipsis = true;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(651, 12);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(42, 15);
            this.LabelHeaderVersion.TabIndex = 1196;
            this.LabelHeaderVersion.Text = "Version";
            // 
            // LabelFilesCount
            // 
            this.LabelFilesCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFilesCount.Appearance.Options.UseFont = true;
            this.LabelFilesCount.Appearance.Options.UseTextOptions = true;
            this.LabelFilesCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelFilesCount.AutoEllipsis = true;
            this.LabelFilesCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFilesCount.Location = new System.Drawing.Point(12, 34);
            this.LabelFilesCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.LabelFilesCount.Name = "LabelFilesCount";
            this.LabelFilesCount.Size = new System.Drawing.Size(32, 15);
            this.LabelFilesCount.TabIndex = 1198;
            this.LabelFilesCount.Text = "0 Files";
            // 
            // Separator
            // 
            this.Separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.Separator.LineColor = System.Drawing.SystemColors.WindowFrame;
            this.Separator.Location = new System.Drawing.Point(0, 104);
            this.Separator.Name = "Separator";
            this.Separator.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.Separator.Size = new System.Drawing.Size(817, 10);
            this.Separator.TabIndex = 1199;
            // 
            // ImageDownload
            // 
            this.ImageDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDownload.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageDownload.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDownload.ContextButtonOptions.PanelCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDownload.Location = new System.Drawing.Point(751, 18);
            this.ImageDownload.Name = "ImageDownload";
            this.ImageDownload.ShowToolTips = DevExpress.Utils.DefaultBoolean.False;
            this.ImageDownload.Size = new System.Drawing.Size(24, 24);
            this.ImageDownload.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageDownload.SvgImage = global::NeoModsX.Properties.Resources.download_svg;
            this.ImageDownload.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageDownload.TabIndex = 1200;
            this.ImageDownload.Click += new System.EventHandler(this.ImageDownload_Click);
            // 
            // ImageInstall
            // 
            this.ImageInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInstall.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageInstall.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstall.ContextButtonOptions.PanelCursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstall.Location = new System.Drawing.Point(721, 18);
            this.ImageInstall.Name = "ImageInstall";
            this.ImageInstall.ShowToolTips = DevExpress.Utils.DefaultBoolean.False;
            this.ImageInstall.Size = new System.Drawing.Size(24, 24);
            this.ImageInstall.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageInstall.SvgImage = global::NeoModsX.Properties.Resources.install_svg;
            this.ImageInstall.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageInstall.TabIndex = 1201;
            this.ImageInstall.Click += new System.EventHandler(this.ImageInstall_Click);
            // 
            // ListBoxInstallFiles
            // 
            this.ListBoxInstallFiles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ListBoxInstallFiles.Appearance.Options.UseFont = true;
            this.ListBoxInstallFiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ListBoxInstallFiles.Location = new System.Drawing.Point(8, 82);
            this.ListBoxInstallFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.ListBoxInstallFiles.Name = "ListBoxInstallFiles";
            this.ListBoxInstallFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListBoxInstallFiles.ShowFocusRect = false;
            this.ListBoxInstallFiles.Size = new System.Drawing.Size(734, 18);
            this.ListBoxInstallFiles.TabIndex = 1202;
            this.ListBoxInstallFiles.Visible = false;
            this.ListBoxInstallFiles.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.ListBoxInstallFiles_DrawItem);
            // 
            // LabelInstallationFiles
            // 
            this.LabelInstallationFiles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelInstallationFiles.Appearance.Options.UseFont = true;
            this.LabelInstallationFiles.AutoEllipsis = true;
            this.LabelInstallationFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstallationFiles.Location = new System.Drawing.Point(12, 59);
            this.LabelInstallationFiles.Margin = new System.Windows.Forms.Padding(0, 1, 3, 3);
            this.LabelInstallationFiles.Name = "LabelInstallationFiles";
            this.LabelInstallationFiles.Size = new System.Drawing.Size(102, 17);
            this.LabelInstallationFiles.TabIndex = 1203;
            this.LabelInstallationFiles.Text = "Installation Files";
            this.LabelInstallationFiles.Visible = false;
            // 
            // SvgImages
            // 
            this.SvgImages.ImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.SvgImages.Add("arrow_down", "arrow_down", typeof(NeoModsX.Properties.Resources));
            this.SvgImages.Add("arrow_up", "arrow_up", typeof(NeoModsX.Properties.Resources));
            // 
            // ImageExpand
            // 
            this.ImageExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageExpand.EditValue = global::NeoModsX.Properties.Resources.arrow_down;
            this.ImageExpand.Location = new System.Drawing.Point(781, 18);
            this.ImageExpand.Name = "ImageExpand";
            this.ImageExpand.Properties.AllowFocused = false;
            this.ImageExpand.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ImageExpand.Properties.Appearance.Options.UseBackColor = true;
            this.ImageExpand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageExpand.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageExpand.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageExpand.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageExpand.Size = new System.Drawing.Size(24, 24);
            this.ImageExpand.TabIndex = 1204;
            this.ImageExpand.Click += new System.EventHandler(this.ImageExpand_Click);
            // 
            // DownloadFileItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ImageExpand);
            this.Controls.Add(this.LabelInstallationFiles);
            this.Controls.Add(this.ListBoxInstallFiles);
            this.Controls.Add(this.ImageInstall);
            this.Controls.Add(this.ImageDownload);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.LabelFilesCount);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelHeaderVersion);
            this.Controls.Add(this.LabelLastUpdated);
            this.Controls.Add(this.LabelHeaderLastUpdated);
            this.Controls.Add(this.LabelRegion);
            this.Controls.Add(this.LabelHeaderRegion);
            this.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.Name = "DownloadFileItem";
            this.Size = new System.Drawing.Size(817, 114);
            this.Load += new System.EventHandler(this.DownloadItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxInstallFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageExpand.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LabelHeaderRegion;
        private DevExpress.XtraEditors.LabelControl LabelName;
        private DevExpress.XtraEditors.LabelControl LabelRegion;
        private DevExpress.XtraEditors.LabelControl LabelLastUpdated;
        private DevExpress.XtraEditors.LabelControl LabelHeaderLastUpdated;
        private DevExpress.XtraEditors.LabelControl LabelVersion;
        private DevExpress.XtraEditors.LabelControl LabelHeaderVersion;
        private DevExpress.XtraEditors.LabelControl LabelFilesCount;
        private DevExpress.XtraEditors.SeparatorControl Separator;
        private DevExpress.XtraEditors.SvgImageBox ImageDownload;
        private DevExpress.XtraEditors.SvgImageBox ImageInstall;
        private DevExpress.XtraEditors.ListBoxControl ListBoxInstallFiles;
        private DevExpress.XtraEditors.LabelControl LabelInstallationFiles;
        private DevExpress.Utils.SvgImageCollection SvgImages;
        private DevExpress.XtraEditors.PictureEdit ImageExpand;
    }
}
