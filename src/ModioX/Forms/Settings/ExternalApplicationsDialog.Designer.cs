namespace ModioX.Forms.Settings
{
    partial class ExternalApplicationsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalApplicationsDialog));
            this.ButtonSaveAll = new DarkUI.Controls.DarkButton();
            this.SectionApplications = new DarkUI.Controls.DarkSectionPanel();
            this.DgvApplications = new DarkUI.Controls.DarkDataGridView();
            this.ColumnApplicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripGameRegions = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalApplications = new System.Windows.Forms.ToolStripLabel();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionAddApplication = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonNewApplication = new DarkUI.Controls.DarkButton();
            this.ButtonLocalFilePath = new DarkUI.Controls.DarkButton();
            this.TextBoxFileLocation = new DarkUI.Controls.DarkTextBox();
            this.TextBoxFileName = new DarkUI.Controls.DarkTextBox();
            this.ButtonAddApplication = new DarkUI.Controls.DarkButton();
            this.LabelFileLocation = new DarkUI.Controls.DarkLabel();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.SectionApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplications)).BeginInit();
            this.ToolStripGameRegions.SuspendLayout();
            this.SectionAddApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.Location = new System.Drawing.Point(582, 403);
            this.ButtonSaveAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Size = new System.Drawing.Size(79, 24);
            this.ButtonSaveAll.TabIndex = 3;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // SectionApplications
            // 
            this.SectionApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionApplications.Controls.Add(this.DgvApplications);
            this.SectionApplications.Controls.Add(this.ToolStripGameRegions);
            this.SectionApplications.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionApplications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionApplications.Location = new System.Drawing.Point(12, 12);
            this.SectionApplications.Margin = new System.Windows.Forms.Padding(4);
            this.SectionApplications.Name = "SectionApplications";
            this.SectionApplications.SectionHeader = "EXTERNAL APPLICATIONS";
            this.SectionApplications.Size = new System.Drawing.Size(651, 256);
            this.SectionApplications.TabIndex = 0;
            // 
            // DgvApplications
            // 
            this.DgvApplications.AllowUserToAddRows = false;
            this.DgvApplications.AllowUserToPasteCells = false;
            this.DgvApplications.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvApplications.ColumnHeadersHeight = 19;
            this.DgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnApplicationName,
            this.ColumnFileLocation});
            this.DgvApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvApplications.Location = new System.Drawing.Point(1, 25);
            this.DgvApplications.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvApplications.MultiSelect = false;
            this.DgvApplications.Name = "DgvApplications";
            this.DgvApplications.ReadOnly = true;
            this.DgvApplications.RowHeadersWidth = 41;
            this.DgvApplications.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvApplications.RowTemplate.Height = 24;
            this.DgvApplications.RowTemplate.ReadOnly = true;
            this.DgvApplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvApplications.Size = new System.Drawing.Size(649, 194);
            this.DgvApplications.TabIndex = 0;
            this.DgvApplications.SelectionChanged += new System.EventHandler(this.DgvApplications_SelectionChanged);
            // 
            // ColumnApplicationName
            // 
            this.ColumnApplicationName.HeaderText = "Application Name";
            this.ColumnApplicationName.Name = "ColumnApplicationName";
            this.ColumnApplicationName.ReadOnly = true;
            this.ColumnApplicationName.Width = 190;
            // 
            // ColumnFileLocation
            // 
            this.ColumnFileLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFileLocation.HeaderText = "File Location";
            this.ColumnFileLocation.Name = "ColumnFileLocation";
            this.ColumnFileLocation.ReadOnly = true;
            this.ColumnFileLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ToolStripGameRegions
            // 
            this.ToolStripGameRegions.AutoSize = false;
            this.ToolStripGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripGameRegions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripGameRegions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripGameRegions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripGameRegions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDeleteAll,
            this.ToolStripDelete,
            this.LabelTotalApplications});
            this.ToolStripGameRegions.Location = new System.Drawing.Point(1, 219);
            this.ToolStripGameRegions.Name = "ToolStripGameRegions";
            this.ToolStripGameRegions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripGameRegions.Size = new System.Drawing.Size(649, 36);
            this.ToolStripGameRegions.TabIndex = 2;
            this.ToolStripGameRegions.TabStop = true;
            this.ToolStripGameRegions.Text = "darkToolStrip2";
            // 
            // ToolStripDeleteAll
            // 
            this.ToolStripDeleteAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripDeleteAll.Enabled = false;
            this.ToolStripDeleteAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripDeleteAll.Image = global::ModioX.Properties.Resources.delete;
            this.ToolStripDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripDeleteAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDeleteAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripDeleteAll.Name = "ToolStripDeleteAll";
            this.ToolStripDeleteAll.Size = new System.Drawing.Size(88, 26);
            this.ToolStripDeleteAll.Text = "Delete All";
            this.ToolStripDeleteAll.ToolTipText = "Delete All Applications";
            this.ToolStripDeleteAll.Click += new System.EventHandler(this.ToolStripDeleteAll_Click);
            // 
            // ToolStripDelete
            // 
            this.ToolStripDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripDelete.Enabled = false;
            this.ToolStripDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripDelete.Image = global::ModioX.Properties.Resources.delete;
            this.ToolStripDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripDelete.Name = "ToolStripDelete";
            this.ToolStripDelete.Size = new System.Drawing.Size(71, 26);
            this.ToolStripDelete.Text = "Delete";
            this.ToolStripDelete.ToolTipText = "Delete Selected Item";
            this.ToolStripDelete.Click += new System.EventHandler(this.ToolStripDelete_Click);
            // 
            // LabelTotalApplications
            // 
            this.LabelTotalApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelTotalApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelTotalApplications.Name = "LabelTotalApplications";
            this.LabelTotalApplications.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelTotalApplications.Size = new System.Drawing.Size(88, 33);
            this.LabelTotalApplications.Text = "0 Applications";
            // 
            // ColumnGameTitle
            // 
            this.ColumnGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGameTitle.HeaderText = "Game Title";
            this.ColumnGameTitle.Name = "ColumnGameTitle";
            this.ColumnGameTitle.ReadOnly = true;
            // 
            // SectionAddApplication
            // 
            this.SectionAddApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionAddApplication.Controls.Add(this.ButtonNewApplication);
            this.SectionAddApplication.Controls.Add(this.ButtonLocalFilePath);
            this.SectionAddApplication.Controls.Add(this.TextBoxFileLocation);
            this.SectionAddApplication.Controls.Add(this.TextBoxFileName);
            this.SectionAddApplication.Controls.Add(this.ButtonAddApplication);
            this.SectionAddApplication.Controls.Add(this.LabelFileLocation);
            this.SectionAddApplication.Controls.Add(this.LabelName);
            this.SectionAddApplication.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionAddApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionAddApplication.Location = new System.Drawing.Point(12, 276);
            this.SectionAddApplication.Margin = new System.Windows.Forms.Padding(4);
            this.SectionAddApplication.Name = "SectionAddApplication";
            this.SectionAddApplication.SectionHeader = "APPLICATION DETAILS";
            this.SectionAddApplication.Size = new System.Drawing.Size(651, 118);
            this.SectionAddApplication.TabIndex = 1179;
            // 
            // ButtonNewApplication
            // 
            this.ButtonNewApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNewApplication.Location = new System.Drawing.Point(376, 84);
            this.ButtonNewApplication.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonNewApplication.Name = "ButtonNewApplication";
            this.ButtonNewApplication.Size = new System.Drawing.Size(128, 24);
            this.ButtonNewApplication.TabIndex = 1185;
            this.ButtonNewApplication.Text = "New Application";
            this.ButtonNewApplication.Click += new System.EventHandler(this.ButtonNewApplication_Click);
            // 
            // ButtonLocalFilePath
            // 
            this.ButtonLocalFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLocalFilePath.Location = new System.Drawing.Point(600, 51);
            this.ButtonLocalFilePath.Name = "ButtonLocalFilePath";
            this.ButtonLocalFilePath.Size = new System.Drawing.Size(42, 23);
            this.ButtonLocalFilePath.TabIndex = 1184;
            this.ButtonLocalFilePath.Text = "...";
            this.ButtonLocalFilePath.Click += new System.EventHandler(this.ButtonLocalFilePath_Click);
            // 
            // TextBoxFileLocation
            // 
            this.TextBoxFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileLocation.Location = new System.Drawing.Point(198, 51);
            this.TextBoxFileLocation.Name = "TextBoxFileLocation";
            this.TextBoxFileLocation.Size = new System.Drawing.Size(396, 23);
            this.TextBoxFileLocation.TabIndex = 1183;
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(184, 23);
            this.TextBoxFileName.TabIndex = 1182;
            // 
            // ButtonAddApplication
            // 
            this.ButtonAddApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddApplication.Location = new System.Drawing.Point(514, 84);
            this.ButtonAddApplication.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAddApplication.Name = "ButtonAddApplication";
            this.ButtonAddApplication.Size = new System.Drawing.Size(128, 24);
            this.ButtonAddApplication.TabIndex = 1180;
            this.ButtonAddApplication.Text = "Add Application";
            this.ButtonAddApplication.Click += new System.EventHandler(this.ButtonAddApplication_Click);
            // 
            // LabelFileLocation
            // 
            this.LabelFileLocation.AutoSize = true;
            this.LabelFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFileLocation.Location = new System.Drawing.Point(196, 31);
            this.LabelFileLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelFileLocation.Name = "LabelFileLocation";
            this.LabelFileLocation.Size = new System.Drawing.Size(77, 15);
            this.LabelFileLocation.TabIndex = 15;
            this.LabelFileLocation.Text = "File Location:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(6, 31);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(106, 15);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Application Name:";
            // 
            // ExternalApplicationsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 441);
            this.Controls.Add(this.SectionAddApplication);
            this.Controls.Add(this.SectionApplications);
            this.Controls.Add(this.ButtonSaveAll);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExternalApplicationsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "External Applications";
            this.Load += new System.EventHandler(this.EditExternalApplications_Load);
            this.SectionApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplications)).EndInit();
            this.ToolStripGameRegions.ResumeLayout(false);
            this.ToolStripGameRegions.PerformLayout();
            this.SectionAddApplication.ResumeLayout(false);
            this.SectionAddApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonSaveAll;
        private DarkUI.Controls.DarkSectionPanel SectionApplications;
        private DarkUI.Controls.DarkDataGridView DgvApplications;
        private DarkUI.Controls.DarkToolStrip ToolStripGameRegions;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteAll;
        private System.Windows.Forms.ToolStripLabel LabelTotalApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private DarkUI.Controls.DarkSectionPanel SectionAddApplication;
        private DarkUI.Controls.DarkLabel LabelFileLocation;
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkButton ButtonAddApplication;
        private DarkUI.Controls.DarkTextBox TextBoxFileLocation;
        private DarkUI.Controls.DarkTextBox TextBoxFileName;
        private DarkUI.Controls.DarkButton ButtonLocalFilePath;
        private System.Windows.Forms.ToolStripButton ToolStripDelete;
        private DarkUI.Controls.DarkButton ButtonNewApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApplicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileLocation;
    }
}