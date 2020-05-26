namespace ModioX.Forms
{
    partial class EditBackupFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBackupFiles));
            this.DgvBackups = new DarkUI.Controls.DarkDataGridView();
            this.SectionBackupFile = new DarkUI.Controls.DarkSectionPanel();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemEditBackup = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDeleteBackup = new System.Windows.Forms.ToolStripButton();
            this.ToolItemBackupFile = new System.Windows.Forms.ToolStripButton();
            this.ToolItemRestoreFile = new System.Windows.Forms.ToolStripButton();
            this.SectionBackupDetails = new DarkUI.Controls.DarkSectionPanel();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelHeaderGame = new System.Windows.Forms.Label();
            this.LabelGame = new System.Windows.Forms.Label();
            this.LabelHeaderFileName = new System.Windows.Forms.Label();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.LabelHeaderLocalPath = new System.Windows.Forms.Label();
            this.LabelLocalPath = new System.Windows.Forms.Label();
            this.LabelHeaderInstallPath = new System.Windows.Forms.Label();
            this.LabelConsolePath = new System.Windows.Forms.Label();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBackups)).BeginInit();
            this.SectionBackupFile.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.SectionBackupDetails.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBackups
            // 
            this.DgvBackups.AllowUserToAddRows = false;
            this.DgvBackups.AllowUserToDeleteRows = false;
            this.DgvBackups.AllowUserToDragDropRows = false;
            this.DgvBackups.AllowUserToPasteCells = false;
            this.DgvBackups.AllowUserToResizeColumns = false;
            this.DgvBackups.ColumnHeadersHeight = 23;
            this.DgvBackups.ColumnHeadersVisible = false;
            this.DgvBackups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBackups.Location = new System.Drawing.Point(1, 25);
            this.DgvBackups.MultiSelect = false;
            this.DgvBackups.Name = "DgvBackups";
            this.DgvBackups.ReadOnly = true;
            this.DgvBackups.RowHeadersWidth = 41;
            this.DgvBackups.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBackups.RowTemplate.Height = 24;
            this.DgvBackups.RowTemplate.ReadOnly = true;
            this.DgvBackups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvBackups.Size = new System.Drawing.Size(519, 189);
            this.DgvBackups.TabIndex = 12;
            this.DgvBackups.SelectionChanged += new System.EventHandler(this.DgvBackupFiles_SelectionChanged);
            // 
            // SectionBackupFile
            // 
            this.SectionBackupFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionBackupFile.Controls.Add(this.DgvBackups);
            this.SectionBackupFile.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionBackupFile.Location = new System.Drawing.Point(12, 12);
            this.SectionBackupFile.Name = "SectionBackupFile";
            this.SectionBackupFile.SectionHeader = "Backup Files";
            this.SectionBackupFile.Size = new System.Drawing.Size(521, 251);
            this.SectionBackupFile.TabIndex = 15;
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
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 214);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(519, 36);
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
            this.ToolItemEditBackup.Image = global::ModioX.Properties.Resources.icons8_edit_22;
            this.ToolItemEditBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemEditBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemEditBackup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemEditBackup.Name = "ToolItemEditBackup";
            this.ToolItemEditBackup.Size = new System.Drawing.Size(54, 26);
            this.ToolItemEditBackup.Text = "Edit";
            this.ToolItemEditBackup.Click += new System.EventHandler(this.ToolItemEditBackup_Click);
            // 
            // ToolItemDeleteBackup
            // 
            this.ToolItemDeleteBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDeleteBackup.Enabled = false;
            this.ToolItemDeleteBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDeleteBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDeleteBackup.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolItemDeleteBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDeleteBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDeleteBackup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDeleteBackup.Name = "ToolItemDeleteBackup";
            this.ToolItemDeleteBackup.Size = new System.Drawing.Size(71, 26);
            this.ToolItemDeleteBackup.Text = "Delete";
            this.ToolItemDeleteBackup.Click += new System.EventHandler(this.ToolItemDeleteBackup_Click);
            // 
            // ToolItemBackupFile
            // 
            this.ToolItemBackupFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemBackupFile.Enabled = false;
            this.ToolItemBackupFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemBackupFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemBackupFile.Image = global::ModioX.Properties.Resources.icons8_download_22;
            this.ToolItemBackupFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemBackupFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemBackupFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemBackupFile.Name = "ToolItemBackupFile";
            this.ToolItemBackupFile.Size = new System.Drawing.Size(74, 26);
            this.ToolItemBackupFile.Text = "Backup";
            this.ToolItemBackupFile.Click += new System.EventHandler(this.ToolItemBackupFile_Click);
            // 
            // ToolItemRestoreFile
            // 
            this.ToolItemRestoreFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemRestoreFile.Enabled = false;
            this.ToolItemRestoreFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemRestoreFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemRestoreFile.Image = global::ModioX.Properties.Resources.icons8_restore_page_22;
            this.ToolItemRestoreFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemRestoreFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemRestoreFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemRestoreFile.Name = "ToolItemRestoreFile";
            this.ToolItemRestoreFile.Size = new System.Drawing.Size(77, 26);
            this.ToolItemRestoreFile.Text = "Restore";
            this.ToolItemRestoreFile.Click += new System.EventHandler(this.ToolItemRestoreFile_Click);
            // 
            // SectionBackupDetails
            // 
            this.SectionBackupDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionBackupDetails.Controls.Add(this.FlowPanelDetails);
            this.SectionBackupDetails.Location = new System.Drawing.Point(12, 269);
            this.SectionBackupDetails.Name = "SectionBackupDetails";
            this.SectionBackupDetails.SectionHeader = "Backup File Details";
            this.SectionBackupDetails.Size = new System.Drawing.Size(521, 216);
            this.SectionBackupDetails.TabIndex = 16;
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderName);
            this.FlowPanelDetails.Controls.Add(this.LabelName);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderGame);
            this.FlowPanelDetails.Controls.Add(this.LabelGame);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderFileName);
            this.FlowPanelDetails.Controls.Add(this.LabelFileName);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderLocalPath);
            this.FlowPanelDetails.Controls.Add(this.LabelLocalPath);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderInstallPath);
            this.FlowPanelDetails.Controls.Add(this.LabelConsolePath);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(4, 4, 18, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(519, 190);
            this.FlowPanelDetails.TabIndex = 15;
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.AutoSize = true;
            this.LabelHeaderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(7, 7);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(43, 15);
            this.LabelHeaderName.TabIndex = 2;
            this.LabelHeaderName.Text = "Name:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelName, true);
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(52, 7);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(16, 15);
            this.LabelName.TabIndex = 25;
            this.LabelName.Text = "...";
            // 
            // LabelHeaderGame
            // 
            this.LabelHeaderGame.AutoSize = true;
            this.LabelHeaderGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGame.Location = new System.Drawing.Point(7, 28);
            this.LabelHeaderGame.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderGame.Name = "LabelHeaderGame";
            this.LabelHeaderGame.Size = new System.Drawing.Size(60, 15);
            this.LabelHeaderGame.TabIndex = 24;
            this.LabelHeaderGame.Text = "Category:";
            // 
            // LabelGame
            // 
            this.LabelGame.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelGame, true);
            this.LabelGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGame.Location = new System.Drawing.Point(69, 28);
            this.LabelGame.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(16, 15);
            this.LabelGame.TabIndex = 23;
            this.LabelGame.Text = "...";
            // 
            // LabelHeaderFileName
            // 
            this.LabelHeaderFileName.AutoSize = true;
            this.LabelHeaderFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileName.Location = new System.Drawing.Point(7, 49);
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
            this.LabelFileName.Location = new System.Drawing.Point(74, 49);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(16, 15);
            this.LabelFileName.TabIndex = 17;
            this.LabelFileName.Text = "...";
            // 
            // LabelHeaderLocalPath
            // 
            this.LabelHeaderLocalPath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderLocalPath, true);
            this.LabelHeaderLocalPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderLocalPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderLocalPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderLocalPath.Location = new System.Drawing.Point(7, 70);
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
            this.LabelLocalPath.Location = new System.Drawing.Point(7, 91);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(3);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(16, 15);
            this.LabelLocalPath.TabIndex = 4;
            this.LabelLocalPath.Text = "...";
            // 
            // LabelHeaderInstallPath
            // 
            this.LabelHeaderInstallPath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderInstallPath, true);
            this.LabelHeaderInstallPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderInstallPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderInstallPath.Location = new System.Drawing.Point(7, 112);
            this.LabelHeaderInstallPath.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderInstallPath.Name = "LabelHeaderInstallPath";
            this.LabelHeaderInstallPath.Size = new System.Drawing.Size(68, 15);
            this.LabelHeaderInstallPath.TabIndex = 6;
            this.LabelHeaderInstallPath.Text = "Install Path";
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConsolePath, true);
            this.LabelConsolePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConsolePath.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConsolePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConsolePath.Location = new System.Drawing.Point(7, 133);
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "File Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "File Size";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // ViewGameBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 497);
            this.Controls.Add(this.SectionBackupDetails);
            this.Controls.Add(this.SectionBackupFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewGameBackups";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Backup Files";
            this.Load += new System.EventHandler(this.BackupManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBackups)).EndInit();
            this.SectionBackupFile.ResumeLayout(false);
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.SectionBackupDetails.ResumeLayout(false);
            this.SectionBackupDetails.PerformLayout();
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkDataGridView DgvBackups;
        private DarkUI.Controls.DarkSectionPanel SectionBackupFile;
        private DarkUI.Controls.DarkSectionPanel SectionBackupDetails;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.Label LabelHeaderGame;
        private System.Windows.Forms.Label LabelGame;
        private System.Windows.Forms.Label LabelHeaderFileName;
        private System.Windows.Forms.Label LabelHeaderLocalPath;
        private System.Windows.Forms.Label LabelLocalPath;
        private System.Windows.Forms.Label LabelHeaderInstallPath;
        private System.Windows.Forms.Label LabelConsolePath;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripButton ToolItemEditBackup;
        private System.Windows.Forms.ToolStripButton ToolItemDeleteBackup;
        private System.Windows.Forms.ToolStripButton ToolItemBackupFile;
        private System.Windows.Forms.ToolStripButton ToolItemRestoreFile;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}