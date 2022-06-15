using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenMods.Forms.Dialogs.Details
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
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.PanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelResources = new DevExpress.XtraEditors.LabelControl();
            this.LabelSlash = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelHomebrewItemActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonFavorite = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonReport = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.TabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabDescription = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.TabDownloads = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.TablePanelStats = new DevExpress.Utils.Layout.TablePanel();
            this.StatVersion = new ArisenMods.Controls.StatItem();
            this.StatSubmittedBy = new ArisenMods.Controls.StatItem();
            this.StatCreatedBy = new ArisenMods.Controls.StatItem();
            this.StatModType = new ArisenMods.Controls.StatItem();
            this.StatSystemType = new ArisenMods.Controls.StatItem();
            this.StatLastUpdated = new ArisenMods.Controls.StatItem();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHomebrewItemActions)).BeginInit();
            this.PanelHomebrewItemActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).BeginInit();
            this.TabPane.SuspendLayout();
            this.TabDescription.SuspendLayout();
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).BeginInit();
            this.TablePanelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHomebrewDetails
            // 
            this.PanelHomebrewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHomebrewDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelHomebrewDetails.Name = "PanelHomebrewDetails";
            this.PanelHomebrewDetails.Size = new System.Drawing.Size(800, 476);
            this.PanelHomebrewDetails.TabIndex = 1;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.PanelTitle);
            this.PanelHeader.Controls.Add(this.LabelName);
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageClose);
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
            this.PanelTitle.Controls.Add(this.LabelResources);
            this.PanelTitle.Controls.Add(this.LabelSlash);
            this.PanelTitle.Controls.Add(this.LabelCategory);
            this.PanelTitle.Location = new System.Drawing.Point(16, 12);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(744, 22);
            this.PanelTitle.TabIndex = 1192;
            this.PanelTitle.WrapContents = false;
            // 
            // LabelResources
            // 
            this.LabelResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResources.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelResources.Appearance.Options.UseFont = true;
            this.LabelResources.AutoEllipsis = true;
            this.LabelResources.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResources.Location = new System.Drawing.Point(0, 1);
            this.LabelResources.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelResources.Name = "LabelResources";
            this.LabelResources.Size = new System.Drawing.Size(61, 17);
            this.LabelResources.TabIndex = 1190;
            this.LabelResources.Text = "Resources";
            // 
            // LabelSlash
            // 
            this.LabelSlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSlash.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelSlash.Appearance.Options.UseFont = true;
            this.LabelSlash.AutoEllipsis = true;
            this.LabelSlash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSlash.Location = new System.Drawing.Point(67, 1);
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
            this.LabelCategory.Location = new System.Drawing.Point(80, 1);
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
            this.LabelName.Size = new System.Drawing.Size(772, 20);
            this.LabelName.TabIndex = 1191;
            this.LabelName.Text = "Name";
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
            this.ImageClose.Location = new System.Drawing.Point(764, 10);
            this.ImageClose.Name = "ImageClose";
            this.ImageClose.Size = new System.Drawing.Size(26, 26);
            this.ImageClose.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageClose.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageClose.SvgImage")));
            this.ImageClose.TabIndex = 1171;
            this.ImageClose.Text = "Close";
            this.ImageClose.Click += new System.EventHandler(this.ImageClose_Click);
            // 
            // PanelHomebrewItemActions
            // 
            this.PanelHomebrewItemActions.Controls.Add(this.ButtonFavorite);
            this.PanelHomebrewItemActions.Controls.Add(this.ButtonReport);
            this.PanelHomebrewItemActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelHomebrewItemActions.Location = new System.Drawing.Point(0, 556);
            this.PanelHomebrewItemActions.Name = "PanelHomebrewItemActions";
            this.PanelHomebrewItemActions.Size = new System.Drawing.Size(800, 50);
            this.PanelHomebrewItemActions.TabIndex = 1175;
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
            this.ButtonFavorite.Location = new System.Drawing.Point(12, 12);
            this.ButtonFavorite.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFavorite.Size = new System.Drawing.Size(140, 26);
            this.ButtonFavorite.TabIndex = 1181;
            this.ButtonFavorite.Text = "Add to Favorites";
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
            this.ButtonReport.Location = new System.Drawing.Point(158, 12);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(120, 26);
            this.ButtonReport.TabIndex = 1180;
            this.ButtonReport.Text = "Report Issue";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReportIssue_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // TabPane
            // 
            this.TabPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPane.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TabPane.AppearanceButton.Hovered.Options.UseFont = true;
            this.TabPane.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TabPane.AppearanceButton.Normal.Options.UseFont = true;
            this.TabPane.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.TabPane.AppearanceButton.Pressed.Options.UseFont = true;
            this.TabPane.Controls.Add(this.TabDescription);
            this.TabPane.Controls.Add(this.TabDownloads);
            this.TabPane.Location = new System.Drawing.Point(12, 132);
            this.TabPane.Name = "TabPane";
            this.TabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabDescription,
            this.TabDownloads});
            this.TabPane.RegularSize = new System.Drawing.Size(776, 338);
            this.TabPane.SelectedPage = this.TabDescription;
            this.TabPane.Size = new System.Drawing.Size(776, 338);
            this.TabPane.TabIndex = 1195;
            this.TabPane.Text = "TabPane";
            // 
            // TabDescription
            // 
            this.TabDescription.AutoScroll = true;
            this.TabDescription.Caption = "Description";
            this.TabDescription.Controls.Add(this.LabelDescription);
            this.TabDescription.Name = "TabDescription";
            this.TabDescription.Size = new System.Drawing.Size(776, 309);
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
            this.LabelDescription.Size = new System.Drawing.Size(776, 23);
            this.LabelDescription.TabIndex = 1176;
            this.LabelDescription.Text = "...";
            // 
            // TabDownloads
            // 
            this.TabDownloads.AutoScroll = true;
            this.TabDownloads.Caption = "Downloads";
            this.TabDownloads.Name = "TabDownloads";
            this.TabDownloads.Size = new System.Drawing.Size(776, 295);
            this.TabDownloads.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDownloads_Scroll);
            // 
            // PanelDetails
            // 
            this.PanelDetails.Controls.Add(this.TablePanelStats);
            this.PanelDetails.Controls.Add(this.TabPane);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(800, 476);
            this.PanelDetails.TabIndex = 1196;
            // 
            // TablePanelStats
            // 
            this.TablePanelStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelStats.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 19.85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40.15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.TablePanelStats.Controls.Add(this.StatVersion);
            this.TablePanelStats.Controls.Add(this.StatSubmittedBy);
            this.TablePanelStats.Controls.Add(this.StatCreatedBy);
            this.TablePanelStats.Controls.Add(this.StatModType);
            this.TablePanelStats.Controls.Add(this.StatSystemType);
            this.TablePanelStats.Controls.Add(this.StatLastUpdated);
            this.TablePanelStats.Location = new System.Drawing.Point(14, 14);
            this.TablePanelStats.Name = "TablePanelStats";
            this.TablePanelStats.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.TablePanelStats.Size = new System.Drawing.Size(773, 101);
            this.TablePanelStats.TabIndex = 1205;
            // 
            // StatVersion
            // 
            this.StatVersion.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatVersion.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatVersion, 0);
            this.StatVersion.Location = new System.Drawing.Point(3, 56);
            this.StatVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatVersion.Name = "StatVersion";
            this.TablePanelStats.SetRow(this.StatVersion, 1);
            this.StatVersion.Size = new System.Drawing.Size(140, 35);
            this.StatVersion.TabIndex = 5;
            this.StatVersion.Title = "Version";
            this.StatVersion.Value = "Value";
            // 
            // StatSubmittedBy
            // 
            this.StatSubmittedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSubmittedBy.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatSubmittedBy, 4);
            this.StatSubmittedBy.Location = new System.Drawing.Point(587, 3);
            this.StatSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatSubmittedBy.Name = "StatSubmittedBy";
            this.TablePanelStats.SetRow(this.StatSubmittedBy, 0);
            this.StatSubmittedBy.Size = new System.Drawing.Size(140, 40);
            this.StatSubmittedBy.TabIndex = 4;
            this.StatSubmittedBy.Title = "Submitted By";
            this.StatSubmittedBy.Value = "Value";
            // 
            // StatCreatedBy
            // 
            this.StatCreatedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatCreatedBy.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatCreatedBy, 3);
            this.StatCreatedBy.Location = new System.Drawing.Point(441, 3);
            this.StatCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatCreatedBy.Name = "StatCreatedBy";
            this.TablePanelStats.SetRow(this.StatCreatedBy, 0);
            this.StatCreatedBy.Size = new System.Drawing.Size(140, 40);
            this.StatCreatedBy.TabIndex = 3;
            this.StatCreatedBy.Title = "Created By";
            this.StatCreatedBy.Value = "Value";
            // 
            // StatModType
            // 
            this.StatModType.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatModType.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatModType, 2);
            this.StatModType.Location = new System.Drawing.Point(295, 3);
            this.StatModType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatModType.Name = "StatModType";
            this.TablePanelStats.SetRow(this.StatModType, 0);
            this.StatModType.Size = new System.Drawing.Size(140, 40);
            this.StatModType.TabIndex = 2;
            this.StatModType.Title = "Mod Type";
            this.StatModType.Value = "Value";
            // 
            // StatSystemType
            // 
            this.StatSystemType.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSystemType.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatSystemType, 1);
            this.StatSystemType.Location = new System.Drawing.Point(149, 3);
            this.StatSystemType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatSystemType.Name = "StatSystemType";
            this.TablePanelStats.SetRow(this.StatSystemType, 0);
            this.StatSystemType.Size = new System.Drawing.Size(140, 40);
            this.StatSystemType.TabIndex = 1;
            this.StatSystemType.Title = "System Type";
            this.StatSystemType.Value = "Value";
            // 
            // StatLastUpdated
            // 
            this.StatLastUpdated.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatLastUpdated.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatLastUpdated, 0);
            this.StatLastUpdated.Location = new System.Drawing.Point(3, 3);
            this.StatLastUpdated.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatLastUpdated.Name = "StatLastUpdated";
            this.TablePanelStats.SetRow(this.StatLastUpdated, 0);
            this.StatLastUpdated.Size = new System.Drawing.Size(140, 40);
            this.StatLastUpdated.TabIndex = 0;
            this.StatLastUpdated.Title = "Last Updated";
            this.StatLastUpdated.Value = "Value";
            // 
            // ResourceDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelHomebrewDetails);
            this.Controls.Add(this.PanelHomebrewItemActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ResourceDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenMods.Properties.Resources.arisenmods;
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
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHomebrewItemActions)).EndInit();
            this.PanelHomebrewItemActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).EndInit();
            this.TabPane.ResumeLayout(false);
            this.TabDescription.ResumeLayout(false);
            this.PanelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).EndInit();
            this.TablePanelStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScrollableControl PanelHomebrewDetails;
        private DevExpress.Utils.Layout.StackPanel PanelHomebrewItemActions;
        private DevExpress.Utils.SvgImageCollection Images;
        private PanelControl PanelHeader;
        private SeparatorControl SeparatorHeader;
        private SvgImageBox ImageClose;
        private SimpleButton ButtonFavorite;
        private SimpleButton ButtonReport;
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private LabelControl LabelResources;
        private LabelControl LabelSlash;
        private LabelControl LabelCategory;
        private LabelControl LabelName;
        private XtraScrollableControl PanelDetails;
        private DevExpress.XtraBars.Navigation.TabPane TabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDescription;
        private LabelControl LabelDescription;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDownloads;
        private DevExpress.Utils.Layout.TablePanel TablePanelStats;
        private Controls.StatItem StatVersion;
        private Controls.StatItem StatSubmittedBy;
        private Controls.StatItem StatCreatedBy;
        private Controls.StatItem StatModType;
        private Controls.StatItem StatSystemType;
        private Controls.StatItem StatLastUpdated;
    }
}