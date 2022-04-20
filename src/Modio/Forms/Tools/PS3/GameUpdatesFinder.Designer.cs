using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Modio.Forms.Tools.PS3
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
            this.SectionPanelInformation = new DevExpress.XtraEditors.GroupControl();
            this.ButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxTitleID = new DevExpress.XtraEditors.TextEdit();
            this.GridGameUpdates = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameUpdates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstallToConsole = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownloadToComputer = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.SectionPanelInformation)).BeginInit();
            this.SectionPanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionPanelInformation
            // 
            this.SectionPanelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelInformation.Controls.Add(this.ButtonSearch);
            this.SectionPanelInformation.Controls.Add(this.TextBoxTitleID);
            this.SectionPanelInformation.Controls.Add(this.GridGameUpdates);
            this.SectionPanelInformation.Controls.Add(this.LabelSearch);
            this.SectionPanelInformation.Controls.Add(this.stackPanel2);
            this.SectionPanelInformation.Location = new System.Drawing.Point(11, 11);
            this.SectionPanelInformation.Name = "SectionPanelInformation";
            this.SectionPanelInformation.Size = new System.Drawing.Size(622, 368);
            this.SectionPanelInformation.TabIndex = 0;
            this.SectionPanelInformation.Text = "SEARCH FOR GAME UPDATES";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AllowFocus = false;
            this.ButtonSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Appearance.Options.UseFont = true;
            this.ButtonSearch.Location = new System.Drawing.Point(162, 31);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(67, 22);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxTitleID
            // 
            this.TextBoxTitleID.EditValue = "e.g. BLES01807";
            this.TextBoxTitleID.Location = new System.Drawing.Point(55, 31);
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
            this.GridGameUpdates.Location = new System.Drawing.Point(2, 61);
            this.GridGameUpdates.MainView = this.GridViewGameUpdates;
            this.GridGameUpdates.Name = "GridGameUpdates";
            this.GridGameUpdates.Size = new System.Drawing.Size(618, 266);
            this.GridGameUpdates.TabIndex = 1183;
            this.GridGameUpdates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameUpdates});
            // 
            // GridViewGameUpdates
            // 
            this.GridViewGameUpdates.ActiveFilterEnabled = false;
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
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(10, 34);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(38, 15);
            this.LabelSearch.TabIndex = 1161;
            this.LabelSearch.Text = "Title Id:";
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.ButtonInstallToConsole);
            this.stackPanel2.Controls.Add(this.ButtonDownloadToComputer);
            this.stackPanel2.Controls.Add(this.ButtonCopyURLToClipboard);
            this.stackPanel2.Controls.Add(this.ButtonCopySHA1ToClipboard);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(2, 327);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(618, 39);
            this.stackPanel2.TabIndex = 1181;
            // 
            // ButtonInstallToConsole
            // 
            this.ButtonInstallToConsole.Enabled = false;
            this.ButtonInstallToConsole.Location = new System.Drawing.Point(8, 8);
            this.ButtonInstallToConsole.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonInstallToConsole.Name = "ButtonInstallToConsole";
            this.ButtonInstallToConsole.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstallToConsole.Size = new System.Drawing.Size(121, 23);
            this.ButtonInstallToConsole.TabIndex = 6;
            this.ButtonInstallToConsole.Text = "Install to Console";
            this.ButtonInstallToConsole.Click += new System.EventHandler(this.ButtonInstallToConsole_Click);
            // 
            // ButtonDownloadToComputer
            // 
            this.ButtonDownloadToComputer.Enabled = false;
            this.ButtonDownloadToComputer.Location = new System.Drawing.Point(135, 8);
            this.ButtonDownloadToComputer.Name = "ButtonDownloadToComputer";
            this.ButtonDownloadToComputer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownloadToComputer.Size = new System.Drawing.Size(108, 23);
            this.ButtonDownloadToComputer.TabIndex = 7;
            this.ButtonDownloadToComputer.Text = "Download File";
            this.ButtonDownloadToComputer.Click += new System.EventHandler(this.ButtonDownloadFile_Click);
            // 
            // ButtonCopyURLToClipboard
            // 
            this.ButtonCopyURLToClipboard.Enabled = false;
            this.ButtonCopyURLToClipboard.Location = new System.Drawing.Point(249, 8);
            this.ButtonCopyURLToClipboard.Name = "ButtonCopyURLToClipboard";
            this.ButtonCopyURLToClipboard.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCopyURLToClipboard.Size = new System.Drawing.Size(149, 23);
            this.ButtonCopyURLToClipboard.TabIndex = 8;
            this.ButtonCopyURLToClipboard.Text = "Copy URL to Clipboard";
            this.ButtonCopyURLToClipboard.Click += new System.EventHandler(this.ButtonCopyURLToClipboard_Click);
            // 
            // ButtonCopySHA1ToClipboard
            // 
            this.ButtonCopySHA1ToClipboard.Enabled = false;
            this.ButtonCopySHA1ToClipboard.Location = new System.Drawing.Point(404, 8);
            this.ButtonCopySHA1ToClipboard.Name = "ButtonCopySHA1ToClipboard";
            this.ButtonCopySHA1ToClipboard.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCopySHA1ToClipboard.Size = new System.Drawing.Size(157, 23);
            this.ButtonCopySHA1ToClipboard.TabIndex = 9;
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
            this.LabelStatus.Caption = "Status";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 393);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(644, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 393);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(644, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 393);
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
            // GameUpdatesFinder
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 418);
            this.Controls.Add(this.SectionPanelInformation);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameUpdatesFinder.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameUpdatesFinder";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Update Finder";
            this.Load += new System.EventHandler(this.GameUpdatesFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionPanelInformation)).EndInit();
            this.SectionPanelInformation.ResumeLayout(false);
            this.SectionPanelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupControl SectionPanelInformation;
        private TextEdit TextBoxTitleID;
        private LabelControl LabelSearch;
        private SimpleButton ButtonSearch;
        private ToolStripMenuItem ContextMenuDownloadToComputer;
        private ToolStripMenuItem ContextMenuInstallToConsole;
        private ToolStripMenuItem ContextMenuCopyURLToClipboard;
        private DataGridViewTextBoxColumn ColumnVersion;
        private StackPanel stackPanel2;
        private SimpleButton ButtonInstallToConsole;
        private SimpleButton ButtonDownloadToComputer;
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
    }
}