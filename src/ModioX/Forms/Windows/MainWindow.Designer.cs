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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ContextMenuMods = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuModsInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsUninstallFiles = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LabelHeaderInstallationFiles = new DarkUI.Controls.DarkTitle();
            this.DgvInstallPaths = new DarkUI.Controls.DarkDataGridView();
            this.ColumnInstallationPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.MenuItemToolsGameBackupFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemToolsFileManager = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsShowModID = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAutoDetectGameRegions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsRememberGameRegions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAlwaysDownloadInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSettingsEditGameRegions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsEditExternalApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSettingsAddNewConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSettingsResetAllSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpDiscordServer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemMoreInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripHelpCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRequestMod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStatusStrip = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripStatusSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
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
            this.ColumnModsInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsFavourite = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.LabelTitleHomebrew = new DarkUI.Controls.DarkTitle();
            this.PanelHomebrew = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleResources = new DarkUI.Controls.DarkTitle();
            this.PanelResources = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleMyLists = new DarkUI.Controls.DarkTitle();
            this.PanelLists = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionInstalledGameMods = new DarkUI.Controls.DarkSectionPanel();
            this.LabelNoModsInstalled = new System.Windows.Forms.Label();
            this.DgvModsInstalled = new DarkUI.Controls.DarkDataGridView();
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
            this.MenuGameModsStrip = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemUninstallAllGameMods = new System.Windows.Forms.ToolStripButton();
            this.LabelInstalledGameModsStatus = new System.Windows.Forms.ToolStripLabel();
            this.ContextMenuMods.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.SectionModsInstallFilePaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).BeginInit();
            this.SectionArchiveInformation.SuspendLayout();
            this.PanelModsInstallationPaths.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.MenuStatusStrip.SuspendLayout();
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
            this.ContextMenuModsInstallFiles,
            this.ContextMenuModsUninstallFiles,
            this.ContextMenuModsDownloadArchive,
            this.ContextMenuModsSeperator1,
            this.ContextMenuModsExtractInformation,
            this.ContextMenuModsSeperator0,
            this.ContextMenuModsReportOnGitHub});
            this.ContextMenuMods.Name = "ContextMenuConsole";
            this.ContextMenuMods.Size = new System.Drawing.Size(200, 128);
            // 
            // ContextMenuModsInstallFiles
            // 
            this.ContextMenuModsInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsInstallFiles.Name = "ContextMenuModsInstallFiles";
            this.ContextMenuModsInstallFiles.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsInstallFiles.Text = "Install Files...";
            this.ContextMenuModsInstallFiles.Click += new System.EventHandler(this.ContextMenuModsInstallToConsole_Click);
            // 
            // ContextMenuModsUninstallFiles
            // 
            this.ContextMenuModsUninstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsUninstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsUninstallFiles.Name = "ContextMenuModsUninstallFiles";
            this.ContextMenuModsUninstallFiles.Size = new System.Drawing.Size(199, 22);
            this.ContextMenuModsUninstallFiles.Text = "Uninstall Files...";
            this.ContextMenuModsUninstallFiles.Click += new System.EventHandler(this.ContextMenuModsUninstallFromConsole_Click);
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
            // LabelHeaderNameNo
            // 
            this.LabelHeaderNameNo.AutoEllipsis = true;
            this.LabelHeaderNameNo.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderNameNo, true);
            this.LabelHeaderNameNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelHeaderNameNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderNameNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderNameNo.Location = new System.Drawing.Point(50, 33);
            this.LabelHeaderNameNo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderNameNo.MaximumSize = new System.Drawing.Size(300, 15);
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
            this.SectionModsInstallFilePaths.Controls.Add(this.LabelHeaderInstallationFiles);
            this.SectionModsInstallFilePaths.Controls.Add(this.DgvInstallPaths);
            this.SectionModsInstallFilePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionModsInstallFilePaths.Location = new System.Drawing.Point(0, 11);
            this.SectionModsInstallFilePaths.Margin = new System.Windows.Forms.Padding(0);
            this.SectionModsInstallFilePaths.Name = "SectionModsInstallFilePaths";
            this.SectionModsInstallFilePaths.SectionHeader = " ";
            this.SectionModsInstallFilePaths.Size = new System.Drawing.Size(375, 125);
            this.SectionModsInstallFilePaths.TabIndex = 26;
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
            this.LabelHeaderInstallationFiles.Text = "INSTALLATION FILES";
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
            this.ColumnInstallationPath});
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
            // ColumnInstallationPath
            // 
            this.ColumnInstallationPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInstallationPath.HeaderText = "Install File Path";
            this.ColumnInstallationPath.MinimumWidth = 6;
            this.ColumnInstallationPath.Name = "ColumnInstallationPath";
            this.ColumnInstallationPath.ReadOnly = true;
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
            this.ToolItemInstallMod,
            this.ToolItemUninstallMod,
            this.ToolItemDownloadMod,
            this.ToolItemFavoriteMod});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 706);
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
            this.ToolItemInstallMod.Image = global::ModioX.Properties.Resources.install;
            this.ToolItemInstallMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemInstallMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemInstallMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemInstallMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemInstallMod.Name = "ToolItemInstallMod";
            this.ToolItemInstallMod.Size = new System.Drawing.Size(66, 26);
            this.ToolItemInstallMod.Text = "Install";
            this.ToolItemInstallMod.ToolTipText = "Install to Console";
            this.ToolItemInstallMod.Click += new System.EventHandler(this.ToolStripInstallFiles_Click);
            // 
            // ToolItemUninstallMod
            // 
            this.ToolItemUninstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemUninstallMod.Enabled = false;
            this.ToolItemUninstallMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemUninstallMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemUninstallMod.Image = global::ModioX.Properties.Resources.uninstall;
            this.ToolItemUninstallMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstallMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstallMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstallMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstallMod.Name = "ToolItemUninstallMod";
            this.ToolItemUninstallMod.Size = new System.Drawing.Size(81, 26);
            this.ToolItemUninstallMod.Text = "Uninstall";
            this.ToolItemUninstallMod.ToolTipText = "Uninstall from Console";
            this.ToolItemUninstallMod.Click += new System.EventHandler(this.ToolStripUninstallFiles_Click);
            // 
            // ToolItemDownloadMod
            // 
            this.ToolItemDownloadMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDownloadMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDownloadMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDownloadMod.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemDownloadMod.Image")));
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
            this.ToolItemFavoriteMod.Image = global::ModioX.Properties.Resources.heart_outline;
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
            this.MenuStrip.Size = new System.Drawing.Size(1584, 29);
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
            this.MenuItemToolsGameBackupFiles,
            this.MenuItemToolsSeperator0,
            this.MenuItemToolsFileManager});
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
            this.MenuItemToolsGameBackupFiles.Size = new System.Drawing.Size(173, 22);
            this.MenuItemToolsGameBackupFiles.Text = "Game Backup Files";
            this.MenuItemToolsGameBackupFiles.Click += new System.EventHandler(this.MenuItemToolsBackupFileManager_Click);
            // 
            // MenuItemToolsSeperator0
            // 
            this.MenuItemToolsSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemToolsSeperator0.Name = "MenuItemToolsSeperator0";
            this.MenuItemToolsSeperator0.Size = new System.Drawing.Size(170, 6);
            // 
            // MenuItemToolsFileManager
            // 
            this.MenuItemToolsFileManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsFileManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsFileManager.Name = "MenuItemToolsFileManager";
            this.MenuItemToolsFileManager.Size = new System.Drawing.Size(173, 22);
            this.MenuItemToolsFileManager.Text = "File Manager";
            this.MenuItemToolsFileManager.Click += new System.EventHandler(this.MenuItemToolsFileManager_Click);
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
            this.MenuItemBrewologyStore.Click += new System.EventHandler(this.MenuStripResourcesBrewology_Click);
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
            this.MenuStripResourcesGamesNoPsv2.Text = "NoPayStation v3.0";
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
            this.MenuItemApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemApplications.Name = "MenuItemApplications";
            this.MenuItemApplications.Size = new System.Drawing.Size(98, 19);
            this.MenuItemApplications.Text = "APPLICATIONS";
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingsShowModID,
            this.MenuItemSettingsAutoDetectGameRegions,
            this.MenuItemSettingsRememberGameRegions,
            this.MenuItemSettingsAlwaysDownloadInstallFiles,
            this.MenuItemSeperator2,
            this.MenuItemSettingsEditGameRegions,
            this.MenuItemSettingsEditExternalApplications,
            this.MenuItemSeperator5,
            this.MenuItemSettingsAddNewConsole,
            this.MenuItemSeperator6,
            this.MenuItemSettingsResetAllSettings});
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
            // MenuItemSettingsAutoDetectGameRegions
            // 
            this.MenuItemSettingsAutoDetectGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAutoDetectGameRegions.CheckOnClick = true;
            this.MenuItemSettingsAutoDetectGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAutoDetectGameRegions.Name = "MenuItemSettingsAutoDetectGameRegions";
            this.MenuItemSettingsAutoDetectGameRegions.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsAutoDetectGameRegions.Text = "Detect Game Regions";
            this.MenuItemSettingsAutoDetectGameRegions.Click += new System.EventHandler(this.MenuItemSettingsAutoDetectGameRegions_Click);
            // 
            // MenuItemSettingsRememberGameRegions
            // 
            this.MenuItemSettingsRememberGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsRememberGameRegions.CheckOnClick = true;
            this.MenuItemSettingsRememberGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsRememberGameRegions.Name = "MenuItemSettingsRememberGameRegions";
            this.MenuItemSettingsRememberGameRegions.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsRememberGameRegions.Text = "Remember Game Regions";
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
            // MenuItemSettingsEditGameRegions
            // 
            this.MenuItemSettingsEditGameRegions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsEditGameRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsEditGameRegions.Name = "MenuItemSettingsEditGameRegions";
            this.MenuItemSettingsEditGameRegions.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsEditGameRegions.Text = "Edit Game Regions...";
            this.MenuItemSettingsEditGameRegions.Click += new System.EventHandler(this.MenuItemSettingsEditGameRegions_Click);
            // 
            // MenuItemSettingsEditExternalApplications
            // 
            this.MenuItemSettingsEditExternalApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsEditExternalApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsEditExternalApplications.Name = "MenuItemSettingsEditExternalApplications";
            this.MenuItemSettingsEditExternalApplications.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsEditExternalApplications.Text = "Edit Applications...";
            this.MenuItemSettingsEditExternalApplications.Click += new System.EventHandler(this.MenuItemSettingsEditExternalApplications_Click);
            // 
            // MenuItemSeperator5
            // 
            this.MenuItemSeperator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator5.Name = "MenuItemSeperator5";
            this.MenuItemSeperator5.Size = new System.Drawing.Size(225, 6);
            // 
            // MenuItemSettingsAddNewConsole
            // 
            this.MenuItemSettingsAddNewConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAddNewConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAddNewConsole.Name = "MenuItemSettingsAddNewConsole";
            this.MenuItemSettingsAddNewConsole.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsAddNewConsole.Text = "Add New Console...";
            this.MenuItemSettingsAddNewConsole.Click += new System.EventHandler(this.MenuItemSettingsAddNewConsole_Click);
            // 
            // MenuItemSeperator6
            // 
            this.MenuItemSeperator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator6.Name = "MenuItemSeperator6";
            this.MenuItemSeperator6.Size = new System.Drawing.Size(225, 6);
            // 
            // MenuItemSettingsResetAllSettings
            // 
            this.MenuItemSettingsResetAllSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsResetAllSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsResetAllSettings.Name = "MenuItemSettingsResetAllSettings";
            this.MenuItemSettingsResetAllSettings.Size = new System.Drawing.Size(228, 22);
            this.MenuItemSettingsResetAllSettings.Text = "Reset All Settings";
            this.MenuItemSettingsResetAllSettings.Click += new System.EventHandler(this.MenuItemSettingsResetAllOptions_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportIssue,
            this.MenuItemSourceCode,
            this.MenuItemHelpDiscordServer,
            this.MenuItemSeperator3,
            this.MenuItemMoreInformation,
            this.MenuItemSeperator4,
            this.MenuStripHelpCheckForUpdates,
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
            this.MenuItemReportIssue.Size = new System.Drawing.Size(207, 22);
            this.MenuItemReportIssue.Text = "Report Issue/Suggestions";
            this.MenuItemReportIssue.Click += new System.EventHandler(this.MenuStripHelpReportBugSuggestions_Click);
            // 
            // MenuItemSourceCode
            // 
            this.MenuItemSourceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSourceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSourceCode.Name = "MenuItemSourceCode";
            this.MenuItemSourceCode.Size = new System.Drawing.Size(207, 22);
            this.MenuItemSourceCode.Text = "View Source Code";
            this.MenuItemSourceCode.Click += new System.EventHandler(this.MenuStripHelpSourceCode_Click);
            // 
            // MenuItemHelpDiscordServer
            // 
            this.MenuItemHelpDiscordServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelpDiscordServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelpDiscordServer.Name = "MenuItemHelpDiscordServer";
            this.MenuItemHelpDiscordServer.Size = new System.Drawing.Size(207, 22);
            this.MenuItemHelpDiscordServer.Text = "Discord Server";
            this.MenuItemHelpDiscordServer.Click += new System.EventHandler(this.MenuItemHelpDiscordServer_Click);
            // 
            // MenuItemSeperator3
            // 
            this.MenuItemSeperator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator3.Name = "MenuItemSeperator3";
            this.MenuItemSeperator3.Size = new System.Drawing.Size(204, 6);
            // 
            // MenuItemMoreInformation
            // 
            this.MenuItemMoreInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemMoreInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemMoreInformation.Name = "MenuItemMoreInformation";
            this.MenuItemMoreInformation.Size = new System.Drawing.Size(207, 22);
            this.MenuItemMoreInformation.Text = "More Information";
            this.MenuItemMoreInformation.Click += new System.EventHandler(this.MenuItemMoreInformation_Click);
            // 
            // MenuItemSeperator4
            // 
            this.MenuItemSeperator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator4.Name = "MenuItemSeperator4";
            this.MenuItemSeperator4.Size = new System.Drawing.Size(204, 6);
            // 
            // MenuStripHelpCheckForUpdates
            // 
            this.MenuStripHelpCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelpCheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpCheckForUpdates.Name = "MenuStripHelpCheckForUpdates";
            this.MenuStripHelpCheckForUpdates.Size = new System.Drawing.Size(207, 22);
            this.MenuStripHelpCheckForUpdates.Text = "Check for Update";
            this.MenuStripHelpCheckForUpdates.Click += new System.EventHandler(this.MenuStripHelpCheckForUpdates_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(207, 22);
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
            this.MenuStatusStrip.Location = new System.Drawing.Point(0, 789);
            this.MenuStatusStrip.Name = "MenuStatusStrip";
            this.MenuStatusStrip.Padding = new System.Windows.Forms.Padding(11, 0, 8, 5);
            this.MenuStatusStrip.Size = new System.Drawing.Size(1584, 32);
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
            this.LabelNoModsFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsFound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelNoModsFound.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsFound.Location = new System.Drawing.Point(398, 182);
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
            this.ColumnModsFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsFirmware.HeaderText = "System Type";
            this.ColumnModsFirmware.MinimumWidth = 6;
            this.ColumnModsFirmware.Name = "ColumnModsFirmware";
            this.ColumnModsFirmware.ReadOnly = true;
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsType.HeaderText = "Mod Type";
            this.ColumnModsType.MinimumWidth = 6;
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            this.ColumnModsType.Width = 110;
            // 
            // ColumnModsRegion
            // 
            this.ColumnModsRegion.HeaderText = "Regions";
            this.ColumnModsRegion.MinimumWidth = 6;
            this.ColumnModsRegion.Name = "ColumnModsRegion";
            this.ColumnModsRegion.ReadOnly = true;
            this.ColumnModsRegion.Width = 86;
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
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.SectionInstalledGameMods.Controls.Add(this.DgvModsInstalled);
            this.SectionInstalledGameMods.Controls.Add(this.PanelModsInstalledHeader);
            this.SectionInstalledGameMods.Controls.Add(this.MenuGameModsStrip);
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
            this.LabelNoModsInstalled.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsInstalled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelNoModsInstalled.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsInstalled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsInstalled.Location = new System.Drawing.Point(389, 107);
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
            this.ColumnModsInstalledId,
            this.ColumnModsInstalledGameTitle,
            this.ColumnModsInstalledRegion,
            this.ColumnModsInstalledModName,
            this.ColumnModsInstalledModType,
            this.ColumnModsInstalledVersion,
            this.ColumnModsInstalledNoOfFiles,
            this.ColumnModsInstalledDateTime,
            this.ColumnModsInstalledUninstall});
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
            this.DgvModsInstalled.Size = new System.Drawing.Size(899, 145);
            this.DgvModsInstalled.TabIndex = 7;
            this.DgvModsInstalled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModsInstalled_CellClick);
            this.DgvModsInstalled.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvModsInstalled.SelectionChanged += new System.EventHandler(this.DgvModsInstalled_SelectionChanged);
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
            this.ColumnModsInstalledRegion.HeaderText = "Region";
            this.ColumnModsInstalledRegion.MinimumWidth = 6;
            this.ColumnModsInstalledRegion.Name = "ColumnModsInstalledRegion";
            this.ColumnModsInstalledRegion.ReadOnly = true;
            this.ColumnModsInstalledRegion.Width = 74;
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
            this.ColumnModsInstalledModType.HeaderText = "Mod Type";
            this.ColumnModsInstalledModType.MinimumWidth = 6;
            this.ColumnModsInstalledModType.Name = "ColumnModsInstalledModType";
            this.ColumnModsInstalledModType.ReadOnly = true;
            this.ColumnModsInstalledModType.Width = 86;
            // 
            // ColumnModsInstalledVersion
            // 
            this.ColumnModsInstalledVersion.HeaderText = "Version";
            this.ColumnModsInstalledVersion.MinimumWidth = 6;
            this.ColumnModsInstalledVersion.Name = "ColumnModsInstalledVersion";
            this.ColumnModsInstalledVersion.ReadOnly = true;
            this.ColumnModsInstalledVersion.Width = 68;
            // 
            // ColumnModsInstalledNoOfFiles
            // 
            this.ColumnModsInstalledNoOfFiles.HeaderText = "# Files";
            this.ColumnModsInstalledNoOfFiles.MinimumWidth = 6;
            this.ColumnModsInstalledNoOfFiles.Name = "ColumnModsInstalledNoOfFiles";
            this.ColumnModsInstalledNoOfFiles.ReadOnly = true;
            this.ColumnModsInstalledNoOfFiles.Width = 60;
            // 
            // ColumnModsInstalledDateTime
            // 
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
            this.MenuGameModsStrip.Size = new System.Drawing.Size(899, 36);
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
            this.ToolItemUninstallAllGameMods.Image = global::ModioX.Properties.Resources.uninstall;
            this.ToolItemUninstallAllGameMods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstallAllGameMods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstallAllGameMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstallAllGameMods.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstallAllGameMods.Name = "ToolItemUninstallAllGameMods";
            this.ToolItemUninstallAllGameMods.Size = new System.Drawing.Size(98, 26);
            this.ToolItemUninstallAllGameMods.Text = "Uninstall All";
            this.ToolItemUninstallAllGameMods.ToolTipText = "Uninstall All Mods from Console";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1584, 821);
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
            this.MinimumSize = new System.Drawing.Size(1600, 860);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).EndInit();
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.PanelModsInstallationPaths.ResumeLayout(false);
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MenuStatusStrip.ResumeLayout(false);
            this.MenuStatusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsInstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsUninstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsDownloadArchive;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeperator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsExtractInformation;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeperator0;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsReportOnGitHub;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReddit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedditPS3Homebrew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedditPS3Hacks;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools;
        private System.Windows.Forms.ToolStripButton ToolItemInstallMod;
        private System.Windows.Forms.ToolStripButton ToolItemDownloadMod;
        private DarkUI.Controls.DarkSectionPanel SectionModsLibrary;
        private DarkUI.Controls.DarkSectionPanel SectionGames;
        private DarkUI.Controls.DarkComboBox ComboBoxSystemType;
        private DarkUI.Controls.DarkComboBox ComboBoxModType;
        private DarkUI.Controls.DarkDataGridView DgvMods;
        private DarkUI.Controls.DarkSectionPanel SectionModsInstallFilePaths;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsGameBackupFiles;
        private System.Windows.Forms.ToolStripButton ToolItemUninstallMod;
        private System.Windows.Forms.ToolStripButton ToolItemFavoriteMod;
        private System.Windows.Forms.Panel PanelModsInstallationPaths;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectOfflineMode;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRefreshData;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRequestMod;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConnectPS3Console;
        private DarkUI.Controls.DarkDataGridView DgvInstallPaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstallationPath;
        private System.Windows.Forms.ToolStripSeparator MenuItemToolsSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsFileManager;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAddNewConsole;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsShowModID;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAutoDetectGameRegions;
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
        private DarkUI.Controls.DarkTitle LabelHeaderGameMods;
        private DarkUI.Controls.DarkTitle LabelHeaderInstallationFiles;
        private DarkUI.Controls.DarkToolStrip MenuGameModsStrip;
        private System.Windows.Forms.ToolStripButton ToolItemUninstallAllGameMods;
        private System.Windows.Forms.ToolStripLabel LabelInstalledGameModsStatus;
        private System.Windows.Forms.Label LabelHeaderRegion;
        private System.Windows.Forms.Label LabelRegion;
        private DarkUI.Controls.DarkComboBox ComboBoxRegion;
        private System.Windows.Forms.Label LabelSelectRegion;
        private System.Windows.Forms.Label LabelNoModsFound;
        private System.Windows.Forms.Label LabelNoModsInstalled;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMoreInformation;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsRememberGameRegions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsEditGameRegions;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsEditExternalApplications;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsResetAllSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpDiscordServer;
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
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpCheckForUpdates;
        private DarkUI.Controls.DarkTitle LabelTitleHomebrew;
        private System.Windows.Forms.FlowLayoutPanel PanelHomebrew;
    }
}