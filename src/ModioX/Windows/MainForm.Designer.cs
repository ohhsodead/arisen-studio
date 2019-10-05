namespace ModioX.Windows
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.LabelHeaderNameNo = new System.Windows.Forms.Label();
            this.LabelHeaderCategory = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelHeaderType = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelHeaderVersion = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelHeaderAuthor = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelHeaderSubmittedBy = new System.Windows.Forms.Label();
            this.LabelSubmittedBy = new System.Windows.Forms.Label();
            this.LabelHeaderFirmware = new System.Windows.Forms.Label();
            this.LabelFirmware = new System.Windows.Forms.Label();
            this.LabelHeaderConfig = new System.Windows.Forms.Label();
            this.LabelConfig = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.DgvInstallPaths = new System.Windows.Forms.DataGridView();
            this.ColumnModFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonConnectConsole = new DarkUI.Controls.DarkButton();
            this.ScrollBarDetails = new DarkUI.Controls.DarkScrollBar();
            this.SectionArchiveInformation = new DarkUI.Controls.DarkSectionPanel();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripInstallFiles = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDownloadArchive = new System.Windows.Forms.ToolStripButton();
            this.ToolStripFavorite = new System.Windows.Forms.ToolStripButton();
            this.SectionModsInstallFilePaths = new DarkUI.Controls.DarkSectionPanel();
            this.ScrollBarInstallPaths = new DarkUI.Controls.DarkScrollBar();
            this.MenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripApplicationsCCAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesCustomFirmware = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesCustomFirmwareRebug = new System.Windows.Forms.ToolStripMenuItem();
            this.moddingForumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesForumsPsxPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesForumsPsxPlacePs3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesForumsPsxPlaceGameMods = new System.Windows.Forms.ToolStripMenuItem();
            this.pSXSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesForumsPsxScenePs3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesForumsPsxSceneGameMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesNguPs3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesForumsNguPs3Mods = new System.Windows.Forms.ToolStripMenuItem();
            this.se7enSinsPS3ModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pS3ModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theTechGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pS3ModsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesGames = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesGamesPsnDLv3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesGamesNoPsv2 = new System.Windows.Forms.ToolStripMenuItem();
            this.homebrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHomebrewBrewologyStore = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesReddit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesRedditPs3Hacks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripResourcesRedditPs3Homebrew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripContribute = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettingsEditConsoles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripSettingsEnableFileManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettingsAutoDetectGameRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettingsSaveCurrentLocalDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripHelpAboutApp = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStrip1 = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.ButtonRequestMods = new DarkUI.Controls.DarkButton();
            this.SectionFileExplorer = new DarkUI.Controls.DarkSectionPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelLocalFiles = new System.Windows.Forms.Panel();
            this.DgvLocalFiles = new DarkUI.Controls.DarkDataGridView();
            this.ButtonLocalDirectory = new DarkUI.Controls.DarkButton();
            this.TextBoxLocalDirectory = new DarkUI.Controls.DarkTextBox();
            this.darkToolStrip5 = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLocalFiles = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLocalDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalUploadFile = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLocalOpenExplorer = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvConsoleFiles = new DarkUI.Controls.DarkDataGridView();
            this.ButtonNavigateConsoleExplorer = new DarkUI.Controls.DarkButton();
            this.TextBoxConsoleDirectory = new DarkUI.Controls.DarkTextBox();
            this.darkToolStrip6 = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripConsoleFiles = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripConsoleDownloadFile = new System.Windows.Forms.ToolStripButton();
            this.ToolStripConsoleDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.ToolStripConsoleRefresh = new System.Windows.Forms.ToolStripButton();
            this.ContextMenuLocalFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuStripLocalUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripLocalDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleFile = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuConsoleDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuConsoleRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSelectFirmware = new System.Windows.Forms.Label();
            this.ButtonPickRandom = new DarkUI.Controls.DarkButton();
            this.TextBoxSearch = new DarkUI.Controls.DarkTextBox();
            this.ImageSearch = new System.Windows.Forms.PictureBox();
            this.SectionModsLibrary = new DarkUI.Controls.DarkSectionPanel();
            this.DgvMods = new DarkUI.Controls.DarkDataGridView();
            this.ColumnModsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsFirmware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsNoFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsFavorite = new System.Windows.Forms.DataGridViewImageColumn();
            this.SectionGamesCategories = new DarkUI.Controls.DarkSectionPanel();
            this.ListViewGamesCategories = new DarkUI.Controls.DarkListView();
            this.ComboBoxConsole = new DarkUI.Controls.DarkComboBox();
            this.ComboBoxFirmware = new DarkUI.Controls.DarkComboBox();
            this.ComboBoxType = new DarkUI.Controls.DarkComboBox();
            this.ColumnLocalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnLocalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnConsoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsoleDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuMods.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).BeginInit();
            this.SectionArchiveInformation.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.SectionModsInstallFilePaths.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.darkToolStrip1.SuspendLayout();
            this.SectionFileExplorer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelLocalFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalFiles)).BeginInit();
            this.ToolStripLocalFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsoleFiles)).BeginInit();
            this.ToolStripConsoleFiles.SuspendLayout();
            this.ContextMenuLocalFile.SuspendLayout();
            this.ContextMenuConsoleFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSearch)).BeginInit();
            this.SectionModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).BeginInit();
            this.SectionGamesCategories.SuspendLayout();
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
            this.LabelSelectType.Location = new System.Drawing.Point(869, 43);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(34, 15);
            this.LabelSelectType.TabIndex = 1122;
            this.LabelSelectType.Text = "Type:";
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderNameNo);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderCategory);
            this.FlowPanelDetails.Controls.Add(this.LabelCategory);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderType);
            this.FlowPanelDetails.Controls.Add(this.LabelType);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderFirmware);
            this.FlowPanelDetails.Controls.Add(this.LabelFirmware);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderConfig);
            this.FlowPanelDetails.Controls.Add(this.LabelConfig);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(4, 4, 18, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(398, 652);
            this.FlowPanelDetails.TabIndex = 15;
            this.FlowPanelDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowPanelDetails_Scroll);
            // 
            // LabelHeaderNameNo
            // 
            this.LabelHeaderNameNo.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderNameNo, true);
            this.LabelHeaderNameNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderNameNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderNameNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderNameNo.Location = new System.Drawing.Point(4, 7);
            this.LabelHeaderNameNo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelHeaderNameNo.Name = "LabelHeaderNameNo";
            this.LabelHeaderNameNo.Size = new System.Drawing.Size(65, 15);
            this.LabelHeaderNameNo.TabIndex = 2;
            this.LabelHeaderNameNo.Text = "Name (##)";
            // 
            // LabelHeaderCategory
            // 
            this.LabelHeaderCategory.AutoSize = true;
            this.LabelHeaderCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCategory.Location = new System.Drawing.Point(4, 27);
            this.LabelHeaderCategory.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
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
            this.LabelCategory.Location = new System.Drawing.Point(64, 27);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(16, 15);
            this.LabelCategory.TabIndex = 23;
            this.LabelCategory.Text = "...";
            // 
            // LabelHeaderType
            // 
            this.LabelHeaderType.AutoSize = true;
            this.LabelHeaderType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderType.Location = new System.Drawing.Point(4, 47);
            this.LabelHeaderType.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelHeaderType.Name = "LabelHeaderType";
            this.LabelHeaderType.Size = new System.Drawing.Size(36, 15);
            this.LabelHeaderType.TabIndex = 16;
            this.LabelHeaderType.Text = "Type:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelType, true);
            this.LabelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelType.Location = new System.Drawing.Point(40, 47);
            this.LabelType.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
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
            this.LabelHeaderVersion.Location = new System.Drawing.Point(4, 67);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
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
            this.LabelVersion.Location = new System.Drawing.Point(55, 67);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(16, 15);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderAuthor
            // 
            this.LabelHeaderAuthor.AutoSize = true;
            this.LabelHeaderAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderAuthor.Location = new System.Drawing.Point(4, 87);
            this.LabelHeaderAuthor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelHeaderAuthor.Name = "LabelHeaderAuthor";
            this.LabelHeaderAuthor.Size = new System.Drawing.Size(49, 15);
            this.LabelHeaderAuthor.TabIndex = 6;
            this.LabelHeaderAuthor.Text = "Author:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelAuthor, true);
            this.LabelAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAuthor.Location = new System.Drawing.Point(53, 87);
            this.LabelAuthor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
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
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(4, 107);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
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
            this.LabelSubmittedBy.Location = new System.Drawing.Point(90, 107);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(16, 15);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // LabelHeaderFirmware
            // 
            this.LabelHeaderFirmware.AutoSize = true;
            this.LabelHeaderFirmware.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFirmware.Location = new System.Drawing.Point(4, 127);
            this.LabelHeaderFirmware.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelHeaderFirmware.Name = "LabelHeaderFirmware";
            this.LabelHeaderFirmware.Size = new System.Drawing.Size(63, 15);
            this.LabelHeaderFirmware.TabIndex = 20;
            this.LabelHeaderFirmware.Text = "Firmware:";
            // 
            // LabelFirmware
            // 
            this.LabelFirmware.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelFirmware, true);
            this.LabelFirmware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFirmware.Location = new System.Drawing.Point(67, 127);
            this.LabelFirmware.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelFirmware.Name = "LabelFirmware";
            this.LabelFirmware.Size = new System.Drawing.Size(16, 15);
            this.LabelFirmware.TabIndex = 21;
            this.LabelFirmware.Text = "...";
            // 
            // LabelHeaderConfig
            // 
            this.LabelHeaderConfig.AutoSize = true;
            this.LabelHeaderConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderConfig.Location = new System.Drawing.Point(4, 147);
            this.LabelHeaderConfig.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelHeaderConfig.Name = "LabelHeaderConfig";
            this.LabelHeaderConfig.Size = new System.Drawing.Size(78, 15);
            this.LabelHeaderConfig.TabIndex = 9;
            this.LabelHeaderConfig.Text = "Game Mode:";
            // 
            // LabelConfig
            // 
            this.LabelConfig.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConfig, true);
            this.LabelConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConfig.Location = new System.Drawing.Point(82, 147);
            this.LabelConfig.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelConfig.Name = "LabelConfig";
            this.LabelConfig.Size = new System.Drawing.Size(16, 15);
            this.LabelConfig.TabIndex = 10;
            this.LabelConfig.Text = "...";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(4, 168);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(404, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelDescription.Size = new System.Drawing.Size(16, 25);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            // 
            // DgvInstallPaths
            // 
            this.DgvInstallPaths.AllowUserToAddRows = false;
            this.DgvInstallPaths.AllowUserToDeleteRows = false;
            this.DgvInstallPaths.AllowUserToResizeColumns = false;
            this.DgvInstallPaths.AllowUserToResizeRows = false;
            this.DgvInstallPaths.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DgvInstallPaths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInstallPaths.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvInstallPaths.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInstallPaths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvInstallPaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInstallPaths.ColumnHeadersVisible = false;
            this.DgvInstallPaths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModFilePath});
            this.DgvInstallPaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvInstallPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvInstallPaths.EnableHeadersVisualStyles = false;
            this.DgvInstallPaths.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.DgvInstallPaths.Location = new System.Drawing.Point(1, 25);
            this.DgvInstallPaths.Margin = new System.Windows.Forms.Padding(3, 7, 3, 5);
            this.DgvInstallPaths.MultiSelect = false;
            this.DgvInstallPaths.Name = "DgvInstallPaths";
            this.DgvInstallPaths.ReadOnly = true;
            this.DgvInstallPaths.RowHeadersVisible = false;
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DgvInstallPaths.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DgvInstallPaths.RowTemplate.Height = 24;
            this.DgvInstallPaths.RowTemplate.ReadOnly = true;
            this.DgvInstallPaths.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInstallPaths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvInstallPaths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInstallPaths.ShowCellToolTips = false;
            this.DgvInstallPaths.ShowEditingIcon = false;
            this.DgvInstallPaths.Size = new System.Drawing.Size(380, 72);
            this.DgvInstallPaths.TabIndex = 17;
            this.DgvInstallPaths.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvInstallPaths.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DgvInstallPaths_Scroll);
            // 
            // ColumnModFilePath
            // 
            this.ColumnModFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModFilePath.HeaderText = "Install Paths";
            this.ColumnModFilePath.Name = "ColumnModFilePath";
            this.ColumnModFilePath.ReadOnly = true;
            this.ColumnModFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ButtonConnectConsole
            // 
            this.ButtonConnectConsole.Location = new System.Drawing.Point(229, 39);
            this.ButtonConnectConsole.Name = "ButtonConnectConsole";
            this.ButtonConnectConsole.Size = new System.Drawing.Size(77, 24);
            this.ButtonConnectConsole.TabIndex = 1;
            this.ButtonConnectConsole.Text = "Connect";
            this.ButtonConnectConsole.Click += new System.EventHandler(this.ButtonConnectConsole_Click);
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(1367, 87);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(17, 662);
            this.ScrollBarDetails.TabIndex = 1133;
            this.ScrollBarDetails.Text = "darkScrollBar1";
            this.ScrollBarDetails.ViewSize = 1;
            this.ScrollBarDetails.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarDetails_ValueChanged);
            // 
            // SectionArchiveInformation
            // 
            this.SectionArchiveInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionArchiveInformation.Controls.Add(this.FlowPanelDetails);
            this.SectionArchiveInformation.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionArchiveInformation.Location = new System.Drawing.Point(985, 70);
            this.SectionArchiveInformation.Name = "SectionArchiveInformation";
            this.SectionArchiveInformation.SectionHeader = "Mods Information";
            this.SectionArchiveInformation.Size = new System.Drawing.Size(400, 715);
            this.SectionArchiveInformation.TabIndex = 12;
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
            this.ToolStripInstallFiles,
            this.ToolStripDownloadArchive,
            this.ToolStripFavorite});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 677);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(398, 37);
            this.ToolStripArchiveInformation.TabIndex = 16;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolStripInstallFiles
            // 
            this.ToolStripInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripInstallFiles.Enabled = false;
            this.ToolStripInstallFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripInstallFiles.Image = global::ModioX.Properties.Resources.icons8_upload_22;
            this.ToolStripInstallFiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripInstallFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripInstallFiles.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripInstallFiles.Name = "ToolStripInstallFiles";
            this.ToolStripInstallFiles.Size = new System.Drawing.Size(138, 27);
            this.ToolStripInstallFiles.Text = "Download && Install";
            this.ToolStripInstallFiles.Click += new System.EventHandler(this.ToolStripInstallFiles_Click);
            // 
            // ToolStripDownloadArchive
            // 
            this.ToolStripDownloadArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripDownloadArchive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripDownloadArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripDownloadArchive.Image = global::ModioX.Properties.Resources.icons8_download_from_the_cloud_22;
            this.ToolStripDownloadArchive.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripDownloadArchive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripDownloadArchive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDownloadArchive.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripDownloadArchive.Name = "ToolStripDownloadArchive";
            this.ToolStripDownloadArchive.Size = new System.Drawing.Size(135, 27);
            this.ToolStripDownloadArchive.Text = "Download Archive";
            this.ToolStripDownloadArchive.Click += new System.EventHandler(this.ToolStripDownloadArchive_Click);
            // 
            // ToolStripFavorite
            // 
            this.ToolStripFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripFavorite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripFavorite.Image = global::ModioX.Properties.Resources.icons8_heart_outline_22;
            this.ToolStripFavorite.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripFavorite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripFavorite.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripFavorite.Name = "ToolStripFavorite";
            this.ToolStripFavorite.Size = new System.Drawing.Size(79, 27);
            this.ToolStripFavorite.Text = "Favorite";
            this.ToolStripFavorite.Click += new System.EventHandler(this.ToolStripFavorite_Click);
            // 
            // SectionModsInstallFilePaths
            // 
            this.SectionModsInstallFilePaths.Controls.Add(this.ScrollBarInstallPaths);
            this.SectionModsInstallFilePaths.Controls.Add(this.DgvInstallPaths);
            this.SectionModsInstallFilePaths.Location = new System.Drawing.Point(981, 617);
            this.SectionModsInstallFilePaths.Name = "SectionModsInstallFilePaths";
            this.SectionModsInstallFilePaths.SectionHeader = "Installation File Paths";
            this.SectionModsInstallFilePaths.Size = new System.Drawing.Size(382, 98);
            this.SectionModsInstallFilePaths.TabIndex = 16;
            this.SectionModsInstallFilePaths.Visible = false;
            // 
            // ScrollBarInstallPaths
            // 
            this.ScrollBarInstallPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarInstallPaths.Location = new System.Drawing.Point(364, 34);
            this.ScrollBarInstallPaths.Name = "ScrollBarInstallPaths";
            this.ScrollBarInstallPaths.Size = new System.Drawing.Size(17, 63);
            this.ScrollBarInstallPaths.TabIndex = 1144;
            this.ScrollBarInstallPaths.Text = "darkScrollBar3";
            this.ScrollBarInstallPaths.ViewSize = 40;
            this.ScrollBarInstallPaths.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarInstallPaths_ValueChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripApplications,
            this.resourcesToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.MenuStripContribute,
            this.MenuStripSettings,
            this.MenuStripHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(6, 9, 3, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1396, 30);
            this.MenuStrip.TabIndex = 1140;
            this.MenuStrip.Text = "darkMenuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileRefreshData,
            this.MenuStripFileSeparator0,
            this.MenuStripFileExit});
            this.MenuStripFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(37, 19);
            this.MenuStripFile.Text = "File";
            // 
            // MenuStripFileRefreshData
            // 
            this.MenuStripFileRefreshData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileRefreshData.Name = "MenuStripFileRefreshData";
            this.MenuStripFileRefreshData.Size = new System.Drawing.Size(140, 22);
            this.MenuStripFileRefreshData.Text = "Refresh Data";
            this.MenuStripFileRefreshData.Click += new System.EventHandler(this.MenuStripFileRefreshData_Click);
            // 
            // MenuStripFileSeparator0
            // 
            this.MenuStripFileSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStripFileSeparator0.Name = "MenuStripFileSeparator0";
            this.MenuStripFileSeparator0.Size = new System.Drawing.Size(137, 6);
            // 
            // MenuStripFileExit
            // 
            this.MenuStripFileExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileExit.Name = "MenuStripFileExit";
            this.MenuStripFileExit.Size = new System.Drawing.Size(140, 22);
            this.MenuStripFileExit.Text = "Exit";
            this.MenuStripFileExit.Click += new System.EventHandler(this.MenuStripFileExit_Click);
            // 
            // MenuStripApplications
            // 
            this.MenuStripApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripApplicationsCCAPI});
            this.MenuStripApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripApplications.Name = "MenuStripApplications";
            this.MenuStripApplications.Size = new System.Drawing.Size(85, 19);
            this.MenuStripApplications.Text = "Applications";
            // 
            // MenuStripApplicationsCCAPI
            // 
            this.MenuStripApplicationsCCAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripApplicationsCCAPI.Name = "MenuStripApplicationsCCAPI";
            this.MenuStripApplicationsCCAPI.Size = new System.Drawing.Size(204, 22);
            this.MenuStripApplicationsCCAPI.Text = "Console Manager CCAPI";
            this.MenuStripApplicationsCCAPI.Click += new System.EventHandler(this.MenuStripApplicationsCCAPI_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesCustomFirmware,
            this.moddingForumsToolStripMenuItem,
            this.MenuStripResourcesGames,
            this.homebrewToolStripMenuItem,
            this.MenuStripResourcesReddit});
            this.resourcesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // MenuStripResourcesCustomFirmware
            // 
            this.MenuStripResourcesCustomFirmware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesCustomFirmwareRebug});
            this.MenuStripResourcesCustomFirmware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesCustomFirmware.Name = "MenuStripResourcesCustomFirmware";
            this.MenuStripResourcesCustomFirmware.Size = new System.Drawing.Size(168, 22);
            this.MenuStripResourcesCustomFirmware.Text = "Custom Firmware";
            // 
            // MenuStripResourcesCustomFirmwareRebug
            // 
            this.MenuStripResourcesCustomFirmwareRebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesCustomFirmwareRebug.Name = "MenuStripResourcesCustomFirmwareRebug";
            this.MenuStripResourcesCustomFirmwareRebug.Size = new System.Drawing.Size(108, 22);
            this.MenuStripResourcesCustomFirmwareRebug.Text = "Rebug";
            this.MenuStripResourcesCustomFirmwareRebug.Click += new System.EventHandler(this.MenuStripResourcesCustomFirmwareRebug_Click);
            // 
            // moddingForumsToolStripMenuItem
            // 
            this.moddingForumsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesForumsPsxPlace,
            this.pSXSceneToolStripMenuItem,
            this.MenuStripResourcesNguPs3Mods,
            this.se7enSinsPS3ModsToolStripMenuItem,
            this.theTechGameToolStripMenuItem});
            this.moddingForumsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.moddingForumsToolStripMenuItem.Name = "moddingForumsToolStripMenuItem";
            this.moddingForumsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.moddingForumsToolStripMenuItem.Text = "Modding Forums";
            // 
            // MenuStripResourcesForumsPsxPlace
            // 
            this.MenuStripResourcesForumsPsxPlace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesForumsPsxPlacePs3Mods,
            this.MenuStripResourcesForumsPsxPlaceGameMods});
            this.MenuStripResourcesForumsPsxPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesForumsPsxPlace.Name = "MenuStripResourcesForumsPsxPlace";
            this.MenuStripResourcesForumsPsxPlace.Size = new System.Drawing.Size(158, 22);
            this.MenuStripResourcesForumsPsxPlace.Text = "PSX Place";
            // 
            // MenuStripResourcesForumsPsxPlacePs3Mods
            // 
            this.MenuStripResourcesForumsPsxPlacePs3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesForumsPsxPlacePs3Mods.Name = "MenuStripResourcesForumsPsxPlacePs3Mods";
            this.MenuStripResourcesForumsPsxPlacePs3Mods.Size = new System.Drawing.Size(143, 22);
            this.MenuStripResourcesForumsPsxPlacePs3Mods.Text = "PS3 Mods";
            this.MenuStripResourcesForumsPsxPlacePs3Mods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxPlacePs3Mods_Click);
            // 
            // MenuStripResourcesForumsPsxPlaceGameMods
            // 
            this.MenuStripResourcesForumsPsxPlaceGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesForumsPsxPlaceGameMods.Name = "MenuStripResourcesForumsPsxPlaceGameMods";
            this.MenuStripResourcesForumsPsxPlaceGameMods.Size = new System.Drawing.Size(143, 22);
            this.MenuStripResourcesForumsPsxPlaceGameMods.Text = "Games Mods";
            this.MenuStripResourcesForumsPsxPlaceGameMods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxPlaceGameMods_Click);
            // 
            // pSXSceneToolStripMenuItem
            // 
            this.pSXSceneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesForumsPsxScenePs3Mods,
            this.MenuStripResourcesForumsPsxSceneGameMods});
            this.pSXSceneToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pSXSceneToolStripMenuItem.Name = "pSXSceneToolStripMenuItem";
            this.pSXSceneToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pSXSceneToolStripMenuItem.Text = "PSX Scene";
            // 
            // MenuStripResourcesForumsPsxScenePs3Mods
            // 
            this.MenuStripResourcesForumsPsxScenePs3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesForumsPsxScenePs3Mods.Name = "MenuStripResourcesForumsPsxScenePs3Mods";
            this.MenuStripResourcesForumsPsxScenePs3Mods.Size = new System.Drawing.Size(138, 22);
            this.MenuStripResourcesForumsPsxScenePs3Mods.Text = "PS3 Mods";
            this.MenuStripResourcesForumsPsxScenePs3Mods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxScenePs3Mods_Click);
            // 
            // MenuStripResourcesForumsPsxSceneGameMods
            // 
            this.MenuStripResourcesForumsPsxSceneGameMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesForumsPsxSceneGameMods.Name = "MenuStripResourcesForumsPsxSceneGameMods";
            this.MenuStripResourcesForumsPsxSceneGameMods.Size = new System.Drawing.Size(138, 22);
            this.MenuStripResourcesForumsPsxSceneGameMods.Text = "Game Mods";
            this.MenuStripResourcesForumsPsxSceneGameMods.Click += new System.EventHandler(this.MenuStripResourcesForumsPsxSceneGameMods_Click);
            // 
            // MenuStripResourcesNguPs3Mods
            // 
            this.MenuStripResourcesNguPs3Mods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesForumsNguPs3Mods});
            this.MenuStripResourcesNguPs3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesNguPs3Mods.Name = "MenuStripResourcesNguPs3Mods";
            this.MenuStripResourcesNguPs3Mods.Size = new System.Drawing.Size(158, 22);
            this.MenuStripResourcesNguPs3Mods.Text = "NextGenUpdate";
            // 
            // MenuStripResourcesForumsNguPs3Mods
            // 
            this.MenuStripResourcesForumsNguPs3Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesForumsNguPs3Mods.Name = "MenuStripResourcesForumsNguPs3Mods";
            this.MenuStripResourcesForumsNguPs3Mods.Size = new System.Drawing.Size(126, 22);
            this.MenuStripResourcesForumsNguPs3Mods.Text = "PS3 Mods";
            this.MenuStripResourcesForumsNguPs3Mods.Click += new System.EventHandler(this.MenuStripResourcesForumsNguPs3Mods_Click);
            // 
            // se7enSinsPS3ModsToolStripMenuItem
            // 
            this.se7enSinsPS3ModsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pS3ModsToolStripMenuItem,
            this.gameModsToolStripMenuItem});
            this.se7enSinsPS3ModsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.se7enSinsPS3ModsToolStripMenuItem.Name = "se7enSinsPS3ModsToolStripMenuItem";
            this.se7enSinsPS3ModsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.se7enSinsPS3ModsToolStripMenuItem.Text = "Se7enSins";
            // 
            // pS3ModsToolStripMenuItem
            // 
            this.pS3ModsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pS3ModsToolStripMenuItem.Name = "pS3ModsToolStripMenuItem";
            this.pS3ModsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pS3ModsToolStripMenuItem.Text = "PS3 Mods";
            this.pS3ModsToolStripMenuItem.Click += new System.EventHandler(this.PS3ModsToolStripMenuItem_Click);
            // 
            // gameModsToolStripMenuItem
            // 
            this.gameModsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gameModsToolStripMenuItem.Name = "gameModsToolStripMenuItem";
            this.gameModsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gameModsToolStripMenuItem.Text = "Game Mods";
            this.gameModsToolStripMenuItem.Click += new System.EventHandler(this.GameModsToolStripMenuItem_Click);
            // 
            // theTechGameToolStripMenuItem
            // 
            this.theTechGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pS3ModsToolStripMenuItem3,
            this.gameModsToolStripMenuItem2});
            this.theTechGameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.theTechGameToolStripMenuItem.Name = "theTechGameToolStripMenuItem";
            this.theTechGameToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.theTechGameToolStripMenuItem.Text = "TheTechGame";
            // 
            // pS3ModsToolStripMenuItem3
            // 
            this.pS3ModsToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pS3ModsToolStripMenuItem3.Name = "pS3ModsToolStripMenuItem3";
            this.pS3ModsToolStripMenuItem3.Size = new System.Drawing.Size(138, 22);
            this.pS3ModsToolStripMenuItem3.Text = "PS3 Mods";
            this.pS3ModsToolStripMenuItem3.Click += new System.EventHandler(this.PS3ModsToolStripMenuItem3_Click);
            // 
            // gameModsToolStripMenuItem2
            // 
            this.gameModsToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gameModsToolStripMenuItem2.Name = "gameModsToolStripMenuItem2";
            this.gameModsToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.gameModsToolStripMenuItem2.Text = "Game Mods";
            this.gameModsToolStripMenuItem2.Click += new System.EventHandler(this.GameModsToolStripMenuItem2_Click);
            // 
            // MenuStripResourcesGames
            // 
            this.MenuStripResourcesGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesGamesPsnDLv3,
            this.MenuStripResourcesGamesNoPsv2});
            this.MenuStripResourcesGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesGames.Name = "MenuStripResourcesGames";
            this.MenuStripResourcesGames.Size = new System.Drawing.Size(168, 22);
            this.MenuStripResourcesGames.Text = "Games";
            // 
            // MenuStripResourcesGamesPsnDLv3
            // 
            this.MenuStripResourcesGamesPsnDLv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesGamesPsnDLv3.Name = "MenuStripResourcesGamesPsnDLv3";
            this.MenuStripResourcesGamesPsnDLv3.Size = new System.Drawing.Size(170, 22);
            this.MenuStripResourcesGamesPsnDLv3.Text = "PSNDLv3";
            this.MenuStripResourcesGamesPsnDLv3.Click += new System.EventHandler(this.MenuStripResourcesGamesPsnDLv3_Click);
            // 
            // MenuStripResourcesGamesNoPsv2
            // 
            this.MenuStripResourcesGamesNoPsv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesGamesNoPsv2.Name = "MenuStripResourcesGamesNoPsv2";
            this.MenuStripResourcesGamesNoPsv2.Size = new System.Drawing.Size(170, 22);
            this.MenuStripResourcesGamesNoPsv2.Text = "NoPayStation v2.0";
            this.MenuStripResourcesGamesNoPsv2.Click += new System.EventHandler(this.MenuStripResourcesGamesNoPsv2_Click);
            // 
            // homebrewToolStripMenuItem
            // 
            this.homebrewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripHomebrewBrewologyStore});
            this.homebrewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.homebrewToolStripMenuItem.Name = "homebrewToolStripMenuItem";
            this.homebrewToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.homebrewToolStripMenuItem.Text = "Homebrew";
            // 
            // MenuStripHomebrewBrewologyStore
            // 
            this.MenuStripHomebrewBrewologyStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHomebrewBrewologyStore.Name = "MenuStripHomebrewBrewologyStore";
            this.MenuStripHomebrewBrewologyStore.Size = new System.Drawing.Size(160, 22);
            this.MenuStripHomebrewBrewologyStore.Text = "Brewology Store";
            this.MenuStripHomebrewBrewologyStore.Click += new System.EventHandler(this.BrewologyToolStripMenuItem_Click);
            // 
            // MenuStripResourcesReddit
            // 
            this.MenuStripResourcesReddit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripResourcesRedditPs3Hacks,
            this.MenuStripResourcesRedditPs3Homebrew});
            this.MenuStripResourcesReddit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesReddit.Name = "MenuStripResourcesReddit";
            this.MenuStripResourcesReddit.Size = new System.Drawing.Size(168, 22);
            this.MenuStripResourcesReddit.Text = "Reddit";
            // 
            // MenuStripResourcesRedditPs3Hacks
            // 
            this.MenuStripResourcesRedditPs3Hacks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesRedditPs3Hacks.Name = "MenuStripResourcesRedditPs3Hacks";
            this.MenuStripResourcesRedditPs3Hacks.Size = new System.Drawing.Size(155, 22);
            this.MenuStripResourcesRedditPs3Hacks.Text = "PS3 Hacks";
            this.MenuStripResourcesRedditPs3Hacks.Click += new System.EventHandler(this.MenuStripResourcesRedditPs3Hacks_Click);
            // 
            // MenuStripResourcesRedditPs3Homebrew
            // 
            this.MenuStripResourcesRedditPs3Homebrew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripResourcesRedditPs3Homebrew.Name = "MenuStripResourcesRedditPs3Homebrew";
            this.MenuStripResourcesRedditPs3Homebrew.Size = new System.Drawing.Size(155, 22);
            this.MenuStripResourcesRedditPs3Homebrew.Text = "PS3 Homebrew";
            this.MenuStripResourcesRedditPs3Homebrew.Click += new System.EventHandler(this.MenuStripResourcesRedditPs3Homebrew_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // MenuStripContribute
            // 
            this.MenuStripContribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripContribute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripContribute.Name = "MenuStripContribute";
            this.MenuStripContribute.Size = new System.Drawing.Size(76, 19);
            this.MenuStripContribute.Text = "Contribute";
            this.MenuStripContribute.Click += new System.EventHandler(this.MenuStripContribute_Click);
            // 
            // MenuStripSettings
            // 
            this.MenuStripSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripSettingsEditConsoles,
            this.toolStripSeparator1,
            this.MenuStripSettingsEnableFileManager,
            this.MenuStripSettingsAutoDetectGameRegion,
            this.MenuStripSettingsSaveCurrentLocalDirectory});
            this.MenuStripSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettings.Name = "MenuStripSettings";
            this.MenuStripSettings.Size = new System.Drawing.Size(61, 19);
            this.MenuStripSettings.Text = "Settings";
            // 
            // MenuStripSettingsEditConsoles
            // 
            this.MenuStripSettingsEditConsoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettingsEditConsoles.Name = "MenuStripSettingsEditConsoles";
            this.MenuStripSettingsEditConsoles.Size = new System.Drawing.Size(223, 22);
            this.MenuStripSettingsEditConsoles.Text = "Edit Consoles...";
            this.MenuStripSettingsEditConsoles.Click += new System.EventHandler(this.MenuStripSettingsEditConsoles_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // MenuStripSettingsEnableFileManager
            // 
            this.MenuStripSettingsEnableFileManager.Checked = true;
            this.MenuStripSettingsEnableFileManager.CheckOnClick = true;
            this.MenuStripSettingsEnableFileManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuStripSettingsEnableFileManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettingsEnableFileManager.Name = "MenuStripSettingsEnableFileManager";
            this.MenuStripSettingsEnableFileManager.Size = new System.Drawing.Size(223, 22);
            this.MenuStripSettingsEnableFileManager.Text = "Enable File Manager";
            this.MenuStripSettingsEnableFileManager.Click += new System.EventHandler(this.MenuStripSettingsEnableFileManager_Click);
            // 
            // MenuStripSettingsAutoDetectGameRegion
            // 
            this.MenuStripSettingsAutoDetectGameRegion.Checked = true;
            this.MenuStripSettingsAutoDetectGameRegion.CheckOnClick = true;
            this.MenuStripSettingsAutoDetectGameRegion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuStripSettingsAutoDetectGameRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettingsAutoDetectGameRegion.Name = "MenuStripSettingsAutoDetectGameRegion";
            this.MenuStripSettingsAutoDetectGameRegion.ShortcutKeyDisplayString = "";
            this.MenuStripSettingsAutoDetectGameRegion.Size = new System.Drawing.Size(223, 22);
            this.MenuStripSettingsAutoDetectGameRegion.Text = "Auto-Detect Game Region";
            this.MenuStripSettingsAutoDetectGameRegion.Click += new System.EventHandler(this.MenuStripSettingsAutoDetectRegion_Click);
            // 
            // MenuStripSettingsSaveCurrentLocalDirectory
            // 
            this.MenuStripSettingsSaveCurrentLocalDirectory.Checked = true;
            this.MenuStripSettingsSaveCurrentLocalDirectory.CheckOnClick = true;
            this.MenuStripSettingsSaveCurrentLocalDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuStripSettingsSaveCurrentLocalDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettingsSaveCurrentLocalDirectory.Name = "MenuStripSettingsSaveCurrentLocalDirectory";
            this.MenuStripSettingsSaveCurrentLocalDirectory.Size = new System.Drawing.Size(223, 22);
            this.MenuStripSettingsSaveCurrentLocalDirectory.Text = "Save Current Local Directory";
            this.MenuStripSettingsSaveCurrentLocalDirectory.Click += new System.EventHandler(this.MenuStripSettingsSaveCurrentLocalDirectory_Click);
            // 
            // MenuStripHelp
            // 
            this.MenuStripHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripHelpSourceCode,
            this.MenuStripHelpReportIssue,
            this.MenuStripHelpSeperator0,
            this.MenuStripHelpAboutApp});
            this.MenuStripHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelp.Name = "MenuStripHelp";
            this.MenuStripHelp.Size = new System.Drawing.Size(44, 19);
            this.MenuStripHelp.Text = "Help";
            // 
            // MenuStripHelpSourceCode
            // 
            this.MenuStripHelpSourceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpSourceCode.Name = "MenuStripHelpSourceCode";
            this.MenuStripHelpSourceCode.Size = new System.Drawing.Size(154, 22);
            this.MenuStripHelpSourceCode.Text = "Source Code";
            this.MenuStripHelpSourceCode.Click += new System.EventHandler(this.MenuStripHelpSourceCode_Click);
            // 
            // MenuStripHelpReportIssue
            // 
            this.MenuStripHelpReportIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpReportIssue.Name = "MenuStripHelpReportIssue";
            this.MenuStripHelpReportIssue.Size = new System.Drawing.Size(154, 22);
            this.MenuStripHelpReportIssue.Text = "Report an Issue";
            this.MenuStripHelpReportIssue.Click += new System.EventHandler(this.MenuStripHelpGitHubIssues_Click);
            // 
            // MenuStripHelpSeperator0
            // 
            this.MenuStripHelpSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStripHelpSeperator0.Name = "MenuStripHelpSeperator0";
            this.MenuStripHelpSeperator0.Size = new System.Drawing.Size(151, 6);
            // 
            // MenuStripHelpAboutApp
            // 
            this.MenuStripHelpAboutApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelpAboutApp.Name = "MenuStripHelpAboutApp";
            this.MenuStripHelpAboutApp.Size = new System.Drawing.Size(154, 22);
            this.MenuStripHelpAboutApp.Text = "About ModioX";
            this.MenuStripHelpAboutApp.Click += new System.EventHandler(this.MenuStripHelpAbout_Click);
            // 
            // darkToolStrip1
            // 
            this.darkToolStrip1.AutoSize = false;
            this.darkToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkToolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.darkToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelConnectedConsole,
            this.ToolStripLabelConsole,
            this.toolStripSeparator3,
            this.ToolStripLabelStatus,
            this.ToolStripLabelStats});
            this.darkToolStrip1.Location = new System.Drawing.Point(0, 792);
            this.darkToolStrip1.Name = "darkToolStrip1";
            this.darkToolStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 6, 7);
            this.darkToolStrip1.Size = new System.Drawing.Size(1396, 30);
            this.darkToolStrip1.TabIndex = 1146;
            this.darkToolStrip1.Text = "darkToolStrip1";
            // 
            // ToolStripLabelConnectedConsole
            // 
            this.ToolStripLabelConnectedConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConnectedConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConnectedConsole.Name = "ToolStripLabelConnectedConsole";
            this.ToolStripLabelConnectedConsole.Size = new System.Drawing.Size(96, 20);
            this.ToolStripLabelConnectedConsole.Text = "PS3 Connected  :";
            // 
            // ToolStripLabelConsole
            // 
            this.ToolStripLabelConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsole.Name = "ToolStripLabelConsole";
            this.ToolStripLabelConsole.Size = new System.Drawing.Size(36, 20);
            this.ToolStripLabelConsole.Text = "None";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(85, 20);
            this.ToolStripLabelStatus.Text = "Loading data...";
            // 
            // ToolStripLabelStats
            // 
            this.ToolStripLabelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStats.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.ToolStripLabelStats.Name = "ToolStripLabelStats";
            this.ToolStripLabelStats.Size = new System.Drawing.Size(567, 20);
            this.ToolStripLabelStats.Text = "## Mods for ## Games, ## Game Updates, ## Homebrew Packages, ## Resources && ## A" +
    "wesome Themes";
            // 
            // ButtonRequestMods
            // 
            this.ButtonRequestMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRequestMods.Location = new System.Drawing.Point(1086, 39);
            this.ButtonRequestMods.Name = "ButtonRequestMods";
            this.ButtonRequestMods.Size = new System.Drawing.Size(100, 24);
            this.ButtonRequestMods.TabIndex = 6;
            this.ButtonRequestMods.Text = "Request Mods";
            this.ButtonRequestMods.Click += new System.EventHandler(this.ButtonRequestMods_Click);
            // 
            // SectionFileExplorer
            // 
            this.SectionFileExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionFileExplorer.Controls.Add(this.tableLayoutPanel1);
            this.SectionFileExplorer.Location = new System.Drawing.Point(12, 518);
            this.SectionFileExplorer.Name = "SectionFileExplorer";
            this.SectionFileExplorer.SectionHeader = "File Explorer";
            this.SectionFileExplorer.Size = new System.Drawing.Size(967, 268);
            this.SectionFileExplorer.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PanelLocalFiles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 242);
            this.tableLayoutPanel1.TabIndex = 1156;
            // 
            // PanelLocalFiles
            // 
            this.PanelLocalFiles.Controls.Add(this.DgvLocalFiles);
            this.PanelLocalFiles.Controls.Add(this.ButtonLocalDirectory);
            this.PanelLocalFiles.Controls.Add(this.TextBoxLocalDirectory);
            this.PanelLocalFiles.Controls.Add(this.darkToolStrip5);
            this.PanelLocalFiles.Controls.Add(this.ToolStripLocalFiles);
            this.PanelLocalFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLocalFiles.Location = new System.Drawing.Point(3, 3);
            this.PanelLocalFiles.Name = "PanelLocalFiles";
            this.PanelLocalFiles.Size = new System.Drawing.Size(476, 236);
            this.PanelLocalFiles.TabIndex = 1156;
            // 
            // DgvLocalFiles
            // 
            this.DgvLocalFiles.AllowUserToAddRows = false;
            this.DgvLocalFiles.AllowUserToDeleteRows = false;
            this.DgvLocalFiles.AllowUserToDragDropRows = false;
            this.DgvLocalFiles.AllowUserToPasteCells = false;
            this.DgvLocalFiles.ColumnHeadersHeight = 23;
            this.DgvLocalFiles.ColumnHeadersVisible = false;
            this.DgvLocalFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLocalType,
            this.ColumnLocalIcon,
            this.ColumnLocalName,
            this.ColumnLocalSize,
            this.ColumnLocalExtension,
            this.ColumnLocalDateTime});
            this.DgvLocalFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLocalFiles.Location = new System.Drawing.Point(0, 30);
            this.DgvLocalFiles.Margin = new System.Windows.Forms.Padding(6, 5, 3, 5);
            this.DgvLocalFiles.MultiSelect = false;
            this.DgvLocalFiles.Name = "DgvLocalFiles";
            this.DgvLocalFiles.ReadOnly = true;
            this.DgvLocalFiles.RowHeadersWidth = 41;
            this.DgvLocalFiles.RowTemplate.ContextMenuStrip = this.ContextMenuMods;
            this.DgvLocalFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvLocalFiles.RowTemplate.Height = 26;
            this.DgvLocalFiles.RowTemplate.ReadOnly = true;
            this.DgvLocalFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvLocalFiles.Size = new System.Drawing.Size(476, 169);
            this.DgvLocalFiles.TabIndex = 20;
            this.DgvLocalFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLocalFiles_CellClick);
            this.DgvLocalFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            // 
            // ButtonLocalDirectory
            // 
            this.ButtonLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalDirectory.Location = new System.Drawing.Point(431, 3);
            this.ButtonLocalDirectory.Name = "ButtonLocalDirectory";
            this.ButtonLocalDirectory.Size = new System.Drawing.Size(43, 23);
            this.ButtonLocalDirectory.TabIndex = 19;
            this.ButtonLocalDirectory.Text = "...";
            this.ButtonLocalDirectory.Click += new System.EventHandler(this.ButtonLocalDirectory_Click);
            // 
            // TextBoxLocalDirectory
            // 
            this.TextBoxLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalDirectory.Location = new System.Drawing.Point(2, 3);
            this.TextBoxLocalDirectory.Name = "TextBoxLocalDirectory";
            this.TextBoxLocalDirectory.ReadOnly = true;
            this.TextBoxLocalDirectory.Size = new System.Drawing.Size(472, 23);
            this.TextBoxLocalDirectory.TabIndex = 18;
            this.TextBoxLocalDirectory.Text = "\\";
            // 
            // darkToolStrip5
            // 
            this.darkToolStrip5.AutoSize = false;
            this.darkToolStrip5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.darkToolStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkToolStrip5.Location = new System.Drawing.Point(0, 0);
            this.darkToolStrip5.Name = "darkToolStrip5";
            this.darkToolStrip5.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.darkToolStrip5.Size = new System.Drawing.Size(476, 30);
            this.darkToolStrip5.TabIndex = 1157;
            this.darkToolStrip5.Text = "darkToolStrip5";
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
            this.ToolStripLocalDeleteFile,
            this.ToolStripLocalUploadFile,
            this.ToolStripLocalOpenExplorer});
            this.ToolStripLocalFiles.Location = new System.Drawing.Point(0, 199);
            this.ToolStripLocalFiles.Name = "ToolStripLocalFiles";
            this.ToolStripLocalFiles.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.ToolStripLocalFiles.Size = new System.Drawing.Size(476, 37);
            this.ToolStripLocalFiles.TabIndex = 21;
            this.ToolStripLocalFiles.TabStop = true;
            this.ToolStripLocalFiles.Text = "darkToolStrip3";
            // 
            // ToolStripLocalDeleteFile
            // 
            this.ToolStripLocalDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalDeleteFile.Enabled = false;
            this.ToolStripLocalDeleteFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalDeleteFile.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolStripLocalDeleteFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripLocalDeleteFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalDeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalDeleteFile.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripLocalDeleteFile.Name = "ToolStripLocalDeleteFile";
            this.ToolStripLocalDeleteFile.Size = new System.Drawing.Size(71, 27);
            this.ToolStripLocalDeleteFile.Text = "Delete";
            this.ToolStripLocalDeleteFile.Click += new System.EventHandler(this.ToolStripLocalDeleteFile_Click);
            // 
            // ToolStripLocalUploadFile
            // 
            this.ToolStripLocalUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalUploadFile.Enabled = false;
            this.ToolStripLocalUploadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalUploadFile.Image = global::ModioX.Properties.Resources.icons8_upload_22;
            this.ToolStripLocalUploadFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripLocalUploadFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalUploadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalUploadFile.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripLocalUploadFile.Name = "ToolStripLocalUploadFile";
            this.ToolStripLocalUploadFile.Size = new System.Drawing.Size(72, 27);
            this.ToolStripLocalUploadFile.Text = "Upload";
            this.ToolStripLocalUploadFile.Click += new System.EventHandler(this.ToolStripLocalUploadFile_Click);
            // 
            // ToolStripLocalOpenExplorer
            // 
            this.ToolStripLocalOpenExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalOpenExplorer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripLocalOpenExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalOpenExplorer.Image = global::ModioX.Properties.Resources.icons8_opened_folder_22;
            this.ToolStripLocalOpenExplorer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripLocalOpenExplorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLocalOpenExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLocalOpenExplorer.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripLocalOpenExplorer.Name = "ToolStripLocalOpenExplorer";
            this.ToolStripLocalOpenExplorer.Size = new System.Drawing.Size(113, 27);
            this.ToolStripLocalOpenExplorer.Text = "Open Explorer";
            this.ToolStripLocalOpenExplorer.Click += new System.EventHandler(this.ToolStripLocalOpenExplorer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvConsoleFiles);
            this.panel2.Controls.Add(this.ButtonNavigateConsoleExplorer);
            this.panel2.Controls.Add(this.TextBoxConsoleDirectory);
            this.panel2.Controls.Add(this.darkToolStrip6);
            this.panel2.Controls.Add(this.ToolStripConsoleFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(485, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 236);
            this.panel2.TabIndex = 1157;
            // 
            // DgvConsoleFiles
            // 
            this.DgvConsoleFiles.AllowUserToAddRows = false;
            this.DgvConsoleFiles.AllowUserToDeleteRows = false;
            this.DgvConsoleFiles.AllowUserToDragDropRows = false;
            this.DgvConsoleFiles.AllowUserToPasteCells = false;
            this.DgvConsoleFiles.ColumnHeadersHeight = 23;
            this.DgvConsoleFiles.ColumnHeadersVisible = false;
            this.DgvConsoleFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConsoleType,
            this.ColumnConsoleIcon,
            this.ColumnConsoleName,
            this.ColumnConsoleSize,
            this.ColumnConsoleExtension,
            this.ColumnConsoleDateTime});
            this.DgvConsoleFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvConsoleFiles.Location = new System.Drawing.Point(0, 30);
            this.DgvConsoleFiles.Margin = new System.Windows.Forms.Padding(6, 5, 3, 5);
            this.DgvConsoleFiles.MultiSelect = false;
            this.DgvConsoleFiles.Name = "DgvConsoleFiles";
            this.DgvConsoleFiles.ReadOnly = true;
            this.DgvConsoleFiles.RowHeadersWidth = 41;
            this.DgvConsoleFiles.RowTemplate.ContextMenuStrip = this.ContextMenuMods;
            this.DgvConsoleFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvConsoleFiles.RowTemplate.Height = 26;
            this.DgvConsoleFiles.RowTemplate.ReadOnly = true;
            this.DgvConsoleFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvConsoleFiles.Size = new System.Drawing.Size(477, 169);
            this.DgvConsoleFiles.TabIndex = 24;
            this.DgvConsoleFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsoleFiles_CellClick);
            this.DgvConsoleFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            // 
            // ButtonNavigateConsoleExplorer
            // 
            this.ButtonNavigateConsoleExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNavigateConsoleExplorer.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonNavigateConsoleExplorer.Location = new System.Drawing.Point(437, 3);
            this.ButtonNavigateConsoleExplorer.Name = "ButtonNavigateConsoleExplorer";
            this.ButtonNavigateConsoleExplorer.Size = new System.Drawing.Size(39, 23);
            this.ButtonNavigateConsoleExplorer.TabIndex = 23;
            this.ButtonNavigateConsoleExplorer.Text = ">";
            this.ButtonNavigateConsoleExplorer.Click += new System.EventHandler(this.ButtonNavigateConsoleExplorer_Click);
            // 
            // TextBoxConsoleDirectory
            // 
            this.TextBoxConsoleDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsoleDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsoleDirectory.Location = new System.Drawing.Point(2, 3);
            this.TextBoxConsoleDirectory.Name = "TextBoxConsoleDirectory";
            this.TextBoxConsoleDirectory.Size = new System.Drawing.Size(438, 23);
            this.TextBoxConsoleDirectory.TabIndex = 22;
            this.TextBoxConsoleDirectory.Text = "/";
            // 
            // darkToolStrip6
            // 
            this.darkToolStrip6.AutoSize = false;
            this.darkToolStrip6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.darkToolStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkToolStrip6.Location = new System.Drawing.Point(0, 0);
            this.darkToolStrip6.Name = "darkToolStrip6";
            this.darkToolStrip6.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.darkToolStrip6.Size = new System.Drawing.Size(477, 30);
            this.darkToolStrip6.TabIndex = 1155;
            this.darkToolStrip6.Text = "darkToolStrip6";
            // 
            // ToolStripConsoleFiles
            // 
            this.ToolStripConsoleFiles.AutoSize = false;
            this.ToolStripConsoleFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripConsoleFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleFiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripConsoleFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripConsoleFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripConsoleDownloadFile,
            this.ToolStripConsoleDeleteFile,
            this.ToolStripConsoleRefresh});
            this.ToolStripConsoleFiles.Location = new System.Drawing.Point(0, 199);
            this.ToolStripConsoleFiles.Name = "ToolStripConsoleFiles";
            this.ToolStripConsoleFiles.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.ToolStripConsoleFiles.Size = new System.Drawing.Size(477, 37);
            this.ToolStripConsoleFiles.TabIndex = 25;
            this.ToolStripConsoleFiles.TabStop = true;
            this.ToolStripConsoleFiles.Text = "darkToolStrip4";
            // 
            // ToolStripConsoleDownloadFile
            // 
            this.ToolStripConsoleDownloadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleDownloadFile.Enabled = false;
            this.ToolStripConsoleDownloadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleDownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleDownloadFile.Image = global::ModioX.Properties.Resources.icons8_download_22;
            this.ToolStripConsoleDownloadFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripConsoleDownloadFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleDownloadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleDownloadFile.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripConsoleDownloadFile.Name = "ToolStripConsoleDownloadFile";
            this.ToolStripConsoleDownloadFile.Size = new System.Drawing.Size(89, 27);
            this.ToolStripConsoleDownloadFile.Text = "Download";
            this.ToolStripConsoleDownloadFile.Click += new System.EventHandler(this.ToolStripConsoleDownloadFile_Click);
            // 
            // ToolStripConsoleDeleteFile
            // 
            this.ToolStripConsoleDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleDeleteFile.Enabled = false;
            this.ToolStripConsoleDeleteFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleDeleteFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleDeleteFile.Image = global::ModioX.Properties.Resources.icons8_delete_22;
            this.ToolStripConsoleDeleteFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripConsoleDeleteFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleDeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleDeleteFile.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripConsoleDeleteFile.Name = "ToolStripConsoleDeleteFile";
            this.ToolStripConsoleDeleteFile.Size = new System.Drawing.Size(71, 27);
            this.ToolStripConsoleDeleteFile.Text = "Delete";
            this.ToolStripConsoleDeleteFile.Click += new System.EventHandler(this.ToolStripConsoleDeleteFile_Click);
            // 
            // ToolStripConsoleRefresh
            // 
            this.ToolStripConsoleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripConsoleRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripConsoleRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripConsoleRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripConsoleRefresh.Image")));
            this.ToolStripConsoleRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolStripConsoleRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripConsoleRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConsoleRefresh.Margin = new System.Windows.Forms.Padding(0, 9, 4, 1);
            this.ToolStripConsoleRefresh.Name = "ToolStripConsoleRefresh";
            this.ToolStripConsoleRefresh.Size = new System.Drawing.Size(77, 27);
            this.ToolStripConsoleRefresh.Text = "Refresh";
            this.ToolStripConsoleRefresh.Click += new System.EventHandler(this.ToolStripConsoleRefresh_Click);
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
            // LabelSelectFirmware
            // 
            this.LabelSelectFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectFirmware.AutoSize = true;
            this.LabelSelectFirmware.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectFirmware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectFirmware.Location = new System.Drawing.Point(732, 43);
            this.LabelSelectFirmware.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSelectFirmware.Name = "LabelSelectFirmware";
            this.LabelSelectFirmware.Size = new System.Drawing.Size(59, 15);
            this.LabelSelectFirmware.TabIndex = 1156;
            this.LabelSelectFirmware.Text = "Firmware:";
            // 
            // ButtonPickRandom
            // 
            this.ButtonPickRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPickRandom.Location = new System.Drawing.Point(985, 39);
            this.ButtonPickRandom.Name = "ButtonPickRandom";
            this.ButtonPickRandom.Size = new System.Drawing.Size(95, 24);
            this.ButtonPickRandom.TabIndex = 5;
            this.ButtonPickRandom.Text = "Pick Random";
            this.ButtonPickRandom.Click += new System.EventHandler(this.ButtonPickRandom_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.Location = new System.Drawing.Point(493, 39);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(230, 23);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.Text = "Enter text to search...";
            this.TextBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ImageSearch
            // 
            this.ImageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ImageSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImageSearch.Image = global::ModioX.Properties.Resources.icons8_search_16;
            this.ImageSearch.Location = new System.Drawing.Point(703, 42);
            this.ImageSearch.Name = "ImageSearch";
            this.ImageSearch.Size = new System.Drawing.Size(17, 17);
            this.ImageSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageSearch.TabIndex = 1163;
            this.ImageSearch.TabStop = false;
            // 
            // SectionModsLibrary
            // 
            this.SectionModsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionModsLibrary.Controls.Add(this.DgvMods);
            this.SectionModsLibrary.Location = new System.Drawing.Point(285, 70);
            this.SectionModsLibrary.Name = "SectionModsLibrary";
            this.SectionModsLibrary.SectionHeader = "Mods Library";
            this.SectionModsLibrary.Size = new System.Drawing.Size(694, 442);
            this.SectionModsLibrary.TabIndex = 10;
            // 
            // DgvMods
            // 
            this.DgvMods.AllowUserToAddRows = false;
            this.DgvMods.AllowUserToDeleteRows = false;
            this.DgvMods.AllowUserToDragDropRows = false;
            this.DgvMods.AllowUserToPasteCells = false;
            this.DgvMods.ColumnHeadersHeight = 23;
            this.DgvMods.ColumnHeadersVisible = false;
            this.DgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModsId,
            this.ColumnModsName,
            this.ColumnModsFirmware,
            this.ColumnModsType,
            this.ColumnModsVersion,
            this.ColumnModsAuthor,
            this.ColumnModsNoFiles,
            this.ColumnModsDownload,
            this.ColumnModsFavorite});
            this.DgvMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMods.Location = new System.Drawing.Point(1, 25);
            this.DgvMods.MultiSelect = false;
            this.DgvMods.Name = "DgvMods";
            this.DgvMods.ReadOnly = true;
            this.DgvMods.RowHeadersWidth = 41;
            this.DgvMods.RowTemplate.ContextMenuStrip = this.ContextMenuMods;
            this.DgvMods.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMods.RowTemplate.Height = 24;
            this.DgvMods.RowTemplate.ReadOnly = true;
            this.DgvMods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMods.Size = new System.Drawing.Size(692, 416);
            this.DgvMods.TabIndex = 11;
            this.DgvMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMods_CellClick);
            this.DgvMods.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvMods.SelectionChanged += new System.EventHandler(this.DgvMods_SelectionChanged);
            // 
            // ColumnModsId
            // 
            this.ColumnModsId.HeaderText = "Id";
            this.ColumnModsId.Name = "ColumnModsId";
            this.ColumnModsId.ReadOnly = true;
            this.ColumnModsId.Visible = false;
            // 
            // ColumnModsName
            // 
            this.ColumnModsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsName.HeaderText = "Name";
            this.ColumnModsName.Name = "ColumnModsName";
            this.ColumnModsName.ReadOnly = true;
            // 
            // ColumnModsFirmware
            // 
            this.ColumnModsFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsFirmware.HeaderText = "Firmware";
            this.ColumnModsFirmware.Name = "ColumnModsFirmware";
            this.ColumnModsFirmware.ReadOnly = true;
            this.ColumnModsFirmware.Width = 62;
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsType.HeaderText = "Type";
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            this.ColumnModsType.Width = 72;
            // 
            // ColumnModsVersion
            // 
            this.ColumnModsVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsVersion.HeaderText = "Version";
            this.ColumnModsVersion.Name = "ColumnModsVersion";
            this.ColumnModsVersion.ReadOnly = true;
            this.ColumnModsVersion.Width = 68;
            // 
            // ColumnModsAuthor
            // 
            this.ColumnModsAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsAuthor.HeaderText = "Author";
            this.ColumnModsAuthor.MinimumWidth = 122;
            this.ColumnModsAuthor.Name = "ColumnModsAuthor";
            this.ColumnModsAuthor.ReadOnly = true;
            this.ColumnModsAuthor.Width = 122;
            // 
            // ColumnModsNoFiles
            // 
            this.ColumnModsNoFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsNoFiles.HeaderText = "No. Files";
            this.ColumnModsNoFiles.Name = "ColumnModsNoFiles";
            this.ColumnModsNoFiles.ReadOnly = true;
            this.ColumnModsNoFiles.Width = 60;
            // 
            // ColumnModsDownload
            // 
            this.ColumnModsDownload.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsDownload.HeaderText = "Download";
            this.ColumnModsDownload.Image = global::ModioX.Properties.Resources.icons8_download_24;
            this.ColumnModsDownload.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnModsDownload.Name = "ColumnModsDownload";
            this.ColumnModsDownload.ReadOnly = true;
            this.ColumnModsDownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnModsDownload.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnModsDownload.Visible = false;
            this.ColumnModsDownload.Width = 25;
            // 
            // ColumnModsFavorite
            // 
            this.ColumnModsFavorite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnModsFavorite.HeaderText = "Favorite";
            this.ColumnModsFavorite.Image = global::ModioX.Properties.Resources.icons8_download_24;
            this.ColumnModsFavorite.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnModsFavorite.Name = "ColumnModsFavorite";
            this.ColumnModsFavorite.ReadOnly = true;
            this.ColumnModsFavorite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnModsFavorite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnModsFavorite.Visible = false;
            this.ColumnModsFavorite.Width = 28;
            // 
            // SectionGamesCategories
            // 
            this.SectionGamesCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SectionGamesCategories.Controls.Add(this.ListViewGamesCategories);
            this.SectionGamesCategories.Location = new System.Drawing.Point(13, 70);
            this.SectionGamesCategories.Name = "SectionGamesCategories";
            this.SectionGamesCategories.SectionHeader = "Categories";
            this.SectionGamesCategories.Size = new System.Drawing.Size(266, 442);
            this.SectionGamesCategories.TabIndex = 8;
            // 
            // ListViewGamesCategories
            // 
            this.ListViewGamesCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewGamesCategories.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ListViewGamesCategories.HideScrollBars = false;
            this.ListViewGamesCategories.ItemHeight = 24;
            this.ListViewGamesCategories.Location = new System.Drawing.Point(1, 25);
            this.ListViewGamesCategories.Name = "ListViewGamesCategories";
            this.ListViewGamesCategories.Size = new System.Drawing.Size(264, 416);
            this.ListViewGamesCategories.TabIndex = 9;
            this.ListViewGamesCategories.SelectedIndicesChanged += new System.EventHandler(this.ListViewGamesCategories_SelectedIndicesChanged);
            // 
            // ComboBoxConsole
            // 
            this.ComboBoxConsole.DrawDropdownHoverOutline = true;
            this.ComboBoxConsole.FormattingEnabled = true;
            this.ComboBoxConsole.Location = new System.Drawing.Point(14, 39);
            this.ComboBoxConsole.Name = "ComboBoxConsole";
            this.ComboBoxConsole.Size = new System.Drawing.Size(209, 24);
            this.ComboBoxConsole.TabIndex = 0;
            this.ComboBoxConsole.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsole_SelectedIndexChanged);
            // 
            // ComboBoxFirmware
            // 
            this.ComboBoxFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxFirmware.FormattingEnabled = true;
            this.ComboBoxFirmware.Location = new System.Drawing.Point(797, 39);
            this.ComboBoxFirmware.Name = "ComboBoxFirmware";
            this.ComboBoxFirmware.Size = new System.Drawing.Size(65, 24);
            this.ComboBoxFirmware.TabIndex = 3;
            this.ComboBoxFirmware.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFirmware_SelectedIndexChanged);
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Location = new System.Drawing.Point(909, 39);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(69, 24);
            this.ComboBoxType.TabIndex = 4;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // ColumnLocalType
            // 
            this.ColumnLocalType.HeaderText = "Type";
            this.ColumnLocalType.Name = "ColumnLocalType";
            this.ColumnLocalType.ReadOnly = true;
            this.ColumnLocalType.Visible = false;
            // 
            // ColumnLocalIcon
            // 
            this.ColumnLocalIcon.HeaderText = "Icon";
            this.ColumnLocalIcon.Name = "ColumnLocalIcon";
            this.ColumnLocalIcon.ReadOnly = true;
            this.ColumnLocalIcon.Width = 27;
            // 
            // ColumnLocalName
            // 
            this.ColumnLocalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLocalName.HeaderText = "Name";
            this.ColumnLocalName.Name = "ColumnLocalName";
            this.ColumnLocalName.ReadOnly = true;
            // 
            // ColumnLocalSize
            // 
            this.ColumnLocalSize.HeaderText = "Size";
            this.ColumnLocalSize.Name = "ColumnLocalSize";
            this.ColumnLocalSize.ReadOnly = true;
            this.ColumnLocalSize.Width = 94;
            // 
            // ColumnLocalExtension
            // 
            this.ColumnLocalExtension.HeaderText = "Ext";
            this.ColumnLocalExtension.Name = "ColumnLocalExtension";
            this.ColumnLocalExtension.ReadOnly = true;
            this.ColumnLocalExtension.Width = 82;
            // 
            // ColumnLocalDateTime
            // 
            this.ColumnLocalDateTime.HeaderText = "DateTime";
            this.ColumnLocalDateTime.Name = "ColumnLocalDateTime";
            this.ColumnLocalDateTime.ReadOnly = true;
            this.ColumnLocalDateTime.Width = 120;
            // 
            // ColumnConsoleType
            // 
            this.ColumnConsoleType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnConsoleType.HeaderText = "Type";
            this.ColumnConsoleType.Name = "ColumnConsoleType";
            this.ColumnConsoleType.ReadOnly = true;
            this.ColumnConsoleType.Visible = false;
            // 
            // ColumnConsoleIcon
            // 
            this.ColumnConsoleIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnConsoleIcon.HeaderText = "Icon";
            this.ColumnConsoleIcon.Name = "ColumnConsoleIcon";
            this.ColumnConsoleIcon.ReadOnly = true;
            this.ColumnConsoleIcon.Width = 27;
            // 
            // ColumnConsoleName
            // 
            this.ColumnConsoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnConsoleName.HeaderText = "Name";
            this.ColumnConsoleName.Name = "ColumnConsoleName";
            this.ColumnConsoleName.ReadOnly = true;
            // 
            // ColumnConsoleSize
            // 
            this.ColumnConsoleSize.HeaderText = "Size";
            this.ColumnConsoleSize.Name = "ColumnConsoleSize";
            this.ColumnConsoleSize.ReadOnly = true;
            this.ColumnConsoleSize.Width = 94;
            // 
            // ColumnConsoleExtension
            // 
            this.ColumnConsoleExtension.HeaderText = "Extension";
            this.ColumnConsoleExtension.Name = "ColumnConsoleExtension";
            this.ColumnConsoleExtension.ReadOnly = true;
            this.ColumnConsoleExtension.Width = 82;
            // 
            // ColumnConsoleDateTime
            // 
            this.ColumnConsoleDateTime.HeaderText = "DateTime";
            this.ColumnConsoleDateTime.Name = "ColumnConsoleDateTime";
            this.ColumnConsoleDateTime.ReadOnly = true;
            this.ColumnConsoleDateTime.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1396, 822);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.ComboBoxFirmware);
            this.Controls.Add(this.ComboBoxConsole);
            this.Controls.Add(this.ImageSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonPickRandom);
            this.Controls.Add(this.LabelSelectFirmware);
            this.Controls.Add(this.SectionFileExplorer);
            this.Controls.Add(this.ButtonRequestMods);
            this.Controls.Add(this.ButtonConnectConsole);
            this.Controls.Add(this.darkToolStrip1);
            this.Controls.Add(this.ScrollBarDetails);
            this.Controls.Add(this.LabelSelectType);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.SectionArchiveInformation);
            this.Controls.Add(this.SectionModsInstallFilePaths);
            this.Controls.Add(this.SectionModsLibrary);
            this.Controls.Add(this.SectionGamesCategories);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1050, 300);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX (beta) ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContextMenuMods.ResumeLayout(false);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).EndInit();
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.SectionModsInstallFilePaths.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.darkToolStrip1.ResumeLayout(false);
            this.darkToolStrip1.PerformLayout();
            this.SectionFileExplorer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelLocalFiles.ResumeLayout(false);
            this.PanelLocalFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalFiles)).EndInit();
            this.ToolStripLocalFiles.ResumeLayout(false);
            this.ToolStripLocalFiles.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsoleFiles)).EndInit();
            this.ToolStripConsoleFiles.ResumeLayout(false);
            this.ToolStripConsoleFiles.PerformLayout();
            this.ContextMenuLocalFile.ResumeLayout(false);
            this.ContextMenuConsoleFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSearch)).EndInit();
            this.SectionModsLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).EndInit();
            this.SectionGamesCategories.ResumeLayout(false);
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
        private System.Windows.Forms.Label LabelHeaderConfig;
        private System.Windows.Forms.Label LabelConfig;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.DataGridView DgvInstallPaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModFilePath;
        private DarkUI.Controls.DarkButton ButtonConnectConsole;
        private DarkUI.Controls.DarkScrollBar ScrollBarDetails;
        private DarkUI.Controls.DarkSectionPanel SectionArchiveInformation;
        private DarkUI.Controls.DarkMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripContribute;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsAutoDetectGameRegion;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRefreshData;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileExit;
        private DarkUI.Controls.DarkSectionPanel SectionModsInstallFilePaths;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator0;
        private DarkUI.Controls.DarkScrollBar ScrollBarInstallPaths;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsEditConsoles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DarkUI.Controls.DarkToolStrip darkToolStrip1;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnectedConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private DarkUI.Controls.DarkButton ButtonRequestMods;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
        private System.Windows.Forms.Label LabelHeaderSubmittedBy;
        private System.Windows.Forms.Label LabelSubmittedBy;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelHeaderType;
        private System.Windows.Forms.Label LabelType;
        private DarkUI.Controls.DarkSectionPanel SectionFileExplorer;
        private DarkUI.Controls.DarkTextBox TextBoxConsoleDirectory;
        private System.Windows.Forms.Label LabelSelectFirmware;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelLocalFiles;
        private DarkUI.Controls.DarkButton ButtonLocalDirectory;
        private DarkUI.Controls.DarkToolStrip ToolStripLocalFiles;
        private DarkUI.Controls.DarkTextBox TextBoxLocalDirectory;
        private System.Windows.Forms.Panel panel2;
        private DarkUI.Controls.DarkToolStrip ToolStripConsoleFiles;
        private DarkUI.Controls.DarkToolStrip darkToolStrip5;
        private DarkUI.Controls.DarkToolStrip darkToolStrip6;
        private DarkUI.Controls.DarkContextMenu ContextMenuConsoleFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuConsoleRefresh;
        private DarkUI.Controls.DarkContextMenu ContextMenuLocalFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripLocalUploadFile;
        private DarkUI.Controls.DarkButton ButtonNavigateConsoleExplorer;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsSaveCurrentLocalDirectory;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripLocalDeleteFile;
        private System.Windows.Forms.Label LabelHeaderFirmware;
        private System.Windows.Forms.Label LabelFirmware;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsEnableFileManager;
        private DarkUI.Controls.DarkButton ButtonPickRandom;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelHeaderCategory;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moddingForumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesNguPs3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesForumsPsxPlace;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesForumsPsxPlacePs3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesForumsPsxPlaceGameMods;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesForumsNguPs3Mods;
        private System.Windows.Forms.ToolStripMenuItem se7enSinsPS3ModsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pS3ModsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameModsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theTechGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pS3ModsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gameModsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pSXSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesForumsPsxScenePs3Mods;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesForumsPsxSceneGameMods;
        private System.Windows.Forms.ToolStripMenuItem homebrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHomebrewBrewologyStore;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesGames;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesGamesPsnDLv3;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesGamesNoPsv2;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpSourceCode;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpReportIssue;
        private System.Windows.Forms.ToolStripSeparator MenuStripHelpSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelpAboutApp;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesCustomFirmware;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesCustomFirmwareRebug;
        private DarkUI.Controls.DarkContextMenu ContextMenuMods;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsInstallToConsole;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsUninstallFromConsole;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsDownloadArchive;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeperator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsExtractInformation;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeperator0;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsReportOnGitHub;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesReddit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesRedditPs3Homebrew;
        private System.Windows.Forms.ToolStripMenuItem MenuStripResourcesRedditPs3Hacks;
        private System.Windows.Forms.ToolStripMenuItem MenuStripApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuStripApplicationsCCAPI;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private DarkUI.Controls.DarkTextBox TextBoxSearch;
        private System.Windows.Forms.PictureBox ImageSearch;
        private System.Windows.Forms.ToolStripButton ToolStripInstallFiles;
        private System.Windows.Forms.ToolStripButton ToolStripDownloadArchive;
        private System.Windows.Forms.ToolStripButton ToolStripFavorite;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleRefresh;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleDownloadFile;
        private System.Windows.Forms.ToolStripButton ToolStripConsoleDeleteFile;
        private System.Windows.Forms.ToolStripButton ToolStripLocalUploadFile;
        private System.Windows.Forms.ToolStripButton ToolStripLocalDeleteFile;
        private System.Windows.Forms.ToolStripButton ToolStripLocalOpenExplorer;
        private DarkUI.Controls.DarkSectionPanel SectionModsLibrary;
        private DarkUI.Controls.DarkSectionPanel SectionGamesCategories;
        private DarkUI.Controls.DarkComboBox ComboBoxConsole;
        private DarkUI.Controls.DarkComboBox ComboBoxFirmware;
        private DarkUI.Controls.DarkComboBox ComboBoxType;
        private DarkUI.Controls.DarkDataGridView DgvMods;
        private DarkUI.Controls.DarkDataGridView DgvLocalFiles;
        private DarkUI.Controls.DarkListView ListViewGamesCategories;
        private DarkUI.Controls.DarkDataGridView DgvConsoleFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsFirmware;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsNoFiles;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsDownload;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsFavorite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnLocalIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnConsoleIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsoleDateTime;
    }
}