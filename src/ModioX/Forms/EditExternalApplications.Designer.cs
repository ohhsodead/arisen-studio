namespace ModioX.Forms
{
    partial class EditExternalApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExternalApplications));
            this.ButtonSaveGameRegions = new DarkUI.Controls.DarkButton();
            this.SectionApplications = new DarkUI.Controls.DarkSectionPanel();
            this.DgvApplications = new DarkUI.Controls.DarkDataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripGameRegions = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalApplications = new System.Windows.Forms.ToolStripLabel();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionAddApplication = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonLocalPath = new DarkUI.Controls.DarkButton();
            this.TextBoxFileLocation = new DarkUI.Controls.DarkTextBox();
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.ButtonAddGame = new DarkUI.Controls.DarkButton();
            this.LabelFileLocation = new DarkUI.Controls.DarkLabel();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.SectionApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplications)).BeginInit();
            this.ToolStripGameRegions.SuspendLayout();
            this.SectionAddApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveGameRegions
            // 
            this.ButtonSaveGameRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveGameRegions.Location = new System.Drawing.Point(584, 375);
            this.ButtonSaveGameRegions.Name = "ButtonSaveGameRegions";
            this.ButtonSaveGameRegions.Size = new System.Drawing.Size(79, 24);
            this.ButtonSaveGameRegions.TabIndex = 3;
            this.ButtonSaveGameRegions.Text = "Save All";
            this.ButtonSaveGameRegions.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // SectionApplications
            // 
            this.SectionApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionApplications.Controls.Add(this.DgvApplications);
            this.SectionApplications.Controls.Add(this.ToolStripGameRegions);
            this.SectionApplications.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionApplications.Location = new System.Drawing.Point(12, 12);
            this.SectionApplications.Margin = new System.Windows.Forms.Padding(4);
            this.SectionApplications.Name = "SectionApplications";
            this.SectionApplications.SectionHeader = "EXTERNAL APPLICATIONS";
            this.SectionApplications.Size = new System.Drawing.Size(651, 234);
            this.SectionApplications.TabIndex = 0;
            // 
            // DgvApplications
            // 
            this.DgvApplications.AllowUserToAddRows = false;
            this.DgvApplications.AllowUserToPasteCells = false;
            this.DgvApplications.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvApplications.ColumnHeadersHeight = 19;
            this.DgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
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
            this.DgvApplications.Size = new System.Drawing.Size(649, 172);
            this.DgvApplications.TabIndex = 0;
            this.DgvApplications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGameRegions_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Application Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 172;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "File Location";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.ToolItemDeleteAll,
            this.LabelTotalApplications});
            this.ToolStripGameRegions.Location = new System.Drawing.Point(1, 197);
            this.ToolStripGameRegions.Name = "ToolStripGameRegions";
            this.ToolStripGameRegions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripGameRegions.Size = new System.Drawing.Size(649, 36);
            this.ToolStripGameRegions.TabIndex = 2;
            this.ToolStripGameRegions.TabStop = true;
            this.ToolStripGameRegions.Text = "darkToolStrip2";
            // 
            // ToolItemDeleteAll
            // 
            this.ToolItemDeleteAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolItemDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDeleteAll.Enabled = false;
            this.ToolItemDeleteAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDeleteAll.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolItemDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemDeleteAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDeleteAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDeleteAll.Name = "ToolItemDeleteAll";
            this.ToolItemDeleteAll.Size = new System.Drawing.Size(88, 26);
            this.ToolItemDeleteAll.Text = "Delete All";
            this.ToolItemDeleteAll.ToolTipText = "Delete All Saved Game Regions";
            this.ToolItemDeleteAll.Click += new System.EventHandler(this.ToolItemDeleteAll_Click);
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
            // ColumnGameRegion
            // 
            this.ColumnGameRegion.HeaderText = "Game Region";
            this.ColumnGameRegion.Name = "ColumnGameRegion";
            this.ColumnGameRegion.Width = 120;
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
            this.SectionAddApplication.Controls.Add(this.ButtonLocalPath);
            this.SectionAddApplication.Controls.Add(this.TextBoxFileLocation);
            this.SectionAddApplication.Controls.Add(this.TextBoxName);
            this.SectionAddApplication.Controls.Add(this.ButtonAddGame);
            this.SectionAddApplication.Controls.Add(this.LabelFileLocation);
            this.SectionAddApplication.Controls.Add(this.LabelName);
            this.SectionAddApplication.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionAddApplication.Location = new System.Drawing.Point(12, 254);
            this.SectionAddApplication.Margin = new System.Windows.Forms.Padding(4);
            this.SectionAddApplication.Name = "SectionAddApplication";
            this.SectionAddApplication.SectionHeader = "ADD EXTERNAL APPLICATIONS";
            this.SectionAddApplication.Size = new System.Drawing.Size(651, 112);
            this.SectionAddApplication.TabIndex = 1179;
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalPath.Location = new System.Drawing.Point(600, 51);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(42, 23);
            this.ButtonLocalPath.TabIndex = 1184;
            this.ButtonLocalPath.Text = "...";
            this.ButtonLocalPath.Click += new System.EventHandler(this.ButtonLocalPath_Click);
            // 
            // TextBoxFileLocation
            // 
            this.TextBoxFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileLocation.Location = new System.Drawing.Point(186, 51);
            this.TextBoxFileLocation.Name = "TextBoxFileLocation";
            this.TextBoxFileLocation.Size = new System.Drawing.Size(408, 23);
            this.TextBoxFileLocation.TabIndex = 1183;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(172, 23);
            this.TextBoxName.TabIndex = 1182;
            // 
            // ButtonAddGame
            // 
            this.ButtonAddGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddGame.Location = new System.Drawing.Point(8, 80);
            this.ButtonAddGame.Name = "ButtonAddGame";
            this.ButtonAddGame.Size = new System.Drawing.Size(635, 24);
            this.ButtonAddGame.TabIndex = 1180;
            this.ButtonAddGame.Text = "Add External Application";
            this.ButtonAddGame.Click += new System.EventHandler(this.ButtonAddGame_Click);
            // 
            // LabelFileLocation
            // 
            this.LabelFileLocation.AutoSize = true;
            this.LabelFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFileLocation.Location = new System.Drawing.Point(184, 31);
            this.LabelFileLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelFileLocation.Name = "LabelFileLocation";
            this.LabelFileLocation.Size = new System.Drawing.Size(106, 15);
            this.LabelFileLocation.TabIndex = 15;
            this.LabelFileLocation.Text = "File Location (exe):";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(6, 31);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(106, 15);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Application Name:";
            // 
            // EditExternalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 411);
            this.Controls.Add(this.SectionAddApplication);
            this.Controls.Add(this.SectionApplications);
            this.Controls.Add(this.ButtonSaveGameRegions);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditExternalApplications";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit External Applications";
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
        private DarkUI.Controls.DarkButton ButtonSaveGameRegions;
        private DarkUI.Controls.DarkSectionPanel SectionApplications;
        private DarkUI.Controls.DarkDataGridView DgvApplications;
        private DarkUI.Controls.DarkToolStrip ToolStripGameRegions;
        private System.Windows.Forms.ToolStripButton ToolItemDeleteAll;
        private System.Windows.Forms.ToolStripLabel LabelTotalApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private DarkUI.Controls.DarkSectionPanel SectionAddApplication;
        private DarkUI.Controls.DarkLabel LabelFileLocation;
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkButton ButtonAddGame;
        private DarkUI.Controls.DarkTextBox TextBoxFileLocation;
        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkButton ButtonLocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}