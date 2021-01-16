namespace ModioX.Forms.Tools
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
            this.SectionPanelInformation = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoGameUpdatesFound = new System.Windows.Forms.Label();
            this.DgvGameUpdates = new XDevkit.XtraDataGridView();
            this.ContextMenuGameUpdates = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuDownloadToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuInstallToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuCopyURLToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuCopySHA1ToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ButtonSearch = new DarkUI.Controls.DarkButton();
            this.TextBoxTitleID = new DarkUI.Controls.DarkTextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.LabelSelectType = new System.Windows.Forms.Label();
            this.ComboBoxType = new DarkUI.Controls.DarkComboBox();
            this.ToolStripFooter = new DarkUI.Controls.DarkToolStrip();
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
            this.SectionPanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameUpdates)).BeginInit();
            this.ContextMenuGameUpdates.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.ToolStripFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionPanelInformation
            // 
            this.SectionPanelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelInformation.Controls.Add(this.LabelNoGameUpdatesFound);
            this.SectionPanelInformation.Controls.Add(this.DgvGameUpdates);
            this.SectionPanelInformation.Controls.Add(this.PanelSearch);
            this.SectionPanelInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionPanelInformation.Location = new System.Drawing.Point(13, 13);
            this.SectionPanelInformation.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelInformation.Name = "SectionPanelInformation";
            this.SectionPanelInformation.SectionHeader = "SEARCH FOR GAME UPDATES";
            this.SectionPanelInformation.Size = new System.Drawing.Size(688, 346);
            this.SectionPanelInformation.TabIndex = 0;
            // 
            // LabelNoGameUpdatesFound
            // 
            this.LabelNoGameUpdatesFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoGameUpdatesFound.AutoSize = true;
            this.LabelNoGameUpdatesFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoGameUpdatesFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoGameUpdatesFound.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoGameUpdatesFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoGameUpdatesFound.Location = new System.Drawing.Point(263, 144);
            this.LabelNoGameUpdatesFound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoGameUpdatesFound.Name = "LabelNoGameUpdatesFound";
            this.LabelNoGameUpdatesFound.Size = new System.Drawing.Size(162, 15);
            this.LabelNoGameUpdatesFound.TabIndex = 1180;
            this.LabelNoGameUpdatesFound.Text = "NO GAME UPDATES FOUND";
            // 
            // DgvGameUpdates
            // 
            this.DgvGameUpdates.AllowUserToAddRows = false;
            this.DgvGameUpdates.AllowUserToDeleteRows = false;
            this.DgvGameUpdates.AllowUserToDragDropRows = false;
            this.DgvGameUpdates.AllowUserToPasteCells = false;
            this.DgvGameUpdates.AllowUserToResizeColumns = false;
            this.DgvGameUpdates.ColumnHeadersHeight = 19;
            this.DgvGameUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnURL,
            this.ColumnSHA1,
            this.ColumnGameTitle,
            this.ColumnVersion,
            this.ColumnSize,
            this.ColumnFirmware,
            this.ColumnDownload,
            this.ColumnInstall});
            this.DgvGameUpdates.ContextMenuStrip = this.ContextMenuGameUpdates;
            this.DgvGameUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGameUpdates.Location = new System.Drawing.Point(1, 69);
            this.DgvGameUpdates.MultiSelect = false;
            this.DgvGameUpdates.Name = "DgvGameUpdates";
            this.DgvGameUpdates.ReadOnly = true;
            this.DgvGameUpdates.RowHeadersWidth = 41;
            this.DgvGameUpdates.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DgvGameUpdates.RowTemplate.ReadOnly = true;
            this.DgvGameUpdates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvGameUpdates.ShowEditingIcon = false;
            this.DgvGameUpdates.Size = new System.Drawing.Size(686, 276);
            this.DgvGameUpdates.TabIndex = 3;
            this.DgvGameUpdates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGameUpdates_CellClick);
            this.DgvGameUpdates.SelectionChanged += new System.EventHandler(this.DgvGameUpdates_SelectionChanged);
            // 
            // ContextMenuGameUpdates
            // 
            this.ContextMenuGameUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuGameUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuGameUpdates.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ContextMenuGameUpdates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuDownloadToComputer,
            this.ContextMenuInstallToConsole,
            this.toolStripSeparator1,
            this.ContextMenuCopyURLToClipboard,
            this.ContextMenuCopySHA1ToClipboard});
            this.ContextMenuGameUpdates.Name = "ContextMenuGameUpdates";
            this.ContextMenuGameUpdates.Size = new System.Drawing.Size(211, 107);
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
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Controls.Add(this.TextBoxTitleID);
            this.PanelSearch.Controls.Add(this.LabelSearch);
            this.PanelSearch.Controls.Add(this.LabelSelectType);
            this.PanelSearch.Controls.Add(this.ComboBoxType);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(1, 25);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(686, 44);
            this.PanelSearch.TabIndex = 2;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Location = new System.Drawing.Point(343, 10);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(78, 24);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxTitleID
            // 
            this.TextBoxTitleID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTitleID.Location = new System.Drawing.Point(59, 10);
            this.TextBoxTitleID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTitleID.Name = "TextBoxTitleID";
            this.TextBoxTitleID.Size = new System.Drawing.Size(117, 23);
            this.TextBoxTitleID.TabIndex = 0;
            this.TextBoxTitleID.Text = "e.g. BLES01807";
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
            this.LabelSearch.Size = new System.Drawing.Size(48, 15);
            this.LabelSearch.TabIndex = 1161;
            this.LabelSearch.Text = "TITLE ID";
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.AutoSize = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(184, 14);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(78, 15);
            this.LabelSelectType.TabIndex = 1160;
            this.LabelSelectType.Text = "UPDATE TYPE";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Retail",
            "Debug"});
            this.ComboBoxType.Location = new System.Drawing.Point(268, 10);
            this.ComboBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(67, 24);
            this.ComboBoxType.TabIndex = 1;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
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
            this.ToolStripFooter.Location = new System.Drawing.Point(0, 363);
            this.ToolStripFooter.Name = "ToolStripFooter";
            this.ToolStripFooter.Padding = new System.Windows.Forms.Padding(3, 0, 8, 5);
            this.ToolStripFooter.Size = new System.Drawing.Size(714, 28);
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
            this.ColumnVersion.Width = 72;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.MinimumWidth = 70;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            this.ColumnSize.Width = 70;
            // 
            // ColumnFirmware
            // 
            this.ColumnFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnFirmware.HeaderText = "Firmware";
            this.ColumnFirmware.Name = "ColumnFirmware";
            this.ColumnFirmware.ReadOnly = true;
            this.ColumnFirmware.Width = 84;
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
            // GameUpdatesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(714, 391);
            this.Controls.Add(this.ToolStripFooter);
            this.Controls.Add(this.SectionPanelInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameUpdatesWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Update Finder";
            this.Load += new System.EventHandler(this.GameUpdateFinder_Load);
            this.SectionPanelInformation.ResumeLayout(false);
            this.SectionPanelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameUpdates)).EndInit();
            this.ContextMenuGameUpdates.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ToolStripFooter.ResumeLayout(false);
            this.ToolStripFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkSectionPanel SectionPanelInformation;
        private XDevkit.XtraDataGridView DgvGameUpdates;
        private System.Windows.Forms.Panel PanelSearch;
        private DarkUI.Controls.DarkTextBox TextBoxTitleID;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Label LabelSelectType;
        private DarkUI.Controls.DarkComboBox ComboBoxType;
        private DarkUI.Controls.DarkButton ButtonSearch;
        private DarkUI.Controls.DarkToolStrip ToolStripFooter;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private DarkUI.Controls.DarkContextMenu ContextMenuGameUpdates;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDownloadToComputer;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuInstallToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopyURLToClipboard;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopySHA1ToClipboard;
        private System.Windows.Forms.Label LabelNoGameUpdatesFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirmware;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownload;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInstall;
    }
}