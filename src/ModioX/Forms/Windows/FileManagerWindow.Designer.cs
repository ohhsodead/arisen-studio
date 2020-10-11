namespace ModioX.Forms.Windows
{
    partial class FileManagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagerWindow));
            this.ContextMenuConsoleFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuConsoleDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHeader = new DarkUI.Controls.DarkMenuStrip();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsSaveLocalDirectoryPath = new System.Windows.Forms.ToolStripMenuItem();
            this.SectionLocalFileExplorer = new DarkUI.Controls.DarkSectionPanel();
            this.ComboBoxLocalDrives = new DarkUI.Controls.DarkComboBox();
            this.ToolStripLocalActions = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLocalUpload = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalNewFolder = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalOpenExplorer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalStatus = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelLocalStatus = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxLocalDirectory = new DarkUI.Controls.DarkTextBox();
            this.ButtonLocalDirectory = new DarkUI.Controls.DarkButton();
            this.DgvLocalFiles = new DarkUI.Controls.DarkDataGridView();
            this.ColumnLocalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnLocalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuLocalFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuLocallUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalRename = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.SectionConsoleFileExplorer = new DarkUI.Controls.DarkSectionPanel();
            this.ComboBoxConsoleDrives = new DarkUI.Controls.DarkComboBox();
            this.ToolStripConsoleActions = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripConsoleDownload = new System.Windows.Forms.ToolStripButton();
            this.ToolStripConsoleDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripConsoleNewFolder = new System.Windows.Forms.ToolStripButton();
            this.ToolStripConsoleRefresh = new System.Windows.Forms.ToolStripButton();
            this.ToolStripConsoleStatus = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConsoleStatus = new System.Windows.Forms.ToolStripLabel();
            this.ButtonConsoleNavigate = new DarkUI.Controls.DarkButton();
            this.TextBoxConsoleDirectory = new DarkUI.Controls.DarkTextBox();
            this.DgvConsoleFiles = new DarkUI.Controls.DarkDataGridView();
            this.ColumnConsoleFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnConsoleFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleLastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WaitLoadConsole = new System.Windows.Forms.Timer(this.components);
            this.ContextMenuConsoleFile.SuspendLayout();
            this.MenuStripHeader.SuspendLayout();
            this.SectionLocalFileExplorer.SuspendLayout();
            this.ToolStripLocalActions.SuspendLayout();
            this.ToolStripLocalStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalFiles)).BeginInit();
            this.ContextMenuLocalFile.SuspendLayout();
            this.SectionConsoleFileExplorer.SuspendLayout();
            this.ToolStripConsoleActions.SuspendLayout();
            this.ToolStripConsoleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsoleFiles)).BeginInit();
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
            this.ContextMenuConsoleFile.Size = new System.Drawing.Size(129, 70);
            // 
            // ContextMenuConsoleDownloadFile
            // 
            this.ContextMenuConsoleDownloadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleDownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleDownloadFile.Name = "ContextMenuConsoleDownloadFile";
            this.ContextMenuConsoleDownloadFile.Size = new System.Drawing.Size(128, 22);
            this.ContextMenuConsoleDownloadFile.Text = "Download";
            this.ContextMenuConsoleDownloadFile.Click += new System.EventHandler(this.ContextMenuConsoleDownloadFile_Click);
            // 
            // ContextMenuConsoleDeleteFile
            // 
            this.ContextMenuConsoleDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleDeleteFile.Name = "ContextMenuConsoleDeleteFile";
            this.ContextMenuConsoleDeleteFile.Size = new System.Drawing.Size(128, 22);
            this.ContextMenuConsoleDeleteFile.Text = "Delete";
            this.ContextMenuConsoleDeleteFile.Click += new System.EventHandler(this.ContextMenuConsoleDeleteFile_Click);
            // 
            // ContextMenuConsoleRefresh
            // 
            this.ContextMenuConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleRefresh.Name = "ContextMenuConsoleRefresh";
            this.ContextMenuConsoleRefresh.Size = new System.Drawing.Size(128, 22);
            this.ContextMenuConsoleRefresh.Text = "Refresh";
            this.ContextMenuConsoleRefresh.Click += new System.EventHandler(this.ContextMenuConsoleRefresh_Click);
            // 
            // MenuStripHeader
            // 
            this.MenuStripHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettings});
            this.MenuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.MenuStripHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MenuStripHeader.Name = "MenuStripHeader";
            this.MenuStripHeader.Padding = new System.Windows.Forms.Padding(8, 9, 8, 0);
            this.MenuStripHeader.Size = new System.Drawing.Size(1117, 28);
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
            // SectionLocalFileExplorer
            // 
            this.SectionLocalFileExplorer.Controls.Add(this.ComboBoxLocalDrives);
            this.SectionLocalFileExplorer.Controls.Add(this.ToolStripLocalActions);
            this.SectionLocalFileExplorer.Controls.Add(this.ToolStripLocalStatus);
            this.SectionLocalFileExplorer.Controls.Add(this.TextBoxLocalDirectory);
            this.SectionLocalFileExplorer.Controls.Add(this.ButtonLocalDirectory);
            this.SectionLocalFileExplorer.Controls.Add(this.DgvLocalFiles);
            this.SectionLocalFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionLocalFileExplorer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionLocalFileExplorer.Location = new System.Drawing.Point(0, 0);
            this.SectionLocalFileExplorer.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.SectionLocalFileExplorer.Name = "SectionLocalFileExplorer";
            this.SectionLocalFileExplorer.SectionHeader = "LOCAL EXPLORER";
            this.SectionLocalFileExplorer.Size = new System.Drawing.Size(541, 415);
            this.SectionLocalFileExplorer.TabIndex = 17;
            // 
            // ComboBoxLocalDrives
            // 
            this.ComboBoxLocalDrives.FormattingEnabled = true;
            this.ComboBoxLocalDrives.Location = new System.Drawing.Point(7, 30);
            this.ComboBoxLocalDrives.Name = "ComboBoxLocalDrives";
            this.ComboBoxLocalDrives.Size = new System.Drawing.Size(42, 24);
            this.ComboBoxLocalDrives.TabIndex = 1148;
            this.ComboBoxLocalDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLocalDrives_SelectedIndexChanged);
            // 
            // ToolStripLocalActions
            // 
            this.ToolStripLocalActions.AutoSize = false;
            this.ToolStripLocalActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripLocalActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripLocalActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripLocalActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLocalUpload,
            this.ToolStripLocalDelete,
            this.ToolStripLocalNewFolder,
            this.ToolStripLocalOpenExplorer});
            this.ToolStripLocalActions.Location = new System.Drawing.Point(1, 348);
            this.ToolStripLocalActions.Name = "ToolStripLocalActions";
            this.ToolStripLocalActions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripLocalActions.Size = new System.Drawing.Size(539, 36);
            this.ToolStripLocalActions.TabIndex = 21;
            this.ToolStripLocalActions.TabStop = true;
            this.ToolStripLocalActions.Text = "darkToolStrip3";
            // 
            // ToolStripLocalUpload
            // 
            this.ToolStripLocalUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalUpload.Enabled = false;
            this.ToolStripLocalUpload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalUpload.Image = global::ModioX.Properties.Resources.icons8_upload_22;
            this.ToolStripLocalUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripLocalUpload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalUpload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripLocalUpload.Name = "ToolStripLocalUpload";
            this.ToolStripLocalUpload.Size = new System.Drawing.Size(72, 26);
            this.ToolStripLocalUpload.Text = "Upload";
            this.ToolStripLocalUpload.Click += new System.EventHandler(this.ToolStripLocalUploadFile_Click);
            // 
            // ToolStripLocalDelete
            // 
            this.ToolStripLocalDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalDelete.Enabled = false;
            this.ToolStripLocalDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalDelete.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolStripLocalDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripLocalDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripLocalDelete.Name = "ToolStripLocalDelete";
            this.ToolStripLocalDelete.Size = new System.Drawing.Size(71, 26);
            this.ToolStripLocalDelete.Text = "Delete";
            this.ToolStripLocalDelete.Click += new System.EventHandler(this.ToolStripLocalDeleteFile_Click);
            // 
            // ToolStripLocalNewFolder
            // 
            this.ToolStripLocalNewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalNewFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalNewFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalNewFolder.Image = global::ModioX.Properties.Resources.icons8_add_folder_22;
            this.ToolStripLocalNewFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripLocalNewFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalNewFolder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripLocalNewFolder.Name = "ToolStripLocalNewFolder";
            this.ToolStripLocalNewFolder.Size = new System.Drawing.Size(97, 26);
            this.ToolStripLocalNewFolder.Text = "New Folder";
            this.ToolStripLocalNewFolder.Click += new System.EventHandler(this.ToolStripLocalNewFolder_Click);
            // 
            // ToolStripLocalOpenExplorer
            // 
            this.ToolStripLocalOpenExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalOpenExplorer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalOpenExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalOpenExplorer.Image = global::ModioX.Properties.Resources.icons8_opened_folder_22;
            this.ToolStripLocalOpenExplorer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripLocalOpenExplorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalOpenExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalOpenExplorer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripLocalOpenExplorer.Name = "ToolStripLocalOpenExplorer";
            this.ToolStripLocalOpenExplorer.Size = new System.Drawing.Size(113, 26);
            this.ToolStripLocalOpenExplorer.Text = "Open Explorer";
            this.ToolStripLocalOpenExplorer.Click += new System.EventHandler(this.ToolStripLocalOpenExplorer_Click);
            // 
            // ToolStripLocalStatus
            // 
            this.ToolStripLocalStatus.AutoSize = false;
            this.ToolStripLocalStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripLocalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripLocalStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripLocalStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelLocalStatus});
            this.ToolStripLocalStatus.Location = new System.Drawing.Point(1, 384);
            this.ToolStripLocalStatus.Name = "ToolStripLocalStatus";
            this.ToolStripLocalStatus.Padding = new System.Windows.Forms.Padding(6, 0, 8, 5);
            this.ToolStripLocalStatus.Size = new System.Drawing.Size(539, 30);
            this.ToolStripLocalStatus.TabIndex = 1147;
            this.ToolStripLocalStatus.Text = "darkToolStrip1";
            // 
            // ToolStripLabelLocalStatus
            // 
            this.ToolStripLabelLocalStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelLocalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelLocalStatus.Name = "ToolStripLabelLocalStatus";
            this.ToolStripLabelLocalStatus.Size = new System.Drawing.Size(85, 22);
            this.ToolStripLabelLocalStatus.Text = "Loading data...";
            this.ToolStripLabelLocalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxLocalDirectory
            // 
            this.TextBoxLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalDirectory.Location = new System.Drawing.Point(55, 31);
            this.TextBoxLocalDirectory.Name = "TextBoxLocalDirectory";
            this.TextBoxLocalDirectory.ReadOnly = true;
            this.TextBoxLocalDirectory.Size = new System.Drawing.Size(430, 23);
            this.TextBoxLocalDirectory.TabIndex = 18;
            this.TextBoxLocalDirectory.Text = "\\";
            // 
            // ButtonLocalDirectory
            // 
            this.ButtonLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalDirectory.Location = new System.Drawing.Point(491, 31);
            this.ButtonLocalDirectory.Name = "ButtonLocalDirectory";
            this.ButtonLocalDirectory.Size = new System.Drawing.Size(43, 23);
            this.ButtonLocalDirectory.TabIndex = 19;
            this.ButtonLocalDirectory.Text = "...";
            this.ButtonLocalDirectory.Click += new System.EventHandler(this.ButtonLocalDirectory_Click);
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
            this.DgvLocalFiles.ColumnHeadersHeight = 19;
            this.DgvLocalFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLocalType,
            this.ColumnLocalIcon,
            this.ColumnLocalName,
            this.ColumnLocalSize,
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
            this.DgvLocalFiles.Size = new System.Drawing.Size(527, 288);
            this.DgvLocalFiles.TabIndex = 20;
            this.DgvLocalFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLocalFiles_CellClick);
            this.DgvLocalFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLocalFiles_CellDoubleClick);
            this.DgvLocalFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvLocalFiles.SelectionChanged += new System.EventHandler(this.DgvLocalFiles_SelectionChanged);
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
            this.ColumnLocalIcon.HeaderText = "";
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
            this.ColumnLocalName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnLocalSize
            // 
            this.ColumnLocalSize.HeaderText = "Size";
            this.ColumnLocalSize.MinimumWidth = 6;
            this.ColumnLocalSize.Name = "ColumnLocalSize";
            this.ColumnLocalSize.ReadOnly = true;
            this.ColumnLocalSize.Width = 115;
            // 
            // ColumnLocalDateTime
            // 
            this.ColumnLocalDateTime.HeaderText = "Last Modified";
            this.ColumnLocalDateTime.MinimumWidth = 6;
            this.ColumnLocalDateTime.Name = "ColumnLocalDateTime";
            this.ColumnLocalDateTime.ReadOnly = true;
            this.ColumnLocalDateTime.Width = 120;
            // 
            // ContextMenuLocalFile
            // 
            this.ContextMenuLocalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuLocalFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuLocallUploadFile,
            this.ContextMenuLocalDeleteFile,
            this.ContextMenuLocalRename,
            this.ContextMenuLocalRefresh});
            this.ContextMenuLocalFile.Name = "ContextMenuConsole";
            this.ContextMenuLocalFile.Size = new System.Drawing.Size(118, 92);
            // 
            // ContextMenuLocallUploadFile
            // 
            this.ContextMenuLocallUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocallUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocallUploadFile.Name = "ContextMenuLocallUploadFile";
            this.ContextMenuLocallUploadFile.Size = new System.Drawing.Size(117, 22);
            this.ContextMenuLocallUploadFile.Text = "Upload";
            this.ContextMenuLocallUploadFile.Click += new System.EventHandler(this.ContextMenuLocalFileUpload_Click);
            // 
            // ContextMenuLocalDeleteFile
            // 
            this.ContextMenuLocalDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalDeleteFile.Name = "ContextMenuLocalDeleteFile";
            this.ContextMenuLocalDeleteFile.Size = new System.Drawing.Size(117, 22);
            this.ContextMenuLocalDeleteFile.Text = "Delete";
            this.ContextMenuLocalDeleteFile.Click += new System.EventHandler(this.ContextMenuLocalDeleteFile_Click);
            // 
            // ContextMenuLocalRename
            // 
            this.ContextMenuLocalRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalRename.Name = "ContextMenuLocalRename";
            this.ContextMenuLocalRename.Size = new System.Drawing.Size(117, 22);
            this.ContextMenuLocalRename.Text = "Rename";
            this.ContextMenuLocalRename.Click += new System.EventHandler(this.ContextMenuLocalRename_Click);
            // 
            // ContextMenuLocalRefresh
            // 
            this.ContextMenuLocalRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalRefresh.Name = "ContextMenuLocalRefresh";
            this.ContextMenuLocalRefresh.Size = new System.Drawing.Size(117, 22);
            this.ContextMenuLocalRefresh.Text = "Refresh";
            this.ContextMenuLocalRefresh.Click += new System.EventHandler(this.ContextMenuLocalRefresh_Click);
            // 
            // SectionConsoleFileExplorer
            // 
            this.SectionConsoleFileExplorer.Controls.Add(this.ComboBoxConsoleDrives);
            this.SectionConsoleFileExplorer.Controls.Add(this.ToolStripConsoleActions);
            this.SectionConsoleFileExplorer.Controls.Add(this.ToolStripConsoleStatus);
            this.SectionConsoleFileExplorer.Controls.Add(this.ButtonConsoleNavigate);
            this.SectionConsoleFileExplorer.Controls.Add(this.TextBoxConsoleDirectory);
            this.SectionConsoleFileExplorer.Controls.Add(this.DgvConsoleFiles);
            this.SectionConsoleFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionConsoleFileExplorer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionConsoleFileExplorer.Location = new System.Drawing.Point(551, 0);
            this.SectionConsoleFileExplorer.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SectionConsoleFileExplorer.Name = "SectionConsoleFileExplorer";
            this.SectionConsoleFileExplorer.SectionHeader = "CONSOLE EXPLORER";
            this.SectionConsoleFileExplorer.Size = new System.Drawing.Size(541, 415);
            this.SectionConsoleFileExplorer.TabIndex = 1157;
            // 
            // ComboBoxConsoleDrives
            // 
            this.ComboBoxConsoleDrives.FormattingEnabled = true;
            this.ComboBoxConsoleDrives.Location = new System.Drawing.Point(7, 30);
            this.ComboBoxConsoleDrives.Name = "ComboBoxConsoleDrives";
            this.ComboBoxConsoleDrives.Size = new System.Drawing.Size(88, 24);
            this.ComboBoxConsoleDrives.TabIndex = 1149;
            this.ComboBoxConsoleDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoleDrives_SelectedIndexChanged);
            // 
            // ToolStripConsoleActions
            // 
            this.ToolStripConsoleActions.AutoSize = false;
            this.ToolStripConsoleActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripConsoleActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripConsoleActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripConsoleActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripConsoleDownload,
            this.ToolStripConsoleDelete,
            this.ToolStripConsoleNewFolder,
            this.ToolStripConsoleRefresh});
            this.ToolStripConsoleActions.Location = new System.Drawing.Point(1, 348);
            this.ToolStripConsoleActions.Name = "ToolStripConsoleActions";
            this.ToolStripConsoleActions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripConsoleActions.Size = new System.Drawing.Size(539, 36);
            this.ToolStripConsoleActions.TabIndex = 25;
            this.ToolStripConsoleActions.TabStop = true;
            this.ToolStripConsoleActions.Text = "darkToolStrip4";
            // 
            // ToolStripConsoleDownload
            // 
            this.ToolStripConsoleDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleDownload.Enabled = false;
            this.ToolStripConsoleDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleDownload.Image = global::ModioX.Properties.Resources.icons8_download_22;
            this.ToolStripConsoleDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripConsoleDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleDownload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripConsoleDownload.Name = "ToolStripConsoleDownload";
            this.ToolStripConsoleDownload.Size = new System.Drawing.Size(89, 26);
            this.ToolStripConsoleDownload.Text = "Download";
            this.ToolStripConsoleDownload.Click += new System.EventHandler(this.ToolStripConsoleDownload_Click);
            // 
            // ToolStripConsoleDelete
            // 
            this.ToolStripConsoleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleDelete.Enabled = false;
            this.ToolStripConsoleDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleDelete.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolStripConsoleDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripConsoleDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripConsoleDelete.Name = "ToolStripConsoleDelete";
            this.ToolStripConsoleDelete.Size = new System.Drawing.Size(71, 26);
            this.ToolStripConsoleDelete.Text = "Delete";
            this.ToolStripConsoleDelete.Click += new System.EventHandler(this.ToolStripConsoleDelete_Click);
            // 
            // ToolStripConsoleNewFolder
            // 
            this.ToolStripConsoleNewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleNewFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleNewFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleNewFolder.Image = global::ModioX.Properties.Resources.icons8_add_folder_22;
            this.ToolStripConsoleNewFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripConsoleNewFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleNewFolder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripConsoleNewFolder.Name = "ToolStripConsoleNewFolder";
            this.ToolStripConsoleNewFolder.Size = new System.Drawing.Size(97, 26);
            this.ToolStripConsoleNewFolder.Text = "New Folder";
            this.ToolStripConsoleNewFolder.Click += new System.EventHandler(this.ToolStripConsoleNewFolder_Click);
            // 
            // ToolStripConsoleRefresh
            // 
            this.ToolStripConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripConsoleRefresh.Image")));
            this.ToolStripConsoleRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripConsoleRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleRefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripConsoleRefresh.Name = "ToolStripConsoleRefresh";
            this.ToolStripConsoleRefresh.Size = new System.Drawing.Size(77, 26);
            this.ToolStripConsoleRefresh.Text = "Refresh";
            this.ToolStripConsoleRefresh.Click += new System.EventHandler(this.ToolStripConsoleFileRefresh_Click);
            // 
            // ToolStripConsoleStatus
            // 
            this.ToolStripConsoleStatus.AutoSize = false;
            this.ToolStripConsoleStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripConsoleStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripConsoleStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripConsoleStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelConsoleStatus});
            this.ToolStripConsoleStatus.Location = new System.Drawing.Point(1, 384);
            this.ToolStripConsoleStatus.Name = "ToolStripConsoleStatus";
            this.ToolStripConsoleStatus.Padding = new System.Windows.Forms.Padding(6, 0, 8, 5);
            this.ToolStripConsoleStatus.Size = new System.Drawing.Size(539, 30);
            this.ToolStripConsoleStatus.TabIndex = 1147;
            this.ToolStripConsoleStatus.Text = "darkToolStrip1";
            // 
            // ToolStripLabelConsoleStatus
            // 
            this.ToolStripLabelConsoleStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConsoleStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsoleStatus.Name = "ToolStripLabelConsoleStatus";
            this.ToolStripLabelConsoleStatus.Size = new System.Drawing.Size(85, 22);
            this.ToolStripLabelConsoleStatus.Text = "Loading data...";
            this.ToolStripLabelConsoleStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonConsoleNavigate
            // 
            this.ButtonConsoleNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConsoleNavigate.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonConsoleNavigate.Location = new System.Drawing.Point(496, 31);
            this.ButtonConsoleNavigate.Name = "ButtonConsoleNavigate";
            this.ButtonConsoleNavigate.Size = new System.Drawing.Size(39, 23);
            this.ButtonConsoleNavigate.TabIndex = 23;
            this.ButtonConsoleNavigate.Text = ">";
            this.ButtonConsoleNavigate.Click += new System.EventHandler(this.ButtonConsoleNavigate_Click);
            // 
            // TextBoxConsoleDirectory
            // 
            this.TextBoxConsoleDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsoleDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsoleDirectory.Location = new System.Drawing.Point(101, 31);
            this.TextBoxConsoleDirectory.Name = "TextBoxConsoleDirectory";
            this.TextBoxConsoleDirectory.Size = new System.Drawing.Size(389, 23);
            this.TextBoxConsoleDirectory.TabIndex = 22;
            this.TextBoxConsoleDirectory.Text = "/";
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
            this.DgvConsoleFiles.ColumnHeadersHeight = 19;
            this.DgvConsoleFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConsoleFileType,
            this.ColumnConsoleFileImage,
            this.ColumnConsoleFileName,
            this.ColumnConsoleFileSize,
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
            this.DgvConsoleFiles.Size = new System.Drawing.Size(528, 288);
            this.DgvConsoleFiles.TabIndex = 24;
            this.DgvConsoleFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsoleFiles_CellClick);
            this.DgvConsoleFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsoleFiles_CellDoubleClick);
            this.DgvConsoleFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvConsoleFiles.SelectionChanged += new System.EventHandler(this.DgvConsoleFiles_SelectionChanged);
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
            this.ColumnConsoleFileImage.HeaderText = "";
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
            this.ColumnConsoleFileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnConsoleFileSize
            // 
            this.ColumnConsoleFileSize.HeaderText = "Size";
            this.ColumnConsoleFileSize.MinimumWidth = 6;
            this.ColumnConsoleFileSize.Name = "ColumnConsoleFileSize";
            this.ColumnConsoleFileSize.ReadOnly = true;
            this.ColumnConsoleFileSize.Width = 115;
            // 
            // ColumnConsoleLastModified
            // 
            this.ColumnConsoleLastModified.HeaderText = "Last Modified";
            this.ColumnConsoleLastModified.MinimumWidth = 6;
            this.ColumnConsoleLastModified.Name = "ColumnConsoleLastModified";
            this.ColumnConsoleLastModified.ReadOnly = true;
            this.ColumnConsoleLastModified.Width = 120;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 415);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // WaitLoadConsole
            // 
            this.WaitLoadConsole.Enabled = true;
            this.WaitLoadConsole.Tick += new System.EventHandler(this.WaitLoadConsole_Tick);
            // 
            // FileManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1117, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuStripHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripHeader;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FileManagerWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileExplorer_FormClosing);
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            this.ContextMenuConsoleFile.ResumeLayout(false);
            this.MenuStripHeader.ResumeLayout(false);
            this.MenuStripHeader.PerformLayout();
            this.SectionLocalFileExplorer.ResumeLayout(false);
            this.SectionLocalFileExplorer.PerformLayout();
            this.ToolStripLocalActions.ResumeLayout(false);
            this.ToolStripLocalActions.PerformLayout();
            this.ToolStripLocalStatus.ResumeLayout(false);
            this.ToolStripLocalStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalFiles)).EndInit();
            this.ContextMenuLocalFile.ResumeLayout(false);
            this.SectionConsoleFileExplorer.ResumeLayout(false);
            this.SectionConsoleFileExplorer.PerformLayout();
            this.ToolStripConsoleActions.ResumeLayout(false);
            this.ToolStripConsoleActions.PerformLayout();
            this.ToolStripConsoleStatus.ResumeLayout(false);
            this.ToolStripConsoleStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsoleFiles)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkMenuStrip MenuStripHeader;
        private DarkUI.Controls.DarkSectionPanel SectionLocalFileExplorer;
        private DarkUI.Controls.DarkButton ButtonLocalDirectory;
        private DarkUI.Controls.DarkToolStrip ToolStripLocalActions;
        private DarkUI.Controls.DarkTextBox TextBoxLocalDirectory;
        private DarkUI.Controls.DarkContextMenu ContextMenuConsoleFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleRefresh;
        private DarkUI.Controls.DarkContextMenu ContextMenuLocalFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocallUploadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalDeleteFile;
        private System.Windows.Forms.ToolStripButton ToolStripLocalUpload;
        private System.Windows.Forms.ToolStripButton ToolStripLocalDelete;
        private System.Windows.Forms.ToolStripButton ToolStripLocalOpenExplorer;
        private DarkUI.Controls.DarkDataGridView DgvLocalFiles;
        private DarkUI.Controls.DarkSectionPanel SectionConsoleFileExplorer;
        private DarkUI.Controls.DarkButton ButtonConsoleNavigate;
        private DarkUI.Controls.DarkToolStrip ToolStripConsoleActions;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleDownload;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleDelete;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleRefresh;
        private DarkUI.Controls.DarkDataGridView DgvConsoleFiles;
        private DarkUI.Controls.DarkTextBox TextBoxConsoleDirectory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsSaveLocalDirectoryPath;
        private System.Windows.Forms.Timer WaitLoadConsole;
        private DarkUI.Controls.DarkToolStrip ToolStripLocalStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelLocalStatus;
        private DarkUI.Controls.DarkToolStrip ToolStripConsoleStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsoleStatus;
        private System.Windows.Forms.ToolStripButton ToolStripLocalNewFolder;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleNewFolder;
        private DarkUI.Controls.DarkComboBox ComboBoxLocalDrives;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnLocalIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnConsoleFileImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleLastModified;
        private DarkUI.Controls.DarkComboBox ComboBoxConsoleDrives;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalRename;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalRefresh;
    }
}