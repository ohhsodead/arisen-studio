using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Dialogs.Details
{
    partial class GameModDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameModDialog));
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelSystemType = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSystemType = new DevExpress.XtraEditors.LabelControl();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderDescription = new DevExpress.XtraEditors.LabelControl();
            this.LabelSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreatedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderCreatedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameMode = new DevExpress.XtraEditors.LabelControl();
            this.LabelModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderGameMode = new DevExpress.XtraEditors.LabelControl();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageCloseDetails = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.PanelRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
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
            this.ButtonFavorite = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonReport = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
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
            this.PanelDetails.Controls.Add(this.LabelSystemType);
            this.PanelDetails.Controls.Add(this.LabelHeaderVersion);
            this.PanelDetails.Controls.Add(this.LabelVersion);
            this.PanelDetails.Controls.Add(this.LabelHeaderSystemType);
            this.PanelDetails.Controls.Add(this.LabelDescription);
            this.PanelDetails.Controls.Add(this.LabelHeaderDescription);
            this.PanelDetails.Controls.Add(this.LabelSubmittedBy);
            this.PanelDetails.Controls.Add(this.LabelHeaderSubmittedBy);
            this.PanelDetails.Controls.Add(this.LabelCreatedBy);
            this.PanelDetails.Controls.Add(this.LabelHeaderCreatedBy);
            this.PanelDetails.Controls.Add(this.LabelHeaderModType);
            this.PanelDetails.Controls.Add(this.LabelGameMode);
            this.PanelDetails.Controls.Add(this.LabelModType);
            this.PanelDetails.Controls.Add(this.LabelHeaderGameMode);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(509, 476);
            this.PanelDetails.TabIndex = 1;
            // 
            // LabelSystemType
            // 
            this.LabelSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSystemType.Appearance.Options.UseFont = true;
            this.LabelSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSystemType.Location = new System.Drawing.Point(15, 43);
            this.LabelSystemType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelSystemType.Name = "LabelSystemType";
            this.LabelSystemType.Size = new System.Drawing.Size(9, 15);
            this.LabelSystemType.TabIndex = 1192;
            this.LabelSystemType.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(15, 72);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(42, 15);
            this.LabelHeaderVersion.TabIndex = 1191;
            this.LabelHeaderVersion.Text = "Version";
            // 
            // LabelVersion
            // 
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(15, 95);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(9, 15);
            this.LabelVersion.TabIndex = 1183;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderSystemType
            // 
            this.LabelHeaderSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderSystemType.Appearance.Options.UseFont = true;
            this.LabelHeaderSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSystemType.Location = new System.Drawing.Point(15, 20);
            this.LabelHeaderSystemType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelHeaderSystemType.Name = "LabelHeaderSystemType";
            this.LabelHeaderSystemType.Size = new System.Drawing.Size(71, 15);
            this.LabelHeaderSystemType.TabIndex = 1182;
            this.LabelHeaderSystemType.Text = "System Type";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AllowHtmlString = true;
            this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(15, 202);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(542, 0);
            this.LabelDescription.MinimumSize = new System.Drawing.Size(542, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.LabelDescription.Size = new System.Drawing.Size(542, 31);
            this.LabelDescription.TabIndex = 1176;
            this.LabelDescription.Text = "...";
            this.LabelDescription.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelDescription_HyperlinkClick);
            // 
            // LabelHeaderDescription
            // 
            this.LabelHeaderDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderDescription.Appearance.Options.UseFont = true;
            this.LabelHeaderDescription.Location = new System.Drawing.Point(15, 178);
            this.LabelHeaderDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelHeaderDescription.Name = "LabelHeaderDescription";
            this.LabelHeaderDescription.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderDescription.TabIndex = 1189;
            this.LabelHeaderDescription.Text = "Description";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(180, 148);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(9, 15);
            this.LabelSubmittedBy.TabIndex = 1178;
            this.LabelSubmittedBy.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(180, 125);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(76, 15);
            this.LabelHeaderSubmittedBy.TabIndex = 1177;
            this.LabelHeaderSubmittedBy.Text = "Submitted By";
            // 
            // LabelCreatedBy
            // 
            this.LabelCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedBy.Appearance.Options.UseFont = true;
            this.LabelCreatedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedBy.Location = new System.Drawing.Point(15, 148);
            this.LabelCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelCreatedBy.Name = "LabelCreatedBy";
            this.LabelCreatedBy.Size = new System.Drawing.Size(9, 15);
            this.LabelCreatedBy.TabIndex = 1179;
            this.LabelCreatedBy.Text = "...";
            // 
            // LabelHeaderCreatedBy
            // 
            this.LabelHeaderCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCreatedBy.Appearance.Options.UseFont = true;
            this.LabelHeaderCreatedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCreatedBy.Location = new System.Drawing.Point(15, 125);
            this.LabelHeaderCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderCreatedBy.Name = "LabelHeaderCreatedBy";
            this.LabelHeaderCreatedBy.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderCreatedBy.TabIndex = 1173;
            this.LabelHeaderCreatedBy.Text = "Created By";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderModType.Appearance.Options.UseFont = true;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(180, 20);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(55, 15);
            this.LabelHeaderModType.TabIndex = 1180;
            this.LabelHeaderModType.Text = "Mod Type";
            // 
            // LabelGameMode
            // 
            this.LabelGameMode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameMode.Appearance.Options.UseFont = true;
            this.LabelGameMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameMode.Location = new System.Drawing.Point(180, 95);
            this.LabelGameMode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelGameMode.Name = "LabelGameMode";
            this.LabelGameMode.Size = new System.Drawing.Size(9, 15);
            this.LabelGameMode.TabIndex = 1175;
            this.LabelGameMode.Text = "...";
            // 
            // LabelModType
            // 
            this.LabelModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModType.Appearance.Options.UseFont = true;
            this.LabelModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModType.Location = new System.Drawing.Point(180, 43);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(9, 15);
            this.LabelModType.TabIndex = 1181;
            this.LabelModType.Text = "...";
            // 
            // LabelHeaderGameMode
            // 
            this.LabelHeaderGameMode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderGameMode.Appearance.Options.UseFont = true;
            this.LabelHeaderGameMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameMode.Location = new System.Drawing.Point(180, 72);
            this.LabelHeaderGameMode.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderGameMode.Name = "LabelHeaderGameMode";
            this.LabelHeaderGameMode.Size = new System.Drawing.Size(68, 15);
            this.LabelHeaderGameMode.TabIndex = 1174;
            this.LabelHeaderGameMode.Text = "Game Mode";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageCloseDetails);
            this.PanelHeader.Controls.Add(this.LabelCategory);
            this.PanelHeader.Controls.Add(this.PanelRegion);
            this.PanelHeader.Controls.Add(this.LabelName);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(509, 80);
            this.PanelHeader.TabIndex = 1190;
            // 
            // SeparatorHeader
            // 
            this.SeparatorHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorHeader.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHeader.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorHeader.Location = new System.Drawing.Point(0, 70);
            this.SeparatorHeader.Name = "SeparatorHeader";
            this.SeparatorHeader.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.SeparatorHeader.Size = new System.Drawing.Size(509, 10);
            this.SeparatorHeader.TabIndex = 1185;
            // 
            // ImageCloseDetails
            // 
            this.ImageCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageCloseDetails.Location = new System.Drawing.Point(475, 10);
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
            this.LabelCategory.Size = new System.Drawing.Size(294, 17);
            this.LabelCategory.TabIndex = 1184;
            this.LabelCategory.Text = "Category";
            // 
            // PanelRegion
            // 
            this.PanelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRegion.Controls.Add(this.LabelRegion);
            this.PanelRegion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelRegion.Location = new System.Drawing.Point(311, 12);
            this.PanelRegion.Name = "PanelRegion";
            this.PanelRegion.Size = new System.Drawing.Size(158, 22);
            this.PanelRegion.TabIndex = 1190;
            this.PanelRegion.WrapContents = false;
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
            this.LabelRegion.Location = new System.Drawing.Point(94, 3);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(61, 15);
            this.LabelRegion.TabIndex = 1188;
            this.LabelRegion.Text = "All Regions";
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(12, 44);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(485, 15);
            this.LabelName.TabIndex = 1170;
            this.LabelName.Text = "Name";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonActions);
            this.PanelActions.Controls.Add(this.ButtonDownload);
            this.PanelActions.Controls.Add(this.ButtonFavorite);
            this.PanelActions.Controls.Add(this.ButtonReport);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 556);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(509, 50);
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
            this.ButtonActions.Location = new System.Drawing.Point(12, 12);
            this.ButtonActions.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
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
            this.MenuItemInstallFiles.Caption = "Install Files";
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
            this.barDockControlTop.Size = new System.Drawing.Size(509, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(509, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(509, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
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
            this.ButtonDownload.Location = new System.Drawing.Point(144, 12);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownload.Size = new System.Drawing.Size(102, 26);
            this.ButtonDownload.TabIndex = 1176;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonFavorite
            // 
            this.ButtonFavorite.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonFavorite.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonFavorite.Appearance.Options.UseFont = true;
            this.ButtonFavorite.Appearance.Options.UseForeColor = true;
            this.ButtonFavorite.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFavorite.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFavorite.ImageOptions.ImageToTextIndent = 6;
            this.ButtonFavorite.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFavorite.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFavorite.ImageOptions.SvgImage")));
            this.ButtonFavorite.ImageOptions.SvgImageSize = new System.Drawing.Size(17, 17);
            this.ButtonFavorite.Location = new System.Drawing.Point(252, 12);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFavorite.Size = new System.Drawing.Size(92, 26);
            this.ButtonFavorite.TabIndex = 1178;
            this.ButtonFavorite.Text = "Favorite";
            this.ButtonFavorite.Click += new System.EventHandler(this.ButtonFavorite_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonReport.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonReport.Appearance.Options.UseFont = true;
            this.ButtonReport.Appearance.Options.UseForeColor = true;
            this.ButtonReport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonReport.ImageOptions.ImageToTextIndent = 6;
            this.ButtonReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonReport.ImageOptions.SvgImage")));
            this.ButtonReport.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonReport.Location = new System.Drawing.Point(350, 12);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(84, 26);
            this.ButtonReport.TabIndex = 1177;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // GameModDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 606);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameModDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameModDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.GameModDialog_Load);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
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
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonReport;
        private DevExpress.XtraBars.PopupMenu MenuActions;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection Images;
        private DevExpress.XtraBars.BarButtonItem MenuItemInstallFiles;
        private LabelControl LabelName;
        private LabelControl LabelHeaderDescription;
        private LabelControl LabelSubmittedBy;
        private LabelControl LabelCategory;
        private LabelControl LabelHeaderSubmittedBy;
        private LabelControl LabelHeaderSystemType;
        private LabelControl LabelCreatedBy;
        private LabelControl LabelVersion;
        private LabelControl LabelHeaderCreatedBy;
        private LabelControl LabelHeaderModType;
        private LabelControl LabelGameMode;
        private LabelControl LabelModType;
        private LabelControl LabelHeaderGameMode;
        private LabelControl LabelRegion;
        private LabelControl LabelDescription;
        private PanelControl PanelHeader;
        private SvgImageBox ImageCloseDetails;
        private SeparatorControl SeparatorHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelRegion;
        private SimpleButton ButtonFavorite;
        private LabelControl LabelSystemType;
        private LabelControl LabelHeaderVersion;
    }
}