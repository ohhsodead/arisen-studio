namespace ModioX.Forms.Tools.PS3_Tools
{
    partial class GameUpdatesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUpdatesWindow));
            this.SectionPanelInformation = new DevExpress.XtraEditors.GroupControl();
            this.LabelNoGameUpdatesFound = new DevExpress.XtraEditors.LabelControl();
            this.DgvGameUpdates = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxTitleID = new DevExpress.XtraEditors.TextEdit();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.LabelSelectType = new DevExpress.XtraEditors.LabelControl();
            this.ContextMenuDownloadToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuInstallToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuCopyURLToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuCopySHA1ToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLabelHeaderStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ColumnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirmware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonNewApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAddApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionPanelInformation)).BeginInit();
            this.SectionPanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionPanelInformation
            // 
            this.SectionPanelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelInformation.Controls.Add(this.stackPanel2);
            this.SectionPanelInformation.Controls.Add(this.LabelNoGameUpdatesFound);
            this.SectionPanelInformation.Controls.Add(this.DgvGameUpdates);
            this.SectionPanelInformation.Controls.Add(this.PanelSearch);
            this.SectionPanelInformation.Location = new System.Drawing.Point(11, 11);
            this.SectionPanelInformation.Name = "SectionPanelInformation";
            this.SectionPanelInformation.Size = new System.Drawing.Size(590, 300);
            this.SectionPanelInformation.TabIndex = 0;
            this.SectionPanelInformation.Text = "SEARCH FOR GAME UPDATES";
            // 
            // LabelNoGameUpdatesFound
            // 
            this.LabelNoGameUpdatesFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoGameUpdatesFound.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoGameUpdatesFound.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoGameUpdatesFound.Appearance.Options.UseFont = true;
            this.LabelNoGameUpdatesFound.Appearance.Options.UseForeColor = true;
            this.LabelNoGameUpdatesFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoGameUpdatesFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoGameUpdatesFound.Location = new System.Drawing.Point(225, 125);
            this.LabelNoGameUpdatesFound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelNoGameUpdatesFound.Name = "LabelNoGameUpdatesFound";
            this.LabelNoGameUpdatesFound.Size = new System.Drawing.Size(156, 15);
            this.LabelNoGameUpdatesFound.TabIndex = 1180;
            this.LabelNoGameUpdatesFound.Text = "NO GAME UPDATES FOUND";
            // 
            // DgvGameUpdates
            // 
            this.DgvGameUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGameUpdates.Location = new System.Drawing.Point(2, 58);
            this.DgvGameUpdates.MainView = this.gridView1;
            this.DgvGameUpdates.Name = "DgvGameUpdates";
            this.DgvGameUpdates.Size = new System.Drawing.Size(586, 240);
            this.DgvGameUpdates.TabIndex = 3;
            this.DgvGameUpdates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.DgvGameUpdates;
            this.gridView1.Name = "gridView1";
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.Transparent;
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Controls.Add(this.TextBoxTitleID);
            this.PanelSearch.Controls.Add(this.LabelSearch);
            this.PanelSearch.Controls.Add(this.LabelSelectType);
            this.PanelSearch.Controls.Add(this.ComboBoxType);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(2, 20);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(586, 38);
            this.PanelSearch.TabIndex = 2;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Appearance.Options.UseFont = true;
            this.ButtonSearch.Location = new System.Drawing.Point(306, 9);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(67, 21);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxTitleID
            // 
            this.TextBoxTitleID.EditValue = "e.g. BLES01807";
            this.TextBoxTitleID.Location = new System.Drawing.Point(57, 9);
            this.TextBoxTitleID.Name = "TextBoxTitleID";
            this.TextBoxTitleID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTitleID.Properties.Appearance.Options.UseFont = true;
            this.TextBoxTitleID.Size = new System.Drawing.Size(100, 22);
            this.TextBoxTitleID.TabIndex = 0;
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Appearance.Options.UseForeColor = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(10, 12);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(41, 15);
            this.LabelSearch.TabIndex = 1161;
            this.LabelSearch.Text = "TITLE ID";
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectType.Appearance.Options.UseFont = true;
            this.LabelSelectType.Appearance.Options.UseForeColor = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(164, 12);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(4, 3, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(72, 15);
            this.LabelSelectType.TabIndex = 1160;
            this.LabelSelectType.Text = "UPDATE TYPE";
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
            // ContextMenuInstallToConsole
            // 
            this.ContextMenuInstallToConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuInstallToConsole.Enabled = false;
            this.ContextMenuInstallToConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuInstallToConsole.Image = global::ModioX.Properties.Resources.install;
            this.ContextMenuInstallToConsole.Name = "ContextMenuInstallToConsole";
            this.ContextMenuInstallToConsole.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuInstallToConsole.Text = "Install to Console...";
            this.ContextMenuInstallToConsole.Click += new System.EventHandler(this.ContextMenuInstallToConsole_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // ContextMenuCopyURLToClipboard
            // 
            this.ContextMenuCopyURLToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCopyURLToClipboard.Enabled = false;
            this.ContextMenuCopyURLToClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCopyURLToClipboard.Image = global::ModioX.Properties.Resources.copy_to_clipboard;
            this.ContextMenuCopyURLToClipboard.Name = "ContextMenuCopyURLToClipboard";
            this.ContextMenuCopyURLToClipboard.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuCopyURLToClipboard.Text = "Copy URL to Clipboard";
            this.ContextMenuCopyURLToClipboard.Click += new System.EventHandler(this.ContextMenuCopyToClipboard_Click);
            // 
            // ContextMenuCopySHA1ToClipboard
            // 
            this.ContextMenuCopySHA1ToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCopySHA1ToClipboard.Enabled = false;
            this.ContextMenuCopySHA1ToClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCopySHA1ToClipboard.Image = global::ModioX.Properties.Resources.copy_to_clipboard;
            this.ContextMenuCopySHA1ToClipboard.Name = "ContextMenuCopySHA1ToClipboard";
            this.ContextMenuCopySHA1ToClipboard.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuCopySHA1ToClipboard.Text = "Copy SHA1 to Clipboard";
            this.ContextMenuCopySHA1ToClipboard.Click += new System.EventHandler(this.ContextMenuCopySHA1ToClipboard_Click);
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
            // ColumnURL
            // 
            this.ColumnURL.HeaderText = "URL";
            this.ColumnURL.Name = "ColumnURL";
            this.ColumnURL.ReadOnly = true;
            this.ColumnURL.Visible = false;
            // 
            // ColumnSHA1
            // 
            this.ColumnSHA1.HeaderText = "SHA1";
            this.ColumnSHA1.Name = "ColumnSHA1";
            this.ColumnSHA1.ReadOnly = true;
            this.ColumnSHA1.Visible = false;
            // 
            // ColumnGameTitle
            // 
            this.ColumnGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGameTitle.HeaderText = "Game Title";
            this.ColumnGameTitle.Name = "ColumnGameTitle";
            this.ColumnGameTitle.ReadOnly = true;
            // 
            // ColumnVersion
            // 
            this.ColumnVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnVersion.HeaderText = "Version";
            this.ColumnVersion.Name = "ColumnVersion";
            this.ColumnVersion.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.MinimumWidth = 70;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // ColumnFirmware
            // 
            this.ColumnFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnFirmware.HeaderText = "Firmware";
            this.ColumnFirmware.Name = "ColumnFirmware";
            this.ColumnFirmware.ReadOnly = true;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // ColumnInstall
            // 
            this.ColumnInstall.HeaderText = "";
            this.ColumnInstall.Name = "ColumnInstall";
            this.ColumnInstall.ReadOnly = true;
            this.ColumnInstall.Width = 28;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.ButtonNewApplication);
            this.stackPanel2.Controls.Add(this.ButtonAddApplication);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(2, 267);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(586, 31);
            this.stackPanel2.TabIndex = 1181;
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
            // ComboBoxType
            // 
            this.ComboBoxType.Location = new System.Drawing.Point(242, 9);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxType.Size = new System.Drawing.Size(57, 22);
            this.ComboBoxType.TabIndex = 1;
            // 
            // GameUpdatesWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(612, 339);
            this.Controls.Add(this.SectionPanelInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameUpdatesWindow.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameUpdatesWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Update Finder";
            this.Load += new System.EventHandler(this.GameUpdateFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionPanelInformation)).EndInit();
            this.SectionPanelInformation.ResumeLayout(false);
            this.SectionPanelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl SectionPanelInformation;
        private DevExpress.XtraGrid.GridControl DgvGameUpdates;
        private System.Windows.Forms.Panel PanelSearch;
        private DevExpress.XtraEditors.TextEdit TextBoxTitleID;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraEditors.LabelControl LabelSelectType;
        private DevExpress.XtraEditors.SimpleButton ButtonSearch;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDownloadToComputer;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuInstallToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopyURLToClipboard;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopySHA1ToClipboard;
        private DevExpress.XtraEditors.LabelControl LabelNoGameUpdatesFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirmware;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownload;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInstall;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton ButtonNewApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonAddApplication;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxType;
    }
}