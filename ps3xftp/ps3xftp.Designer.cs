namespace ps3xftp
{
    partial class Ps3xftp
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
            this.ButtonUninstallMods = new System.Windows.Forms.Button();
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
            this.ButtonInstallMods = new System.Windows.Forms.Button();
            this.LabelSelectGame = new System.Windows.Forms.Label();
            this.DropdownGames = new System.Windows.Forms.ComboBox();
            this.DataModItems = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropdownTypes = new System.Windows.Forms.ComboBox();
            this.LabelSelectType = new System.Windows.Forms.Label();
            this.ImageHeader = new System.Windows.Forms.PictureBox();
            this.LabelSelectRegion = new System.Windows.Forms.Label();
            this.DropdownRegions = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripConsoles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripConsolesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripContribute = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripTitleConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripStatus = new System.Windows.Forms.ToolStripLabel();
            this.ButtonConnectToConsole = new System.Windows.Forms.Button();
            this.LabelModDetails = new System.Windows.Forms.Label();
            this.FlowPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataModItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeader)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSelectConsole
            // 
            this.LabelSelectConsole.AutoSize = true;
            this.LabelSelectConsole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectConsole.Location = new System.Drawing.Point(235, 39);
            this.LabelSelectConsole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectConsole.Name = "LabelSelectConsole";
            this.LabelSelectConsole.Size = new System.Drawing.Size(58, 17);
            this.LabelSelectConsole.TabIndex = 1074;
            this.LabelSelectConsole.Text = "Console:";
            // 
            // DropdownConsoles
            // 
            this.DropdownConsoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownConsoles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownConsoles.FormattingEnabled = true;
            this.DropdownConsoles.Location = new System.Drawing.Point(238, 61);
            this.DropdownConsoles.Name = "DropdownConsoles";
            this.DropdownConsoles.Size = new System.Drawing.Size(228, 23);
            this.DropdownConsoles.TabIndex = 1063;
            this.DropdownConsoles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoles_SelectedIndexChanged);
            // 
            // ButtonUninstallMods
            // 
            this.ButtonUninstallMods.Enabled = false;
            this.ButtonUninstallMods.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonUninstallMods.Location = new System.Drawing.Point(623, 339);
            this.ButtonUninstallMods.Name = "ButtonUninstallMods";
            this.ButtonUninstallMods.Size = new System.Drawing.Size(70, 26);
            this.ButtonUninstallMods.TabIndex = 1107;
            this.ButtonUninstallMods.Text = "Uninstall";
            this.ButtonUninstallMods.UseVisualStyleBackColor = true;
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
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
            this.FlowPanelDetails.Location = new System.Drawing.Point(558, 60);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(314, 273);
            this.FlowPanelDetails.TabIndex = 1105;
            // 
            // LabelDetailsName
            // 
            this.LabelDetailsName.AutoSize = true;
            this.LabelDetailsName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailsName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsName.Location = new System.Drawing.Point(0, 5);
            this.LabelDetailsName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsName.Name = "LabelDetailsName";
            this.LabelDetailsName.Size = new System.Drawing.Size(46, 17);
            this.LabelDetailsName.TabIndex = 1100;
            this.LabelDetailsName.Text = "Name:";
            // 
            // LabelModName
            // 
            this.LabelModName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModName, true);
            this.LabelModName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModName.Location = new System.Drawing.Point(46, 7);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(16, 15);
            this.LabelModName.TabIndex = 1107;
            this.LabelModName.Text = "...";
            // 
            // LabelDetailsVersion
            // 
            this.LabelDetailsVersion.AutoSize = true;
            this.LabelDetailsVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailsVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsVersion.Location = new System.Drawing.Point(0, 28);
            this.LabelDetailsVersion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsVersion.Name = "LabelDetailsVersion";
            this.LabelDetailsVersion.Size = new System.Drawing.Size(54, 17);
            this.LabelDetailsVersion.TabIndex = 1110;
            this.LabelDetailsVersion.Text = "Version:";
            // 
            // LabelModVersion
            // 
            this.LabelModVersion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModVersion, true);
            this.LabelModVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModVersion.Location = new System.Drawing.Point(54, 30);
            this.LabelModVersion.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.LabelModVersion.Name = "LabelModVersion";
            this.LabelModVersion.Size = new System.Drawing.Size(16, 15);
            this.LabelModVersion.TabIndex = 1111;
            this.LabelModVersion.Text = "...";
            // 
            // LabelDetailsAuthor
            // 
            this.LabelDetailsAuthor.AutoSize = true;
            this.LabelDetailsAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailsAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsAuthor.Location = new System.Drawing.Point(0, 51);
            this.LabelDetailsAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsAuthor.Name = "LabelDetailsAuthor";
            this.LabelDetailsAuthor.Size = new System.Drawing.Size(50, 17);
            this.LabelDetailsAuthor.TabIndex = 1101;
            this.LabelDetailsAuthor.Text = "Author:";
            // 
            // LabelModAuthor
            // 
            this.LabelModAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModAuthor, true);
            this.LabelModAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModAuthor.Location = new System.Drawing.Point(50, 53);
            this.LabelModAuthor.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.LabelModAuthor.Name = "LabelModAuthor";
            this.LabelModAuthor.Size = new System.Drawing.Size(16, 15);
            this.LabelModAuthor.TabIndex = 1106;
            this.LabelModAuthor.Text = "...";
            // 
            // LabelDetailsType
            // 
            this.LabelDetailsType.AutoSize = true;
            this.LabelDetailsType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailsType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsType.Location = new System.Drawing.Point(0, 74);
            this.LabelDetailsType.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsType.Name = "LabelDetailsType";
            this.LabelDetailsType.Size = new System.Drawing.Size(38, 17);
            this.LabelDetailsType.TabIndex = 1108;
            this.LabelDetailsType.Text = "Type:";
            // 
            // LabelModType
            // 
            this.LabelModType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModType, true);
            this.LabelModType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModType.Location = new System.Drawing.Point(38, 76);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(16, 15);
            this.LabelModType.TabIndex = 1109;
            this.LabelModType.Text = "...";
            // 
            // LabelDetailsConfiguration
            // 
            this.LabelDetailsConfiguration.AutoSize = true;
            this.LabelDetailsConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailsConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDetailsConfiguration.Location = new System.Drawing.Point(0, 97);
            this.LabelDetailsConfiguration.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDetailsConfiguration.Name = "LabelDetailsConfiguration";
            this.LabelDetailsConfiguration.Size = new System.Drawing.Size(90, 17);
            this.LabelDetailsConfiguration.TabIndex = 1102;
            this.LabelDetailsConfiguration.Text = "Configuration:";
            // 
            // LabelModConfiguration
            // 
            this.LabelModConfiguration.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModConfiguration, true);
            this.LabelModConfiguration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModConfiguration.Location = new System.Drawing.Point(90, 99);
            this.LabelModConfiguration.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.LabelModConfiguration.Name = "LabelModConfiguration";
            this.LabelModConfiguration.Size = new System.Drawing.Size(16, 15);
            this.LabelModConfiguration.TabIndex = 1105;
            this.LabelModConfiguration.Text = "...";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(0, 120);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(77, 17);
            this.LabelDescription.TabIndex = 1103;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelModDescription
            // 
            this.LabelModDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelModDescription.AutoEllipsis = true;
            this.LabelModDescription.AutoSize = true;
            this.LabelModDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModDescription.Location = new System.Drawing.Point(0, 143);
            this.LabelModDescription.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.LabelModDescription.Name = "LabelModDescription";
            this.LabelModDescription.Size = new System.Drawing.Size(16, 15);
            this.LabelModDescription.TabIndex = 1104;
            this.LabelModDescription.Text = "...";
            // 
            // ButtonInstallMods
            // 
            this.ButtonInstallMods.Enabled = false;
            this.ButtonInstallMods.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonInstallMods.Location = new System.Drawing.Point(561, 339);
            this.ButtonInstallMods.Name = "ButtonInstallMods";
            this.ButtonInstallMods.Size = new System.Drawing.Size(56, 26);
            this.ButtonInstallMods.TabIndex = 1106;
            this.ButtonInstallMods.Text = "Install";
            this.ButtonInstallMods.UseVisualStyleBackColor = true;
            this.ButtonInstallMods.Click += new System.EventHandler(this.ButtonInstallMods_Click);
            // 
            // LabelSelectGame
            // 
            this.LabelSelectGame.AutoSize = true;
            this.LabelSelectGame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectGame.Location = new System.Drawing.Point(9, 90);
            this.LabelSelectGame.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectGame.Name = "LabelSelectGame";
            this.LabelSelectGame.Size = new System.Drawing.Size(45, 17);
            this.LabelSelectGame.TabIndex = 1093;
            this.LabelSelectGame.Text = "Game:";
            // 
            // DropdownGames
            // 
            this.DropdownGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownGames.FormattingEnabled = true;
            this.DropdownGames.Location = new System.Drawing.Point(12, 112);
            this.DropdownGames.Name = "DropdownGames";
            this.DropdownGames.Size = new System.Drawing.Size(349, 23);
            this.DropdownGames.TabIndex = 1092;
            this.DropdownGames.SelectedIndexChanged += new System.EventHandler(this.DropdownGames_SelectedIndexChanged);
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
            this.ColumnName,
            this.ColumnType,
            this.ColumnVersion,
            this.ColumnAuthor});
            this.DataModItems.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataModItems.Location = new System.Drawing.Point(12, 144);
            this.DataModItems.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DataModItems.MultiSelect = false;
            this.DataModItems.Name = "DataModItems";
            this.DataModItems.ReadOnly = true;
            this.DataModItems.RowHeadersVisible = false;
            this.DataModItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataModItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataModItems.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.DataModItems.RowTemplate.Height = 26;
            this.DataModItems.RowTemplate.ReadOnly = true;
            this.DataModItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataModItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataModItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataModItems.ShowCellToolTips = false;
            this.DataModItems.ShowEditingIcon = false;
            this.DataModItems.Size = new System.Drawing.Size(537, 221);
            this.DataModItems.TabIndex = 1095;
            this.DataModItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataItemsMods_CellClick);
            this.DataModItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataItemsMods_CellContentClick);
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
            this.DropdownTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownTypes.FormattingEnabled = true;
            this.DropdownTypes.Location = new System.Drawing.Point(471, 112);
            this.DropdownTypes.Name = "DropdownTypes";
            this.DropdownTypes.Size = new System.Drawing.Size(78, 23);
            this.DropdownTypes.TabIndex = 1101;
            this.DropdownTypes.SelectedIndexChanged += new System.EventHandler(this.DropdownTypes_SelectedIndexChanged);
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.AutoSize = true;
            this.LabelSelectType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(468, 90);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(38, 17);
            this.LabelSelectType.TabIndex = 1102;
            this.LabelSelectType.Text = "Type:";
            // 
            // ImageHeader
            // 
            this.ImageHeader.Image = global::ps3xftp.Properties.Resources.ps3xftp_text;
            this.ImageHeader.Location = new System.Drawing.Point(9, 32);
            this.ImageHeader.Name = "ImageHeader";
            this.ImageHeader.Size = new System.Drawing.Size(213, 52);
            this.ImageHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageHeader.TabIndex = 1077;
            this.ImageHeader.TabStop = false;
            // 
            // LabelSelectRegion
            // 
            this.LabelSelectRegion.AutoSize = true;
            this.LabelSelectRegion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectRegion.Location = new System.Drawing.Point(364, 90);
            this.LabelSelectRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSelectRegion.Name = "LabelSelectRegion";
            this.LabelSelectRegion.Size = new System.Drawing.Size(52, 17);
            this.LabelSelectRegion.TabIndex = 1104;
            this.LabelSelectRegion.Text = "Region:";
            // 
            // DropdownRegions
            // 
            this.DropdownRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownRegions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownRegions.FormattingEnabled = true;
            this.DropdownRegions.Location = new System.Drawing.Point(367, 112);
            this.DropdownRegions.Name = "DropdownRegions";
            this.DropdownRegions.Size = new System.Drawing.Size(98, 23);
            this.DropdownRegions.TabIndex = 1103;
            this.DropdownRegions.SelectedIndexChanged += new System.EventHandler(this.DropdownRegions_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripConsoles,
            this.MenuStripContribute,
            this.MenuStripInformation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1105;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileRefreshData,
            this.MenuStripFileExit});
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(37, 20);
            this.MenuStripFile.Text = "File";
            // 
            // MenuStripFileRefreshData
            // 
            this.MenuStripFileRefreshData.Name = "MenuStripFileRefreshData";
            this.MenuStripFileRefreshData.Size = new System.Drawing.Size(140, 22);
            this.MenuStripFileRefreshData.Text = "Refresh Data";
            this.MenuStripFileRefreshData.Click += new System.EventHandler(this.MenuStripFileRefreshData_Click);
            // 
            // MenuStripFileExit
            // 
            this.MenuStripFileExit.Name = "MenuStripFileExit";
            this.MenuStripFileExit.Size = new System.Drawing.Size(140, 22);
            this.MenuStripFileExit.Text = "Exit";
            this.MenuStripFileExit.Click += new System.EventHandler(this.MenuStripFileExit_Click);
            // 
            // MenuStripConsoles
            // 
            this.MenuStripConsoles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripConsolesEdit});
            this.MenuStripConsoles.Name = "MenuStripConsoles";
            this.MenuStripConsoles.Size = new System.Drawing.Size(67, 20);
            this.MenuStripConsoles.Text = "Consoles";
            // 
            // MenuStripConsolesEdit
            // 
            this.MenuStripConsolesEdit.Name = "MenuStripConsolesEdit";
            this.MenuStripConsolesEdit.Size = new System.Drawing.Size(103, 22);
            this.MenuStripConsolesEdit.Text = "Edit...";
            this.MenuStripConsolesEdit.Click += new System.EventHandler(this.MenuStripConsolesEdit_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTitleConsole,
            this.ToolStripConsole,
            this.ToolStripSeperator,
            this.ToolStripStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 378);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1106;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripTitleConsole
            // 
            this.ToolStripTitleConsole.Name = "ToolStripTitleConsole";
            this.ToolStripTitleConsole.Size = new System.Drawing.Size(53, 22);
            this.ToolStripTitleConsole.Text = "Console:";
            // 
            // ToolStripConsole
            // 
            this.ToolStripConsole.ForeColor = System.Drawing.Color.Red;
            this.ToolStripConsole.Name = "ToolStripConsole";
            this.ToolStripConsole.Size = new System.Drawing.Size(34, 22);
            this.ToolStripConsole.Text = "none";
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
            this.ButtonConnectToConsole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonConnectToConsole.Location = new System.Drawing.Point(472, 59);
            this.ButtonConnectToConsole.Name = "ButtonConnectToConsole";
            this.ButtonConnectToConsole.Size = new System.Drawing.Size(77, 26);
            this.ButtonConnectToConsole.TabIndex = 1108;
            this.ButtonConnectToConsole.Text = "Connect...";
            this.ButtonConnectToConsole.UseVisualStyleBackColor = true;
            this.ButtonConnectToConsole.Click += new System.EventHandler(this.ButtonConnectToConsole_Click);
            // 
            // LabelModDetails
            // 
            this.LabelModDetails.AutoSize = true;
            this.LabelModDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModDetails.Location = new System.Drawing.Point(558, 39);
            this.LabelModDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelModDetails.Name = "LabelModDetails";
            this.LabelModDetails.Size = new System.Drawing.Size(79, 17);
            this.LabelModDetails.TabIndex = 1109;
            this.LabelModDetails.Text = "Mod Details";
            // 
            // Ps3xftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.LabelModDetails);
            this.Controls.Add(this.ButtonUninstallMods);
            this.Controls.Add(this.ButtonInstallMods);
            this.Controls.Add(this.ButtonConnectToConsole);
            this.Controls.Add(this.FlowPanelDetails);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LabelSelectRegion);
            this.Controls.Add(this.DropdownRegions);
            this.Controls.Add(this.LabelSelectType);
            this.Controls.Add(this.DropdownTypes);
            this.Controls.Add(this.DataModItems);
            this.Controls.Add(this.LabelSelectGame);
            this.Controls.Add(this.DropdownGames);
            this.Controls.Add(this.ImageHeader);
            this.Controls.Add(this.LabelSelectConsole);
            this.Controls.Add(this.DropdownConsoles);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Ps3xftp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ps3xftp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ps3xftp_FormClosing);
            this.Load += new System.EventHandler(this.Ps3xftp_Load);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataModItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeader)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ImageHeader;
        private System.Windows.Forms.Label LabelSelectConsole;
        private System.Windows.Forms.ComboBox DropdownConsoles;
        private System.Windows.Forms.Label LabelSelectGame;
        private System.Windows.Forms.ComboBox DropdownGames;
        private System.Windows.Forms.DataGridView DataModItems;
        private System.Windows.Forms.ComboBox DropdownTypes;
        private System.Windows.Forms.Label LabelSelectType;
        private System.Windows.Forms.Label LabelSelectRegion;
        private System.Windows.Forms.ComboBox DropdownRegions;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelDetailsName;
        private System.Windows.Forms.Label LabelModName;
        private System.Windows.Forms.Label LabelDetailsAuthor;
        private System.Windows.Forms.Label LabelModAuthor;
        private System.Windows.Forms.Label LabelDetailsConfiguration;
        private System.Windows.Forms.Label LabelModConfiguration;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelModDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConsoles;
        private System.Windows.Forms.ToolStripMenuItem MenuStripConsolesEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripContribute;
        private System.Windows.Forms.ToolStripMenuItem MenuStripInformation;
        private System.Windows.Forms.Label LabelDetailsVersion;
        private System.Windows.Forms.Label LabelModVersion;
        private System.Windows.Forms.Label LabelDetailsType;
        private System.Windows.Forms.Label LabelModType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.Button ButtonUninstallMods;
        private System.Windows.Forms.Button ButtonInstallMods;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ToolStripStatus;
        private System.Windows.Forms.Label LabelModDetails;
        private System.Windows.Forms.Button ButtonConnectToConsole;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRefreshData;
        private System.Windows.Forms.ToolStripLabel ToolStripTitleConsole;
        private System.Windows.Forms.ToolStripLabel ToolStripConsole;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeperator;
    }
}