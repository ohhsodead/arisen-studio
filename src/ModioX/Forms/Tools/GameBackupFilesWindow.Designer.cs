namespace ModioX.Forms.Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBackupFilesWindow));
            this.DgvBackupFiles = new DarkUI.Controls.DarkDataGridView();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionBackupFiles = new DarkUI.Controls.DarkSectionPanel();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemEditBackup = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDeleteBackup = new System.Windows.Forms.ToolStripButton();
            this.ToolItemBackupFile = new System.Windows.Forms.ToolStripButton();
            this.ToolItemRestoreFile = new System.Windows.Forms.ToolStripButton();
            this.SectionBackupDetails = new DarkUI.Controls.DarkSectionPanel();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelHeaderGameTitle = new System.Windows.Forms.Label();
            this.LabelGameTitle = new System.Windows.Forms.Label();
            this.LabelHeaderFileName = new System.Windows.Forms.Label();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.LabelHeaderFileSize = new System.Windows.Forms.Label();
            this.LabelFileSize = new System.Windows.Forms.Label();
            this.LabelHeaderCreatedOn = new System.Windows.Forms.Label();
            this.LabelCreatedDate = new System.Windows.Forms.Label();
            this.LabelHeaderLocalPath = new System.Windows.Forms.Label();
            this.LabelLocalPath = new System.Windows.Forms.Label();
            this.LabelHeaderInstallFilePath = new System.Windows.Forms.Label();
            this.LabelConsolePath = new System.Windows.Forms.Label();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNoBackupFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBackupFiles)).BeginInit();
            this.SectionBackupFiles.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.SectionBackupDetails.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBackupFiles
            // 
            this.DgvBackupFiles.AllowUserToAddRows = false;
            this.DgvBackupFiles.AllowUserToDeleteRows = false;
            this.DgvBackupFiles.AllowUserToDragDropRows = false;
            this.DgvBackupFiles.AllowUserToPasteCells = false;
            this.DgvBackupFiles.AllowUserToResizeColumns = false;
            this.DgvBackupFiles.ColumnHeadersHeight = 19;
            this.DgvBackupFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGameTitle,
            this.ColumnFileName,
            this.ColumnFileSize,
            this.ColumnCreatedOn});
            this.DgvBackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBackupFiles.Location = new System.Drawing.Point(1, 25);
            this.DgvBackupFiles.MultiSelect = false;
            this.DgvBackupFiles.Name = "DgvBackupFiles";
            this.DgvBackupFiles.ReadOnly = true;
            this.DgvBackupFiles.RowHeadersWidth = 41;
            this.DgvBackupFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBackupFiles.RowTemplate.Height = 24;
            this.DgvBackupFiles.RowTemplate.ReadOnly = true;
            this.DgvBackupFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvBackupFiles.Size = new System.Drawing.Size(617, 197);
            this.DgvBackupFiles.TabIndex = 12;
            this.DgvBackupFiles.SelectionChanged += new System.EventHandler(this.DgvBackupFiles_SelectionChanged);
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
            // SectionBackupFiles
            // 
            this.SectionBackupFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionBackupFiles.Controls.Add(this.LabelNoBackupFiles);
            this.SectionBackupFiles.Controls.Add(this.DgvBackupFiles);
            this.SectionBackupFiles.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionBackupFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionBackupFiles.Location = new System.Drawing.Point(13, 13);
            this.SectionBackupFiles.Margin = new System.Windows.Forms.Padding(4);
            this.SectionBackupFiles.Name = "SectionBackupFiles";
            this.SectionBackupFiles.SectionHeader = "BACKUP FILES";
            this.SectionBackupFiles.Size = new System.Drawing.Size(619, 259);
            this.SectionBackupFiles.TabIndex = 15;
            // 
            // ToolStripArchiveInformation
            // 
            this.ToolStripArchiveInformation.AutoSize = false;
            this.ToolStripArchiveInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripArchiveInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripArchiveInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripArchiveInformation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripArchiveInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripArchiveInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemEditBackup,
            this.ToolItemDeleteBackup,
            this.ToolItemBackupFile,
            this.ToolItemRestoreFile});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 222);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(617, 36);
            this.ToolStripArchiveInformation.TabIndex = 17;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolItemEditBackup
            // 
            this.ToolItemEditBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemEditBackup.Enabled = false;
            this.ToolItemEditBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemEditBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemEditBackup.Image = global::ModioX.Properties.Resources.edit;
            this.ToolItemEditBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemEditBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemEditBackup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemEditBackup.Name = "ToolItemEditBackup";
            this.ToolItemEditBackup.Size = new System.Drawing.Size(117, 26);
            this.ToolItemEditBackup.Text = "Edit File Details";
            this.ToolItemEditBackup.Click += new System.EventHandler(this.ToolItemEditBackup_Click);
            // 
            // ToolItemDeleteBackup
            // 
            this.ToolItemDeleteBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDeleteBackup.Enabled = false;
            this.ToolItemDeleteBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDeleteBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDeleteBackup.Image = global::ModioX.Properties.Resources.delete;
            this.ToolItemDeleteBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDeleteBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDeleteBackup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDeleteBackup.Name = "ToolItemDeleteBackup";
            this.ToolItemDeleteBackup.Size = new System.Drawing.Size(93, 26);
            this.ToolItemDeleteBackup.Text = "Delete File";
            this.ToolItemDeleteBackup.Click += new System.EventHandler(this.ToolItemDeleteBackup_Click);
            // 
            // ToolItemBackupFile
            // 
            this.ToolItemBackupFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemBackupFile.Enabled = false;
            this.ToolItemBackupFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemBackupFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemBackupFile.Image = global::ModioX.Properties.Resources.download;
            this.ToolItemBackupFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemBackupFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemBackupFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemBackupFile.Name = "ToolItemBackupFile";
            this.ToolItemBackupFile.Size = new System.Drawing.Size(96, 26);
            this.ToolItemBackupFile.Text = "Backup File";
            this.ToolItemBackupFile.Click += new System.EventHandler(this.ToolItemBackupFile_Click);
            // 
            // ToolItemRestoreFile
            // 
            this.ToolItemRestoreFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemRestoreFile.Enabled = false;
            this.ToolItemRestoreFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemRestoreFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemRestoreFile.Image = global::ModioX.Properties.Resources.restore_file;
            this.ToolItemRestoreFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemRestoreFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemRestoreFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemRestoreFile.Name = "ToolItemRestoreFile";
            this.ToolItemRestoreFile.Size = new System.Drawing.Size(99, 26);
            this.ToolItemRestoreFile.Text = "Restore File";
            this.ToolItemRestoreFile.Click += new System.EventHandler(this.ToolItemRestoreFile_Click);
            // 
            // SectionBackupDetails
            // 
            this.SectionBackupDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionBackupDetails.Controls.Add(this.FlowPanelDetails);
            this.SectionBackupDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionBackupDetails.Location = new System.Drawing.Point(13, 280);
            this.SectionBackupDetails.Margin = new System.Windows.Forms.Padding(4);
            this.SectionBackupDetails.Name = "SectionBackupDetails";
            this.SectionBackupDetails.SectionHeader = "BACKUP FILE DETAILS";
            this.SectionBackupDetails.Size = new System.Drawing.Size(619, 204);
            this.SectionBackupDetails.TabIndex = 16;
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderGameTitle);
            this.FlowPanelDetails.Controls.Add(this.LabelGameTitle);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderFileName);
            this.FlowPanelDetails.Controls.Add(this.LabelFileName);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderFileSize);
            this.FlowPanelDetails.Controls.Add(this.LabelFileSize);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderCreatedOn);
            this.FlowPanelDetails.Controls.Add(this.LabelCreatedDate);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderLocalPath);
            this.FlowPanelDetails.Controls.Add(this.LabelLocalPath);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderInstallFilePath);
            this.FlowPanelDetails.Controls.Add(this.LabelConsolePath);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(4, 5, 18, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(617, 178);
            this.FlowPanelDetails.TabIndex = 15;
            // 
            // LabelHeaderGameTitle
            // 
            this.LabelHeaderGameTitle.AutoSize = true;
            this.LabelHeaderGameTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGameTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameTitle.Location = new System.Drawing.Point(7, 8);
            this.LabelHeaderGameTitle.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderGameTitle.Name = "LabelHeaderGameTitle";
            this.LabelHeaderGameTitle.Size = new System.Drawing.Size(71, 15);
            this.LabelHeaderGameTitle.TabIndex = 24;
            this.LabelHeaderGameTitle.Text = "Game Title:";
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelGameTitle, true);
            this.LabelGameTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameTitle.Location = new System.Drawing.Point(80, 8);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Size = new System.Drawing.Size(16, 15);
            this.LabelGameTitle.TabIndex = 23;
            this.LabelGameTitle.Text = "...";
            // 
            // LabelHeaderFileName
            // 
            this.LabelHeaderFileName.AutoSize = true;
            this.LabelHeaderFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileName.Location = new System.Drawing.Point(7, 29);
            this.LabelHeaderFileName.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderFileName.Name = "LabelHeaderFileName";
            this.LabelHeaderFileName.Size = new System.Drawing.Size(65, 15);
            this.LabelHeaderFileName.TabIndex = 16;
            this.LabelHeaderFileName.Text = "File Name:";
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelFileName, true);
            this.LabelFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileName.Location = new System.Drawing.Point(74, 29);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(16, 15);
            this.LabelFileName.TabIndex = 17;
            this.LabelFileName.Text = "...";
            // 
            // LabelHeaderFileSize
            // 
            this.LabelHeaderFileSize.AutoSize = true;
            this.LabelHeaderFileSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileSize.Location = new System.Drawing.Point(7, 50);
            this.LabelHeaderFileSize.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderFileSize.Name = "LabelHeaderFileSize";
            this.LabelHeaderFileSize.Size = new System.Drawing.Size(55, 15);
            this.LabelHeaderFileSize.TabIndex = 28;
            this.LabelHeaderFileSize.Text = "File Size:";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelFileSize, true);
            this.LabelFileSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileSize.Location = new System.Drawing.Point(64, 50);
            this.LabelFileSize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(16, 15);
            this.LabelFileSize.TabIndex = 29;
            this.LabelFileSize.Text = "...";
            // 
            // LabelHeaderCreatedOn
            // 
            this.LabelHeaderCreatedOn.AutoSize = true;
            this.LabelHeaderCreatedOn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCreatedOn.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderCreatedOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCreatedOn.Location = new System.Drawing.Point(7, 71);
            this.LabelHeaderCreatedOn.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderCreatedOn.Name = "LabelHeaderCreatedOn";
            this.LabelHeaderCreatedOn.Size = new System.Drawing.Size(73, 15);
            this.LabelHeaderCreatedOn.TabIndex = 27;
            this.LabelHeaderCreatedOn.Text = "Created On:";
            // 
            // LabelCreatedDate
            // 
            this.LabelCreatedDate.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelCreatedDate, true);
            this.LabelCreatedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCreatedDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCreatedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCreatedDate.Location = new System.Drawing.Point(82, 71);
            this.LabelCreatedDate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelCreatedDate.Name = "LabelCreatedDate";
            this.LabelCreatedDate.Size = new System.Drawing.Size(16, 15);
            this.LabelCreatedDate.TabIndex = 26;
            this.LabelCreatedDate.Text = "...";
            // 
            // LabelHeaderLocalPath
            // 
            this.LabelHeaderLocalPath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderLocalPath, true);
            this.LabelHeaderLocalPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderLocalPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLocalPath.Location = new System.Drawing.Point(7, 92);
            this.LabelHeaderLocalPath.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderLocalPath.Name = "LabelHeaderLocalPath";
            this.LabelHeaderLocalPath.Size = new System.Drawing.Size(66, 15);
            this.LabelHeaderLocalPath.TabIndex = 3;
            this.LabelHeaderLocalPath.Text = "Local Path:";
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelLocalPath, true);
            this.LabelLocalPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLocalPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelLocalPath.Location = new System.Drawing.Point(7, 113);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(3);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(16, 15);
            this.LabelLocalPath.TabIndex = 4;
            this.LabelLocalPath.Text = "...";
            // 
            // LabelHeaderInstallFilePath
            // 
            this.LabelHeaderInstallFilePath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderInstallFilePath, true);
            this.LabelHeaderInstallFilePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallFilePath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderInstallFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderInstallFilePath.Location = new System.Drawing.Point(7, 134);
            this.LabelHeaderInstallFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderInstallFilePath.Name = "LabelHeaderInstallFilePath";
            this.LabelHeaderInstallFilePath.Size = new System.Drawing.Size(68, 15);
            this.LabelHeaderInstallFilePath.TabIndex = 6;
            this.LabelHeaderInstallFilePath.Text = "Install Path";
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConsolePath, true);
            this.LabelConsolePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConsolePath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConsolePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConsolePath.Location = new System.Drawing.Point(7, 155);
            this.LabelConsolePath.Margin = new System.Windows.Forms.Padding(3);
            this.LabelConsolePath.Name = "LabelConsolePath";
            this.LabelConsolePath.Size = new System.Drawing.Size(16, 15);
            this.LabelConsolePath.TabIndex = 15;
            this.LabelConsolePath.Text = "...";
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
            // LabelNoBackupFiles
            // 
            this.LabelNoBackupFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoBackupFiles.AutoSize = true;
            this.LabelNoBackupFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoBackupFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoBackupFiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoBackupFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoBackupFiles.Location = new System.Drawing.Point(256, 93);
            this.LabelNoBackupFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoBackupFiles.Name = "LabelNoBackupFiles";
            this.LabelNoBackupFiles.Size = new System.Drawing.Size(107, 15);
            this.LabelNoBackupFiles.TabIndex = 1179;
            this.LabelNoBackupFiles.Text = "NO BACKUP FILES";
            // 
            // GameBackupFilesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.SectionBackupDetails);
            this.Controls.Add(this.SectionBackupFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBackupFilesWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Backup Files";
            this.Load += new System.EventHandler(this.GameBackupFilesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBackupFiles)).EndInit();
            this.SectionBackupFiles.ResumeLayout(false);
            this.SectionBackupFiles.PerformLayout();
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.SectionBackupDetails.ResumeLayout(false);
            this.SectionBackupDetails.PerformLayout();
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkDataGridView DgvBackupFiles;
        private DarkUI.Controls.DarkSectionPanel SectionBackupFiles;
        private DarkUI.Controls.DarkSectionPanel SectionBackupDetails;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelHeaderGameTitle;
        private System.Windows.Forms.Label LabelGameTitle;
        private System.Windows.Forms.Label LabelHeaderFileName;
        private System.Windows.Forms.Label LabelHeaderLocalPath;
        private System.Windows.Forms.Label LabelLocalPath;
        private System.Windows.Forms.Label LabelHeaderInstallFilePath;
        private System.Windows.Forms.Label LabelConsolePath;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripButton ToolItemEditBackup;
        private System.Windows.Forms.ToolStripButton ToolItemDeleteBackup;
        private System.Windows.Forms.ToolStripButton ToolItemBackupFile;
        private System.Windows.Forms.ToolStripButton ToolItemRestoreFile;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label LabelHeaderCreatedOn;
        private System.Windows.Forms.Label LabelCreatedDate;
        private System.Windows.Forms.Label LabelHeaderFileSize;
        private System.Windows.Forms.Label LabelFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedOn;
        private System.Windows.Forms.Label LabelNoBackupFiles;
    }
}