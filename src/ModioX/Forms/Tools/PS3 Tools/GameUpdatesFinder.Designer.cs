namespace ModioX.Forms.Tools.PS3_Tools
{
    partial class GameUpdatesFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUpdatesFinder));
            this.SectionPanelInformation = new DevExpress.XtraEditors.GroupControl();
            this.ProgressNoGameUpdatesFound = new DevExpress.XtraWaitForm.ProgressPanel();
            this.GridGameUpdates = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameUpdates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstallToConsole = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownloadFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCopyURLToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCopySHA1ToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxTitleID = new DevExpress.XtraEditors.TextEdit();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.LabelSelectType = new DevExpress.XtraEditors.LabelControl();
            this.ContextMenuDownloadToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuInstallToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuCopyURLToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLabelHeaderStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ColumnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarManagerStatus = new DevExpress.XtraBars.BarManager(this.components);
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ComboBoxType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionPanelInformation)).BeginInit();
            this.SectionPanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionPanelInformation
            // 
            this.SectionPanelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanelInformation.Controls.Add(this.ComboBoxType);
            this.SectionPanelInformation.Controls.Add(this.ButtonSearch);
            this.SectionPanelInformation.Controls.Add(this.ProgressNoGameUpdatesFound);
            this.SectionPanelInformation.Controls.Add(this.TextBoxTitleID);
            this.SectionPanelInformation.Controls.Add(this.GridGameUpdates);
            this.SectionPanelInformation.Controls.Add(this.LabelSearch);
            this.SectionPanelInformation.Controls.Add(this.LabelSelectType);
            this.SectionPanelInformation.Controls.Add(this.stackPanel2);
            this.SectionPanelInformation.Location = new System.Drawing.Point(11, 11);
            this.SectionPanelInformation.Name = "SectionPanelInformation";
            this.SectionPanelInformation.Size = new System.Drawing.Size(574, 368);
            this.SectionPanelInformation.TabIndex = 0;
            this.SectionPanelInformation.Text = "SEARCH FOR GAME UPDATES";
            // 
            // ProgressNoGameUpdatesFound
            // 
            this.ProgressNoGameUpdatesFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressNoGameUpdatesFound.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressNoGameUpdatesFound.Appearance.Options.UseBackColor = true;
            this.ProgressNoGameUpdatesFound.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressNoGameUpdatesFound.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressNoGameUpdatesFound.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressNoGameUpdatesFound.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressNoGameUpdatesFound.Caption = "NO GAME UPDATES FOUND";
            this.ProgressNoGameUpdatesFound.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressNoGameUpdatesFound.Description = "";
            this.ProgressNoGameUpdatesFound.Location = new System.Drawing.Point(164, 120);
            this.ProgressNoGameUpdatesFound.Name = "ProgressNoGameUpdatesFound";
            this.ProgressNoGameUpdatesFound.Size = new System.Drawing.Size(246, 66);
            this.ProgressNoGameUpdatesFound.TabIndex = 1184;
            this.ProgressNoGameUpdatesFound.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridGameUpdates
            // 
            this.GridGameUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGameUpdates.Location = new System.Drawing.Point(2, 61);
            this.GridGameUpdates.MainView = this.GridViewGameUpdates;
            this.GridGameUpdates.Name = "GridGameUpdates";
            this.GridGameUpdates.Size = new System.Drawing.Size(570, 266);
            this.GridGameUpdates.TabIndex = 1183;
            this.GridGameUpdates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameUpdates});
            // 
            // GridViewGameUpdates
            // 
            this.GridViewGameUpdates.GridControl = this.GridGameUpdates;
            this.GridViewGameUpdates.Name = "GridViewGameUpdates";
            this.GridViewGameUpdates.OptionsView.ShowGroupPanel = false;
            this.GridViewGameUpdates.OptionsView.ShowIndicator = false;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.ButtonInstallToConsole);
            this.stackPanel2.Controls.Add(this.ButtonDownloadFile);
            this.stackPanel2.Controls.Add(this.ButtonCopyURLToClipboard);
            this.stackPanel2.Controls.Add(this.ButtonCopySHA1ToClipboard);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(2, 327);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(570, 39);
            this.stackPanel2.TabIndex = 1181;
            // 
            // ButtonInstallToConsole
            // 
            this.ButtonInstallToConsole.Location = new System.Drawing.Point(8, 8);
            this.ButtonInstallToConsole.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonInstallToConsole.Name = "ButtonInstallToConsole";
            this.ButtonInstallToConsole.Size = new System.Drawing.Size(121, 23);
            this.ButtonInstallToConsole.TabIndex = 6;
            this.ButtonInstallToConsole.Text = "Install to Console";
            this.ButtonInstallToConsole.Click += new System.EventHandler(this.ButtonInstallToConsole_Click);
            // 
            // ButtonDownloadFile
            // 
            this.ButtonDownloadFile.Location = new System.Drawing.Point(135, 8);
            this.ButtonDownloadFile.Name = "ButtonDownloadFile";
            this.ButtonDownloadFile.Size = new System.Drawing.Size(108, 23);
            this.ButtonDownloadFile.TabIndex = 7;
            this.ButtonDownloadFile.Text = "Download File";
            this.ButtonDownloadFile.Click += new System.EventHandler(this.ButtonDownloadFile_Click);
            // 
            // ButtonCopyURLToClipboard
            // 
            this.ButtonCopyURLToClipboard.Location = new System.Drawing.Point(249, 8);
            this.ButtonCopyURLToClipboard.Name = "ButtonCopyURLToClipboard";
            this.ButtonCopyURLToClipboard.Size = new System.Drawing.Size(149, 23);
            this.ButtonCopyURLToClipboard.TabIndex = 8;
            this.ButtonCopyURLToClipboard.Text = "Copy URL to Clipboard";
            this.ButtonCopyURLToClipboard.Click += new System.EventHandler(this.ButtonCopyURLToClipboard_Click);
            // 
            // ButtonCopySHA1ToClipboard
            // 
            this.ButtonCopySHA1ToClipboard.Location = new System.Drawing.Point(404, 8);
            this.ButtonCopySHA1ToClipboard.Name = "ButtonCopySHA1ToClipboard";
            this.ButtonCopySHA1ToClipboard.Size = new System.Drawing.Size(157, 23);
            this.ButtonCopySHA1ToClipboard.TabIndex = 9;
            this.ButtonCopySHA1ToClipboard.Text = "Copy SHA1 to Clipboard";
            this.ButtonCopySHA1ToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1ToClipboard_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.Appearance.Options.UseFont = true;
            this.ButtonSearch.Location = new System.Drawing.Point(352, 31);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(67, 22);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxTitleID
            // 
            this.TextBoxTitleID.EditValue = "e.g. BLES01807";
            this.TextBoxTitleID.Location = new System.Drawing.Point(57, 31);
            this.TextBoxTitleID.Name = "TextBoxTitleID";
            this.TextBoxTitleID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTitleID.Properties.Appearance.Options.UseFont = true;
            this.TextBoxTitleID.Size = new System.Drawing.Size(100, 22);
            this.TextBoxTitleID.TabIndex = 0;
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Appearance.Options.UseForeColor = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(10, 34);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(41, 15);
            this.LabelSearch.TabIndex = 1161;
            this.LabelSearch.Text = "TITLE ID";
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectType.Appearance.Options.UseFont = true;
            this.LabelSelectType.Appearance.Options.UseForeColor = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(167, 34);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(4, 3, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(72, 15);
            this.LabelSelectType.TabIndex = 1160;
            this.LabelSelectType.Text = "UPDATE TYPE";
            // 
            // ContextMenuDownloadToComputer
            // 
            this.ContextMenuDownloadToComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuDownloadToComputer.Enabled = false;
            this.ContextMenuDownloadToComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuDownloadToComputer.Image = global::ModioX.Properties.Resources.download_from_the_cloud;
            this.ContextMenuDownloadToComputer.Name = "ContextMenuDownloadToComputer";
            this.ContextMenuDownloadToComputer.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuDownloadToComputer.Text = "Download to Computer...";
            // 
            // ContextMenuInstallToConsole
            // 
            this.ContextMenuInstallToConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuInstallToConsole.Enabled = false;
            this.ContextMenuInstallToConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuInstallToConsole.Image = global::ModioX.Properties.Resources.install;
            this.ContextMenuInstallToConsole.Name = "ContextMenuInstallToConsole";
            this.ContextMenuInstallToConsole.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuInstallToConsole.Text = "Install to Console...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // ContextMenuCopyURLToClipboard
            // 
            this.ContextMenuCopyURLToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuCopyURLToClipboard.Enabled = false;
            this.ContextMenuCopyURLToClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuCopyURLToClipboard.Image = global::ModioX.Properties.Resources.copy_to_clipboard;
            this.ContextMenuCopyURLToClipboard.Name = "ContextMenuCopyURLToClipboard";
            this.ContextMenuCopyURLToClipboard.Size = new System.Drawing.Size(210, 24);
            this.ContextMenuCopyURLToClipboard.Text = "Copy URL to Clipboard";
            // 
            // ToolStripLabelHeaderStatus
            // 
            this.ToolStripLabelHeaderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelHeaderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelHeaderStatus.Name = "ToolStripLabelHeaderStatus";
            this.ToolStripLabelHeaderStatus.Size = new System.Drawing.Size(48, 20);
            this.ToolStripLabelHeaderStatus.Text = "Status  :";
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(26, 20);
            this.ToolStripLabelStatus.Text = "Idle";
            // 
            // ColumnVersion
            // 
            this.ColumnVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnVersion.HeaderText = "Version";
            this.ColumnVersion.Name = "ColumnVersion";
            this.ColumnVersion.ReadOnly = true;
            // 
            // BarManagerStatus
            // 
            this.BarManagerStatus.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarStatus});
            this.BarManagerStatus.DockControls.Add(this.barDockControlTop);
            this.BarManagerStatus.DockControls.Add(this.barDockControlBottom);
            this.BarManagerStatus.DockControls.Add(this.barDockControlLeft);
            this.BarManagerStatus.DockControls.Add(this.barDockControlRight);
            this.BarManagerStatus.Form = this;
            this.BarManagerStatus.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelHeaderStatus,
            this.barHeaderItem1,
            this.barStaticItem2,
            this.LabelStatus});
            this.BarManagerStatus.MaxItemId = 4;
            this.BarManagerStatus.StatusBar = this.BarStatus;
            // 
            // BarStatus
            // 
            this.BarStatus.BarItemVertIndent = 5;
            this.BarStatus.BarName = "Status bar";
            this.BarStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BarStatus.DockCol = 0;
            this.BarStatus.DockRow = 0;
            this.BarStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BarStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 0;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 4;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Status";
            this.LabelStatus.Id = 3;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManagerStatus;
            this.barDockControlTop.Size = new System.Drawing.Size(596, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 393);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(596, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 393);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(596, 0);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 393);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem2.Caption = "Status";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Location = new System.Drawing.Point(245, 32);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxType.Properties.Items.AddRange(new object[] {
            "Retail",
            "Debug"});
            this.ComboBoxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxType.Size = new System.Drawing.Size(100, 20);
            this.ComboBoxType.TabIndex = 1185;
            // 
            // GameUpdatesFinder
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.SectionPanelInformation);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameUpdatesFinder.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameUpdatesFinder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Update Finder";
            this.Load += new System.EventHandler(this.GameUpdatesFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionPanelInformation)).EndInit();
            this.SectionPanelInformation.ResumeLayout(false);
            this.SectionPanelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl SectionPanelInformation;
        private DevExpress.XtraEditors.TextEdit TextBoxTitleID;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraEditors.LabelControl LabelSelectType;
        private DevExpress.XtraEditors.SimpleButton ButtonSearch;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDownloadToComputer;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuInstallToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopyURLToClipboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersion;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton ButtonInstallToConsole;
        private DevExpress.XtraEditors.SimpleButton ButtonDownloadFile;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressNoGameUpdatesFound;
        private DevExpress.XtraGrid.GridControl GridGameUpdates;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewGameUpdates;
        private DevExpress.XtraEditors.SimpleButton ButtonCopyURLToClipboard;
        private DevExpress.XtraEditors.SimpleButton ButtonCopySHA1ToClipboard;
        private DevExpress.XtraBars.BarManager BarManagerStatus;
        private DevExpress.XtraBars.Bar BarStatus;
        private DevExpress.XtraBars.BarStaticItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxType;
    }
}