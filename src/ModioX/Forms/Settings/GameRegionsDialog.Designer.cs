using ModioX;
namespace ModioX.Forms.Settings
{
    partial class GameRegionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRegionsDialog));
            this.ButtonSaveAll = new DarkUI.Controls.DarkButton();
            this.SectionPanelGameRegions = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoGameRegionsSaved = new System.Windows.Forms.Label();
            this.DgvGameRegions = new XDevkit.XtraDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripGameRegions = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalGameRegions = new System.Windows.Forms.ToolStripLabel();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionPanelUpdateGameRegions = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonAddGame = new DarkUI.Controls.DarkButton();
            this.LabelGameRegion = new DarkUI.Controls.DarkLabel();
            this.ComboBoxGameTitle = new DarkUI.Controls.DarkComboBox();
            this.LabelGameTitle = new DarkUI.Controls.DarkLabel();
            this.ComboBoxGameRegion = new DarkUI.Controls.DarkComboBox();
            this.SectionPanelGameRegions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameRegions)).BeginInit();
            this.ToolStripGameRegions.SuspendLayout();
            this.SectionPanelUpdateGameRegions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.Location = new System.Drawing.Point(347, 382);
            this.ButtonSaveAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Size = new System.Drawing.Size(79, 24);
            this.ButtonSaveAll.TabIndex = 5;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // SectionPanelGameRegions
            // 
            this.SectionPanelGameRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelGameRegions.Controls.Add(this.LabelNoGameRegionsSaved);
            this.SectionPanelGameRegions.Controls.Add(this.DgvGameRegions);
            this.SectionPanelGameRegions.Controls.Add(this.ToolStripGameRegions);
            this.SectionPanelGameRegions.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionPanelGameRegions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionPanelGameRegions.Location = new System.Drawing.Point(12, 12);
            this.SectionPanelGameRegions.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelGameRegions.Name = "SectionPanelGameRegions";
            this.SectionPanelGameRegions.SectionHeader = "GAME REGIONS";
            this.SectionPanelGameRegions.Size = new System.Drawing.Size(414, 237);
            this.SectionPanelGameRegions.TabIndex = 0;
            // 
            // LabelNoGameRegionsSaved
            // 
            this.LabelNoGameRegionsSaved.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoGameRegionsSaved.AutoSize = true;
            this.LabelNoGameRegionsSaved.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoGameRegionsSaved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoGameRegionsSaved.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoGameRegionsSaved.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoGameRegionsSaved.Location = new System.Drawing.Point(147, 79);
            this.LabelNoGameRegionsSaved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoGameRegionsSaved.Name = "LabelNoGameRegionsSaved";
            this.LabelNoGameRegionsSaved.Size = new System.Drawing.Size(120, 15);
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
            this.ColumnRegion});
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
            this.DgvGameRegions.Size = new System.Drawing.Size(412, 175);
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
            // ColumnRegion
            // 
            this.ColumnRegion.HeaderText = "Region";
            this.ColumnRegion.Name = "ColumnRegion";
            this.ColumnRegion.ReadOnly = true;
            this.ColumnRegion.Width = 110;
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
            this.ToolStripDeleteSelected,
            this.LabelTotalGameRegions});
            this.ToolStripGameRegions.Location = new System.Drawing.Point(1, 200);
            this.ToolStripGameRegions.Name = "ToolStripGameRegions";
            this.ToolStripGameRegions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripGameRegions.Size = new System.Drawing.Size(412, 36);
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
            this.ToolStripDeleteAll.ToolTipText = "Delete All Saved Game Regions";
            this.ToolStripDeleteAll.Click += new System.EventHandler(this.ToolStripDeleteAll_Click);
            // 
            // ToolStripDeleteSelected
            // 
            this.ToolStripDeleteSelected.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripDeleteSelected.Enabled = false;
            this.ToolStripDeleteSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripDeleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripDeleteSelected.Image = global::ModioX.Properties.Resources.delete;
            this.ToolStripDeleteSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripDeleteSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripDeleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDeleteSelected.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripDeleteSelected.Name = "ToolStripDeleteSelected";
            this.ToolStripDeleteSelected.Size = new System.Drawing.Size(71, 26);
            this.ToolStripDeleteSelected.Text = "Delete";
            this.ToolStripDeleteSelected.ToolTipText = "Delete Selected";
            this.ToolStripDeleteSelected.Click += new System.EventHandler(this.ToolStripDeleteSelected_Click);
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
            // SectionPanelUpdateGameRegions
            // 
            this.SectionPanelUpdateGameRegions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelUpdateGameRegions.Controls.Add(this.ButtonAddGame);
            this.SectionPanelUpdateGameRegions.Controls.Add(this.LabelGameRegion);
            this.SectionPanelUpdateGameRegions.Controls.Add(this.ComboBoxGameTitle);
            this.SectionPanelUpdateGameRegions.Controls.Add(this.LabelGameTitle);
            this.SectionPanelUpdateGameRegions.Controls.Add(this.ComboBoxGameRegion);
            this.SectionPanelUpdateGameRegions.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionPanelUpdateGameRegions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionPanelUpdateGameRegions.Location = new System.Drawing.Point(12, 257);
            this.SectionPanelUpdateGameRegions.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelUpdateGameRegions.Name = "SectionPanelUpdateGameRegions";
            this.SectionPanelUpdateGameRegions.SectionHeader = "UPDATE GAME REGIONS";
            this.SectionPanelUpdateGameRegions.Size = new System.Drawing.Size(414, 116);
            this.SectionPanelUpdateGameRegions.TabIndex = 1179;
            // 
            // ButtonAddGame
            // 
            this.ButtonAddGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddGame.Location = new System.Drawing.Point(255, 83);
            this.ButtonAddGame.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAddGame.Name = "ButtonAddGame";
            this.ButtonAddGame.Size = new System.Drawing.Size(151, 24);
            this.ButtonAddGame.TabIndex = 4;
            this.ButtonAddGame.Text = "Update Game Region";
            this.ButtonAddGame.Click += new System.EventHandler(this.ButtonAddGame_Click);
            // 
            // LabelGameRegion
            // 
            this.LabelGameRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameRegion.AutoSize = true;
            this.LabelGameRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.ComboBoxGameTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameTitle.FormattingEnabled = true;
            this.ComboBoxGameTitle.Location = new System.Drawing.Point(8, 51);
            this.ComboBoxGameTitle.Name = "ComboBoxGameTitle";
            this.ComboBoxGameTitle.Size = new System.Drawing.Size(280, 24);
            this.ComboBoxGameTitle.TabIndex = 2;
            this.ComboBoxGameTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameTitle_SelectedIndexChanged);
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.AutoSize = true;
            this.LabelGameTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.ComboBoxGameRegion.Enabled = false;
            this.ComboBoxGameRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameRegion.FormattingEnabled = true;
            this.ComboBoxGameRegion.Location = new System.Drawing.Point(294, 51);
            this.ComboBoxGameRegion.Name = "ComboBoxGameRegion";
            this.ComboBoxGameRegion.Size = new System.Drawing.Size(112, 24);
            this.ComboBoxGameRegion.TabIndex = 3;
            // 
            // GameRegionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(438, 418);
            this.Controls.Add(this.SectionPanelUpdateGameRegions);
            this.Controls.Add(this.SectionPanelGameRegions);
            this.Controls.Add(this.ButtonSaveAll);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameRegionsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Regions";
            this.Load += new System.EventHandler(this.EditGameRegions_Load);
            this.SectionPanelGameRegions.ResumeLayout(false);
            this.SectionPanelGameRegions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameRegions)).EndInit();
            this.ToolStripGameRegions.ResumeLayout(false);
            this.ToolStripGameRegions.PerformLayout();
            this.SectionPanelUpdateGameRegions.ResumeLayout(false);
            this.SectionPanelUpdateGameRegions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonSaveAll;
        private DarkUI.Controls.DarkSectionPanel SectionPanelGameRegions;
        private System.Windows.Forms.Label LabelNoGameRegionsSaved;
        private XDevkit.XtraDataGridView DgvGameRegions;
        private DarkUI.Controls.DarkToolStrip ToolStripGameRegions;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteAll;
        private System.Windows.Forms.ToolStripLabel LabelTotalGameRegions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private DarkUI.Controls.DarkSectionPanel SectionPanelUpdateGameRegions;
        private DarkUI.Controls.DarkLabel LabelGameRegion;
        private DarkUI.Controls.DarkComboBox ComboBoxGameTitle;
        private DarkUI.Controls.DarkLabel LabelGameTitle;
        private DarkUI.Controls.DarkButton ButtonAddGame;
        private DarkUI.Controls.DarkComboBox ComboBoxGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegion;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteSelected;
    }
}