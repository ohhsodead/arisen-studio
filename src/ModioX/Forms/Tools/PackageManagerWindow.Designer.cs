namespace ModioX.Forms.Tools
{
    partial class PackageManagerWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManagerWindow));
            this.SectionPackages = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoPackageFiles = new System.Windows.Forms.Label();
            this.DgvPackages = new DevExpress.XtraGrid.GridControl();
            this.ColumnPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ContextMenuPackages = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuDownloadToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripGameRegions = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.ToolStripInstallPackageFile = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalPackageFiles = new System.Windows.Forms.ToolStripLabel();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ButtonSearch = new DarkUI.Controls.DarkButton();
            this.TextBoxSearch = new DarkUI.Controls.DarkTextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ToolStripFooter = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelHeaderStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.TimerWait = new System.Windows.Forms.Timer(this.components);
            this.SectionPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPackages)).BeginInit();
            this.ContextMenuPackages.SuspendLayout();
            this.ToolStripGameRegions.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.ToolStripFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionPackages
            // 
            this.SectionPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPackages.Controls.Add(this.LabelNoPackageFiles);
            this.SectionPackages.Controls.Add(this.DgvPackages);
            this.SectionPackages.Controls.Add(this.ToolStripGameRegions);
            this.SectionPackages.Controls.Add(this.PanelSearch);
            this.SectionPackages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionPackages.Location = new System.Drawing.Point(13, 13);
            this.SectionPackages.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPackages.Name = "SectionPackages";
            this.SectionPackages.SectionHeader = "PACKAGE FILES";
            this.SectionPackages.Size = new System.Drawing.Size(602, 345);
            this.SectionPackages.TabIndex = 0;
            // 
            // LabelNoPackageFiles
            // 
            this.LabelNoPackageFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoPackageFiles.AutoSize = true;
            this.LabelNoPackageFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoPackageFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoPackageFiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoPackageFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoPackageFiles.Location = new System.Drawing.Point(245, 133);
            this.LabelNoPackageFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoPackageFiles.Name = "LabelNoPackageFiles";
            this.LabelNoPackageFiles.Size = new System.Drawing.Size(112, 15);
            this.LabelNoPackageFiles.TabIndex = 1179;
            this.LabelNoPackageFiles.Text = "NO PACKAGE FILES";
            // 
            // DgvPackages
            // 
            this.DgvPackages.ContextMenuStrip = this.ContextMenuPackages;
            this.DgvPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPackages.Location = new System.Drawing.Point(1, 69);
            this.DgvPackages.Name = "DgvPackages";
            this.DgvPackages.Size = new System.Drawing.Size(600, 239);
            this.DgvPackages.TabIndex = 3;
            // 
            // ColumnPackageName
            // 
            this.ColumnPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPackageName.HeaderText = "Package File Name";
            this.ColumnPackageName.Name = "ColumnPackageName";
            this.ColumnPackageName.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            this.ColumnSize.Width = 54;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // ContextMenuPackages
            // 
            this.ContextMenuPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuPackages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuPackages.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ContextMenuPackages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuDownloadToComputer});
            this.ContextMenuPackages.Name = "ContextMenuGameUpdates";
            this.ContextMenuPackages.Size = new System.Drawing.Size(211, 28);
            // 
            // ContextMenuDownloadToComputer
            // 
            this.ContextMenuDownloadToComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuDownloadToComputer.Enabled = false;
            this.ContextMenuDownloadToComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuDownloadToComputer.Image = global::ModioX.Properties.Resources.download_from_the_cloud;
            this.ContextMenuDownloadToComputer.Name = "ContextMenuDownloadToComputer";
            this.ContextMenuDownloadToComputer.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuDownloadToComputer.Text = "Download to Computer...";
            this.ContextMenuDownloadToComputer.Click += new System.EventHandler(this.ContextMenuDownloadToComptuer_Click);
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
            this.ToolStripInstallPackageFile,
            this.LabelTotalPackageFiles});
            this.ToolStripGameRegions.Location = new System.Drawing.Point(1, 308);
            this.ToolStripGameRegions.Name = "ToolStripGameRegions";
            this.ToolStripGameRegions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripGameRegions.Size = new System.Drawing.Size(600, 36);
            this.ToolStripGameRegions.TabIndex = 4;
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
            this.ToolStripDeleteAll.ToolTipText = "Delete All Package Files";
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
            this.ToolStripDeleteSelected.ToolTipText = "Delete Selected Package";
            this.ToolStripDeleteSelected.Click += new System.EventHandler(this.ToolStripDeleteSelected_Click);
            // 
            // ToolStripInstallPackageFile
            // 
            this.ToolStripInstallPackageFile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripInstallPackageFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripInstallPackageFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripInstallPackageFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripInstallPackageFile.Image = global::ModioX.Properties.Resources.install;
            this.ToolStripInstallPackageFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripInstallPackageFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripInstallPackageFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripInstallPackageFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripInstallPackageFile.Name = "ToolStripInstallPackageFile";
            this.ToolStripInstallPackageFile.Size = new System.Drawing.Size(137, 26);
            this.ToolStripInstallPackageFile.Text = "Install Package File";
            this.ToolStripInstallPackageFile.ToolTipText = "Install Package File";
            this.ToolStripInstallPackageFile.Click += new System.EventHandler(this.ToolStripInstallPackageFile_Click);
            // 
            // LabelTotalPackageFiles
            // 
            this.LabelTotalPackageFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelTotalPackageFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelTotalPackageFiles.Name = "LabelTotalPackageFiles";
            this.LabelTotalPackageFiles.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelTotalPackageFiles.Size = new System.Drawing.Size(92, 33);
            this.LabelTotalPackageFiles.Text = "0 Package Files";
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Controls.Add(this.LabelSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(1, 25);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(600, 44);
            this.PanelSearch.TabIndex = 2;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Enabled = false;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Location = new System.Drawing.Point(513, 10);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(78, 24);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.Location = new System.Drawing.Point(62, 10);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(445, 23);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(5, 14);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(51, 15);
            this.LabelSearch.TabIndex = 1161;
            this.LabelSearch.Text = "SEARCH";
            // 
            // ToolStripFooter
            // 
            this.ToolStripFooter.AutoSize = false;
            this.ToolStripFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelHeaderStatus,
            this.ToolStripLabelStatus});
            this.ToolStripFooter.Location = new System.Drawing.Point(0, 362);
            this.ToolStripFooter.Name = "ToolStripFooter";
            this.ToolStripFooter.Padding = new System.Windows.Forms.Padding(3, 0, 8, 5);
            this.ToolStripFooter.Size = new System.Drawing.Size(628, 28);
            this.ToolStripFooter.TabIndex = 5;
            this.ToolStripFooter.Text = "darkToolStrip1";
            // 
            // ToolStripLabelHeaderStatus
            // 
            this.ToolStripLabelHeaderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelHeaderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelHeaderStatus.Name = "ToolStripLabelHeaderStatus";
            this.ToolStripLabelHeaderStatus.Size = new System.Drawing.Size(48, 20);
            this.ToolStripLabelHeaderStatus.Text = "Status  :";
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(26, 20);
            this.ToolStripLabelStatus.Text = "Idle";
            // 
            // TimerWait
            // 
            this.TimerWait.Enabled = true;
            this.TimerWait.Tick += new System.EventHandler(this.TimerWait_Tick);
            // 
            // PackageManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(628, 390);
            this.Controls.Add(this.ToolStripFooter);
            this.Controls.Add(this.SectionPackages);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageManagerWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Manger";
            this.Load += new System.EventHandler(this.PackageManagerWindow_Load);
            this.SectionPackages.ResumeLayout(false);
            this.SectionPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPackages)).EndInit();
            this.ContextMenuPackages.ResumeLayout(false);
            this.ToolStripGameRegions.ResumeLayout(false);
            this.ToolStripGameRegions.PerformLayout();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ToolStripFooter.ResumeLayout(false);
            this.ToolStripFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkSectionPanel SectionPackages;
        private DevExpress.XtraGrid.GridControl DgvPackages;
        private System.Windows.Forms.Panel PanelSearch;
        private DarkUI.Controls.DarkTextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private DarkUI.Controls.DarkButton ButtonSearch;
        private DarkUI.Controls.DarkToolStrip ToolStripFooter;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private DarkUI.Controls.DarkContextMenu ContextMenuPackages;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDownloadToComputer;
        private DarkUI.Controls.DarkToolStrip ToolStripGameRegions;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteAll;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteSelected;
        private System.Windows.Forms.ToolStripLabel LabelTotalPackageFiles;
        private System.Windows.Forms.Label LabelNoPackageFiles;
        private System.Windows.Forms.Timer TimerWait;
        private System.Windows.Forms.ToolStripButton ToolStripInstallPackageFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownload;
    }
}