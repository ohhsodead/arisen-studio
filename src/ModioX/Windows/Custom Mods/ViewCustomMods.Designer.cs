namespace ModioX.Windows.Custom_Mods
{
    partial class ViewCustomMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomMods));
            this.SectionCustomMods = new DarkUI.Controls.DarkSectionPanel();
            this.DgvCustomMods = new DarkUI.Controls.DarkDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolItemEdit = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripInstall = new System.Windows.Forms.ToolStripButton();
            this.ToolStripUninstall = new System.Windows.Forms.ToolStripButton();
            this.LabelGame = new System.Windows.Forms.Label();
            this.LabelHeaderGame = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.ListViewInstallFiles = new DarkUI.Controls.DarkListView();
            this.LabelTitleLocalConsolePath = new DarkUI.Controls.DarkTitle();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelHeaderDescription = new System.Windows.Forms.Label();
            this.SectionBackupDetails = new DarkUI.Controls.DarkSectionPanel();
            this.SectionCustomMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomMods)).BeginInit();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.SectionBackupDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionCustomMods
            // 
            this.SectionCustomMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionCustomMods.Controls.Add(this.DgvCustomMods);
            this.SectionCustomMods.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionCustomMods.Location = new System.Drawing.Point(12, 12);
            this.SectionCustomMods.Margin = new System.Windows.Forms.Padding(4);
            this.SectionCustomMods.Name = "SectionCustomMods";
            this.SectionCustomMods.SectionHeader = "Mods";
            this.SectionCustomMods.Size = new System.Drawing.Size(521, 224);
            this.SectionCustomMods.TabIndex = 15;
            // 
            // DgvCustomMods
            // 
            this.DgvCustomMods.AllowUserToAddRows = false;
            this.DgvCustomMods.AllowUserToDeleteRows = false;
            this.DgvCustomMods.AllowUserToDragDropRows = false;
            this.DgvCustomMods.AllowUserToPasteCells = false;
            this.DgvCustomMods.ColumnHeadersHeight = 23;
            this.DgvCustomMods.ColumnHeadersVisible = false;
            this.DgvCustomMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvCustomMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCustomMods.Location = new System.Drawing.Point(1, 25);
            this.DgvCustomMods.MultiSelect = false;
            this.DgvCustomMods.Name = "DgvCustomMods";
            this.DgvCustomMods.ReadOnly = true;
            this.DgvCustomMods.RowHeadersWidth = 41;
            this.DgvCustomMods.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomMods.RowTemplate.Height = 24;
            this.DgvCustomMods.RowTemplate.ReadOnly = true;
            this.DgvCustomMods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCustomMods.Size = new System.Drawing.Size(519, 162);
            this.DgvCustomMods.TabIndex = 12;
            this.DgvCustomMods.SelectionChanged += new System.EventHandler(this.DgvCustomMods_SelectionChanged);
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
            this.Column2.Width = 205;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "# of Files";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
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
            this.ToolStripCreate,
            this.ToolItemEdit,
            this.ToolItemDelete,
            this.ToolStripInstall,
            this.ToolStripUninstall});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 187);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(519, 36);
            this.ToolStripArchiveInformation.TabIndex = 17;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolStripCreate
            // 
            this.ToolStripCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripCreate.Image = global::ModioX.Properties.Resources.icons8_create_22;
            this.ToolStripCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCreate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripCreate.Name = "ToolStripCreate";
            this.ToolStripCreate.Size = new System.Drawing.Size(70, 26);
            this.ToolStripCreate.Text = "Create";
            this.ToolStripCreate.Click += new System.EventHandler(this.ToolStripCreate_Click);
            // 
            // ToolItemEdit
            // 
            this.ToolItemEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemEdit.Enabled = false;
            this.ToolItemEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemEdit.Image = global::ModioX.Properties.Resources.icons8_edit_22;
            this.ToolItemEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemEdit.Name = "ToolItemEdit";
            this.ToolItemEdit.Size = new System.Drawing.Size(54, 26);
            this.ToolItemEdit.Text = "Edit";
            this.ToolItemEdit.Click += new System.EventHandler(this.ToolStripItemEdit_Click);
            // 
            // ToolItemDelete
            // 
            this.ToolItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDelete.Enabled = false;
            this.ToolItemDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDelete.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolItemDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDelete.Name = "ToolItemDelete";
            this.ToolItemDelete.Size = new System.Drawing.Size(71, 26);
            this.ToolItemDelete.Text = "Delete";
            this.ToolItemDelete.Click += new System.EventHandler(this.ToolStripItemDelete_Click);
            // 
            // ToolStripInstall
            // 
            this.ToolStripInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripInstall.Enabled = false;
            this.ToolStripInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripInstall.Image = global::ModioX.Properties.Resources.icons8_software_installer_22;
            this.ToolStripInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripInstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripInstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripInstall.Name = "ToolStripInstall";
            this.ToolStripInstall.Size = new System.Drawing.Size(66, 26);
            this.ToolStripInstall.Text = "Install";
            this.ToolStripInstall.Click += new System.EventHandler(this.ToolStripItemInstall_Click);
            // 
            // ToolStripUninstall
            // 
            this.ToolStripUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripUninstall.Enabled = false;
            this.ToolStripUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripUninstall.Image = global::ModioX.Properties.Resources.icons8_uninstall_programs_22;
            this.ToolStripUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripUninstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripUninstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripUninstall.Name = "ToolStripUninstall";
            this.ToolStripUninstall.Size = new System.Drawing.Size(81, 26);
            this.ToolStripUninstall.Text = "Uninstall";
            this.ToolStripUninstall.Click += new System.EventHandler(this.ToolStripItemUninstall_Click);
            // 
            // LabelGame
            // 
            this.LabelGame.AutoSize = true;
            this.LabelGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGame.Location = new System.Drawing.Point(319, 32);
            this.LabelGame.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(16, 15);
            this.LabelGame.TabIndex = 23;
            this.LabelGame.Text = "...";
            // 
            // LabelHeaderGame
            // 
            this.LabelHeaderGame.AutoSize = true;
            this.LabelHeaderGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGame.Location = new System.Drawing.Point(257, 32);
            this.LabelHeaderGame.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderGame.Name = "LabelHeaderGame";
            this.LabelHeaderGame.Size = new System.Drawing.Size(60, 15);
            this.LabelHeaderGame.TabIndex = 24;
            this.LabelHeaderGame.Text = "Category:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(51, 32);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(16, 15);
            this.LabelName.TabIndex = 25;
            this.LabelName.Text = "...";
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.AutoSize = true;
            this.LabelHeaderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(6, 32);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(43, 15);
            this.LabelHeaderName.TabIndex = 2;
            this.LabelHeaderName.Text = "Name:";
            // 
            // ListViewInstallFiles
            // 
            this.ListViewInstallFiles.Location = new System.Drawing.Point(9, 116);
            this.ListViewInstallFiles.Name = "ListViewInstallFiles";
            this.ListViewInstallFiles.Size = new System.Drawing.Size(502, 78);
            this.ListViewInstallFiles.TabIndex = 18;
            this.ListViewInstallFiles.Text = "darkListView1";
            // 
            // LabelTitleLocalConsolePath
            // 
            this.LabelTitleLocalConsolePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleLocalConsolePath.Location = new System.Drawing.Point(9, 94);
            this.LabelTitleLocalConsolePath.Name = "LabelTitleLocalConsolePath";
            this.LabelTitleLocalConsolePath.Size = new System.Drawing.Size(500, 19);
            this.LabelTitleLocalConsolePath.TabIndex = 26;
            this.LabelTitleLocalConsolePath.Text = "Install File Paths";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(6, 74);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(16, 15);
            this.LabelDescription.TabIndex = 27;
            this.LabelDescription.Text = "...";
            // 
            // LabelHeaderDescription
            // 
            this.LabelHeaderDescription.AutoSize = true;
            this.LabelHeaderDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderDescription.Location = new System.Drawing.Point(6, 53);
            this.LabelHeaderDescription.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderDescription.Name = "LabelHeaderDescription";
            this.LabelHeaderDescription.Size = new System.Drawing.Size(74, 15);
            this.LabelHeaderDescription.TabIndex = 28;
            this.LabelHeaderDescription.Text = "Description:";
            // 
            // SectionBackupDetails
            // 
            this.SectionBackupDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionBackupDetails.Controls.Add(this.LabelHeaderDescription);
            this.SectionBackupDetails.Controls.Add(this.LabelDescription);
            this.SectionBackupDetails.Controls.Add(this.LabelTitleLocalConsolePath);
            this.SectionBackupDetails.Controls.Add(this.ListViewInstallFiles);
            this.SectionBackupDetails.Controls.Add(this.LabelHeaderName);
            this.SectionBackupDetails.Controls.Add(this.LabelName);
            this.SectionBackupDetails.Controls.Add(this.LabelHeaderGame);
            this.SectionBackupDetails.Controls.Add(this.LabelGame);
            this.SectionBackupDetails.Location = new System.Drawing.Point(12, 244);
            this.SectionBackupDetails.Margin = new System.Windows.Forms.Padding(4);
            this.SectionBackupDetails.Name = "SectionBackupDetails";
            this.SectionBackupDetails.SectionHeader = "Mod Details";
            this.SectionBackupDetails.Size = new System.Drawing.Size(521, 204);
            this.SectionBackupDetails.TabIndex = 16;
            // 
            // ViewCustomMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 461);
            this.Controls.Add(this.SectionBackupDetails);
            this.Controls.Add(this.SectionCustomMods);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewCustomMods";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Mods";
            this.Load += new System.EventHandler(this.ViewCustomMods_Load);
            this.SectionCustomMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomMods)).EndInit();
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.SectionBackupDetails.ResumeLayout(false);
            this.SectionBackupDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkSectionPanel SectionCustomMods;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripButton ToolItemEdit;
        private System.Windows.Forms.ToolStripButton ToolItemDelete;
        private System.Windows.Forms.ToolStripButton ToolStripCreate;
        private DarkUI.Controls.DarkDataGridView DgvCustomMods;
        private System.Windows.Forms.ToolStripButton ToolStripInstall;
        private System.Windows.Forms.ToolStripButton ToolStripUninstall;
        private System.Windows.Forms.Label LabelGame;
        private System.Windows.Forms.Label LabelHeaderGame;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelHeaderName;
        private DarkUI.Controls.DarkListView ListViewInstallFiles;
        private DarkUI.Controls.DarkTitle LabelTitleLocalConsolePath;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelHeaderDescription;
        private DarkUI.Controls.DarkSectionPanel SectionBackupDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}