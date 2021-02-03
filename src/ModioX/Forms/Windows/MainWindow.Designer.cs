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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.MenuBarItemTools = new DevExpress.XtraBars.BarButtonItem();
            this.ToolsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonGameBackupFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3GameUpdateFinder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3FileManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3PackageManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3WebManControls = new DevExpress.XtraBars.BarSubItem();
            this.ButtonPS3PowerFunctions = new DevExpress.XtraBars.BarSubItem();
            this.ButtonPS3Shutdown = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3Restart = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3SoftReboot = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3HardReboot = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3SystemInfo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonPS3ShowSystemInformation = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3ShowMinimumVersion = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3ShowTemperatures = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3NotifyMessage = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonPS3VirtualController = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxFileManager = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxPluginsEditor = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxXBDMMenu = new DevExpress.XtraBars.BarSubItem();
            this.ButtonXboxPowerFunctions = new DevExpress.XtraBars.BarSubItem();
            this.ButtonXboxPowerShutdown = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxPowerRestart = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxPowerSoftReboot = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxPowerHardReboot = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxSystemInfo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonXboxShowSystemTemperatures = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxDashboard = new DevExpress.XtraBars.BarSubItem();
            this.ButtonXboxShowProfileIDInfo = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxQuickSignIn = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxAvatarEditor = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxDashboardHome = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxOpenCloseTray = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxTakeScreenshot = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXboxXNotifyMessage = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBarItemApplications = new DevExpress.XtraBars.BarButtonItem();
            this.ApplicationsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuBarItemOptions = new DevExpress.XtraBars.BarButtonItem();
            this.OptionsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonAddNewConsole = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonEditGameRegions = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonEditApplications = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonEditLists = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonSettings = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBarItemHelp = new DevExpress.XtraBars.BarButtonItem();
            this.HelpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonDiscordServer = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonOfficialSource = new DevExpress.XtraBars.BarButtonItem();
            this.OpenLogFileButton = new DevExpress.XtraBars.BarButtonItem();
            this.OpenLogFolderButton = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonCheckForUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonWhatsNew = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonSkinChanger = new DevExpress.XtraBars.SkinBarSubItem();
            this.ButtonAbout = new DevExpress.XtraBars.BarButtonItem();
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderConnectedConsole = new DevExpress.XtraBars.BarStaticItem();
            this.LabelConsoleConnected = new DevExpress.XtraBars.BarStaticItem();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelModsStats = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.LabelHeaderConsoleConnected = new DevExpress.XtraBars.BarHeaderItem();
            this.ButtonModInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModUninstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModDownloadArchive = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModAddToList = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModRemoveFromList = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonModReportAnIssue = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonXNotifySend = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.XNotifyText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.XNotifyType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
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
            this.GridControlInstalledGameMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewInstalledGameMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnModsInstalledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledNoOfFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledUninstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupModsLibrary = new DevExpress.XtraEditors.GroupControl();
            this.ProgressMods = new DevExpress.XtraWaitForm.ProgressPanel();
            this.GridControlMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NavBarCategories = new DevExpress.XtraNavBar.NavBarControl();
            this.NavGroupGames = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupHomebrewApps = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupResources = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupMyLists = new DevExpress.XtraNavBar.NavBarGroup();
            this.GroupCategories = new DevExpress.XtraEditors.GroupControl();
            this.GroupModsInstalled = new DevExpress.XtraEditors.GroupControl();
            this.ProgressInstalledMods = new DevExpress.XtraWaitForm.ProgressPanel();
            this.PanelInstalledModsPlugins = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonUninstallInstalledMods = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUninstallAllMods = new DevExpress.XtraEditors.SimpleButton();
            this.GroupModInformation = new DevExpress.XtraEditors.GroupControl();
            this.ScrollBarModInformation = new DevExpress.XtraEditors.VScrollBar();
            this.GroupInstallFiles = new DevExpress.XtraEditors.GroupControl();
            this.PanelButtonsModInformation = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonModInstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonModUninstall = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonModDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonModFavorite = new DevExpress.XtraEditors.SimpleButton();
            this.ModsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BarManagerModsInstalled = new DevExpress.XtraBars.BarManager(this.components);
            this.BarModsInstalled = new DevExpress.XtraBars.Bar();
            this.LabelModsInstalled = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.HeaderLabelModsInstalled = new DevExpress.XtraBars.BarHeaderItem();
            this.ButtonModsUninstallAll = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInstalledGameMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInstalledGameMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsLibrary)).BeginInit();
            this.GroupModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBarCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCategories)).BeginInit();
            this.GroupCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsInstalled)).BeginInit();
            this.GroupModsInstalled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelInstalledModsPlugins)).BeginInit();
            this.PanelInstalledModsPlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModInformation)).BeginInit();
            this.GroupModInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallFiles)).BeginInit();
            this.GroupInstallFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsModInformation)).BeginInit();
            this.PanelButtonsModInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerModsInstalled)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.Appearance.Options.UseFont = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(531, 42);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelSelectType.Size = new System.Drawing.Size(63, 15);
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
            this.FlowPanelDetails.Size = new System.Drawing.Size(373, 570);
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
            this.GridControlModsInstallFiles.Location = new System.Drawing.Point(2, 23);
            this.GridControlModsInstallFiles.MainView = this.GridViewModsInstallFiles;
            this.GridControlModsInstallFiles.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlModsInstallFiles.Name = "GridControlModsInstallFiles";
            this.GridControlModsInstallFiles.Size = new System.Drawing.Size(369, 99);
            this.GridControlModsInstallFiles.TabIndex = 3;
            this.GridControlModsInstallFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewModsInstallFiles});
            // 
            // GridViewModsInstallFiles
            // 
            this.GridViewModsInstallFiles.ActiveFilterEnabled = false;
            this.GridViewModsInstallFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewModsInstallFiles.GridControl = this.GridControlModsInstallFiles;
            this.GridViewModsInstallFiles.Name = "GridViewModsInstallFiles";
            this.GridViewModsInstallFiles.OptionsBehavior.Editable = false;
            this.GridViewModsInstallFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewModsInstallFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewModsInstallFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewModsInstallFiles.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewModsInstallFiles.OptionsMenu.ShowAutoFilterRowItem = false;
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
            this.LabelSelectSystemType.Location = new System.Drawing.Point(380, 42);
            this.LabelSelectSystemType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectSystemType.Name = "LabelSelectSystemType";
            this.LabelSelectSystemType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelSelectSystemType.Size = new System.Drawing.Size(77, 15);
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
            this.PanelModsLibraryFilters.Size = new System.Drawing.Size(873, 98);
            this.PanelModsLibraryFilters.TabIndex = 12;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(63, 39);
            this.TextBoxSearch.MenuManager = this.MainMenu;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Properties.AllowFocused = false;
            this.TextBoxSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSearch.Size = new System.Drawing.Size(309, 22);
            this.TextBoxSearch.TabIndex = 1;
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
            this.MainMenu.Form = this;
            this.MainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuBarItemConnect,
            this.MenuBarItemTools,
            this.MenuBarItemApplications,
            this.MenuBarItemOptions,
            this.MenuBarItemHelp,
            this.ButtonGameBackupFiles,
            this.ButtonPS3GameUpdateFinder,
            this.ButtonPS3FileManager,
            this.ButtonPS3PackageManager,
            this.ButtonAddNewConsole,
            this.ButtonEditGameRegions,
            this.ButtonEditApplications,
            this.ButtonEditLists,
            this.ButtonSettings,
            this.ButtonSkinChanger,
            this.ButtonDiscordServer,
            this.ButtonOfficialSource,
            this.OpenLogFileButton,
            this.OpenLogFolderButton,
            this.ButtonAbout,
            this.ButtonWhatsNew,
            this.ButtonCheckForUpdate,
            this.ButtonPS3,
            this.ButtonXbox360,
            this.ButtonConnectToPS3,
            this.ButtonPS3WebManControls,
            this.ButtonPS3NotifyMessage,
            this.ButtonPS3VirtualController,
            this.ButtonPS3PowerFunctions,
            this.ButtonPS3Shutdown,
            this.ButtonPS3Restart,
            this.ButtonPS3SoftReboot,
            this.LabelHeaderConsoleConnected,
            this.LabelConsoleConnected,
            this.ButtonConnectToXBOX,
            this.ButtonModInstallFiles,
            this.ButtonModUninstallFiles,
            this.ButtonModDownloadArchive,
            this.ButtonModAddToList,
            this.ButtonModRemoveFromList,
            this.ButtonModReportAnIssue,
            this.LabelStatus,
            this.ButtonXboxFileManager,
            this.ButtonXboxXBDMMenu,
            this.ButtonXboxPowerFunctions,
            this.ButtonXboxPowerShutdown,
            this.ButtonXboxPowerRestart,
            this.ButtonXboxSystemInfo,
            this.ButtonXboxPowerSoftReboot,
            this.ButtonXboxPowerHardReboot,
            this.ButtonXboxDashboard,
            this.ButtonXboxAvatarEditor,
            this.ButtonXboxDashboardHome,
            this.ButtonXboxQuickSignIn,
            this.ButtonXboxShowSystemTemperatures,
            this.LabelHeaderConnectedConsole,
            this.LabelModsStats,
            this.ButtonXboxOpenCloseTray,
            this.ButtonXNotifySend,
            this.ButtonXboxShowProfileIDInfo,
            this.ButtonXboxPluginsEditor,
            this.ButtonXboxXNotifyMessage,
            this.ButtonPS3HardReboot,
            this.LabelHeaderStatus,
            this.ButtonXboxTakeScreenshot,
            this.barButtonItem1,
            this.ButtonPS3SystemInfo,
            this.ButtonPS3ShowMinimumVersion,
            this.ButtonPS3ShowSystemInformation,
            this.ButtonPS3ShowTemperatures});
            this.MainMenu.MainMenu = this.BarMenu;
            this.MainMenu.MaxItemId = 114;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonConnectToXBOX)});
            this.ButtonXbox360.Name = "ButtonXbox360";
            // 
            // ButtonConnectToXBOX
            // 
            this.ButtonConnectToXBOX.Caption = "Connect to Console...";
            this.ButtonConnectToXBOX.Id = 56;
            this.ButtonConnectToXBOX.Name = "ButtonConnectToXBOX";
            this.ButtonConnectToXBOX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConnectXBOX_ItemClick);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3GameUpdateFinder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3FileManager, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3PackageManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3WebManControls, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxFileManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPluginsEditor),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxXBDMMenu, true)});
            this.ToolsMenu.Manager = this.MainMenu;
            this.ToolsMenu.Name = "ToolsMenu";
            // 
            // ButtonGameBackupFiles
            // 
            this.ButtonGameBackupFiles.Caption = "Game Backup Files...";
            this.ButtonGameBackupFiles.Id = 7;
            this.ButtonGameBackupFiles.Name = "ButtonGameBackupFiles";
            this.ButtonGameBackupFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3GameBackupFiles_ItemClick);
            // 
            // ButtonPS3GameUpdateFinder
            // 
            this.ButtonPS3GameUpdateFinder.Caption = "Game Update Finder...";
            this.ButtonPS3GameUpdateFinder.Id = 8;
            this.ButtonPS3GameUpdateFinder.Name = "ButtonPS3GameUpdateFinder";
            this.ButtonPS3GameUpdateFinder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3GameUpdateFinder_ItemClick);
            // 
            // ButtonPS3FileManager
            // 
            this.ButtonPS3FileManager.Caption = "File Manager...";
            this.ButtonPS3FileManager.Id = 12;
            this.ButtonPS3FileManager.Name = "ButtonPS3FileManager";
            this.ButtonPS3FileManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3FileManager_ItemClick);
            // 
            // ButtonPS3PackageManager
            // 
            this.ButtonPS3PackageManager.Caption = "Package Manager...";
            this.ButtonPS3PackageManager.Id = 13;
            this.ButtonPS3PackageManager.Name = "ButtonPS3PackageManager";
            this.ButtonPS3PackageManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3PackageManager_ItemClick);
            // 
            // ButtonPS3WebManControls
            // 
            this.ButtonPS3WebManControls.Caption = "WebMAN Controls...";
            this.ButtonPS3WebManControls.Id = 37;
            this.ButtonPS3WebManControls.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3PowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3SystemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3NotifyMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3VirtualController)});
            this.ButtonPS3WebManControls.Name = "ButtonPS3WebManControls";
            // 
            // ButtonPS3PowerFunctions
            // 
            this.ButtonPS3PowerFunctions.Caption = "Power Functions";
            this.ButtonPS3PowerFunctions.Id = 40;
            this.ButtonPS3PowerFunctions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3Shutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3Restart),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3SoftReboot),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3HardReboot)});
            this.ButtonPS3PowerFunctions.Name = "ButtonPS3PowerFunctions";
            // 
            // ButtonPS3Shutdown
            // 
            this.ButtonPS3Shutdown.Caption = "Shutdown...";
            this.ButtonPS3Shutdown.Id = 41;
            this.ButtonPS3Shutdown.Name = "ButtonPS3Shutdown";
            this.ButtonPS3Shutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3Shutdown_ItemClick);
            // 
            // ButtonPS3Restart
            // 
            this.ButtonPS3Restart.Caption = "Restart...";
            this.ButtonPS3Restart.Id = 42;
            this.ButtonPS3Restart.Name = "ButtonPS3Restart";
            this.ButtonPS3Restart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3Restart_ItemClick);
            // 
            // ButtonPS3SoftReboot
            // 
            this.ButtonPS3SoftReboot.Caption = "Soft Reboot...";
            this.ButtonPS3SoftReboot.Id = 43;
            this.ButtonPS3SoftReboot.Name = "ButtonPS3SoftReboot";
            this.ButtonPS3SoftReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3SoftReboot_ItemClick);
            // 
            // ButtonPS3HardReboot
            // 
            this.ButtonPS3HardReboot.Caption = "Hard Reboot...";
            this.ButtonPS3HardReboot.Id = 105;
            this.ButtonPS3HardReboot.Name = "ButtonPS3HardReboot";
            // 
            // ButtonPS3SystemInfo
            // 
            this.ButtonPS3SystemInfo.Caption = "System Info";
            this.ButtonPS3SystemInfo.Id = 110;
            this.ButtonPS3SystemInfo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3ShowSystemInformation),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3ShowMinimumVersion),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonPS3ShowTemperatures)});
            this.ButtonPS3SystemInfo.Name = "ButtonPS3SystemInfo";
            // 
            // ButtonPS3ShowSystemInformation
            // 
            this.ButtonPS3ShowSystemInformation.Caption = "Show System Information...";
            this.ButtonPS3ShowSystemInformation.Id = 112;
            this.ButtonPS3ShowSystemInformation.Name = "ButtonPS3ShowSystemInformation";
            this.ButtonPS3ShowSystemInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3ShowSystemInformation_ItemClick);
            // 
            // ButtonPS3ShowMinimumVersion
            // 
            this.ButtonPS3ShowMinimumVersion.Caption = "Show Minimum Version...";
            this.ButtonPS3ShowMinimumVersion.Id = 111;
            this.ButtonPS3ShowMinimumVersion.Name = "ButtonPS3ShowMinimumVersion";
            this.ButtonPS3ShowMinimumVersion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3ShowMinimumVersion_ItemClick);
            // 
            // ButtonPS3ShowTemperatures
            // 
            this.ButtonPS3ShowTemperatures.Caption = "Show Temperatures...";
            this.ButtonPS3ShowTemperatures.Id = 113;
            this.ButtonPS3ShowTemperatures.Name = "ButtonPS3ShowTemperatures";
            this.ButtonPS3ShowTemperatures.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3ShowTemperatures_ItemClick);
            // 
            // ButtonPS3NotifyMessage
            // 
            this.ButtonPS3NotifyMessage.Caption = "Notify Message...";
            this.ButtonPS3NotifyMessage.Id = 38;
            this.ButtonPS3NotifyMessage.Name = "ButtonPS3NotifyMessage";
            this.ButtonPS3NotifyMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3NotifyMessage_ItemClick);
            // 
            // ButtonPS3VirtualController
            // 
            this.ButtonPS3VirtualController.Caption = "Virtual Controller...";
            this.ButtonPS3VirtualController.Id = 39;
            this.ButtonPS3VirtualController.Name = "ButtonPS3VirtualController";
            this.ButtonPS3VirtualController.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3VirtualController_ItemClick);
            // 
            // ButtonXboxFileManager
            // 
            this.ButtonXboxFileManager.Caption = "File Manager...";
            this.ButtonXboxFileManager.Id = 65;
            this.ButtonXboxFileManager.Name = "ButtonXboxFileManager";
            this.ButtonXboxFileManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxFileManager_ItemClick);
            // 
            // ButtonXboxPluginsEditor
            // 
            this.ButtonXboxPluginsEditor.Caption = "Plugins Editor...";
            this.ButtonXboxPluginsEditor.Id = 102;
            this.ButtonXboxPluginsEditor.Name = "ButtonXboxPluginsEditor";
            this.ButtonXboxPluginsEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxLaunchFileEditor_ItemClick);
            // 
            // ButtonXboxXBDMMenu
            // 
            this.ButtonXboxXBDMMenu.Caption = "XBDM Controls...";
            this.ButtonXboxXBDMMenu.Id = 66;
            this.ButtonXboxXBDMMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxSystemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxDashboard),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxTakeScreenshot),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxXNotifyMessage)});
            this.ButtonXboxXBDMMenu.Name = "ButtonXboxXBDMMenu";
            // 
            // ButtonXboxPowerFunctions
            // 
            this.ButtonXboxPowerFunctions.Caption = "Power Functions";
            this.ButtonXboxPowerFunctions.Id = 67;
            this.ButtonXboxPowerFunctions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPowerShutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPowerRestart),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPowerSoftReboot),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxPowerHardReboot)});
            this.ButtonXboxPowerFunctions.Name = "ButtonXboxPowerFunctions";
            // 
            // ButtonXboxPowerShutdown
            // 
            this.ButtonXboxPowerShutdown.Caption = "Shutdown...";
            this.ButtonXboxPowerShutdown.Id = 68;
            this.ButtonXboxPowerShutdown.Name = "ButtonXboxPowerShutdown";
            this.ButtonXboxPowerShutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMShutdown_ItemClick);
            // 
            // ButtonXboxPowerRestart
            // 
            this.ButtonXboxPowerRestart.Caption = "Restart...";
            this.ButtonXboxPowerRestart.Id = 69;
            this.ButtonXboxPowerRestart.Name = "ButtonXboxPowerRestart";
            this.ButtonXboxPowerRestart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMRestart_ItemClick);
            // 
            // ButtonXboxPowerSoftReboot
            // 
            this.ButtonXboxPowerSoftReboot.Caption = "Soft Reboot...";
            this.ButtonXboxPowerSoftReboot.Id = 75;
            this.ButtonXboxPowerSoftReboot.Name = "ButtonXboxPowerSoftReboot";
            this.ButtonXboxPowerSoftReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMSoftReboot_ItemClick);
            // 
            // ButtonXboxPowerHardReboot
            // 
            this.ButtonXboxPowerHardReboot.Caption = "Hard Reboot...";
            this.ButtonXboxPowerHardReboot.Id = 76;
            this.ButtonXboxPowerHardReboot.Name = "ButtonXboxPowerHardReboot";
            this.ButtonXboxPowerHardReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMHardReboot_ItemClick);
            // 
            // ButtonXboxSystemInfo
            // 
            this.ButtonXboxSystemInfo.Caption = "System Info";
            this.ButtonXboxSystemInfo.Id = 70;
            this.ButtonXboxSystemInfo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonXboxShowSystemTemperatures)});
            this.ButtonXboxSystemInfo.Name = "ButtonXboxSystemInfo";
            // 
            // ButtonXboxShowSystemTemperatures
            // 
            this.ButtonXboxShowSystemTemperatures.Caption = "Show Temperatures...";
            this.ButtonXboxShowSystemTemperatures.Id = 85;
            this.ButtonXboxShowSystemTemperatures.Name = "ButtonXboxShowSystemTemperatures";
            this.ButtonXboxShowSystemTemperatures.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxShowSystemInfo_ItemClick);
            // 
            // ButtonXboxDashboard
            // 
            this.ButtonXboxDashboard.Caption = "Xbox Dashboard";
            this.ButtonXboxDashboard.Id = 80;
            this.ButtonXboxDashboard.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonXboxShowProfileIDInfo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonXboxQuickSignIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonXboxAvatarEditor, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonXboxDashboardHome, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonXboxOpenCloseTray, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ButtonXboxDashboard.Name = "ButtonXboxDashboard";
            // 
            // ButtonXboxShowProfileIDInfo
            // 
            this.ButtonXboxShowProfileIDInfo.Caption = "Show Profile ID";
            this.ButtonXboxShowProfileIDInfo.Id = 99;
            this.ButtonXboxShowProfileIDInfo.Name = "ButtonXboxShowProfileIDInfo";
            // 
            // ButtonXboxQuickSignIn
            // 
            this.ButtonXboxQuickSignIn.Id = 107;
            this.ButtonXboxQuickSignIn.Name = "ButtonXboxQuickSignIn";
            // 
            // ButtonXboxAvatarEditor
            // 
            this.ButtonXboxAvatarEditor.Caption = "Avatar Editor...";
            this.ButtonXboxAvatarEditor.Id = 81;
            this.ButtonXboxAvatarEditor.ItemInMenuAppearance.Hovered.Options.UseImage = true;
            this.ButtonXboxAvatarEditor.Name = "ButtonXboxAvatarEditor";
            // 
            // ButtonXboxDashboardHome
            // 
            this.ButtonXboxDashboardHome.Caption = "Xbox Home...";
            this.ButtonXboxDashboardHome.Id = 82;
            this.ButtonXboxDashboardHome.Name = "ButtonXboxDashboardHome";
            // 
            // ButtonXboxOpenCloseTray
            // 
            this.ButtonXboxOpenCloseTray.Caption = "Open/Close Tray";
            this.ButtonXboxOpenCloseTray.Id = 91;
            this.ButtonXboxOpenCloseTray.Name = "ButtonXboxOpenCloseTray";
            // 
            // ButtonXboxTakeScreenshot
            // 
            this.ButtonXboxTakeScreenshot.Caption = "Take Screenshot...";
            this.ButtonXboxTakeScreenshot.Id = 108;
            this.ButtonXboxTakeScreenshot.Name = "ButtonXboxTakeScreenshot";
            this.ButtonXboxTakeScreenshot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxTakeScreenshot_ItemClick);
            // 
            // ButtonXboxXNotifyMessage
            // 
            this.ButtonXboxXNotifyMessage.Caption = "XNotify Message...";
            this.ButtonXboxXNotifyMessage.Id = 103;
            this.ButtonXboxXNotifyMessage.Name = "ButtonXboxXNotifyMessage";
            this.ButtonXboxXNotifyMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXNotifyMessage_ItemClick);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSettings, true)});
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
            this.ButtonEditGameRegions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonEditGameRegions_ItemClick);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonDiscordServer),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonOfficialSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenLogFileButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenLogFolderButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckForUpdate, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonWhatsNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSkinChanger, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonAbout, true)});
            this.HelpMenu.Manager = this.MainMenu;
            this.HelpMenu.Name = "HelpMenu";
            // 
            // ButtonDiscordServer
            // 
            this.ButtonDiscordServer.Caption = "Discord Server...";
            this.ButtonDiscordServer.Id = 22;
            this.ButtonDiscordServer.Name = "ButtonDiscordServer";
            this.ButtonDiscordServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonDiscordServer_ItemClick);
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
            // ButtonCheckForUpdate
            // 
            this.ButtonCheckForUpdate.Caption = "Check For Updates...";
            this.ButtonCheckForUpdate.Id = 30;
            this.ButtonCheckForUpdate.Name = "ButtonCheckForUpdate";
            this.ButtonCheckForUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonCheckForUpdate_ItemClick);
            // 
            // ButtonWhatsNew
            // 
            this.ButtonWhatsNew.Caption = "What\'s New...";
            this.ButtonWhatsNew.Id = 29;
            this.ButtonWhatsNew.Name = "ButtonWhatsNew";
            this.ButtonWhatsNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonWhatsNew_ItemClick);
            // 
            // ButtonSkinChanger
            // 
            this.ButtonSkinChanger.Caption = "Skin Changer...";
            this.ButtonSkinChanger.Id = 19;
            this.ButtonSkinChanger.Name = "ButtonSkinChanger";
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Caption = "About...";
            this.ButtonAbout.Id = 28;
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonAbout_ItemClick);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
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
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status";
            this.LabelHeaderStatus.Id = 106;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 2;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1598, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 812);
            this.barDockControlBottom.Manager = this.MainMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1598, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.MainMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 787);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1598, 25);
            this.barDockControlRight.Manager = this.MainMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 787);
            // 
            // LabelHeaderConsoleConnected
            // 
            this.LabelHeaderConsoleConnected.Caption = "Console Connected:";
            this.LabelHeaderConsoleConnected.Id = 53;
            this.LabelHeaderConsoleConnected.Name = "LabelHeaderConsoleConnected";
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
            // ButtonXNotifySend
            // 
            this.ButtonXNotifySend.Caption = "Send XNotify";
            this.ButtonXNotifySend.Id = 98;
            this.ButtonXNotifySend.Name = "ButtonXNotifySend";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "System Info";
            this.barButtonItem1.Id = 109;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // XNotifyText
            // 
            this.XNotifyText.AutoHeight = false;
            this.XNotifyText.Name = "XNotifyText";
            // 
            // XNotifyType
            // 
            this.XNotifyType.AccessibleDescription = "";
            this.XNotifyType.AutoHeight = false;
            this.XNotifyType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "mnjukjui", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(852, 15);
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
            this.labelControl1.Location = new System.Drawing.Point(10, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(852, 15);
            this.labelControl1.TabIndex = 1167;
            this.labelControl1.Text = "FILTER MODS";
            // 
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRegion.Location = new System.Drawing.Point(758, 39);
            this.ComboBoxRegion.MenuManager = this.MainMenu;
            this.ComboBoxRegion.Name = "ComboBoxRegion";
            this.ComboBoxRegion.Properties.AllowFocused = false;
            this.ComboBoxRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxRegion.Size = new System.Drawing.Size(104, 22);
            this.ComboBoxRegion.TabIndex = 4;
            this.ComboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRegion_SelectedIndexChanged);
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.Location = new System.Drawing.Point(600, 39);
            this.ComboBoxModType.MenuManager = this.MainMenu;
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Properties.AllowFocused = false;
            this.ComboBoxModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxModType.Size = new System.Drawing.Size(96, 22);
            this.ComboBoxModType.TabIndex = 3;
            this.ComboBoxModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModType_SelectedIndexChanged);
            // 
            // ComboBoxSystemType
            // 
            this.ComboBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSystemType.Location = new System.Drawing.Point(463, 39);
            this.ComboBoxSystemType.MenuManager = this.MainMenu;
            this.ComboBoxSystemType.Name = "ComboBoxSystemType";
            this.ComboBoxSystemType.Properties.AllowFocused = false;
            this.ComboBoxSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxSystemType.Size = new System.Drawing.Size(60, 22);
            this.ComboBoxSystemType.TabIndex = 2;
            this.ComboBoxSystemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSystemType_SelectedIndexChanged);
            // 
            // LabelSelectRegion
            // 
            this.LabelSelectRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectRegion.Appearance.Options.UseFont = true;
            this.LabelSelectRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectRegion.Location = new System.Drawing.Point(704, 42);
            this.LabelSelectRegion.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectRegion.Name = "LabelSelectRegion";
            this.LabelSelectRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelSelectRegion.Size = new System.Drawing.Size(48, 15);
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
            this.LabelSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelSearch.Size = new System.Drawing.Size(50, 15);
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
            // GridControlInstalledGameMods
            // 
            this.GridControlInstalledGameMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlInstalledGameMods.Location = new System.Drawing.Point(2, 23);
            this.GridControlInstalledGameMods.MainView = this.GridViewInstalledGameMods;
            this.GridControlInstalledGameMods.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlInstalledGameMods.Name = "GridControlInstalledGameMods";
            this.GridControlInstalledGameMods.Size = new System.Drawing.Size(873, 136);
            this.GridControlInstalledGameMods.TabIndex = 7;
            this.GridControlInstalledGameMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewInstalledGameMods});
            // 
            // GridViewInstalledGameMods
            // 
            this.GridViewInstalledGameMods.ActiveFilterEnabled = false;
            this.GridViewInstalledGameMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewInstalledGameMods.GridControl = this.GridControlInstalledGameMods;
            this.GridViewInstalledGameMods.Name = "GridViewInstalledGameMods";
            this.GridViewInstalledGameMods.OptionsBehavior.Editable = false;
            this.GridViewInstalledGameMods.OptionsBehavior.ReadOnly = true;
            this.GridViewInstalledGameMods.OptionsCustomization.AllowFilter = false;
            this.GridViewInstalledGameMods.OptionsFilter.AllowFilterEditor = false;
            this.GridViewInstalledGameMods.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewInstalledGameMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewInstalledGameMods.OptionsView.ShowGroupPanel = false;
            this.GridViewInstalledGameMods.OptionsView.ShowIndicator = false;
            this.GridViewInstalledGameMods.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewInstalledGameMods_RowClick);
            this.GridViewInstalledGameMods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewInstalledGameMods_FocusedRowChanged);
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
            this.GroupModsLibrary.Size = new System.Drawing.Size(877, 548);
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
            this.ProgressMods.Description = "";
            this.ProgressMods.Location = new System.Drawing.Point(330, 187);
            this.ProgressMods.Name = "ProgressMods";
            this.ProgressMods.Size = new System.Drawing.Size(246, 66);
            this.ProgressMods.TabIndex = 1170;
            this.ProgressMods.Visible = false;
            this.ProgressMods.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridControlMods
            // 
            this.GridControlMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlMods.Location = new System.Drawing.Point(2, 121);
            this.GridControlMods.MainView = this.GridViewMods;
            this.GridControlMods.MenuManager = this.MainMenu;
            this.GridControlMods.Name = "GridControlMods";
            this.GridControlMods.Size = new System.Drawing.Size(873, 425);
            this.GridControlMods.TabIndex = 5;
            this.GridControlMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMods});
            // 
            // GridViewMods
            // 
            this.GridViewMods.ActiveFilterEnabled = false;
            this.GridViewMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewMods.GridControl = this.GridControlMods;
            this.GridViewMods.Name = "GridViewMods";
            this.GridViewMods.OptionsBehavior.Editable = false;
            this.GridViewMods.OptionsBehavior.ReadOnly = true;
            this.GridViewMods.OptionsCustomization.AllowFilter = false;
            this.GridViewMods.OptionsFilter.AllowFilterEditor = false;
            this.GridViewMods.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewMods.OptionsView.ShowGroupPanel = false;
            this.GridViewMods.OptionsView.ShowIndicator = false;
            this.GridViewMods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewMods_FocusedRowChanged);
            // 
            // NavBarCategories
            // 
            this.NavBarCategories.ActiveGroup = this.NavGroupGames;
            this.NavBarCategories.Appearance.GroupHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NavBarCategories.Appearance.GroupHeader.Options.UseFont = true;
            this.NavBarCategories.Appearance.ItemActive.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NavBarCategories.Appearance.ItemActive.Options.UseFont = true;
            this.NavBarCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavBarCategories.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.NavGroupGames,
            this.NavGroupHomebrewApps,
            this.NavGroupResources,
            this.NavGroupMyLists});
            this.NavBarCategories.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.NavBarCategories.Location = new System.Drawing.Point(2, 23);
            this.NavBarCategories.Name = "NavBarCategories";
            this.NavBarCategories.OptionsNavPane.ExpandedWidth = 296;
            this.NavBarCategories.Size = new System.Drawing.Size(296, 734);
            this.NavBarCategories.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.NavBarCategories.TabIndex = 0;
            this.NavBarCategories.Text = "navBarControl1";
            this.NavBarCategories.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            this.NavBarCategories.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavigationBar_LinkClicked);
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
            this.GroupCategories.Controls.Add(this.NavBarCategories);
            this.GroupCategories.Location = new System.Drawing.Point(12, 39);
            this.GroupCategories.Margin = new System.Windows.Forms.Padding(4, 3, 5, 3);
            this.GroupCategories.Name = "GroupCategories";
            this.GroupCategories.Size = new System.Drawing.Size(300, 759);
            this.GroupCategories.TabIndex = 1185;
            this.GroupCategories.Text = "CATEGORIES";
            // 
            // GroupModsInstalled
            // 
            this.GroupModsInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModsInstalled.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GroupModsInstalled.AppearanceCaption.Options.UseFont = true;
            this.GroupModsInstalled.Controls.Add(this.ProgressInstalledMods);
            this.GroupModsInstalled.Controls.Add(this.GridControlInstalledGameMods);
            this.GroupModsInstalled.Controls.Add(this.PanelInstalledModsPlugins);
            this.GroupModsInstalled.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.GroupModsInstalled.Location = new System.Drawing.Point(322, 597);
            this.GroupModsInstalled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 3);
            this.GroupModsInstalled.Name = "GroupModsInstalled";
            this.GroupModsInstalled.Size = new System.Drawing.Size(877, 201);
            this.GroupModsInstalled.TabIndex = 1179;
            this.GroupModsInstalled.Text = "INSTALLED MODS && PLUGINS";
            // 
            // ProgressInstalledMods
            // 
            this.ProgressInstalledMods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressInstalledMods.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressInstalledMods.Appearance.Options.UseBackColor = true;
            this.ProgressInstalledMods.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressInstalledMods.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressInstalledMods.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressInstalledMods.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressInstalledMods.Caption = "NO MODS INSTALLED";
            this.ProgressInstalledMods.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressInstalledMods.Description = "";
            this.ProgressInstalledMods.Location = new System.Drawing.Point(330, 70);
            this.ProgressInstalledMods.Name = "ProgressInstalledMods";
            this.ProgressInstalledMods.Size = new System.Drawing.Size(246, 66);
            this.ProgressInstalledMods.TabIndex = 1171;
            this.ProgressInstalledMods.Text = "progressPanel1";
            this.ProgressInstalledMods.Visible = false;
            this.ProgressInstalledMods.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // PanelInstalledModsPlugins
            // 
            this.PanelInstalledModsPlugins.Controls.Add(this.ButtonUninstallInstalledMods);
            this.PanelInstalledModsPlugins.Controls.Add(this.ButtonUninstallAllMods);
            this.PanelInstalledModsPlugins.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInstalledModsPlugins.Location = new System.Drawing.Point(2, 159);
            this.PanelInstalledModsPlugins.Name = "PanelInstalledModsPlugins";
            this.PanelInstalledModsPlugins.Size = new System.Drawing.Size(873, 40);
            this.PanelInstalledModsPlugins.TabIndex = 1175;
            // 
            // ButtonUninstallInstalledMods
            // 
            this.ButtonUninstallInstalledMods.Enabled = false;
            this.ButtonUninstallInstalledMods.Location = new System.Drawing.Point(8, 8);
            this.ButtonUninstallInstalledMods.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonUninstallInstalledMods.Name = "ButtonUninstallInstalledMods";
            this.ButtonUninstallInstalledMods.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonUninstallInstalledMods.Size = new System.Drawing.Size(77, 24);
            this.ButtonUninstallInstalledMods.TabIndex = 14;
            this.ButtonUninstallInstalledMods.Text = "Uninstall";
            // 
            // ButtonUninstallAllMods
            // 
            this.ButtonUninstallAllMods.Enabled = false;
            this.ButtonUninstallAllMods.Location = new System.Drawing.Point(91, 8);
            this.ButtonUninstallAllMods.Name = "ButtonUninstallAllMods";
            this.ButtonUninstallAllMods.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonUninstallAllMods.Size = new System.Drawing.Size(93, 24);
            this.ButtonUninstallAllMods.TabIndex = 13;
            this.ButtonUninstallAllMods.Text = "Uninstall All";
            this.ButtonUninstallAllMods.Click += new System.EventHandler(this.ButtonUninstallAllMods_Click);
            // 
            // GroupModInformation
            // 
            this.GroupModInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModInformation.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GroupModInformation.AppearanceCaption.Options.UseFont = true;
            this.GroupModInformation.Controls.Add(this.ScrollBarModInformation);
            this.GroupModInformation.Controls.Add(this.FlowPanelDetails);
            this.GroupModInformation.Controls.Add(this.GroupInstallFiles);
            this.GroupModInformation.Location = new System.Drawing.Point(1209, 39);
            this.GroupModInformation.Margin = new System.Windows.Forms.Padding(5, 3, 4, 3);
            this.GroupModInformation.Name = "GroupModInformation";
            this.GroupModInformation.Size = new System.Drawing.Size(377, 759);
            this.GroupModInformation.TabIndex = 1160;
            this.GroupModInformation.Text = "MOD INFORMATION";
            // 
            // ScrollBarModInformation
            // 
            this.ScrollBarModInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScrollBarModInformation.Location = new System.Drawing.Point(358, 21);
            this.ScrollBarModInformation.Name = "ScrollBarModInformation";
            this.ScrollBarModInformation.Size = new System.Drawing.Size(17, 575);
            this.ScrollBarModInformation.TabIndex = 3;
            this.ScrollBarModInformation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarModInformation_Scroll);
            // 
            // GroupInstallFiles
            // 
            this.GroupInstallFiles.Controls.Add(this.GridControlModsInstallFiles);
            this.GroupInstallFiles.Controls.Add(this.PanelButtonsModInformation);
            this.GroupInstallFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupInstallFiles.Location = new System.Drawing.Point(2, 593);
            this.GroupInstallFiles.Name = "GroupInstallFiles";
            this.GroupInstallFiles.Size = new System.Drawing.Size(373, 164);
            this.GroupInstallFiles.TabIndex = 1;
            this.GroupInstallFiles.Text = "INSTALL FILES";
            // 
            // PanelButtonsModInformation
            // 
            this.PanelButtonsModInformation.Controls.Add(this.ButtonModInstall);
            this.PanelButtonsModInformation.Controls.Add(this.ButtonModUninstall);
            this.PanelButtonsModInformation.Controls.Add(this.ButtonModDownload);
            this.PanelButtonsModInformation.Controls.Add(this.ButtonModFavorite);
            this.PanelButtonsModInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtonsModInformation.Location = new System.Drawing.Point(2, 122);
            this.PanelButtonsModInformation.Name = "PanelButtonsModInformation";
            this.PanelButtonsModInformation.Size = new System.Drawing.Size(369, 40);
            this.PanelButtonsModInformation.TabIndex = 1174;
            // 
            // ButtonModInstall
            // 
            this.ButtonModInstall.Enabled = false;
            this.ButtonModInstall.Location = new System.Drawing.Point(8, 8);
            this.ButtonModInstall.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonModInstall.Name = "ButtonModInstall";
            this.ButtonModInstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonModInstall.Size = new System.Drawing.Size(60, 24);
            this.ButtonModInstall.TabIndex = 13;
            this.ButtonModInstall.Text = "Install";
            this.ButtonModInstall.Click += new System.EventHandler(this.ButtonModInstall_Click);
            // 
            // ButtonModUninstall
            // 
            this.ButtonModUninstall.Enabled = false;
            this.ButtonModUninstall.Location = new System.Drawing.Point(74, 8);
            this.ButtonModUninstall.Name = "ButtonModUninstall";
            this.ButtonModUninstall.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonModUninstall.Size = new System.Drawing.Size(75, 24);
            this.ButtonModUninstall.TabIndex = 14;
            this.ButtonModUninstall.Text = "Uninstall";
            this.ButtonModUninstall.Click += new System.EventHandler(this.ButtonModUninstall_Click);
            // 
            // ButtonModDownload
            // 
            this.ButtonModDownload.Location = new System.Drawing.Point(155, 8);
            this.ButtonModDownload.Name = "ButtonModDownload";
            this.ButtonModDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonModDownload.Size = new System.Drawing.Size(82, 24);
            this.ButtonModDownload.TabIndex = 15;
            this.ButtonModDownload.Text = "Download";
            this.ButtonModDownload.Click += new System.EventHandler(this.ButtonModDownload_Click);
            // 
            // ButtonModFavorite
            // 
            this.ButtonModFavorite.Location = new System.Drawing.Point(243, 8);
            this.ButtonModFavorite.Name = "ButtonModFavorite";
            this.ButtonModFavorite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonModFavorite.Size = new System.Drawing.Size(73, 24);
            this.ButtonModFavorite.TabIndex = 16;
            this.ButtonModFavorite.Text = "Favorite";
            this.ButtonModFavorite.TextChanged += new System.EventHandler(this.ButtonModFavorite_TextChanged);
            this.ButtonModFavorite.Click += new System.EventHandler(this.ButtonModFavorite_Click);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelModsInstalled)});
            this.BarModsInstalled.OptionsBar.DrawBorder = false;
            this.BarModsInstalled.OptionsBar.DrawDragBorder = false;
            this.BarModsInstalled.OptionsBar.MultiLine = true;
            this.BarModsInstalled.OptionsBar.UseWholeRow = true;
            this.BarModsInstalled.Text = "Main menu";
            // 
            // LabelModsInstalled
            // 
            this.LabelModsInstalled.Caption = "0 Mods Installed";
            this.LabelModsInstalled.Id = 1;
            this.LabelModsInstalled.LeftIndent = 6;
            this.LabelModsInstalled.Name = "LabelModsInstalled";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.BarManagerModsInstalled;
            this.barDockControl5.Size = new System.Drawing.Size(1598, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 837);
            this.barDockControl6.Manager = this.BarManagerModsInstalled;
            this.barDockControl6.Size = new System.Drawing.Size(1598, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.BarManagerModsInstalled;
            this.barDockControl7.Size = new System.Drawing.Size(0, 837);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1598, 0);
            this.barDockControl8.Manager = this.BarManagerModsInstalled;
            this.barDockControl8.Size = new System.Drawing.Size(0, 837);
            // 
            // HeaderLabelModsInstalled
            // 
            this.HeaderLabelModsInstalled.Caption = "Mods Installed:";
            this.HeaderLabelModsInstalled.Id = 0;
            this.HeaderLabelModsInstalled.Name = "HeaderLabelModsInstalled";
            // 
            // ButtonModsUninstallAll
            // 
            this.ButtonModsUninstallAll.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ButtonModsUninstallAll.Caption = "Uninstall All";
            this.ButtonModsUninstallAll.Id = 2;
            this.ButtonModsUninstallAll.Name = "ButtonModsUninstallAll";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Connected Console:";
            this.barStaticItem1.Id = 85;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.LeftIndent = 4;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem2.Caption = "Connected Console:";
            this.barStaticItem2.Id = 85;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.LeftIndent = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // MainWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1598, 837);
            this.Controls.Add(this.GroupModInformation);
            this.Controls.Add(this.GroupModsInstalled);
            this.Controls.Add(this.GroupCategories);
            this.Controls.Add(this.GroupModsLibrary);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1586, 853);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v1.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.StyleChanged += new System.EventHandler(this.MainWindow_StyleChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInstalledGameMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInstalledGameMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsLibrary)).EndInit();
            this.GroupModsLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBarCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCategories)).EndInit();
            this.GroupCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsInstalled)).EndInit();
            this.GroupModsInstalled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelInstalledModsPlugins)).EndInit();
            this.PanelInstalledModsPlugins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupModInformation)).EndInit();
            this.GroupModInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallFiles)).EndInit();
            this.GroupInstallFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsModInformation)).EndInit();
            this.PanelButtonsModInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModsMenu)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl LabelHeaderName;
        private System.Windows.Forms.Panel PanelModsLibraryFilters;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraGrid.GridControl GridControlInstalledGameMods;
        private DevExpress.XtraEditors.LabelControl LabelHeaderRegion;
        private DevExpress.XtraEditors.LabelControl LabelRegion;
        private DevExpress.XtraEditors.LabelControl LabelSelectRegion;
        private DevExpress.XtraGrid.GridControl GridControlModsInstallFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstallationFiles;
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
        private ComboBoxEdit ComboBoxSystemType;
        private BarButtonItem ButtonGameBackupFiles;
        private BarButtonItem ButtonPS3GameUpdateFinder;
        private BarButtonItem ButtonPS3FileManager;
        private BarButtonItem ButtonPS3PackageManager;
        private BarSubItem barSubItem1;
        private BarButtonItem ButtonAddNewConsole;
        private BarButtonItem ButtonEditGameRegions;
        private BarButtonItem ButtonEditApplications;
        private BarButtonItem ButtonEditLists;
        private BarButtonItem ButtonSettings;
        private SkinBarSubItem ButtonSkinChanger;
        private BarButtonItem ButtonDiscordServer;
        private BarButtonItem ButtonOfficialSource;
        private BarButtonItem OpenLogFileButton;
        private BarButtonItem OpenLogFolderButton;
        private BarButtonItem ButtonCheckForUpdate;
        private BarButtonItem ButtonWhatsNew;
        private BarButtonItem ButtonAbout;
        private BarSubItem ButtonPS3;
        private BarButtonItem ButtonConnectToPS3;
        private BarSubItem ButtonXbox360;
        private BarSubItem ButtonPS3WebManControls;
        private BarSubItem ButtonPS3PowerFunctions;
        private BarButtonItem ButtonPS3Shutdown;
        private BarButtonItem ButtonPS3Restart;
        private BarButtonItem ButtonPS3SoftReboot;
        private BarButtonItem ButtonPS3NotifyMessage;
        private BarButtonItem ButtonPS3VirtualController;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewModsInstallFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewInstalledGameMods;
        private ComboBoxEdit ComboBoxRegion;
        private ComboBoxEdit ComboBoxModType;
        private BarHeaderItem LabelHeaderConsoleConnected;
        private BarStaticItem LabelConsoleConnected;
        private DevExpress.XtraNavBar.NavBarControl NavBarCategories;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupGames;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupHomebrewApps;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupResources;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupMyLists;
        private GroupControl GroupModsLibrary;
        private GroupControl GroupModsInstalled;
        private GroupControl GroupCategories;
        private GroupControl GroupModInformation;
        private GroupControl GroupInstallFiles;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit TextBoxSearch;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressMods;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressInstalledMods;
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
        private BarStaticItem LabelStatus;
        private VScrollBar ScrollBarModInformation;
        private BarButtonItem ButtonXboxFileManager;
        private BarSubItem ButtonXboxXBDMMenu;
        private BarSubItem ButtonXboxPowerFunctions;
        private BarButtonItem ButtonXboxPowerShutdown;
        private BarButtonItem ButtonXboxPowerRestart;
        private BarButtonItem ButtonXboxPowerSoftReboot;
        private BarButtonItem ButtonXboxPowerHardReboot;
        private BarSubItem ButtonXboxSystemInfo;
        private BarSubItem ButtonXboxDashboard;
        private BarButtonItem ButtonXboxAvatarEditor;
        private BarButtonItem ButtonXboxDashboardHome;
        private BarButtonItem ButtonXboxQuickSignIn;
        private BarButtonItem ButtonXboxShowSystemTemperatures;
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
        private BarStaticItem LabelModsStats;
        private BarButtonItem ButtonXboxOpenCloseTray;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox XNotifyType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit XNotifyText;
        private BarButtonItem ButtonXNotifySend;
        private BarButtonItem ButtonXboxShowProfileIDInfo;
        private DevExpress.Utils.Layout.StackPanel PanelButtonsModInformation;
        private SimpleButton ButtonModInstall;
        private SimpleButton ButtonModUninstall;
        private SimpleButton ButtonModDownload;
        private SimpleButton ButtonModFavorite;
        private DevExpress.Utils.Layout.StackPanel PanelInstalledModsPlugins;
        private SimpleButton ButtonUninstallAllMods;
        private BarButtonItem ButtonXboxPluginsEditor;
        private SimpleButton ButtonUninstallInstalledMods;
        private BarButtonItem ButtonXboxXNotifyMessage;
        private BarButtonItem ButtonPS3HardReboot;
        private BarStaticItem LabelHeaderStatus;
        private BarStaticItem barStaticItem1;
        private BarStaticItem barStaticItem2;
        private BarButtonItem ButtonXboxTakeScreenshot;
        private BarSubItem ButtonPS3SystemInfo;
        private BarButtonItem barButtonItem1;
        private BarButtonItem ButtonPS3ShowMinimumVersion;
        private BarButtonItem ButtonPS3ShowSystemInformation;
        private BarButtonItem ButtonPS3ShowTemperatures;
    }
}