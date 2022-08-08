using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ArisenStudio.Forms.Tools.PS3
{
    partial class BackupFilesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupFilesManager));
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
            this.PanelFileDetails = new DevExpress.XtraEditors.PanelControl();
            this.LabelInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderInstallPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelLocalPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderLocalPath = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreatedOn = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderCreatedOn = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileSize = new DevExpress.XtraEditors.LabelControl();
            this.LabelFileName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileName = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFileDetails = new DevExpress.XtraEditors.LabelControl();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRestoreFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonBackupFile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileDetails)).BeginInit();
            this.PanelFileDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBackupFiles
            // 
            this.GridBackupFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBackupFiles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridBackupFiles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridBackupFiles.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridBackupFiles.Location = new System.Drawing.Point(12, 12);
            this.GridBackupFiles.MainView = this.GridViewBackupFiles;
            this.GridBackupFiles.Name = "GridBackupFiles";
            this.GridBackupFiles.Size = new System.Drawing.Size(590, 407);
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
            // PanelFileDetails
            // 
            this.PanelFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFileDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelFileDetails.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelFileDetails.Controls.Add(this.LabelInstallPath);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderInstallPath);
            this.PanelFileDetails.Controls.Add(this.LabelLocalPath);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderLocalPath);
            this.PanelFileDetails.Controls.Add(this.LabelCreatedOn);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderCreatedOn);
            this.PanelFileDetails.Controls.Add(this.LabelFileSize);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderFileSize);
            this.PanelFileDetails.Controls.Add(this.LabelFileName);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderFileName);
            this.PanelFileDetails.Controls.Add(this.LabelGameTitle);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderGameTitle);
            this.PanelFileDetails.Controls.Add(this.LabelHeaderFileDetails);
            this.PanelFileDetails.Location = new System.Drawing.Point(602, 12);
            this.PanelFileDetails.Name = "PanelFileDetails";
            this.PanelFileDetails.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.PanelFileDetails.Size = new System.Drawing.Size(330, 407);
            this.PanelFileDetails.TabIndex = 1182;
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelInstallPath.Appearance.Options.UseFont = true;
            this.LabelInstallPath.Appearance.Options.UseTextOptions = true;
            this.LabelInstallPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelInstallPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelInstallPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstallPath.Location = new System.Drawing.Point(8, 241);
            this.LabelInstallPath.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.LabelInstallPath.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.LabelInstallPath.Size = new System.Drawing.Size(322, 24);
            this.LabelInstallPath.TabIndex = 50;
            this.LabelInstallPath.Text = "-";
            // 
            // LabelHeaderInstallPath
            // 
            this.LabelHeaderInstallPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallPath.Appearance.Options.UseFont = true;
            this.LabelHeaderInstallPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderInstallPath.Location = new System.Drawing.Point(8, 226);
            this.LabelHeaderInstallPath.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.LabelHeaderInstallPath.Name = "LabelHeaderInstallPath";
            this.LabelHeaderInstallPath.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderInstallPath.TabIndex = 49;
            this.LabelHeaderInstallPath.Text = "Install Path";
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLocalPath.Appearance.Options.UseFont = true;
            this.LabelLocalPath.Appearance.Options.UseTextOptions = true;
            this.LabelLocalPath.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelLocalPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelLocalPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLocalPath.Location = new System.Drawing.Point(8, 202);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.LabelLocalPath.Size = new System.Drawing.Size(322, 24);
            this.LabelLocalPath.TabIndex = 48;
            this.LabelLocalPath.Text = "-";
            // 
            // LabelHeaderLocalPath
            // 
            this.LabelHeaderLocalPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderLocalPath.Appearance.Options.UseFont = true;
            this.LabelHeaderLocalPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLocalPath.Location = new System.Drawing.Point(8, 187);
            this.LabelHeaderLocalPath.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.LabelHeaderLocalPath.Name = "LabelHeaderLocalPath";
            this.LabelHeaderLocalPath.Size = new System.Drawing.Size(56, 15);
            this.LabelHeaderLocalPath.TabIndex = 47;
            this.LabelHeaderLocalPath.Text = "Local Path";
            // 
            // LabelCreatedOn
            // 
            this.LabelCreatedOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedOn.Appearance.Options.UseFont = true;
            this.LabelCreatedOn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelCreatedOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedOn.Location = new System.Drawing.Point(8, 163);
            this.LabelCreatedOn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelCreatedOn.Name = "LabelCreatedOn";
            this.LabelCreatedOn.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.LabelCreatedOn.Size = new System.Drawing.Size(322, 24);
            this.LabelCreatedOn.TabIndex = 46;
            this.LabelCreatedOn.Text = "-";
            // 
            // LabelHeaderCreatedOn
            // 
            this.LabelHeaderCreatedOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCreatedOn.Appearance.Options.UseFont = true;
            this.LabelHeaderCreatedOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCreatedOn.Location = new System.Drawing.Point(8, 148);
            this.LabelHeaderCreatedOn.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.LabelHeaderCreatedOn.Name = "LabelHeaderCreatedOn";
            this.LabelHeaderCreatedOn.Size = new System.Drawing.Size(63, 15);
            this.LabelHeaderCreatedOn.TabIndex = 45;
            this.LabelHeaderCreatedOn.Text = "Created On";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.Appearance.Options.UseFont = true;
            this.LabelFileSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelFileSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(8, 124);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.LabelFileSize.Size = new System.Drawing.Size(322, 24);
            this.LabelFileSize.TabIndex = 44;
            this.LabelFileSize.Text = "-";
            // 
            // LabelHeaderFileSize
            // 
            this.LabelHeaderFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileSize.Appearance.Options.UseFont = true;
            this.LabelHeaderFileSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileSize.Location = new System.Drawing.Point(8, 109);
            this.LabelHeaderFileSize.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.LabelHeaderFileSize.Name = "LabelHeaderFileSize";
            this.LabelHeaderFileSize.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderFileSize.TabIndex = 43;
            this.LabelHeaderFileSize.Text = "File Size";
            // 
            // LabelFileName
            // 
            this.LabelFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileName.Appearance.Options.UseFont = true;
            this.LabelFileName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileName.Location = new System.Drawing.Point(8, 85);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.LabelFileName.Size = new System.Drawing.Size(322, 24);
            this.LabelFileName.TabIndex = 42;
            this.LabelFileName.Text = "-";
            // 
            // LabelHeaderFileName
            // 
            this.LabelHeaderFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileName.Appearance.Options.UseFont = true;
            this.LabelHeaderFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileName.Location = new System.Drawing.Point(8, 70);
            this.LabelHeaderFileName.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.LabelHeaderFileName.Name = "LabelHeaderFileName";
            this.LabelHeaderFileName.Size = new System.Drawing.Size(55, 15);
            this.LabelHeaderFileName.TabIndex = 41;
            this.LabelHeaderFileName.Text = "File Name";
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameTitle.Appearance.Options.UseFont = true;
            this.LabelGameTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelGameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameTitle.Location = new System.Drawing.Point(8, 46);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.LabelGameTitle.Size = new System.Drawing.Size(322, 24);
            this.LabelGameTitle.TabIndex = 40;
            this.LabelGameTitle.Text = "-";
            // 
            // LabelHeaderGameTitle
            // 
            this.LabelHeaderGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGameTitle.Appearance.Options.UseFont = true;
            this.LabelHeaderGameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameTitle.Location = new System.Drawing.Point(8, 31);
            this.LabelHeaderGameTitle.Margin = new System.Windows.Forms.Padding(10, 3, 2, 3);
            this.LabelHeaderGameTitle.Name = "LabelHeaderGameTitle";
            this.LabelHeaderGameTitle.Size = new System.Drawing.Size(61, 15);
            this.LabelHeaderGameTitle.TabIndex = 39;
            this.LabelHeaderGameTitle.Text = "Game Title";
            // 
            // LabelHeaderFileDetails
            // 
            this.LabelHeaderFileDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileDetails.Appearance.Options.UseFont = true;
            this.LabelHeaderFileDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderFileDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileDetails.Location = new System.Drawing.Point(8, 6);
            this.LabelHeaderFileDetails.Margin = new System.Windows.Forms.Padding(10, 0, 2, 3);
            this.LabelHeaderFileDetails.Name = "LabelHeaderFileDetails";
            this.LabelHeaderFileDetails.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.LabelHeaderFileDetails.Size = new System.Drawing.Size(69, 25);
            this.LabelHeaderFileDetails.TabIndex = 51;
            this.LabelHeaderFileDetails.Text = "File Details";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonEdit);
            this.PanelButtons.Controls.Add(this.ButtonDelete);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Controls.Add(this.ButtonRestoreFile);
            this.PanelButtons.Controls.Add(this.ButtonBackupFile);
            this.PanelButtons.Location = new System.Drawing.Point(12, 425);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(920, 24);
            this.PanelButtons.TabIndex = 1181;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEdit.Appearance.Options.UseFont = true;
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.Location = new System.Drawing.Point(0, 0);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonEdit.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonEdit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEdit.Size = new System.Drawing.Size(47, 24);
            this.ButtonEdit.TabIndex = 8;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDelete.Appearance.Options.UseFont = true;
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.Location = new System.Drawing.Point(53, 0);
            this.ButtonDelete.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(60, 24);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDeleteAll.Appearance.Options.UseFont = true;
            this.ButtonDeleteAll.AutoSize = true;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(119, 0);
            this.ButtonDeleteAll.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(77, 24);
            this.ButtonDeleteAll.TabIndex = 7;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // ButtonRestoreFile
            // 
            this.ButtonRestoreFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRestoreFile.Appearance.Options.UseFont = true;
            this.ButtonRestoreFile.AutoSize = true;
            this.ButtonRestoreFile.Location = new System.Drawing.Point(202, 0);
            this.ButtonRestoreFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRestoreFile.Name = "ButtonRestoreFile";
            this.ButtonRestoreFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonRestoreFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreFile.Size = new System.Drawing.Size(87, 24);
            this.ButtonRestoreFile.TabIndex = 10;
            this.ButtonRestoreFile.Text = "Restore File";
            this.ButtonRestoreFile.Click += new System.EventHandler(this.ButtonRestoreFile_Click);
            // 
            // ButtonBackupFile
            // 
            this.ButtonBackupFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBackupFile.Appearance.ForeColor = System.Drawing.Color.White;
            this.ButtonBackupFile.Appearance.Options.UseFont = true;
            this.ButtonBackupFile.Appearance.Options.UseForeColor = true;
            this.ButtonBackupFile.AutoSize = true;
            this.ButtonBackupFile.Location = new System.Drawing.Point(295, 0);
            this.ButtonBackupFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonBackupFile.Name = "ButtonBackupFile";
            this.ButtonBackupFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonBackupFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonBackupFile.Size = new System.Drawing.Size(87, 24);
            this.ButtonBackupFile.TabIndex = 9;
            this.ButtonBackupFile.Text = "Backup File";
            this.ButtonBackupFile.Click += new System.EventHandler(this.ButtonBackupFile_Click);
            // 
            // BackupFilesManager
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.GridBackupFiles);
            this.Controls.Add(this.PanelFileDetails);
            this.Controls.Add(this.PanelButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("BackupFilesManager.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupFilesManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup Files Manager";
            this.Load += new System.EventHandler(this.BackupFilesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBackupFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileDetails)).EndInit();
            this.PanelFileDetails.ResumeLayout(false);
            this.PanelFileDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
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
        private StackPanel PanelButtons;
        private SimpleButton ButtonDelete;
        private SimpleButton ButtonDeleteAll;
        private PanelControl PanelFileDetails;
        private LabelControl LabelInstallPath;
        private LabelControl LabelHeaderInstallPath;
        private LabelControl LabelLocalPath;
        private LabelControl LabelHeaderLocalPath;
        private LabelControl LabelCreatedOn;
        private LabelControl LabelHeaderCreatedOn;
        private LabelControl LabelFileSize;
        private LabelControl LabelHeaderFileSize;
        private LabelControl LabelFileName;
        private LabelControl LabelHeaderFileName;
        private LabelControl LabelGameTitle;
        private LabelControl LabelHeaderGameTitle;
        private SimpleButton ButtonEdit;
        private SimpleButton ButtonBackupFile;
        private SimpleButton ButtonRestoreFile;
        private LabelControl LabelHeaderFileDetails;
    }
}