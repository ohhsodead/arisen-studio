namespace ModioX.Forms
{
    partial class EditCustomMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomMods));
            this.SectionCustomMods = new DarkUI.Controls.DarkSectionPanel();
            this.DgvCustomMods = new DarkUI.Controls.DarkDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripCreate = new System.Windows.Forms.ToolStripButton();
            this.ToolItemEdit = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolItemInstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemUninstall = new System.Windows.Forms.ToolStripButton();
            this.SectionModDetails = new DarkUI.Controls.DarkSectionPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.DgvInstallFilePaths = new DarkUI.Controls.DarkDataGridView();
            this.ColumnLocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInstallPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelInstallFilePaths = new DarkUI.Controls.DarkTitle();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelHeaderFileName = new System.Windows.Forms.Label();
            this.SectionCustomMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomMods)).BeginInit();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.SectionModDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallFilePaths)).BeginInit();
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
            this.SectionCustomMods.SectionHeader = "CUSTOM MODS";
            this.SectionCustomMods.Size = new System.Drawing.Size(725, 272);
            this.SectionCustomMods.TabIndex = 15;
            // 
            // DgvCustomMods
            // 
            this.DgvCustomMods.AllowUserToAddRows = false;
            this.DgvCustomMods.AllowUserToDeleteRows = false;
            this.DgvCustomMods.AllowUserToDragDropRows = false;
            this.DgvCustomMods.AllowUserToPasteCells = false;
            this.DgvCustomMods.AllowUserToResizeColumns = false;
            this.DgvCustomMods.ColumnHeadersHeight = 19;
            this.DgvCustomMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.ColumnCreatedDate});
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
            this.DgvCustomMods.Size = new System.Drawing.Size(723, 210);
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
            this.Column2.HeaderText = "Game Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "# of Files";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // ColumnCreatedDate
            // 
            this.ColumnCreatedDate.HeaderText = "Created Date";
            this.ColumnCreatedDate.Name = "ColumnCreatedDate";
            this.ColumnCreatedDate.ReadOnly = true;
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
            this.ToolItemInstall,
            this.ToolItemUninstall});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 235);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(723, 36);
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
            // ToolItemInstall
            // 
            this.ToolItemInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemInstall.Enabled = false;
            this.ToolItemInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemInstall.Image = global::ModioX.Properties.Resources.icons8_software_installer_22;
            this.ToolItemInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemInstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemInstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemInstall.Name = "ToolItemInstall";
            this.ToolItemInstall.Size = new System.Drawing.Size(66, 26);
            this.ToolItemInstall.Text = "Install";
            this.ToolItemInstall.Click += new System.EventHandler(this.ToolStripItemInstall_Click);
            // 
            // ToolItemUninstall
            // 
            this.ToolItemUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemUninstall.Enabled = false;
            this.ToolItemUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemUninstall.Image = global::ModioX.Properties.Resources.icons8_uninstall_programs_22;
            this.ToolItemUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstall.Name = "ToolItemUninstall";
            this.ToolItemUninstall.Size = new System.Drawing.Size(81, 26);
            this.ToolItemUninstall.Text = "Uninstall";
            this.ToolItemUninstall.Click += new System.EventHandler(this.ToolStripItemUninstall_Click);
            // 
            // SectionModDetails
            // 
            this.SectionModDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionModDetails.Controls.Add(this.panel1);
            this.SectionModDetails.Location = new System.Drawing.Point(12, 291);
            this.SectionModDetails.Name = "SectionModDetails";
            this.SectionModDetails.SectionHeader = "MOD INFORMATION";
            this.SectionModDetails.Size = new System.Drawing.Size(725, 262);
            this.SectionModDetails.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Controls.Add(this.DgvInstallFilePaths);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelInstallFilePaths);
            this.panel1.Controls.Add(this.LabelCategory);
            this.panel1.Controls.Add(this.LabelDescription);
            this.panel1.Controls.Add(this.LabelHeaderFileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 236);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(48, 4);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(16, 15);
            this.LabelName.TabIndex = 25;
            this.LabelName.Text = "...";
            // 
            // DgvInstallFilePaths
            // 
            this.DgvInstallFilePaths.AllowUserToAddRows = false;
            this.DgvInstallFilePaths.AllowUserToDeleteRows = false;
            this.DgvInstallFilePaths.AllowUserToDragDropRows = false;
            this.DgvInstallFilePaths.AllowUserToPasteCells = false;
            this.DgvInstallFilePaths.AllowUserToResizeColumns = false;
            this.DgvInstallFilePaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInstallFilePaths.ColumnHeadersHeight = 21;
            this.DgvInstallFilePaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvInstallFilePaths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLocalPath,
            this.ColumnInstallPath});
            this.DgvInstallFilePaths.Location = new System.Drawing.Point(0, 130);
            this.DgvInstallFilePaths.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvInstallFilePaths.MultiSelect = false;
            this.DgvInstallFilePaths.Name = "DgvInstallFilePaths";
            this.DgvInstallFilePaths.ReadOnly = true;
            this.DgvInstallFilePaths.RowHeadersWidth = 41;
            this.DgvInstallFilePaths.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInstallFilePaths.RowTemplate.Height = 24;
            this.DgvInstallFilePaths.RowTemplate.ReadOnly = true;
            this.DgvInstallFilePaths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvInstallFilePaths.Size = new System.Drawing.Size(721, 105);
            this.DgvInstallFilePaths.TabIndex = 28;
            // 
            // ColumnLocalPath
            // 
            this.ColumnLocalPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLocalPath.HeaderText = "Local File Path";
            this.ColumnLocalPath.Name = "ColumnLocalPath";
            this.ColumnLocalPath.ReadOnly = true;
            // 
            // ColumnInstallPath
            // 
            this.ColumnInstallPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInstallPath.HeaderText = "Install File Path";
            this.ColumnInstallPath.Name = "ColumnInstallPath";
            this.ColumnInstallPath.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Game:";
            // 
            // LabelInstallFilePaths
            // 
            this.LabelInstallFilePaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstallFilePaths.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelInstallFilePaths.Location = new System.Drawing.Point(6, 106);
            this.LabelInstallFilePaths.Margin = new System.Windows.Forms.Padding(6, 2, 3, 0);
            this.LabelInstallFilePaths.Name = "LabelInstallFilePaths";
            this.LabelInstallFilePaths.Size = new System.Drawing.Size(711, 19);
            this.LabelInstallFilePaths.TabIndex = 27;
            this.LabelInstallFilePaths.Text = "Install File Paths";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(48, 25);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(16, 15);
            this.LabelCategory.TabIndex = 23;
            this.LabelCategory.Text = "...";
            // 
            // LabelDescription
            // 
            this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(3, 67);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(715, 34);
            this.LabelDescription.TabIndex = 17;
            this.LabelDescription.Text = "...";
            // 
            // LabelHeaderFileName
            // 
            this.LabelHeaderFileName.AutoSize = true;
            this.LabelHeaderFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFileName.Location = new System.Drawing.Point(3, 46);
            this.LabelHeaderFileName.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderFileName.Name = "LabelHeaderFileName";
            this.LabelHeaderFileName.Size = new System.Drawing.Size(74, 15);
            this.LabelHeaderFileName.TabIndex = 16;
            this.LabelHeaderFileName.Text = "Description:";
            // 
            // EditCustomMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 565);
            this.Controls.Add(this.SectionModDetails);
            this.Controls.Add(this.SectionCustomMods);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomMods";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Mods";
            this.Load += new System.EventHandler(this.ViewCustomMods_Load);
            this.SectionCustomMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomMods)).EndInit();
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.SectionModDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallFilePaths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkSectionPanel SectionCustomMods;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripButton ToolItemEdit;
        private System.Windows.Forms.ToolStripButton ToolItemDelete;
        private System.Windows.Forms.ToolStripButton ToolStripCreate;
        private DarkUI.Controls.DarkDataGridView DgvCustomMods;
        private System.Windows.Forms.ToolStripButton ToolItemInstall;
        private System.Windows.Forms.ToolStripButton ToolItemUninstall;
        private DarkUI.Controls.DarkSectionPanel SectionModDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelHeaderFileName;
        private System.Windows.Forms.Label LabelDescription;
        private DarkUI.Controls.DarkTitle LabelInstallFilePaths;
        private DarkUI.Controls.DarkDataGridView DgvInstallFilePaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstallPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedDate;
        private System.Windows.Forms.Panel panel1;
    }
}