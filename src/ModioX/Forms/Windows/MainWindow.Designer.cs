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
            DevExpress.XtraBars.BarButtonItem ButtonConnectXbox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            DevExpress.Utils.Animation.PushTransition pushTransition2 = new DevExpress.Utils.Animation.PushTransition();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ContextMenuMods = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuModsInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsUninstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsDownloadArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsAddToList = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsRemoveFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsReportOnGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSelectType = new DevExpress.XtraEditors.LabelControl();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderName = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFirmware = new DevExpress.XtraEditors.LabelControl();
            this.LabelFirmware = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelType = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderGameType = new DevExpress.XtraEditors.LabelControl();
            this.LabelConfig = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderAuthor = new DevExpress.XtraEditors.LabelControl();
            this.LabelAuthor = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.GridControlModsInstallFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewModsInstallFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnInstallationFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolItemModInstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModUninstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModDownload = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModAddToFavorite = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripStatusSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.LabelSelectSystemType = new DevExpress.XtraEditors.LabelControl();
            this.PanelModsLibraryFilters = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.MainMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.MenuBarItemConnect = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonPS3 = new DevExpress.XtraBars.BarSubItem();
            this.ButtonConnectToPS3 = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXbox360 = new DevExpress.XtraBars.BarSubItem();
            this.ButtonConnectToXBOX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBarItemTools = new DevExpress.XtraBars.BarButtonItem();
            this.ToolsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonGameBackupFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonGameUpdateFinder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonFileManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPackageManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonWebManControls = new DevExpress.XtraBars.BarSubItem();
            this.ButtonPowerFunctions = new DevExpress.XtraBars.BarSubItem();
            this.ButtonShutdown = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonRestart = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonSystemInfo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonShowSystemInformation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem24 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem26 = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonNotifyMessage = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonVirtualController = new DevExpress.XtraBars.BarButtonItem();
            this.XBDMMenu = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.xbdmShutdown = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBarItemApplications = new DevExpress.XtraBars.BarButtonItem();
            this.ApplicationsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuBarItemOptions = new DevExpress.XtraBars.BarButtonItem();
            this.OptionsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonAddNewConsole = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonEditGameRegions = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonEditApplications = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonEditLists = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonExit = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBarItemHelp = new DevExpress.XtraBars.BarButtonItem();
            this.HelpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ReportBugButton = new DevExpress.XtraBars.BarButtonItem();
            this.DiscordServerButton = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonOfficialSource = new DevExpress.XtraBars.BarButtonItem();
            this.OpenLogFileButton = new DevExpress.XtraBars.BarButtonItem();
            this.OpenLogFolderButton = new DevExpress.XtraBars.BarButtonItem();
            this.CheckForUpdateButton = new DevExpress.XtraBars.BarButtonItem();
            this.WhatsNewButton = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonSkinManager = new DevExpress.XtraBars.SkinBarSubItem();
            this.AboutBar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.LabelHeaderConsoleConnected = new DevExpress.XtraBars.BarHeaderItem();
            this.LabelConsoleConnected = new DevExpress.XtraBars.BarStaticItem();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarHeaderItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DockModInformation = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.HelpSpacer1 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpSpacer2 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpSpacer3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barButtonItem27 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem28 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem2 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.ButtonModInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModUninstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModDownloadArchive = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModAddToList = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModRemoveFromList = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModReportAnIssue = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem3 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxSystemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelSelectRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
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
            this.GridControlGameModsInstalled = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameModsInstalled = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolItemGameModsUninstallAll = new System.Windows.Forms.ToolStripButton();
            this.LabelInstalledGameModsStatus = new System.Windows.Forms.ToolStripLabel();
            this.ColumnModsInstalledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledNoOfFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledUninstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.GroupModsLibrary = new DevExpress.XtraEditors.GroupControl();
            this.ProgressMods = new DevExpress.XtraWaitForm.ProgressPanel();
            this.GridControlMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NavigationBar = new DevExpress.XtraNavBar.NavBarControl();
            this.NavGroupGames = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupHomebrewApps = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupResources = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupMyLists = new DevExpress.XtraNavBar.NavBarGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GroupModsInstalled = new DevExpress.XtraEditors.GroupControl();
            this.ProgressModsInstalled = new DevExpress.XtraWaitForm.ProgressPanel();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.GroupModInformation = new DevExpress.XtraEditors.GroupControl();
            this.ScrollBarModInformation = new DevExpress.XtraEditors.VScrollBar();
            this.GroupInstallFiles = new DevExpress.XtraEditors.GroupControl();
            this.ModsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMenuModInformation = new DevExpress.XtraBars.Bar();
            this.ButtonModInstall = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModUninstall = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModDownload = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModFavorite = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ButtonConnectXbox = new DevExpress.XtraBars.BarButtonItem();
            this.ContextMenuMods.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModsInstallFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModsInstallFiles)).BeginInit();
            this.PanelModsLibraryFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSystemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameModsInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameModsInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsLibrary)).BeginInit();
            this.GroupModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsInstalled)).BeginInit();
            this.GroupModsInstalled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModInformation)).BeginInit();
            this.GroupModInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallFiles)).BeginInit();
            this.GroupInstallFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConnectXbox
            // 
            ButtonConnectXbox.Caption = "Connect to Console...";
            ButtonConnectXbox.Id = 35;
            ButtonConnectXbox.Name = "ButtonConnectXbox";
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
            this.LabelSelectType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectType.Appearance.Options.UseFont = true;
            this.LabelSelectType.Appearance.Options.UseForeColor = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(541, 42);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(57, 15);
            this.LabelSelectType.TabIndex = 1122;
            this.LabelSelectType.Text = "MOD TYPE";
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.Controls.Add(this.labelControl3);
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
            this.FlowPanelDetails.Controls.Add(this.labelControl4);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(2, 23);
            this.FlowPanelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelDetails.MaximumSize = new System.Drawing.Size(373, 0);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(3, 8, 18, 4);
            this.FlowPanelDetails.Size = new System.Drawing.Size(373, 580);
            this.FlowPanelDetails.TabIndex = 0;
            this.FlowPanelDetails.TabStop = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.labelControl3, true);
            this.labelControl3.Location = new System.Drawing.Point(9, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6, 3, 3, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 15);
            this.labelControl3.TabIndex = 1168;
            this.labelControl3.Text = "DETAILS";
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.Appearance.Options.UseFont = true;
            this.LabelHeaderName.Appearance.Options.UseForeColor = true;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(9, 34);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(36, 15);
            this.LabelHeaderName.TabIndex = 26;
            this.LabelHeaderName.Text = "Name:";
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Appearance.Options.UseForeColor = true;
            this.LabelName.AutoEllipsis = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelName, true);
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(50, 34);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelName.MaximumSize = new System.Drawing.Size(300, 15);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(9, 15);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "...";
            // 
            // LabelHeaderCategory
            // 
            this.LabelHeaderCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCategory.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderCategory.Appearance.Options.UseFont = true;
            this.LabelHeaderCategory.Appearance.Options.UseForeColor = true;
            this.LabelHeaderCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCategory.Location = new System.Drawing.Point(9, 55);
            this.LabelHeaderCategory.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderCategory.Name = "LabelHeaderCategory";
            this.LabelHeaderCategory.Size = new System.Drawing.Size(53, 15);
            this.LabelHeaderCategory.TabIndex = 24;
            this.LabelHeaderCategory.Text = "Category:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCategory.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelCategory, true);
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(67, 55);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(9, 15);
            this.LabelCategory.TabIndex = 23;
            this.LabelCategory.Text = "...";
            // 
            // LabelHeaderFirmware
            // 
            this.LabelHeaderFirmware.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFirmware.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFirmware.Appearance.Options.UseFont = true;
            this.LabelHeaderFirmware.Appearance.Options.UseForeColor = true;
            this.LabelHeaderFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFirmware.Location = new System.Drawing.Point(9, 76);
            this.LabelHeaderFirmware.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderFirmware.Name = "LabelHeaderFirmware";
            this.LabelHeaderFirmware.Size = new System.Drawing.Size(74, 15);
            this.LabelHeaderFirmware.TabIndex = 20;
            this.LabelHeaderFirmware.Text = "System Type:";
            // 
            // LabelFirmware
            // 
            this.LabelFirmware.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFirmware.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFirmware.Appearance.Options.UseFont = true;
            this.LabelFirmware.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelFirmware, true);
            this.LabelFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFirmware.Location = new System.Drawing.Point(88, 76);
            this.LabelFirmware.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFirmware.Name = "LabelFirmware";
            this.LabelFirmware.Size = new System.Drawing.Size(9, 15);
            this.LabelFirmware.TabIndex = 21;
            this.LabelFirmware.Text = "...";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderModType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderModType.Appearance.Options.UseFont = true;
            this.LabelHeaderModType.Appearance.Options.UseForeColor = true;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(9, 97);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(58, 15);
            this.LabelHeaderModType.TabIndex = 16;
            this.LabelHeaderModType.Text = "Mod Type:";
            // 
            // LabelType
            // 
            this.LabelType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelType.Appearance.Options.UseFont = true;
            this.LabelType.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelType, true);
            this.LabelType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelType.Location = new System.Drawing.Point(72, 97);
            this.LabelType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(9, 15);
            this.LabelType.TabIndex = 17;
            this.LabelType.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderVersion.Appearance.Options.UseForeColor = true;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(9, 118);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderVersion.TabIndex = 3;
            this.LabelHeaderVersion.Text = "Version:";
            // 
            // LabelVersion
            // 
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelVersion, true);
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(59, 118);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(9, 15);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderRegion
            // 
            this.LabelHeaderRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderRegion.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderRegion.Appearance.Options.UseFont = true;
            this.LabelHeaderRegion.Appearance.Options.UseForeColor = true;
            this.LabelHeaderRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderRegion.Location = new System.Drawing.Point(9, 139);
            this.LabelHeaderRegion.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderRegion.Name = "LabelHeaderRegion";
            this.LabelHeaderRegion.Size = new System.Drawing.Size(78, 15);
            this.LabelHeaderRegion.TabIndex = 1164;
            this.LabelHeaderRegion.Text = "Game Region:";
            // 
            // LabelRegion
            // 
            this.LabelRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRegion.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelRegion.Appearance.Options.UseFont = true;
            this.LabelRegion.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelRegion, true);
            this.LabelRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRegion.Location = new System.Drawing.Point(92, 139);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(9, 15);
            this.LabelRegion.TabIndex = 1165;
            this.LabelRegion.Text = "...";
            // 
            // LabelHeaderGameType
            // 
            this.LabelHeaderGameType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderGameType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGameType.Appearance.Options.UseFont = true;
            this.LabelHeaderGameType.Appearance.Options.UseForeColor = true;
            this.LabelHeaderGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameType.Location = new System.Drawing.Point(9, 160);
            this.LabelHeaderGameType.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderGameType.Name = "LabelHeaderGameType";
            this.LabelHeaderGameType.Size = new System.Drawing.Size(66, 15);
            this.LabelHeaderGameType.TabIndex = 9;
            this.LabelHeaderGameType.Text = "Game Type:";
            // 
            // LabelConfig
            // 
            this.LabelConfig.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConfig.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConfig.Appearance.Options.UseFont = true;
            this.LabelConfig.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConfig, true);
            this.LabelConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConfig.Location = new System.Drawing.Point(80, 160);
            this.LabelConfig.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelConfig.Name = "LabelConfig";
            this.LabelConfig.Size = new System.Drawing.Size(9, 15);
            this.LabelConfig.TabIndex = 10;
            this.LabelConfig.Text = "...";
            // 
            // LabelHeaderAuthor
            // 
            this.LabelHeaderAuthor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAuthor.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderAuthor.Appearance.Options.UseFont = true;
            this.LabelHeaderAuthor.Appearance.Options.UseForeColor = true;
            this.LabelHeaderAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderAuthor.Location = new System.Drawing.Point(9, 181);
            this.LabelHeaderAuthor.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderAuthor.Name = "LabelHeaderAuthor";
            this.LabelHeaderAuthor.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderAuthor.TabIndex = 6;
            this.LabelHeaderAuthor.Text = "Created By:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAuthor.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelAuthor.Appearance.Options.UseFont = true;
            this.LabelAuthor.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelAuthor, true);
            this.LabelAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAuthor.Location = new System.Drawing.Point(78, 181);
            this.LabelAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(9, 15);
            this.LabelAuthor.TabIndex = 15;
            this.LabelAuthor.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelHeaderSubmittedBy.Appearance.Options.UseForeColor = true;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(9, 202);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(79, 15);
            this.LabelHeaderSubmittedBy.TabIndex = 13;
            this.LabelHeaderSubmittedBy.Text = "Submitted By:";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelSubmittedBy.Appearance.Options.UseForeColor = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelSubmittedBy, true);
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(93, 202);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(9, 15);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.labelControl4, true);
            this.labelControl4.Location = new System.Drawing.Point(9, 225);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 15);
            this.labelControl4.TabIndex = 1169;
            this.labelControl4.Text = "DESCRIPTION ";
            // 
            // LabelDescription
            // 
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.Appearance.Options.UseForeColor = true;
            this.LabelDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(9, 243);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(6, 3, 2, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(340, 0);
            this.LabelDescription.MinimumSize = new System.Drawing.Size(340, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.LabelDescription.Size = new System.Drawing.Size(340, 27);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            // 
            // GridControlModsInstallFiles
            // 
            this.GridControlModsInstallFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlModsInstallFiles.Location = new System.Drawing.Point(2, 23);
            this.GridControlModsInstallFiles.MainView = this.GridViewModsInstallFiles;
            this.GridControlModsInstallFiles.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlModsInstallFiles.Name = "GridControlModsInstallFiles";
            this.GridControlModsInstallFiles.Size = new System.Drawing.Size(369, 90);
            this.GridControlModsInstallFiles.TabIndex = 3;
            this.GridControlModsInstallFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewModsInstallFiles});
            // 
            // GridViewModsInstallFiles
            // 
            this.GridViewModsInstallFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewModsInstallFiles.GridControl = this.GridControlModsInstallFiles;
            this.GridViewModsInstallFiles.Name = "GridViewModsInstallFiles";
            this.GridViewModsInstallFiles.OptionsBehavior.Editable = false;
            this.GridViewModsInstallFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewModsInstallFiles.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewModsInstallFiles.OptionsNavigation.AutoMoveRowFocus = false;
            this.GridViewModsInstallFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewModsInstallFiles.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.GridViewModsInstallFiles.OptionsView.ShowColumnHeaders = false;
            this.GridViewModsInstallFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewModsInstallFiles.OptionsView.ShowIndicator = false;
            // 
            // ColumnInstallationFiles
            // 
            this.ColumnInstallationFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInstallationFiles.HeaderText = "Installation Files";
            this.ColumnInstallationFiles.Name = "ColumnInstallationFiles";
            this.ColumnInstallationFiles.ReadOnly = true;
            this.ColumnInstallationFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.LabelSelectSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectSystemType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectSystemType.Appearance.Options.UseFont = true;
            this.LabelSelectSystemType.Appearance.Options.UseForeColor = true;
            this.LabelSelectSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectSystemType.Location = new System.Drawing.Point(396, 42);
            this.LabelSelectSystemType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectSystemType.Name = "LabelSelectSystemType";
            this.LabelSelectSystemType.Size = new System.Drawing.Size(71, 15);
            this.LabelSelectSystemType.TabIndex = 1156;
            this.LabelSelectSystemType.Text = "SYSTEM TYPE";
            // 
            // PanelModsLibraryFilters
            // 
            this.PanelModsLibraryFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelModsLibraryFilters.Controls.Add(this.TextBoxSearch);
            this.PanelModsLibraryFilters.Controls.Add(this.labelControl2);
            this.PanelModsLibraryFilters.Controls.Add(this.labelControl1);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxRegion);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxModType);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxSystemType);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectRegion);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSearch);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectSystemType);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectType);
            this.PanelModsLibraryFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModsLibraryFilters.Location = new System.Drawing.Point(2, 23);
            this.PanelModsLibraryFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsLibraryFilters.Name = "PanelModsLibraryFilters";
            this.PanelModsLibraryFilters.Size = new System.Drawing.Size(866, 96);
            this.PanelModsLibraryFilters.TabIndex = 12;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(57, 39);
            this.TextBoxSearch.MenuManager = this.MainMenu;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Properties.AllowFocused = false;
            this.TextBoxSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSearch.Size = new System.Drawing.Size(331, 22);
            this.TextBoxSearch.TabIndex = 1169;
            this.TextBoxSearch.EditValueChanged += new System.EventHandler(this.TextBoxSearch_EditValueChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.MainMenu.DockControls.Add(this.barDockControlTop);
            this.MainMenu.DockControls.Add(this.barDockControlBottom);
            this.MainMenu.DockControls.Add(this.barDockControlLeft);
            this.MainMenu.DockControls.Add(this.barDockControlRight);
            this.MainMenu.DockControls.Add(this.DockModInformation);
            this.MainMenu.Form = this;
            this.MainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuBarItemConnect,
            this.MenuBarItemTools,
            this.MenuBarItemApplications,
            this.MenuBarItemOptions,
            this.MenuBarItemHelp,
            this.barButtonItem6,
            this.barButtonItem7,
            this.ButtonGameBackupFiles,
            this.ButtonGameUpdateFinder,
            this.barToolbarsListItem1,
            this.barWorkspaceMenuItem1,
            this.ButtonFileManager,
            this.ButtonPackageManager,
            this.ButtonAddNewConsole,
            this.ButtonEditGameRegions,
            this.ButtonEditApplications,
            this.ButtonEditLists,
            this.ButtonSettings,
            this.ButtonSkinManager,
            this.ButtonExit,
            this.ReportBugButton,
            this.DiscordServerButton,
            this.ButtonOfficialSource,
            this.OpenLogFileButton,
            this.OpenLogFolderButton,
            this.HelpSpacer1,
            this.HelpSpacer2,
            this.AboutBar,
            this.WhatsNewButton,
            this.CheckForUpdateButton,
            this.HelpSpacer3,
            this.ButtonPS3,
            this.ButtonXbox360,
            this.ButtonConnectToPS3,
            ButtonConnectXbox,
            this.barDockingMenuItem1,
            this.ButtonWebManControls,
            this.ButtonNotifyMessage,
            this.ButtonVirtualController,
            this.ButtonPowerFunctions,
            this.ButtonShutdown,
            this.ButtonRestart,
            this.barButtonItem20,
            this.barButtonItem21,
            this.ButtonSystemInfo,
            this.ButtonShowSystemInformation,
            this.barButtonItem24,
            this.barButtonItem26,
            this.barButtonItem27,
            this.barButtonItem28,
            this.LabelHeaderConsoleConnected,
            this.LabelConsoleConnected,
            this.barToolbarsListItem2,
            this.ButtonConnectToXBOX,
            this.ButtonModInstallFiles,
            this.ButtonModUninstallFiles,
            this.ButtonModDownloadArchive,
            this.ButtonModAddToList,
            this.ButtonModRemoveFromList,
            this.ButtonModReportAnIssue,
            this.LabelStatus,
            this.LabelHeaderStatus,
            this.barButtonItem1,
            this.XBDMMenu,
            this.barSubItem3,
            this.xbdmShutdown,
            this.barButtonItem3,
            this.barSubItem2,
            this.barButtonItem2,
            this.barSubItem4,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barToolbarsListItem3,
            this.barSubItem5,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15});
            this.MainMenu.MainMenu = this.bar2;
            this.MainMenu.MaxItemId = 85;
            this.MainMenu.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemConnect),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemTools),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemApplications),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemOptions),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemHelp)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // MenuBarItemConnect
            // 
            this.MenuBarItemConnect.ActAsDropDown = true;
            this.MenuBarItemConnect.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuBarItemConnect.Caption = "CONNECT";
            this.MenuBarItemConnect.DropDownControl = this.ConnectMenu;
            this.MenuBarItemConnect.Id = 0;
            this.MenuBarItemConnect.Name = "MenuBarItemConnect";
            // 
            // ConnectMenu
            // 
            this.ConnectMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXbox360)});
            this.ConnectMenu.Manager = this.MainMenu;
            this.ConnectMenu.Name = "ConnectMenu";
            // 
            // ButtonPS3
            // 
            this.ButtonPS3.Caption = "PS3";
            this.ButtonPS3.Id = 32;
            this.ButtonPS3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConnectToPS3)});
            this.ButtonPS3.Name = "ButtonPS3";
            // 
            // ButtonConnectToPS3
            // 
            this.ButtonConnectToPS3.Caption = "Connect to Console...";
            this.ButtonConnectToPS3.Id = 34;
            this.ButtonConnectToPS3.Name = "ButtonConnectToPS3";
            this.ButtonConnectToPS3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConnectPS3_ItemClick);
            // 
            // ButtonXbox360
            // 
            this.ButtonXbox360.Caption = "XBOX";
            this.ButtonXbox360.Id = 33;
            this.ButtonXbox360.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConnectToXBOX),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.ButtonXbox360.Name = "ButtonXbox360";
            // 
            // ButtonConnectToXBOX
            // 
            this.ButtonConnectToXBOX.Caption = "Connect to Console...";
            this.ButtonConnectToXBOX.Id = 56;
            this.ButtonConnectToXBOX.Name = "ButtonConnectToXBOX";
            this.ButtonConnectToXBOX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConnectXBOX_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Find Console...";
            this.barButtonItem11.Id = 78;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XBDMFindConsole_ItemClick);
            // 
            // MenuBarItemTools
            // 
            this.MenuBarItemTools.ActAsDropDown = true;
            this.MenuBarItemTools.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuBarItemTools.Caption = "TOOLS";
            this.MenuBarItemTools.DropDownControl = this.ToolsMenu;
            this.MenuBarItemTools.Id = 1;
            this.MenuBarItemTools.Name = "MenuBarItemTools";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonGameBackupFiles, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonGameUpdateFinder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonFileManager, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPackageManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonWebManControls, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.XBDMMenu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.ToolsMenu.Manager = this.MainMenu;
            this.ToolsMenu.Name = "ToolsMenu";
            // 
            // ButtonGameBackupFiles
            // 
            this.ButtonGameBackupFiles.Caption = "Game Backup Files...";
            this.ButtonGameBackupFiles.Id = 7;
            this.ButtonGameBackupFiles.Name = "ButtonGameBackupFiles";
            this.ButtonGameBackupFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonGameBackupFiles_ItemClick);
            // 
            // ButtonGameUpdateFinder
            // 
            this.ButtonGameUpdateFinder.Caption = "Game Update Finder...";
            this.ButtonGameUpdateFinder.Id = 8;
            this.ButtonGameUpdateFinder.Name = "ButtonGameUpdateFinder";
            this.ButtonGameUpdateFinder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonGameUpdateFinder_ItemClick);
            // 
            // ButtonFileManager
            // 
            this.ButtonFileManager.Caption = "File Manager...";
            this.ButtonFileManager.Id = 12;
            this.ButtonFileManager.Name = "ButtonFileManager";
            this.ButtonFileManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonFileManager_ItemClick);
            // 
            // ButtonPackageManager
            // 
            this.ButtonPackageManager.Caption = "Package Manager...";
            this.ButtonPackageManager.Id = 13;
            this.ButtonPackageManager.Name = "ButtonPackageManager";
            this.ButtonPackageManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPackageManager_ItemClick);
            // 
            // ButtonWebManControls
            // 
            this.ButtonWebManControls.Caption = "WebMAN Controls...";
            this.ButtonWebManControls.Id = 37;
            this.ButtonWebManControls.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSystemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonNotifyMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonVirtualController)});
            this.ButtonWebManControls.Name = "ButtonWebManControls";
            // 
            // ButtonPowerFunctions
            // 
            this.ButtonPowerFunctions.Caption = "Power Functions";
            this.ButtonPowerFunctions.Id = 40;
            this.ButtonPowerFunctions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonShutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonRestart),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem21)});
            this.ButtonPowerFunctions.Name = "ButtonPowerFunctions";
            // 
            // ButtonShutdown
            // 
            this.ButtonShutdown.Caption = "Shutdown...";
            this.ButtonShutdown.Id = 41;
            this.ButtonShutdown.Name = "ButtonShutdown";
            this.ButtonShutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonShutdown_ItemClick);
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.Caption = "Restart...";
            this.ButtonRestart.Id = 42;
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonRestart_ItemClick);
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Caption = "Soft Reboot...";
            this.barButtonItem20.Id = 43;
            this.barButtonItem20.Name = "barButtonItem20";
            this.barButtonItem20.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonSoftReboot_ItemClick);
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Caption = "Hard Reboot...";
            this.barButtonItem21.Id = 44;
            this.barButtonItem21.Name = "barButtonItem21";
            this.barButtonItem21.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonHardReboot_ItemClick);
            // 
            // ButtonSystemInfo
            // 
            this.ButtonSystemInfo.Caption = "System Info";
            this.ButtonSystemInfo.Id = 45;
            this.ButtonSystemInfo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonShowSystemInformation),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem24),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem26)});
            this.ButtonSystemInfo.Name = "ButtonSystemInfo";
            // 
            // ButtonShowSystemInformation
            // 
            this.ButtonShowSystemInformation.Caption = "Show System Information...";
            this.ButtonShowSystemInformation.Id = 46;
            this.ButtonShowSystemInformation.Name = "ButtonShowSystemInformation";
            this.ButtonShowSystemInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonSystemInformation_ItemClick);
            // 
            // barButtonItem24
            // 
            this.barButtonItem24.Caption = "Show CPU/RSX Temperature...";
            this.barButtonItem24.Id = 47;
            this.barButtonItem24.Name = "barButtonItem24";
            this.barButtonItem24.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonCPURSXTemperature_ItemClick);
            // 
            // barButtonItem26
            // 
            this.barButtonItem26.Caption = "Show Minimum Version...";
            this.barButtonItem26.Id = 48;
            this.barButtonItem26.Name = "barButtonItem26";
            this.barButtonItem26.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonMinimumVersion_ItemClick);
            // 
            // ButtonNotifyMessage
            // 
            this.ButtonNotifyMessage.Caption = "Notify Message...";
            this.ButtonNotifyMessage.Id = 38;
            this.ButtonNotifyMessage.Name = "ButtonNotifyMessage";
            this.ButtonNotifyMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonNotifyMessage_ItemClick);
            // 
            // ButtonVirtualController
            // 
            this.ButtonVirtualController.Caption = "Virtual Controller...";
            this.ButtonVirtualController.Id = 39;
            this.ButtonVirtualController.Name = "ButtonVirtualController";
            this.ButtonVirtualController.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonVirtualController_ItemClick);
            // 
            // XBDMMenu
            // 
            this.XBDMMenu.Caption = "XBDM Controls... (Xbox)";
            this.XBDMMenu.Id = 66;
            this.XBDMMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem15)});
            this.XBDMMenu.Name = "XBDMMenu";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Power Functions";
            this.barSubItem3.Id = 67;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.xbdmShutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // xbdmShutdown
            // 
            this.xbdmShutdown.Caption = "Shutdown...";
            this.xbdmShutdown.Id = 68;
            this.xbdmShutdown.Name = "xbdmShutdown";
            this.xbdmShutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XBDMShutdown_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Restart...";
            this.barButtonItem3.Id = 69;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XBDMReboot_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Soft Reboot...";
            this.barButtonItem8.Id = 75;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XBDMSoftReboot_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Hard Reboot...";
            this.barButtonItem9.Id = 76;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XBDMHardReboot_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "System Info";
            this.barSubItem2.Id = 70;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "XNotify";
            this.barSubItem4.Id = 72;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "XMessagebox UI";
            this.barButtonItem4.Id = 73;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XBDM_XMessageboxUI_ItemClick);
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Xbox Dashboard";
            this.barSubItem5.Id = 80;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem12, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem13, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem14)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Avatar Editor...";
            this.barButtonItem12.Id = 81;
            this.barButtonItem12.ImageOptions.LargeImage = global::ModioX.Properties.Resources.avatar;
            this.barButtonItem12.ItemInMenuAppearance.Hovered.Options.UseImage = true;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AvatarEditor_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Xbox Home..";
            this.barButtonItem13.Id = 82;
            this.barButtonItem13.ImageOptions.Image = global::ModioX.Properties.Resources.Xbox_Logo;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "barButtonItem14";
            this.barButtonItem14.Id = 83;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Virtual Controller..";
            this.barButtonItem15.Id = 84;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxVirtualController_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "File Manager... (Xbox)";
            this.barButtonItem1.Id = 65;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // MenuBarItemApplications
            // 
            this.MenuBarItemApplications.ActAsDropDown = true;
            this.MenuBarItemApplications.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuBarItemApplications.Caption = "APPLICATIONS";
            this.MenuBarItemApplications.DropDownControl = this.ApplicationsMenu;
            this.MenuBarItemApplications.Id = 2;
            this.MenuBarItemApplications.Name = "MenuBarItemApplications";
            // 
            // ApplicationsMenu
            // 
            this.ApplicationsMenu.Manager = this.MainMenu;
            this.ApplicationsMenu.Name = "ApplicationsMenu";
            // 
            // MenuBarItemOptions
            // 
            this.MenuBarItemOptions.ActAsDropDown = true;
            this.MenuBarItemOptions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuBarItemOptions.Caption = "OPTIONS";
            this.MenuBarItemOptions.DropDownControl = this.OptionsMenu;
            this.MenuBarItemOptions.Id = 3;
            this.MenuBarItemOptions.Name = "MenuBarItemOptions";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonAddNewConsole, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonEditGameRegions, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonEditApplications),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonEditLists),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSettings, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonExit, true)});
            this.OptionsMenu.Manager = this.MainMenu;
            this.OptionsMenu.Name = "OptionsMenu";
            // 
            // ButtonAddNewConsole
            // 
            this.ButtonAddNewConsole.Caption = "Add New Console...";
            this.ButtonAddNewConsole.Id = 14;
            this.ButtonAddNewConsole.Name = "ButtonAddNewConsole";
            this.ButtonAddNewConsole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonAddNewConsole_ItemClick);
            // 
            // ButtonEditGameRegions
            // 
            this.ButtonEditGameRegions.Caption = "Edit Game Regions...";
            this.ButtonEditGameRegions.Id = 15;
            this.ButtonEditGameRegions.Name = "ButtonEditGameRegions";
            this.ButtonEditGameRegions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonEditGameRegion_ItemClick);
            // 
            // ButtonEditApplications
            // 
            this.ButtonEditApplications.Caption = "Edit Applications...";
            this.ButtonEditApplications.Id = 16;
            this.ButtonEditApplications.Name = "ButtonEditApplications";
            this.ButtonEditApplications.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonEditApplications_ItemClick);
            // 
            // ButtonEditLists
            // 
            this.ButtonEditLists.Caption = "Edit Your Lists...";
            this.ButtonEditLists.Id = 17;
            this.ButtonEditLists.Name = "ButtonEditLists";
            this.ButtonEditLists.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonEditYourLists_ItemClick);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Caption = "Settings...";
            this.ButtonSettings.Id = 18;
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonSettings_ItemClick);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Caption = "Exit Application";
            this.ButtonExit.Id = 20;
            this.ButtonExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonExit_ItemClick);
            // 
            // MenuBarItemHelp
            // 
            this.MenuBarItemHelp.ActAsDropDown = true;
            this.MenuBarItemHelp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuBarItemHelp.Caption = "HELP";
            this.MenuBarItemHelp.DropDownControl = this.HelpMenu;
            this.MenuBarItemHelp.Id = 4;
            this.MenuBarItemHelp.Name = "MenuBarItemHelp";
            // 
            // HelpMenu
            // 
            this.HelpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ReportBugButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.DiscordServerButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonOfficialSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenLogFileButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenLogFolderButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.CheckForUpdateButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.WhatsNewButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSkinManager, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.AboutBar, true)});
            this.HelpMenu.Manager = this.MainMenu;
            this.HelpMenu.Name = "HelpMenu";
            // 
            // ReportBugButton
            // 
            this.ReportBugButton.Caption = "Report Bug...";
            this.ReportBugButton.Id = 21;
            this.ReportBugButton.Name = "ReportBugButton";
            this.ReportBugButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonReportBug_ItemClick);
            // 
            // DiscordServerButton
            // 
            this.DiscordServerButton.Caption = "Discord Server...";
            this.DiscordServerButton.Id = 22;
            this.DiscordServerButton.Name = "DiscordServerButton";
            this.DiscordServerButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonDiscordServer_ItemClick);
            // 
            // ButtonOfficialSource
            // 
            this.ButtonOfficialSource.Caption = "Official Source...";
            this.ButtonOfficialSource.Id = 23;
            this.ButtonOfficialSource.Name = "ButtonOfficialSource";
            this.ButtonOfficialSource.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonOfficialSource_ItemClick);
            // 
            // OpenLogFileButton
            // 
            this.OpenLogFileButton.Caption = "Open Log File...";
            this.OpenLogFileButton.Id = 24;
            this.OpenLogFileButton.Name = "OpenLogFileButton";
            this.OpenLogFileButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonOpenLogFile_ItemClick);
            // 
            // OpenLogFolderButton
            // 
            this.OpenLogFolderButton.Caption = "Open Log Folder";
            this.OpenLogFolderButton.Id = 25;
            this.OpenLogFolderButton.Name = "OpenLogFolderButton";
            this.OpenLogFolderButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonOpenLogFolder_ItemClick);
            // 
            // CheckForUpdateButton
            // 
            this.CheckForUpdateButton.Caption = "Check For Updates...";
            this.CheckForUpdateButton.Id = 30;
            this.CheckForUpdateButton.Name = "CheckForUpdateButton";
            this.CheckForUpdateButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonCheckForUpdate_ItemClick);
            // 
            // WhatsNewButton
            // 
            this.WhatsNewButton.Caption = "What\'s New...";
            this.WhatsNewButton.Id = 29;
            this.WhatsNewButton.Name = "WhatsNewButton";
            this.WhatsNewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonWhatsNew_ItemClick);
            // 
            // ButtonSkinManager
            // 
            this.ButtonSkinManager.Caption = "Skin Changer...";
            this.ButtonSkinManager.Id = 19;
            this.ButtonSkinManager.Name = "ButtonSkinManager";
            // 
            // AboutBar
            // 
            this.AboutBar.Caption = "About...";
            this.AboutBar.Id = 28;
            this.AboutBar.Name = "AboutBar";
            this.AboutBar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonAbout_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarItemVertIndent = 5;
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderConsoleConnected),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelConsoleConnected),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // LabelHeaderConsoleConnected
            // 
            this.LabelHeaderConsoleConnected.Caption = "Console Connected:";
            this.LabelHeaderConsoleConnected.Id = 53;
            this.LabelHeaderConsoleConnected.Name = "LabelHeaderConsoleConnected";
            // 
            // LabelConsoleConnected
            // 
            this.LabelConsoleConnected.Caption = "Idle";
            this.LabelConsoleConnected.Id = 54;
            this.LabelConsoleConnected.Name = "LabelConsoleConnected";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 64;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.Id = 63;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainMenu;
            this.barDockControlTop.Size = new System.Drawing.Size(1584, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 796);
            this.barDockControlBottom.Manager = this.MainMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1584, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.MainMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 771);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1584, 25);
            this.barDockControlRight.Manager = this.MainMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 771);
            // 
            // DockModInformation
            // 
            this.DockModInformation.CausesValidation = false;
            this.DockModInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DockModInformation.Location = new System.Drawing.Point(2, 718);
            this.DockModInformation.Manager = this.MainMenu;
            this.DockModInformation.Name = "DockModInformation";
            this.DockModInformation.Size = new System.Drawing.Size(373, 23);
            this.DockModInformation.Text = "standaloneBarDockControl1";
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
            this.workspaceManager1.TransitionType = pushTransition2;
            // 
            // HelpSpacer1
            // 
            this.HelpSpacer1.Caption = "_________________________";
            this.HelpSpacer1.DropDownEnabled = false;
            this.HelpSpacer1.Enabled = false;
            this.HelpSpacer1.Id = 26;
            this.HelpSpacer1.Name = "HelpSpacer1";
            // 
            // HelpSpacer2
            // 
            this.HelpSpacer2.Caption = "______";
            this.HelpSpacer2.Enabled = false;
            this.HelpSpacer2.Id = 27;
            this.HelpSpacer2.Name = "HelpSpacer2";
            // 
            // HelpSpacer3
            // 
            this.HelpSpacer3.Caption = "______________________";
            this.HelpSpacer3.Enabled = false;
            this.HelpSpacer3.Id = 31;
            this.HelpSpacer3.Name = "HelpSpacer3";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 36;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barButtonItem27
            // 
            this.barButtonItem27.Caption = "Control Console (CCAPI)";
            this.barButtonItem27.Id = 49;
            this.barButtonItem27.Name = "barButtonItem27";
            // 
            // barButtonItem28
            // 
            this.barButtonItem28.Caption = "FileZilla";
            this.barButtonItem28.Id = 50;
            this.barButtonItem28.Name = "barButtonItem28";
            // 
            // barToolbarsListItem2
            // 
            this.barToolbarsListItem2.Caption = "barToolbarsListItem2";
            this.barToolbarsListItem2.Id = 55;
            this.barToolbarsListItem2.Name = "barToolbarsListItem2";
            // 
            // ButtonModInstallFiles
            // 
            this.ButtonModInstallFiles.Caption = "Install Files...";
            this.ButtonModInstallFiles.Id = 57;
            this.ButtonModInstallFiles.Name = "ButtonModInstallFiles";
            // 
            // ButtonModUninstallFiles
            // 
            this.ButtonModUninstallFiles.Caption = "Uninstall Files...";
            this.ButtonModUninstallFiles.Id = 58;
            this.ButtonModUninstallFiles.Name = "ButtonModUninstallFiles";
            // 
            // ButtonModDownloadArchive
            // 
            this.ButtonModDownloadArchive.Caption = "Download Archive to...";
            this.ButtonModDownloadArchive.Id = 59;
            this.ButtonModDownloadArchive.Name = "ButtonModDownloadArchive";
            // 
            // ButtonModAddToList
            // 
            this.ButtonModAddToList.Caption = "Add to List...";
            this.ButtonModAddToList.Id = 60;
            this.ButtonModAddToList.Name = "ButtonModAddToList";
            // 
            // ButtonModRemoveFromList
            // 
            this.ButtonModRemoveFromList.Caption = "Remove from List...";
            this.ButtonModRemoveFromList.Id = 61;
            this.ButtonModRemoveFromList.Name = "ButtonModRemoveFromList";
            // 
            // ButtonModReportAnIssue
            // 
            this.ButtonModReportAnIssue.Caption = "Report an Issue...";
            this.ButtonModReportAnIssue.Id = 62;
            this.ButtonModReportAnIssue.Name = "ButtonModReportAnIssue";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "XNo";
            this.barButtonItem2.Id = 71;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 74;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 77;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barToolbarsListItem3
            // 
            this.barToolbarsListItem3.Caption = "barToolbarsListItem3";
            this.barToolbarsListItem3.Id = 79;
            this.barToolbarsListItem3.Name = "barToolbarsListItem3";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(853, 15);
            this.labelControl2.TabIndex = 1168;
            this.labelControl2.Text = "MODS";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(853, 15);
            this.labelControl1.TabIndex = 1167;
            this.labelControl1.Text = "FILTER MODS";
            // 
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRegion.Location = new System.Drawing.Point(756, 39);
            this.ComboBoxRegion.MenuManager = this.MainMenu;
            this.ComboBoxRegion.Name = "ComboBoxRegion";
            this.ComboBoxRegion.Properties.AllowFocused = false;
            this.ComboBoxRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxRegion.Size = new System.Drawing.Size(104, 22);
            this.ComboBoxRegion.TabIndex = 1166;
            this.ComboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRegion_SelectedIndexChanged);
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.Location = new System.Drawing.Point(604, 39);
            this.ComboBoxModType.MenuManager = this.MainMenu;
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Properties.AllowFocused = false;
            this.ComboBoxModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxModType.Size = new System.Drawing.Size(96, 22);
            this.ComboBoxModType.TabIndex = 1165;
            this.ComboBoxModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModType_SelectedIndexChanged);
            // 
            // ComboBoxSystemType
            // 
            this.ComboBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSystemType.Location = new System.Drawing.Point(473, 39);
            this.ComboBoxSystemType.MenuManager = this.MainMenu;
            this.ComboBoxSystemType.Name = "ComboBoxSystemType";
            this.ComboBoxSystemType.Properties.AllowFocused = false;
            this.ComboBoxSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxSystemType.Size = new System.Drawing.Size(60, 22);
            this.ComboBoxSystemType.TabIndex = 1164;
            this.ComboBoxSystemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSystemType_SelectedIndexChanged);
            // 
            // LabelSelectRegion
            // 
            this.LabelSelectRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectRegion.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectRegion.Appearance.Options.UseFont = true;
            this.LabelSelectRegion.Appearance.Options.UseForeColor = true;
            this.LabelSelectRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectRegion.Location = new System.Drawing.Point(708, 42);
            this.LabelSelectRegion.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectRegion.Name = "LabelSelectRegion";
            this.LabelSelectRegion.Size = new System.Drawing.Size(42, 15);
            this.LabelSelectRegion.TabIndex = 1163;
            this.LabelSelectRegion.Text = "REGION";
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Appearance.Options.UseForeColor = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(7, 42);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 15);
            this.LabelSearch.TabIndex = 1157;
            this.LabelSearch.Text = "SEARCH";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 9;
            this.barSubItem1.Name = "barSubItem1";
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
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsType.HeaderText = "Mod Type";
            this.ColumnModsType.MinimumWidth = 6;
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            // 
            // ColumnModsRegion
            // 
            this.ColumnModsRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsRegion.HeaderText = "Region";
            this.ColumnModsRegion.MinimumWidth = 6;
            this.ColumnModsRegion.Name = "ColumnModsRegion";
            this.ColumnModsRegion.ReadOnly = true;
            // 
            // ColumnModsVersion
            // 
            this.ColumnModsVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsVersion.HeaderText = "Version";
            this.ColumnModsVersion.MinimumWidth = 6;
            this.ColumnModsVersion.Name = "ColumnModsVersion";
            this.ColumnModsVersion.ReadOnly = true;
            // 
            // ColumnModsAuthor
            // 
            this.ColumnModsAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsAuthor.HeaderText = "Creator";
            this.ColumnModsAuthor.MinimumWidth = 124;
            this.ColumnModsAuthor.Name = "ColumnModsAuthor";
            this.ColumnModsAuthor.ReadOnly = true;
            // 
            // ColumnModsNoFiles
            // 
            this.ColumnModsNoFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsNoFiles.HeaderText = "# of Files";
            this.ColumnModsNoFiles.MinimumWidth = 6;
            this.ColumnModsNoFiles.Name = "ColumnModsNoFiles";
            this.ColumnModsNoFiles.ReadOnly = true;
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
            // GridControlGameModsInstalled
            // 
            this.GridControlGameModsInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlGameModsInstalled.Location = new System.Drawing.Point(2, 23);
            this.GridControlGameModsInstalled.MainView = this.GridViewGameModsInstalled;
            this.GridControlGameModsInstalled.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlGameModsInstalled.Name = "GridControlGameModsInstalled";
            this.GridControlGameModsInstalled.Size = new System.Drawing.Size(866, 178);
            this.GridControlGameModsInstalled.TabIndex = 7;
            this.GridControlGameModsInstalled.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameModsInstalled});
            // 
            // GridViewGameModsInstalled
            // 
            this.GridViewGameModsInstalled.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewGameModsInstalled.GridControl = this.GridControlGameModsInstalled;
            this.GridViewGameModsInstalled.Name = "GridViewGameModsInstalled";
            this.GridViewGameModsInstalled.OptionsBehavior.Editable = false;
            this.GridViewGameModsInstalled.OptionsBehavior.ReadOnly = true;
            this.GridViewGameModsInstalled.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewGameModsInstalled.OptionsView.ShowGroupPanel = false;
            this.GridViewGameModsInstalled.OptionsView.ShowIndicator = false;
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
            // 
            // ColumnModsInstalledVersion
            // 
            this.ColumnModsInstalledVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledVersion.HeaderText = "Version";
            this.ColumnModsInstalledVersion.MinimumWidth = 6;
            this.ColumnModsInstalledVersion.Name = "ColumnModsInstalledVersion";
            this.ColumnModsInstalledVersion.ReadOnly = true;
            // 
            // ColumnModsInstalledNoOfFiles
            // 
            this.ColumnModsInstalledNoOfFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledNoOfFiles.HeaderText = "# Files";
            this.ColumnModsInstalledNoOfFiles.MinimumWidth = 6;
            this.ColumnModsInstalledNoOfFiles.Name = "ColumnModsInstalledNoOfFiles";
            this.ColumnModsInstalledNoOfFiles.ReadOnly = true;
            // 
            // ColumnModsInstalledDateTime
            // 
            this.ColumnModsInstalledDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledDateTime.HeaderText = "Installed On";
            this.ColumnModsInstalledDateTime.Name = "ColumnModsInstalledDateTime";
            this.ColumnModsInstalledDateTime.ReadOnly = true;
            // 
            // ColumnModsInstalledUninstall
            // 
            this.ColumnModsInstalledUninstall.HeaderText = "";
            this.ColumnModsInstalledUninstall.MinimumWidth = 6;
            this.ColumnModsInstalledUninstall.Name = "ColumnModsInstalledUninstall";
            this.ColumnModsInstalledUninstall.ReadOnly = true;
            this.ColumnModsInstalledUninstall.Width = 28;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 4";
            // 
            // GroupModsLibrary
            // 
            this.GroupModsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModsLibrary.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupModsLibrary.AppearanceCaption.Options.UseFont = true;
            this.GroupModsLibrary.Controls.Add(this.ProgressMods);
            this.GroupModsLibrary.Controls.Add(this.GridControlMods);
            this.GroupModsLibrary.Controls.Add(this.PanelModsLibraryFilters);
            this.GroupModsLibrary.Location = new System.Drawing.Point(318, 39);
            this.GroupModsLibrary.Name = "GroupModsLibrary";
            this.GroupModsLibrary.Size = new System.Drawing.Size(870, 534);
            this.GroupModsLibrary.TabIndex = 1167;
            this.GroupModsLibrary.Text = "MODS LIBRARY";
            // 
            // ProgressMods
            // 
            this.ProgressMods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressMods.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressMods.Appearance.Options.UseBackColor = true;
            this.ProgressMods.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressMods.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressMods.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressMods.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressMods.Caption = "NO MODS FOUND";
            this.ProgressMods.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressMods.Description = "Loading...";
            this.ProgressMods.Location = new System.Drawing.Point(327, 187);
            this.ProgressMods.Name = "ProgressMods";
            this.ProgressMods.Size = new System.Drawing.Size(246, 66);
            this.ProgressMods.TabIndex = 1170;
            this.ProgressMods.Text = "progressPanel1";
            this.ProgressMods.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridControlMods
            // 
            this.GridControlMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlMods.Location = new System.Drawing.Point(2, 119);
            this.GridControlMods.MainView = this.GridViewMods;
            this.GridControlMods.MenuManager = this.MainMenu;
            this.GridControlMods.Name = "GridControlMods";
            this.GridControlMods.Size = new System.Drawing.Size(866, 413);
            this.GridControlMods.TabIndex = 1171;
            this.GridControlMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMods});
            // 
            // GridViewMods
            // 
            this.GridViewMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewMods.GridControl = this.GridControlMods;
            this.GridViewMods.Name = "GridViewMods";
            this.GridViewMods.OptionsBehavior.Editable = false;
            this.GridViewMods.OptionsBehavior.ReadOnly = true;
            this.GridViewMods.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewMods.OptionsView.ShowGroupPanel = false;
            this.GridViewMods.OptionsView.ShowIndicator = false;
            this.GridViewMods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewMods_FocusedRowChanged);
            // 
            // NavigationBar
            // 
            this.NavigationBar.ActiveGroup = this.NavGroupGames;
            this.NavigationBar.Appearance.GroupHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NavigationBar.Appearance.GroupHeader.Options.UseFont = true;
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.NavGroupGames,
            this.NavGroupHomebrewApps,
            this.NavGroupResources,
            this.NavGroupMyLists});
            this.NavigationBar.Location = new System.Drawing.Point(2, 23);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.OptionsNavPane.ExpandedWidth = 296;
            this.NavigationBar.Size = new System.Drawing.Size(296, 718);
            this.NavigationBar.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.NavigationBar.TabIndex = 1180;
            this.NavigationBar.Text = "navBarControl1";
            this.NavigationBar.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2019 Black");
            this.NavigationBar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavigationBar_LinkClicked);
            // 
            // NavGroupGames
            // 
            this.NavGroupGames.Caption = "GAMES";
            this.NavGroupGames.Expanded = true;
            this.NavGroupGames.Name = "NavGroupGames";
            // 
            // NavGroupHomebrewApps
            // 
            this.NavGroupHomebrewApps.Caption = "HOMEBREW APPLICATIONS";
            this.NavGroupHomebrewApps.Expanded = true;
            this.NavGroupHomebrewApps.Name = "NavGroupHomebrewApps";
            // 
            // NavGroupResources
            // 
            this.NavGroupResources.Caption = "RESOURCES";
            this.NavGroupResources.Expanded = true;
            this.NavGroupResources.Name = "NavGroupResources";
            // 
            // NavGroupMyLists
            // 
            this.NavGroupMyLists.Caption = "MY LISTS";
            this.NavGroupMyLists.Expanded = true;
            this.NavGroupMyLists.Name = "NavGroupMyLists";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.NavigationBar);
            this.groupControl1.Location = new System.Drawing.Point(12, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 743);
            this.groupControl1.TabIndex = 1185;
            this.groupControl1.Text = "CATEGORIES";
            // 
            // GroupModsInstalled
            // 
            this.GroupModsInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModsInstalled.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GroupModsInstalled.AppearanceCaption.Options.UseFont = true;
            this.GroupModsInstalled.Controls.Add(this.ProgressModsInstalled);
            this.GroupModsInstalled.Controls.Add(this.GridControlGameModsInstalled);
            buttonImageOptions2.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText;
            this.GroupModsInstalled.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Uninstall All", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", 2, true, null, false, false, true, null, 2)});
            this.GroupModsInstalled.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.GroupModsInstalled.Location = new System.Drawing.Point(318, 579);
            this.GroupModsInstalled.Name = "GroupModsInstalled";
            this.GroupModsInstalled.Size = new System.Drawing.Size(870, 203);
            this.GroupModsInstalled.TabIndex = 1179;
            this.GroupModsInstalled.Text = "MODS/PLUGINS INSTALLED";
            // 
            // ProgressModsInstalled
            // 
            this.ProgressModsInstalled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressModsInstalled.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressModsInstalled.Appearance.Options.UseBackColor = true;
            this.ProgressModsInstalled.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressModsInstalled.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressModsInstalled.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressModsInstalled.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressModsInstalled.Caption = "NO MODS INSTALLED";
            this.ProgressModsInstalled.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressModsInstalled.Description = "Loading...";
            this.ProgressModsInstalled.Location = new System.Drawing.Point(327, 87);
            this.ProgressModsInstalled.Name = "ProgressModsInstalled";
            this.ProgressModsInstalled.Size = new System.Drawing.Size(246, 66);
            this.ProgressModsInstalled.TabIndex = 1171;
            this.ProgressModsInstalled.Text = "progressPanel1";
            this.ProgressModsInstalled.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 4";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Custom 4";
            // 
            // GroupModInformation
            // 
            this.GroupModInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModInformation.Controls.Add(this.ScrollBarModInformation);
            this.GroupModInformation.Controls.Add(this.FlowPanelDetails);
            this.GroupModInformation.Controls.Add(this.GroupInstallFiles);
            this.GroupModInformation.Controls.Add(this.DockModInformation);
            this.GroupModInformation.Location = new System.Drawing.Point(1195, 39);
            this.GroupModInformation.Name = "GroupModInformation";
            this.GroupModInformation.Size = new System.Drawing.Size(377, 743);
            this.GroupModInformation.TabIndex = 1160;
            this.GroupModInformation.Text = "MOD INFORMATION";
            // 
            // ScrollBarModInformation
            // 
            this.ScrollBarModInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScrollBarModInformation.Location = new System.Drawing.Point(358, 23);
            this.ScrollBarModInformation.Name = "ScrollBarModInformation";
            this.ScrollBarModInformation.Size = new System.Drawing.Size(17, 580);
            this.ScrollBarModInformation.TabIndex = 3;
            this.ScrollBarModInformation.Visible = false;
            this.ScrollBarModInformation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarModInformation_Scroll);
            // 
            // GroupInstallFiles
            // 
            this.GroupInstallFiles.Controls.Add(this.GridControlModsInstallFiles);
            this.GroupInstallFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupInstallFiles.Location = new System.Drawing.Point(2, 603);
            this.GroupInstallFiles.Name = "GroupInstallFiles";
            this.GroupInstallFiles.Size = new System.Drawing.Size(373, 115);
            this.GroupInstallFiles.TabIndex = 1;
            this.GroupInstallFiles.Text = "INSTALL FILES";
            // 
            // ModsMenu
            // 
            this.ModsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModInstallFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModUninstallFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModDownloadArchive),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModAddToList, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModRemoveFromList),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModReportAnIssue, true)});
            this.ModsMenu.Manager = this.MainMenu;
            this.ModsMenu.Name = "ModsMenu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMenuModInformation});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ButtonModInstall,
            this.ButtonModUninstall,
            this.ButtonModDownload,
            this.ButtonModFavorite});
            this.barManager1.MainMenu = this.BarMenuModInformation;
            this.barManager1.MaxItemId = 4;
            // 
            // BarMenuModInformation
            // 
            this.BarMenuModInformation.BarItemVertIndent = 5;
            this.BarMenuModInformation.BarName = "Main menu";
            this.BarMenuModInformation.DockCol = 0;
            this.BarMenuModInformation.DockRow = 0;
            this.BarMenuModInformation.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.BarMenuModInformation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModInstall),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModUninstall),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModDownload),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModFavorite)});
            this.BarMenuModInformation.OptionsBar.DrawBorder = false;
            this.BarMenuModInformation.OptionsBar.DrawDragBorder = false;
            this.BarMenuModInformation.OptionsBar.UseWholeRow = true;
            this.BarMenuModInformation.StandaloneBarDockControl = this.DockModInformation;
            this.BarMenuModInformation.Text = "Main menu";
            // 
            // ButtonModInstall
            // 
            this.ButtonModInstall.Caption = "Install";
            this.ButtonModInstall.Id = 0;
            this.ButtonModInstall.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.ButtonModInstall.Name = "ButtonModInstall";
            // 
            // ButtonModUninstall
            // 
            this.ButtonModUninstall.Caption = "Uninstall";
            this.ButtonModUninstall.Id = 1;
            this.ButtonModUninstall.Name = "ButtonModUninstall";
            // 
            // ButtonModDownload
            // 
            this.ButtonModDownload.Caption = "Download";
            this.ButtonModDownload.Id = 2;
            this.ButtonModDownload.Name = "ButtonModDownload";
            // 
            // ButtonModFavorite
            // 
            this.ButtonModFavorite.Caption = "Favorite";
            this.ButtonModFavorite.Id = 3;
            this.ButtonModFavorite.Name = "ButtonModFavorite";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 821);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 821);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1584, 0);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 821);
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
            this.Controls.Add(this.GroupModInformation);
            this.Controls.Add(this.GroupModsInstalled);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GroupModsLibrary);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainWindow.IconOptions.Icon")));
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1586, 853);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ContextMenuMods.ResumeLayout(false);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModsInstallFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModsInstallFiles)).EndInit();
            this.PanelModsLibraryFilters.ResumeLayout(false);
            this.PanelModsLibraryFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSystemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameModsInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameModsInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsLibrary)).EndInit();
            this.GroupModsLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsInstalled)).EndInit();
            this.GroupModsInstalled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupModInformation)).EndInit();
            this.GroupModInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallFiles)).EndInit();
            this.GroupInstallFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LabelSelectType;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private DevExpress.XtraEditors.LabelControl LabelName;
        private DevExpress.XtraEditors.LabelControl LabelHeaderAuthor;
        private DevExpress.XtraEditors.LabelControl LabelHeaderVersion;
        private DevExpress.XtraEditors.LabelControl LabelVersion;
        private DevExpress.XtraEditors.LabelControl LabelHeaderGameType;
        private DevExpress.XtraEditors.LabelControl LabelConfig;
        private DevExpress.XtraEditors.LabelControl LabelDescription;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnectedConsole;
        private System.Windows.Forms.ToolStripSeparator ToolStripStatusSeperator0;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
        private DevExpress.XtraEditors.LabelControl LabelHeaderSubmittedBy;
        private DevExpress.XtraEditors.LabelControl LabelSubmittedBy;
        private DevExpress.XtraEditors.LabelControl LabelAuthor;
        private DevExpress.XtraEditors.LabelControl LabelHeaderModType;
        private DevExpress.XtraEditors.LabelControl LabelType;
        private DevExpress.XtraEditors.LabelControl LabelSelectSystemType;
        private DevExpress.XtraEditors.LabelControl LabelHeaderFirmware;
        private DevExpress.XtraEditors.LabelControl LabelFirmware;
        private DevExpress.XtraEditors.LabelControl LabelCategory;
        private DevExpress.XtraEditors.LabelControl LabelHeaderCategory;
        private DarkUI.Controls.DarkContextMenu ContextMenuMods;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsInstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsUninstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsDownloadArchive;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeparator0;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsReportOnGitHub;
        private System.Windows.Forms.ToolStripButton ToolItemModInstall;
        private System.Windows.Forms.ToolStripButton ToolItemModDownload;
        private System.Windows.Forms.ToolStripButton ToolItemModUninstall;
        private System.Windows.Forms.ToolStripButton ToolItemModAddToFavorite;
        private DevExpress.XtraEditors.LabelControl LabelHeaderName;
        private System.Windows.Forms.Panel PanelModsLibraryFilters;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraGrid.GridControl GridControlGameModsInstalled;
        private System.Windows.Forms.ToolStripButton ToolItemGameModsUninstallAll;
        private System.Windows.Forms.ToolStripLabel LabelInstalledGameModsStatus;
        private DevExpress.XtraEditors.LabelControl LabelHeaderRegion;
        private DevExpress.XtraEditors.LabelControl LabelRegion;
        private DevExpress.XtraEditors.LabelControl LabelSelectRegion;
        private DevExpress.XtraGrid.GridControl GridControlModsInstallFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstallationFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsAddToList;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsRemoveFromList;
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
        private BarManager MainMenu;
        private Bar bar2;
        private BarButtonItem MenuBarItemConnect;
        private PopupMenu HelpMenu;
        private BarButtonItem MenuBarItemTools;
        private PopupMenu OptionsMenu;
        private BarButtonItem MenuBarItemApplications;
        private PopupMenu ApplicationsMenu;
        private BarButtonItem MenuBarItemOptions;
        private PopupMenu ToolsMenu;
        private BarButtonItem MenuBarItemHelp;
        private PopupMenu ConnectMenu;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private ComboBoxEdit ComboBoxSystemType;
        private BarButtonItem ButtonGameBackupFiles;
        private BarButtonItem ButtonGameUpdateFinder;
        private BarButtonItem ButtonFileManager;
        private BarButtonItem ButtonPackageManager;
        private BarSubItem barSubItem1;
        private BarToolbarsListItem barToolbarsListItem1;
        private BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private BarButtonItem ButtonAddNewConsole;
        private BarButtonItem ButtonEditGameRegions;
        private BarButtonItem ButtonEditApplications;
        private BarButtonItem ButtonEditLists;
        private BarButtonItem ButtonSettings;
        private SkinBarSubItem ButtonSkinManager;
        private BarButtonItem ButtonExit;
        private BarButtonItem ReportBugButton;
        private BarButtonItem DiscordServerButton;
        private BarButtonItem HelpSpacer1;
        private BarButtonItem ButtonOfficialSource;
        private BarButtonItem OpenLogFileButton;
        private BarButtonItem OpenLogFolderButton;
        private BarButtonItem HelpSpacer2;
        private BarButtonItem CheckForUpdateButton;
        private BarButtonItem WhatsNewButton;
        private BarButtonItem HelpSpacer3;
        private BarButtonItem AboutBar;
        private BarSubItem ButtonPS3;
        private BarButtonItem ButtonConnectToPS3;
        private BarSubItem ButtonXbox360;
        private BarDockingMenuItem barDockingMenuItem1;
        private BarSubItem ButtonWebManControls;
        private BarSubItem ButtonPowerFunctions;
        private BarButtonItem ButtonShutdown;
        private BarButtonItem ButtonRestart;
        private BarButtonItem barButtonItem20;
        private BarButtonItem barButtonItem21;
        private BarSubItem ButtonSystemInfo;
        private BarButtonItem ButtonShowSystemInformation;
        private BarButtonItem barButtonItem24;
        private BarButtonItem barButtonItem26;
        private BarButtonItem ButtonNotifyMessage;
        private BarButtonItem ButtonVirtualController;
        private BarButtonItem barButtonItem27;
        private BarButtonItem barButtonItem28;
        private Bar bar1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewModsInstallFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewGameModsInstalled;
        private ComboBoxEdit ComboBoxRegion;
        private ComboBoxEdit ComboBoxModType;
        private BarHeaderItem LabelHeaderConsoleConnected;
        private BarStaticItem LabelConsoleConnected;
        private BarToolbarsListItem barToolbarsListItem2;
        private DevExpress.XtraNavBar.NavBarControl NavigationBar;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupGames;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupHomebrewApps;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupResources;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupMyLists;
        private GroupControl GroupModsLibrary;
        private GroupControl GroupModsInstalled;
        private GroupControl groupControl1;
        private Bar bar4;
        private GroupControl GroupModInformation;
        private GroupControl GroupInstallFiles;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit TextBoxSearch;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressMods;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressModsInstalled;
        private DevExpress.XtraGrid.GridControl GridControlMods;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewMods;
        private BarButtonItem ButtonConnectToXBOX;
        private BarButtonItem ButtonModInstallFiles;
        private BarButtonItem ButtonModUninstallFiles;
        private BarButtonItem ButtonModDownloadArchive;
        private BarButtonItem ButtonModAddToList;
        private BarButtonItem ButtonModRemoveFromList;
        private BarButtonItem ButtonModReportAnIssue;
        private PopupMenu ModsMenu;
        private BarHeaderItem LabelHeaderStatus;
        private BarStaticItem LabelStatus;
        private StandaloneBarDockControl DockModInformation;
        private BarDockControl barDockControl3;
        private BarManager barManager1;
        private Bar BarMenuModInformation;
        private BarButtonItem ButtonModInstall;
        private BarButtonItem ButtonModUninstall;
        private BarButtonItem ButtonModDownload;
        private BarButtonItem ButtonModFavorite;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl4;
        private VScrollBar ScrollBarModInformation;
        private BarButtonItem barButtonItem1;
        private BarSubItem XBDMMenu;
        private BarSubItem barSubItem3;
        private BarButtonItem xbdmShutdown;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarSubItem barSubItem2;
        private BarSubItem barSubItem4;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem10;
        private BarButtonItem barButtonItem11;
        private BarSubItem barSubItem5;
        private BarButtonItem barButtonItem12;
        private BarToolbarsListItem barToolbarsListItem3;
        private BarButtonItem barButtonItem13;
        private BarButtonItem barButtonItem14;
        private BarButtonItem barButtonItem15;
    }
}