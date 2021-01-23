namespace ModioX.Forms.Tools.PS3_Tools
{
    partial class GameBackupFilesWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBackupFilesWindow));
            this.GridBackupFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewBackupFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBackupFiles = new DevExpress.XtraEditors.GroupControl();
            this.ProgressBackupFiles = new DevExpress.XtraWaitForm.ProgressPanel();
            this.DockControlBackupFiles = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.BarBackupFiles = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.LabelHeaderGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileName = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderCreatedOn = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreatedOn = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderLocalPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.LabelInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelLocalPath = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBackupFiles)).BeginInit();
            this.GroupBackupFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBackupFiles
            // 
            this.GridBackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBackupFiles.Location = new System.Drawing.Point(2, 23);
            this.GridBackupFiles.MainView = this.GridViewBackupFiles;
            this.GridBackupFiles.Name = "GridBackupFiles";
            this.GridBackupFiles.Size = new System.Drawing.Size(617, 213);
            this.GridBackupFiles.TabIndex = 12;
            this.GridBackupFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewBackupFiles});
            // 
            // GridViewBackupFiles
            // 
            this.GridViewBackupFiles.GridControl = this.GridBackupFiles;
            this.GridViewBackupFiles.Name = "GridViewBackupFiles";
            this.GridViewBackupFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewBackupFiles.OptionsView.ShowIndicator = false;
            // 
            // ColumnGameTitle
            // 
            this.ColumnGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGameTitle.HeaderText = "Game Title";
            this.ColumnGameTitle.Name = "ColumnGameTitle";
            this.ColumnGameTitle.ReadOnly = true;
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.HeaderText = "File Name";
            this.ColumnFileName.Name = "ColumnFileName";
            this.ColumnFileName.ReadOnly = true;
            this.ColumnFileName.Width = 120;
            // 
            // ColumnFileSize
            // 
            this.ColumnFileSize.HeaderText = "File Size";
            this.ColumnFileSize.Name = "ColumnFileSize";
            this.ColumnFileSize.ReadOnly = true;
            this.ColumnFileSize.Width = 120;
            // 
            // ColumnCreatedOn
            // 
            this.ColumnCreatedOn.HeaderText = "Created On";
            this.ColumnCreatedOn.Name = "ColumnCreatedOn";
            this.ColumnCreatedOn.ReadOnly = true;
            this.ColumnCreatedOn.Width = 120;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.MinimumWidth = 6;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.Width = 95;
            // 
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnType.HeaderText = "File Name";
            this.ColumnType.MinimumWidth = 100;
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 105;
            // 
            // ColumnGameId
            // 
            this.ColumnGameId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnGameId.HeaderText = "Game Id";
            this.ColumnGameId.MinimumWidth = 6;
            this.ColumnGameId.Name = "ColumnGameId";
            this.ColumnGameId.Width = 140;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Game Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "File Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // GroupBackupFiles
            // 
            this.GroupBackupFiles.Controls.Add(this.ProgressBackupFiles);
            this.GroupBackupFiles.Controls.Add(this.GridBackupFiles);
            this.GroupBackupFiles.Controls.Add(this.DockControlBackupFiles);
            this.GroupBackupFiles.Location = new System.Drawing.Point(12, 12);
            this.GroupBackupFiles.Name = "GroupBackupFiles";
            this.GroupBackupFiles.Size = new System.Drawing.Size(621, 261);
            this.GroupBackupFiles.TabIndex = 17;
            this.GroupBackupFiles.Text = "BACKUP FILES";
            // 
            // ProgressBackupFiles
            // 
            this.ProgressBackupFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressBackupFiles.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressBackupFiles.Appearance.Options.UseBackColor = true;
            this.ProgressBackupFiles.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressBackupFiles.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressBackupFiles.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressBackupFiles.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressBackupFiles.Caption = "NO BACKUP FILES";
            this.ProgressBackupFiles.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressBackupFiles.Description = "Loading..";
            this.ProgressBackupFiles.Location = new System.Drawing.Point(187, 97);
            this.ProgressBackupFiles.Name = "ProgressBackupFiles";
            this.ProgressBackupFiles.Size = new System.Drawing.Size(246, 66);
            this.ProgressBackupFiles.TabIndex = 1171;
            this.ProgressBackupFiles.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // DockControlBackupFiles
            // 
            this.DockControlBackupFiles.CausesValidation = false;
            this.DockControlBackupFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DockControlBackupFiles.Location = new System.Drawing.Point(2, 236);
            this.DockControlBackupFiles.Manager = this.barManager1;
            this.DockControlBackupFiles.Name = "DockControlBackupFiles";
            this.DockControlBackupFiles.Size = new System.Drawing.Size(617, 23);
            this.DockControlBackupFiles.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.DockControlBackupFiles);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(645, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(645, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(645, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 497);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarBackupFiles});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager2.MaxItemId = 4;
            // 
            // BarBackupFiles
            // 
            this.BarBackupFiles.BarItemVertIndent = 5;
            this.BarBackupFiles.BarName = "Tools";
            this.BarBackupFiles.DockCol = 0;
            this.BarBackupFiles.DockRow = 0;
            this.BarBackupFiles.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.BarBackupFiles.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.BarBackupFiles.Offset = 2;
            this.BarBackupFiles.OptionsBar.DrawDragBorder = false;
            this.BarBackupFiles.StandaloneBarDockControl = this.DockControlBackupFiles;
            this.BarBackupFiles.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit File Details";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete File";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Backup File";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Restore File";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(645, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 497);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(645, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(645, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 497);
            // 
            // LabelHeaderGameTitle
            // 
            this.LabelHeaderGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGameTitle.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGameTitle.Appearance.Options.UseFont = true;
            this.LabelHeaderGameTitle.Appearance.Options.UseForeColor = true;
            this.LabelHeaderGameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameTitle.Location = new System.Drawing.Point(6, 6);
            this.LabelHeaderGameTitle.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderGameTitle.Name = "LabelHeaderGameTitle";
            this.LabelHeaderGameTitle.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderGameTitle.TabIndex = 37;
            this.LabelHeaderGameTitle.Text = "Game Title:";
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameTitle.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGameTitle.Appearance.Options.UseFont = true;
            this.LabelGameTitle.Appearance.Options.UseForeColor = true;
            this.LabelGameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameTitle.Location = new System.Drawing.Point(160, 6);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Size = new System.Drawing.Size(9, 15);
            this.LabelGameTitle.TabIndex = 36;
            this.LabelGameTitle.Text = "...";
            // 
            // LabelHeaderFileName
            // 
            this.LabelHeaderFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileName.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFileName.Appearance.Options.UseFont = true;
            this.LabelHeaderFileName.Appearance.Options.UseForeColor = true;
            this.LabelHeaderFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileName.Location = new System.Drawing.Point(6, 30);
            this.LabelHeaderFileName.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderFileName.Name = "LabelHeaderFileName";
            this.LabelHeaderFileName.Size = new System.Drawing.Size(58, 15);
            this.LabelHeaderFileName.TabIndex = 34;
            this.LabelHeaderFileName.Text = "File Name:";
            // 
            // LabelFileName
            // 
            this.LabelFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileName.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFileName.Appearance.Options.UseFont = true;
            this.LabelFileName.Appearance.Options.UseForeColor = true;
            this.LabelFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileName.Location = new System.Drawing.Point(160, 30);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(9, 15);
            this.LabelFileName.TabIndex = 35;
            this.LabelFileName.Text = "...";
            // 
            // LabelHeaderFileSize
            // 
            this.LabelHeaderFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileSize.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFileSize.Appearance.Options.UseFont = true;
            this.LabelHeaderFileSize.Appearance.Options.UseForeColor = true;
            this.LabelHeaderFileSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileSize.Location = new System.Drawing.Point(6, 53);
            this.LabelHeaderFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderFileSize.Name = "LabelHeaderFileSize";
            this.LabelHeaderFileSize.Size = new System.Drawing.Size(48, 15);
            this.LabelHeaderFileSize.TabIndex = 40;
            this.LabelHeaderFileSize.Text = "File Size:";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFileSize.Appearance.Options.UseFont = true;
            this.LabelFileSize.Appearance.Options.UseForeColor = true;
            this.LabelFileSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(160, 53);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(9, 15);
            this.LabelFileSize.TabIndex = 41;
            this.LabelFileSize.Text = "...";
            // 
            // LabelHeaderCreatedOn
            // 
            this.LabelHeaderCreatedOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCreatedOn.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderCreatedOn.Appearance.Options.UseFont = true;
            this.LabelHeaderCreatedOn.Appearance.Options.UseForeColor = true;
            this.LabelHeaderCreatedOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCreatedOn.Location = new System.Drawing.Point(6, 78);
            this.LabelHeaderCreatedOn.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderCreatedOn.Name = "LabelHeaderCreatedOn";
            this.LabelHeaderCreatedOn.Size = new System.Drawing.Size(66, 15);
            this.LabelHeaderCreatedOn.TabIndex = 39;
            this.LabelHeaderCreatedOn.Text = "Created On:";
            // 
            // LabelCreatedOn
            // 
            this.LabelCreatedOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedOn.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCreatedOn.Appearance.Options.UseFont = true;
            this.LabelCreatedOn.Appearance.Options.UseForeColor = true;
            this.LabelCreatedOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedOn.Location = new System.Drawing.Point(160, 78);
            this.LabelCreatedOn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelCreatedOn.Name = "LabelCreatedOn";
            this.LabelCreatedOn.Size = new System.Drawing.Size(9, 15);
            this.LabelCreatedOn.TabIndex = 38;
            this.LabelCreatedOn.Text = "...";
            // 
            // LabelHeaderLocalPath
            // 
            this.LabelHeaderLocalPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderLocalPath.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderLocalPath.Appearance.Options.UseFont = true;
            this.LabelHeaderLocalPath.Appearance.Options.UseForeColor = true;
            this.LabelHeaderLocalPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLocalPath.Location = new System.Drawing.Point(6, 103);
            this.LabelHeaderLocalPath.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderLocalPath.Name = "LabelHeaderLocalPath";
            this.LabelHeaderLocalPath.Size = new System.Drawing.Size(59, 15);
            this.LabelHeaderLocalPath.TabIndex = 30;
            this.LabelHeaderLocalPath.Text = "Local Path:";
            // 
            // LabelHeaderInstallPath
            // 
            this.LabelHeaderInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallPath.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderInstallPath.Appearance.Options.UseFont = true;
            this.LabelHeaderInstallPath.Appearance.Options.UseForeColor = true;
            this.LabelHeaderInstallPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderInstallPath.Location = new System.Drawing.Point(6, 143);
            this.LabelHeaderInstallPath.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderInstallPath.Name = "LabelHeaderInstallPath";
            this.LabelHeaderInstallPath.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderInstallPath.TabIndex = 32;
            this.LabelHeaderInstallPath.Text = "Install Path";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.6F)});
            this.tablePanel1.Controls.Add(this.LabelInstallPath);
            this.tablePanel1.Controls.Add(this.LabelLocalPath);
            this.tablePanel1.Controls.Add(this.LabelCreatedOn);
            this.tablePanel1.Controls.Add(this.LabelFileSize);
            this.tablePanel1.Controls.Add(this.LabelFileName);
            this.tablePanel1.Controls.Add(this.LabelGameTitle);
            this.tablePanel1.Controls.Add(this.LabelHeaderGameTitle);
            this.tablePanel1.Controls.Add(this.LabelHeaderFileName);
            this.tablePanel1.Controls.Add(this.LabelHeaderFileSize);
            this.tablePanel1.Controls.Add(this.LabelHeaderCreatedOn);
            this.tablePanel1.Controls.Add(this.LabelHeaderLocalPath);
            this.tablePanel1.Controls.Add(this.LabelHeaderInstallPath);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(2, 23);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 23F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.ShowGrid = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.Size = new System.Drawing.Size(617, 181);
            this.tablePanel1.TabIndex = 26;
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelInstallPath.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelInstallPath.Appearance.Options.UseFont = true;
            this.LabelInstallPath.Appearance.Options.UseForeColor = true;
            this.LabelInstallPath.Appearance.Options.UseTextOptions = true;
            this.LabelInstallPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tablePanel1.SetColumn(this.LabelInstallPath, 1);
            this.LabelInstallPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstallPath.Location = new System.Drawing.Point(160, 126);
            this.LabelInstallPath.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.tablePanel1.SetRow(this.LabelInstallPath, 5);
            this.LabelInstallPath.Size = new System.Drawing.Size(451, 49);
            this.LabelInstallPath.TabIndex = 42;
            this.LabelInstallPath.Text = "...";
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLocalPath.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelLocalPath.Appearance.Options.UseFont = true;
            this.LabelLocalPath.Appearance.Options.UseForeColor = true;
            this.LabelLocalPath.Appearance.Options.UseTextOptions = true;
            this.LabelLocalPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tablePanel1.SetColumn(this.LabelLocalPath, 1);
            this.LabelLocalPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLocalPath.Location = new System.Drawing.Point(160, 86);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.tablePanel1.SetRow(this.LabelLocalPath, 4);
            this.LabelLocalPath.Size = new System.Drawing.Size(451, 34);
            this.LabelLocalPath.TabIndex = 39;
            this.LabelLocalPath.Text = "...";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tablePanel1);
            this.groupControl1.Location = new System.Drawing.Point(12, 279);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 206);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "BACKUP FILE DETAILS";
            // 
            // GameBackupFilesWindow
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GroupBackupFiles);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameBackupFilesWindow.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBackupFilesWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Backup Files";
            this.Load += new System.EventHandler(this.GameBackupFilesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBackupFiles)).EndInit();
            this.GroupBackupFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridBackupFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedOn;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewBackupFiles;
        private DevExpress.XtraEditors.GroupControl GroupBackupFiles;
        private DevExpress.XtraBars.StandaloneBarDockControl DockControlBackupFiles;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar BarBackupFiles;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private  DevExpress.XtraEditors.LabelControl LabelCreatedOn;
        private  DevExpress.XtraEditors.LabelControl LabelFileSize;
        private  DevExpress.XtraEditors.LabelControl LabelFileName;
        private  DevExpress.XtraEditors.LabelControl LabelGameTitle;
        private  DevExpress.XtraEditors.LabelControl LabelHeaderGameTitle;
        private  DevExpress.XtraEditors.LabelControl LabelHeaderFileName;
        private  DevExpress.XtraEditors.LabelControl LabelHeaderFileSize;
        private  DevExpress.XtraEditors.LabelControl LabelHeaderCreatedOn;
        private  DevExpress.XtraEditors.LabelControl LabelHeaderLocalPath;
        private  DevExpress.XtraEditors.LabelControl LabelHeaderInstallPath;
        private DevExpress.XtraEditors.LabelControl LabelInstallPath;
        private DevExpress.XtraEditors.LabelControl LabelLocalPath;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressBackupFiles;
    }
}