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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.LabelSelectSystemType = new DevExpress.XtraEditors.LabelControl();
            this.PanelModsLibraryFilters = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.MainMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMenu = new DevExpress.XtraBars.Bar();
            this.MenuBarItemConnect = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonPS3 = new DevExpress.XtraBars.BarSubItem();
            this.ButtonConnectToPS3 = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXbox360 = new DevExpress.XtraBars.BarSubItem();
            this.ButtonConnectToXBOX = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxFindConsole = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBarItemTools = new DevExpress.XtraBars.BarButtonItem();
            this.ToolsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonPS3GameBackupFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3GameUpdateFinder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3FileManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3PackageManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3WebManControls = new DevExpress.XtraBars.BarSubItem();
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
            this.ButtonXboxXBDMMenu = new DevExpress.XtraBars.BarSubItem();
            this.ButtonXboxMessageBoxUI = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxPowerFunctions = new DevExpress.XtraBars.BarSubItem();
            this.xbdmShutdown = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.ProfileIDInfo = new DevExpress.XtraBars.BarButtonItem();
            this.QuickSignIn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.OpenCloseTray = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxFileManager = new DevExpress.XtraBars.BarButtonItem();
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
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderConnectedConsole = new DevExpress.XtraBars.BarStaticItem();
            this.LabelConsoleConnected = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelModsStats = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DockModInformation = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.DockControlModsInstalled = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.WorkspaceManager = new DevExpress.Utils.WorkspaceManager(this.components);
            this.HelpSpacer1 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpSpacer2 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpSpacer3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barButtonItem27 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem28 = new DevExpress.XtraBars.BarButtonItem();
            this.LabelHeaderConsoleConnected = new DevExpress.XtraBars.BarHeaderItem();
            this.barToolbarsListItem2 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.ButtonModInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModUninstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModDownloadArchive = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModAddToList = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModRemoveFromList = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModReportAnIssue = new DevExpress.XtraBars.BarButtonItem();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarHeaderItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem3 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.XNotifyButton = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.XNotifyText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.XNotifyType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.XNotifySend = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            this.GroupCategories = new DevExpress.XtraEditors.GroupControl();
            this.GroupModsInstalled = new DevExpress.XtraEditors.GroupControl();
            this.ProgressModsInstalled = new DevExpress.XtraWaitForm.ProgressPanel();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.GroupModInformation = new DevExpress.XtraEditors.GroupControl();
            this.ScrollBarModInformation = new DevExpress.XtraEditors.VScrollBar();
            this.GroupInstallFiles = new DevExpress.XtraEditors.GroupControl();
            this.ModsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BarManagerModInformation = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMenuModInformation = new DevExpress.XtraBars.Bar();
            this.ButtonModInstall = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModUninstall = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModDownload = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModFavorite = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.BarManagerModsInstalled = new DevExpress.XtraBars.BarManager(this.components);
            this.BarModsInstalled = new DevExpress.XtraBars.Bar();
            this.LabelModsInstalled = new DevExpress.XtraBars.BarStaticItem();
            this.ButtonModsUninstallAll = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.HeaderLabelModsInstalled = new DevExpress.XtraBars.BarHeaderItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyType)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupCategories)).BeginInit();
            this.GroupCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsInstalled)).BeginInit();
            this.GroupModsInstalled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModInformation)).BeginInit();
            this.GroupModInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallFiles)).BeginInit();
            this.GroupInstallFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerModInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerModsInstalled)).BeginInit();
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
            this.ContextMenuModsAddToList.Name = "ContextMenuModsAddToList";
            this.ContextMenuModsAddToList.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsAddToList.Text = "Add to List...";
            this.ContextMenuModsAddToList.Click += new System.EventHandler(this.ContextMenuModsAddToList_Click);
            // 
            // ContextMenuModsRemoveFromList
            // 
            this.ContextMenuModsRemoveFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsRemoveFromList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
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
            this.ContextMenuModsReportOnGitHub.Name = "ContextMenuModsReportOnGitHub";
            this.ContextMenuModsReportOnGitHub.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsReportOnGitHub.Text = "Report an Issue";
            this.ContextMenuModsReportOnGitHub.Click += new System.EventHandler(this.ContextMenuModsReportOnGitHub_Click);
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.Appearance.Options.UseFont = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(534, 42);
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
            this.FlowPanelDetails.Location = new System.Drawing.Point(2, 21);
            this.FlowPanelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelDetails.MaximumSize = new System.Drawing.Size(373, 0);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(3, 8, 18, 4);
            this.FlowPanelDetails.Size = new System.Drawing.Size(373, 582);
            this.FlowPanelDetails.TabIndex = 0;
            this.FlowPanelDetails.TabStop = true;
            this.FlowPanelDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowPanelDetails_Scroll);
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
            this.LabelHeaderName.Appearance.Options.UseFont = true;
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
            this.LabelName.Appearance.Options.UseFont = true;
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
            this.LabelHeaderCategory.Appearance.Options.UseFont = true;
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
            this.LabelCategory.Appearance.Options.UseFont = true;
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
            this.LabelHeaderFirmware.Appearance.Options.UseFont = true;
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
            this.LabelFirmware.Appearance.Options.UseFont = true;
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
            this.LabelHeaderModType.Appearance.Options.UseFont = true;
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
            this.LabelType.Appearance.Options.UseFont = true;
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
            this.LabelHeaderVersion.Appearance.Options.UseFont = true;
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
            this.LabelVersion.Appearance.Options.UseFont = true;
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
            this.LabelHeaderRegion.Appearance.Options.UseFont = true;
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
            this.LabelRegion.Appearance.Options.UseFont = true;
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
            this.LabelHeaderGameType.Appearance.Options.UseFont = true;
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
            this.LabelConfig.Appearance.Options.UseFont = true;
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
            this.LabelHeaderAuthor.Appearance.Options.UseFont = true;
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
            this.LabelAuthor.Appearance.Options.UseFont = true;
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
            this.LabelHeaderSubmittedBy.Appearance.Options.UseFont = true;
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
            this.LabelSubmittedBy.Appearance.Options.UseFont = true;
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
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(9, 246);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(6, 6, 2, 3);
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
            this.GridControlModsInstallFiles.Location = new System.Drawing.Point(2, 21);
            this.GridControlModsInstallFiles.MainView = this.GridViewModsInstallFiles;
            this.GridControlModsInstallFiles.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlModsInstallFiles.Name = "GridControlModsInstallFiles";
            this.GridControlModsInstallFiles.Size = new System.Drawing.Size(369, 92);
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
            // LabelSelectSystemType
            // 
            this.LabelSelectSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectSystemType.Appearance.Options.UseFont = true;
            this.LabelSelectSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectSystemType.Location = new System.Drawing.Point(389, 42);
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
            this.PanelModsLibraryFilters.Location = new System.Drawing.Point(2, 21);
            this.PanelModsLibraryFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsLibraryFilters.Name = "PanelModsLibraryFilters";
            this.PanelModsLibraryFilters.Size = new System.Drawing.Size(859, 96);
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
            this.TextBoxSearch.Size = new System.Drawing.Size(324, 22);
            this.TextBoxSearch.TabIndex = 1169;
            this.TextBoxSearch.EditValueChanged += new System.EventHandler(this.TextBoxSearch_EditValueChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMenu,
            this.BarStatus});
            this.MainMenu.DockControls.Add(this.barDockControlTop);
            this.MainMenu.DockControls.Add(this.barDockControlBottom);
            this.MainMenu.DockControls.Add(this.barDockControlLeft);
            this.MainMenu.DockControls.Add(this.barDockControlRight);
            this.MainMenu.DockControls.Add(this.DockModInformation);
            this.MainMenu.DockControls.Add(this.DockControlModsInstalled);
            this.MainMenu.Form = this;
            this.MainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuBarItemConnect,
            this.MenuBarItemTools,
            this.MenuBarItemApplications,
            this.MenuBarItemOptions,
            this.MenuBarItemHelp,
            this.barButtonItem6,
            this.barButtonItem7,
            this.ButtonPS3GameBackupFiles,
            this.ButtonPS3GameUpdateFinder,
            this.barToolbarsListItem1,
            this.barWorkspaceMenuItem1,
            this.ButtonPS3FileManager,
            this.ButtonPS3PackageManager,
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
            this.ButtonPS3WebManControls,
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
            this.ButtonXboxFileManager,
            this.ButtonXboxXBDMMenu,
            this.ButtonXboxPowerFunctions,
            this.xbdmShutdown,
            this.barButtonItem3,
            this.barSubItem2,
            this.barButtonItem2,
            this.barSubItem4,
            this.ButtonXboxMessageBoxUI,
            this.barButtonItem5,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.ButtonXboxFindConsole,
            this.barToolbarsListItem3,
            this.barSubItem5,
            this.barButtonItem12,
            this.barButtonItem13,
            this.QuickSignIn,
            this.barButtonItem15,
            this.barButtonItem16,
            this.LabelHeaderConnectedConsole,
            this.barStaticItem2,
            this.LabelModsStats,
            this.barSubItem6,
            this.barButtonItem17,
            this.XNotifyButton,
            this.OpenCloseTray,
            this.barHeaderItem1,
            this.barListItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.barSubItem7,
            this.barButtonItem1,
            this.XNotifySend,
            this.ProfileIDInfo,
            this.barButtonItem4});
            this.MainMenu.MainMenu = this.BarMenu;
            this.MainMenu.MaxItemId = 101;
            this.MainMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.XNotifyText,
            this.XNotifyType});
            this.MainMenu.StatusBar = this.BarStatus;
            // 
            // BarMenu
            // 
            this.BarMenu.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.BarMenu.BarItemVertIndent = 5;
            this.BarMenu.BarName = "Main menu";
            this.BarMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.BarMenu.DockCol = 0;
            this.BarMenu.DockRow = 0;
            this.BarMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BarMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemConnect),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemTools),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemApplications),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemOptions),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuBarItemHelp)});
            this.BarMenu.OptionsBar.DrawBorder = false;
            this.BarMenu.OptionsBar.MultiLine = true;
            this.BarMenu.OptionsBar.UseWholeRow = true;
            this.BarMenu.Text = "Main menu";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXbox360),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxFindConsole)});
            this.ButtonXbox360.Name = "ButtonXbox360";
            // 
            // ButtonConnectToXBOX
            // 
            this.ButtonConnectToXBOX.Caption = "Connect to Console...";
            this.ButtonConnectToXBOX.Id = 56;
            this.ButtonConnectToXBOX.Name = "ButtonConnectToXBOX";
            this.ButtonConnectToXBOX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConnectXBOX_ItemClick);
            // 
            // ButtonXboxFindConsole
            // 
            this.ButtonXboxFindConsole.Caption = "Find Console...";
            this.ButtonXboxFindConsole.Id = 78;
            this.ButtonXboxFindConsole.Name = "ButtonXboxFindConsole";
            this.ButtonXboxFindConsole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonFindXBOX_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ch";
            this.barButtonItem4.Id = 100;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick_1);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3GameBackupFiles, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3GameUpdateFinder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3FileManager, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3PackageManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3WebManControls, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxXBDMMenu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxFileManager)});
            this.ToolsMenu.Manager = this.MainMenu;
            this.ToolsMenu.Name = "ToolsMenu";
            // 
            // ButtonPS3GameBackupFiles
            // 
            this.ButtonPS3GameBackupFiles.Caption = "Game Backup Files...";
            this.ButtonPS3GameBackupFiles.Id = 7;
            this.ButtonPS3GameBackupFiles.Name = "ButtonPS3GameBackupFiles";
            this.ButtonPS3GameBackupFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonGameBackupFiles_ItemClick);
            // 
            // ButtonPS3GameUpdateFinder
            // 
            this.ButtonPS3GameUpdateFinder.Caption = "Game Update Finder...";
            this.ButtonPS3GameUpdateFinder.Id = 8;
            this.ButtonPS3GameUpdateFinder.Name = "ButtonPS3GameUpdateFinder";
            this.ButtonPS3GameUpdateFinder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonGameUpdateFinder_ItemClick);
            // 
            // ButtonPS3FileManager
            // 
            this.ButtonPS3FileManager.Caption = "File Manager...";
            this.ButtonPS3FileManager.Id = 12;
            this.ButtonPS3FileManager.Name = "ButtonPS3FileManager";
            this.ButtonPS3FileManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonFileManager_ItemClick);
            // 
            // ButtonPS3PackageManager
            // 
            this.ButtonPS3PackageManager.Caption = "Package Manager...";
            this.ButtonPS3PackageManager.Id = 13;
            this.ButtonPS3PackageManager.Name = "ButtonPS3PackageManager";
            this.ButtonPS3PackageManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPackageManager_ItemClick);
            // 
            // ButtonPS3WebManControls
            // 
            this.ButtonPS3WebManControls.Caption = "WebMAN Controls...";
            this.ButtonPS3WebManControls.Id = 37;
            this.ButtonPS3WebManControls.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSystemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonNotifyMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonVirtualController)});
            this.ButtonPS3WebManControls.Name = "ButtonPS3WebManControls";
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
            // ButtonXboxXBDMMenu
            // 
            this.ButtonXboxXBDMMenu.Caption = "XBDM Controls...";
            this.ButtonXboxXBDMMenu.Id = 66;
            this.ButtonXboxXBDMMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxMessageBoxUI),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6)});
            this.ButtonXboxXBDMMenu.Name = "ButtonXboxXBDMMenu";
            // 
            // ButtonXboxMessageBoxUI
            // 
            this.ButtonXboxMessageBoxUI.Caption = "XMessagebox UI";
            this.ButtonXboxMessageBoxUI.Id = 73;
            this.ButtonXboxMessageBoxUI.Name = "ButtonXboxMessageBoxUI";
            this.ButtonXboxMessageBoxUI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxXBDM_XMessageboxUI_ItemClick);
            // 
            // ButtonXboxPowerFunctions
            // 
            this.ButtonXboxPowerFunctions.Caption = "Power Functions";
            this.ButtonXboxPowerFunctions.Id = 67;
            this.ButtonXboxPowerFunctions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.xbdmShutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9)});
            this.ButtonXboxPowerFunctions.Name = "ButtonXboxPowerFunctions";
            // 
            // xbdmShutdown
            // 
            this.xbdmShutdown.Caption = "Shutdown...";
            this.xbdmShutdown.Id = 68;
            this.xbdmShutdown.Name = "xbdmShutdown";
            this.xbdmShutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxXBDMShutdown_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Restart...";
            this.barButtonItem3.Id = 69;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxXBDMReboot_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Soft Reboot...";
            this.barButtonItem8.Id = 75;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxXBDMSoftReboot_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Hard Reboot...";
            this.barButtonItem9.Id = 76;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxXBDMHardReboot_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "System Info";
            this.barSubItem2.Id = 70;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem16)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Show CPU/GPU/RAM/MOBO Temps...";
            this.barButtonItem16.Id = 85;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxShowTemperature_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "XNotify";
            this.barSubItem4.Id = 72;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Xbox Dashboard";
            this.barSubItem5.Id = 80;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ProfileIDInfo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.QuickSignIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem12, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem13, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.OpenCloseTray, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // ProfileIDInfo
            // 
            this.ProfileIDInfo.Caption = "Show Profile ID";
            this.ProfileIDInfo.Id = 99;
            this.ProfileIDInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProfileIDInfo.ImageOptions.Image")));
            this.ProfileIDInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ProfileIDInfo.ImageOptions.LargeImage")));
            this.ProfileIDInfo.Name = "ProfileIDInfo";
            this.ProfileIDInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxProfileIDInfo_ItemClick);
            // 
            // QuickSignIn
            // 
            this.QuickSignIn.Caption = "Quick Sign In...";
            this.QuickSignIn.Id = 83;
            this.QuickSignIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("QuickSignIn.ImageOptions.Image")));
            this.QuickSignIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("QuickSignIn.ImageOptions.LargeImage")));
            this.QuickSignIn.Name = "QuickSignIn";
            this.QuickSignIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxQuickSignIn_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Avatar Editor...";
            this.barButtonItem12.Id = 81;
            this.barButtonItem12.ItemInMenuAppearance.Hovered.Options.UseImage = true;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxAvatarEditor_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Xbox Home..";
            this.barButtonItem13.Id = 82;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // OpenCloseTray
            // 
            this.OpenCloseTray.Caption = "Open/Close Tray";
            this.OpenCloseTray.Id = 91;
            this.OpenCloseTray.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OpenCloseTray.ImageOptions.Image")));
            this.OpenCloseTray.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("OpenCloseTray.ImageOptions.LargeImage")));
            this.OpenCloseTray.Name = "OpenCloseTray";
            this.OpenCloseTray.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxOpenCloseTray_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Virtual Controller..";
            this.barButtonItem15.Id = 84;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxVirtualController_ItemClick);
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Debugging Tools";
            this.barSubItem6.Id = 88;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem17)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Memory Peek/Poker";
            this.barButtonItem17.Id = 89;
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // ButtonXboxFileManager
            // 
            this.ButtonXboxFileManager.Caption = "File Manager...";
            this.ButtonXboxFileManager.Id = 65;
            this.ButtonXboxFileManager.Name = "ButtonXboxFileManager";
            this.ButtonXboxFileManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxFileManager_ItemClick);
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
            // BarStatus
            // 
            this.BarStatus.BarItemHorzIndent = 3;
            this.BarStatus.BarItemVertIndent = 5;
            this.BarStatus.BarName = "Status bar";
            this.BarStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BarStatus.DockCol = 0;
            this.BarStatus.DockRow = 0;
            this.BarStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BarStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderConnectedConsole),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelConsoleConnected),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelModsStats)});
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // LabelHeaderConnectedConsole
            // 
            this.LabelHeaderConnectedConsole.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderConnectedConsole.Caption = "Connected Console:";
            this.LabelHeaderConnectedConsole.Id = 85;
            this.LabelHeaderConnectedConsole.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderConnectedConsole.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderConnectedConsole.LeftIndent = 4;
            this.LabelHeaderConnectedConsole.Name = "LabelHeaderConnectedConsole";
            // 
            // LabelConsoleConnected
            // 
            this.LabelConsoleConnected.Caption = "Idle";
            this.LabelConsoleConnected.Id = 54;
            this.LabelConsoleConnected.Name = "LabelConsoleConnected";
            this.LabelConsoleConnected.RightIndent = 3;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem2.Caption = "Status:";
            this.barStaticItem2.Id = 86;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.LeftIndent = 3;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.Id = 63;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // LabelModsStats
            // 
            this.LabelModsStats.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.LabelModsStats.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelModsStats.Caption = "Stats";
            this.LabelModsStats.Id = 87;
            this.LabelModsStats.Name = "LabelModsStats";
            this.LabelModsStats.RightIndent = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainMenu;
            this.barDockControlTop.Size = new System.Drawing.Size(1584, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 793);
            this.barDockControlBottom.Manager = this.MainMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1584, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.MainMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 767);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1584, 26);
            this.barDockControlRight.Manager = this.MainMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 767);
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
            // DockControlModsInstalled
            // 
            this.DockControlModsInstalled.CausesValidation = false;
            this.DockControlModsInstalled.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DockControlModsInstalled.Location = new System.Drawing.Point(2, 176);
            this.DockControlModsInstalled.Manager = this.MainMenu;
            this.DockControlModsInstalled.Name = "DockControlModsInstalled";
            this.DockControlModsInstalled.Size = new System.Drawing.Size(859, 23);
            this.DockControlModsInstalled.Text = "standaloneBarDockControl1";
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
            this.barWorkspaceMenuItem1.WorkspaceManager = this.WorkspaceManager;
            // 
            // WorkspaceManager
            // 
            this.WorkspaceManager.TargetControl = this;
            this.WorkspaceManager.TransitionType = pushTransition1;
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
            // LabelHeaderConsoleConnected
            // 
            this.LabelHeaderConsoleConnected.Caption = "Console Connected:";
            this.LabelHeaderConsoleConnected.Id = 53;
            this.LabelHeaderConsoleConnected.Name = "LabelHeaderConsoleConnected";
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
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 64;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
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
            // XNotifyButton
            // 
            this.XNotifyButton.Caption = "XNotify";
            this.XNotifyButton.Id = 90;
            this.XNotifyButton.Name = "XNotifyButton";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 92;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 93;
            this.barListItem1.Name = "barListItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.AccessibleDescription = "";
            this.barEditItem1.Caption = "Text";
            this.barEditItem1.Edit = this.XNotifyText;
            this.barEditItem1.Id = 94;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // XNotifyText
            // 
            this.XNotifyText.AutoHeight = false;
            this.XNotifyText.Name = "XNotifyText";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Type";
            this.barEditItem2.Description = "x";
            this.barEditItem2.Edit = this.XNotifyType;
            this.barEditItem2.Hint = "Type Of icons ";
            this.barEditItem2.Id = 95;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Tag = "<Null>";
            this.barEditItem2.VisibleInSearchMenu = false;
            // 
            // XNotifyType
            // 
            this.XNotifyType.AccessibleDescription = "";
            this.XNotifyType.AutoHeight = false;
            this.XNotifyType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "mnjukjui", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.XNotifyType.Items.AddRange(new object[] {
            "Blank",
            "Game Invite",
            "Friend Request",
            "Message Logo",
            "Message",
            "Signed Out",
            "Signed In",
            "Signed In Live",
            "Signed In Offline",
            "Chat Request",
            "Disconnected",
            "Downloaded",
            "Music Logo",
            "Smiley Face",
            "Sad Face",
            "Hammer",
            "Reinsert Memory",
            "Reconnect Controller",
            "Joined Chat",
            "Left Chat",
            "Game Invite Sent",
            "Page Sent",
            "Achievement",
            "Video Kinect",
            "Ready to Play",
            "Can\'t Download",
            "Download Stopped",
            "Console Logo",
            "Game Message",
            "Device Full",
            "Achievements",
            "Family Timer",
            "Reconnect Time",
            "Excessive Play Time",
            "Party Invite Recieved",
            "Party Invite Sent",
            "Invite Party to Game",
            "Party Kicked",
            "Party Disconnected",
            "Party Can\'t Connect",
            "Joined Party",
            "Left Party",
            "Gamer pic Unlocked",
            "Avatar Award Unlocked",
            "Party Joined",
            "Reinsert USB",
            "Player Muted",
            "Player Unmuted",
            "Kinect Connected",
            "Take a Break",
            "Kinect Recognized",
            "Console Auto Shut Off",
            "Signed in Elsewhere",
            "Last Signed in Elsewhere",
            "Kinect Not Supported",
            "Wireless Turn Off",
            "Updating",
            "SmartGlass Available"});
            this.XNotifyType.Name = "XNotifyType";
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "XNotify";
            this.barSubItem7.Id = 96;
            this.barSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.XNotifySend)});
            this.barSubItem7.Name = "barSubItem7";
            // 
            // XNotifySend
            // 
            this.XNotifySend.Caption = "Send XNotify";
            this.XNotifySend.Id = 98;
            this.XNotifySend.Name = "XNotifySend";
            this.XNotifySend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XboxNotifySend_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 97;
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.labelControl2.Size = new System.Drawing.Size(846, 15);
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
            this.labelControl1.Size = new System.Drawing.Size(846, 15);
            this.labelControl1.TabIndex = 1167;
            this.labelControl1.Text = "FILTER MODS";
            // 
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRegion.Location = new System.Drawing.Point(749, 39);
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
            this.ComboBoxModType.Location = new System.Drawing.Point(597, 39);
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
            this.ComboBoxSystemType.Location = new System.Drawing.Point(466, 39);
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
            this.LabelSelectRegion.Appearance.Options.UseFont = true;
            this.LabelSelectRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectRegion.Location = new System.Drawing.Point(701, 42);
            this.LabelSelectRegion.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectRegion.Name = "LabelSelectRegion";
            this.LabelSelectRegion.Size = new System.Drawing.Size(42, 15);
            this.LabelSelectRegion.TabIndex = 1163;
            this.LabelSelectRegion.Text = "REGION";
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.Options.UseFont = true;
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
            this.GridControlGameModsInstalled.Location = new System.Drawing.Point(2, 21);
            this.GridControlGameModsInstalled.MainView = this.GridViewGameModsInstalled;
            this.GridControlGameModsInstalled.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlGameModsInstalled.Name = "GridControlGameModsInstalled";
            this.GridControlGameModsInstalled.Size = new System.Drawing.Size(859, 155);
            this.GridControlGameModsInstalled.TabIndex = 7;
            this.GridControlGameModsInstalled.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameModsInstalled});
            this.GridControlGameModsInstalled.BackColorChanged += new System.EventHandler(this.GridControlGameModsInstalled_BackColorChanged);
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
            this.GroupModsLibrary.Location = new System.Drawing.Point(322, 39);
            this.GroupModsLibrary.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.GroupModsLibrary.Name = "GroupModsLibrary";
            this.GroupModsLibrary.Size = new System.Drawing.Size(863, 532);
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
            this.ProgressMods.Description = "Loading..";
            this.ProgressMods.Location = new System.Drawing.Point(323, 187);
            this.ProgressMods.Name = "ProgressMods";
            this.ProgressMods.Size = new System.Drawing.Size(246, 66);
            this.ProgressMods.TabIndex = 1170;
            this.ProgressMods.Visible = false;
            this.ProgressMods.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridControlMods
            // 
            this.GridControlMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlMods.Location = new System.Drawing.Point(2, 117);
            this.GridControlMods.MainView = this.GridViewMods;
            this.GridControlMods.MenuManager = this.MainMenu;
            this.GridControlMods.Name = "GridControlMods";
            this.GridControlMods.Size = new System.Drawing.Size(859, 413);
            this.GridControlMods.TabIndex = 1171;
            this.GridControlMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMods});
            this.GridControlMods.BackColorChanged += new System.EventHandler(this.GridControlMods_BackColorChanged);
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
            this.NavigationBar.Location = new System.Drawing.Point(2, 21);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.OptionsNavPane.ExpandedWidth = 296;
            this.NavigationBar.Size = new System.Drawing.Size(296, 720);
            this.NavigationBar.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.NavigationBar.TabIndex = 1180;
            this.NavigationBar.Text = "navBarControl1";
            this.NavigationBar.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
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
            // GroupCategories
            // 
            this.GroupCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupCategories.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GroupCategories.AppearanceCaption.Options.UseFont = true;
            this.GroupCategories.Controls.Add(this.NavigationBar);
            this.GroupCategories.Location = new System.Drawing.Point(12, 39);
            this.GroupCategories.Margin = new System.Windows.Forms.Padding(4, 3, 5, 3);
            this.GroupCategories.Name = "GroupCategories";
            this.GroupCategories.Size = new System.Drawing.Size(300, 743);
            this.GroupCategories.TabIndex = 1185;
            this.GroupCategories.Text = "CATEGORIES";
            // 
            // GroupModsInstalled
            // 
            this.GroupModsInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModsInstalled.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GroupModsInstalled.AppearanceCaption.Options.UseFont = true;
            this.GroupModsInstalled.Controls.Add(this.ProgressModsInstalled);
            this.GroupModsInstalled.Controls.Add(this.GridControlGameModsInstalled);
            this.GroupModsInstalled.Controls.Add(this.DockControlModsInstalled);
            this.GroupModsInstalled.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.GroupModsInstalled.Location = new System.Drawing.Point(322, 581);
            this.GroupModsInstalled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 3);
            this.GroupModsInstalled.Name = "GroupModsInstalled";
            this.GroupModsInstalled.Size = new System.Drawing.Size(863, 201);
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
            this.ProgressModsInstalled.Location = new System.Drawing.Point(323, 87);
            this.ProgressModsInstalled.Name = "ProgressModsInstalled";
            this.ProgressModsInstalled.Size = new System.Drawing.Size(246, 66);
            this.ProgressModsInstalled.TabIndex = 1171;
            this.ProgressModsInstalled.Text = "progressPanel1";
            this.ProgressModsInstalled.Visible = false;
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
            this.GroupModInformation.Margin = new System.Windows.Forms.Padding(5, 3, 4, 3);
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
            // BarManagerModInformation
            // 
            this.BarManagerModInformation.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMenuModInformation});
            this.BarManagerModInformation.DockControls.Add(this.barDockControl1);
            this.BarManagerModInformation.DockControls.Add(this.barDockControl2);
            this.BarManagerModInformation.DockControls.Add(this.barDockControl3);
            this.BarManagerModInformation.DockControls.Add(this.barDockControl4);
            this.BarManagerModInformation.Form = this;
            this.BarManagerModInformation.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ButtonModInstall,
            this.ButtonModUninstall,
            this.ButtonModDownload,
            this.ButtonModFavorite});
            this.BarManagerModInformation.MainMenu = this.BarMenuModInformation;
            this.BarManagerModInformation.MaxItemId = 4;
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
            this.ButtonModInstall.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonModInstall_ItemClick);
            // 
            // ButtonModUninstall
            // 
            this.ButtonModUninstall.Caption = "Uninstall";
            this.ButtonModUninstall.Id = 1;
            this.ButtonModUninstall.Name = "ButtonModUninstall";
            this.ButtonModUninstall.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonModUninstall_ItemClick);
            // 
            // ButtonModDownload
            // 
            this.ButtonModDownload.Caption = "Download";
            this.ButtonModDownload.Id = 2;
            this.ButtonModDownload.Name = "ButtonModDownload";
            this.ButtonModDownload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonModDownload_ItemClick);
            // 
            // ButtonModFavorite
            // 
            this.ButtonModFavorite.Caption = "Favorite";
            this.ButtonModFavorite.Id = 3;
            this.ButtonModFavorite.Name = "ButtonModFavorite";
            this.ButtonModFavorite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonModFavorite_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.BarManagerModInformation;
            this.barDockControl1.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 821);
            this.barDockControl2.Manager = this.BarManagerModInformation;
            this.barDockControl2.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.BarManagerModInformation;
            this.barDockControl3.Size = new System.Drawing.Size(0, 821);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1584, 0);
            this.barDockControl4.Manager = this.BarManagerModInformation;
            this.barDockControl4.Size = new System.Drawing.Size(0, 821);
            // 
            // BarManagerModsInstalled
            // 
            this.BarManagerModsInstalled.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarModsInstalled});
            this.BarManagerModsInstalled.DockControls.Add(this.barDockControl5);
            this.BarManagerModsInstalled.DockControls.Add(this.barDockControl6);
            this.BarManagerModsInstalled.DockControls.Add(this.barDockControl7);
            this.BarManagerModsInstalled.DockControls.Add(this.barDockControl8);
            this.BarManagerModsInstalled.Form = this;
            this.BarManagerModsInstalled.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.HeaderLabelModsInstalled,
            this.LabelModsInstalled,
            this.ButtonModsUninstallAll});
            this.BarManagerModsInstalled.MainMenu = this.BarModsInstalled;
            this.BarManagerModsInstalled.MaxItemId = 3;
            // 
            // BarModsInstalled
            // 
            this.BarModsInstalled.BarItemVertIndent = 5;
            this.BarModsInstalled.BarName = "Main menu";
            this.BarModsInstalled.DockCol = 0;
            this.BarModsInstalled.DockRow = 0;
            this.BarModsInstalled.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.BarModsInstalled.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelModsInstalled),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonModsUninstallAll)});
            this.BarModsInstalled.OptionsBar.DrawBorder = false;
            this.BarModsInstalled.OptionsBar.DrawDragBorder = false;
            this.BarModsInstalled.OptionsBar.MultiLine = true;
            this.BarModsInstalled.OptionsBar.UseWholeRow = true;
            this.BarModsInstalled.StandaloneBarDockControl = this.DockControlModsInstalled;
            this.BarModsInstalled.Text = "Main menu";
            // 
            // LabelModsInstalled
            // 
            this.LabelModsInstalled.Caption = "0 Mods Installed";
            this.LabelModsInstalled.Id = 1;
            this.LabelModsInstalled.LeftIndent = 6;
            this.LabelModsInstalled.Name = "LabelModsInstalled";
            // 
            // ButtonModsUninstallAll
            // 
            this.ButtonModsUninstallAll.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ButtonModsUninstallAll.Caption = "Uninstall All";
            this.ButtonModsUninstallAll.Id = 2;
            this.ButtonModsUninstallAll.Name = "ButtonModsUninstallAll";
            this.ButtonModsUninstallAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonModsUninstallAll_ItemClick);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.BarManagerModsInstalled;
            this.barDockControl5.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 821);
            this.barDockControl6.Manager = this.BarManagerModsInstalled;
            this.barDockControl6.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.BarManagerModsInstalled;
            this.barDockControl7.Size = new System.Drawing.Size(0, 821);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1584, 0);
            this.barDockControl8.Manager = this.BarManagerModsInstalled;
            this.barDockControl8.Size = new System.Drawing.Size(0, 821);
            // 
            // HeaderLabelModsInstalled
            // 
            this.HeaderLabelModsInstalled.Caption = "Mods Installed:";
            this.HeaderLabelModsInstalled.Id = 0;
            this.HeaderLabelModsInstalled.Name = "HeaderLabelModsInstalled";
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
            this.Controls.Add(this.GroupCategories);
            this.Controls.Add(this.GroupModsLibrary);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainWindow.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1586, 853);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v1.4.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.StyleChanged += new System.EventHandler(this.MainWindow_StyleChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyType)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupCategories)).EndInit();
            this.GroupCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsInstalled)).EndInit();
            this.GroupModsInstalled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupModInformation)).EndInit();
            this.GroupModInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallFiles)).EndInit();
            this.GroupInstallFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerModInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerModsInstalled)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl LabelHeaderName;
        private System.Windows.Forms.Panel PanelModsLibraryFilters;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraGrid.GridControl GridControlGameModsInstalled;
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
        private Bar BarMenu;
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
        private Bar BarStatus;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private ComboBoxEdit ComboBoxSystemType;
        private BarButtonItem ButtonPS3GameBackupFiles;
        private BarButtonItem ButtonPS3GameUpdateFinder;
        private BarButtonItem ButtonPS3FileManager;
        private BarButtonItem ButtonPS3PackageManager;
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
        private BarSubItem ButtonPS3WebManControls;
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
        private GroupControl GroupCategories;
        private Bar bar4;
        private GroupControl GroupModInformation;
        private GroupControl GroupInstallFiles;
        private DevExpress.Utils.WorkspaceManager WorkspaceManager;
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
        private BarManager BarManagerModInformation;
        private Bar BarMenuModInformation;
        private BarButtonItem ButtonModInstall;
        private BarButtonItem ButtonModUninstall;
        private BarButtonItem ButtonModDownload;
        private BarButtonItem ButtonModFavorite;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl4;
        private VScrollBar ScrollBarModInformation;
        private BarButtonItem ButtonXboxFileManager;
        private BarSubItem ButtonXboxXBDMMenu;
        private BarSubItem ButtonXboxPowerFunctions;
        private BarButtonItem xbdmShutdown;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarSubItem barSubItem2;
        private BarSubItem barSubItem4;
        private BarButtonItem ButtonXboxMessageBoxUI;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem10;
        private BarButtonItem ButtonXboxFindConsole;
        private BarSubItem barSubItem5;
        private BarButtonItem barButtonItem12;
        private BarToolbarsListItem barToolbarsListItem3;
        private BarButtonItem barButtonItem13;
        private BarButtonItem QuickSignIn;
        private BarButtonItem barButtonItem15;
        private BarButtonItem barButtonItem16;
        private StandaloneBarDockControl DockControlModsInstalled;
        private BarDockControl barDockControl7;
        private BarManager BarManagerModsInstalled;
        private Bar BarModsInstalled;
        private BarHeaderItem HeaderLabelModsInstalled;
        private BarStaticItem LabelModsInstalled;
        private BarButtonItem ButtonModsUninstallAll;
        private BarDockControl barDockControl5;
        private BarDockControl barDockControl6;
        private BarDockControl barDockControl8;
        private BarStaticItem LabelHeaderConnectedConsole;
        private BarStaticItem barStaticItem2;
        private BarStaticItem LabelModsStats;
        private BarButtonItem XNotifyButton;
        private BarSubItem barSubItem6;
        private BarButtonItem barButtonItem17;
        private BarButtonItem OpenCloseTray;
        private BarSubItem barSubItem7;
        private BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox XNotifyType;
        private BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit XNotifyText;
        private BarButtonItem XNotifySend;
        private BarHeaderItem barHeaderItem1;
        private BarListItem barListItem1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem ProfileIDInfo;
        private BarButtonItem barButtonItem4;
    }
}