using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Dialogs.Details
{
    partial class ResourceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceDialog));
            this.PanelHomebrewDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderDescription = new DevExpress.XtraEditors.LabelControl();
            this.LabelSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreatedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderCreatedBy = new DevExpress.XtraEditors.LabelControl();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.PanelVersion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderVersion = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageCloseDetails = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.PanelRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelSystemType = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.PanelHomebrewItemActions = new DevExpress.Utils.Layout.StackPanel();
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
            this.PanelHomebrewDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).BeginInit();
            this.PanelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHomebrewItemActions)).BeginInit();
            this.PanelHomebrewItemActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHomebrewDetails
            // 
            this.PanelHomebrewDetails.Controls.Add(this.LabelModType);
            this.PanelHomebrewDetails.Controls.Add(this.LabelHeaderModType);
            this.PanelHomebrewDetails.Controls.Add(this.LabelDescription);
            this.PanelHomebrewDetails.Controls.Add(this.LabelHeaderDescription);
            this.PanelHomebrewDetails.Controls.Add(this.LabelSubmittedBy);
            this.PanelHomebrewDetails.Controls.Add(this.LabelHeaderSubmittedBy);
            this.PanelHomebrewDetails.Controls.Add(this.LabelCreatedBy);
            this.PanelHomebrewDetails.Controls.Add(this.LabelHeaderCreatedBy);
            this.PanelHomebrewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHomebrewDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelHomebrewDetails.Name = "PanelHomebrewDetails";
            this.PanelHomebrewDetails.Size = new System.Drawing.Size(475, 463);
            this.PanelHomebrewDetails.TabIndex = 1;
            // 
            // LabelModType
            // 
            this.LabelModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModType.Appearance.Options.UseFont = true;
            this.LabelModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModType.Location = new System.Drawing.Point(333, 43);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(9, 15);
            this.LabelModType.TabIndex = 1193;
            this.LabelModType.Text = "...";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderModType.Appearance.Options.UseFont = true;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(333, 20);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(55, 15);
            this.LabelHeaderModType.TabIndex = 1192;
            this.LabelHeaderModType.Text = "Mod Type";
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
            this.LabelDescription.Location = new System.Drawing.Point(15, 97);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(508, 0);
            this.LabelDescription.MinimumSize = new System.Drawing.Size(508, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.LabelDescription.Size = new System.Drawing.Size(508, 31);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            this.LabelDescription.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelDescription_HyperlinkClick);
            // 
            // LabelHeaderDescription
            // 
            this.LabelHeaderDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderDescription.Appearance.Options.UseFont = true;
            this.LabelHeaderDescription.Location = new System.Drawing.Point(15, 73);
            this.LabelHeaderDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelHeaderDescription.Name = "LabelHeaderDescription";
            this.LabelHeaderDescription.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderDescription.TabIndex = 1169;
            this.LabelHeaderDescription.Text = "Description";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(180, 43);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(9, 15);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(180, 20);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(76, 15);
            this.LabelHeaderSubmittedBy.TabIndex = 13;
            this.LabelHeaderSubmittedBy.Text = "Submitted By";
            // 
            // LabelCreatedBy
            // 
            this.LabelCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedBy.Appearance.Options.UseFont = true;
            this.LabelCreatedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedBy.Location = new System.Drawing.Point(15, 43);
            this.LabelCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelCreatedBy.Name = "LabelCreatedBy";
            this.LabelCreatedBy.Size = new System.Drawing.Size(9, 15);
            this.LabelCreatedBy.TabIndex = 15;
            this.LabelCreatedBy.Text = "...";
            // 
            // LabelHeaderCreatedBy
            // 
            this.LabelHeaderCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCreatedBy.Appearance.Options.UseFont = true;
            this.LabelHeaderCreatedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCreatedBy.Location = new System.Drawing.Point(15, 20);
            this.LabelHeaderCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.LabelHeaderCreatedBy.Name = "LabelHeaderCreatedBy";
            this.LabelHeaderCreatedBy.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderCreatedBy.TabIndex = 6;
            this.LabelHeaderCreatedBy.Text = "Created By";
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
            this.PanelHeader.Size = new System.Drawing.Size(475, 80);
            this.PanelHeader.TabIndex = 1191;
            // 
            // PanelVersion
            // 
            this.PanelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelVersion.Controls.Add(this.LabelVersion);
            this.PanelVersion.Controls.Add(this.LabelHeaderVersion);
            this.PanelVersion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelVersion.Location = new System.Drawing.Point(348, 41);
            this.PanelVersion.Name = "PanelVersion";
            this.PanelVersion.Size = new System.Drawing.Size(117, 22);
            this.PanelVersion.TabIndex = 1189;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(105, 3);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(9, 15);
            this.LabelVersion.TabIndex = 1172;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(54, 3);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderVersion.TabIndex = 1171;
            this.LabelHeaderVersion.Text = "Version:";
            // 
            // SeparatorHeader
            // 
            this.SeparatorHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorHeader.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHeader.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorHeader.Location = new System.Drawing.Point(0, 69);
            this.SeparatorHeader.Name = "SeparatorHeader";
            this.SeparatorHeader.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.SeparatorHeader.Size = new System.Drawing.Size(475, 11);
            this.SeparatorHeader.TabIndex = 1185;
            // 
            // ImageCloseDetails
            // 
            this.ImageCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageCloseDetails.Location = new System.Drawing.Point(441, 10);
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
            this.LabelCategory.Size = new System.Drawing.Size(285, 17);
            this.LabelCategory.TabIndex = 1184;
            this.LabelCategory.Text = "Category";
            // 
            // PanelRegion
            // 
            this.PanelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRegion.Controls.Add(this.LabelSystemType);
            this.PanelRegion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelRegion.Location = new System.Drawing.Point(303, 12);
            this.PanelRegion.Name = "PanelRegion";
            this.PanelRegion.Size = new System.Drawing.Size(132, 22);
            this.PanelRegion.TabIndex = 1190;
            this.PanelRegion.WrapContents = false;
            // 
            // LabelSystemType
            // 
            this.LabelSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSystemType.Appearance.Options.UseFont = true;
            this.LabelSystemType.Appearance.Options.UseTextOptions = true;
            this.LabelSystemType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelSystemType.AutoEllipsis = true;
            this.LabelSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSystemType.Location = new System.Drawing.Point(58, 3);
            this.LabelSystemType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelSystemType.Name = "LabelSystemType";
            this.LabelSystemType.Size = new System.Drawing.Size(71, 15);
            this.LabelSystemType.TabIndex = 1188;
            this.LabelSystemType.Text = "System Type";
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
            this.LabelName.Location = new System.Drawing.Point(12, 44);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(330, 15);
            this.LabelName.TabIndex = 1170;
            this.LabelName.Text = "Name";
            // 
            // PanelHomebrewItemActions
            // 
            this.PanelHomebrewItemActions.Controls.Add(this.ButtonActions);
            this.PanelHomebrewItemActions.Controls.Add(this.ButtonDownload);
            this.PanelHomebrewItemActions.Controls.Add(this.ButtonFavorite);
            this.PanelHomebrewItemActions.Controls.Add(this.ButtonReport);
            this.PanelHomebrewItemActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelHomebrewItemActions.Location = new System.Drawing.Point(0, 543);
            this.PanelHomebrewItemActions.Name = "PanelHomebrewItemActions";
            this.PanelHomebrewItemActions.Size = new System.Drawing.Size(475, 42);
            this.PanelHomebrewItemActions.TabIndex = 1175;
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
            this.barDockControlTop.Size = new System.Drawing.Size(475, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(475, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 585);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(475, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 585);
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
            this.ButtonFavorite.Location = new System.Drawing.Point(248, 8);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFavorite.Size = new System.Drawing.Size(92, 26);
            this.ButtonFavorite.TabIndex = 1181;
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
            this.ButtonReport.Location = new System.Drawing.Point(346, 8);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(84, 26);
            this.ButtonReport.TabIndex = 1180;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // ResourceDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(475, 585);
            this.ControlBox = false;
            this.Controls.Add(this.PanelHomebrewDetails);
            this.Controls.Add(this.PanelHomebrewItemActions);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ResourceDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourceDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Homebrew Details";
            this.Load += new System.EventHandler(this.ResourceDialog_Load);
            this.PanelHomebrewDetails.ResumeLayout(false);
            this.PanelHomebrewDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelVersion.ResumeLayout(false);
            this.PanelVersion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).EndInit();
            this.PanelRegion.ResumeLayout(false);
            this.PanelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHomebrewItemActions)).EndInit();
            this.PanelHomebrewItemActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraScrollableControl PanelHomebrewDetails;
        private LabelControl LabelDescription;
        private LabelControl LabelHeaderDescription;
        private LabelControl LabelSubmittedBy;
        private LabelControl LabelHeaderSubmittedBy;
        private LabelControl LabelCreatedBy;
        private LabelControl LabelHeaderCreatedBy;
        private DevExpress.Utils.Layout.StackPanel PanelHomebrewItemActions;
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
        private LabelControl LabelVersion;
        private LabelControl LabelHeaderVersion;
        private SeparatorControl SeparatorHeader;
        private SvgImageBox ImageCloseDetails;
        private LabelControl LabelCategory;
        private System.Windows.Forms.FlowLayoutPanel PanelRegion;
        private LabelControl LabelSystemType;
        private LabelControl LabelName;
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonFavorite;
        private SimpleButton ButtonReport;
        private LabelControl LabelModType;
        private LabelControl LabelHeaderModType;
    }
}