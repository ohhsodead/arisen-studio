namespace ModioX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DropdownConsoles = new System.Windows.Forms.ComboBox();
            this.ButtonUninstallFiles = new System.Windows.Forms.Button();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelModName = new System.Windows.Forms.Label();
            this.LabelModAuthor = new System.Windows.Forms.Label();
            this.LabelDetailsVersion = new System.Windows.Forms.Label();
            this.LabelModVersion = new System.Windows.Forms.Label();
            this.LabelDetailsConfiguration = new System.Windows.Forms.Label();
            this.LabelModConfiguration = new System.Windows.Forms.Label();
            this.LabelModDescription = new System.Windows.Forms.Label();
            this.DataModItems = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropdownTypes = new System.Windows.Forms.ComboBox();
            this.LabelSelectType = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripContribute = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabelConnected = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripStatus = new System.Windows.Forms.ToolStripLabel();
            this.ButtonConnectToConsole = new System.Windows.Forms.Button();
            this.ButtonDownloadLocally = new System.Windows.Forms.Button();
            this.ButtonInstallToConsole = new System.Windows.Forms.Button();
            this.ButtonReportMod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListGames = new System.Windows.Forms.ListBox();
            this.FlowPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataModItems)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DropdownConsoles
            // 
            this.DropdownConsoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownConsoles.Enabled = false;
            this.DropdownConsoles.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DropdownConsoles.FormattingEnabled = true;
            this.DropdownConsoles.Location = new System.Drawing.Point(12, 35);
            this.DropdownConsoles.Name = "DropdownConsoles";
            this.DropdownConsoles.Size = new System.Drawing.Size(264, 25);
            this.DropdownConsoles.TabIndex = 0;
            this.DropdownConsoles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoles_SelectedIndexChanged);
            // 
            // ButtonUninstallFiles
            // 
            this.ButtonUninstallFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonUninstallFiles.Enabled = false;
            this.ButtonUninstallFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUninstallFiles.Location = new System.Drawing.Point(80, 447);
            this.ButtonUninstallFiles.Name = "ButtonUninstallFiles";
            this.ButtonUninstallFiles.Size = new System.Drawing.Size(78, 27);
            this.ButtonUninstallFiles.TabIndex = 8;
            this.ButtonUninstallFiles.Text = "Uninstall";
            this.ButtonUninstallFiles.UseVisualStyleBackColor = true;
            this.ButtonUninstallFiles.Click += new System.EventHandler(this.ButtonUninstallFiles_Click);
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelDetails.Controls.Add(this.LabelModName);
            this.FlowPanelDetails.Controls.Add(this.LabelModAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelModVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsConfiguration);
            this.FlowPanelDetails.Controls.Add(this.LabelModConfiguration);
            this.FlowPanelDetails.Controls.Add(this.LabelModDescription);
            this.FlowPanelDetails.Location = new System.Drawing.Point(626, 34);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(323, 308);
            this.FlowPanelDetails.TabIndex = 6;
            // 
            // LabelModName
            // 
            this.LabelModName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModName, true);
            this.LabelModName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelModName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModName.Location = new System.Drawing.Point(0, 5);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(45, 19);
            this.LabelModName.TabIndex = 2;
            this.LabelModName.Text = "Name";
            // 
            // LabelModAuthor
            // 
            this.LabelModAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModAuthor, true);
            this.LabelModAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModAuthor.Location = new System.Drawing.Point(0, 29);
            this.LabelModAuthor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.LabelModAuthor.Name = "LabelModAuthor";
            this.LabelModAuthor.Size = new System.Drawing.Size(65, 17);
            this.LabelModAuthor.TabIndex = 6;
            this.LabelModAuthor.Text = "by Author";
            // 
            // LabelDetailsVersion
            // 
            this.LabelDetailsVersion.AutoSize = true;
            this.LabelDetailsVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelDetailsVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsVersion.Location = new System.Drawing.Point(0, 53);
            this.LabelDetailsVersion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsVersion.Name = "LabelDetailsVersion";
            this.LabelDetailsVersion.Size = new System.Drawing.Size(54, 17);
            this.LabelDetailsVersion.TabIndex = 3;
            this.LabelDetailsVersion.Text = "Version:";
            // 
            // LabelModVersion
            // 
            this.LabelModVersion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModVersion, true);
            this.LabelModVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModVersion.Location = new System.Drawing.Point(54, 53);
            this.LabelModVersion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModVersion.Name = "LabelModVersion";
            this.LabelModVersion.Size = new System.Drawing.Size(17, 17);
            this.LabelModVersion.TabIndex = 4;
            this.LabelModVersion.Text = "...";
            // 
            // LabelDetailsConfiguration
            // 
            this.LabelDetailsConfiguration.AutoSize = true;
            this.LabelDetailsConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelDetailsConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsConfiguration.Location = new System.Drawing.Point(0, 76);
            this.LabelDetailsConfiguration.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsConfiguration.Name = "LabelDetailsConfiguration";
            this.LabelDetailsConfiguration.Size = new System.Drawing.Size(90, 17);
            this.LabelDetailsConfiguration.TabIndex = 9;
            this.LabelDetailsConfiguration.Text = "Configuration:";
            // 
            // LabelModConfiguration
            // 
            this.LabelModConfiguration.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModConfiguration, true);
            this.LabelModConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModConfiguration.Location = new System.Drawing.Point(90, 76);
            this.LabelModConfiguration.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModConfiguration.Name = "LabelModConfiguration";
            this.LabelModConfiguration.Size = new System.Drawing.Size(17, 17);
            this.LabelModConfiguration.TabIndex = 10;
            this.LabelModConfiguration.Text = "...";
            // 
            // LabelModDescription
            // 
            this.LabelModDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModDescription, true);
            this.LabelModDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModDescription.Location = new System.Drawing.Point(0, 99);
            this.LabelModDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModDescription.MaximumSize = new System.Drawing.Size(332, 0);
            this.LabelModDescription.Name = "LabelModDescription";
            this.LabelModDescription.Size = new System.Drawing.Size(17, 17);
            this.LabelModDescription.TabIndex = 12;
            this.LabelModDescription.Text = "...";
            // 
            // DataModItems
            // 
            this.DataModItems.AllowUserToAddRows = false;
            this.DataModItems.AllowUserToDeleteRows = false;
            this.DataModItems.AllowUserToResizeColumns = false;
            this.DataModItems.AllowUserToResizeRows = false;
            this.DataModItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataModItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataModItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataModItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataModItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnVersion,
            this.ColumnAuthor});
            this.DataModItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataModItems.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataModItems.Location = new System.Drawing.Point(12, 169);
            this.DataModItems.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.DataModItems.MultiSelect = false;
            this.DataModItems.Name = "DataModItems";
            this.DataModItems.ReadOnly = true;
            this.DataModItems.RowHeadersVisible = false;
            this.DataModItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataModItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataModItems.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.DataModItems.RowTemplate.Height = 24;
            this.DataModItems.RowTemplate.ReadOnly = true;
            this.DataModItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataModItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataModItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataModItems.ShowCellToolTips = false;
            this.DataModItems.ShowEditingIcon = false;
            this.DataModItems.Size = new System.Drawing.Size(607, 271);
            this.DataModItems.TabIndex = 6;
            this.DataModItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataItemsMods_CellClick);
            this.DataModItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataItemsMods_CellContentClick);
            this.DataModItems.SelectionChanged += new System.EventHandler(this.DataModItems_SelectionChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnVersion
            // 
            this.ColumnVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnVersion.HeaderText = "Version";
            this.ColumnVersion.Name = "ColumnVersion";
            this.ColumnVersion.ReadOnly = true;
            this.ColumnVersion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnVersion.Width = 82;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnAuthor.HeaderText = "Author";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            this.ColumnAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAuthor.Width = 130;
            // 
            // DropdownTypes
            // 
            this.DropdownTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DropdownTypes.FormattingEnabled = true;
            this.DropdownTypes.Location = new System.Drawing.Point(541, 135);
            this.DropdownTypes.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.DropdownTypes.Name = "DropdownTypes";
            this.DropdownTypes.Size = new System.Drawing.Size(78, 25);
            this.DropdownTypes.TabIndex = 5;
            this.DropdownTypes.SelectedIndexChanged += new System.EventHandler(this.DropdownTypes_SelectedIndexChanged);
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.AutoSize = true;
            this.LabelSelectType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(497, 138);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(38, 17);
            this.LabelSelectType.TabIndex = 1102;
            this.LabelSelectType.Text = "Type:";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripContribute,
            this.MenuStripInformation,
            this.settingsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(960, 24);
            this.MenuStrip.TabIndex = 0;
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileRefreshData,
            this.toolStripSeparator1,
            this.MenuStripFileExit});
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(37, 20);
            this.MenuStripFile.Text = "File";
            // 
            // MenuStripFileRefreshData
            // 
            this.MenuStripFileRefreshData.Name = "MenuStripFileRefreshData";
            this.MenuStripFileRefreshData.Size = new System.Drawing.Size(146, 22);
            this.MenuStripFileRefreshData.Text = "Refresh Mods";
            this.MenuStripFileRefreshData.Click += new System.EventHandler(this.MenuStripFileRefreshData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // MenuStripFileExit
            // 
            this.MenuStripFileExit.Name = "MenuStripFileExit";
            this.MenuStripFileExit.Size = new System.Drawing.Size(146, 22);
            this.MenuStripFileExit.Text = "Exit";
            this.MenuStripFileExit.Click += new System.EventHandler(this.MenuStripFileExit_Click);
            // 
            // MenuStripContribute
            // 
            this.MenuStripContribute.Name = "MenuStripContribute";
            this.MenuStripContribute.Size = new System.Drawing.Size(76, 20);
            this.MenuStripContribute.Text = "Contribute";
            this.MenuStripContribute.Click += new System.EventHandler(this.MenuStripContribute_Click);
            // 
            // MenuStripInformation
            // 
            this.MenuStripInformation.Name = "MenuStripInformation";
            this.MenuStripInformation.Size = new System.Drawing.Size(82, 20);
            this.MenuStripInformation.Text = "Information";
            this.MenuStripInformation.Click += new System.EventHandler(this.MenuStripInformation_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelConnected,
            this.ToolStripConsole,
            this.ToolStripSeperator,
            this.ToolStripStatus});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 480);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.ToolStrip.Size = new System.Drawing.Size(960, 25);
            this.ToolStrip.Stretch = true;
            this.ToolStrip.TabIndex = 1106;
            // 
            // ToolStripLabelConnected
            // 
            this.ToolStripLabelConnected.Name = "ToolStripLabelConnected";
            this.ToolStripLabelConnected.Size = new System.Drawing.Size(68, 22);
            this.ToolStripLabelConnected.Text = "Connected:";
            // 
            // ToolStripConsole
            // 
            this.ToolStripConsole.Name = "ToolStripConsole";
            this.ToolStripConsole.Size = new System.Drawing.Size(36, 22);
            this.ToolStripConsole.Text = "None";
            // 
            // ToolStripSeperator
            // 
            this.ToolStripSeperator.Name = "ToolStripSeperator";
            this.ToolStripSeperator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripStatus
            // 
            this.ToolStripStatus.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new System.Drawing.Size(48, 22);
            this.ToolStripStatus.Text = "Status...";
            // 
            // ButtonConnectToConsole
            // 
            this.ButtonConnectToConsole.AutoSize = true;
            this.ButtonConnectToConsole.Enabled = false;
            this.ButtonConnectToConsole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnectToConsole.Location = new System.Drawing.Point(282, 34);
            this.ButtonConnectToConsole.Name = "ButtonConnectToConsole";
            this.ButtonConnectToConsole.Size = new System.Drawing.Size(86, 27);
            this.ButtonConnectToConsole.TabIndex = 2;
            this.ButtonConnectToConsole.Text = "Connect";
            this.ButtonConnectToConsole.UseVisualStyleBackColor = true;
            this.ButtonConnectToConsole.Click += new System.EventHandler(this.ButtonConnectToConsole_Click);
            // 
            // ButtonDownloadLocally
            // 
            this.ButtonDownloadLocally.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDownloadLocally.Enabled = false;
            this.ButtonDownloadLocally.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDownloadLocally.Location = new System.Drawing.Point(164, 447);
            this.ButtonDownloadLocally.Name = "ButtonDownloadLocally";
            this.ButtonDownloadLocally.Size = new System.Drawing.Size(86, 27);
            this.ButtonDownloadLocally.TabIndex = 9;
            this.ButtonDownloadLocally.Text = "Download";
            this.ButtonDownloadLocally.UseVisualStyleBackColor = true;
            this.ButtonDownloadLocally.Click += new System.EventHandler(this.ButtonDownloadFiles_Click);
            // 
            // ButtonInstallToConsole
            // 
            this.ButtonInstallToConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonInstallToConsole.Enabled = false;
            this.ButtonInstallToConsole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonInstallToConsole.Location = new System.Drawing.Point(12, 447);
            this.ButtonInstallToConsole.Name = "ButtonInstallToConsole";
            this.ButtonInstallToConsole.Size = new System.Drawing.Size(62, 27);
            this.ButtonInstallToConsole.TabIndex = 7;
            this.ButtonInstallToConsole.Text = "Install";
            this.ButtonInstallToConsole.UseVisualStyleBackColor = true;
            this.ButtonInstallToConsole.Click += new System.EventHandler(this.ButtonDownloadInstallMods_Click);
            // 
            // ButtonReportMod
            // 
            this.ButtonReportMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonReportMod.Enabled = false;
            this.ButtonReportMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonReportMod.Location = new System.Drawing.Point(256, 447);
            this.ButtonReportMod.Name = "ButtonReportMod";
            this.ButtonReportMod.Size = new System.Drawing.Size(66, 27);
            this.ButtonReportMod.TabIndex = 10;
            this.ButtonReportMod.Text = "Report";
            this.ButtonReportMod.UseVisualStyleBackColor = true;
            this.ButtonReportMod.Click += new System.EventHandler(this.ButtonReportMod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(626, 351);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(323, 89);
            this.dataGridView1.TabIndex = 1115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Files";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ListGames
            // 
            this.ListGames.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ListGames.FormattingEnabled = true;
            this.ListGames.ItemHeight = 17;
            this.ListGames.Location = new System.Drawing.Point(12, 71);
            this.ListGames.Name = "ListGames";
            this.ListGames.Size = new System.Drawing.Size(393, 89);
            this.ListGames.TabIndex = 1126;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 505);
            this.Controls.Add(this.ListGames);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonReportMod);
            this.Controls.Add(this.ButtonInstallToConsole);
            this.Controls.Add(this.ButtonDownloadLocally);
            this.Controls.Add(this.ButtonConnectToConsole);
            this.Controls.Add(this.FlowPanelDetails);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.LabelSelectType);
            this.Controls.Add(this.DropdownTypes);
            this.Controls.Add(this.DataModItems);
            this.Controls.Add(this.ButtonUninstallFiles);
            this.Controls.Add(this.DropdownConsoles);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ps3xftp_FormClosing);
            this.Load += new System.EventHandler(this.Ps3xftp_Load);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataModItems)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DropdownConsoles;
        private System.Windows.Forms.DataGridView DataModItems;
        private System.Windows.Forms.ComboBox DropdownTypes;
        private System.Windows.Forms.Label LabelSelectType;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelModName;
        private System.Windows.Forms.Label LabelModAuthor;
        private System.Windows.Forms.Label LabelDetailsConfiguration;
        private System.Windows.Forms.Label LabelModConfiguration;
        private System.Windows.Forms.Label LabelModDescription;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripContribute;
        private System.Windows.Forms.ToolStripMenuItem MenuStripInformation;
        private System.Windows.Forms.Label LabelDetailsVersion;
        private System.Windows.Forms.Label LabelModVersion;
        private System.Windows.Forms.Button ButtonUninstallFiles;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel ToolStripStatus;
        private System.Windows.Forms.Button ButtonConnectToConsole;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRefreshData;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnected;
        private System.Windows.Forms.ToolStripLabel ToolStripConsole;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeperator;
        private System.Windows.Forms.Button ButtonDownloadLocally;
        private System.Windows.Forms.Button ButtonInstallToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button ButtonReportMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ListBox ListGames;
    }
}