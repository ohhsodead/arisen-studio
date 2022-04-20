using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Dialogs.Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCheatsDialog));
            this.PanelDetails = new DevExpress.XtraEditors.XtraScrollableControl();
            this.GridControlCheats = new DevExpress.XtraGrid.GridControl();
            this.GridViewCheats = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelHeader = new DevExpress.XtraEditors.PanelControl();
            this.SeparatorHeader = new DevExpress.XtraEditors.SeparatorControl();
            this.ImageCloseDetails = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelGame = new DevExpress.XtraEditors.LabelControl();
            this.PanelRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.PanelActions = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonApply = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonReport = new DevExpress.XtraEditors.SimpleButton();
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCheats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCheats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).BeginInit();
            this.PanelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).BeginInit();
            this.PanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Controls.Add(this.GridControlCheats);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(0, 80);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(650, 202);
            this.PanelDetails.TabIndex = 1;
            // 
            // GridControlCheats
            // 
            this.GridControlCheats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlCheats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlCheats.Location = new System.Drawing.Point(12, 3);
            this.GridControlCheats.MainView = this.GridViewCheats;
            this.GridControlCheats.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlCheats.Name = "GridControlCheats";
            this.GridControlCheats.Size = new System.Drawing.Size(628, 183);
            this.GridControlCheats.TabIndex = 6;
            this.GridControlCheats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewCheats});
            // 
            // GridViewCheats
            // 
            this.GridViewCheats.ActiveFilterEnabled = false;
            this.GridViewCheats.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewCheats.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewCheats.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewCheats.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewCheats.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewCheats.Appearance.Row.Options.UseBackColor = true;
            this.GridViewCheats.Appearance.Row.Options.UseFont = true;
            this.GridViewCheats.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewCheats.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewCheats.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewCheats.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewCheats.GridControl = this.GridControlCheats;
            this.GridViewCheats.GroupRowHeight = 20;
            this.GridViewCheats.Name = "GridViewCheats";
            this.GridViewCheats.OptionsBehavior.Editable = false;
            this.GridViewCheats.OptionsBehavior.ReadOnly = true;
            this.GridViewCheats.OptionsCustomization.AllowFilter = false;
            this.GridViewCheats.OptionsFilter.AllowFilterEditor = false;
            this.GridViewCheats.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewCheats.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewCheats.OptionsView.ShowColumnHeaders = false;
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
            this.PanelHeader.Controls.Add(this.SeparatorHeader);
            this.PanelHeader.Controls.Add(this.ImageCloseDetails);
            this.PanelHeader.Controls.Add(this.LabelGame);
            this.PanelHeader.Controls.Add(this.PanelRegion);
            this.PanelHeader.Controls.Add(this.LabelRegion);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(650, 80);
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
            this.SeparatorHeader.Size = new System.Drawing.Size(650, 10);
            this.SeparatorHeader.TabIndex = 1185;
            // 
            // ImageCloseDetails
            // 
            this.ImageCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageCloseDetails.Location = new System.Drawing.Point(616, 10);
            this.ImageCloseDetails.Name = "ImageCloseDetails";
            this.ImageCloseDetails.Size = new System.Drawing.Size(24, 24);
            this.ImageCloseDetails.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageCloseDetails.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageCloseDetails.SvgImage")));
            this.ImageCloseDetails.TabIndex = 1171;
            this.ImageCloseDetails.Text = "Close";
            this.ImageCloseDetails.Click += new System.EventHandler(this.ImageCloseDetails_Click);
            // 
            // LabelGame
            // 
            this.LabelGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGame.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelGame.Appearance.Options.UseFont = true;
            this.LabelGame.AutoEllipsis = true;
            this.LabelGame.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGame.Location = new System.Drawing.Point(12, 13);
            this.LabelGame.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(435, 17);
            this.LabelGame.TabIndex = 1184;
            this.LabelGame.Text = "Game";
            // 
            // PanelRegion
            // 
            this.PanelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRegion.Controls.Add(this.LabelVersion);
            this.PanelRegion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelRegion.Location = new System.Drawing.Point(452, 12);
            this.PanelRegion.Name = "PanelRegion";
            this.PanelRegion.Size = new System.Drawing.Size(158, 22);
            this.PanelRegion.TabIndex = 1190;
            this.PanelRegion.WrapContents = false;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.Appearance.Options.UseTextOptions = true;
            this.LabelVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LabelVersion.AutoEllipsis = true;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(113, 3);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(42, 15);
            this.LabelVersion.TabIndex = 1188;
            this.LabelVersion.Text = "Version";
            // 
            // LabelRegion
            // 
            this.LabelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelRegion.Appearance.Options.UseFont = true;
            this.LabelRegion.AutoEllipsis = true;
            this.LabelRegion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRegion.Location = new System.Drawing.Point(12, 44);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(626, 15);
            this.LabelRegion.TabIndex = 1170;
            this.LabelRegion.Text = "Region";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.ButtonApply);
            this.PanelActions.Controls.Add(this.ButtonReport);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelActions.Location = new System.Drawing.Point(0, 282);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(650, 50);
            this.PanelActions.TabIndex = 1175;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonApply.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonApply.Appearance.Options.UseFont = true;
            this.ButtonApply.Appearance.Options.UseForeColor = true;
            this.ButtonApply.Enabled = false;
            this.ButtonApply.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonApply.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonApply.ImageOptions.ImageToTextIndent = 6;
            this.ButtonApply.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonApply.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonApply.ImageOptions.SvgImage")));
            this.ButtonApply.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonApply.Location = new System.Drawing.Point(12, 12);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonApply.Size = new System.Drawing.Size(81, 26);
            this.ButtonApply.TabIndex = 1176;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonReport.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ButtonReport.Appearance.Options.UseFont = true;
            this.ButtonReport.Appearance.Options.UseForeColor = true;
            this.ButtonReport.Enabled = false;
            this.ButtonReport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonReport.ImageOptions.ImageToTextIndent = 6;
            this.ButtonReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonReport.ImageOptions.SvgImage")));
            this.ButtonReport.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonReport.Location = new System.Drawing.Point(99, 12);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonReport.Size = new System.Drawing.Size(84, 26);
            this.ButtonReport.TabIndex = 1177;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // GameCheatsDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(650, 332);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameCheatsDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameCheatsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.GameCheatsDialog_Load);
            this.PanelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCheats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCheats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseDetails)).EndInit();
            this.PanelRegion.ResumeLayout(false);
            this.PanelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelActions)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScrollableControl PanelDetails;
        private DevExpress.Utils.Layout.StackPanel PanelActions;
        private SimpleButton ButtonApply;
        private SimpleButton ButtonReport;
        private LabelControl LabelRegion;
        private LabelControl LabelGame;
        private LabelControl LabelVersion;
        private PanelControl PanelHeader;
        private SvgImageBox ImageCloseDetails;
        private SeparatorControl SeparatorHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelRegion;
        private DevExpress.XtraGrid.GridControl GridControlCheats;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewCheats;
    }
}