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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FlowPanelGames = new System.Windows.Forms.FlowLayoutPanel();
            this.DgvMods = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxConsole = new System.Windows.Forms.ComboBox();
            this.LabelSelectCategory = new System.Windows.Forms.Label();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.LabelByAuthor = new System.Windows.Forms.Label();
            this.LabelHeaderVersion = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelHeaderConfiguration = new System.Windows.Forms.Label();
            this.LabelConfiguration = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.DgvInstallPaths = new System.Windows.Forms.DataGridView();
            this.ColumnModFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonConnectConsole = new DarkUI.Controls.DarkButton();
            this.ScrollBarDetails = new DarkUI.Controls.DarkScrollBar();
            this.SectionModsDetails = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonInstallFiles = new DarkUI.Controls.DarkButton();
            this.ButtonUninstallFiles = new DarkUI.Controls.DarkButton();
            this.ButtonDownloadFiles = new DarkUI.Controls.DarkButton();
            this.ButtonReport = new DarkUI.Controls.DarkButton();
            this.SectionInstallPaths = new DarkUI.Controls.DarkSectionPanel();
            this.ScrollBarInstallPaths = new DarkUI.Controls.DarkScrollBar();
            this.darkToolStrip2 = new DarkUI.Controls.DarkToolStrip();
            this.MenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripContribute = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettingsEditConsoles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripSettingsAutoDetectRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.SectionGames = new DarkUI.Controls.DarkSectionPanel();
            this.ScrollBarGames = new DarkUI.Controls.DarkScrollBar();
            this.ScrollBarMods = new DarkUI.Controls.DarkScrollBar();
            this.SectionMods = new DarkUI.Controls.DarkSectionPanel();
            this.darkToolStrip1 = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConnected = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxAddress = new DarkUI.Controls.DarkTextBox();
            this.LabelConsoleAddress = new DarkUI.Controls.DarkLabel();
            this.LabelConsoles = new DarkUI.Controls.DarkLabel();
            this.TextBoxSelectedConsole = new DarkUI.Controls.DarkTextBox();
            this.TextBoxSelectedCategory = new DarkUI.Controls.DarkTextBox();
            this.SectionCustomInstallation = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonBrowseFile = new DarkUI.Controls.DarkButton();
            this.TextBoxLocalFile = new DarkUI.Controls.DarkTextBox();
            this.TextBoxInstallPath = new DarkUI.Controls.DarkTextBox();
            this.ComboBoxInstallPath = new System.Windows.Forms.ComboBox();
            this.LabelInstallPath = new DarkUI.Controls.DarkLabel();
            this.ButtonInstallCustom = new DarkUI.Controls.DarkButton();
            this.LabelLocalFile = new DarkUI.Controls.DarkLabel();
            this.ButtonRequestMods = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).BeginInit();
            this.FlowPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).BeginInit();
            this.SectionModsDetails.SuspendLayout();
            this.SectionInstallPaths.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SectionGames.SuspendLayout();
            this.SectionMods.SuspendLayout();
            this.darkToolStrip1.SuspendLayout();
            this.SectionCustomInstallation.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanelGames
            // 
            this.FlowPanelGames.AutoScroll = true;
            this.FlowPanelGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelGames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanelGames.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelGames.Margin = new System.Windows.Forms.Padding(5);
            this.FlowPanelGames.Name = "FlowPanelGames";
            this.FlowPanelGames.Size = new System.Drawing.Size(226, 447);
            this.FlowPanelGames.TabIndex = 5;
            this.FlowPanelGames.WrapContents = false;
            this.FlowPanelGames.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowPanelGames_Scroll);
            // 
            // DgvMods
            // 
            this.DgvMods.AllowUserToAddRows = false;
            this.DgvMods.AllowUserToDeleteRows = false;
            this.DgvMods.AllowUserToResizeColumns = false;
            this.DgvMods.AllowUserToResizeRows = false;
            this.DgvMods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DgvMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvMods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMods.ColumnHeadersVisible = false;
            this.DgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnVersion,
            this.ColumnAuthor});
            this.DgvMods.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMods.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMods.EnableHeadersVisualStyles = false;
            this.DgvMods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.DgvMods.Location = new System.Drawing.Point(1, 25);
            this.DgvMods.Margin = new System.Windows.Forms.Padding(3, 8, 3, 5);
            this.DgvMods.MultiSelect = false;
            this.DgvMods.Name = "DgvMods";
            this.DgvMods.ReadOnly = true;
            this.DgvMods.RowHeadersVisible = false;
            this.DgvMods.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvMods.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DgvMods.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DgvMods.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DgvMods.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DgvMods.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.DgvMods.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvMods.RowTemplate.Height = 26;
            this.DgvMods.RowTemplate.ReadOnly = true;
            this.DgvMods.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMods.ShowCellToolTips = false;
            this.DgvMods.ShowEditingIcon = false;
            this.DgvMods.Size = new System.Drawing.Size(531, 351);
            this.DgvMods.TabIndex = 7;
            this.DgvMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMods_CellClick);
            this.DgvMods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMods_CellContentClick);
            this.DgvMods.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DgvMods_Scroll);
            this.DgvMods.SelectionChanged += new System.EventHandler(this.DgvMods_SelectionChanged);
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
            this.ColumnAuthor.Width = 134;
            // 
            // ComboBoxConsole
            // 
            this.ComboBoxConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ComboBoxConsole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxConsole.Enabled = false;
            this.ComboBoxConsole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxConsole.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxConsole.FormattingEnabled = true;
            this.ComboBoxConsole.Location = new System.Drawing.Point(282, 34);
            this.ComboBoxConsole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxConsole.Name = "ComboBoxConsole";
            this.ComboBoxConsole.Size = new System.Drawing.Size(162, 23);
            this.ComboBoxConsole.TabIndex = 2;
            this.ComboBoxConsole.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsole_SelectedIndexChanged);
            // 
            // LabelSelectCategory
            // 
            this.LabelSelectCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectCategory.AutoSize = true;
            this.LabelSelectCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectCategory.Location = new System.Drawing.Point(627, 37);
            this.LabelSelectCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSelectCategory.Name = "LabelSelectCategory";
            this.LabelSelectCategory.Size = new System.Drawing.Size(58, 15);
            this.LabelSelectCategory.TabIndex = 1122;
            this.LabelSelectCategory.Text = "Category:";
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(691, 34);
            this.ComboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 7, 4);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(90, 23);
            this.ComboBoxCategory.TabIndex = 1121;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderName);
            this.FlowPanelDetails.Controls.Add(this.LabelByAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderConfiguration);
            this.FlowPanelDetails.Controls.Add(this.LabelConfiguration);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(4, 4, 18, 2);
            this.FlowPanelDetails.Size = new System.Drawing.Size(328, 313);
            this.FlowPanelDetails.TabIndex = 15;
            this.FlowPanelDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowPanelDetails_Scroll);
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderName, true);
            this.LabelHeaderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(4, 6);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(101, 15);
            this.LabelHeaderName.TabIndex = 2;
            this.LabelHeaderName.Text = "Name (Category)";
            // 
            // LabelByAuthor
            // 
            this.LabelByAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelByAuthor, true);
            this.LabelByAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelByAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelByAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelByAuthor.Location = new System.Drawing.Point(4, 25);
            this.LabelByAuthor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LabelByAuthor.Name = "LabelByAuthor";
            this.LabelByAuthor.Size = new System.Drawing.Size(62, 15);
            this.LabelByAuthor.TabIndex = 6;
            this.LabelByAuthor.Text = "by Author";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.AutoSize = true;
            this.LabelHeaderVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(4, 44);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
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
            this.LabelVersion.Location = new System.Drawing.Point(55, 44);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(16, 15);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderConfiguration
            // 
            this.LabelHeaderConfiguration.AutoSize = true;
            this.LabelHeaderConfiguration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderConfiguration.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderConfiguration.Location = new System.Drawing.Point(4, 63);
            this.LabelHeaderConfiguration.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LabelHeaderConfiguration.Name = "LabelHeaderConfiguration";
            this.LabelHeaderConfiguration.Size = new System.Drawing.Size(86, 15);
            this.LabelHeaderConfiguration.TabIndex = 9;
            this.LabelHeaderConfiguration.Text = "Configuration:";
            // 
            // LabelConfiguration
            // 
            this.LabelConfiguration.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConfiguration, true);
            this.LabelConfiguration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConfiguration.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConfiguration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConfiguration.Location = new System.Drawing.Point(90, 63);
            this.LabelConfiguration.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LabelConfiguration.Name = "LabelConfiguration";
            this.LabelConfiguration.Size = new System.Drawing.Size(16, 15);
            this.LabelConfiguration.TabIndex = 10;
            this.LabelConfiguration.Text = "...";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(4, 83);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(332, 0);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInstallPaths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.DgvInstallPaths.Size = new System.Drawing.Size(326, 71);
            this.DgvInstallPaths.TabIndex = 17;
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
            this.ButtonConnectConsole.Location = new System.Drawing.Point(450, 34);
            this.ButtonConnectConsole.Name = "ButtonConnectConsole";
            this.ButtonConnectConsole.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonConnectConsole.Size = new System.Drawing.Size(78, 23);
            this.ButtonConnectConsole.TabIndex = 3;
            this.ButtonConnectConsole.Text = "Connect";
            this.ButtonConnectConsole.Click += new System.EventHandler(this.ButtonConnectConsole_Click);
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(1097, 87);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(17, 313);
            this.ScrollBarDetails.TabIndex = 1133;
            this.ScrollBarDetails.Text = "darkScrollBar1";
            this.ScrollBarDetails.ViewSize = 1;
            this.ScrollBarDetails.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarDetails_ValueChanged);
            // 
            // SectionModsDetails
            // 
            this.SectionModsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionModsDetails.Controls.Add(this.ButtonInstallFiles);
            this.SectionModsDetails.Controls.Add(this.ButtonUninstallFiles);
            this.SectionModsDetails.Controls.Add(this.ButtonDownloadFiles);
            this.SectionModsDetails.Controls.Add(this.ButtonReport);
            this.SectionModsDetails.Controls.Add(this.FlowPanelDetails);
            this.SectionModsDetails.Controls.Add(this.SectionInstallPaths);
            this.SectionModsDetails.Controls.Add(this.darkToolStrip2);
            this.SectionModsDetails.Location = new System.Drawing.Point(785, 62);
            this.SectionModsDetails.Name = "SectionModsDetails";
            this.SectionModsDetails.SectionHeader = "Mods Details";
            this.SectionModsDetails.Size = new System.Drawing.Size(330, 473);
            this.SectionModsDetails.TabIndex = 14;
            // 
            // ButtonInstallFiles
            // 
            this.ButtonInstallFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonInstallFiles.Enabled = false;
            this.ButtonInstallFiles.Location = new System.Drawing.Point(7, 442);
            this.ButtonInstallFiles.Name = "ButtonInstallFiles";
            this.ButtonInstallFiles.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonInstallFiles.Size = new System.Drawing.Size(59, 23);
            this.ButtonInstallFiles.TabIndex = 18;
            this.ButtonInstallFiles.Text = "Install";
            this.ButtonInstallFiles.Click += new System.EventHandler(this.ButtonInstallFiles_Click);
            // 
            // ButtonUninstallFiles
            // 
            this.ButtonUninstallFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonUninstallFiles.Enabled = false;
            this.ButtonUninstallFiles.Location = new System.Drawing.Point(72, 442);
            this.ButtonUninstallFiles.Name = "ButtonUninstallFiles";
            this.ButtonUninstallFiles.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonUninstallFiles.Size = new System.Drawing.Size(73, 23);
            this.ButtonUninstallFiles.TabIndex = 19;
            this.ButtonUninstallFiles.Text = "Uninstall";
            this.ButtonUninstallFiles.Click += new System.EventHandler(this.ButtonUninstallFiles_Click);
            // 
            // ButtonDownloadFiles
            // 
            this.ButtonDownloadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDownloadFiles.Enabled = false;
            this.ButtonDownloadFiles.Location = new System.Drawing.Point(151, 442);
            this.ButtonDownloadFiles.Name = "ButtonDownloadFiles";
            this.ButtonDownloadFiles.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonDownloadFiles.Size = new System.Drawing.Size(79, 23);
            this.ButtonDownloadFiles.TabIndex = 20;
            this.ButtonDownloadFiles.Text = "Download";
            this.ButtonDownloadFiles.Click += new System.EventHandler(this.ButtonDownloadFiles_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonReport.Enabled = false;
            this.ButtonReport.Location = new System.Drawing.Point(236, 442);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonReport.Size = new System.Drawing.Size(61, 23);
            this.ButtonReport.TabIndex = 21;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // SectionInstallPaths
            // 
            this.SectionInstallPaths.Controls.Add(this.ScrollBarInstallPaths);
            this.SectionInstallPaths.Controls.Add(this.DgvInstallPaths);
            this.SectionInstallPaths.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SectionInstallPaths.Location = new System.Drawing.Point(1, 338);
            this.SectionInstallPaths.Name = "SectionInstallPaths";
            this.SectionInstallPaths.SectionHeader = "Install Paths";
            this.SectionInstallPaths.Size = new System.Drawing.Size(328, 97);
            this.SectionInstallPaths.TabIndex = 16;
            // 
            // ScrollBarInstallPaths
            // 
            this.ScrollBarInstallPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarInstallPaths.Location = new System.Drawing.Point(310, 33);
            this.ScrollBarInstallPaths.Name = "ScrollBarInstallPaths";
            this.ScrollBarInstallPaths.Size = new System.Drawing.Size(17, 63);
            this.ScrollBarInstallPaths.TabIndex = 1144;
            this.ScrollBarInstallPaths.Text = "darkScrollBar3";
            this.ScrollBarInstallPaths.ViewSize = 40;
            this.ScrollBarInstallPaths.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarInstallPaths_ValueChanged);
            // 
            // darkToolStrip2
            // 
            this.darkToolStrip2.AutoSize = false;
            this.darkToolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkToolStrip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip2.Location = new System.Drawing.Point(1, 435);
            this.darkToolStrip2.Name = "darkToolStrip2";
            this.darkToolStrip2.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.darkToolStrip2.Size = new System.Drawing.Size(328, 37);
            this.darkToolStrip2.TabIndex = 16;
            this.darkToolStrip2.Text = "darkToolStrip2";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripInformation,
            this.MenuStripContribute,
            this.MenuStripSettings,
            this.MenuStripHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1126, 26);
            this.MenuStrip.TabIndex = 1140;
            this.MenuStrip.Text = "darkMenuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileRefreshData,
            this.MenuStripFileSeparator,
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
            // MenuStripFileSeparator
            // 
            this.MenuStripFileSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileSeparator.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStripFileSeparator.Name = "MenuStripFileSeparator";
            this.MenuStripFileSeparator.Size = new System.Drawing.Size(137, 6);
            // 
            // MenuStripFileExit
            // 
            this.MenuStripFileExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFileExit.Name = "MenuStripFileExit";
            this.MenuStripFileExit.Size = new System.Drawing.Size(140, 22);
            this.MenuStripFileExit.Text = "Exit";
            this.MenuStripFileExit.Click += new System.EventHandler(this.MenuStripFileExit_Click);
            // 
            // MenuStripInformation
            // 
            this.MenuStripInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripInformation.Name = "MenuStripInformation";
            this.MenuStripInformation.Size = new System.Drawing.Size(82, 19);
            this.MenuStripInformation.Text = "Information";
            this.MenuStripInformation.Click += new System.EventHandler(this.MenuStripInformation_Click);
            // 
            // MenuStripContribute
            // 
            this.MenuStripContribute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripContribute.Name = "MenuStripContribute";
            this.MenuStripContribute.Size = new System.Drawing.Size(76, 19);
            this.MenuStripContribute.Text = "Contribute";
            this.MenuStripContribute.Click += new System.EventHandler(this.MenuStripContribute_Click);
            // 
            // MenuStripSettings
            // 
            this.MenuStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripSettingsEditConsoles,
            this.toolStripSeparator1,
            this.MenuStripSettingsAutoDetectRegion});
            this.MenuStripSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettings.Name = "MenuStripSettings";
            this.MenuStripSettings.Size = new System.Drawing.Size(61, 19);
            this.MenuStripSettings.Text = "Settings";
            // 
            // MenuStripSettingsEditConsoles
            // 
            this.MenuStripSettingsEditConsoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettingsEditConsoles.Name = "MenuStripSettingsEditConsoles";
            this.MenuStripSettingsEditConsoles.Size = new System.Drawing.Size(179, 22);
            this.MenuStripSettingsEditConsoles.Text = "Edit Consoles...";
            this.MenuStripSettingsEditConsoles.Click += new System.EventHandler(this.MenuStripSettingsEditConsoles_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // MenuStripSettingsAutoDetectRegion
            // 
            this.MenuStripSettingsAutoDetectRegion.Checked = true;
            this.MenuStripSettingsAutoDetectRegion.CheckOnClick = true;
            this.MenuStripSettingsAutoDetectRegion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuStripSettingsAutoDetectRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripSettingsAutoDetectRegion.Name = "MenuStripSettingsAutoDetectRegion";
            this.MenuStripSettingsAutoDetectRegion.ShortcutKeyDisplayString = "";
            this.MenuStripSettingsAutoDetectRegion.Size = new System.Drawing.Size(179, 22);
            this.MenuStripSettingsAutoDetectRegion.Text = "Auto-Detect Region";
            this.MenuStripSettingsAutoDetectRegion.Click += new System.EventHandler(this.MenuStripSettingsAutoDetectRegion_Click);
            // 
            // MenuStripHelp
            // 
            this.MenuStripHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripHelp.Name = "MenuStripHelp";
            this.MenuStripHelp.Size = new System.Drawing.Size(44, 19);
            this.MenuStripHelp.Text = "Help";
            this.MenuStripHelp.Click += new System.EventHandler(this.MenuStripHelp_Click);
            // 
            // SectionGames
            // 
            this.SectionGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SectionGames.Controls.Add(this.ScrollBarGames);
            this.SectionGames.Controls.Add(this.FlowPanelGames);
            this.SectionGames.Location = new System.Drawing.Point(12, 62);
            this.SectionGames.Name = "SectionGames";
            this.SectionGames.SectionHeader = "Browse Games";
            this.SectionGames.Size = new System.Drawing.Size(228, 473);
            this.SectionGames.TabIndex = 4;
            // 
            // ScrollBarGames
            // 
            this.ScrollBarGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarGames.Location = new System.Drawing.Point(210, 25);
            this.ScrollBarGames.Name = "ScrollBarGames";
            this.ScrollBarGames.Size = new System.Drawing.Size(17, 447);
            this.ScrollBarGames.TabIndex = 1144;
            this.ScrollBarGames.Text = "darkScrollBar2";
            this.ScrollBarGames.ViewSize = 10;
            this.ScrollBarGames.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarGames_ValueChanged);
            // 
            // ScrollBarMods
            // 
            this.ScrollBarMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarMods.Location = new System.Drawing.Point(761, 87);
            this.ScrollBarMods.Name = "ScrollBarMods";
            this.ScrollBarMods.Size = new System.Drawing.Size(17, 351);
            this.ScrollBarMods.TabIndex = 1143;
            this.ScrollBarMods.Text = "darkScrollBar2";
            this.ScrollBarMods.ViewSize = 10;
            this.ScrollBarMods.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarMods_ValueChanged);
            // 
            // SectionMods
            // 
            this.SectionMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionMods.Controls.Add(this.DgvMods);
            this.SectionMods.Location = new System.Drawing.Point(246, 62);
            this.SectionMods.Name = "SectionMods";
            this.SectionMods.SectionHeader = "Discover Mods";
            this.SectionMods.Size = new System.Drawing.Size(533, 377);
            this.SectionMods.TabIndex = 6;
            // 
            // darkToolStrip1
            // 
            this.darkToolStrip1.AutoSize = false;
            this.darkToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkToolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.darkToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelConnected,
            this.ToolStripLabelConsole,
            this.toolStripSeparator3,
            this.ToolStripLabelStatus,
            this.ToolStripLabelStats});
            this.darkToolStrip1.Location = new System.Drawing.Point(0, 541);
            this.darkToolStrip1.Name = "darkToolStrip1";
            this.darkToolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 2);
            this.darkToolStrip1.Size = new System.Drawing.Size(1126, 25);
            this.darkToolStrip1.TabIndex = 1146;
            this.darkToolStrip1.Text = "darkToolStrip1";
            // 
            // ToolStripLabelConnected
            // 
            this.ToolStripLabelConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConnected.Name = "ToolStripLabelConnected";
            this.ToolStripLabelConnected.Size = new System.Drawing.Size(74, 20);
            this.ToolStripLabelConnected.Text = "Connected  :";
            // 
            // ToolStripLabelConsole
            // 
            this.ToolStripLabelConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsole.Name = "ToolStripLabelConsole";
            this.ToolStripLabelConsole.Size = new System.Drawing.Size(36, 20);
            this.ToolStripLabelConsole.Text = "None";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(85, 20);
            this.ToolStripLabelStatus.Text = "Loading data...";
            // 
            // ToolStripLabelStats
            // 
            this.ToolStripLabelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStats.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.ToolStripLabelStats.Name = "ToolStripLabelStats";
            this.ToolStripLabelStats.Size = new System.Drawing.Size(154, 20);
            this.ToolStripLabelStats.Text = "# Mods Overall for # Games";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxAddress.Location = new System.Drawing.Point(115, 34);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(92, 23);
            this.TextBoxAddress.TabIndex = 0;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // LabelConsoleAddress
            // 
            this.LabelConsoleAddress.AutoSize = true;
            this.LabelConsoleAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsoleAddress.Location = new System.Drawing.Point(11, 38);
            this.LabelConsoleAddress.Name = "LabelConsoleAddress";
            this.LabelConsoleAddress.Size = new System.Drawing.Size(98, 15);
            this.LabelConsoleAddress.TabIndex = 1148;
            this.LabelConsoleAddress.Text = "Console Address:";
            // 
            // LabelConsoles
            // 
            this.LabelConsoles.AutoSize = true;
            this.LabelConsoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsoles.Location = new System.Drawing.Point(215, 38);
            this.LabelConsoles.Name = "LabelConsoles";
            this.LabelConsoles.Size = new System.Drawing.Size(61, 15);
            this.LabelConsoles.TabIndex = 1149;
            this.LabelConsoles.Text = "Console\'s:";
            // 
            // TextBoxSelectedConsole
            // 
            this.TextBoxSelectedConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxSelectedConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSelectedConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxSelectedConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxSelectedConsole.Location = new System.Drawing.Point(282, 34);
            this.TextBoxSelectedConsole.Name = "TextBoxSelectedConsole";
            this.TextBoxSelectedConsole.ReadOnly = true;
            this.TextBoxSelectedConsole.Size = new System.Drawing.Size(145, 23);
            this.TextBoxSelectedConsole.TabIndex = 1;
            this.TextBoxSelectedConsole.Click += new System.EventHandler(this.TextBoxSelectedConsole_Click);
            this.TextBoxSelectedConsole.Enter += new System.EventHandler(this.TextBoxSelectedConsole_Enter);
            // 
            // TextBoxSelectedCategory
            // 
            this.TextBoxSelectedCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSelectedCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxSelectedCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSelectedCategory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxSelectedCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxSelectedCategory.Location = new System.Drawing.Point(689, 34);
            this.TextBoxSelectedCategory.Name = "TextBoxSelectedCategory";
            this.TextBoxSelectedCategory.ReadOnly = true;
            this.TextBoxSelectedCategory.Size = new System.Drawing.Size(73, 23);
            this.TextBoxSelectedCategory.TabIndex = 1151;
            this.TextBoxSelectedCategory.Text = "ANY";
            this.TextBoxSelectedCategory.Click += new System.EventHandler(this.TextBoxSelectedCategory_Click);
            this.TextBoxSelectedCategory.Enter += new System.EventHandler(this.TextBoxSelectedCategory_Enter);
            // 
            // SectionCustomInstallation
            // 
            this.SectionCustomInstallation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionCustomInstallation.Controls.Add(this.ButtonBrowseFile);
            this.SectionCustomInstallation.Controls.Add(this.TextBoxLocalFile);
            this.SectionCustomInstallation.Controls.Add(this.TextBoxInstallPath);
            this.SectionCustomInstallation.Controls.Add(this.ComboBoxInstallPath);
            this.SectionCustomInstallation.Controls.Add(this.LabelInstallPath);
            this.SectionCustomInstallation.Controls.Add(this.ButtonInstallCustom);
            this.SectionCustomInstallation.Controls.Add(this.LabelLocalFile);
            this.SectionCustomInstallation.Location = new System.Drawing.Point(246, 445);
            this.SectionCustomInstallation.Name = "SectionCustomInstallation";
            this.SectionCustomInstallation.SectionHeader = "Custom Installation";
            this.SectionCustomInstallation.Size = new System.Drawing.Size(533, 90);
            this.SectionCustomInstallation.TabIndex = 8;
            // 
            // ButtonBrowseFile
            // 
            this.ButtonBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseFile.Location = new System.Drawing.Point(469, 31);
            this.ButtonBrowseFile.Name = "ButtonBrowseFile";
            this.ButtonBrowseFile.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonBrowseFile.Size = new System.Drawing.Size(59, 23);
            this.ButtonBrowseFile.TabIndex = 10;
            this.ButtonBrowseFile.Text = "...";
            this.ButtonBrowseFile.Click += new System.EventHandler(this.ButtonBrowseFile_Click);
            // 
            // TextBoxLocalFile
            // 
            this.TextBoxLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxLocalFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLocalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxLocalFile.Location = new System.Drawing.Point(80, 31);
            this.TextBoxLocalFile.Name = "TextBoxLocalFile";
            this.TextBoxLocalFile.Size = new System.Drawing.Size(383, 23);
            this.TextBoxLocalFile.TabIndex = 9;
            // 
            // TextBoxInstallPath
            // 
            this.TextBoxInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInstallPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxInstallPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxInstallPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxInstallPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxInstallPath.Location = new System.Drawing.Point(80, 59);
            this.TextBoxInstallPath.Name = "TextBoxInstallPath";
            this.TextBoxInstallPath.Size = new System.Drawing.Size(366, 23);
            this.TextBoxInstallPath.TabIndex = 11;
            // 
            // ComboBoxInstallPath
            // 
            this.ComboBoxInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstallPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ComboBoxInstallPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInstallPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstallPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxInstallPath.FormattingEnabled = true;
            this.ComboBoxInstallPath.Items.AddRange(new object[] {
            "dev_hdd0/game/{REGION}/USRDIR/EBOOT.BIN",
            "dev_hdd0/game/{REGION}/USRDIR/patch_mp.ff",
            "dev_hdd0/game/{REGION}/default_mp.self",
            "dev_hdd0/tmp/Menu.sprx"});
            this.ComboBoxInstallPath.Location = new System.Drawing.Point(80, 59);
            this.ComboBoxInstallPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxInstallPath.Name = "ComboBoxInstallPath";
            this.ComboBoxInstallPath.Size = new System.Drawing.Size(383, 23);
            this.ComboBoxInstallPath.TabIndex = 12;
            this.ComboBoxInstallPath.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstallPath_SelectedIndexChanged);
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelInstallPath.AutoSize = true;
            this.LabelInstallPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelInstallPath.Location = new System.Drawing.Point(4, 62);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.LabelInstallPath.Size = new System.Drawing.Size(69, 15);
            this.LabelInstallPath.TabIndex = 1153;
            this.LabelInstallPath.Text = "Upload File:";
            // 
            // ButtonInstallCustom
            // 
            this.ButtonInstallCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInstallCustom.Enabled = false;
            this.ButtonInstallCustom.Location = new System.Drawing.Point(469, 59);
            this.ButtonInstallCustom.Name = "ButtonInstallCustom";
            this.ButtonInstallCustom.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonInstallCustom.Size = new System.Drawing.Size(59, 23);
            this.ButtonInstallCustom.TabIndex = 13;
            this.ButtonInstallCustom.Text = "Upload";
            this.ButtonInstallCustom.Click += new System.EventHandler(this.ButtonInstallCustom_Click);
            // 
            // LabelLocalFile
            // 
            this.LabelLocalFile.AutoSize = true;
            this.LabelLocalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalFile.Location = new System.Drawing.Point(4, 34);
            this.LabelLocalFile.Name = "LabelLocalFile";
            this.LabelLocalFile.Size = new System.Drawing.Size(59, 15);
            this.LabelLocalFile.TabIndex = 1152;
            this.LabelLocalFile.Text = "Local File:";
            // 
            // ButtonRequestMods
            // 
            this.ButtonRequestMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRequestMods.Location = new System.Drawing.Point(1013, 34);
            this.ButtonRequestMods.Name = "ButtonRequestMods";
            this.ButtonRequestMods.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonRequestMods.Size = new System.Drawing.Size(102, 23);
            this.ButtonRequestMods.TabIndex = 22;
            this.ButtonRequestMods.Text = "Request Mods";
            this.ButtonRequestMods.Click += new System.EventHandler(this.ButtonRequestMods_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1126, 566);
            this.Controls.Add(this.ButtonRequestMods);
            this.Controls.Add(this.SectionCustomInstallation);
            this.Controls.Add(this.TextBoxSelectedCategory);
            this.Controls.Add(this.ButtonConnectConsole);
            this.Controls.Add(this.TextBoxSelectedConsole);
            this.Controls.Add(this.LabelConsoles);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.LabelConsoleAddress);
            this.Controls.Add(this.darkToolStrip1);
            this.Controls.Add(this.ScrollBarMods);
            this.Controls.Add(this.SectionGames);
            this.Controls.Add(this.ScrollBarDetails);
            this.Controls.Add(this.LabelSelectCategory);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.ComboBoxConsole);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.SectionModsDetails);
            this.Controls.Add(this.SectionMods);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1050, 128);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX (beta) ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).EndInit();
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstallPaths)).EndInit();
            this.SectionModsDetails.ResumeLayout(false);
            this.SectionModsDetails.PerformLayout();
            this.SectionInstallPaths.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.SectionGames.ResumeLayout(false);
            this.SectionMods.ResumeLayout(false);
            this.darkToolStrip1.ResumeLayout(false);
            this.darkToolStrip1.PerformLayout();
            this.SectionCustomInstallation.ResumeLayout(false);
            this.SectionCustomInstallation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanelGames;
        private System.Windows.Forms.DataGridView DgvMods;
        private System.Windows.Forms.ComboBox ComboBoxConsole;
        private System.Windows.Forms.Label LabelSelectCategory;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.Label LabelByAuthor;
        private System.Windows.Forms.Label LabelHeaderVersion;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelHeaderConfiguration;
        private System.Windows.Forms.Label LabelConfiguration;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.DataGridView DgvInstallPaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModFilePath;
        private DarkUI.Controls.DarkButton ButtonConnectConsole;
        private DarkUI.Controls.DarkScrollBar ScrollBarDetails;
        private DarkUI.Controls.DarkSectionPanel SectionModsDetails;
        private DarkUI.Controls.DarkButton ButtonInstallFiles;
        private DarkUI.Controls.DarkButton ButtonUninstallFiles;
        private DarkUI.Controls.DarkButton ButtonDownloadFiles;
        private DarkUI.Controls.DarkButton ButtonReport;
        private DarkUI.Controls.DarkMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripContribute;
        private System.Windows.Forms.ToolStripMenuItem MenuStripInformation;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsAutoDetectRegion;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRefreshData;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileExit;
        private DarkUI.Controls.DarkSectionPanel SectionGames;
        private DarkUI.Controls.DarkScrollBar ScrollBarMods;
        private DarkUI.Controls.DarkSectionPanel SectionInstallPaths;
        private DarkUI.Controls.DarkSectionPanel SectionMods;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator;
        private DarkUI.Controls.DarkScrollBar ScrollBarInstallPaths;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsEditConsoles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DarkUI.Controls.DarkToolStrip darkToolStrip1;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private DarkUI.Controls.DarkTextBox TextBoxAddress;
        private DarkUI.Controls.DarkLabel LabelConsoleAddress;
        private DarkUI.Controls.DarkLabel LabelConsoles;
        private DarkUI.Controls.DarkTextBox TextBoxSelectedConsole;
        private DarkUI.Controls.DarkTextBox TextBoxSelectedCategory;
        private DarkUI.Controls.DarkSectionPanel SectionCustomInstallation;
        private DarkUI.Controls.DarkButton ButtonBrowseFile;
        private DarkUI.Controls.DarkTextBox TextBoxLocalFile;
        private DarkUI.Controls.DarkTextBox TextBoxInstallPath;
        private System.Windows.Forms.ComboBox ComboBoxInstallPath;
        private DarkUI.Controls.DarkLabel LabelInstallPath;
        private DarkUI.Controls.DarkButton ButtonInstallCustom;
        private DarkUI.Controls.DarkLabel LabelLocalFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private DarkUI.Controls.DarkToolStrip darkToolStrip2;
        private DarkUI.Controls.DarkButton ButtonRequestMods;
        private DarkUI.Controls.DarkScrollBar ScrollBarGames;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
    }
}