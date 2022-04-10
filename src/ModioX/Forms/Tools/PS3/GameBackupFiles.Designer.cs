using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ModioX.Forms.Tools.PS3
{
    partial class GameBackupFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBackupFiles));
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
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonBackupFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRestoreFile = new DevExpress.XtraEditors.SimpleButton();
            this.PanelFileDetails = new DevExpress.XtraEditors.PanelControl();
            this.LabelInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelLocalPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreatedOn = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileSize = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBackupFiles)).BeginInit();
            this.GroupBackupFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileDetails)).BeginInit();
            this.PanelFileDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBackupFiles
            // 
            this.GridBackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBackupFiles.Location = new System.Drawing.Point(2, 23);
            this.GridBackupFiles.MainView = this.GridViewBackupFiles;
            this.GridBackupFiles.Name = "GridBackupFiles";
            this.GridBackupFiles.Size = new System.Drawing.Size(586, 373);
            this.GridBackupFiles.TabIndex = 12;
            this.GridBackupFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewBackupFiles});
            // 
            // GridViewBackupFiles
            // 
            this.GridViewBackupFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewBackupFiles.GridControl = this.GridBackupFiles;
            this.GridViewBackupFiles.Name = "GridViewBackupFiles";
            this.GridViewBackupFiles.OptionsBehavior.Editable = false;
            this.GridViewBackupFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewBackupFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewBackupFiles.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewBackupFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewBackupFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewBackupFiles.OptionsView.ShowIndicator = false;
            this.GridViewBackupFiles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewBackupFiles_FocusedRowChanged);
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
            this.GroupBackupFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBackupFiles.Controls.Add(this.GridBackupFiles);
            this.GroupBackupFiles.Controls.Add(this.PanelFileDetails);
            this.GroupBackupFiles.Controls.Add(this.PanelButtons);
            this.GroupBackupFiles.Location = new System.Drawing.Point(12, 12);
            this.GroupBackupFiles.Name = "GroupBackupFiles";
            this.GroupBackupFiles.Size = new System.Drawing.Size(920, 437);
            this.GroupBackupFiles.TabIndex = 17;
            this.GroupBackupFiles.Text = "BACKUP FILES";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonEdit);
            this.PanelButtons.Controls.Add(this.ButtonDelete);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Controls.Add(this.ButtonBackupFile);
            this.PanelButtons.Controls.Add(this.ButtonRestoreFile);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 396);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(916, 39);
            this.PanelButtons.TabIndex = 1181;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(8, 8);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEdit.Size = new System.Drawing.Size(93, 23);
            this.ButtonEdit.TabIndex = 8;
            this.ButtonEdit.Text = "Edit Details";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(107, 8);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(69, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Location = new System.Drawing.Point(182, 8);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(86, 23);
            this.ButtonDeleteAll.TabIndex = 7;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // ButtonBackupFile
            // 
            this.ButtonBackupFile.Location = new System.Drawing.Point(274, 8);
            this.ButtonBackupFile.Name = "ButtonBackupFile";
            this.ButtonBackupFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonBackupFile.Size = new System.Drawing.Size(93, 23);
            this.ButtonBackupFile.TabIndex = 9;
            this.ButtonBackupFile.Text = "Backup File";
            this.ButtonBackupFile.Click += new System.EventHandler(this.ButtonBackupFile_Click);
            // 
            // ButtonRestoreFile
            // 
            this.ButtonRestoreFile.Location = new System.Drawing.Point(373, 8);
            this.ButtonRestoreFile.Name = "ButtonRestoreFile";
            this.ButtonRestoreFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreFile.Size = new System.Drawing.Size(93, 23);
            this.ButtonRestoreFile.TabIndex = 10;
            this.ButtonRestoreFile.Text = "Restore File";
            this.ButtonRestoreFile.Click += new System.EventHandler(this.ButtonRestoreFile_Click);
            // 
            // PanelFileDetails
            // 
            this.PanelFileDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelFileDetails.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelFileDetails.Controls.Add(this.LabelInstallPath);
            this.PanelFileDetails.Controls.Add(this.labelControl2);
            this.PanelFileDetails.Controls.Add(this.LabelLocalPath);
            this.PanelFileDetails.Controls.Add(this.labelControl13);
            this.PanelFileDetails.Controls.Add(this.LabelCreatedOn);
            this.PanelFileDetails.Controls.Add(this.labelControl11);
            this.PanelFileDetails.Controls.Add(this.LabelFileSize);
            this.PanelFileDetails.Controls.Add(this.labelControl9);
            this.PanelFileDetails.Controls.Add(this.LabelFileName);
            this.PanelFileDetails.Controls.Add(this.labelControl7);
            this.PanelFileDetails.Controls.Add(this.LabelGameTitle);
            this.PanelFileDetails.Controls.Add(this.labelControl4);
            this.PanelFileDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFileDetails.Location = new System.Drawing.Point(588, 23);
            this.PanelFileDetails.Name = "PanelFileDetails";
            this.PanelFileDetails.Size = new System.Drawing.Size(330, 373);
            this.PanelFileDetails.TabIndex = 1182;
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelInstallPath.Appearance.Options.UseFont = true;
            this.LabelInstallPath.Appearance.Options.UseTextOptions = true;
            this.LabelInstallPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelInstallPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstallPath.Location = new System.Drawing.Point(97, 178);
            this.LabelInstallPath.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.LabelInstallPath.Size = new System.Drawing.Size(229, 62);
            this.LabelInstallPath.TabIndex = 50;
            this.LabelInstallPath.Text = "...";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl2.Location = new System.Drawing.Point(10, 178);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 15);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Install Path:";
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLocalPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLocalPath.Appearance.Options.UseFont = true;
            this.LabelLocalPath.Appearance.Options.UseTextOptions = true;
            this.LabelLocalPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelLocalPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLocalPath.Location = new System.Drawing.Point(95, 100);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(229, 72);
            this.LabelLocalPath.TabIndex = 48;
            this.LabelLocalPath.Text = "...";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl13.Location = new System.Drawing.Point(8, 100);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 15);
            this.labelControl13.TabIndex = 47;
            this.labelControl13.Text = "Local Path:";
            // 
            // LabelCreatedOn
            // 
            this.LabelCreatedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCreatedOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedOn.Appearance.Options.UseFont = true;
            this.LabelCreatedOn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedOn.Location = new System.Drawing.Point(95, 77);
            this.LabelCreatedOn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelCreatedOn.Name = "LabelCreatedOn";
            this.LabelCreatedOn.Size = new System.Drawing.Size(229, 15);
            this.LabelCreatedOn.TabIndex = 46;
            this.LabelCreatedOn.Text = "...";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl11.Location = new System.Drawing.Point(8, 77);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(66, 15);
            this.labelControl11.TabIndex = 45;
            this.labelControl11.Text = "Created On:";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.Appearance.Options.UseFont = true;
            this.LabelFileSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(95, 54);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(229, 15);
            this.LabelFileSize.TabIndex = 44;
            this.LabelFileSize.Text = "...";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl9.Location = new System.Drawing.Point(8, 54);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 15);
            this.labelControl9.TabIndex = 43;
            this.labelControl9.Text = "File Size:";
            // 
            // LabelFileName
            // 
            this.LabelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileName.Appearance.Options.UseFont = true;
            this.LabelFileName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileName.Location = new System.Drawing.Point(95, 31);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(229, 15);
            this.LabelFileName.TabIndex = 42;
            this.LabelFileName.Text = "...";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl7.Location = new System.Drawing.Point(8, 31);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 15);
            this.labelControl7.TabIndex = 41;
            this.labelControl7.Text = "File Name:";
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameTitle.Appearance.Options.UseFont = true;
            this.LabelGameTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameTitle.Location = new System.Drawing.Point(95, 8);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Size = new System.Drawing.Size(229, 15);
            this.LabelGameTitle.TabIndex = 40;
            this.LabelGameTitle.Text = "...";
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
            // GameBackupFiles
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.GroupBackupFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameBackupFiles.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBackupFiles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup Files";
            this.Load += new System.EventHandler(this.GameBackupFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBackupFiles)).EndInit();
            this.GroupBackupFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileDetails)).EndInit();
            this.PanelFileDetails.ResumeLayout(false);
            this.PanelFileDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl GridBackupFiles;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnGameId;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnGameTitle;
        private DataGridViewTextBoxColumn ColumnFileName;
        private DataGridViewTextBoxColumn ColumnFileSize;
        private DataGridViewTextBoxColumn ColumnCreatedOn;
        private GridView GridViewBackupFiles;
        private GroupControl GroupBackupFiles;
        private StackPanel PanelButtons;
        private SimpleButton ButtonDelete;
        private SimpleButton ButtonDeleteAll;
        private PanelControl PanelFileDetails;
        private LabelControl LabelInstallPath;
        private LabelControl labelControl2;
        private LabelControl LabelLocalPath;
        private LabelControl labelControl13;
        private LabelControl LabelCreatedOn;
        private LabelControl labelControl11;
        private LabelControl LabelFileSize;
        private LabelControl labelControl9;
        private LabelControl LabelFileName;
        private LabelControl labelControl7;
        private LabelControl LabelGameTitle;
        private LabelControl labelControl4;
        private SimpleButton ButtonEdit;
        private SimpleButton ButtonBackupFile;
        private SimpleButton ButtonRestoreFile;
    }
}