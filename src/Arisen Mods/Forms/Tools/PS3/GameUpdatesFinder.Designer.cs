using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenMods.Forms.Tools.PS3
{
    partial class GameUpdatesFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUpdatesFinder));
            this.ButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxTitleID = new DevExpress.XtraEditors.TextEdit();
            this.GridGameUpdates = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameUpdates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelHeaderTitleID = new DevExpress.XtraEditors.LabelControl();
            this.ButtonInstallFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownloadFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCopyURLToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCopySHA1ToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.ContextMenuDownloadToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuInstallToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuCopyURLToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarManagerStatus = new DevExpress.XtraBars.BarManager(this.components);
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.PanelButtonsFooter = new DevExpress.Utils.Layout.StackPanel();
            this.PanelButtonsHeader = new DevExpress.Utils.Layout.StackPanel();
            this.PanelGameTitle = new DevExpress.Utils.Layout.StackPanel();
            this.LabelHeaderTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsFooter)).BeginInit();
            this.PanelButtonsFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsHeader)).BeginInit();
            this.PanelButtonsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelGameTitle)).BeginInit();
            this.PanelGameTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AllowFocus = false;
            this.ButtonSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Appearance.Options.UseFont = true;
            this.ButtonSearch.Location = new System.Drawing.Point(151, 0);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(67, 24);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxTitleID
            // 
            this.TextBoxTitleID.EditValue = "e.g. BLES01807";
            this.TextBoxTitleID.Location = new System.Drawing.Point(45, 1);
            this.TextBoxTitleID.Name = "TextBoxTitleID";
            this.TextBoxTitleID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTitleID.Properties.Appearance.Options.UseFont = true;
            this.TextBoxTitleID.Size = new System.Drawing.Size(100, 22);
            this.TextBoxTitleID.TabIndex = 0;
            // 
            // GridGameUpdates
            // 
            this.GridGameUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGameUpdates.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridGameUpdates.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridGameUpdates.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridGameUpdates.Location = new System.Drawing.Point(12, 72);
            this.GridGameUpdates.MainView = this.GridViewGameUpdates;
            this.GridGameUpdates.Name = "GridGameUpdates";
            this.GridGameUpdates.Size = new System.Drawing.Size(620, 273);
            this.GridGameUpdates.TabIndex = 2;
            this.GridGameUpdates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameUpdates});
            // 
            // GridViewGameUpdates
            // 
            this.GridViewGameUpdates.ActiveFilterEnabled = false;
            this.GridViewGameUpdates.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.GridViewGameUpdates.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridViewGameUpdates.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewGameUpdates.GridControl = this.GridGameUpdates;
            this.GridViewGameUpdates.Name = "GridViewGameUpdates";
            this.GridViewGameUpdates.OptionsBehavior.Editable = false;
            this.GridViewGameUpdates.OptionsBehavior.ReadOnly = true;
            this.GridViewGameUpdates.OptionsCustomization.AllowFilter = false;
            this.GridViewGameUpdates.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewGameUpdates.OptionsFilter.AllowColumnMRUFilterList = false;
            this.GridViewGameUpdates.OptionsFilter.AllowFilterEditor = false;
            this.GridViewGameUpdates.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewGameUpdates.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewGameUpdates.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridViewGameUpdates.OptionsView.ShowGroupPanel = false;
            this.GridViewGameUpdates.OptionsView.ShowIndicator = false;
            this.GridViewGameUpdates.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewGameUpdates_RowClick);
            this.GridViewGameUpdates.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewGameUpdates_FocusedRowChanged);
            // 
            // LabelHeaderTitleID
            // 
            this.LabelHeaderTitleID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelHeaderTitleID.Appearance.Options.UseFont = true;
            this.LabelHeaderTitleID.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHeaderTitleID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderTitleID.Location = new System.Drawing.Point(0, 4);
            this.LabelHeaderTitleID.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderTitleID.Name = "LabelHeaderTitleID";
            this.LabelHeaderTitleID.Size = new System.Drawing.Size(39, 15);
            this.LabelHeaderTitleID.TabIndex = 1161;
            this.LabelHeaderTitleID.Text = "Title ID:";
            // 
            // ButtonInstallFile
            // 
            this.ButtonInstallFile.AutoSize = true;
            this.ButtonInstallFile.Enabled = false;
            this.ButtonInstallFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonInstallFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonInstallFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonInstallFile.Name = "ButtonInstallFile";
            this.ButtonInstallFile.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonInstallFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstallFile.Size = new System.Drawing.Size(83, 24);
            this.ButtonInstallFile.TabIndex = 3;
            this.ButtonInstallFile.Text = "Install File";
            this.ButtonInstallFile.Click += new System.EventHandler(this.ButtonInstallFile_Click);
            // 
            // ButtonDownloadFile
            // 
            this.ButtonDownloadFile.AutoSize = true;
            this.ButtonDownloadFile.Enabled = false;
            this.ButtonDownloadFile.Location = new System.Drawing.Point(89, 0);
            this.ButtonDownloadFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDownloadFile.Name = "ButtonDownloadFile";
            this.ButtonDownloadFile.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonDownloadFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownloadFile.Size = new System.Drawing.Size(106, 24);
            this.ButtonDownloadFile.TabIndex = 4;
            this.ButtonDownloadFile.Text = "Download File";
            this.ButtonDownloadFile.Click += new System.EventHandler(this.ButtonDownloadFile_Click);
            // 
            // ButtonCopyURLToClipboard
            // 
            this.ButtonCopyURLToClipboard.AutoSize = true;
            this.ButtonCopyURLToClipboard.Enabled = false;
            this.ButtonCopyURLToClipboard.Location = new System.Drawing.Point(362, 0);
            this.ButtonCopyURLToClipboard.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonCopyURLToClipboard.Name = "ButtonCopyURLToClipboard";
            this.ButtonCopyURLToClipboard.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonCopyURLToClipboard.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCopyURLToClipboard.Size = new System.Drawing.Size(148, 24);
            this.ButtonCopyURLToClipboard.TabIndex = 6;
            this.ButtonCopyURLToClipboard.Text = "Copy URL to Clipboard";
            this.ButtonCopyURLToClipboard.Click += new System.EventHandler(this.ButtonCopyURLToClipboard_Click);
            // 
            // ButtonCopySHA1ToClipboard
            // 
            this.ButtonCopySHA1ToClipboard.AutoSize = true;
            this.ButtonCopySHA1ToClipboard.Enabled = false;
            this.ButtonCopySHA1ToClipboard.Location = new System.Drawing.Point(201, 0);
            this.ButtonCopySHA1ToClipboard.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonCopySHA1ToClipboard.Name = "ButtonCopySHA1ToClipboard";
            this.ButtonCopySHA1ToClipboard.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonCopySHA1ToClipboard.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCopySHA1ToClipboard.Size = new System.Drawing.Size(155, 24);
            this.ButtonCopySHA1ToClipboard.TabIndex = 5;
            this.ButtonCopySHA1ToClipboard.Text = "Copy SHA1 to Clipboard";
            this.ButtonCopySHA1ToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1ToClipboard_Click);
            // 
            // ContextMenuDownloadToComputer
            // 
            this.ContextMenuDownloadToComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuDownloadToComputer.Enabled = false;
            this.ContextMenuDownloadToComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuDownloadToComputer.Name = "ContextMenuDownloadToComputer";
            this.ContextMenuDownloadToComputer.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuDownloadToComputer.Text = "Download to Computer...";
            // 
            // ContextMenuInstallToConsole
            // 
            this.ContextMenuInstallToConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuInstallToConsole.Enabled = false;
            this.ContextMenuInstallToConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuInstallToConsole.Name = "ContextMenuInstallToConsole";
            this.ContextMenuInstallToConsole.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuInstallToConsole.Text = "Install to Console...";
            // 
            // ContextMenuCopyURLToClipboard
            // 
            this.ContextMenuCopyURLToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCopyURLToClipboard.Enabled = false;
            this.ContextMenuCopyURLToClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCopyURLToClipboard.Name = "ContextMenuCopyURLToClipboard";
            this.ContextMenuCopyURLToClipboard.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuCopyURLToClipboard.Text = "Copy URL to Clipboard";
            // 
            // ColumnVersion
            // 
            this.ColumnVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnVersion.HeaderText = "Version";
            this.ColumnVersion.Name = "ColumnVersion";
            this.ColumnVersion.ReadOnly = true;
            // 
            // BarManagerStatus
            // 
            this.BarManagerStatus.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarStatus});
            this.BarManagerStatus.DockControls.Add(this.barDockControlTop);
            this.BarManagerStatus.DockControls.Add(this.barDockControlBottom);
            this.BarManagerStatus.DockControls.Add(this.barDockControlLeft);
            this.BarManagerStatus.DockControls.Add(this.barDockControlRight);
            this.BarManagerStatus.Form = this;
            this.BarManagerStatus.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelHeaderStatus,
            this.barHeaderItem1,
            this.barStaticItem2,
            this.LabelStatus});
            this.BarManagerStatus.MaxItemId = 4;
            this.BarManagerStatus.StatusBar = this.BarStatus;
            // 
            // BarStatus
            // 
            this.BarStatus.BarItemVertIndent = 5;
            this.BarStatus.BarName = "Status bar";
            this.BarStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BarStatus.DockCol = 0;
            this.BarStatus.DockRow = 0;
            this.BarStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BarStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 0;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 4;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Idle";
            this.LabelStatus.Id = 3;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManagerStatus;
            this.barDockControlTop.Size = new System.Drawing.Size(644, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 389);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(644, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 389);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(644, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 389);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem2.Caption = "Status";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // PanelButtonsFooter
            // 
            this.PanelButtonsFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtonsFooter.Controls.Add(this.ButtonInstallFile);
            this.PanelButtonsFooter.Controls.Add(this.ButtonDownloadFile);
            this.PanelButtonsFooter.Controls.Add(this.ButtonCopySHA1ToClipboard);
            this.PanelButtonsFooter.Controls.Add(this.ButtonCopyURLToClipboard);
            this.PanelButtonsFooter.Location = new System.Drawing.Point(12, 351);
            this.PanelButtonsFooter.Name = "PanelButtonsFooter";
            this.PanelButtonsFooter.Size = new System.Drawing.Size(620, 24);
            this.PanelButtonsFooter.TabIndex = 1184;
            // 
            // PanelButtonsHeader
            // 
            this.PanelButtonsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtonsHeader.Controls.Add(this.LabelHeaderTitleID);
            this.PanelButtonsHeader.Controls.Add(this.TextBoxTitleID);
            this.PanelButtonsHeader.Controls.Add(this.ButtonSearch);
            this.PanelButtonsHeader.Location = new System.Drawing.Point(12, 12);
            this.PanelButtonsHeader.Name = "PanelButtonsHeader";
            this.PanelButtonsHeader.Size = new System.Drawing.Size(620, 24);
            this.PanelButtonsHeader.TabIndex = 1189;
            // 
            // PanelGameTitle
            // 
            this.PanelGameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGameTitle.Controls.Add(this.LabelHeaderTitle);
            this.PanelGameTitle.Controls.Add(this.LabelTitle);
            this.PanelGameTitle.Location = new System.Drawing.Point(12, 42);
            this.PanelGameTitle.Name = "PanelGameTitle";
            this.PanelGameTitle.Size = new System.Drawing.Size(620, 24);
            this.PanelGameTitle.TabIndex = 1190;
            // 
            // LabelHeaderTitle
            // 
            this.LabelHeaderTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderTitle.Appearance.Options.UseFont = true;
            this.LabelHeaderTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderTitle.Location = new System.Drawing.Point(0, 4);
            this.LabelHeaderTitle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderTitle.Name = "LabelHeaderTitle";
            this.LabelHeaderTitle.Size = new System.Drawing.Size(28, 15);
            this.LabelHeaderTitle.TabIndex = 1161;
            this.LabelHeaderTitle.Text = "Title:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitle.Location = new System.Drawing.Point(31, 4);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(5, 15);
            this.LabelTitle.TabIndex = 1162;
            this.LabelTitle.Text = "-";
            // 
            // GameUpdatesFinder
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 413);
            this.Controls.Add(this.PanelButtonsHeader);
            this.Controls.Add(this.PanelButtonsFooter);
            this.Controls.Add(this.GridGameUpdates);
            this.Controls.Add(this.PanelGameTitle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameUpdatesFinder.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenMods.Properties.Resources.arisenmods;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameUpdatesFinder";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Updates Finder";
            this.Load += new System.EventHandler(this.GameUpdatesFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsFooter)).EndInit();
            this.PanelButtonsFooter.ResumeLayout(false);
            this.PanelButtonsFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsHeader)).EndInit();
            this.PanelButtonsHeader.ResumeLayout(false);
            this.PanelButtonsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelGameTitle)).EndInit();
            this.PanelGameTitle.ResumeLayout(false);
            this.PanelGameTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextEdit TextBoxTitleID;
        private LabelControl LabelHeaderTitleID;
        private SimpleButton ButtonSearch;
        private ToolStripMenuItem ContextMenuDownloadToComputer;
        private ToolStripMenuItem ContextMenuInstallToConsole;
        private ToolStripMenuItem ContextMenuCopyURLToClipboard;
        private DataGridViewTextBoxColumn ColumnVersion;
        private SimpleButton ButtonInstallFile;
        private SimpleButton ButtonDownloadFile;
        private GridControl GridGameUpdates;
        private GridView GridViewGameUpdates;
        private SimpleButton ButtonCopyURLToClipboard;
        private SimpleButton ButtonCopySHA1ToClipboard;
        private BarManager BarManagerStatus;
        private Bar BarStatus;
        private BarStaticItem LabelHeaderStatus;
        private BarStaticItem LabelStatus;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarHeaderItem barHeaderItem1;
        private BarStaticItem barStaticItem2;
        private StackPanel PanelButtonsFooter;
        private StackPanel PanelButtonsHeader;
        private StackPanel PanelGameTitle;
        private LabelControl LabelHeaderTitle;
        private LabelControl LabelTitle;
    }
}