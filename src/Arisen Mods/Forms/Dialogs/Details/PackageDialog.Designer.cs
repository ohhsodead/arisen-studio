using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenMods.Forms.Dialogs.Details
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
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFaq = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.TablePanelStats = new DevExpress.Utils.Layout.TablePanel();
            this.StatTitleId = new ArisenMods.Controls.StatItem();
            this.StatFileSize = new ArisenMods.Controls.StatItem();
            this.StatSha256 = new ArisenMods.Controls.StatItem();
            this.StatContentId = new ArisenMods.Controls.StatItem();
            this.StatModifiedDate = new ArisenMods.Controls.StatItem();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).BeginInit();
            this.TablePanelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.PanelTitle);
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageClose);
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
            this.PanelActions.Location = new System.Drawing.Point(0, 161);
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
            this.ButtonInstall.ImageOptions.Image = global::ArisenMods.Properties.Resources.install;
            this.ButtonInstall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInstall.ImageOptions.ImageToTextIndent = 6;
            this.ButtonInstall.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInstall.ImageOptions.SvgImage = global::ArisenMods.Properties.Resources.install_svg;
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
            this.ButtonDownload.ImageOptions.SvgImage = global::ArisenMods.Properties.Resources.download_svg;
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
            // PanelDetails
            // 
            this.PanelDetails.Controls.Add(this.TablePanelStats);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(800, 81);
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
            this.TablePanelStats.Controls.Add(this.StatTitleId);
            this.TablePanelStats.Controls.Add(this.StatFileSize);
            this.TablePanelStats.Controls.Add(this.StatSha256);
            this.TablePanelStats.Controls.Add(this.StatContentId);
            this.TablePanelStats.Controls.Add(this.StatModifiedDate);
            this.TablePanelStats.Location = new System.Drawing.Point(14, 14);
            this.TablePanelStats.Name = "TablePanelStats";
            this.TablePanelStats.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.TablePanelStats.Size = new System.Drawing.Size(773, 49);
            this.TablePanelStats.TabIndex = 1208;
            // 
            // StatTitleId
            // 
            this.StatTitleId.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatTitleId.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatTitleId, 2);
            this.StatTitleId.Location = new System.Drawing.Point(295, 3);
            this.StatTitleId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatTitleId.Name = "StatTitleId";
            this.TablePanelStats.SetRow(this.StatTitleId, 0);
            this.StatTitleId.Size = new System.Drawing.Size(140, 36);
            this.StatTitleId.TabIndex = 6;
            this.StatTitleId.Title = "Title ID";
            this.StatTitleId.Value = "Value";
            // 
            // StatFileSize
            // 
            this.StatFileSize.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatFileSize.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatFileSize, 1);
            this.StatFileSize.Location = new System.Drawing.Point(149, 3);
            this.StatFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatFileSize.Name = "StatFileSize";
            this.TablePanelStats.SetRow(this.StatFileSize, 0);
            this.StatFileSize.Size = new System.Drawing.Size(140, 35);
            this.StatFileSize.TabIndex = 5;
            this.StatFileSize.Title = "File Size";
            this.StatFileSize.Value = "Value";
            // 
            // StatSha256
            // 
            this.StatSha256.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatSha256.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatSha256, 4);
            this.StatSha256.Location = new System.Drawing.Point(587, 3);
            this.StatSha256.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatSha256.Name = "StatSha256";
            this.TablePanelStats.SetRow(this.StatSha256, 0);
            this.StatSha256.Size = new System.Drawing.Size(183, 36);
            this.StatSha256.TabIndex = 4;
            this.StatSha256.Title = "SHA-256";
            this.StatSha256.Value = "Value";
            // 
            // StatContentId
            // 
            this.StatContentId.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatContentId.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatContentId, 3);
            this.StatContentId.Location = new System.Drawing.Point(441, 3);
            this.StatContentId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatContentId.Name = "StatContentId";
            this.TablePanelStats.SetRow(this.StatContentId, 0);
            this.StatContentId.Size = new System.Drawing.Size(140, 36);
            this.StatContentId.TabIndex = 3;
            this.StatContentId.Title = "Content ID";
            this.StatContentId.Value = "Value";
            // 
            // StatModifiedDate
            // 
            this.StatModifiedDate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatModifiedDate.Appearance.Options.UseBackColor = true;
            this.TablePanelStats.SetColumn(this.StatModifiedDate, 0);
            this.StatModifiedDate.Location = new System.Drawing.Point(3, 3);
            this.StatModifiedDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StatModifiedDate.Name = "StatModifiedDate";
            this.TablePanelStats.SetRow(this.StatModifiedDate, 0);
            this.StatModifiedDate.Size = new System.Drawing.Size(140, 36);
            this.StatModifiedDate.TabIndex = 0;
            this.StatModifiedDate.Title = "Modified Date";
            this.StatModifiedDate.Value = "Value";
            // 
            // PackageDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackageDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenMods.Properties.Resources.arisenmods;
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
            ((System.ComponentModel.ISupportInitialize)(this.ImageClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.PanelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelStats)).EndInit();
            this.TablePanelStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private DevExpress.Utils.SvgImageCollection Images;
        private PanelControl PanelHeader;
        private SeparatorControl SeparatorHeader;
        private SvgImageBox ImageClose;
        private SimpleButton ButtonDownload;
        private SimpleButton ButtonFaq;
        private SimpleButton ButtonInstall;
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private LabelControl LabelPackages;
        private LabelControl LabelSlash;
        private LabelControl LabelCategory;
        private LabelControl LabelRegion;
        private XtraScrollableControl PanelDetails;
        private LabelControl LabelName;
        private DevExpress.Utils.Layout.TablePanel TablePanelStats;
        private Controls.StatItem StatTitleId;
        private Controls.StatItem StatFileSize;
        private Controls.StatItem StatSha256;
        private Controls.StatItem StatContentId;
        private Controls.StatItem StatModifiedDate;
    }
}