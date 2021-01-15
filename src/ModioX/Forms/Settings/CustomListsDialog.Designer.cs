namespace ModioX.Forms.Settings
{
    partial class CustomListsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomListsDialog));
            this.SectionPanelCustomLists = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoListsCreated = new System.Windows.Forms.Label();
            this.DgvCustomLists = new DarkUI.Controls.DarkDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuCustomLists = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuCustomListsRename = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuCustomListsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripGameRegions = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.ToolStripCreateNewList = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalCustomLists = new System.Windows.Forms.ToolStripLabel();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSaveAll = new DarkUI.Controls.DarkButton();
            this.SectionPanelCustomLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomLists)).BeginInit();
            this.ContextMenuCustomLists.SuspendLayout();
            this.ToolStripGameRegions.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionPanelCustomLists
            // 
            this.SectionPanelCustomLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelCustomLists.Controls.Add(this.LabelNoListsCreated);
            this.SectionPanelCustomLists.Controls.Add(this.DgvCustomLists);
            this.SectionPanelCustomLists.Controls.Add(this.ToolStripGameRegions);
            this.SectionPanelCustomLists.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionPanelCustomLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionPanelCustomLists.Location = new System.Drawing.Point(12, 13);
            this.SectionPanelCustomLists.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelCustomLists.Name = "SectionPanelCustomLists";
            this.SectionPanelCustomLists.SectionHeader = "YOUR LISTS";
            this.SectionPanelCustomLists.Size = new System.Drawing.Size(407, 253);
            this.SectionPanelCustomLists.TabIndex = 0;
            // 
            // LabelNoListsCreated
            // 
            this.LabelNoListsCreated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoListsCreated.AutoSize = true;
            this.LabelNoListsCreated.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoListsCreated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoListsCreated.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoListsCreated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoListsCreated.Location = new System.Drawing.Point(147, 79);
            this.LabelNoListsCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoListsCreated.Name = "LabelNoListsCreated";
            this.LabelNoListsCreated.Size = new System.Drawing.Size(112, 15);
            this.LabelNoListsCreated.TabIndex = 1178;
            this.LabelNoListsCreated.Text = "NO LISTS CREATED";
            // 
            // DgvCustomLists
            // 
            this.DgvCustomLists.AllowUserToAddRows = false;
            this.DgvCustomLists.AllowUserToDragDropRows = false;
            this.DgvCustomLists.AllowUserToPasteCells = false;
            this.DgvCustomLists.AllowUserToResizeColumns = false;
            this.DgvCustomLists.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvCustomLists.ColumnHeadersHeight = 21;
            this.DgvCustomLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvCustomLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColumnRegion});
            this.DgvCustomLists.ContextMenuStrip = this.ContextMenuCustomLists;
            this.DgvCustomLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCustomLists.Location = new System.Drawing.Point(1, 25);
            this.DgvCustomLists.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvCustomLists.MultiSelect = false;
            this.DgvCustomLists.Name = "DgvCustomLists";
            this.DgvCustomLists.ReadOnly = true;
            this.DgvCustomLists.RowHeadersWidth = 41;
            this.DgvCustomLists.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomLists.RowTemplate.Height = 24;
            this.DgvCustomLists.RowTemplate.ReadOnly = true;
            this.DgvCustomLists.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCustomLists.Size = new System.Drawing.Size(405, 191);
            this.DgvCustomLists.TabIndex = 0;
            this.DgvCustomLists.SelectionChanged += new System.EventHandler(this.DgvCustomLists_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnRegion
            // 
            this.ColumnRegion.HeaderText = "# of Mods";
            this.ColumnRegion.Name = "ColumnRegion";
            this.ColumnRegion.ReadOnly = true;
            this.ColumnRegion.Width = 80;
            // 
            // ContextMenuCustomLists
            // 
            this.ContextMenuCustomLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCustomLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCustomLists.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuCustomLists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuCustomListsRename,
            this.ContextMenuCustomListsDelete});
            this.ContextMenuCustomLists.Name = "ContextMenuConsole";
            this.ContextMenuCustomLists.Size = new System.Drawing.Size(152, 56);
            // 
            // ContextMenuCustomListsRename
            // 
            this.ContextMenuCustomListsRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCustomListsRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCustomListsRename.Image = global::ModioX.Properties.Resources.rename;
            this.ContextMenuCustomListsRename.Name = "ContextMenuCustomListsRename";
            this.ContextMenuCustomListsRename.Size = new System.Drawing.Size(151, 26);
            this.ContextMenuCustomListsRename.Text = "Rename List...";
            this.ContextMenuCustomListsRename.Click += new System.EventHandler(this.ContextMenuCustomListsRename_Click);
            // 
            // ContextMenuCustomListsDelete
            // 
            this.ContextMenuCustomListsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCustomListsDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCustomListsDelete.Image = global::ModioX.Properties.Resources.delete_list;
            this.ContextMenuCustomListsDelete.Name = "ContextMenuCustomListsDelete";
            this.ContextMenuCustomListsDelete.Size = new System.Drawing.Size(151, 26);
            this.ContextMenuCustomListsDelete.Text = "Delete List...";
            this.ContextMenuCustomListsDelete.Click += new System.EventHandler(this.ContextMenuCustomListsDelete_Click);
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
            this.ToolStripCreateNewList,
            this.LabelTotalCustomLists});
            this.ToolStripGameRegions.Location = new System.Drawing.Point(1, 216);
            this.ToolStripGameRegions.Name = "ToolStripGameRegions";
            this.ToolStripGameRegions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripGameRegions.Size = new System.Drawing.Size(405, 36);
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
            this.ToolStripDeleteAll.ToolTipText = "Delete All Lists";
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
            this.ToolStripDeleteSelected.ToolTipText = "Delete Selected List";
            this.ToolStripDeleteSelected.Click += new System.EventHandler(this.ToolStripDeleteSelected_Click);
            // 
            // ToolStripCreateNewList
            // 
            this.ToolStripCreateNewList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripCreateNewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripCreateNewList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripCreateNewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripCreateNewList.Image = global::ModioX.Properties.Resources.add_list;
            this.ToolStripCreateNewList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripCreateNewList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripCreateNewList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCreateNewList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripCreateNewList.Name = "ToolStripCreateNewList";
            this.ToolStripCreateNewList.Size = new System.Drawing.Size(121, 26);
            this.ToolStripCreateNewList.Text = "Create New List";
            this.ToolStripCreateNewList.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripCreateNewList.ToolTipText = "Create New List";
            this.ToolStripCreateNewList.Click += new System.EventHandler(this.ToolStripCreateNewList_Click);
            // 
            // LabelTotalCustomLists
            // 
            this.LabelTotalCustomLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelTotalCustomLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelTotalCustomLists.Name = "LabelTotalCustomLists";
            this.LabelTotalCustomLists.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelTotalCustomLists.Size = new System.Drawing.Size(45, 33);
            this.LabelTotalCustomLists.Text = "0 Lists";
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
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.Location = new System.Drawing.Point(340, 275);
            this.ButtonSaveAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Size = new System.Drawing.Size(79, 24);
            this.ButtonSaveAll.TabIndex = 4;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // CustomListsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 313);
            this.Controls.Add(this.ButtonSaveAll);
            this.Controls.Add(this.SectionPanelCustomLists);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomListsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Your Lists";
            this.Load += new System.EventHandler(this.CustomListsDialog_Load);
            this.SectionPanelCustomLists.ResumeLayout(false);
            this.SectionPanelCustomLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomLists)).EndInit();
            this.ContextMenuCustomLists.ResumeLayout(false);
            this.ToolStripGameRegions.ResumeLayout(false);
            this.ToolStripGameRegions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkSectionPanel SectionPanelCustomLists;
        private System.Windows.Forms.Label LabelNoListsCreated;
        private DarkUI.Controls.DarkDataGridView DgvCustomLists;
        private DarkUI.Controls.DarkToolStrip ToolStripGameRegions;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteAll;
        private System.Windows.Forms.ToolStripLabel LabelTotalCustomLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteSelected;
        private System.Windows.Forms.ToolStripButton ToolStripCreateNewList;
        private DarkUI.Controls.DarkButton ButtonSaveAll;
        private DarkUI.Controls.DarkContextMenu ContextMenuCustomLists;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCustomListsRename;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCustomListsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegion;
    }
}