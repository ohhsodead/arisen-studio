namespace ModioX.Forms.File_Explorer
{
    partial class FileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.ContextMenuConsoleFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuConsoleDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHeader = new DarkUI.Controls.DarkMenuStrip();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsSaveLocalDirectoryPath = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripHelpAboutApp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFooter = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.SectionLocalFileExplorer = new DarkUI.Controls.DarkSectionPanel();
            this.DgvLocalFiles = new DarkUI.Controls.DarkDataGridView();
            this.ContextMenuLocalFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuStripLocalUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripLocalDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLocalFiles = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripItemLocalUploadFile = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.ToolStripItemLocalOpenExplorer = new System.Windows.Forms.ToolStripButton();
            this.TextBoxLocalDirectory = new DarkUI.Controls.DarkTextBox();
            this.ButtonLocalDirectory = new DarkUI.Controls.DarkButton();
            this.SectionConsoleFileExplorer = new DarkUI.Controls.DarkSectionPanel();
            this.DgvConsoleFiles = new DarkUI.Controls.DarkDataGridView();
            this.ButtonConsoleExplorerNavigate = new DarkUI.Controls.DarkButton();
            this.darkToolStrip7 = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripItemConsoleFileDownload = new System.Windows.Forms.ToolStripButton();
            this.ToolStripItemConsoleFileDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripItemConsoleRefresh = new System.Windows.Forms.ToolStripButton();
            this.TextBoxConsoleDirectory = new DarkUI.Controls.DarkTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ColumnLocalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnLocalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnConsoleFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleLastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuConsoleFile.SuspendLayout();
            this.MenuStripHeader.SuspendLayout();
            this.ToolStripFooter.SuspendLayout();
            this.SectionLocalFileExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalFiles)).BeginInit();
            this.ContextMenuLocalFile.SuspendLayout();
            this.ToolStripLocalFiles.SuspendLayout();
            this.SectionConsoleFileExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsoleFiles)).BeginInit();
            this.darkToolStrip7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuConsoleFile
            // 
            this.ContextMenuConsoleFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuConsoleFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuConsoleDownloadFile,
            this.ContextMenuConsoleDeleteFile,
            this.ContextMenuConsoleRefresh});
            this.ContextMenuConsoleFile.Name = "ContextMenuConsole";
            this.ContextMenuConsoleFile.Size = new System.Drawing.Size(150, 70);
            // 
            // ContextMenuConsoleDownloadFile
            // 
            this.ContextMenuConsoleDownloadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleDownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleDownloadFile.Name = "ContextMenuConsoleDownloadFile";
            this.ContextMenuConsoleDownloadFile.Size = new System.Drawing.Size(149, 22);
            this.ContextMenuConsoleDownloadFile.Text = "Download File";
            this.ContextMenuConsoleDownloadFile.Click += new System.EventHandler(this.ContextMenuConsoleDownloadFile_Click);
            // 
            // ContextMenuConsoleDeleteFile
            // 
            this.ContextMenuConsoleDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleDeleteFile.Name = "ContextMenuConsoleDeleteFile";
            this.ContextMenuConsoleDeleteFile.Size = new System.Drawing.Size(149, 22);
            this.ContextMenuConsoleDeleteFile.Text = "Delete File";
            this.ContextMenuConsoleDeleteFile.Click += new System.EventHandler(this.ContextMenuConsoleDeleteFile_Click);
            // 
            // ContextMenuConsoleRefresh
            // 
            this.ContextMenuConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleRefresh.Name = "ContextMenuConsoleRefresh";
            this.ContextMenuConsoleRefresh.Size = new System.Drawing.Size(149, 22);
            this.ContextMenuConsoleRefresh.Text = "Refresh";
            this.ContextMenuConsoleRefresh.Click += new System.EventHandler(this.ContextMenuConsoleRefresh_Click);
            // 
            // MenuStripHeader
            // 
            this.MenuStripHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettings,
            this.MenuItemHelp});
            this.MenuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.MenuStripHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MenuStripHeader.Name = "MenuStripHeader";
            this.MenuStripHeader.Padding = new System.Windows.Forms.Padding(8, 9, 8, 0);
            this.MenuStripHeader.Size = new System.Drawing.Size(1226, 28);
            this.MenuStripHeader.TabIndex = 1140;
            this.MenuStripHeader.Text = "darkMenuStrip1";
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingsSaveLocalDirectoryPath});
            this.MenuItemSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.Size = new System.Drawing.Size(69, 19);
            this.MenuItemSettings.Text = "SETTINGS";
            // 
            // MenuItemSettingsSaveLocalDirectoryPath
            // 
            this.MenuItemSettingsSaveLocalDirectoryPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsSaveLocalDirectoryPath.CheckOnClick = true;
            this.MenuItemSettingsSaveLocalDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsSaveLocalDirectoryPath.Name = "MenuItemSettingsSaveLocalDirectoryPath";
            this.MenuItemSettingsSaveLocalDirectoryPath.Size = new System.Drawing.Size(207, 22);
            this.MenuItemSettingsSaveLocalDirectoryPath.Text = "Save Local Directory Path";
            this.MenuItemSettingsSaveLocalDirectoryPath.Click += new System.EventHandler(this.MenuItemSettingsSaveLocalDirectoryPath_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripHelpReportIssue,
            this.MenuStripHelpSeperator0,
            this.MenuStripHelpAboutApp});
            this.MenuItemHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(47, 19);
            this.MenuItemHelp.Text = "HELP";
            // 
            // MenuStripHelpReportIssue
            // 
            this.MenuStripHelpReportIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpReportIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpReportIssue.Name = "MenuStripHelpReportIssue";
            this.MenuStripHelpReportIssue.Size = new System.Drawing.Size(226, 22);
            this.MenuStripHelpReportIssue.Text = "Report Problem/Suggestions";
            // 
            // MenuStripHelpSeperator0
            // 
            this.MenuStripHelpSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStripHelpSeperator0.Name = "MenuStripHelpSeperator0";
            this.MenuStripHelpSeperator0.Size = new System.Drawing.Size(223, 6);
            // 
            // MenuStripHelpAboutApp
            // 
            this.MenuStripHelpAboutApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpAboutApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpAboutApp.Name = "MenuStripHelpAboutApp";
            this.MenuStripHelpAboutApp.Size = new System.Drawing.Size(226, 22);
            this.MenuStripHelpAboutApp.Text = "About ModioX";
            // 
            // ToolStripFooter
            // 
            this.ToolStripFooter.AutoSize = false;
            this.ToolStripFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripFooter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelStatus});
            this.ToolStripFooter.Location = new System.Drawing.Point(0, 385);
            this.ToolStripFooter.Name = "ToolStripFooter";
            this.ToolStripFooter.Padding = new System.Windows.Forms.Padding(12, 0, 8, 5);
            this.ToolStripFooter.Size = new System.Drawing.Size(1226, 32);
            this.ToolStripFooter.TabIndex = 1146;
            this.ToolStripFooter.Text = "darkToolStrip1";
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(85, 24);
            this.ToolStripLabelStatus.Text = "Loading data...";
            // 
            // SectionLocalFileExplorer
            // 
            this.SectionLocalFileExplorer.Controls.Add(this.DgvLocalFiles);
            this.SectionLocalFileExplorer.Controls.Add(this.ToolStripLocalFiles);
            this.SectionLocalFileExplorer.Controls.Add(this.TextBoxLocalDirectory);
            this.SectionLocalFileExplorer.Controls.Add(this.ButtonLocalDirectory);
            this.SectionLocalFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionLocalFileExplorer.Location = new System.Drawing.Point(0, 0);
            this.SectionLocalFileExplorer.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.SectionLocalFileExplorer.Name = "SectionLocalFileExplorer";
            this.SectionLocalFileExplorer.SectionHeader = "Local File Explorer";
            this.SectionLocalFileExplorer.Size = new System.Drawing.Size(595, 340);
            this.SectionLocalFileExplorer.TabIndex = 17;
            // 
            // DgvLocalFiles
            // 
            this.DgvLocalFiles.AllowUserToAddRows = false;
            this.DgvLocalFiles.AllowUserToDeleteRows = false;
            this.DgvLocalFiles.AllowUserToDragDropRows = false;
            this.DgvLocalFiles.AllowUserToPasteCells = false;
            this.DgvLocalFiles.AllowUserToResizeColumns = false;
            this.DgvLocalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLocalFiles.ColumnHeadersHeight = 23;
            this.DgvLocalFiles.ColumnHeadersVisible = false;
            this.DgvLocalFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLocalType,
            this.ColumnLocalIcon,
            this.ColumnLocalName,
            this.ColumnLocalSize,
            this.ColumnLocalExtension,
            this.ColumnLocalDateTime});
            this.DgvLocalFiles.ContextMenuStrip = this.ContextMenuLocalFile;
            this.DgvLocalFiles.Location = new System.Drawing.Point(7, 60);
            this.DgvLocalFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.DgvLocalFiles.MultiSelect = false;
            this.DgvLocalFiles.Name = "DgvLocalFiles";
            this.DgvLocalFiles.ReadOnly = true;
            this.DgvLocalFiles.RowHeadersWidth = 41;
            this.DgvLocalFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvLocalFiles.RowTemplate.Height = 24;
            this.DgvLocalFiles.RowTemplate.ReadOnly = true;
            this.DgvLocalFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvLocalFiles.Size = new System.Drawing.Size(581, 243);
            this.DgvLocalFiles.TabIndex = 20;
            this.DgvLocalFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLocalFiles_CellClick);
            this.DgvLocalFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvLocalFiles.SelectionChanged += new System.EventHandler(this.DgvLocalFiles_SelectionChanged);
            // 
            // ContextMenuLocalFile
            // 
            this.ContextMenuLocalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuLocalFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuStripLocalUploadFile,
            this.ContextMenuStripLocalDeleteFile});
            this.ContextMenuLocalFile.Name = "ContextMenuConsole";
            this.ContextMenuLocalFile.Size = new System.Drawing.Size(134, 48);
            // 
            // ContextMenuStripLocalUploadFile
            // 
            this.ContextMenuStripLocalUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuStripLocalUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuStripLocalUploadFile.Name = "ContextMenuStripLocalUploadFile";
            this.ContextMenuStripLocalUploadFile.Size = new System.Drawing.Size(133, 22);
            this.ContextMenuStripLocalUploadFile.Text = "Upload File";
            this.ContextMenuStripLocalUploadFile.Click += new System.EventHandler(this.ContextMenuStripLocalFileUpload_Click);
            // 
            // ContextMenuStripLocalDeleteFile
            // 
            this.ContextMenuStripLocalDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuStripLocalDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuStripLocalDeleteFile.Name = "ContextMenuStripLocalDeleteFile";
            this.ContextMenuStripLocalDeleteFile.Size = new System.Drawing.Size(133, 22);
            this.ContextMenuStripLocalDeleteFile.Text = "Delete File";
            this.ContextMenuStripLocalDeleteFile.Click += new System.EventHandler(this.ContextMenuStripLocalDeleteFile_Click);
            // 
            // ToolStripLocalFiles
            // 
            this.ToolStripLocalFiles.AutoSize = false;
            this.ToolStripLocalFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripLocalFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalFiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripLocalFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripLocalFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemLocalUploadFile,
            this.ToolStripLocalDeleteFile,
            this.ToolStripItemLocalOpenExplorer});
            this.ToolStripLocalFiles.Location = new System.Drawing.Point(1, 303);
            this.ToolStripLocalFiles.Name = "ToolStripLocalFiles";
            this.ToolStripLocalFiles.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripLocalFiles.Size = new System.Drawing.Size(593, 36);
            this.ToolStripLocalFiles.TabIndex = 21;
            this.ToolStripLocalFiles.TabStop = true;
            this.ToolStripLocalFiles.Text = "darkToolStrip3";
            // 
            // ToolStripItemLocalUploadFile
            // 
            this.ToolStripItemLocalUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripItemLocalUploadFile.Enabled = false;
            this.ToolStripItemLocalUploadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripItemLocalUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripItemLocalUploadFile.Image = global::ModioX.Properties.Resources.icons8_upload_22;
            this.ToolStripItemLocalUploadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripItemLocalUploadFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripItemLocalUploadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItemLocalUploadFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripItemLocalUploadFile.Name = "ToolStripItemLocalUploadFile";
            this.ToolStripItemLocalUploadFile.Size = new System.Drawing.Size(72, 26);
            this.ToolStripItemLocalUploadFile.Text = "Upload";
            this.ToolStripItemLocalUploadFile.Click += new System.EventHandler(this.ToolStripLocalUploadFile_Click);
            // 
            // ToolStripLocalDeleteFile
            // 
            this.ToolStripLocalDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalDeleteFile.Enabled = false;
            this.ToolStripLocalDeleteFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalDeleteFile.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolStripLocalDeleteFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripLocalDeleteFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalDeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalDeleteFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripLocalDeleteFile.Name = "ToolStripLocalDeleteFile";
            this.ToolStripLocalDeleteFile.Size = new System.Drawing.Size(71, 26);
            this.ToolStripLocalDeleteFile.Text = "Delete";
            this.ToolStripLocalDeleteFile.Click += new System.EventHandler(this.ToolStripLocalDeleteFile_Click);
            // 
            // ToolStripItemLocalOpenExplorer
            // 
            this.ToolStripItemLocalOpenExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripItemLocalOpenExplorer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripItemLocalOpenExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripItemLocalOpenExplorer.Image = global::ModioX.Properties.Resources.icons8_opened_folder_22;
            this.ToolStripItemLocalOpenExplorer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripItemLocalOpenExplorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripItemLocalOpenExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItemLocalOpenExplorer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripItemLocalOpenExplorer.Name = "ToolStripItemLocalOpenExplorer";
            this.ToolStripItemLocalOpenExplorer.Size = new System.Drawing.Size(113, 26);
            this.ToolStripItemLocalOpenExplorer.Text = "Open Explorer";
            this.ToolStripItemLocalOpenExplorer.Click += new System.EventHandler(this.ToolStripLocalOpenExplorer_Click);
            // 
            // TextBoxLocalDirectory
            // 
            this.TextBoxLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalDirectory.Location = new System.Drawing.Point(7, 31);
            this.TextBoxLocalDirectory.Name = "TextBoxLocalDirectory";
            this.TextBoxLocalDirectory.ReadOnly = true;
            this.TextBoxLocalDirectory.Size = new System.Drawing.Size(532, 23);
            this.TextBoxLocalDirectory.TabIndex = 18;
            this.TextBoxLocalDirectory.Text = "\\";
            // 
            // ButtonLocalDirectory
            // 
            this.ButtonLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalDirectory.Location = new System.Drawing.Point(545, 31);
            this.ButtonLocalDirectory.Name = "ButtonLocalDirectory";
            this.ButtonLocalDirectory.Size = new System.Drawing.Size(43, 23);
            this.ButtonLocalDirectory.TabIndex = 19;
            this.ButtonLocalDirectory.Text = "...";
            this.ButtonLocalDirectory.Click += new System.EventHandler(this.ButtonLocalDirectory_Click);
            // 
            // SectionConsoleFileExplorer
            // 
            this.SectionConsoleFileExplorer.Controls.Add(this.DgvConsoleFiles);
            this.SectionConsoleFileExplorer.Controls.Add(this.ButtonConsoleExplorerNavigate);
            this.SectionConsoleFileExplorer.Controls.Add(this.darkToolStrip7);
            this.SectionConsoleFileExplorer.Controls.Add(this.TextBoxConsoleDirectory);
            this.SectionConsoleFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionConsoleFileExplorer.Location = new System.Drawing.Point(605, 0);
            this.SectionConsoleFileExplorer.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SectionConsoleFileExplorer.Name = "SectionConsoleFileExplorer";
            this.SectionConsoleFileExplorer.SectionHeader = "Console File Explorer";
            this.SectionConsoleFileExplorer.Size = new System.Drawing.Size(596, 340);
            this.SectionConsoleFileExplorer.TabIndex = 1157;
            // 
            // DgvConsoleFiles
            // 
            this.DgvConsoleFiles.AllowUserToAddRows = false;
            this.DgvConsoleFiles.AllowUserToDeleteRows = false;
            this.DgvConsoleFiles.AllowUserToDragDropRows = false;
            this.DgvConsoleFiles.AllowUserToPasteCells = false;
            this.DgvConsoleFiles.AllowUserToResizeColumns = false;
            this.DgvConsoleFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvConsoleFiles.ColumnHeadersHeight = 23;
            this.DgvConsoleFiles.ColumnHeadersVisible = false;
            this.DgvConsoleFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConsoleFileType,
            this.ColumnConsoleFileImage,
            this.ColumnConsoleFileName,
            this.ColumnConsoleFileSize,
            this.ColumnConsoleFileExt,
            this.ColumnConsoleLastModified});
            this.DgvConsoleFiles.ContextMenuStrip = this.ContextMenuConsoleFile;
            this.DgvConsoleFiles.Location = new System.Drawing.Point(7, 60);
            this.DgvConsoleFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.DgvConsoleFiles.MultiSelect = false;
            this.DgvConsoleFiles.Name = "DgvConsoleFiles";
            this.DgvConsoleFiles.ReadOnly = true;
            this.DgvConsoleFiles.RowHeadersWidth = 41;
            this.DgvConsoleFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvConsoleFiles.RowTemplate.Height = 24;
            this.DgvConsoleFiles.RowTemplate.ReadOnly = true;
            this.DgvConsoleFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvConsoleFiles.Size = new System.Drawing.Size(583, 243);
            this.DgvConsoleFiles.TabIndex = 24;
            this.DgvConsoleFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsoleFiles_CellClick);
            this.DgvConsoleFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvConsoleFiles.SelectionChanged += new System.EventHandler(this.DgvConsoleFiles_SelectionChanged);
            // 
            // ButtonConsoleExplorerNavigate
            // 
            this.ButtonConsoleExplorerNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConsoleExplorerNavigate.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonConsoleExplorerNavigate.Location = new System.Drawing.Point(551, 31);
            this.ButtonConsoleExplorerNavigate.Name = "ButtonConsoleExplorerNavigate";
            this.ButtonConsoleExplorerNavigate.Size = new System.Drawing.Size(39, 23);
            this.ButtonConsoleExplorerNavigate.TabIndex = 23;
            this.ButtonConsoleExplorerNavigate.Text = ">";
            this.ButtonConsoleExplorerNavigate.Click += new System.EventHandler(this.ButtonConsoleExplorerNavigate_Click);
            // 
            // darkToolStrip7
            // 
            this.darkToolStrip7.AutoSize = false;
            this.darkToolStrip7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkToolStrip7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.darkToolStrip7.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkToolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemConsoleFileDownload,
            this.ToolStripItemConsoleFileDelete,
            this.ToolStripItemConsoleRefresh});
            this.darkToolStrip7.Location = new System.Drawing.Point(1, 303);
            this.darkToolStrip7.Name = "darkToolStrip7";
            this.darkToolStrip7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.darkToolStrip7.Size = new System.Drawing.Size(594, 36);
            this.darkToolStrip7.TabIndex = 25;
            this.darkToolStrip7.TabStop = true;
            this.darkToolStrip7.Text = "darkToolStrip4";
            // 
            // ToolStripItemConsoleFileDownload
            // 
            this.ToolStripItemConsoleFileDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripItemConsoleFileDownload.Enabled = false;
            this.ToolStripItemConsoleFileDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripItemConsoleFileDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripItemConsoleFileDownload.Image = global::ModioX.Properties.Resources.icons8_download_22;
            this.ToolStripItemConsoleFileDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripItemConsoleFileDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripItemConsoleFileDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItemConsoleFileDownload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripItemConsoleFileDownload.Name = "ToolStripItemConsoleFileDownload";
            this.ToolStripItemConsoleFileDownload.Size = new System.Drawing.Size(89, 26);
            this.ToolStripItemConsoleFileDownload.Text = "Download";
            this.ToolStripItemConsoleFileDownload.Click += new System.EventHandler(this.ToolStripItemConsoleFileDownload_Click);
            // 
            // ToolStripItemConsoleFileDelete
            // 
            this.ToolStripItemConsoleFileDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripItemConsoleFileDelete.Enabled = false;
            this.ToolStripItemConsoleFileDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripItemConsoleFileDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripItemConsoleFileDelete.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolStripItemConsoleFileDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripItemConsoleFileDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripItemConsoleFileDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItemConsoleFileDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripItemConsoleFileDelete.Name = "ToolStripItemConsoleFileDelete";
            this.ToolStripItemConsoleFileDelete.Size = new System.Drawing.Size(71, 26);
            this.ToolStripItemConsoleFileDelete.Text = "Delete";
            this.ToolStripItemConsoleFileDelete.Click += new System.EventHandler(this.ToolStripItemConsoleFileDelete_Click);
            // 
            // ToolStripItemConsoleRefresh
            // 
            this.ToolStripItemConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripItemConsoleRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripItemConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripItemConsoleRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripItemConsoleRefresh.Image")));
            this.ToolStripItemConsoleRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripItemConsoleRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripItemConsoleRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItemConsoleRefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripItemConsoleRefresh.Name = "ToolStripItemConsoleRefresh";
            this.ToolStripItemConsoleRefresh.Size = new System.Drawing.Size(77, 26);
            this.ToolStripItemConsoleRefresh.Text = "Refresh";
            this.ToolStripItemConsoleRefresh.Click += new System.EventHandler(this.ToolStripConsoleFileRefresh_Click);
            // 
            // TextBoxConsoleDirectory
            // 
            this.TextBoxConsoleDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsoleDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsoleDirectory.Location = new System.Drawing.Point(7, 31);
            this.TextBoxConsoleDirectory.Name = "TextBoxConsoleDirectory";
            this.TextBoxConsoleDirectory.Size = new System.Drawing.Size(538, 23);
            this.TextBoxConsoleDirectory.TabIndex = 22;
            this.TextBoxConsoleDirectory.Text = "/";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SectionConsoleFileExplorer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SectionLocalFileExplorer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1201, 340);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColumnLocalType
            // 
            this.ColumnLocalType.HeaderText = "Type";
            this.ColumnLocalType.MinimumWidth = 6;
            this.ColumnLocalType.Name = "ColumnLocalType";
            this.ColumnLocalType.ReadOnly = true;
            this.ColumnLocalType.Visible = false;
            this.ColumnLocalType.Width = 125;
            // 
            // ColumnLocalIcon
            // 
            this.ColumnLocalIcon.HeaderText = "Icon";
            this.ColumnLocalIcon.MinimumWidth = 6;
            this.ColumnLocalIcon.Name = "ColumnLocalIcon";
            this.ColumnLocalIcon.ReadOnly = true;
            this.ColumnLocalIcon.Width = 28;
            // 
            // ColumnLocalName
            // 
            this.ColumnLocalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLocalName.HeaderText = "Name";
            this.ColumnLocalName.MinimumWidth = 6;
            this.ColumnLocalName.Name = "ColumnLocalName";
            this.ColumnLocalName.ReadOnly = true;
            // 
            // ColumnLocalSize
            // 
            this.ColumnLocalSize.HeaderText = "Size";
            this.ColumnLocalSize.MinimumWidth = 6;
            this.ColumnLocalSize.Name = "ColumnLocalSize";
            this.ColumnLocalSize.ReadOnly = true;
            this.ColumnLocalSize.Width = 115;
            // 
            // ColumnLocalExtension
            // 
            this.ColumnLocalExtension.HeaderText = "Ext";
            this.ColumnLocalExtension.MinimumWidth = 6;
            this.ColumnLocalExtension.Name = "ColumnLocalExtension";
            this.ColumnLocalExtension.ReadOnly = true;
            this.ColumnLocalExtension.Width = 90;
            // 
            // ColumnLocalDateTime
            // 
            this.ColumnLocalDateTime.HeaderText = "Last Modified";
            this.ColumnLocalDateTime.MinimumWidth = 6;
            this.ColumnLocalDateTime.Name = "ColumnLocalDateTime";
            this.ColumnLocalDateTime.ReadOnly = true;
            this.ColumnLocalDateTime.Width = 120;
            // 
            // ColumnConsoleFileType
            // 
            this.ColumnConsoleFileType.HeaderText = "Type";
            this.ColumnConsoleFileType.MinimumWidth = 6;
            this.ColumnConsoleFileType.Name = "ColumnConsoleFileType";
            this.ColumnConsoleFileType.ReadOnly = true;
            this.ColumnConsoleFileType.Visible = false;
            this.ColumnConsoleFileType.Width = 125;
            // 
            // ColumnConsoleFileImage
            // 
            this.ColumnConsoleFileImage.HeaderText = "Icon";
            this.ColumnConsoleFileImage.MinimumWidth = 6;
            this.ColumnConsoleFileImage.Name = "ColumnConsoleFileImage";
            this.ColumnConsoleFileImage.ReadOnly = true;
            this.ColumnConsoleFileImage.Width = 28;
            // 
            // ColumnConsoleFileName
            // 
            this.ColumnConsoleFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnConsoleFileName.HeaderText = "Name";
            this.ColumnConsoleFileName.MinimumWidth = 6;
            this.ColumnConsoleFileName.Name = "ColumnConsoleFileName";
            this.ColumnConsoleFileName.ReadOnly = true;
            // 
            // ColumnConsoleFileSize
            // 
            this.ColumnConsoleFileSize.HeaderText = "Size";
            this.ColumnConsoleFileSize.MinimumWidth = 6;
            this.ColumnConsoleFileSize.Name = "ColumnConsoleFileSize";
            this.ColumnConsoleFileSize.ReadOnly = true;
            this.ColumnConsoleFileSize.Width = 115;
            // 
            // ColumnConsoleFileExt
            // 
            this.ColumnConsoleFileExt.HeaderText = "Ext";
            this.ColumnConsoleFileExt.MinimumWidth = 6;
            this.ColumnConsoleFileExt.Name = "ColumnConsoleFileExt";
            this.ColumnConsoleFileExt.ReadOnly = true;
            this.ColumnConsoleFileExt.Width = 90;
            // 
            // ColumnConsoleLastModified
            // 
            this.ColumnConsoleLastModified.HeaderText = "Last Modified";
            this.ColumnConsoleLastModified.MinimumWidth = 6;
            this.ColumnConsoleLastModified.Name = "ColumnConsoleLastModified";
            this.ColumnConsoleLastModified.ReadOnly = true;
            this.ColumnConsoleLastModified.Width = 120;
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1226, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ToolStripFooter);
            this.Controls.Add(this.MenuStripHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripHeader;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FileExplorer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileExplorer_FormClosing);
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            this.ContextMenuConsoleFile.ResumeLayout(false);
            this.MenuStripHeader.ResumeLayout(false);
            this.MenuStripHeader.PerformLayout();
            this.ToolStripFooter.ResumeLayout(false);
            this.ToolStripFooter.PerformLayout();
            this.SectionLocalFileExplorer.ResumeLayout(false);
            this.SectionLocalFileExplorer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalFiles)).EndInit();
            this.ContextMenuLocalFile.ResumeLayout(false);
            this.ToolStripLocalFiles.ResumeLayout(false);
            this.ToolStripLocalFiles.PerformLayout();
            this.SectionConsoleFileExplorer.ResumeLayout(false);
            this.SectionConsoleFileExplorer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsoleFiles)).EndInit();
            this.darkToolStrip7.ResumeLayout(false);
            this.darkToolStrip7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkMenuStrip MenuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private DarkUI.Controls.DarkToolStrip ToolStripFooter;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private DarkUI.Controls.DarkSectionPanel SectionLocalFileExplorer;
        private DarkUI.Controls.DarkButton ButtonLocalDirectory;
        private DarkUI.Controls.DarkToolStrip ToolStripLocalFiles;
        private DarkUI.Controls.DarkTextBox TextBoxLocalDirectory;
        private DarkUI.Controls.DarkContextMenu ContextMenuConsoleFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleRefresh;
        private DarkUI.Controls.DarkContextMenu ContextMenuLocalFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripLocalUploadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripLocalDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpReportIssue;
        private System.Windows.Forms.ToolStripSeparator MenuStripHelpSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpAboutApp;
        private System.Windows.Forms.ToolStripButton ToolStripItemLocalUploadFile;
        private System.Windows.Forms.ToolStripButton ToolStripLocalDeleteFile;
        private System.Windows.Forms.ToolStripButton ToolStripItemLocalOpenExplorer;
        private DarkUI.Controls.DarkDataGridView DgvLocalFiles;
        private DarkUI.Controls.DarkSectionPanel SectionConsoleFileExplorer;
        private DarkUI.Controls.DarkButton ButtonConsoleExplorerNavigate;
        private DarkUI.Controls.DarkToolStrip darkToolStrip7;
        private System.Windows.Forms.ToolStripButton ToolStripItemConsoleFileDownload;
        private System.Windows.Forms.ToolStripButton ToolStripItemConsoleFileDelete;
        private System.Windows.Forms.ToolStripButton ToolStripItemConsoleRefresh;
        private DarkUI.Controls.DarkDataGridView DgvConsoleFiles;
        private DarkUI.Controls.DarkTextBox TextBoxConsoleDirectory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsSaveLocalDirectoryPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnLocalIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnConsoleFileImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleLastModified;
    }
}