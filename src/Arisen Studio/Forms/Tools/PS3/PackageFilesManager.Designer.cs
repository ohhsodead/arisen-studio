using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ArisenStudio.Forms.Tools.PS3
{
    partial class PackageFilesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageFilesManager));
            this.GridPackageFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewPackageFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstallFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownloadFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.GridPackageFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPackageFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPackageFiles
            // 
            this.GridPackageFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPackageFiles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridPackageFiles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridPackageFiles.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridPackageFiles.Location = new System.Drawing.Point(12, 12);
            this.GridPackageFiles.MainView = this.GridViewPackageFiles;
            this.GridPackageFiles.Name = "GridPackageFiles";
            this.GridPackageFiles.Size = new System.Drawing.Size(606, 296);
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
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonInstallFile);
            this.PanelButtons.Controls.Add(this.ButtonDownloadFile);
            this.PanelButtons.Controls.Add(this.ButtonDelete);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Location = new System.Drawing.Point(12, 314);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(608, 24);
            this.PanelButtons.TabIndex = 1180;
            // 
            // ButtonInstallFile
            // 
            this.ButtonInstallFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonInstallFile.Appearance.Options.UseFont = true;
            this.ButtonInstallFile.AutoSize = true;
            this.ButtonInstallFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonInstallFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonInstallFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonInstallFile.Name = "ButtonInstallFile";
            this.ButtonInstallFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonInstallFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstallFile.Size = new System.Drawing.Size(79, 24);
            this.ButtonInstallFile.TabIndex = 1;
            this.ButtonInstallFile.Text = "Install File";
            this.ButtonInstallFile.Click += new System.EventHandler(this.ButtonInstallPackageFile_Click);
            // 
            // ButtonDownloadFile
            // 
            this.ButtonDownloadFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDownloadFile.Appearance.Options.UseFont = true;
            this.ButtonDownloadFile.AutoSize = true;
            this.ButtonDownloadFile.Enabled = false;
            this.ButtonDownloadFile.Location = new System.Drawing.Point(85, 0);
            this.ButtonDownloadFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDownloadFile.Name = "ButtonDownloadFile";
            this.ButtonDownloadFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDownloadFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownloadFile.Size = new System.Drawing.Size(102, 24);
            this.ButtonDownloadFile.TabIndex = 2;
            this.ButtonDownloadFile.Text = "Download File";
            this.ButtonDownloadFile.Click += new System.EventHandler(this.ButtonDownloadPackageFile_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDelete.Appearance.Options.UseFont = true;
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(193, 0);
            this.ButtonDelete.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(60, 24);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeletePackageFile_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDeleteAll.Appearance.Options.UseFont = true;
            this.ButtonDeleteAll.AutoSize = true;
            this.ButtonDeleteAll.Enabled = false;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(259, 0);
            this.ButtonDeleteAll.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(77, 24);
            this.ButtonDeleteAll.TabIndex = 4;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAllPackageFiles_Click);
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
            this.barDockControlTop.Size = new System.Drawing.Size(630, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 353);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(630, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 353);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(630, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 353);
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
            // PackageFilesManager
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 377);
            this.Controls.Add(this.GridPackageFiles);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackageFilesManager.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageFilesManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package File Manger";
            this.Load += new System.EventHandler(this.PackageFilesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPackageFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPackageFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Timer TimerWait;
        private DataGridViewTextBoxColumn ColumnPackageName;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewImageColumn ColumnDownload;
        private StackPanel PanelButtons;
        private SimpleButton ButtonDelete;
        private SimpleButton ButtonDeleteAll;
        private GridControl GridPackageFiles;
        private GridView GridViewPackageFiles;
        private SimpleButton ButtonInstallFile;
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
        private SimpleButton ButtonDownloadFile;
    }
}