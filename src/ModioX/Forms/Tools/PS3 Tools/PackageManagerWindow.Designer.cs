namespace ModioX.Forms.Tools.PS3_Tools
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
            this.SectionPackages = new DevExpress.XtraEditors.GroupControl();
            this.LabelNoPackageFiles = new DevExpress.XtraEditors.LabelControl();
            this.DgvPackages = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.ColumnPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ContextMenuDownloadToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.ToolStripInstallPackageFile = new System.Windows.Forms.ToolStripButton();
            this.LabelTotalPackageFiles = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelHeaderStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.TimerWait = new System.Windows.Forms.Timer(this.components);
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonNewApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAddApplication = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.SectionPackages)).BeginInit();
            this.SectionPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionPackages
            // 
            this.SectionPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPackages.Controls.Add(this.stackPanel2);
            this.SectionPackages.Controls.Add(this.LabelNoPackageFiles);
            this.SectionPackages.Controls.Add(this.DgvPackages);
            this.SectionPackages.Controls.Add(this.PanelSearch);
            this.SectionPackages.Location = new System.Drawing.Point(11, 11);
            this.SectionPackages.Name = "SectionPackages";
            this.SectionPackages.Size = new System.Drawing.Size(516, 286);
            this.SectionPackages.TabIndex = 0;
            this.SectionPackages.Text = "PACKAGE FILES";
            // 
            // LabelNoPackageFiles
            // 
            this.LabelNoPackageFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoPackageFiles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoPackageFiles.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoPackageFiles.Appearance.Options.UseFont = true;
            this.LabelNoPackageFiles.Appearance.Options.UseForeColor = true;
            this.LabelNoPackageFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoPackageFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoPackageFiles.Location = new System.Drawing.Point(210, 115);
            this.LabelNoPackageFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelNoPackageFiles.Name = "LabelNoPackageFiles";
            this.LabelNoPackageFiles.Size = new System.Drawing.Size(106, 15);
            this.LabelNoPackageFiles.TabIndex = 1179;
            this.LabelNoPackageFiles.Text = "NO PACKAGE FILES";
            // 
            // DgvPackages
            // 
            this.DgvPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPackages.Location = new System.Drawing.Point(2, 58);
            this.DgvPackages.MainView = this.gridView1;
            this.DgvPackages.Name = "DgvPackages";
            this.DgvPackages.Size = new System.Drawing.Size(513, 226);
            this.DgvPackages.TabIndex = 3;
            this.DgvPackages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.DgvPackages;
            this.gridView1.Name = "gridView1";
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.Transparent;
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Controls.Add(this.LabelSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(2, 20);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(513, 38);
            this.PanelSearch.TabIndex = 2;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Appearance.Options.UseFont = true;
            this.ButtonSearch.Enabled = false;
            this.ButtonSearch.Location = new System.Drawing.Point(440, 9);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(67, 20);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(53, 9);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSearch.Size = new System.Drawing.Size(381, 22);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Appearance.Options.UseForeColor = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(10, 11);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 15);
            this.LabelSearch.TabIndex = 1161;
            this.LabelSearch.Text = "SEARCH";
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
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
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
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.ButtonNewApplication);
            this.stackPanel2.Controls.Add(this.ButtonAddApplication);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(2, 253);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(513, 31);
            this.stackPanel2.TabIndex = 1180;
            // 
            // ButtonNewApplication
            // 
            this.ButtonNewApplication.Location = new System.Drawing.Point(5, 5);
            this.ButtonNewApplication.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ButtonNewApplication.Name = "ButtonNewApplication";
            this.ButtonNewApplication.Size = new System.Drawing.Size(105, 21);
            this.ButtonNewApplication.TabIndex = 6;
            this.ButtonNewApplication.Text = "New Application";
            // 
            // ButtonAddApplication
            // 
            this.ButtonAddApplication.Location = new System.Drawing.Point(116, 5);
            this.ButtonAddApplication.Name = "ButtonAddApplication";
            this.ButtonAddApplication.Size = new System.Drawing.Size(105, 21);
            this.ButtonAddApplication.TabIndex = 7;
            this.ButtonAddApplication.Text = "Add Application";
            // 
            // PackageManagerWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 338);
            this.Controls.Add(this.SectionPackages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackageManagerWindow.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageManagerWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Manger";
            this.Load += new System.EventHandler(this.PackageManagerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionPackages)).EndInit();
            this.SectionPackages.ResumeLayout(false);
            this.SectionPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl SectionPackages;
        private DevExpress.XtraGrid.GridControl DgvPackages;
        private System.Windows.Forms.Panel PanelSearch;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraEditors.SimpleButton ButtonSearch;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDownloadToComputer;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteAll;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteSelected;
        private System.Windows.Forms.ToolStripLabel LabelTotalPackageFiles;
        private DevExpress.XtraEditors.LabelControl LabelNoPackageFiles;
        private System.Windows.Forms.Timer TimerWait;
        private System.Windows.Forms.ToolStripButton ToolStripInstallPackageFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownload;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton ButtonNewApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonAddApplication;
    }
}