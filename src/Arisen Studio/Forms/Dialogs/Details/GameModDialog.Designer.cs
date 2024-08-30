using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs.Details
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
            this.TablePanelStats = new DevExpress.Utils.Layout.TablePanel();
            this.StatGameMode = new ArisenStudio.Controls.StatItem();
            this.StatLastUpdated = new ArisenStudio.Controls.StatItem();
            this.StatSystemType = new ArisenStudio.Controls.StatItem();
            this.StatModType = new ArisenStudio.Controls.StatItem();
            this.StatSubmittedBy = new ArisenStudio.Controls.StatItem();
            this.StatVersion = new ArisenStudio.Controls.StatItem();
            this.StatCreatedBy = new ArisenStudio.Controls.StatItem();
            this.TabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabDescription = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.TabDownloads = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelGameMods = new DevExpress.XtraEditors.LabelControl();
            this.LabelSlash = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).BeginInit();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelDetails.Appearance.Options.UseBackColor = true;
            this.PanelDetails.Controls.Add(this.TablePanelStats);
            this.PanelDetails.Controls.Add(this.TabPane);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(800, 476);
            this.PanelDetails.TabIndex = 1;
            // 
            // TablePanelStats
            // 
            this.TablePanelStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelStats.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.TablePanelStats.Controls.Add(this.StatGameMode);
            this.TablePanelStats.Controls.Add(this.StatLastUpdated);
            this.TablePanelStats.Controls.Add(this.StatSystemType);
            this.TablePanelStats.Controls.Add(this.StatModType);
            this.TablePanelStats.Controls.Add(this.StatSubmittedBy);
            this.TablePanelStats.Controls.Add(this.StatVersion);
            this.TablePanelStats.Controls.Add(this.StatCreatedBy);
            this.TablePanelStats.Location = new System.Drawing.Point(16, 14);
            this.TablePanelStats.Name = "TablePanelStats";
            this.TablePanelStats.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.TablePanelStats.Size = new System.Drawing.Size(768, 108);
            this.TablePanelStats.TabIndex = 1197;
            // 
            // StatGameMode
            // 
            this.StatGameMode.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatGameMode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatGameMode.Appearance.Options.UseBackColor = true;
            this.StatGameMode.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatGameMode, 0);
            this.StatGameMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatGameMode.Location = new System.Drawing.Point(0, 54);
            this.StatGameMode.Margin = new System.Windows.Forms.Padding(0);
            this.StatGameMode.Name = "StatGameMode";
            this.TablePanelStats.SetRow(this.StatGameMode, 1);
            this.StatGameMode.Size = new System.Drawing.Size(154, 54);
            this.StatGameMode.TabIndex = 6;
            this.StatGameMode.Title = "Game Mode";
            this.StatGameMode.Value = "Value";
            // 
            // StatLastUpdated
            // 
            this.StatLastUpdated.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatLastUpdated.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatLastUpdated.Appearance.Options.UseBackColor = true;
            this.StatLastUpdated.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatLastUpdated, 1);
            this.StatLastUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatLastUpdated.Location = new System.Drawing.Point(154, 54);
            this.StatLastUpdated.Margin = new System.Windows.Forms.Padding(0);
            this.StatLastUpdated.Name = "StatLastUpdated";
            this.TablePanelStats.SetRow(this.StatLastUpdated, 1);
            this.StatLastUpdated.Size = new System.Drawing.Size(154, 54);
            this.StatLastUpdated.TabIndex = 0;
            this.StatLastUpdated.Title = "Last Updated";
            this.StatLastUpdated.Value = "Value";
            // 
            // StatSystemType
            // 
            this.StatSystemType.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatSystemType.Appearance.Options.UseBackColor = true;
            this.StatSystemType.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatSystemType, 0);
            this.StatSystemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatSystemType.Location = new System.Drawing.Point(0, 0);
            this.StatSystemType.Margin = new System.Windows.Forms.Padding(0);
            this.StatSystemType.Name = "StatSystemType";
            this.TablePanelStats.SetRow(this.StatSystemType, 0);
            this.StatSystemType.Size = new System.Drawing.Size(154, 54);
            this.StatSystemType.TabIndex = 1;
            this.StatSystemType.Title = "System Type";
            this.StatSystemType.Value = "Value";
            // 
            // StatModType
            // 
            this.StatModType.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatModType.Appearance.Options.UseBackColor = true;
            this.StatModType.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatModType, 1);
            this.StatModType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatModType.Location = new System.Drawing.Point(154, 0);
            this.StatModType.Margin = new System.Windows.Forms.Padding(0);
            this.StatModType.Name = "StatModType";
            this.TablePanelStats.SetRow(this.StatModType, 0);
            this.StatModType.Size = new System.Drawing.Size(154, 54);
            this.StatModType.TabIndex = 2;
            this.StatModType.Title = "Mod Type";
            this.StatModType.Value = "Value";
            // 
            // StatSubmittedBy
            // 
            this.StatSubmittedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatSubmittedBy.Appearance.Options.UseBackColor = true;
            this.StatSubmittedBy.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatSubmittedBy, 4);
            this.StatSubmittedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatSubmittedBy.Location = new System.Drawing.Point(614, 0);
            this.StatSubmittedBy.Margin = new System.Windows.Forms.Padding(0);
            this.StatSubmittedBy.Name = "StatSubmittedBy";
            this.TablePanelStats.SetRow(this.StatSubmittedBy, 0);
            this.StatSubmittedBy.Size = new System.Drawing.Size(154, 54);
            this.StatSubmittedBy.TabIndex = 4;
            this.StatSubmittedBy.Title = "Submitted By";
            this.StatSubmittedBy.Value = "Value";
            // 
            // StatVersion
            // 
            this.StatVersion.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatVersion.Appearance.Options.UseBackColor = true;
            this.StatVersion.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatVersion, 2);
            this.StatVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatVersion.Location = new System.Drawing.Point(307, 0);
            this.StatVersion.Margin = new System.Windows.Forms.Padding(0);
            this.StatVersion.Name = "StatVersion";
            this.TablePanelStats.SetRow(this.StatVersion, 0);
            this.StatVersion.Size = new System.Drawing.Size(154, 54);
            this.StatVersion.TabIndex = 5;
            this.StatVersion.Title = "Version";
            this.StatVersion.Value = "Value";
            // 
            // StatCreatedBy
            // 
            this.StatCreatedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatCreatedBy.Appearance.Options.UseBackColor = true;
            this.StatCreatedBy.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatCreatedBy, 3);
            this.StatCreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatCreatedBy.Location = new System.Drawing.Point(461, 0);
            this.StatCreatedBy.Margin = new System.Windows.Forms.Padding(0);
            this.StatCreatedBy.Name = "StatCreatedBy";
            this.TablePanelStats.SetRow(this.StatCreatedBy, 0);
            this.StatCreatedBy.Size = new System.Drawing.Size(154, 54);
            this.StatCreatedBy.TabIndex = 3;
            this.StatCreatedBy.Title = "Created By";
            this.StatCreatedBy.Value = "Value";
            // 
            // TabPane
            // 
            this.TabPane.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TabPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPane.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TabPane.Appearance.Options.UseFont = true;
            this.TabPane.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.AppearanceButton.Hovered.Options.UseFont = true;
            this.TabPane.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.AppearanceButton.Normal.Options.UseFont = true;
            this.TabPane.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabPane.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.TabPane.AppearanceButton.Pressed.Options.UseFont = true;
            this.TabPane.Controls.Add(this.TabDescription);
            this.TabPane.Controls.Add(this.TabDownloads);
            this.TabPane.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.Location = new System.Drawing.Point(15, 132);
            this.TabPane.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TabPane.Name = "TabPane";
            this.TabPane.PageProperties.AppearanceCaption.Options.UseBackColor = true;
            this.TabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabDescription,
            this.TabDownloads});
            this.TabPane.RegularSize = new System.Drawing.Size(770, 344);
            this.TabPane.SelectedPage = this.TabDescription;
            this.TabPane.Size = new System.Drawing.Size(770, 344);
            this.TabPane.TabIndex = 0;
            this.TabPane.TransitionAnimationProperties.FrameCount = 900;
            this.TabPane.TransitionAnimationProperties.FrameInterval = 2500;
            // 
            // TabDescription
            // 
            this.TabDescription.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TabDescription.Appearance.Options.UseBackColor = true;
            this.TabDescription.AutoScroll = true;
            this.TabDescription.Caption = "Description";
            this.TabDescription.Controls.Add(this.LabelDescription);
            this.TabDescription.Name = "TabDescription";
            this.TabDescription.Properties.AppearanceCaption.Options.UseBackColor = true;
            this.TabDescription.Size = new System.Drawing.Size(770, 308);
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
            this.TabDownloads.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TabDownloads.Appearance.Options.UseBackColor = true;
            this.TabDownloads.AutoScroll = true;
            this.TabDownloads.Caption = "Downloads";
            this.TabDownloads.Name = "TabDownloads";
            this.TabDownloads.Size = new System.Drawing.Size(776, 294);
            this.TabDownloads.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDownloads_Scroll);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageClose);
            this.PanelHeader.Controls.Add(this.PanelTitle);
            this.PanelHeader.Controls.Add(this.LabelName);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 80);
            this.PanelHeader.TabIndex = 1190;
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
            // ImageClose
            // 
            this.ImageClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageClose.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.ImageClose.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ImageClose.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageClose.Location = new System.Drawing.Point(764, 10);
            this.ImageClose.Name = "ImageClose";
            this.ImageClose.Size = new System.Drawing.Size(26, 26);
            this.ImageClose.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageClose.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageClose.SvgImage")));
            this.ImageClose.TabIndex = 1171;
            this.ImageClose.Text = "Close";
            this.ImageClose.Click += new System.EventHandler(this.ImageClose_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitle.Controls.Add(this.LabelGameMods);
            this.PanelTitle.Controls.Add(this.LabelSlash);
            this.PanelTitle.Controls.Add(this.LabelCategory);
            this.PanelTitle.Controls.Add(this.LabelRegion);
            this.PanelTitle.Location = new System.Drawing.Point(16, 12);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(744, 22);
            this.PanelTitle.TabIndex = 1190;
            this.PanelTitle.WrapContents = false;
            // 
            // LabelGameMods
            // 
            this.LabelGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameMods.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelGameMods.Appearance.Options.UseFont = true;
            this.LabelGameMods.AutoEllipsis = true;
            this.LabelGameMods.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameMods.Location = new System.Drawing.Point(0, 1);
            this.LabelGameMods.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelGameMods.Name = "LabelGameMods";
            this.LabelGameMods.Size = new System.Drawing.Size(73, 17);
            this.LabelGameMods.TabIndex = 1190;
            this.LabelGameMods.Text = "Game Mods";
            // 
            // LabelSlash
            // 
            this.LabelSlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSlash.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelSlash.Appearance.Options.UseFont = true;
            this.LabelSlash.AutoEllipsis = true;
            this.LabelSlash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSlash.Location = new System.Drawing.Point(79, 1);
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
            this.LabelCategory.Appearance.Options.UseTextOptions = true;
            this.LabelCategory.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelCategory.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.LabelCategory.AutoEllipsis = true;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(92, 1);
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
            this.LabelRegion.Location = new System.Drawing.Point(153, 3);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(69, 15);
            this.LabelRegion.TabIndex = 1188;
            this.LabelRegion.Text = "(All Regions)";
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
            this.LabelName.TabIndex = 1170;
            this.LabelName.Text = "Name";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonDownload);
            this.PanelActions.Controls.Add(this.ButtonInstall);
            this.PanelActions.Controls.Add(this.ButtonFavorite);
            this.PanelActions.Controls.Add(this.ButtonReport);
            this.PanelActions.Controls.Add(this.ButtonHelp);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 556);
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
            this.ButtonDownload.TabIndex = 6;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownloadLatest_Click);
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonInstall.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonInstall.Appearance.Options.UseFont = true;
            this.ButtonInstall.Appearance.Options.UseForeColor = true;
            this.ButtonInstall.AutoSize = true;
            this.ButtonInstall.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonInstall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInstall.ImageOptions.ImageToTextIndent = 6;
            this.ButtonInstall.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInstall.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_install;
            this.ButtonInstall.ImageOptions.SvgImageSize = new System.Drawing.Size(17, 17);
            this.ButtonInstall.Location = new System.Drawing.Point(133, 11);
            this.ButtonInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonInstall.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonInstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstall.Size = new System.Drawing.Size(91, 28);
            this.ButtonInstall.TabIndex = 1182;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstallLatest_Click);
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
            this.ButtonFavorite.Location = new System.Drawing.Point(232, 11);
            this.ButtonFavorite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonFavorite.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFavorite.Size = new System.Drawing.Size(149, 28);
            this.ButtonFavorite.TabIndex = 5;
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
            this.ButtonReport.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(127, 28);
            this.ButtonReport.TabIndex = 1181;
            this.ButtonReport.Text = "Report Issue";
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
            this.ButtonHelp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonHelp.ImageOptions.SvgImage")));
            this.ButtonHelp.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonHelp.Location = new System.Drawing.Point(522, 11);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonHelp.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonHelp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonHelp.Size = new System.Drawing.Size(152, 28);
            this.ButtonHelp.TabIndex = 7;
            this.ButtonHelp.Text = "Help && Support";
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // GameModDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameModDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
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
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).EndInit();
            this.TablePanelStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).EndInit();
            this.TabPane.ResumeLayout(false);
            this.TabDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.PanelActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScrollableControl PanelDetails;
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private DevExpress.Utils.SvgImageCollection Images;
        private LabelControl LabelName;
        private LabelControl LabelCategory;
        private LabelControl LabelRegion;
        private LabelControl LabelDescription;
        private PanelControl PanelHeader;
        private SvgImageBox ImageClose;
        private SeparatorControl SeparatorHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private SimpleButton ButtonFavorite;
        private DevExpress.XtraBars.Navigation.TabPane TabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDescription;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDownloads;
        private LabelControl LabelGameMods;
        private LabelControl LabelSlash;
        private DevExpress.Utils.Layout.TablePanel TablePanelStats;
        private Controls.StatItem StatGameMode;
        private Controls.StatItem StatVersion;
        private Controls.StatItem StatSubmittedBy;
        private Controls.StatItem StatCreatedBy;
        private Controls.StatItem StatModType;
        private Controls.StatItem StatSystemType;
        private Controls.StatItem StatLastUpdated;
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonHelp;
        private SimpleButton ButtonReport;
        private SimpleButton ButtonInstall;
    }
}