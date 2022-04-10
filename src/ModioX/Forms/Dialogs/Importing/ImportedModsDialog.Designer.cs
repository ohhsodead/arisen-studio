using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ModioX.Forms.Dialogs.Importing
{
    partial class ImportedModsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportedModsDialog));
            this.SectionPackages = new DevExpress.XtraEditors.GroupControl();
            this.GridMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ColumnPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.TimerWait = new System.Windows.Forms.Timer(this.components);
            this.BarManagerStatus = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.SectionPackages)).BeginInit();
            this.SectionPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).BeginInit();
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
            this.SectionPackages.Controls.Add(this.GridMods);
            this.SectionPackages.Controls.Add(this.PanelButtons);
            this.SectionPackages.Location = new System.Drawing.Point(11, 11);
            this.SectionPackages.Name = "SectionPackages";
            this.SectionPackages.Size = new System.Drawing.Size(739, 415);
            this.SectionPackages.TabIndex = 0;
            this.SectionPackages.Text = "IMPORTED MODS";
            // 
            // GridMods
            // 
            this.GridMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMods.Location = new System.Drawing.Point(2, 23);
            this.GridMods.MainView = this.GridViewMods;
            this.GridMods.Name = "GridMods";
            this.GridMods.Size = new System.Drawing.Size(735, 349);
            this.GridMods.TabIndex = 0;
            this.GridMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMods});
            // 
            // GridViewMods
            // 
            this.GridViewMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewMods.GridControl = this.GridMods;
            this.GridViewMods.Name = "GridViewMods";
            this.GridViewMods.OptionsBehavior.Editable = false;
            this.GridViewMods.OptionsBehavior.ReadOnly = true;
            this.GridViewMods.OptionsCustomization.AllowFilter = false;
            this.GridViewMods.OptionsFilter.AllowFilterEditor = false;
            this.GridViewMods.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewMods.OptionsView.ShowGroupPanel = false;
            this.GridViewMods.OptionsView.ShowIndicator = false;
            this.GridViewMods.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewMods_RowClick);
            this.GridViewMods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewMods_FocusedRowChanged);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonAddNew);
            this.PanelButtons.Controls.Add(this.ButtonDelete);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 372);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(735, 41);
            this.PanelButtons.TabIndex = 1180;
            // 
            // ButtonAddNew
            // 
            this.ButtonAddNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonAddNew.Appearance.Options.UseFont = true;
            this.ButtonAddNew.Location = new System.Drawing.Point(8, 8);
            this.ButtonAddNew.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonAddNew.Name = "ButtonAddNew";
            this.ButtonAddNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddNew.Size = new System.Drawing.Size(81, 25);
            this.ButtonAddNew.TabIndex = 1;
            this.ButtonAddNew.Text = "Add New";
            this.ButtonAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDelete.Appearance.Options.UseFont = true;
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(95, 8);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(69, 25);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDeleteAll.Appearance.Options.UseFont = true;
            this.ButtonDeleteAll.Enabled = false;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(170, 8);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(86, 25);
            this.ButtonDeleteAll.TabIndex = 4;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManagerStatus;
            this.barDockControlTop.Size = new System.Drawing.Size(761, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(761, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(761, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
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
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.Id = 3;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // ImportedModsDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(761, 438);
            this.Controls.Add(this.SectionPackages);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ImportedModsDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportedModsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Imported Mods";
            this.Load += new System.EventHandler(this.ImportedModsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionPackages)).EndInit();
            this.SectionPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).EndInit();
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
        private SimpleButton ButtonDelete;
        private SimpleButton ButtonDeleteAll;
        private GridControl GridMods;
        private GridView GridViewMods;
        private SimpleButton ButtonAddNew;
        private BarManager BarManagerStatus;
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