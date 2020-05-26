namespace ModioX.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContextMenuMods = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuModsInstallToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsUninstallFromConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsDownloadArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsExtractInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsReportOnGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSelectType = new System.Windows.Forms.Label();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleModDetails = new DarkUI.Controls.DarkTitle();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.LabelHeaderNameNo = new System.Windows.Forms.Label();
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
            this.darkTitle7 = new DarkUI.Controls.DarkTitle();
            this.DgvInstallPaths = new DarkUI.Controls.DarkDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuConsoleFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuConsoleDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ScrollBarDetails = new DarkUI.Controls.DarkScrollBar();
            this.SectionArchiveInformation = new DarkUI.Controls.DarkSectionPanel();
            this.PanelModsInstallationPaths = new System.Windows.Forms.Panel();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemInstallMod = new System.Windows.Forms.ToolStripButton();
            this.ToolItemUninstallMod = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDownloadMod = new System.Windows.Forms.ToolStripButton();
            this.ToolItemFavoriteMod = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripConnectPS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripConnectPS3Console = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripConnectOfflineMode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripToolsCustomMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsBackupFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemToolsFileExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemResources = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCustomFirmware = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesCustomFirmwareRebug = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemModdingForums = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPsxPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPSXPlacePs3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPSXPlaceGameMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPSXScene = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPSXScenePS3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPSXSceneGameMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNGU = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNGUPS3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSe7enSins = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSe7enSinsPS3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSe7enSinsGameMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTTG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTTGPS3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTTGGameMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHomebrew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBrewologyStore = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGames = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesGamesPsnDLv3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesGamesNoPsv2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReddit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRedditPS3Hacks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRedditPS3Homebrew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplicationsCCAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplicationsFileZilla = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsShowModID = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAutoDetectGameRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsRememberGameRegions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAlwaysDownloadInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSettingsEditConsoleProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsEditGameRegions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemMoreInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRequestMod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStatusStrip = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripStatusSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.ContextMenuLocalFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuStripLocalUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripLocalDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSelectSystemType = new System.Windows.Forms.Label();
            this.SectionModsLibrary = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoModsFound = new System.Windows.Forms.Label();
            this.DgvMods = new DarkUI.Controls.DarkDataGridView();
            this.ColumnModsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsFirmware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsNoFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelModsLibraryFilters = new System.Windows.Forms.Panel();
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
            this.LabelTitleResources = new DarkUI.Controls.DarkTitle();
            this.PanelResources = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleMyLists = new DarkUI.Controls.DarkTitle();
            this.PanelLists = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionInstalledGameMods = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoModsInstalled = new System.Windows.Forms.Label();
            this.DgvModsInstalled = new DarkUI.Controls.DarkDataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelModsInstalledHeader = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.darkTitle12 = new DarkUI.Controls.DarkTitle();
            this.MenuGameModsStrip = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemUninstallAllGameMods = new System.Windows.Forms.ToolStripButton();
            this.LabelInstalledGameModsStatus = new System.Windows.Forms.ToolStripLabel();
            this.MenuItemSeperator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuMods.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.SectionModsInstallFilePaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).BeginInit();
            this.ContextMenuConsoleFile.SuspendLayout();
            this.SectionArchiveInformation.SuspendLayout();
            this.PanelModsInstallationPaths.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.MenuStatusStrip.SuspendLayout();
            this.ContextMenuLocalFile.SuspendLayout();
            this.SectionModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).BeginInit();
            this.PanelModsLibraryFilters.SuspendLayout();
            this.SectionGames.SuspendLayout();
            this.FlowPanelCategories.SuspendLayout();
            this.SectionInstalledGameMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModsInstalled)).BeginInit();
            this.PanelModsInstalledHeader.SuspendLayout();
            this.MenuGameModsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuMods
            // 
            this.ContextMenuMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuMods.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuMods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuModsInstallToConsole,
            this.ContextMenuModsUninstallFromConsole,
            this.ContextMenuModsDownloadArchive,
            this.ContextMenuModsSeperator1,
            this.ContextMenuModsExtractInformation,
            this.ContextMenuModsSeperator0,
            this.ContextMenuModsReportOnGitHub});
            this.ContextMenuMods.Name = "ContextMenuConsole";
            this.ContextMenuMods.Size = new System.Drawing.Size(200, 128);
            // 
            // ContextMenuModsInstallToConsole
            // 
            this.ContextMenuModsInstallToConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsInstallToConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsInstallToConsole.Name = "ContextMenuModsInstallToConsole";
            this.ContextMenuModsInstallToConsole.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsInstallToConsole.Text = "Install to Console";
            this.ContextMenuModsInstallToConsole.Click += new System.EventHandler(this.ContextMenuModsInstallToConsole_Click);
            // 
            // ContextMenuModsUninstallFromConsole
            // 
            this.ContextMenuModsUninstallFromConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsUninstallFromConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsUninstallFromConsole.Name = "ContextMenuModsUninstallFromConsole";
            this.ContextMenuModsUninstallFromConsole.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsUninstallFromConsole.Text = "Uninstall from Console";
            this.ContextMenuModsUninstallFromConsole.Click += new System.EventHandler(this.ContextMenuModsUninstallFromConsole_Click);
            // 
            // ContextMenuModsDownloadArchive
            // 
            this.ContextMenuModsDownloadArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsDownloadArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsDownloadArchive.Name = "ContextMenuModsDownloadArchive";
            this.ContextMenuModsDownloadArchive.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsDownloadArchive.Text = "Download Archive to...";
            this.ContextMenuModsDownloadArchive.Click += new System.EventHandler(this.ContextMenuModsDownloadArchive_Click);
            // 
            // ContextMenuModsSeperator1
            // 
            this.ContextMenuModsSeperator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsSeperator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsSeperator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuModsSeperator1.Name = "ContextMenuModsSeperator1";
            this.ContextMenuModsSeperator1.Size = new System.Drawing.Size(196, 6);
            // 
            // ContextMenuModsExtractInformation
            // 
            this.ContextMenuModsExtractInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsExtractInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsExtractInformation.Name = "ContextMenuModsExtractInformation";
            this.ContextMenuModsExtractInformation.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsExtractInformation.Text = "Extract Information to...";
            this.ContextMenuModsExtractInformation.Click += new System.EventHandler(this.ContextMenuModsExtractInformation_Click);
            // 
            // ContextMenuModsSeperator0
            // 
            this.ContextMenuModsSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuModsSeperator0.Name = "ContextMenuModsSeperator0";
            this.ContextMenuModsSeperator0.Size = new System.Drawing.Size(196, 6);
            // 
            // ContextMenuModsReportOnGitHub
            // 
            this.ContextMenuModsReportOnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsReportOnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsReportOnGitHub.Name = "ContextMenuModsReportOnGitHub";
            this.ContextMenuModsReportOnGitHub.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsReportOnGitHub.Text = "Report on GitHub";
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
            this.LabelSelectType.Location = new System.Drawing.Point(468, 42);
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
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderNameNo);
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
            this.FlowPanelDetails.Size = new System.Drawing.Size(375, 489);
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
            this.LabelTitleModDetails.Text = "MOD DETAILS";
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
            // LabelHeaderNameNo
            // 
            this.LabelHeaderNameNo.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderNameNo, true);
            this.LabelHeaderNameNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelHeaderNameNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderNameNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderNameNo.Location = new System.Drawing.Point(50, 33);
            this.LabelHeaderNameNo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderNameNo.Name = "LabelHeaderNameNo";
            this.LabelHeaderNameNo.Size = new System.Drawing.Size(16, 15);
            this.LabelHeaderNameNo.TabIndex = 2;
            this.LabelHeaderNameNo.Text = "...";
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
            this.SectionModsInstallFilePaths.Controls.Add(this.darkTitle7);
            this.SectionModsInstallFilePaths.Controls.Add(this.DgvInstallPaths);
            this.SectionModsInstallFilePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionModsInstallFilePaths.Location = new System.Drawing.Point(0, 11);
            this.SectionModsInstallFilePaths.Margin = new System.Windows.Forms.Padding(0);
            this.SectionModsInstallFilePaths.Name = "SectionModsInstallFilePaths";
            this.SectionModsInstallFilePaths.SectionHeader = " ";
            this.SectionModsInstallFilePaths.Size = new System.Drawing.Size(375, 125);
            this.SectionModsInstallFilePaths.TabIndex = 26;
            // 
            // darkTitle7
            // 
            this.darkTitle7.BackColor = System.Drawing.Color.Transparent;
            this.darkTitle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.darkTitle7.Location = new System.Drawing.Point(6, 5);
            this.darkTitle7.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.darkTitle7.Name = "darkTitle7";
            this.darkTitle7.Size = new System.Drawing.Size(362, 16);
            this.darkTitle7.TabIndex = 1163;
            this.darkTitle7.Text = "INSTALLATION FILES";
            // 
            // DgvInstallPaths
            // 
            this.DgvInstallPaths.AllowUserToAddRows = false;
            this.DgvInstallPaths.AllowUserToDeleteRows = false;
            this.DgvInstallPaths.AllowUserToDragDropRows = false;
            this.DgvInstallPaths.AllowUserToPasteCells = false;
            this.DgvInstallPaths.AllowUserToResizeColumns = false;
            this.DgvInstallPaths.ColumnHeadersHeight = 23;
            this.DgvInstallPaths.ColumnHeadersVisible = false;
            this.DgvInstallPaths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DgvInstallPaths.ContextMenuStrip = this.ContextMenuConsoleFile;
            this.DgvInstallPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvInstallPaths.Location = new System.Drawing.Point(1, 25);
            this.DgvInstallPaths.Margin = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.DgvInstallPaths.MultiSelect = false;
            this.DgvInstallPaths.Name = "DgvInstallPaths";
            this.DgvInstallPaths.ReadOnly = true;
            this.DgvInstallPaths.RowHeadersWidth = 41;
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInstallPaths.RowTemplate.Height = 24;
            this.DgvInstallPaths.RowTemplate.ReadOnly = true;
            this.DgvInstallPaths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvInstallPaths.Size = new System.Drawing.Size(373, 99);
            this.DgvInstallPaths.TabIndex = 3;
            this.DgvInstallPaths.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvInstallPaths.SelectionChanged += new System.EventHandler(this.Dgv_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Install File Path";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // 
            // ContextMenuConsoleDeleteFile
            // 
            this.ContextMenuConsoleDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleDeleteFile.Name = "ContextMenuConsoleDeleteFile";
            this.ContextMenuConsoleDeleteFile.Size = new System.Drawing.Size(149, 22);
            this.ContextMenuConsoleDeleteFile.Text = "Delete File";
            // 
            // ContextMenuConsoleRefresh
            // 
            this.ContextMenuConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuConsoleRefresh.Name = "ContextMenuConsoleRefresh";
            this.ContextMenuConsoleRefresh.Size = new System.Drawing.Size(149, 22);
            this.ContextMenuConsoleRefresh.Text = "Refresh";
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(359, 25);
            this.ScrollBarDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(17, 500);
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
            this.SectionArchiveInformation.Location = new System.Drawing.Point(1096, 39);
            this.SectionArchiveInformation.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.SectionArchiveInformation.Name = "SectionArchiveInformation";
            this.SectionArchiveInformation.SectionHeader = "MOD INFORMATION";
            this.SectionArchiveInformation.Size = new System.Drawing.Size(377, 687);
            this.SectionArchiveInformation.TabIndex = 9;
            // 
            // PanelModsInstallationPaths
            // 
            this.PanelModsInstallationPaths.Controls.Add(this.SectionModsInstallFilePaths);
            this.PanelModsInstallationPaths.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelModsInstallationPaths.Location = new System.Drawing.Point(1, 514);
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
            this.ToolItemInstallMod,
            this.ToolItemUninstallMod,
            this.ToolItemDownloadMod,
            this.ToolItemFavoriteMod});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 650);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(375, 36);
            this.ToolStripArchiveInformation.TabIndex = 4;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolItemInstallMod
            // 
            this.ToolItemInstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemInstallMod.Enabled = false;
            this.ToolItemInstallMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemInstallMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemInstallMod.Image = global::ModioX.Properties.Resources.icons8_software_installer_22;
            this.ToolItemInstallMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemInstallMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemInstallMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemInstallMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemInstallMod.Name = "ToolItemInstallMod";
            this.ToolItemInstallMod.Size = new System.Drawing.Size(66, 26);
            this.ToolItemInstallMod.Text = "Install";
            this.ToolItemInstallMod.ToolTipText = "Install Mod to Console";
            this.ToolItemInstallMod.Click += new System.EventHandler(this.ToolStripInstallFiles_Click);
            // 
            // ToolItemUninstallMod
            // 
            this.ToolItemUninstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemUninstallMod.Enabled = false;
            this.ToolItemUninstallMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemUninstallMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemUninstallMod.Image = global::ModioX.Properties.Resources.icons8_uninstall_programs_22;
            this.ToolItemUninstallMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstallMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstallMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstallMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstallMod.Name = "ToolItemUninstallMod";
            this.ToolItemUninstallMod.Size = new System.Drawing.Size(81, 26);
            this.ToolItemUninstallMod.Text = "Uninstall";
            this.ToolItemUninstallMod.ToolTipText = "Uninstall Mod from Console";
            this.ToolItemUninstallMod.Click += new System.EventHandler(this.ToolStripUninstallFiles_Click);
            // 
            // ToolItemDownloadMod
            // 
            this.ToolItemDownloadMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDownloadMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDownloadMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDownloadMod.Image = global::ModioX.Properties.Resources.icons8_download_from_the_cloud_22;
            this.ToolItemDownloadMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemDownloadMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDownloadMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDownloadMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDownloadMod.Name = "ToolItemDownloadMod";
            this.ToolItemDownloadMod.Size = new System.Drawing.Size(89, 26);
            this.ToolItemDownloadMod.Text = "Download";
            this.ToolItemDownloadMod.ToolTipText = "Download Archive to Computer";
            this.ToolItemDownloadMod.Click += new System.EventHandler(this.ToolStripDownloadArchive_Click);
            // 
            // ToolItemFavoriteMod
            // 
            this.ToolItemFavoriteMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemFavoriteMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemFavoriteMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemFavoriteMod.Image = global::ModioX.Properties.Resources.icons8_heart_outline_22;
            this.ToolItemFavoriteMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemFavoriteMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemFavoriteMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemFavoriteMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemFavoriteMod.Name = "ToolItemFavoriteMod";
            this.ToolItemFavoriteMod.Size = new System.Drawing.Size(79, 26);
            this.ToolItemFavoriteMod.Text = "Favorite";
            this.ToolItemFavoriteMod.ToolTipText = "Add/Remove from Favorites";
            this.ToolItemFavoriteMod.Click += new System.EventHandler(this.ToolStripFavorite_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuItemTools,
            this.MenuItemResources,
            this.MenuItemApplications,
            this.MenuItemSettings,
            this.MenuItemHelp,
            this.MenuStripRefreshData,
            this.MenuStripRequestMod});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.MenuStrip.Size = new System.Drawing.Size(1485, 29);
            this.MenuStrip.TabIndex = 1140;
            this.MenuStrip.Text = "darkMenuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripConnectPS3,
            this.MenuStripFileSeparator0,
            this.MenuStripConnectOfflineMode});
            this.MenuStripFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(74, 19);
            this.MenuStripFile.Text = "CONNECT";
            // 
            // MenuStripConnectPS3
            // 
            this.MenuStripConnectPS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripConnectPS3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripConnectPS3Console});
            this.MenuStripConnectPS3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripConnectPS3.Name = "MenuStripConnectPS3";
            this.MenuStripConnectPS3.Size = new System.Drawing.Size(144, 22);
            this.MenuStripConnectPS3.Text = "PS3";
            // 
            // MenuStripConnectPS3Console
            // 
            this.MenuStripConnectPS3Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripConnectPS3Console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripConnectPS3Console.Name = "MenuStripConnectPS3Console";
            this.MenuStripConnectPS3Console.Size = new System.Drawing.Size(186, 22);
            this.MenuStripConnectPS3Console.Text = "Connect to console...";
            this.MenuStripConnectPS3Console.Click += new System.EventHandler(this.MenuStripConnectPS3Console_Click);
            // 
            // MenuStripFileSeparator0
            // 
            this.MenuStripFileSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripFileSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStripFileSeparator0.Name = "MenuStripFileSeparator0";
            this.MenuStripFileSeparator0.Size = new System.Drawing.Size(141, 6);
            // 
            // MenuStripConnectOfflineMode
            // 
            this.MenuStripConnectOfflineMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripConnectOfflineMode.CheckOnClick = true;
            this.MenuStripConnectOfflineMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripConnectOfflineMode.Name = "MenuStripConnectOfflineMode";
            this.MenuStripConnectOfflineMode.Size = new System.Drawing.Size(144, 22);
            this.MenuStripConnectOfflineMode.Text = "Offline Mode";
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripToolsCustomMods,
            this.MenuItemToolsBackupFiles,
            this.MenuItemToolsSeperator0,
            this.MenuItemToolsFileExplorer});
            this.MenuItemTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTools.Name = "MenuItemTools";
            this.MenuItemTools.Size = new System.Drawing.Size(54, 19);
            this.MenuItemTools.Text = "TOOLS";
            // 
            // MenuStripToolsCustomMods
            // 
            this.MenuStripToolsCustomMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripToolsCustomMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripToolsCustomMods.Name = "MenuStripToolsCustomMods";
            this.MenuStripToolsCustomMods.Size = new System.Drawing.Size(180, 22);
            this.MenuStripToolsCustomMods.Text = "Custom Mods";
            this.MenuStripToolsCustomMods.Click += new System.EventHandler(this.MenuStripToolsCustomMods_Click);
            // 
            // MenuItemToolsBackupFiles
            // 
            this.MenuItemToolsBackupFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsBackupFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsBackupFiles.Name = "MenuItemToolsBackupFiles";
            this.MenuItemToolsBackupFiles.Size = new System.Drawing.Size(180, 22);
            this.MenuItemToolsBackupFiles.Text = "Backup Files";
            this.MenuItemToolsBackupFiles.Click += new System.EventHandler(this.MenuItemToolsBackupFileManager_Click);
            // 
            // MenuItemToolsSeperator0
            // 
            this.MenuItemToolsSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemToolsSeperator0.Name = "MenuItemToolsSeperator0";
            this.MenuItemToolsSeperator0.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemToolsFileExplorer
            // 
            this.MenuItemToolsFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsFileExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsFileExplorer.Name = "MenuItemToolsFileExplorer";
            this.MenuItemToolsFileExplorer.Size = new System.Drawing.Size(180, 22);
            this.MenuItemToolsFileExplorer.Text = "File Explorer (FTP)";
            this.MenuItemToolsFileExplorer.Click += new System.EventHandler(this.MenuItemToolsFileExplorer_Click);
            // 
            // MenuItemResources
            // 
            this.MenuItemResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemResources.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCustomFirmware,
            this.MenuItemModdingForums,
            this.MenuItemHomebrew,
            this.MenuItemGames,
            this.MenuItemReddit});
            this.MenuItemResources.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemResources.Name = "MenuItemResources";
            this.MenuItemResources.Size = new System.Drawing.Size(82, 19);
            this.MenuItemResources.Text = "RESOURCES";
            // 
            // MenuItemCustomFirmware
            // 
            this.MenuItemCustomFirmware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemCustomFirmware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesCustomFirmwareRebug});
            this.MenuItemCustomFirmware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemCustomFirmware.Name = "MenuItemCustomFirmware";
            this.MenuItemCustomFirmware.Size = new System.Drawing.Size(168, 22);
            this.MenuItemCustomFirmware.Text = "Custom Firmware";
            // 
            // MenuStripResourcesCustomFirmwareRebug
            // 
            this.MenuStripResourcesCustomFirmwareRebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripResourcesCustomFirmwareRebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesCustomFirmwareRebug.Name = "MenuStripResourcesCustomFirmwareRebug";
            this.MenuStripResourcesCustomFirmwareRebug.Size = new System.Drawing.Size(128, 22);
            this.MenuStripResourcesCustomFirmwareRebug.Text = "Rebug.me";
            this.MenuStripResourcesCustomFirmwareRebug.Click += new System.EventHandler(this.MenuStripResourcesCustomFirmwareRebug_Click);
            // 
            // MenuItemModdingForums
            // 
            this.MenuItemModdingForums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemModdingForums.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPsxPlace,
            this.MenuItemPSXScene,
            this.MenuItemNGU,
            this.MenuItemSe7enSins,
            this.MenuItemTTG});
            this.MenuItemModdingForums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemModdingForums.Name = "MenuItemModdingForums";
            this.MenuItemModdingForums.Size = new System.Drawing.Size(168, 22);
            this.MenuItemModdingForums.Text = "Modding Forums";
            // 
            // MenuItemPsxPlace
            // 
            this.MenuItemPsxPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemPsxPlace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPSXPlacePs3Mods,
            this.MenuItemPSXPlaceGameMods});
            this.MenuItemPsxPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemPsxPlace.Name = "MenuItemPsxPlace";
            this.MenuItemPsxPlace.Size = new System.Drawing.Size(158, 22);
            this.MenuItemPsxPlace.Text = "PSX Place";
            // 
            // MenuItemPSXPlacePs3Mods
            // 
            this.MenuItemPSXPlacePs3Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemPSXPlacePs3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemPSXPlacePs3Mods.Name = "MenuItemPSXPlacePs3Mods";
            this.MenuItemPSXPlacePs3Mods.Size = new System.Drawing.Size(143, 22);
            this.MenuItemPSXPlacePs3Mods.Text = "PS3 Mods";
            this.MenuItemPSXPlacePs3Mods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxPlacePs3Mods_Click);
            // 
            // MenuItemPSXPlaceGameMods
            // 
            this.MenuItemPSXPlaceGameMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemPSXPlaceGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemPSXPlaceGameMods.Name = "MenuItemPSXPlaceGameMods";
            this.MenuItemPSXPlaceGameMods.Size = new System.Drawing.Size(143, 22);
            this.MenuItemPSXPlaceGameMods.Text = "Games Mods";
            this.MenuItemPSXPlaceGameMods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxPlaceGameMods_Click);
            // 
            // MenuItemPSXScene
            // 
            this.MenuItemPSXScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemPSXScene.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPSXScenePS3Mods,
            this.MenuItemPSXSceneGameMods});
            this.MenuItemPSXScene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemPSXScene.Name = "MenuItemPSXScene";
            this.MenuItemPSXScene.Size = new System.Drawing.Size(158, 22);
            this.MenuItemPSXScene.Text = "PSX Scene";
            // 
            // MenuItemPSXScenePS3Mods
            // 
            this.MenuItemPSXScenePS3Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemPSXScenePS3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemPSXScenePS3Mods.Name = "MenuItemPSXScenePS3Mods";
            this.MenuItemPSXScenePS3Mods.Size = new System.Drawing.Size(138, 22);
            this.MenuItemPSXScenePS3Mods.Text = "PS3 Mods";
            this.MenuItemPSXScenePS3Mods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxScenePs3Mods_Click);
            // 
            // MenuItemPSXSceneGameMods
            // 
            this.MenuItemPSXSceneGameMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemPSXSceneGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemPSXSceneGameMods.Name = "MenuItemPSXSceneGameMods";
            this.MenuItemPSXSceneGameMods.Size = new System.Drawing.Size(138, 22);
            this.MenuItemPSXSceneGameMods.Text = "Game Mods";
            this.MenuItemPSXSceneGameMods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxSceneGameMods_Click);
            // 
            // MenuItemNGU
            // 
            this.MenuItemNGU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemNGU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNGUPS3Mods});
            this.MenuItemNGU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemNGU.Name = "MenuItemNGU";
            this.MenuItemNGU.Size = new System.Drawing.Size(158, 22);
            this.MenuItemNGU.Text = "NextGenUpdate";
            // 
            // MenuItemNGUPS3Mods
            // 
            this.MenuItemNGUPS3Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemNGUPS3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemNGUPS3Mods.Name = "MenuItemNGUPS3Mods";
            this.MenuItemNGUPS3Mods.Size = new System.Drawing.Size(178, 22);
            this.MenuItemNGUPS3Mods.Text = "PS3 Mods && Cheats";
            this.MenuItemNGUPS3Mods.Click += new System.EventHandler(this.MenuStripResourcesForumsNguPs3Mods_Click);
            // 
            // MenuItemSe7enSins
            // 
            this.MenuItemSe7enSins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSe7enSins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSe7enSinsPS3Mods,
            this.MenuItemSe7enSinsGameMods});
            this.MenuItemSe7enSins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSe7enSins.Name = "MenuItemSe7enSins";
            this.MenuItemSe7enSins.Size = new System.Drawing.Size(158, 22);
            this.MenuItemSe7enSins.Text = "Se7enSins";
            // 
            // MenuItemSe7enSinsPS3Mods
            // 
            this.MenuItemSe7enSinsPS3Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSe7enSinsPS3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSe7enSinsPS3Mods.Name = "MenuItemSe7enSinsPS3Mods";
            this.MenuItemSe7enSinsPS3Mods.Size = new System.Drawing.Size(138, 22);
            this.MenuItemSe7enSinsPS3Mods.Text = "PS3 Mods";
            this.MenuItemSe7enSinsPS3Mods.Click += new System.EventHandler(this.PS3ModsToolStripMenuItem_Click);
            // 
            // MenuItemSe7enSinsGameMods
            // 
            this.MenuItemSe7enSinsGameMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSe7enSinsGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSe7enSinsGameMods.Name = "MenuItemSe7enSinsGameMods";
            this.MenuItemSe7enSinsGameMods.Size = new System.Drawing.Size(138, 22);
            this.MenuItemSe7enSinsGameMods.Text = "Game Mods";
            this.MenuItemSe7enSinsGameMods.Click += new System.EventHandler(this.GameModsToolStripMenuItem_Click);
            // 
            // MenuItemTTG
            // 
            this.MenuItemTTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTTG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTTGPS3Mods,
            this.MenuItemTTGGameMods});
            this.MenuItemTTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTTG.Name = "MenuItemTTG";
            this.MenuItemTTG.Size = new System.Drawing.Size(158, 22);
            this.MenuItemTTG.Text = "TheTechGame";
            // 
            // MenuItemTTGPS3Mods
            // 
            this.MenuItemTTGPS3Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTTGPS3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTTGPS3Mods.Name = "MenuItemTTGPS3Mods";
            this.MenuItemTTGPS3Mods.Size = new System.Drawing.Size(138, 22);
            this.MenuItemTTGPS3Mods.Text = "PS3 Mods";
            this.MenuItemTTGPS3Mods.Click += new System.EventHandler(this.PS3ModsToolStripMenuItem3_Click);
            // 
            // MenuItemTTGGameMods
            // 
            this.MenuItemTTGGameMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTTGGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTTGGameMods.Name = "MenuItemTTGGameMods";
            this.MenuItemTTGGameMods.Size = new System.Drawing.Size(138, 22);
            this.MenuItemTTGGameMods.Text = "Game Mods";
            this.MenuItemTTGGameMods.Click += new System.EventHandler(this.GameModsToolStripMenuItem2_Click);
            // 
            // MenuItemHomebrew
            // 
            this.MenuItemHomebrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHomebrew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemBrewologyStore});
            this.MenuItemHomebrew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHomebrew.Name = "MenuItemHomebrew";
            this.MenuItemHomebrew.Size = new System.Drawing.Size(168, 22);
            this.MenuItemHomebrew.Text = "Homebrew";
            // 
            // MenuItemBrewologyStore
            // 
            this.MenuItemBrewologyStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemBrewologyStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemBrewologyStore.Name = "MenuItemBrewologyStore";
            this.MenuItemBrewologyStore.Size = new System.Drawing.Size(160, 22);
            this.MenuItemBrewologyStore.Text = "Brewology Store";
            this.MenuItemBrewologyStore.Click += new System.EventHandler(this.BrewologyToolStripMenuItem_Click);
            // 
            // MenuItemGames
            // 
            this.MenuItemGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesGamesPsnDLv3,
            this.MenuStripResourcesGamesNoPsv2});
            this.MenuItemGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemGames.Name = "MenuItemGames";
            this.MenuItemGames.Size = new System.Drawing.Size(168, 22);
            this.MenuItemGames.Text = "Games";
            // 
            // MenuStripResourcesGamesPsnDLv3
            // 
            this.MenuStripResourcesGamesPsnDLv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripResourcesGamesPsnDLv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesGamesPsnDLv3.Name = "MenuStripResourcesGamesPsnDLv3";
            this.MenuStripResourcesGamesPsnDLv3.Size = new System.Drawing.Size(170, 22);
            this.MenuStripResourcesGamesPsnDLv3.Text = "PSNDLv3";
            this.MenuStripResourcesGamesPsnDLv3.Click += new System.EventHandler(this.MenuStripResourcesGamesPsnDLv3_Click);
            // 
            // MenuStripResourcesGamesNoPsv2
            // 
            this.MenuStripResourcesGamesNoPsv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripResourcesGamesNoPsv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesGamesNoPsv2.Name = "MenuStripResourcesGamesNoPsv2";
            this.MenuStripResourcesGamesNoPsv2.Size = new System.Drawing.Size(170, 22);
            this.MenuStripResourcesGamesNoPsv2.Text = "NoPayStation v2.0";
            this.MenuStripResourcesGamesNoPsv2.Click += new System.EventHandler(this.MenuStripResourcesGamesNoPsv2_Click);
            // 
            // MenuItemReddit
            // 
            this.MenuItemReddit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemReddit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRedditPS3Hacks,
            this.MenuItemRedditPS3Homebrew});
            this.MenuItemReddit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemReddit.Name = "MenuItemReddit";
            this.MenuItemReddit.Size = new System.Drawing.Size(168, 22);
            this.MenuItemReddit.Text = "Reddit";
            // 
            // MenuItemRedditPS3Hacks
            // 
            this.MenuItemRedditPS3Hacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemRedditPS3Hacks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemRedditPS3Hacks.Name = "MenuItemRedditPS3Hacks";
            this.MenuItemRedditPS3Hacks.Size = new System.Drawing.Size(155, 22);
            this.MenuItemRedditPS3Hacks.Text = "PS3 Hacks";
            this.MenuItemRedditPS3Hacks.Click += new System.EventHandler(this.MenuStripResourcesRedditPs3Hacks_Click);
            // 
            // MenuItemRedditPS3Homebrew
            // 
            this.MenuItemRedditPS3Homebrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemRedditPS3Homebrew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemRedditPS3Homebrew.Name = "MenuItemRedditPS3Homebrew";
            this.MenuItemRedditPS3Homebrew.Size = new System.Drawing.Size(155, 22);
            this.MenuItemRedditPS3Homebrew.Text = "PS3 Homebrew";
            this.MenuItemRedditPS3Homebrew.Click += new System.EventHandler(this.MenuStripResourcesRedditPs3Homebrew_Click);
            // 
            // MenuItemApplications
            // 
            this.MenuItemApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemApplicationsCCAPI,
            this.MenuItemApplicationsFileZilla});
            this.MenuItemApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemApplications.Name = "MenuItemApplications";
            this.MenuItemApplications.Size = new System.Drawing.Size(98, 19);
            this.MenuItemApplications.Text = "APPLICATIONS";
            // 
            // MenuItemApplicationsCCAPI
            // 
            this.MenuItemApplicationsCCAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemApplicationsCCAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemApplicationsCCAPI.Name = "MenuItemApplicationsCCAPI";
            this.MenuItemApplicationsCCAPI.Size = new System.Drawing.Size(212, 22);
            this.MenuItemApplicationsCCAPI.Text = "Console Manager (CCAPI)";
            this.MenuItemApplicationsCCAPI.Click += new System.EventHandler(this.MenuStripApplicationsCCAPI_Click);
            // 
            // MenuItemApplicationsFileZilla
            // 
            this.MenuItemApplicationsFileZilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemApplicationsFileZilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemApplicationsFileZilla.Name = "MenuItemApplicationsFileZilla";
            this.MenuItemApplicationsFileZilla.Size = new System.Drawing.Size(212, 22);
            this.MenuItemApplicationsFileZilla.Text = "FileZilla";
            this.MenuItemApplicationsFileZilla.Click += new System.EventHandler(this.MenuStripApplicationsFileZilla_Click);
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingsShowModID,
            this.MenuItemSettingsAutoDetectGameRegion,
            this.MenuItemSettingsRememberGameRegions,
            this.MenuItemSettingsAlwaysDownloadInstallFiles,
            this.MenuItemSeperator2,
            this.MenuItemSettingsEditGameRegions,
            this.MenuItemSeperator5,
            this.MenuItemSettingsEditConsoleProfiles});
            this.MenuItemSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.Size = new System.Drawing.Size(69, 19);
            this.MenuItemSettings.Text = "SETTINGS";
            // 
            // MenuItemSettingsShowModID
            // 
            this.MenuItemSettingsShowModID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsShowModID.CheckOnClick = true;
            this.MenuItemSettingsShowModID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsShowModID.Name = "MenuItemSettingsShowModID";
            this.MenuItemSettingsShowModID.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsShowModID.Text = "Show Mod ID #";
            this.MenuItemSettingsShowModID.Click += new System.EventHandler(this.MenuItemSettingsShowModID_Click);
            // 
            // MenuItemSettingsAutoDetectGameRegion
            // 
            this.MenuItemSettingsAutoDetectGameRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAutoDetectGameRegion.CheckOnClick = true;
            this.MenuItemSettingsAutoDetectGameRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAutoDetectGameRegion.Name = "MenuItemSettingsAutoDetectGameRegion";
            this.MenuItemSettingsAutoDetectGameRegion.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsAutoDetectGameRegion.Text = "Auto-Detect Game Regions";
            this.MenuItemSettingsAutoDetectGameRegion.Click += new System.EventHandler(this.MenuItemSettingsAutoDetectGameRegion_Click);
            // 
            // MenuItemSettingsRememberGameRegions
            // 
            this.MenuItemSettingsRememberGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsRememberGameRegions.CheckOnClick = true;
            this.MenuItemSettingsRememberGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsRememberGameRegions.Name = "MenuItemSettingsRememberGameRegions";
            this.MenuItemSettingsRememberGameRegions.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsRememberGameRegions.Text = "Save Game Regions";
            this.MenuItemSettingsRememberGameRegions.Click += new System.EventHandler(this.MenuItemSettingsRememberGameRegions_Click);
            // 
            // MenuItemSettingsAlwaysDownloadInstallFiles
            // 
            this.MenuItemSettingsAlwaysDownloadInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAlwaysDownloadInstallFiles.CheckOnClick = true;
            this.MenuItemSettingsAlwaysDownloadInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Name = "MenuItemSettingsAlwaysDownloadInstallFiles";
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Text = "Always Download Install Files";
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Click += new System.EventHandler(this.MenuItemSettingsAlwaysDownloadInstallFiles_Click);
            // 
            // MenuItemSeperator2
            // 
            this.MenuItemSeperator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator2.Name = "MenuItemSeperator2";
            this.MenuItemSeperator2.Size = new System.Drawing.Size(225, 6);
            // 
            // MenuItemSettingsEditConsoleProfiles
            // 
            this.MenuItemSettingsEditConsoleProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsEditConsoleProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsEditConsoleProfiles.Name = "MenuItemSettingsEditConsoleProfiles";
            this.MenuItemSettingsEditConsoleProfiles.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsEditConsoleProfiles.Text = "Edit Console Profiles...";
            this.MenuItemSettingsEditConsoleProfiles.Click += new System.EventHandler(this.MenuItemSettingsEditConsoleProfiles_Click);
            // 
            // MenuItemSettingsEditGameRegions
            // 
            this.MenuItemSettingsEditGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsEditGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsEditGameRegions.Name = "MenuItemSettingsEditGameRegions";
            this.MenuItemSettingsEditGameRegions.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsEditGameRegions.Text = "Edit Saved Game Regions...";
            this.MenuItemSettingsEditGameRegions.Click += new System.EventHandler(this.MenuItemSettingsEditGameRegions_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportIssue,
            this.MenuItemSourceCode,
            this.MenuItemCheckForUpdates,
            this.MenuItemSeperator3,
            this.MenuItemMoreInformation,
            this.MenuItemSeperator4,
            this.MenuItemAbout});
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
            this.MenuItemReportIssue.Size = new System.Drawing.Size(226, 22);
            this.MenuItemReportIssue.Text = "Report Problem/Suggestions";
            this.MenuItemReportIssue.Click += new System.EventHandler(this.MenuStripHelpReportBugSuggestions_Click);
            // 
            // MenuItemSourceCode
            // 
            this.MenuItemSourceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSourceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSourceCode.Name = "MenuItemSourceCode";
            this.MenuItemSourceCode.Size = new System.Drawing.Size(226, 22);
            this.MenuItemSourceCode.Text = "Source Code (GitHub)";
            this.MenuItemSourceCode.Click += new System.EventHandler(this.MenuStripHelpSourceCode_Click);
            // 
            // MenuItemCheckForUpdates
            // 
            this.MenuItemCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemCheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemCheckForUpdates.Name = "MenuItemCheckForUpdates";
            this.MenuItemCheckForUpdates.Size = new System.Drawing.Size(226, 22);
            this.MenuItemCheckForUpdates.Text = "Check for Update";
            this.MenuItemCheckForUpdates.Click += new System.EventHandler(this.MenuStripHelpCheckForUpdates_Click);
            // 
            // MenuItemSeperator3
            // 
            this.MenuItemSeperator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator3.Name = "MenuItemSeperator3";
            this.MenuItemSeperator3.Size = new System.Drawing.Size(223, 6);
            // 
            // MenuItemMoreInformation
            // 
            this.MenuItemMoreInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemMoreInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemMoreInformation.Name = "MenuItemMoreInformation";
            this.MenuItemMoreInformation.Size = new System.Drawing.Size(226, 22);
            this.MenuItemMoreInformation.Text = "More Information";
            this.MenuItemMoreInformation.Click += new System.EventHandler(this.MenuItemInstallUninstallNotes_Click);
            // 
            // MenuItemSeperator4
            // 
            this.MenuItemSeperator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator4.Name = "MenuItemSeperator4";
            this.MenuItemSeperator4.Size = new System.Drawing.Size(223, 6);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(226, 22);
            this.MenuItemAbout.Text = "About ModioX";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuStripHelpAbout_Click);
            // 
            // MenuStripRefreshData
            // 
            this.MenuStripRefreshData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuStripRefreshData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripRefreshData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripRefreshData.Name = "MenuStripRefreshData";
            this.MenuStripRefreshData.Size = new System.Drawing.Size(97, 19);
            this.MenuStripRefreshData.Text = "REFRESH DATA";
            this.MenuStripRefreshData.Click += new System.EventHandler(this.MenuStripItemRefreshData_Click);
            // 
            // MenuStripRequestMod
            // 
            this.MenuStripRequestMod.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuStripRequestMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripRequestMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripRequestMod.Name = "MenuStripRequestMod";
            this.MenuStripRequestMod.Size = new System.Drawing.Size(104, 19);
            this.MenuStripRequestMod.Text = "REQUEST MODS";
            this.MenuStripRequestMod.Click += new System.EventHandler(this.MenuStripRequestMod_Click);
            // 
            // MenuStatusStrip
            // 
            this.MenuStatusStrip.AutoSize = false;
            this.MenuStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelConnectedConsole,
            this.ToolStripLabelConsole,
            this.ToolStripStatusSeperator0,
            this.ToolStripLabelStatus,
            this.ToolStripLabelStats});
            this.MenuStatusStrip.Location = new System.Drawing.Point(0, 733);
            this.MenuStatusStrip.Name = "MenuStatusStrip";
            this.MenuStatusStrip.Padding = new System.Windows.Forms.Padding(11, 0, 8, 5);
            this.MenuStatusStrip.Size = new System.Drawing.Size(1485, 32);
            this.MenuStatusStrip.TabIndex = 1146;
            this.MenuStatusStrip.Text = "darkToolStrip1";
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
            this.ToolStripLabelStats.Size = new System.Drawing.Size(567, 24);
            this.ToolStripLabelStats.Text = "## Mods for ## Games, ## Game Updates, ## Homebrew Packages, ## Resources && ## A" +
    "wesome Themes";
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
            // 
            // ContextMenuStripLocalDeleteFile
            // 
            this.ContextMenuStripLocalDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuStripLocalDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuStripLocalDeleteFile.Name = "ContextMenuStripLocalDeleteFile";
            this.ContextMenuStripLocalDeleteFile.Size = new System.Drawing.Size(133, 22);
            this.ContextMenuStripLocalDeleteFile.Text = "Delete File";
            // 
            // LabelSelectSystemType
            // 
            this.LabelSelectSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectSystemType.AutoSize = true;
            this.LabelSelectSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectSystemType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectSystemType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectSystemType.Location = new System.Drawing.Point(316, 42);
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
            this.SectionModsLibrary.Location = new System.Drawing.Point(286, 39);
            this.SectionModsLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.SectionModsLibrary.Name = "SectionModsLibrary";
            this.SectionModsLibrary.SectionHeader = "MODS LIBRARY";
            this.SectionModsLibrary.Size = new System.Drawing.Size(802, 437);
            this.SectionModsLibrary.TabIndex = 10;
            // 
            // LabelNoModsFound
            // 
            this.LabelNoModsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoModsFound.AutoSize = true;
            this.LabelNoModsFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsFound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelNoModsFound.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsFound.Location = new System.Drawing.Point(349, 182);
            this.LabelNoModsFound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoModsFound.Name = "LabelNoModsFound";
            this.LabelNoModsFound.Size = new System.Drawing.Size(105, 15);
            this.LabelNoModsFound.TabIndex = 1159;
            this.LabelNoModsFound.Text = "NO MODS FOUND";
            // 
            // DgvMods
            // 
            this.DgvMods.AllowUserToAddRows = false;
            this.DgvMods.AllowUserToDeleteRows = false;
            this.DgvMods.AllowUserToDragDropRows = false;
            this.DgvMods.AllowUserToPasteCells = false;
            this.DgvMods.AllowUserToResizeColumns = false;
            this.DgvMods.ColumnHeadersHeight = 21;
            this.DgvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModsId,
            this.ColumnModsName,
            this.ColumnModsFirmware,
            this.ColumnModsType,
            this.ColumnModsRegion,
            this.ColumnModsVersion,
            this.ColumnModsAuthor,
            this.ColumnModsNoFiles,
            this.Column9,
            this.Column10,
            this.Column13});
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
            this.DgvMods.Size = new System.Drawing.Size(800, 315);
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
            this.ColumnModsFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsFirmware.HeaderText = "System Type";
            this.ColumnModsFirmware.MinimumWidth = 6;
            this.ColumnModsFirmware.Name = "ColumnModsFirmware";
            this.ColumnModsFirmware.ReadOnly = true;
            this.ColumnModsFirmware.Width = 82;
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsType.HeaderText = "Mod Type";
            this.ColumnModsType.MinimumWidth = 6;
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            this.ColumnModsType.Width = 86;
            // 
            // ColumnModsRegion
            // 
            this.ColumnModsRegion.HeaderText = "Region";
            this.ColumnModsRegion.MinimumWidth = 6;
            this.ColumnModsRegion.Name = "ColumnModsRegion";
            this.ColumnModsRegion.ReadOnly = true;
            this.ColumnModsRegion.Width = 78;
            // 
            // ColumnModsVersion
            // 
            this.ColumnModsVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsVersion.HeaderText = "Version";
            this.ColumnModsVersion.MinimumWidth = 6;
            this.ColumnModsVersion.Name = "ColumnModsVersion";
            this.ColumnModsVersion.ReadOnly = true;
            this.ColumnModsVersion.Width = 70;
            // 
            // ColumnModsAuthor
            // 
            this.ColumnModsAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsAuthor.HeaderText = "Creator";
            this.ColumnModsAuthor.MinimumWidth = 124;
            this.ColumnModsAuthor.Name = "ColumnModsAuthor";
            this.ColumnModsAuthor.ReadOnly = true;
            this.ColumnModsAuthor.Width = 124;
            // 
            // ColumnModsNoFiles
            // 
            this.ColumnModsNoFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsNoFiles.HeaderText = "# Files";
            this.ColumnModsNoFiles.MinimumWidth = 6;
            this.ColumnModsNoFiles.Name = "ColumnModsNoFiles";
            this.ColumnModsNoFiles.ReadOnly = true;
            this.ColumnModsNoFiles.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 28;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 28;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 28;
            // 
            // PanelModsLibraryFilters
            // 
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
            this.PanelModsLibraryFilters.Size = new System.Drawing.Size(800, 96);
            this.PanelModsLibraryFilters.TabIndex = 12;
            // 
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRegion.FormattingEnabled = true;
            this.ComboBoxRegion.Location = new System.Drawing.Point(697, 39);
            this.ComboBoxRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxRegion.Name = "ComboBoxRegion";
            this.ComboBoxRegion.Size = new System.Drawing.Size(95, 24);
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
            this.LabelSelectRegion.Location = new System.Drawing.Point(642, 42);
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
            this.LabelTitleMods.Size = new System.Drawing.Size(785, 17);
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
            this.LabelTitleFilterMods.Size = new System.Drawing.Size(785, 17);
            this.LabelTitleFilterMods.TabIndex = 1159;
            this.LabelTitleFilterMods.Text = "FILTER MODS";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(61, 38);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(246, 23);
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
            this.ComboBoxModType.FormattingEnabled = true;
            this.ComboBoxModType.Location = new System.Drawing.Point(538, 38);
            this.ComboBoxModType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Size = new System.Drawing.Size(96, 24);
            this.ComboBoxModType.TabIndex = 4;
            this.ComboBoxModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // ComboBoxSystemType
            // 
            this.ComboBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSystemType.FormattingEnabled = true;
            this.ComboBoxSystemType.Location = new System.Drawing.Point(400, 38);
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
            this.SectionGames.Location = new System.Drawing.Point(13, 39);
            this.SectionGames.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.SectionGames.Name = "SectionGames";
            this.SectionGames.SectionHeader = "CATEGORIES";
            this.SectionGames.Size = new System.Drawing.Size(265, 687);
            this.SectionGames.TabIndex = 0;
            // 
            // ScrollBarCategories
            // 
            this.ScrollBarCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarCategories.Location = new System.Drawing.Point(247, 25);
            this.ScrollBarCategories.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.ScrollBarCategories.Name = "ScrollBarCategories";
            this.ScrollBarCategories.Size = new System.Drawing.Size(17, 661);
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
            this.FlowPanelCategories.Size = new System.Drawing.Size(263, 661);
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
            this.PanelGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelGames.Location = new System.Drawing.Point(2, 30);
            this.PanelGames.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelGames.Name = "PanelGames";
            this.PanelGames.Size = new System.Drawing.Size(244, 0);
            this.PanelGames.TabIndex = 0;
            // 
            // LabelTitleResources
            // 
            this.LabelTitleResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleResources.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleResources.Location = new System.Drawing.Point(7, 38);
            this.LabelTitleResources.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleResources.Name = "LabelTitleResources";
            this.LabelTitleResources.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleResources.TabIndex = 1163;
            this.LabelTitleResources.Text = "RESOURCES";
            // 
            // PanelResources
            // 
            this.PanelResources.AutoSize = true;
            this.PanelResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResources.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelResources.Location = new System.Drawing.Point(2, 59);
            this.PanelResources.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelResources.Name = "PanelResources";
            this.PanelResources.Size = new System.Drawing.Size(244, 0);
            this.PanelResources.TabIndex = 1164;
            // 
            // LabelTitleMyLists
            // 
            this.LabelTitleMyLists.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleMyLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleMyLists.Location = new System.Drawing.Point(7, 67);
            this.LabelTitleMyLists.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleMyLists.Name = "LabelTitleMyLists";
            this.LabelTitleMyLists.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleMyLists.TabIndex = 1165;
            this.LabelTitleMyLists.Text = "MY LISTS";
            // 
            // PanelLists
            // 
            this.PanelLists.AutoSize = true;
            this.PanelLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLists.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelLists.Location = new System.Drawing.Point(2, 88);
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
            this.SectionInstalledGameMods.Controls.Add(this.DgvModsInstalled);
            this.SectionInstalledGameMods.Controls.Add(this.PanelModsInstalledHeader);
            this.SectionInstalledGameMods.Controls.Add(this.MenuGameModsStrip);
            this.SectionInstalledGameMods.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionInstalledGameMods.Location = new System.Drawing.Point(286, 483);
            this.SectionInstalledGameMods.Margin = new System.Windows.Forms.Padding(4);
            this.SectionInstalledGameMods.Name = "SectionInstalledGameMods";
            this.SectionInstalledGameMods.SectionHeader = "MODS INSTALLED";
            this.SectionInstalledGameMods.Size = new System.Drawing.Size(802, 243);
            this.SectionInstalledGameMods.TabIndex = 1175;
            // 
            // LabelNoModsInstalled
            // 
            this.LabelNoModsInstalled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoModsInstalled.AutoSize = true;
            this.LabelNoModsInstalled.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsInstalled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelNoModsInstalled.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsInstalled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsInstalled.Location = new System.Drawing.Point(340, 107);
            this.LabelNoModsInstalled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoModsInstalled.Name = "LabelNoModsInstalled";
            this.LabelNoModsInstalled.Size = new System.Drawing.Size(122, 15);
            this.LabelNoModsInstalled.TabIndex = 1178;
            this.LabelNoModsInstalled.Text = "NO MODS INSTALLED";
            // 
            // DgvModsInstalled
            // 
            this.DgvModsInstalled.AllowUserToAddRows = false;
            this.DgvModsInstalled.AllowUserToDeleteRows = false;
            this.DgvModsInstalled.AllowUserToDragDropRows = false;
            this.DgvModsInstalled.AllowUserToPasteCells = false;
            this.DgvModsInstalled.AllowUserToResizeColumns = false;
            this.DgvModsInstalled.ColumnHeadersHeight = 21;
            this.DgvModsInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvModsInstalled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column3,
            this.Column16,
            this.Column2,
            this.Column17,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column12});
            this.DgvModsInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvModsInstalled.Location = new System.Drawing.Point(1, 61);
            this.DgvModsInstalled.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DgvModsInstalled.MultiSelect = false;
            this.DgvModsInstalled.Name = "DgvModsInstalled";
            this.DgvModsInstalled.ReadOnly = true;
            this.DgvModsInstalled.RowHeadersWidth = 41;
            this.DgvModsInstalled.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvModsInstalled.RowTemplate.Height = 24;
            this.DgvModsInstalled.RowTemplate.ReadOnly = true;
            this.DgvModsInstalled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvModsInstalled.Size = new System.Drawing.Size(800, 145);
            this.DgvModsInstalled.TabIndex = 7;
            this.DgvModsInstalled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModsInstalled_CellClick);
            this.DgvModsInstalled.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvModsInstalled.SelectionChanged += new System.EventHandler(this.DgvModsInstalled_SelectionChanged);
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Mod Id";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Game Title";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Region";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 78;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Mod Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "System Type";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 82;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mod Type";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 86;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Version";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 68;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "# Files";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 28;
            // 
            // PanelModsInstalledHeader
            // 
            this.PanelModsInstalledHeader.Controls.Add(this.label7);
            this.PanelModsInstalledHeader.Controls.Add(this.label8);
            this.PanelModsInstalledHeader.Controls.Add(this.darkTitle12);
            this.PanelModsInstalledHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModsInstalledHeader.Location = new System.Drawing.Point(1, 25);
            this.PanelModsInstalledHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsInstalledHeader.Name = "PanelModsInstalledHeader";
            this.PanelModsInstalledHeader.Size = new System.Drawing.Size(800, 36);
            this.PanelModsInstalledHeader.TabIndex = 1177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(520, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 2, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 1177;
            this.label7.Text = "Mod Version:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(601, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 1176;
            this.label8.Text = "n/a";
            // 
            // darkTitle12
            // 
            this.darkTitle12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTitle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.darkTitle12.Location = new System.Drawing.Point(7, 10);
            this.darkTitle12.Name = "darkTitle12";
            this.darkTitle12.Size = new System.Drawing.Size(788, 17);
            this.darkTitle12.TabIndex = 1160;
            this.darkTitle12.Text = "GAME MODS";
            // 
            // MenuGameModsStrip
            // 
            this.MenuGameModsStrip.AutoSize = false;
            this.MenuGameModsStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuGameModsStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuGameModsStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuGameModsStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuGameModsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuGameModsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemUninstallAllGameMods,
            this.LabelInstalledGameModsStatus});
            this.MenuGameModsStrip.Location = new System.Drawing.Point(1, 206);
            this.MenuGameModsStrip.Name = "MenuGameModsStrip";
            this.MenuGameModsStrip.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.MenuGameModsStrip.Size = new System.Drawing.Size(800, 36);
            this.MenuGameModsStrip.TabIndex = 8;
            this.MenuGameModsStrip.TabStop = true;
            this.MenuGameModsStrip.Text = "darkToolStrip2";
            // 
            // ToolItemUninstallAllGameMods
            // 
            this.ToolItemUninstallAllGameMods.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolItemUninstallAllGameMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemUninstallAllGameMods.Enabled = false;
            this.ToolItemUninstallAllGameMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemUninstallAllGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemUninstallAllGameMods.Image = global::ModioX.Properties.Resources.icons8_uninstall_programs_22;
            this.ToolItemUninstallAllGameMods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstallAllGameMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstallAllGameMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstallAllGameMods.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstallAllGameMods.Name = "ToolItemUninstallAllGameMods";
            this.ToolItemUninstallAllGameMods.Size = new System.Drawing.Size(98, 26);
            this.ToolItemUninstallAllGameMods.Text = "Uninstall All";
            this.ToolItemUninstallAllGameMods.ToolTipText = "Uninstall All Mods";
            this.ToolItemUninstallAllGameMods.Click += new System.EventHandler(this.ToolItemUninstallAllGameMods_Click);
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
            // MenuItemSeperator5
            // 
            this.MenuItemSeperator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator5.Name = "MenuItemSeperator5";
            this.MenuItemSeperator5.Size = new System.Drawing.Size(225, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1485, 765);
            this.Controls.Add(this.SectionInstalledGameMods);
            this.Controls.Add(this.MenuStatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.SectionArchiveInformation);
            this.Controls.Add(this.SectionModsLibrary);
            this.Controls.Add(this.SectionGames);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ContextMenuMods.ResumeLayout(false);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.SectionModsInstallFilePaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).EndInit();
            this.ContextMenuConsoleFile.ResumeLayout(false);
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.PanelModsInstallationPaths.ResumeLayout(false);
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MenuStatusStrip.ResumeLayout(false);
            this.MenuStatusStrip.PerformLayout();
            this.ContextMenuLocalFile.ResumeLayout(false);
            this.SectionModsLibrary.ResumeLayout(false);
            this.SectionModsLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).EndInit();
            this.PanelModsLibraryFilters.ResumeLayout(false);
            this.PanelModsLibraryFilters.PerformLayout();
            this.SectionGames.ResumeLayout(false);
            this.FlowPanelCategories.ResumeLayout(false);
            this.FlowPanelCategories.PerformLayout();
            this.SectionInstalledGameMods.ResumeLayout(false);
            this.SectionInstalledGameMods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModsInstalled)).EndInit();
            this.PanelModsInstalledHeader.ResumeLayout(false);
            this.PanelModsInstalledHeader.PerformLayout();
            this.MenuGameModsStrip.ResumeLayout(false);
            this.MenuGameModsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSelectType;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelHeaderNameNo;
        private System.Windows.Forms.Label LabelHeaderAuthor;
        private System.Windows.Forms.Label LabelHeaderVersion;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelHeaderGameType;
        private System.Windows.Forms.Label LabelConfig;
        private System.Windows.Forms.Label LabelDescription;
        private DarkUI.Controls.DarkScrollBar ScrollBarDetails;
        private DarkUI.Controls.DarkSectionPanel SectionArchiveInformation;
        private DarkUI.Controls.DarkMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectPS3;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator0;
        private DarkUI.Controls.DarkToolStrip MenuStatusStrip;
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
        private DarkUI.Controls.DarkContextMenu ContextMenuConsoleFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleRefresh;
        private DarkUI.Controls.DarkContextMenu ContextMenuLocalFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripLocalUploadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripLocalDeleteFile;
        private System.Windows.Forms.Label LabelHeaderFirmware;
        private System.Windows.Forms.Label LabelFirmware;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelHeaderCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemResources;
        private System.Windows.Forms.ToolStripMenuItem MenuItemModdingForums;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNGU;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPsxPlace;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPSXPlacePs3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPSXPlaceGameMods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNGUPS3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSe7enSins;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSe7enSinsPS3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSe7enSinsGameMods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTTG;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTTGPS3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTTGGameMods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPSXScene;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPSXScenePS3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPSXSceneGameMods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHomebrew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBrewologyStore;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGames;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesGamesPsnDLv3;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesGamesNoPsv2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSourceCode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportIssue;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCustomFirmware;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesCustomFirmwareRebug;
        private DarkUI.Controls.DarkContextMenu ContextMenuMods;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsInstallToConsole;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsUninstallFromConsole;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsDownloadArchive;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeperator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsExtractInformation;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeperator0;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsReportOnGitHub;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReddit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedditPS3Homebrew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedditPS3Hacks;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplicationsCCAPI;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools;
        private System.Windows.Forms.ToolStripButton ToolItemInstallMod;
        private System.Windows.Forms.ToolStripButton ToolItemDownloadMod;
        private DarkUI.Controls.DarkSectionPanel SectionModsLibrary;
        private DarkUI.Controls.DarkSectionPanel SectionGames;
        private DarkUI.Controls.DarkComboBox ComboBoxSystemType;
        private DarkUI.Controls.DarkComboBox ComboBoxModType;
        private DarkUI.Controls.DarkDataGridView DgvMods;
        private DarkUI.Controls.DarkSectionPanel SectionModsInstallFilePaths;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsBackupFiles;
        private System.Windows.Forms.ToolStripButton ToolItemUninstallMod;
        private System.Windows.Forms.ToolStripButton ToolItemFavoriteMod;
        private System.Windows.Forms.ToolStripMenuItem MenuStripToolsCustomMods;
        private System.Windows.Forms.Panel PanelModsInstallationPaths;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectOfflineMode;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRefreshData;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplicationsFileZilla;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRequestMod;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectPS3Console;
        private DarkUI.Controls.DarkDataGridView DgvInstallPaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripSeparator MenuItemToolsSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsFileExplorer;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsEditConsoleProfiles;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsShowModID;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAutoDetectGameRegion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAlwaysDownloadInstallFiles;
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
        private DarkUI.Controls.DarkDataGridView DgvModsInstalled;
        private System.Windows.Forms.Panel PanelModsInstalledHeader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DarkUI.Controls.DarkTitle darkTitle12;
        private DarkUI.Controls.DarkTitle darkTitle7;
        private DarkUI.Controls.DarkToolStrip MenuGameModsStrip;
        private System.Windows.Forms.ToolStripButton ToolItemUninstallAllGameMods;
        private System.Windows.Forms.ToolStripLabel LabelInstalledGameModsStatus;
        private System.Windows.Forms.Label LabelHeaderRegion;
        private System.Windows.Forms.Label LabelRegion;
        private DarkUI.Controls.DarkComboBox ComboBoxRegion;
        private System.Windows.Forms.Label LabelSelectRegion;
        private System.Windows.Forms.Label LabelNoModsFound;
        private System.Windows.Forms.Label LabelNoModsInstalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsFirmware;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsNoFiles;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column12;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMoreInformation;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsRememberGameRegions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsEditGameRegions;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator5;
    }
}