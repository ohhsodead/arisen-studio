using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs.Details
{
    partial class ApplicationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationDialog));
            this.PanelAppsDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.TablePanelStats = new DevExpress.Utils.Layout.TablePanel();
            this.StatLastUpdated = new ArisenStudio.Controls.StatItem();
            this.StatSubmittedBy = new ArisenStudio.Controls.StatItem();
            this.StatCreatedBy = new ArisenStudio.Controls.StatItem();
            this.StatVersion = new ArisenStudio.Controls.StatItem();
            this.StatFwVersions = new ArisenStudio.Controls.StatItem();
            this.StatTitleId = new ArisenStudio.Controls.StatItem();
            this.TabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabDescription = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.TabDownloads = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.PanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelApplications = new DevExpress.XtraEditors.LabelControl();
            this.LabelSlash = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelAppsItemActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFavorite = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonHelpSupport = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.ButtonReportIssue = new DevExpress.XtraEditors.SimpleButton();
            this.PanelAppsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).BeginInit();
            this.TablePanelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).BeginInit();
            this.TabPane.SuspendLayout();
            this.TabDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAppsItemActions)).BeginInit();
            this.PanelAppsItemActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAppsDetails
            // 
            this.PanelAppsDetails.Controls.Add(this.TablePanelStats);
            this.PanelAppsDetails.Controls.Add(this.TabPane);
            this.PanelAppsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAppsDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelAppsDetails.Name = "PanelAppsDetails";
            this.PanelAppsDetails.Size = new System.Drawing.Size(800, 476);
            this.PanelAppsDetails.TabIndex = 1;
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
            this.TablePanelStats.Controls.Add(this.StatLastUpdated);
            this.TablePanelStats.Controls.Add(this.StatSubmittedBy);
            this.TablePanelStats.Controls.Add(this.StatCreatedBy);
            this.TablePanelStats.Controls.Add(this.StatVersion);
            this.TablePanelStats.Controls.Add(this.StatFwVersions);
            this.TablePanelStats.Controls.Add(this.StatTitleId);
            this.TablePanelStats.Location = new System.Drawing.Point(16, 14);
            this.TablePanelStats.Name = "TablePanelStats";
            this.TablePanelStats.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.TablePanelStats.Size = new System.Drawing.Size(768, 108);
            this.TablePanelStats.TabIndex = 7;
            // 
            // StatLastUpdated
            // 
            this.StatLastUpdated.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatLastUpdated.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatLastUpdated.Appearance.Options.UseBackColor = true;
            this.StatLastUpdated.Appearance.Options.UseFont = true;
            this.StatLastUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatLastUpdated.Location = new System.Drawing.Point(0, 54);
            this.StatLastUpdated.Margin = new System.Windows.Forms.Padding(0);
            this.StatLastUpdated.Name = "StatLastUpdated";
            this.StatLastUpdated.Size = new System.Drawing.Size(154, 54);
            this.StatLastUpdated.TabIndex = 5;
            this.StatLastUpdated.Title = "Last Updated";
            this.StatLastUpdated.Value = "Value";
            // 
            // StatSubmittedBy
            // 
            this.StatSubmittedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatSubmittedBy.Appearance.Options.UseBackColor = true;
            this.StatSubmittedBy.Appearance.Options.UseFont = true;
            this.StatSubmittedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatSubmittedBy.Location = new System.Drawing.Point(616, 0);
            this.StatSubmittedBy.Margin = new System.Windows.Forms.Padding(0);
            this.StatSubmittedBy.Name = "StatSubmittedBy";
            this.StatSubmittedBy.Size = new System.Drawing.Size(154, 54);
            this.StatSubmittedBy.TabIndex = 4;
            this.StatSubmittedBy.Title = "Submitted By";
            this.StatSubmittedBy.Value = "Value";
            // 
            // StatCreatedBy
            // 
            this.StatCreatedBy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatCreatedBy.Appearance.Options.UseBackColor = true;
            this.StatCreatedBy.Appearance.Options.UseFont = true;
            this.StatCreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatCreatedBy.Location = new System.Drawing.Point(462, 0);
            this.StatCreatedBy.Margin = new System.Windows.Forms.Padding(0);
            this.StatCreatedBy.Name = "StatCreatedBy";
            this.StatCreatedBy.Size = new System.Drawing.Size(154, 54);
            this.StatCreatedBy.TabIndex = 3;
            this.StatCreatedBy.Title = "Created By";
            this.StatCreatedBy.Value = "Value";
            // 
            // StatVersion
            // 
            this.StatVersion.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatVersion.Appearance.Options.UseBackColor = true;
            this.StatVersion.Appearance.Options.UseFont = true;
            this.StatVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatVersion.Location = new System.Drawing.Point(308, 0);
            this.StatVersion.Margin = new System.Windows.Forms.Padding(0);
            this.StatVersion.Name = "StatVersion";
            this.StatVersion.Size = new System.Drawing.Size(154, 54);
            this.StatVersion.TabIndex = 2;
            this.StatVersion.Title = "Version";
            this.StatVersion.Value = "Value";
            // 
            // StatFwVersions
            // 
            this.StatFwVersions.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatFwVersions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatFwVersions.Appearance.Options.UseBackColor = true;
            this.StatFwVersions.Appearance.Options.UseFont = true;
            this.StatFwVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatFwVersions.Location = new System.Drawing.Point(154, 0);
            this.StatFwVersions.Margin = new System.Windows.Forms.Padding(0);
            this.StatFwVersions.Name = "StatFwVersions";
            this.StatFwVersions.Size = new System.Drawing.Size(154, 54);
            this.StatFwVersions.TabIndex = 1;
            this.StatFwVersions.Title = "Firmware Versions";
            this.StatFwVersions.Value = "Value";
            // 
            // StatTitleId
            // 
            this.StatTitleId.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatTitleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StatTitleId.Appearance.Options.UseBackColor = true;
            this.StatTitleId.Appearance.Options.UseFont = true;
            this.StatTitleId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatTitleId.Location = new System.Drawing.Point(0, 0);
            this.StatTitleId.Margin = new System.Windows.Forms.Padding(0);
            this.StatTitleId.Name = "StatTitleId";
            this.StatTitleId.Size = new System.Drawing.Size(154, 54);
            this.StatTitleId.TabIndex = 0;
            this.StatTitleId.Title = "Title ID";
            this.StatTitleId.Value = "Value";
            // 
            // TabPane
            // 
            this.TabPane.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TabPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPane.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.AppearanceButton.Hovered.Options.UseFont = true;
            this.TabPane.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.AppearanceButton.Normal.Options.UseFont = true;
            this.TabPane.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabPane.AppearanceButton.Pressed.Options.UseFont = true;
            this.TabPane.Controls.Add(this.TabDescription);
            this.TabPane.Controls.Add(this.TabDownloads);
            this.TabPane.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPane.Location = new System.Drawing.Point(15, 132);
            this.TabPane.Margin = new System.Windows.Forms.Padding(3, 10, 3, 6);
            this.TabPane.Name = "TabPane";
            this.TabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabDescription,
            this.TabDownloads});
            this.TabPane.RegularSize = new System.Drawing.Size(770, 344);
            this.TabPane.SelectedPage = this.TabDescription;
            this.TabPane.Size = new System.Drawing.Size(770, 344);
            this.TabPane.TabIndex = 8;
            this.TabPane.Text = "TabPane";
            this.TabPane.TransitionAnimationProperties.FrameCount = 900;
            this.TabPane.TransitionAnimationProperties.FrameInterval = 2500;
            // 
            // TabDescription
            // 
            this.TabDescription.AutoScroll = true;
            this.TabDescription.Caption = "Description";
            this.TabDescription.Controls.Add(this.LabelDescription);
            this.TabDescription.Name = "TabDescription";
            this.TabDescription.Size = new System.Drawing.Size(770, 308);
            this.TabDescription.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDescription_Scroll);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AllowHtmlString = true;
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
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
            this.LabelDescription.TabIndex = 6;
            this.LabelDescription.Text = "...";
            this.LabelDescription.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelDescription_HyperlinkClick);
            // 
            // TabDownloads
            // 
            this.TabDownloads.AutoScroll = true;
            this.TabDownloads.Caption = "Downloads";
            this.TabDownloads.Name = "TabDownloads";
            this.TabDownloads.Size = new System.Drawing.Size(770, 308);
            this.TabDownloads.Scroll += new DevExpress.XtraEditors.XtraScrollEventHandler(this.TabDownloads_Scroll);
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
            this.PanelTitle.Controls.Add(this.LabelApplications);
            this.PanelTitle.Controls.Add(this.LabelSlash);
            this.PanelTitle.Controls.Add(this.LabelCategory);
            this.PanelTitle.Location = new System.Drawing.Point(16, 12);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(744, 22);
            this.PanelTitle.TabIndex = 0;
            this.PanelTitle.WrapContents = false;
            // 
            // LabelApplications
            // 
            this.LabelApplications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelApplications.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelApplications.Appearance.Options.UseFont = true;
            this.LabelApplications.AutoEllipsis = true;
            this.LabelApplications.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelApplications.Location = new System.Drawing.Point(0, 1);
            this.LabelApplications.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelApplications.Name = "LabelApplications";
            this.LabelApplications.Size = new System.Drawing.Size(77, 17);
            this.LabelApplications.TabIndex = 0;
            this.LabelApplications.Text = "Applications";
            // 
            // LabelSlash
            // 
            this.LabelSlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSlash.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelSlash.Appearance.Options.UseFont = true;
            this.LabelSlash.AutoEllipsis = true;
            this.LabelSlash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSlash.Location = new System.Drawing.Point(83, 1);
            this.LabelSlash.Margin = new System.Windows.Forms.Padding(3, 1, 3, 10);
            this.LabelSlash.Name = "LabelSlash";
            this.LabelSlash.Size = new System.Drawing.Size(7, 17);
            this.LabelSlash.TabIndex = 1;
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
            this.LabelCategory.Location = new System.Drawing.Point(96, 1);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 10);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(55, 17);
            this.LabelCategory.TabIndex = 2;
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
            this.LabelName.TabIndex = 5;
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
            this.SeparatorHeader.TabIndex = 6;
            // 
            // ImageClose
            // 
            this.ImageClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageClose.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.ImageClose.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ImageClose.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageClose.Location = new System.Drawing.Point(764, 10);
            this.ImageClose.Name = "ImageClose";
            this.ImageClose.Size = new System.Drawing.Size(26, 26);
            this.ImageClose.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageClose.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageClose.SvgImage")));
            this.ImageClose.TabIndex = 4;
            this.ImageClose.Text = "Close";
            this.ImageClose.Click += new System.EventHandler(this.ImageClose_Click);
            // 
            // PanelAppsItemActions
            // 
            this.PanelAppsItemActions.Controls.Add(this.ButtonDownload);
            this.PanelAppsItemActions.Controls.Add(this.ButtonInstall);
            this.PanelAppsItemActions.Controls.Add(this.ButtonFavorite);
            this.PanelAppsItemActions.Controls.Add(this.ButtonReportIssue);
            this.PanelAppsItemActions.Controls.Add(this.ButtonHelpSupport);
            this.PanelAppsItemActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAppsItemActions.Location = new System.Drawing.Point(0, 556);
            this.PanelAppsItemActions.Name = "PanelAppsItemActions";
            this.PanelAppsItemActions.Size = new System.Drawing.Size(800, 50);
            this.PanelAppsItemActions.TabIndex = 1175;
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
            this.ButtonDownload.Location = new System.Drawing.Point(12, 10);
            this.ButtonDownload.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.ButtonDownload.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownload.Size = new System.Drawing.Size(113, 30);
            this.ButtonDownload.TabIndex = 9;
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
            this.ButtonInstall.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_install;
            this.ButtonInstall.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonInstall.Location = new System.Drawing.Point(133, 10);
            this.ButtonInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonInstall.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonInstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstall.Size = new System.Drawing.Size(90, 30);
            this.ButtonInstall.TabIndex = 10;
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
            this.ButtonFavorite.Location = new System.Drawing.Point(231, 10);
            this.ButtonFavorite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonFavorite.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFavorite.Size = new System.Drawing.Size(149, 30);
            this.ButtonFavorite.TabIndex = 11;
            this.ButtonFavorite.Text = "Add to Favorites";
            this.ButtonFavorite.Click += new System.EventHandler(this.ButtonFavorite_Click);
            // 
            // ButtonHelpSupport
            // 
            this.ButtonHelpSupport.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonHelpSupport.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonHelpSupport.Appearance.Options.UseFont = true;
            this.ButtonHelpSupport.Appearance.Options.UseForeColor = true;
            this.ButtonHelpSupport.AutoSize = true;
            this.ButtonHelpSupport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonHelpSupport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonHelpSupport.ImageOptions.ImageToTextIndent = 4;
            this.ButtonHelpSupport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonHelpSupport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.ButtonHelpSupport.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonHelpSupport.Location = new System.Drawing.Point(521, 10);
            this.ButtonHelpSupport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonHelpSupport.MinimumSize = new System.Drawing.Size(0, 30);
            this.ButtonHelpSupport.Name = "ButtonHelpSupport";
            this.ButtonHelpSupport.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonHelpSupport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonHelpSupport.Size = new System.Drawing.Size(152, 30);
            this.ButtonHelpSupport.TabIndex = 12;
            this.ButtonHelpSupport.Text = "Help && Support";
            this.ButtonHelpSupport.Click += new System.EventHandler(this.ButtonHelpSupport_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // ButtonReportIssue
            // 
            this.ButtonReportIssue.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonReportIssue.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonReportIssue.Appearance.Options.UseFont = true;
            this.ButtonReportIssue.Appearance.Options.UseForeColor = true;
            this.ButtonReportIssue.AutoSize = true;
            this.ButtonReportIssue.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonReportIssue.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonReportIssue.ImageOptions.ImageToTextIndent = 6;
            this.ButtonReportIssue.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonReportIssue.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonReport.ImageOptions.SvgImage")));
            this.ButtonReportIssue.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonReportIssue.Location = new System.Drawing.Point(387, 11);
            this.ButtonReportIssue.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonReportIssue.Name = "ButtonReportIssue";
            this.ButtonReportIssue.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonReportIssue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReportIssue.Size = new System.Drawing.Size(127, 28);
            this.ButtonReportIssue.TabIndex = 1182;
            this.ButtonReportIssue.Text = "Report Issue";
            this.ButtonReportIssue.Click += new System.EventHandler(this.ButtonReportIssue_Click);
            // 
            // ApplicationDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.ControlBox = false;
            this.Controls.Add(this.PanelAppsDetails);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelAppsItemActions);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ApplicationDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Homebrew Details";
            this.Load += new System.EventHandler(this.ApplicationDialog_Load);
            this.PanelAppsDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).EndInit();
            this.TablePanelStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).EndInit();
            this.TabPane.ResumeLayout(false);
            this.TabDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAppsItemActions)).EndInit();
            this.PanelAppsItemActions.ResumeLayout(false);
            this.PanelAppsItemActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScrollableControl PanelAppsDetails;
        private DevExpress.Utils.Layout.StackPanel PanelAppsItemActions;
        private DevExpress.Utils.SvgImageCollection Images;
        private PanelControl PanelHeader;
        private SeparatorControl SeparatorHeader;
        private SvgImageBox ImageClose;
        private SimpleButton ButtonFavorite;
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private LabelControl LabelCategory;
        private LabelControl LabelName;
        private LabelControl LabelApplications;
        private LabelControl LabelSlash;
        private DevExpress.XtraBars.Navigation.TabPane TabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDescription;
        private LabelControl LabelDescription;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDownloads;
        private DevExpress.Utils.Layout.TablePanel TablePanelStats;
        private Controls.StatItem StatSubmittedBy;
        private Controls.StatItem StatCreatedBy;
        private Controls.StatItem StatVersion;
        private Controls.StatItem StatFwVersions;
        private Controls.StatItem StatTitleId;
        private Controls.StatItem StatLastUpdated;
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonHelpSupport;
        private SimpleButton ButtonInstall;
        private SimpleButton ButtonReportIssue;
    }
}