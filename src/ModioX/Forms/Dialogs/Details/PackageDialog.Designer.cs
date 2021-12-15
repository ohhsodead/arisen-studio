using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs.Details
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
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelSha256 = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSha256 = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelContentId = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderContentId = new DevExpress.XtraEditors.LabelControl();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.PanelVersion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageCloseDetails = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.PanelRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleIdRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonActions = new DevExpress.XtraEditors.DropDownButton();
            this.MenuActions = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).BeginInit();
            this.PanelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Controls.Add(this.LabelSha256);
            this.PanelDetails.Controls.Add(this.LabelHeaderSha256);
            this.PanelDetails.Controls.Add(this.LabelFileSize);
            this.PanelDetails.Controls.Add(this.LabelHeaderFileSize);
            this.PanelDetails.Controls.Add(this.LabelContentId);
            this.PanelDetails.Controls.Add(this.LabelHeaderContentId);
            this.PanelDetails.Controls.Add(this.PanelHeader);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 0);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(428, 271);
            this.PanelDetails.TabIndex = 1;
            // 
            // LabelSha256
            // 
            this.LabelSha256.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSha256.Appearance.Options.UseFont = true;
            this.LabelSha256.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSha256.Location = new System.Drawing.Point(15, 230);
            this.LabelSha256.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelSha256.Name = "LabelSha256";
            this.LabelSha256.Size = new System.Drawing.Size(9, 15);
            this.LabelSha256.TabIndex = 1203;
            this.LabelSha256.Text = "...";
            // 
            // LabelHeaderSha256
            // 
            this.LabelHeaderSha256.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderSha256.Appearance.Options.UseFont = true;
            this.LabelHeaderSha256.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSha256.Location = new System.Drawing.Point(15, 207);
            this.LabelHeaderSha256.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderSha256.Name = "LabelHeaderSha256";
            this.LabelHeaderSha256.Size = new System.Drawing.Size(50, 15);
            this.LabelHeaderSha256.TabIndex = 1202;
            this.LabelHeaderSha256.Text = "SHA-256";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.Appearance.Options.UseFont = true;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(15, 179);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(9, 15);
            this.LabelFileSize.TabIndex = 1195;
            this.LabelFileSize.Text = "...";
            // 
            // LabelHeaderFileSize
            // 
            this.LabelHeaderFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileSize.Appearance.Options.UseFont = true;
            this.LabelHeaderFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileSize.Location = new System.Drawing.Point(15, 156);
            this.LabelHeaderFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderFileSize.Name = "LabelHeaderFileSize";
            this.LabelHeaderFileSize.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderFileSize.TabIndex = 1192;
            this.LabelHeaderFileSize.Text = "File Size";
            // 
            // LabelContentId
            // 
            this.LabelContentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelContentId.Appearance.Options.UseFont = true;
            this.LabelContentId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelContentId.Location = new System.Drawing.Point(15, 128);
            this.LabelContentId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelContentId.Name = "LabelContentId";
            this.LabelContentId.Size = new System.Drawing.Size(9, 15);
            this.LabelContentId.TabIndex = 1201;
            this.LabelContentId.Text = "...";
            // 
            // LabelHeaderContentId
            // 
            this.LabelHeaderContentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderContentId.Appearance.Options.UseFont = true;
            this.LabelHeaderContentId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderContentId.Location = new System.Drawing.Point(15, 105);
            this.LabelHeaderContentId.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderContentId.Name = "LabelHeaderContentId";
            this.LabelHeaderContentId.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderContentId.TabIndex = 1200;
            this.LabelHeaderContentId.Text = "Content ID";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.PanelVersion);
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageCloseDetails);
            this.PanelHeader.Controls.Add(this.LabelCategory);
            this.PanelHeader.Controls.Add(this.PanelRegion);
            this.PanelHeader.Controls.Add(this.LabelName);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(428, 89);
            this.PanelHeader.TabIndex = 1191;
            // 
            // PanelVersion
            // 
            this.PanelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelVersion.Controls.Add(this.LabelModifiedDate);
            this.PanelVersion.Controls.Add(this.LabelHeaderModifiedDate);
            this.PanelVersion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelVersion.Location = new System.Drawing.Point(301, 60);
            this.PanelVersion.Name = "PanelVersion";
            this.PanelVersion.Size = new System.Drawing.Size(117, 22);
            this.PanelVersion.TabIndex = 1189;
            // 
            // LabelModifiedDate
            // 
            this.LabelModifiedDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModifiedDate.Appearance.Options.UseFont = true;
            this.LabelModifiedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModifiedDate.Location = new System.Drawing.Point(105, 3);
            this.LabelModifiedDate.Name = "LabelModifiedDate";
            this.LabelModifiedDate.Size = new System.Drawing.Size(9, 15);
            this.LabelModifiedDate.TabIndex = 1172;
            this.LabelModifiedDate.Text = "...";
            // 
            // LabelHeaderModifiedDate
            // 
            this.LabelHeaderModifiedDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderModifiedDate.Appearance.Options.UseFont = true;
            this.LabelHeaderModifiedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModifiedDate.Location = new System.Drawing.Point(16, 3);
            this.LabelHeaderModifiedDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelHeaderModifiedDate.Name = "LabelHeaderModifiedDate";
            this.LabelHeaderModifiedDate.Size = new System.Drawing.Size(83, 15);
            this.LabelHeaderModifiedDate.TabIndex = 1171;
            this.LabelHeaderModifiedDate.Text = "Modified Date:";
            // 
            // SeparatorHeader
            // 
            this.SeparatorHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeparatorHeader.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHeader.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorHeader.Location = new System.Drawing.Point(0, 42);
            this.SeparatorHeader.Name = "SeparatorHeader";
            this.SeparatorHeader.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.SeparatorHeader.Size = new System.Drawing.Size(428, 11);
            this.SeparatorHeader.TabIndex = 1185;
            // 
            // ImageCloseDetails
            // 
            this.ImageCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageCloseDetails.Location = new System.Drawing.Point(394, 10);
            this.ImageCloseDetails.Name = "ImageCloseDetails";
            this.ImageCloseDetails.Size = new System.Drawing.Size(24, 24);
            this.ImageCloseDetails.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageCloseDetails.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageCloseDetails.SvgImage")));
            this.ImageCloseDetails.TabIndex = 1171;
            this.ImageCloseDetails.Text = "Close";
            this.ImageCloseDetails.Click += new System.EventHandler(this.ImageCloseDetails_Click);
            // 
            // LabelCategory
            // 
            this.LabelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.AutoEllipsis = true;
            this.LabelCategory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(12, 13);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(251, 17);
            this.LabelCategory.TabIndex = 1184;
            this.LabelCategory.Text = "Category";
            // 
            // PanelRegion
            // 
            this.PanelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRegion.Controls.Add(this.LabelTitleIdRegion);
            this.PanelRegion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelRegion.Location = new System.Drawing.Point(269, 12);
            this.PanelRegion.Name = "PanelRegion";
            this.PanelRegion.Size = new System.Drawing.Size(119, 22);
            this.PanelRegion.TabIndex = 1190;
            this.PanelRegion.WrapContents = false;
            // 
            // LabelTitleIdRegion
            // 
            this.LabelTitleIdRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleIdRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleIdRegion.Appearance.Options.UseFont = true;
            this.LabelTitleIdRegion.Appearance.Options.UseTextOptions = true;
            this.LabelTitleIdRegion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelTitleIdRegion.AutoEllipsis = true;
            this.LabelTitleIdRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleIdRegion.Location = new System.Drawing.Point(27, 3);
            this.LabelTitleIdRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelTitleIdRegion.Name = "LabelTitleIdRegion";
            this.LabelTitleIdRegion.Size = new System.Drawing.Size(89, 15);
            this.LabelTitleIdRegion.TabIndex = 1188;
            this.LabelTitleIdRegion.Text = "Title Id (Region)";
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(12, 63);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(283, 15);
            this.LabelName.TabIndex = 1170;
            this.LabelName.Text = "Name";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonActions);
            this.PanelActions.Controls.Add(this.ButtonDownload);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 271);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(428, 42);
            this.PanelActions.TabIndex = 1175;
            // 
            // ButtonActions
            // 
            this.ButtonActions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonActions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonActions.Appearance.Options.UseFont = true;
            this.ButtonActions.Appearance.Options.UseTextOptions = true;
            this.ButtonActions.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ButtonActions.DropDownControl = this.MenuActions;
            this.ButtonActions.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonActions.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonActions.ImageOptions.ImageToTextIndent = 4;
            this.ButtonActions.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonActions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonActions.ImageOptions.SvgImage")));
            this.ButtonActions.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonActions.Location = new System.Drawing.Point(8, 8);
            this.ButtonActions.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonActions.Name = "ButtonActions";
            this.ButtonActions.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ButtonActions.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonActions.Size = new System.Drawing.Size(126, 26);
            this.ButtonActions.TabIndex = 1173;
            this.ButtonActions.Text = "Not Installed";
            // 
            // MenuActions
            // 
            this.MenuActions.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuActions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemInstallFiles)});
            this.MenuActions.Manager = this.BarManager;
            this.MenuActions.Name = "MenuActions";
            this.MenuActions.BeforePopup += new System.ComponentModel.CancelEventHandler(this.MenuActions_BeforePopup);
            // 
            // MenuItemInstallFiles
            // 
            this.MenuItemInstallFiles.Caption = "Install Files...";
            this.MenuItemInstallFiles.Id = 0;
            this.MenuItemInstallFiles.Name = "MenuItemInstallFiles";
            this.MenuItemInstallFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemInstallFiles_ItemClick);
            // 
            // BarManager
            // 
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuItemInstallFiles});
            this.BarManager.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(428, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 313);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(428, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 313);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(428, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 313);
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
            this.ButtonDownload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDownload.ImageOptions.SvgImage")));
            this.ButtonDownload.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonDownload.Location = new System.Drawing.Point(140, 8);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownload.Size = new System.Drawing.Size(102, 26);
            this.ButtonDownload.TabIndex = 1179;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // PackageDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 313);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackageDialog.IconOptions.Icon")));
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
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelVersion.ResumeLayout(false);
            this.PanelVersion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).EndInit();
            this.PanelRegion.ResumeLayout(false);
            this.PanelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraScrollableControl PanelDetails;
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private DropDownButton ButtonActions;
        private DevExpress.XtraBars.PopupMenu MenuActions;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection Images;
        private DevExpress.XtraBars.BarButtonItem MenuItemInstallFiles;
        private PanelControl PanelHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelVersion;
        private LabelControl LabelModifiedDate;
        private LabelControl LabelHeaderModifiedDate;
        private SeparatorControl SeparatorHeader;
        private SvgImageBox ImageCloseDetails;
        private LabelControl LabelCategory;
        private System.Windows.Forms.FlowLayoutPanel PanelRegion;
        private LabelControl LabelTitleIdRegion;
        private LabelControl LabelName;
        private SimpleButton ButtonDownload;
        private LabelControl LabelSha256;
        private LabelControl LabelHeaderSha256;
        private LabelControl LabelFileSize;
        private LabelControl LabelHeaderFileSize;
        private LabelControl LabelContentId;
        private LabelControl LabelHeaderContentId;
    }
}