using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Windows
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ContextMenuMods = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuModsInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsUninstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsDownloadArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsAddToList = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsRemoveFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsReportOnGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSelectType = new System.Windows.Forms.Label();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleModDetails = new DarkUI.Controls.DarkTitle();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelHeaderCategory = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelHeaderFirmware = new System.Windows.Forms.Label();
            this.LabelFirmware = new System.Windows.Forms.Label();
            this.LabelHeaderModType = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelHeaderVersion = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelHeaderRegion = new System.Windows.Forms.Label();
            this.LabelRegion = new System.Windows.Forms.Label();
            this.LabelHeaderGameType = new System.Windows.Forms.Label();
            this.LabelConfig = new System.Windows.Forms.Label();
            this.LabelHeaderAuthor = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelHeaderSubmittedBy = new System.Windows.Forms.Label();
            this.LabelSubmittedBy = new System.Windows.Forms.Label();
            this.LabelTitleModDescription = new DarkUI.Controls.DarkTitle();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.SectionModsInstallFilePaths = new DarkUI.Controls.DarkSectionPanel();
            this.DgvInstallationFiles = new XDevkit.XtraDataGridView();
            this.ColumnInstallationFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelHeaderInstallationFiles = new DarkUI.Controls.DarkTitle();
            this.ScrollBarDetails = new DarkUI.Controls.DarkScrollBar();
            this.SectionArchiveInformation = new DarkUI.Controls.DarkSectionPanel();
            this.PanelModsInstallationPaths = new System.Windows.Forms.Panel();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemModInstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModUninstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModDownload = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModAddToFavorite = new System.Windows.Forms.ToolStripButton();
            this.MenuStripHeader = new DarkUI.Controls.DarkMenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripConnectPS3Console = new System.Windows.Forms.ToolStripMenuItem();
            this.xBOXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripConnectExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsGameBackupFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsGameUpdatesFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemToolsFileManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsPackageManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemToolsWebManControls = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolStripWebManPowerFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemToolsWebManSoftReboot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManHardReboot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolStripWebManSystemInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolStripWebManShowSystemInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManShowCPURSX = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManShowMinVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManNotify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsWebManVirtualController = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAddNewConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSettingsEditGameRegions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsEditExternalApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpDiscordServer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOfficialSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripHelpOpenLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpOpenLogFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripHelpCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpWhatsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFooter = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripStatusSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.LabelSelectSystemType = new System.Windows.Forms.Label();
            this.SectionModsLibrary = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoModsFound = new System.Windows.Forms.Label();
            this.DgvMods = new XDevkit.XtraDataGridView();
            this.ColumnModsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsFirmware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsNoFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsFavourite = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelModsLibraryFilters = new System.Windows.Forms.Panel();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ToolsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ApplicationsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.OptionsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.EditYourLists = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.ComboBoxRegion = new DarkUI.Controls.DarkComboBox();
            this.LabelSelectRegion = new System.Windows.Forms.Label();
            this.LabelTitleMods = new DarkUI.Controls.DarkTitle();
            this.LabelTitleFilterMods = new DarkUI.Controls.DarkTitle();
            this.TextBoxSearch = new DarkUI.Controls.DarkTextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ComboBoxModType = new DarkUI.Controls.DarkComboBox();
            this.ComboBoxSystemType = new DarkUI.Controls.DarkComboBox();
            this.SectionGames = new DarkUI.Controls.DarkSectionPanel();
            this.ScrollBarCategories = new DarkUI.Controls.DarkScrollBar();
            this.FlowPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleGames = new DarkUI.Controls.DarkTitle();
            this.PanelGames = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleHomebrew = new DarkUI.Controls.DarkTitle();
            this.PanelHomebrew = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleResources = new DarkUI.Controls.DarkTitle();
            this.PanelResources = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleMyLists = new DarkUI.Controls.DarkTitle();
            this.PanelLists = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionInstalledGameMods = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoModsInstalled = new System.Windows.Forms.Label();
            this.DgvGameModsInstalled = new XDevkit.XtraDataGridView();
            this.ColumnModsInstalledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledNoOfFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledUninstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelModsInstalledHeader = new System.Windows.Forms.Panel();
            this.LabelHeaderGameMods = new DarkUI.Controls.DarkTitle();
            this.MenuStripGameMods = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemGameModsUninstallAll = new System.Windows.Forms.ToolStripButton();
            this.LabelInstalledGameModsStatus = new System.Windows.Forms.ToolStripLabel();
            this.ContextMenuMods.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.SectionModsInstallFilePaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallationFiles)).BeginInit();
            this.SectionArchiveInformation.SuspendLayout();
            this.PanelModsInstallationPaths.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.MenuStripHeader.SuspendLayout();
            this.ToolStripFooter.SuspendLayout();
            this.SectionModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).BeginInit();
            this.PanelModsLibraryFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpMenu)).BeginInit();
            this.SectionGames.SuspendLayout();
            this.FlowPanelCategories.SuspendLayout();
            this.SectionInstalledGameMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameModsInstalled)).BeginInit();
            this.PanelModsInstalledHeader.SuspendLayout();
            this.MenuStripGameMods.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuMods
            // 
            this.ContextMenuMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuMods.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuMods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuModsInstallFiles,
            this.ContextMenuModsUninstallFiles,
            this.ContextMenuModsDownloadArchive,
            this.ContextMenuModsSeparator0,
            this.ContextMenuModsAddToList,
            this.ContextMenuModsRemoveFromList,
            this.ContextMenuModsSeparator1,
            this.ContextMenuModsReportOnGitHub});
            this.ContextMenuMods.Name = "ContextMenuConsole";
            this.ContextMenuMods.Size = new System.Drawing.Size(185, 174);
            // 
            // ContextMenuModsInstallFiles
            // 
            this.ContextMenuModsInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsInstallFiles.Image = ((System.Drawing.Image)(resources.GetObject("ContextMenuModsInstallFiles.Image")));
            this.ContextMenuModsInstallFiles.Name = "ContextMenuModsInstallFiles";
            this.ContextMenuModsInstallFiles.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsInstallFiles.Text = "Install Files...";
            this.ContextMenuModsInstallFiles.Click += new System.EventHandler(this.ContextMenuModsInstallToConsole_Click);
            // 
            // ContextMenuModsUninstallFiles
            // 
            this.ContextMenuModsUninstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsUninstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsUninstallFiles.Image = ((System.Drawing.Image)(resources.GetObject("ContextMenuModsUninstallFiles.Image")));
            this.ContextMenuModsUninstallFiles.Name = "ContextMenuModsUninstallFiles";
            this.ContextMenuModsUninstallFiles.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsUninstallFiles.Text = "Uninstall Files...";
            this.ContextMenuModsUninstallFiles.Click += new System.EventHandler(this.ContextMenuModsUninstallFromConsole_Click);
            // 
            // ContextMenuModsDownloadArchive
            // 
            this.ContextMenuModsDownloadArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsDownloadArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsDownloadArchive.Image = ((System.Drawing.Image)(resources.GetObject("ContextMenuModsDownloadArchive.Image")));
            this.ContextMenuModsDownloadArchive.Name = "ContextMenuModsDownloadArchive";
            this.ContextMenuModsDownloadArchive.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsDownloadArchive.Text = "Download Archive...";
            this.ContextMenuModsDownloadArchive.Click += new System.EventHandler(this.ContextMenuModsDownloadArchive_Click);
            // 
            // ContextMenuModsSeparator0
            // 
            this.ContextMenuModsSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuModsSeparator0.Name = "ContextMenuModsSeparator0";
            this.ContextMenuModsSeparator0.Size = new System.Drawing.Size(181, 6);
            // 
            // ContextMenuModsAddToList
            // 
            this.ContextMenuModsAddToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsAddToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsAddToList.Image = global::ModioX.Properties.Resources.add_list;
            this.ContextMenuModsAddToList.Name = "ContextMenuModsAddToList";
            this.ContextMenuModsAddToList.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsAddToList.Text = "Add to List...";
            this.ContextMenuModsAddToList.Click += new System.EventHandler(this.ContextMenuModsAddToList_Click);
            // 
            // ContextMenuModsRemoveFromList
            // 
            this.ContextMenuModsRemoveFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsRemoveFromList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsRemoveFromList.Image = global::ModioX.Properties.Resources.delete_list;
            this.ContextMenuModsRemoveFromList.Name = "ContextMenuModsRemoveFromList";
            this.ContextMenuModsRemoveFromList.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsRemoveFromList.Text = "Remove from List...";
            this.ContextMenuModsRemoveFromList.Click += new System.EventHandler(this.ContextMenuModsRemoveFromList_Click);
            // 
            // ContextMenuModsSeparator1
            // 
            this.ContextMenuModsSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuModsSeparator1.Name = "ContextMenuModsSeparator1";
            this.ContextMenuModsSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // ContextMenuModsReportOnGitHub
            // 
            this.ContextMenuModsReportOnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsReportOnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsReportOnGitHub.Image = global::ModioX.Properties.Resources.bug;
            this.ContextMenuModsReportOnGitHub.Name = "ContextMenuModsReportOnGitHub";
            this.ContextMenuModsReportOnGitHub.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsReportOnGitHub.Text = "Report an Issue";
            this.ContextMenuModsReportOnGitHub.Click += new System.EventHandler(this.ContextMenuModsReportOnGitHub_Click);
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectType.AutoSize = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(558, 42);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(64, 15);
            this.LabelSelectType.TabIndex = 1122;
            this.LabelSelectType.Text = "MOD TYPE";
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelTitleModDetails);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderName);
            this.FlowPanelDetails.Controls.Add(this.LabelName);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderCategory);
            this.FlowPanelDetails.Controls.Add(this.LabelCategory);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderFirmware);
            this.FlowPanelDetails.Controls.Add(this.LabelFirmware);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderModType);
            this.FlowPanelDetails.Controls.Add(this.LabelType);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderRegion);
            this.FlowPanelDetails.Controls.Add(this.LabelRegion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderGameType);
            this.FlowPanelDetails.Controls.Add(this.LabelConfig);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelTitleModDescription);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(3, 8, 18, 4);
            this.FlowPanelDetails.Size = new System.Drawing.Size(375, 545);
            this.FlowPanelDetails.TabIndex = 0;
            this.FlowPanelDetails.TabStop = true;
            this.FlowPanelDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowPanelDetails_Scroll);
            this.FlowPanelDetails.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FlowPanelDetails_MouseWheel);
            // 
            // LabelTitleModDetails
            // 
            this.LabelTitleModDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleModDetails.Location = new System.Drawing.Point(8, 10);
            this.LabelTitleModDetails.Margin = new System.Windows.Forms.Padding(5, 2, 3, 3);
            this.LabelTitleModDetails.Name = "LabelTitleModDetails";
            this.LabelTitleModDetails.Size = new System.Drawing.Size(344, 17);
            this.LabelTitleModDetails.TabIndex = 1163;
            this.LabelTitleModDetails.Text = "DETAILS";
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.AutoSize = true;
            this.LabelHeaderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(5, 33);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(43, 15);
            this.LabelHeaderName.TabIndex = 26;
            this.LabelHeaderName.Text = "Name:";
            // 
            // LabelName
            // 
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelName, true);
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(50, 33);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelName.MaximumSize = new System.Drawing.Size(300, 15);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(16, 15);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "...";
            // 
            // LabelHeaderCategory
            // 
            this.LabelHeaderCategory.AutoSize = true;
            this.LabelHeaderCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCategory.Location = new System.Drawing.Point(5, 54);
            this.LabelHeaderCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderCategory.Name = "LabelHeaderCategory";
            this.LabelHeaderCategory.Size = new System.Drawing.Size(60, 15);
            this.LabelHeaderCategory.TabIndex = 24;
            this.LabelHeaderCategory.Text = "Category:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelCategory, true);
            this.LabelCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(67, 54);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(16, 15);
            this.LabelCategory.TabIndex = 23;
            this.LabelCategory.Text = "...";
            // 
            // LabelHeaderFirmware
            // 
            this.LabelHeaderFirmware.AutoSize = true;
            this.LabelHeaderFirmware.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFirmware.Location = new System.Drawing.Point(5, 75);
            this.LabelHeaderFirmware.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderFirmware.Name = "LabelHeaderFirmware";
            this.LabelHeaderFirmware.Size = new System.Drawing.Size(80, 15);
            this.LabelHeaderFirmware.TabIndex = 20;
            this.LabelHeaderFirmware.Text = "System Type:";
            // 
            // LabelFirmware
            // 
            this.LabelFirmware.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelFirmware, true);
            this.LabelFirmware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFirmware.Location = new System.Drawing.Point(87, 75);
            this.LabelFirmware.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFirmware.Name = "LabelFirmware";
            this.LabelFirmware.Size = new System.Drawing.Size(16, 15);
            this.LabelFirmware.TabIndex = 21;
            this.LabelFirmware.Text = "...";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.AutoSize = true;
            this.LabelHeaderModType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderModType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(5, 96);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderModType.TabIndex = 16;
            this.LabelHeaderModType.Text = "Mod Type:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelType, true);
            this.LabelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelType.Location = new System.Drawing.Point(71, 96);
            this.LabelType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(16, 15);
            this.LabelType.TabIndex = 17;
            this.LabelType.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.AutoSize = true;
            this.LabelHeaderVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(5, 117);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(51, 15);
            this.LabelHeaderVersion.TabIndex = 3;
            this.LabelHeaderVersion.Text = "Version:";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelVersion, true);
            this.LabelVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(58, 117);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(16, 15);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderRegion
            // 
            this.LabelHeaderRegion.AutoSize = true;
            this.LabelHeaderRegion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderRegion.Location = new System.Drawing.Point(5, 138);
            this.LabelHeaderRegion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderRegion.Name = "LabelHeaderRegion";
            this.LabelHeaderRegion.Size = new System.Drawing.Size(85, 15);
            this.LabelHeaderRegion.TabIndex = 1164;
            this.LabelHeaderRegion.Text = "Game Region:";
            // 
            // LabelRegion
            // 
            this.LabelRegion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelRegion, true);
            this.LabelRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRegion.Location = new System.Drawing.Point(92, 138);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(16, 15);
            this.LabelRegion.TabIndex = 1165;
            this.LabelRegion.Text = "...";
            // 
            // LabelHeaderGameType
            // 
            this.LabelHeaderGameType.AutoSize = true;
            this.LabelHeaderGameType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderGameType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameType.Location = new System.Drawing.Point(5, 159);
            this.LabelHeaderGameType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderGameType.Name = "LabelHeaderGameType";
            this.LabelHeaderGameType.Size = new System.Drawing.Size(72, 15);
            this.LabelHeaderGameType.TabIndex = 9;
            this.LabelHeaderGameType.Text = "Game Type:";
            // 
            // LabelConfig
            // 
            this.LabelConfig.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConfig, true);
            this.LabelConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConfig.Location = new System.Drawing.Point(79, 159);
            this.LabelConfig.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelConfig.Name = "LabelConfig";
            this.LabelConfig.Size = new System.Drawing.Size(16, 15);
            this.LabelConfig.TabIndex = 10;
            this.LabelConfig.Text = "...";
            // 
            // LabelHeaderAuthor
            // 
            this.LabelHeaderAuthor.AutoSize = true;
            this.LabelHeaderAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderAuthor.Location = new System.Drawing.Point(5, 180);
            this.LabelHeaderAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderAuthor.Name = "LabelHeaderAuthor";
            this.LabelHeaderAuthor.Size = new System.Drawing.Size(71, 15);
            this.LabelHeaderAuthor.TabIndex = 6;
            this.LabelHeaderAuthor.Text = "Created By:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelAuthor, true);
            this.LabelAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAuthor.Location = new System.Drawing.Point(78, 180);
            this.LabelAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(16, 15);
            this.LabelAuthor.TabIndex = 15;
            this.LabelAuthor.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.AutoSize = true;
            this.LabelHeaderSubmittedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(5, 201);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(86, 15);
            this.LabelHeaderSubmittedBy.TabIndex = 13;
            this.LabelHeaderSubmittedBy.Text = "Submitted By:";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelSubmittedBy, true);
            this.LabelSubmittedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(93, 201);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(16, 15);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // LabelTitleModDescription
            // 
            this.LabelTitleModDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleModDescription.Location = new System.Drawing.Point(8, 223);
            this.LabelTitleModDescription.Margin = new System.Windows.Forms.Padding(5, 4, 3, 4);
            this.LabelTitleModDescription.Name = "LabelTitleModDescription";
            this.LabelTitleModDescription.Size = new System.Drawing.Size(344, 17);
            this.LabelTitleModDescription.TabIndex = 1162;
            this.LabelTitleModDescription.Text = "DESCRIPTION";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(5, 246);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(410, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.LabelDescription.Size = new System.Drawing.Size(16, 27);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            // 
            // SectionModsInstallFilePaths
            // 
            this.SectionModsInstallFilePaths.Controls.Add(this.DgvInstallationFiles);
            this.SectionModsInstallFilePaths.Controls.Add(this.LabelHeaderInstallationFiles);
            this.SectionModsInstallFilePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionModsInstallFilePaths.Location = new System.Drawing.Point(0, 11);
            this.SectionModsInstallFilePaths.Margin = new System.Windows.Forms.Padding(0);
            this.SectionModsInstallFilePaths.Name = "SectionModsInstallFilePaths";
            this.SectionModsInstallFilePaths.SectionHeader = " ";
            this.SectionModsInstallFilePaths.Size = new System.Drawing.Size(375, 125);
            this.SectionModsInstallFilePaths.TabIndex = 26;
            // 
            // DgvInstallationFiles
            // 
            this.DgvInstallationFiles.AllowUserToAddRows = false;
            this.DgvInstallationFiles.AllowUserToDeleteRows = false;
            this.DgvInstallationFiles.AllowUserToDragDropRows = false;
            this.DgvInstallationFiles.AllowUserToPasteCells = false;
            this.DgvInstallationFiles.AllowUserToResizeColumns = false;
            this.DgvInstallationFiles.ColumnHeadersHeight = 21;
            this.DgvInstallationFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvInstallationFiles.ColumnHeadersVisible = false;
            this.DgvInstallationFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInstallationFiles});
            this.DgvInstallationFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvInstallationFiles.Location = new System.Drawing.Point(1, 25);
            this.DgvInstallationFiles.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvInstallationFiles.MultiSelect = false;
            this.DgvInstallationFiles.Name = "DgvInstallationFiles";
            this.DgvInstallationFiles.ReadOnly = true;
            this.DgvInstallationFiles.RowHeadersWidth = 41;
            this.DgvInstallationFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInstallationFiles.RowTemplate.Height = 24;
            this.DgvInstallationFiles.RowTemplate.ReadOnly = true;
            this.DgvInstallationFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvInstallationFiles.Size = new System.Drawing.Size(373, 99);
            this.DgvInstallationFiles.TabIndex = 3;
            this.DgvInstallationFiles.SelectionChanged += new System.EventHandler(this.Dgv_SelectionChanged);
            // 
            // ColumnInstallationFiles
            // 
            this.ColumnInstallationFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInstallationFiles.HeaderText = "Installation Files";
            this.ColumnInstallationFiles.Name = "ColumnInstallationFiles";
            this.ColumnInstallationFiles.ReadOnly = true;
            this.ColumnInstallationFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LabelHeaderInstallationFiles
            // 
            this.LabelHeaderInstallationFiles.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeaderInstallationFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallationFiles.Location = new System.Drawing.Point(6, 5);
            this.LabelHeaderInstallationFiles.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.LabelHeaderInstallationFiles.Name = "LabelHeaderInstallationFiles";
            this.LabelHeaderInstallationFiles.Size = new System.Drawing.Size(362, 16);
            this.LabelHeaderInstallationFiles.TabIndex = 1163;
            this.LabelHeaderInstallationFiles.Text = "INSTALL FILES";
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(359, 25);
            this.ScrollBarDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(17, 556);
            this.ScrollBarDetails.TabIndex = 1133;
            this.ScrollBarDetails.Text = "darkScrollBar1";
            this.ScrollBarDetails.ViewSize = 1;
            this.ScrollBarDetails.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarDetails_ValueChanged);
            // 
            // SectionArchiveInformation
            // 
            this.SectionArchiveInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionArchiveInformation.Controls.Add(this.ScrollBarDetails);
            this.SectionArchiveInformation.Controls.Add(this.FlowPanelDetails);
            this.SectionArchiveInformation.Controls.Add(this.PanelModsInstallationPaths);
            this.SectionArchiveInformation.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionArchiveInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionArchiveInformation.Location = new System.Drawing.Point(1195, 39);
            this.SectionArchiveInformation.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.SectionArchiveInformation.Name = "SectionArchiveInformation";
            this.SectionArchiveInformation.SectionHeader = "MOD INFORMATION";
            this.SectionArchiveInformation.Size = new System.Drawing.Size(377, 743);
            this.SectionArchiveInformation.TabIndex = 9;
            // 
            // PanelModsInstallationPaths
            // 
            this.PanelModsInstallationPaths.Controls.Add(this.SectionModsInstallFilePaths);
            this.PanelModsInstallationPaths.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelModsInstallationPaths.Location = new System.Drawing.Point(1, 570);
            this.PanelModsInstallationPaths.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsInstallationPaths.Name = "PanelModsInstallationPaths";
            this.PanelModsInstallationPaths.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.PanelModsInstallationPaths.Size = new System.Drawing.Size(375, 136);
            this.PanelModsInstallationPaths.TabIndex = 26;
            // 
            // ToolStripArchiveInformation
            // 
            this.ToolStripArchiveInformation.AutoSize = false;
            this.ToolStripArchiveInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripArchiveInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripArchiveInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripArchiveInformation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripArchiveInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripArchiveInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemModInstall,
            this.ToolItemModUninstall,
            this.ToolItemModDownload,
            this.ToolItemModAddToFavorite});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 706);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(375, 36);
            this.ToolStripArchiveInformation.TabIndex = 4;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolItemModInstall
            // 
            this.ToolItemModInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModInstall.Enabled = false;
            this.ToolItemModInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModInstall.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemModInstall.Image")));
            this.ToolItemModInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModInstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModInstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModInstall.Name = "ToolItemModInstall";
            this.ToolItemModInstall.Size = new System.Drawing.Size(66, 26);
            this.ToolItemModInstall.Text = "Install";
            this.ToolItemModInstall.ToolTipText = "Install to Console";
            this.ToolItemModInstall.Click += new System.EventHandler(this.ToolStripInstallFiles_Click);
            // 
            // ToolItemModUninstall
            // 
            this.ToolItemModUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModUninstall.Enabled = false;
            this.ToolItemModUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModUninstall.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemModUninstall.Image")));
            this.ToolItemModUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModUninstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModUninstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModUninstall.Name = "ToolItemModUninstall";
            this.ToolItemModUninstall.Size = new System.Drawing.Size(81, 26);
            this.ToolItemModUninstall.Text = "Uninstall";
            this.ToolItemModUninstall.ToolTipText = "Uninstall from Console";
            this.ToolItemModUninstall.Click += new System.EventHandler(this.ToolStripUninstallFiles_Click);
            // 
            // ToolItemModDownload
            // 
            this.ToolItemModDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModDownload.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemModDownload.Image")));
            this.ToolItemModDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModDownload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModDownload.Name = "ToolItemModDownload";
            this.ToolItemModDownload.Size = new System.Drawing.Size(89, 26);
            this.ToolItemModDownload.Text = "Download";
            this.ToolItemModDownload.ToolTipText = "Download Archive to Computer";
            this.ToolItemModDownload.Click += new System.EventHandler(this.ToolStripDownloadArchive_Click);
            // 
            // ToolItemModAddToFavorite
            // 
            this.ToolItemModAddToFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModAddToFavorite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModAddToFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModAddToFavorite.Image = global::ModioX.Properties.Resources.heart;
            this.ToolItemModAddToFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModAddToFavorite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModAddToFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModAddToFavorite.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModAddToFavorite.Name = "ToolItemModAddToFavorite";
            this.ToolItemModAddToFavorite.Size = new System.Drawing.Size(79, 26);
            this.ToolItemModAddToFavorite.Text = "Favorite";
            this.ToolItemModAddToFavorite.ToolTipText = "Add/Remove from Favorites";
            this.ToolItemModAddToFavorite.Click += new System.EventHandler(this.ToolStripFavorite_Click);
            // 
            // MenuStripHeader
            // 
            this.MenuStripHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MenuStripHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuItemTools,
            this.MenuItemApplications,
            this.MenuItemOptions,
            this.MenuItemHelp,
            this.MenuStripRefreshData});
            this.MenuStripHeader.Location = new System.Drawing.Point(0, 25);
            this.MenuStripHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MenuStripHeader.Name = "MenuStripHeader";
            this.MenuStripHeader.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.MenuStripHeader.Size = new System.Drawing.Size(1584, 29);
            this.MenuStripHeader.TabIndex = 1140;
            this.MenuStripHeader.Text = "darkMenuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConnectPS3,
            this.xBOXToolStripMenuItem,
            this.MenuStripFileSeparator0,
            this.MenuStripConnectExit});
            this.MenuStripFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(74, 19);
            this.MenuStripFile.Text = "CONNECT";
            // 
            // MenuItemConnectPS3
            // 
            this.MenuItemConnectPS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripConnectPS3Console});
            this.MenuItemConnectPS3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3.Name = "MenuItemConnectPS3";
            this.MenuItemConnectPS3.Size = new System.Drawing.Size(135, 22);
            this.MenuItemConnectPS3.Text = "PS3";
            // 
            // MenuStripConnectPS3Console
            // 
            this.MenuStripConnectPS3Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripConnectPS3Console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripConnectPS3Console.Name = "MenuStripConnectPS3Console";
            this.MenuStripConnectPS3Console.Size = new System.Drawing.Size(186, 22);
            this.MenuStripConnectPS3Console.Text = "Connect to console...";
            this.MenuStripConnectPS3Console.Click += new System.EventHandler(this.MenuItemConnectPS3Console_Click);
            // 
            // xBOXToolStripMenuItem
            // 
            this.xBOXToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.xBOXToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.xBOXToolStripMenuItem.Name = "xBOXToolStripMenuItem";
            this.xBOXToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.xBOXToolStripMenuItem.Text = "XBOX";
            // 
            // MenuStripFileSeparator0
            // 
            this.MenuStripFileSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripFileSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStripFileSeparator0.Name = "MenuStripFileSeparator0";
            this.MenuStripFileSeparator0.Size = new System.Drawing.Size(132, 6);
            // 
            // MenuStripConnectExit
            // 
            this.MenuStripConnectExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripConnectExit.CheckOnClick = true;
            this.MenuStripConnectExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripConnectExit.Name = "MenuStripConnectExit";
            this.MenuStripConnectExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuStripConnectExit.Size = new System.Drawing.Size(135, 22);
            this.MenuStripConnectExit.Text = "Exit";
            this.MenuStripConnectExit.Click += new System.EventHandler(this.MenuStripConnectExit_Click);
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemToolsGameBackupFiles,
            this.MenuItemToolsGameUpdatesFinder,
            this.MenuItemToolsSeperator0,
            this.MenuItemToolsFileManager,
            this.MenuItemToolsPackageManager,
            this.MenuItemToolsSeperator1,
            this.MenuItemToolsWebManControls});
            this.MenuItemTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTools.Name = "MenuItemTools";
            this.MenuItemTools.Size = new System.Drawing.Size(54, 19);
            this.MenuItemTools.Text = "TOOLS";
            // 
            // MenuItemToolsGameBackupFiles
            // 
            this.MenuItemToolsGameBackupFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsGameBackupFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsGameBackupFiles.Name = "MenuItemToolsGameBackupFiles";
            this.MenuItemToolsGameBackupFiles.Size = new System.Drawing.Size(196, 22);
            this.MenuItemToolsGameBackupFiles.Text = "Game Backup Files...";
            this.MenuItemToolsGameBackupFiles.Click += new System.EventHandler(this.MenuItemToolsBackupFileManager_Click);
            // 
            // MenuItemToolsGameUpdatesFinder
            // 
            this.MenuItemToolsGameUpdatesFinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsGameUpdatesFinder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsGameUpdatesFinder.Name = "MenuItemToolsGameUpdatesFinder";
            this.MenuItemToolsGameUpdatesFinder.Size = new System.Drawing.Size(196, 22);
            this.MenuItemToolsGameUpdatesFinder.Text = "Game Updates Finder...";
            this.MenuItemToolsGameUpdatesFinder.Click += new System.EventHandler(this.MenuItemToolsGameUpdatesFinder_Click);
            // 
            // MenuItemToolsSeperator0
            // 
            this.MenuItemToolsSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemToolsSeperator0.Name = "MenuItemToolsSeperator0";
            this.MenuItemToolsSeperator0.Size = new System.Drawing.Size(193, 6);
            // 
            // MenuItemToolsFileManager
            // 
            this.MenuItemToolsFileManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsFileManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsFileManager.Name = "MenuItemToolsFileManager";
            this.MenuItemToolsFileManager.Size = new System.Drawing.Size(196, 22);
            this.MenuItemToolsFileManager.Text = "File Manager...";
            this.MenuItemToolsFileManager.Click += new System.EventHandler(this.MenuItemToolsFileManager_Click);
            // 
            // MenuItemToolsPackageManager
            // 
            this.MenuItemToolsPackageManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsPackageManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsPackageManager.Name = "MenuItemToolsPackageManager";
            this.MenuItemToolsPackageManager.Size = new System.Drawing.Size(196, 22);
            this.MenuItemToolsPackageManager.Text = "Package Manager...";
            this.MenuItemToolsPackageManager.Click += new System.EventHandler(this.MenuItemToolsPackageManager_Click);
            // 
            // MenuItemToolsSeperator1
            // 
            this.MenuItemToolsSeperator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsSeperator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsSeperator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemToolsSeperator1.Name = "MenuItemToolsSeperator1";
            this.MenuItemToolsSeperator1.Size = new System.Drawing.Size(193, 6);
            // 
            // MenuItemToolsWebManControls
            // 
            this.MenuItemToolsWebManControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManControls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripWebManPowerFunctions,
            this.MenuToolStripWebManSystemInformation,
            this.MenuItemToolsWebManNotify,
            this.MenuItemToolsWebManVirtualController});
            this.MenuItemToolsWebManControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManControls.Name = "MenuItemToolsWebManControls";
            this.MenuItemToolsWebManControls.Size = new System.Drawing.Size(196, 22);
            this.MenuItemToolsWebManControls.Text = "WebMAN Controls...";
            // 
            // MenuToolStripWebManPowerFunctions
            // 
            this.MenuToolStripWebManPowerFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuToolStripWebManPowerFunctions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemToolsWebManShutdown,
            this.MenuItemToolsWebManRestart,
            this.toolStripSeparator1,
            this.MenuItemToolsWebManSoftReboot,
            this.MenuItemToolsWebManHardReboot});
            this.MenuToolStripWebManPowerFunctions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuToolStripWebManPowerFunctions.Name = "MenuToolStripWebManPowerFunctions";
            this.MenuToolStripWebManPowerFunctions.Size = new System.Drawing.Size(178, 22);
            this.MenuToolStripWebManPowerFunctions.Text = "Power Functions";
            // 
            // MenuItemToolsWebManShutdown
            // 
            this.MenuItemToolsWebManShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManShutdown.Name = "MenuItemToolsWebManShutdown";
            this.MenuItemToolsWebManShutdown.Size = new System.Drawing.Size(150, 22);
            this.MenuItemToolsWebManShutdown.Text = "Shutdown...";
            this.MenuItemToolsWebManShutdown.Click += new System.EventHandler(this.MenuItemToolsWebManShutdown_Click);
            // 
            // MenuItemToolsWebManRestart
            // 
            this.MenuItemToolsWebManRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManRestart.Name = "MenuItemToolsWebManRestart";
            this.MenuItemToolsWebManRestart.Size = new System.Drawing.Size(150, 22);
            this.MenuItemToolsWebManRestart.Text = "Restart...";
            this.MenuItemToolsWebManRestart.Click += new System.EventHandler(this.MenuItemToolsWebManRestart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // MenuItemToolsWebManSoftReboot
            // 
            this.MenuItemToolsWebManSoftReboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManSoftReboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManSoftReboot.Name = "MenuItemToolsWebManSoftReboot";
            this.MenuItemToolsWebManSoftReboot.Size = new System.Drawing.Size(150, 22);
            this.MenuItemToolsWebManSoftReboot.Text = "Soft Reboot...";
            this.MenuItemToolsWebManSoftReboot.Click += new System.EventHandler(this.MenuItemToolsWebManSoftReboot_Click);
            // 
            // MenuItemToolsWebManHardReboot
            // 
            this.MenuItemToolsWebManHardReboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManHardReboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManHardReboot.Name = "MenuItemToolsWebManHardReboot";
            this.MenuItemToolsWebManHardReboot.Size = new System.Drawing.Size(150, 22);
            this.MenuItemToolsWebManHardReboot.Text = "Hard Reboot...";
            this.MenuItemToolsWebManHardReboot.Click += new System.EventHandler(this.MenuItemToolsWebManHardReboot_Click);
            // 
            // MenuToolStripWebManSystemInformation
            // 
            this.MenuToolStripWebManSystemInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuToolStripWebManSystemInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripWebManShowSystemInformation,
            this.MenuItemToolsWebManShowCPURSX,
            this.MenuItemToolsWebManShowMinVersion});
            this.MenuToolStripWebManSystemInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuToolStripWebManSystemInformation.Name = "MenuToolStripWebManSystemInformation";
            this.MenuToolStripWebManSystemInformation.Size = new System.Drawing.Size(178, 22);
            this.MenuToolStripWebManSystemInformation.Text = "System Information";
            // 
            // MenuToolStripWebManShowSystemInformation
            // 
            this.MenuToolStripWebManShowSystemInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuToolStripWebManShowSystemInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuToolStripWebManShowSystemInformation.Name = "MenuToolStripWebManShowSystemInformation";
            this.MenuToolStripWebManShowSystemInformation.Size = new System.Drawing.Size(232, 22);
            this.MenuToolStripWebManShowSystemInformation.Text = "Show System Information...";
            this.MenuToolStripWebManShowSystemInformation.Click += new System.EventHandler(this.MenuItemToolsWebManShowSystemInformation_Click);
            // 
            // MenuItemToolsWebManShowCPURSX
            // 
            this.MenuItemToolsWebManShowCPURSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManShowCPURSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManShowCPURSX.Name = "MenuItemToolsWebManShowCPURSX";
            this.MenuItemToolsWebManShowCPURSX.Size = new System.Drawing.Size(232, 22);
            this.MenuItemToolsWebManShowCPURSX.Text = "Show CPU/RSX Temperature...";
            this.MenuItemToolsWebManShowCPURSX.Click += new System.EventHandler(this.MenuItemToolsWebManShowCPURSX_Click);
            // 
            // MenuItemToolsWebManShowMinVersion
            // 
            this.MenuItemToolsWebManShowMinVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManShowMinVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManShowMinVersion.Name = "MenuItemToolsWebManShowMinVersion";
            this.MenuItemToolsWebManShowMinVersion.Size = new System.Drawing.Size(232, 22);
            this.MenuItemToolsWebManShowMinVersion.Text = "Show Minimum Version...";
            this.MenuItemToolsWebManShowMinVersion.Click += new System.EventHandler(this.MenuItemToolsWebManShowMinVersion_Click);
            // 
            // MenuItemToolsWebManNotify
            // 
            this.MenuItemToolsWebManNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManNotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManNotify.Name = "MenuItemToolsWebManNotify";
            this.MenuItemToolsWebManNotify.Size = new System.Drawing.Size(178, 22);
            this.MenuItemToolsWebManNotify.Text = "Notify Message...";
            this.MenuItemToolsWebManNotify.Click += new System.EventHandler(this.MenuItemToolsWebManNotify_Click);
            // 
            // MenuItemToolsWebManVirtualController
            // 
            this.MenuItemToolsWebManVirtualController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsWebManVirtualController.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsWebManVirtualController.Name = "MenuItemToolsWebManVirtualController";
            this.MenuItemToolsWebManVirtualController.Size = new System.Drawing.Size(178, 22);
            this.MenuItemToolsWebManVirtualController.Text = "Virtual Controller...";
            this.MenuItemToolsWebManVirtualController.Click += new System.EventHandler(this.MenuItemToolsWebManVirtualController_Click);
            // 
            // MenuItemApplications
            // 
            this.MenuItemApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemApplications.Name = "MenuItemApplications";
            this.MenuItemApplications.Size = new System.Drawing.Size(98, 19);
            this.MenuItemApplications.Text = "APPLICATIONS";
            // 
            // MenuItemOptions
            // 
            this.MenuItemOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingsAddNewConsole,
            this.MenuItemSettingsSeperator0,
            this.MenuItemSettingsEditGameRegions,
            this.MenuItemSettingsEditExternalApplications,
            this.MenuItemSettingsSeperator1});
            this.MenuItemOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemOptions.Name = "MenuItemOptions";
            this.MenuItemOptions.Size = new System.Drawing.Size(68, 19);
            this.MenuItemOptions.Text = "OPTIONS";
            // 
            // MenuItemSettingsAddNewConsole
            // 
            this.MenuItemSettingsAddNewConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAddNewConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAddNewConsole.Name = "MenuItemSettingsAddNewConsole";
            this.MenuItemSettingsAddNewConsole.Size = new System.Drawing.Size(182, 22);
            this.MenuItemSettingsAddNewConsole.Text = "Add New Console...";
            this.MenuItemSettingsAddNewConsole.Click += new System.EventHandler(this.MenuItemSettingsAddNewConsole_Click);
            // 
            // MenuItemSettingsSeperator0
            // 
            this.MenuItemSettingsSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSettingsSeperator0.Name = "MenuItemSettingsSeperator0";
            this.MenuItemSettingsSeperator0.Size = new System.Drawing.Size(179, 6);
            // 
            // MenuItemSettingsEditGameRegions
            // 
            this.MenuItemSettingsEditGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsEditGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsEditGameRegions.Name = "MenuItemSettingsEditGameRegions";
            this.MenuItemSettingsEditGameRegions.Size = new System.Drawing.Size(182, 22);
            this.MenuItemSettingsEditGameRegions.Text = "Edit Game Regions...";
            this.MenuItemSettingsEditGameRegions.Click += new System.EventHandler(this.MenuItemSettingsEditGameRegions_Click);
            // 
            // MenuItemSettingsEditExternalApplications
            // 
            this.MenuItemSettingsEditExternalApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsEditExternalApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsEditExternalApplications.Name = "MenuItemSettingsEditExternalApplications";
            this.MenuItemSettingsEditExternalApplications.Size = new System.Drawing.Size(182, 22);
            this.MenuItemSettingsEditExternalApplications.Text = "Edit Applications...";
            this.MenuItemSettingsEditExternalApplications.Click += new System.EventHandler(this.MenuItemSettingsEditExternalApplications_Click);
            // 
            // MenuItemSettingsSeperator1
            // 
            this.MenuItemSettingsSeperator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsSeperator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsSeperator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSettingsSeperator1.Name = "MenuItemSettingsSeperator1";
            this.MenuItemSettingsSeperator1.Size = new System.Drawing.Size(179, 6);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportIssue,
            this.MenuItemHelpDiscordServer,
            this.MenuItemOfficialSourceCode,
            this.MenuItemHelpSeperator0,
            this.MenuStripHelpOpenLogFile,
            this.MenuStripHelpOpenLogFolder,
            this.MenuItemHelpSeperator1,
            this.MenuStripHelpCheckForUpdates,
            this.MenuStripHelpWhatsNew,
            this.MenuItemHelpSeperator2,
            this.MenuStripHelpAbout});
            this.MenuItemHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(47, 19);
            this.MenuItemHelp.Text = "HELP";
            // 
            // MenuItemReportIssue
            // 
            this.MenuItemReportIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemReportIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemReportIssue.Name = "MenuItemReportIssue";
            this.MenuItemReportIssue.Size = new System.Drawing.Size(180, 22);
            this.MenuItemReportIssue.Text = "Report Bug...";
            this.MenuItemReportIssue.Click += new System.EventHandler(this.MenuItemHelpReportBugSuggestions_Click);
            // 
            // MenuItemHelpDiscordServer
            // 
            this.MenuItemHelpDiscordServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelpDiscordServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelpDiscordServer.Name = "MenuItemHelpDiscordServer";
            this.MenuItemHelpDiscordServer.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelpDiscordServer.Text = "Discord Server...";
            this.MenuItemHelpDiscordServer.Click += new System.EventHandler(this.MenuItemHelpDiscordServer_Click);
            // 
            // MenuItemOfficialSourceCode
            // 
            this.MenuItemOfficialSourceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemOfficialSourceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemOfficialSourceCode.Name = "MenuItemOfficialSourceCode";
            this.MenuItemOfficialSourceCode.Size = new System.Drawing.Size(180, 22);
            this.MenuItemOfficialSourceCode.Text = "Official Source...";
            this.MenuItemOfficialSourceCode.Click += new System.EventHandler(this.MenuItemHelpOfficialSourceCode_Click);
            // 
            // MenuItemHelpSeperator0
            // 
            this.MenuItemHelpSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelpSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelpSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemHelpSeperator0.Name = "MenuItemHelpSeperator0";
            this.MenuItemHelpSeperator0.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuStripHelpOpenLogFile
            // 
            this.MenuStripHelpOpenLogFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpOpenLogFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpOpenLogFile.Name = "MenuStripHelpOpenLogFile";
            this.MenuStripHelpOpenLogFile.Size = new System.Drawing.Size(180, 22);
            this.MenuStripHelpOpenLogFile.Text = "Open Log File...";
            this.MenuStripHelpOpenLogFile.Click += new System.EventHandler(this.MenuItemHelpOpenLogFile_Click);
            // 
            // MenuStripHelpOpenLogFolder
            // 
            this.MenuStripHelpOpenLogFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpOpenLogFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpOpenLogFolder.Name = "MenuStripHelpOpenLogFolder";
            this.MenuStripHelpOpenLogFolder.Size = new System.Drawing.Size(180, 22);
            this.MenuStripHelpOpenLogFolder.Text = "Open Log Folder...";
            this.MenuStripHelpOpenLogFolder.Click += new System.EventHandler(this.MenuItemHelpOpenLogFolder_Click);
            // 
            // MenuItemHelpSeperator1
            // 
            this.MenuItemHelpSeperator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelpSeperator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelpSeperator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemHelpSeperator1.Name = "MenuItemHelpSeperator1";
            this.MenuItemHelpSeperator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuStripHelpCheckForUpdates
            // 
            this.MenuStripHelpCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpCheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpCheckForUpdates.Name = "MenuStripHelpCheckForUpdates";
            this.MenuStripHelpCheckForUpdates.Size = new System.Drawing.Size(180, 22);
            this.MenuStripHelpCheckForUpdates.Text = "Check for Updates...";
            this.MenuStripHelpCheckForUpdates.Click += new System.EventHandler(this.MenuItemHelpCheckForUpdates_Click);
            // 
            // MenuStripHelpWhatsNew
            // 
            this.MenuStripHelpWhatsNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpWhatsNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpWhatsNew.Name = "MenuStripHelpWhatsNew";
            this.MenuStripHelpWhatsNew.Size = new System.Drawing.Size(180, 22);
            this.MenuStripHelpWhatsNew.Text = "What\'s New...";
            this.MenuStripHelpWhatsNew.Click += new System.EventHandler(this.MenuItemHelpWhatsNew_Click);
            // 
            // MenuItemHelpSeperator2
            // 
            this.MenuItemHelpSeperator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelpSeperator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelpSeperator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemHelpSeperator2.Name = "MenuItemHelpSeperator2";
            this.MenuItemHelpSeperator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuStripHelpAbout
            // 
            this.MenuStripHelpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpAbout.Name = "MenuStripHelpAbout";
            this.MenuStripHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.MenuStripHelpAbout.Text = "About...";
            this.MenuStripHelpAbout.Click += new System.EventHandler(this.MenuItemHelpAbout_Click);
            // 
            // MenuStripRefreshData
            // 
            this.MenuStripRefreshData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuStripRefreshData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripRefreshData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripRefreshData.Name = "MenuStripRefreshData";
            this.MenuStripRefreshData.Size = new System.Drawing.Size(97, 19);
            this.MenuStripRefreshData.Text = "REFRESH DATA";
            this.MenuStripRefreshData.Click += new System.EventHandler(this.MenuItemRefreshData_Click);
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
            this.ToolStripLabelConnectedConsole,
            this.ToolStripLabelConsole,
            this.ToolStripStatusSeperator0,
            this.ToolStripLabelStatus,
            this.ToolStripLabelStats});
            this.ToolStripFooter.Location = new System.Drawing.Point(0, 770);
            this.ToolStripFooter.Name = "ToolStripFooter";
            this.ToolStripFooter.Padding = new System.Windows.Forms.Padding(11, 0, 8, 5);
            this.ToolStripFooter.Size = new System.Drawing.Size(1584, 32);
            this.ToolStripFooter.TabIndex = 1146;
            this.ToolStripFooter.Text = "darkToolStrip1";
            // 
            // ToolStripLabelConnectedConsole
            // 
            this.ToolStripLabelConnectedConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConnectedConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConnectedConsole.Name = "ToolStripLabelConnectedConsole";
            this.ToolStripLabelConnectedConsole.Size = new System.Drawing.Size(96, 24);
            this.ToolStripLabelConnectedConsole.Text = "PS3 Connected  :";
            // 
            // ToolStripLabelConsole
            // 
            this.ToolStripLabelConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsole.Name = "ToolStripLabelConsole";
            this.ToolStripLabelConsole.Size = new System.Drawing.Size(26, 24);
            this.ToolStripLabelConsole.Text = "Idle";
            // 
            // ToolStripStatusSeperator0
            // 
            this.ToolStripStatusSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripStatusSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripStatusSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripStatusSeperator0.Name = "ToolStripStatusSeperator0";
            this.ToolStripStatusSeperator0.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(85, 24);
            this.ToolStripLabelStatus.Text = "Loading data...";
            // 
            // ToolStripLabelStats
            // 
            this.ToolStripLabelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStats.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.ToolStripLabelStats.Name = "ToolStripLabelStats";
            this.ToolStripLabelStats.Size = new System.Drawing.Size(348, 24);
            this.ToolStripLabelStats.Text = "## Mods for ## Games, ## Resources (Last Updated: 00/00/0000)";
            // 
            // LabelSelectSystemType
            // 
            this.LabelSelectSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectSystemType.AutoSize = true;
            this.LabelSelectSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectSystemType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectSystemType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectSystemType.Location = new System.Drawing.Point(406, 42);
            this.LabelSelectSystemType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectSystemType.Name = "LabelSelectSystemType";
            this.LabelSelectSystemType.Size = new System.Drawing.Size(78, 15);
            this.LabelSelectSystemType.TabIndex = 1156;
            this.LabelSelectSystemType.Text = "SYSTEM TYPE";
            // 
            // SectionModsLibrary
            // 
            this.SectionModsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionModsLibrary.Controls.Add(this.LabelNoModsFound);
            this.SectionModsLibrary.Controls.Add(this.DgvMods);
            this.SectionModsLibrary.Controls.Add(this.PanelModsLibraryFilters);
            this.SectionModsLibrary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionModsLibrary.Location = new System.Drawing.Point(286, 39);
            this.SectionModsLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.SectionModsLibrary.Name = "SectionModsLibrary";
            this.SectionModsLibrary.SectionHeader = "MODS LIBRARY";
            this.SectionModsLibrary.Size = new System.Drawing.Size(901, 493);
            this.SectionModsLibrary.TabIndex = 10;
            // 
            // LabelNoModsFound
            // 
            this.LabelNoModsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoModsFound.AutoSize = true;
            this.LabelNoModsFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelNoModsFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoModsFound.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsFound.Location = new System.Drawing.Point(396, 193);
            this.LabelNoModsFound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoModsFound.Name = "LabelNoModsFound";
            this.LabelNoModsFound.Size = new System.Drawing.Size(109, 15);
            this.LabelNoModsFound.TabIndex = 1159;
            this.LabelNoModsFound.Text = "NO MODS FOUND";
            // 
            // DgvMods
            // 
            this.DgvMods.AllowUserToAddRows = false;
            this.DgvMods.AllowUserToDeleteRows = false;
            this.DgvMods.AllowUserToDragDropRows = false;
            this.DgvMods.AllowUserToPasteCells = false;
            this.DgvMods.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvMods.ColumnHeadersHeight = 21;
            this.DgvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModsId,
            this.ColumnModsName,
            this.ColumnModsFirmware,
            this.ColumnModsType,
            this.ColumnModsRegion,
            this.ColumnModsVersion,
            this.ColumnModsAuthor,
            this.ColumnModsNoFiles,
            this.ColumnModsInstall,
            this.ColumnModsDownload,
            this.ColumnModsFavourite});
            this.DgvMods.ContextMenuStrip = this.ContextMenuMods;
            this.DgvMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMods.Location = new System.Drawing.Point(1, 121);
            this.DgvMods.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvMods.MultiSelect = false;
            this.DgvMods.Name = "DgvMods";
            this.DgvMods.ReadOnly = true;
            this.DgvMods.RowHeadersWidth = 41;
            this.DgvMods.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMods.RowTemplate.Height = 24;
            this.DgvMods.RowTemplate.ReadOnly = true;
            this.DgvMods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMods.ShowEditingIcon = false;
            this.DgvMods.Size = new System.Drawing.Size(899, 371);
            this.DgvMods.TabIndex = 6;
            this.DgvMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMods_CellClick);
            this.DgvMods.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvMods.SelectionChanged += new System.EventHandler(this.DgvMods_SelectionChanged);
            // 
            // ColumnModsId
            // 
            this.ColumnModsId.HeaderText = "Id";
            this.ColumnModsId.MinimumWidth = 6;
            this.ColumnModsId.Name = "ColumnModsId";
            this.ColumnModsId.ReadOnly = true;
            this.ColumnModsId.Visible = false;
            this.ColumnModsId.Width = 125;
            // 
            // ColumnModsName
            // 
            this.ColumnModsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsName.HeaderText = "Mod Name";
            this.ColumnModsName.MinimumWidth = 6;
            this.ColumnModsName.Name = "ColumnModsName";
            this.ColumnModsName.ReadOnly = true;
            // 
            // ColumnModsFirmware
            // 
            this.ColumnModsFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsFirmware.HeaderText = "System Type";
            this.ColumnModsFirmware.MinimumWidth = 6;
            this.ColumnModsFirmware.Name = "ColumnModsFirmware";
            this.ColumnModsFirmware.ReadOnly = true;
            this.ColumnModsFirmware.Width = 101;
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsType.HeaderText = "Mod Type";
            this.ColumnModsType.MinimumWidth = 6;
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            this.ColumnModsType.Width = 85;
            // 
            // ColumnModsRegion
            // 
            this.ColumnModsRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsRegion.HeaderText = "Region";
            this.ColumnModsRegion.MinimumWidth = 6;
            this.ColumnModsRegion.Name = "ColumnModsRegion";
            this.ColumnModsRegion.ReadOnly = true;
            this.ColumnModsRegion.Width = 70;
            // 
            // ColumnModsVersion
            // 
            this.ColumnModsVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsVersion.HeaderText = "Version";
            this.ColumnModsVersion.MinimumWidth = 6;
            this.ColumnModsVersion.Name = "ColumnModsVersion";
            this.ColumnModsVersion.ReadOnly = true;
            this.ColumnModsVersion.Width = 72;
            // 
            // ColumnModsAuthor
            // 
            this.ColumnModsAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsAuthor.HeaderText = "Creator";
            this.ColumnModsAuthor.MinimumWidth = 124;
            this.ColumnModsAuthor.Name = "ColumnModsAuthor";
            this.ColumnModsAuthor.ReadOnly = true;
            this.ColumnModsAuthor.Width = 124;
            // 
            // ColumnModsNoFiles
            // 
            this.ColumnModsNoFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsNoFiles.HeaderText = "# of Files";
            this.ColumnModsNoFiles.MinimumWidth = 6;
            this.ColumnModsNoFiles.Name = "ColumnModsNoFiles";
            this.ColumnModsNoFiles.ReadOnly = true;
            this.ColumnModsNoFiles.Width = 80;
            // 
            // ColumnModsInstall
            // 
            this.ColumnModsInstall.HeaderText = "";
            this.ColumnModsInstall.MinimumWidth = 6;
            this.ColumnModsInstall.Name = "ColumnModsInstall";
            this.ColumnModsInstall.ReadOnly = true;
            this.ColumnModsInstall.Width = 28;
            // 
            // ColumnModsDownload
            // 
            this.ColumnModsDownload.HeaderText = "";
            this.ColumnModsDownload.MinimumWidth = 6;
            this.ColumnModsDownload.Name = "ColumnModsDownload";
            this.ColumnModsDownload.ReadOnly = true;
            this.ColumnModsDownload.Width = 28;
            // 
            // ColumnModsFavourite
            // 
            this.ColumnModsFavourite.HeaderText = "";
            this.ColumnModsFavourite.MinimumWidth = 6;
            this.ColumnModsFavourite.Name = "ColumnModsFavourite";
            this.ColumnModsFavourite.ReadOnly = true;
            this.ColumnModsFavourite.Width = 28;
            // 
            // PanelModsLibraryFilters
            // 
            this.PanelModsLibraryFilters.Controls.Add(this.comboBoxEdit1);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxRegion);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectRegion);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelTitleMods);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelTitleFilterMods);
            this.PanelModsLibraryFilters.Controls.Add(this.TextBoxSearch);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSearch);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxModType);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectSystemType);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectType);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxSystemType);
            this.PanelModsLibraryFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModsLibraryFilters.Location = new System.Drawing.Point(1, 25);
            this.PanelModsLibraryFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsLibraryFilters.Name = "PanelModsLibraryFilters";
            this.PanelModsLibraryFilters.Size = new System.Drawing.Size(899, 96);
            this.PanelModsLibraryFilters.TabIndex = 12;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(490, 39);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(60, 20);
            this.comboBoxEdit1.TabIndex = 1164;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barSubItem1,
            this.barToolbarsListItem1,
            this.barWorkspaceMenuItem1,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.EditYourLists,
            this.barButtonItem16,
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 20;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.bar2.BarItemVertIndent = 5;
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "CONNECT";
            this.barButtonItem1.DropDownControl = this.ConnectMenu;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ConnectMenu
            // 
            this.ConnectMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.ConnectMenu.Manager = this.barManager1;
            this.ConnectMenu.Name = "ConnectMenu";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "PS3";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "XBOX 360";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ActAsDropDown = true;
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem2.Caption = "TOOLS";
            this.barButtonItem2.DropDownControl = this.ToolsMenu;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.ToolsMenu.Manager = this.barManager1;
            this.ToolsMenu.Name = "ToolsMenu";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Game Backup Files...";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Game Update Finder...";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "File Manager...";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Package Manager...";
            this.barButtonItem11.Id = 13;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.ActAsDropDown = true;
            this.barButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem3.Caption = "APPLICATIONS";
            this.barButtonItem3.DropDownControl = this.ApplicationsMenu;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ApplicationsMenu
            // 
            this.ApplicationsMenu.Manager = this.barManager1;
            this.ApplicationsMenu.Name = "ApplicationsMenu";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.Caption = "OPTIONS";
            this.barButtonItem4.DropDownControl = this.OptionsMenu;
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem13, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditYourLists),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem16, true)});
            this.OptionsMenu.Manager = this.barManager1;
            this.OptionsMenu.Name = "OptionsMenu";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Add New Console...";
            this.barButtonItem12.Id = 14;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Edit Game Regions...";
            this.barButtonItem13.Id = 15;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Edit Applications...";
            this.barButtonItem14.Id = 16;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // EditYourLists
            // 
            this.EditYourLists.Caption = "Edit Your Lists...";
            this.EditYourLists.Id = 17;
            this.EditYourLists.Name = "EditYourLists";
            this.EditYourLists.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditYourLists_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Settings...";
            this.barButtonItem16.Id = 18;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Settings_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem5.Caption = "HELP";
            this.barButtonItem5.DropDownControl = this.HelpMenu;
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // HelpMenu
            // 
            this.HelpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.HelpMenu.Manager = this.barManager1;
            this.HelpMenu.Name = "HelpMenu";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skin Changer";
            this.skinBarSubItem1.Id = 19;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1584, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 802);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1584, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 777);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1584, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 777);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 9;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 10;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 11;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxRegion.FormattingEnabled = true;
            this.ComboBoxRegion.Location = new System.Drawing.Point(787, 39);
            this.ComboBoxRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxRegion.Name = "ComboBoxRegion";
            this.ComboBoxRegion.Size = new System.Drawing.Size(104, 24);
            this.ComboBoxRegion.TabIndex = 5;
            this.ComboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRegion_SelectedIndexChanged);
            // 
            // LabelSelectRegion
            // 
            this.LabelSelectRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectRegion.AutoSize = true;
            this.LabelSelectRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectRegion.Location = new System.Drawing.Point(732, 42);
            this.LabelSelectRegion.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectRegion.Name = "LabelSelectRegion";
            this.LabelSelectRegion.Size = new System.Drawing.Size(49, 15);
            this.LabelSelectRegion.TabIndex = 1163;
            this.LabelSelectRegion.Text = "REGION";
            // 
            // LabelTitleMods
            // 
            this.LabelTitleMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleMods.Location = new System.Drawing.Point(7, 70);
            this.LabelTitleMods.Name = "LabelTitleMods";
            this.LabelTitleMods.Size = new System.Drawing.Size(884, 17);
            this.LabelTitleMods.TabIndex = 1161;
            this.LabelTitleMods.Text = "MODS";
            // 
            // LabelTitleFilterMods
            // 
            this.LabelTitleFilterMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleFilterMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleFilterMods.Location = new System.Drawing.Point(7, 10);
            this.LabelTitleFilterMods.Name = "LabelTitleFilterMods";
            this.LabelTitleFilterMods.Size = new System.Drawing.Size(884, 17);
            this.LabelTitleFilterMods.TabIndex = 1159;
            this.LabelTitleFilterMods.Text = "FILTER MODS";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxSearch.Location = new System.Drawing.Point(61, 38);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(337, 23);
            this.TextBoxSearch.TabIndex = 1158;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(4, 42);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(51, 15);
            this.LabelSearch.TabIndex = 1157;
            this.LabelSearch.Text = "SEARCH";
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxModType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxModType.FormattingEnabled = true;
            this.ComboBoxModType.Location = new System.Drawing.Point(628, 38);
            this.ComboBoxModType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Size = new System.Drawing.Size(96, 24);
            this.ComboBoxModType.TabIndex = 4;
            this.ComboBoxModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // ComboBoxSystemType
            // 
            this.ComboBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSystemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSystemType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSystemType.FormattingEnabled = true;
            this.ComboBoxSystemType.Location = new System.Drawing.Point(490, 38);
            this.ComboBoxSystemType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxSystemType.Name = "ComboBoxSystemType";
            this.ComboBoxSystemType.Size = new System.Drawing.Size(60, 24);
            this.ComboBoxSystemType.TabIndex = 3;
            this.ComboBoxSystemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFirmware_SelectedIndexChanged);
            // 
            // SectionGames
            // 
            this.SectionGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SectionGames.Controls.Add(this.ScrollBarCategories);
            this.SectionGames.Controls.Add(this.FlowPanelCategories);
            this.SectionGames.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionGames.Location = new System.Drawing.Point(13, 39);
            this.SectionGames.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.SectionGames.Name = "SectionGames";
            this.SectionGames.SectionHeader = "CATEGORIES";
            this.SectionGames.Size = new System.Drawing.Size(265, 743);
            this.SectionGames.TabIndex = 0;
            // 
            // ScrollBarCategories
            // 
            this.ScrollBarCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarCategories.Location = new System.Drawing.Point(247, 25);
            this.ScrollBarCategories.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.ScrollBarCategories.Name = "ScrollBarCategories";
            this.ScrollBarCategories.Size = new System.Drawing.Size(17, 717);
            this.ScrollBarCategories.TabIndex = 1174;
            this.ScrollBarCategories.Text = "darkScrollBar1";
            this.ScrollBarCategories.ViewSize = 1;
            this.ScrollBarCategories.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarCategories_ValueChanged);
            // 
            // FlowPanelCategories
            // 
            this.FlowPanelCategories.AutoScroll = true;
            this.FlowPanelCategories.Controls.Add(this.LabelTitleGames);
            this.FlowPanelCategories.Controls.Add(this.PanelGames);
            this.FlowPanelCategories.Controls.Add(this.LabelTitleHomebrew);
            this.FlowPanelCategories.Controls.Add(this.PanelHomebrew);
            this.FlowPanelCategories.Controls.Add(this.LabelTitleResources);
            this.FlowPanelCategories.Controls.Add(this.PanelResources);
            this.FlowPanelCategories.Controls.Add(this.LabelTitleMyLists);
            this.FlowPanelCategories.Controls.Add(this.PanelLists);
            this.FlowPanelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelCategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanelCategories.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FlowPanelCategories.Name = "FlowPanelCategories";
            this.FlowPanelCategories.Padding = new System.Windows.Forms.Padding(2, 6, 0, 11);
            this.FlowPanelCategories.Size = new System.Drawing.Size(263, 717);
            this.FlowPanelCategories.TabIndex = 0;
            this.FlowPanelCategories.WrapContents = false;
            this.FlowPanelCategories.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FlowPanelCategories_MouseWheel);
            // 
            // LabelTitleGames
            // 
            this.LabelTitleGames.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleGames.Location = new System.Drawing.Point(7, 9);
            this.LabelTitleGames.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.LabelTitleGames.Name = "LabelTitleGames";
            this.LabelTitleGames.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleGames.TabIndex = 1161;
            this.LabelTitleGames.Text = "GAMES";
            // 
            // PanelGames
            // 
            this.PanelGames.AutoSize = true;
            this.PanelGames.BackColor = System.Drawing.Color.Transparent;
            this.PanelGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelGames.Location = new System.Drawing.Point(2, 30);
            this.PanelGames.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelGames.Name = "PanelGames";
            this.PanelGames.Size = new System.Drawing.Size(244, 0);
            this.PanelGames.TabIndex = 0;
            // 
            // LabelTitleHomebrew
            // 
            this.LabelTitleHomebrew.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleHomebrew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleHomebrew.Location = new System.Drawing.Point(7, 38);
            this.LabelTitleHomebrew.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleHomebrew.Name = "LabelTitleHomebrew";
            this.LabelTitleHomebrew.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleHomebrew.TabIndex = 1167;
            this.LabelTitleHomebrew.Text = "HOMEBREW PACKAGES";
            // 
            // PanelHomebrew
            // 
            this.PanelHomebrew.AutoSize = true;
            this.PanelHomebrew.BackColor = System.Drawing.Color.Transparent;
            this.PanelHomebrew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHomebrew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelHomebrew.Location = new System.Drawing.Point(2, 59);
            this.PanelHomebrew.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelHomebrew.Name = "PanelHomebrew";
            this.PanelHomebrew.Size = new System.Drawing.Size(244, 0);
            this.PanelHomebrew.TabIndex = 1168;
            // 
            // LabelTitleResources
            // 
            this.LabelTitleResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleResources.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleResources.Location = new System.Drawing.Point(7, 67);
            this.LabelTitleResources.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleResources.Name = "LabelTitleResources";
            this.LabelTitleResources.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleResources.TabIndex = 1163;
            this.LabelTitleResources.Text = "RESOURCES";
            // 
            // PanelResources
            // 
            this.PanelResources.AutoSize = true;
            this.PanelResources.BackColor = System.Drawing.Color.Transparent;
            this.PanelResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResources.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelResources.Location = new System.Drawing.Point(2, 88);
            this.PanelResources.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelResources.Name = "PanelResources";
            this.PanelResources.Size = new System.Drawing.Size(244, 0);
            this.PanelResources.TabIndex = 1164;
            // 
            // LabelTitleMyLists
            // 
            this.LabelTitleMyLists.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleMyLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleMyLists.Location = new System.Drawing.Point(7, 96);
            this.LabelTitleMyLists.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleMyLists.Name = "LabelTitleMyLists";
            this.LabelTitleMyLists.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleMyLists.TabIndex = 1165;
            this.LabelTitleMyLists.Text = "MY LISTS";
            // 
            // PanelLists
            // 
            this.PanelLists.AutoSize = true;
            this.PanelLists.BackColor = System.Drawing.Color.Transparent;
            this.PanelLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLists.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelLists.Location = new System.Drawing.Point(2, 117);
            this.PanelLists.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelLists.Name = "PanelLists";
            this.PanelLists.Size = new System.Drawing.Size(244, 0);
            this.PanelLists.TabIndex = 1166;
            // 
            // SectionInstalledGameMods
            // 
            this.SectionInstalledGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionInstalledGameMods.Controls.Add(this.LabelNoModsInstalled);
            this.SectionInstalledGameMods.Controls.Add(this.DgvGameModsInstalled);
            this.SectionInstalledGameMods.Controls.Add(this.PanelModsInstalledHeader);
            this.SectionInstalledGameMods.Controls.Add(this.MenuStripGameMods);
            this.SectionInstalledGameMods.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionInstalledGameMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionInstalledGameMods.Location = new System.Drawing.Point(286, 539);
            this.SectionInstalledGameMods.Margin = new System.Windows.Forms.Padding(4);
            this.SectionInstalledGameMods.Name = "SectionInstalledGameMods";
            this.SectionInstalledGameMods.SectionHeader = "MODS INSTALLED";
            this.SectionInstalledGameMods.Size = new System.Drawing.Size(901, 243);
            this.SectionInstalledGameMods.TabIndex = 1175;
            // 
            // LabelNoModsInstalled
            // 
            this.LabelNoModsInstalled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoModsInstalled.AutoSize = true;
            this.LabelNoModsInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelNoModsInstalled.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsInstalled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoModsInstalled.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsInstalled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsInstalled.Location = new System.Drawing.Point(386, 114);
            this.LabelNoModsInstalled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoModsInstalled.Name = "LabelNoModsInstalled";
            this.LabelNoModsInstalled.Size = new System.Drawing.Size(128, 15);
            this.LabelNoModsInstalled.TabIndex = 1178;
            this.LabelNoModsInstalled.Text = "NO MODS INSTALLED";
            // 
            // DgvGameModsInstalled
            // 
            this.DgvGameModsInstalled.AllowUserToAddRows = false;
            this.DgvGameModsInstalled.AllowUserToDeleteRows = false;
            this.DgvGameModsInstalled.AllowUserToDragDropRows = false;
            this.DgvGameModsInstalled.AllowUserToPasteCells = false;
            this.DgvGameModsInstalled.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvGameModsInstalled.ColumnHeadersHeight = 21;
            this.DgvGameModsInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvGameModsInstalled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModsInstalledId,
            this.ColumnModsInstalledGameTitle,
            this.ColumnModsInstalledRegion,
            this.ColumnModsInstalledModName,
            this.ColumnModsInstalledModType,
            this.ColumnModsInstalledVersion,
            this.ColumnModsInstalledNoOfFiles,
            this.ColumnModsInstalledDateTime,
            this.ColumnModsInstalledUninstall});
            this.DgvGameModsInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGameModsInstalled.Location = new System.Drawing.Point(1, 61);
            this.DgvGameModsInstalled.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvGameModsInstalled.MultiSelect = false;
            this.DgvGameModsInstalled.Name = "DgvGameModsInstalled";
            this.DgvGameModsInstalled.ReadOnly = true;
            this.DgvGameModsInstalled.RowHeadersWidth = 41;
            this.DgvGameModsInstalled.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvGameModsInstalled.RowTemplate.Height = 24;
            this.DgvGameModsInstalled.RowTemplate.ReadOnly = true;
            this.DgvGameModsInstalled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvGameModsInstalled.ShowEditingIcon = false;
            this.DgvGameModsInstalled.Size = new System.Drawing.Size(899, 145);
            this.DgvGameModsInstalled.TabIndex = 7;
            this.DgvGameModsInstalled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModsInstalled_CellClick);
            this.DgvGameModsInstalled.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvGameModsInstalled.SelectionChanged += new System.EventHandler(this.DgvModsInstalled_SelectionChanged);
            // 
            // ColumnModsInstalledId
            // 
            this.ColumnModsInstalledId.HeaderText = "Mod Id";
            this.ColumnModsInstalledId.MinimumWidth = 6;
            this.ColumnModsInstalledId.Name = "ColumnModsInstalledId";
            this.ColumnModsInstalledId.ReadOnly = true;
            this.ColumnModsInstalledId.Visible = false;
            this.ColumnModsInstalledId.Width = 125;
            // 
            // ColumnModsInstalledGameTitle
            // 
            this.ColumnModsInstalledGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsInstalledGameTitle.HeaderText = "Game Title";
            this.ColumnModsInstalledGameTitle.MinimumWidth = 6;
            this.ColumnModsInstalledGameTitle.Name = "ColumnModsInstalledGameTitle";
            this.ColumnModsInstalledGameTitle.ReadOnly = true;
            // 
            // ColumnModsInstalledRegion
            // 
            this.ColumnModsInstalledRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledRegion.HeaderText = "Region";
            this.ColumnModsInstalledRegion.MinimumWidth = 6;
            this.ColumnModsInstalledRegion.Name = "ColumnModsInstalledRegion";
            this.ColumnModsInstalledRegion.ReadOnly = true;
            this.ColumnModsInstalledRegion.Width = 70;
            // 
            // ColumnModsInstalledModName
            // 
            this.ColumnModsInstalledModName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsInstalledModName.HeaderText = "Mod Name";
            this.ColumnModsInstalledModName.MinimumWidth = 6;
            this.ColumnModsInstalledModName.Name = "ColumnModsInstalledModName";
            this.ColumnModsInstalledModName.ReadOnly = true;
            // 
            // ColumnModsInstalledModType
            // 
            this.ColumnModsInstalledModType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledModType.HeaderText = "Mod Type";
            this.ColumnModsInstalledModType.MinimumWidth = 6;
            this.ColumnModsInstalledModType.Name = "ColumnModsInstalledModType";
            this.ColumnModsInstalledModType.ReadOnly = true;
            this.ColumnModsInstalledModType.Width = 85;
            // 
            // ColumnModsInstalledVersion
            // 
            this.ColumnModsInstalledVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledVersion.HeaderText = "Version";
            this.ColumnModsInstalledVersion.MinimumWidth = 6;
            this.ColumnModsInstalledVersion.Name = "ColumnModsInstalledVersion";
            this.ColumnModsInstalledVersion.ReadOnly = true;
            this.ColumnModsInstalledVersion.Width = 72;
            // 
            // ColumnModsInstalledNoOfFiles
            // 
            this.ColumnModsInstalledNoOfFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledNoOfFiles.HeaderText = "# Files";
            this.ColumnModsInstalledNoOfFiles.MinimumWidth = 6;
            this.ColumnModsInstalledNoOfFiles.Name = "ColumnModsInstalledNoOfFiles";
            this.ColumnModsInstalledNoOfFiles.ReadOnly = true;
            this.ColumnModsInstalledNoOfFiles.Width = 65;
            // 
            // ColumnModsInstalledDateTime
            // 
            this.ColumnModsInstalledDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledDateTime.HeaderText = "Installed On";
            this.ColumnModsInstalledDateTime.Name = "ColumnModsInstalledDateTime";
            this.ColumnModsInstalledDateTime.ReadOnly = true;
            this.ColumnModsInstalledDateTime.Width = 97;
            // 
            // ColumnModsInstalledUninstall
            // 
            this.ColumnModsInstalledUninstall.HeaderText = "";
            this.ColumnModsInstalledUninstall.MinimumWidth = 6;
            this.ColumnModsInstalledUninstall.Name = "ColumnModsInstalledUninstall";
            this.ColumnModsInstalledUninstall.ReadOnly = true;
            this.ColumnModsInstalledUninstall.Width = 28;
            // 
            // PanelModsInstalledHeader
            // 
            this.PanelModsInstalledHeader.Controls.Add(this.LabelHeaderGameMods);
            this.PanelModsInstalledHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModsInstalledHeader.Location = new System.Drawing.Point(1, 25);
            this.PanelModsInstalledHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsInstalledHeader.Name = "PanelModsInstalledHeader";
            this.PanelModsInstalledHeader.Size = new System.Drawing.Size(899, 36);
            this.PanelModsInstalledHeader.TabIndex = 1177;
            // 
            // LabelHeaderGameMods
            // 
            this.LabelHeaderGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderGameMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGameMods.Location = new System.Drawing.Point(7, 10);
            this.LabelHeaderGameMods.Name = "LabelHeaderGameMods";
            this.LabelHeaderGameMods.Size = new System.Drawing.Size(887, 17);
            this.LabelHeaderGameMods.TabIndex = 1160;
            this.LabelHeaderGameMods.Text = "GAME MODS";
            // 
            // MenuStripGameMods
            // 
            this.MenuStripGameMods.AutoSize = false;
            this.MenuStripGameMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripGameMods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStripGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripGameMods.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuStripGameMods.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripGameMods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemGameModsUninstallAll,
            this.LabelInstalledGameModsStatus});
            this.MenuStripGameMods.Location = new System.Drawing.Point(1, 206);
            this.MenuStripGameMods.Name = "MenuStripGameMods";
            this.MenuStripGameMods.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.MenuStripGameMods.Size = new System.Drawing.Size(899, 36);
            this.MenuStripGameMods.TabIndex = 8;
            this.MenuStripGameMods.TabStop = true;
            this.MenuStripGameMods.Text = "darkToolStrip2";
            // 
            // ToolItemGameModsUninstallAll
            // 
            this.ToolItemGameModsUninstallAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolItemGameModsUninstallAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemGameModsUninstallAll.Enabled = false;
            this.ToolItemGameModsUninstallAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemGameModsUninstallAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemGameModsUninstallAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemGameModsUninstallAll.Image")));
            this.ToolItemGameModsUninstallAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemGameModsUninstallAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemGameModsUninstallAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemGameModsUninstallAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemGameModsUninstallAll.Name = "ToolItemGameModsUninstallAll";
            this.ToolItemGameModsUninstallAll.Size = new System.Drawing.Size(98, 26);
            this.ToolItemGameModsUninstallAll.Text = "Uninstall All";
            this.ToolItemGameModsUninstallAll.ToolTipText = "Uninstall All Mods from Console";
            this.ToolItemGameModsUninstallAll.Click += new System.EventHandler(this.ToolItemUninstallAllGameMods_Click);
            // 
            // LabelInstalledGameModsStatus
            // 
            this.LabelInstalledGameModsStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelInstalledGameModsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelInstalledGameModsStatus.Name = "LabelInstalledGameModsStatus";
            this.LabelInstalledGameModsStatus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelInstalledGameModsStatus.Size = new System.Drawing.Size(170, 33);
            this.LabelInstalledGameModsStatus.Text = "0 Mods Installed (0 Files Total)";
            // 
            // MainWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.SectionInstalledGameMods);
            this.Controls.Add(this.ToolStripFooter);
            this.Controls.Add(this.MenuStripHeader);
            this.Controls.Add(this.SectionArchiveInformation);
            this.Controls.Add(this.SectionModsLibrary);
            this.Controls.Add(this.SectionGames);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainWindow.IconOptions.Icon")));
            this.MainMenuStrip = this.MenuStripHeader;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1586, 853);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ContextMenuMods.ResumeLayout(false);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.SectionModsInstallFilePaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallationFiles)).EndInit();
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.PanelModsInstallationPaths.ResumeLayout(false);
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.MenuStripHeader.ResumeLayout(false);
            this.MenuStripHeader.PerformLayout();
            this.ToolStripFooter.ResumeLayout(false);
            this.ToolStripFooter.PerformLayout();
            this.SectionModsLibrary.ResumeLayout(false);
            this.SectionModsLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).EndInit();
            this.PanelModsLibraryFilters.ResumeLayout(false);
            this.PanelModsLibraryFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpMenu)).EndInit();
            this.SectionGames.ResumeLayout(false);
            this.FlowPanelCategories.ResumeLayout(false);
            this.FlowPanelCategories.PerformLayout();
            this.SectionInstalledGameMods.ResumeLayout(false);
            this.SectionInstalledGameMods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGameModsInstalled)).EndInit();
            this.PanelModsInstalledHeader.ResumeLayout(false);
            this.MenuStripGameMods.ResumeLayout(false);
            this.MenuStripGameMods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSelectType;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelHeaderAuthor;
        private System.Windows.Forms.Label LabelHeaderVersion;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelHeaderGameType;
        private System.Windows.Forms.Label LabelConfig;
        private System.Windows.Forms.Label LabelDescription;
        private DarkUI.Controls.DarkScrollBar ScrollBarDetails;
        private DarkUI.Controls.DarkSectionPanel SectionArchiveInformation;
        private DarkUI.Controls.DarkMenuStrip MenuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator0;
        private DarkUI.Controls.DarkToolStrip ToolStripFooter;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnectedConsole;
        private System.Windows.Forms.ToolStripSeparator ToolStripStatusSeperator0;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
        private System.Windows.Forms.Label LabelHeaderSubmittedBy;
        private System.Windows.Forms.Label LabelSubmittedBy;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelHeaderModType;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelSelectSystemType;
        private System.Windows.Forms.Label LabelHeaderFirmware;
        private System.Windows.Forms.Label LabelFirmware;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelHeaderCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOfficialSourceCode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportIssue;
        private System.Windows.Forms.ToolStripSeparator MenuItemHelpSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpAbout;
        private DarkUI.Controls.DarkContextMenu ContextMenuMods;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsInstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsUninstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsDownloadArchive;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeparator0;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsReportOnGitHub;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools;
        private System.Windows.Forms.ToolStripButton ToolItemModInstall;
        private System.Windows.Forms.ToolStripButton ToolItemModDownload;
        private DarkUI.Controls.DarkSectionPanel SectionModsLibrary;
        private DarkUI.Controls.DarkSectionPanel SectionGames;
        private DarkUI.Controls.DarkComboBox ComboBoxSystemType;
        private DarkUI.Controls.DarkComboBox ComboBoxModType;
        private XDevkit.XtraDataGridView DgvMods;
        private DarkUI.Controls.DarkSectionPanel SectionModsInstallFilePaths;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsGameBackupFiles;
        private System.Windows.Forms.ToolStripButton ToolItemModUninstall;
        private System.Windows.Forms.ToolStripButton ToolItemModAddToFavorite;
        private System.Windows.Forms.Panel PanelModsInstallationPaths;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectExit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRefreshData;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectPS3Console;
        private System.Windows.Forms.ToolStripSeparator MenuItemToolsSeperator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsFileManager;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAddNewConsole;
        private System.Windows.Forms.ToolStripSeparator MenuItemSettingsSeperator0;
        private System.Windows.Forms.Panel PanelModsLibraryFilters;
        private DarkUI.Controls.DarkTextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private DarkUI.Controls.DarkTitle LabelTitleMods;
        private DarkUI.Controls.DarkTitle LabelTitleFilterMods;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelCategories;
        private DarkUI.Controls.DarkTitle LabelTitleGames;
        private System.Windows.Forms.FlowLayoutPanel PanelGames;
        private DarkUI.Controls.DarkTitle LabelTitleResources;
        private System.Windows.Forms.FlowLayoutPanel PanelResources;
        private DarkUI.Controls.DarkScrollBar ScrollBarCategories;
        private DarkUI.Controls.DarkTitle LabelTitleMyLists;
        private System.Windows.Forms.FlowLayoutPanel PanelLists;
        private DarkUI.Controls.DarkTitle LabelTitleModDetails;
        private DarkUI.Controls.DarkTitle LabelTitleModDescription;
        private DarkUI.Controls.DarkSectionPanel SectionInstalledGameMods;
        private XDevkit.XtraDataGridView DgvGameModsInstalled;
        private System.Windows.Forms.Panel PanelModsInstalledHeader;
        private DarkUI.Controls.DarkTitle LabelHeaderGameMods;
        private DarkUI.Controls.DarkTitle LabelHeaderInstallationFiles;
        private DarkUI.Controls.DarkToolStrip MenuStripGameMods;
        private System.Windows.Forms.ToolStripButton ToolItemGameModsUninstallAll;
        private System.Windows.Forms.ToolStripLabel LabelInstalledGameModsStatus;
        private System.Windows.Forms.Label LabelHeaderRegion;
        private System.Windows.Forms.Label LabelRegion;
        private DarkUI.Controls.DarkComboBox ComboBoxRegion;
        private System.Windows.Forms.Label LabelSelectRegion;
        private System.Windows.Forms.Label LabelNoModsFound;
        private System.Windows.Forms.Label LabelNoModsInstalled;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsEditGameRegions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsEditExternalApplications;
        private System.Windows.Forms.ToolStripSeparator MenuItemSettingsSeperator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpDiscordServer;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpCheckForUpdates;
        private DarkUI.Controls.DarkTitle LabelTitleHomebrew;
        private System.Windows.Forms.FlowLayoutPanel PanelHomebrew;
        private System.Windows.Forms.ToolStripSeparator MenuItemHelpSeperator1;
        private XDevkit.XtraDataGridView DgvInstallationFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstallationFiles;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsGameUpdatesFinder;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManControls;
        private System.Windows.Forms.ToolStripSeparator MenuItemToolsSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManNotify;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripWebManSystemInformation;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripWebManPowerFunctions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManShutdown;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManRestart;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManShowMinVersion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManShowCPURSX;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripWebManShowSystemInformation;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManVirtualController;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManSoftReboot;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsWebManHardReboot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsAddToList;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsRemoveFromList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsPackageManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsFirmware;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsNoFiles;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsInstall;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsDownload;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsFavourite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledModType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledNoOfFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledDateTime;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsInstalledUninstall;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpWhatsNew;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpOpenLogFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpOpenLogFolder;
        private System.Windows.Forms.ToolStripSeparator MenuItemHelpSeperator2;
        private System.Windows.Forms.ToolStripMenuItem xBOXToolStripMenuItem;
        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem barButtonItem1;
        private PopupMenu HelpMenu;
        private BarButtonItem barButtonItem2;
        private PopupMenu OptionsMenu;
        private BarButtonItem barButtonItem3;
        private PopupMenu ApplicationsMenu;
        private BarButtonItem barButtonItem4;
        private PopupMenu ToolsMenu;
        private BarButtonItem barButtonItem5;
        private PopupMenu ConnectMenu;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private ComboBoxEdit comboBoxEdit1;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarButtonItem barButtonItem10;
        private BarButtonItem barButtonItem11;
        private BarSubItem barSubItem1;
        private BarToolbarsListItem barToolbarsListItem1;
        private BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private BarButtonItem barButtonItem12;
        private BarButtonItem barButtonItem13;
        private BarButtonItem barButtonItem14;
        private BarButtonItem EditYourLists;
        private BarButtonItem barButtonItem16;
        private SkinBarSubItem skinBarSubItem1;
    }
}