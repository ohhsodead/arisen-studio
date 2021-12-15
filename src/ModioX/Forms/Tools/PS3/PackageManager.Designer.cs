using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ModioX.Forms.Tools.PS3
{
    partial class PackageManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManager));
            this.SectionPackages = new DevExpress.XtraEditors.GroupControl();
            this.GridPackageFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewPackageFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstallPackageFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownloadPackageFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeletePackageFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAllPackageFiles = new DevExpress.XtraEditors.SimpleButton();
            this.ColumnPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.TimerWait = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.SectionPackages)).BeginInit();
            this.SectionPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPackageFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPackageFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionPackages
            // 
            this.SectionPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPackages.Controls.Add(this.GridPackageFiles);
            this.SectionPackages.Controls.Add(this.PanelButtons);
            this.SectionPackages.Location = new System.Drawing.Point(11, 11);
            this.SectionPackages.Name = "SectionPackages";
            this.SectionPackages.Size = new System.Drawing.Size(608, 327);
            this.SectionPackages.TabIndex = 0;
            this.SectionPackages.Text = "PACKAGE FILES";
            // 
            // GridPackageFiles
            // 
            this.GridPackageFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPackageFiles.Location = new System.Drawing.Point(2, 23);
            this.GridPackageFiles.MainView = this.GridViewPackageFiles;
            this.GridPackageFiles.Name = "GridPackageFiles";
            this.GridPackageFiles.Size = new System.Drawing.Size(604, 261);
            this.GridPackageFiles.TabIndex = 0;
            this.GridPackageFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPackageFiles});
            // 
            // GridViewPackageFiles
            // 
            this.GridViewPackageFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewPackageFiles.GridControl = this.GridPackageFiles;
            this.GridViewPackageFiles.Name = "GridViewPackageFiles";
            this.GridViewPackageFiles.OptionsBehavior.Editable = false;
            this.GridViewPackageFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewPackageFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewPackageFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewPackageFiles.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewPackageFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewPackageFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewPackageFiles.OptionsView.ShowIndicator = false;
            this.GridViewPackageFiles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewPackageFiles_RowClick);
            this.GridViewPackageFiles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewPackageFiles_FocusedRowChanged);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonInstallPackageFile);
            this.PanelButtons.Controls.Add(this.ButtonDownloadPackageFile);
            this.PanelButtons.Controls.Add(this.ButtonDeletePackageFile);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAllPackageFiles);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 284);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(604, 41);
            this.PanelButtons.TabIndex = 1180;
            // 
            // ButtonInstallPackageFile
            // 
            this.ButtonInstallPackageFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonInstallPackageFile.Appearance.Options.UseFont = true;
            this.ButtonInstallPackageFile.Location = new System.Drawing.Point(8, 8);
            this.ButtonInstallPackageFile.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonInstallPackageFile.Name = "ButtonInstallPackageFile";
            this.ButtonInstallPackageFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstallPackageFile.Size = new System.Drawing.Size(129, 25);
            this.ButtonInstallPackageFile.TabIndex = 1;
            this.ButtonInstallPackageFile.Text = "Install Package File";
            this.ButtonInstallPackageFile.Click += new System.EventHandler(this.ButtonInstallPackageFile_Click);
            // 
            // ButtonDownloadPackageFile
            // 
            this.ButtonDownloadPackageFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDownloadPackageFile.Appearance.Options.UseFont = true;
            this.ButtonDownloadPackageFile.Enabled = false;
            this.ButtonDownloadPackageFile.Location = new System.Drawing.Point(143, 8);
            this.ButtonDownloadPackageFile.Name = "ButtonDownloadPackageFile";
            this.ButtonDownloadPackageFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownloadPackageFile.Size = new System.Drawing.Size(150, 25);
            this.ButtonDownloadPackageFile.TabIndex = 2;
            this.ButtonDownloadPackageFile.Text = "Download Package File";
            this.ButtonDownloadPackageFile.Click += new System.EventHandler(this.ButtonDownloadPackageFile_Click);
            // 
            // ButtonDeletePackageFile
            // 
            this.ButtonDeletePackageFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDeletePackageFile.Appearance.Options.UseFont = true;
            this.ButtonDeletePackageFile.Enabled = false;
            this.ButtonDeletePackageFile.Location = new System.Drawing.Point(299, 8);
            this.ButtonDeletePackageFile.Name = "ButtonDeletePackageFile";
            this.ButtonDeletePackageFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeletePackageFile.Size = new System.Drawing.Size(69, 25);
            this.ButtonDeletePackageFile.TabIndex = 3;
            this.ButtonDeletePackageFile.Text = "Delete";
            this.ButtonDeletePackageFile.Click += new System.EventHandler(this.ButtonDeletePackageFile_Click);
            // 
            // ButtonDeleteAllPackageFiles
            // 
            this.ButtonDeleteAllPackageFiles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDeleteAllPackageFiles.Appearance.Options.UseFont = true;
            this.ButtonDeleteAllPackageFiles.Enabled = false;
            this.ButtonDeleteAllPackageFiles.Location = new System.Drawing.Point(374, 8);
            this.ButtonDeleteAllPackageFiles.Name = "ButtonDeleteAllPackageFiles";
            this.ButtonDeleteAllPackageFiles.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAllPackageFiles.Size = new System.Drawing.Size(86, 25);
            this.ButtonDeleteAllPackageFiles.TabIndex = 4;
            this.ButtonDeleteAllPackageFiles.Text = "Delete All";
            this.ButtonDeleteAllPackageFiles.Click += new System.EventHandler(this.ButtonDeleteAllPackageFiles_Click);
            // 
            // ColumnPackageName
            // 
            this.ColumnPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPackageName.HeaderText = "Package File Name";
            this.ColumnPackageName.Name = "ColumnPackageName";
            this.ColumnPackageName.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // TimerWait
            // 
            this.TimerWait.Enabled = true;
            this.TimerWait.Tick += new System.EventHandler(this.TimerWait_Tick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(630, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 352);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(630, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 352);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(630, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 352);
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
            // PackageManager
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 377);
            this.Controls.Add(this.SectionPackages);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackageManager.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Manger";
            this.Load += new System.EventHandler(this.PackageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionPackages)).EndInit();
            this.SectionPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPackageFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPackageFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupControl SectionPackages;
        private Timer TimerWait;
        private DataGridViewTextBoxColumn ColumnPackageName;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewImageColumn ColumnDownload;
        private StackPanel PanelButtons;
        private SimpleButton ButtonDeletePackageFile;
        private SimpleButton ButtonDeleteAllPackageFiles;
        private GridControl GridPackageFiles;
        private GridView GridViewPackageFiles;
        private SimpleButton ButtonInstallPackageFile;
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
        private SimpleButton ButtonDownloadPackageFile;
    }
}