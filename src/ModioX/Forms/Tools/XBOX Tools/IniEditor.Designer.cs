
namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class INIEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INIEditor));
            this.GridLaunchFile = new DevExpress.XtraGrid.GridControl();
            this.GridViewLaunchFile = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TextBoxKey = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxValue = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxSections = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSetValue = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.MainMenu = new DevExpress.XtraBars.Bar();
            this.FileMenu = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.RestoreBackupFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.SettingsMenu = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.ToggleSwitchEnableLiveStrong = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.ToggleSwitchEnableLiveBlock = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.CheatEngineSettings = new DevExpress.XtraBars.BarButtonItem();
            this.Quit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridLaunchFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLaunchFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSections.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridLaunchFile
            // 
            this.GridLaunchFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridLaunchFile.Location = new System.Drawing.Point(0, 24);
            this.GridLaunchFile.MainView = this.GridViewLaunchFile;
            this.GridLaunchFile.Name = "GridLaunchFile";
            this.GridLaunchFile.Size = new System.Drawing.Size(412, 409);
            this.GridLaunchFile.TabIndex = 6;
            this.GridLaunchFile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewLaunchFile});
            // 
            // GridViewLaunchFile
            // 
            this.GridViewLaunchFile.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.GridViewLaunchFile.GridControl = this.GridLaunchFile;
            this.GridViewLaunchFile.Name = "GridViewLaunchFile";
            this.GridViewLaunchFile.OptionsView.ShowGroupPanel = false;
            this.GridViewLaunchFile.OptionsView.ShowIndicator = false;
            this.GridViewLaunchFile.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewIniFile_RowClick);
            this.GridViewLaunchFile.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewIniFile_FocusedRowChanged);
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.EditValue = "";
            this.TextBoxKey.Location = new System.Drawing.Point(77, 8);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxKey.Properties.Appearance.Options.UseFont = true;
            this.TextBoxKey.Size = new System.Drawing.Size(80, 22);
            this.TextBoxKey.TabIndex = 1;
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Location = new System.Drawing.Point(178, 8);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxValue.Properties.Appearance.Options.UseFont = true;
            this.TextBoxValue.Size = new System.Drawing.Size(145, 22);
            this.TextBoxValue.TabIndex = 2;
            // 
            // ComboBoxSections
            // 
            this.ComboBoxSections.EditValue = "Paths";
            this.ComboBoxSections.Location = new System.Drawing.Point(3, 8);
            this.ComboBoxSections.Name = "ComboBoxSections";
            this.ComboBoxSections.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSections.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSections.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSections.Properties.Items.AddRange(new object[] {
            "Paths",
            "Plugins",
            "Externals",
            "Settings"});
            this.ComboBoxSections.Size = new System.Drawing.Size(68, 22);
            this.ComboBoxSections.TabIndex = 0;
            this.ComboBoxSections.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSections_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(163, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "=";
            // 
            // ButtonSetValue
            // 
            this.ButtonSetValue.Location = new System.Drawing.Point(329, 8);
            this.ButtonSetValue.Name = "ButtonSetValue";
            this.ButtonSetValue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetValue.Size = new System.Drawing.Size(78, 23);
            this.ButtonSetValue.TabIndex = 3;
            this.ButtonSetValue.Text = "Set Value";
            this.ButtonSetValue.Click += new System.EventHandler(this.ButtonSetValue_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.CheatEngineSettings,
            this.Quit,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barSubItem5,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.SettingsMenu,
            this.FileMenu,
            this.barButtonItem13,
            this.RestoreBackupFile,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barButtonItem17,
            this.barSubItem1,
            this.ToggleSwitchEnableLiveBlock,
            this.ToggleSwitchEnableLiveStrong,
            this.barSubItem2,
            this.barButtonItem14,
            this.barButtonItem18,
            this.barButtonItem19,
            this.barButtonItem20,
            this.barSubItem3,
            this.barButtonItem21});
            this.barManager1.MainMenu = this.MainMenu;
            this.barManager1.MaxItemId = 51;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            // 
            // MainMenu
            // 
            this.MainMenu.BarName = "Main menu";
            this.MainMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MainMenu.DockCol = 0;
            this.MainMenu.DockRow = 0;
            this.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.FileMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.SettingsMenu)});
            this.MainMenu.OptionsBar.DrawBorder = false;
            this.MainMenu.OptionsBar.DrawDragBorder = false;
            this.MainMenu.OptionsBar.MultiLine = true;
            this.MainMenu.OptionsBar.UseWholeRow = true;
            this.MainMenu.Text = "Main menu";
            // 
            // FileMenu
            // 
            this.FileMenu.Caption = "File";
            this.FileMenu.Id = 26;
            this.FileMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.RestoreBackupFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem16)});
            this.FileMenu.Name = "FileMenu";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Show Backup Folder";
            this.barButtonItem13.Id = 27;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // RestoreBackupFile
            // 
            this.RestoreBackupFile.Caption = "Restore Backup File";
            this.RestoreBackupFile.Id = 28;
            this.RestoreBackupFile.Name = "RestoreBackupFile";
            this.RestoreBackupFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonRestoreLaunchFile_Click);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Load Local INI FIle";
            this.barButtonItem15.Id = 29;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Save Backup";
            this.barButtonItem17.Id = 31;
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Save File";
            this.barButtonItem16.Id = 30;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.Caption = "Options";
            this.SettingsMenu.Id = 23;
            this.SettingsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ToggleSwitchEnableLiveStrong),
            new DevExpress.XtraBars.LinkPersistInfo(this.ToggleSwitchEnableLiveBlock),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.SettingsMenu.Name = "SettingsMenu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Change Drive Location";
            this.barSubItem1.Id = 35;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem21)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // ToggleSwitchEnableLiveStrong
            // 
            this.ToggleSwitchEnableLiveStrong.Caption = "Enable Live Strong";
            this.ToggleSwitchEnableLiveStrong.Id = 38;
            this.ToggleSwitchEnableLiveStrong.Name = "ToggleSwitchEnableLiveStrong";
            // 
            // ToggleSwitchEnableLiveBlock
            // 
            this.ToggleSwitchEnableLiveBlock.Caption = "Enable Live Block";
            this.ToggleSwitchEnableLiveBlock.Id = 37;
            this.ToggleSwitchEnableLiveBlock.Name = "ToggleSwitchEnableLiveBlock";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(412, 23);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 472);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(412, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 23);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 449);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(412, 23);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 449);
            // 
            // CheatEngineSettings
            // 
            this.CheatEngineSettings.Caption = "Settings";
            this.CheatEngineSettings.Id = 6;
            this.CheatEngineSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CheatEngineSettings.ImageOptions.Image")));
            this.CheatEngineSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CheatEngineSettings.ImageOptions.LargeImage")));
            this.CheatEngineSettings.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.CheatEngineSettings.Name = "CheatEngineSettings";
            // 
            // Quit
            // 
            this.Quit.Caption = "Quit";
            this.Quit.Id = 7;
            this.Quit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Quit.ImageOptions.Image")));
            this.Quit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Quit.ImageOptions.LargeImage")));
            this.Quit.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.Quit.Name = "Quit";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Make A Cheat Table";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Load File";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Save FIle";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.Caption = "IDA";
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Add Scan Tab";
            this.barButtonItem5.Id = 13;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Clear List";
            this.barButtonItem6.Id = 14;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Save State";
            this.barButtonItem7.Id = 15;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Load State";
            this.barButtonItem8.Id = 16;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Loa";
            this.barButtonItem9.Id = 17;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Load Recent";
            this.barSubItem5.Id = 18;
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Produce C# File...";
            this.barButtonItem10.Id = 19;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Tutorial";
            this.barButtonItem11.Id = 20;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Prase File";
            this.barButtonItem12.Id = 22;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ComboBoxSections);
            this.PanelButtons.Controls.Add(this.TextBoxKey);
            this.PanelButtons.Controls.Add(this.labelControl1);
            this.PanelButtons.Controls.Add(this.TextBoxValue);
            this.PanelButtons.Controls.Add(this.ButtonSetValue);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 433);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(412, 39);
            this.PanelButtons.TabIndex = 1181;
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Change INI Sector";
            this.barSubItem2.Id = 41;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem20)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Paths";
            this.barButtonItem14.Id = 44;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Plugins";
            this.barButtonItem18.Id = 45;
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Caption = "Externals";
            this.barButtonItem19.Id = 46;
            this.barButtonItem19.Name = "barButtonItem19";
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Caption = "Settings";
            this.barButtonItem20.Id = 47;
            this.barButtonItem20.Name = "barButtonItem20";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Edit";
            this.barSubItem3.Id = 49;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Caption = "Loads Drives here as buttons";
            this.barButtonItem21.Id = 50;
            this.barButtonItem21.Name = "barButtonItem21";
            // 
            // INIEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 472);
            this.Controls.Add(this.GridLaunchFile);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "INIEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INI File Editor";
            this.Load += new System.EventHandler(this.PluginsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLaunchFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLaunchFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSections.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GridLaunchFile;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewLaunchFile;
        private DevExpress.XtraEditors.TextEdit TextBoxKey;
        private DevExpress.XtraEditors.TextEdit TextBoxValue;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxSections;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonSetValue;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar MainMenu;
        private DevExpress.XtraBars.BarSubItem FileMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem RestoreBackupFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarSubItem SettingsMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem CheatEngineSettings;
        private DevExpress.XtraBars.BarButtonItem Quit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarToggleSwitchItem ToggleSwitchEnableLiveBlock;
        private DevExpress.XtraBars.BarToggleSwitchItem ToggleSwitchEnableLiveStrong;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem21;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraBars.BarButtonItem barButtonItem20;
    }
}