namespace ModioX.Forms.Tools.XBOX_Tools
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
            this.ContextMenuConsole = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuItemConsoleDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemConsoleDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemConsoleRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuItemConsoleRenameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemConsoleRenameFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.GridLocalFiles = new DevExpress.XtraGrid.GridControl();
            this.ContextMenuLocal = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuLocallUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuLocalRenameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalRenameFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.GridViewLocalFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnLocalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnLocalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridConsoleFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewConsoleFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnConsoleFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnConsoleFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleLastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BarDockConsoleFiles = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BarDockLocalFiles = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.ButtonConsoleNavigate = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxConsolePath = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxConsoleDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ButtonBrowseLocalDirectory = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxLocalDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxLocalPath = new DevExpress.XtraEditors.TextEdit();
            this.WaitLoadConsole = new System.Windows.Forms.Timer(this.components);
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.ButtonLocalUploadFile = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonLocalDeleteFile = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonLocalNewFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonLocalRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonLocalOpenExplorer = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.ButtonConsoleDownloadFile = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonConsoleDeleteFile = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonConsoleNewFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonConsoleRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barManager4 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl11 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl12 = new DevExpress.XtraBars.BarDockControl();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarHeaderItem();
            this.ContextMenuConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocalFiles)).BeginInit();
            this.ContextMenuLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocalFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsoleFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsoleFiles)).BeginInit();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxLocalDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager4)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuConsole
            // 
            this.ContextMenuConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsole.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ContextMenuConsole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemConsoleDownloadFile,
            this.ContextMenuItemConsoleDeleteFile,
            this.ContextMenuItemConsoleRefresh,
            this.ContextMenuConsoleSeparator,
            this.ContextMenuItemConsoleRenameFile,
            this.ContextMenuItemConsoleRenameFolder});
            this.ContextMenuConsole.Name = "ContextMenuConsole";
            this.ContextMenuConsole.Size = new System.Drawing.Size(156, 131);
            // 
            // ContextMenuItemConsoleDownloadFile
            // 
            this.ContextMenuItemConsoleDownloadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuItemConsoleDownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuItemConsoleDownloadFile.Image = global::ModioX.Properties.Resources.download;
            this.ContextMenuItemConsoleDownloadFile.Name = "ContextMenuItemConsoleDownloadFile";
            this.ContextMenuItemConsoleDownloadFile.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuItemConsoleDownloadFile.Text = "Download";
            this.ContextMenuItemConsoleDownloadFile.Click += new System.EventHandler(this.ContextMenuConsoleDownloadFile_Click);
            // 
            // ContextMenuItemConsoleDeleteFile
            // 
            this.ContextMenuItemConsoleDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuItemConsoleDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuItemConsoleDeleteFile.Image = global::ModioX.Properties.Resources.delete;
            this.ContextMenuItemConsoleDeleteFile.Name = "ContextMenuItemConsoleDeleteFile";
            this.ContextMenuItemConsoleDeleteFile.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuItemConsoleDeleteFile.Text = "Delete";
            this.ContextMenuItemConsoleDeleteFile.Click += new System.EventHandler(this.ContextMenuConsoleDeleteFile_Click);
            // 
            // ContextMenuItemConsoleRefresh
            // 
            this.ContextMenuItemConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuItemConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuItemConsoleRefresh.Image = global::ModioX.Properties.Resources.refresh;
            this.ContextMenuItemConsoleRefresh.Name = "ContextMenuItemConsoleRefresh";
            this.ContextMenuItemConsoleRefresh.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuItemConsoleRefresh.Text = "Refresh";
            this.ContextMenuItemConsoleRefresh.Click += new System.EventHandler(this.ContextMenuConsoleRefresh_Click);
            // 
            // ContextMenuConsoleSeparator
            // 
            this.ContextMenuConsoleSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleSeparator.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuConsoleSeparator.Name = "ContextMenuConsoleSeparator";
            this.ContextMenuConsoleSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // ContextMenuItemConsoleRenameFile
            // 
            this.ContextMenuItemConsoleRenameFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuItemConsoleRenameFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuItemConsoleRenameFile.Image = global::ModioX.Properties.Resources.rename;
            this.ContextMenuItemConsoleRenameFile.Name = "ContextMenuItemConsoleRenameFile";
            this.ContextMenuItemConsoleRenameFile.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuItemConsoleRenameFile.Text = "Rename File";
            this.ContextMenuItemConsoleRenameFile.Click += new System.EventHandler(this.ContextMenuItemConsoleRenameFile_Click);
            // 
            // ContextMenuItemConsoleRenameFolder
            // 
            this.ContextMenuItemConsoleRenameFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuItemConsoleRenameFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuItemConsoleRenameFolder.Image = global::ModioX.Properties.Resources.rename;
            this.ContextMenuItemConsoleRenameFolder.Name = "ContextMenuItemConsoleRenameFolder";
            this.ContextMenuItemConsoleRenameFolder.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuItemConsoleRenameFolder.Text = "Rename Folder";
            this.ContextMenuItemConsoleRenameFolder.Click += new System.EventHandler(this.ContextMenuItemConsoleRenameFolder_Click);
            // 
            // GridLocalFiles
            // 
            this.GridLocalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLocalFiles.ContextMenuStrip = this.ContextMenuLocal;
            this.GridLocalFiles.Location = new System.Drawing.Point(11, 60);
            this.GridLocalFiles.MainView = this.GridViewLocalFiles;
            this.GridLocalFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.GridLocalFiles.Name = "GridLocalFiles";
            this.GridLocalFiles.Size = new System.Drawing.Size(623, 402);
            this.GridLocalFiles.TabIndex = 20;
            this.GridLocalFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewLocalFiles});
            // 
            // ContextMenuLocal
            // 
            this.ContextMenuLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocal.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ContextMenuLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuLocallUploadFile,
            this.ContextMenuLocalDeleteFile,
            this.ContextMenuLocalRefresh,
            this.ContextMenuLocalSeparator,
            this.ContextMenuLocalRenameFile,
            this.ContextMenuLocalRenameFolder});
            this.ContextMenuLocal.Name = "ContextMenuConsole";
            this.ContextMenuLocal.Size = new System.Drawing.Size(156, 131);
            // 
            // ContextMenuLocallUploadFile
            // 
            this.ContextMenuLocallUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocallUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocallUploadFile.Image = global::ModioX.Properties.Resources.upload;
            this.ContextMenuLocallUploadFile.Name = "ContextMenuLocallUploadFile";
            this.ContextMenuLocallUploadFile.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuLocallUploadFile.Text = "Upload";
            this.ContextMenuLocallUploadFile.Click += new System.EventHandler(this.ContextMenuLocalFileUpload_Click);
            // 
            // ContextMenuLocalDeleteFile
            // 
            this.ContextMenuLocalDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalDeleteFile.Image = global::ModioX.Properties.Resources.delete;
            this.ContextMenuLocalDeleteFile.Name = "ContextMenuLocalDeleteFile";
            this.ContextMenuLocalDeleteFile.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuLocalDeleteFile.Text = "Delete";
            this.ContextMenuLocalDeleteFile.Click += new System.EventHandler(this.ContextMenuLocalDeleteFile_Click);
            // 
            // ContextMenuLocalRefresh
            // 
            this.ContextMenuLocalRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalRefresh.Image = global::ModioX.Properties.Resources.refresh;
            this.ContextMenuLocalRefresh.Name = "ContextMenuLocalRefresh";
            this.ContextMenuLocalRefresh.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuLocalRefresh.Text = "Refresh";
            this.ContextMenuLocalRefresh.Click += new System.EventHandler(this.ContextMenuLocalRefresh_Click);
            // 
            // ContextMenuLocalSeparator
            // 
            this.ContextMenuLocalSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalSeparator.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuLocalSeparator.Name = "ContextMenuLocalSeparator";
            this.ContextMenuLocalSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // ContextMenuLocalRenameFile
            // 
            this.ContextMenuLocalRenameFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalRenameFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalRenameFile.Image = global::ModioX.Properties.Resources.rename;
            this.ContextMenuLocalRenameFile.Name = "ContextMenuLocalRenameFile";
            this.ContextMenuLocalRenameFile.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuLocalRenameFile.Text = "Rename File";
            this.ContextMenuLocalRenameFile.Click += new System.EventHandler(this.ContextMenuLocalRenameFile_Click);
            // 
            // ContextMenuLocalRenameFolder
            // 
            this.ContextMenuLocalRenameFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuLocalRenameFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuLocalRenameFolder.Image = global::ModioX.Properties.Resources.rename;
            this.ContextMenuLocalRenameFolder.Name = "ContextMenuLocalRenameFolder";
            this.ContextMenuLocalRenameFolder.Size = new System.Drawing.Size(155, 24);
            this.ContextMenuLocalRenameFolder.Text = "Rename Folder";
            this.ContextMenuLocalRenameFolder.Click += new System.EventHandler(this.ContextMenuLocalRenameFolder_Click);
            // 
            // GridViewLocalFiles
            // 
            this.GridViewLocalFiles.GridControl = this.GridLocalFiles;
            this.GridViewLocalFiles.Name = "GridViewLocalFiles";
            this.GridViewLocalFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewLocalFiles.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewLocalFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewLocalFiles.OptionsView.ShowIndicator = false;
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
            // GridConsoleFiles
            // 
            this.GridConsoleFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridConsoleFiles.ContextMenuStrip = this.ContextMenuConsole;
            this.GridConsoleFiles.Location = new System.Drawing.Point(11, 60);
            this.GridConsoleFiles.MainView = this.GridViewConsoleFiles;
            this.GridConsoleFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.GridConsoleFiles.Name = "GridConsoleFiles";
            this.GridConsoleFiles.Size = new System.Drawing.Size(623, 402);
            this.GridConsoleFiles.TabIndex = 24;
            this.GridConsoleFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewConsoleFiles});
            // 
            // GridViewConsoleFiles
            // 
            this.GridViewConsoleFiles.GridControl = this.GridConsoleFiles;
            this.GridViewConsoleFiles.Name = "GridViewConsoleFiles";
            this.GridViewConsoleFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewConsoleFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewConsoleFiles.OptionsView.ShowIndicator = false;
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
            // LayoutPanel
            // 
            this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanel.ColumnCount = 2;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.Controls.Add(this.groupControl2, 1, 0);
            this.LayoutPanel.Controls.Add(this.groupControl1, 0, 0);
            this.LayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.LayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.Size = new System.Drawing.Size(1300, 496);
            this.LayoutPanel.TabIndex = 12;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BarDockConsoleFiles);
            this.groupControl2.Controls.Add(this.ButtonConsoleNavigate);
            this.groupControl2.Controls.Add(this.TextBoxConsolePath);
            this.groupControl2.Controls.Add(this.ComboBoxConsoleDrives);
            this.groupControl2.Controls.Add(this.GridConsoleFiles);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(653, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(644, 490);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "CONSOLE FILE EXPLORER";
            // 
            // BarDockConsoleFiles
            // 
            this.BarDockConsoleFiles.CausesValidation = false;
            this.BarDockConsoleFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockConsoleFiles.Location = new System.Drawing.Point(2, 465);
            this.BarDockConsoleFiles.Manager = this.barManager1;
            this.BarDockConsoleFiles.Name = "BarDockConsoleFiles";
            this.BarDockConsoleFiles.Size = new System.Drawing.Size(640, 23);
            this.BarDockConsoleFiles.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.BarDockLocalFiles);
            this.barManager1.DockControls.Add(this.BarDockConsoleFiles);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1326, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // BarDockLocalFiles
            // 
            this.BarDockLocalFiles.CausesValidation = false;
            this.BarDockLocalFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockLocalFiles.Location = new System.Drawing.Point(2, 465);
            this.BarDockLocalFiles.Manager = this.barManager1;
            this.BarDockLocalFiles.Name = "BarDockLocalFiles";
            this.BarDockLocalFiles.Size = new System.Drawing.Size(640, 23);
            this.BarDockLocalFiles.Text = "standaloneBarDockControl1";
            // 
            // ButtonConsoleNavigate
            // 
            this.ButtonConsoleNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConsoleNavigate.Location = new System.Drawing.Point(594, 32);
            this.ButtonConsoleNavigate.Name = "ButtonConsoleNavigate";
            this.ButtonConsoleNavigate.Size = new System.Drawing.Size(40, 22);
            this.ButtonConsoleNavigate.TabIndex = 1173;
            this.ButtonConsoleNavigate.Text = ">>";
            this.ButtonConsoleNavigate.Click += new System.EventHandler(this.ButtonConsoleNavigate_Click);
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsolePath.Location = new System.Drawing.Point(113, 32);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.Properties.AllowFocused = false;
            this.TextBoxConsolePath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsolePath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConsolePath.Size = new System.Drawing.Size(475, 22);
            this.TextBoxConsolePath.TabIndex = 1171;
            // 
            // ComboBoxConsoleDrives
            // 
            this.ComboBoxConsoleDrives.Location = new System.Drawing.Point(11, 32);
            this.ComboBoxConsoleDrives.Name = "ComboBoxConsoleDrives";
            this.ComboBoxConsoleDrives.Properties.AllowFocused = false;
            this.ComboBoxConsoleDrives.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxConsoleDrives.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxConsoleDrives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxConsoleDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxConsoleDrives.Size = new System.Drawing.Size(96, 22);
            this.ComboBoxConsoleDrives.TabIndex = 0;
            this.ComboBoxConsoleDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoleDrives_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BarDockLocalFiles);
            this.groupControl1.Controls.Add(this.ButtonBrowseLocalDirectory);
            this.groupControl1.Controls.Add(this.ComboBoxLocalDrives);
            this.groupControl1.Controls.Add(this.TextBoxLocalPath);
            this.groupControl1.Controls.Add(this.GridLocalFiles);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(644, 490);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "LOCAL FILE EXPLORER";
            // 
            // ButtonBrowseLocalDirectory
            // 
            this.ButtonBrowseLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseLocalDirectory.Location = new System.Drawing.Point(594, 32);
            this.ButtonBrowseLocalDirectory.Name = "ButtonBrowseLocalDirectory";
            this.ButtonBrowseLocalDirectory.Size = new System.Drawing.Size(40, 22);
            this.ButtonBrowseLocalDirectory.TabIndex = 1172;
            this.ButtonBrowseLocalDirectory.Text = "...";
            this.ButtonBrowseLocalDirectory.Click += new System.EventHandler(this.ButtonBrowseLocalDirectory_Click);
            // 
            // ComboBoxLocalDrives
            // 
            this.ComboBoxLocalDrives.Location = new System.Drawing.Point(11, 32);
            this.ComboBoxLocalDrives.Name = "ComboBoxLocalDrives";
            this.ComboBoxLocalDrives.Properties.AllowFocused = false;
            this.ComboBoxLocalDrives.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxLocalDrives.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxLocalDrives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxLocalDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxLocalDrives.Size = new System.Drawing.Size(42, 22);
            this.ComboBoxLocalDrives.TabIndex = 1165;
            this.ComboBoxLocalDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLocalDrives_SelectedIndexChanged);
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalPath.Location = new System.Drawing.Point(59, 32);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Properties.AllowFocused = false;
            this.TextBoxLocalPath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxLocalPath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxLocalPath.Size = new System.Drawing.Size(529, 22);
            this.TextBoxLocalPath.TabIndex = 1170;
            // 
            // WaitLoadConsole
            // 
            this.WaitLoadConsole.Enabled = true;
            this.WaitLoadConsole.Tick += new System.EventHandler(this.WaitLoadConsole_Tick);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ButtonLocalUploadFile,
            this.ButtonLocalDeleteFile,
            this.ButtonLocalNewFolder,
            this.ButtonLocalRefresh,
            this.ButtonLocalOpenExplorer});
            this.barManager2.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarItemVertIndent = 5;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonLocalUploadFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonLocalDeleteFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonLocalNewFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonLocalRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonLocalOpenExplorer)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.StandaloneBarDockControl = this.BarDockLocalFiles;
            this.bar1.Text = "Tools";
            // 
            // ButtonLocalUploadFile
            // 
            this.ButtonLocalUploadFile.Caption = "Upload";
            this.ButtonLocalUploadFile.Id = 0;
            this.ButtonLocalUploadFile.Name = "ButtonLocalUploadFile";
            this.ButtonLocalUploadFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonLocalUploadFile_ItemClick);
            // 
            // ButtonLocalDeleteFile
            // 
            this.ButtonLocalDeleteFile.Caption = "Delete";
            this.ButtonLocalDeleteFile.Id = 1;
            this.ButtonLocalDeleteFile.Name = "ButtonLocalDeleteFile";
            this.ButtonLocalDeleteFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonLocalDeleteFile_ItemClick);
            // 
            // ButtonLocalNewFolder
            // 
            this.ButtonLocalNewFolder.Caption = "New Folder";
            this.ButtonLocalNewFolder.Id = 2;
            this.ButtonLocalNewFolder.Name = "ButtonLocalNewFolder";
            this.ButtonLocalNewFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonLocalNewFolder_ItemClick);
            // 
            // ButtonLocalRefresh
            // 
            this.ButtonLocalRefresh.Caption = "Refresh";
            this.ButtonLocalRefresh.Id = 3;
            this.ButtonLocalRefresh.Name = "ButtonLocalRefresh";
            // 
            // ButtonLocalOpenExplorer
            // 
            this.ButtonLocalOpenExplorer.Caption = "Open Explorer";
            this.ButtonLocalOpenExplorer.Id = 4;
            this.ButtonLocalOpenExplorer.Name = "ButtonLocalOpenExplorer";
            this.ButtonLocalOpenExplorer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonLocalOpenExplorer_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 521);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1326, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 521);
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager3.DockControls.Add(this.barDockControl5);
            this.barManager3.DockControls.Add(this.barDockControl6);
            this.barManager3.DockControls.Add(this.barDockControl7);
            this.barManager3.DockControls.Add(this.barDockControl8);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ButtonConsoleDownloadFile,
            this.ButtonConsoleDeleteFile,
            this.ButtonConsoleNewFolder,
            this.ButtonConsoleRefresh});
            this.barManager3.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarItemVertIndent = 5;
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConsoleDownloadFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConsoleDeleteFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConsoleNewFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConsoleRefresh)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.StandaloneBarDockControl = this.BarDockConsoleFiles;
            this.bar2.Text = "Tools";
            // 
            // ButtonConsoleDownloadFile
            // 
            this.ButtonConsoleDownloadFile.Caption = "Download";
            this.ButtonConsoleDownloadFile.Id = 0;
            this.ButtonConsoleDownloadFile.Name = "ButtonConsoleDownloadFile";
            this.ButtonConsoleDownloadFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConsoleDownloadFile_ItemClick);
            // 
            // ButtonConsoleDeleteFile
            // 
            this.ButtonConsoleDeleteFile.Caption = "Delete";
            this.ButtonConsoleDeleteFile.Id = 1;
            this.ButtonConsoleDeleteFile.Name = "ButtonConsoleDeleteFile";
            this.ButtonConsoleDeleteFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConsoleDeleteFile_ItemClick);
            // 
            // ButtonConsoleNewFolder
            // 
            this.ButtonConsoleNewFolder.Caption = "New Folder";
            this.ButtonConsoleNewFolder.Id = 2;
            this.ButtonConsoleNewFolder.Name = "ButtonConsoleNewFolder";
            this.ButtonConsoleNewFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConsoleNewFolder_ItemClick);
            // 
            // ButtonConsoleRefresh
            // 
            this.ButtonConsoleRefresh.Caption = "Refresh";
            this.ButtonConsoleRefresh.Id = 3;
            this.ButtonConsoleRefresh.Name = "ButtonConsoleRefresh";
            this.ButtonConsoleRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConsoleRefresh_ItemClick);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager3;
            this.barDockControl5.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 521);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1326, 0);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 521);
            // 
            // barManager4
            // 
            this.barManager4.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5});
            this.barManager4.DockControls.Add(this.barDockControl9);
            this.barManager4.DockControls.Add(this.barDockControl10);
            this.barManager4.DockControls.Add(this.barDockControl11);
            this.barManager4.DockControls.Add(this.barDockControl12);
            this.barManager4.Form = this;
            this.barManager4.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelHeaderStatus,
            this.LabelStatus,
            this.barStaticItem1});
            this.barManager4.MaxItemId = 3;
            this.barManager4.StatusBar = this.bar5;
            // 
            // bar5
            // 
            this.bar5.BarItemVertIndent = 5;
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Status";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.LeftIndent = 4;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.Id = 1;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl9.Location = new System.Drawing.Point(0, 0);
            this.barDockControl9.Manager = this.barManager4;
            this.barDockControl9.Size = new System.Drawing.Size(1326, 0);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl10.Location = new System.Drawing.Point(0, 521);
            this.barDockControl10.Manager = this.barManager4;
            this.barDockControl10.Size = new System.Drawing.Size(1326, 28);
            // 
            // barDockControl11
            // 
            this.barDockControl11.CausesValidation = false;
            this.barDockControl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl11.Location = new System.Drawing.Point(0, 0);
            this.barDockControl11.Manager = this.barManager4;
            this.barDockControl11.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControl12
            // 
            this.barDockControl12.CausesValidation = false;
            this.barDockControl12.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl12.Location = new System.Drawing.Point(1326, 0);
            this.barDockControl12.Manager = this.barManager4;
            this.barDockControl12.Size = new System.Drawing.Size(0, 521);
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 0;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // FileManagerWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1326, 549);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl11);
            this.Controls.Add(this.barDockControl12);
            this.Controls.Add(this.barDockControl10);
            this.Controls.Add(this.barDockControl9);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FileManagerWindow.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FileManagerWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileExplorer_FormClosing);
            this.Load += new System.EventHandler(this.FileManagerWindow_Load);
            this.ContextMenuConsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLocalFiles)).EndInit();
            this.ContextMenuLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocalFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsoleFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsoleFiles)).EndInit();
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxLocalDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkContextMenu ContextMenuConsole;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemConsoleDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemConsoleDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemConsoleRefresh;
        private DarkUI.Controls.DarkContextMenu ContextMenuLocal;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocallUploadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalDeleteFile;
        private DevExpress.XtraGrid.GridControl GridLocalFiles;
        private DevExpress.XtraGrid.GridControl GridConsoleFiles;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Timer WaitLoadConsole;
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
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalRenameFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalRefresh;
        private System.Windows.Forms.ToolStripSeparator ContextMenuConsoleSeparator;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemConsoleRenameFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemConsoleRenameFolder;
        private System.Windows.Forms.ToolStripSeparator ContextMenuLocalSeparator;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuLocalRenameFolder;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewLocalFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewConsoleFiles;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxLocalDrives;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxConsoleDrives;
        private DevExpress.XtraEditors.TextEdit TextBoxLocalPath;
        private DevExpress.XtraEditors.TextEdit TextBoxConsolePath;
        private DevExpress.XtraEditors.SimpleButton ButtonBrowseLocalDirectory;
        private DevExpress.XtraEditors.SimpleButton ButtonConsoleNavigate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.StandaloneBarDockControl BarDockLocalFiles;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.StandaloneBarDockControl BarDockConsoleFiles;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem ButtonLocalUploadFile;
        private DevExpress.XtraBars.BarButtonItem ButtonLocalDeleteFile;
        private DevExpress.XtraBars.BarButtonItem ButtonLocalNewFolder;
        private DevExpress.XtraBars.BarButtonItem ButtonLocalRefresh;
        private DevExpress.XtraBars.BarButtonItem ButtonLocalOpenExplorer;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem ButtonConsoleDownloadFile;
        private DevExpress.XtraBars.BarButtonItem ButtonConsoleDeleteFile;
        private DevExpress.XtraBars.BarButtonItem ButtonConsoleNewFolder;
        private DevExpress.XtraBars.BarButtonItem ButtonConsoleRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl11;
        private DevExpress.XtraBars.BarManager barManager4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarHeaderItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private DevExpress.XtraBars.BarDockControl barDockControl12;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}