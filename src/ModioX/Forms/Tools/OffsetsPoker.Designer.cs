using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ModioX.Forms.Tools
{
    partial class OffsetsPoker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffsetsPoker));
            this.GroupGameMods = new DevExpress.XtraEditors.GroupControl();
            this.ComboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxGameMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxGameTitles = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ProgressNoModsFound = new DevExpress.XtraWaitForm.ProgressPanel();
            this.GridModsOffsets = new DevExpress.XtraGrid.GridControl();
            this.GridViewModsOffsets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonSetValue = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEnable = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDisable = new DevExpress.XtraEditors.SimpleButton();
            this.ColumnPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.TimerWait = new System.Windows.Forms.Timer(this.components);
            this.BarManagerStatus = new DevExpress.XtraBars.BarManager(this.components);
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.HeaderConsoleConnected = new DevExpress.XtraBars.BarHeaderItem();
            this.LabelConsoleName = new DevExpress.XtraBars.BarStaticItem();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.MainMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMenu = new DevExpress.XtraBars.Bar();
            this.MenuItemConnect = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemConnectPS3 = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemConnectToPS3 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemDisconnectPS3 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemConnectXBOX = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemConnectToXBOX = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemDisconnectXBOX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.XNotifyText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.XNotifyType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameMods)).BeginInit();
            this.GroupGameMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridModsOffsets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModsOffsets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupGameMods
            // 
            this.GroupGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupGameMods.Controls.Add(this.ComboBoxCategory);
            this.GroupGameMods.Controls.Add(this.ComboBoxGameMode);
            this.GroupGameMods.Controls.Add(this.ComboBoxGameTitles);
            this.GroupGameMods.Controls.Add(this.ProgressNoModsFound);
            this.GroupGameMods.Controls.Add(this.GridModsOffsets);
            this.GroupGameMods.Controls.Add(this.PanelButtons);
            this.GroupGameMods.Location = new System.Drawing.Point(11, 39);
            this.GroupGameMods.Name = "GroupGameMods";
            this.GroupGameMods.Size = new System.Drawing.Size(564, 260);
            this.GroupGameMods.TabIndex = 0;
            this.GroupGameMods.Text = "Game Mods (PS3)";
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCategory.EditValue = "";
            this.ComboBoxCategory.Location = new System.Drawing.Point(447, 33);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Properties.AllowFocused = false;
            this.ComboBoxCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxCategory.Properties.AutoComplete = false;
            this.ComboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxCategory.Properties.Items.AddRange(new object[] {
            "ALL",
            "Singleplayer",
            "Multiplayer",
            "Zombies"});
            this.ComboBoxCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxCategory.Size = new System.Drawing.Size(106, 22);
            this.ComboBoxCategory.TabIndex = 1185;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // ComboBoxGameMode
            // 
            this.ComboBoxGameMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameMode.EditValue = "";
            this.ComboBoxGameMode.Location = new System.Drawing.Point(335, 33);
            this.ComboBoxGameMode.Name = "ComboBoxGameMode";
            this.ComboBoxGameMode.Properties.AllowFocused = false;
            this.ComboBoxGameMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameMode.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameMode.Properties.AutoComplete = false;
            this.ComboBoxGameMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameMode.Properties.Items.AddRange(new object[] {
            "ALL",
            "Singleplayer",
            "Multiplayer",
            "Zombies"});
            this.ComboBoxGameMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameMode.Size = new System.Drawing.Size(106, 22);
            this.ComboBoxGameMode.TabIndex = 1184;
            this.ComboBoxGameMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameMode_SelectedIndexChanged);
            // 
            // ComboBoxGameTitles
            // 
            this.ComboBoxGameTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameTitles.EditValue = "";
            this.ComboBoxGameTitles.Location = new System.Drawing.Point(10, 33);
            this.ComboBoxGameTitles.Name = "ComboBoxGameTitles";
            this.ComboBoxGameTitles.Properties.AllowFocused = false;
            this.ComboBoxGameTitles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameTitles.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameTitles.Properties.AutoComplete = false;
            this.ComboBoxGameTitles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameTitles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameTitles.Size = new System.Drawing.Size(319, 22);
            this.ComboBoxGameTitles.TabIndex = 1;
            this.ComboBoxGameTitles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameTitles_SelectedIndexChanged);
            // 
            // ProgressNoModsFound
            // 
            this.ProgressNoModsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressNoModsFound.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressNoModsFound.Appearance.Options.UseBackColor = true;
            this.ProgressNoModsFound.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressNoModsFound.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressNoModsFound.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressNoModsFound.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressNoModsFound.Caption = "NO MODS FOUND";
            this.ProgressNoModsFound.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressNoModsFound.Description = "";
            this.ProgressNoModsFound.Location = new System.Drawing.Point(159, 92);
            this.ProgressNoModsFound.Name = "ProgressNoModsFound";
            this.ProgressNoModsFound.Size = new System.Drawing.Size(246, 66);
            this.ProgressNoModsFound.TabIndex = 0;
            this.ProgressNoModsFound.TabStop = false;
            this.ProgressNoModsFound.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridModsOffsets
            // 
            this.GridModsOffsets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridModsOffsets.Location = new System.Drawing.Point(10, 61);
            this.GridModsOffsets.MainView = this.GridViewModsOffsets;
            this.GridModsOffsets.Name = "GridModsOffsets";
            this.GridModsOffsets.Size = new System.Drawing.Size(543, 158);
            this.GridModsOffsets.TabIndex = 0;
            this.GridModsOffsets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewModsOffsets});
            // 
            // GridViewModsOffsets
            // 
            this.GridViewModsOffsets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewModsOffsets.GridControl = this.GridModsOffsets;
            this.GridViewModsOffsets.Name = "GridViewModsOffsets";
            this.GridViewModsOffsets.OptionsBehavior.Editable = false;
            this.GridViewModsOffsets.OptionsBehavior.ReadOnly = true;
            this.GridViewModsOffsets.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewModsOffsets.OptionsView.ShowGroupPanel = false;
            this.GridViewModsOffsets.OptionsView.ShowIndicator = false;
            this.GridViewModsOffsets.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewPackageFiles_RowClick);
            this.GridViewModsOffsets.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewPackageFiles_FocusedRowChanged);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonSetValue);
            this.PanelButtons.Controls.Add(this.ButtonEnable);
            this.PanelButtons.Controls.Add(this.ButtonDisable);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 219);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(560, 39);
            this.PanelButtons.TabIndex = 1180;
            // 
            // ButtonSetValue
            // 
            this.ButtonSetValue.Location = new System.Drawing.Point(8, 8);
            this.ButtonSetValue.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonSetValue.Name = "ButtonSetValue";
            this.ButtonSetValue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetValue.Size = new System.Drawing.Size(80, 23);
            this.ButtonSetValue.TabIndex = 1;
            this.ButtonSetValue.Text = "Set Value";
            this.ButtonSetValue.Click += new System.EventHandler(this.ButtonSetValue_Click);
            // 
            // ButtonEnable
            // 
            this.ButtonEnable.Location = new System.Drawing.Point(99, 8);
            this.ButtonEnable.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonEnable.Name = "ButtonEnable";
            this.ButtonEnable.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEnable.Size = new System.Drawing.Size(71, 23);
            this.ButtonEnable.TabIndex = 2;
            this.ButtonEnable.Text = "Enable";
            this.ButtonEnable.Visible = false;
            this.ButtonEnable.Click += new System.EventHandler(this.ButtonEnable_Click);
            // 
            // ButtonDisable
            // 
            this.ButtonDisable.Location = new System.Drawing.Point(176, 8);
            this.ButtonDisable.Name = "ButtonDisable";
            this.ButtonDisable.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDisable.Size = new System.Drawing.Size(71, 23);
            this.ButtonDisable.TabIndex = 3;
            this.ButtonDisable.Text = "Disable";
            this.ButtonDisable.Visible = false;
            this.ButtonDisable.Click += new System.EventHandler(this.ButtonDisable_Click);
            // 
            // ColumnPackageName
            // 
            this.ColumnPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPackageName.HeaderText = "Package File Name";
            this.ColumnPackageName.Name = "ColumnPackageName";
            this.ColumnPackageName.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // TimerWait
            // 
            this.TimerWait.Enabled = true;
            this.TimerWait.Tick += new System.EventHandler(this.TimerWait_Tick);
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
            this.LabelStatus,
            this.HeaderConsoleConnected,
            this.LabelConsoleName});
            this.BarManagerStatus.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.HeaderConsoleConnected),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelConsoleName),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // HeaderConsoleConnected
            // 
            this.HeaderConsoleConnected.Caption = "Connected Console:";
            this.HeaderConsoleConnected.Id = 4;
            this.HeaderConsoleConnected.Name = "HeaderConsoleConnected";
            // 
            // LabelConsoleName
            // 
            this.LabelConsoleName.Caption = "Idle";
            this.LabelConsoleName.Id = 5;
            this.LabelConsoleName.Name = "LabelConsoleName";
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
            this.barDockControlTop.Location = new System.Drawing.Point(0, 25);
            this.barDockControlTop.Manager = this.BarManagerStatus;
            this.barDockControlTop.Size = new System.Drawing.Size(586, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 313);
            this.barDockControlBottom.Manager = this.BarManagerStatus;
            this.barDockControlBottom.Size = new System.Drawing.Size(586, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.BarManagerStatus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 288);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(586, 25);
            this.barDockControlRight.Manager = this.BarManagerStatus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 288);
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
            // MainMenu
            // 
            this.MainMenu.AllowCustomization = false;
            this.MainMenu.AllowQuickCustomization = false;
            this.MainMenu.AllowShowToolbarsPopup = false;
            this.MainMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMenu});
            this.MainMenu.DockControls.Add(this.barDockControl1);
            this.MainMenu.DockControls.Add(this.barDockControl2);
            this.MainMenu.DockControls.Add(this.barDockControl3);
            this.MainMenu.DockControls.Add(this.barDockControl4);
            this.MainMenu.Form = this;
            this.MainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuItemConnectToPS3,
            this.MenuItemConnect,
            this.MenuItemDisconnectPS3,
            this.MenuItemConnectPS3,
            this.MenuItemConnectXBOX,
            this.MenuItemConnectToXBOX,
            this.MenuItemDisconnectXBOX});
            this.MainMenu.MainMenu = this.BarMenu;
            this.MainMenu.MaxItemId = 133;
            this.MainMenu.OptionsLayout.AllowAddNewItems = false;
            this.MainMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.XNotifyText,
            this.XNotifyType,
            this.repositoryItemRadioGroup1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnect)});
            this.BarMenu.OptionsBar.AllowQuickCustomization = false;
            this.BarMenu.OptionsBar.DisableCustomization = true;
            this.BarMenu.OptionsBar.DrawBorder = false;
            this.BarMenu.OptionsBar.MultiLine = true;
            this.BarMenu.OptionsBar.UseWholeRow = true;
            this.BarMenu.Text = "Main menu";
            // 
            // MenuItemConnect
            // 
            this.MenuItemConnect.ActAsDropDown = true;
            this.MenuItemConnect.AllowDrawArrow = false;
            this.MenuItemConnect.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuItemConnect.Caption = "CONNECT";
            this.MenuItemConnect.DropDownControl = this.ConnectMenu;
            this.MenuItemConnect.Id = 125;
            this.MenuItemConnect.Name = "MenuItemConnect";
            // 
            // ConnectMenu
            // 
            this.ConnectMenu.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.ConnectMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnectPS3),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnectXBOX)});
            this.ConnectMenu.Manager = this.MainMenu;
            this.ConnectMenu.Name = "ConnectMenu";
            // 
            // MenuItemConnectPS3
            // 
            this.MenuItemConnectPS3.Caption = "PS3";
            this.MenuItemConnectPS3.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemConnectPS3.Id = 128;
            this.MenuItemConnectPS3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnectToPS3),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemDisconnectPS3)});
            this.MenuItemConnectPS3.Name = "MenuItemConnectPS3";
            // 
            // MenuItemConnectToPS3
            // 
            this.MenuItemConnectToPS3.Caption = "Connect to console...";
            this.MenuItemConnectToPS3.Id = 124;
            this.MenuItemConnectToPS3.Name = "MenuItemConnectToPS3";
            this.MenuItemConnectToPS3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonConnectToPS3_ItemClick);
            // 
            // MenuItemDisconnectPS3
            // 
            this.MenuItemDisconnectPS3.Caption = "Disconnect from console...";
            this.MenuItemDisconnectPS3.Id = 126;
            this.MenuItemDisconnectPS3.Name = "MenuItemDisconnectPS3";
            this.MenuItemDisconnectPS3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.MenuItemDisconnectPS3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemDisconnectPS3_ItemClick);
            // 
            // MenuItemConnectXBOX
            // 
            this.MenuItemConnectXBOX.Caption = "XBOX";
            this.MenuItemConnectXBOX.Id = 130;
            this.MenuItemConnectXBOX.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnectToXBOX),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemDisconnectXBOX)});
            this.MenuItemConnectXBOX.Name = "MenuItemConnectXBOX";
            // 
            // MenuItemConnectToXBOX
            // 
            this.MenuItemConnectToXBOX.Caption = "Connect to console...";
            this.MenuItemConnectToXBOX.Id = 131;
            this.MenuItemConnectToXBOX.Name = "MenuItemConnectToXBOX";
            this.MenuItemConnectToXBOX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemConnectToXBOX_ItemClick);
            // 
            // MenuItemDisconnectXBOX
            // 
            this.MenuItemDisconnectXBOX.Caption = "Disconnect from console...";
            this.MenuItemDisconnectXBOX.Id = 132;
            this.MenuItemDisconnectXBOX.Name = "MenuItemDisconnectXBOX";
            this.MenuItemDisconnectXBOX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemDisconnectXBOX_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.MainMenu;
            this.barDockControl1.Size = new System.Drawing.Size(586, 25);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 338);
            this.barDockControl2.Manager = this.MainMenu;
            this.barDockControl2.Size = new System.Drawing.Size(586, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 25);
            this.barDockControl3.Manager = this.MainMenu;
            this.barDockControl3.Size = new System.Drawing.Size(0, 313);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(586, 25);
            this.barDockControl4.Manager = this.MainMenu;
            this.barDockControl4.Size = new System.Drawing.Size(0, 313);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "mnjukjui", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Columns = 1;
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem4.Caption = "Status:";
            this.barStaticItem4.Id = 0;
            this.barStaticItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem4.LeftIndent = 4;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem5.Caption = "Status";
            this.barStaticItem5.Id = 3;
            this.barStaticItem5.Name = "barStaticItem5";
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem6.Caption = "Status";
            this.barStaticItem6.Id = 3;
            this.barStaticItem6.Name = "barStaticItem6";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 3";
            // 
            // OffsetsPoker
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(586, 338);
            this.Controls.Add(this.GroupGameMods);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("OffsetsPoker.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OffsetsPoker";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Real Time Modding";
            this.Load += new System.EventHandler(this.OffsetsPoker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameMods)).EndInit();
            this.GroupGameMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameTitles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridModsOffsets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModsOffsets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManagerStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupControl GroupGameMods;
        private Timer TimerWait;
        private DataGridViewTextBoxColumn ColumnPackageName;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewImageColumn ColumnDownload;
        private StackPanel PanelButtons;
        private ProgressPanel ProgressNoModsFound;
        private GridControl GridModsOffsets;
        private GridView GridViewModsOffsets;
        private SimpleButton ButtonSetValue;
        private BarManager BarManagerStatus;
        private Bar BarStatus;
        private BarStaticItem LabelHeaderStatus;
        private BarStaticItem LabelStatus;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarHeaderItem barHeaderItem1;
        private BarStaticItem barStaticItem2;
        private ComboBoxEdit ComboBoxGameTitles;
        private ComboBoxEdit ComboBoxGameMode;
        private BarDockControl barDockControl3;
        private BarManager MainMenu;
        private Bar BarMenu;
        private PopupMenu ConnectMenu;
        private BarButtonItem MenuItemConnectToPS3;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit XNotifyText;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox XNotifyType;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private BarStaticItem barStaticItem4;
        private BarStaticItem barStaticItem5;
        private BarStaticItem barStaticItem6;
        private BarButtonItem MenuItemConnect;
        private Bar bar1;
        private BarHeaderItem HeaderConsoleConnected;
        private BarStaticItem LabelConsoleName;
        private BarButtonItem MenuItemDisconnectPS3;
        private BarSubItem MenuItemConnectPS3;
        private BarSubItem MenuItemConnectXBOX;
        private BarButtonItem MenuItemConnectToXBOX;
        private BarButtonItem MenuItemDisconnectXBOX;
        private ComboBoxEdit ComboBoxCategory;
        private SimpleButton ButtonEnable;
        private SimpleButton ButtonDisable;
    }
}