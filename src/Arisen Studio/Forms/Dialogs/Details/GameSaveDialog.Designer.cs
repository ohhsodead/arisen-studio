using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs.Details
{
    partial class GameSaveDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSaveDialog));
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.TablePanelStats = new DevExpress.Utils.Layout.TablePanel();
            this.StatGameMode = new ArisenStudio.Controls.StatItem();
            this.StatVersion = new ArisenStudio.Controls.StatItem();
            this.StatSubmittedBy = new ArisenStudio.Controls.StatItem();
            this.StatCreatedBy = new ArisenStudio.Controls.StatItem();
            this.StatLastUpdated = new ArisenStudio.Controls.StatItem();
            this.TabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabDescription = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.TabDownloads = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.PanelRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageCloseDetails = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFavorite = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonReport = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonHelp = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).BeginInit();
            this.TablePanelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).BeginInit();
            this.TabPane.SuspendLayout();
            this.TabDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PanelDetails.Appearance.Options.UseBackColor = true;
            this.PanelDetails.Controls.Add(this.TablePanelStats);
            this.PanelDetails.Controls.Add(this.TabPane);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(800, 370);
            this.PanelDetails.TabIndex = 1;
            // 
            // TablePanelStats
            // 
            this.TablePanelStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelStats.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 19.85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40.15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.TablePanelStats.Controls.Add(this.StatGameMode);
            this.TablePanelStats.Controls.Add(this.StatVersion);
            this.TablePanelStats.Controls.Add(this.StatSubmittedBy);
            this.TablePanelStats.Controls.Add(this.StatCreatedBy);
            this.TablePanelStats.Controls.Add(this.StatLastUpdated);
            this.TablePanelStats.Location = new System.Drawing.Point(16, 14);
            this.TablePanelStats.Name = "TablePanelStats";
            this.TablePanelStats.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.TablePanelStats.Size = new System.Drawing.Size(768, 54);
            this.TablePanelStats.TabIndex = 1198;
            // 
            // StatGameMode
            // 
            this.StatGameMode.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatGameMode.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatGameMode, 2);
            this.StatGameMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatGameMode.Location = new System.Drawing.Point(295, 3);
            this.StatGameMode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatGameMode.Name = "StatGameMode";
            this.TablePanelStats.SetRow(this.StatGameMode, 0);
            this.StatGameMode.Size = new System.Drawing.Size(140, 41);
            this.StatGameMode.TabIndex = 6;
            this.StatGameMode.Title = "Game Mode";
            this.StatGameMode.Value = "Value";
            // 
            // StatVersion
            // 
            this.StatVersion.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatVersion.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatVersion, 1);
            this.StatVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatVersion.Location = new System.Drawing.Point(149, 3);
            this.StatVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatVersion.Name = "StatVersion";
            this.TablePanelStats.SetRow(this.StatVersion, 0);
            this.StatVersion.Size = new System.Drawing.Size(140, 41);
            this.StatVersion.TabIndex = 5;
            this.StatVersion.Title = "Version";
            this.StatVersion.Value = "Value";
            // 
            // StatSubmittedBy
            // 
            this.StatSubmittedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSubmittedBy.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatSubmittedBy, 4);
            this.StatSubmittedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatSubmittedBy.Location = new System.Drawing.Point(587, 3);
            this.StatSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatSubmittedBy.Name = "StatSubmittedBy";
            this.TablePanelStats.SetRow(this.StatSubmittedBy, 0);
            this.StatSubmittedBy.Size = new System.Drawing.Size(178, 41);
            this.StatSubmittedBy.TabIndex = 4;
            this.StatSubmittedBy.Title = "Submitted By";
            this.StatSubmittedBy.Value = "Value";
            // 
            // StatCreatedBy
            // 
            this.StatCreatedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatCreatedBy.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatCreatedBy, 3);
            this.StatCreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatCreatedBy.Location = new System.Drawing.Point(441, 3);
            this.StatCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatCreatedBy.Name = "StatCreatedBy";
            this.TablePanelStats.SetRow(this.StatCreatedBy, 0);
            this.StatCreatedBy.Size = new System.Drawing.Size(140, 41);
            this.StatCreatedBy.TabIndex = 3;
            this.StatCreatedBy.Title = "Created By";
            this.StatCreatedBy.Value = "Value";
            // 
            // StatLastUpdated
            // 
            this.StatLastUpdated.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatLastUpdated.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatLastUpdated, 0);
            this.StatLastUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatLastUpdated.Location = new System.Drawing.Point(3, 3);
            this.StatLastUpdated.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatLastUpdated.Name = "StatLastUpdated";
            this.TablePanelStats.SetRow(this.StatLastUpdated, 0);
            this.StatLastUpdated.Size = new System.Drawing.Size(140, 41);
            this.StatLastUpdated.TabIndex = 0;
            this.StatLastUpdated.Title = "Last Updated";
            this.StatLastUpdated.Value = "Value";
            // 
            // TabPane
            // 
            this.TabPane.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TabPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPane.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TabPane.Appearance.Options.UseBackColor = true;
            this.TabPane.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.AppearanceButton.Hovered.Options.UseFont = true;
            this.TabPane.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.AppearanceButton.Normal.Options.UseFont = true;
            this.TabPane.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabPane.AppearanceButton.Pressed.Options.UseFont = true;
            this.TabPane.Controls.Add(this.TabDescription);
            this.TabPane.Controls.Add(this.TabDownloads);
            this.TabPane.Location = new System.Drawing.Point(15, 78);
            this.TabPane.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TabPane.Name = "TabPane";
            this.TabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabDescription,
            this.TabDownloads});
            this.TabPane.RegularSize = new System.Drawing.Size(770, 292);
            this.TabPane.SelectedPage = this.TabDescription;
            this.TabPane.Size = new System.Drawing.Size(770, 292);
            this.TabPane.TabIndex = 1197;
            this.TabPane.Text = "TabPane";
            this.TabPane.TransitionAnimationProperties.FrameCount = 900;
            this.TabPane.TransitionAnimationProperties.FrameInterval = 2500;
            // 
            // TabDescription
            // 
            this.TabDescription.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TabDescription.Appearance.Options.UseBackColor = true;
            this.TabDescription.AutoScroll = true;
            this.TabDescription.Caption = "Description";
            this.TabDescription.Controls.Add(this.LabelDescription);
            this.TabDescription.Name = "TabDescription";
            this.TabDescription.Size = new System.Drawing.Size(770, 256);
            this.TabDescription.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDescription_Scroll);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AllowHtmlString = true;
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.Appearance.Options.UseTextOptions = true;
            this.LabelDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(0, 0);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.LabelDescription.Size = new System.Drawing.Size(770, 23);
            this.LabelDescription.TabIndex = 1176;
            this.LabelDescription.Text = "...";
            this.LabelDescription.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelDescription_HyperlinkClick);
            // 
            // TabDownloads
            // 
            this.TabDownloads.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TabDownloads.Appearance.Options.UseBackColor = true;
            this.TabDownloads.AutoScroll = true;
            this.TabDownloads.Caption = "Downloads";
            this.TabDownloads.Name = "TabDownloads";
            this.TabDownloads.Size = new System.Drawing.Size(776, 243);
            this.TabDownloads.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDownloads_Scroll);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.LabelName);
            this.PanelHeader.Controls.Add(this.PanelRegion);
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageCloseDetails);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 80);
            this.PanelHeader.TabIndex = 1190;
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
            this.LabelName.Location = new System.Drawing.Point(16, 43);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(772, 20);
            this.LabelName.TabIndex = 1192;
            this.LabelName.Text = "Name";
            // 
            // PanelRegion
            // 
            this.PanelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRegion.Controls.Add(this.LabelCategory);
            this.PanelRegion.Controls.Add(this.LabelRegion);
            this.PanelRegion.Location = new System.Drawing.Point(16, 12);
            this.PanelRegion.Name = "PanelRegion";
            this.PanelRegion.Size = new System.Drawing.Size(744, 22);
            this.PanelRegion.TabIndex = 1191;
            this.PanelRegion.WrapContents = false;
            // 
            // LabelCategory
            // 
            this.LabelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.AutoEllipsis = true;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(0, 1);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
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
            this.LabelRegion.Location = new System.Drawing.Point(61, 3);
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
            this.ImageCloseDetails.ForeColor = System.Drawing.Color.White;
            this.ImageCloseDetails.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.ImageCloseDetails.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ImageCloseDetails.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageCloseDetails.Location = new System.Drawing.Point(764, 10);
            this.ImageCloseDetails.Name = "ImageCloseDetails";
            this.ImageCloseDetails.Size = new System.Drawing.Size(26, 26);
            this.ImageCloseDetails.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageCloseDetails.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageCloseDetails.SvgImage")));
            this.ImageCloseDetails.TabIndex = 1171;
            this.ImageCloseDetails.Text = "Close";
            this.ImageCloseDetails.Click += new System.EventHandler(this.ImageClose_Click);
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonDownload);
            this.PanelActions.Controls.Add(this.ButtonInstall);
            this.PanelActions.Controls.Add(this.ButtonFavorite);
            this.PanelActions.Controls.Add(this.ButtonReport);
            this.PanelActions.Controls.Add(this.ButtonHelp);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 450);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(800, 50);
            this.PanelActions.TabIndex = 1175;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDownload.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonDownload.Appearance.Options.UseFont = true;
            this.ButtonDownload.Appearance.Options.UseForeColor = true;
            this.ButtonDownload.AutoSize = true;
            this.ButtonDownload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDownload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDownload.ImageOptions.ImageToTextIndent = 6;
            this.ButtonDownload.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDownload.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_download_from_cloud;
            this.ButtonDownload.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonDownload.Location = new System.Drawing.Point(12, 11);
            this.ButtonDownload.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.ButtonDownload.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownload.Size = new System.Drawing.Size(113, 28);
            this.ButtonDownload.TabIndex = 1179;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonInstall.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonInstall.Appearance.Options.UseFont = true;
            this.ButtonInstall.Appearance.Options.UseForeColor = true;
            this.ButtonInstall.AutoSize = true;
            this.ButtonInstall.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonInstall.ImageOptions.Image = global::ArisenStudio.Properties.Resources.install;
            this.ButtonInstall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInstall.ImageOptions.ImageToTextIndent = 6;
            this.ButtonInstall.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInstall.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.install_svg;
            this.ButtonInstall.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonInstall.Location = new System.Drawing.Point(133, 10);
            this.ButtonInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonInstall.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonInstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstall.Size = new System.Drawing.Size(90, 30);
            this.ButtonInstall.TabIndex = 1185;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // ButtonFavorite
            // 
            this.ButtonFavorite.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonFavorite.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonFavorite.Appearance.Options.UseFont = true;
            this.ButtonFavorite.Appearance.Options.UseForeColor = true;
            this.ButtonFavorite.AutoSize = true;
            this.ButtonFavorite.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFavorite.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFavorite.ImageOptions.ImageToTextIndent = 6;
            this.ButtonFavorite.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFavorite.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFavorite.ImageOptions.SvgImage")));
            this.ButtonFavorite.ImageOptions.SvgImageSize = new System.Drawing.Size(17, 17);
            this.ButtonFavorite.Location = new System.Drawing.Point(231, 11);
            this.ButtonFavorite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonFavorite.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFavorite.Size = new System.Drawing.Size(149, 28);
            this.ButtonFavorite.TabIndex = 1178;
            this.ButtonFavorite.Text = "Add to Favorites";
            this.ButtonFavorite.Click += new System.EventHandler(this.ButtonFavorite_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonReport.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonReport.Appearance.Options.UseFont = true;
            this.ButtonReport.Appearance.Options.UseForeColor = true;
            this.ButtonReport.AutoSize = true;
            this.ButtonReport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonReport.ImageOptions.ImageToTextIndent = 6;
            this.ButtonReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonReport.ImageOptions.SvgImage")));
            this.ButtonReport.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonReport.Location = new System.Drawing.Point(388, 11);
            this.ButtonReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonReport.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(127, 28);
            this.ButtonReport.TabIndex = 1177;
            this.ButtonReport.Text = "Report Issue";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReportIssue_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonHelp.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonHelp.Appearance.Options.UseFont = true;
            this.ButtonHelp.Appearance.Options.UseForeColor = true;
            this.ButtonHelp.AutoSize = true;
            this.ButtonHelp.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonHelp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonHelp.ImageOptions.ImageToTextIndent = 4;
            this.ButtonHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonHelp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.ButtonHelp.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonHelp.Location = new System.Drawing.Point(523, 11);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonHelp.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonHelp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonHelp.Size = new System.Drawing.Size(152, 28);
            this.ButtonHelp.TabIndex = 1180;
            this.ButtonHelp.Text = "Help && Support";
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // GameSaveDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameSaveDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSaveDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.GameSaveDialog_Load);
            this.PanelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).EndInit();
            this.TablePanelStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).EndInit();
            this.TabPane.ResumeLayout(false);
            this.TabDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelRegion.ResumeLayout(false);
            this.PanelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.PanelActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScrollableControl PanelDetails;
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private SimpleButton ButtonReport;
        private DevExpress.Utils.SvgImageCollection Images;
        private PanelControl PanelHeader;
        private SvgImageBox ImageCloseDetails;
        private SeparatorControl SeparatorHeader;
        private SimpleButton ButtonFavorite;
        private System.Windows.Forms.FlowLayoutPanel PanelRegion;
        private LabelControl LabelCategory;
        private LabelControl LabelRegion;
        private LabelControl LabelName;
        private DevExpress.XtraBars.Navigation.TabPane TabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDescription;
        private LabelControl LabelDescription;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDownloads;
        private DevExpress.Utils.Layout.TablePanel TablePanelStats;
        private Controls.StatItem StatGameMode;
        private Controls.StatItem StatVersion;
        private Controls.StatItem StatSubmittedBy;
        private Controls.StatItem StatCreatedBy;
        private Controls.StatItem StatLastUpdated;
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonHelp;
        private SimpleButton ButtonInstall;
    }
}