using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs.Details
{
    partial class CustomModDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomModDialog));
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.TablePanelStats = new DevExpress.Utils.Layout.TablePanel();
            this.StatGameMode = new ArisenStudio.Controls.StatItem();
            this.StatSubmittedBy = new ArisenStudio.Controls.StatItem();
            this.StatLastUpdated = new ArisenStudio.Controls.StatItem();
            this.StatVersion = new ArisenStudio.Controls.StatItem();
            this.StatModType = new ArisenStudio.Controls.StatItem();
            this.StatCreatedBy = new ArisenStudio.Controls.StatItem();
            this.StatPlatform = new ArisenStudio.Controls.StatItem();
            this.TabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabDescription = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.TabInstallationFiles = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelCategoryType = new DevExpress.XtraEditors.LabelControl();
            this.LabelSlash = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEditDetails = new DevExpress.XtraEditors.SimpleButton();
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
            this.TablePanelStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelStats.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F)});
            this.TablePanelStats.Controls.Add(this.StatGameMode);
            this.TablePanelStats.Controls.Add(this.StatSubmittedBy);
            this.TablePanelStats.Controls.Add(this.StatLastUpdated);
            this.TablePanelStats.Controls.Add(this.StatVersion);
            this.TablePanelStats.Controls.Add(this.StatModType);
            this.TablePanelStats.Controls.Add(this.StatCreatedBy);
            this.TablePanelStats.Controls.Add(this.StatPlatform);
            this.TablePanelStats.Location = new System.Drawing.Point(16, 14);
            this.TablePanelStats.Name = "TablePanelStats";
            this.TablePanelStats.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.TablePanelStats.Size = new System.Drawing.Size(772, 117);
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
            this.StatGameMode.Location = new System.Drawing.Point(0, 59);
            this.StatGameMode.Margin = new System.Windows.Forms.Padding(0);
            this.StatGameMode.Name = "StatGameMode";
            this.TablePanelStats.SetRow(this.StatGameMode, 1);
            this.StatGameMode.Size = new System.Drawing.Size(140, 58);
            this.StatGameMode.TabIndex = 6;
            this.StatGameMode.Title = "Game Mode";
            this.StatGameMode.Value = "Value";
            // 
            // StatSubmittedBy
            // 
            this.StatSubmittedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatSubmittedBy.Appearance.Options.UseBackColor = true;
            this.StatSubmittedBy.Appearance.Options.UseFont = true;
            this.StatSubmittedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatSubmittedBy.Location = new System.Drawing.Point(570, 0);
            this.StatSubmittedBy.Margin = new System.Windows.Forms.Padding(0);
            this.StatSubmittedBy.Name = "StatSubmittedBy";
            this.StatSubmittedBy.Size = new System.Drawing.Size(202, 59);
            this.StatSubmittedBy.TabIndex = 4;
            this.StatSubmittedBy.Title = "Submitted By";
            this.StatSubmittedBy.Value = "Value";
            // 
            // StatLastUpdated
            // 
            this.StatLastUpdated.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatLastUpdated.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatLastUpdated.Appearance.Options.UseBackColor = true;
            this.StatLastUpdated.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatLastUpdated, 1);
            this.StatLastUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatLastUpdated.Location = new System.Drawing.Point(140, 59);
            this.StatLastUpdated.Margin = new System.Windows.Forms.Padding(0);
            this.StatLastUpdated.Name = "StatLastUpdated";
            this.TablePanelStats.SetRow(this.StatLastUpdated, 1);
            this.StatLastUpdated.Size = new System.Drawing.Size(140, 58);
            this.StatLastUpdated.TabIndex = 0;
            this.StatLastUpdated.Title = "Last Updated";
            this.StatLastUpdated.Value = "Value";
            // 
            // StatVersion
            // 
            this.StatVersion.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatVersion.Appearance.Options.UseBackColor = true;
            this.StatVersion.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatVersion, 2);
            this.StatVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatVersion.Location = new System.Drawing.Point(280, 0);
            this.StatVersion.Margin = new System.Windows.Forms.Padding(0);
            this.StatVersion.Name = "StatVersion";
            this.TablePanelStats.SetRow(this.StatVersion, 0);
            this.StatVersion.Size = new System.Drawing.Size(140, 59);
            this.StatVersion.TabIndex = 5;
            this.StatVersion.Title = "Version";
            this.StatVersion.Value = "Value";
            // 
            // StatModType
            // 
            this.StatModType.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatModType.Appearance.Options.UseBackColor = true;
            this.StatModType.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatModType, 1);
            this.StatModType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatModType.Location = new System.Drawing.Point(140, 0);
            this.StatModType.Margin = new System.Windows.Forms.Padding(0);
            this.StatModType.Name = "StatModType";
            this.TablePanelStats.SetRow(this.StatModType, 0);
            this.StatModType.Size = new System.Drawing.Size(140, 59);
            this.StatModType.TabIndex = 2;
            this.StatModType.Title = "Mod Type";
            this.StatModType.Value = "Value";
            // 
            // StatCreatedBy
            // 
            this.StatCreatedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatCreatedBy.Appearance.Options.UseBackColor = true;
            this.StatCreatedBy.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatCreatedBy, 3);
            this.StatCreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatCreatedBy.Location = new System.Drawing.Point(420, 0);
            this.StatCreatedBy.Margin = new System.Windows.Forms.Padding(0);
            this.StatCreatedBy.Name = "StatCreatedBy";
            this.TablePanelStats.SetRow(this.StatCreatedBy, 0);
            this.StatCreatedBy.Size = new System.Drawing.Size(150, 59);
            this.StatCreatedBy.TabIndex = 3;
            this.StatCreatedBy.Title = "Created By";
            this.StatCreatedBy.Value = "Value";
            // 
            // StatPlatform
            // 
            this.StatPlatform.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatPlatform.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatPlatform.Appearance.Options.UseBackColor = true;
            this.StatPlatform.Appearance.Options.UseFont = true;
            this.TablePanelStats.SetColumn(this.StatPlatform, 0);
            this.StatPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatPlatform.Location = new System.Drawing.Point(0, 0);
            this.StatPlatform.Margin = new System.Windows.Forms.Padding(0);
            this.StatPlatform.Name = "StatPlatform";
            this.TablePanelStats.SetRow(this.StatPlatform, 0);
            this.StatPlatform.Size = new System.Drawing.Size(140, 59);
            this.StatPlatform.TabIndex = 1;
            this.StatPlatform.Title = "Platform";
            this.StatPlatform.Value = "Value";
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
            this.TabPane.Controls.Add(this.TabInstallationFiles);
            this.TabPane.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.Location = new System.Drawing.Point(12, 132);
            this.TabPane.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.TabPane.Name = "TabPane";
            this.TabPane.PageProperties.AppearanceCaption.Options.UseBackColor = true;
            this.TabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabDescription,
            this.TabInstallationFiles});
            this.TabPane.RegularSize = new System.Drawing.Size(776, 338);
            this.TabPane.SelectedPage = this.TabDescription;
            this.TabPane.Size = new System.Drawing.Size(776, 338);
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
            this.TabDescription.Size = new System.Drawing.Size(776, 302);
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
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(8);
            this.LabelDescription.Size = new System.Drawing.Size(776, 31);
            this.LabelDescription.TabIndex = 1176;
            this.LabelDescription.Text = "...";
            this.LabelDescription.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelDescription_HyperlinkClick);
            // 
            // TabInstallationFiles
            // 
            this.TabInstallationFiles.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TabInstallationFiles.Appearance.Options.UseBackColor = true;
            this.TabInstallationFiles.AutoScroll = true;
            this.TabInstallationFiles.Caption = "Installation Files";
            this.TabInstallationFiles.Name = "TabInstallationFiles";
            this.TabInstallationFiles.Size = new System.Drawing.Size(776, 302);
            this.TabInstallationFiles.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDownloads_Scroll);
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
            this.PanelTitle.Controls.Add(this.LabelCategoryType);
            this.PanelTitle.Controls.Add(this.LabelSlash);
            this.PanelTitle.Controls.Add(this.LabelCategory);
            this.PanelTitle.Location = new System.Drawing.Point(16, 12);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(744, 22);
            this.PanelTitle.TabIndex = 1190;
            this.PanelTitle.WrapContents = false;
            // 
            // LabelCategoryType
            // 
            this.LabelCategoryType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategoryType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCategoryType.Appearance.Options.UseFont = true;
            this.LabelCategoryType.AutoEllipsis = true;
            this.LabelCategoryType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategoryType.Location = new System.Drawing.Point(0, 1);
            this.LabelCategoryType.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelCategoryType.Name = "LabelCategoryType";
            this.LabelCategoryType.Size = new System.Drawing.Size(89, 17);
            this.LabelCategoryType.TabIndex = 1190;
            this.LabelCategoryType.Text = "Category Type";
            // 
            // LabelSlash
            // 
            this.LabelSlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSlash.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelSlash.Appearance.Options.UseFont = true;
            this.LabelSlash.AutoEllipsis = true;
            this.LabelSlash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSlash.Location = new System.Drawing.Point(95, 1);
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
            this.LabelCategory.Location = new System.Drawing.Point(108, 1);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 10);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(55, 17);
            this.LabelCategory.TabIndex = 1184;
            this.LabelCategory.Text = "Category";
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
            this.PanelActions.Controls.Add(this.ButtonInstall);
            this.PanelActions.Controls.Add(this.ButtonEditDetails);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 556);
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
            this.ButtonInstall.AutoSize = true;
            this.ButtonInstall.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonInstall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInstall.ImageOptions.ImageToTextIndent = 6;
            this.ButtonInstall.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInstall.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_install;
            this.ButtonInstall.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonInstall.Location = new System.Drawing.Point(12, 10);
            this.ButtonInstall.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.ButtonInstall.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonInstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstall.Size = new System.Drawing.Size(90, 30);
            this.ButtonInstall.TabIndex = 6;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstallMod_Click);
            // 
            // ButtonEditDetails
            // 
            this.ButtonEditDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonEditDetails.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonEditDetails.Appearance.Options.UseFont = true;
            this.ButtonEditDetails.Appearance.Options.UseForeColor = true;
            this.ButtonEditDetails.AutoSize = true;
            this.ButtonEditDetails.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonEditDetails.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonEditDetails.ImageOptions.ImageToTextIndent = 6;
            this.ButtonEditDetails.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonEditDetails.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_edit;
            this.ButtonEditDetails.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonEditDetails.Location = new System.Drawing.Point(109, 10);
            this.ButtonEditDetails.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonEditDetails.Name = "ButtonEditDetails";
            this.ButtonEditDetails.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonEditDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditDetails.Size = new System.Drawing.Size(78, 30);
            this.ButtonEditDetails.TabIndex = 1181;
            this.ButtonEditDetails.Text = "Edit";
            this.ButtonEditDetails.Click += new System.EventHandler(this.ButtonEditDetails_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // CustomModDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("CustomModDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomModDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CustomModDialog_Load);
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
        private LabelControl LabelDescription;
        private PanelControl PanelHeader;
        private SvgImageBox ImageClose;
        private SeparatorControl SeparatorHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private DevExpress.XtraBars.Navigation.TabPane TabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDescription;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabInstallationFiles;
        private LabelControl LabelCategoryType;
        private LabelControl LabelSlash;
        private SimpleButton ButtonInstall;
        private SimpleButton ButtonEditDetails;
        private DevExpress.Utils.Layout.TablePanel TablePanelStats;
        private Controls.StatItem StatGameMode;
        private Controls.StatItem StatSubmittedBy;
        private Controls.StatItem StatLastUpdated;
        private Controls.StatItem StatVersion;
        private Controls.StatItem StatModType;
        private Controls.StatItem StatCreatedBy;
        private Controls.StatItem StatPlatform;
    }
}