namespace Ps3Xftp
{
    partial class Ps3Xftp
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
            this.LabelSelectConsole = new System.Windows.Forms.Label();
            this.DropdownConsoles = new System.Windows.Forms.ComboBox();
            this.ButtonUninstallFromConsole = new System.Windows.Forms.Button();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelDetailsName = new System.Windows.Forms.Label();
            this.LabelModName = new System.Windows.Forms.Label();
            this.LabelDetailsVersion = new System.Windows.Forms.Label();
            this.LabelModVersion = new System.Windows.Forms.Label();
            this.LabelDetailsAuthor = new System.Windows.Forms.Label();
            this.LabelModAuthor = new System.Windows.Forms.Label();
            this.LabelDetailsType = new System.Windows.Forms.Label();
            this.LabelModType = new System.Windows.Forms.Label();
            this.LabelDetailsConfiguration = new System.Windows.Forms.Label();
            this.LabelModConfiguration = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelModDescription = new System.Windows.Forms.Label();
            this.LabelSelectGame = new System.Windows.Forms.Label();
            this.DataModItems = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabelConnected = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripStatus = new System.Windows.Forms.ToolStripLabel();
            this.ButtonConnectToConsole = new System.Windows.Forms.Button();
            this.CheckboxAutoRegion = new System.Windows.Forms.CheckBox();
            this.ButtonDownloadLocally = new System.Windows.Forms.Button();
            this.ButtonInstallToConsole = new System.Windows.Forms.Button();
            this.LabelHint1 = new System.Windows.Forms.Label();
            this.DropdownGames = new System.Windows.Forms.ListBox();
            this.ButtonEditConsoles = new System.Windows.Forms.Button();
            this.ButtonReportMod = new System.Windows.Forms.Button();
            this.FlowPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataModItems)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSelectConsole
            // 
            this.LabelSelectConsole.AutoSize = true;
            this.LabelSelectConsole.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelSelectConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectConsole.Location = new System.Drawing.Point(9, 41);
            this.LabelSelectConsole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectConsole.Name = "LabelSelectConsole";
            this.LabelSelectConsole.Size = new System.Drawing.Size(58, 17);
            this.LabelSelectConsole.TabIndex = 1074;
            this.LabelSelectConsole.Text = "Console:";
            // 
            // DropdownConsoles
            // 
            this.DropdownConsoles.Enabled = false;
            this.DropdownConsoles.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DropdownConsoles.FormattingEnabled = true;
            this.DropdownConsoles.Location = new System.Drawing.Point(74, 38);
            this.DropdownConsoles.Name = "DropdownConsoles";
            this.DropdownConsoles.Size = new System.Drawing.Size(274, 25);
            this.DropdownConsoles.TabIndex = 0;
            this.DropdownConsoles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoles_SelectedIndexChanged);
            // 
            // ButtonUninstallFromConsole
            // 
            this.ButtonUninstallFromConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonUninstallFromConsole.Enabled = false;
            this.ButtonUninstallFromConsole.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonUninstallFromConsole.Location = new System.Drawing.Point(142, 446);
            this.ButtonUninstallFromConsole.Name = "ButtonUninstallFromConsole";
            this.ButtonUninstallFromConsole.Size = new System.Drawing.Size(154, 27);
            this.ButtonUninstallFromConsole.TabIndex = 8;
            this.ButtonUninstallFromConsole.Text = "Uninstall from Console";
            this.ButtonUninstallFromConsole.UseVisualStyleBackColor = true;
            this.ButtonUninstallFromConsole.Click += new System.EventHandler(this.ButtonUninstallFiles_Click);
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsName);
            this.FlowPanelDetails.Controls.Add(this.LabelModName);
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelModVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelModAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsType);
            this.FlowPanelDetails.Controls.Add(this.LabelModType);
            this.FlowPanelDetails.Controls.Add(this.LabelDetailsConfiguration);
            this.FlowPanelDetails.Controls.Add(this.LabelModConfiguration);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Controls.Add(this.LabelModDescription);
            this.FlowPanelDetails.Location = new System.Drawing.Point(626, 33);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(352, 464);
            this.FlowPanelDetails.TabIndex = 6;
            // 
            // LabelDetailsName
            // 
            this.LabelDetailsName.AutoSize = true;
            this.LabelDetailsName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LabelDetailsName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsName.Location = new System.Drawing.Point(0, 5);
            this.LabelDetailsName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsName.Name = "LabelDetailsName";
            this.LabelDetailsName.Size = new System.Drawing.Size(47, 17);
            this.LabelDetailsName.TabIndex = 1;
            this.LabelDetailsName.Text = "Name:";
            // 
            // LabelModName
            // 
            this.LabelModName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModName, true);
            this.LabelModName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModName.Location = new System.Drawing.Point(47, 5);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(17, 17);
            this.LabelModName.TabIndex = 2;
            this.LabelModName.Text = "...";
            // 
            // LabelDetailsVersion
            // 
            this.LabelDetailsVersion.AutoSize = true;
            this.LabelDetailsVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LabelDetailsVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsVersion.Location = new System.Drawing.Point(0, 28);
            this.LabelDetailsVersion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsVersion.Name = "LabelDetailsVersion";
            this.LabelDetailsVersion.Size = new System.Drawing.Size(55, 17);
            this.LabelDetailsVersion.TabIndex = 3;
            this.LabelDetailsVersion.Text = "Version:";
            // 
            // LabelModVersion
            // 
            this.LabelModVersion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModVersion, true);
            this.LabelModVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModVersion.Location = new System.Drawing.Point(55, 28);
            this.LabelModVersion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModVersion.Name = "LabelModVersion";
            this.LabelModVersion.Size = new System.Drawing.Size(17, 17);
            this.LabelModVersion.TabIndex = 4;
            this.LabelModVersion.Text = "...";
            // 
            // LabelDetailsAuthor
            // 
            this.LabelDetailsAuthor.AutoSize = true;
            this.LabelDetailsAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LabelDetailsAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsAuthor.Location = new System.Drawing.Point(0, 51);
            this.LabelDetailsAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsAuthor.Name = "LabelDetailsAuthor";
            this.LabelDetailsAuthor.Size = new System.Drawing.Size(55, 17);
            this.LabelDetailsAuthor.TabIndex = 5;
            this.LabelDetailsAuthor.Text = "Author:";
            // 
            // LabelModAuthor
            // 
            this.LabelModAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModAuthor, true);
            this.LabelModAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModAuthor.Location = new System.Drawing.Point(55, 51);
            this.LabelModAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModAuthor.Name = "LabelModAuthor";
            this.LabelModAuthor.Size = new System.Drawing.Size(17, 17);
            this.LabelModAuthor.TabIndex = 6;
            this.LabelModAuthor.Text = "...";
            // 
            // LabelDetailsType
            // 
            this.LabelDetailsType.AutoSize = true;
            this.LabelDetailsType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LabelDetailsType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsType.Location = new System.Drawing.Point(0, 74);
            this.LabelDetailsType.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsType.Name = "LabelDetailsType";
            this.LabelDetailsType.Size = new System.Drawing.Size(39, 17);
            this.LabelDetailsType.TabIndex = 7;
            this.LabelDetailsType.Text = "Type:";
            // 
            // LabelModType
            // 
            this.LabelModType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModType, true);
            this.LabelModType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModType.Location = new System.Drawing.Point(39, 74);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(17, 17);
            this.LabelModType.TabIndex = 8;
            this.LabelModType.Text = "...";
            // 
            // LabelDetailsConfiguration
            // 
            this.LabelDetailsConfiguration.AutoSize = true;
            this.LabelDetailsConfiguration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LabelDetailsConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsConfiguration.Location = new System.Drawing.Point(0, 97);
            this.LabelDetailsConfiguration.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsConfiguration.Name = "LabelDetailsConfiguration";
            this.LabelDetailsConfiguration.Size = new System.Drawing.Size(94, 17);
            this.LabelDetailsConfiguration.TabIndex = 9;
            this.LabelDetailsConfiguration.Text = "Configuration:";
            // 
            // LabelModConfiguration
            // 
            this.LabelModConfiguration.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModConfiguration, true);
            this.LabelModConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModConfiguration.Location = new System.Drawing.Point(94, 97);
            this.LabelModConfiguration.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelModConfiguration.Name = "LabelModConfiguration";
            this.LabelModConfiguration.Size = new System.Drawing.Size(17, 17);
            this.LabelModConfiguration.TabIndex = 10;
            this.LabelModConfiguration.Text = "...";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(0, 120);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(79, 17);
            this.LabelDescription.TabIndex = 11;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelModDescription
            // 
            this.LabelModDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModDescription, true);
            this.LabelModDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelModDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModDescription.Location = new System.Drawing.Point(0, 145);
            this.LabelModDescription.Margin = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.LabelModDescription.MaximumSize = new System.Drawing.Size(332, 0);
            this.LabelModDescription.Name = "LabelModDescription";
            this.LabelModDescription.Size = new System.Drawing.Size(17, 17);
            this.LabelModDescription.TabIndex = 12;
            this.LabelModDescription.Text = "...";
            // 
            // LabelSelectGame
            // 
            this.LabelSelectGame.AutoSize = true;
            this.LabelSelectGame.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelSelectGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectGame.Location = new System.Drawing.Point(22, 79);
            this.LabelSelectGame.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectGame.Name = "LabelSelectGame";
            this.LabelSelectGame.Size = new System.Drawing.Size(45, 17);
            this.LabelSelectGame.TabIndex = 1093;
            this.LabelSelectGame.Text = "Game:";
            // 
            // DataModItems
            // 
            this.DataModItems.AllowUserToAddRows = false;
            this.DataModItems.AllowUserToDeleteRows = false;
            this.DataModItems.AllowUserToResizeColumns = false;
            this.DataModItems.AllowUserToResizeRows = false;
            this.DataModItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataModItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataModItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnType,
            this.ColumnVersion,
            this.ColumnAuthor});
            this.DataModItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataModItems.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataModItems.Location = new System.Drawing.Point(13, 145);
            this.DataModItems.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
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
            this.DataModItems.Size = new System.Drawing.Size(600, 292);
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
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 86;
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
            this.DropdownTypes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DropdownTypes.FormattingEnabled = true;
            this.DropdownTypes.Location = new System.Drawing.Point(472, 108);
            this.DropdownTypes.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.DropdownTypes.Name = "DropdownTypes";
            this.DropdownTypes.Size = new System.Drawing.Size(100, 25);
            this.DropdownTypes.TabIndex = 5;
            this.DropdownTypes.SelectedIndexChanged += new System.EventHandler(this.DropdownTypes_SelectedIndexChanged);
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.AutoSize = true;
            this.LabelSelectType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(424, 110);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(39, 17);
            this.LabelSelectType.TabIndex = 1102;
            this.LabelSelectType.Text = "Filter:";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripContribute,
            this.MenuStripInformation});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(991, 24);
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
            this.ToolStrip.Location = new System.Drawing.Point(0, 506);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.ToolStrip.Size = new System.Drawing.Size(991, 25);
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
            this.ButtonConnectToConsole.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonConnectToConsole.Location = new System.Drawing.Point(422, 37);
            this.ButtonConnectToConsole.Name = "ButtonConnectToConsole";
            this.ButtonConnectToConsole.Size = new System.Drawing.Size(98, 27);
            this.ButtonConnectToConsole.TabIndex = 2;
            this.ButtonConnectToConsole.Text = "Connect";
            this.ButtonConnectToConsole.UseVisualStyleBackColor = true;
            this.ButtonConnectToConsole.Click += new System.EventHandler(this.ButtonConnectToConsole_Click);
            // 
            // CheckboxAutoRegion
            // 
            this.CheckboxAutoRegion.AutoSize = true;
            this.CheckboxAutoRegion.Checked = true;
            this.CheckboxAutoRegion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxAutoRegion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CheckboxAutoRegion.Location = new System.Drawing.Point(427, 80);
            this.CheckboxAutoRegion.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.CheckboxAutoRegion.Name = "CheckboxAutoRegion";
            this.CheckboxAutoRegion.Size = new System.Drawing.Size(141, 21);
            this.CheckboxAutoRegion.TabIndex = 4;
            this.CheckboxAutoRegion.Text = "Auto-Detect Region";
            this.CheckboxAutoRegion.UseVisualStyleBackColor = true;
            // 
            // ButtonDownloadLocally
            // 
            this.ButtonDownloadLocally.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDownloadLocally.Enabled = false;
            this.ButtonDownloadLocally.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonDownloadLocally.Location = new System.Drawing.Point(302, 446);
            this.ButtonDownloadLocally.Name = "ButtonDownloadLocally";
            this.ButtonDownloadLocally.Size = new System.Drawing.Size(112, 27);
            this.ButtonDownloadLocally.TabIndex = 9;
            this.ButtonDownloadLocally.Text = "Download to ...";
            this.ButtonDownloadLocally.UseVisualStyleBackColor = true;
            this.ButtonDownloadLocally.Click += new System.EventHandler(this.ButtonDownloadFiles_Click);
            // 
            // ButtonInstallToConsole
            // 
            this.ButtonInstallToConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonInstallToConsole.Enabled = false;
            this.ButtonInstallToConsole.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonInstallToConsole.Location = new System.Drawing.Point(12, 446);
            this.ButtonInstallToConsole.Name = "ButtonInstallToConsole";
            this.ButtonInstallToConsole.Size = new System.Drawing.Size(124, 27);
            this.ButtonInstallToConsole.TabIndex = 7;
            this.ButtonInstallToConsole.Text = "Install to Console";
            this.ButtonInstallToConsole.UseVisualStyleBackColor = true;
            this.ButtonInstallToConsole.Click += new System.EventHandler(this.ButtonDownloadInstallMods_Click);
            // 
            // LabelHint1
            // 
            this.LabelHint1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelHint1.AutoSize = true;
            this.LabelHint1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHint1.Location = new System.Drawing.Point(10, 481);
            this.LabelHint1.Name = "LabelHint1";
            this.LabelHint1.Size = new System.Drawing.Size(338, 15);
            this.LabelHint1.TabIndex = 1113;
            this.LabelHint1.Text = "*Only install files to your console when you\'re at the xmb screen";
            // 
            // DropdownGames
            // 
            this.DropdownGames.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DropdownGames.FormattingEnabled = true;
            this.DropdownGames.ItemHeight = 17;
            this.DropdownGames.Location = new System.Drawing.Point(74, 77);
            this.DropdownGames.Name = "DropdownGames";
            this.DropdownGames.Size = new System.Drawing.Size(342, 55);
            this.DropdownGames.Sorted = true;
            this.DropdownGames.TabIndex = 3;
            this.DropdownGames.SelectedIndexChanged += new System.EventHandler(this.DropdownGames_SelectedIndexChanged);
            // 
            // ButtonEditConsoles
            // 
            this.ButtonEditConsoles.AutoSize = true;
            this.ButtonEditConsoles.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonEditConsoles.Location = new System.Drawing.Point(354, 37);
            this.ButtonEditConsoles.Name = "ButtonEditConsoles";
            this.ButtonEditConsoles.Size = new System.Drawing.Size(62, 27);
            this.ButtonEditConsoles.TabIndex = 1;
            this.ButtonEditConsoles.Text = "Edit...";
            this.ButtonEditConsoles.UseVisualStyleBackColor = true;
            this.ButtonEditConsoles.Click += new System.EventHandler(this.ButtonEditConsoles_Click);
            // 
            // ButtonReportMod
            // 
            this.ButtonReportMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonReportMod.Enabled = false;
            this.ButtonReportMod.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonReportMod.Location = new System.Drawing.Point(547, 445);
            this.ButtonReportMod.Name = "ButtonReportMod";
            this.ButtonReportMod.Size = new System.Drawing.Size(66, 27);
            this.ButtonReportMod.TabIndex = 10;
            this.ButtonReportMod.Text = "Report";
            this.ButtonReportMod.UseVisualStyleBackColor = true;
            this.ButtonReportMod.Click += new System.EventHandler(this.ButtonReportMod_Click);
            // 
            // Ps3Xftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(991, 531);
            this.Controls.Add(this.ButtonReportMod);
            this.Controls.Add(this.ButtonEditConsoles);
            this.Controls.Add(this.DropdownGames);
            this.Controls.Add(this.LabelHint1);
            this.Controls.Add(this.ButtonInstallToConsole);
            this.Controls.Add(this.ButtonDownloadLocally);
            this.Controls.Add(this.CheckboxAutoRegion);
            this.Controls.Add(this.ButtonConnectToConsole);
            this.Controls.Add(this.FlowPanelDetails);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.LabelSelectType);
            this.Controls.Add(this.DropdownTypes);
            this.Controls.Add(this.DataModItems);
            this.Controls.Add(this.LabelSelectGame);
            this.Controls.Add(this.ButtonUninstallFromConsole);
            this.Controls.Add(this.LabelSelectConsole);
            this.Controls.Add(this.DropdownConsoles);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Ps3Xftp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ps3Xftp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ps3xftp_FormClosing);
            this.Load += new System.EventHandler(this.Ps3xftp_Load);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataModItems)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSelectConsole;
        private System.Windows.Forms.ComboBox DropdownConsoles;
        private System.Windows.Forms.Label LabelSelectGame;
        private System.Windows.Forms.DataGridView DataModItems;
        private System.Windows.Forms.ComboBox DropdownTypes;
        private System.Windows.Forms.Label LabelSelectType;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelDetailsName;
        private System.Windows.Forms.Label LabelModName;
        private System.Windows.Forms.Label LabelDetailsAuthor;
        private System.Windows.Forms.Label LabelModAuthor;
        private System.Windows.Forms.Label LabelDetailsConfiguration;
        private System.Windows.Forms.Label LabelModConfiguration;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelModDescription;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripContribute;
        private System.Windows.Forms.ToolStripMenuItem MenuStripInformation;
        private System.Windows.Forms.Label LabelDetailsVersion;
        private System.Windows.Forms.Label LabelModVersion;
        private System.Windows.Forms.Label LabelDetailsType;
        private System.Windows.Forms.Label LabelModType;
        private System.Windows.Forms.Button ButtonUninstallFromConsole;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel ToolStripStatus;
        private System.Windows.Forms.Button ButtonConnectToConsole;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRefreshData;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnected;
        private System.Windows.Forms.ToolStripLabel ToolStripConsole;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeperator;
        private System.Windows.Forms.CheckBox CheckboxAutoRegion;
        private System.Windows.Forms.Button ButtonDownloadLocally;
        private System.Windows.Forms.Button ButtonInstallToConsole;
        private System.Windows.Forms.Label LabelHint1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.ListBox DropdownGames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button ButtonEditConsoles;
        private System.Windows.Forms.Button ButtonReportMod;
    }
}