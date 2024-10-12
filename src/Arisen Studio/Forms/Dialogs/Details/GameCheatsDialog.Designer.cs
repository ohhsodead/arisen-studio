using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs.Details
{
    partial class GameCheatsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCheatsDialog));
            this.PanelAppsDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.GridControlCheats = new DevExpress.XtraGrid.GridControl();
            this.GridViewCheats = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.PanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelGame = new DevExpress.XtraEditors.LabelControl();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageClose = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelAppsItemActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonApplyCheat = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonReport = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonHelp = new DevExpress.XtraEditors.SimpleButton();
            this.Images = new DevExpress.Utils.SvgImageCollection(this.components);
            this.PanelAppsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCheats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCheats)).BeginInit();
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
            this.PanelAppsDetails.Controls.Add(this.GridControlCheats);
            this.PanelAppsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAppsDetails.Location = new System.Drawing.Point(0, 50);
            this.PanelAppsDetails.Name = "PanelAppsDetails";
            this.PanelAppsDetails.Size = new System.Drawing.Size(630, 332);
            this.PanelAppsDetails.TabIndex = 1;
            // 
            // GridControlCheats
            // 
            this.GridControlCheats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlCheats.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GridControlCheats.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.GridControlCheats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlCheats.Location = new System.Drawing.Point(16, 14);
            this.GridControlCheats.MainView = this.GridViewCheats;
            this.GridControlCheats.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GridControlCheats.Name = "GridControlCheats";
            this.GridControlCheats.Size = new System.Drawing.Size(599, 315);
            this.GridControlCheats.TabIndex = 9;
            this.GridControlCheats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewCheats});
            // 
            // GridViewCheats
            // 
            this.GridViewCheats.ActiveFilterEnabled = false;
            this.GridViewCheats.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GridViewCheats.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GridViewCheats.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.Appearance.Row.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.Row.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.EvenRow.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.GroupRow.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewCheats.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.Lines.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.OddRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.OddRow.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.Preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.Preview.Options.UseFont = true;
            this.GridViewCheats.AppearancePrint.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.AppearancePrint.Row.Options.UseFont = true;
            this.GridViewCheats.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewCheats.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewCheats.GridControl = this.GridControlCheats;
            this.GridViewCheats.GroupRowHeight = 20;
            this.GridViewCheats.Name = "GridViewCheats";
            this.GridViewCheats.OptionsBehavior.Editable = false;
            this.GridViewCheats.OptionsBehavior.ReadOnly = true;
            this.GridViewCheats.OptionsCustomization.AllowColumnMoving = false;
            this.GridViewCheats.OptionsCustomization.AllowColumnResizing = false;
            this.GridViewCheats.OptionsCustomization.AllowFilter = false;
            this.GridViewCheats.OptionsCustomization.AllowQuickHideColumns = false;
            this.GridViewCheats.OptionsCustomization.AllowSort = false;
            this.GridViewCheats.OptionsDragDrop.AllowSortedDataDragDrop = false;
            this.GridViewCheats.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsFilter.AllowFilterEditor = false;
            this.GridViewCheats.OptionsFilter.AllowMRUFilterList = false;
            this.GridViewCheats.OptionsFilter.FilterEditorAllowCustomExpressions = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.Disabled;
            this.GridViewCheats.OptionsFilter.ShowCustomFunctions = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsFilter.ShowInHeaderSearchResults = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchResultsMode.None;
            this.GridViewCheats.OptionsMenu.EnableColumnMenu = false;
            this.GridViewCheats.OptionsMenu.EnableFooterMenu = false;
            this.GridViewCheats.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewCheats.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewCheats.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.GridViewCheats.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.GridViewCheats.OptionsMenu.ShowSplitItem = false;
            this.GridViewCheats.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewCheats.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewCheats.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridViewCheats.OptionsView.ShowGroupPanel = false;
            this.GridViewCheats.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.OptionsView.ShowIndicator = false;
            this.GridViewCheats.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewCheats.RowHeight = 24;
            this.GridViewCheats.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewCheats_RowClick);
            this.GridViewCheats.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewCheats_FocusedRowChanged);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelHeader.Controls.Add(this.PanelTitle);
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(630, 50);
            this.PanelHeader.TabIndex = 1191;
            // 
            // PanelTitle
            // 
            this.PanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitle.Controls.Add(this.LabelGame);
            this.PanelTitle.Controls.Add(this.LabelVersion);
            this.PanelTitle.Controls.Add(this.LabelRegion);
            this.PanelTitle.Location = new System.Drawing.Point(16, 12);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(574, 22);
            this.PanelTitle.TabIndex = 0;
            this.PanelTitle.WrapContents = false;
            // 
            // LabelGame
            // 
            this.LabelGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGame.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelGame.Appearance.Options.UseFont = true;
            this.LabelGame.AutoEllipsis = true;
            this.LabelGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGame.Location = new System.Drawing.Point(0, 1);
            this.LabelGame.Margin = new System.Windows.Forms.Padding(0, 1, 3, 10);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(35, 17);
            this.LabelGame.TabIndex = 1190;
            this.LabelGame.Text = "Game";
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.AutoEllipsis = true;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(41, 3);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(50, 15);
            this.LabelVersion.TabIndex = 1189;
            this.LabelVersion.Text = "- Version";
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
            this.LabelRegion.Location = new System.Drawing.Point(97, 3);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(53, 15);
            this.LabelRegion.TabIndex = 1191;
            this.LabelRegion.Text = "(REGION)";
            // 
            // SeparatorHeader
            // 
            this.SeparatorHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorHeader.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHeader.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorHeader.Location = new System.Drawing.Point(0, 40);
            this.SeparatorHeader.Name = "SeparatorHeader";
            this.SeparatorHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.SeparatorHeader.Size = new System.Drawing.Size(630, 10);
            this.SeparatorHeader.TabIndex = 6;
            // 
            // ImageClose
            // 
            this.ImageClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageClose.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.ImageClose.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ImageClose.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.ImageClose.Location = new System.Drawing.Point(594, 10);
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
            this.PanelAppsItemActions.Controls.Add(this.ButtonApplyCheat);
            this.PanelAppsItemActions.Controls.Add(this.ButtonReport);
            this.PanelAppsItemActions.Controls.Add(this.ButtonHelp);
            this.PanelAppsItemActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAppsItemActions.Location = new System.Drawing.Point(0, 382);
            this.PanelAppsItemActions.Name = "PanelAppsItemActions";
            this.PanelAppsItemActions.Size = new System.Drawing.Size(630, 50);
            this.PanelAppsItemActions.TabIndex = 1175;
            // 
            // ButtonApplyCheat
            // 
            this.ButtonApplyCheat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonApplyCheat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonApplyCheat.Appearance.Options.UseFont = true;
            this.ButtonApplyCheat.Appearance.Options.UseForeColor = true;
            this.ButtonApplyCheat.AutoSize = true;
            this.ButtonApplyCheat.Enabled = false;
            this.ButtonApplyCheat.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonApplyCheat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonApplyCheat.ImageOptions.ImageToTextIndent = 6;
            this.ButtonApplyCheat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonApplyCheat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonApplyCheat.ImageOptions.SvgImage")));
            this.ButtonApplyCheat.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonApplyCheat.Location = new System.Drawing.Point(12, 11);
            this.ButtonApplyCheat.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.ButtonApplyCheat.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonApplyCheat.Name = "ButtonApplyCheat";
            this.ButtonApplyCheat.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonApplyCheat.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonApplyCheat.Size = new System.Drawing.Size(123, 28);
            this.ButtonApplyCheat.TabIndex = 7;
            this.ButtonApplyCheat.Text = "Apply Cheat";
            this.ButtonApplyCheat.Click += new System.EventHandler(this.ButtonApplyCheat_Click);
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
            this.ButtonReport.Location = new System.Drawing.Point(142, 11);
            this.ButtonReport.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(127, 28);
            this.ButtonReport.TabIndex = 8;
            this.ButtonReport.Text = "Report Issue";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
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
            this.ButtonHelp.Location = new System.Drawing.Point(276, 11);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonHelp.MinimumSize = new System.Drawing.Size(0, 28);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonHelp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonHelp.Size = new System.Drawing.Size(152, 28);
            this.ButtonHelp.TabIndex = 9;
            this.ButtonHelp.Text = "Help && Support";
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // Images
            // 
            this.Images.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.Images.Add("check", "image://svgimages/icon builder/actions_check.svg");
            // 
            // GameCheatsDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 432);
            this.ControlBox = false;
            this.Controls.Add(this.PanelAppsDetails);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelAppsItemActions);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameCheatsDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameCheatsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Cheats";
            this.Load += new System.EventHandler(this.GameCheatsDialog_Load);
            this.PanelAppsDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCheats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCheats)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel PanelTitle;
        private DevExpress.XtraGrid.GridControl GridControlCheats;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewCheats;
        private SimpleButton ButtonApplyCheat;
        private SimpleButton ButtonReport;
        private SimpleButton ButtonHelp;
        private LabelControl LabelGame;
        private LabelControl LabelVersion;
        private LabelControl LabelRegion;
    }
}