namespace ModioX.Forms.Tools.PS3_Tools
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
            this.GridLocalFiles = new DevExpress.XtraGrid.GridControl();
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
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.LabelConsoleStats = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonConsoleDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConsoleDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConsoleRename = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConsoleNewFolder = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConsoleRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConsoleNavigate = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxConsolePath = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxConsoleDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.LabelLocalStatus = new DevExpress.XtraEditors.LabelControl();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonLocalUpload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLocalDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLocalRename = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLocalNewFolder = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLocalRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLocalOpenExplorer = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonBrowseLocalDirectory = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxLocalDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxLocalPath = new DevExpress.XtraEditors.TextEdit();
            this.WaitLoadConsole = new System.Windows.Forms.Timer(this.components);
            this.BarManagerStatus = new DevExpress.XtraBars.BarManager(this.components);
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocalFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocalFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsoleFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsoleFiles)).BeginInit();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxLocalDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLocalFiles
            // 
            this.GridLocalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLocalFiles.Location = new System.Drawing.Point(11, 60);
            this.GridLocalFiles.MainView = this.GridViewLocalFiles;
            this.GridLocalFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.GridLocalFiles.Name = "GridLocalFiles";
            this.GridLocalFiles.Size = new System.Drawing.Size(630, 372);
            this.GridLocalFiles.TabIndex = 20;
            this.GridLocalFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewLocalFiles});
            this.GridLocalFiles.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.GridLocalFiles_FocusedViewChanged);
            // 
            // GridViewLocalFiles
            // 
            this.GridViewLocalFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewLocalFiles.GridControl = this.GridLocalFiles;
            this.GridViewLocalFiles.Name = "GridViewLocalFiles";
            this.GridViewLocalFiles.OptionsBehavior.Editable = false;
            this.GridViewLocalFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewLocalFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewLocalFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewLocalFiles.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewLocalFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewLocalFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewLocalFiles.OptionsView.ShowIndicator = false;
            this.GridViewLocalFiles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewLocalFiles_RowClick);
            this.GridViewLocalFiles.DoubleClick += new System.EventHandler(this.GridViewLocalFiles_DoubleClick);
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
            this.GridConsoleFiles.Location = new System.Drawing.Point(11, 60);
            this.GridConsoleFiles.MainView = this.GridViewConsoleFiles;
            this.GridConsoleFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.GridConsoleFiles.Name = "GridConsoleFiles";
            this.GridConsoleFiles.Size = new System.Drawing.Size(630, 372);
            this.GridConsoleFiles.TabIndex = 24;
            this.GridConsoleFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewConsoleFiles});
            this.GridConsoleFiles.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.GridConsoleFiles_FocusedViewChanged);
            this.GridConsoleFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridConsoleFiles_MouseDoubleClick);
            // 
            // GridViewConsoleFiles
            // 
            this.GridViewConsoleFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewConsoleFiles.GridControl = this.GridConsoleFiles;
            this.GridViewConsoleFiles.Name = "GridViewConsoleFiles";
            this.GridViewConsoleFiles.OptionsBehavior.Editable = false;
            this.GridViewConsoleFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewConsoleFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewConsoleFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewConsoleFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewConsoleFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewConsoleFiles.OptionsView.ShowIndicator = false;
            this.GridViewConsoleFiles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewConsoleFiles_RowClick);
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
            this.LayoutPanel.Size = new System.Drawing.Size(1314, 512);
            this.LayoutPanel.TabIndex = 12;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.stackPanel1);
            this.groupControl2.Controls.Add(this.stackPanel3);
            this.groupControl2.Controls.Add(this.GridConsoleFiles);
            this.groupControl2.Controls.Add(this.ButtonConsoleNavigate);
            this.groupControl2.Controls.Add(this.TextBoxConsolePath);
            this.groupControl2.Controls.Add(this.ComboBoxConsoleDrives);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(660, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(651, 506);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "CONSOLE FILE EXPLORER";
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.LabelConsoleStats);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel3.Location = new System.Drawing.Point(2, 478);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(647, 26);
            this.stackPanel3.TabIndex = 1175;
            // 
            // LabelConsoleStats
            // 
            this.LabelConsoleStats.Location = new System.Drawing.Point(10, 6);
            this.LabelConsoleStats.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LabelConsoleStats.Name = "LabelConsoleStats";
            this.LabelConsoleStats.Size = new System.Drawing.Size(0, 13);
            this.LabelConsoleStats.TabIndex = 11;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.ButtonConsoleDownload);
            this.stackPanel1.Controls.Add(this.ButtonConsoleDelete);
            this.stackPanel1.Controls.Add(this.ButtonConsoleRename);
            this.stackPanel1.Controls.Add(this.ButtonConsoleNewFolder);
            this.stackPanel1.Controls.Add(this.ButtonConsoleRefresh);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(2, 438);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(647, 40);
            this.stackPanel1.TabIndex = 1174;
            // 
            // ButtonConsoleDownload
            // 
            this.ButtonConsoleDownload.Enabled = false;
            this.ButtonConsoleDownload.Location = new System.Drawing.Point(9, 8);
            this.ButtonConsoleDownload.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.ButtonConsoleDownload.Name = "ButtonConsoleDownload";
            this.ButtonConsoleDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonConsoleDownload.Size = new System.Drawing.Size(89, 24);
            this.ButtonConsoleDownload.TabIndex = 10;
            this.ButtonConsoleDownload.Text = "Download";
            this.ButtonConsoleDownload.Click += new System.EventHandler(this.ButtonConsoleDownload_Click);
            // 
            // ButtonConsoleDelete
            // 
            this.ButtonConsoleDelete.Enabled = false;
            this.ButtonConsoleDelete.Location = new System.Drawing.Point(104, 8);
            this.ButtonConsoleDelete.Name = "ButtonConsoleDelete";
            this.ButtonConsoleDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonConsoleDelete.Size = new System.Drawing.Size(67, 24);
            this.ButtonConsoleDelete.TabIndex = 11;
            this.ButtonConsoleDelete.Text = "Delete";
            this.ButtonConsoleDelete.Click += new System.EventHandler(this.ButtonConsoleDelete_Click);
            // 
            // ButtonConsoleRename
            // 
            this.ButtonConsoleRename.Enabled = false;
            this.ButtonConsoleRename.Location = new System.Drawing.Point(177, 8);
            this.ButtonConsoleRename.Name = "ButtonConsoleRename";
            this.ButtonConsoleRename.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonConsoleRename.Size = new System.Drawing.Size(76, 24);
            this.ButtonConsoleRename.TabIndex = 16;
            this.ButtonConsoleRename.Text = "Rename";
            this.ButtonConsoleRename.Click += new System.EventHandler(this.ButtonConsoleRename_Click);
            // 
            // ButtonConsoleNewFolder
            // 
            this.ButtonConsoleNewFolder.Location = new System.Drawing.Point(259, 8);
            this.ButtonConsoleNewFolder.Name = "ButtonConsoleNewFolder";
            this.ButtonConsoleNewFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonConsoleNewFolder.Size = new System.Drawing.Size(91, 24);
            this.ButtonConsoleNewFolder.TabIndex = 12;
            this.ButtonConsoleNewFolder.Text = "New Folder";
            this.ButtonConsoleNewFolder.Click += new System.EventHandler(this.ButtonConsoleNewFolder_Click);
            // 
            // ButtonConsoleRefresh
            // 
            this.ButtonConsoleRefresh.Location = new System.Drawing.Point(356, 8);
            this.ButtonConsoleRefresh.Name = "ButtonConsoleRefresh";
            this.ButtonConsoleRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonConsoleRefresh.Size = new System.Drawing.Size(72, 24);
            this.ButtonConsoleRefresh.TabIndex = 13;
            this.ButtonConsoleRefresh.Text = "Refresh";
            this.ButtonConsoleRefresh.Click += new System.EventHandler(this.ButtonConsoleRefresh_Click);
            // 
            // ButtonConsoleNavigate
            // 
            this.ButtonConsoleNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConsoleNavigate.Location = new System.Drawing.Point(601, 32);
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
            this.TextBoxConsolePath.Size = new System.Drawing.Size(482, 22);
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
            this.groupControl1.Controls.Add(this.PanelButtons);
            this.groupControl1.Controls.Add(this.stackPanel2);
            this.groupControl1.Controls.Add(this.GridLocalFiles);
            this.groupControl1.Controls.Add(this.ButtonBrowseLocalDirectory);
            this.groupControl1.Controls.Add(this.ComboBoxLocalDrives);
            this.groupControl1.Controls.Add(this.TextBoxLocalPath);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(651, 506);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "LOCAL FILE EXPLORER";
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.LabelLocalStatus);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(2, 478);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(647, 26);
            this.stackPanel2.TabIndex = 1174;
            // 
            // LabelLocalStatus
            // 
            this.LabelLocalStatus.Location = new System.Drawing.Point(10, 6);
            this.LabelLocalStatus.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LabelLocalStatus.Name = "LabelLocalStatus";
            this.LabelLocalStatus.Size = new System.Drawing.Size(0, 13);
            this.LabelLocalStatus.TabIndex = 11;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonLocalUpload);
            this.PanelButtons.Controls.Add(this.ButtonLocalDelete);
            this.PanelButtons.Controls.Add(this.ButtonLocalRename);
            this.PanelButtons.Controls.Add(this.ButtonLocalNewFolder);
            this.PanelButtons.Controls.Add(this.ButtonLocalRefresh);
            this.PanelButtons.Controls.Add(this.ButtonLocalOpenExplorer);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 438);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(647, 40);
            this.PanelButtons.TabIndex = 1173;
            // 
            // ButtonLocalUpload
            // 
            this.ButtonLocalUpload.Enabled = false;
            this.ButtonLocalUpload.Location = new System.Drawing.Point(9, 8);
            this.ButtonLocalUpload.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.ButtonLocalUpload.Name = "ButtonLocalUpload";
            this.ButtonLocalUpload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLocalUpload.Size = new System.Drawing.Size(73, 24);
            this.ButtonLocalUpload.TabIndex = 10;
            this.ButtonLocalUpload.Text = "Upload";
            this.ButtonLocalUpload.Click += new System.EventHandler(this.ButtonLocalUpload_Click);
            // 
            // ButtonLocalDelete
            // 
            this.ButtonLocalDelete.Enabled = false;
            this.ButtonLocalDelete.Location = new System.Drawing.Point(88, 8);
            this.ButtonLocalDelete.Name = "ButtonLocalDelete";
            this.ButtonLocalDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLocalDelete.Size = new System.Drawing.Size(68, 24);
            this.ButtonLocalDelete.TabIndex = 11;
            this.ButtonLocalDelete.Text = "Delete";
            this.ButtonLocalDelete.Click += new System.EventHandler(this.ButtonLocalDelete_Click);
            // 
            // ButtonLocalRename
            // 
            this.ButtonLocalRename.Enabled = false;
            this.ButtonLocalRename.Location = new System.Drawing.Point(162, 8);
            this.ButtonLocalRename.Name = "ButtonLocalRename";
            this.ButtonLocalRename.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLocalRename.Size = new System.Drawing.Size(76, 24);
            this.ButtonLocalRename.TabIndex = 15;
            this.ButtonLocalRename.Text = "Rename";
            this.ButtonLocalRename.Click += new System.EventHandler(this.ButtonLocalRename_Click);
            // 
            // ButtonLocalNewFolder
            // 
            this.ButtonLocalNewFolder.Location = new System.Drawing.Point(244, 8);
            this.ButtonLocalNewFolder.Name = "ButtonLocalNewFolder";
            this.ButtonLocalNewFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLocalNewFolder.Size = new System.Drawing.Size(91, 24);
            this.ButtonLocalNewFolder.TabIndex = 12;
            this.ButtonLocalNewFolder.Text = "New Folder";
            this.ButtonLocalNewFolder.Click += new System.EventHandler(this.ButtonLocalNewFolder_Click);
            // 
            // ButtonLocalRefresh
            // 
            this.ButtonLocalRefresh.Location = new System.Drawing.Point(341, 8);
            this.ButtonLocalRefresh.Name = "ButtonLocalRefresh";
            this.ButtonLocalRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLocalRefresh.Size = new System.Drawing.Size(72, 24);
            this.ButtonLocalRefresh.TabIndex = 13;
            this.ButtonLocalRefresh.Text = "Refresh";
            this.ButtonLocalRefresh.Click += new System.EventHandler(this.ButtonLocalRefresh_Click);
            // 
            // ButtonLocalOpenExplorer
            // 
            this.ButtonLocalOpenExplorer.Location = new System.Drawing.Point(419, 8);
            this.ButtonLocalOpenExplorer.Name = "ButtonLocalOpenExplorer";
            this.ButtonLocalOpenExplorer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLocalOpenExplorer.Size = new System.Drawing.Size(105, 24);
            this.ButtonLocalOpenExplorer.TabIndex = 14;
            this.ButtonLocalOpenExplorer.Text = "Open Explorer";
            this.ButtonLocalOpenExplorer.Click += new System.EventHandler(this.ButtonLocalOpenExplorer_Click);
            // 
            // ButtonBrowseLocalDirectory
            // 
            this.ButtonBrowseLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseLocalDirectory.Location = new System.Drawing.Point(601, 32);
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
            this.TextBoxLocalPath.Size = new System.Drawing.Size(536, 22);
            this.TextBoxLocalPath.TabIndex = 1170;
            // 
            // WaitLoadConsole
            // 
            this.WaitLoadConsole.Enabled = true;
            this.WaitLoadConsole.Tick += new System.EventHandler(this.WaitLoadConsole_Tick);
            // 
            // BarManagerStatus
            // 
            this.BarManagerStatus.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarStatus});
            this.BarManagerStatus.DockControls.Add(this.barDockControlTop);
            this.BarManagerStatus.DockControls.Add(this.barDockControlBottom);
            this.BarManagerStatus.DockControls.Add(this.barDockControlLeft);
            this.BarManagerStatus.DockControls.Add(this.barDockControlRight);
            this.BarManagerStatus.Form = this;
            this.BarManagerStatus.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelHeaderStatus,
            this.barHeaderItem1,
            this.barStaticItem2,
            this.LabelStatus});
            this.BarManagerStatus.MaxItemId = 4;
            this.BarManagerStatus.StatusBar = this.BarStatus;
            // 
            // BarStatus
            // 
            this.BarStatus.BarItemVertIndent = 5;
            this.BarStatus.BarName = "Status bar";
            this.BarStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BarStatus.DockCol = 0;
            this.BarStatus.DockRow = 0;
            this.BarStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BarStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 0;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 4;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.Id = 3;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManagerStatus;
            this.barDockControlTop.Size = new System.Drawing.Size(1340, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(1340, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1340, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 540);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem2.Caption = "Status";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // FileManagerWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1340, 565);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
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
            ((System.ComponentModel.ISupportInitialize)(this.GridLocalFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocalFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsoleFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsoleFiles)).EndInit();
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxLocalDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private DevExpress.XtraEditors.SimpleButton ButtonLocalUpload;
        private DevExpress.XtraEditors.SimpleButton ButtonLocalDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonLocalNewFolder;
        private DevExpress.XtraEditors.SimpleButton ButtonLocalRefresh;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton ButtonConsoleDownload;
        private DevExpress.XtraEditors.SimpleButton ButtonConsoleDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonConsoleNewFolder;
        private DevExpress.XtraEditors.SimpleButton ButtonConsoleRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonLocalOpenExplorer;
        private DevExpress.XtraBars.BarManager BarManagerStatus;
        private DevExpress.XtraBars.Bar BarStatus;
        private DevExpress.XtraBars.BarStaticItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.SimpleButton ButtonConsoleRename;
        private DevExpress.XtraEditors.SimpleButton ButtonLocalRename;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private DevExpress.XtraEditors.LabelControl LabelConsoleStats;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.LabelControl LabelLocalStatus;
    }
}