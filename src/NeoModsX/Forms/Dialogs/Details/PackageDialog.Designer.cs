using System.ComponentModel;
using DevExpress.XtraEditors;

namespace NeoModsX.Forms.Dialogs.Details
{
    partial class PackageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageDialog));
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.PanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPackages = new DevExpress.XtraEditors.LabelControl();
            this.LabelSlash = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageCloseDetails = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFaq = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.LabelHeaderContentId = new DevExpress.XtraEditors.LabelControl();
            this.LabelContentId = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSha256 = new DevExpress.XtraEditors.LabelControl();
            this.LabelSha256 = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.LabelModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTitleId = new DevExpress.XtraEditors.LabelControl();
            this.LabelTitleID = new DevExpress.XtraEditors.LabelControl();
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.PanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.PanelTitle);
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageCloseDetails);
            this.PanelHeader.Controls.Add(this.LabelName);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 80);
            this.PanelHeader.TabIndex = 1191;
            // 
            // PanelTitle
            // 
            this.PanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitle.Controls.Add(this.LabelPackages);
            this.PanelTitle.Controls.Add(this.LabelSlash);
            this.PanelTitle.Controls.Add(this.LabelCategory);
            this.PanelTitle.Controls.Add(this.LabelRegion);
            this.PanelTitle.Location = new System.Drawing.Point(16, 12);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(744, 22);
            this.PanelTitle.TabIndex = 1191;
            this.PanelTitle.WrapContents = false;
            // 
            // LabelPackages
            // 
            this.LabelPackages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPackages.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelPackages.Appearance.Options.UseFont = true;
            this.LabelPackages.AutoEllipsis = true;
            this.LabelPackages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPackages.Location = new System.Drawing.Point(0, 1);
            this.LabelPackages.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelPackages.Name = "LabelPackages";
            this.LabelPackages.Size = new System.Drawing.Size(56, 17);
            this.LabelPackages.TabIndex = 1190;
            this.LabelPackages.Text = "Packages";
            // 
            // LabelSlash
            // 
            this.LabelSlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSlash.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelSlash.Appearance.Options.UseFont = true;
            this.LabelSlash.AutoEllipsis = true;
            this.LabelSlash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSlash.Location = new System.Drawing.Point(62, 1);
            this.LabelSlash.Margin = new System.Windows.Forms.Padding(3, 1, 3, 10);
            this.LabelSlash.Name = "LabelSlash";
            this.LabelSlash.Size = new System.Drawing.Size(7, 17);
            this.LabelSlash.TabIndex = 1189;
            this.LabelSlash.Text = "/";
            // 
            // LabelCategory
            // 
            this.LabelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.AutoEllipsis = true;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(75, 1);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 10);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(55, 17);
            this.LabelCategory.TabIndex = 1184;
            this.LabelCategory.Text = "Category";
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
            this.LabelRegion.Location = new System.Drawing.Point(136, 3);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(69, 15);
            this.LabelRegion.TabIndex = 1188;
            this.LabelRegion.Text = "(All Regions)";
            // 
            // SeparatorHeader
            // 
            this.SeparatorHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorHeader.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHeader.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorHeader.Location = new System.Drawing.Point(0, 70);
            this.SeparatorHeader.Name = "SeparatorHeader";
            this.SeparatorHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.SeparatorHeader.Size = new System.Drawing.Size(800, 10);
            this.SeparatorHeader.TabIndex = 1185;
            // 
            // ImageCloseDetails
            // 
            this.ImageCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageCloseDetails.Location = new System.Drawing.Point(764, 10);
            this.ImageCloseDetails.Name = "ImageCloseDetails";
            this.ImageCloseDetails.Size = new System.Drawing.Size(26, 26);
            this.ImageCloseDetails.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageCloseDetails.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageCloseDetails.SvgImage")));
            this.ImageCloseDetails.TabIndex = 1171;
            this.ImageCloseDetails.Text = "Close";
            this.ImageCloseDetails.Click += new System.EventHandler(this.ImageCloseDetails_Click);
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(16, 42);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(776, 20);
            this.LabelName.TabIndex = 1191;
            this.LabelName.Text = "Name";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonInstall);
            this.PanelActions.Controls.Add(this.ButtonDownload);
            this.PanelActions.Controls.Add(this.ButtonFaq);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 169);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(800, 50);
            this.PanelActions.TabIndex = 1175;
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonInstall.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonInstall.Appearance.Options.UseFont = true;
            this.ButtonInstall.Appearance.Options.UseForeColor = true;
            this.ButtonInstall.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonInstall.ImageOptions.Image = global::NeoModsX.Properties.Resources.install;
            this.ButtonInstall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInstall.ImageOptions.ImageToTextIndent = 6;
            this.ButtonInstall.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInstall.ImageOptions.SvgImage = global::NeoModsX.Properties.Resources.install_svg;
            this.ButtonInstall.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonInstall.Location = new System.Drawing.Point(12, 12);
            this.ButtonInstall.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstall.Size = new System.Drawing.Size(100, 26);
            this.ButtonInstall.TabIndex = 1181;
            this.ButtonInstall.Text = "Install File";
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDownload.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonDownload.Appearance.Options.UseFont = true;
            this.ButtonDownload.Appearance.Options.UseForeColor = true;
            this.ButtonDownload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDownload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDownload.ImageOptions.ImageToTextIndent = 6;
            this.ButtonDownload.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDownload.ImageOptions.SvgImage = global::NeoModsX.Properties.Resources.download_svg;
            this.ButtonDownload.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonDownload.Location = new System.Drawing.Point(118, 12);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownload.Size = new System.Drawing.Size(123, 26);
            this.ButtonDownload.TabIndex = 1179;
            this.ButtonDownload.Text = "Download File";
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonFaq
            // 
            this.ButtonFaq.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonFaq.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonFaq.Appearance.Options.UseFont = true;
            this.ButtonFaq.Appearance.Options.UseForeColor = true;
            this.ButtonFaq.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFaq.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFaq.ImageOptions.ImageToTextIndent = 6;
            this.ButtonFaq.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFaq.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFaq.ImageOptions.SvgImage")));
            this.ButtonFaq.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFaq.Location = new System.Drawing.Point(247, 12);
            this.ButtonFaq.Name = "ButtonFaq";
            this.ButtonFaq.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFaq.Size = new System.Drawing.Size(72, 26);
            this.ButtonFaq.TabIndex = 1180;
            this.ButtonFaq.Text = "FAQ";
            this.ButtonFaq.Click += new System.EventHandler(this.ButtonFaq_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // LabelHeaderContentId
            // 
            this.LabelHeaderContentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderContentId.Appearance.Options.UseFont = true;
            this.LabelHeaderContentId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderContentId.Location = new System.Drawing.Point(403, 20);
            this.LabelHeaderContentId.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderContentId.Name = "LabelHeaderContentId";
            this.LabelHeaderContentId.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderContentId.TabIndex = 1200;
            this.LabelHeaderContentId.Text = "Content ID";
            // 
            // LabelContentId
            // 
            this.LabelContentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelContentId.Appearance.Options.UseFont = true;
            this.LabelContentId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelContentId.Location = new System.Drawing.Point(403, 43);
            this.LabelContentId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelContentId.Name = "LabelContentId";
            this.LabelContentId.Size = new System.Drawing.Size(9, 15);
            this.LabelContentId.TabIndex = 1201;
            this.LabelContentId.Text = "...";
            // 
            // LabelHeaderFileSize
            // 
            this.LabelHeaderFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileSize.Appearance.Options.UseFont = true;
            this.LabelHeaderFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileSize.Location = new System.Drawing.Point(164, 20);
            this.LabelHeaderFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderFileSize.Name = "LabelHeaderFileSize";
            this.LabelHeaderFileSize.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderFileSize.TabIndex = 1192;
            this.LabelHeaderFileSize.Text = "File Size";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.Appearance.Options.UseFont = true;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(164, 43);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(9, 15);
            this.LabelFileSize.TabIndex = 1195;
            this.LabelFileSize.Text = "...";
            // 
            // LabelHeaderSha256
            // 
            this.LabelHeaderSha256.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderSha256.Appearance.Options.UseFont = true;
            this.LabelHeaderSha256.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSha256.Location = new System.Drawing.Point(643, 20);
            this.LabelHeaderSha256.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderSha256.Name = "LabelHeaderSha256";
            this.LabelHeaderSha256.Size = new System.Drawing.Size(50, 15);
            this.LabelHeaderSha256.TabIndex = 1202;
            this.LabelHeaderSha256.Text = "SHA-256";
            // 
            // LabelSha256
            // 
            this.LabelSha256.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSha256.Appearance.Options.UseFont = true;
            this.LabelSha256.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSha256.Location = new System.Drawing.Point(643, 43);
            this.LabelSha256.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelSha256.Name = "LabelSha256";
            this.LabelSha256.Size = new System.Drawing.Size(9, 15);
            this.LabelSha256.TabIndex = 1203;
            this.LabelSha256.Text = "...";
            // 
            // LabelHeaderModifiedDate
            // 
            this.LabelHeaderModifiedDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderModifiedDate.Appearance.Options.UseFont = true;
            this.LabelHeaderModifiedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModifiedDate.Location = new System.Drawing.Point(20, 20);
            this.LabelHeaderModifiedDate.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderModifiedDate.Name = "LabelHeaderModifiedDate";
            this.LabelHeaderModifiedDate.Size = new System.Drawing.Size(80, 15);
            this.LabelHeaderModifiedDate.TabIndex = 1204;
            this.LabelHeaderModifiedDate.Text = "Modified Date";
            // 
            // LabelModifiedDate
            // 
            this.LabelModifiedDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModifiedDate.Appearance.Options.UseFont = true;
            this.LabelModifiedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModifiedDate.Location = new System.Drawing.Point(20, 43);
            this.LabelModifiedDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelModifiedDate.Name = "LabelModifiedDate";
            this.LabelModifiedDate.Size = new System.Drawing.Size(9, 15);
            this.LabelModifiedDate.TabIndex = 1205;
            this.LabelModifiedDate.Text = "...";
            // 
            // LabelHeaderTitleId
            // 
            this.LabelHeaderTitleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderTitleId.Appearance.Options.UseFont = true;
            this.LabelHeaderTitleId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderTitleId.Location = new System.Drawing.Point(280, 20);
            this.LabelHeaderTitleId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelHeaderTitleId.Name = "LabelHeaderTitleId";
            this.LabelHeaderTitleId.Size = new System.Drawing.Size(41, 15);
            this.LabelHeaderTitleId.TabIndex = 1206;
            this.LabelHeaderTitleId.Text = "Title ID";
            // 
            // LabelTitleID
            // 
            this.LabelTitleID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelTitleID.Appearance.Options.UseFont = true;
            this.LabelTitleID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleID.Location = new System.Drawing.Point(280, 43);
            this.LabelTitleID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelTitleID.Name = "LabelTitleID";
            this.LabelTitleID.Size = new System.Drawing.Size(9, 15);
            this.LabelTitleID.TabIndex = 1207;
            this.LabelTitleID.Text = "...";
            // 
            // PanelDetails
            // 
            this.PanelDetails.Controls.Add(this.LabelTitleID);
            this.PanelDetails.Controls.Add(this.LabelHeaderTitleId);
            this.PanelDetails.Controls.Add(this.LabelModifiedDate);
            this.PanelDetails.Controls.Add(this.LabelHeaderModifiedDate);
            this.PanelDetails.Controls.Add(this.LabelSha256);
            this.PanelDetails.Controls.Add(this.LabelHeaderSha256);
            this.PanelDetails.Controls.Add(this.LabelFileSize);
            this.PanelDetails.Controls.Add(this.LabelHeaderFileSize);
            this.PanelDetails.Controls.Add(this.LabelContentId);
            this.PanelDetails.Controls.Add(this.LabelHeaderContentId);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(800, 89);
            this.PanelDetails.TabIndex = 1;
            // 
            // PackageDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 219);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackageDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::NeoModsX.Properties.Resources.neomodsx;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Homebrew Details";
            this.Load += new System.EventHandler(this.PackageDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private DevExpress.Utils.SvgImageCollection Images;
        private PanelControl PanelHeader;
        private SeparatorControl SeparatorHeader;
        private SvgImageBox ImageCloseDetails;
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonFaq;
        private SimpleButton ButtonInstall;
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private LabelControl LabelPackages;
        private LabelControl LabelSlash;
        private LabelControl LabelCategory;
        private LabelControl LabelRegion;
        private XtraScrollableControl PanelDetails;
        private LabelControl LabelTitleID;
        private LabelControl LabelHeaderTitleId;
        private LabelControl LabelModifiedDate;
        private LabelControl LabelHeaderModifiedDate;
        private LabelControl LabelSha256;
        private LabelControl LabelHeaderSha256;
        private LabelControl LabelFileSize;
        private LabelControl LabelHeaderFileSize;
        private LabelControl LabelContentId;
        private LabelControl LabelHeaderContentId;
        private LabelControl LabelName;
    }
}