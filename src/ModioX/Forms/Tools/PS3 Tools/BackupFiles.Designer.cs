namespace ModioX.Forms.Tools.PS3_Tools
{
    partial class BackupFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupFiles));
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
            this.GroupBackupFiles = new DevExpress.XtraEditors.GroupControl();
            this.ProgressBackupFiles = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonNewApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAddApplication = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileSize = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreatedOn = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LabelLocaPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.LabelInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBackupFiles)).BeginInit();
            this.GroupBackupFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBackupFiles
            // 
            this.GridBackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBackupFiles.Location = new System.Drawing.Point(2, 23);
            this.GridBackupFiles.MainView = this.GridViewBackupFiles;
            this.GridBackupFiles.Name = "GridBackupFiles";
            this.GridBackupFiles.Size = new System.Drawing.Size(617, 197);
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
            // GroupBackupFiles
            // 
            this.GroupBackupFiles.Controls.Add(this.GridBackupFiles);
            this.GroupBackupFiles.Controls.Add(this.PanelButtons);
            this.GroupBackupFiles.Controls.Add(this.ProgressBackupFiles);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 279);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 206);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "BACKUP FILE DETAILS";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonNewApplication);
            this.PanelButtons.Controls.Add(this.ButtonAddApplication);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 220);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(617, 39);
            this.PanelButtons.TabIndex = 1181;
            // 
            // ButtonNewApplication
            // 
            this.ButtonNewApplication.Location = new System.Drawing.Point(8, 8);
            this.ButtonNewApplication.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonNewApplication.Name = "ButtonNewApplication";
            this.ButtonNewApplication.Size = new System.Drawing.Size(69, 23);
            this.ButtonNewApplication.TabIndex = 6;
            this.ButtonNewApplication.Text = "Delete";
            // 
            // ButtonAddApplication
            // 
            this.ButtonAddApplication.Location = new System.Drawing.Point(83, 8);
            this.ButtonAddApplication.Name = "ButtonAddApplication";
            this.ButtonAddApplication.Size = new System.Drawing.Size(86, 23);
            this.ButtonAddApplication.TabIndex = 7;
            this.ButtonAddApplication.Text = "Delete All";
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.LabelInstallPath);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.LabelLocaPath);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.LabelCreatedOn);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.LabelFileSize);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.LabelFileName);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.LabelGameTitle);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(617, 181);
            this.panelControl1.TabIndex = 1182;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl4.Location = new System.Drawing.Point(8, 8);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 15);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Game Title:";
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameTitle.Appearance.Options.UseFont = true;
            this.LabelGameTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameTitle.Location = new System.Drawing.Point(95, 8);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Size = new System.Drawing.Size(512, 15);
            this.LabelGameTitle.TabIndex = 40;
            this.LabelGameTitle.Text = "...";
            // 
            // LabelFileName
            // 
            this.LabelFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileName.Appearance.Options.UseFont = true;
            this.LabelFileName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileName.Location = new System.Drawing.Point(95, 29);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(512, 15);
            this.LabelFileName.TabIndex = 42;
            this.LabelFileName.Text = "...";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl7.Location = new System.Drawing.Point(8, 29);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 15);
            this.labelControl7.TabIndex = 41;
            this.labelControl7.Text = "File Name:";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.Appearance.Options.UseFont = true;
            this.LabelFileSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(95, 50);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(512, 15);
            this.LabelFileSize.TabIndex = 44;
            this.LabelFileSize.Text = "...";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl9.Location = new System.Drawing.Point(8, 50);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 15);
            this.labelControl9.TabIndex = 43;
            this.labelControl9.Text = "File Size:";
            // 
            // LabelCreatedOn
            // 
            this.LabelCreatedOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedOn.Appearance.Options.UseFont = true;
            this.LabelCreatedOn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedOn.Location = new System.Drawing.Point(95, 71);
            this.LabelCreatedOn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelCreatedOn.Name = "LabelCreatedOn";
            this.LabelCreatedOn.Size = new System.Drawing.Size(512, 15);
            this.LabelCreatedOn.TabIndex = 46;
            this.LabelCreatedOn.Text = "...";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl11.Location = new System.Drawing.Point(8, 71);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(66, 15);
            this.labelControl11.TabIndex = 45;
            this.labelControl11.Text = "Created On:";
            // 
            // LabelLocaPath
            // 
            this.LabelLocaPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLocaPath.Appearance.Options.UseFont = true;
            this.LabelLocaPath.Appearance.Options.UseTextOptions = true;
            this.LabelLocaPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelLocaPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelLocaPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLocaPath.Location = new System.Drawing.Point(95, 92);
            this.LabelLocaPath.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelLocaPath.Name = "LabelLocaPath";
            this.LabelLocaPath.Size = new System.Drawing.Size(512, 34);
            this.LabelLocaPath.TabIndex = 48;
            this.LabelLocaPath.Text = "...";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl13.Location = new System.Drawing.Point(8, 92);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 15);
            this.labelControl13.TabIndex = 47;
            this.labelControl13.Text = "Local Path:";
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelInstallPath.Appearance.Options.UseFont = true;
            this.LabelInstallPath.Appearance.Options.UseTextOptions = true;
            this.LabelInstallPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelInstallPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstallPath.Location = new System.Drawing.Point(95, 137);
            this.LabelInstallPath.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.LabelInstallPath.Size = new System.Drawing.Size(512, 34);
            this.LabelInstallPath.TabIndex = 50;
            this.LabelInstallPath.Text = "...";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl2.Location = new System.Drawing.Point(8, 137);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 15);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Install Path:";
            // 
            // BackupFiles
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GroupBackupFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("BackupFiles.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupFiles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup Files";
            this.Load += new System.EventHandler(this.BackupFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBackupFiles)).EndInit();
            this.GroupBackupFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridBackupFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedOn;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewBackupFiles;
        private DevExpress.XtraEditors.GroupControl GroupBackupFiles;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressBackupFiles;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private DevExpress.XtraEditors.SimpleButton ButtonNewApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonAddApplication;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl LabelInstallPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LabelLocaPath;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl LabelCreatedOn;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl LabelFileSize;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl LabelFileName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl LabelGameTitle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}