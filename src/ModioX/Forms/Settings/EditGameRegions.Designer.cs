namespace ModioX.Forms
{
    partial class EditGameRegions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGameRegions));
            this.ButtonSaveAll = new DarkUI.Controls.DarkButton();
            this.SectionGameRegions = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoGameRegionsSaved = new System.Windows.Forms.Label();
            this.DgvGameRegions = new DarkUI.Controls.DarkDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripGameRegions = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalGameRegions = new System.Windows.Forms.ToolStripLabel();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonAddGame = new DarkUI.Controls.DarkButton();
            this.LabelGameRegion = new DarkUI.Controls.DarkLabel();
            this.ComboBoxGameTitle = new DarkUI.Controls.DarkComboBox();
            this.LabelGameTitle = new DarkUI.Controls.DarkLabel();
            this.ComboBoxGameRegion = new DarkUI.Controls.DarkComboBox();
            this.SectionGameRegions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameRegions)).BeginInit();
            this.ToolStripGameRegions.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.Location = new System.Drawing.Point(347, 371);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Size = new System.Drawing.Size(79, 24);
            this.ButtonSaveAll.TabIndex = 3;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // SectionGameRegions
            // 
            this.SectionGameRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionGameRegions.Controls.Add(this.LabelNoGameRegionsSaved);
            this.SectionGameRegions.Controls.Add(this.DgvGameRegions);
            this.SectionGameRegions.Controls.Add(this.ToolStripGameRegions);
            this.SectionGameRegions.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionGameRegions.Location = new System.Drawing.Point(12, 12);
            this.SectionGameRegions.Margin = new System.Windows.Forms.Padding(4);
            this.SectionGameRegions.Name = "SectionGameRegions";
            this.SectionGameRegions.SectionHeader = "GAME REGIONS";
            this.SectionGameRegions.Size = new System.Drawing.Size(414, 230);
            this.SectionGameRegions.TabIndex = 0;
            // 
            // LabelNoGameRegionsSaved
            // 
            this.LabelNoGameRegionsSaved.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoGameRegionsSaved.AutoSize = true;
            this.LabelNoGameRegionsSaved.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoGameRegionsSaved.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelNoGameRegionsSaved.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoGameRegionsSaved.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoGameRegionsSaved.Location = new System.Drawing.Point(151, 79);
            this.LabelNoGameRegionsSaved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoGameRegionsSaved.Name = "LabelNoGameRegionsSaved";
            this.LabelNoGameRegionsSaved.Size = new System.Drawing.Size(113, 15);
            this.LabelNoGameRegionsSaved.TabIndex = 1178;
            this.LabelNoGameRegionsSaved.Text = "NO REGIONS SAVED";
            // 
            // DgvGameRegions
            // 
            this.DgvGameRegions.AllowUserToAddRows = false;
            this.DgvGameRegions.AllowUserToDragDropRows = false;
            this.DgvGameRegions.AllowUserToPasteCells = false;
            this.DgvGameRegions.AllowUserToResizeColumns = false;
            this.DgvGameRegions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvGameRegions.ColumnHeadersHeight = 21;
            this.DgvGameRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvGameRegions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgvGameRegions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGameRegions.Location = new System.Drawing.Point(1, 25);
            this.DgvGameRegions.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvGameRegions.MultiSelect = false;
            this.DgvGameRegions.Name = "DgvGameRegions";
            this.DgvGameRegions.ReadOnly = true;
            this.DgvGameRegions.RowHeadersWidth = 41;
            this.DgvGameRegions.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvGameRegions.RowTemplate.Height = 24;
            this.DgvGameRegions.RowTemplate.ReadOnly = true;
            this.DgvGameRegions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvGameRegions.Size = new System.Drawing.Size(412, 168);
            this.DgvGameRegions.TabIndex = 0;
            this.DgvGameRegions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGameRegions_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Game Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Game Region";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
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
            this.LabelTotalGameRegions});
            this.ToolStripGameRegions.Location = new System.Drawing.Point(1, 193);
            this.ToolStripGameRegions.Name = "ToolStripGameRegions";
            this.ToolStripGameRegions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripGameRegions.Size = new System.Drawing.Size(412, 36);
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
            // LabelTotalGameRegions
            // 
            this.LabelTotalGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelTotalGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelTotalGameRegions.Name = "LabelTotalGameRegions";
            this.LabelTotalGameRegions.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelTotalGameRegions.Size = new System.Drawing.Size(98, 33);
            this.LabelTotalGameRegions.Text = "0 Regions Saved";
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
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSectionPanel1.Controls.Add(this.ButtonAddGame);
            this.darkSectionPanel1.Controls.Add(this.LabelGameRegion);
            this.darkSectionPanel1.Controls.Add(this.ComboBoxGameTitle);
            this.darkSectionPanel1.Controls.Add(this.LabelGameTitle);
            this.darkSectionPanel1.Controls.Add(this.ComboBoxGameRegion);
            this.darkSectionPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 250);
            this.darkSectionPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "UPDATE GAME REGIONS";
            this.darkSectionPanel1.Size = new System.Drawing.Size(414, 113);
            this.darkSectionPanel1.TabIndex = 1179;
            // 
            // ButtonAddGame
            // 
            this.ButtonAddGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddGame.Location = new System.Drawing.Point(8, 81);
            this.ButtonAddGame.Name = "ButtonAddGame";
            this.ButtonAddGame.Size = new System.Drawing.Size(398, 24);
            this.ButtonAddGame.TabIndex = 1180;
            this.ButtonAddGame.Text = "Update Region for Game";
            this.ButtonAddGame.Click += new System.EventHandler(this.ButtonAddGame_Click);
            // 
            // LabelGameRegion
            // 
            this.LabelGameRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameRegion.AutoSize = true;
            this.LabelGameRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameRegion.Location = new System.Drawing.Point(291, 31);
            this.LabelGameRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.LabelGameRegion.Name = "LabelGameRegion";
            this.LabelGameRegion.Size = new System.Drawing.Size(81, 15);
            this.LabelGameRegion.TabIndex = 15;
            this.LabelGameRegion.Text = "Game Region:";
            // 
            // ComboBoxGameTitle
            // 
            this.ComboBoxGameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameTitle.FormattingEnabled = true;
            this.ComboBoxGameTitle.Location = new System.Drawing.Point(8, 51);
            this.ComboBoxGameTitle.Name = "ComboBoxGameTitle";
            this.ComboBoxGameTitle.Size = new System.Drawing.Size(280, 24);
            this.ComboBoxGameTitle.TabIndex = 13;
            this.ComboBoxGameTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameTitle_SelectedIndexChanged);
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.AutoSize = true;
            this.LabelGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameTitle.Location = new System.Drawing.Point(6, 31);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Size = new System.Drawing.Size(66, 15);
            this.LabelGameTitle.TabIndex = 16;
            this.LabelGameTitle.Text = "Game Title:";
            // 
            // ComboBoxGameRegion
            // 
            this.ComboBoxGameRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameRegion.FormattingEnabled = true;
            this.ComboBoxGameRegion.Location = new System.Drawing.Point(294, 51);
            this.ComboBoxGameRegion.Name = "ComboBoxGameRegion";
            this.ComboBoxGameRegion.Size = new System.Drawing.Size(112, 24);
            this.ComboBoxGameRegion.TabIndex = 1181;
            // 
            // EditGameRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(438, 407);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.SectionGameRegions);
            this.Controls.Add(this.ButtonSaveAll);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGameRegions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Game Regions";
            this.Load += new System.EventHandler(this.EditGameRegions_Load);
            this.SectionGameRegions.ResumeLayout(false);
            this.SectionGameRegions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameRegions)).EndInit();
            this.ToolStripGameRegions.ResumeLayout(false);
            this.ToolStripGameRegions.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonSaveAll;
        private DarkUI.Controls.DarkSectionPanel SectionGameRegions;
        private System.Windows.Forms.Label LabelNoGameRegionsSaved;
        private DarkUI.Controls.DarkDataGridView DgvGameRegions;
        private DarkUI.Controls.DarkToolStrip ToolStripGameRegions;
        private System.Windows.Forms.ToolStripButton ToolItemDeleteAll;
        private System.Windows.Forms.ToolStripLabel LabelTotalGameRegions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkLabel LabelGameRegion;
        private DarkUI.Controls.DarkComboBox ComboBoxGameTitle;
        private DarkUI.Controls.DarkLabel LabelGameTitle;
        private DarkUI.Controls.DarkButton ButtonAddGame;
        private DarkUI.Controls.DarkComboBox ComboBoxGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}